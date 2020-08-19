using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_TSXX_LOG : Form
    {
        Bll_TQC_SPECIFIC_CONTENT_LOG bllLog = new Bll_TQC_SPECIFIC_CONTENT_LOG();

        public FrmQR_TSXX_LOG()
        {
            InitializeComponent();
        }

        private void FrmQR_TSXX_LOG_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        private void btn_Query_ZY_CG_Click(object sender, EventArgs e)
        {
            BindList();
        }

        private void BindList()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bllLog.GetList(txt_Batch.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim()).Tables[0];

                gridControl1.DataSource = dt;

                SetGridViewRowNum.SetRowNum(gridView1);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
