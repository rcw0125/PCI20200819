namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_GPDCWH
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
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Wgt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Len_Cool = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Len_Hot = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Slab = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Type = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Type1 = new DevExpress.XtraEditors.TextEdit();
            this.gc_Slab = new DevExpress.XtraGrid.GridControl();
            this.gv_Slab = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SLAB_SIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_HOT_LEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_COLD_LEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_THE_WEIGHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Wgt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Len_Cool.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Len_Hot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Slab.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Slab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Slab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(155, 8);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 4;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(924, 81);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Cancle.Location = new System.Drawing.Point(317, 8);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancle.TabIndex = 6;
            this.btn_Cancle.Text = "停用";
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.ImageUri.Uri = "Reset;Size16x16";
            this.btn_Reset.Location = new System.Drawing.Point(1006, 81);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 8;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.Location = new System.Drawing.Point(13, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "备注";
            // 
            // txt_Wgt
            // 
            this.txt_Wgt.Location = new System.Drawing.Point(809, 10);
            this.txt_Wgt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Wgt.Name = "txt_Wgt";
            this.txt_Wgt.Properties.Mask.EditMask = "F8";
            this.txt_Wgt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Wgt.Size = new System.Drawing.Size(100, 20);
            this.txt_Wgt.TabIndex = 29;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.Location = new System.Drawing.Point(726, 13);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 14);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "理论重量吨/支";
            // 
            // txt_Len_Cool
            // 
            this.txt_Len_Cool.Location = new System.Drawing.Point(620, 10);
            this.txt_Len_Cool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Len_Cool.Name = "txt_Len_Cool";
            this.txt_Len_Cool.Properties.Mask.EditMask = "F0";
            this.txt_Len_Cool.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Len_Cool.Size = new System.Drawing.Size(100, 20);
            this.txt_Len_Cool.TabIndex = 27;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.Location = new System.Drawing.Point(522, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 14);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "冷坯参考长度mm";
            // 
            // txt_Len_Hot
            // 
            this.txt_Len_Hot.Location = new System.Drawing.Point(416, 10);
            this.txt_Len_Hot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Len_Hot.Name = "txt_Len_Hot";
            this.txt_Len_Hot.Properties.Mask.EditMask = "F0";
            this.txt_Len_Hot.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Len_Hot.Size = new System.Drawing.Size(100, 20);
            this.txt_Len_Hot.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Location = new System.Drawing.Point(342, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "热坯长度mm";
            // 
            // txt_Slab
            // 
            this.txt_Slab.Location = new System.Drawing.Point(236, 10);
            this.txt_Slab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Slab.Name = "txt_Slab";
            this.txt_Slab.Size = new System.Drawing.Size(100, 20);
            this.txt_Slab.TabIndex = 23;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Location = new System.Drawing.Point(149, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 14);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "断面(mm*mm)";
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(43, 10);
            this.txt_Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(100, 20);
            this.txt_Type.TabIndex = 33;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.Location = new System.Drawing.Point(13, 13);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "类型";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txt_Type);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.txt_Slab);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btn_Reset);
            this.panelControl1.Controls.Add(this.txt_Len_Hot);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txt_Len_Cool);
            this.panelControl1.Controls.Add(this.txt_Wgt);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1342, 114);
            this.panelControl1.TabIndex = 51;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(43, 39);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(866, 65);
            this.txt_Remark.TabIndex = 31;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Update);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.txt_Type1);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.btn_Cancle);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 114);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1342, 36);
            this.panelControl2.TabIndex = 52;
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(236, 8);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 36;
            this.btn_Update.Text = "修改";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.Location = new System.Drawing.Point(13, 12);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "类型";
            // 
            // txt_Type1
            // 
            this.txt_Type1.Location = new System.Drawing.Point(43, 9);
            this.txt_Type1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Type1.Name = "txt_Type1";
            this.txt_Type1.Size = new System.Drawing.Size(100, 20);
            this.txt_Type1.TabIndex = 35;
            // 
            // gc_Slab
            // 
            this.gc_Slab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Slab.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_Slab.Location = new System.Drawing.Point(0, 150);
            this.gc_Slab.MainView = this.gv_Slab;
            this.gc_Slab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_Slab.Name = "gc_Slab";
            this.gc_Slab.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_Slab.Size = new System.Drawing.Size(1342, 482);
            this.gc_Slab.TabIndex = 54;
            this.gc_Slab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Slab});
            // 
            // gv_Slab
            // 
            this.gv_Slab.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_SLAB_SIZE,
            this.colC_TYPE,
            this.colC_HOT_LEN,
            this.colC_COLD_LEN,
            this.colC_THE_WEIGHT,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_Slab.GridControl = this.gc_Slab;
            this.gv_Slab.Name = "gv_Slab";
            this.gv_Slab.OptionsBehavior.Editable = false;
            this.gv_Slab.OptionsView.ColumnAutoWidth = false;
            this.gv_Slab.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_SLAB_SIZE
            // 
            this.colC_SLAB_SIZE.Caption = "断面";
            this.colC_SLAB_SIZE.FieldName = "C_SLAB_SIZE";
            this.colC_SLAB_SIZE.Name = "colC_SLAB_SIZE";
            this.colC_SLAB_SIZE.Visible = true;
            this.colC_SLAB_SIZE.VisibleIndex = 1;
            // 
            // colC_TYPE
            // 
            this.colC_TYPE.Caption = "类型";
            this.colC_TYPE.FieldName = "C_TYPE";
            this.colC_TYPE.Name = "colC_TYPE";
            this.colC_TYPE.Visible = true;
            this.colC_TYPE.VisibleIndex = 0;
            // 
            // colC_HOT_LEN
            // 
            this.colC_HOT_LEN.Caption = "热坯长度";
            this.colC_HOT_LEN.FieldName = "C_HOT_LEN";
            this.colC_HOT_LEN.Name = "colC_HOT_LEN";
            this.colC_HOT_LEN.Visible = true;
            this.colC_HOT_LEN.VisibleIndex = 2;
            // 
            // colC_COLD_LEN
            // 
            this.colC_COLD_LEN.Caption = "冷坯参考长度";
            this.colC_COLD_LEN.FieldName = "C_COLD_LEN";
            this.colC_COLD_LEN.Name = "colC_COLD_LEN";
            this.colC_COLD_LEN.Visible = true;
            this.colC_COLD_LEN.VisibleIndex = 3;
            // 
            // colC_THE_WEIGHT
            // 
            this.colC_THE_WEIGHT.Caption = "理论重量顿/支";
            this.colC_THE_WEIGHT.FieldName = "C_THE_WEIGHT";
            this.colC_THE_WEIGHT.Name = "colC_THE_WEIGHT";
            this.colC_THE_WEIGHT.Visible = true;
            this.colC_THE_WEIGHT.VisibleIndex = 4;
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
            this.colC_REMARK.VisibleIndex = 5;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人员";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 6;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "操作时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 7;
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
            // FrmQB_GPDCWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 632);
            this.Controls.Add(this.gc_Slab);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_GPDCWH";
            this.Text = "钢坯定尺";
            this.Load += new System.EventHandler(this.FrmQB_GPDCWH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Wgt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Len_Cool.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Len_Hot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Slab.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Slab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Slab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Cancle;
        private DevExpress.XtraEditors.SimpleButton btn_Reset;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_Wgt;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_Len_Cool;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Len_Hot;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Slab;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Type;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Type1;
        private DevExpress.XtraGrid.GridControl gc_Slab;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Slab;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SLAB_SIZE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_HOT_LEN;
        private DevExpress.XtraGrid.Columns.GridColumn colC_COLD_LEN;
        private DevExpress.XtraGrid.Columns.GridColumn colC_THE_WEIGHT;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
    }
}