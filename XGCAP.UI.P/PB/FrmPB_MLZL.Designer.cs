namespace XGCAP.UI.P.PB
{
    partial class FrmPB_MLZL
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
            this.gc_GWCN = new DevExpress.XtraGrid.GridControl();
            this.gv_GWCN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_CAPACITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Query2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_UpdateGW = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cn = new DevExpress.XtraEditors.TextEdit();
            this.cbo_GW = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_DCMLZL = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GWCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GWCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_GWCN
            // 
            this.gc_GWCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GWCN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GWCN.Location = new System.Drawing.Point(0, 102);
            this.gc_GWCN.MainView = this.gv_GWCN;
            this.gc_GWCN.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GWCN.Name = "gc_GWCN";
            this.gc_GWCN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gc_GWCN.Size = new System.Drawing.Size(1224, 530);
            this.gc_GWCN.TabIndex = 14;
            this.gc_GWCN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GWCN});
            // 
            // gv_GWCN
            // 
            this.gv_GWCN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_STA_ID,
            this.colN_CAPACITY,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_GWCN.GridControl = this.gc_GWCN;
            this.gv_GWCN.Name = "gv_GWCN";
            this.gv_GWCN.OptionsBehavior.Editable = false;
            this.gv_GWCN.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_STA_ID
            // 
            this.colC_STA_ID.Caption = "转炉";
            this.colC_STA_ID.FieldName = "C_STA_ID";
            this.colC_STA_ID.Name = "colC_STA_ID";
            this.colC_STA_ID.Visible = true;
            this.colC_STA_ID.VisibleIndex = 0;
            // 
            // colN_CAPACITY
            // 
            this.colN_CAPACITY.Caption = "重量";
            this.colN_CAPACITY.FieldName = "N_STA_WGT";
            this.colN_CAPACITY.Name = "colN_CAPACITY";
            this.colN_CAPACITY.Visible = true;
            this.colN_CAPACITY.VisibleIndex = 1;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 2;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "操作时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_DCMLZL);
            this.panelControl2.Controls.Add(this.btn_Query2);
            this.panelControl2.Controls.Add(this.btn_Cancle);
            this.panelControl2.Controls.Add(this.btn_UpdateGW);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 52);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1224, 50);
            this.panelControl2.TabIndex = 15;
            // 
            // btn_Query2
            // 
            this.btn_Query2.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query2.Location = new System.Drawing.Point(16, 15);
            this.btn_Query2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_Query2.Name = "btn_Query2";
            this.btn_Query2.Size = new System.Drawing.Size(77, 27);
            this.btn_Query2.TabIndex = 140;
            this.btn_Query2.Text = "查询";
            this.btn_Query2.Click += new System.EventHandler(this.btn_Query2_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Cancle.Location = new System.Drawing.Point(194, 15);
            this.btn_Cancle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(77, 27);
            this.btn_Cancle.TabIndex = 139;
            this.btn_Cancle.Text = "删除";
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_UpdateGW
            // 
            this.btn_UpdateGW.ImageUri.Uri = "Save;Size16x16";
            this.btn_UpdateGW.Location = new System.Drawing.Point(105, 15);
            this.btn_UpdateGW.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UpdateGW.Name = "btn_UpdateGW";
            this.btn_UpdateGW.Size = new System.Drawing.Size(77, 27);
            this.btn_UpdateGW.TabIndex = 138;
            this.btn_UpdateGW.Text = "修改";
            this.btn_UpdateGW.Click += new System.EventHandler(this.btn_UpdateGW_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_cn);
            this.panelControl1.Controls.Add(this.cbo_GW);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1224, 52);
            this.panelControl1.TabIndex = 13;
            // 
            // btn_save
            // 
            this.btn_save.ImageUri.Uri = "Save;Size16x16";
            this.btn_save.Location = new System.Drawing.Point(401, 16);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 27);
            this.btn_save.TabIndex = 90;
            this.btn_save.Text = "保存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(247, 21);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "重量";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "工位";
            // 
            // txt_cn
            // 
            this.txt_cn.Location = new System.Drawing.Point(305, 18);
            this.txt_cn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cn.Name = "txt_cn";
            this.txt_cn.Properties.Mask.EditMask = "n0";
            this.txt_cn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_cn.Properties.MaxLength = 3;
            this.txt_cn.Size = new System.Drawing.Size(84, 24);
            this.txt_cn.TabIndex = 1;
            // 
            // cbo_GW
            // 
            this.cbo_GW.Location = new System.Drawing.Point(65, 15);
            this.cbo_GW.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_GW.Name = "cbo_GW";
            this.cbo_GW.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GW.Size = new System.Drawing.Size(174, 24);
            this.cbo_GW.TabIndex = 1;
            // 
            // btn_DCMLZL
            // 
            this.btn_DCMLZL.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_DCMLZL.Location = new System.Drawing.Point(281, 15);
            this.btn_DCMLZL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_DCMLZL.Name = "btn_DCMLZL";
            this.btn_DCMLZL.Size = new System.Drawing.Size(77, 27);
            this.btn_DCMLZL.TabIndex = 247;
            this.btn_DCMLZL.Text = "导出";
            this.btn_DCMLZL.Click += new System.EventHandler(this.btn_DCMLZL_Click);
            // 
            // FrmPB_MLZL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 632);
            this.Controls.Add(this.gc_GWCN);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPB_MLZL";
            this.Text = "转炉每炉重量";
            this.Load += new System.EventHandler(this.FrmPB_MLZL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_GWCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GWCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_GWCN;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GWCN;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colN_CAPACITY;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_cn;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_UpdateGW;
        private DevExpress.XtraEditors.SimpleButton btn_Cancle;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GW;
        private DevExpress.XtraEditors.SimpleButton btn_Query2;
        private DevExpress.XtraEditors.SimpleButton btn_DCMLZL;
    }
}