namespace XGCAP.UI.P.PQ
{
    partial class FrmPQ_XCCKD
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
            this.txt_CKD = new DevExpress.XtraEditors.TextEdit();
            this.txt_CPH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.gc_GP = new DevExpress.XtraGrid.GridControl();
            this.gv_GP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_SLABWH_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_BATCH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_QUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CKD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CPH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txt_CKD);
            this.panelControl2.Controls.Add(this.txt_CPH);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1387, 68);
            this.panelControl2.TabIndex = 207;
            // 
            // txt_CKD
            // 
            this.txt_CKD.Location = new System.Drawing.Point(70, 18);
            this.txt_CKD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_CKD.Name = "txt_CKD";
            this.txt_CKD.Size = new System.Drawing.Size(133, 24);
            this.txt_CKD.TabIndex = 242;
            // 
            // txt_CPH
            // 
            this.txt_CPH.Location = new System.Drawing.Point(266, 18);
            this.txt_CPH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_CPH.Name = "txt_CPH";
            this.txt_CPH.Size = new System.Drawing.Size(133, 24);
            this.txt_CPH.TabIndex = 241;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(212, 21);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 240;
            this.labelControl3.Text = "车牌号";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 21);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 18);
            this.labelControl5.TabIndex = 238;
            this.labelControl5.Text = "出库单";
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(408, 16);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(85, 29);
            this.btn_Query.TabIndex = 237;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // gc_GP
            // 
            this.gc_GP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GP.Location = new System.Drawing.Point(0, 68);
            this.gc_GP.MainView = this.gv_GP;
            this.gc_GP.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GP.Name = "gc_GP";
            this.gc_GP.Size = new System.Drawing.Size(1387, 563);
            this.gc_GP.TabIndex = 244;
            this.gc_GP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GP});
            // 
            // gv_GP
            // 
            this.gv_GP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_SLABWH_CODE,
            this.gridColumn5,
            this.colC_BATCH_NO,
            this.colC_STL_GRD,
            this.colC_SPEC,
            this.colN_QUA,
            this.colN_WGT,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gv_GP.GridControl = this.gc_GP;
            this.gv_GP.Name = "gv_GP";
            this.gv_GP.OptionsBehavior.Editable = false;
            this.gv_GP.OptionsView.ShowFooter = true;
            this.gv_GP.OptionsView.ShowGroupPanel = false;
            // 
            // colC_SLABWH_CODE
            // 
            this.colC_SLABWH_CODE.Caption = "发货仓库";
            this.colC_SLABWH_CODE.FieldName = "C_SEND_STOCK";
            this.colC_SLABWH_CODE.Name = "colC_SLABWH_CODE";
            this.colC_SLABWH_CODE.Visible = true;
            this.colC_SLABWH_CODE.VisibleIndex = 8;
            this.colC_SLABWH_CODE.Width = 63;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "出库时间";
            this.gridColumn5.FieldName = "D_CKSJ";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 10;
            // 
            // colC_BATCH_NO
            // 
            this.colC_BATCH_NO.Caption = "批号";
            this.colC_BATCH_NO.FieldName = "C_BATCH_NO";
            this.colC_BATCH_NO.Name = "colC_BATCH_NO";
            this.colC_BATCH_NO.Visible = true;
            this.colC_BATCH_NO.VisibleIndex = 2;
            this.colC_BATCH_NO.Width = 63;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 4;
            this.colC_STL_GRD.Width = 63;
            // 
            // colC_SPEC
            // 
            this.colC_SPEC.Caption = "规格";
            this.colC_SPEC.FieldName = "C_SPEC";
            this.colC_SPEC.Name = "colC_SPEC";
            this.colC_SPEC.Visible = true;
            this.colC_SPEC.VisibleIndex = 5;
            this.colC_SPEC.Width = 63;
            // 
            // colN_QUA
            // 
            this.colN_QUA.Caption = "件数";
            this.colN_QUA.FieldName = "N_NUM";
            this.colN_QUA.Name = "colN_QUA";
            this.colN_QUA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_QUA", "{0:0.##}")});
            this.colN_QUA.Visible = true;
            this.colN_QUA.VisibleIndex = 6;
            this.colN_QUA.Width = 63;
            // 
            // colN_WGT
            // 
            this.colN_WGT.Caption = "重量";
            this.colN_WGT.FieldName = "N_JZ";
            this.colN_WGT.Name = "colN_WGT";
            this.colN_WGT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_WGT", "{0:0.##}")});
            this.colN_WGT.Visible = true;
            this.colN_WGT.VisibleIndex = 7;
            this.colN_WGT.Width = 63;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "发运单号";
            this.gridColumn1.FieldName = "C_DISPATCH_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "发运方式";
            this.gridColumn3.FieldName = "C_TRANSMODE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "车牌号";
            this.gridColumn6.FieldName = "C_LIC_PLA_NO";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 11;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "客户名称";
            this.gridColumn7.FieldName = "C_CUST_NAME";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 12;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "存货名称";
            this.gridColumn8.FieldName = "C_MAT_NAME";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "制单人";
            this.gridColumn9.FieldName = "C_CREATE_NAME";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 13;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "签字人";
            this.gridColumn10.FieldName = "C_APPROVE_NAME";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 14;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "签字时间";
            this.gridColumn11.FieldName = "D_APPROVE_DT";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 15;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "出库单号";
            this.gridColumn12.FieldName = "C_CKDH";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // FrmPQ_XCCKD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 631);
            this.Controls.Add(this.gc_GP);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmPQ_XCCKD";
            this.Text = "钢坯出库单";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CKD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CPH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txt_CPH;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.TextEdit txt_CKD;
        private DevExpress.XtraGrid.GridControl gc_GP;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GP;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SLABWH_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colC_BATCH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colN_QUA;
        private DevExpress.XtraGrid.Columns.GridColumn colN_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
    }
}