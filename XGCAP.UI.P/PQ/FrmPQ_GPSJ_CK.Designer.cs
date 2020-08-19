namespace XGCAP.UI.P.PQ
{
    partial class FrmPQ_GPSJ_CK
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
            this.components = new System.ComponentModel.Container();
            this.txt_GZ = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_LH = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DCGW = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_CK1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Remark = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gc_GPSJ = new DevExpress.XtraGrid.GridControl();
            this.gv_GPSJ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_CK1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_GZ
            // 
            this.txt_GZ.Location = new System.Drawing.Point(47, 10);
            this.txt_GZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GZ.Name = "txt_GZ";
            this.txt_GZ.Properties.MaxLength = 50;
            this.txt_GZ.Size = new System.Drawing.Size(100, 20);
            this.txt_GZ.TabIndex = 81;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(334, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 129;
            this.labelControl4.Text = "仓库";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 129;
            this.labelControl3.Text = "钢种";
            // 
            // txt_LH
            // 
            this.txt_LH.Location = new System.Drawing.Point(227, 10);
            this.txt_LH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LH.Name = "txt_LH";
            this.txt_LH.Properties.MaxLength = 50;
            this.txt_LH.Size = new System.Drawing.Size(100, 20);
            this.txt_LH.TabIndex = 81;
            // 
            // btn_Query
            // 
            this.btn_Query.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_Query.Appearance.Options.UseBackColor = true;
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(515, 9);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(58, 22);
            this.btn_Query.TabIndex = 131;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_DCGW
            // 
            this.btn_DCGW.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_DCGW.Location = new System.Drawing.Point(586, 9);
            this.btn_DCGW.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_DCGW.Name = "btn_DCGW";
            this.btn_DCGW.Size = new System.Drawing.Size(58, 22);
            this.btn_DCGW.TabIndex = 244;
            this.btn_DCGW.Text = "导出";
            this.btn_DCGW.Click += new System.EventHandler(this.btn_DCGW_Click);
            // 
            // cbo_CK1
            // 
            this.cbo_CK1.Location = new System.Drawing.Point(362, 10);
            this.cbo_CK1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_CK1.Name = "cbo_CK1";
            this.cbo_CK1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_CK1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("610", "610", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("611", "611", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("612", "612", -1)});
            this.cbo_CK1.Size = new System.Drawing.Size(143, 20);
            this.cbo_CK1.TabIndex = 245;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(156, 13);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 14);
            this.labelControl7.TabIndex = 246;
            this.labelControl7.Text = "炉号/开坯号";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(2, 36);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(2);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(7);
            this.separatorControl1.Size = new System.Drawing.Size(1287, 18);
            this.separatorControl1.TabIndex = 247;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(316, 54);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(58, 22);
            this.btn_Save.TabIndex = 248;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(47, 55);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(257, 20);
            this.txt_Remark.TabIndex = 250;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 58);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 249;
            this.labelControl2.Text = "备注";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txt_Remark);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.separatorControl1);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.cbo_CK1);
            this.panel1.Controls.Add(this.btn_DCGW);
            this.panel1.Controls.Add(this.btn_Query);
            this.panel1.Controls.Add(this.txt_LH);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txt_GZ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 87);
            this.panel1.TabIndex = 94;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 87);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1298, 5);
            this.splitterControl1.TabIndex = 95;
            this.splitterControl1.TabStop = false;
            // 
            // gc_GPSJ
            // 
            this.gc_GPSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GPSJ.Location = new System.Drawing.Point(0, 92);
            this.gc_GPSJ.MainView = this.gv_GPSJ;
            this.gc_GPSJ.Name = "gc_GPSJ";
            this.gc_GPSJ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2});
            this.gc_GPSJ.Size = new System.Drawing.Size(1298, 580);
            this.gc_GPSJ.TabIndex = 96;
            this.gc_GPSJ.ToolTipController = this.toolTipController1;
            this.gc_GPSJ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GPSJ});
            // 
            // gv_GPSJ
            // 
            this.gv_GPSJ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn9,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn23,
            this.gridColumn1});
            this.gv_GPSJ.GridControl = this.gc_GPSJ;
            this.gv_GPSJ.Name = "gv_GPSJ";
            this.gv_GPSJ.OptionsBehavior.Editable = false;
            this.gv_GPSJ.OptionsCustomization.AllowSort = false;
            this.gv_GPSJ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GPSJ.OptionsView.ShowFooter = true;
            this.gv_GPSJ.OptionsView.ShowGroupPanel = false;
            this.gv_GPSJ.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gv_GPSJ_RowStyle);
            this.gv_GPSJ.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_GPSJ_FocusedRowChanged);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "炉号";
            this.gridColumn2.FieldName = "C_STOVE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "批号";
            this.gridColumn3.FieldName = "C_BATCH_NO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "钢种";
            this.gridColumn4.FieldName = "C_STL_GRD";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "执行标准";
            this.gridColumn5.FieldName = "C_STD_CODE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "支数";
            this.gridColumn9.FieldName = "N_QUA";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_QUA", "{0:0.##}")});
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "仓库";
            this.gridColumn15.FieldName = "C_SLABWH_CODE_NAME";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 5;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "库位";
            this.gridColumn16.FieldName = "C_SLABWH_LOC_CODE_NAME";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 6;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "备注";
            this.gridColumn23.FieldName = "C_REMARK";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "钢坯异常原因";
            this.gridColumn1.FieldName = "C_KP_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // toolTipController1
            // 
            this.toolTipController1.AutoPopDelay = 5000000;
            this.toolTipController1.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController1_GetActiveObjectInfo);
            // 
            // FrmPQ_GPSJ_CK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 672);
            this.Controls.Add(this.gc_GPSJ);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPQ_GPSJ_CK";
            this.Text = "FrmPQ_GPSJ";
            this.Load += new System.EventHandler(this.FrmPQ_GPSJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_CK1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txt_GZ;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_LH;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_DCGW;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_CK1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.TextEdit txt_Remark;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl gc_GPSJ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GPSJ;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}