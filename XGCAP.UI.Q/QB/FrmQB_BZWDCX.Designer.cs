namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_BZWDCX
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.gc_StdFileb = new DevExpress.XtraGrid.GridControl();
            this.gv_StdFileb = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.C_FILE_TYPE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_FILE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_FILE_PATH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_STD_FILE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_FILE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonEdit_Preview = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StdFileb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StdFileb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEdit_Preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txt_Name);
            this.panelControl1.Controls.Add(this.btn_Query);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(932, 35);
            this.panelControl1.TabIndex = 69;
            // 
            // labelControl4
            // 
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(12, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 125;
            this.labelControl4.Text = "文档名称";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(66, 7);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.MaxLength = 50;
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 126;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(172, 5);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(78, 25);
            this.btn_Query.TabIndex = 127;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // gc_StdFileb
            // 
            this.gc_StdFileb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_StdFileb.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_StdFileb.Location = new System.Drawing.Point(0, 35);
            this.gc_StdFileb.MainView = this.gv_StdFileb;
            this.gc_StdFileb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_StdFileb.Name = "gc_StdFileb";
            this.gc_StdFileb.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1,
            this.ItemButtonEdit_Preview});
            this.gc_StdFileb.Size = new System.Drawing.Size(932, 494);
            this.gc_StdFileb.TabIndex = 70;
            this.gc_StdFileb.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_StdFileb});
            // 
            // gv_StdFileb
            // 
            this.gv_StdFileb.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.C_FILE_TYPE_NAME,
            this.colC_STD_FILE_CODE,
            this.colC_STD_FILE_PATH,
            this.C_STD_FILE_NAME,
            this.colC_FILE_NAME,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT,
            this.gridColumn1,
            this.gridColumn2});
            this.gv_StdFileb.GridControl = this.gc_StdFileb;
            this.gv_StdFileb.Name = "gv_StdFileb";
            this.gv_StdFileb.OptionsView.ColumnAutoWidth = false;
            this.gv_StdFileb.OptionsView.ShowGroupPanel = false;
            // 
            // C_FILE_TYPE_NAME
            // 
            this.C_FILE_TYPE_NAME.Caption = "标准文档类型";
            this.C_FILE_TYPE_NAME.FieldName = "C_FILE_TYPE_NAME";
            this.C_FILE_TYPE_NAME.Name = "C_FILE_TYPE_NAME";
            this.C_FILE_TYPE_NAME.OptionsColumn.AllowEdit = false;
            this.C_FILE_TYPE_NAME.Visible = true;
            this.C_FILE_TYPE_NAME.VisibleIndex = 1;
            this.C_FILE_TYPE_NAME.Width = 83;
            // 
            // colC_STD_FILE_CODE
            // 
            this.colC_STD_FILE_CODE.Caption = "标准文档代码";
            this.colC_STD_FILE_CODE.FieldName = "C_STD_FILE_CODE";
            this.colC_STD_FILE_CODE.Name = "colC_STD_FILE_CODE";
            this.colC_STD_FILE_CODE.OptionsColumn.AllowEdit = false;
            this.colC_STD_FILE_CODE.Visible = true;
            this.colC_STD_FILE_CODE.VisibleIndex = 0;
            this.colC_STD_FILE_CODE.Width = 101;
            // 
            // colC_STD_FILE_PATH
            // 
            this.colC_STD_FILE_PATH.Caption = "文档地址";
            this.colC_STD_FILE_PATH.FieldName = "C_STD_FILE_PATH";
            this.colC_STD_FILE_PATH.Name = "colC_STD_FILE_PATH";
            this.colC_STD_FILE_PATH.OptionsColumn.AllowEdit = false;
            // 
            // C_STD_FILE_NAME
            // 
            this.C_STD_FILE_NAME.Caption = "标准文档名称";
            this.C_STD_FILE_NAME.FieldName = "C_STD_FILE_NAME";
            this.C_STD_FILE_NAME.Name = "C_STD_FILE_NAME";
            this.C_STD_FILE_NAME.OptionsColumn.AllowEdit = false;
            this.C_STD_FILE_NAME.Visible = true;
            this.C_STD_FILE_NAME.VisibleIndex = 3;
            // 
            // colC_FILE_NAME
            // 
            this.colC_FILE_NAME.Caption = "上传的文档名称";
            this.colC_FILE_NAME.FieldName = "C_FILE_NAME";
            this.colC_FILE_NAME.Name = "colC_FILE_NAME";
            this.colC_FILE_NAME.OptionsColumn.AllowEdit = false;
            this.colC_FILE_NAME.Visible = true;
            this.colC_FILE_NAME.VisibleIndex = 2;
            this.colC_FILE_NAME.Width = 89;
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.Caption = "使用状态";
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
            this.colN_STATUS.OptionsColumn.AllowEdit = false;
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.Caption = "备注";
            this.colC_REMARK.FieldName = "C_REMARK";
            this.colC_REMARK.Name = "colC_REMARK";
            this.colC_REMARK.OptionsColumn.AllowEdit = false;
            this.colC_REMARK.Visible = true;
            this.colC_REMARK.VisibleIndex = 4;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人员";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.OptionsColumn.AllowEdit = false;
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 5;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "操作时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.OptionsColumn.AllowEdit = false;
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "预览";
            this.gridColumn1.ColumnEdit = this.ItemButtonEdit_Preview;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // ItemButtonEdit_Preview
            // 
            this.ItemButtonEdit_Preview.AutoHeight = false;
            this.ItemButtonEdit_Preview.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "预览", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.ItemButtonEdit_Preview.Name = "ItemButtonEdit_Preview";
            this.ItemButtonEdit_Preview.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "C_ID";
            this.gridColumn2.FieldName = "C_ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
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
            // FrmQB_BZWDCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 529);
            this.Controls.Add(this.gc_StdFileb);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_BZWDCX";
            this.Text = "标准文档查询";
            this.Load += new System.EventHandler(this.FrmQB_BZWDCX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StdFileb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StdFileb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEdit_Preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraGrid.GridControl gc_StdFileb;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_StdFileb;
        private DevExpress.XtraGrid.Columns.GridColumn C_FILE_TYPE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_FILE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_FILE_PATH;
        private DevExpress.XtraGrid.Columns.GridColumn C_STD_FILE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_FILE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonEdit_Preview;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}