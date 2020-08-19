namespace XGCAP.UI.P.PB
{
    partial class FrmPB_ZGJSCN_EDIT
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
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.lab_GW1 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_GW = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_JSCN = new DevExpress.XtraEditors.TextEdit();
            this.cbo_DM = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Grd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_JSCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_DM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(119, 204);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 29);
            this.btn_Save.TabIndex = 108;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_cancel.Location = new System.Drawing.Point(227, 204);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 29);
            this.btn_cancel.TabIndex = 107;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lab_GW1
            // 
            this.lab_GW1.Location = new System.Drawing.Point(109, 32);
            this.lab_GW1.Margin = new System.Windows.Forms.Padding(4);
            this.lab_GW1.Name = "lab_GW1";
            this.lab_GW1.Size = new System.Drawing.Size(30, 18);
            this.lab_GW1.TabIndex = 106;
            this.lab_GW1.Text = "工位";
            // 
            // cbo_GW
            // 
            this.cbo_GW.Location = new System.Drawing.Point(167, 28);
            this.cbo_GW.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbo_GW.Name = "cbo_GW";
            this.cbo_GW.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GW.Size = new System.Drawing.Size(178, 24);
            this.cbo_GW.TabIndex = 99;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(79, 158);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 18);
            this.labelControl5.TabIndex = 104;
            this.labelControl5.Text = "机时产能";
            // 
            // txt_JSCN
            // 
            this.txt_JSCN.Location = new System.Drawing.Point(167, 154);
            this.txt_JSCN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_JSCN.Name = "txt_JSCN";
            this.txt_JSCN.Properties.Mask.EditMask = "n0";
            this.txt_JSCN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_JSCN.Properties.MaxLength = 3;
            this.txt_JSCN.Size = new System.Drawing.Size(178, 24);
            this.txt_JSCN.TabIndex = 105;
            // 
            // cbo_DM
            // 
            this.cbo_DM.Location = new System.Drawing.Point(167, 113);
            this.cbo_DM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbo_DM.Name = "cbo_DM";
            this.cbo_DM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_DM.Properties.Items.AddRange(new object[] {
            "150*150",
            "160*160",
            "280*325"});
            this.cbo_DM.Size = new System.Drawing.Size(178, 24);
            this.cbo_DM.TabIndex = 103;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(109, 117);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 101;
            this.labelControl2.Text = "规格";
            // 
            // txt_Grd
            // 
            this.txt_Grd.Location = new System.Drawing.Point(167, 69);
            this.txt_Grd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_Grd.Name = "txt_Grd";
            this.txt_Grd.Properties.MaxLength = 50;
            this.txt_Grd.Size = new System.Drawing.Size(178, 24);
            this.txt_Grd.TabIndex = 96;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(109, 73);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 95;
            this.labelControl3.Text = "钢种";
            // 
            // FrmPB_ZGJSCN_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 324);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lab_GW1);
            this.Controls.Add(this.cbo_GW);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_JSCN);
            this.Controls.Add(this.cbo_DM);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_Grd);
            this.Controls.Add(this.labelControl3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPB_ZGJSCN_EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "轧钢机时产能修改";
            this.Load += new System.EventHandler(this.FrmPB_ZGJSCN_EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_JSCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_DM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.LabelControl lab_GW1;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GW;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_JSCN;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_DM;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Grd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}