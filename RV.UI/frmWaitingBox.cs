using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RV.UI
{
    public partial class frmWaitingBox : Form
    {
        #region Properties
        private int _MaxWaitTime;
        private int _WaitTime;
        private IAsyncResult _AsyncResult;
        private EventHandler<EventArgs> _Method;

        public string Message { get; private set; }
        public int TimeSpan { get; set; }
        public bool FormEffectEnable { get; set; }
        #endregion

        #region frmWaitingBox
        public frmWaitingBox(EventHandler<EventArgs> method,int maxWaitTime,string waitMessage)
        {
            maxWaitTime *= 1000;
            Initialize(method, maxWaitTime,waitMessage);
        }
        public frmWaitingBox(EventHandler<EventArgs> method)
        {
            int maxWaitTime=60*1000;
            string waitMessage = "正在处理，请稍后...";
            Initialize(method, maxWaitTime,waitMessage);
        }
        public frmWaitingBox(EventHandler<EventArgs> method, string waitMessage)
        {
            int maxWaitTime = 60 * 1000;
            Initialize(method, maxWaitTime, waitMessage);
        }
        public frmWaitingBox(EventHandler<EventArgs> method, bool cancelEnable, bool timerVisable)
        {
            int maxWaitTime = 60*1000;
            string waitMessage = "正在处理，请稍后...";
            Initialize(method, maxWaitTime,waitMessage);
        }
        #endregion

        #region Initialize
        private void Initialize(EventHandler<EventArgs> method, int maxWaitTime,string waitMessage)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            Color[] c = GetRandColor();
            this.labMessage.Text = waitMessage;
            FormEffectEnable = true;
            //para
            TimeSpan = 500;
            Message = string.Empty;
            _MaxWaitTime = maxWaitTime;
            _WaitTime = 0;
            _Method = method;
            this.labTimer.Visible = true;
            this.timer1.Interval = TimeSpan;
            this.timer1.Start();
        }
        #endregion

        #region Color
        private Color[] GetRandColor()
        {
            int rMax = 248;
            int rMin = 204;
            int gMax = 250;
            int gMin = 215;
            int bMax = 250;
            int bMin = 240;
            Random r = new Random(DateTime.Now.Millisecond);
            int r1 = r.Next(rMin, rMax);
            int r2 = r1 + 5;
            int g1 = r.Next(gMin, gMax);
            int g2 = g1 + 5;
            int b1 = r.Next(bMin, bMax);
            int b2 = b1 + 5;
            Color c1 = Color.FromArgb(r1, g1, b1);
            Color c2 = Color.FromArgb(r2, g2, b2);
            Color[] c = { c1, c2 };
            return c;
        }
        #endregion

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Message = "您结束了当前操作！";
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _WaitTime += TimeSpan;
            this.labTimer.Text = string.Format("{0}秒", _WaitTime / 1000);
            if (!this._AsyncResult.IsCompleted)
            {
                if (_WaitTime > _MaxWaitTime)
                {
                    Message = string.Format("处理数据超时{0}秒，结束当前操作！", _MaxWaitTime / 1000);
                    this.Close();
                }
            }
            else
            {
                this.Message = string.Empty;
                this.Close();
            }
            
        }

        private void frmWaitingBox_Shown(object sender, EventArgs e)
        {
            _AsyncResult = _Method.BeginInvoke(null, null, null, null);
        }
        #endregion

        
    }
}
