namespace XGCAP.UI.P.PO
{
    partial class FrmPO_OrderFX
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gc_tj2 = new DevExpress.XtraGrid.GridControl();
            this.gv_tj_lz = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gv_tj_gz = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gv_tj_gg = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gv_tj_zg = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel24 = new System.Windows.Forms.Panel();
            this.rbtn_tj = new DevExpress.XtraEditors.RadioGroup();
            this.btn_tj2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn74 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn75 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn76 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn80 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn72 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn73 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn81 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn47 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn48 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn83 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn84 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn85 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn49 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_tj2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tj_lz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tj_gz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tj_gg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tj_zg)).BeginInit();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_tj.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl2.Size = new System.Drawing.Size(1075, 441);
            this.xtraTabControl2.TabIndex = 189;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gc_tj2);
            this.xtraTabPage3.Controls.Add(this.panel24);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1067, 410);
            this.xtraTabPage3.Text = "已评价订单分析";
            // 
            // gc_tj2
            // 
            this.gc_tj2.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gv_tj_lz;
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.LevelTemplate = this.gv_tj_gz;
            gridLevelNode2.RelationName = "Level2";
            gridLevelNode3.LevelTemplate = this.gv_tj_gg;
            gridLevelNode3.RelationName = "Level3";
            this.gc_tj2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.gc_tj2.Location = new System.Drawing.Point(0, 42);
            this.gc_tj2.MainView = this.gv_tj_zg;
            this.gc_tj2.Name = "gc_tj2";
            this.gc_tj2.Size = new System.Drawing.Size(1067, 368);
            this.gc_tj2.TabIndex = 170;
            this.gc_tj2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_tj_lz,
            this.gv_tj_gz,
            this.gv_tj_gg,
            this.gv_tj_zg});
            // 
            // gv_tj_lz
            // 
            this.gv_tj_lz.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn76,
            this.gridColumn80,
            this.gridColumn46});
            this.gv_tj_lz.GridControl = this.gc_tj2;
            this.gv_tj_lz.Name = "gv_tj_lz";
            this.gv_tj_lz.OptionsView.ShowFooter = true;
            this.gv_tj_lz.OptionsView.ShowGroupPanel = false;
            // 
            // gv_tj_gz
            // 
            this.gv_tj_gz.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn72,
            this.gridColumn73,
            this.gridColumn81,
            this.gridColumn47,
            this.gridColumn48});
            this.gv_tj_gz.GridControl = this.gc_tj2;
            this.gv_tj_gz.Name = "gv_tj_gz";
            this.gv_tj_gz.OptionsView.ShowFooter = true;
            this.gv_tj_gz.OptionsView.ShowGroupPanel = false;
            // 
            // gv_tj_gg
            // 
            this.gv_tj_gg.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn83,
            this.gridColumn84,
            this.gridColumn85,
            this.gridColumn49});
            this.gv_tj_gg.GridControl = this.gc_tj2;
            this.gv_tj_gg.Name = "gv_tj_gg";
            this.gv_tj_gg.OptionsView.ShowFooter = true;
            this.gv_tj_gg.OptionsView.ShowGroupPanel = false;
            // 
            // gv_tj_zg
            // 
            this.gv_tj_zg.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn74,
            this.gridColumn75,
            this.gridColumn45});
            this.gv_tj_zg.GridControl = this.gc_tj2;
            this.gv_tj_zg.Name = "gv_tj_zg";
            this.gv_tj_zg.OptionsView.ShowFooter = true;
            this.gv_tj_zg.OptionsView.ShowGroupPanel = false;
            // 
            // panel24
            // 
            this.panel24.AutoScroll = true;
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel24.Controls.Add(this.checkBox2);
            this.panel24.Controls.Add(this.checkBox1);
            this.panel24.Controls.Add(this.rbtn_tj);
            this.panel24.Controls.Add(this.btn_tj2);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(1067, 42);
            this.panel24.TabIndex = 169;
            // 
            // rbtn_tj
            // 
            this.rbtn_tj.EditValue = ((short)(1));
            this.rbtn_tj.Location = new System.Drawing.Point(11, 9);
            this.rbtn_tj.Name = "rbtn_tj";
            this.rbtn_tj.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "轧钢"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "炼钢")});
            this.rbtn_tj.Size = new System.Drawing.Size(123, 23);
            this.rbtn_tj.TabIndex = 164;
            // 
            // btn_tj2
            // 
            this.btn_tj2.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_tj2.Location = new System.Drawing.Point(309, 9);
            this.btn_tj2.Name = "btn_tj2";
            this.btn_tj2.Size = new System.Drawing.Size(61, 23);
            this.btn_tj2.TabIndex = 160;
            this.btn_tj2.Text = "查询";
            // 
            // gridColumn74
            // 
            this.gridColumn74.Caption = "订单重量";
            this.gridColumn74.FieldName = "ORDER_WGT";
            this.gridColumn74.Name = "gridColumn74";
            this.gridColumn74.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ORDER_WGT", "{0:0.##}")});
            this.gridColumn74.Visible = true;
            this.gridColumn74.VisibleIndex = 1;
            // 
            // gridColumn75
            // 
            this.gridColumn75.Caption = "产线";
            this.gridColumn75.FieldName = "C_LINE_NO";
            this.gridColumn75.Name = "gridColumn75";
            this.gridColumn75.Visible = true;
            this.gridColumn75.VisibleIndex = 0;
            // 
            // gridColumn45
            // 
            this.gridColumn45.Caption = "排产重量";
            this.gridColumn45.FieldName = "N_PC_WGT";
            this.gridColumn45.Name = "gridColumn45";
            this.gridColumn45.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_PC_WGT", "{0:0.##}")});
            this.gridColumn45.Visible = true;
            this.gridColumn45.VisibleIndex = 2;
            // 
            // gridColumn76
            // 
            this.gridColumn76.Caption = "连铸";
            this.gridColumn76.FieldName = "C_CCM_NO";
            this.gridColumn76.Name = "gridColumn76";
            this.gridColumn76.Visible = true;
            this.gridColumn76.VisibleIndex = 0;
            // 
            // gridColumn80
            // 
            this.gridColumn80.Caption = "订单重量";
            this.gridColumn80.FieldName = "ORDER_WGT";
            this.gridColumn80.Name = "gridColumn80";
            this.gridColumn80.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ORDER_WGT", "{0:0.##}")});
            this.gridColumn80.Visible = true;
            this.gridColumn80.VisibleIndex = 1;
            // 
            // gridColumn46
            // 
            this.gridColumn46.Caption = "排产重量";
            this.gridColumn46.FieldName = "N_PC_WGT";
            this.gridColumn46.Name = "gridColumn46";
            this.gridColumn46.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_PC_WGT", "{0:0.##}")});
            this.gridColumn46.Visible = true;
            this.gridColumn46.VisibleIndex = 2;
            // 
            // gridColumn72
            // 
            this.gridColumn72.Caption = "钢种";
            this.gridColumn72.FieldName = "C_STL_GRD";
            this.gridColumn72.Name = "gridColumn72";
            this.gridColumn72.Visible = true;
            this.gridColumn72.VisibleIndex = 1;
            // 
            // gridColumn73
            // 
            this.gridColumn73.Caption = "执行标准";
            this.gridColumn73.FieldName = "C_STD_CODE";
            this.gridColumn73.Name = "gridColumn73";
            this.gridColumn73.Visible = true;
            this.gridColumn73.VisibleIndex = 2;
            // 
            // gridColumn81
            // 
            this.gridColumn81.Caption = "订单重量";
            this.gridColumn81.FieldName = "ORDER_WGT";
            this.gridColumn81.Name = "gridColumn81";
            this.gridColumn81.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ORDER_WGT", "{0:0.##}")});
            this.gridColumn81.Visible = true;
            this.gridColumn81.VisibleIndex = 3;
            // 
            // gridColumn47
            // 
            this.gridColumn47.Caption = "连铸";
            this.gridColumn47.FieldName = "C_CCM_NO";
            this.gridColumn47.Name = "gridColumn47";
            this.gridColumn47.Visible = true;
            this.gridColumn47.VisibleIndex = 0;
            // 
            // gridColumn48
            // 
            this.gridColumn48.Caption = "排产重量";
            this.gridColumn48.FieldName = "N_PC_WGT";
            this.gridColumn48.Name = "gridColumn48";
            this.gridColumn48.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_PC_WGT", "{0:0.##}")});
            this.gridColumn48.Visible = true;
            this.gridColumn48.VisibleIndex = 4;
            // 
            // gridColumn83
            // 
            this.gridColumn83.Caption = "规格";
            this.gridColumn83.FieldName = "C_SPEC";
            this.gridColumn83.Name = "gridColumn83";
            this.gridColumn83.Visible = true;
            this.gridColumn83.VisibleIndex = 1;
            // 
            // gridColumn84
            // 
            this.gridColumn84.Caption = "产线";
            this.gridColumn84.FieldName = "C_LINE_NO";
            this.gridColumn84.Name = "gridColumn84";
            this.gridColumn84.Visible = true;
            this.gridColumn84.VisibleIndex = 0;
            // 
            // gridColumn85
            // 
            this.gridColumn85.Caption = "订单重量";
            this.gridColumn85.FieldName = "ORDER_WGT";
            this.gridColumn85.Name = "gridColumn85";
            this.gridColumn85.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ORDER_WGT", "{0:0.##}")});
            this.gridColumn85.Visible = true;
            this.gridColumn85.VisibleIndex = 2;
            // 
            // gridColumn49
            // 
            this.gridColumn49.Caption = "排产重量";
            this.gridColumn49.FieldName = "N_PC_WGT";
            this.gridColumn49.Name = "gridColumn49";
            this.gridColumn49.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_PC_WGT", "{0:0.##}")});
            this.gridColumn49.Visible = true;
            this.gridColumn49.VisibleIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(143, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 18);
            this.checkBox1.TabIndex = 165;
            this.checkBox1.Text = "规格分布";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(226, 11);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 18);
            this.checkBox2.TabIndex = 165;
            this.checkBox2.Text = "钢种分布";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // FrmPO_OrderFX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 441);
            this.Controls.Add(this.xtraTabControl2);
            this.Name = "FrmPO_OrderFX";
            this.Text = "订单排产分析";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_tj2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tj_lz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tj_gz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tj_gg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tj_zg)).EndInit();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_tj.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gc_tj2;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_tj_lz;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn76;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn80;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_tj_gz;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn72;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn73;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn81;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn47;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn48;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_tj_gg;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn83;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn84;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn85;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn49;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_tj_zg;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn74;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn75;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
        private System.Windows.Forms.Panel panel24;
        private DevExpress.XtraEditors.RadioGroup rbtn_tj;
        private DevExpress.XtraEditors.SimpleButton btn_tj2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}