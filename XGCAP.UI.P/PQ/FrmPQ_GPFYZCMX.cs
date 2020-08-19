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

namespace XGCAP.UI.P.PQ
{
    public partial class FrmPQ_GPFYZCMX : Form
    {
        public FrmPQ_GPFYZCMX()
        {
            InitializeComponent();
        }
        Bll_TMD_DISPATCH bll_TMD_DISPATCH = new Bll_TMD_DISPATCH();

        private void btn_Query_Click_1(object sender, EventArgs e)
        {
            FYDQuery();
        }
        public void FYDQuery()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TMD_DISPATCH.GetCPH(2, txt_CPH.Text).Tables[0];
                this.gc_GP.DataSource = dt;
                this.gv_GP.OptionsView.ColumnAutoWidth = false;
                this.gv_GP.OptionsSelection.MultiSelect = true;
                gv_GP.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                //this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox(); //翻译工位
                this.gv_GP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gv_GP_Click(object sender, EventArgs e)
        {
            int selectedHandle = this.gv_GP.FocusedRowHandle;//获取焦点行索引
            string ckdh = gv_GP.GetRowCellValue(selectedHandle, "C_CKDH").ToString();
            DataTable dt = null;
            dt = bll_TMD_DISPATCH.GetCKByCKDH(2, ckdh).Tables[0];
            this.gc_BH.DataSource = dt;
            this.gv_BH.OptionsView.ColumnAutoWidth = false;
            this.gv_BH.OptionsSelection.MultiSelect = true;
            gv_BH.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_BH.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_BH);
        }
    }
}
