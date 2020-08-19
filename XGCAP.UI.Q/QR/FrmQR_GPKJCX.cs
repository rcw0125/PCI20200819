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
    public partial class FrmQR_GPKJCX : Form
    {
        public FrmQR_GPKJCX()
        {
            InitializeComponent();
        }

        Bll_TQC_WE_CHECK_AFFIRM bll_affirm = new Bll_TQC_WE_CHECK_AFFIRM();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC_KJQR_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }
        /// <summary>
        /// 库检信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (this.rbtn_isty_wh.SelectedIndex == 0)//未确认 查询
                {
                    dt = bll_affirm.GetList_Query(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_Stove1.Text).Tables[0];
                }
                else//已确认
                {
                    dt = bll_affirm.GetList_Query1(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_Stove1.Text).Tables[0];
                }
                gc_GPKJ.DataSource = dt;
                gv_GPKJ.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
