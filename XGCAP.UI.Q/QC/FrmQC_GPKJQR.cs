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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_GPKJQR : Form
    {
        public FrmQC_GPKJQR()
        {
            InitializeComponent();
        }
        Bll_TQC_WAREHOUSE_CHECK_SLAB bll_slab = new Bll_TQC_WAREHOUSE_CHECK_SLAB();
        Bll_TQC_WE_CHECK_AFFIRM bll_affirm = new Bll_TQC_WE_CHECK_AFFIRM();
        Bll_TSC_SLAB_MAIN bllSlabMain = new Bll_TSC_SLAB_MAIN();
        private string strMenuName;

        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC_KJQR_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 库检信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = new DataTable();
                if (this.rbtn_isty_wh.SelectedIndex == 0)//未确认 查询
                {
                    dt = bll_affirm.GetList_Query(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_Stove1.Text).Tables[0];
                }
                else//已确认
                {
                    dt = bll_affirm.GetList_Query1(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_Stove1.Text).Tables[0];
                }
                gc_GPKJ.DataSource = dt;
                gv_GPKJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPKJ);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_GPKJ.GetDataRow(this.gv_GPKJ.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择要确认的库检信息!", "提示");
                    return;
                }
                if (dr["C_CHECK_EMP_ID"].ToString() != "")
                {
                    MessageBox.Show("请勿重复确认!", "提示");
                    return;
                }
                if (imgcbo_HGZT.Text.Trim()=="")
                {
                    MessageBox.Show("请选择合格状态！");
                    return;
                }
                Mod_TQC_WAREHOUSE_CHECK_SLAB mod_slab = bll_slab.GetModel(dr["C_ID"].ToString());
                mod_slab.C_CHECK_EMP_ID = RV.UI.UserInfo.UserID;
                mod_slab.D_CHECK_DT = RV.UI.ServerTime.timeNow(); 
                DialogResult dialogResult = MessageBox.Show("是否确认\n炉号:'" + dr["C_STOVE"].ToString() + "'", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    if (bll_slab.Update(mod_slab))
                    {
                        txt_Query1_Click(null, null);
                    }

                    Mod_TQC_WE_CHECK_AFFIRM mod = new Mod_TQC_WE_CHECK_AFFIRM();
                    mod.C_WE_CHECK_SLAB_ID = dr["C_ID"].ToString();
                    mod.C_SUGGESTION = txt_SHYJ.Text.Trim();
                    mod.C_CHECK_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_CHECK_DT = RV.UI.ServerTime.timeNow();
                    if (bll_affirm.Add(mod))
                    {
                        Mod_TSC_SLAB_MAIN mod_SlabMain = bllSlabMain.GetModel(mod_slab.C_SLAB_ID);
                        mod_SlabMain.C_DEPOT_TYPE = imgcbo_HGZT.Text.Trim();
                        bllSlabMain.Update(mod_SlabMain);
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "钢坯库检信息确认");//添加操作日志

                        ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
                        MessageBox.Show("已确认！", "提示");
                    }
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

    }
}
