namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_JYLB_EDIT
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
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Remark1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Seave = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TypeName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TypeName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_cancel);
            this.panelControl1.Controls.Add(this.txt_Remark1);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.btn_Seave);
            this.panelControl1.Controls.Add(this.txt_TypeName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(267, 151);
            this.panelControl1.TabIndex = 39;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_cancel.Location = new System.Drawing.Point(171, 116);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 73;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_Remark1
            // 
            this.txt_Remark1.Location = new System.Drawing.Point(66, 44);
            this.txt_Remark1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark1.Name = "txt_Remark1";
            this.txt_Remark1.Size = new System.Drawing.Size(180, 53);
            this.txt_Remark1.TabIndex = 72;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "类别名称";
            // 
            // btn_Seave
            // 
            this.btn_Seave.ImageUri.Uri = "Save;Size16x16";
            this.btn_Seave.Location = new System.Drawing.Point(90, 116);
            this.btn_Seave.Name = "btn_Seave";
            this.btn_Seave.Size = new System.Drawing.Size(75, 23);
            this.btn_Seave.TabIndex = 1;
            this.btn_Seave.Text = "保存";
            this.btn_Seave.Click += new System.EventHandler(this.btn_Seave_Click);
            // 
            // txt_TypeName
            // 
            this.txt_TypeName.Location = new System.Drawing.Point(66, 11);
            this.txt_TypeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TypeName.Name = "txt_TypeName";
            this.txt_TypeName.Properties.MaxLength = 50;
            this.txt_TypeName.Size = new System.Drawing.Size(180, 20);
            this.txt_TypeName.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "备注";
            // 
            // FrmQB_JYLB_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 151);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQB_JYLB_EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改";
            this.Load += new System.EventHandler(this.FrmQB_JYLB_EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TypeName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_TypeName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Seave;
        private DevExpress.XtraEditors.MemoEdit txt_Remark1;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
    }
}