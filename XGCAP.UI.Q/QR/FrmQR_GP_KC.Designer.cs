namespace XGCAP.UI.Q.QR
{
    partial class FrmQR_GP_KC
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
            this.btn_Edit_Wgt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XGZT = new DevExpress.XtraEditors.SimpleButton();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.gc_KC = new DevExpress.XtraGrid.GridControl();
            this.gv_KC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_TBWL = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TBHSL = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_KC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_TBHSL);
            this.panelControl1.Controls.Add(this.btn_TBWL);
            this.panelControl1.Controls.Add(this.btn_Edit_Wgt);
            this.panelControl1.Controls.Add(this.btn_XGZT);
            this.panelControl1.Controls.Add(this.btn_out);
            this.panelControl1.Controls.Add(this.btn_Query);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(841, 45);
            this.panelControl1.TabIndex = 1;
            // 
            // btn_Edit_Wgt
            // 
            this.btn_Edit_Wgt.ImageUri.Uri = "EditDataSource;Size16x16";
            this.btn_Edit_Wgt.Location = new System.Drawing.Point(298, 11);
            this.btn_Edit_Wgt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Edit_Wgt.Name = "btn_Edit_Wgt";
            this.btn_Edit_Wgt.Size = new System.Drawing.Size(91, 22);
            this.btn_Edit_Wgt.TabIndex = 136;
            this.btn_Edit_Wgt.Text = "修改重量";
            this.btn_Edit_Wgt.Click += new System.EventHandler(this.btn_Edit_Wgt_Click);
            // 
            // btn_XGZT
            // 
            this.btn_XGZT.ImageUri.Uri = "EditDataSource;Size16x16";
            this.btn_XGZT.Location = new System.Drawing.Point(203, 11);
            this.btn_XGZT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_XGZT.Name = "btn_XGZT";
            this.btn_XGZT.Size = new System.Drawing.Size(91, 22);
            this.btn_XGZT.TabIndex = 135;
            this.btn_XGZT.Text = "修改状态";
            this.btn_XGZT.Click += new System.EventHandler(this.btn_XGZT_Click);
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(110, 10);
            this.btn_out.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(75, 22);
            this.btn_out.TabIndex = 135;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(9, 9);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(80, 25);
            this.btn_Query.TabIndex = 1;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // gc_KC
            // 
            this.gc_KC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_KC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_KC.Location = new System.Drawing.Point(0, 45);
            this.gc_KC.MainView = this.gv_KC;
            this.gc_KC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_KC.Name = "gc_KC";
            this.gc_KC.Size = new System.Drawing.Size(841, 441);
            this.gc_KC.TabIndex = 2;
            this.gc_KC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_KC});
            // 
            // gv_KC
            // 
            this.gv_KC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn12});
            this.gv_KC.GridControl = this.gc_KC;
            this.gv_KC.Name = "gv_KC";
            this.gv_KC.OptionsBehavior.Editable = false;
            this.gv_KC.OptionsView.ColumnAutoWidth = false;
            this.gv_KC.OptionsView.ShowFooter = true;
            this.gv_KC.OptionsView.ShowGroupPanel = false;
            this.gv_KC.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gv_KC_RowStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "仓库";
            this.gridColumn1.FieldName = "仓库";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "编码";
            this.gridColumn2.FieldName = "物料号";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "名称";
            this.gridColumn3.FieldName = "物料名称";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "断面";
            this.gridColumn4.FieldName = "规格";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "型号";
            this.gridColumn5.FieldName = "钢种";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "开坯号";
            this.gridColumn6.FieldName = "开坯号";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 8;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "质量等级";
            this.gridColumn7.FieldName = "质量等级";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 9;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "NC账存支数";
            this.gridColumn8.FieldName = "NC账存支数";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NC账存支数", "{0:0.##}")});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 10;
            this.gridColumn8.Width = 132;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "NC账存重量";
            this.gridColumn9.FieldName = "NC账存重量";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NC账存重量", "{0:0.##}")});
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 11;
            this.gridColumn9.Width = 127;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "CAP账存支数";
            this.gridColumn10.FieldName = "CAP账存支数";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CAP账存支数", "{0:0.##}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 12;
            this.gridColumn10.Width = 128;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "CAP账存重量";
            this.gridColumn11.FieldName = "CAP账存重量";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CAP账存重量", "{0:0.##}")});
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 13;
            this.gridColumn11.Width = 152;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "NC与CAP支数账差";
            this.gridColumn16.FieldName = "NC与CAP支数账差";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NC与CAP支数账差", "{0:0.##}")});
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 14;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "NC与CAP重量账差";
            this.gridColumn17.FieldName = "NC与CAP重量账差";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NC与CAP重量账差", "{0:0.##}")});
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 15;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "自由项1";
            this.gridColumn22.FieldName = "自由项1";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 16;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "自由项2";
            this.gridColumn23.FieldName = "自由项2";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 17;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "炉号";
            this.gridColumn18.FieldName = "炉号";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 7;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "定尺";
            this.gridColumn19.FieldName = "定尺";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 5;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "生产时间";
            this.gridColumn12.FieldName = "生产时间";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // btn_TBWL
            // 
            this.btn_TBWL.ImageUri.Uri = "Replace;Size16x16";
            this.btn_TBWL.Location = new System.Drawing.Point(393, 11);
            this.btn_TBWL.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TBWL.Name = "btn_TBWL";
            this.btn_TBWL.Size = new System.Drawing.Size(112, 22);
            this.btn_TBWL.TabIndex = 137;
            this.btn_TBWL.Text = "同步物料编码";
            this.btn_TBWL.Click += new System.EventHandler(this.btn_TBWL_Click);
            // 
            // btn_TBHSL
            // 
            this.btn_TBHSL.ImageUri.Uri = "Replace;Size16x16";
            this.btn_TBHSL.Location = new System.Drawing.Point(509, 12);
            this.btn_TBHSL.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TBHSL.Name = "btn_TBHSL";
            this.btn_TBHSL.Size = new System.Drawing.Size(97, 22);
            this.btn_TBHSL.TabIndex = 138;
            this.btn_TBHSL.Text = "同步换算率";
            this.btn_TBHSL.Click += new System.EventHandler(this.btn_TBHSL_Click);
            // 
            // FrmQR_GP_KC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.gc_KC);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmQR_GP_KC";
            this.Text = "FrmQR_GP_KC";
            this.Load += new System.EventHandler(this.FrmQR_GP_KC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_KC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_out;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraGrid.GridControl gc_KC;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_KC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraEditors.SimpleButton btn_XGZT;
        private DevExpress.XtraEditors.SimpleButton btn_Edit_Wgt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.SimpleButton btn_TBHSL;
        private DevExpress.XtraEditors.SimpleButton btn_TBWL;
    }
}