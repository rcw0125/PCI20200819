namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_SYSBWH
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
            this.gc_SYSB = new DevExpress.XtraGrid.GridControl();
            this.modTQBPHYSICSEQUIPMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv_SYSB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EQ_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EQ_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EQ_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name1 = new DevExpress.XtraEditors.TextEdit();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_num = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Code = new DevExpress.XtraEditors.TextEdit();
            this.btn_Rest = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.imgcbo_Name = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SYSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modTQBPHYSICSEQUIPMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SYSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Name.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_SYSB
            // 
            this.gc_SYSB.DataSource = this.modTQBPHYSICSEQUIPMENTBindingSource;
            this.gc_SYSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SYSB.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_SYSB.Location = new System.Drawing.Point(0, 122);
            this.gc_SYSB.MainView = this.gv_SYSB;
            this.gc_SYSB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_SYSB.Name = "gc_SYSB";
            this.gc_SYSB.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_SYSB.Size = new System.Drawing.Size(870, 328);
            this.gc_SYSB.TabIndex = 64;
            this.gc_SYSB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SYSB});
            // 
            // modTQBPHYSICSEQUIPMENTBindingSource
            // 
            this.modTQBPHYSICSEQUIPMENTBindingSource.DataSource = typeof(MODEL.Mod_TQB_PHYSICS_EQUIPMENT);
            // 
            // gv_SYSB
            // 
            this.gv_SYSB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.C_NAME,
            this.colC_EQ_NAME,
            this.colC_EQ_NUMBER,
            this.colC_EQ_CODE,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_SYSB.GridControl = this.gc_SYSB;
            this.gv_SYSB.Name = "gv_SYSB";
            this.gv_SYSB.OptionsBehavior.Editable = false;
            this.gv_SYSB.OptionsView.ColumnAutoWidth = false;
            this.gv_SYSB.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "主键";
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // C_NAME
            // 
            this.C_NAME.Caption = "性能名称";
            this.C_NAME.FieldName = "C_NAME";
            this.C_NAME.Name = "C_NAME";
            this.C_NAME.Visible = true;
            this.C_NAME.VisibleIndex = 0;
            // 
            // colC_EQ_NAME
            // 
            this.colC_EQ_NAME.Caption = "设备名称";
            this.colC_EQ_NAME.FieldName = "C_EQ_NAME";
            this.colC_EQ_NAME.Name = "colC_EQ_NAME";
            this.colC_EQ_NAME.Visible = true;
            this.colC_EQ_NAME.VisibleIndex = 1;
            // 
            // colC_EQ_NUMBER
            // 
            this.colC_EQ_NUMBER.Caption = "设备型号";
            this.colC_EQ_NUMBER.FieldName = "C_EQ_NUMBER";
            this.colC_EQ_NUMBER.Name = "colC_EQ_NUMBER";
            this.colC_EQ_NUMBER.Visible = true;
            this.colC_EQ_NUMBER.VisibleIndex = 2;
            // 
            // colC_EQ_CODE
            // 
            this.colC_EQ_CODE.Caption = "设备编号";
            this.colC_EQ_CODE.FieldName = "C_EQ_CODE";
            this.colC_EQ_CODE.Name = "colC_EQ_CODE";
            this.colC_EQ_CODE.Visible = true;
            this.colC_EQ_CODE.VisibleIndex = 3;
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.Caption = "使用状态";
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
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
            this.panelControl2.Controls.Add(this.btn_Update);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.txt_Name1);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 87);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(870, 35);
            this.panelControl2.TabIndex = 63;
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(269, 7);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 55;
            this.btn_Update.Text = "修改";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(188, 7);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 54;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 11);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "设备名称";
            // 
            // txt_Name1
            // 
            this.txt_Name1.Location = new System.Drawing.Point(67, 8);
            this.txt_Name1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name1.Name = "txt_Name1";
            this.txt_Name1.Size = new System.Drawing.Size(115, 20);
            this.txt_Name1.TabIndex = 29;
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(350, 7);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txt_num);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txt_Code);
            this.panelControl1.Controls.Add(this.btn_Rest);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_Name);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Controls.Add(this.imgcbo_Name);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(870, 87);
            this.panelControl1.TabIndex = 62;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(337, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 130;
            this.labelControl4.Text = "设备型号";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(391, 9);
            this.txt_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num.Name = "txt_num";
            this.txt_num.Properties.MaxLength = 50;
            this.txt_num.Size = new System.Drawing.Size(115, 20);
            this.txt_num.TabIndex = 131;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(512, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 128;
            this.labelControl3.Text = "设备编码";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(566, 9);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Properties.MaxLength = 50;
            this.txt_Code.Size = new System.Drawing.Size(115, 20);
            this.txt_Code.TabIndex = 129;
            // 
            // btn_Rest
            // 
            this.btn_Rest.ImageUri.Uri = "Reset;Size16x16";
            this.btn_Rest.Location = new System.Drawing.Point(701, 54);
            this.btn_Rest.Name = "btn_Rest";
            this.btn_Rest.Size = new System.Drawing.Size(75, 23);
            this.btn_Rest.TabIndex = 127;
            this.btn_Rest.Text = "重置";
            this.btn_Rest.Click += new System.EventHandler(this.btn_Rest_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "性能名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(162, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "设备名称";
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Add;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(701, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "添加";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(37, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "备注";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(216, 9);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.MaxLength = 50;
            this.txt_Name.Size = new System.Drawing.Size(115, 20);
            this.txt_Name.TabIndex = 27;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(67, 39);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(614, 38);
            this.txt_Remark.TabIndex = 25;
            // 
            // imgcbo_Name
            // 
            this.imgcbo_Name.Location = new System.Drawing.Point(67, 9);
            this.imgcbo_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_Name.Name = "imgcbo_Name";
            this.imgcbo_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_Name.Size = new System.Drawing.Size(89, 20);
            this.imgcbo_Name.TabIndex = 29;
            // 
            // FrmQB_SYSBWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.gc_SYSB);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_SYSBWH";
            this.Text = "实验设备维护";
            this.Load += new System.EventHandler(this.FrmQB_SYSBWH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SYSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modTQBPHYSICSEQUIPMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SYSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Name.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_SYSB;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SYSB;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Rest;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_num;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Code;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_Name;
        private System.Windows.Forms.BindingSource modTQBPHYSICSEQUIPMENTBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn C_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EQ_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EQ_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EQ_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_Name1;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
    }
}