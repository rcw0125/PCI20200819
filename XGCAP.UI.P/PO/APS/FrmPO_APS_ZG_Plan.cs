using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APS_ZG_Plan : Form
    {
        public FrmPO_APS_ZG_Plan()
        {
            InitializeComponent();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {

        }

        private void FrmPO_APS_ZG_Plan_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }
    }
}
