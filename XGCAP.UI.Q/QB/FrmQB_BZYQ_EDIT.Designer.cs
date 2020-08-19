namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_BZYQ_EDIT
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
            this.memo_PackDesc = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_PackCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_PackName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Seave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memo_PackDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PackCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PackName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.memo_PackDesc);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_PackCode);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txt_PackName);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Controls.Add(this.btn_cancel);
            this.panelControl1.Controls.Add(this.btn_Seave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(470, 196);
            this.panelControl1.TabIndex = 39;
            // 
            // memo_PackDesc
            // 
            this.memo_PackDesc.Location = new System.Drawing.Point(94, 44);
            this.memo_PackDesc.Name = "memo_PackDesc";
            this.memo_PackDesc.Size = new System.Drawing.Size(360, 49);
            this.memo_PackDesc.TabIndex = 81;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 14);
            this.labelControl5.TabIndex = 74;
            this.labelControl5.Text = "包装类型代码";
            // 
            // txt_PackCode
            // 
            this.txt_PackCode.Location = new System.Drawing.Point(94, 9);
            this.txt_PackCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PackCode.Name = "txt_PackCode";
            this.txt_PackCode.Size = new System.Drawing.Size(139, 20);
            this.txt_PackCode.TabIndex = 76;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(239, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 14);
            this.labelControl6.TabIndex = 75;
            this.labelControl6.Text = "包装类型名称";
            // 
            // txt_PackName
            // 
            this.txt_PackName.Location = new System.Drawing.Point(317, 9);
            this.txt_PackName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PackName.Name = "txt_PackName";
            this.txt_PackName.Size = new System.Drawing.Size(137, 20);
            this.txt_PackName.TabIndex = 77;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(60, 100);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 78;
            this.labelControl7.Text = "备注";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 46);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 14);
            this.labelControl8.TabIndex = 80;
            this.labelControl8.Text = "包装方式说明";
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(94, 99);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(360, 52);
            this.txt_Remark.TabIndex = 79;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_cancel.Location = new System.Drawing.Point(379, 156);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 73;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Seave
            // 
            this.btn_Seave.ImageUri.Uri = "Save;Size16x16";
            this.btn_Seave.Location = new System.Drawing.Point(298, 156);
            this.btn_Seave.Name = "btn_Seave";
            this.btn_Seave.Size = new System.Drawing.Size(75, 23);
            this.btn_Seave.TabIndex = 1;
            this.btn_Seave.Text = "保存";
            this.btn_Seave.Click += new System.EventHandler(this.btn_Seave_Click);
            // 
            // FrmQB_BZYQ_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 196);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQB_BZYQ_EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改";
            this.Load += new System.EventHandler(this.FrmQB_BZYQ_EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memo_PackDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PackCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PackName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Seave;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.MemoEdit memo_PackDesc;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_PackCode;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_PackName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
    }
}