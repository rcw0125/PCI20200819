namespace XGCAP.UI.P.PB
{
    partial class FrmPB_GLCN_OLD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPB_GLCN_OLD));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_id = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cn = new DevExpress.XtraEditors.TextEdit();
            this.btn_reset = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_GX = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbo_GW = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.rbtn_isty_gx = new DevExpress.XtraEditors.RadioGroup();
            this.gc_GWCN = new DevExpress.XtraGrid.GridControl();
            this.gv_GWCN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_PRO_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STA_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STA_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_CAPACITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_START_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_END_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_QueryMain = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_GX_Query = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_gx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GWCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GWCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX_Query.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbl_id);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_cn);
            this.panelControl1.Controls.Add(this.btn_reset);
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Controls.Add(this.cbo_GX);
            this.panelControl1.Controls.Add(this.cbo_GW);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1223, 53);
            this.panelControl1.TabIndex = 7;
            // 
            // lbl_id
            // 
            this.lbl_id.Location = new System.Drawing.Point(1054, 18);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(45, 18);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "日产能";
            this.lbl_id.Visible = false;
            this.lbl_id.TextChanged += new System.EventHandler(this.lbl_id_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(467, 19);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "日产能";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 19);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "工序";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(236, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "工位";
            // 
            // txt_cn
            // 
            this.txt_cn.Location = new System.Drawing.Point(525, 16);
            this.txt_cn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cn.Name = "txt_cn";
            this.txt_cn.Properties.Mask.EditMask = "n0";
            this.txt_cn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_cn.Size = new System.Drawing.Size(84, 24);
            this.txt_cn.TabIndex = 1;
            // 
            // btn_reset
            // 
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.Location = new System.Drawing.Point(716, 14);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(81, 29);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "重置";
            this.btn_reset.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(622, 14);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 29);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "保存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cbo_GX
            // 
            this.cbo_GX.Location = new System.Drawing.Point(48, 16);
            this.cbo_GX.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_GX.Name = "cbo_GX";
            this.cbo_GX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GX.Size = new System.Drawing.Size(175, 24);
            this.cbo_GX.TabIndex = 1;
            this.cbo_GX.SelectedValueChanged += new System.EventHandler(this.cbo_GW_SelectedValueChanged);
            // 
            // cbo_GW
            // 
            this.cbo_GW.Location = new System.Drawing.Point(279, 16);
            this.cbo_GW.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_GW.Name = "cbo_GW";
            this.cbo_GW.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GW.Size = new System.Drawing.Size(175, 24);
            this.cbo_GW.TabIndex = 1;
            // 
            // rbtn_isty_gx
            // 
            this.rbtn_isty_gx.Location = new System.Drawing.Point(256, 12);
            this.rbtn_isty_gx.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_isty_gx.Name = "rbtn_isty_gx";
            this.rbtn_isty_gx.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "启用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "停用")});
            this.rbtn_isty_gx.Size = new System.Drawing.Size(149, 28);
            this.rbtn_isty_gx.TabIndex = 134;
            // 
            // gc_GWCN
            // 
            this.gc_GWCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GWCN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GWCN.Location = new System.Drawing.Point(0, 103);
            this.gc_GWCN.MainView = this.gv_GWCN;
            this.gc_GWCN.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GWCN.Name = "gc_GWCN";
            this.gc_GWCN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gc_GWCN.Size = new System.Drawing.Size(1223, 408);
            this.gc_GWCN.TabIndex = 8;
            this.gc_GWCN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GWCN});
            // 
            // gv_GWCN
            // 
            this.gv_GWCN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_PRO_ID,
            this.colC_STA_ID,
            this.colC_STA_DESC,
            this.colC_STA_CODE,
            this.colN_CAPACITY,
            this.colD_START_DATE,
            this.colD_END_DATE,
            this.colN_STATUS,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_GWCN.GridControl = this.gc_GWCN;
            this.gv_GWCN.Name = "gv_GWCN";
            this.gv_GWCN.OptionsBehavior.Editable = false;
            this.gv_GWCN.OptionsView.ShowGroupPanel = false;
            this.gv_GWCN.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colC_ID
            // 
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_PRO_ID
            // 
            this.colC_PRO_ID.Caption = "工序";
            this.colC_PRO_ID.FieldName = "C_PRO_ID";
            this.colC_PRO_ID.Name = "colC_PRO_ID";
            this.colC_PRO_ID.Visible = true;
            this.colC_PRO_ID.VisibleIndex = 0;
            // 
            // colC_STA_ID
            // 
            this.colC_STA_ID.Caption = "工位主键";
            this.colC_STA_ID.FieldName = "C_STA_ID";
            this.colC_STA_ID.Name = "colC_STA_ID";
            // 
            // colC_STA_DESC
            // 
            this.colC_STA_DESC.Caption = "工位";
            this.colC_STA_DESC.FieldName = "C_STA_DESC";
            this.colC_STA_DESC.Name = "colC_STA_DESC";
            this.colC_STA_DESC.Visible = true;
            this.colC_STA_DESC.VisibleIndex = 1;
            // 
            // colC_STA_CODE
            // 
            this.colC_STA_CODE.Caption = "工位代码";
            this.colC_STA_CODE.FieldName = "C_STA_CODE";
            this.colC_STA_CODE.Name = "colC_STA_CODE";
            this.colC_STA_CODE.Visible = true;
            this.colC_STA_CODE.VisibleIndex = 2;
            // 
            // colN_CAPACITY
            // 
            this.colN_CAPACITY.Caption = "产能";
            this.colN_CAPACITY.FieldName = "N_CAPACITY";
            this.colN_CAPACITY.Name = "colN_CAPACITY";
            this.colN_CAPACITY.Visible = true;
            this.colN_CAPACITY.VisibleIndex = 3;
            // 
            // colD_START_DATE
            // 
            this.colD_START_DATE.FieldName = "D_START_DATE";
            this.colD_START_DATE.Name = "colD_START_DATE";
            // 
            // colD_END_DATE
            // 
            this.colD_END_DATE.FieldName = "D_END_DATE";
            this.colD_END_DATE.Name = "colD_END_DATE";
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.Caption = "状态";
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
            this.colN_STATUS.Visible = true;
            this.colN_STATUS.VisibleIndex = 4;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人";
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
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_QueryMain);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Controls.Add(this.rbtn_isty_gx);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.cbo_GX_Query);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 53);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1223, 50);
            this.panelControl2.TabIndex = 9;
            // 
            // btn_QueryMain
            // 
            this.btn_QueryMain.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_QueryMain.Location = new System.Drawing.Point(428, 12);
            this.btn_QueryMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_QueryMain.Name = "btn_QueryMain";
            this.btn_QueryMain.Size = new System.Drawing.Size(100, 29);
            this.btn_QueryMain.TabIndex = 136;
            this.btn_QueryMain.Text = "查询";
            this.btn_QueryMain.Click += new System.EventHandler(this.btn_QueryMain_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(551, 12);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(100, 29);
            this.btn_Stop.TabIndex = 135;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // cbo_GX_Query
            // 
            this.cbo_GX_Query.Location = new System.Drawing.Point(58, 14);
            this.cbo_GX_Query.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_GX_Query.Name = "cbo_GX_Query";
            this.cbo_GX_Query.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GX_Query.Size = new System.Drawing.Size(175, 24);
            this.cbo_GX_Query.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 17);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 18);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "工序";
            // 
            // FrmPB_GLCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 511);
            this.Controls.Add(this.gc_GWCN);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPB_GLCN";
            this.Text = "工位日产能维护";
            this.Load += new System.EventHandler(this.FrmPB_GLCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_gx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GWCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GWCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX_Query.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_cn;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraGrid.GridControl gc_GWCN;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GWCN;
        private DevExpress.XtraEditors.SimpleButton btn_reset;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GW;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_PRO_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STA_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STA_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colN_CAPACITY;
        private DevExpress.XtraGrid.Columns.GridColumn colD_START_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colD_END_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.LabelControl lbl_id;
        private DevExpress.XtraEditors.RadioGroup rbtn_isty_gx;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GX;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_QueryMain;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GX_Query;
    }
}