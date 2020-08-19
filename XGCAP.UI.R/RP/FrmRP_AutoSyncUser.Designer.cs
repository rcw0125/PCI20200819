namespace XGCAP.UI.R.RP
{
    partial class FrmRP_AutoSyncUser
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
            this.gc_ZGSJ = new DevExpress.XtraGrid.GridControl();
            this.gv_ZGSJ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_TB = new DevExpress.XtraEditors.SimpleButton();
            this.txt_num = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZGSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZGSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_ZGSJ
            // 
            this.gc_ZGSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ZGSJ.Location = new System.Drawing.Point(0, 38);
            this.gc_ZGSJ.MainView = this.gv_ZGSJ;
            this.gc_ZGSJ.Name = "gc_ZGSJ";
            this.gc_ZGSJ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gc_ZGSJ.Size = new System.Drawing.Size(371, 163);
            this.gc_ZGSJ.TabIndex = 25;
            this.gc_ZGSJ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ZGSJ});
            // 
            // gv_ZGSJ
            // 
            this.gv_ZGSJ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_ZGSJ.GridControl = this.gc_ZGSJ;
            this.gv_ZGSJ.Name = "gv_ZGSJ";
            this.gv_ZGSJ.OptionsBehavior.Editable = false;
            this.gv_ZGSJ.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "C_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "编号";
            this.gridColumn2.FieldName = "C_USERACCOUNT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_TB);
            this.panelControl2.Controls.Add(this.txt_num);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(371, 38);
            this.panelControl2.TabIndex = 24;
            // 
            // btn_TB
            // 
            this.btn_TB.ImageUri.Uri = "Refresh;Size16x16";
            this.btn_TB.Location = new System.Drawing.Point(203, 10);
            this.btn_TB.Name = "btn_TB";
            this.btn_TB.Size = new System.Drawing.Size(75, 23);
            this.btn_TB.TabIndex = 241;
            this.btn_TB.Text = "保存";
            this.btn_TB.Click += new System.EventHandler(this.btn_TB_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(53, 11);
            this.txt_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num.Name = "txt_num";
            this.txt_num.Properties.MaxLength = 30;
            this.txt_num.Size = new System.Drawing.Size(144, 20);
            this.txt_num.TabIndex = 230;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(11, 14);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(24, 14);
            this.labelControl13.TabIndex = 228;
            this.labelControl13.Text = "编号";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "名称";
            this.gridColumn3.FieldName = "C_NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // FrmRP_AutoSyncUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 201);
            this.Controls.Add(this.gc_ZGSJ);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmRP_AutoSyncUser";
            this.Text = "FrmRP_AutoSyncUser";
            this.Load += new System.EventHandler(this.FrmRP_AutoSyncUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZGSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZGSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_ZGSJ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ZGSJ;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_TB;
        private DevExpress.XtraEditors.TextEdit txt_num;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}