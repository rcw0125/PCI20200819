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
    public partial class FrmPO_SELECT_WL : Form
    {
        private Bll_TB_SLAB_MATRAL bllTbSlabMatral = new Bll_TB_SLAB_MATRAL();

        public string str_MatCode = "";
        public string str_MatName = "";
        public string str_Spec = "";
        public string str_Len = "";
        public string str_Hsl = "";

        public FrmPO_SELECT_WL(string s_bz, string s_gz)
        {
            InitializeComponent();

            txt_Std.Text = s_bz;
            txt_Grd.Text = s_gz;
        }

        private void FrmPO_SELECT_WL_Load(object sender, EventArgs e)
        {
            BindList();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindList();
        }

        private void BindList()
        {
            try
            {
                DataTable dt = bllTbSlabMatral.Get_MatCode_List(txt_Grd.Text.Trim(), txt_Std.Text.Trim()).Tables[0];

                gc_StdMain.DataSource = dt;
                gv_StdMain.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_StdMain);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_StdMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
                if (dr == null) return;
                str_MatCode = dr["C_MATRAL_CODE"].ToString();
                str_MatName = dr["C_MAT_NAME"].ToString();
                str_Spec = dr["C_SLAB_SIZE"].ToString();
                str_Len = dr["N_LTH"].ToString();
                str_Hsl = dr["N_HSL"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
