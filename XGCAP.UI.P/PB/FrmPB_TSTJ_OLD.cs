using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aspose.Cells;
using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_TSTJ_OLD : Form
    {
        public FrmPB_TSTJ_OLD()
        {
            InitializeComponent();
        }

        private Bll_TQB_TSBZ_MAIN bllTsbz_Main = new Bll_TQB_TSBZ_MAIN();//铁水标准

        private Bll_TQB_TSBZ_CF bllTsbz_CF = new Bll_TQB_TSBZ_CF();//铁水标准成分

        CommonSub comSub = new CommonSub();

        private string strMenuName;


        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPB_TSTJ_Load(object sender, EventArgs e)
        {
            try
            {
                strMenuName = RV.UI.UserInfo.menuName;
                lbl_tsbz_main_id.Text = "";
                this.lbl_CFID.Text = "";
                comSub.ComboBoxEditBindGZ(this.cbo_stl_grd);//加载钢种
                comSub.ImageComboBoxEditBindItem("成分", this.imgcbo_item);//加载项目
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #region 方法

        /// <summary>
        /// 加载铁水标准
        /// </summary>
        /// <param name="strGZFL">钢种分类</param>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="iStatus">状态</param>
        public void BindTSBZ(string strGZFL, string strGZ, string strBZ, int iStatus)
        {
            DataTable dt = null;
            dt = bllTsbz_Main.GetListByWhere(strGZFL, strGZ, strBZ, iStatus).Tables[0];
            this.gc_tsbz_main.DataSource = dt;
            this.gv_tsbz_main.OptionsView.ColumnAutoWidth = false;
            this.gv_tsbz_main.OptionsSelection.MultiSelect = true;
            gv_tsbz_main.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_tsbz_main.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_tsbz_main);
            BindFocusedRowMain();
        }

        /// <summary>
        /// 获取铁水标准列表焦点行信息
        /// </summary>
        public void BindFocusedRowMain()
        {
            int selectedHandle = this.gv_tsbz_main.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.lbl_tsbz_main_id.Text = "";
                this.groupControl2.Text = "标准成分";
                return;
            }
            this.lbl_tsbz_main_id.Text = this.gv_tsbz_main.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到铁水标准对象，并在界面赋值
            Mod_TQB_TSBZ_MAIN model = bllTsbz_Main.GetModel(this.lbl_tsbz_main_id.Text);
            this.txt_prod_kind.Text = model.C_PROD_KIND;
            this.cbo_stl_grd.Text = model.C_STL_GRD;
            this.cbo_std_code.Text = model.C_XY_CODE;
            this.cbo_route.Text = model.C_ROUTE;
            if (model.C_IS_OFTEN == "1")
            {
                this.rbtn_iscy.SelectedIndex = 0;
            }
            else { this.rbtn_iscy.SelectedIndex = 1; }
            this.txt_bzjb.Text = model.C_REMARK_JB;
            this.txt_remark_mian.Text = model.C_REMARK;
            this.groupControl2.Text = "标准成分：" + this.cbo_stl_grd.Text + "(" + this.cbo_std_code.Text + ")";

            //加载成分信息
            BindCF(this.lbl_tsbz_main_id.Text, this.rbtn_isty_cf.SelectedIndex == 0 ? 1 : 0);
        }
        /// <summary>
        /// 获取铁水成分列表焦点行信息
        /// </summary>
        public void BindFocusedRowCF()
        {
            int selectedHandle = this.gv_tsbz_cf.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.lbl_CFID.Text = "";
                this.groupControl2.Text = "标准成分";
                return;
            }
            this.lbl_CFID.Text = this.gv_tsbz_cf.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到铁水标准对象，并在界面赋值
            Mod_TQB_TSBZ_CF model = bllTsbz_CF.GetModel(this.lbl_CFID.Text);
            this.imgcbo_item.EditValue = model.C_CODE;
            this.txt_value.Text = model.N_TARGET_VALUE.ToString();
            this.txt_remark_cf.Text = model.C_REMARK;
            this.groupControl2.Text = "标准成分：" + this.cbo_stl_grd.Text + "(" + this.cbo_std_code.Text + ")";
        }

        /// <summary>
        /// 根据铁水标准主键加载成分信息
        /// </summary>
        /// <param name="strMainID">铁水标准主键</param>
        public void BindCF(string strMainID, int iStatus)
        {
            DataTable dt = null;
            if (strMainID.Trim() != "")
            {
                dt = bllTsbz_CF.GetListByMainID(strMainID, iStatus).Tables[0];
            }
            this.gc_tsbz_cf.DataSource = dt;
            this.gv_tsbz_cf.OptionsView.ColumnAutoWidth = false;
            this.gv_tsbz_cf.OptionsSelection.MultiSelect = true;
            this.gv_tsbz_cf.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_tsbz_cf.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_tsbz_cf);
            BindFocusedRowCF();
        }

        #endregion
        /// <summary>
        /// 查询铁水成分信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_main_Click(object sender, EventArgs e)
        {
            try
            {
                BindTSBZ(this.txt_q_kind.Text.Trim(), this.txt_q_stl_grd.Text.Trim(), this.txt_q_std_code.Text.Trim(), this.rbtn_isty_main.SelectedIndex == 0 ? 1 : 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbo_stl_grd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comSub.ComboBoxEditBindBZ(this.cbo_stl_grd.Text, cbo_std_code);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbo_stl_grd_TextChanged(object sender, EventArgs e)
        {

            try
            {
                comSub.ComboBoxEditBindBZ(this.cbo_stl_grd.Text, cbo_std_code);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 导入Excle模板数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                // DataTable dt = OpenExcelFile(this.txtUrl.Text, "Sheet2");
                DataTable dt = ReadExcel(this.txtUrl.Text);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string strGUID = System.Guid.NewGuid().ToString();
                        Mod_TQB_TSBZ_MAIN model = new Mod_TQB_TSBZ_MAIN();
                        model.C_ID = strGUID;//主键
                        model.C_PROD_KIND = dt.Rows[i][0].ToString();//钢种分类
                        model.C_STL_GRD = dt.Rows[i][1].ToString();//钢种
                        model.C_XY_CODE = dt.Rows[i][2].ToString();//协议号
                        model.C_ROUTE = dt.Rows[i][3].ToString();//工艺
                        model.C_REMARK = dt.Rows[i][4].ToString();//备注
                        model.C_IS_OFTEN = dt.Rows[i][5].ToString();//是否常用
                        //model.C_REMARK_JB = dt.Rows[i][6].ToString();//备注级别
                        model.C_EMP_ID = dt.Rows[i][6].ToString();//负责人
                        bool res = bllTsbz_Main.Add(model);
                        if (res)
                        {
                            for (int j = 7; j < 27; j++)//成分信息
                            {
                                string nvalue = dt.Rows[i][j].ToString().Trim().Replace("-","");
                                if (nvalue != "")
                                {
                                    string itemName = dt.Columns[j].ColumnName;
                                    Mod_TQB_TSBZ_CF modcf = new Mod_TQB_TSBZ_CF();
                                  //  modcf.C_TSBZ_MAIN_ID = strGUID;
                                    modcf.C_EMP_ID = RV.UI.UserInfo.userName;
                                    modcf.C_NAME = itemName;
                                    try
                                    {
                                        modcf.N_TARGET_VALUE = Convert.ToDecimal(nvalue);
                                    }
                                    catch (Exception)
                                    {

                                        modcf.N_TARGET_VALUE = -1;
                                    }
                                    bool rescf = bllTsbz_CF.Add(modcf);
                                }

                            }
                        }


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        /// <summary>
        /// 将Excel转换成datatable
        /// </summary>
        /// <param name="strFileName">路径</param>
        /// <returns></returns>
        public static System.Data.DataTable ReadExcel(String strFileName)
        {
            Workbook book = new Workbook(strFileName);
            //book.Open(strFileName);
            Worksheet sheet = book.Worksheets[0];
            Cells cells = sheet.Cells;
            return cells.ExportDataTableAsString(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, true);
        }

        ///// <summary>
        ///// 导入Excel文件
        ///// </summary>
        ///// <param name="strFileName">文件地址</param>
        ///// <returns></returns>
        //public static DataTable ReadExcel(String strFileName)
        //{
        //    Workbook book = new Workbook(strFileName);

        //    Worksheet sheet = book.Worksheets[0];
        //    Cells cells = sheet.Cells;

        //    return cells.ExportDataTableAsString(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, true);
        //}


        /// <summary>

        ///  获取Excel中的数据，根据Sheet名字获取数据
        /// </summary>
        /// <param name="excelPath">文件路径</param>
        /// <param name="sheetName">需要打开的sheet名称</param>
        /// <returns></returns>
        public static DataTable OpenExcelFile(string excelPath, string sheetName)
        {
            DataSet ds = new DataSet();
            Workbook workBook = new Workbook(excelPath);
            Worksheet workSheet = workBook.Worksheets[sheetName];
            Cells cell = workSheet.Cells;
            DataTable dt = new DataTable();
            int count = cell.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                string str = cell.GetRow(0)[i].StringValue;
                dt.Columns.Add(new DataColumn(str));
            }
            for (int i = 1; i < cell.Rows.Count; i++)//第一行为表头行，不取
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < count; j++)
                {
                    dr[j] = cell[i, j].StringValue;
                }
                dt.Rows.Add(dr);
            }
            dt.AcceptChanges();
            //ds.Tables.Add(dt);
            return dt;
        }

        private void textEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
        /// <summary>
        /// 查询铁水成分信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_cf_Click(object sender, EventArgs e)
        {
            try
            {
                BindCF(this.lbl_tsbz_main_id.Text, this.rbtn_isty_cf.SelectedIndex == 0 ? 1 : 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 焦点行变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_tsbz_main_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                BindFocusedRowMain();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 保存信息主表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_main_Click(object sender, EventArgs e)
        {
            try
            {
                #region 验证信息
                if (this.txt_prod_kind.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入钢种分类！");
                    this.txt_prod_kind.Focus();
                    return;
                }
                if (this.cbo_stl_grd.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请选择检钢种！");
                    this.cbo_stl_grd.Focus();
                    return;
                }
                if (this.cbo_std_code.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请选择协议号！");
                    this.cbo_std_code.Focus();
                    return;
                }
                if (this.cbo_route.Text.Trim() == "")
                {
                    MessageBox.Show("请选择生产工艺！");
                    this.cbo_route.Focus();
                    return;
                }


                #endregion
                bool res = false;
                if (this.lbl_tsbz_main_id.Text == "")
                {
                    if (DialogResult.No == MessageBox.Show("是否确认添加记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }

                    Mod_TQB_TSBZ_MAIN model = new Mod_TQB_TSBZ_MAIN();
                    model.C_PROD_KIND = this.txt_prod_kind.Text;
                    model.C_STL_GRD = this.cbo_stl_grd.Text;
                    model.C_XY_CODE = this.cbo_std_code.Text;
                    model.C_ROUTE = this.cbo_route.Text;
                    if (this.rbtn_iscy.SelectedIndex == 0)
                    {
                        model.C_IS_OFTEN = "1";
                    }
                    else { model.C_IS_OFTEN = "2"; }
                    model.C_REMARK_JB = this.txt_bzjb.Text;
                    model.C_REMARK = this.txt_remark_mian.Text;

                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    res = bllTsbz_Main.Add(model);

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加铁水条件信息");//添加操作日志

                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑选中的记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TQB_TSBZ_MAIN model = bllTsbz_Main.GetModel(this.lbl_tsbz_main_id.Text);
                    model.C_PROD_KIND = this.txt_prod_kind.Text;
                    model.C_STL_GRD = this.cbo_stl_grd.Text;
                    model.C_XY_CODE = this.cbo_std_code.Text;
                    model.C_ROUTE = this.cbo_route.Text;
                    if (this.rbtn_iscy.SelectedIndex == 0)
                    {
                        model.C_IS_OFTEN = "1";
                    }
                    else { model.C_IS_OFTEN = "2"; }
                    model.C_REMARK_JB = this.txt_bzjb.Text;
                    model.C_REMARK = this.txt_remark_mian.Text;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    res = bllTsbz_Main.Update(model);

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改铁水条件信息");//添加操作日志

                }
                if (res)
                {
                    MessageBox.Show("操作成功！");
                    btn_query_main_Click(null, null);
                    btn_Reset_main_Click(null, null);//清空控件
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 重置主表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_main_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearPanelControl(panelControl1.Controls);
                this.lbl_tsbz_main_id.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 停用主表信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_main_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_tsbz_main.SelectedRowsCount;
                int commitNum = 0;//停用记录数量
                int failtNum = 0;//停用失败数量
                int[] rownumber = this.gv_tsbz_main.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_tsbz_main.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    Mod_TQB_TSBZ_MAIN model = bllTsbz_Main.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool update = bllTsbz_Main.Update(model);
                    if (update)
                    {
                        commitNum = commitNum + 1;
                    }
                    else
                    {
                        failtNum = failtNum + 1;
                    }
                }
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，停用" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用铁水条件信息");//添加操作日志

                btn_query_main_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void gv_tsbz_main_Click(object sender, EventArgs e)
        {
            try
            {
                BindFocusedRowMain();
                BindFocusedRowCF();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 保存子表信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_cf_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lbl_tsbz_main_id.Text.Trim() == "")
                {
                    MessageBox.Show("请选择要求添加成分信息的主表！");
                    return;
                }

                #region 验证信息
                if (this.imgcbo_item.SelectedIndex < 0)
                {
                    MessageBox.Show("请选择项目名称！");
                    this.imgcbo_item.Focus();
                    return;
                }
                if (this.txt_value.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入目标值！");
                    this.txt_value.Focus();
                    return;
                }
             
                #endregion
              
                bool res = false;
                string str = "";
                if (this.lbl_CFID.Text == "")
                {
                    if (DialogResult.No == MessageBox.Show("是否确认添加记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }

                    Mod_TQB_TSBZ_CF model = new Mod_TQB_TSBZ_CF();
                    model.C_CHARACTER_ID = this.lbl_tsbz_main_id.Text;
                    model.C_CODE = this.imgcbo_item.Properties.Items[this.imgcbo_item.SelectedIndex].Value.ToString();
                    model.C_NAME = this.imgcbo_item.Properties.Items[this.imgcbo_item.SelectedIndex].Description.ToString();
                    model.N_TARGET_VALUE = Convert.ToDecimal(this.txt_value.Text);
                    model.C_REMARK = this.txt_remark_cf.Text;
                   // model.C_TSBZ_MAIN_ID = this.lbl_tsbz_main_id.Text;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                   
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_CODE", model.C_CODE);
                   
                    if (Common.CheckRepeat.CheckTable("TQB_TSBZ_CF", ht) > 0)
                    {
                        MessageBox.Show("已存在该数据！");
                        return;
                    }
                    else
                    {
                        res = bllTsbz_CF.Add(model);
                    }
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加铁水成分信息");//添加操作日志
                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑选中的记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TQB_TSBZ_CF model = bllTsbz_CF.GetModel(this.lbl_CFID.Text);
                    model.C_CHARACTER_ID = this.lbl_tsbz_main_id.Text;
                    model.C_CODE = this.imgcbo_item.Properties.Items[this.imgcbo_item.SelectedIndex].Value.ToString();
                    model.C_NAME = this.imgcbo_item.Properties.Items[this.imgcbo_item.SelectedIndex].Description.ToString();
                    model.N_TARGET_VALUE = Convert.ToDecimal(this.txt_value.Text);
                    model.C_REMARK = this.txt_remark_cf.Text;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    res = bllTsbz_CF.Update(model);

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改铁水成分信息");//添加操作日志

                }
                if (res)
                {
                    MessageBox.Show("操作成功！");
                    BindCF(this.lbl_tsbz_main_id.Text, this.rbtn_isty_cf.SelectedIndex == 0 ? 1 : 0);
                    //btn_Reset_main_Click(null, null);//清空控件
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 重置字表信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_cf_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearPanelControl(panelControl2.Controls);
                this.lbl_CFID.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 停用字表信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_cf_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_tsbz_cf.SelectedRowsCount;
                int commitNum = 0;//停用记录数量
                int failtNum = 0;//停用失败数量
                int[] rownumber = this.gv_tsbz_cf.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_tsbz_cf.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    Mod_TQB_TSBZ_CF model = bllTsbz_CF.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool update = bllTsbz_CF.Update(model);
                    if (update)
                    {
                        commitNum = commitNum + 1;
                    }
                    else
                    {
                        failtNum = failtNum + 1;
                    }
                }
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，停用" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用铁水成分信息");//添加操作日志

                BindCF(this.lbl_tsbz_main_id.Text, this.rbtn_isty_cf.SelectedIndex == 0 ? 1 : 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void gv_tsbz_cf_Click(object sender, EventArgs e)
        {
            try
            {
                BindFocusedRowCF();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

