namespace XGCAP.UI.P.PB
{
    partial class FrmPB_TSBZXX_EDIT
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cn = new DevExpress.XtraEditors.TextEdit();
            this.cbo_GX = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbo_GW = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_cn);
            this.panelControl1.Controls.Add(this.cbo_GX);
            this.panelControl1.Controls.Add(this.cbo_GW);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.btn_cancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 450);
            this.panelControl1.TabIndex = 43;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 114);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 93;
            this.labelControl2.Text = "产能";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 26);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 94;
            this.labelControl3.Text = "工序";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 72);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 95;
            this.labelControl1.Text = "工位";
            // 
            // txt_cn
            // 
            this.txt_cn.Location = new System.Drawing.Point(87, 111);
            this.txt_cn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cn.Name = "txt_cn";
            this.txt_cn.Properties.Mask.EditMask = "n0";
            this.txt_cn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_cn.Size = new System.Drawing.Size(175, 24);
            this.txt_cn.TabIndex = 96;
            // 
            // cbo_GX
            // 
            this.cbo_GX.Location = new System.Drawing.Point(87, 23);
            this.cbo_GX.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_GX.Name = "cbo_GX";
            this.cbo_GX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GX.Size = new System.Drawing.Size(175, 24);
            this.cbo_GX.TabIndex = 97;
            // 
            // cbo_GW
            // 
            this.cbo_GW.Location = new System.Drawing.Point(87, 69);
            this.cbo_GW.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_GW.Name = "cbo_GW";
            this.cbo_GW.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GW.Size = new System.Drawing.Size(175, 24);
            this.cbo_GW.TabIndex = 98;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(59, 165);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 29);
            this.btn_Save.TabIndex = 92;
            this.btn_Save.Text = "保存";
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_cancel.Location = new System.Drawing.Point(167, 165);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 29);
            this.btn_cancel.TabIndex = 73;
            this.btn_cancel.Text = "取消";
            // 
            // FrmPB_TSBZXX_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPB_TSBZXX_EDIT";
            this.Text = "修改";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_cn;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GX;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GW;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
    }
}