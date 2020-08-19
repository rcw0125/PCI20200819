namespace XGCAP.UI.R.RR
{
    partial class FrmRR_WGDBCJL
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
            this.gc_KDZGZ = new DevExpress.XtraGrid.GridControl();
            this.gv_KDZGZ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STOVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_LEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWGTSUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SLABWH_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SLABWH_AREA_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SLABWH_LOC_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_out_toExcel1 = new DevExpress.XtraEditors.SimpleButton();
            this.img_prodLine = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_rq2 = new DevExpress.XtraEditors.DateEdit();
            this.cbo_PutShift = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dt_rq = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn_AllowGrdQuery = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_KDZGZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KDZGZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_prodLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_PutShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_KDZGZ
            // 
            this.gc_KDZGZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_KDZGZ.Location = new System.Drawing.Point(0, 50);
            this.gc_KDZGZ.MainView = this.gv_KDZGZ;
            this.gc_KDZGZ.Name = "gc_KDZGZ";
            this.gc_KDZGZ.Size = new System.Drawing.Size(800, 400);
            this.gc_KDZGZ.TabIndex = 207;
            this.gc_KDZGZ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_KDZGZ});
            // 
            // gv_KDZGZ
            // 
            this.gv_KDZGZ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn6,
            this.colC_STOVE,
            this.colC_STL_GRD,
            this.colC_STD_CODE,
            this.gridColumn3,
            this.gridColumn18,
            this.colN_LEN,
            this.colWGTSUM,
            this.gridColumn4,
            this.colN_WGT,
            this.colC_SLABWH_CODE,
            this.colC_SLABWH_AREA_CODE,
            this.colC_SLABWH_LOC_CODE,
            this.gridColumn5,
            this.gridColumn23,
            this.gridColumn2});
            this.gv_KDZGZ.GridControl = this.gc_KDZGZ;
            this.gv_KDZGZ.Name = "gv_KDZGZ";
            this.gv_KDZGZ.OptionsBehavior.Editable = false;
            this.gv_KDZGZ.OptionsBehavior.ReadOnly = true;
            this.gv_KDZGZ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gv_KDZGZ.OptionsView.ShowFooter = true;
            this.gv_KDZGZ.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "订单号";
            this.gridColumn1.FieldName = "C_ORDER_NO";
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
            this.colC_STOVE.VisibleIndex = 4;
            this.colC_STOVE.Width = 63;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 5;
            this.colC_STL_GRD.Width = 63;
            // 
            // colC_STD_CODE
            // 
            this.colC_STD_CODE.Caption = "自由项1";
            this.colC_STD_CODE.FieldName = "C_FREE_TERM";
            this.colC_STD_CODE.Name = "colC_STD_CODE";
            this.colC_STD_CODE.Visible = true;
            this.colC_STD_CODE.VisibleIndex = 6;
            this.colC_STD_CODE.Width = 63;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "自由项2";
            this.gridColumn3.FieldName = "C_FREE_TERM2";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "批号";
            this.gridColumn18.FieldName = "C_BATCH_NO";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 2;
            // 
            // colN_LEN
            // 
            this.colN_LEN.Caption = "炉号";
            this.colN_LEN.FieldName = "C_STOVE";
            this.colN_LEN.Name = "colN_LEN";
            this.colN_LEN.Visible = true;
            this.colN_LEN.VisibleIndex = 3;
            this.colN_LEN.Width = 63;
            // 
            // colWGTSUM
            // 
            this.colWGTSUM.Caption = "钢坯消耗";
            this.colWGTSUM.FieldName = "CONSUME";
            this.colWGTSUM.Name = "colWGTSUM";
            this.colWGTSUM.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CONSUME", "{0:0.##}")});
            this.colWGTSUM.Visible = true;
            this.colWGTSUM.VisibleIndex = 8;
            this.colWGTSUM.Width = 63;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "完工重量";
            this.gridColumn4.FieldName = "N_PROD_WGT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_PROD_WGT", "{0:0.##}")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 9;
            // 
            // colN_WGT
            // 
            this.colN_WGT.Caption = "合格品";
            this.colN_WGT.FieldName = "N_HG_WGT";
            this.colN_WGT.Name = "colN_WGT";
            this.colN_WGT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_HG_WGT", "{0:0.##}")});
            this.colN_WGT.Visible = true;
            this.colN_WGT.VisibleIndex = 10;
            this.colN_WGT.Width = 63;
            // 
            // colC_SLABWH_CODE
            // 
            this.colC_SLABWH_CODE.Caption = "不合格品";
            this.colC_SLABWH_CODE.FieldName = "N_BHG_WGT";
            this.colC_SLABWH_CODE.Name = "colC_SLABWH_CODE";
            this.colC_SLABWH_CODE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_BHG_WGT", "{0:0.##}")});
            this.colC_SLABWH_CODE.Visible = true;
            this.colC_SLABWH_CODE.VisibleIndex = 11;
            this.colC_SLABWH_CODE.Width = 63;
            // 
            // colC_SLABWH_AREA_CODE
            // 
            this.colC_SLABWH_AREA_CODE.Caption = "协议品";
            this.colC_SLABWH_AREA_CODE.FieldName = "N_XY_WGT";
            this.colC_SLABWH_AREA_CODE.Name = "colC_SLABWH_AREA_CODE";
            this.colC_SLABWH_AREA_CODE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_XY_WGT", "{0:0.##}")});
            this.colC_SLABWH_AREA_CODE.Visible = true;
            this.colC_SLABWH_AREA_CODE.VisibleIndex = 12;
            this.colC_SLABWH_AREA_CODE.Width = 62;
            // 
            // colC_SLABWH_LOC_CODE
            // 
            this.colC_SLABWH_LOC_CODE.Caption = "头尾材";
            this.colC_SLABWH_LOC_CODE.FieldName = "N_TW_WGT";
            this.colC_SLABWH_LOC_CODE.Name = "colC_SLABWH_LOC_CODE";
            this.colC_SLABWH_LOC_CODE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_TW_WGT", "{0:0.##}")});
            this.colC_SLABWH_LOC_CODE.Visible = true;
            this.colC_SLABWH_LOC_CODE.VisibleIndex = 13;
            this.colC_SLABWH_LOC_CODE.Width = 69;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "待判";
            this.gridColumn5.FieldName = "N_DP_WGT";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_DP_WGT", "{0:0.##}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 14;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "成材率";
            this.gridColumn23.FieldName = "R";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "R", "{0:0.##}")});
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 15;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "出炉时间";
            this.gridColumn2.DisplayFormat.FormatString = "G";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "D_PRODUCE_DATE_B";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 16;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_out_toExcel1);
            this.panelControl2.Controls.Add(this.img_prodLine);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.imageComboBoxEdit1);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.dt_rq2);
            this.panelControl2.Controls.Add(this.cbo_PutShift);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.dt_rq);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.btn_AllowGrdQuery);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 50);
            this.panelControl2.TabIndex = 206;
            // 
            // btn_out_toExcel1
            // 
            this.btn_out_toExcel1.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out_toExcel1.Location = new System.Drawing.Point(610, 15);
            this.btn_out_toExcel1.Name = "btn_out_toExcel1";
            this.btn_out_toExcel1.Size = new System.Drawing.Size(61, 23);
            this.btn_out_toExcel1.TabIndex = 243;
            this.btn_out_toExcel1.Text = "导出";
            this.btn_out_toExcel1.Click += new System.EventHandler(this.btn_out_toExcel1_Click);
            // 
            // img_prodLine
            // 
            this.img_prodLine.EditValue = "";
            this.img_prodLine.Location = new System.Drawing.Point(430, 16);
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
            this.labelControl3.Location = new System.Drawing.Point(400, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 230;
            this.labelControl3.Text = "产线";
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.EditValue = "";
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(430, 16);
            this.imageComboBoxEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1)});
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(92, 20);
            this.imageComboBoxEdit1.TabIndex = 231;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(400, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 230;
            this.labelControl2.Text = "产线";
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
            // cbo_PutShift
            // 
            this.cbo_PutShift.EditValue = "";
            this.cbo_PutShift.Location = new System.Drawing.Point(293, 16);
            this.cbo_PutShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_PutShift.Name = "cbo_PutShift";
            this.cbo_PutShift.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_PutShift.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, -1)});
            this.cbo_PutShift.Size = new System.Drawing.Size(92, 20);
            this.cbo_PutShift.TabIndex = 225;
            this.cbo_PutShift.SelectedIndexChanged += new System.EventHandler(this.cbo_PutShift_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(263, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 224;
            this.labelControl4.Text = "班次";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
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
            this.btn_AllowGrdQuery.Location = new System.Drawing.Point(543, 15);
            this.btn_AllowGrdQuery.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_AllowGrdQuery.Name = "btn_AllowGrdQuery";
            this.btn_AllowGrdQuery.Size = new System.Drawing.Size(61, 23);
            this.btn_AllowGrdQuery.TabIndex = 139;
            this.btn_AllowGrdQuery.Text = "查询";
            this.btn_AllowGrdQuery.Click += new System.EventHandler(this.btn_AllowGrdQuery_Click);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "完工日期";
            this.gridColumn6.FieldName = "D_MOD_DT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // FrmRR_WGDBCJL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gc_KDZGZ);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmRR_WGDBCJL";
            this.Text = "FrmRR_WGDBCJL";
            this.Load += new System.EventHandler(this.FrmRR_WGDBCJL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_KDZGZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KDZGZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_prodLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_PutShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_rq.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_KDZGZ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_KDZGZ;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STOVE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colN_LEN;
        private DevExpress.XtraGrid.Columns.GridColumn colWGTSUM;
        private DevExpress.XtraGrid.Columns.GridColumn colN_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SLABWH_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SLABWH_AREA_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SLABWH_LOC_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit dt_rq;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btn_AllowGrdQuery;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_PutShift;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_rq2;
        private DevExpress.XtraEditors.ImageComboBoxEdit img_prodLine;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btn_out_toExcel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}