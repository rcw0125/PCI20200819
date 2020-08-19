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

namespace XGCAP.UI.R.RR
{
    public partial class FrmRR_TCJL : Form
    {
        public FrmRR_TCJL()
        {
            InitializeComponent();
        }

        Bll_TRC_ROLL_MAIN bll_TRC_ROLL_MAIN = new Bll_TRC_ROLL_MAIN();

        private void btn_AllowGrdQuery_Click(object sender, EventArgs e)
        {
            DataTable dt = bll_TRC_ROLL_MAIN.GetTCJL(dt_Plan.DateTime);
            this.gc_ZGZPSJ.DataSource = dt;
            this.gv_ZGZPSJ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_ZGZPSJ);
        }

        private void FrmRR_TCJL_Load(object sender, EventArgs e)
        {
            dt_Plan.DateTime = DateTime.Now.AddMonths(-1);
        }
    }
}
