namespace XGCAP.UI.P.PB
{
    partial class FrmPB_SCLX
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.gc_SCLX = new DevExpress.XtraGrid.GridControl();
            this.gv_SCLX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_RH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_LF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ZL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SCLX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SCLX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_out);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(856, 53);
            this.panelControl1.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(13, 13);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 29);
            this.btn_Save.TabIndex = 113;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gc_SCLX
            // 
            this.gc_SCLX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SCLX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_SCLX.Location = new System.Drawing.Point(0, 53);
            this.gc_SCLX.MainView = this.gv_SCLX;
            this.gc_SCLX.Margin = new System.Windows.Forms.Padding(4);
            this.gc_SCLX.Name = "gc_SCLX";
            this.gc_SCLX.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gc_SCLX.Size = new System.Drawing.Size(856, 441);
            this.gc_SCLX.TabIndex = 9;
            this.gc_SCLX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SCLX});
            // 
            // gv_SCLX
            // 
            this.gv_SCLX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_CC,
            this.Col_RH,
            this.Col_LF,
            this.Col_ZL,
            this.gridColumn5,
            this.gridColumn6});
            this.gv_SCLX.GridControl = this.gc_SCLX;
            this.gv_SCLX.Name = "gv_SCLX";
            this.gv_SCLX.OptionsView.ShowGroupPanel = false;
            this.gv_SCLX.RowHeight = 60;
            // 
            // Col_CC
            // 
            this.Col_CC.Caption = "连铸";
            this.Col_CC.FieldName = "C_CC";
            this.Col_CC.Name = "Col_CC";
            this.Col_CC.OptionsColumn.AllowEdit = false;
            this.Col_CC.Visible = true;
            this.Col_CC.VisibleIndex = 0;
            // 
            // Col_RH
            // 
            this.Col_RH.Caption = "真空";
            this.Col_RH.FieldName = "C_RH";
            this.Col_RH.Name = "Col_RH";
            this.Col_RH.Visible = true;
            this.Col_RH.VisibleIndex = 1;
            // 
            // Col_LF
            // 
            this.Col_LF.Caption = "精炼";
            this.Col_LF.FieldName = "C_LF";
            this.Col_LF.Name = "Col_LF";
            this.Col_LF.Visible = true;
            this.Col_LF.VisibleIndex = 2;
            // 
            // Col_ZL
            // 
            this.Col_ZL.Caption = "转炉";
            this.Col_ZL.FieldName = "C_ZL";
            this.Col_ZL.Name = "Col_ZL";
            this.Col_ZL.Visible = true;
            this.Col_ZL.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "操作人";
            this.gridColumn5.FieldName = "C_EMP_ID";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "操作时间";
            this.gridColumn6.ColumnEdit = this.repositoryItemTextEdit2;
            this.gridColumn6.FieldName = "D_MOD_DT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(121, 13);
            this.btn_out.Margin = new System.Windows.Forms.Padding(4);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(105, 29);
            this.btn_out.TabIndex = 213;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // FrmPB_SCLX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 494);
            this.Controls.Add(this.gc_SCLX);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPB_SCLX";
            this.Text = "FrmPB_SCLX";
            this.Load += new System.EventHandler(this.FrmPB_SCLX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SCLX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SCLX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_SCLX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SCLX;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraGrid.Columns.GridColumn Col_CC;
        private DevExpress.XtraGrid.Columns.GridColumn Col_RH;
        private DevExpress.XtraGrid.Columns.GridColumn Col_LF;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ZL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.SimpleButton btn_out;
    }
}