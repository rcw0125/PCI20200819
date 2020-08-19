namespace RV.UI
{
    partial class FrmEditPwd
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
            this.txt_Pwd1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Pwd2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pwd1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pwd2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Pwd1
            // 
            this.txt_Pwd1.Location = new System.Drawing.Point(107, 12);
            this.txt_Pwd1.Name = "txt_Pwd1";
            this.txt_Pwd1.Properties.MaxLength = 50;
            this.txt_Pwd1.Properties.PasswordChar = '*';
            this.txt_Pwd1.Size = new System.Drawing.Size(215, 24);
            this.txt_Pwd1.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(56, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "新密码";
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(107, 99);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 28);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "确定";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Cancle.Location = new System.Drawing.Point(247, 99);
            this.btn_Cancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancle.TabIndex = 4;
            this.btn_Cancle.Text = "取消";
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(25, 57);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 18);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "新密码确认";
            // 
            // txt_Pwd2
            // 
            this.txt_Pwd2.Location = new System.Drawing.Point(107, 54);
            this.txt_Pwd2.Name = "txt_Pwd2";
            this.txt_Pwd2.Properties.MaxLength = 50;
            this.txt_Pwd2.Properties.PasswordChar = '*';
            this.txt_Pwd2.Size = new System.Drawing.Size(215, 24);
            this.txt_Pwd2.TabIndex = 2;
            // 
            // FrmEditPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 148);
            this.Controls.Add(this.txt_Pwd2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Pwd1);
            this.Controls.Add(this.labelControl4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FrmEditPwd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pwd1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pwd2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txt_Pwd1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Cancle;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Pwd2;
    }
}