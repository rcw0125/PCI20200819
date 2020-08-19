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


namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_Order_Initialize_log : Form
    {
        public FrmPO_Order_Initialize_log()
        {
            InitializeComponent();
        }
        DataTable dtquery = null;
        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();//销售订单
        public FrmPO_Order_Initialize_log(DataTable dt)
        {
            InitializeComponent();
            dtquery = dt;
            this.gridControl1.DataSource = dt;
            this.gridControl1.MainView = gridView1;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
        }
        /// <summary>
        /// 导出到EXCEL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( gridControl1);
        }

       

        private void FrmPO_Order_Initialize_log_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            DataTable dt = bll_order.GetListPJLOG().Tables[0];
            this.gridControl1.DataSource = dt;
            this.gridControl1.MainView = gridView1;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
        }
    }
}
