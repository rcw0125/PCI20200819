using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MODEL;
using BLL;
using Common;
using DevExpress.XtraEditors.Repository;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_CGSYGL : Form
    {
        private string strMenuName;

        public FrmQC_CGSYGL()
        {
            InitializeComponent();
        }

        Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        Bll_TQB_STD_SAMPLING bll_std_sampling = new Bll_TQB_STD_SAMPLING();
        Bll_TRC_ROLL_MAIN bll_trc_roll_main = new Bll_TRC_ROLL_MAIN();
        Bll_TPB_STA_HOOK_NO bll_tpbstahook = new Bll_TPB_STA_HOOK_NO();
        Bll_TPB_HOOK bll_hook = new Bll_TPB_HOOK();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        CommonSub common = new CommonSub();

        private bool m_checkStatus = false;

        private void FrmQC011_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            string cou = RV.UI.QueryString.parameter;
            strMenuName = RV.UI.UserInfo.menuName;

            //DataTable dt = bll_tpbstahook.GetList_GH(cou).Tables[0];
            //gc_right.DataSource = dt;
            //gv_right.BestFitColumns();
            //SetGridViewRowNum.SetRowNum(gv_right);
            gv_right.OptionsSelection.MultiSelect = true;//复选框
            //gv_right.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            imgcbo_CJ.Properties.Items.Clear();
            imgcbo_CJ.Properties.Items.Add("全部", "全部", -1);
            DataTable dt = bll_TB_STA.GetListByGXStr("'ZX'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    imgcbo_CJ.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), i);
                }
            }
            else
            {
                imgcbo_CJ.Properties.Items.Clear();
            }
            imgcbo_CJ.SelectedIndex = 0;
            //NewMethod();
        }
        /// <summary>
        /// 查询线材实绩信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            try
            {
                string pland = imgcbo_CJ.Text.ToString();
                string batch = txt_BatchNo.Text;
                DataTable dt = bll_trc_roll_main.GetProductList(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), pland, batch).Tables[0];

                this.gc_SJXX.DataSource = dt;
                gv_SJXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SJXX);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 添加送样
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TJSY_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(icbo_BC.Text.ToString()) || string.IsNullOrEmpty(icbo_BZ.Text.ToString()))
                {
                    MessageBox.Show("请选择班次班组！");
                    return;
                }

                DataRow dr = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
                for (int i = 0; i < gv_right.DataRowCount; i++)
                {
                    string val = this.gv_right.GetRowCellValue(i, this.gv_right.Columns["chk"]).ToString();
                    if (val == "True")
                    {
                        string strSG = this.gv_right.GetRowCellValue(i, this.gv_right.Columns["strSG"]).ToString();//首钩
                        string strCG = this.gv_right.GetRowCellValue(i, this.gv_right.Columns["strCG"]).ToString();//次钩
                        string strT = this.gv_right.GetRowCellValue(i, this.gv_right.Columns["strT"]).ToString();//头
                        string strW = this.gv_right.GetRowCellValue(i, this.gv_right.Columns["strW"]).ToString();//尾

                        if (strT == "True" || strW == "True")
                        {
                            if (strT == "True")
                            {
                                Mod_TQC_PRESENT_SAMPLES model = new Mod_TQC_PRESENT_SAMPLES();
                                model.C_BATCH_NO = dr["C_BATCH_NO"].ToString();
                                model.C_STL_GRD = dr["C_STL_GRD"].ToString();
                                model.C_SPEC = dr["C_SPEC"].ToString();
                                model.N_ENTRUST_TYPE = 0;
                                model.C_TICK_NO = gv_right.GetRowCellValue(i, "N_HOOK_NO").ToString() + "-T";
                                model.C_EMP_ID = RV.UI.UserInfo.userID;
                                model.C_BC_SY = icbo_BC.EditValue.ToString();
                                model.C_BZ_SY = icbo_BZ.EditValue.ToString();
                                if (strSG == "True")
                                {
                                    model.C_TICK_STATE = "2";
                                }
                                else if (strCG == "True")
                                {
                                    model.C_TICK_STATE = "1";
                                }
                                else
                                {
                                    model.C_TICK_STATE = "0";
                                    model.N_SAMPLES_NUM = 1;
                                }

                                bllTqcPresentSamples.Add(model);
                            }

                            if (strW == "True")
                            {
                                Mod_TQC_PRESENT_SAMPLES model = new Mod_TQC_PRESENT_SAMPLES();
                                model.C_BATCH_NO = dr["C_BATCH_NO"].ToString();
                                model.C_STL_GRD = dr["C_STL_GRD"].ToString();
                                model.C_SPEC = dr["C_SPEC"].ToString();
                                model.N_ENTRUST_TYPE = 0;
                                model.C_TICK_NO = gv_right.GetRowCellValue(i, "N_HOOK_NO").ToString() + "-W";
                                model.C_EMP_ID = RV.UI.UserInfo.userID;
                                model.C_BC_SY = icbo_BC.EditValue.ToString();
                                model.C_BZ_SY = icbo_BZ.EditValue.ToString();
                                if (strSG == "True")
                                {
                                    model.C_TICK_STATE = "2";
                                }
                                else if (strCG == "True")
                                {
                                    model.C_TICK_STATE = "1";
                                }
                                else
                                {
                                    model.C_TICK_STATE = "0";
                                    model.N_SAMPLES_NUM = 1;
                                }

                                bllTqcPresentSamples.Add(model);
                            }

                        }
                        else
                        {
                            Mod_TQC_PRESENT_SAMPLES model = new Mod_TQC_PRESENT_SAMPLES();
                            model.C_BATCH_NO = dr["C_BATCH_NO"].ToString();
                            model.C_STL_GRD = dr["C_STL_GRD"].ToString();
                            model.C_SPEC = dr["C_SPEC"].ToString();
                            model.N_ENTRUST_TYPE = 0;
                            model.C_TICK_NO = gv_right.GetRowCellValue(i, "N_HOOK_NO").ToString();
                            model.C_EMP_ID = RV.UI.UserInfo.userID;
                            model.C_BC_SY = icbo_BC.EditValue.ToString();
                            model.C_BZ_SY = icbo_BZ.EditValue.ToString();
                            if (strSG == "True")
                            {
                                model.C_TICK_STATE = "2";
                            }
                            else if (strCG == "True")
                            {
                                model.C_TICK_STATE = "1";
                            }
                            else
                            {
                                model.C_TICK_STATE = "0";
                                model.N_SAMPLES_NUM = 1;
                            }

                            bllTqcPresentSamples.Add(model);
                        }

                    }
                }

                BindSampling();
                NewMethod1();
                MessageBox.Show("添加成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加常规送样信息");//添加操作日志


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询送样信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Sam_Click(object sender, EventArgs e)
        {
            try
            {
                BindSampling();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询送样信息
        /// </summary>
        private void BindSampling()
        {
            DataTable dt = bllTqcPresentSamples.Get_List(txt_BatchNo_Sam.Text.Trim(), txt_GRL.Text.Trim(), txt_Spec.Text.Trim(), txt_Hook_No.Text.Trim(), icbo_State.EditValue.ToString()).Tables[0];

            if (dt.Rows.Count > 0)
            {
                gc_SYXX.DataSource = dt;
                gv_SYXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SYXX);
                gv_SYXX.Columns["C_EMP_ID"].Caption = "操作人员";
                gv_SYXX.Columns["状态"].OptionsColumn.AllowEdit = false;
                gv_SYXX.Columns["钩号"].OptionsColumn.AllowEdit = false;
                gv_SYXX.Columns["批号"].OptionsColumn.AllowEdit = false;
                gv_SYXX.Columns["钢种"].OptionsColumn.AllowEdit = false;
                gv_SYXX.Columns["规格"].OptionsColumn.AllowEdit = false;
                gv_SYXX.Columns["C_EMP_ID"].OptionsColumn.AllowEdit = false;
                gv_SYXX.Columns["操作时间"].OptionsColumn.AllowEdit = false;
                gv_SYXX.Columns["钩号状态"].OptionsColumn.AllowEdit = false;
                gv_SYXX.Columns[0].Visible = false;

                gv_SYXX.OptionsSelection.MultiSelect = true;
                gv_SYXX.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

            }
            else
            {
                gc_SYXX.DataSource = null;
                gv_SYXX.BestFitColumns();
            }
        }

        /// <summary>
        /// 提交委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TJWT_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = RV.UI.UserInfo.userID;
                DateTime dtTime = RV.UI.ServerTime.timeNow();

                int[] rownumber = gv_SYXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    ArrayList SQLStringList = new ArrayList();

                    if (rownumber.Length > 0)
                    {
                        for (int i = 0; i < rownumber.Length; i++)
                        {
                            int selectedHandle = rownumber[i];

                            string strID = gv_SYXX.GetRowCellValue(selectedHandle, "主键").ToString();


                            if (!string.IsNullOrEmpty(gv_SYXX.GetRowCellValue(selectedHandle, "取样数量").ToString()))
                            {
                                int result = 0;
                                if (!int.TryParse(gv_SYXX.GetRowCellValue(selectedHandle, "取样数量").ToString(), out result))
                                {
                                    MessageBox.Show("取样数量只能填写整数！");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("请填写取样数量！");
                                return;
                            }

                            SQLStringList.Add("update tqc_present_samples set  N_SAMPLES_NUM='" + gv_SYXX.GetRowCellValue(selectedHandle, "取样数量").ToString() + "',N_ENTRUST_TYPE=1,C_EMP_ID='" + userID + "',D_MOD_DT=SYSDATE,C_REMARK='" + gv_SYXX.GetRowCellValue(selectedHandle, "备注").ToString() + "' where C_ID='" + strID + "' ");

                            //SQLStringList.Add("update tqc_present_samples set N_ENTRUST_TYPE=1,C_EMP_ID='" + userID + "',D_MOD_DT=SYSDATE where C_ID='" + strID + "' ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("勾选的需要委托的信息！");
                    }

                    if (bllTqcPresentSamples.SaveSamp(SQLStringList))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "委托常规送样信息");//添加操作日志

                        MessageBox.Show("保存成功！");
                        BindSampling();
                    }
                }

                else
                {
                    MessageBox.Show("请选择需要委托的送样信息！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void NewMethod1()
        {
            try
            {
                m_checkStatus = false;

                DataRow dr = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
                if (dr == null) return;//判断是否选中线材实绩信息                             
                if (string.IsNullOrEmpty(dr["C_STL_GRD"].ToString()) || string.IsNullOrEmpty(dr["C_STD_CODE"].ToString()))
                {
                    return;
                }
                DataTable dt = bll_hook.GetList(dr["C_BATCH_NO"].ToString(), dr["C_STA_ID"].ToString()).Tables[0];

                dt.Columns.Add("chk", System.Type.GetType("System.Boolean"));
                dt.Columns.Add("strSG", System.Type.GetType("System.Boolean"));//首钩
                dt.Columns.Add("strCG", System.Type.GetType("System.Boolean"));//次钩
                dt.Columns.Add("strT", System.Type.GetType("System.Boolean"));//头
                dt.Columns.Add("strW", System.Type.GetType("System.Boolean"));//尾
                dt.Columns["chk"].DefaultValue = Boolean.FalseString;
                dt.Columns["strSG"].DefaultValue = Boolean.FalseString;
                dt.Columns["strCG"].DefaultValue = Boolean.FalseString;
                dt.Columns["strT"].DefaultValue = Boolean.FalseString;
                dt.Columns["strW"].DefaultValue = Boolean.FalseString;


                gc_right.DataSource = dt;
                gv_right.BestFitColumns();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gv_right.SetRowCellValue(i, "strSG", false);
                    gv_right.SetRowCellValue(i, "strCG", false);
                    gv_right.SetRowCellValue(i, "chk", false);
                    gv_right.SetRowCellValue(i, "strT", false);
                    gv_right.SetRowCellValue(i, "strW", false);
                }

                SetGridViewRowNum.SetRowNum(gv_right);
                DataTable dt_sampling = bll_std_sampling.GetList_Query(dr["C_STL_GRD"].ToString(), dr["C_STD_CODE"].ToString()).Tables[0];
                gc_XNLB.DataSource = dt_sampling;
                gv_XNLB.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_XNLB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 取消委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Back_Click(object sender, EventArgs e)
        {
            int[] rownumber = gv_SYXX.GetSelectedRows();//获取选中行号数组；

            if (rownumber.Length > 0)
            {
                ArrayList SQLStringList = new ArrayList();

                int a = 0;

                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];

                    string strID = gv_SYXX.GetRowCellValue(selectedHandle, "主键").ToString();

                    DataTable dt_RustType = bllTqcPresentSamples.GetList_CID(strID).Tables[0];

                    if (Convert.ToInt32(dt_RustType.Rows[0]["N_ENTRUST_TYPE"].ToString()) > 1)
                    {
                        a++;
                        MessageBox.Show("批号：" + gv_SYXX.GetRowCellValue(selectedHandle, "批号").ToString() + "钩号：" + gv_SYXX.GetRowCellValue(selectedHandle, "钩号").ToString() + "的数据数据已接收，不能取消委托！");
                        break;
                    }

                }

                if (a == 0)
                {
                    string userID = RV.UI.UserInfo.userID;
                    DateTime dtTime = RV.UI.ServerTime.timeNow();

                    if (rownumber.Length > 0)
                    {
                        for (int i = 0; i < rownumber.Length; i++)
                        {
                            int selectedHandle = rownumber[i];

                            string strID = gv_SYXX.GetRowCellValue(selectedHandle, "主键").ToString();

                            SQLStringList.Add("update tqc_present_samples set N_ENTRUST_TYPE=0,C_EMP_ID='" + userID + "',D_MOD_DT=SYSDATE where C_ID='" + strID + "' ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("勾选的需要委托的信息！");
                    }

                    if (bllTqcPresentSamples.SaveSamp(SQLStringList))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "委托常规送样信息");//添加操作日志

                        MessageBox.Show("保存成功！");
                        BindSampling();
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择需要取消委托的信息！");
                return;
            }
        }

        private void gv_SJXX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod1();
        }
        /// <summary>
        /// 跳转到添加界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                FrmQC_CGSYGL_Add frm = new FrmQC_CGSYGL_Add();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    NewMethod();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 删除手动添加的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {

                    DataRow dr = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
                    if (dr == null)
                    {
                        MessageBox.Show("请选择需要删除的信息！");
                        return;
                    }
                    if (dr["C_REMARK"].ToString() != "手动添加请勿删除！！")
                    {
                        MessageBox.Show("只能删除手动添加的数据！");
                        return;
                    }
                    if (bll_trc_roll_main.Delete(dr["C_ID"].ToString()))
                    {
                        MessageBox.Show("删除成功！");
                        NewMethod();
                        ClearContent.ClearFlowLayoutPanel(panelControl2.Controls);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void gv_SYXX_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_SYXX.GetDataRow(this.gv_SYXX.FocusedRowHandle);
                if (dr == null) return;//判断是否选中线材实绩信息                             
                DataTable dt = bll_trc_roll_main.GetList_Batch(dr["批号"].ToString()).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    DataTable dt_sampling = bll_std_sampling.GetList_Query(dt.Rows[0]["C_STL_GRD"].ToString(), dt.Rows[0]["C_STD_CODE"].ToString()).Tables[0];
                    gc_XNLB.DataSource = dt_sampling;
                    gv_XNLB.BestFitColumns();
                    SetGridViewRowNum.SetRowNum(gv_XNLB);
                }
                else
                {
                    gc_XNLB.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 删除未委托的取样信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {

                    int[] rownumber = gv_SYXX.GetSelectedRows();//获取选中行号数组；
                    int a = 0;
                    if (rownumber.Length == 0)
                    {
                        MessageBox.Show("请选择需要删除的信息！");
                        return;
                    }
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        if (gv_SYXX.GetRowCellValue(selectedHandle, "状态").ToString() == "已委托")
                        {
                            a++;
                            MessageBox.Show("勾选的数据已委托，不能删除！");
                            break;
                        }
                    }
                    if (a == 0)
                    {
                        for (int i = 0; i < rownumber.Length; i++)
                        {
                            int selectedHandle = rownumber[i];

                            if (gv_SYXX.GetRowCellValue(selectedHandle, "状态").ToString() == "已委托")
                            {
                                MessageBox.Show("勾选的数据已委托，不能删除！");
                                break;
                            }
                            string strID = gv_SYXX.GetRowCellValue(selectedHandle, "主键").ToString();
                            bllTqcPresentSamples.Delete(strID);
                        }
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除未委托的常规送样信息");//添加操作日志
                        MessageBox.Show("删除成功！");
                        BindSampling();
                        NewMethod1();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 列头画多选框
        /// </summary>
        /// <param name="e"></param>
        /// <param name="chk"></param>

        private static void DrawCheckBox(DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e, bool chk)
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

        /// <summary>
        /// 自定义列头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_right_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
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

        private void gv_right_Click(object sender, EventArgs e)
        {
            if (ClickGridCheckBox(gv_right, "chk", m_checkStatus))
            {
                m_checkStatus = !m_checkStatus;
            }
        }
        /// <summary>
        /// 保存备注
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BCBZ_Click(object sender, EventArgs e)
        {
            int[] rownumber = gv_SYXX.GetSelectedRows();//获取选中行号数组；
            int a = 0;
            if (rownumber.Length == 0)
            {
                MessageBox.Show("请选择需要添加备注的信息！");
                return;
            }
            for (int i = 0; i < rownumber.Length; i++)
            {
                int selectedHandle = rownumber[i];

                if (gv_SYXX.GetRowCellValue(selectedHandle, "状态").ToString() == "已委托")
                {
                    a++;
                    MessageBox.Show("勾选的数据已委托，不能保存备注！");
                    break;
                }
            }
            if (a == 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];

                    if (gv_SYXX.GetRowCellValue(selectedHandle, "状态").ToString() == "已委托")
                    {
                        MessageBox.Show("勾选的数据已委托，不能保存备注！");
                        break;
                    }
                    string strID = gv_SYXX.GetRowCellValue(selectedHandle, "主键").ToString();
                    Mod_TQC_PRESENT_SAMPLES mod = bllTqcPresentSamples.GetModel(strID);
                    mod.C_REMARK = txt_Remark.Text.Trim();
                    if (!bllTqcPresentSamples.Update(mod))
                    {
                        MessageBox.Show("保存失败");
                        return;
                    }

                }
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "保存未委托的常规送样的备注信息");//添加操作日志
                MessageBox.Show("保存成功！");
                BindSampling();
                NewMethod1();
            }
        }

        DevExpress.Utils.AppearanceDefault appNotPass = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Yellow, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);

        private void gv_SJXX_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                string strResult = gv_SJXX.GetRowCellValue(e.RowHandle, "ADDNUM").ToString();

                if (strResult != "0")
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass);
                }

            }
            catch
            {

            }
        }
    }
}
