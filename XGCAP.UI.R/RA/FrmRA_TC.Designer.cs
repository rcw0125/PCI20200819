namespace XGCAP.UI.R.RA
{
    partial class FrmRA_TC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRA_TC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.image_Loc = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.image_Area = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_CK1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.bindChangeFlooerSource = new System.Windows.Forms.BindingSource();
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
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btn_up = new DevExpress.XtraEditors.SimpleButton();
            this.btn_down = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_Loc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Area.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_CK1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindChangeFlooerSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btn_down);
            this.panel1.Controls.Add(this.btn_up);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.image_Loc);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.image_Area);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.cbo_CK1);
            this.panel1.Controls.Add(this.btn_Query);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 50);
            this.panel1.TabIndex = 95;
            // 
            // btn_save
            // 
            this.btn_save.ImageUri.Uri = "Save;Size16x16";
            this.btn_save.Location = new System.Drawing.Point(907, 11);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 29);
            this.btn_save.TabIndex = 250;
            this.btn_save.Text = "保存修改";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // image_Loc
            // 
            this.image_Loc.Location = new System.Drawing.Point(516, 14);
            this.image_Loc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.image_Loc.Name = "image_Loc";
            this.image_Loc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.image_Loc.Size = new System.Drawing.Size(84, 24);
            this.image_Loc.TabIndex = 249;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(477, 18);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 18);
            this.labelControl6.TabIndex = 248;
            this.labelControl6.Text = "库位";
            // 
            // image_Area
            // 
            this.image_Area.Location = new System.Drawing.Point(315, 14);
            this.image_Area.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.image_Area.Name = "image_Area";
            this.image_Area.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.image_Area.Size = new System.Drawing.Size(144, 24);
            this.image_Area.TabIndex = 247;
            this.image_Area.SelectedIndexChanged += new System.EventHandler(this.image_Area_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(276, 18);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 246;
            this.labelControl1.Text = "区域";
            // 
            // cbo_CK1
            // 
            this.cbo_CK1.Location = new System.Drawing.Point(63, 14);
            this.cbo_CK1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbo_CK1.Name = "cbo_CK1";
            this.cbo_CK1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_CK1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("610", "610", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("611", "611", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("612", "612", -1)});
            this.cbo_CK1.Size = new System.Drawing.Size(191, 24);
            this.cbo_CK1.TabIndex = 245;
            this.cbo_CK1.SelectedIndexChanged += new System.EventHandler(this.cbo_CK1_SelectedIndexChanged);
            // 
            // btn_Query
            // 
            this.btn_Query.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_Query.Appearance.Options.UseBackColor = true;
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(616, 12);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(77, 28);
            this.btn_Query.TabIndex = 131;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 18);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 18);
            this.labelControl4.TabIndex = 129;
            this.labelControl4.Text = "仓库";
            // 
            // gc_GPSJ
            // 
            this.gc_GPSJ.DataSource = this.bindChangeFlooerSource;
            this.gc_GPSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GPSJ.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gc_GPSJ.Location = new System.Drawing.Point(0, 50);
            this.gc_GPSJ.MainView = this.gv_GPSJ;
            this.gc_GPSJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gc_GPSJ.Name = "gc_GPSJ";
            this.gc_GPSJ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2});
            this.gc_GPSJ.Size = new System.Drawing.Size(1117, 606);
            this.gc_GPSJ.TabIndex = 97;
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
            this.gridColumn1,
            this.gridColumn6});
            this.gv_GPSJ.GridControl = this.gc_GPSJ;
            this.gv_GPSJ.Name = "gv_GPSJ";
            this.gv_GPSJ.OptionsBehavior.Editable = false;
            this.gv_GPSJ.OptionsCustomization.AllowFilter = false;
            this.gv_GPSJ.OptionsCustomization.AllowSort = false;
            this.gv_GPSJ.OptionsView.ShowFooter = true;
            this.gv_GPSJ.OptionsView.ShowGroupPanel = false;
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
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "钢坯异常原因";
            this.gridColumn1.FieldName = "C_KP_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.FieldName = "N_SORT";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // btn_up
            // 
            this.btn_up.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_up.Appearance.Options.UseBackColor = true;
            this.btn_up.Image = ((System.Drawing.Image)(resources.GetObject("btn_up.Image")));
            this.btn_up.Location = new System.Drawing.Point(716, 12);
            this.btn_up.Margin = new System.Windows.Forms.Padding(4);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(77, 28);
            this.btn_up.TabIndex = 251;
            this.btn_up.Text = "上移";
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_down.Appearance.Options.UseBackColor = true;
            this.btn_down.Image = ((System.Drawing.Image)(resources.GetObject("btn_down.Image")));
            this.btn_down.Location = new System.Drawing.Point(813, 12);
            this.btn_down.Margin = new System.Windows.Forms.Padding(4);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(77, 28);
            this.btn_down.TabIndex = 252;
            this.btn_down.Text = "下移";
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // FrmRA_TC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 656);
            this.Controls.Add(this.gc_GPSJ);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRA_TC";
            this.Text = "FrmRA_TC";
            this.Load += new System.EventHandler(this.FrmRA_TC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_Loc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Area.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_CK1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindChangeFlooerSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_CK1;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ImageComboBoxEdit image_Loc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ImageComboBoxEdit image_Area;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bindChangeFlooerSource;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraGrid.GridControl gc_GPSJ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GPSJ;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btn_down;
        private DevExpress.XtraEditors.SimpleButton btn_up;
    }
}