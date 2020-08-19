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
using DevExpress.XtraEditors.Controls;
using Common;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_XCSJ : Form
    {
        /// <summary>
        /// 2018-05-03 zmc
        /// </summary>
        public FrmQR_XCSJ()
        {
            InitializeComponent();
        }

        Bll_TB_STA bll_sta = new Bll_TB_STA();
        Bll_TRC_ROLL_PRODCUT bll = new Bll_TRC_ROLL_PRODCUT();
        private void FrmQC001_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            DataSet dt_sta = bll_sta.GetList("");
            imgcbo_CJ.Properties.Items.Clear();
            imgcbo_CJ.Properties.Items.Add("全部", "全部", -1);
            foreach (DataRow item in dt_sta.Tables[0].Rows)// 
            {
                imgcbo_CJ.Properties.Items.Add(item["C_STA_DESC"].ToString(), item["C_ID"], -1);
            }
            imgcbo_CJ.SelectedIndex = 0;
        }

        /// <summary>
        /// 判定结果查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_PDJG.DataSource = null;

                DataTable dt = bll.GetList_Query1(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), imgcbo_CJ.Text, txt_BatchNo1.Text.Trim(), txt_STL.Text.Trim(), txt_STD.Text.Trim()).Tables[0];

                this.gc_PDJG.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_PDJG);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DC_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_PDJG);
        }

        private void gv_PDJG_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_PDJG.GetDataRow(e.FocusedRowHandle);

                if (dr != null)
                {
                    DataTable dt = bll.Get_List_Details(dr["C_BATCH_NO"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_STD_CODE"].ToString(), dr["C_JUDGE_LEV_BP"].ToString(), dr["C_JUDGE_LEV_ZH"].ToString(), dr["C_MAT_CODE"].ToString()).Tables[0];

                    gc_Sj.DataSource = dt;
                    SetGridViewRowNum.SetRowNum(gv_Sj);
                }
                else
                {
                    gc_Sj.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
