using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using BLL;
using Common;
using Aspose.Cells;
using System.Text.RegularExpressions;

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_HJXH : Form
    {
        public FrmPB_HJXH()
        {
            InitializeComponent();
        }

        private static Bll_TQB_ALLOY_CONSUMPTION bll_hjxh = new Bll_TQB_ALLOY_CONSUMPTION();

        /// <summary>
        /// 将Excel转换成datatable
        /// </summary>
        /// <param name="strFileName">路径</param>
        /// <returns></returns>
        public static System.Data.DataTable ReadExcel(String strFileName)
        {
            Workbook book = new Workbook(strFileName);
            //book.Open(strFileName);
            int count = book.Worksheets.Count;
            Worksheet sheet = book.Worksheets[0];
            Cells cells = sheet.Cells;
            return cells.ExportDataTableAsString(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, true);
        }


        public string strMenuName = "";
        private void FrmPB_HJXH_Load(object sender, EventArgs e)
        {
            // UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strMenuName = RV.UI.UserInfo.menuName;
        }

        private void txtUrl_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = false;
                fileDialog.Title = "请选择文件";
                fileDialog.Filter = "所有Excel文件|*.XLSX;*.XLS;*.xlsx;*.xls";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = fileDialog.FileName;
                    txtUrl.Text = file;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtUrl.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请选择需要导入的文件！");
                    return;
                }
                Workbook book = new Workbook(this.txtUrl.Text);
                int count = book.Worksheets.Count;
                for (int c = 0; c < count; c++)
                {
                    Worksheet sheet = book.Worksheets[c];
                    Cells cells = sheet.Cells;
                    string cellname = sheet.Name;
                    if (cellname == "操作说明")
                    {
                        continue;
                    }
                    DataTable dt = cells.ExportDataTableAsString(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, true);
                    if (dt.Rows.Count > 0)
                    {

                        int colnum = dt.Columns.Count;
                        for (int i = 1; i < dt.Rows.Count; i++)
                        {

                            string strGUID = System.Guid.NewGuid().ToString();
                            string c_stl_grd = dt.Rows[i][0].ToString();//钢种
                            string c_std_code = dt.Rows[i][1].ToString();//执行标准
                            for (int j = 2; j < colnum; j++)
                            {
                                string c_aolly_name = dt.Columns[j].ColumnName;//合金名
                                string c_aolly_code = dt.Rows[0][j].ToString().Trim();//合金代码
                                string c_aolly_value = dt.Rows[i][j].ToString().Trim();//合金值
                                decimal n_aolly_value = 0;//合金值
                                try
                                {
                                    n_aolly_value = Convert.ToDecimal(c_aolly_value);
                                }
                                catch (Exception)
                                {

                                    n_aolly_value = 0;
                                }
                                if (c_aolly_value.Length > 0 && n_aolly_value > 0 && c_aolly_code.Trim().Length > 0)
                                {
                                    //插入数据库
                                    //验证数据是否重复（钢种、执行标准（国标的不带版本号）、合金名称）
                                    Mod_TQB_ALLOY_CONSUMPTION modhj = bll_hjxh.GetModel(c_stl_grd, c_std_code, c_aolly_code);
                                    if (modhj == null)
                                    {
                                        //插入
                                        Mod_TQB_ALLOY_CONSUMPTION modadd = new Mod_TQB_ALLOY_CONSUMPTION();
                                        modadd.C_STL_GRD = c_stl_grd;
                                        modadd.C_STD_CODE = c_std_code;
                                        modadd.C_ALLOYN__NAME = c_aolly_name;
                                        modadd.C_ALLOYN__CODE = c_aolly_code;
                                        modadd.N_ALLOY_WGT = n_aolly_value;
                                        modadd.C_EMP_ID = RV.UI.UserInfo.userID;
                                        modadd.D_MOD_DT = RV.UI.ServerTime.timeNow();
                                        modadd.C_REMARK = cellname;
                                        bll_hjxh.Add(modadd);
                                    }
                                    else
                                    {
                                        //更新
                                        modhj.C_ALLOYN__NAME = c_aolly_name;
                                        modhj.N_ALLOY_WGT = n_aolly_value;
                                        modhj.C_EMP_ID = RV.UI.UserInfo.userID;
                                        modhj.D_MOD_DT = RV.UI.ServerTime.timeNow();
                                        modhj.C_REMARK = cellname;
                                        bll_hjxh.Update(modhj);
                                    }
                                }
                            }

                        }
                        MessageBox.Show("导入成功！");
                        this.txtUrl.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_open_excel_Click(object sender, EventArgs e)
        {
            try
            {
                //将模板复制到桌面
                string fileName = Environment.CurrentDirectory + @"\钢种钢铁料消耗模板.xlsx";
                string deskPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string newFile = deskPath + "\\钢种钢铁料消耗模板.xlsx";
                System.IO.File.Copy(fileName, newFile);

                if (DialogResult.Yes == MessageBox.Show("模板已保存到桌面，是否打开文件?", "提示", MessageBoxButtons.YesNo))
                {
                    System.Diagnostics.Process.Start(newFile);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            //查询当前数据库维护的合金的钢种和标准
            DataTable dt = bll_hjxh.GetList(this.txt_gz.Text.Trim(), this.txt_zxbz.Text.Trim()).Tables[0];
            this.gridControl2.DataSource = dt;
            gridView2.OptionsView.ColumnAutoWidth = false;
            gridView2.OptionsView.RowAutoHeight = true;
            gridView2.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gridView2);
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            try
            {
                int selectedHandle;
                selectedHandle = this.gridView2.GetSelectedRows()[0];

                if (selectedHandle >= 0)
                {
                    string C_STL_GRD = this.gridView2.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
                    string C_STD_CODE = this.gridView2.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();

                    this.txt_gz1.Text = C_STL_GRD;
                    this.txt_bz1.Text = C_STD_CODE;
                    btn_query_hj_Click(null, null);
                    //DataTable dt = bll_hjxh.GetAlloy(C_STL_GRD, C_STD_CODE).Tables[0];
                    //this.gridControl1.DataSource = dt;
                    //gridView1.OptionsView.ColumnAutoWidth = false;
                    //gridView1.OptionsView.RowAutoHeight = true;
                    //this.gridView1.OptionsView.ColumnAutoWidth = false;
                    //this.gridView1.OptionsSelection.MultiSelect = true;
                    //gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                    //gridView1.BestFitColumns();
                    //SetGridViewRowNum.SetRowNum(gridView1);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_query_hj_Click(object sender, EventArgs e)
        {
            string C_ALLOYN__CODE = this.txt_hjdm.Text.Trim();
            string C_ALLOYN__NAME = this.txt_hjmc.Text.Trim();
            DataTable dt = bll_hjxh.GetAlloyByWhere(this.txt_gz1.Text.Trim(), this.txt_bz1.Text.Trim(), C_ALLOYN__CODE, C_ALLOYN__NAME).Tables[0];
            this.gridControl1.DataSource = dt;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridView1.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gridView1);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gridView1.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int cannotNum = 0;//不能删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gridView1.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gridView1.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TQB_ALLOY_CONSUMPTION model = bll_hjxh.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool update = bll_hjxh.Update(model);
                    if (update)
                    {
                        commitNum = commitNum + 1;
                    }
                    else
                    {
                        failtNum = failtNum + 1;
                    }

                }
                if (selectedNum == 0)
                {
                    MessageBox.Show("未选中需要删除的数据！");
                }
                else
                {
                    MessageBox.Show("选择" + selectedNum.ToString() + "条记录，删除" + commitNum.ToString() + "条记录！");
                }
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除钢种合金信息");//添加操作日志

                btn_query_hj_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_change_code_Click(object sender, EventArgs e)
        {


            try
            {
               
                int selectedNum = this.gridView1.SelectedRowsCount;
                if (selectedNum<=0)
                {
                    MessageBox.Show("请选择需要转换的数据！");
                    return;
                }
                int[] rownumber = this.gridView1.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string jccode = this.gridView1.GetRowCellValue(rownumber[0], "C_ALLOYN__CODE").ToString();
                    string dqcode = this.gridView1.GetRowCellValue(selectedHandle, "C_ALLOYN__CODE").ToString();//合金代码
                    if (jccode!= dqcode)
                    {
                        MessageBox.Show("选中行的合金代码必须一致才能批量转换！");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            string code = "";
            string name = "";
            Frm_HJEdit frm = new Frm_HJEdit();
            frm.Owner = this;
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                code = frm.textEdit3.Text.Trim();
                name = frm.textEdit4.Text.Trim();
                frm.Close();

            }

            if (code==""||name=="")
            {
                return;
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("是否确认替换选中合金的代码？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    //替换选中的数据
                    int selectedNum = this.gridView1.SelectedRowsCount;
                    int commitNum = 0;//删除记录数量
                    int cannotNum = 0;//不能删除记录数量
                    int failtNum = 0;//删除失败数量
                    int[] rownumber = this.gridView1.GetSelectedRows();//获取选中行号数组；
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        string strID = this.gridView1.GetRowCellValue(selectedHandle, "C_ID").ToString();
                        Mod_TQB_ALLOY_CONSUMPTION model = bll_hjxh.GetModel(strID);
                        model.C_ALLOYN__CODE = code;
                        model.C_ALLOYN__NAME = name;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        bool update = bll_hjxh.Update(model);
                        if (update)
                        {
                            commitNum = commitNum + 1;
                        }
                        else
                        {
                            failtNum = failtNum + 1;
                        }

                    }
                    if (selectedNum == 0)
                    {
                        MessageBox.Show("未选中需要转换的数据！");
                    }
                    else
                    {
                        MessageBox.Show("选择" + selectedNum.ToString() + "条记录，转换" + commitNum.ToString() + "条记录！");
                    }
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "转换钢种合金代码和名称，转换成功数量："+ commitNum.ToString()+"条！");//添加操作日志
                    this.txt_hjdm.Text = code;
                    this.txt_hjmc.Text = name;
                    btn_query_hj_Click(null, null);

                }
            }
        }
    }
}
