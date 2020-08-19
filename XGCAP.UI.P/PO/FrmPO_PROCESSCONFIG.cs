using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_PROCESSCONFIG : Form
    {
        public FrmPO_PROCESSCONFIG()
        {
            InitializeComponent();
        }

        private void FrmPO_PROCESSCONFIG_Load(object sender, EventArgs e)
        {
            txt_ccm_dfphl.Text = ConfigurationManager.AppSettings.Get("ccm_dfphl");
            txt_dfphl_kp.Text = ConfigurationManager.AppSettings.Get("dfphl_kp");
            txt_kp_hl.Text = ConfigurationManager.AppSettings.Get("kp_hl");
            txt_hl_xm.Text = ConfigurationManager.AppSettings.Get("hl_xm");
            txt_ccm_kp.Text = ConfigurationManager.AppSettings.Get("ccm_kp");
            txt_kp_xm.Text = ConfigurationManager.AppSettings.Get("kp_xm");
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save2_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings.Set("ccm_dfphl", txt_ccm_dfphl.Text);
            ConfigurationManager.AppSettings.Set("dfphl_kp", txt_dfphl_kp.Text);
            ConfigurationManager.AppSettings.Set("kp_hl", txt_kp_hl.Text);
            ConfigurationManager.AppSettings.Set("hl_xm", txt_hl_xm.Text);
            ConfigurationManager.AppSettings.Set("ccm_kp", txt_ccm_kp.Text);
            ConfigurationManager.AppSettings.Set("kp_xm", txt_kp_xm.Text);
            MessageBox.Show("保存成功");
            this.Close();
        }
    }
}
