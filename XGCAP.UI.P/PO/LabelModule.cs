using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace XGCAP.UI.P.PO
{
    [ToolboxItem(true)]
    public partial class LabelModule : LabelControl
    {
        private bool IsMouseDown = false;
        private Point MousePrePosition;

        public LabelModule()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(LabelModule_MouseDown);
            this.MouseUp += new MouseEventHandler(LabelModule_MouseUp);
            this.MouseMove += new MouseEventHandler(LabelModule_MouseMove);

            this.BackColor = Color.LightGreen;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void LabelModule_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            MousePrePosition = new Point(e.X, e.Y);
            this.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Cursor = Cursors.SizeAll;
        }

        private void LabelModule_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            this.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Cursor = Cursors.Default;
        }

        private void LabelModule_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsMouseDown) return;
            this.Top = this.Top + (e.Y - MousePrePosition.Y);
            this.Left = this.Left + (e.X - MousePrePosition.X);
            
            if (this.Top < 0)
                this.Top = 0;
             
            if (this.Left < 0)
                this.Left = 0;

         }
    }
}
