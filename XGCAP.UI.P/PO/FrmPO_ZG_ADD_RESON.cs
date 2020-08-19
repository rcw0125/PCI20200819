using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;
using MODEL;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_ZG_ADD_RESON : Form
    {
        private Bll_TRP_PLAN_REASON bllTrpPlanReason = new Bll_TRP_PLAN_REASON();

        string strPlanID = "";
        string strOrderNo = "";
        string strGG = "";
        string strGZ = "";
        string strBZ = "";

        public FrmPO_ZG_ADD_RESON(string PlanID, string OrderNo, string GG, string GZ, string BZ)
        {
            InitializeComponent();

            strPlanID = PlanID;
            strOrderNo = OrderNo;
            strGG = GG;
            strGZ = GZ;
            strBZ = BZ;
        }

        private void FrmPO_ZG_ADD_RESON_Load(object sender, EventArgs e)
        {
            txt_Order.Text = strOrderNo;
            txt_Spec.Text = strGG;
            txt_Grd.Text = strGZ;
            txt_Std.Text = strBZ;

            BindInfo();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void BindInfo()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bllTrpPlanReason.Get_List(strPlanID).Tables[0];

                gc_Log.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Log);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Reason.Text.Trim()))
                {
                    MessageBox.Show("请填写原因！");
                    return;
                }

                Mod_TRP_PLAN_REASON modReason = new Mod_TRP_PLAN_REASON();
                modReason.C_PLAN_ROLL_ID = strPlanID;
                modReason.C_ORDER_NO = strOrderNo;
                modReason.C_STL_GRD = strGZ;
                modReason.C_STD_CODE = strBZ;
                modReason.C_SPEC = strGG;
                modReason.C_REASON = txt_Reason.Text.Trim();
                modReason.C_EMP_ID = RV.UI.UserInfo.userID;
                modReason.D_MOD_DT = RV.UI.ServerTime.timeNow();

                if (bllTrpPlanReason.Add(modReason))
                {
                    MessageBox.Show("添加成功！");

                    txt_Reason.Text = "";

                    BindInfo();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
