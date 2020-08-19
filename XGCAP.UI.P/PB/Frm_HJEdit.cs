using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PB
{
    public partial class Frm_HJEdit : Form
    {
        public Frm_HJEdit()
        {
            InitializeComponent();
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.textEdit3.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入合金代码！");
                textEdit3.Focus();
                return;
            }
            if (this.textEdit4.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入合金名称！");
                textEdit4.Focus();
                return;
            }
            this.Close();
        }
    }
}
