namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_XNJYGC_EDIT
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_XMMX = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Order = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_Name = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Seave = new DevExpress.XtraEditors.SimpleButton();
            this.imgcbo_QYMC = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_XMMX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Order.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_QYMC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.imgcbo_QYMC);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_XMMX);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txt_Order);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.imgcbo_Name);
            this.panelControl1.Controls.Add(this.btn_cancel);
            this.panelControl1.Controls.Add(this.btn_Seave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(354, 112);
            this.panelControl1.TabIndex = 39;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 141;
            this.labelControl5.Text = "项目明细";
            // 
            // txt_XMMX
            // 
            this.txt_XMMX.Location = new System.Drawing.Point(66, 39);
            this.txt_XMMX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_XMMX.Name = "txt_XMMX";
            this.txt_XMMX.Size = new System.Drawing.Size(145, 20);
            this.txt_XMMX.TabIndex = 142;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(217, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 139;
            this.labelControl4.Text = "顺序号";
            // 
            // txt_Order
            // 
            this.txt_Order.Location = new System.Drawing.Point(259, 39);
            this.txt_Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Order.Name = "txt_Order";
            this.txt_Order.Properties.Mask.EditMask = "F0";
            this.txt_Order.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Order.Size = new System.Drawing.Size(87, 20);
            this.txt_Order.TabIndex = 140;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 137;
            this.labelControl1.Text = "性能名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(163, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 135;
            this.labelControl2.Text = "项目类别";
            // 
            // imgcbo_Name
            // 
            this.imgcbo_Name.Location = new System.Drawing.Point(66, 10);
            this.imgcbo_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_Name.Name = "imgcbo_Name";
            this.imgcbo_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_Name.Size = new System.Drawing.Size(89, 20);
            this.imgcbo_Name.TabIndex = 138;
            this.imgcbo_Name.SelectedIndexChanged += new System.EventHandler(this.imgcbo_Name_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_cancel.Location = new System.Drawing.Point(269, 73);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 73;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Seave
            // 
            this.btn_Seave.ImageUri.Uri = "Save;Size16x16";
            this.btn_Seave.Location = new System.Drawing.Point(188, 73);
            this.btn_Seave.Name = "btn_Seave";
            this.btn_Seave.Size = new System.Drawing.Size(75, 23);
            this.btn_Seave.TabIndex = 1;
            this.btn_Seave.Text = "保存";
            this.btn_Seave.Click += new System.EventHandler(this.btn_Seave_Click);
            // 
            // imgcbo_QYMC
            // 
            this.imgcbo_QYMC.Location = new System.Drawing.Point(217, 9);
            this.imgcbo_QYMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_QYMC.Name = "imgcbo_QYMC";
            this.imgcbo_QYMC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_QYMC.Size = new System.Drawing.Size(129, 20);
            this.imgcbo_QYMC.TabIndex = 143;
            // 
            // FrmQB_XNJYGC_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 112);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQB_XNJYGC_EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改";
            this.Load += new System.EventHandler(this.FrmQB_XNJYGC_EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_XMMX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Order.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_QYMC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Seave;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Order;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_Name;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_XMMX;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_QYMC;
    }
}