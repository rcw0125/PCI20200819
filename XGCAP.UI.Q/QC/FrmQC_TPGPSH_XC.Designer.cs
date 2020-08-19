namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_TPGPSH_XC
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
            this.gc_GPGP = new DevExpress.XtraGrid.GridControl();
            this.gv_GPGP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CZYJ = new DevExpress.XtraEditors.MemoEdit();
            this.btn_SHBH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SHTG = new DevExpress.XtraEditors.SimpleButton();
            this.dte_End = new DevExpress.XtraEditors.DateEdit();
            this.dte_Begin = new DevExpress.XtraEditors.DateEdit();
            this.txt_Stove1 = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPGP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPGP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CZYJ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_GPGP
            // 
            this.gc_GPGP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GPGP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_GPGP.Location = new System.Drawing.Point(0, 93);
            this.gc_GPGP.MainView = this.gv_GPGP;
            this.gc_GPGP.Margin = new System.Windows.Forms.Padding(2);
            this.gc_GPGP.Name = "gc_GPGP";
            this.gc_GPGP.Size = new System.Drawing.Size(1213, 550);
            this.gc_GPGP.TabIndex = 56;
            this.gc_GPGP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GPGP});
            // 
            // gv_GPGP
            // 
            this.gv_GPGP.GridControl = this.gc_GPGP;
            this.gv_GPGP.Name = "gv_GPGP";
            this.gv_GPGP.OptionsBehavior.Editable = false;
            this.gv_GPGP.OptionsSelection.MultiSelect = true;
            this.gv_GPGP.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GPGP.OptionsView.ColumnAutoWidth = false;
            this.gv_GPGP.OptionsView.ShowGroupPanel = false;
            this.gv_GPGP.DoubleClick += new System.EventHandler(this.gv_GPGP_DoubleClick);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl12);
            this.panelControl3.Controls.Add(this.txt_CZYJ);
            this.panelControl3.Controls.Add(this.btn_SHBH);
            this.panelControl3.Controls.Add(this.btn_SHTG);
            this.panelControl3.Controls.Add(this.dte_End);
            this.panelControl3.Controls.Add(this.dte_Begin);
            this.panelControl3.Controls.Add(this.txt_Stove1);
            this.panelControl3.Controls.Add(this.btn_Query1);
            this.panelControl3.Controls.Add(this.labelControl15);
            this.panelControl3.Controls.Add(this.labelControl16);
            this.panelControl3.Controls.Add(this.labelControl17);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1213, 93);
            this.panelControl3.TabIndex = 55;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(33, 29);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 14);
            this.labelControl12.TabIndex = 63;
            this.labelControl12.Text = "处置意见";
            // 
            // txt_CZYJ
            // 
            this.txt_CZYJ.Location = new System.Drawing.Point(85, 29);
            this.txt_CZYJ.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CZYJ.Name = "txt_CZYJ";
            this.txt_CZYJ.Size = new System.Drawing.Size(312, 55);
            this.txt_CZYJ.TabIndex = 64;
            // 
            // btn_SHBH
            // 
            this.btn_SHBH.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_SHBH.Location = new System.Drawing.Point(492, 61);
            this.btn_SHBH.Name = "btn_SHBH";
            this.btn_SHBH.Size = new System.Drawing.Size(83, 23);
            this.btn_SHBH.TabIndex = 54;
            this.btn_SHBH.Text = "审核驳回";
            this.btn_SHBH.Click += new System.EventHandler(this.btn_SHBH_Click);
            // 
            // btn_SHTG
            // 
            this.btn_SHTG.ImageUri.Uri = "Apply;Size16x16";
            this.btn_SHTG.Location = new System.Drawing.Point(402, 61);
            this.btn_SHTG.Name = "btn_SHTG";
            this.btn_SHTG.Size = new System.Drawing.Size(84, 23);
            this.btn_SHTG.TabIndex = 53;
            this.btn_SHTG.Text = "审核通过";
            this.btn_SHTG.Click += new System.EventHandler(this.btn_SHTG_Click);
            // 
            // dte_End
            // 
            this.dte_End.EditValue = null;
            this.dte_End.Location = new System.Drawing.Point(250, 5);
            this.dte_End.Margin = new System.Windows.Forms.Padding(2);
            this.dte_End.Name = "dte_End";
            this.dte_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_End.Properties.DisplayFormat.FormatString = "G";
            this.dte_End.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_End.Properties.EditFormat.FormatString = "G";
            this.dte_End.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_End.Properties.Mask.EditMask = "G";
            this.dte_End.Size = new System.Drawing.Size(147, 20);
            this.dte_End.TabIndex = 52;
            // 
            // dte_Begin
            // 
            this.dte_Begin.EditValue = null;
            this.dte_Begin.Location = new System.Drawing.Point(85, 5);
            this.dte_Begin.Margin = new System.Windows.Forms.Padding(2);
            this.dte_Begin.Name = "dte_Begin";
            this.dte_Begin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Begin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Begin.Properties.DisplayFormat.FormatString = "G";
            this.dte_Begin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_Begin.Properties.EditFormat.FormatString = "G";
            this.dte_Begin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_Begin.Properties.Mask.EditMask = "G";
            this.dte_Begin.Size = new System.Drawing.Size(147, 20);
            this.dte_Begin.TabIndex = 51;
            // 
            // txt_Stove1
            // 
            this.txt_Stove1.Location = new System.Drawing.Point(475, 5);
            this.txt_Stove1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Stove1.Name = "txt_Stove1";
            this.txt_Stove1.Size = new System.Drawing.Size(139, 20);
            this.txt_Stove1.TabIndex = 49;
            // 
            // btn_Query1
            // 
            this.btn_Query1.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query1.Location = new System.Drawing.Point(619, 5);
            this.btn_Query1.Name = "btn_Query1";
            this.btn_Query1.Size = new System.Drawing.Size(75, 23);
            this.btn_Query1.TabIndex = 48;
            this.btn_Query1.Text = "查询";
            this.btn_Query1.Click += new System.EventHandler(this.btn_Query1_Click);
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(406, 8);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(65, 14);
            this.labelControl15.TabIndex = 48;
            this.labelControl15.Text = "炉号/开坯号";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(238, 5);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(9, 14);
            this.labelControl16.TabIndex = 47;
            this.labelControl16.Text = "~";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(9, 8);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(72, 14);
            this.labelControl17.TabIndex = 46;
            this.labelControl17.Text = "改判申请时间";
            // 
            // FrmQC_TPGPSH_XC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 643);
            this.Controls.Add(this.gc_GPGP);
            this.Controls.Add(this.panelControl3);
            this.Name = "FrmQC_TPGPSH_XC";
            this.Text = "FrmQC_TPGPSH";
            this.Load += new System.EventHandler(this.FrmQC_TPGPSH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPGP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPGP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CZYJ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_GPGP;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GPGP;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.DateEdit dte_End;
        private DevExpress.XtraEditors.DateEdit dte_Begin;
        private DevExpress.XtraEditors.TextEdit txt_Stove1;
        private DevExpress.XtraEditors.SimpleButton btn_Query1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.SimpleButton btn_SHBH;
        private DevExpress.XtraEditors.SimpleButton btn_SHTG;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.MemoEdit txt_CZYJ;
    }
}