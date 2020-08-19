namespace XGCAP.UI.P.PB
{
    partial class FrmPB_GWYDSJ_OLD
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
            this.gc_GWYDSJ = new DevExpress.XtraGrid.GridControl();
            this.gv_GWYDSJ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STA_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STA_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_CAPACITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.rbtn_isty_gx = new DevExpress.XtraEditors.RadioGroup();
            this.btn_QueryMain = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_JSGW2 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbo_QSGW2 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_id = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cn = new DevExpress.XtraEditors.TextEdit();
            this.btn_reset = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_QSGW1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbo_JSGW1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GWYDSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GWYDSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_gx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_JSGW2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_QSGW2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_QSGW1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_JSGW1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_GWYDSJ
            // 
            this.gc_GWYDSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GWYDSJ.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GWYDSJ.Location = new System.Drawing.Point(0, 103);
            this.gc_GWYDSJ.MainView = this.gv_GWYDSJ;
            this.gc_GWYDSJ.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GWYDSJ.Name = "gc_GWYDSJ";
            this.gc_GWYDSJ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gc_GWYDSJ.Size = new System.Drawing.Size(1015, 450);
            this.gc_GWYDSJ.TabIndex = 11;
            this.gc_GWYDSJ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GWYDSJ});
            // 
            // gv_GWYDSJ
            // 
            this.gv_GWYDSJ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_STA_ID1,
            this.colC_STA_ID2,
            this.colN_CAPACITY,
            this.colN_STATUS,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_GWYDSJ.GridControl = this.gc_GWYDSJ;
            this.gv_GWYDSJ.Name = "gv_GWYDSJ";
            this.gv_GWYDSJ.OptionsBehavior.Editable = false;
            this.gv_GWYDSJ.OptionsView.ShowGroupPanel = false;
            this.gv_GWYDSJ.Click += new System.EventHandler(this.gv_GWYDSJ_Click);
            // 
            // colC_ID
            // 
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_STA_ID1
            // 
            this.colC_STA_ID1.Caption = "起始工位";
            this.colC_STA_ID1.FieldName = "C_STA_ID1";
            this.colC_STA_ID1.Name = "colC_STA_ID1";
            this.colC_STA_ID1.Visible = true;
            this.colC_STA_ID1.VisibleIndex = 0;
            // 
            // colC_STA_ID2
            // 
            this.colC_STA_ID2.Caption = "结束工位";
            this.colC_STA_ID2.FieldName = "C_STA_ID2";
            this.colC_STA_ID2.Name = "colC_STA_ID2";
            this.colC_STA_ID2.Visible = true;
            this.colC_STA_ID2.VisibleIndex = 1;
            // 
            // colN_CAPACITY
            // 
            this.colN_CAPACITY.Caption = "时间";
            this.colN_CAPACITY.FieldName = "N_TIME";
            this.colN_CAPACITY.Name = "colN_CAPACITY";
            this.colN_CAPACITY.Visible = true;
            this.colN_CAPACITY.VisibleIndex = 2;
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.Caption = "状态";
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
            this.colN_STATUS.Visible = true;
            this.colN_STATUS.VisibleIndex = 3;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
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
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 5;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.rbtn_isty_gx);
            this.panelControl2.Controls.Add(this.btn_QueryMain);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.cbo_JSGW2);
            this.panelControl2.Controls.Add(this.cbo_QSGW2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 53);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1015, 50);
            this.panelControl2.TabIndex = 12;
            // 
            // rbtn_isty_gx
            // 
            this.rbtn_isty_gx.Location = new System.Drawing.Point(496, 16);
            this.rbtn_isty_gx.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_isty_gx.Name = "rbtn_isty_gx";
            this.rbtn_isty_gx.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "启用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "停用")});
            this.rbtn_isty_gx.Size = new System.Drawing.Size(149, 28);
            this.rbtn_isty_gx.TabIndex = 137;
            // 
            // btn_QueryMain
            // 
            this.btn_QueryMain.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_QueryMain.Location = new System.Drawing.Point(653, 17);
            this.btn_QueryMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_QueryMain.Name = "btn_QueryMain";
            this.btn_QueryMain.Size = new System.Drawing.Size(81, 29);
            this.btn_QueryMain.TabIndex = 136;
            this.btn_QueryMain.Text = "查询";
            this.btn_QueryMain.Click += new System.EventHandler(this.btn_QueryMain_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(742, 19);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(81, 29);
            this.btn_Stop.TabIndex = 135;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 17);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "起始工位";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(251, 20);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "结束工位";
            // 
            // cbo_JSGW2
            // 
            this.cbo_JSGW2.Location = new System.Drawing.Point(313, 16);
            this.cbo_JSGW2.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_JSGW2.Name = "cbo_JSGW2";
            this.cbo_JSGW2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_JSGW2.Size = new System.Drawing.Size(175, 24);
            this.cbo_JSGW2.TabIndex = 1;
            // 
            // cbo_QSGW2
            // 
            this.cbo_QSGW2.Location = new System.Drawing.Point(76, 16);
            this.cbo_QSGW2.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_QSGW2.Name = "cbo_QSGW2";
            this.cbo_QSGW2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_QSGW2.Size = new System.Drawing.Size(175, 24);
            this.cbo_QSGW2.TabIndex = 1;
            this.cbo_QSGW2.SelectedValueChanged += new System.EventHandler(this.cbo_QSGW2_SelectedValueChanged);
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
            this.panelControl1.Controls.Add(this.cbo_QSGW1);
            this.panelControl1.Controls.Add(this.cbo_JSGW1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1015, 53);
            this.panelControl1.TabIndex = 10;
            // 
            // lbl_id
            // 
            this.lbl_id.Location = new System.Drawing.Point(869, 13);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(10, 18);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            this.lbl_id.TextChanged += new System.EventHandler(this.lbl_id_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(488, 19);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "移动时间";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 19);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "起始工位";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(249, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "结束工位";
            // 
            // txt_cn
            // 
            this.txt_cn.Location = new System.Drawing.Point(550, 16);
            this.txt_cn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cn.Name = "txt_cn";
            this.txt_cn.Properties.Mask.EditMask = "n0";
            this.txt_cn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_cn.Size = new System.Drawing.Size(84, 24);
            this.txt_cn.TabIndex = 1;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(719, 14);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(81, 29);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "重置";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(636, 14);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 29);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "保存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cbo_QSGW1
            // 
            this.cbo_QSGW1.Location = new System.Drawing.Point(72, 16);
            this.cbo_QSGW1.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_QSGW1.Name = "cbo_QSGW1";
            this.cbo_QSGW1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_QSGW1.Size = new System.Drawing.Size(175, 24);
            this.cbo_QSGW1.TabIndex = 1;
            this.cbo_QSGW1.SelectedValueChanged += new System.EventHandler(this.cbo_QSGW1_SelectedValueChanged);
            // 
            // cbo_JSGW1
            // 
            this.cbo_JSGW1.Location = new System.Drawing.Point(311, 16);
            this.cbo_JSGW1.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_JSGW1.Name = "cbo_JSGW1";
            this.cbo_JSGW1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_JSGW1.Size = new System.Drawing.Size(175, 24);
            this.cbo_JSGW1.TabIndex = 1;
            // 
            // FrmPB_GWYDSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 553);
            this.Controls.Add(this.gc_GWYDSJ);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPB_GWYDSJ";
            this.Text = "工位转移时间";
            this.Load += new System.EventHandler(this.FrmPB_GWYDSJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_GWYDSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GWYDSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_gx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_JSGW2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_QSGW2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_QSGW1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_JSGW1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_GWYDSJ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GWYDSJ;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STA_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STA_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colN_CAPACITY;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_QueryMain;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_id;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_cn;
        private DevExpress.XtraEditors.SimpleButton btn_reset;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_QSGW1;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_JSGW1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_JSGW2;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_QSGW2;
        private DevExpress.XtraEditors.RadioGroup rbtn_isty_gx;
    }
}