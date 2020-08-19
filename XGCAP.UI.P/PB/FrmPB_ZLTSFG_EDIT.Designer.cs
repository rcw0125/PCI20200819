namespace XGCAP.UI.P.PB
{
    partial class FrmPB_ZLTSFG_EDIT
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_ZL1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CT = new DevExpress.XtraEditors.TextEdit();
            this.txt_ZL = new DevExpress.XtraEditors.TextEdit();
            this.txt_TS = new DevExpress.XtraEditors.TextEdit();
            this.txt_FG = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_ZL1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ZL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_CT);
            this.panelControl1.Controls.Add(this.txt_ZL);
            this.panelControl1.Controls.Add(this.txt_TS);
            this.panelControl1.Controls.Add(this.txt_FG);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.cbo_ZL1);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.btn_cancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(603, 317);
            this.panelControl1.TabIndex = 43;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Location = new System.Drawing.Point(89, 149);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 111;
            this.labelControl1.Text = "备注";
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(159, 137);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Properties.MaxLength = 300;
            this.txt_Remark.Size = new System.Drawing.Size(350, 55);
            this.txt_Remark.TabIndex = 112;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(89, 54);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 18);
            this.labelControl6.TabIndex = 109;
            this.labelControl6.Text = "转炉";
            // 
            // cbo_ZL1
            // 
            this.cbo_ZL1.EditValue = "";
            this.cbo_ZL1.Location = new System.Drawing.Point(159, 51);
            this.cbo_ZL1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_ZL1.Name = "cbo_ZL1";
            this.cbo_ZL1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_ZL1.Size = new System.Drawing.Size(161, 24);
            this.cbo_ZL1.TabIndex = 108;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(178, 218);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 29);
            this.btn_Save.TabIndex = 92;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_cancel.Location = new System.Drawing.Point(325, 218);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 29);
            this.btn_cancel.TabIndex = 73;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(378, 54);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 113;
            this.labelControl2.Text = "每炉重量";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(378, 93);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 18);
            this.labelControl3.TabIndex = 114;
            this.labelControl3.Text = "出铁重量";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(87, 93);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 18);
            this.labelControl4.TabIndex = 115;
            this.labelControl4.Text = "铁水重量";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(235, 92);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 18);
            this.labelControl5.TabIndex = 116;
            this.labelControl5.Text = "废钢重量";
            // 
            // txt_CT
            // 
            this.txt_CT.EditValue = "";
            this.txt_CT.Location = new System.Drawing.Point(450, 90);
            this.txt_CT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_CT.Name = "txt_CT";
            this.txt_CT.Properties.DisplayFormat.FormatString = "d";
            this.txt_CT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_CT.Properties.EditFormat.FormatString = "d";
            this.txt_CT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_CT.Properties.Mask.EditMask = "f0";
            this.txt_CT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_CT.Properties.MaxLength = 3;
            this.txt_CT.Size = new System.Drawing.Size(59, 24);
            this.txt_CT.TabIndex = 120;
            // 
            // txt_ZL
            // 
            this.txt_ZL.EditValue = "";
            this.txt_ZL.Location = new System.Drawing.Point(450, 51);
            this.txt_ZL.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_ZL.Name = "txt_ZL";
            this.txt_ZL.Properties.DisplayFormat.FormatString = "d";
            this.txt_ZL.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_ZL.Properties.EditFormat.FormatString = "d";
            this.txt_ZL.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_ZL.Properties.Mask.EditMask = "f0";
            this.txt_ZL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_ZL.Properties.MaxLength = 3;
            this.txt_ZL.Size = new System.Drawing.Size(59, 24);
            this.txt_ZL.TabIndex = 117;
            // 
            // txt_TS
            // 
            this.txt_TS.EditValue = "";
            this.txt_TS.Location = new System.Drawing.Point(159, 90);
            this.txt_TS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_TS.Name = "txt_TS";
            this.txt_TS.Properties.DisplayFormat.FormatString = "d";
            this.txt_TS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_TS.Properties.EditFormat.FormatString = "d";
            this.txt_TS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_TS.Properties.Mask.EditMask = "f0";
            this.txt_TS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_TS.Properties.MaxLength = 3;
            this.txt_TS.Size = new System.Drawing.Size(59, 24);
            this.txt_TS.TabIndex = 118;
            // 
            // txt_FG
            // 
            this.txt_FG.EditValue = "";
            this.txt_FG.Enabled = false;
            this.txt_FG.Location = new System.Drawing.Point(307, 89);
            this.txt_FG.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_FG.Name = "txt_FG";
            this.txt_FG.Properties.DisplayFormat.FormatString = "d";
            this.txt_FG.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_FG.Properties.EditFormat.FormatString = "d";
            this.txt_FG.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_FG.Properties.Mask.EditMask = "f0";
            this.txt_FG.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_FG.Properties.MaxLength = 3;
            this.txt_FG.Size = new System.Drawing.Size(59, 24);
            this.txt_FG.TabIndex = 119;
            // 
            // FrmPB_ZLTSFG_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 317);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPB_ZLTSFG_EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "转炉铁水废钢比例修改";
            this.Load += new System.EventHandler(this.FrmPB_ZLTSFG_EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_ZL1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ZL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FG.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_ZL1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_CT;
        private DevExpress.XtraEditors.TextEdit txt_ZL;
        private DevExpress.XtraEditors.TextEdit txt_TS;
        private DevExpress.XtraEditors.TextEdit txt_FG;
    }
}