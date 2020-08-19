using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.R.RP
{
    public partial class FrmRP_REPORT : Form
    {
        public FrmRP_REPORT()
        {
            InitializeComponent();
        }

        private void FrmRP_REPORT_Load(object sender, EventArgs e)
        {
            string strUrl = RV.UI.QueryString.parameter;

            strUrl = "http://192.168.2.93:8685/webroot/decision/view/report?viewlet=xgcap/" + strUrl + ".cpt&__bypagesize__=false";

            BindInfo(strUrl);
        }

        private void BindInfo(string strUrl)
        {
            webBrowser1.Navigate(new Uri(strUrl, UriKind.Absolute));
        }
    }
}
