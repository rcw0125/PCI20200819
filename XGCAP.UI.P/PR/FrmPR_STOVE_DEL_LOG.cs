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

namespace XGCAP.UI.P.PR
{
    public partial class FrmPR_STOVE_DEL_LOG : Form
    {
        private Bll_TSC_SLAB_MES_LOG bllLog = new Bll_TSC_SLAB_MES_LOG();

        public FrmPR_STOVE_DEL_LOG()
        {
            InitializeComponent();
        }

        private void FrmPR_STOVE_DEL_LOG_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bllLog.Get_List(txt_BatchNo.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim()).Tables[0];

                gc_Log.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Log);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
