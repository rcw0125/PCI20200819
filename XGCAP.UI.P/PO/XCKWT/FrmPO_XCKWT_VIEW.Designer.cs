namespace XGCAP.UI.P.PO.XCKWT
{
    partial class FrmPO_XCKWT_VIEW
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
            this.btn_Select = new DevExpress.XtraEditors.SimpleButton();
            this.icbo_CK = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gc_SJXX = new DevExpress.XtraGrid.GridControl();
            this.gv_SJXX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_STOVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_BATCH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_TICK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.N_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SHIFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_GROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.D_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_CK.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SJXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SJXX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Select);
            this.panel1.Controls.Add(this.icbo_CK);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 38);
            this.panel1.TabIndex = 0;
            // 
            // btn_Select
            // 
            this.btn_Select.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Select.Location = new System.Drawing.Point(150, 7);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 23);
            this.btn_Select.TabIndex = 26;
            this.btn_Select.Text = "查询";
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // icbo_CK
            // 
            this.icbo_CK.Location = new System.Drawing.Point(39, 10);
            this.icbo_CK.Margin = new System.Windows.Forms.Padding(2);
            this.icbo_CK.Name = "icbo_CK";
            this.icbo_CK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbo_CK.Size = new System.Drawing.Size(106, 20);
            this.icbo_CK.TabIndex = 18;
            this.icbo_CK.SelectedIndexChanged += new System.EventHandler(this.icbo_CK_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "仓库";
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
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
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 601);
            this.panel3.TabIndex = 6;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(717, 38);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 601);
            this.splitterControl1.TabIndex = 7;
            this.splitterControl1.TabStop = false;
            // 
            // gc_SJXX
            // 
            this.gc_SJXX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SJXX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_SJXX.Location = new System.Drawing.Point(722, 38);
            this.gc_SJXX.MainView = this.gv_SJXX;
            this.gc_SJXX.Margin = new System.Windows.Forms.Padding(2);
            this.gc_SJXX.Name = "gc_SJXX";
            this.gc_SJXX.Size = new System.Drawing.Size(516, 601);
            this.gc_SJXX.TabIndex = 52;
            this.gc_SJXX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SJXX});
            // 
            // gv_SJXX
            // 
            this.gv_SJXX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_STOVE,
            this.colC_BATCH_NO,
            this.C_TICK_NO,
            this.C_STL_GRD,
            this.N_WGT,
            this.colC_STD_CODE,
            this.colC_SPEC,
            this.colC_SHIFT,
            this.colC_GROUP,
            this.D_MOD_DT,
            this.C_MAT_CODE,
            this.C_MAT_DESC});
            this.gv_SJXX.GridControl = this.gc_SJXX;
            this.gv_SJXX.Name = "gv_SJXX";
            this.gv_SJXX.OptionsBehavior.Editable = false;
            this.gv_SJXX.OptionsView.ColumnAutoWidth = false;
            this.gv_SJXX.OptionsView.ShowFooter = true;
            this.gv_SJXX.OptionsView.ShowGroupPanel = false;
            // 
            // colC_STOVE
            // 
            this.colC_STOVE.Caption = "炉号";
            this.colC_STOVE.FieldName = "C_STOVE";
            this.colC_STOVE.Name = "colC_STOVE";
            this.colC_STOVE.Visible = true;
            this.colC_STOVE.VisibleIndex = 0;
            // 
            // colC_BATCH_NO
            // 
            this.colC_BATCH_NO.Caption = "批号";
            this.colC_BATCH_NO.FieldName = "C_BATCH_NO";
            this.colC_BATCH_NO.Name = "colC_BATCH_NO";
            this.colC_BATCH_NO.Visible = true;
            this.colC_BATCH_NO.VisibleIndex = 1;
            // 
            // C_TICK_NO
            // 
            this.C_TICK_NO.Caption = "钩号";
            this.C_TICK_NO.FieldName = "C_TICK_NO";
            this.C_TICK_NO.Name = "C_TICK_NO";
            this.C_TICK_NO.Visible = true;
            this.C_TICK_NO.VisibleIndex = 2;
            // 
            // C_STL_GRD
            // 
            this.C_STL_GRD.Caption = "钢种";
            this.C_STL_GRD.FieldName = "C_STL_GRD";
            this.C_STL_GRD.Name = "C_STL_GRD";
            this.C_STL_GRD.Visible = true;
            this.C_STL_GRD.VisibleIndex = 3;
            // 
            // N_WGT
            // 
            this.N_WGT.Caption = "重量";
            this.N_WGT.FieldName = "N_WGT";
            this.N_WGT.Name = "N_WGT";
            this.N_WGT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_WGT", "{0:0.##}")});
            this.N_WGT.Visible = true;
            this.N_WGT.VisibleIndex = 5;
            // 
            // colC_STD_CODE
            // 
            this.colC_STD_CODE.Caption = "执行标准";
            this.colC_STD_CODE.FieldName = "C_STD_CODE";
            this.colC_STD_CODE.Name = "colC_STD_CODE";
            this.colC_STD_CODE.Visible = true;
            this.colC_STD_CODE.VisibleIndex = 4;
            // 
            // colC_SPEC
            // 
            this.colC_SPEC.Caption = "规格";
            this.colC_SPEC.FieldName = "C_SPEC";
            this.colC_SPEC.Name = "colC_SPEC";
            this.colC_SPEC.Visible = true;
            this.colC_SPEC.VisibleIndex = 8;
            // 
            // colC_SHIFT
            // 
            this.colC_SHIFT.Caption = "班次";
            this.colC_SHIFT.FieldName = "C_SHIFT";
            this.colC_SHIFT.Name = "colC_SHIFT";
            // 
            // colC_GROUP
            // 
            this.colC_GROUP.Caption = "班组";
            this.colC_GROUP.FieldName = "C_GROUP";
            this.colC_GROUP.Name = "colC_GROUP";
            // 
            // D_MOD_DT
            // 
            this.D_MOD_DT.Caption = "生产时间";
            this.D_MOD_DT.FieldName = "D_MOD_DT";
            this.D_MOD_DT.Name = "D_MOD_DT";
            this.D_MOD_DT.Visible = true;
            this.D_MOD_DT.VisibleIndex = 9;
            // 
            // C_MAT_CODE
            // 
            this.C_MAT_CODE.Caption = "物料编码";
            this.C_MAT_CODE.FieldName = "C_MAT_CODE";
            this.C_MAT_CODE.Name = "C_MAT_CODE";
            this.C_MAT_CODE.Visible = true;
            this.C_MAT_CODE.VisibleIndex = 6;
            // 
            // C_MAT_DESC
            // 
            this.C_MAT_DESC.Caption = "物料描述";
            this.C_MAT_DESC.FieldName = "C_MAT_DESC";
            this.C_MAT_DESC.Name = "C_MAT_DESC";
            this.C_MAT_DESC.Visible = true;
            this.C_MAT_DESC.VisibleIndex = 7;
            // 
            // FrmPO_XCKWT_VIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 639);
            this.Controls.Add(this.gc_SJXX);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPO_XCKWT_VIEW";
            this.Text = "线材库位图配置";
            this.Load += new System.EventHandler(this.FrmPO_GPKWT_VIEW_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_CK.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SJXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SJXX)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gc_SJXX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SJXX;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STOVE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_BATCH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn C_TICK_NO;
        private DevExpress.XtraGrid.Columns.GridColumn C_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn N_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SHIFT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_GROUP;
        private DevExpress.XtraGrid.Columns.GridColumn D_MOD_DT;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_DESC;
    }
}