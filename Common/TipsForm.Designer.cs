namespace Common
{
    partial class TipsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.btn_Sure = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.Location = new System.Drawing.Point(24, 23);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(300, 76);
            this.lbl_Msg.TabIndex = 0;
            this.lbl_Msg.Text = "label";
            // 
            // btn_Sure
            // 
            this.btn_Sure.ImageUri.Uri = "Apply;Size16x16";
            this.btn_Sure.Location = new System.Drawing.Point(121, 117);
            this.btn_Sure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(100, 29);
            this.btn_Sure.TabIndex = 201;
            this.btn_Sure.Text = "确定";
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // TipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 163);
            this.Controls.Add(this.btn_Sure);
            this.Controls.Add(this.lbl_Msg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "消息提醒";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TipsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Msg;
        private DevExpress.XtraEditors.SimpleButton btn_Sure;
    }
}