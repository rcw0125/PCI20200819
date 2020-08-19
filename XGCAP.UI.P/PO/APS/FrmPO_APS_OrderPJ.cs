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
    public partial class FrmPO_APS_OrderPJ : Form
    {
        public FrmPO_APS_OrderPJ()
        {
            InitializeComponent();
        }
        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();
        private Bll_TQB_STD_MAIN bll_std = new Bll_TQB_STD_MAIN();
        private Bll_TMO_ORDER_PJ_LOG bll_ddpj = new Bll_TMO_ORDER_PJ_LOG();
        private Bll_TRP_PLAN_ROLL bll_trp_paln = new Bll_TRP_PLAN_ROLL();//
        private Bll_TRP_PLAN_ROLL_ITEM bll_trp_plan_item = new Bll_TRP_PLAN_ROLL_ITEM();//
        private Bll_TRP_PLAN_ROLL bllTrpPlanRoll = new Bll_TRP_PLAN_ROLL();
        private Bll_TB_STA bll_sta = new Bll_TB_STA();
        List<Mod_TMO_ORDER> lst = new List<Mod_TMO_ORDER>();//订单列表
        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_order_Click(object sender, EventArgs e)
        {
            if (this.dtp_form1.Text.Trim() == "" || this.dtp_end1.Text == "")
            {
                MessageBox.Show("请输入查询日期！");
                return;
            }
            WaitingFrom.ShowWait("订单正在加载，请稍后...");
            //double? gg_min = null;//规格最小值
            //if (this.txt_gg_min.Text.Trim() != "")
            //{
            //    gg_min = Convert.ToDouble(this.txt_gg_min.Text.Trim());
            //}
            //double? gg_max = null;//规格最大值
            //if (this.txt_gg_max.Text.Trim() != "" && Convert.ToDouble(this.txt_gg_max.Text.Trim()) > 0)
            //{
            //    gg_max = Convert.ToDouble(this.txt_gg_max.Text.Trim());
            //}
            string strJQMin = "";
            string strJQMax = "";
            string strDDMin = "";
            string strDDMax = "";

            string strOrderNOlist = "";
            if (txt_order_no.Text.Trim()!="")
            {
                string[] OrderNo = txt_order_no.Text.Trim().Split(new string[] { "\r\n" }, StringSplitOptions.None);
                OrderNo = OrderNo.Where(s => !string.IsNullOrEmpty(s)).ToArray();
                if (OrderNo.Length>0)
                {
                    for (int i = 0; i < OrderNo.Length; i++)
                    {
                        if (i==0)
                        {
                            strOrderNOlist = "'" + OrderNo[i] + "'";
                        }
                        else
                        {
                            strOrderNOlist = strOrderNOlist+ ",'" + OrderNo[i] + "'";
                        }
                       
                    }
                }

            }
            // string aaa=   strOrderNOlist;

            if (cbo_date_type.Text == "计划日期")
            {
                strJQMin = Convert.ToDateTime(this.dtp_form1.Text).ToShortDateString() + " 00:00:00";
                strJQMax = Convert.ToDateTime(this.dtp_end1.Text).ToShortDateString() + " 23:59:59";
                strDDMin = "";
                strDDMax = "";
            }
            else
            {
                strJQMin = "";
                strJQMax = "";
                strDDMin = Convert.ToDateTime(this.dtp_form1.Text).ToShortDateString() + " 00:00:00";
                strDDMax = Convert.ToDateTime(this.dtp_end1.Text).ToShortDateString() + " 23:59:59";
            }
            string C_SFPJ = "";
            if (rbtn_sfpj.SelectedIndex == 0)
            {
                C_SFPJ = "";
            }
            else if (rbtn_sfpj.SelectedIndex == 1)
            {
                C_SFPJ = "N";
            }
            else
            {
                C_SFPJ = "Y";
            }

            int n_sfqr = rbtn_sfqr.SelectedIndex;//是否确认

            int sfwc = rbtn_sfwc.SelectedIndex;//是否完成

            int gzlb = this.rbtn_type.SelectedIndex;//0全部，1碳钢，2不锈钢，3钢坯
            string c_line_no = "";
            if (icbo_line.SelectedIndex>=0)
            {
                c_line_no = icbo_line.Properties.Items[icbo_line.SelectedIndex].Value.ToString();
            }
            lst = bll_order.GetOrderListByWhere(gzlb,C_SFPJ, sfwc, n_sfqr, strOrderNOlist, "", this.txt_gz1.Text.Trim(), this.txt_zxbz1.Text.Trim(), txt_Spec.Text,  "", strJQMin, strJQMax, strDDMin, strDDMax,c_line_no);

            this.modTMOORDERBindingSource.DataSource = lst;
            this.gv_tmo_order.OptionsView.ColumnAutoWidth = false;
            this.gv_tmo_order.OptionsSelection.MultiSelect = true;
            SetGridViewRowNum.SetRowNum(gv_tmo_order);
            this.gv_tmo_order.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void btn_order_pj1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否评价选中的订单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                WaitingFrom.ShowWait("系统正在对订单进行分析，请稍候...");
                int res = 0;
                if (lst.Count > 0)
                {
                    if (lst.Where(a => a.B_check).ToList().Count > 0)
                    {
                        string C_TYPE = "正常";
                        if (rbtn_lx_type.SelectedIndex==1)
                        {
                            C_TYPE = "试验";
                        }

                        for (int i = 0; i < lst.Count; i++)
                        {
                           
                            if (lst[i].B_check)
                            {
                                string c_order_id = lst[i].C_ID;
                                Mod_TMO_ORDER mod = bll_order.GetModel(c_order_id);
                                Cls_Order_PC.OrderPj(mod, C_TYPE);
                                res = res + 1;
                            }
                        }

                    }
                }
                
                MessageBox.Show("订单已成功评价"+ res.ToString() + "条！");
                btn_query_order_Click(null, null);
                WaitingFrom.CloseWait();
            }



        }

        /// <summary>
        /// 取消评价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancle_pj_Click(object sender, EventArgs e)
        {

        }
        private Bll_TPC_PLAN_SMS bll_plan = new Bll_TPC_PLAN_SMS();
        private Bll_TB_MATRL_MAIN bll_wl = new Bll_TB_MATRL_MAIN();
        List<Mod_TB_MATRL_MAIN> lstwl = new List<Mod_TB_MATRL_MAIN>();
        /// <summary>
        /// 订单确认排产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_pc_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否确认排产所选中的订单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                lstwl = bll_wl.GetListLZ("");
                #region 新方法
                WaitingFrom.ShowWait("");
                if (lst.Count > 0)
                {
                    if (lst.Where(a => a.B_check).ToList().Count > 0)
                    {
                        for (int i = 0; i < lst.Count; i++)
                        {
                            if (lst[i].B_check)
                            {
                                if (lst[i].B_check)
                                {
                                    decimal down_wgt = lst[i].N_WGT - lst[i].N_PROD_WGT - lst[i].N_ROLL_PROD_WGT;
                                    if (down_wgt>0)
                                    {
                                        #region 验证订单是否有首尾炉钢种
                                        bool flag = true;
                                        DataTable dtsl = Cls_Order_PC.GetSWLGZ(lst[i].C_STL_GRD_SLAB, lst[i].C_STD_CODE_SLAB, "首炉");
                                        if (dtsl != null && dtsl.Rows.Count > 0)
                                        {

                                            string slorder = "";//首炉生产钢种的订单
                                            for (int m = 0; m < dtsl.Rows.Count; m++)
                                            {
                                                string C_STL_GRD = dtsl.Rows[m]["C_B_E_STOVE_STEEL"].ToString();
                                                string C_STD_CODE = dtsl.Rows[m]["C_BORDER_STD_CODE"].ToString();


                                            }

                                          
                                        }
                                       
                                        #endregion


                                        Cls_APS_PC.DownOrder(lst[i].C_ID, down_wgt);
                                    }
                                }
                            }
                        }
                        //string group = bll_plan.P_LGPLAN_GROUPING();//炼钢计划重新分组
                    }
                }
                WaitingFrom.CloseWait();
                #endregion
           
            }

            btn_query_order_Click(null, null);
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_tmo_order, "销售计划-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void btn_query_bz_Click(object sender, EventArgs e)
        {
            string C_IS_BXG = "";
            if (radioGroup1.SelectedIndex == 0)
            {
                C_IS_BXG = "0";
            }
            else
            {
                C_IS_BXG = "1";
            }
            string C_ROUTE_DESC = "";
            if (radioGroup2.SelectedIndex == 2)
            {
                C_ROUTE_DESC = "N";
            }
            else
            {
                C_ROUTE_DESC = "";
            }
            string C_STL_GRD_TYPE = "";
            if (radioGroup2.SelectedIndex == 1)
            {
                C_STL_GRD_TYPE = "N";
            }
            else
            {
                C_STL_GRD_TYPE = "";
            }
            string C_STL_GRD = this.txt_gz2.Text.Trim();
            string C_STD_CODE = this.txt_bz2.Text.Trim();

            WaitingFrom.ShowWait("订单数据正在加载，请稍候...");
            DataTable dt = bll_std.GetSCTJ(C_IS_BXG, C_ROUTE_DESC, C_STL_GRD_TYPE, C_STL_GRD, C_STD_CODE);
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            //this.gridView2.OptionsSelection.MultiSelect = true;
            //gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 取消排产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancle_pc_Click(object sender, EventArgs e)
        {
            int checknum = lst.Where(a => a.B_check).ToList().Count;
            if (DialogResult.Yes == MessageBox.Show("是否确认取消当前选中的计划？\r\n选中计划数："+ checknum.ToString(), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                WaitingFrom.ShowWait("系统正对订单进行确认处理，请稍候...");
                int res = 0;
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].B_check)
                    {
                        string C_ID = lst[i].C_ORDER_NO;
                        bool result = Cls_APS_PC.CancleOrder(lst[i].C_ID);
                        if (result)
                        {
                            res = res + 1;
                        }
                    }
                }
                WaitingFrom.CloseWait();
                MessageBox.Show("成功取消计划数："+res.ToString());
                
            }

            btn_query_order_Click(null, null);
        }

        private void btn_calcle_pj_Click(object sender, EventArgs e)
        {
            int selectnum = lst.Where(a => a.B_check).ToList().Count;//选中的行数
            int updatenum = 0;//修改成功的行数
            if (selectnum == 0)
            {
                MessageBox.Show("请选择需要取消评价的订单！");
                return;
            }

          
            if (DialogResult.Yes == MessageBox.Show("是否将取消已评价的订单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                WaitingFrom.ShowWait("系统正在对订单进行修改，请稍候...");
                if (lst.Count > 0)
                {
                    if (selectnum > 0)
                    {
                        for (int i = 0; i < lst.Count; i++)
                        {
                            if (lst[i].B_check&&lst[i].N_ROLL_PROD_WGT==0)
                            {
                                string C_ID = lst[i].C_ID;
                                Mod_TMO_ORDER mod = bll_order.GetModel(C_ID);
                                mod.C_SFPJ = "N";
                                mod.D_PJ_DATE = null;
                                mod.D_SC_MOD_DT = RV.UI.ServerTime.timeNow();
                                bll_order.Update(mod);
                                updatenum = updatenum + 1;

                                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                                modlog.C_ORDER_NO = lst[i].C_ORDER_NO;
                                modlog.C_TYPE = "取消评价";
                                modlog.C_RESULT = "订单已取消评价！";
                                modlog.C_MSG = "取消评价！";
                                bll_ddpj.Add(modlog);
                            }
                        }
                    }
                }
                MessageBox.Show("选中"+ selectnum.ToString()+ "条订单取消评价，执行成功"+ updatenum + "条订单！");
                btn_query_order_Click(null, null);
                WaitingFrom.CloseWait();
            }
        }


        private void gv_tmo_order_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            int index = gv_tmo_order.FocusedRowHandle;
            double NWGT = Convert.ToDouble(gv_tmo_order.GetRowCellValue(index, "N_WGT"));
            double N_PROD_WGT = Convert.ToDouble(gv_tmo_order.GetRowCellValue(index, "N_PROD_WGT"));
            //this.txt_wgt.Text = (NWGT - N_PROD_WGT).ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].B_check == true)
                {
                    MessageBox.Show(i.ToString());
                }
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
        private bool m_checkStatus = false;


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

        private void gv_tmo_order_Click(object sender, EventArgs e)
        {
            if (ClickGridCheckBox(gv_tmo_order, "B_check", m_checkStatus))
            {
                m_checkStatus = !m_checkStatus;
            }
        }

        private void gv_tmo_order_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null && e.Column.FieldName == "B_check")
            {
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                DrawCheckBox(e, m_checkStatus);
                e.Handled = true;
            }
        }

        private void rbtn_sfqr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rbtn_sfqr.SelectedIndex == 1)
            {
                btn_pc.Enabled = true;

            }
            else
            {
                btn_pc.Enabled = false;

            }

            if (this.rbtn_sfqr.SelectedIndex == 2)
            {

                btn_cancle_pc.Enabled = true;
            }
            else
            {

                btn_cancle_pc.Enabled = false;
            }
        }

        private void btn_OutToExcel2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl1, "标准维护数据-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void FrmPO_APS_OrderPJ_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            dtp_form1.Text = Cls_Order_PC.GetDXFristDay()[0];
            this.dtp_end1.Text = Cls_Order_PC.GetDXFristDay()[1];
            

            CommonSub.BindIcbo("", "ZX", icbo_line, "Y");
            CommonSub.BindIcboNoAll("", "ZX", icbo_line2);
            BindSpec();
            icbo_line.SelectedIndex = 0;
            icbo_line2.SelectedIndex = 0;
            rbtn_sfqr.SelectedIndex = 0;
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

        private void btn_close_order_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("是否确认关闭所选中的订单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                #region 方法
                WaitingFrom.ShowWait("");
                if (lst.Count > 0)
                {
                    if (lst.Where(a => a.B_check).ToList().Count > 0)
                    {
                        for (int i = 0; i < lst.Count; i++)
                        {
                            if (lst[i].B_check)
                            {
                                lst[i].N_EXEC_STATUS = 8;//订单关闭
                                lst[i].D_SC_MOD_DT = RV.UI.ServerTime.timeNow();
                                bll_order.Update(lst[i]);

                                DataTable dtroll_plan = bll_trp_paln.GetListByOrderID(lst[i].C_ID).Tables[0];
                                if (dtroll_plan.Rows.Count > 0)
                                {
                                    for (int j = 0; j < dtroll_plan.Rows.Count; j++)
                                    {
                                        Mod_TRP_PLAN_ROLL modtrp_roll = bll_trp_paln.GetModel(dtroll_plan.Rows[j]["C_ID"].ToString());
                                        modtrp_roll.N_STATUS = 2;
                                        bll_trp_paln.Update(modtrp_roll);
                                    }
                                }


                                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                                modlog.C_ORDER_NO = lst[i].C_ORDER_NO;
                                modlog.C_TYPE = "订单关闭";
                                modlog.C_RESULT = "订单已关闭！";
                                modlog.C_MSG = "订单已关闭！";
                                bll_ddpj.Add(modlog);
                            }
                        }

                    }
                }
                WaitingFrom.CloseWait();
                #endregion

            }

            btn_query_order_Click(null, null);
        }

        private void btn_change_date_Click(object sender, EventArgs e)
        {
            if (this.dtp_d_plan_date.Text.Trim() == "" || this.dtp_d_need_date.Text.Trim() == "")
            {
                MessageBox.Show("请输入要修改的日期！");
                this.dtp_d_plan_date.Focus();
                return;
            }
          string cou=  lst.Where(a => a.B_check).ToList().Count.ToString();
            if (DialogResult.Yes == MessageBox.Show("是否确认修改选中订单的计划日期和需求日期？\r\n选中订单数量："+cou+" 条！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {

                int updatenum = 0;
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
                                string strdfrom = lst[i].D_PCTBTS.ToString();
                                string strdend = lst[i].D_NEED_DT.ToString();
                                if (lst[i].D_OLD_DATE==null)
                                {
                                    lst[i].D_OLD_DATE = lst[i].D_PCTBTS;
                                }
                                if (lst[i].D_OLD_NEED_DATE==null)
                                {
                                    lst[i].D_OLD_NEED_DATE = lst[i].D_NEED_DT;
                                }
                                lst[i].D_PCTBTS = Convert.ToDateTime(this.dtp_d_plan_date.Text);
                                lst[i].D_NEED_DT = Convert.ToDateTime(this.dtp_d_need_date.Text);
                                lst[i].D_SC_MOD_DT = RV.UI.ServerTime.timeNow();
                               bll_order.Update(lst[i]);

                                DataTable dtroll_plan = bll_trp_paln.GetListByOrderID(lst[i].C_ID).Tables[0];
                                if (dtroll_plan.Rows.Count > 0)
                                {
                                    for (int j = 0; j < dtroll_plan.Rows.Count; j++)
                                    {
                                        Mod_TRP_PLAN_ROLL modtrp_roll = bll_trp_paln.GetModel(dtroll_plan.Rows[j]["C_ID"].ToString());
                                        modtrp_roll.D_DT = Convert.ToDateTime(this.dtp_d_plan_date.Text);
                                        modtrp_roll.D_NEED_DT = Convert.ToDateTime(this.dtp_d_need_date.Text);
                                        bll_trp_paln.Update(modtrp_roll);
                                    }
                                }
                                DataTable dtroll_item = bll_trp_plan_item.GetListByOrderID(lst[i].C_ID);
                                if (dtroll_item.Rows.Count > 0)
                                {
                                    for (int j = 0; j < dtroll_item.Rows.Count; j++)
                                    {
                                        Mod_TRP_PLAN_ROLL_ITEM modtrp_roll_item = bll_trp_plan_item.GetModel(dtroll_item.Rows[j]["C_ID"].ToString());
                                        modtrp_roll_item.D_DT = Convert.ToDateTime(this.dtp_d_plan_date.Text);
                                        modtrp_roll_item.D_NEED_DT = Convert.ToDateTime(this.dtp_d_need_date.Text);
                                        bll_trp_plan_item.Update(modtrp_roll_item);
                                    }
                                }
                                updatenum = updatenum + 1;
                                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                                modlog.C_ORDER_NO = lst[i].C_ORDER_NO;
                                modlog.C_TYPE = "调整计划日期";
                                modlog.C_RESULT = "调整计划日期到：" + lst[i].D_PCTBTS.ToString() + "；调整计划需求日期到：" + lst[i].D_NEED_DT.ToString();
                                modlog.C_MSG = "计划原日期：" + strdfrom + "；计划原需求日期：" + strdend;
                                bll_ddpj.Add(modlog);
                            }
                        }

                    }
                    MessageBox.Show("调整成功："+ updatenum.ToString()+"！");
                }
                WaitingFrom.CloseWait();
                #endregion

            }

            btn_query_order_Click(null, null);
        }

        private void btn_change_line_Click(object sender, EventArgs e)
        {
            if (this.icbo_line2.SelectedIndex<0)
            {
                MessageBox.Show("请选择要调整的产线！");
                this.dtp_d_plan_date.Focus();
                return;
            }
            int slsctcou = lst.Where(a => a.B_check).ToList().Count;

            if (DialogResult.Yes == MessageBox.Show("您当前选中"+ slsctcou.ToString()+ "条订单，\r\n是否确认将选中的订单调整到 "+ this.icbo_line2.Properties.Items[this.icbo_line2.SelectedIndex].Description.ToString() + " ？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {

                Mod_TB_STA modsta = bll_sta.GetModel(this.icbo_line2.Properties.Items[this.icbo_line2.SelectedIndex].Value.ToString());
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
                                string oldline = lst[i].C_ROLL_DESC;
                                lst[i].C_LINE_NO = modsta.C_ID;
                                lst[i].C_ROLL_CODE = modsta.C_STA_CODE;
                                lst[i].C_ROLL_DESC = modsta.C_STA_DESC;
                                lst[i].D_SC_MOD_DT = RV.UI.ServerTime.timeNow();
                                bll_order.Update(lst[i]);

                                DataTable dtroll_plan = bll_trp_paln.GetListByOrderID(lst[i].C_ID).Tables[0];
                                if (dtroll_plan.Rows.Count > 0)
                                {
                                    for (int j = 0; j < dtroll_plan.Rows.Count; j++)
                                    {
                                        Mod_TRP_PLAN_ROLL modtrp_roll = bll_trp_paln.GetModel(dtroll_plan.Rows[j]["C_ID"].ToString());
                                        modtrp_roll.C_STA_ID = modsta.C_ID;
                                        modtrp_roll.C_LINE_CODE = modsta.C_STA_CODE;
                                        modtrp_roll.C_LINE_DESC = modsta.C_STA_DESC;
                                        bll_trp_paln.Update(modtrp_roll);
                                    }
                                }
                             
                                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                                modlog.C_ORDER_NO = lst[i].C_ORDER_NO;
                                modlog.C_TYPE = "调整计划产线";
                                modlog.C_RESULT = "调整计划产线["+ oldline + "=>" + lst[i].C_ROLL_DESC.ToString()+"]";
                                modlog.C_MSG = "计划产线调整！";
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

        /// <summary>
        /// 取消订单完工
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_caldel_wg_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否确认将选中的订单取消关闭？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                #region 方法
                WaitingFrom.ShowWait("");
                if (lst.Count > 0)
                {
                    if (lst.Where(a => a.B_check).ToList().Count > 0)
                    {
                        for (int i = 0; i < lst.Count; i++)
                        {
                            if (lst[i].B_check && lst[i].N_EXEC_STATUS ==5)
                            {
                                lst[i].N_EXEC_STATUS = 0;
                                lst[i].D_SC_MOD_DT = RV.UI.ServerTime.timeNow();
                                bll_order.Update(lst[i]);

                                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                                modlog.C_ORDER_NO = lst[i].C_ORDER_NO;
                                modlog.C_TYPE = "取消关闭";
                                modlog.C_RESULT = "订单已取消关闭！";
                                modlog.C_MSG = "订单已取消关闭！";
                                bll_ddpj.Add(modlog);
                            }
                        }

                    }
                }
                WaitingFrom.CloseWait();
                #endregion

            }

            btn_query_order_Click(null, null);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("是否确认所选中的订单完工？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                #region 方法
                WaitingFrom.ShowWait("");
                if (lst.Count > 0)
                {
                    if (lst.Where(a => a.B_check).ToList().Count > 0)
                    {
                        for (int i = 0; i < lst.Count; i++)
                        {
                            if (lst[i].B_check)
                            {
                               // Cls_Order_PC.UpdateOrderMatral(lst[i]);
                            }
                        }

                    }
                }
                WaitingFrom.CloseWait();
                #endregion

            }
           
        }
        private static Bll_TPB_STEEL_PRO_CONDITION bll_sctj = new Bll_TPB_STEEL_PRO_CONDITION();//钢种生产条件
        private Bll_TRP_PLAN_ROLL bll_plan_roll = new Bll_TRP_PLAN_ROLL();
        private Bll_TSP_PLAN_SMS bll_plan_sms = new Bll_TSP_PLAN_SMS();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            List<Mod_TMO_ORDER> list = bll_order.GetModelList(" N_STATUS=2 AND N_EXEC_STATUS IN (0,1,2)");//
            for (int i = 0; i < list.Count; i++)
            {
                DataTable dtsctj = bll_sctj.GetSCTJ(list[i].C_STL_GRD_SLAB, list[i].C_STD_CODE_SLAB);
                if (dtsctj.Rows.Count > 0)
                {
                    list[i].C_STL_GRD_TYPE = dtsctj.Rows[0]["C_STL_GRD_TYPE"].ToString();//钢种类别
                    list[i].N_GROUP = Convert.ToDecimal(dtsctj.Rows[0]["N_GROUP"].ToString());//自由项2
                }
                // list[i].C_REMARK5 = Cls_Order_PC.GetReplaceSlab(list[i].C_STL_GRD,list[i].C_STD_CODE);
                bll_order.Update(list[i]);
            }

            List<Mod_TRP_PLAN_ROLL> listtrp = bll_trp_paln.GetModelList("");
            for (int i = 0; i < listtrp.Count; i++)
            {
                DataTable dtsctj = bll_sctj.GetSCTJ(listtrp[i].C_STL_GRD_SLAB, listtrp[i].C_STD_CODE_SLAB);
                if (dtsctj.Rows.Count > 0)
                {
                    listtrp[i].C_STL_GRD_TYPE = dtsctj.Rows[0]["C_STL_GRD_TYPE"].ToString();//钢种类别
                    listtrp[i].N_GROUP = Convert.ToDecimal(dtsctj.Rows[0]["N_GROUP"].ToString());//自由项2
                }
                // list[i].C_REMARK5 = Cls_Order_PC.GetReplaceSlab(list[i].C_STL_GRD,list[i].C_STD_CODE);
                bll_trp_paln.Update(listtrp[i]);
            }

            List<Mod_TSP_PLAN_SMS> lsisms = bll_plan_sms.GetModelList("");
            for (int i = 0; i < lsisms.Count; i++)
            {
                DataTable dtsctj = bll_sctj.GetSCTJ(lsisms[i].C_STL_GRD, lsisms[i].C_STD_CODE);
                if (dtsctj.Rows.Count > 0)
                {

                    lsisms[i].N_GROUP = Convert.ToDecimal(dtsctj.Rows[0]["N_GROUP"].ToString());//自由项2
                }
                // list[i].C_REMARK5 = Cls_Order_PC.GetReplaceSlab(list[i].C_STL_GRD,list[i].C_STD_CODE);
                bll_plan_sms.Update(lsisms[i]);
            }
        }
    }
}
