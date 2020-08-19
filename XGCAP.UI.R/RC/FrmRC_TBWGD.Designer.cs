namespace XGCAP.UI.R.RC
{
    partial class FrmRC_TBWGD
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
            this.gc_WGD = new DevExpress.XtraGrid.GridControl();
            this.gv_WGD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_BATCH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_PACK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_FREE_TERM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_FREE_TERM2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SyncRF = new DevExpress.XtraEditors.SimpleButton();
            this.gc_NC = new DevExpress.XtraGrid.GridControl();
            this.gv_NC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_QueryNC = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SyncNC = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gc_WGD);
            this.splitContainer1.Panel1.Controls.Add(this.panelControl3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gc_NC);
            this.splitContainer1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainer1.Size = new System.Drawing.Size(679, 545);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 11;
            // 
            // gc_WGD
            // 
            this.gc_WGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_WGD.Location = new System.Drawing.Point(0, 38);
            this.gc_WGD.MainView = this.gv_WGD;
            this.gc_WGD.Name = "gc_WGD";
            this.gc_WGD.Size = new System.Drawing.Size(679, 203);
            this.gc_WGD.TabIndex = 9;
            this.gc_WGD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WGD});
            // 
            // gv_WGD
            // 
            this.gv_WGD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn15,
            this.colC_ID,
            this.colC_BATCH_NO,
            this.gridColumn1,
            this.colC_PACK,
            this.colC_FREE_TERM,
            this.colC_FREE_TERM2,
            this.gridColumn2});
            this.gv_WGD.GridControl = this.gc_WGD;
            this.gv_WGD.Name = "gv_WGD";
            this.gv_WGD.OptionsBehavior.ReadOnly = true;
            this.gv_WGD.OptionsView.ShowFooter = true;
            this.gv_WGD.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "钢种";
            this.gridColumn15.FieldName = "C_STL_GRD";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 2;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "完工单号";
            this.colC_ID.FieldName = "WGDH";
            this.colC_ID.Name = "colC_ID";
            this.colC_ID.Visible = true;
            this.colC_ID.VisibleIndex = 0;
            // 
            // colC_BATCH_NO
            // 
            this.colC_BATCH_NO.Caption = "批号";
            this.colC_BATCH_NO.FieldName = "C_BATCH_NO";
            this.colC_BATCH_NO.Name = "colC_BATCH_NO";
            this.colC_BATCH_NO.Visible = true;
            this.colC_BATCH_NO.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "状态";
            this.gridColumn1.FieldName = "ZJBstatus";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colC_PACK
            // 
            this.colC_PACK.Caption = "包装要求";
            this.colC_PACK.FieldName = "C_PACK";
            this.colC_PACK.Name = "colC_PACK";
            this.colC_PACK.Visible = true;
            this.colC_PACK.VisibleIndex = 5;
            // 
            // colC_FREE_TERM
            // 
            this.colC_FREE_TERM.Caption = "自由项";
            this.colC_FREE_TERM.FieldName = "C_FREE_TERM";
            this.colC_FREE_TERM.Name = "colC_FREE_TERM";
            this.colC_FREE_TERM.Visible = true;
            this.colC_FREE_TERM.VisibleIndex = 3;
            // 
            // colC_FREE_TERM2
            // 
            this.colC_FREE_TERM2.Caption = "自由项2";
            this.colC_FREE_TERM2.FieldName = "C_FREE_TERM2";
            this.colC_FREE_TERM2.Name = "colC_FREE_TERM2";
            this.colC_FREE_TERM2.Visible = true;
            this.colC_FREE_TERM2.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "时间";
            this.gridColumn2.FieldName = "insertts";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_Query);
            this.panelControl3.Controls.Add(this.btn_SyncRF);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(679, 38);
            this.panelControl3.TabIndex = 6;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(12, 9);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 201;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_SyncRF
            // 
            this.btn_SyncRF.ImageUri.Uri = "Recurrence;Size16x16";
            this.btn_SyncRF.Location = new System.Drawing.Point(93, 9);
            this.btn_SyncRF.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_SyncRF.Name = "btn_SyncRF";
            this.btn_SyncRF.Size = new System.Drawing.Size(75, 23);
            this.btn_SyncRF.TabIndex = 200;
            this.btn_SyncRF.Text = "同步条码";
            this.btn_SyncRF.Click += new System.EventHandler(this.btn_SyncRF_Click);
            // 
            // gc_NC
            // 
            this.gc_NC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_NC.Location = new System.Drawing.Point(0, 38);
            this.gc_NC.MainView = this.gv_NC;
            this.gc_NC.Name = "gc_NC";
            this.gc_NC.Size = new System.Drawing.Size(679, 263);
            this.gc_NC.TabIndex = 12;
            this.gc_NC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NC});
            // 
            // gv_NC
            // 
            this.gv_NC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14});
            this.gv_NC.GridControl = this.gc_NC;
            this.gv_NC.Name = "gv_NC";
            this.gv_NC.OptionsBehavior.ReadOnly = true;
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
            this.gridColumn4.Caption = "批号";
            this.gridColumn4.FieldName = "C_BATCH_NO";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
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
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "自由项";
            this.gridColumn7.FieldName = "C_FREE_TERM";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "自由项2";
            this.gridColumn8.FieldName = "C_FREE_TERM2";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "时间";
            this.gridColumn9.FieldName = "D_MOD_DT";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "钢种";
            this.gridColumn10.FieldName = "C_STL_GRD";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "规格";
            this.gridColumn11.FieldName = "C_SPEC";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "执行标准";
            this.gridColumn12.FieldName = "C_STD_CODE";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 8;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "同步信息";
            this.gridColumn13.FieldName = "N_IF_EXEC_REMARK";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 9;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "同步状态";
            this.gridColumn14.FieldName = "N_IF_EXEC_STATUS";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_QueryNC);
            this.panelControl1.Controls.Add(this.btn_SyncNC);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(679, 38);
            this.panelControl1.TabIndex = 11;
            // 
            // btn_QueryNC
            // 
            this.btn_QueryNC.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_QueryNC.Location = new System.Drawing.Point(12, 9);
            this.btn_QueryNC.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_QueryNC.Name = "btn_QueryNC";
            this.btn_QueryNC.Size = new System.Drawing.Size(75, 23);
            this.btn_QueryNC.TabIndex = 201;
            this.btn_QueryNC.Text = "查询";
            this.btn_QueryNC.Click += new System.EventHandler(this.btn_QueryNC_Click);
            // 
            // btn_SyncNC
            // 
            this.btn_SyncNC.ImageUri.Uri = "Recurrence;Size16x16";
            this.btn_SyncNC.Location = new System.Drawing.Point(93, 9);
            this.btn_SyncNC.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_SyncNC.Name = "btn_SyncNC";
            this.btn_SyncNC.Size = new System.Drawing.Size(75, 23);
            this.btn_SyncNC.TabIndex = 200;
            this.btn_SyncNC.Text = "下发NC";
            this.btn_SyncNC.Click += new System.EventHandler(this.btn_SyncNC_Click);
            // 
            // FrmRC_TBWGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 545);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRC_TBWGD";
            this.Text = "FrmRC_TBWGD";
            this.Load += new System.EventHandler(this.FrmRC_TBWGD_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_WGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_NC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gc_WGD;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WGD;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_BATCH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_PACK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_FREE_TERM;
        private DevExpress.XtraGrid.Columns.GridColumn colC_FREE_TERM2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_SyncRF;
        private DevExpress.XtraGrid.GridControl gc_NC;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_QueryNC;
        private DevExpress.XtraEditors.SimpleButton btn_SyncNC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
    }
}