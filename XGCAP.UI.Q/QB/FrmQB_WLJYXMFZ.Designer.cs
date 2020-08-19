namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_WLJYXMFZ
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
            this.lab_Name = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_jcbm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lab_Remark = new DevExpress.XtraEditors.LabelControl();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Rest = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name1 = new DevExpress.XtraEditors.TextEdit();
            this.gc_wljyfz = new DevExpress.XtraGrid.GridControl();
            this.gv_wljyfz = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_CHECK_DEPMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_jcbm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_wljyfz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_wljyfz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Name
            // 
            this.lab_Name.Location = new System.Drawing.Point(12, 10);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(48, 14);
            this.lab_Name.TabIndex = 1;
            this.lab_Name.Text = "项目名称";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(66, 7);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(120, 20);
            this.txt_Name.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(192, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "检测部门";
            // 
            // cbo_jcbm
            // 
            this.cbo_jcbm.Location = new System.Drawing.Point(248, 7);
            this.cbo_jcbm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_jcbm.Name = "cbo_jcbm";
            this.cbo_jcbm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_jcbm.Properties.Items.AddRange(new object[] {
            "质控部",
            "技术中心"});
            this.cbo_jcbm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbo_jcbm.Size = new System.Drawing.Size(100, 20);
            this.cbo_jcbm.TabIndex = 44;
            // 
            // lab_Remark
            // 
            this.lab_Remark.Location = new System.Drawing.Point(36, 38);
            this.lab_Remark.Name = "lab_Remark";
            this.lab_Remark.Size = new System.Drawing.Size(24, 14);
            this.lab_Remark.TabIndex = 22;
            this.lab_Remark.Text = "备注";
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(365, 8);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Cancel;Size16x16;Colored";
            this.btn_Stop.Location = new System.Drawing.Point(395, 6);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 10;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Rest
            // 
            this.btn_Rest.ImageUri.Uri = "Reset;Size16x16";
            this.btn_Rest.Location = new System.Drawing.Point(365, 53);
            this.btn_Rest.Name = "btn_Rest";
            this.btn_Rest.Size = new System.Drawing.Size(75, 23);
            this.btn_Rest.TabIndex = 42;
            this.btn_Rest.Text = "重置";
            this.btn_Rest.Click += new System.EventHandler(this.btn_Rest_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(233, 6);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 8;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(314, 6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "修改";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lab_Name);
            this.panelControl1.Controls.Add(this.txt_Name);
            this.panelControl1.Controls.Add(this.btn_Rest);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbo_jcbm);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.lab_Remark);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(969, 85);
            this.panelControl1.TabIndex = 43;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(66, 37);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(282, 39);
            this.txt_Remark.TabIndex = 23;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txt_Name1);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.btn_Update);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 85);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(969, 39);
            this.panelControl2.TabIndex = 44;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "项目名称";
            // 
            // txt_Name1
            // 
            this.txt_Name1.Location = new System.Drawing.Point(66, 7);
            this.txt_Name1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name1.Name = "txt_Name1";
            this.txt_Name1.Size = new System.Drawing.Size(161, 20);
            this.txt_Name1.TabIndex = 22;
            // 
            // gc_wljyfz
            // 
            this.gc_wljyfz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_wljyfz.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_wljyfz.Location = new System.Drawing.Point(0, 124);
            this.gc_wljyfz.MainView = this.gv_wljyfz;
            this.gc_wljyfz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_wljyfz.Name = "gc_wljyfz";
            this.gc_wljyfz.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_wljyfz.Size = new System.Drawing.Size(969, 386);
            this.gc_wljyfz.TabIndex = 48;
            this.gc_wljyfz.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_wljyfz});
            // 
            // gv_wljyfz
            // 
            this.gv_wljyfz.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_CODE,
            this.colC_NAME,
            this.colC_CHECK_DEPMT,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_wljyfz.GridControl = this.gc_wljyfz;
            this.gv_wljyfz.Name = "gv_wljyfz";
            this.gv_wljyfz.OptionsBehavior.Editable = false;
            this.gv_wljyfz.OptionsView.ColumnAutoWidth = false;
            this.gv_wljyfz.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "主键";
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_CODE
            // 
            this.colC_CODE.Caption = "项目代码";
            this.colC_CODE.FieldName = "C_CODE";
            this.colC_CODE.Name = "colC_CODE";
            this.colC_CODE.OptionsColumn.AllowEdit = false;
            this.colC_CODE.Visible = true;
            this.colC_CODE.VisibleIndex = 0;
            // 
            // colC_NAME
            // 
            this.colC_NAME.Caption = "项目名称";
            this.colC_NAME.FieldName = "C_NAME";
            this.colC_NAME.Name = "colC_NAME";
            this.colC_NAME.Visible = true;
            this.colC_NAME.VisibleIndex = 1;
            // 
            // colC_CHECK_DEPMT
            // 
            this.colC_CHECK_DEPMT.Caption = "检测部门";
            this.colC_CHECK_DEPMT.FieldName = "C_CHECK_DEPMT";
            this.colC_CHECK_DEPMT.Name = "colC_CHECK_DEPMT";
            this.colC_CHECK_DEPMT.Visible = true;
            this.colC_CHECK_DEPMT.VisibleIndex = 2;
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
            this.colC_REMARK.VisibleIndex = 3;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人员";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.OptionsColumn.ReadOnly = true;
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 4;
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
            this.colD_MOD_DT.VisibleIndex = 5;
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
            // FrmQB_WLJYXMFZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 510);
            this.Controls.Add(this.gc_wljyfz);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_WLJYXMFZ";
            this.Text = "物理检验项目分组";
            this.Load += new System.EventHandler(this.FrmQB0002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_jcbm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_wljyfz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_wljyfz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lab_Name;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.LabelControl lab_Remark;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Rest;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_jcbm;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Name1;
        private DevExpress.XtraGrid.GridControl gc_wljyfz;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_wljyfz;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_CHECK_DEPMT;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}