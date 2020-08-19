namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_QYMC
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
            DevExpress.Utils.SimpleContextButton simpleContextButton1 = new DevExpress.Utils.SimpleContextButton();
            DevExpress.Utils.SimpleContextButton simpleContextButton2 = new DevExpress.Utils.SimpleContextButton();
            this.gc_QYMC = new DevExpress.XtraGrid.GridControl();
            this.gv_QYMC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_SAMPLING_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SAMPLING_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_CHECK_DEPMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.N_SAMPLING_SN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Query_Main = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_jcbm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_Rest = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.txt_Remark = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gc_QYMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_QYMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_jcbm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_QYMC
            // 
            this.gc_QYMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_QYMC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_QYMC.Location = new System.Drawing.Point(0, 75);
            this.gc_QYMC.MainView = this.gv_QYMC;
            this.gc_QYMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_QYMC.Name = "gc_QYMC";
            this.gc_QYMC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemImageComboBox1});
            this.gc_QYMC.Size = new System.Drawing.Size(908, 375);
            this.gc_QYMC.TabIndex = 64;
            this.gc_QYMC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_QYMC});
            // 
            // gv_QYMC
            // 
            this.gv_QYMC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_SAMPLING_CODE,
            this.colC_SAMPLING_NAME,
            this.colN_STATUS,
            this.C_CHECK_DEPMT,
            this.N_SAMPLING_SN,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_QYMC.GridControl = this.gc_QYMC;
            this.gv_QYMC.Name = "gv_QYMC";
            this.gv_QYMC.OptionsBehavior.Editable = false;
            this.gv_QYMC.OptionsView.ColumnAutoWidth = false;
            this.gv_QYMC.OptionsView.ShowGroupPanel = false;
            // 
            // colC_SAMPLING_CODE
            // 
            this.colC_SAMPLING_CODE.Caption = "项目代码";
            this.colC_SAMPLING_CODE.FieldName = "C_SAMPLING_CODE";
            this.colC_SAMPLING_CODE.Name = "colC_SAMPLING_CODE";
            this.colC_SAMPLING_CODE.OptionsColumn.AllowEdit = false;
            this.colC_SAMPLING_CODE.Visible = true;
            this.colC_SAMPLING_CODE.VisibleIndex = 0;
            // 
            // colC_SAMPLING_NAME
            // 
            this.colC_SAMPLING_NAME.Caption = "项目名称";
            this.colC_SAMPLING_NAME.FieldName = "C_SAMPLING_NAME";
            this.colC_SAMPLING_NAME.Name = "colC_SAMPLING_NAME";
            this.colC_SAMPLING_NAME.Visible = true;
            this.colC_SAMPLING_NAME.VisibleIndex = 1;
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.Caption = "使用状态";
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
            this.colN_STATUS.OptionsColumn.ReadOnly = true;
            // 
            // C_CHECK_DEPMT
            // 
            this.C_CHECK_DEPMT.Caption = "检测部门";
            this.C_CHECK_DEPMT.ColumnEdit = this.repositoryItemImageComboBox1;
            this.C_CHECK_DEPMT.FieldName = "C_CHECK_DEPMT";
            this.C_CHECK_DEPMT.Name = "C_CHECK_DEPMT";
            this.C_CHECK_DEPMT.Visible = true;
            this.C_CHECK_DEPMT.VisibleIndex = 3;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            simpleContextButton1.Id = new System.Guid("2e7e1447-b85d-4125-9226-ca23cbeafcb2");
            simpleContextButton1.Name = "质控部";
            simpleContextButton2.Id = new System.Guid("d324b778-6093-4d74-a70e-ca08b852822b");
            simpleContextButton2.Name = "技术中心";
            this.repositoryItemImageComboBox1.ContextButtons.Add(simpleContextButton1);
            this.repositoryItemImageComboBox1.ContextButtons.Add(simpleContextButton2);
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // N_SAMPLING_SN
            // 
            this.N_SAMPLING_SN.Caption = "顺序号";
            this.N_SAMPLING_SN.FieldName = "N_SAMPLING_SN";
            this.N_SAMPLING_SN.Name = "N_SAMPLING_SN";
            this.N_SAMPLING_SN.Visible = true;
            this.N_SAMPLING_SN.VisibleIndex = 2;
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.Caption = "备注";
            this.colC_REMARK.FieldName = "C_REMARK";
            this.colC_REMARK.Name = "colC_REMARK";
            this.colC_REMARK.Visible = true;
            this.colC_REMARK.VisibleIndex = 4;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人员";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.OptionsColumn.ReadOnly = true;
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
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Query_Main);
            this.panelControl2.Controls.Add(this.btn_Update);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(908, 35);
            this.panelControl2.TabIndex = 63;
            // 
            // btn_Query_Main
            // 
            this.btn_Query_Main.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query_Main.Location = new System.Drawing.Point(12, 5);
            this.btn_Query_Main.Name = "btn_Query_Main";
            this.btn_Query_Main.Size = new System.Drawing.Size(75, 23);
            this.btn_Query_Main.TabIndex = 21;
            this.btn_Query_Main.Text = "查询";
            this.btn_Query_Main.Click += new System.EventHandler(this.btn_Query_Main_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(93, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "修改";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(174, 6);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbo_jcbm);
            this.panelControl1.Controls.Add(this.btn_Rest);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_Name);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(908, 40);
            this.panelControl1.TabIndex = 62;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(472, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 128;
            this.labelControl1.Text = "检测部门";
            // 
            // cbo_jcbm
            // 
            this.cbo_jcbm.Location = new System.Drawing.Point(528, 11);
            this.cbo_jcbm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_jcbm.Name = "cbo_jcbm";
            this.cbo_jcbm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_jcbm.Properties.Items.AddRange(new object[] {
            "质控部",
            "技术中心"});
            this.cbo_jcbm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbo_jcbm.Size = new System.Drawing.Size(100, 20);
            this.cbo_jcbm.TabIndex = 129;
            // 
            // btn_Rest
            // 
            this.btn_Rest.ImageUri.Uri = "Reset;Size16x16";
            this.btn_Rest.Location = new System.Drawing.Point(732, 9);
            this.btn_Rest.Name = "btn_Rest";
            this.btn_Rest.Size = new System.Drawing.Size(75, 23);
            this.btn_Rest.TabIndex = 127;
            this.btn_Rest.Text = "重置";
            this.btn_Rest.Click += new System.EventHandler(this.btn_Rest_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "项目名称";
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(651, 9);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(255, 11);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "备注";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(68, 11);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(181, 20);
            this.txt_Name.TabIndex = 27;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(285, 11);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(181, 20);
            this.txt_Remark.TabIndex = 25;
            // 
            // FrmQB_QYMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.gc_QYMC);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_QYMC";
            this.Text = "取样名称";
            this.Load += new System.EventHandler(this.FrmQB_QYMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_QYMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_QYMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_jcbm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_QYMC;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_QYMC;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SAMPLING_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SAMPLING_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Rest;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.TextEdit txt_Remark;
        private DevExpress.XtraGrid.Columns.GridColumn N_SAMPLING_SN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_jcbm;
        private DevExpress.XtraGrid.Columns.GridColumn C_CHECK_DEPMT;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btn_Query_Main;
    }
}