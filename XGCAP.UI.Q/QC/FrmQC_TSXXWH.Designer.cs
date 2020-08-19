namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_TSXXWH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gc_TSXX = new DevExpress.XtraGrid.GridControl();
            this.gv_TSXX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_TYPE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_TYPE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_LRBM = new DevExpress.XtraEditors.TextEdit();
            this.txt_QXBM = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Rest = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.txt_Content = new DevExpress.XtraEditors.MemoEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TSXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TSXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LRBM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QXBM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Content.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gc_TSXX);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 694);
            this.panel1.TabIndex = 0;
            // 
            // gc_TSXX
            // 
            this.gc_TSXX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TSXX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_TSXX.Location = new System.Drawing.Point(0, 124);
            this.gc_TSXX.MainView = this.gv_TSXX;
            this.gc_TSXX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_TSXX.Name = "gc_TSXX";
            this.gc_TSXX.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_TSXX.Size = new System.Drawing.Size(1084, 570);
            this.gc_TSXX.TabIndex = 64;
            this.gc_TSXX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_TSXX});
            // 
            // gv_TSXX
            // 
            this.gv_TSXX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_TYPE_CODE,
            this.colC_TYPE_NAME,
            this.gridColumn1,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_TSXX.GridControl = this.gc_TSXX;
            this.gv_TSXX.Name = "gv_TSXX";
            this.gv_TSXX.OptionsBehavior.Editable = false;
            this.gv_TSXX.OptionsView.ColumnAutoWidth = false;
            this.gv_TSXX.OptionsView.ShowGroupPanel = false;
            // 
            // colC_TYPE_CODE
            // 
            this.colC_TYPE_CODE.Caption = "录入部门";
            this.colC_TYPE_CODE.FieldName = "C_LR_BM";
            this.colC_TYPE_CODE.Name = "colC_TYPE_CODE";
            this.colC_TYPE_CODE.Visible = true;
            this.colC_TYPE_CODE.VisibleIndex = 0;
            // 
            // colC_TYPE_NAME
            // 
            this.colC_TYPE_NAME.Caption = "内容";
            this.colC_TYPE_NAME.FieldName = "C_CONTENT";
            this.colC_TYPE_NAME.Name = "colC_TYPE_NAME";
            this.colC_TYPE_NAME.Visible = true;
            this.colC_TYPE_NAME.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "取消部门";
            this.gridColumn1.FieldName = "C_QX_BM";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Rest);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_Stop);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_LRBM);
            this.panelControl1.Controls.Add(this.txt_QXBM);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Controls.Add(this.txt_Content);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 124);
            this.panelControl1.TabIndex = 62;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "内容";
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(427, 60);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "录入部门";
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(427, 34);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(220, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "取消部门";
            // 
            // txt_LRBM
            // 
            this.txt_LRBM.Location = new System.Drawing.Point(68, 9);
            this.txt_LRBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LRBM.Name = "txt_LRBM";
            this.txt_LRBM.Properties.MaxLength = 50;
            this.txt_LRBM.Size = new System.Drawing.Size(146, 20);
            this.txt_LRBM.TabIndex = 27;
            // 
            // txt_QXBM
            // 
            this.txt_QXBM.Location = new System.Drawing.Point(274, 9);
            this.txt_QXBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_QXBM.Name = "txt_QXBM";
            this.txt_QXBM.Size = new System.Drawing.Size(147, 20);
            this.txt_QXBM.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "备注";
            // 
            // btn_Rest
            // 
            this.btn_Rest.ImageUri.Uri = "Reset;Size16x16";
            this.btn_Rest.Location = new System.Drawing.Point(427, 86);
            this.btn_Rest.Name = "btn_Rest";
            this.btn_Rest.Size = new System.Drawing.Size(75, 23);
            this.btn_Rest.TabIndex = 128;
            this.btn_Rest.Text = "重置";
            this.btn_Rest.Click += new System.EventHandler(this.btn_Rest_Click);
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(68, 74);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(353, 37);
            this.txt_Remark.TabIndex = 30;
            // 
            // txt_Content
            // 
            this.txt_Content.Location = new System.Drawing.Point(68, 33);
            this.txt_Content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Properties.MaxLength = 50;
            this.txt_Content.Size = new System.Drawing.Size(353, 37);
            this.txt_Content.TabIndex = 29;
            // 
            // FrmQC_TSXXWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 694);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQC_TSXXWH";
            this.Text = "FrmQC_TSXX";
            this.Load += new System.EventHandler(this.FrmQC_TSXX_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TSXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TSXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LRBM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QXBM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Content.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gc_TSXX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TSXX;
        private DevExpress.XtraGrid.Columns.GridColumn colC_TYPE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_TYPE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_LRBM;
        private DevExpress.XtraEditors.TextEdit txt_QXBM;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Rest;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.MemoEdit txt_Content;
    }
}