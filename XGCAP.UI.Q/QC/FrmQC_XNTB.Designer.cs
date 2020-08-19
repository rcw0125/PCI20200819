namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_XNTB
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
            this.gc_Batch = new DevExpress.XtraGrid.GridControl();
            this.gv_Batch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_Start = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dt_End = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_BatchNo = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Tb = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Item = new DevExpress.XtraGrid.GridControl();
            this.gv_Item = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.gc_Item_NC = new DevExpress.XtraGrid.GridControl();
            this.gv_Item_NC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Batch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Batch)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item_NC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item_NC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_Batch);
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(495, 731);
            this.panelControl1.TabIndex = 0;
            // 
            // gc_Batch
            // 
            this.gc_Batch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Batch.Location = new System.Drawing.Point(2, 68);
            this.gc_Batch.MainView = this.gv_Batch;
            this.gc_Batch.Name = "gc_Batch";
            this.gc_Batch.Size = new System.Drawing.Size(491, 661);
            this.gc_Batch.TabIndex = 1;
            this.gc_Batch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Batch});
            // 
            // gv_Batch
            // 
            this.gv_Batch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn14});
            this.gv_Batch.GridControl = this.gc_Batch;
            this.gv_Batch.Name = "gv_Batch";
            this.gv_Batch.OptionsBehavior.Editable = false;
            this.gv_Batch.OptionsView.ColumnAutoWidth = false;
            this.gv_Batch.OptionsView.ShowGroupPanel = false;
            this.gv_Batch.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Batch_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "批号";
            this.gridColumn1.FieldName = "C_BATCH_NO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "物料编码";
            this.gridColumn2.FieldName = "C_MAT_CODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "物料名称";
            this.gridColumn3.FieldName = "C_MAT_DESC";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "钢种";
            this.gridColumn4.FieldName = "C_STL_GRD";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "执行标准";
            this.gridColumn5.FieldName = "C_STD_CODE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "生产时间";
            this.gridColumn14.FieldName = "D_PRODUCE_DATE";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelControl1);
            this.flowLayoutPanel1.Controls.Add(this.dt_Start);
            this.flowLayoutPanel1.Controls.Add(this.labelControl2);
            this.flowLayoutPanel1.Controls.Add(this.dt_End);
            this.flowLayoutPanel1.Controls.Add(this.labelControl4);
            this.flowLayoutPanel1.Controls.Add(this.txt_BatchNo);
            this.flowLayoutPanel1.Controls.Add(this.btn_Query);
            this.flowLayoutPanel1.Controls.Add(this.btn_Tb);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 66);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "生产时间";
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(69, 2);
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
            this.dt_Start.TabIndex = 45;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(271, 2);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 18);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "~";
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(288, 2);
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
            this.dt_End.TabIndex = 46;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 30);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 18);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "批号";
            // 
            // txt_BatchNo
            // 
            this.txt_BatchNo.Location = new System.Drawing.Point(39, 30);
            this.txt_BatchNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_BatchNo.Name = "txt_BatchNo";
            this.txt_BatchNo.Size = new System.Drawing.Size(133, 24);
            this.txt_BatchNo.TabIndex = 48;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(178, 30);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 28);
            this.btn_Query.TabIndex = 49;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Tb
            // 
            this.btn_Tb.ImageUri.Uri = "Recurrence;Size16x16";
            this.btn_Tb.Location = new System.Drawing.Point(259, 30);
            this.btn_Tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tb.Name = "btn_Tb";
            this.btn_Tb.Size = new System.Drawing.Size(102, 28);
            this.btn_Tb.TabIndex = 50;
            this.btn_Tb.Text = "同步NC";
            this.btn_Tb.Click += new System.EventHandler(this.btn_Tb_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(495, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 731);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_Item);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(501, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(510, 731);
            this.panelControl2.TabIndex = 5;
            // 
            // gc_Item
            // 
            this.gc_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Item.Location = new System.Drawing.Point(2, 68);
            this.gc_Item.MainView = this.gv_Item;
            this.gc_Item.Name = "gc_Item";
            this.gc_Item.Size = new System.Drawing.Size(506, 661);
            this.gc_Item.TabIndex = 4;
            this.gc_Item.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Item});
            // 
            // gv_Item
            // 
            this.gv_Item.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gv_Item.GridControl = this.gc_Item;
            this.gv_Item.Name = "gv_Item";
            this.gv_Item.OptionsBehavior.Editable = false;
            this.gv_Item.OptionsView.ColumnAutoWidth = false;
            this.gv_Item.OptionsView.ShowGroupPanel = false;
            this.gv_Item.OptionsView.ShowViewCaption = true;
            this.gv_Item.ViewCaption = "成分性能明细";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "项目代码";
            this.gridColumn6.FieldName = "C_CODE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "项目名称";
            this.gridColumn7.FieldName = "C_NAME";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "项目值";
            this.gridColumn8.FieldName = "C_VALUE";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "样品编码";
            this.gridColumn9.FieldName = "SAMCODE";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_Delete);
            this.panelControl3.Controls.Add(this.btn_Add);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(506, 66);
            this.panelControl3.TabIndex = 3;
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(18, 20);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 28);
            this.btn_Add.TabIndex = 50;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // splitterControl2
            // 
            this.splitterControl2.Location = new System.Drawing.Point(1011, 0);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(6, 731);
            this.splitterControl2.TabIndex = 6;
            this.splitterControl2.TabStop = false;
            // 
            // gc_Item_NC
            // 
            this.gc_Item_NC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Item_NC.Location = new System.Drawing.Point(1017, 0);
            this.gc_Item_NC.MainView = this.gv_Item_NC;
            this.gc_Item_NC.Name = "gc_Item_NC";
            this.gc_Item_NC.Size = new System.Drawing.Size(374, 731);
            this.gc_Item_NC.TabIndex = 7;
            this.gc_Item_NC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Item_NC});
            // 
            // gv_Item_NC
            // 
            this.gv_Item_NC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            this.gv_Item_NC.GridControl = this.gc_Item_NC;
            this.gv_Item_NC.Name = "gv_Item_NC";
            this.gv_Item_NC.OptionsBehavior.Editable = false;
            this.gv_Item_NC.OptionsView.ColumnAutoWidth = false;
            this.gv_Item_NC.OptionsView.ShowGroupPanel = false;
            this.gv_Item_NC.OptionsView.ShowViewCaption = true;
            this.gv_Item_NC.ViewCaption = "NC成分性能明细";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "项目代码";
            this.gridColumn10.FieldName = "CCHECKITEMCODE";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "项目名称";
            this.gridColumn11.FieldName = "CCHECKITEMNAME";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "项目值";
            this.gridColumn12.FieldName = "CRESULT";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "样品编码";
            this.gridColumn13.FieldName = "VSAMPLECODE";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            // 
            // btn_Delete
            // 
            this.btn_Delete.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Delete.Location = new System.Drawing.Point(121, 20);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 28);
            this.btn_Delete.TabIndex = 51;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // FrmQC_XNTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 731);
            this.Controls.Add(this.gc_Item_NC);
            this.Controls.Add(this.splitterControl2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQC_XNTB";
            this.Text = "同步NC成分性能";
            this.Load += new System.EventHandler(this.FrmQC_XNTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Batch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Batch)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item_NC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item_NC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dt_End;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Tb;
        private DevExpress.XtraGrid.GridControl gc_Batch;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Batch;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gc_Item;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Item;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraGrid.GridControl gc_Item_NC;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Item_NC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
    }
}