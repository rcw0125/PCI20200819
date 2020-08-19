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
namespace XGCAP.UI.Q.QR
{
    /// <summary>
    /// 2018-05-09 zmc
    /// </summary>
    public partial class FrmQR_GPBMPDCX : Form
    {
        public FrmQR_GPBMPDCX()
        {
            InitializeComponent();
        }

        Bll_TQC_FACE_SLAB bll_face_slab = new Bll_TQC_FACE_SLAB();

        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC_GPBMPD_Load(object sender, EventArgs e)
        {
            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
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
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                string stove = txt_Stove.Text;
                DataTable dt = bll_face_slab.GetList_Stove1(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), stove).Tables[0];
                this.gc_PDJG.DataSource = dt;
                gv_PDJG.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_PDJG);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
