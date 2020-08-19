namespace XGCAP.UI.P.PQ
{
    partial class FrmPQ_GPFYZCMX
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gc_GP = new DevExpress.XtraGrid.GridControl();
            this.gv_GP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_STOVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_QUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SLABWH_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txt_CPH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.gc_BH = new DevExpress.XtraGrid.GridControl();
            this.gv_BH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CPH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_BH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BH)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gc_GP);
            this.splitContainer1.Panel1.Controls.Add(this.panelControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gc_BH);
            this.splitContainer1.Size = new System.Drawing.Size(1405, 683);
            this.splitContainer1.SplitterDistance = 511;
            this.splitContainer1.TabIndex = 1;
            // 
            // gc_GP
            // 
            this.gc_GP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GP.Location = new System.Drawing.Point(0, 68);
            this.gc_GP.MainView = this.gv_GP;
            this.gc_GP.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GP.Name = "gc_GP";
            this.gc_GP.Size = new System.Drawing.Size(511, 615);
            this.gc_GP.TabIndex = 212;
            this.gc_GP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GP});
            // 
            // gv_GP
            // 
            this.gv_GP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_STOVE,
            this.colC_STL_GRD,
            this.colC_SPEC,
            this.colN_QUA,
            this.colN_WGT,
            this.colC_SLABWH_CODE,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gv_GP.GridControl = this.gc_GP;
            this.gv_GP.Name = "gv_GP";
            this.gv_GP.OptionsBehavior.Editable = false;
            this.gv_GP.OptionsView.ShowFooter = true;
            this.gv_GP.OptionsView.ShowGroupPanel = false;
            // 
            // colC_STOVE
            // 
            this.colC_STOVE.Caption = "批号";
            this.colC_STOVE.FieldName = "C_BATCH_NO";
            this.colC_STOVE.Name = "colC_STOVE";
            this.colC_STOVE.Width = 63;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Width = 63;
            // 
            // colC_SPEC
            // 
            this.colC_SPEC.Caption = "规格";
            this.colC_SPEC.FieldName = "C_SPEC";
            this.colC_SPEC.Name = "colC_SPEC";
            this.colC_SPEC.Width = 63;
            // 
            // colN_QUA
            // 
            this.colN_QUA.Caption = "件数";
            this.colN_QUA.FieldName = "N_QUA";
            this.colN_QUA.Name = "colN_QUA";
            this.colN_QUA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_QUA", "{0:0.##}")});
            this.colN_QUA.Width = 63;
            // 
            // colN_WGT
            // 
            this.colN_WGT.Caption = "重量";
            this.colN_WGT.FieldName = "N_WGT";
            this.colN_WGT.Name = "colN_WGT";
            this.colN_WGT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_WGT", "{0:0.##}")});
            this.colN_WGT.Width = 63;
            // 
            // colC_SLABWH_CODE
            // 
            this.colC_SLABWH_CODE.Caption = "仓库编码";
            this.colC_SLABWH_CODE.FieldName = "C_SLABWH_CODE";
            this.colC_SLABWH_CODE.Name = "colC_SLABWH_CODE";
            this.colC_SLABWH_CODE.Width = 63;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "发运单号";
            this.gridColumn1.FieldName = "C_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "车牌号";
            this.gridColumn2.FieldName = "C_CPH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "发运方式";
            this.gridColumn3.FieldName = "C_FYSH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "客户";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txt_CPH);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(511, 68);
            this.panelControl2.TabIndex = 211;
            // 
            // txt_CPH
            // 
            this.txt_CPH.Location = new System.Drawing.Point(72, 21);
            this.txt_CPH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_CPH.Name = "txt_CPH";
            this.txt_CPH.Size = new System.Drawing.Size(133, 24);
            this.txt_CPH.TabIndex = 241;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 24);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 240;
            this.labelControl3.Text = "车牌号";
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(214, 19);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(85, 29);
            this.btn_Query.TabIndex = 237;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click_1);
            // 
            // gc_BH
            // 
            this.gc_BH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_BH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_BH.Location = new System.Drawing.Point(0, 0);
            this.gc_BH.MainView = this.gv_BH;
            this.gc_BH.Margin = new System.Windows.Forms.Padding(4);
            this.gc_BH.Name = "gc_BH";
            this.gc_BH.Size = new System.Drawing.Size(890, 683);
            this.gc_BH.TabIndex = 214;
            this.gc_BH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_BH});
            // 
            // gv_BH
            // 
            this.gv_BH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn14,
            this.gridColumn13,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gv_BH.GridControl = this.gc_BH;
            this.gv_BH.Name = "gv_BH";
            this.gv_BH.OptionsBehavior.Editable = false;
            this.gv_BH.OptionsView.ShowFooter = true;
            this.gv_BH.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "牌号";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "出库单号";
            this.gridColumn13.FieldName = "C_CKDH";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "批号";
            this.gridColumn7.FieldName = "C_STOVE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 63;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "钢种";
            this.gridColumn8.FieldName = "C_STL_GRD";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 63;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "规格";
            this.gridColumn9.FieldName = "C_SPEC";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 63;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "件数";
            this.gridColumn10.FieldName = "N_QUA";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_QUA", "{0:0.##}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 63;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "重量";
            this.gridColumn11.FieldName = "N_WGT";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_WGT", "{0:0.##}")});
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            this.gridColumn11.Width = 63;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "仓库编码";
            this.gridColumn12.FieldName = "C_SLABWH_CODE";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 6;
            this.gridColumn12.Width = 63;
            // 
            // FrmPQ_GPFYZCMX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 683);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmPQ_GPFYZCMX";
            this.Text = "钢坯发运装车明细";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_GP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CPH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_BH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gc_GP;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GP;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STOVE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colN_QUA;
        private DevExpress.XtraGrid.Columns.GridColumn colN_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SLABWH_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txt_CPH;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraGrid.GridControl gc_BH;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_BH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
    }
}