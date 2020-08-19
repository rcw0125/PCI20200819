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

namespace XGCAP.UI.P.PO
{
    public partial class Frm_Order_Manger : Form
    {
        public Frm_Order_Manger()
        {
            InitializeComponent();
        }
        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();

        private void btn_query_order_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
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

            string strJQMin = this.dtp_form1.EditValue == null ? "" : this.dtp_form1.EditValue.ToString();
            string strJQMax = this.dtp_end1.EditValue == null ? "" : this.dtp_end1.EditValue.ToString();
            DataTable dtOrder = bll_order.GetListByWhere1("", this.txt_hth.Text.Trim(), this.txt_gz1.Text.Trim(), this.txt_zxbz1.Text.Trim(), gg_min, gg_max, "", "", dtp_form1.Text+" 00:00:01", dtp_end1.Text+" 23:59:59").Tables[0];

            this.gc_tmo_order.DataSource = dtOrder;
            this.gv_tmo_order.OptionsView.ColumnAutoWidth = false;
            this.gv_tmo_order.OptionsSelection.MultiSelect = true;
            gv_tmo_order.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gv_tmo_order);
            this.gv_tmo_order.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void Frm_Order_Manger_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            dtp_form1.Text = System.DateTime.Now.ToShortDateString();
            dtp_end1.Text =bll_order.GetMaxJQ("");
            CommonSub.BindIcbo("", "ZX", icbo_zx1);
            CommonSub.BindIcbo("", "CC", icbo_lz1);
           
        }

        private void btn_order_pj1_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            string res = bll_order.ManageOrder();
            MessageBox.Show(res);
            btn_query_order_Click(null, null);
           
            WaitingFrom.CloseWait();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_tmo_order);
        }
    }
}
