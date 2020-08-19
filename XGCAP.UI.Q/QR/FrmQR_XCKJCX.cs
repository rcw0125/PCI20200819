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
using Common;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_XCKJCX : Form
    {
        public FrmQR_XCKJCX()
        {
            InitializeComponent();
        }
        Bll_TQC_ROOL_CHECK_AFFIRM bll_we_check_roll = new Bll_TQC_ROOL_CHECK_AFFIRM();

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (this.rbtn_isty_wh.SelectedIndex == 0)//未确认 查询
                {
                    dt = bll_we_check_roll.GetList_Query(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_BatchNo1.Text).Tables[0];
                }
                else//已确认
                {
                    dt = bll_we_check_roll.GetList_Query1(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_BatchNo1.Text).Tables[0];
                }
                gc_PDJG.DataSource = dt;
                gv_PDJG.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_PDJG);
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
        private void FrmQC_XCKJQR_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

    }
}
