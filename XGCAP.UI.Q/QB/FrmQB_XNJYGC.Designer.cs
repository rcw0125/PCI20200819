namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_XNJYGC
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
            this.gc_JYGC = new DevExpress.XtraGrid.GridControl();
            this.gv_JYGC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.性能名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_DESC_ITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.N_ORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_XNMC = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_XMMX = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Order = new DevExpress.XtraEditors.TextEdit();
            this.btn_Rest = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.imgcbo_Name = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.imgcbo_QYMC = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gc_JYGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_JYGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_XNMC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_XMMX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Order.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_QYMC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_JYGC
            // 
            this.gc_JYGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_JYGC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_JYGC.Location = new System.Drawing.Point(0, 75);
            this.gc_JYGC.MainView = this.gv_JYGC;
            this.gc_JYGC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_JYGC.Name = "gc_JYGC";
            this.gc_JYGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_JYGC.Size = new System.Drawing.Size(1177, 589);
            this.gc_JYGC.TabIndex = 67;
            this.gc_JYGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_JYGC});
            // 
            // gv_JYGC
            // 
            this.gv_JYGC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.性能名称,
            this.colC_DESC_ITEM,
            this.N_ORDER,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT,
            this.gridColumn1});
            this.gv_JYGC.GridControl = this.gc_JYGC;
            this.gv_JYGC.Name = "gv_JYGC";
            this.gv_JYGC.OptionsBehavior.Editable = false;
            this.gv_JYGC.OptionsView.ColumnAutoWidth = false;
            this.gv_JYGC.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "主键";
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // 性能名称
            // 
            this.性能名称.Caption = "性能名称";
            this.性能名称.FieldName = "性能名称";
            this.性能名称.Name = "性能名称";
            this.性能名称.Visible = true;
            this.性能名称.VisibleIndex = 0;
            // 
            // colC_DESC_ITEM
            // 
            this.colC_DESC_ITEM.Caption = "项目明细";
            this.colC_DESC_ITEM.FieldName = "C_DESC_ITEM";
            this.colC_DESC_ITEM.Name = "colC_DESC_ITEM";
            this.colC_DESC_ITEM.Visible = true;
            this.colC_DESC_ITEM.VisibleIndex = 2;
            // 
            // N_ORDER
            // 
            this.N_ORDER.Caption = "顺序号";
            this.N_ORDER.FieldName = "N_ORDER";
            this.N_ORDER.Name = "N_ORDER";
            this.N_ORDER.Visible = true;
            this.N_ORDER.VisibleIndex = 3;
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "项目类别";
            this.gridColumn1.FieldName = "C_DESC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
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
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.imgcbo_XNMC);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1177, 35);
            this.panelControl2.TabIndex = 66;
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(273, 6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 53;
            this.btn_Update.Text = "修改";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(192, 6);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 32;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "性能名称";
            // 
            // imgcbo_XNMC
            // 
            this.imgcbo_XNMC.EditValue = "全部";
            this.imgcbo_XNMC.Location = new System.Drawing.Point(67, 6);
            this.imgcbo_XNMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_XNMC.Name = "imgcbo_XNMC";
            this.imgcbo_XNMC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_XNMC.Size = new System.Drawing.Size(113, 20);
            this.imgcbo_XNMC.TabIndex = 31;
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(354, 6);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_XMMX);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txt_Order);
            this.panelControl1.Controls.Add(this.btn_Rest);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.imgcbo_Name);
            this.panelControl1.Controls.Add(this.imgcbo_QYMC);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1177, 40);
            this.panelControl1.TabIndex = 65;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(392, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 135;
            this.labelControl5.Text = "项目明细";
            // 
            // txt_XMMX
            // 
            this.txt_XMMX.Location = new System.Drawing.Point(445, 10);
            this.txt_XMMX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_XMMX.Name = "txt_XMMX";
            this.txt_XMMX.Size = new System.Drawing.Size(212, 20);
            this.txt_XMMX.TabIndex = 136;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(663, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 133;
            this.labelControl4.Text = "顺序号";
            // 
            // txt_Order
            // 
            this.txt_Order.Location = new System.Drawing.Point(706, 10);
            this.txt_Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Order.Name = "txt_Order";
            this.txt_Order.Properties.Mask.EditMask = "F0";
            this.txt_Order.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Order.Size = new System.Drawing.Size(87, 20);
            this.txt_Order.TabIndex = 134;
            // 
            // btn_Rest
            // 
            this.btn_Rest.ImageUri.Uri = "Reset;Size16x16";
            this.btn_Rest.Location = new System.Drawing.Point(890, 9);
            this.btn_Rest.Name = "btn_Rest";
            this.btn_Rest.Size = new System.Drawing.Size(75, 23);
            this.btn_Rest.TabIndex = 127;
            this.btn_Rest.Text = "重置";
            this.btn_Rest.Click += new System.EventHandler(this.btn_Rest_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "性能名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(186, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "项目类别";
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Add;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(809, 9);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "添加";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // imgcbo_Name
            // 
            this.imgcbo_Name.Location = new System.Drawing.Point(67, 10);
            this.imgcbo_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_Name.Name = "imgcbo_Name";
            this.imgcbo_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_Name.Size = new System.Drawing.Size(113, 20);
            this.imgcbo_Name.TabIndex = 29;
            this.imgcbo_Name.SelectedIndexChanged += new System.EventHandler(this.imgcbo_Name_SelectedIndexChanged);
            // 
            // imgcbo_QYMC
            // 
            this.imgcbo_QYMC.Location = new System.Drawing.Point(239, 10);
            this.imgcbo_QYMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_QYMC.Name = "imgcbo_QYMC";
            this.imgcbo_QYMC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_QYMC.Size = new System.Drawing.Size(146, 20);
            this.imgcbo_QYMC.TabIndex = 27;
            // 
            // FrmQB_XNJYGC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 664);
            this.Controls.Add(this.gc_JYGC);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_XNJYGC";
            this.Text = "性能检验过程";
            this.Load += new System.EventHandler(this.FrmQB_XNJYGC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_JYGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_JYGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_XNMC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_XMMX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Order.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_QYMC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_JYGC;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_JYGC;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_XNMC;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Rest;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_Name;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn 性能名称;
        private DevExpress.XtraGrid.Columns.GridColumn colC_DESC_ITEM;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Order;
        private DevExpress.XtraGrid.Columns.GridColumn N_ORDER;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_XMMX;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_QYMC;
    }
}