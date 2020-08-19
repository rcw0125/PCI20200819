using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_Allot_CCM : Form
    {
        public FrmPO_Allot_CCM()
        {
            InitializeComponent();
        }

        private void FrmPO_Allot_CCM_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }
    }
}
