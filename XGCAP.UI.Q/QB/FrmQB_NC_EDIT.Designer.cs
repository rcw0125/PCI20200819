namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_NC_EDIT
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Use = new DevExpress.XtraEditors.TextEdit();
            this.txt_Path = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_DataName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_PassWord = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Use.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Path.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DataName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PassWord.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用途";
            // 
            // txt_Use
            // 
            this.txt_Use.Location = new System.Drawing.Point(81, 21);
            this.txt_Use.Name = "txt_Use";
            this.txt_Use.Properties.ReadOnly = true;
            this.txt_Use.Size = new System.Drawing.Size(644, 24);
            this.txt_Use.TabIndex = 1;
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(81, 60);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(644, 24);
            this.txt_Path.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "地址";
            // 
            // txt_DataName
            // 
            this.txt_DataName.Location = new System.Drawing.Point(81, 98);
            this.txt_DataName.Name = "txt_DataName";
            this.txt_DataName.Size = new System.Drawing.Size(644, 24);
            this.txt_DataName.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "数据库";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(81, 138);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(644, 24);
            this.txt_Name.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 141);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "用户名";
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(81, 178);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(644, 24);
            this.txt_PassWord.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(46, 181);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 18);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "密码";
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(81, 224);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 29);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Close.Location = new System.Drawing.Point(212, 224);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 29);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "关闭";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // FrmQB_NC_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 272);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_DataName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_Use);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQB_NC_EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "接口地址修改";
            this.Load += new System.EventHandler(this.FrmQB_NC_EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Use.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Path.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DataName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PassWord.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Use;
        private DevExpress.XtraEditors.TextEdit txt_Path;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_DataName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_PassWord;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
    }
}