using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL;
using RV.UI;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmChi : FrmPar
    {
        Bll_TQC_COMPRE_ITEM_RESULT bllItemResult = new Bll_TQC_COMPRE_ITEM_RESULT();

        public FrmChi()
        {
            InitializeComponent();
        }

        private void FrmChi_Load(object sender, EventArgs e)
        {
            BindList();
        }

        private void BindList()
        {
            DataTable dt = bllItemResult.GetList_CF_Name().Tables[0];

            gridControl1.DataSource = dt;
            gridView1.BestFitColumns();

            gridControl2.DataSource = dt;
            gridView2.BestFitColumns();
        }

    }
}
