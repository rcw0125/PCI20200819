using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Common
{
    public partial class TipsForm : Form
    {
        public TipsForm(string str)
        {
            InitializeComponent();

            lbl_Msg.Text = str;
        }

        private void TipsForm_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Size.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height;
            Point p = new Point(x, y);
            this.PointToScreen(p);
            this.Location = p;

            SystemSounds.Hand.Play();
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
