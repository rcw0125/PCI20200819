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

namespace XGCAP.UI.P.PQ
{
    public partial class FrmPQ_GPCKD : Form
    {
        public FrmPQ_GPCKD()
        {
            InitializeComponent();
        }
        Bll_TMD_DISPATCH bll_TMD_DISPATCH = new Bll_TMD_DISPATCH();
        private void FrmPQ_GPCKD_Load(object sender, EventArgs e)
        {
            FYDQuery();
        }
        private void btn_Query_Click(object sender, EventArgs e)
        {
            FYDQuery();
        }
        public void FYDQuery()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TMD_DISPATCH.GetCKDList(1,txt_CKD.Text,txt_CPH.Text,"").Tables[0];
                this.gc_GP.DataSource = dt;
                this.gv_GP.OptionsView.ColumnAutoWidth = false;
                this.gv_GP.OptionsSelection.MultiSelect = true;
                gv_GP.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.gv_GP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }
}
