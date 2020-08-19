namespace XGCAP.UI.P.PB
{
    partial class FrmPB_BCBZGZ
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
            this.gc_BCBZ = new DevExpress.XtraGrid.GridControl();
            this.gv_BCBZ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txt_mcQuery = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DC = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_mccx = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_GZ = new DevExpress.XtraEditors.TextEdit();
            this.txt_GZMC = new DevExpress.XtraEditors.TextEdit();
            this.ck_sfzh = new DevExpress.XtraEditors.CheckEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_BCBZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BCBZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mcQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mccx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZMC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_sfzh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_BCBZ
            // 
            this.gc_BCBZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_BCBZ.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_BCBZ.Location = new System.Drawing.Point(0, 113);
            this.gc_BCBZ.MainView = this.gv_BCBZ;
            this.gc_BCBZ.Margin = new System.Windows.Forms.Padding(2);
            this.gc_BCBZ.Name = "gc_BCBZ";
            this.gc_BCBZ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.txt_mcQuery});
            this.gc_BCBZ.Size = new System.Drawing.Size(897, 458);
            this.gc_BCBZ.TabIndex = 5;
            this.gc_BCBZ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_BCBZ});
            // 
            // gv_BCBZ
            // 
            this.gv_BCBZ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4});
            this.gv_BCBZ.GridControl = this.gc_BCBZ;
            this.gv_BCBZ.Name = "gv_BCBZ";
            this.gv_BCBZ.OptionsBehavior.ReadOnly = true;
            this.gv_BCBZ.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "主键";
            this.gridColumn3.FieldName = "C_ID";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "规则名称";
            this.gridColumn1.FieldName = "C_GZMC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "规则";
            this.gridColumn2.FieldName = "C_GZ";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // txt_mcQuery
            // 
            this.txt_mcQuery.AutoHeight = false;
            this.txt_mcQuery.Name = "txt_mcQuery";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_del);
            this.panelControl2.Controls.Add(this.btn_DC);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txt_mccx);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 57);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(897, 56);
            this.panelControl2.TabIndex = 4;
            // 
            // btn_del
            // 
            this.btn_del.ImageUri.Uri = "Delete;Size16x16";
            this.btn_del.Location = new System.Drawing.Point(251, 16);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(64, 23);
            this.btn_del.TabIndex = 7;
            this.btn_del.Text = "删除";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_DC
            // 
            this.btn_DC.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_DC.Location = new System.Drawing.Point(319, 16);
            this.btn_DC.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_DC.Name = "btn_DC";
            this.btn_DC.Size = new System.Drawing.Size(64, 23);
            this.btn_DC.TabIndex = 12;
            this.btn_DC.Text = "导出";
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(182, 16);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(64, 23);
            this.btn_Query.TabIndex = 11;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 240;
            this.labelControl2.Text = "规则名称";
            // 
            // txt_mccx
            // 
            this.txt_mccx.Location = new System.Drawing.Point(74, 18);
            this.txt_mccx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mccx.Name = "txt_mccx";
            this.txt_mccx.Size = new System.Drawing.Size(101, 20);
            this.txt_mccx.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.ck_sfzh);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txt_GZ);
            this.panelControl1.Controls.Add(this.txt_GZMC);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(897, 57);
            this.panelControl1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(182, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 240;
            this.labelControl1.Text = "规则";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 240;
            this.labelControl6.Text = "规则名称";
            // 
            // txt_GZ
            // 
            this.txt_GZ.Location = new System.Drawing.Point(213, 21);
            this.txt_GZ.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GZ.Name = "txt_GZ";
            this.txt_GZ.Size = new System.Drawing.Size(170, 20);
            this.txt_GZ.TabIndex = 1;
            // 
            // txt_GZMC
            // 
            this.txt_GZMC.Location = new System.Drawing.Point(74, 21);
            this.txt_GZMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GZMC.Name = "txt_GZMC";
            this.txt_GZMC.Size = new System.Drawing.Size(101, 20);
            this.txt_GZMC.TabIndex = 0;
            // 
            // ck_sfzh
            // 
            this.ck_sfzh.Location = new System.Drawing.Point(388, 22);
            this.ck_sfzh.Name = "ck_sfzh";
            this.ck_sfzh.Properties.Caption = "延时";
            this.ck_sfzh.Size = new System.Drawing.Size(43, 19);
            this.ck_sfzh.TabIndex = 241;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "是否延时";
            this.gridColumn4.FieldName = "C_SFYS";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(437, 21);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(58, 22);
            this.btn_Save.TabIndex = 242;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FrmPB_BCBZGZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 571);
            this.Controls.Add(this.gc_BCBZ);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPB_BCBZGZ";
            this.Text = "FrmPB_BCBZGZ";
            ((System.ComponentModel.ISupportInitialize)(this.gc_BCBZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BCBZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mcQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mccx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZMC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_sfzh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_BCBZ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_BCBZ;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txt_mcQuery;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_DC;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_GZ;
        private DevExpress.XtraEditors.TextEdit txt_GZMC;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_mccx;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.CheckEdit ck_sfzh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
    }
}