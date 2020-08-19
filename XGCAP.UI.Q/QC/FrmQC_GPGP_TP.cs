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
using XGCAP.UI.Q.QB;
using Common;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_GPGP_TP : Form
    {
        public FrmQC_GPGP_TP()
        {
            InitializeComponent();
        }

        Bll_TQB_CHECKSTATE bll_checkstate = new Bll_TQB_CHECKSTATE();
        private Bll_TQB_GP_LCP_BASIS bllTqbGpLcpBasis = new Bll_TQB_GP_LCP_BASIS();
        Bll_TSC_SLAB_MAIN bll_slab = new Bll_TSC_SLAB_MAIN();
        Bll_TQC_SLAB_COMMUTE bll_commute = new Bll_TQC_SLAB_COMMUTE();
        Bll_TB_STA bll_sta = new Bll_TB_STA();
        Bll_TB_MATRL_MAIN bll_matrl = new Bll_TB_MATRL_MAIN();
        Bll_TQC_TP_SLAB_COMMUTE bllTPSlab = new Bll_TQC_TP_SLAB_COMMUTE();

        private string strMenuName;
        string strLen = "";
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC006_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            btn_mat_code.ReadOnly = true;
            txt_mat_name.ReadOnly = true;
            txt_Grd.ReadOnly = true;
            txt_Std.ReadOnly = true;
            txt_ZYX1.ReadOnly = true;
            txt_ZYX2.ReadOnly = true;

            dte_Begin1.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            DataSet dt_sta = bll_sta.GetAllList();
            imgcbo_ZRDW.Properties.Items.Clear();
            foreach (DataRow item in dt_sta.Tables[0].Rows)//责任单位下拉框
            {
                imgcbo_ZRDW.Properties.Items.Add(item["C_STA_DESC"].ToString(), item["C_STA_CODE"], -1);
            }
            DataSet dt = bll_checkstate.GetList_GP("");
            imgcbo_PDDJ.Properties.Items.Clear();
            foreach (DataRow item in dt.Tables[0].Rows)//判定等级下拉框
            {
                imgcbo_PDDJ.Properties.Items.Add(item["C_CHECKSTATE_NAME"].ToString(), item["C_CHECKSTATE_NAME"], -1);
            }
            imgcbo_PDDJ.SelectedIndex = 0;

        }
        /// <summary>
        /// 钢坯实绩查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_slab.GetList_StoveBetween(dte_Begin1.DateTime, dte_End1.DateTime, txt_Stove.Text.Trim(),txt_StoveEnd.Text.Trim()).Tables[0];
                gc_GPSJ.DataSource = dt;
                gv_GPSJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPSJ);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 跳转到物料编码查询页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mat_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataRow dr = gv_GPSJ.GetDataRow(gv_GPSJ.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请先点击需要改判的信息！");
                    return;
                }
                FrmQC_SELECT_WL frm = new FrmQC_SELECT_WL(dr["C_MAT_CODE"].ToString(), "1", dr["N_LEN"].ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btn_mat_code.Text = frm.mat_code;
                    txt_mat_name.Text = frm.mat_name;
                    txt_Std.Text = frm.std;
                    txt_Grd.Text = frm.stl_grd;
                    txt_ZYX1.Text = frm.strZYX1;
                    txt_ZYX2.Text = frm.strZYX2;

                    strLen = frm.lennew;


                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 钢坯改判记录查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bllTPSlab.GetList_TP(dte_Begin.DateTime, dte_End.DateTime, txt_Stove1.Text.Trim()).Tables[0];
                gc_GPGP.DataSource = dt;
                gv_GPGP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPGP);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 改判
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Decide_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_GPSJ.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要改判的信息！");
                    return;
                }
                if (txt_GPYY.Text.Trim() == "")
                {
                    MessageBox.Show("请输入改判原因");
                    return;
                }
                DataRow row = gv_GPSJ.GetDataRow(rownumber[0]);
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow dr = gv_GPSJ.GetDataRow(rownumber[i]);
                    if (dr["C_STD_CODE"].ToString() != row["C_STD_CODE"].ToString()
                      || dr["C_STL_GRD"].ToString() != row["C_STL_GRD"].ToString()
                      || dr["C_MAT_CODE"].ToString() != row["C_MAT_CODE"].ToString()
                      || dr["C_MAT_NAME"].ToString() != row["C_MAT_NAME"].ToString()
                      || dr["C_SLABWH_CODE"].ToString() != row["C_SLABWH_CODE"].ToString()
                      || dr["N_LEN"].ToString() != row["N_LEN"].ToString())
                    {
                        MessageBox.Show("数据类型不同，请重新选择！");
                        return;
                    }

                    if (dr["C_JUDGE_LEV_ZH"].ToString() == "")
                    {
                        MessageBox.Show("改判失败，信息未综合判定！");
                        return;
                    }
                }

                if (string.IsNullOrEmpty(txt_Std.Text))
                {
                    MessageBox.Show("执行标准不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(btn_mat_code.Text))
                {
                    MessageBox.Show("物料编码不能为空！");
                    return;
                }

                if (DialogResult.OK != MessageBox.Show("是否确认申请已选中的数据？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }
                string strs = "";
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    strs = strs + gv_GPSJ.GetRowCellValue(selectedHandle, "C_ID").ToString() + ",";
                }
                if (strLen == "")
                {
                    strLen = gv_GPSJ.GetRowCellValue(0, "N_LEN").ToString();
                }
                string strResult = bll_slab.TPGP_Slab(strs, txt_Grd.Text.Trim(), txt_Std.Text.Trim(), btn_mat_code.Text.Trim(), txt_mat_name.Text.Trim(), imgcbo_ZRDW.EditValue?.ToString(), imgcbo_ZRDW.Text, imgcbo_PDDJ.Text.Trim(), txt_ZYX1.Text.Trim(), txt_ZYX2.Text.Trim(), txt_GPYY.Text.Trim(), strLen, 1);
                if (strResult == "1")
                {
                    btn_Query_Click(null, null);
                    btn_Query1_Click(null, null);
                    ClearContent.ClearFlowLayoutPanel(panelControl4.Controls);
                    MessageBox.Show("申请成功！");
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "挑坯改判申请");//添加操作日志
                }
                else
                {
                    MessageBox.Show(strResult);
                }

                string url = Application.StartupPath;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 钢坯实绩信息回传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_GPSJ_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_GPSJ.GetDataRow(gv_GPSJ.FocusedRowHandle);
                if (dr == null)
                {
                    txt_Std.Text = "";
                    txt_Grd.Text = "";
                    btn_mat_code.Text = "";
                    txt_mat_name.Text = "";
                }
                else
                {
                    btn_mat_code.Text = dr["C_MAT_CODE"].ToString();
                    txt_mat_name.Text = dr["C_MAT_NAME"].ToString();
                    txt_Std.Text = dr["C_STD_CODE"].ToString();
                    txt_Grd.Text = dr["C_STL_GRD"].ToString();
                    txt_ZYX1.Text = dr["C_ZYX1"].ToString();
                    txt_ZYX2.Text = dr["C_ZYX2"].ToString();
                    imgcbo_PDDJ.EditValue = dr["C_JUDGE_LEV_ZH"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 不审核挑坯改判
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GP_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_GPSJ.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要改判的信息！");
                    return;
                }
                if (txt_GPYY.Text.Trim() == "")
                {
                    MessageBox.Show("请输入改判原因");
                    return;
                }
                DataRow row = gv_GPSJ.GetDataRow(rownumber[0]);
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow dr = gv_GPSJ.GetDataRow(rownumber[i]);
                    if (dr["C_STD_CODE"].ToString() != row["C_STD_CODE"].ToString()
                      || dr["C_STL_GRD"].ToString() != row["C_STL_GRD"].ToString()
                      || dr["C_MAT_CODE"].ToString() != row["C_MAT_CODE"].ToString()
                      || dr["C_MAT_NAME"].ToString() != row["C_MAT_NAME"].ToString()
                      || dr["C_SLABWH_CODE"].ToString() != row["C_SLABWH_CODE"].ToString()
                      || dr["N_LEN"].ToString() != row["N_LEN"].ToString())
                    {
                        MessageBox.Show("数据类型不同，请重新选择！");
                        return;
                    }

                    if (dr["C_JUDGE_LEV_ZH"].ToString() == "")
                    {
                        MessageBox.Show("改判失败，信息未综合判定！");
                        return;
                    }
                }

                if (string.IsNullOrEmpty(txt_Std.Text))
                {
                    MessageBox.Show("执行标准不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(btn_mat_code.Text))
                {
                    MessageBox.Show("物料编码不能为空！");
                    return;
                }

                if (DialogResult.OK != MessageBox.Show("是否确认申请已选中的数据？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }
                string strs = "";
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    strs = strs + gv_GPSJ.GetRowCellValue(selectedHandle, "C_ID").ToString() + ",";
                }
                if (strLen == "")
                {
                    strLen = gv_GPSJ.GetRowCellValue(0, "N_LEN").ToString();
                }
                string strResult = bll_slab.TPGP_Slab(strs, txt_Grd.Text.Trim(), txt_Std.Text.Trim(), btn_mat_code.Text.Trim(), txt_mat_name.Text.Trim(), imgcbo_ZRDW.EditValue?.ToString(), imgcbo_ZRDW.Text, imgcbo_PDDJ.Text.Trim(), txt_ZYX1.Text.Trim(), txt_ZYX2.Text.Trim(), txt_GPYY.Text.Trim(), strLen, 0);
                if (strResult == "1")
                {
                    btn_Query_Click(null, null);
                    btn_Query1_Click(null, null);
                    ClearContent.ClearFlowLayoutPanel(panelControl4.Controls);
                    MessageBox.Show("申请成功！");
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "挑坯改判申请");//添加操作日志
                }
                else
                {
                    MessageBox.Show(strResult);
                }

                string url = Application.StartupPath;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 双击查询成分信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_GPGP_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gv_GPGP.FocusedColumn.GetTextCaption() == "炉号")
                {
                    int handle = gv_GPGP.FocusedRowHandle;
                    if (handle >= 0)
                    {
                        string strStove = gv_GPGP.GetRowCellValue(handle, "炉号").ToString();
                        string strStlGrd = gv_GPGP.GetRowCellValue(handle, "改判后钢种").ToString();
                        string strStdCode = gv_GPGP.GetRowCellValue(handle, "改判后标准").ToString();

                        FrmQC_CFPD_TP frm = new FrmQC_CFPD_TP(strStove, strStdCode, strStlGrd);
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 取消申请
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QXSQ_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != MessageBox.Show("是否确认取消申请已选中的数据？", "提示", MessageBoxButtons.OKCancel))
            {
                return;
            }
            DataRow dr = this.gv_GPGP.GetDataRow(this.gv_GPGP.FocusedRowHandle);
            if (dr == null) return;
            string stove = dr["炉号"].ToString();
            string strBatchNo = dr["开坯号"].ToString(); 
            string stlgrd = dr["改判前钢种"].ToString();
            string stdcode = dr["改判前标准"].ToString();
            string matID = dr["改判前物料编码"].ToString();
            string strZYX1 = dr["改判前自由项1"].ToString();
            string strZYX2 = dr["改判前自由项2"].ToString();
            string strSlabCode = dr["仓库"].ToString();
            string strSTD_GPH = dr["改判后标准"].ToString();
            string strMat_GPH = dr["改判后物料编码"].ToString();
            string strZYX1_GPH = dr["改判后自由项1"].ToString();
            string strZYX2_GPH = dr["改判后自由项2"].ToString(); 
            DataTable dt = bllTPSlab.GetList_TPGP_COU(stove, strBatchNo, stlgrd, stdcode, matID, strZYX1, strZYX2, strSlabCode, strMat_GPH, strSTD_GPH, strZYX1_GPH, strZYX2_GPH).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Mod_TQC_TP_SLAB_COMMUTE mod = bllTPSlab.GetModel(dt.Rows[i]["C_ID"].ToString());
                mod.N_STATUS = 0; 
                mod.C_COMMUTE_REASON = "取消挑坯改判申请";
                mod.C_REMARK1 = RV.UI.UserInfo.UserName;
                mod.D_COMMUTE_DATE = RV.UI.ServerTime.timeNow();
                bllTPSlab.Update(mod);
                Mod_TSC_SLAB_MAIN mod_slab = bll_slab.GetModel(dt.Rows[i]["C_SLAB_MAIN_ID"].ToString());
                mod_slab.C_MOVE_TYPE = dt.Rows[i]["C_REMARK2"].ToString();
                bll_slab.Update(mod_slab);
            } 
            btn_Query1_Click(null, null);
        }
    }
}
 
