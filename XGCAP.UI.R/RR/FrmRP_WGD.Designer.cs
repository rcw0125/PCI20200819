﻿namespace XGCAP.UI.R.RR
{
    partial class FrmRP_WGD
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
            this.btn_out_toExcel1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.dt_PlanEnd = new DevExpress.XtraEditors.DateEdit();
            this.dt_Plan = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn_QueryNC = new DevExpress.XtraEditors.SimpleButton();
            this.gc_NC = new DevExpress.XtraGrid.GridControl();
            this.gv_NC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.icbo_ZX = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_PlanEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_PlanEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_ZX.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.icbo_ZX);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.btn_out_toExcel1);
            this.panelControl1.Controls.Add(this.labelControl20);
            this.panelControl1.Controls.Add(this.dt_PlanEnd);
            this.panelControl1.Controls.Add(this.dt_Plan);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.btn_QueryNC);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1504, 48);
            this.panelControl1.TabIndex = 14;
            // 
            // btn_out_toExcel1
            // 
            this.btn_out_toExcel1.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out_toExcel1.Location = new System.Drawing.Point(682, 9);
            this.btn_out_toExcel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_out_toExcel1.Name = "btn_out_toExcel1";
            this.btn_out_toExcel1.Size = new System.Drawing.Size(81, 29);
            this.btn_out_toExcel1.TabIndex = 243;
            this.btn_out_toExcel1.Text = "导出";
            this.btn_out_toExcel1.Click += new System.EventHandler(this.btn_out_toExcel1_Click);
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(223, 18);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(11, 18);
            this.labelControl20.TabIndex = 208;
            this.labelControl20.Text = "~";
            // 
            // dt_PlanEnd
            // 
            this.dt_PlanEnd.EditValue = null;
            this.dt_PlanEnd.Location = new System.Drawing.Point(255, 14);
            this.dt_PlanEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_PlanEnd.Name = "dt_PlanEnd";
            this.dt_PlanEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_PlanEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_PlanEnd.Size = new System.Drawing.Size(131, 24);
            this.dt_PlanEnd.TabIndex = 207;
            // 
            // dt_Plan
            // 
            this.dt_Plan.EditValue = null;
            this.dt_Plan.Location = new System.Drawing.Point(72, 14);
            this.dt_Plan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Plan.Name = "dt_Plan";
            this.dt_Plan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Plan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Plan.Size = new System.Drawing.Size(131, 24);
            this.dt_Plan.TabIndex = 206;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(20, 18);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 18);
            this.labelControl7.TabIndex = 205;
            this.labelControl7.Text = "日期";
            // 
            // btn_QueryNC
            // 
            this.btn_QueryNC.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_QueryNC.Location = new System.Drawing.Point(591, 9);
            this.btn_QueryNC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_QueryNC.Name = "btn_QueryNC";
            this.btn_QueryNC.Size = new System.Drawing.Size(83, 29);
            this.btn_QueryNC.TabIndex = 201;
            this.btn_QueryNC.Text = "查询";
            this.btn_QueryNC.Click += new System.EventHandler(this.btn_QueryNC_Click);
            // 
            // gc_NC
            // 
            this.gc_NC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_NC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gc_NC.Location = new System.Drawing.Point(0, 48);
            this.gc_NC.MainView = this.gv_NC;
            this.gc_NC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gc_NC.Name = "gc_NC";
            this.gc_NC.Size = new System.Drawing.Size(1504, 656);
            this.gc_NC.TabIndex = 15;
            this.gc_NC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NC});
            // 
            // gv_NC
            // 
            this.gv_NC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn2,
            this.gridColumn15,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn1,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18});
            this.gv_NC.GridControl = this.gc_NC;
            this.gv_NC.Name = "gv_NC";
            this.gv_NC.OptionsBehavior.ReadOnly = true;
            this.gv_NC.OptionsView.ColumnAutoWidth = false;
            this.gv_NC.OptionsView.ShowFooter = true;
            this.gv_NC.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "完工单号";
            this.gridColumn3.FieldName = "C_MAIN_ID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "轧钢批次号";
            this.gridColumn4.FieldName = "C_BATCH_NO";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "开坯批次号";
            this.gridColumn2.FieldName = "C_PLANT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "炼钢批次号";
            this.gridColumn15.FieldName = "C_STOVE";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "状态";
            this.gridColumn5.FieldName = "ZJBstatus";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "包装要求";
            this.gridColumn6.FieldName = "C_PACK";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 10;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "自由项";
            this.gridColumn7.FieldName = "C_FREE_TERM";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "自由项2";
            this.gridColumn8.FieldName = "C_FREE_TERM2";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "时间";
            this.gridColumn9.FieldName = "D_MOD_DT";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "钢种";
            this.gridColumn10.FieldName = "C_STL_GRD";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "规格";
            this.gridColumn11.FieldName = "C_SPEC";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "执行标准";
            this.gridColumn12.FieldName = "C_STD_CODE";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "同步信息";
            this.gridColumn13.FieldName = "N_IF_EXEC_REMARK";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "同步状态";
            this.gridColumn14.FieldName = "N_IF_EXEC_STATUS";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "出炉日期";
            this.gridColumn1.FieldName = "D_PRODUCE_DATE_B";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "重量";
            this.gridColumn16.FieldName = "WGTS";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WGTS", "{0:0.##}")});
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 9;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "支数";
            this.gridColumn17.FieldName = "QUA";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QUA", "{0:0.##}")});
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 8;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "完工日期";
            this.gridColumn18.FieldName = "D_MOD_DT";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 12;
            // 
            // icbo_ZX
            // 
            this.icbo_ZX.Location = new System.Drawing.Point(444, 13);
            this.icbo_ZX.Margin = new System.Windows.Forms.Padding(4);
            this.icbo_ZX.Name = "icbo_ZX";
            this.icbo_ZX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbo_ZX.Size = new System.Drawing.Size(131, 24);
            this.icbo_ZX.TabIndex = 245;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(403, 17);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 18);
            this.labelControl5.TabIndex = 244;
            this.labelControl5.Text = "轧线";
            // 
            // FrmRP_WGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 704);
            this.Controls.Add(this.gc_NC);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRP_WGD";
            this.Text = "FrmRP_WGD";
            this.Load += new System.EventHandler(this.FrmRP_WGD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_PlanEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_PlanEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_ZX.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_QueryNC;
        private DevExpress.XtraGrid.GridControl gc_NC;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.DateEdit dt_PlanEnd;
        private DevExpress.XtraEditors.DateEdit dt_Plan;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraEditors.SimpleButton btn_out_toExcel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbo_ZX;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}