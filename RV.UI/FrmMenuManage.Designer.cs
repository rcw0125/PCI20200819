namespace RV.UI
{
    partial class FrmMenuManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuManage));
            this.bscTSMODULE = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colC_MODULEID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_PARENTMODULEID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_MODULENAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_ASSEMBLYNAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_MODULECLASS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_DISABLE = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colN_ORDER = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_IMAGEINDEX = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_MODULE_TYPE = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_QUERY_STR = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colN_STATUS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_REMARK = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_EMP_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colD_MOD_DT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tl_Module = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.bscTSMODULE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_Module)).BeginInit();
            this.SuspendLayout();
            // 
            // bscTSMODULE
            // 
            this.bscTSMODULE.DataSource = typeof(RV.MODEL.ModTS_MODULE);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Zoom;Size16x16";
            this.simpleButton1.Location = new System.Drawing.Point(12, 9);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 28);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageUri.Uri = "Add;Size16x16";
            this.simpleButton2.Location = new System.Drawing.Point(105, 9);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(121, 28);
            this.simpleButton2.TabIndex = 19;
            this.simpleButton2.Text = "添加根目录";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(245, 9);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(121, 28);
            this.simpleButton3.TabIndex = 20;
            this.simpleButton3.Text = "添加子目录";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton5);
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1103, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(476, 9);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(74, 28);
            this.simpleButton5.TabIndex = 22;
            this.simpleButton5.Text = "下移";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(383, 9);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(74, 28);
            this.simpleButton4.TabIndex = 21;
            this.simpleButton4.Text = "上移";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = "0";
            this.repositoryItemCheckEdit1.ValueUnchecked = "1";
            // 
            // colC_MODULEID
            // 
            this.colC_MODULEID.Caption = "模块编码";
            this.colC_MODULEID.FieldName = "C_MODULEID";
            this.colC_MODULEID.Name = "colC_MODULEID";
            this.colC_MODULEID.Width = 78;
            // 
            // colC_PARENTMODULEID
            // 
            this.colC_PARENTMODULEID.Caption = "父模块编码";
            this.colC_PARENTMODULEID.FieldName = "C_PARENTMODULEID";
            this.colC_PARENTMODULEID.Name = "colC_PARENTMODULEID";
            this.colC_PARENTMODULEID.Width = 78;
            // 
            // colC_MODULENAME
            // 
            this.colC_MODULENAME.Caption = "模块名称";
            this.colC_MODULENAME.FieldName = "C_MODULENAME";
            this.colC_MODULENAME.MinWidth = 52;
            this.colC_MODULENAME.Name = "colC_MODULENAME";
            this.colC_MODULENAME.OptionsColumn.AllowEdit = false;
            this.colC_MODULENAME.OptionsColumn.AllowSize = false;
            this.colC_MODULENAME.Visible = true;
            this.colC_MODULENAME.VisibleIndex = 0;
            this.colC_MODULENAME.Width = 200;
            // 
            // colC_ASSEMBLYNAME
            // 
            this.colC_ASSEMBLYNAME.Caption = "命名空间";
            this.colC_ASSEMBLYNAME.FieldName = "C_ASSEMBLYNAME";
            this.colC_ASSEMBLYNAME.Name = "colC_ASSEMBLYNAME";
            this.colC_ASSEMBLYNAME.OptionsColumn.AllowEdit = false;
            this.colC_ASSEMBLYNAME.Visible = true;
            this.colC_ASSEMBLYNAME.VisibleIndex = 1;
            this.colC_ASSEMBLYNAME.Width = 78;
            // 
            // colC_MODULECLASS
            // 
            this.colC_MODULECLASS.Caption = "模块地址";
            this.colC_MODULECLASS.FieldName = "C_MODULECLASS";
            this.colC_MODULECLASS.Name = "colC_MODULECLASS";
            this.colC_MODULECLASS.OptionsColumn.AllowEdit = false;
            this.colC_MODULECLASS.Visible = true;
            this.colC_MODULECLASS.VisibleIndex = 2;
            this.colC_MODULECLASS.Width = 78;
            // 
            // colC_DISABLE
            // 
            this.colC_DISABLE.Caption = "禁用";
            this.colC_DISABLE.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colC_DISABLE.FieldName = "C_DISABLE";
            this.colC_DISABLE.Name = "colC_DISABLE";
            this.colC_DISABLE.OptionsColumn.AllowEdit = false;
            this.colC_DISABLE.Visible = true;
            this.colC_DISABLE.VisibleIndex = 5;
            this.colC_DISABLE.Width = 77;
            // 
            // colN_ORDER
            // 
            this.colN_ORDER.Caption = "顺序号";
            this.colN_ORDER.FieldName = "N_ORDER";
            this.colN_ORDER.Name = "colN_ORDER";
            this.colN_ORDER.OptionsColumn.AllowEdit = false;
            this.colN_ORDER.Visible = true;
            this.colN_ORDER.VisibleIndex = 3;
            this.colN_ORDER.Width = 77;
            // 
            // colC_IMAGEINDEX
            // 
            this.colC_IMAGEINDEX.FieldName = "C_IMAGEINDEX";
            this.colC_IMAGEINDEX.Name = "colC_IMAGEINDEX";
            this.colC_IMAGEINDEX.Width = 77;
            // 
            // colC_MODULE_TYPE
            // 
            this.colC_MODULE_TYPE.FieldName = "C_MODULE_TYPE";
            this.colC_MODULE_TYPE.Name = "colC_MODULE_TYPE";
            this.colC_MODULE_TYPE.Width = 77;
            // 
            // colC_QUERY_STR
            // 
            this.colC_QUERY_STR.Caption = "注入参数";
            this.colC_QUERY_STR.FieldName = "C_QUERY_STR";
            this.colC_QUERY_STR.Name = "colC_QUERY_STR";
            this.colC_QUERY_STR.OptionsColumn.AllowEdit = false;
            this.colC_QUERY_STR.Visible = true;
            this.colC_QUERY_STR.VisibleIndex = 4;
            this.colC_QUERY_STR.Width = 77;
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
            this.colN_STATUS.Width = 77;
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.FieldName = "C_REMARK";
            this.colC_REMARK.Name = "colC_REMARK";
            this.colC_REMARK.Width = 77;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Width = 77;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Width = 77;
            // 
            // tl_Module
            // 
            this.tl_Module.AllowDrop = true;
            this.tl_Module.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colC_MODULEID,
            this.colC_PARENTMODULEID,
            this.colC_MODULENAME,
            this.colC_ASSEMBLYNAME,
            this.colC_MODULECLASS,
            this.colC_DISABLE,
            this.colN_ORDER,
            this.colC_IMAGEINDEX,
            this.colC_MODULE_TYPE,
            this.colC_QUERY_STR,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.tl_Module.Cursor = System.Windows.Forms.Cursors.Default;
            this.tl_Module.DataSource = this.bscTSMODULE;
            this.tl_Module.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_Module.ImageIndexFieldName = "N_IMAGEINDEX";
            this.tl_Module.Location = new System.Drawing.Point(0, 45);
            this.tl_Module.Name = "tl_Module";
            this.tl_Module.OptionsBehavior.PopulateServiceColumns = true;
            this.tl_Module.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemCheckEdit1});
            this.tl_Module.Size = new System.Drawing.Size(1103, 592);
            this.tl_Module.TabIndex = 1;
            this.tl_Module.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tl_Module_FocusedNodeChanged);
            this.tl_Module.DoubleClick += new System.EventHandler(this.tl_Module_DoubleClick);
            // 
            // FrmMenuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 637);
            this.Controls.Add(this.tl_Module);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmMenuManage";
            this.Text = "模块管理";
            this.Load += new System.EventHandler(this.FrmMenuManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bscTSMODULE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_Module)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bscTSMODULE;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_MODULEID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_PARENTMODULEID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_MODULENAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_ASSEMBLYNAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_MODULECLASS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_DISABLE;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colN_ORDER;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_IMAGEINDEX;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_MODULE_TYPE;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_QUERY_STR;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colN_STATUS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_REMARK;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_EMP_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colD_MOD_DT;
        private DevExpress.XtraTreeList.TreeList tl_Module;
    }
}