﻿namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_BZLB_EDIT
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Seave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txt_Name);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Controls.Add(this.btn_cancel);
            this.panelControl1.Controls.Add(this.btn_Seave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(307, 117);
            this.panelControl1.TabIndex = 39;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl11.Location = new System.Drawing.Point(36, 35);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(24, 14);
            this.labelControl11.TabIndex = 89;
            this.labelControl11.Text = "备注";
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(68, 34);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(226, 40);
            this.txt_Remark.TabIndex = 90;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_cancel.Location = new System.Drawing.Point(218, 79);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 73;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Seave
            // 
            this.btn_Seave.ImageUri.Uri = "Save;Size16x16";
            this.btn_Seave.Location = new System.Drawing.Point(137, 79);
            this.btn_Seave.Name = "btn_Seave";
            this.btn_Seave.Size = new System.Drawing.Size(75, 23);
            this.btn_Seave.TabIndex = 1;
            this.btn_Seave.Text = "保存";
            this.btn_Seave.Click += new System.EventHandler(this.btn_Seave_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 91;
            this.labelControl2.Text = "类别名称";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(68, 9);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(226, 20);
            this.txt_Name.TabIndex = 92;
            // 
            // FrmQB_BZLB_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 117);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQB_BZLB_EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改";
            this.Load += new System.EventHandler(this.FrmQB_BZLB_EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Seave;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Name;
    }
}