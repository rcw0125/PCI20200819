namespace XGCAP.UI.P.PB
{
    partial class FrmPB_LGTLSJ_EDIT
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
            this.txt_JSCN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lab_GW1 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_GW = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbo_GX = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_JSCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(89, 155);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "冶炼时间";
            // 
            // txt_JSCN
            // 
            this.txt_JSCN.Location = new System.Drawing.Point(157, 152);
            this.txt_JSCN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_JSCN.Name = "txt_JSCN";
            this.txt_JSCN.Properties.Mask.EditMask = "n0";
            this.txt_JSCN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_JSCN.Properties.MaxLength = 3;
            this.txt_JSCN.Size = new System.Drawing.Size(176, 24);
            this.txt_JSCN.TabIndex = 79;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(119, 69);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 18);
            this.labelControl6.TabIndex = 77;
            this.labelControl6.Text = "工序";
            // 
            // lab_GW1
            // 
            this.lab_GW1.Location = new System.Drawing.Point(118, 111);
            this.lab_GW1.Margin = new System.Windows.Forms.Padding(4);
            this.lab_GW1.Name = "lab_GW1";
            this.lab_GW1.Size = new System.Drawing.Size(30, 18);
            this.lab_GW1.TabIndex = 78;
            this.lab_GW1.Text = "工位";
            // 
            // cbo_GW
            // 
            this.cbo_GW.Location = new System.Drawing.Point(156, 108);
            this.cbo_GW.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbo_GW.Name = "cbo_GW";
            this.cbo_GW.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GW.Size = new System.Drawing.Size(176, 24);
            this.cbo_GW.TabIndex = 80;
            // 
            // cbo_GX
            // 
            this.cbo_GX.Location = new System.Drawing.Point(156, 63);
            this.cbo_GX.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbo_GX.Name = "cbo_GX";
            this.cbo_GX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GX.Size = new System.Drawing.Size(176, 24);
            this.cbo_GX.TabIndex = 81;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(119, 209);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 29);
            this.btn_Save.TabIndex = 94;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_cancel.Location = new System.Drawing.Point(227, 209);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 29);
            this.btn_cancel.TabIndex = 93;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FrmPB_LGTLSJ_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 327);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbo_GX);
            this.Controls.Add(this.cbo_GW);
            this.Controls.Add(this.txt_JSCN);
            this.Controls.Add(this.lab_GW1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPB_LGTLSJ_EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "炼钢冶炼时间修改";
            this.Load += new System.EventHandler(this.FrmPB_LGTLSJ_EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_JSCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_JSCN;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lab_GW1;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GW;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GX;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
    }
}