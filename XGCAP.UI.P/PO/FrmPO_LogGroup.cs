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

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_LogGroup : Form
    {
        public FrmPO_LogGroup()
        {
            InitializeComponent();
        }
        private Bll_TMO_ORDER_PJ_LOG bll_log = new Bll_TMO_ORDER_PJ_LOG();

        private void btn_query_Click(object sender, EventArgs e)
        {
            if (this.cbo_type.Text.Trim()=="")
            {
                return;
            }
            DataTable dt = bll_log.GetWPJ(this.cbo_type.Text).Tables[0];
            this.gridControl1.DataSource = dt;
            this.gridControl1.MainView = gridView1;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
        }
        /// <summary>
        /// 加载类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPO_LogGroup_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            DataTable dt = bll_log.GetLX().Tables[0];

            if (dt.Rows.Count>0)
            {
                cbo_type.Properties.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.cbo_type.Properties.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_to_excel_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( gridControl1);
        }
    }
}
