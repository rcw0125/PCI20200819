namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_XMYQ
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
            this.txt_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdite_STlGRD = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_STD = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Min = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Max = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Rest = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.txt_CraftFlow = new DevExpress.XtraEditors.MemoEdit();
            this.imcbo_CopingCraft = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdite_STlGRD1 = new DevExpress.XtraEditors.ButtonEdit();
            this.gc_Coping = new DevExpress.XtraGrid.GridControl();
            this.gv_Coping = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SPCIFICATION_MIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SPCIFICATION_MAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_COPING_CRAFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_CRAFT_FLOW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_KHMC = new DevExpress.XtraEditors.ButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdite_STlGRD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_STD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Min.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Max.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CraftFlow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imcbo_CopingCraft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdite_STlGRD1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Coping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Coping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_KHMC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(148, 8);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 13;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txt_Stop
            // 
            this.txt_Stop.ImageUri.Uri = "Cancel;Size16x16";
            this.txt_Stop.Location = new System.Drawing.Point(310, 8);
            this.txt_Stop.Name = "txt_Stop";
            this.txt_Stop.Size = new System.Drawing.Size(75, 23);
            this.txt_Stop.TabIndex = 14;
            this.txt_Stop.Text = "停用";
            this.txt_Stop.Click += new System.EventHandler(this.txt_Stop_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(805, 80);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "钢种";
            // 
            // btnEdite_STlGRD
            // 
            this.btnEdite_STlGRD.Location = new System.Drawing.Point(73, 12);
            this.btnEdite_STlGRD.Name = "btnEdite_STlGRD";
            this.btnEdite_STlGRD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEdite_STlGRD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnEdite_STlGRD.Size = new System.Drawing.Size(100, 20);
            this.btnEdite_STlGRD.TabIndex = 49;
            this.btnEdite_STlGRD.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_STlGRD_ButtonClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(192, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "执行标准";
            // 
            // imgcbo_STD
            // 
            this.imgcbo_STD.Location = new System.Drawing.Point(247, 11);
            this.imgcbo_STD.Name = "imgcbo_STD";
            this.imgcbo_STD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_STD.Size = new System.Drawing.Size(100, 20);
            this.imgcbo_STD.TabIndex = 50;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "规格最小值";
            // 
            // txt_Min
            // 
            this.txt_Min.Location = new System.Drawing.Point(73, 40);
            this.txt_Min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.Properties.Mask.EditMask = "f2";
            this.txt_Min.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Min.Size = new System.Drawing.Size(100, 20);
            this.txt_Min.TabIndex = 23;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(180, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "规格最大值";
            // 
            // txt_Max
            // 
            this.txt_Max.Location = new System.Drawing.Point(247, 40);
            this.txt_Max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Max.Name = "txt_Max";
            this.txt_Max.Properties.Mask.EditMask = "f2";
            this.txt_Max.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Max.Size = new System.Drawing.Size(100, 20);
            this.txt_Max.TabIndex = 25;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(353, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "修磨工艺";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(353, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "工艺流程";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(43, 66);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "备注";
            // 
            // btn_Rest
            // 
            this.btn_Rest.ImageUri.Uri = "Reset;Size16x16";
            this.btn_Rest.Location = new System.Drawing.Point(886, 80);
            this.btn_Rest.Name = "btn_Rest";
            this.btn_Rest.Size = new System.Drawing.Size(75, 23);
            this.btn_Rest.TabIndex = 51;
            this.btn_Rest.Text = "重置";
            this.btn_Rest.Click += new System.EventHandler(this.btn_Rest_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.btn_KHMC);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.btnEdite_STlGRD);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.imgcbo_STD);
            this.panelControl1.Controls.Add(this.btn_Rest);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.txt_Min);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txt_Max);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Controls.Add(this.txt_CraftFlow);
            this.panelControl1.Controls.Add(this.imcbo_CopingCraft);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1040, 112);
            this.panelControl1.TabIndex = 57;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(73, 69);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(274, 34);
            this.txt_Remark.TabIndex = 31;
            // 
            // txt_CraftFlow
            // 
            this.txt_CraftFlow.Location = new System.Drawing.Point(407, 41);
            this.txt_CraftFlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CraftFlow.Name = "txt_CraftFlow";
            this.txt_CraftFlow.Size = new System.Drawing.Size(392, 62);
            this.txt_CraftFlow.TabIndex = 27;
            // 
            // imcbo_CopingCraft
            // 
            this.imcbo_CopingCraft.Location = new System.Drawing.Point(407, 13);
            this.imcbo_CopingCraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imcbo_CopingCraft.Name = "imcbo_CopingCraft";
            this.imcbo_CopingCraft.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imcbo_CopingCraft.Size = new System.Drawing.Size(100, 20);
            this.imcbo_CopingCraft.TabIndex = 29;
            this.imcbo_CopingCraft.SelectedIndexChanged += new System.EventHandler(this.imcbo_CopingCraft_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Update);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.btnEdite_STlGRD1);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.txt_Stop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 112);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1040, 36);
            this.panelControl2.TabIndex = 58;
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(229, 8);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 52;
            this.btn_Update.Text = "修改";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 14);
            this.labelControl8.TabIndex = 50;
            this.labelControl8.Text = "钢种";
            // 
            // btnEdite_STlGRD1
            // 
            this.btnEdite_STlGRD1.Location = new System.Drawing.Point(43, 9);
            this.btnEdite_STlGRD1.Name = "btnEdite_STlGRD1";
            this.btnEdite_STlGRD1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEdite_STlGRD1.Size = new System.Drawing.Size(100, 20);
            this.btnEdite_STlGRD1.TabIndex = 51;
            this.btnEdite_STlGRD1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEdite_STlGRD1_ButtonClick);
            // 
            // gc_Coping
            // 
            this.gc_Coping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Coping.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_Coping.Location = new System.Drawing.Point(0, 148);
            this.gc_Coping.MainView = this.gv_Coping;
            this.gc_Coping.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_Coping.Name = "gc_Coping";
            this.gc_Coping.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_Coping.Size = new System.Drawing.Size(1040, 548);
            this.gc_Coping.TabIndex = 60;
            this.gc_Coping.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Coping});
            // 
            // gv_Coping
            // 
            this.gv_Coping.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_STL_GRD,
            this.colC_STD_CODE,
            this.colC_SPCIFICATION_MIN,
            this.colC_SPCIFICATION_MAX,
            this.colC_COPING_CRAFT,
            this.colC_CRAFT_FLOW,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT,
            this.gridColumn1});
            this.gv_Coping.GridControl = this.gc_Coping;
            this.gv_Coping.Name = "gv_Coping";
            this.gv_Coping.OptionsBehavior.Editable = false;
            this.gv_Coping.OptionsView.ColumnAutoWidth = false;
            this.gv_Coping.OptionsView.ShowGroupPanel = false;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 0;
            // 
            // colC_STD_CODE
            // 
            this.colC_STD_CODE.Caption = "执行标准";
            this.colC_STD_CODE.FieldName = "C_STD_CODE";
            this.colC_STD_CODE.Name = "colC_STD_CODE";
            this.colC_STD_CODE.Visible = true;
            this.colC_STD_CODE.VisibleIndex = 1;
            // 
            // colC_SPCIFICATION_MIN
            // 
            this.colC_SPCIFICATION_MIN.Caption = "规格最小值";
            this.colC_SPCIFICATION_MIN.FieldName = "C_SPCIFICATION_MIN";
            this.colC_SPCIFICATION_MIN.Name = "colC_SPCIFICATION_MIN";
            this.colC_SPCIFICATION_MIN.Visible = true;
            this.colC_SPCIFICATION_MIN.VisibleIndex = 2;
            // 
            // colC_SPCIFICATION_MAX
            // 
            this.colC_SPCIFICATION_MAX.Caption = "规格最大值";
            this.colC_SPCIFICATION_MAX.FieldName = "C_SPCIFICATION_MAX";
            this.colC_SPCIFICATION_MAX.Name = "colC_SPCIFICATION_MAX";
            this.colC_SPCIFICATION_MAX.Visible = true;
            this.colC_SPCIFICATION_MAX.VisibleIndex = 3;
            // 
            // colC_COPING_CRAFT
            // 
            this.colC_COPING_CRAFT.Caption = "修磨工艺";
            this.colC_COPING_CRAFT.FieldName = "C_COPING_CRAFT";
            this.colC_COPING_CRAFT.Name = "colC_COPING_CRAFT";
            this.colC_COPING_CRAFT.Visible = true;
            this.colC_COPING_CRAFT.VisibleIndex = 5;
            // 
            // colC_CRAFT_FLOW
            // 
            this.colC_CRAFT_FLOW.Caption = "工艺流程";
            this.colC_CRAFT_FLOW.FieldName = "C_CRAFT_FLOW";
            this.colC_CRAFT_FLOW.Name = "colC_CRAFT_FLOW";
            this.colC_CRAFT_FLOW.Visible = true;
            this.colC_CRAFT_FLOW.VisibleIndex = 6;
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
            this.colC_REMARK.VisibleIndex = 7;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "维护人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 8;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "维护时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 9;
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
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(515, 13);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 14);
            this.labelControl9.TabIndex = 52;
            this.labelControl9.Text = "客户名称";
            // 
            // btn_KHMC
            // 
            this.btn_KHMC.Location = new System.Drawing.Point(569, 12);
            this.btn_KHMC.Name = "btn_KHMC";
            this.btn_KHMC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn_KHMC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btn_KHMC.Size = new System.Drawing.Size(230, 20);
            this.btn_KHMC.TabIndex = 53;
            this.btn_KHMC.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_KHMC_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "客户名称";
            this.gridColumn1.FieldName = "C_CUSTFILE_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // FrmQB_XMYQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 696);
            this.Controls.Add(this.gc_Coping);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_XMYQ";
            this.Text = "修模要求";
            this.Load += new System.EventHandler(this.FrmQB_XMYQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdite_STlGRD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_STD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Min.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Max.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CraftFlow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imcbo_CopingCraft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdite_STlGRD1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Coping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Coping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_KHMC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Min;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Max;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton txt_Stop;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.ButtonEdit btnEdite_STlGRD;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_STD;
        private DevExpress.XtraEditors.SimpleButton btn_Rest;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ButtonEdit btnEdite_STlGRD1;
        private DevExpress.XtraGrid.GridControl gc_Coping;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Coping;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SPCIFICATION_MIN;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SPCIFICATION_MAX;
        private DevExpress.XtraGrid.Columns.GridColumn colC_COPING_CRAFT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_CRAFT_FLOW;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.MemoEdit txt_CraftFlow;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.ImageComboBoxEdit imcbo_CopingCraft;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ButtonEdit btn_KHMC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}