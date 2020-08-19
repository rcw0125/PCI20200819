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

namespace XGCAP.UI.R.TM
{
    public partial class FrmFR_TMKCPD : Form
    {
        public FrmFR_TMKCPD()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_TRC_ROLL_PRODCUT = new Bll_TRC_ROLL_PRODCUT();
        Bll_Interface_FR bll_Interface_FR = new Bll_Interface_FR();
        private void btn_TB_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
          bll_Interface_FR.TbKCList("","","","","","","");
           // bll_Interface_FR.TbPCIList();
            WaitingFrom.CloseWait();
        }

        private void FrmFR_TMKCPD_Load(object sender, EventArgs e)
        {
            Query();
        }
        private void Query()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TRC_ROLL_PRODCUT.GetTMM().Tables[0];
                this.gc_PCI.DataSource = dt;
                this.gv_PCI.OptionsView.ColumnAutoWidth = false;
                this.gv_PCI.OptionsSelection.MultiSelect = true;
                gv_PCI.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.gv_PCI.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_PCI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void TMQuery()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TRC_ROLL_PRODCUT.GetPCIM().Tables[0];
                this.gc_PCI.DataSource = dt;
                this.gv_PCI.OptionsView.ColumnAutoWidth = false;
                this.gv_PCI.OptionsSelection.MultiSelect = true;
                gv_PCI.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.gv_PCI.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_PCI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bll_Interface_FR.TbPCIList();
        }

        private void btn_TBWWC_Click(object sender, EventArgs e)
        {
            bll_Interface_FR.TbWWList();
        }
    }
}
