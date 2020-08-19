namespace XGCAP.UI.R.RR
{
    partial class FrmRR_TCJL
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
            this.gc_ZGZPSJ = new DevExpress.XtraGrid.GridControl();
            this.gv_ZGZPSJ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dt_Plan = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn_AllowGrdQuery = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZGZPSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZGZPSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_ZGZPSJ
            // 
            this.gc_ZGZPSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ZGZPSJ.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_ZGZPSJ.Location = new System.Drawing.Point(0, 62);
            this.gc_ZGZPSJ.MainView = this.gv_ZGZPSJ;
            this.gc_ZGZPSJ.Margin = new System.Windows.Forms.Padding(4);
            this.gc_ZGZPSJ.Name = "gc_ZGZPSJ";
            this.gc_ZGZPSJ.Size = new System.Drawing.Size(832, 549);
            this.gc_ZGZPSJ.TabIndex = 6;
            this.gc_ZGZPSJ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ZGZPSJ});
            // 
            // gv_ZGZPSJ
            // 
            this.gv_ZGZPSJ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn19,
            this.gridColumn36,
            this.gridColumn37,
            this.gridColumn38,
            this.gridColumn11});
            this.gv_ZGZPSJ.GridControl = this.gc_ZGZPSJ;
            this.gv_ZGZPSJ.Name = "gv_ZGZPSJ";
            this.gv_ZGZPSJ.OptionsBehavior.Editable = false;
            this.gv_ZGZPSJ.OptionsBehavior.ReadOnly = true;
            this.gv_ZGZPSJ.OptionsView.ShowFooter = true;
            this.gv_ZGZPSJ.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "批次号";
            this.gridColumn5.FieldName = "C_BATCH_NO";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 53;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "支数";
            this.gridColumn19.FieldName = "N_QUA";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_QUA_JOIN", "{0:0.##}")});
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 1;
            this.gridColumn19.Width = 32;
            // 
            // gridColumn36
            // 
            this.gridColumn36.Caption = "钢种";
            this.gridColumn36.FieldName = "C_STL_GRD";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.Visible = true;
            this.gridColumn36.VisibleIndex = 3;
            this.gridColumn36.Width = 53;
            // 
            // gridColumn37
            // 
            this.gridColumn37.Caption = "规格";
            this.gridColumn37.FieldName = "C_SPEC";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.Visible = true;
            this.gridColumn37.VisibleIndex = 2;
            this.gridColumn37.Width = 53;
            // 
            // gridColumn38
            // 
            this.gridColumn38.Caption = "执行标准";
            this.gridColumn38.FieldName = "C_STD_CODE";
            this.gridColumn38.Name = "gridColumn38";
            this.gridColumn38.Visible = true;
            this.gridColumn38.VisibleIndex = 4;
            this.gridColumn38.Width = 53;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "操作人";
            this.gridColumn11.FieldName = "C_EMP_ID";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dt_Plan);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.btn_AllowGrdQuery);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(832, 62);
            this.panelControl2.TabIndex = 5;
            // 
            // dt_Plan
            // 
            this.dt_Plan.EditValue = null;
            this.dt_Plan.Location = new System.Drawing.Point(64, 19);
            this.dt_Plan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Plan.Name = "dt_Plan";
            this.dt_Plan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Plan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Plan.Size = new System.Drawing.Size(131, 24);
            this.dt_Plan.TabIndex = 201;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(18, 23);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 18);
            this.labelControl7.TabIndex = 200;
            this.labelControl7.Text = "日期";
            // 
            // btn_AllowGrdQuery
            // 
            this.btn_AllowGrdQuery.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_AllowGrdQuery.Location = new System.Drawing.Point(202, 16);
            this.btn_AllowGrdQuery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_AllowGrdQuery.Name = "btn_AllowGrdQuery";
            this.btn_AllowGrdQuery.Size = new System.Drawing.Size(81, 29);
            this.btn_AllowGrdQuery.TabIndex = 139;
            this.btn_AllowGrdQuery.Text = "查询";
            this.btn_AllowGrdQuery.Click += new System.EventHandler(this.btn_AllowGrdQuery_Click);
            // 
            // FrmRR_TCJL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 611);
            this.Controls.Add(this.gc_ZGZPSJ);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmRR_TCJL";
            this.Text = "FrmRR_TCJL";
            this.Load += new System.EventHandler(this.FrmRR_TCJL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZGZPSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZGZPSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Plan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_ZGZPSJ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ZGZPSJ;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_AllowGrdQuery;
        private DevExpress.XtraEditors.DateEdit dt_Plan;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}