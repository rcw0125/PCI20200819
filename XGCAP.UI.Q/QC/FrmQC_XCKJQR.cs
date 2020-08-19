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
    public partial class FrmQC_XCKJQR : Form
    {
        public FrmQC_XCKJQR()
        {
            InitializeComponent();
        }
        Bll_TQC_ROOL_CHECK_AFFIRM bll_we_check_roll = new Bll_TQC_ROOL_CHECK_AFFIRM();
        Bll_TQC_WAREHOUSE_CHECK_ROLL bll_roll = new Bll_TQC_WAREHOUSE_CHECK_ROLL();
        Bll_TQC_ROOL_CHECK_AFFIRM bll_affirm = new Bll_TQC_ROOL_CHECK_AFFIRM();
        Bll_TRC_ROLL_PRODCUT bllProduct = new Bll_TRC_ROLL_PRODCUT();
        private string strMenuName;

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                DataTable dt = new DataTable();
                if (this.rbtn_isty_wh.SelectedIndex == 0)//未确认 查询
                {
                    dt = bll_we_check_roll.GetList_Query(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_BatchNo1.Text).Tables[0];
                }
                else//已确认
                {
                    dt = bll_we_check_roll.GetList_Query1(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_BatchNo1.Text).Tables[0];
                }
                gc_PDJG.DataSource = dt;
                gv_PDJG.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_PDJG);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC_XCKJQR_Load(object sender, EventArgs e)
        {
            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }
        /// <summary>
        /// 库检确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_PDJG.GetDataRow(this.gv_PDJG.FocusedRowHandle);
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
                    MessageBox.Show("请选择是否合格!", "提示");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("是否确认\n批号:'" + dr["C_BATCH_NO"].ToString() + "'", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {

                    Mod_TQC_ROOL_CHECK_AFFIRM mod = new Mod_TQC_ROOL_CHECK_AFFIRM();
                    mod.C_WE_CHECK_ROOL_ID = dr["C_ID"].ToString();
                    mod.C_SUGGESTION = txt_SHYJ.Text;
                    mod.C_CHECK_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_CHECK_DT = RV.UI.ServerTime.timeNow();
                    if (bll_affirm.Add(mod))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "确认线材库检信息");//添加操作日志

                        ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
                        Mod_TQC_WAREHOUSE_CHECK_ROLL mod_roll = bll_roll.GetModel(dr["C_ID"].ToString());
                        mod_roll.C_CHECK_EMP_ID = RV.UI.UserInfo.UserID;
                        mod_roll.D_CHECK_DT = RV.UI.ServerTime.timeNow();

                        if (bll_roll.Update(mod_roll))
                        {
                            Mod_TRC_ROLL_PRODCUT mod_Product = bllProduct.GetModel(mod_roll.C_ROLL_ID);
                            mod_Product.C_DEPOT_TYPE = imgcbo_HGZT.Text.Trim();
                            bllProduct.Update(mod_Product);
                            btn_Query1_Click(null, null);
                        }
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
