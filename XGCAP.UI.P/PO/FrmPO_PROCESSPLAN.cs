using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_PROCESSPLAN : Form
    {
        public FrmPO_PROCESSPLAN()
        {
            InitializeComponent();
        }

        private void btn_QueryNC_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("正在加载");
            Bll_PROCESS_PLAN plan = new Bll_PROCESS_PLAN();
            List<Mod_TSP_PLAN_SMS> models = new List<Mod_TSP_PLAN_SMS>();
            plan.ProcessSort(out models);
            gridControl1.DataSource = models;
            //plan.List();
            SetGridViewRowNum.SetRowNum(gridView1);
            WaitingFrom.CloseWait();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmPO_PROCESSCONFIG frm = new FrmPO_PROCESSCONFIG();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                frm.Close();
            }
        }
    }
}
