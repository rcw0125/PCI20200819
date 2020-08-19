namespace XGCAP.UI.P.PR
{
    partial class Frm_PR_ORDER_MONITOR_ROLL
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_out_toExcel1 = new DevExpress.XtraEditors.SimpleButton();
            this.img_prodLine = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_rq2 = new DevExpress.XtraEditors.DateEdit();
            this.dt_rq = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn_AllowGrdQuery = new DevExpress.XtraEditors.SimpleButton();
            this.gc_KDZGZ = new DevExpress.XtraGrid.GridControl();
            this.gv_KDZGZ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STOVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_prodLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_KDZGZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KDZGZ)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_out_toExcel1);
            this.panelControl2.Controls.Add(this.img_prodLine);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.dt_rq2);
            this.panelControl2.Controls.Add(this.dt_rq);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.btn_AllowGrdQuery);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 50);
            this.panelControl2.TabIndex = 207;
            // 
            // btn_out_toExcel1
            // 
            this.btn_out_toExcel1.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out_toExcel1.Location = new System.Drawing.Point(481, 15);
            this.btn_out_toExcel1.Name = "btn_out_toExcel1";
            this.btn_out_toExcel1.Size = new System.Drawing.Size(61, 23);
            this.btn_out_toExcel1.TabIndex = 243;
            this.btn_out_toExcel1.Text = "导出";
            this.btn_out_toExcel1.Click += new System.EventHandler(this.btn_out_toExcel1_Click);
            // 
            // img_prodLine
            // 
            this.img_prodLine.EditValue = "";
            this.img_prodLine.Location = new System.Drawing.Point(301, 16);
            this.img_prodLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_prodLine.Name = "img_prodLine";
            this.img_prodLine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.img_prodLine.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1)});
            this.img_prodLine.Size = new System.Drawing.Size(92, 20);
            this.img_prodLine.TabIndex = 231;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(271, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 230;
            this.labelControl3.Text = "产线";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(147, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 14);
            this.labelControl1.TabIndex = 229;
            this.labelControl1.Text = "-";
            // 
            // dt_rq2
            // 
            this.dt_rq2.EditValue = null;
            this.dt_rq2.Location = new System.Drawing.Point(156, 16);
            this.dt_rq2.Margin = new System.Windows.Forms.Padding(2);
            this.dt_rq2.Name = "dt_rq2";
            this.dt_rq2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_rq2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_rq2.Size = new System.Drawing.Size(98, 20);
            this.dt_rq2.TabIndex = 228;
            // 
            // dt_rq
            // 
            this.dt_rq.EditValue = null;
            this.dt_rq.Location = new System.Drawing.Point(43, 16);
            this.dt_rq.Margin = new System.Windows.Forms.Padding(2);
            this.dt_rq.Name = "dt_rq";
            this.dt_rq.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_rq.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_rq.Size = new System.Drawing.Size(98, 20);
            this.dt_rq.TabIndex = 199;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(14, 19);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 198;
            this.labelControl7.Text = "日期";
            // 
            // btn_AllowGrdQuery
            // 
            this.btn_AllowGrdQuery.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_AllowGrdQuery.Location = new System.Drawing.Point(414, 15);
            this.btn_AllowGrdQuery.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_AllowGrdQuery.Name = "btn_AllowGrdQuery";
            this.btn_AllowGrdQuery.Size = new System.Drawing.Size(61, 23);
            this.btn_AllowGrdQuery.TabIndex = 139;
            this.btn_AllowGrdQuery.Text = "查询";
            this.btn_AllowGrdQuery.Click += new System.EventHandler(this.btn_AllowGrdQuery_Click);
            // 
            // gc_KDZGZ
            // 
            this.gc_KDZGZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_KDZGZ.Location = new System.Drawing.Point(0, 50);
            this.gc_KDZGZ.MainView = this.gv_KDZGZ;
            this.gc_KDZGZ.Name = "gc_KDZGZ";
            this.gc_KDZGZ.Size = new System.Drawing.Size(800, 400);
            this.gc_KDZGZ.TabIndex = 208;
            this.gc_KDZGZ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_KDZGZ});
            // 
            // gv_KDZGZ
            // 
            this.gv_KDZGZ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colC_STOVE,
            this.colC_STL_GRD,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6});
            this.gv_KDZGZ.GridControl = this.gc_KDZGZ;
            this.gv_KDZGZ.GroupCount = 1;
            this.gv_KDZGZ.Name = "gv_KDZGZ";
            this.gv_KDZGZ.OptionsBehavior.Editable = false;
            this.gv_KDZGZ.OptionsBehavior.ReadOnly = true;
            this.gv_KDZGZ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gv_KDZGZ.OptionsView.ShowFooter = true;
            this.gv_KDZGZ.OptionsView.ShowGroupPanel = false;
            this.gv_KDZGZ.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colC_STOVE, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gv_KDZGZ.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gv_KDZGZ_CustomDrawFooterCell);
            this.gv_KDZGZ.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gv_KDZGZ_RowStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "车间";
            this.gridColumn1.FieldName = "C_ROLL_CODE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colC_STOVE
            // 
            this.colC_STOVE.Caption = "规格";
            this.colC_STOVE.FieldName = "C_SPEC";
            this.colC_STOVE.Name = "colC_STOVE";
            this.colC_STOVE.Visible = true;
            this.colC_STOVE.VisibleIndex = 2;
            this.colC_STOVE.Width = 63;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 1;
            this.colC_STL_GRD.Width = 63;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "需求重量";
            this.gridColumn2.FieldName = "N_WGT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_WGT", "{0:0.##}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "完工重量";
            this.gridColumn4.FieldName = "N_PROD_WGT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_PROD_WGT", "{0:0.##}")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "订单执行情况";
            this.gridColumn3.FieldName = "EXEC_WGT";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "线材现存量(吨)";
            this.gridColumn5.FieldName = "STAN_WGT";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "STAN_WGT", "{0:0.##}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "钢坯现存量(吨)";
            this.gridColumn6.FieldName = "STAN_WET2";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // Frm_PR_ORDER_MONITOR_ROLL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gc_KDZGZ);
            this.Controls.Add(this.panelControl2);
            this.Name = "Frm_PR_ORDER_MONITOR_ROLL";
            this.Text = "Frm_PR_ORDER_MONITOR_ROLL";
            this.Load += new System.EventHandler(this.Frm_PR_ORDER_MONITOR_ROLL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_prodLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_KDZGZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KDZGZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_out_toExcel1;
        private DevExpress.XtraEditors.ImageComboBoxEdit img_prodLine;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_rq2;
        private DevExpress.XtraEditors.DateEdit dt_rq;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btn_AllowGrdQuery;
        private DevExpress.XtraGrid.GridControl gc_KDZGZ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_KDZGZ;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STOVE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}