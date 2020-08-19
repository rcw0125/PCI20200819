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

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_SELECT_ZXBZ : Form
    {
        private Bll_TQB_STD_MAIN bllStdMain = new Bll_TQB_STD_MAIN();

        public string str_STD_ID = "";
        public string str_STD = "";
        public string str_GRD = "";
        string strPhyCode="";
        public FrmQB_SELECT_ZXBZ(string str_id)
        {
            InitializeComponent();
            strPhyCode = str_id;
        }

        private void FrmQB_SELECT_ZXBZ_Load(object sender, EventArgs e)
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
                WaitingFrom.ShowWait("");
                DataTable dt = bllStdMain.GetList_GPDC(strPhyCode,"全部",txt_Std.Text.Trim(), txt_Grd.Text.Trim()).Tables[0];

                gc_StdMain.DataSource = dt;
                gv_StdMain.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_StdMain);
                WaitingFrom.CloseWait();
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

        private void gv_StdMain_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
                if (dr == null) return;
                str_STD_ID = dr["C_ID"].ToString();
                str_STD = dr["C_STD_CODE"].ToString();
                str_GRD = dr["C_STL_GRD"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 双击执行标准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_StdMain_DoubleClick(object sender, EventArgs e)
        {
            btn_OK_Click(null,null);
        }
    }
}
