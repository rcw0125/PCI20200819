namespace XGCAP.UI.P.PB
{
    partial class FrmPB_CNLR_Edit
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CN = new DevExpress.XtraEditors.TextEdit();
            this.imgcbo_STA = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.dat_Time = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_STA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Time.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Time.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "日期";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(61, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "车间";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(61, 88);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "产能";
            // 
            // txt_CN
            // 
            this.txt_CN.Location = new System.Drawing.Point(91, 85);
            this.txt_CN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CN.Name = "txt_CN";
            this.txt_CN.Properties.Mask.EditMask = "F0";
            this.txt_CN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_CN.Size = new System.Drawing.Size(124, 20);
            this.txt_CN.TabIndex = 25;
            // 
            // imgcbo_STA
            // 
            this.imgcbo_STA.Location = new System.Drawing.Point(91, 53);
            this.imgcbo_STA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_STA.Name = "imgcbo_STA";
            this.imgcbo_STA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_STA.Properties.MaxLength = 50;
            this.imgcbo_STA.Size = new System.Drawing.Size(124, 20);
            this.imgcbo_STA.TabIndex = 27;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(59, 119);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 94;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_cancel.Location = new System.Drawing.Point(140, 119);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 93;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dat_Time
            // 
            this.dat_Time.EditValue = null;
            this.dat_Time.Location = new System.Drawing.Point(91, 21);
            this.dat_Time.Name = "dat_Time";
            this.dat_Time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dat_Time.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dat_Time.Size = new System.Drawing.Size(124, 20);
            this.dat_Time.TabIndex = 95;
            // 
            // FrmPB_CNLR_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 171);
            this.Controls.Add(this.dat_Time);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.imgcbo_STA);
            this.Controls.Add(this.txt_CN);
            this.Controls.Add(this.labelControl5);
            this.Name = "FrmPB_CNLR_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "工序产能修改";
            this.Load += new System.EventHandler(this.FrmPB_CNLR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_CN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_STA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Time.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Time.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_CN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_STA;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.DateEdit dat_Time;
    }
}