using BLL;
using Common;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace XGCAP.UI.P.PP
{
    public partial class FrmPP_HJXQTJ : Form
    {
        public FrmPP_HJXQTJ()
        {
            InitializeComponent();
        }
        Bll_TPP_HJXQ bll_TPP_HJXQ = new Bll_TPP_HJXQ();
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void FrmPP_HJXQTJ_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.ToString("yyyy-MM-1") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.AddMonths(1).ToString("yyyy-MM-1") + DateTime.Now.ToString(" 00:00:00");
            Query();
        }
        private void Query()
        {

            WaitingFrom.ShowWait("");
            DataTable dt = null;
            dt = bll_TPP_HJXQ.GetList(txt_name.Text.Trim(),dt_Start.DateTime,dt_End.DateTime).Tables[0];
            this.gc_HG.DataSource = dt;
            this.gv_HG.OptionsView.ColumnAutoWidth = false;
            this.gv_HG.OptionsSelection.MultiSelect = true;
            gv_HG.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gv_HG);
            WaitingFrom.CloseWait();

        }

        private void btn_DC_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_HG);
        }

        private void gv_HG_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
           
        }

        private void gv_HG_Click(object sender, EventArgs e)
        {
            try
            {
                int row = gv_HG.FocusedRowHandle;
                DataRow dr = gv_HG.GetDataRow(row);
                DataTable dt = null;
                dt = bll_TPP_HJXQ.GetXQList(dr["c_alloy_code"].ToString(), dt_Start.DateTime, dt_End.DateTime).Tables[0];
                this.gc_XQ.DataSource = dt;
                this.gv_XQ.OptionsView.ColumnAutoWidth = false;
                this.gv_XQ.OptionsSelection.MultiSelect = true;
                gv_XQ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                SetGridViewRowNum.SetRowNum(gv_XQ);
         
            }
            catch(Exception ex)
            {

            }
        }

        private void gv_HG_RowStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                //T.C_IS_DECIDE,T.C_IS_SHOW c_value
                decimal N_NEED_WGT = Convert.ToDecimal(gv_HG.GetRowCellValue(e.RowHandle, "N_NEED_WGT"));
                decimal N_ALLOY_WGT = Convert.ToDecimal(gv_HG.GetRowCellValue(e.RowHandle, "N_ALLOY_WGT"));
                if (N_NEED_WGT > N_ALLOY_WGT)
                {
                    e.Appearance.BackColor = Color.Red;
                }


            }
            catch
            {

            }
        }
    }
}
