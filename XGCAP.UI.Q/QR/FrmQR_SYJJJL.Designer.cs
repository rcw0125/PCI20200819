namespace XGCAP.UI.Q.QR
{
    partial class FrmQR_SYJJJL
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gc_ZYXX = new DevExpress.XtraGrid.GridControl();
            this.gv_ZYXX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Batch_Max = new DevExpress.XtraEditors.TextEdit();
            this.txt_Batch_Min = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dt_ZY_End = new DevExpress.XtraEditors.DateEdit();
            this.dt_ZY_Start = new DevExpress.XtraEditors.DateEdit();
            this.btn_Query_ZY_CG = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gc_CCZY = new DevExpress.XtraGrid.GridControl();
            this.gv_CCZY = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dte_End1 = new DevExpress.XtraEditors.DateEdit();
            this.dte_Begin1 = new DevExpress.XtraEditors.DateEdit();
            this.btn_Query_ZY = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZYXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZYXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Max.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Min.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ZY_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ZY_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ZY_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ZY_Start.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CCZY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CCZY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(997, 614);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gc_ZYXX);
            this.xtraTabPage1.Controls.Add(this.panelControl2);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(991, 585);
            this.xtraTabPage1.Text = "常规";
            // 
            // gc_ZYXX
            // 
            this.gc_ZYXX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ZYXX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_ZYXX.Location = new System.Drawing.Point(0, 41);
            this.gc_ZYXX.MainView = this.gv_ZYXX;
            this.gc_ZYXX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_ZYXX.Name = "gc_ZYXX";
            this.gc_ZYXX.Size = new System.Drawing.Size(991, 544);
            this.gc_ZYXX.TabIndex = 21;
            this.gc_ZYXX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ZYXX});
            // 
            // gv_ZYXX
            // 
            this.gv_ZYXX.GridControl = this.gc_ZYXX;
            this.gv_ZYXX.Name = "gv_ZYXX";
            this.gv_ZYXX.OptionsBehavior.Editable = false;
            this.gv_ZYXX.OptionsView.ColumnAutoWidth = false;
            this.gv_ZYXX.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_out);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.txt_Batch_Max);
            this.panelControl2.Controls.Add(this.txt_Batch_Min);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.dt_ZY_End);
            this.panelControl2.Controls.Add(this.dt_ZY_Start);
            this.panelControl2.Controls.Add(this.btn_Query_ZY_CG);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(991, 41);
            this.panelControl2.TabIndex = 20;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(545, 14);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(9, 14);
            this.labelControl13.TabIndex = 34;
            this.labelControl13.Text = "~";
            // 
            // txt_Batch_Max
            // 
            this.txt_Batch_Max.Location = new System.Drawing.Point(558, 12);
            this.txt_Batch_Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Batch_Max.Name = "txt_Batch_Max";
            this.txt_Batch_Max.Size = new System.Drawing.Size(100, 20);
            this.txt_Batch_Max.TabIndex = 33;
            // 
            // txt_Batch_Min
            // 
            this.txt_Batch_Min.Location = new System.Drawing.Point(440, 12);
            this.txt_Batch_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Batch_Min.Name = "txt_Batch_Min";
            this.txt_Batch_Min.Size = new System.Drawing.Size(100, 20);
            this.txt_Batch_Min.TabIndex = 32;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(393, 14);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "批号段：";
            // 
            // dt_ZY_End
            // 
            this.dt_ZY_End.EditValue = null;
            this.dt_ZY_End.Location = new System.Drawing.Point(230, 12);
            this.dt_ZY_End.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_ZY_End.Name = "dt_ZY_End";
            this.dt_ZY_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ZY_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ZY_End.Properties.DisplayFormat.FormatString = "G";
            this.dt_ZY_End.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_ZY_End.Properties.EditFormat.FormatString = "G";
            this.dt_ZY_End.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_ZY_End.Properties.Mask.EditMask = "G";
            this.dt_ZY_End.Size = new System.Drawing.Size(147, 20);
            this.dt_ZY_End.TabIndex = 19;
            // 
            // dt_ZY_Start
            // 
            this.dt_ZY_Start.EditValue = null;
            this.dt_ZY_Start.Location = new System.Drawing.Point(66, 12);
            this.dt_ZY_Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_ZY_Start.Name = "dt_ZY_Start";
            this.dt_ZY_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ZY_Start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ZY_Start.Properties.DisplayFormat.FormatString = "G";
            this.dt_ZY_Start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_ZY_Start.Properties.EditFormat.FormatString = "G";
            this.dt_ZY_Start.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_ZY_Start.Properties.Mask.EditMask = "G";
            this.dt_ZY_Start.Size = new System.Drawing.Size(147, 20);
            this.dt_ZY_Start.TabIndex = 18;
            // 
            // btn_Query_ZY_CG
            // 
            this.btn_Query_ZY_CG.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query_ZY_CG.Location = new System.Drawing.Point(662, 10);
            this.btn_Query_ZY_CG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Query_ZY_CG.Name = "btn_Query_ZY_CG";
            this.btn_Query_ZY_CG.Size = new System.Drawing.Size(72, 22);
            this.btn_Query_ZY_CG.TabIndex = 17;
            this.btn_Query_ZY_CG.Text = "查询";
            this.btn_Query_ZY_CG.Click += new System.EventHandler(this.btn_Query_ZY_CG_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(218, 14);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(9, 14);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "~";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 14);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 14);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "接样时间：";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gc_CCZY);
            this.xtraTabPage2.Controls.Add(this.panelControl3);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(991, 585);
            this.xtraTabPage2.Text = "抽查";
            // 
            // gc_CCZY
            // 
            this.gc_CCZY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CCZY.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_CCZY.Location = new System.Drawing.Point(0, 37);
            this.gc_CCZY.MainView = this.gv_CCZY;
            this.gc_CCZY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_CCZY.Name = "gc_CCZY";
            this.gc_CCZY.Size = new System.Drawing.Size(991, 548);
            this.gc_CCZY.TabIndex = 28;
            this.gc_CCZY.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CCZY});
            // 
            // gv_CCZY
            // 
            this.gv_CCZY.GridControl = this.gc_CCZY;
            this.gv_CCZY.Name = "gv_CCZY";
            this.gv_CCZY.OptionsBehavior.Editable = false;
            this.gv_CCZY.OptionsView.ColumnAutoWidth = false;
            this.gv_CCZY.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.dte_End1);
            this.panelControl3.Controls.Add(this.dte_Begin1);
            this.panelControl3.Controls.Add(this.btn_Query_ZY);
            this.panelControl3.Controls.Add(this.txt_BatchNo2);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Controls.Add(this.labelControl8);
            this.panelControl3.Controls.Add(this.labelControl9);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(991, 37);
            this.panelControl3.TabIndex = 27;
            // 
            // dte_End1
            // 
            this.dte_End1.EditValue = null;
            this.dte_End1.Location = new System.Drawing.Point(230, 8);
            this.dte_End1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dte_End1.Name = "dte_End1";
            this.dte_End1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_End1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_End1.Properties.DisplayFormat.FormatString = "G";
            this.dte_End1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_End1.Properties.EditFormat.FormatString = "G";
            this.dte_End1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_End1.Properties.Mask.EditMask = "G";
            this.dte_End1.Size = new System.Drawing.Size(147, 20);
            this.dte_End1.TabIndex = 19;
            // 
            // dte_Begin1
            // 
            this.dte_Begin1.EditValue = null;
            this.dte_Begin1.Location = new System.Drawing.Point(66, 8);
            this.dte_Begin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dte_Begin1.Name = "dte_Begin1";
            this.dte_Begin1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Begin1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Begin1.Properties.DisplayFormat.FormatString = "G";
            this.dte_Begin1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_Begin1.Properties.EditFormat.FormatString = "G";
            this.dte_Begin1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_Begin1.Properties.Mask.EditMask = "G";
            this.dte_Begin1.Size = new System.Drawing.Size(147, 20);
            this.dte_Begin1.TabIndex = 18;
            // 
            // btn_Query_ZY
            // 
            this.btn_Query_ZY.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query_ZY.Location = new System.Drawing.Point(564, 7);
            this.btn_Query_ZY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Query_ZY.Name = "btn_Query_ZY";
            this.btn_Query_ZY.Size = new System.Drawing.Size(71, 21);
            this.btn_Query_ZY.TabIndex = 17;
            this.btn_Query_ZY.Text = "查询";
            this.btn_Query_ZY.Click += new System.EventHandler(this.btn_Query_ZY_Click);
            // 
            // txt_BatchNo2
            // 
            this.txt_BatchNo2.Location = new System.Drawing.Point(432, 8);
            this.txt_BatchNo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_BatchNo2.Name = "txt_BatchNo2";
            this.txt_BatchNo2.Size = new System.Drawing.Size(128, 20);
            this.txt_BatchNo2.TabIndex = 16;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(393, 11);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 14);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "批号：";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(218, 10);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(9, 14);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "~";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(9, 10);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 14);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "制样时间：";
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(738, 10);
            this.btn_out.Margin = new System.Windows.Forms.Padding(2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(75, 22);
            this.btn_out.TabIndex = 137;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // FrmQR_SYJJJL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 614);
            this.Controls.Add(this.xtraTabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmQR_SYJJJL";
            this.Text = "试样交接记录";
            this.Load += new System.EventHandler(this.FrmQR_SYJJJL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZYXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZYXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Max.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Min.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ZY_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ZY_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ZY_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ZY_Start.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_CCZY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CCZY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gc_ZYXX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ZYXX;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit dt_ZY_End;
        private DevExpress.XtraEditors.DateEdit dt_ZY_Start;
        private DevExpress.XtraEditors.SimpleButton btn_Query_ZY_CG;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gc_CCZY;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CCZY;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.DateEdit dte_End1;
        private DevExpress.XtraEditors.DateEdit dte_Begin1;
        private DevExpress.XtraEditors.SimpleButton btn_Query_ZY;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txt_Batch_Max;
        private DevExpress.XtraEditors.TextEdit txt_Batch_Min;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_out;
    }
}