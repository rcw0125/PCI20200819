namespace XGCAP.UI.P.PO.GPKWT
{
    partial class FrmPO_GPKWT_VIEW
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Select = new DevExpress.XtraEditors.SimpleButton();
            this.icbo_CK = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gc_GPSJ = new DevExpress.XtraGrid.GridControl();
            this.gv_GPSJ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.C_STA_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STOVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_LEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.N_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MAT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MAT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.D_WE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_CK.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPSJ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_Select);
            this.panel1.Controls.Add(this.icbo_CK);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 38);
            this.panel1.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Open;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(311, 7);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(85, 23);
            this.btn_Save.TabIndex = 27;
            this.btn_Save.Text = "钢坯查询";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Select.Location = new System.Drawing.Point(230, 7);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 23);
            this.btn_Select.TabIndex = 26;
            this.btn_Select.Text = "查询";
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // icbo_CK
            // 
            this.icbo_CK.Location = new System.Drawing.Point(39, 10);
            this.icbo_CK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.icbo_CK.Name = "icbo_CK";
            this.icbo_CK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbo_CK.Size = new System.Drawing.Size(186, 20);
            this.icbo_CK.TabIndex = 18;
            this.icbo_CK.SelectedIndexChanged += new System.EventHandler(this.icbo_CK_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "仓库";
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(6, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1500, 1500);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 601);
            this.panel3.TabIndex = 6;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(686, 38);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 601);
            this.splitterControl1.TabIndex = 7;
            this.splitterControl1.TabStop = false;
            // 
            // gc_GPSJ
            // 
            this.gc_GPSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GPSJ.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_GPSJ.Location = new System.Drawing.Point(691, 38);
            this.gc_GPSJ.MainView = this.gv_GPSJ;
            this.gc_GPSJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_GPSJ.Name = "gc_GPSJ";
            this.gc_GPSJ.Size = new System.Drawing.Size(470, 601);
            this.gc_GPSJ.TabIndex = 13;
            this.gc_GPSJ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GPSJ});
            // 
            // gv_GPSJ
            // 
            this.gv_GPSJ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.C_STA_DESC,
            this.colC_STOVE,
            this.colC_STL_GRD,
            this.colC_SPEC,
            this.colN_LEN,
            this.N_WGT,
            this.colC_STD_CODE,
            this.colC_MAT_CODE,
            this.colC_MAT_NAME,
            this.D_WE_DATE,
            this.COU,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gv_GPSJ.GridControl = this.gc_GPSJ;
            this.gv_GPSJ.Name = "gv_GPSJ";
            this.gv_GPSJ.OptionsBehavior.Editable = false;
            this.gv_GPSJ.OptionsView.ColumnAutoWidth = false;
            this.gv_GPSJ.OptionsView.ShowFooter = true;
            this.gv_GPSJ.OptionsView.ShowGroupPanel = false;
            // 
            // C_STA_DESC
            // 
            this.C_STA_DESC.Caption = "铸机号";
            this.C_STA_DESC.FieldName = "C_STA_DESC";
            this.C_STA_DESC.Name = "C_STA_DESC";
            // 
            // colC_STOVE
            // 
            this.colC_STOVE.Caption = "炉号";
            this.colC_STOVE.FieldName = "C_STOVE";
            this.colC_STOVE.Name = "colC_STOVE";
            this.colC_STOVE.Visible = true;
            this.colC_STOVE.VisibleIndex = 0;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 2;
            // 
            // colC_SPEC
            // 
            this.colC_SPEC.Caption = "断面";
            this.colC_SPEC.FieldName = "C_SPEC";
            this.colC_SPEC.Name = "colC_SPEC";
            this.colC_SPEC.Visible = true;
            this.colC_SPEC.VisibleIndex = 4;
            // 
            // colN_LEN
            // 
            this.colN_LEN.Caption = "定尺";
            this.colN_LEN.FieldName = "N_LEN";
            this.colN_LEN.Name = "colN_LEN";
            this.colN_LEN.Visible = true;
            this.colN_LEN.VisibleIndex = 5;
            // 
            // N_WGT
            // 
            this.N_WGT.Caption = "重量";
            this.N_WGT.FieldName = "N_WGT";
            this.N_WGT.Name = "N_WGT";
            this.N_WGT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_WGT", "{0:0.##}")});
            this.N_WGT.Visible = true;
            this.N_WGT.VisibleIndex = 7;
            // 
            // colC_STD_CODE
            // 
            this.colC_STD_CODE.Caption = "执行标准";
            this.colC_STD_CODE.FieldName = "C_STD_CODE";
            this.colC_STD_CODE.Name = "colC_STD_CODE";
            this.colC_STD_CODE.Visible = true;
            this.colC_STD_CODE.VisibleIndex = 3;
            // 
            // colC_MAT_CODE
            // 
            this.colC_MAT_CODE.Caption = "物料编码";
            this.colC_MAT_CODE.FieldName = "C_MAT_CODE";
            this.colC_MAT_CODE.Name = "colC_MAT_CODE";
            this.colC_MAT_CODE.Visible = true;
            this.colC_MAT_CODE.VisibleIndex = 14;
            // 
            // colC_MAT_NAME
            // 
            this.colC_MAT_NAME.Caption = "物料描述";
            this.colC_MAT_NAME.DisplayFormat.FormatString = "G";
            this.colC_MAT_NAME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colC_MAT_NAME.FieldName = "C_MAT_NAME";
            this.colC_MAT_NAME.Name = "colC_MAT_NAME";
            this.colC_MAT_NAME.Visible = true;
            this.colC_MAT_NAME.VisibleIndex = 15;
            // 
            // D_WE_DATE
            // 
            this.D_WE_DATE.Caption = "入库时间";
            this.D_WE_DATE.DisplayFormat.FormatString = "G";
            this.D_WE_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.D_WE_DATE.FieldName = "DT";
            this.D_WE_DATE.Name = "D_WE_DATE";
            this.D_WE_DATE.Visible = true;
            this.D_WE_DATE.VisibleIndex = 8;
            // 
            // COU
            // 
            this.COU.Caption = "支数";
            this.COU.FieldName = "COU";
            this.COU.Name = "COU";
            this.COU.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "COU", "{0:0.##}")});
            this.COU.Visible = true;
            this.COU.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "开坯号";
            this.gridColumn1.FieldName = "C_BATCH_NO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "仓库名称";
            this.gridColumn2.FieldName = "C_SLABWH_CODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 11;
            this.gridColumn2.Width = 54;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "区域名称";
            this.gridColumn3.FieldName = "C_SLABWH_AREA_NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 12;
            this.gridColumn3.Width = 45;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "库位名称";
            this.gridColumn4.FieldName = "C_SLABWH_LOC_NAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 13;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "炉数";
            this.gridColumn5.FieldName = "C_SLABWH_TIER_CODE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 9;
            this.gridColumn5.Width = 34;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "区域最大炉数";
            this.gridColumn6.FieldName = "MAX_LOCCODE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 10;
            this.gridColumn6.Width = 31;
            // 
            // FrmPO_GPKWT_VIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 639);
            this.Controls.Add(this.gc_GPSJ);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPO_GPKWT_VIEW";
            this.Text = "钢坯库位图配置";
            this.Load += new System.EventHandler(this.FrmPO_GPKWT_VIEW_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_CK.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPSJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbo_CK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btn_Select;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl gc_GPSJ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GPSJ;
        private DevExpress.XtraGrid.Columns.GridColumn C_STA_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STOVE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colN_LEN;
        private DevExpress.XtraGrid.Columns.GridColumn N_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MAT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MAT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn D_WE_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn COU;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}