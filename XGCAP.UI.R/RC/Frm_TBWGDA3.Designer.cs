namespace XGCAP.UI.R.RC
{
    partial class Frm_TBWGDA3
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
            this.btn_A3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_QueryNC = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_NC
            // 
            this.gc_NC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_NC.Location = new System.Drawing.Point(0, 38);
            this.gc_NC.MainView = this.gv_NC;
            this.gc_NC.Name = "gc_NC";
            this.gc_NC.Size = new System.Drawing.Size(800, 412);
            this.gc_NC.TabIndex = 16;
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
            this.panelControl1.Controls.Add(this.btn_A3);
            this.panelControl1.Controls.Add(this.btn_QueryNC);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 38);
            this.panelControl1.TabIndex = 15;
            // 
            // btn_A3
            // 
            this.btn_A3.ImageUri.Uri = "Recurrence;Size16x16";
            this.btn_A3.Location = new System.Drawing.Point(93, 8);
            this.btn_A3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_A3.Name = "btn_A3";
            this.btn_A3.Size = new System.Drawing.Size(75, 23);
            this.btn_A3.TabIndex = 202;
            this.btn_A3.Text = "A3";
            this.btn_A3.Click += new System.EventHandler(this.btn_A3_Click);
            // 
            // btn_QueryNC
            // 
            this.btn_QueryNC.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_QueryNC.Location = new System.Drawing.Point(12, 8);
            this.btn_QueryNC.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_QueryNC.Name = "btn_QueryNC";
            this.btn_QueryNC.Size = new System.Drawing.Size(75, 23);
            this.btn_QueryNC.TabIndex = 201;
            this.btn_QueryNC.Text = "查询";
            this.btn_QueryNC.Click += new System.EventHandler(this.btn_QueryNC_Click);
            // 
            // Frm_TBWGDA3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gc_NC);
            this.Controls.Add(this.panelControl1);
            this.Name = "Frm_TBWGDA3";
            this.Text = "Frm_TBWGDA3";
            this.Load += new System.EventHandler(this.Frm_TBWGDA3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_NC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_A3;
        private DevExpress.XtraEditors.SimpleButton btn_QueryNC;
    }
}