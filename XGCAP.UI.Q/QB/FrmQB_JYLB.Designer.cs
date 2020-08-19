namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_JYLB
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Rest = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TypeName = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Remark = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_JYLB = new DevExpress.XtraGrid.GridControl();
            this.gv_JYLB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_TYPE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_TYPE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_JYLB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_JYLB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(477, 8);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Cancel;Size16x16;Colored";
            this.btn_Stop.Location = new System.Drawing.Point(167, 6);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(252, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "备注";
            // 
            // btn_Rest
            // 
            this.btn_Rest.ImageUri.Uri = "Reset;Size16x16";
            this.btn_Rest.Location = new System.Drawing.Point(558, 8);
            this.btn_Rest.Name = "btn_Rest";
            this.btn_Rest.Size = new System.Drawing.Size(75, 23);
            this.btn_Rest.TabIndex = 43;
            this.btn_Rest.Text = "重置";
            this.btn_Rest.Click += new System.EventHandler(this.btn_Rest_Click);
            // 
            // txt_TypeName
            // 
            this.txt_TypeName.Location = new System.Drawing.Point(66, 11);
            this.txt_TypeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TypeName.Name = "txt_TypeName";
            this.txt_TypeName.Properties.MaxLength = 50;
            this.txt_TypeName.Size = new System.Drawing.Size(180, 20);
            this.txt_TypeName.TabIndex = 21;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(5, 6);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 0;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "类别名称";
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(86, 6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "修改";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txt_TypeName);
            this.panelControl1.Controls.Add(this.btn_Rest);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(675, 44);
            this.panelControl1.TabIndex = 38;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(282, 11);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(180, 20);
            this.txt_Remark.TabIndex = 23;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Update);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 44);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(675, 36);
            this.panelControl2.TabIndex = 39;
            // 
            // gc_JYLB
            // 
            this.gc_JYLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_JYLB.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_JYLB.Location = new System.Drawing.Point(0, 80);
            this.gc_JYLB.MainView = this.gv_JYLB;
            this.gc_JYLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_JYLB.Name = "gc_JYLB";
            this.gc_JYLB.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_JYLB.Size = new System.Drawing.Size(675, 365);
            this.gc_JYLB.TabIndex = 44;
            this.gc_JYLB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_JYLB});
            // 
            // gv_JYLB
            // 
            this.gv_JYLB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_TYPE_CODE,
            this.colC_TYPE_NAME,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_JYLB.GridControl = this.gc_JYLB;
            this.gv_JYLB.Name = "gv_JYLB";
            this.gv_JYLB.OptionsBehavior.Editable = false;
            this.gv_JYLB.OptionsView.ColumnAutoWidth = false;
            this.gv_JYLB.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "主键";
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_TYPE_CODE
            // 
            this.colC_TYPE_CODE.Caption = "类别代码";
            this.colC_TYPE_CODE.FieldName = "C_TYPE_CODE";
            this.colC_TYPE_CODE.Name = "colC_TYPE_CODE";
            this.colC_TYPE_CODE.OptionsColumn.AllowEdit = false;
            this.colC_TYPE_CODE.Visible = true;
            this.colC_TYPE_CODE.VisibleIndex = 0;
            // 
            // colC_TYPE_NAME
            // 
            this.colC_TYPE_NAME.Caption = "类别名称";
            this.colC_TYPE_NAME.FieldName = "C_TYPE_NAME";
            this.colC_TYPE_NAME.Name = "colC_TYPE_NAME";
            this.colC_TYPE_NAME.Visible = true;
            this.colC_TYPE_NAME.VisibleIndex = 1;
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.Caption = "备注";
            this.colC_REMARK.FieldName = "C_REMARK";
            this.colC_REMARK.Name = "colC_REMARK";
            this.colC_REMARK.Visible = true;
            this.colC_REMARK.VisibleIndex = 2;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人员";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.OptionsColumn.ReadOnly = true;
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 3;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "操作时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.OptionsColumn.ReadOnly = true;
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 4;
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // FrmQB_JYLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 445);
            this.Controls.Add(this.gc_JYLB);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_JYLB";
            this.Text = "检验类别维护";
            this.Load += new System.EventHandler(this.FrmQB0001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_JYLB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_JYLB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private DevExpress.XtraGrid.GridControl gc_JYLB;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_JYLB;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_TYPE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_TYPE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_TypeName;
        private DevExpress.XtraEditors.SimpleButton btn_Rest;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.TextEdit txt_Remark;
    }
}