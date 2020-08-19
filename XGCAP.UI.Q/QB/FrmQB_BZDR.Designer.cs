namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_BZDR
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
            this.btn_Bz = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrl = new DevExpress.XtraEditors.ButtonEdit();
            this.btn_GG = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CF = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XN = new DevExpress.XtraEditors.SimpleButton();
            this.btn_QY = new DevExpress.XtraEditors.SimpleButton();
            this.rtxt_Log = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Bz
            // 
            this.btn_Bz.ImageUri.Uri = "EditDataSource;Size16x16";
            this.btn_Bz.Location = new System.Drawing.Point(25, 94);
            this.btn_Bz.Name = "btn_Bz";
            this.btn_Bz.Size = new System.Drawing.Size(106, 37);
            this.btn_Bz.TabIndex = 0;
            this.btn_Bz.Text = "导入标准";
            this.btn_Bz.Click += new System.EventHandler(this.btn_Bz_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(25, 29);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(60, 18);
            this.labelControl13.TabIndex = 37;
            this.labelControl13.Text = "导入文件";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(103, 25);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtUrl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtUrl.Size = new System.Drawing.Size(636, 24);
            this.txtUrl.TabIndex = 38;
            this.txtUrl.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtUrl_ButtonClick);
            // 
            // btn_GG
            // 
            this.btn_GG.ImageUri.Uri = "EditDataSource;Size16x16";
            this.btn_GG.Location = new System.Drawing.Point(181, 94);
            this.btn_GG.Name = "btn_GG";
            this.btn_GG.Size = new System.Drawing.Size(106, 37);
            this.btn_GG.TabIndex = 39;
            this.btn_GG.Text = "导入规格";
            this.btn_GG.Click += new System.EventHandler(this.btn_GG_Click);
            // 
            // btn_CF
            // 
            this.btn_CF.ImageUri.Uri = "EditDataSource;Size16x16";
            this.btn_CF.Location = new System.Drawing.Point(335, 94);
            this.btn_CF.Name = "btn_CF";
            this.btn_CF.Size = new System.Drawing.Size(106, 37);
            this.btn_CF.TabIndex = 40;
            this.btn_CF.Text = "导入成分";
            this.btn_CF.Click += new System.EventHandler(this.btn_CF_Click);
            // 
            // btn_XN
            // 
            this.btn_XN.ImageUri.Uri = "EditDataSource;Size16x16";
            this.btn_XN.Location = new System.Drawing.Point(496, 94);
            this.btn_XN.Name = "btn_XN";
            this.btn_XN.Size = new System.Drawing.Size(106, 37);
            this.btn_XN.TabIndex = 41;
            this.btn_XN.Text = "导入性能";
            this.btn_XN.Click += new System.EventHandler(this.btn_XN_Click);
            // 
            // btn_QY
            // 
            this.btn_QY.ImageUri.Uri = "EditDataSource;Size16x16";
            this.btn_QY.Location = new System.Drawing.Point(633, 94);
            this.btn_QY.Name = "btn_QY";
            this.btn_QY.Size = new System.Drawing.Size(106, 37);
            this.btn_QY.TabIndex = 42;
            this.btn_QY.Text = "导入取样";
            this.btn_QY.Click += new System.EventHandler(this.btn_QY_Click);
            // 
            // rtxt_Log
            // 
            this.rtxt_Log.Location = new System.Drawing.Point(25, 169);
            this.rtxt_Log.Name = "rtxt_Log";
            this.rtxt_Log.Size = new System.Drawing.Size(714, 228);
            this.rtxt_Log.TabIndex = 43;
            this.rtxt_Log.Text = "";
            // 
            // FrmQB_BZDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 418);
            this.Controls.Add(this.rtxt_Log);
            this.Controls.Add(this.btn_QY);
            this.Controls.Add(this.btn_XN);
            this.Controls.Add(this.btn_CF);
            this.Controls.Add(this.btn_GG);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btn_Bz);
            this.Name = "FrmQB_BZDR";
            this.Text = "FrmQB_BZDR";
            this.Load += new System.EventHandler(this.FrmQB_BZDR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Bz;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.ButtonEdit txtUrl;
        private DevExpress.XtraEditors.SimpleButton btn_GG;
        private DevExpress.XtraEditors.SimpleButton btn_CF;
        private DevExpress.XtraEditors.SimpleButton btn_XN;
        private DevExpress.XtraEditors.SimpleButton btn_QY;
        private System.Windows.Forms.RichTextBox rtxt_Log;
    }
}