namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_CFXN_CX
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_BatchNo = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Item = new DevExpress.XtraGrid.GridControl();
            this.gv_Item = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_Start = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dt_End = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Batch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Batch)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_Batch);
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(602, 585);
            this.panelControl1.TabIndex = 0;
            // 
            // gc_Batch
            // 
            this.gc_Batch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Batch.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_Batch.Location = new System.Drawing.Point(2, 55);
            this.gc_Batch.MainView = this.gv_Batch;
            this.gc_Batch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_Batch.Name = "gc_Batch";
            this.gc_Batch.Size = new System.Drawing.Size(598, 528);
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
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(598, 53);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(369, 5);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "批号";
            // 
            // txt_BatchNo
            // 
            this.txt_BatchNo.Location = new System.Drawing.Point(397, 5);
            this.txt_BatchNo.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.txt_BatchNo.Name = "txt_BatchNo";
            this.txt_BatchNo.Size = new System.Drawing.Size(100, 20);
            this.txt_BatchNo.TabIndex = 48;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(501, 5);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(63, 22);
            this.btn_Query.TabIndex = 49;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(602, 0);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 585);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_Item);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(607, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(436, 585);
            this.panelControl2.TabIndex = 5;
            // 
            // gc_Item
            // 
            this.gc_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Item.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_Item.Location = new System.Drawing.Point(2, 2);
            this.gc_Item.MainView = this.gv_Item;
            this.gc_Item.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_Item.Name = "gc_Item";
            this.gc_Item.Size = new System.Drawing.Size(432, 581);
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(2, 5);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "生产时间";
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(54, 5);
            this.dt_Start.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
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
            this.dt_Start.TabIndex = 45;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(205, 5);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(9, 14);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "~";
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(218, 5);
            this.dt_End.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
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
            this.dt_End.TabIndex = 46;
            // 
            // FrmQC_CFXN_CX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 585);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmQC_CFXN_CX";
            this.Text = "同步NC成分性能";
            this.Load += new System.EventHandler(this.FrmQC_XNTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Batch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Batch)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
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
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dt_End;
    }
}