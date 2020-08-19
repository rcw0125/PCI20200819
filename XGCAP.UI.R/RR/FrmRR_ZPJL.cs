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
    public partial class FrmRR_ZPJL : Form
    {
        public FrmRR_ZPJL()
        {
            InitializeComponent();
        }

        Bll_TRC_ROLL_MAIN bll_TRC_ROLL_MAIN = new Bll_TRC_ROLL_MAIN();

        private void btn_AllowGrdQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Stove.Text))
            {
                MessageBox.Show("请输入炉/开坯/轧钢 号查询");
                return;
            }

            string whereSql = " AND ( TRM.C_STOVE like '%" + txt_Stove.Text + "%' or  TRM.C_BATCH_NO like '%" + txt_Stove.Text + "%'  or  TRM.C_PLANT like '%" + txt_Stove.Text + "%' ) ";
            DataTable dt = bll_TRC_ROLL_MAIN.GetListMain(whereSql, false).Tables[0];
            this.gc_ZGZPSJ.DataSource = dt;
            this.gv_ZGZPSJ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_ZGZPSJ);
        }
    }
}
