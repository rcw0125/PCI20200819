namespace XGCAP.UI.R.RC
{
    partial class FrmRC_TBKPSJ3
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
            this.gc_TBKPSJ = new DevExpress.XtraGrid.GridControl();
            this.gv_TBKPSJ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_out_toExcel1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.dt_PlanEnd = new DevExpress.XtraEditors.DateEdit();
            this.dt_Plan = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TBKPSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TBKPSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_PlanEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_PlanEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_TBKPSJ
            // 
            this.gc_TBKPSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TBKPSJ.Location = new System.Drawing.Point(0, 38);
            this.gc_TBKPSJ.MainView = this.gv_TBKPSJ;
            this.gc_TBKPSJ.Name = "gc_TBKPSJ";
            this.gc_TBKPSJ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemComboBox1});
            this.gc_TBKPSJ.Size = new System.Drawing.Size(1275, 566);
            this.gc_TBKPSJ.TabIndex = 15;
            this.gc_TBKPSJ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_TBKPSJ});
            // 
            // gv_TBKPSJ
            // 
            this.gv_TBKPSJ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn25,
            this.gridColumn1,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn28,
            this.gridColumn5,
            this.gridColumn29,
            this.gridColumn31,
            this.gridColumn33,
            this.gridColumn34,
            this.gridColumn6,
            this.gridColumn20,
            this.gridColumn35,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7});
            this.gv_TBKPSJ.GridControl = this.gc_TBKPSJ;
            this.gv_TBKPSJ.Name = "gv_TBKPSJ";
            this.gv_TBKPSJ.OptionsBehavior.Editable = false;
            this.gv_TBKPSJ.OptionsView.ColumnAutoWidth = false;
            this.gv_TBKPSJ.OptionsView.ShowFooter = true;
            this.gv_TBKPSJ.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "工位";
            this.gridColumn18.FieldName = "C_STA_ID";
            this.gridColumn18.Name = "gridColumn18";
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "工位描述";
            this.gridColumn19.FieldName = "C_STA_DESC";
            this.gridColumn19.Name = "gridColumn19";
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "炉号";
            this.gridColumn25.FieldName = "C_STOVE";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "批号";
            this.gridColumn1.FieldName = "C_BATCH_NO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "支数";
            this.gridColumn26.FieldName = "N_QUA";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_QUA", "{0:0.##}")});
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 7;
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "钢种";
            this.gridColumn27.FieldName = "C_STL_GRD";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 3;
            this.gridColumn27.Width = 45;
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "自由项1";
            this.gridColumn28.FieldName = "C_ZYX1";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 5;
            this.gridColumn28.Width = 110;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "自由项2";
            this.gridColumn5.FieldName = "C_ZYX2";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // gridColumn29
            // 
            this.gridColumn29.Caption = "规格";
            this.gridColumn29.FieldName = "C_SPEC";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 2;
            this.gridColumn29.Width = 45;
            // 
            // gridColumn31
            // 
            this.gridColumn31.Caption = "备注";
            this.gridColumn31.FieldName = "C_REMARK";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.Width = 41;
            // 
            // gridColumn33
            // 
            this.gridColumn33.Caption = "物料名称";
            this.gridColumn33.FieldName = "C_MAT_NAME";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.Width = 166;
            // 
            // gridColumn34
            // 
            this.gridColumn34.Caption = "物料编码";
            this.gridColumn34.FieldName = "C_MAT_CODE";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.Width = 149;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "长度";
            this.gridColumn6.FieldName = "N_LEN";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "重量";
            this.gridColumn20.FieldName = "N_WGT";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_WGT", "{0:0.##}")});
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 8;
            // 
            // gridColumn35
            // 
            this.gridColumn35.Caption = "判定等级";
            this.gridColumn35.FieldName = "C_MAT_TYPE";
            this.gridColumn35.Name = "gridColumn35";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "同步信息";
            this.gridColumn2.FieldName = "N_IF_EXEC_REMARK";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "同步状态";
            this.gridColumn3.FieldName = "N_IF_EXEC_STATUS";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "出炉日期";
            this.gridColumn4.FieldName = "D_START_DATE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 9;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_out_toExcel1);
            this.panelControl3.Controls.Add(this.labelControl20);
            this.panelControl3.Controls.Add(this.dt_PlanEnd);
            this.panelControl3.Controls.Add(this.dt_Plan);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Controls.Add(this.btn_Query);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1275, 38);
            this.panelControl3.TabIndex = 14;
            // 
            // btn_out_toExcel1
            // 
            this.btn_out_toExcel1.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out_toExcel1.Location = new System.Drawing.Point(371, 8);
            this.btn_out_toExcel1.Name = "btn_out_toExcel1";
            this.btn_out_toExcel1.Size = new System.Drawing.Size(61, 23);
            this.btn_out_toExcel1.TabIndex = 244;
            this.btn_out_toExcel1.Text = "导出";
            this.btn_out_toExcel1.Click += new System.EventHandler(this.btn_out_toExcel1_Click);
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(159, 12);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(9, 14);
            this.labelControl20.TabIndex = 212;
            this.labelControl20.Text = "~";
            // 
            // dt_PlanEnd
            // 
            this.dt_PlanEnd.EditValue = null;
            this.dt_PlanEnd.Location = new System.Drawing.Point(179, 10);
            this.dt_PlanEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dt_PlanEnd.Name = "dt_PlanEnd";
            this.dt_PlanEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_PlanEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_PlanEnd.Size = new System.Drawing.Size(98, 20);
            this.dt_PlanEnd.TabIndex = 211;
            // 
            // dt_Plan
            // 
            this.dt_Plan.EditValue = null;
            this.dt_Plan.Location = new System.Drawing.Point(50, 10);
            this.dt_Plan.Margin = new System.Windows.Forms.Padding(2);
            this.dt_Plan.Name = "dt_Plan";
            this.dt_Plan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Plan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Plan.Size = new System.Drawing.Size(98, 20);
            this.dt_Plan.TabIndex = 210;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 209;
            this.labelControl7.Text = "日期";
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(301, 7);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(64, 23);
            this.btn_Query.TabIndex = 201;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "完工日期";
            this.gridColumn7.FieldName = "D_QR_DATE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 10;
            // 
            // FrmRC_TBKPSJ3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 604);
            this.Controls.Add(this.gc_TBKPSJ);
            this.Controls.Add(this.panelControl3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRC_TBKPSJ3";
            this.Text = "FrmRC_TBKPSJ3";
            this.Load += new System.EventHandler(this.FrmRC_TBKPSJ3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TBKPSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TBKPSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_PlanEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_PlanEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_TBKPSJ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TBKPSJ;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.DateEdit dt_PlanEnd;
        private DevExpress.XtraEditors.DateEdit dt_Plan;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btn_out_toExcel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}