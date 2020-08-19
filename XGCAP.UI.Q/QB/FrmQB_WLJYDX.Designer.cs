namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_WLJYDX
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
            this.modTQBPHYSICSQUALITATIVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Resulet = new DevExpress.XtraEditors.TextEdit();
            this.imgcbo_XM = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_XNMC = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.lab = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.imgcbo_XM1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gc_WLJY = new DevExpress.XtraGrid.GridControl();
            this.gv_WLJY = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_RESULT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.modTQBPHYSICSQUALITATIVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Resulet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_XM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_XNMC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_XM1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WLJY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WLJY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // modTQBPHYSICSQUALITATIVEBindingSource
            // 
            this.modTQBPHYSICSQUALITATIVEBindingSource.DataSource = typeof(MODEL.Mod_TQB_PHYSICS_QUALITATIVE);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txt_Resulet);
            this.panelControl1.Controls.Add(this.imgcbo_XM);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.imgcbo_XNMC);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.lab);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1041, 40);
            this.panelControl1.TabIndex = 63;
            // 
            // txt_Resulet
            // 
            this.txt_Resulet.Location = new System.Drawing.Point(434, 11);
            this.txt_Resulet.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Resulet.Name = "txt_Resulet";
            this.txt_Resulet.Properties.MaxLength = 50;
            this.txt_Resulet.Size = new System.Drawing.Size(114, 20);
            this.txt_Resulet.TabIndex = 40;
            // 
            // imgcbo_XM
            // 
            this.imgcbo_XM.Location = new System.Drawing.Point(43, 10);
            this.imgcbo_XM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_XM.Name = "imgcbo_XM";
            this.imgcbo_XM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_XM.Size = new System.Drawing.Size(125, 20);
            this.imgcbo_XM.TabIndex = 34;
            this.imgcbo_XM.SelectedIndexChanged += new System.EventHandler(this.imgcbo_XM_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "项目";
            // 
            // imgcbo_XNMC
            // 
            this.imgcbo_XNMC.Location = new System.Drawing.Point(232, 10);
            this.imgcbo_XNMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_XNMC.Name = "imgcbo_XNMC";
            this.imgcbo_XNMC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_XNMC.Size = new System.Drawing.Size(168, 20);
            this.imgcbo_XNMC.TabIndex = 32;
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(554, 10);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 28;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lab
            // 
            this.lab.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lab.Location = new System.Drawing.Point(178, 13);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(48, 14);
            this.lab.TabIndex = 31;
            this.lab.Text = "性能名称";
            // 
            // labelControl2
            // 
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(406, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "结果";
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(255, 9);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 29;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.imgcbo_XM1);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1041, 40);
            this.panelControl2.TabIndex = 65;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(174, 9);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 53;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // imgcbo_XM1
            // 
            this.imgcbo_XM1.Location = new System.Drawing.Point(43, 10);
            this.imgcbo_XM1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_XM1.Name = "imgcbo_XM1";
            this.imgcbo_XM1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_XM1.Size = new System.Drawing.Size(125, 20);
            this.imgcbo_XM1.TabIndex = 34;
            // 
            // labelControl3
            // 
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(13, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "项目";
            // 
            // gc_WLJY
            // 
            this.gc_WLJY.DataSource = this.modTQBPHYSICSQUALITATIVEBindingSource;
            this.gc_WLJY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_WLJY.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_WLJY.Location = new System.Drawing.Point(0, 80);
            this.gc_WLJY.MainView = this.gv_WLJY;
            this.gc_WLJY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_WLJY.Name = "gc_WLJY";
            this.gc_WLJY.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_WLJY.Size = new System.Drawing.Size(1041, 370);
            this.gc_WLJY.TabIndex = 66;
            this.gc_WLJY.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_WLJY});
            // 
            // gv_WLJY
            // 
            this.gv_WLJY.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_CODE,
            this.colC_NAME,
            this.C_RESULT,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_WLJY.GridControl = this.gc_WLJY;
            this.gv_WLJY.Name = "gv_WLJY";
            this.gv_WLJY.OptionsBehavior.Editable = false;
            this.gv_WLJY.OptionsView.ColumnAutoWidth = false;
            this.gv_WLJY.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "主键";
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_CODE
            // 
            this.colC_CODE.Caption = "代码";
            this.colC_CODE.FieldName = "C_CHARACTER_ID";
            this.colC_CODE.Name = "colC_CODE";
            // 
            // colC_NAME
            // 
            this.colC_NAME.Caption = "项目";
            this.colC_NAME.FieldName = "C_NAME";
            this.colC_NAME.Name = "colC_NAME";
            this.colC_NAME.Visible = true;
            this.colC_NAME.VisibleIndex = 0;
            // 
            // C_RESULT
            // 
            this.C_RESULT.Caption = "结果";
            this.C_RESULT.FieldName = "C_RESULT";
            this.C_RESULT.Name = "C_RESULT";
            this.C_RESULT.Visible = true;
            this.C_RESULT.VisibleIndex = 1;
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
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "维护人员";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 2;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "维护时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
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
            // FrmQB_WLJYDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.gc_WLJY);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_WLJYDX";
            this.Text = "物理检验枚举";
            this.Load += new System.EventHandler(this.Frm_QB_WLJYDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modTQBPHYSICSQUALITATIVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Resulet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_XM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_XNMC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_XM1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_WLJY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_WLJY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.LabelControl lab;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_XNMC;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_XM;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource modTQBPHYSICSQUALITATIVEBindingSource;
        private DevExpress.XtraEditors.TextEdit txt_Resulet;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_XM1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraGrid.GridControl gc_WLJY;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_WLJY;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn C_RESULT;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}