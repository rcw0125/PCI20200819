using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using MODEL;
namespace XGCAP.UI.Q.QC
{
    /// <summary>
    /// 2018-05-17 zmc
    /// </summary>
    public partial class FrmQC_GPKJGL : Form
    {
        public FrmQC_GPKJGL()
        {
            InitializeComponent();
        }
        Bll_TSC_SLAB_MAIN bll_slab = new Bll_TSC_SLAB_MAIN();
        Bll_TQB_WAREHOUSE_CAUSE bll_cause = new Bll_TQB_WAREHOUSE_CAUSE();
        Bll_TQB_WAREHOUSE_CAUSE_OPINION bll_opinion = new Bll_TQB_WAREHOUSE_CAUSE_OPINION();
        Bll_TQC_WAREHOUSE_CHECK_SLAB bll_check_slab = new Bll_TQC_WAREHOUSE_CHECK_SLAB();

        private string strMenuName;

        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC007_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;
                dte_Begin1.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
                dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
                DataSet dt = bll_cause.GetList_Group("");
                imgcbo_YYLX.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)//原因类型
                {
                    imgcbo_YYLX.Properties.Items.Add(item["C_CAUSE_TYPE"].ToString(), item["C_CAUSE_TYPE"], -1);
                }
                DataSet dt_opinion = bll_opinion.GetList("");
                imgcbo_CZYJ.Properties.Items.Clear();
                foreach (DataRow item in dt_opinion.Tables[0].Rows)//处置意见
                {
                    imgcbo_CZYJ.Properties.Items.Add(item["C_CAUSE_OPINION"].ToString(), item["C_ID"], -1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 钢坯实绩表查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_slab.GetList_Stove(dte_Begin1.DateTime.ToString(), dte_End1.DateTime.ToString(), txt_stl_grd.Text.Trim(), txt_DM.Text.Trim(), txt_Stove.Text.Trim()).Tables[0];
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
        /// 原因类型-原因名称 二级查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_YYLX_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dt = bll_cause.GetList_name(imgcbo_YYLX.EditValue.ToString());
                imgcbo_YYMC.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)//原因名称下拉框查询
                {
                    imgcbo_YYMC.Properties.Items.Add(item["C_CAUSE_NAME"].ToString(), item["C_ID"], -1);
                }
                imgcbo_YYMC.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 钢坯库检信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (this.rbtn_isty_wh.SelectedIndex == 0)//未确认 查询
                {
                    dt = bll_check_slab.GetList_Query(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_Stove1.Text).Tables[0];
                }
                else//已确认
                {
                    dt = bll_check_slab.GetList_Query1(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_Stove1.Text).Tables[0];
                }
                gc_GPKJ.DataSource = dt;
                gv_GPKJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPKJ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 库检申请
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_KJSQ_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_GPSJ.GetDataRow(this.gv_GPSJ.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择需要库检的数据！", "提示");
                    return;
                }

                if (imgcbo_YYMC.EditValue == null)
                {
                    MessageBox.Show("库检原因不能为空！", "提示");
                    return;
                }
                if (imgcbo_ZRBM.EditValue == null)
                {
                    MessageBox.Show("责任单位不能为空！", "提示");
                    return;
                }
                if (imgcbo_CZYJ.EditValue == null)
                {
                    MessageBox.Show("处置意见不能为空！", "提示");
                    return;
                }
                Mod_TQC_WAREHOUSE_CHECK_SLAB mod = new Mod_TQC_WAREHOUSE_CHECK_SLAB();
                mod.C_SLAB_ID = dr["C_ID"].ToString();
                mod.C_STOVE = dr["C_STOVE"].ToString();
                mod.C_STL_GRD = dr["C_STL_GRD"].ToString();
                mod.N_WGT = Convert.ToDecimal(dr["N_WGT"]);
                mod.C_STD_CODE = dr["C_STD_CODE"].ToString();
                mod.C_SLAB_SIZE = dr["C_SPEC"].ToString();
                mod.N_LEN = Convert.ToDecimal(dr["N_LEN"]);
                mod.C_MAT_CODE = dr["C_MAT_CODE"].ToString();
                mod.C_MAT_NAME = dr["C_MAT_NAME"].ToString();
                if (!string.IsNullOrEmpty(dr["D_WE_DATE"].ToString()))
                {
                    mod.D_WAREHOUSE_IN = Convert.ToDateTime(dr["D_WE_DATE"]);
                }
              
                mod.C_REASON_NAME = imgcbo_YYMC.Text.Trim();
                mod.C_REASON_CODE = imgcbo_YYMC.EditValue.ToString();
                mod.C_REASON_DEPMT_ID = imgcbo_ZRBM.Text;
                mod.C_REASON_DEPMT_DESC = imgcbo_ZRBM.EditValue.ToString();
                mod.C_SUGGESTION = imgcbo_CZYJ.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                if (bll_check_slab.Add(mod))
                {
                    MessageBox.Show("申请成功！", "提示");
                }
                Mod_TSC_SLAB_MAIN mod_slab = bll_slab.GetModel(dr["C_ID"].ToString());
                mod_slab.C_IS_DEPOT = "0";
                bll_slab.Update(mod_slab);

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钢坯库检信息");//添加操作日志

                btn_Query_Click(null, null);
                txt_Query1_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 取消库检
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QXKJ_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_GPKJ.GetDataRow(this.gv_GPKJ.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择要取消申请的库检信息!", "提示");
                    return;
                }
                if (dr["C_CHECK_EMP_ID"].ToString() != "")
                {
                    MessageBox.Show("库检已确认，不能取消!", "提示");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("确定要取消申请\n炉号:'" + dr["C_STOVE"].ToString() + "'", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    Mod_TSC_SLAB_MAIN mod_slab = bll_slab.GetModel(dr["C_SLAB_ID"].ToString());
                    mod_slab.C_IS_DEPOT = "1";
                    bll_slab.Update(mod_slab);
                    bll_check_slab.Delete(dr["C_ID"].ToString());
                    btn_Query_Click(null, null);
                    txt_Query1_Click(null, null);
                    MessageBox.Show("已取消!", "提示");

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消钢坯库检申请信息");//添加操作日志

                }
                else//如果点击“取消”按钮
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl3.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
