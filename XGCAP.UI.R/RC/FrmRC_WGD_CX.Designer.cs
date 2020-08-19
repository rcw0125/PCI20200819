namespace XGCAP.UI.R.RC
{
    partial class FrmRC_WGD_CX
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
            this.icbo_ZX = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dt_End = new DevExpress.XtraEditors.DateEdit();
            this.dt_Start = new DevExpress.XtraEditors.DateEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gc_WGD = new DevExpress.XtraGrid.GridControl();
            this.gv_WGD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_out_toExcel1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_ZX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WGD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_out_toExcel1);
            this.panelControl1.Controls.Add(this.icbo_ZX);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.dt_End);
            this.panelControl1.Controls.Add(this.dt_Start);
            this.panelControl1.Controls.Add(this.btn_Query);
            this.panelControl1.Controls.Add(this.txt_BatchNo);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1406, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // icbo_ZX
            // 
            this.icbo_ZX.Location = new System.Drawing.Point(556, 9);
            this.icbo_ZX.Margin = new System.Windows.Forms.Padding(4);
            this.icbo_ZX.Name = "icbo_ZX";
            this.icbo_ZX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbo_ZX.Size = new System.Drawing.Size(131, 24);
            this.icbo_ZX.TabIndex = 189;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(515, 13);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 18);
            this.labelControl5.TabIndex = 188;
            this.labelControl5.Text = "轧线";
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(312, 8);
            this.dt_End.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_End.Name = "dt_End";
            this.dt_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_End.Properties.DisplayFormat.FormatString = "G";
            this.dt_End.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_End.Properties.EditFormat.FormatString = "G";
            this.dt_End.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_End.Properties.Mask.EditMask = "G";
            this.dt_End.Size = new System.Drawing.Size(196, 24);
            this.dt_End.TabIndex = 26;
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(93, 8);
            this.dt_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Start.Name = "dt_Start";
            this.dt_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Start.Properties.DisplayFormat.FormatString = "G";
            this.dt_Start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Start.Properties.EditFormat.FormatString = "G";
            this.dt_Start.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Start.Properties.Mask.EditMask = "G";
            this.dt_Start.Size = new System.Drawing.Size(196, 24);
            this.dt_Start.TabIndex = 25;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(946, 6);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 28);
            this.btn_Query.TabIndex = 24;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txt_BatchNo
            // 
            this.txt_BatchNo.Location = new System.Drawing.Point(760, 9);
            this.txt_BatchNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_BatchNo.Name = "txt_BatchNo";
            this.txt_BatchNo.Size = new System.Drawing.Size(171, 24);
            this.txt_BatchNo.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(706, 13);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 18);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "批号：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(295, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 18);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "~";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 18);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "生产时间：";
            // 
            // gc_WGD
            // 
            this.gc_WGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_WGD.Location = new System.Drawing.Point(0, 42);
            this.gc_WGD.MainView = this.gv_WGD;
            this.gc_WGD.Name = "gc_WGD";
            this.gc_WGD.Size = new System.Drawing.Size(1406, 571);
            this.gc_WGD.TabIndex = 1;
            this.gc_WGD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WGD});
            // 
            // gv_WGD
            // 
            this.gv_WGD.GridControl = this.gc_WGD;
            this.gv_WGD.Name = "gv_WGD";
            this.gv_WGD.OptionsBehavior.Editable = false;
            this.gv_WGD.OptionsView.ColumnAutoWidth = false;
            this.gv_WGD.OptionsView.ShowGroupPanel = false;
            // 
            // btn_out_toExcel1
            // 
            this.btn_out_toExcel1.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out_toExcel1.Location = new System.Drawing.Point(1040, 5);
            this.btn_out_toExcel1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_out_toExcel1.Name = "btn_out_toExcel1";
            this.btn_out_toExcel1.Size = new System.Drawing.Size(93, 29);
            this.btn_out_toExcel1.TabIndex = 224;
            this.btn_out_toExcel1.Text = "导出";
            this.btn_out_toExcel1.Click += new System.EventHandler(this.btn_out_toExcel1_Click);
            // 
            // FrmRC_WGD_CX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 613);
            this.Controls.Add(this.gc_WGD);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmRC_WGD_CX";
            this.Text = "完工单查询";
            this.Load += new System.EventHandler(this.FrmRC_WGD_CX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_ZX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WGD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dt_End;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbo_ZX;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gc_WGD;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WGD;
        private DevExpress.XtraEditors.SimpleButton btn_out_toExcel1;
    }
}