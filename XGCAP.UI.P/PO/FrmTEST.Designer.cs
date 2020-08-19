namespace XGCAP.UI.P.PO
{
    partial class FrmTEST
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_info = new DevExpress.XtraEditors.LabelControl();
            this.btn_query = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.icbo_lz3 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.modTPPLGPCLSBBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colN_SORT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_CCM_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_ORDER_LS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_ZJCLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_ZJCLZL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_PRODUCE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_DFP_HL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_HL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_RH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_XM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_BY3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_GROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_lz3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modTPPLGPCLSBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_info);
            this.panel3.Controls.Add(this.btn_query);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.icbo_lz3);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 53);
            this.panel3.TabIndex = 200;
            // 
            // lbl_info
            // 
            this.lbl_info.Location = new System.Drawing.Point(12, 33);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 14);
            this.lbl_info.TabIndex = 0;
            // 
            // btn_query
            // 
            this.btn_query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_query.Location = new System.Drawing.Point(154, 6);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(61, 23);
            this.btn_query.TabIndex = 190;
            this.btn_query.Text = "查询";
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "连铸";
            // 
            // icbo_lz3
            // 
            this.icbo_lz3.Location = new System.Drawing.Point(42, 7);
            this.icbo_lz3.Name = "icbo_lz3";
            this.icbo_lz3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbo_lz3.Size = new System.Drawing.Size(104, 20);
            this.icbo_lz3.TabIndex = 189;
            // 
            // btn_save
            // 
            this.btn_save.ImageUri.Uri = "SaveAndNew;Size16x16";
            this.btn_save.Location = new System.Drawing.Point(221, 6);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 23);
            this.btn_save.TabIndex = 191;
            this.btn_save.Text = "下发计划";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.modTPPLGPCLSBBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(783, 388);
            this.gridControl1.TabIndex = 201;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // modTPPLGPCLSBBindingSource
            // 
            this.modTPPLGPCLSBBindingSource.DataSource = typeof(MODEL.Mod_TPP_LGPC_LSB);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colN_SORT,
            this.colC_STL_GRD,
            this.colC_CCM_CODE,
            this.colN_ORDER_LS,
            this.colN_ZJCLS,
            this.colN_ZJCLZL,
            this.colN_PRODUCE_TIME,
            this.colC_DFP_HL,
            this.colC_HL,
            this.colC_RH,
            this.colC_XM,
            this.colC_BY3,
            this.colN_GROUP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colN_SORT
            // 
            this.colN_SORT.Caption = "排序号";
            this.colN_SORT.FieldName = "N_SORT";
            this.colN_SORT.Name = "colN_SORT";
            this.colN_SORT.OptionsColumn.AllowEdit = false;
            this.colN_SORT.Visible = true;
            this.colN_SORT.VisibleIndex = 12;
            this.colN_SORT.Width = 53;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colC_STL_GRD.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colC_STL_GRD.AppearanceCell.Options.UseFont = true;
            this.colC_STL_GRD.AppearanceCell.Options.UseForeColor = true;
            this.colC_STL_GRD.AppearanceCell.Options.UseTextOptions = true;
            this.colC_STL_GRD.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colC_STL_GRD.Caption = "牌号";
            this.colC_STL_GRD.FieldName = "C_REMARK";
            this.colC_STL_GRD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colC_STL_GRD.MinWidth = 200;
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.OptionsColumn.AllowEdit = false;
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 0;
            this.colC_STL_GRD.Width = 300;
            // 
            // colC_CCM_CODE
            // 
            this.colC_CCM_CODE.Caption = "连铸";
            this.colC_CCM_CODE.FieldName = "C_CCM_CODE";
            this.colC_CCM_CODE.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colC_CCM_CODE.Name = "colC_CCM_CODE";
            this.colC_CCM_CODE.OptionsColumn.AllowEdit = false;
            this.colC_CCM_CODE.Visible = true;
            this.colC_CCM_CODE.VisibleIndex = 1;
            this.colC_CCM_CODE.Width = 46;
            // 
            // colN_ORDER_LS
            // 
            this.colN_ORDER_LS.Caption = "订单炉数";
            this.colN_ORDER_LS.FieldName = "N_ORDER_LS";
            this.colN_ORDER_LS.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colN_ORDER_LS.Name = "colN_ORDER_LS";
            this.colN_ORDER_LS.OptionsColumn.AllowEdit = false;
            this.colN_ORDER_LS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_ORDER_LS", "{0:0.##}")});
            this.colN_ORDER_LS.Visible = true;
            this.colN_ORDER_LS.VisibleIndex = 2;
            this.colN_ORDER_LS.Width = 62;
            // 
            // colN_ZJCLS
            // 
            this.colN_ZJCLS.Caption = "整浇次炉数";
            this.colN_ZJCLS.FieldName = "N_ZJCLS";
            this.colN_ZJCLS.Name = "colN_ZJCLS";
            this.colN_ZJCLS.OptionsColumn.AllowEdit = false;
            this.colN_ZJCLS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_ZJCLS", "{0:0.##}")});
            this.colN_ZJCLS.Visible = true;
            this.colN_ZJCLS.VisibleIndex = 3;
            this.colN_ZJCLS.Width = 72;
            // 
            // colN_ZJCLZL
            // 
            this.colN_ZJCLZL.Caption = "整浇次重量";
            this.colN_ZJCLZL.FieldName = "N_ZJCLZL";
            this.colN_ZJCLZL.Name = "colN_ZJCLZL";
            this.colN_ZJCLZL.OptionsColumn.AllowEdit = false;
            this.colN_ZJCLZL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_ZJCLZL", "{0:0.##}")});
            this.colN_ZJCLZL.Visible = true;
            this.colN_ZJCLZL.VisibleIndex = 4;
            this.colN_ZJCLZL.Width = 77;
            // 
            // colN_PRODUCE_TIME
            // 
            this.colN_PRODUCE_TIME.Caption = "停机(h)";
            this.colN_PRODUCE_TIME.FieldName = "N_PRODUCE_TIME";
            this.colN_PRODUCE_TIME.Name = "colN_PRODUCE_TIME";
            this.colN_PRODUCE_TIME.Visible = true;
            this.colN_PRODUCE_TIME.VisibleIndex = 5;
            // 
            // colC_DFP_HL
            // 
            this.colC_DFP_HL.Caption = "大方坯缓冷";
            this.colC_DFP_HL.FieldName = "C_DFP_HL";
            this.colC_DFP_HL.Name = "colC_DFP_HL";
            this.colC_DFP_HL.OptionsColumn.AllowEdit = false;
            this.colC_DFP_HL.Visible = true;
            this.colC_DFP_HL.VisibleIndex = 6;
            // 
            // colC_HL
            // 
            this.colC_HL.Caption = "热轧坯缓冷";
            this.colC_HL.FieldName = "C_HL";
            this.colC_HL.Name = "colC_HL";
            this.colC_HL.OptionsColumn.AllowEdit = false;
            this.colC_HL.Visible = true;
            this.colC_HL.VisibleIndex = 7;
            // 
            // colC_RH
            // 
            this.colC_RH.Caption = "是否真空";
            this.colC_RH.FieldName = "C_RH";
            this.colC_RH.Name = "colC_RH";
            this.colC_RH.OptionsColumn.AllowEdit = false;
            this.colC_RH.Visible = true;
            this.colC_RH.VisibleIndex = 8;
            // 
            // colC_XM
            // 
            this.colC_XM.Caption = "修磨要求";
            this.colC_XM.FieldName = "C_XM";
            this.colC_XM.Name = "colC_XM";
            this.colC_XM.OptionsColumn.AllowEdit = false;
            this.colC_XM.Visible = true;
            this.colC_XM.VisibleIndex = 9;
            // 
            // colC_BY3
            // 
            this.colC_BY3.Caption = "标识";
            this.colC_BY3.FieldName = "C_BY3";
            this.colC_BY3.Name = "colC_BY3";
            this.colC_BY3.OptionsColumn.AllowEdit = false;
            this.colC_BY3.Visible = true;
            this.colC_BY3.VisibleIndex = 10;
            // 
            // colN_GROUP
            // 
            this.colN_GROUP.Caption = "组号";
            this.colN_GROUP.FieldName = "N_GROUP";
            this.colN_GROUP.Name = "colN_GROUP";
            this.colN_GROUP.OptionsColumn.AllowEdit = false;
            this.colN_GROUP.Visible = true;
            this.colN_GROUP.VisibleIndex = 11;
            // 
            // FrmTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 441);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmTEST";
            this.Text = "FrmTEST";
            this.Load += new System.EventHandler(this.FrmTEST_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_lz3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modTPPLGPCLSBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lbl_info;
        private DevExpress.XtraEditors.SimpleButton btn_query;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbo_lz3;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colN_SORT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colC_CCM_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colN_ORDER_LS;
        private DevExpress.XtraGrid.Columns.GridColumn colN_ZJCLS;
        private DevExpress.XtraGrid.Columns.GridColumn colN_ZJCLZL;
        private DevExpress.XtraGrid.Columns.GridColumn colN_PRODUCE_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_DFP_HL;
        private DevExpress.XtraGrid.Columns.GridColumn colC_HL;
        private DevExpress.XtraGrid.Columns.GridColumn colC_RH;
        private DevExpress.XtraGrid.Columns.GridColumn colC_XM;
        private DevExpress.XtraGrid.Columns.GridColumn colC_BY3;
        private DevExpress.XtraGrid.Columns.GridColumn colN_GROUP;
        private System.Windows.Forms.BindingSource modTPPLGPCLSBBindingSource;
    }
}