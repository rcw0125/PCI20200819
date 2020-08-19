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
    public partial class Frm_PR_XCJHTJ : Form
    {
        public Frm_PR_XCJHTJ()
        {
            InitializeComponent();
        }

        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();
        private void btn_query_Click(object sender, EventArgs e)
        {
            if (dtp_from.Text.Trim()==""|| dtp_end.Text.Trim() == "")
            {
                MessageBox.Show("请输入查询日期！");
                return;
            }
            string dt1 =Convert.ToDateTime( dtp_from.Text).ToString("yyyy-MM-dd")+" 00:00:00";
            string dt2 =Convert.ToDateTime( dtp_end.Text).ToString("yyyy-MM-dd") + " 23:59:59";
            WaitingFrom.ShowWait("数据正在加载，请稍候...");
            DataTable dt = bll_order.GetXCTJ(dt1, dt2);
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void btn_OutToExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl1, "线材计划汇总" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void Frm_PR_XCJHTJ_Load(object sender, EventArgs e)
        {
            dtp_from.Text = System.DateTime.Now.AddDays(-1).ToShortDateString();
            dtp_end.Text = System.DateTime.Now.ToShortDateString();
        }
    }
}
