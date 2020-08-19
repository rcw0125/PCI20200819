using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PB
{
    public partial class FrmOutTable : Form
    {
        public FrmOutTable()
        {
            InitializeComponent();
        }
        Bll_Common bll_com = new Bll_Common();
        private void btn_query_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            DataTable dt = bll_com.bind();
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            //SetGridViewRowNum.SetRowNum(gridView1);
            WaitingFrom.CloseWait();
        }

        private void btn_outExcel_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl1, "数据库表结构" + System.DateTime.Now.ToLongTimeString());
        }
    }
}
