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
using MODEL;

namespace XGCAP.UI.P.PB
{
    /// <summary>
    /// 2018-04-27 zmc
    /// </summary>
    public partial class FrmPB_SELECT_GZ : Form
    {
        string strPhyCode;
        public FrmPB_SELECT_GZ(string sys_id)
        {
            InitializeComponent();
            strPhyCode = sys_id;
        }
        public string str_c_id = "";
        public string str_c_grd = "";
        Bll_TQB_STD_MAIN bll = new Bll_TQB_STD_MAIN();
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bll.GetList_Type(txt_GRD.Text,strPhyCode).Tables[0];
                this.gc_StdMain.DataSource = dt;
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
        private void btn_Add_Click(object sender, EventArgs e)
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
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPB_SELECT_GZ_Load(object sender, EventArgs e)
        {   
            btn_Query_Click(null,null);
        }

        private void gv_StdMain_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
                if (dr == null) return;
                str_c_grd = dr["C_STL_GRD"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 双击获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_StdMain_DoubleClick(object sender, EventArgs e)
        {
            btn_Add_Click(null,null);
        }
    }   
}
