using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using BLL;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_TWLDD_ADD : Form
    {
        public FrmPO_TWLDD_ADD()
        {
            InitializeComponent();

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
        public string str_MatCode = "";
        public string str_MatName = "";
        public string str_STLGRD = "";
        public string str_STD = "";
        public string str_Spec = "";
        public string str_ZYX1 = "";
        public string str_ZYX2 = "";

        Bll_TB_MATRL_MAIN bll_Matrl = new Bll_TB_MATRL_MAIN();
        private void FrmPO_TWLDD_ADD_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Mat.Text.Trim()=="" && txt_GZ.Text.Trim()=="" && txt_STD.Text.Trim()=="")
                {
                    MessageBox.Show("请输入查询条件再进行查询！");
                    return;
                }
                WaitingFrom.ShowWait("");
                DataTable dt = bll_Matrl.GetGP_StlGrd(txt_Mat.Text.Trim(),txt_GZ.Text.Trim(), txt_STD.Text.Trim()).Tables[0];
                gc_Main.DataSource = dt;
                gv_Main.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Main);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 确认
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
        /// <summary>
        /// 回传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Main_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_Main.GetDataRow(gv_Main.FocusedRowHandle);
                if (dr == null) return;
                str_MatCode = dr["C_MAT_CODE"].ToString();
                str_MatName = dr["C_MAT_NAME"].ToString();
                str_Spec = dr["C_SLAB_SIZE"].ToString();
                str_STD = dr["C_STD_CODE"].ToString();
                str_STLGRD = dr["C_STL_GRD"].ToString();
                str_ZYX1 = dr["C_ZYX1"].ToString();
                str_ZYX2 = dr["C_ZYX2"].ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 双击确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Main_DoubleClick(object sender, EventArgs e)
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
    }
}
