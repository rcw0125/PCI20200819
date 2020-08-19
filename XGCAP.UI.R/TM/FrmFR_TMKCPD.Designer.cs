namespace XGCAP.UI.R.TM
{
    partial class FrmFR_TMKCPD
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
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TB = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gc_PCI = new DevExpress.XtraGrid.GridControl();
            this.gv_PCI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_BATCH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gc_TM = new DevExpress.XtraGrid.GridControl();
            this.gv_TM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_TBWWC = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Query);
            this.panelControl1.Controls.Add(this.btn_TBWWC);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btn_TB);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1402, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(13, 9);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(85, 29);
            this.btn_Query.TabIndex = 243;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Refresh;Size16x16";
            this.simpleButton1.Location = new System.Drawing.Point(214, 9);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 29);
            this.simpleButton1.TabIndex = 242;
            this.simpleButton1.Text = "同步条码";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_TB
            // 
            this.btn_TB.ImageUri.Uri = "Refresh;Size16x16";
            this.btn_TB.Location = new System.Drawing.Point(106, 9);
            this.btn_TB.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TB.Name = "btn_TB";
            this.btn_TB.Size = new System.Drawing.Size(100, 29);
            this.btn_TB.TabIndex = 242;
            this.btn_TB.Text = "同步条码";
            this.btn_TB.Click += new System.EventHandler(this.btn_TB_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 52);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(1402, 665);
            this.splitContainer2.SplitterDistance = 622;
            this.splitContainer2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gc_PCI);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 665);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PCI数据";
            // 
            // gc_PCI
            // 
            this.gc_PCI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_PCI.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_PCI.Location = new System.Drawing.Point(3, 21);
            this.gc_PCI.MainView = this.gv_PCI;
            this.gc_PCI.Margin = new System.Windows.Forms.Padding(4);
            this.gc_PCI.Name = "gc_PCI";
            this.gc_PCI.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gc_PCI.Size = new System.Drawing.Size(616, 641);
            this.gc_PCI.TabIndex = 15;
            this.gc_PCI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_PCI});
            // 
            // gv_PCI
            // 
            this.gv_PCI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn14,
            this.gridColumn3,
            this.colC_BATCH_NO,
            this.colC_STL_GRD,
            this.colN_WGT,
            this.colC_STD_CODE,
            this.colC_SPEC,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn19,
            this.gridColumn15});
            this.gv_PCI.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gv_PCI.GridControl = this.gc_PCI;
            this.gv_PCI.Name = "gv_PCI";
            this.gv_PCI.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "质量等级";
            this.gridColumn14.FieldName = "C_JUDGE_LEV_ZH";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "钩号";
            this.gridColumn3.FieldName = "C_TICK_NO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // colC_BATCH_NO
            // 
            this.colC_BATCH_NO.Caption = "批号";
            this.colC_BATCH_NO.FieldName = "C_BATCH_NO";
            this.colC_BATCH_NO.Name = "colC_BATCH_NO";
            this.colC_BATCH_NO.OptionsColumn.AllowEdit = false;
            this.colC_BATCH_NO.Visible = true;
            this.colC_BATCH_NO.VisibleIndex = 0;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.OptionsColumn.AllowEdit = false;
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 2;
            // 
            // colN_WGT
            // 
            this.colN_WGT.Caption = "重量";
            this.colN_WGT.FieldName = "N_WGT";
            this.colN_WGT.Name = "colN_WGT";
            this.colN_WGT.OptionsColumn.AllowEdit = false;
            this.colN_WGT.Visible = true;
            this.colN_WGT.VisibleIndex = 8;
            // 
            // colC_STD_CODE
            // 
            this.colC_STD_CODE.Caption = "执行标准";
            this.colC_STD_CODE.FieldName = "C_STD_CODE";
            this.colC_STD_CODE.Name = "colC_STD_CODE";
            this.colC_STD_CODE.OptionsColumn.AllowEdit = false;
            this.colC_STD_CODE.Visible = true;
            this.colC_STD_CODE.VisibleIndex = 3;
            // 
            // colC_SPEC
            // 
            this.colC_SPEC.Caption = "规格";
            this.colC_SPEC.FieldName = "C_SPEC";
            this.colC_SPEC.Name = "colC_SPEC";
            this.colC_SPEC.OptionsColumn.AllowEdit = false;
            this.colC_SPEC.Visible = true;
            this.colC_SPEC.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "仓库";
            this.gridColumn1.FieldName = "C_LINEWH_CODE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "计划数量";
            this.gridColumn2.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn2.FieldName = "N_SNUM";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.MaxLength = 2;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "数量";
            this.gridColumn19.FieldName = "N_NUM";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 7;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "包装要求";
            this.gridColumn15.FieldName = "C_BZYQ";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gc_TM);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 665);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "条码数据";
            // 
            // gc_TM
            // 
            this.gc_TM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TM.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_TM.Location = new System.Drawing.Point(3, 21);
            this.gc_TM.MainView = this.gv_TM;
            this.gc_TM.Margin = new System.Windows.Forms.Padding(4);
            this.gc_TM.Name = "gc_TM";
            this.gc_TM.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit3});
            this.gc_TM.Size = new System.Drawing.Size(770, 641);
            this.gc_TM.TabIndex = 15;
            this.gc_TM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_TM});
            // 
            // gv_TM
            // 
            this.gv_TM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn25});
            this.gv_TM.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gv_TM.GridControl = this.gc_TM;
            this.gv_TM.Name = "gv_TM";
            this.gv_TM.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "质量等级";
            this.gridColumn13.FieldName = "C_JUDGE_LEV_ZH";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 4;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "批号";
            this.gridColumn16.FieldName = "C_BATCH_NO";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "钢种";
            this.gridColumn17.FieldName = "C_STL_GRD";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "重量";
            this.gridColumn18.FieldName = "N_WGT";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 8;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "执行标准";
            this.gridColumn20.FieldName = "C_STD_CODE";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 2;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "规格";
            this.gridColumn21.FieldName = "C_SPEC";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 3;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "仓库";
            this.gridColumn22.FieldName = "C_LINEWH_CODE";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 9;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "计划数量";
            this.gridColumn23.ColumnEdit = this.repositoryItemTextEdit3;
            this.gridColumn23.FieldName = "N_SNUM";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 7;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Mask.EditMask = "n0";
            this.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit3.MaxLength = 2;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "数量";
            this.gridColumn24.FieldName = "N_NUM";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.OptionsColumn.AllowEdit = false;
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 6;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "包装要求";
            this.gridColumn25.FieldName = "C_BZYQ";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.OptionsColumn.AllowEdit = false;
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 5;
            // 
            // btn_TBWWC
            // 
            this.btn_TBWWC.ImageUri.Uri = "Refresh;Size16x16";
            this.btn_TBWWC.Location = new System.Drawing.Point(322, 9);
            this.btn_TBWWC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TBWWC.Name = "btn_TBWWC";
            this.btn_TBWWC.Size = new System.Drawing.Size(100, 29);
            this.btn_TBWWC.TabIndex = 242;
            this.btn_TBWWC.Text = "同步委外材";
            this.btn_TBWWC.Click += new System.EventHandler(this.btn_TBWWC_Click);
            // 
            // FrmFR_TMKCPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 717);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmFR_TMKCPD";
            this.Text = "FrmFR_TMKCPD";
            this.Load += new System.EventHandler(this.FrmFR_TMKCPD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_PCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_TB;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gc_TM;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TM;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gc_PCI;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PCI;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn colC_BATCH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colN_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_TBWWC;
    }
}