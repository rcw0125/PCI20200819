namespace XGCAP.UI.P.PO.APS
{
    partial class FrmPO_APS_ZGJSCN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPO_APS_ZGJSCN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save_cap = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btn_query_byline = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_change_line = new DevExpress.XtraEditors.SimpleButton();
            this.icbo_line2 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.icbo_line1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_gg1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_line2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_line1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gg1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_gg1);
            this.panel1.Controls.Add(this.labelControl17);
            this.panel1.Controls.Add(this.icbo_line1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btn_change_line);
            this.panel1.Controls.Add(this.icbo_line2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.btn_query_byline);
            this.panel1.Controls.Add(this.btn_save_cap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 33);
            this.panel1.TabIndex = 212;
            // 
            // btn_save_cap
            // 
            this.btn_save_cap.ImageUri.Uri = "AddNewDataSource;Size16x16";
            this.btn_save_cap.Location = new System.Drawing.Point(487, 5);
            this.btn_save_cap.Name = "btn_save_cap";
            this.btn_save_cap.Size = new System.Drawing.Size(88, 23);
            this.btn_save_cap.TabIndex = 210;
            this.btn_save_cap.Text = "机时产能";
            this.btn_save_cap.Click += new System.EventHandler(this.btn_plan_xf_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 33);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(656, 316);
            this.gridControl1.TabIndex = 213;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "C_STA_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "产线";
            this.gridColumn2.FieldName = "C_LINE_DESC";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "钢种";
            this.gridColumn3.FieldName = "C_STL_GRD";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "规格";
            this.gridColumn4.FieldName = "C_SPEC";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "机时产能";
            this.gridColumn5.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn5.FieldName = "N_MACH_WGT";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "f0";
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btn_query_byline
            // 
            this.btn_query_byline.ImageUri.Uri = "Preview;Size16x16";
            this.btn_query_byline.Location = new System.Drawing.Point(221, 3);
            this.btn_query_byline.Name = "btn_query_byline";
            this.btn_query_byline.Size = new System.Drawing.Size(59, 25);
            this.btn_query_byline.TabIndex = 211;
            this.btn_query_byline.Text = "查询";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "订单量";
            this.gridColumn6.FieldName = "N_WGT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_WGT", "{0:0.##}")});
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "标准";
            this.gridColumn7.FieldName = "C_STD_CODE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // btn_change_line
            // 
            this.btn_change_line.ImageUri.Uri = "CustomizeGrid;Size16x16";
            this.btn_change_line.Location = new System.Drawing.Point(390, 5);
            this.btn_change_line.Name = "btn_change_line";
            this.btn_change_line.Size = new System.Drawing.Size(88, 23);
            this.btn_change_line.TabIndex = 213;
            this.btn_change_line.Text = "调整产线";
            // 
            // icbo_line2
            // 
            this.icbo_line2.Location = new System.Drawing.Point(320, 6);
            this.icbo_line2.Name = "icbo_line2";
            this.icbo_line2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbo_line2.Size = new System.Drawing.Size(61, 20);
            this.icbo_line2.TabIndex = 212;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(287, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 214;
            this.labelControl3.Text = "产线";
            // 
            // icbo_line1
            // 
            this.icbo_line1.Location = new System.Drawing.Point(46, 6);
            this.icbo_line1.Name = "icbo_line1";
            this.icbo_line1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbo_line1.Size = new System.Drawing.Size(67, 20);
            this.icbo_line1.TabIndex = 215;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 216;
            this.labelControl1.Text = "产线";
            // 
            // txt_gg1
            // 
            this.txt_gg1.Location = new System.Drawing.Point(148, 6);
            this.txt_gg1.Name = "txt_gg1";
            this.txt_gg1.Size = new System.Drawing.Size(67, 20);
            this.txt_gg1.TabIndex = 219;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(118, 9);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(24, 14);
            this.labelControl17.TabIndex = 218;
            this.labelControl17.Text = "规格";
            // 
            // FrmPO_APS_ZGJSCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 349);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPO_APS_ZGJSCN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "轧线机时产能维护";
            this.Load += new System.EventHandler(this.FrmPO_APS_ZGJSCN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_line2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_line1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gg1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_save_cap;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_query_byline;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbo_line1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_change_line;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbo_line2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_gg1;
        private DevExpress.XtraEditors.LabelControl labelControl17;
    }
}