using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;
using DevExpress.XtraEditors.Controls;


namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APS_BXG_XM : Form
    {
        public FrmPO_APS_BXG_XM()
        {
            InitializeComponent();
        }
        private Bll_TRP_PLAN_ROLL bllTrpPlanRoll = new Bll_TRP_PLAN_ROLL();
        private Bll_TQB_COPING_BASIC bll_xm = new Bll_TQB_COPING_BASIC();
        private Bll_TMO_ORDER_PJ_LOG bll_ddpj = new Bll_TMO_ORDER_PJ_LOG();
        private void FrmPO_APS_BXG_XM_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            dtp_form1.Text = Cls_Order_PC.GetDXFristDay()[0];
            this.dtp_end1.Text = Cls_Order_PC.GetDXFristDay()[1];
            BindSpec();
            DataTable dtxm = bll_xm.GetBxgBZ();
            icbo_xm.Properties.Items.Clear();
            icbo_xm.Properties.Items.Add("", "", -1);
            for (int i = 0; i < dtxm.Rows.Count; i++)
            {

                icbo_xm.Properties.Items.Add(dtxm.Rows[i]["C_CRAFT_FLOW"].ToString(), dtxm.Rows[i]["C_COPING_CRAFT"].ToString(), -1);

            }
            icbo_xm.SelectedIndex = 0;


        }
        /// <summary>
        /// 加载线材计划查询的规格
        /// </summary>
        public void BindSpec()
        {
            DataTable dt = bllTrpPlanRoll.Get_Spec().Tables[0];
            this.txt_Spec.Properties.Items.Clear();

            CheckedListBoxItem[] itemListQuery = new CheckedListBoxItem[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                itemListQuery[i] = new CheckedListBoxItem(dt.Rows[i]["C_SPEC"].ToString(), dt.Rows[i]["C_SPEC"].ToString());
            }
            this.txt_Spec.Properties.Items.AddRange(itemListQuery);
        }

        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();
        List<Mod_TMO_ORDER> lst = new List<Mod_TMO_ORDER>();//订单列表
        private void btn_query_order_Click(object sender, EventArgs e)
        {
            ////查询已评价、未完成的不锈钢计划

            if (this.dtp_form1.Text.Trim() == "" || this.dtp_end1.Text == "")
            {
                MessageBox.Show("请输入查询日期！");
                return;
            }
            WaitingFrom.ShowWait("订单正在加载，请稍后...");


            string strDDMin = "";
            string strDDMax = "";

            string strOrderNOlist = "";


            strDDMin = Convert.ToDateTime(this.dtp_form1.Text).ToShortDateString() + " 00:00:00";
            strDDMax = Convert.ToDateTime(this.dtp_end1.Text).ToShortDateString() + " 23:59:59";



            lst = bll_order.GetBXGOrder(strDDMin, strDDMax, this.txt_gz1.Text, this.txt_zxbz1.Text.Trim(), this.txt_Spec.Text.Trim(), strOrderNOlist);

            this.modTMOORDERBindingSource.DataSource = lst;
            this.gv_tmo_order.OptionsView.ColumnAutoWidth = false;
            this.gv_tmo_order.OptionsSelection.MultiSelect = true;
            SetGridViewRowNum.SetRowNum(gv_tmo_order);
            this.gv_tmo_order.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void btn_xm_Click(object sender, EventArgs e)
        {
            if (this.icbo_xm.SelectedIndex < 0)
            {
                MessageBox.Show("请选择修磨要求！");
                return;
            }
            int slsctcou = lst.Where(a => a.B_check).ToList().Count;

            if (DialogResult.Yes == MessageBox.Show("是否确认维护选中的订单 ？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                #region 方法
                WaitingFrom.ShowWait("计划正在修改，请稍候...");
                if (lst.Count > 0)
                {
                    if (lst.Where(a => a.B_check).ToList().Count > 0)
                    {
                        for (int i = 0; i < lst.Count; i++)
                        {
                            if (lst[i].B_check)
                            {

                                string c_xm = this.icbo_xm.Properties.Items[this.icbo_xm.SelectedIndex].Value.ToString();
                                lst[i].C_XM = "N";
                                if (c_xm.Trim() != "")
                                {
                                    lst[i].C_XM = "Y";

                                }
                                lst[i].C_XM_YQ = c_xm;
                                bll_order.Update(lst[i]);

                                DataTable dtroll_plan = bllTrpPlanRoll.GetListByOrderID(lst[i].C_ID).Tables[0];
                                if (dtroll_plan.Rows.Count > 0)
                                {
                                    for (int j = 0; j < dtroll_plan.Rows.Count; j++)
                                    {
                                        Mod_TRP_PLAN_ROLL modtrp_roll = bllTrpPlanRoll.GetModel(dtroll_plan.Rows[j]["C_ID"].ToString());
                                        modtrp_roll.C_XM = lst[i].C_XM;
                                        modtrp_roll.C_XM_YQ = lst[i].C_XM_YQ;


                                        bllTrpPlanRoll.Update(modtrp_roll);
                                    }
                                }

                                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                                modlog.C_ORDER_NO = lst[i].C_ORDER_NO;
                                modlog.C_TYPE = "不锈钢订单维护修磨要求";
                                modlog.C_RESULT = "";
                                modlog.C_MSG = "不锈钢订单维护修磨要求！";
                                bll_ddpj.Add(modlog);
                            }
                        }

                    }
                }
                WaitingFrom.CloseWait();
                #endregion
                btn_query_order_Click(null, null);
            }
        }
    }
}
