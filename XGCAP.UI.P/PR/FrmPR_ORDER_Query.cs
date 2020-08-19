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
using DevExpress.XtraEditors.Controls;
using XGCAP.UI.P.PO;

namespace XGCAP.UI.P.PR
{
    public partial class FrmPR_ORDER_Query : Form
    {
        public FrmPR_ORDER_Query()
        {
            InitializeComponent();
        }
        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();
        private Bll_TRP_PLAN_ROLL bllTrpPlanRoll = new Bll_TRP_PLAN_ROLL();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPR_ORDER_Query_Load(object sender, EventArgs e)
        {
          
            dte_Begin.EditValue = Cls_Order_PC.GetDXFristDay()[0];
            dte_End.EditValue = Cls_Order_PC.GetDXFristDay()[1];
            CommonSub.BindIcbo("", "ZX", icbo_line, "Y");
            icbo_line.SelectedIndex = 0;

            BindSpec();
        }

        /// <summary>
        /// 加载线材计划查询的规格
        /// </summary>
        public void BindSpec()
        {
            DataTable dt = bllTrpPlanRoll.Get_Spec().Tables[0];
            this.txt_gg_min.Properties.Items.Clear();

            CheckedListBoxItem[] itemListQuery = new CheckedListBoxItem[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                itemListQuery[i] = new CheckedListBoxItem(dt.Rows[i]["C_SPEC"].ToString(), dt.Rows[i]["C_SPEC"].ToString());
            }
            this.txt_gg_min.Properties.Items.AddRange(itemListQuery);
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
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

                string c_line_no = "";
                if (icbo_line.SelectedIndex >= 0)
                {
                    c_line_no = icbo_line.Properties.Items[icbo_line.SelectedIndex].Value.ToString();
                }
                string c_type = "";
                if (rbtn_type.SelectedIndex>=1)
                {
                    c_type = rbtn_type.Properties.Items[this.rbtn_type.SelectedIndex].Description;
                }
                DataTable dt = bll_order.GetPlanZX_Query(dte_Begin.DateTime, dte_End.DateTime, txt_gz1.Text.Trim(), txt_zxbz1.Text.Trim(), txt_gg_min.Text.Trim(), "", txt_order_no.Text.Trim(), C_SFPJ, sfwc, n_sfqr, c_line_no, c_type);
                this.gridControl1.DataSource = dt;
                this.gridView1.OptionsView.ColumnAutoWidth = false;
                this.gridView1.OptionsSelection.MultiSelect = true; 
                SetGridViewRowNum.SetRowNum(gridView1);
                this.gridView1.BestFitColumns();
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_OutToExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl1, "线材订单执行情况查询" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedHandle;
                selectedHandle = this.gridView1.FocusedRowHandle;
                string C_ID = this.gridView1.GetRowCellValue(selectedHandle, "计划订单号").ToString();

                DataTable dt = bllTrpPlanRoll.GetOrderProInfoByOrderNo(C_ID);
                this.gridControl2.DataSource = dt;
                this.gridView2.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gridView2);
                this.gridView2.BestFitColumns();
            }
            catch (Exception)
            {

                
            }
            
        }
    }
}
