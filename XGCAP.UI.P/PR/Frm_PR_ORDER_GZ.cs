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

namespace XGCAP.UI.P.PR
{
    public partial class Frm_PR_ORDER_GZ : Form
    {
        public Frm_PR_ORDER_GZ()
        {
            InitializeComponent();
        }
        private  Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();
        Bll_TRC_ROLL_MAIN bll_TRC_ROLL_MAIN = new Bll_TRC_ROLL_MAIN();
        private void btn_query_Click(object sender, EventArgs e)
        {
              
            if (this.dtp_form1.Text.Trim() == "" || this.dtp_end1.Text == "")
            {
                MessageBox.Show("请输入查询日期！");
                return;
            }
            WaitingFrom.ShowWait("订单正在加载，请稍后...");
            double? gg_min = null;//规格最小值
            if (this.txt_gg_min.Text.Trim() != "")
            {
                gg_min = Convert.ToDouble(this.txt_gg_min.Text.Trim());
            }
            double? gg_max = null;//规格最大值
            if (this.txt_gg_max.Text.Trim() != "" && Convert.ToDouble(this.txt_gg_max.Text.Trim()) > 0)
            {
                gg_max = Convert.ToDouble(this.txt_gg_max.Text.Trim());
            }
            string strJQMin = "";
            string strJQMax = "";
            string strDDMin = "";
            string strDDMax = "";
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

            DataTable dt = bll_order.GetPlanZX(C_SFPJ, sfwc, n_sfqr, this.txt_order_no.Text.Trim(), "", this.txt_gz1.Text.Trim(), this.txt_zxbz1.Text.Trim(), gg_min, gg_max, txt_wlmc.Text.Trim(), strJQMin, strJQMax, strDDMin, strDDMax,"all");  
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void btn_OutToExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl1,"线材订单执行情况查询"+System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            GetOrderRelationAsse();
        }
        private void GetOrderRelationAsse()
        {
            int selectedHandle = this.gridView1.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                return;
            }

            //获取焦点行钢种
            string id = this.gridView1.GetRowCellValue(selectedHandle, "订单号").ToString();
            string whereSql = " AND TRM.C_PLAN_ID  IN( SELECT T.C_ID FROM TRP_PLAN_ROLL_ITEM T  WHERE T.C_ORDER_NO='" + id + "') ";
            DataTable dt = bll_TRC_ROLL_MAIN.GetListMain(whereSql, false).Tables[0];
            this.gridControl2.DataSource = dt;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView2);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int selectedHandle = this.gridView1.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                return;
            }

            //获取焦点行钢种
            string id = this.gridView1.GetRowCellValue(selectedHandle, "订单号").ToString();
            string whereSql = " AND TRM.C_PLAN_ID  IN( SELECT T.C_ID FROM TRP_PLAN_ROLL_ITEM T  WHERE T.C_ORDER_NO='" + id + "') ";
            DataTable dt = bll_TRC_ROLL_MAIN.GetListMain(whereSql, false).Tables[0];
            this.gridControl2.DataSource = dt;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView2);
        }

        private void Frm_PR_ORDER_GZ_Load(object sender, EventArgs e)
        {

        }
    }
}
