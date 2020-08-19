using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DevExpress.XtraScheduler;
using Common;

namespace XGCAP.UI.P.PQ
{
    public partial class FrmPB_XCKCX_OLD : Form
    {
        public FrmPB_XCKCX_OLD()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_TRC_ROLL_PRODCUT = new Bll_TRC_ROLL_PRODCUT();
        CommonSub commonSub = new CommonSub();
        private void FrmPB_XCKCX_Load(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindXCK(cbo_CK);
            cbo_CK.EditValue = 0;
        }
        private void cbo_CK_SelectedIndexChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindXCKQY(cbo_CK.EditValue.ToString(), cbo_QY);
            cbo_QY.EditValue = 0;
        }

        private void btn_QueryM_Click(object sender, EventArgs e)
        {

        }
    }
}
