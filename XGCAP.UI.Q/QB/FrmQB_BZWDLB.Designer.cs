namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_BZWDLB
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Type = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Remark = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_BZWDLB = new DevExpress.XtraGrid.GridControl();
            this.gv_BZWDLB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_FILE_TYPE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_FILE_TYPE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_BZWDLB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BZWDLB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(12, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "文档类型";
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(66, 7);
            this.txt_Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(158, 20);
            this.txt_Type.TabIndex = 25;
            // 
            // labelControl5
            // 
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl5.Location = new System.Drawing.Point(230, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "备注";
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(451, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 28;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(12, 6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 30;
            this.btn_Update.Text = "修改";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(93, 6);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 29;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_Type);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(842, 38);
            this.panelControl1.TabIndex = 60;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(260, 7);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(185, 20);
            this.txt_Remark.TabIndex = 27;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Update);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 38);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(842, 36);
            this.panelControl2.TabIndex = 61;
            // 
            // gc_BZWDLB
            // 
            this.gc_BZWDLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_BZWDLB.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_BZWDLB.Location = new System.Drawing.Point(0, 74);
            this.gc_BZWDLB.MainView = this.gv_BZWDLB;
            this.gc_BZWDLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_BZWDLB.Name = "gc_BZWDLB";
            this.gc_BZWDLB.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_BZWDLB.Size = new System.Drawing.Size(842, 383);
            this.gc_BZWDLB.TabIndex = 63;
            this.gc_BZWDLB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_BZWDLB});
            // 
            // gv_BZWDLB
            // 
            this.gv_BZWDLB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_FILE_TYPE_CODE,
            this.colC_FILE_TYPE_NAME,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_BZWDLB.GridControl = this.gc_BZWDLB;
            this.gv_BZWDLB.Name = "gv_BZWDLB";
            this.gv_BZWDLB.OptionsBehavior.Editable = false;
            this.gv_BZWDLB.OptionsView.ColumnAutoWidth = false;
            this.gv_BZWDLB.OptionsView.ShowGroupPanel = false;
            // 
            // colC_FILE_TYPE_CODE
            // 
            this.colC_FILE_TYPE_CODE.Caption = "标准文档类型代码";
            this.colC_FILE_TYPE_CODE.FieldName = "C_FILE_TYPE_CODE";
            this.colC_FILE_TYPE_CODE.Name = "colC_FILE_TYPE_CODE";
            this.colC_FILE_TYPE_CODE.OptionsColumn.AllowEdit = false;
            this.colC_FILE_TYPE_CODE.Width = 213;
            // 
            // colC_FILE_TYPE_NAME
            // 
            this.colC_FILE_TYPE_NAME.Caption = "标准文档类型名称";
            this.colC_FILE_TYPE_NAME.FieldName = "C_FILE_TYPE_NAME";
            this.colC_FILE_TYPE_NAME.Name = "colC_FILE_TYPE_NAME";
            this.colC_FILE_TYPE_NAME.Visible = true;
            this.colC_FILE_TYPE_NAME.VisibleIndex = 0;
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.Caption = "使用状态";
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
            this.colN_STATUS.OptionsColumn.ReadOnly = true;
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.Caption = "备注";
            this.colC_REMARK.FieldName = "C_REMARK";
            this.colC_REMARK.Name = "colC_REMARK";
            this.colC_REMARK.Visible = true;
            this.colC_REMARK.VisibleIndex = 1;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人员";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.OptionsColumn.ReadOnly = true;
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
            this.colD_MOD_DT.OptionsColumn.ReadOnly = true;
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 3;
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
            // FrmQB_BZWDLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 457);
            this.Controls.Add(this.gc_BZWDLB);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_BZWDLB";
            this.Text = "标准文档类别维护";
            this.Load += new System.EventHandler(this.FrmQA0102_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_BZWDLB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BZWDLB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Type;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gc_BZWDLB;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_BZWDLB;
        private DevExpress.XtraGrid.Columns.GridColumn colC_FILE_TYPE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_FILE_TYPE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.TextEdit txt_Remark;
    }
}