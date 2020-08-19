namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_XNLR_Excel
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
            Common.DxSpreadsheetControlTemplateData dxSpreadsheetControlTemplateData1 = new Common.DxSpreadsheetControlTemplateData();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQC_XNLR_Excel));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.dt_End = new DevExpress.XtraEditors.DateEdit();
            this.dt_Start = new DevExpress.XtraEditors.DateEdit();
            this.btn_Result = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.spreadsheetManager1 = new Common.SpreadsheetManager();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gc_Result = new DevExpress.XtraGrid.GridControl();
            this.gv_Result = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dt_End_Result = new DevExpress.XtraEditors.DateEdit();
            this.dt_Start_Result = new DevExpress.XtraEditors.DateEdit();
            this.txt_Batch_Result = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.controlExprovider1 = new Common.controlExprovider();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Result.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.spreadsheetControl1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1334, 369);
            this.panelControl2.TabIndex = 2;
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(2, 43);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(1330, 324);
            this.spreadsheetControl1.TabIndex = 9;
            dxSpreadsheetControlTemplateData1.Content = resources.GetString("dxSpreadsheetControlTemplateData1.Content");
            this.controlExprovider1.SetTemplateData(this.spreadsheetControl1, dxSpreadsheetControlTemplateData1);
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_Save);
            this.panelControl3.Controls.Add(this.dt_End);
            this.panelControl3.Controls.Add(this.dt_Start);
            this.panelControl3.Controls.Add(this.btn_Result);
            this.panelControl3.Controls.Add(this.txt_BatchNo);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1330, 41);
            this.panelControl3.TabIndex = 8;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Apply;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(614, 11);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(56, 22);
            this.btn_Save.TabIndex = 25;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(225, 12);
            this.dt_End.Margin = new System.Windows.Forms.Padding(2);
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
            this.dt_End.Size = new System.Drawing.Size(147, 20);
            this.dt_End.TabIndex = 19;
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(61, 12);
            this.dt_Start.Margin = new System.Windows.Forms.Padding(2);
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
            this.dt_Start.Size = new System.Drawing.Size(147, 20);
            this.dt_Start.TabIndex = 18;
            // 
            // btn_Result
            // 
            this.btn_Result.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Result.Location = new System.Drawing.Point(554, 11);
            this.btn_Result.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(56, 22);
            this.btn_Result.TabIndex = 17;
            this.btn_Result.Text = "查询";
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // txt_BatchNo
            // 
            this.txt_BatchNo.Location = new System.Drawing.Point(422, 12);
            this.txt_BatchNo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BatchNo.Name = "txt_BatchNo";
            this.txt_BatchNo.Size = new System.Drawing.Size(128, 20);
            this.txt_BatchNo.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(394, 15);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "批号";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(212, 14);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(9, 14);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "~";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 14);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "制样时间";
            // 
            // spreadsheetManager1
            // 
            this.spreadsheetManager1.Control = this.spreadsheetControl1;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 369);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1334, 5);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // gc_Result
            // 
            this.gc_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Result.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Result.Location = new System.Drawing.Point(0, 415);
            this.gc_Result.MainView = this.gv_Result;
            this.gc_Result.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Result.Name = "gc_Result";
            this.gc_Result.Size = new System.Drawing.Size(1334, 321);
            this.gc_Result.TabIndex = 11;
            this.gc_Result.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Result});
            // 
            // gv_Result
            // 
            this.gv_Result.GridControl = this.gc_Result;
            this.gv_Result.Name = "gv_Result";
            this.gv_Result.OptionsBehavior.Editable = false;
            this.gv_Result.OptionsView.ColumnAutoWidth = false;
            this.gv_Result.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dt_End_Result);
            this.panelControl1.Controls.Add(this.dt_Start_Result);
            this.panelControl1.Controls.Add(this.txt_Batch_Result);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.btn_Query);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 374);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1334, 41);
            this.panelControl1.TabIndex = 10;
            // 
            // dt_End_Result
            // 
            this.dt_End_Result.EditValue = null;
            this.dt_End_Result.Location = new System.Drawing.Point(227, 12);
            this.dt_End_Result.Margin = new System.Windows.Forms.Padding(2);
            this.dt_End_Result.Name = "dt_End_Result";
            this.dt_End_Result.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_End_Result.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_End_Result.Properties.DisplayFormat.FormatString = "G";
            this.dt_End_Result.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_End_Result.Properties.EditFormat.FormatString = "G";
            this.dt_End_Result.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_End_Result.Properties.Mask.EditMask = "G";
            this.dt_End_Result.Size = new System.Drawing.Size(147, 20);
            this.dt_End_Result.TabIndex = 25;
            // 
            // dt_Start_Result
            // 
            this.dt_Start_Result.EditValue = null;
            this.dt_Start_Result.Location = new System.Drawing.Point(63, 11);
            this.dt_Start_Result.Margin = new System.Windows.Forms.Padding(2);
            this.dt_Start_Result.Name = "dt_Start_Result";
            this.dt_Start_Result.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Start_Result.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Start_Result.Properties.DisplayFormat.FormatString = "G";
            this.dt_Start_Result.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Start_Result.Properties.EditFormat.FormatString = "G";
            this.dt_Start_Result.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Start_Result.Properties.Mask.EditMask = "G";
            this.dt_Start_Result.Size = new System.Drawing.Size(147, 20);
            this.dt_Start_Result.TabIndex = 24;
            // 
            // txt_Batch_Result
            // 
            this.txt_Batch_Result.Location = new System.Drawing.Point(424, 11);
            this.txt_Batch_Result.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Batch_Result.Name = "txt_Batch_Result";
            this.txt_Batch_Result.Size = new System.Drawing.Size(128, 20);
            this.txt_Batch_Result.TabIndex = 23;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(396, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "批号";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(214, 13);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(9, 14);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "~";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 13);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "录入时间";
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(556, 10);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(56, 22);
            this.btn_Query.TabIndex = 17;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // FrmQC_XNLR_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 736);
            this.Controls.Add(this.gc_Result);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQC_XNLR_Excel";
            this.Text = "性能结果录入";
            this.Load += new System.EventHandler(this.FrmQC_XNLR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Result.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.DateEdit dt_End;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraEditors.SimpleButton btn_Result;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Common.SpreadsheetManager spreadsheetManager1;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl gc_Result;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Result;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.DateEdit dt_End_Result;
        private DevExpress.XtraEditors.DateEdit dt_Start_Result;
        private DevExpress.XtraEditors.TextEdit txt_Batch_Result;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Common.controlExprovider controlExprovider1;
    }
}