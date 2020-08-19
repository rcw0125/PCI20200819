namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_XNLR_OLD
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
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.dt_End = new DevExpress.XtraEditors.DateEdit();
            this.dt_Start = new DevExpress.XtraEditors.DateEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gc_ZYXX = new DevExpress.XtraGrid.GridControl();
            this.gv_ZYXX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dt_End_Result = new DevExpress.XtraEditors.DateEdit();
            this.dt_Start_Result = new DevExpress.XtraEditors.DateEdit();
            this.btn_Result = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Batch_Result = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gv_Result = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_Result = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZYXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZYXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.dt_End);
            this.panelControl1.Controls.Add(this.dt_Start);
            this.panelControl1.Controls.Add(this.btn_Query);
            this.panelControl1.Controls.Add(this.txt_BatchNo);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1329, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Apply;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(835, 14);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 28);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(312, 15);
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
            this.dt_End.TabIndex = 19;
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(93, 15);
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
            this.dt_Start.TabIndex = 18;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(755, 14);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 28);
            this.btn_Query.TabIndex = 17;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txt_BatchNo
            // 
            this.txt_BatchNo.Location = new System.Drawing.Point(579, 15);
            this.txt_BatchNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_BatchNo.Name = "txt_BatchNo";
            this.txt_BatchNo.Size = new System.Drawing.Size(171, 24);
            this.txt_BatchNo.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(525, 19);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 18);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "批号：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(295, 18);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 18);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "~";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 18);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 18);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "制样时间：";
            // 
            // gc_ZYXX
            // 
            this.gc_ZYXX.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_ZYXX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_ZYXX.Location = new System.Drawing.Point(0, 51);
            this.gc_ZYXX.MainView = this.gv_ZYXX;
            this.gc_ZYXX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_ZYXX.Name = "gc_ZYXX";
            this.gc_ZYXX.Size = new System.Drawing.Size(1329, 324);
            this.gc_ZYXX.TabIndex = 1;
            this.gc_ZYXX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ZYXX});
            // 
            // gv_ZYXX
            // 
            this.gv_ZYXX.GridControl = this.gc_ZYXX;
            this.gv_ZYXX.Name = "gv_ZYXX";
            this.gv_ZYXX.OptionsView.ColumnAutoWidth = false;
            this.gv_ZYXX.OptionsView.ShowGroupPanel = false;
            this.gv_ZYXX.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gv_ZYXX_CustomRowCellEdit);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 375);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1329, 6);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dt_End_Result);
            this.panelControl2.Controls.Add(this.dt_Start_Result);
            this.panelControl2.Controls.Add(this.btn_Result);
            this.panelControl2.Controls.Add(this.txt_Batch_Result);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 381);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1329, 51);
            this.panelControl2.TabIndex = 3;
            // 
            // dt_End_Result
            // 
            this.dt_End_Result.EditValue = null;
            this.dt_End_Result.Location = new System.Drawing.Point(312, 15);
            this.dt_End_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dt_End_Result.Size = new System.Drawing.Size(196, 24);
            this.dt_End_Result.TabIndex = 19;
            // 
            // dt_Start_Result
            // 
            this.dt_Start_Result.EditValue = null;
            this.dt_Start_Result.Location = new System.Drawing.Point(93, 15);
            this.dt_Start_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dt_Start_Result.Size = new System.Drawing.Size(196, 24);
            this.dt_Start_Result.TabIndex = 18;
            // 
            // btn_Result
            // 
            this.btn_Result.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Result.Location = new System.Drawing.Point(755, 14);
            this.btn_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(75, 28);
            this.btn_Result.TabIndex = 17;
            this.btn_Result.Text = "查询";
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // txt_Batch_Result
            // 
            this.txt_Batch_Result.Location = new System.Drawing.Point(579, 15);
            this.txt_Batch_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Batch_Result.Name = "txt_Batch_Result";
            this.txt_Batch_Result.Size = new System.Drawing.Size(171, 24);
            this.txt_Batch_Result.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(525, 19);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "批号：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(295, 18);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(11, 18);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "~";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 18);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 18);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "录入时间：";
            // 
            // gv_Result
            // 
            this.gv_Result.GridControl = this.gc_Result;
            this.gv_Result.Name = "gv_Result";
            this.gv_Result.OptionsBehavior.Editable = false;
            this.gv_Result.OptionsView.ColumnAutoWidth = false;
            this.gv_Result.OptionsView.ShowGroupPanel = false;
            // 
            // gc_Result
            // 
            this.gc_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Result.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_Result.Location = new System.Drawing.Point(0, 432);
            this.gc_Result.MainView = this.gv_Result;
            this.gc_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_Result.Name = "gc_Result";
            this.gc_Result.Size = new System.Drawing.Size(1329, 336);
            this.gc_Result.TabIndex = 4;
            this.gc_Result.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Result});
            // 
            // FrmQC_XNLR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 768);
            this.Controls.Add(this.gc_Result);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gc_ZYXX);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmQC_XNLR_OLD";
            this.Text = "性能结果录入";
            this.Load += new System.EventHandler(this.FrmQC_XNLR_OLD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZYXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZYXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_End;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraGrid.GridControl gc_ZYXX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ZYXX;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit dt_End_Result;
        private DevExpress.XtraEditors.DateEdit dt_Start_Result;
        private DevExpress.XtraEditors.SimpleButton btn_Result;
        private DevExpress.XtraEditors.TextEdit txt_Batch_Result;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Result;
        private DevExpress.XtraGrid.GridControl gc_Result;
    }
}