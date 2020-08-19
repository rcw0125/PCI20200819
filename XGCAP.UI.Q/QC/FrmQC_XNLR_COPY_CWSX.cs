using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using BLL;
using MODEL;
using Common;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_XNLR_COPY_CWSX : Form
    {
        private Bll_TQC_PHYSICS_RESULT bllTqcPhysicsResult = new Bll_TQC_PHYSICS_RESULT();
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        private Bll_TQC_PHYSICS_RESULT_MAIN bllTqcPhyResultMain = new Bll_TQC_PHYSICS_RESULT_MAIN();
        private Bll_TQB_PHYSICS_QUALITATIVE bllTqbPhysicsQualitative = new Bll_TQB_PHYSICS_QUALITATIVE();
        private Bll_TQB_PHYSICS_GROUP bllGroup = new Bll_TQB_PHYSICS_GROUP();

        private string strPhyCode;
        private string strMenuName;

        private string strDeptName;

        private string str_PHYSICS_GROUP_ID;

        private bool m_checkStatus = false;

        Bll_TQB_PHYSICS_EQUIPMENT bll_TQB_PHYSICS_EQUIPMENT = new Bll_TQB_PHYSICS_EQUIPMENT();//实验室设备
        Bll_TQB_PHYSICS_GROUP blltqbPhysicsGroup = new Bll_TQB_PHYSICS_GROUP();//物理检验项目分组维护

        private List<Mod_TQB_PHYSICS_QUALITATIVE> lstDX;

        public FrmQC_XNLR_COPY_CWSX()
        {
            InitializeComponent();
        }

        private void FrmQC_XNLR_COPY_CWSX_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;
                strDeptName = RV.UI.QueryString.parameter;

                lstDX = new List<Mod_TQB_PHYSICS_QUALITATIVE>();

                dt_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

                dt_Start_Result.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dt_End_Result.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

                DataSet ds = bllGroup.Get_XN_List(strDeptName);
                imgcbo_Name.Properties.Items.Clear();
                foreach (DataRow item in ds.Tables[0].Rows)//性能名称下拉框绑定
                {
                    imgcbo_Name.Properties.Items.Add(item["C_NAME"].ToString(), item["C_CODE"], -1);
                }

                if (imgcbo_Name.Properties.Items.Count > 0)
                {
                    imgcbo_Name.SelectedIndex = 0;

                    strPhyCode = imgcbo_Name.EditValue.ToString();

                    str_PHYSICS_GROUP_ID = blltqbPhysicsGroup.Get_ID(strPhyCode);

                    lstDX = bllTqbPhysicsQualitative.DataTableToList(bllTqbPhysicsQualitative.Get_DX_List(str_PHYSICS_GROUP_ID).Tables[0]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                BindZYXX();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定制样主表信息
        /// </summary>
        private void BindZYXX()
        {
            WaitingFrom.ShowWait("");

            m_checkStatus = false;

            gc_ZYXX.DataSource = null;
            gv_ZYXX.Columns.Clear();

            DataTable dt = bllTqcPhysicsResult.Get_CWSX_List(strPhyCode, txt_BatchNo.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), "0").Tables["ds"];

            dt.Columns.Add("chk", System.Type.GetType("System.Boolean"));
            dt.Columns["chk"].DefaultValue = Boolean.FalseString;
            dt.Columns["chk"].SetOrdinal(0);

            gc_ZYXX.DataSource = dt;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gv_ZYXX.SetRowCellValue(i, "chk", false);
            }

            gv_ZYXX.Columns["chk"].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            gv_ZYXX.Columns["chk"].OptionsColumn.ShowCaption = false;
            gv_ZYXX.Columns["chk"].ColumnEdit = new RepositoryItemCheckEdit();

            if (dt != null && dt.Rows.Count > 0)
            {
                gv_ZYXX.Columns["设备信息"].ColumnEdit = GetCombox_SBName();
                gv_ZYXX.Columns["C_EMP_ID"].ColumnEdit = RV.UI.UserInfo.repoUserName;
            }

            WaitingFrom.CloseWait();

            gv_ZYXX.Columns["chk"].OptionsColumn.ShowCaption = false;
            gv_ZYXX.Columns["C_EMP_ID"].Caption = "录入人";
            gv_ZYXX.Columns[1].Visible = false;
            gv_ZYXX.Columns["检验状态"].Visible = false;
            gv_ZYXX.Columns["制样时间"].Visible = false;
            gv_ZYXX.Columns["炉号"].Visible = false;
            gv_ZYXX.Columns["设备信息"].Visible = false;

            int count = 0;

            for (int i = 1; i < dt.Columns.Count; i++)
            {
                if (i < 12)
                {
                    gv_ZYXX.Columns[i].OptionsColumn.AllowEdit = false;
                }
                else if (i > 12)
                {
                    count = lstDX.Where(x => x.C_NAME == gv_ZYXX.Columns[i].FieldName).ToList().Count;

                    if (count > 0)
                    {
                        gv_ZYXX.Columns[i].ColumnEdit = GetCombox_ByName(gv_ZYXX.Columns[i].FieldName);
                    }

                    if (gv_ZYXX.Columns[i].FieldName == "显微组织")
                    {
                        continue;
                    }

                    gv_ZYXX.Columns[i].MaxWidth = 60;
                    gv_ZYXX.Columns[i].MinWidth = 60;
                }
            }

            //冻结有焦点的列
            gv_ZYXX.Columns[0].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_ZYXX.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_ZYXX.Columns[2].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_ZYXX.Columns[3].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_ZYXX.Columns[4].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_ZYXX.Columns[5].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;

            //gv_ZYXX.OptionsBehavior.Editable = false;
            gv_ZYXX.OptionsView.ColumnAutoWidth = false;
            gv_ZYXX.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;

            gv_ZYXX.Appearance.EvenRow.BackColor = Color.White;
            gv_ZYXX.Appearance.OddRow.BackColor = Color.LightYellow;
            gv_ZYXX.OptionsView.EnableAppearanceEvenRow = true;
            gv_ZYXX.OptionsView.EnableAppearanceOddRow = true;

            gv_ZYXX.BestFitColumns();
        }

        /// <summary>
        /// 根据项目名称获取下拉列表
        /// </summary>
        /// <param name="strName">项目名称</param>
        /// <returns></returns>
        public RepositoryItemImageComboBox GetCombox_ByName(string strName)
        {
            var lst = lstDX.Where(x => x.C_NAME == strName).ToList();
            var repo = new RepositoryItemImageComboBox();
            var nulllist = new ImageComboBoxItem("", "");
            repo.Items.Add(nulllist);
            for (int i = 0; i < lst.Count; i++)
            {
                var list = new ImageComboBoxItem(lst[i].C_RESULT, lst[i].C_RESULT);
                repo.Items.Add(list);
            }


            return repo;
        }
        /// <summary>
        /// 根据项目名称获取下拉列表
        /// </summary>
        /// <param name="strName">项目名称</param>
        /// <returns></returns>
        public RepositoryItemImageComboBox GetCombox_SBName()
        {
            DataTable dt = blltqbPhysicsGroup.GetList_Code(strPhyCode).Tables[0];
            DataTable dt_name = bll_TQB_PHYSICS_EQUIPMENT.GetList_Fid(dt.Rows[0]["C_ID"].ToString()).Tables[0];
            var repo = new RepositoryItemImageComboBox();
            foreach (DataRow item in dt_name.Rows)//设备名称
            {
                var list = new ImageComboBoxItem(item["C_EQ_NAME"].ToString(), item["C_EQ_NAME"].ToString());
                repo.Items.Add(list);
            }
            return repo;
        }
        /// <summary>
        /// 查询录入结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Result_Click(object sender, EventArgs e)
        {
            try
            {
                BindResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定性能结果信息
        /// </summary>
        private void BindResult()
        {
            WaitingFrom.ShowWait("");

            gc_Result.DataSource = null;
            gv_Result.Columns.Clear();

            DataTable dt = bllTqcPhysicsResult.Get_CWSX_List(strPhyCode, txt_Batch_Result.Text.Trim(), dt_Start_Result.Text.Trim(), dt_End_Result.Text.Trim(), "1").Tables["ds"];

            gc_Result.DataSource = dt;
            // gv_Result.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Result);

            WaitingFrom.CloseWait();

            if (dt != null && dt.Rows.Count > 0)
            {
                gv_Result.Columns[9].Caption = "录入人";
                gv_Result.Columns[0].Visible = false;
                gv_Result.Columns["炉号"].Visible = false;
                gv_Result.Columns["检验状态"].Visible = false;
                gv_Result.Columns["制样时间"].Visible = false;
                gv_Result.Columns["设备信息"].Visible = false;
            }

            //冻结有焦点的列
            gv_Result.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_Result.Columns[2].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_Result.Columns[3].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_Result.Columns[4].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
        }

        /// <summary>
        /// 保存性能录入结果信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ((DataView)gv_ZYXX.DataSource).ToTable();

                string result = bllTqcPhysicsResult.Save_Result(dt, strPhyCode);

                if (result == "1")
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "保存性能信息");//添加操作日志

                    MessageBox.Show("保存成功！");
                    BindZYXX();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int colStartIndex = 0;
        private int rowStartIndex = 0;
        private string strStart = "";

        private void gv_ZYXX_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Form的KeyPreview属性应设为true
            if (e.KeyChar != (char)22)// Ctrl + V
            {
                return;
            }

            colStartIndex = gv_ZYXX.FocusedColumn.ColumnHandle;
            rowStartIndex = gv_ZYXX.FocusedRowHandle;

            int rowIndex = rowStartIndex;

            if (colStartIndex <= 10)//前10列固定，不能修改
            {
                return;
            }

            IDataObject data = Clipboard.GetDataObject();
            string[] types = data.GetFormats();
            string tmp = "";
            if (data.GetDataPresent(typeof(string)))
            {
                tmp = (string)data.GetData(typeof(string));

                string schar = tmp.Substring(tmp.Length - 1);
                if (schar == "\n")
                {
                    tmp = tmp.Substring(0, tmp.Length - 1);
                }

                tmp = tmp.Replace("\r", "");
                string[] rows = tmp.Split(new char[] { '\n' });

                for (int i = 0; i < rows.Length; i++)
                {
                    int colIndex = colStartIndex;

                    string[] cols = rows[i].Split(new char[] { '\t' });
                    // 把cols插入到grid中

                    for (int jj = 0; jj < cols.Length; jj++)
                    {
                        if (i == 0 && jj == 0)
                        {
                            strStart = cols[jj];
                        }

                        if (colIndex < gv_ZYXX.Columns.Count && rowIndex < gv_ZYXX.RowCount)
                        {
                            gv_ZYXX.SetRowCellValue(rowIndex, gv_ZYXX.Columns[colIndex], cols[jj]);
                            colIndex++;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    rowIndex++;
                }
            }
        }

        private void gv_ZYXX_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Appearance.Font = new System.Drawing.Font("宋体", 9);
            e.Info.ImageIndex = -1;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }

            if (e.RowHandle >= 0)
            {
                if (colStartIndex > 0 && e.RowHandle == rowStartIndex)
                {
                    gv_ZYXX.SetRowCellValue(rowStartIndex, gv_ZYXX.Columns[colStartIndex], strStart);

                    colStartIndex = 0;
                }
            }
        }

        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            string strName = blltqbPhysicsGroup.Get_Name(strPhyCode);
            OutToExcel.ToExcel(gc_Result, strName + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void btn_Out_Lr_Click(object sender, EventArgs e)
        {
            string strName = blltqbPhysicsGroup.Get_Name(strPhyCode);
            OutToExcel.ToExcel(gc_ZYXX, strName + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }


        private void gv_ZYXX_DoubleClick(object sender, EventArgs e)
        {
            if (gv_ZYXX.FocusedColumn.GetTextCaption() == "批号")
            {
                int handle = gv_ZYXX.FocusedRowHandle;
                if (handle >= 0)
                {
                    bool bChk = (bool)gv_ZYXX.GetRowCellValue(handle, "chk");
                    string strBatch = gv_ZYXX.GetRowCellValue(handle, "批号").ToString();
                    for (int i = 0; i < gv_ZYXX.RowCount; i++)
                    {
                        if (strBatch == gv_ZYXX.GetRowCellValue(i, "批号").ToString())
                        {
                            gv_ZYXX.SetRowCellValue(i, "chk", !bChk);
                        }
                    }
                }
            }
        }

        #region  列头选择框

        /// <summary>
        /// 列头画多选框
        /// </summary>
        /// <param name="e"></param>
        /// <param name="chk"></param>

        private static void DrawCheckBox(DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e, bool chk)
        {
            try
            {
                DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryCheck = e.Column.ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit;
                if (repositoryCheck != null)
                {
                    System.Drawing.Graphics g = e.Graphics;
                    System.Drawing.Rectangle r = e.Bounds;

                    DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
                    DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
                    DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
                    info = repositoryCheck.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;

                    painter = repositoryCheck.CreatePainter() as DevExpress.XtraEditors.Drawing.CheckEditPainter;
                    info.EditValue = chk;
                    info.Bounds = r;
                    info.CalcViewInfo(g);
                    args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
                    painter.Draw(args);
                    args.Cache.Dispose();
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 自定义列头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_ZYXX_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null && e.Column.FieldName == "chk")
            {
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                DrawCheckBox(e, m_checkStatus);
                e.Handled = true;
            }
        }

        /// <summary>
        /// 全选/全不选
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="fieldName"></param>
        /// <param name="currentStatus"></param>
        /// <returns></returns>
        private bool ClickGridCheckBox(DevExpress.XtraGrid.Views.Grid.GridView gridView, string fieldName, bool currentStatus)
        {
            try
            {
                bool result = false;

                if (gridView != null)
                {
                    gridView.PostEditor();

                    DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo info;

                    Point pt = gridView.GridControl.PointToClient(Control.MousePosition);

                    info = gridView.CalcHitInfo(pt);

                    if (info.InColumn && info.Column != null && info.Column.FieldName == fieldName)
                    {
                        for (int i = 0; i < gridView.RowCount; i++)
                        {
                            gridView.SetRowCellValue(i, fieldName, !currentStatus);
                        }

                        return true;

                    }

                }

                return result;
            }
            catch
            {
                return false;
            }

        }


        #endregion

        private void gv_ZYXX_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClickGridCheckBox(gv_ZYXX, "chk", m_checkStatus))
                {
                    m_checkStatus = !m_checkStatus;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgcbo_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            strPhyCode = imgcbo_Name.EditValue.ToString();

            str_PHYSICS_GROUP_ID = blltqbPhysicsGroup.Get_ID(strPhyCode);

            lstDX = bllTqbPhysicsQualitative.DataTableToList(bllTqbPhysicsQualitative.Get_DX_List(str_PHYSICS_GROUP_ID).Tables[0]);
        }
    }
}
