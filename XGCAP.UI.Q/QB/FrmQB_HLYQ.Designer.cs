namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_HLYQ
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
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.fil_STlGRD = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cooldate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Hot = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Rest = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_CoolCraft = new DevExpress.XtraEditors.MemoEdit();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.imcbo_CoolCode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.txt_Heat = new DevExpress.XtraEditors.TextEdit();
            this.txt_Type = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.fil_STlGRD1 = new DevExpress.XtraEditors.ButtonEdit();
            this.gc_cool = new DevExpress.XtraGrid.GridControl();
            this.gv_cool = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_COOL_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_HEAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_COOL_CRAFT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_COOL_CRAFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_HOT_T = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fil_STlGRD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cooldate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCraft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imcbo_CoolCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Heat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fil_STlGRD1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_cool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(197, 9);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(100, 29);
            this.btn_Query.TabIndex = 8;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txt_Stop
            // 
            this.txt_Stop.ImageUri.Uri = "Cancel;Size16x16";
            this.txt_Stop.Location = new System.Drawing.Point(413, 9);
            this.txt_Stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Stop.Name = "txt_Stop";
            this.txt_Stop.Size = new System.Drawing.Size(100, 29);
            this.txt_Stop.TabIndex = 10;
            this.txt_Stop.Text = "停用";
            this.txt_Stop.Click += new System.EventHandler(this.txt_Stop_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(1155, 96);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 29);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(515, 11);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 18);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "类型";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(56, 11);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "钢种";
            // 
            // fil_STlGRD
            // 
            this.fil_STlGRD.Location = new System.Drawing.Point(96, 8);
            this.fil_STlGRD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fil_STlGRD.Name = "fil_STlGRD";
            this.fil_STlGRD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fil_STlGRD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.fil_STlGRD.Size = new System.Drawing.Size(133, 24);
            this.fil_STlGRD.TabIndex = 47;
            this.fil_STlGRD.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_STlGRD_ButtonClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(237, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 18);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "缓冷工艺代码";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(696, 11);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 18);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "缓冷工艺";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(483, 50);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "缓冷时间";
            // 
            // txt_cooldate
            // 
            this.txt_cooldate.Location = new System.Drawing.Point(555, 46);
            this.txt_cooldate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_cooldate.Name = "txt_cooldate";
            this.txt_cooldate.Size = new System.Drawing.Size(133, 24);
            this.txt_cooldate.TabIndex = 31;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 50);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 18);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "是否热装";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(269, 50);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 18);
            this.labelControl9.TabIndex = 34;
            this.labelControl9.Text = "热装温度";
            // 
            // txt_Hot
            // 
            this.txt_Hot.Location = new System.Drawing.Point(341, 46);
            this.txt_Hot.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_Hot.Name = "txt_Hot";
            this.txt_Hot.Size = new System.Drawing.Size(133, 24);
            this.txt_Hot.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(56, 80);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 18);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "备注";
            // 
            // btn_Rest
            // 
            this.btn_Rest.ImageUri.Uri = "Reset;Size16x16";
            this.btn_Rest.Location = new System.Drawing.Point(1263, 96);
            this.btn_Rest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Rest.Name = "btn_Rest";
            this.btn_Rest.Size = new System.Drawing.Size(100, 29);
            this.btn_Rest.TabIndex = 45;
            this.btn_Rest.Text = "重置";
            this.btn_Rest.Click += new System.EventHandler(this.btn_Rest_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.fil_STlGRD);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.btn_Rest);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txt_Hot);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_cooldate);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txt_CoolCraft);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Controls.Add(this.imcbo_CoolCode);
            this.panelControl1.Controls.Add(this.txt_Heat);
            this.panelControl1.Controls.Add(this.txt_Type);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1785, 140);
            this.panelControl1.TabIndex = 54;
            // 
            // txt_CoolCraft
            // 
            this.txt_CoolCraft.Location = new System.Drawing.Point(768, 9);
            this.txt_CoolCraft.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_CoolCraft.Name = "txt_CoolCraft";
            this.txt_CoolCraft.Size = new System.Drawing.Size(379, 116);
            this.txt_CoolCraft.TabIndex = 23;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(96, 76);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(592, 49);
            this.txt_Remark.TabIndex = 27;
            // 
            // imcbo_CoolCode
            // 
            this.imcbo_CoolCode.Location = new System.Drawing.Point(341, 8);
            this.imcbo_CoolCode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.imcbo_CoolCode.Name = "imcbo_CoolCode";
            this.imcbo_CoolCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imcbo_CoolCode.Size = new System.Drawing.Size(133, 24);
            this.imcbo_CoolCode.TabIndex = 25;
            this.imcbo_CoolCode.SelectedIndexChanged += new System.EventHandler(this.imcbo_CoolCode_SelectedIndexChanged);
            // 
            // txt_Heat
            // 
            this.txt_Heat.Location = new System.Drawing.Point(96, 46);
            this.txt_Heat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_Heat.Name = "txt_Heat";
            this.txt_Heat.Size = new System.Drawing.Size(133, 24);
            this.txt_Heat.TabIndex = 29;
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(555, 8);
            this.txt_Type.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(133, 24);
            this.txt_Type.TabIndex = 33;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_out);
            this.panelControl2.Controls.Add(this.btn_Update);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.fil_STlGRD1);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.txt_Stop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 140);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1785, 48);
            this.panelControl2.TabIndex = 55;
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(305, 9);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 29);
            this.btn_Update.TabIndex = 50;
            this.btn_Update.Text = "修改";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(16, 11);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(30, 18);
            this.labelControl10.TabIndex = 48;
            this.labelControl10.Text = "钢种";
            // 
            // fil_STlGRD1
            // 
            this.fil_STlGRD1.Location = new System.Drawing.Point(56, 10);
            this.fil_STlGRD1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fil_STlGRD1.Name = "fil_STlGRD1";
            this.fil_STlGRD1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fil_STlGRD1.Size = new System.Drawing.Size(133, 24);
            this.fil_STlGRD1.TabIndex = 49;
            this.fil_STlGRD1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fil_STlGRD1_ButtonClick);
            // 
            // gc_cool
            // 
            this.gc_cool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_cool.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gc_cool.Location = new System.Drawing.Point(0, 188);
            this.gc_cool.MainView = this.gv_cool;
            this.gc_cool.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gc_cool.Name = "gc_cool";
            this.gc_cool.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_cool.Size = new System.Drawing.Size(1785, 693);
            this.gc_cool.TabIndex = 57;
            this.gc_cool.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_cool});
            // 
            // gv_cool
            // 
            this.gv_cool.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_STL_GRD,
            this.colN_COOL_DT,
            this.colC_HEAT,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT,
            this.colC_TYPE,
            this.colC_COOL_CRAFT_CODE,
            this.colC_COOL_CRAFT,
            this.colC_HOT_T});
            this.gv_cool.GridControl = this.gc_cool;
            this.gv_cool.Name = "gv_cool";
            this.gv_cool.OptionsBehavior.Editable = false;
            this.gv_cool.OptionsView.ColumnAutoWidth = false;
            this.gv_cool.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 1;
            // 
            // colN_COOL_DT
            // 
            this.colN_COOL_DT.Caption = "缓冷时间";
            this.colN_COOL_DT.DisplayFormat.FormatString = "G";
            this.colN_COOL_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colN_COOL_DT.FieldName = "N_COOL_DT";
            this.colN_COOL_DT.Name = "colN_COOL_DT";
            this.colN_COOL_DT.Visible = true;
            this.colN_COOL_DT.VisibleIndex = 4;
            // 
            // colC_HEAT
            // 
            this.colC_HEAT.Caption = "是否热装";
            this.colC_HEAT.FieldName = "C_HEAT";
            this.colC_HEAT.Name = "colC_HEAT";
            this.colC_HEAT.Visible = true;
            this.colC_HEAT.VisibleIndex = 5;
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
            this.colC_EMP_ID.Caption = "操作人员";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 8;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "操作时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 9;
            // 
            // colC_TYPE
            // 
            this.colC_TYPE.Caption = "类型";
            this.colC_TYPE.FieldName = "C_TYPE";
            this.colC_TYPE.Name = "colC_TYPE";
            this.colC_TYPE.Visible = true;
            this.colC_TYPE.VisibleIndex = 0;
            // 
            // colC_COOL_CRAFT_CODE
            // 
            this.colC_COOL_CRAFT_CODE.Caption = "缓冷工艺代码";
            this.colC_COOL_CRAFT_CODE.FieldName = "C_COOL_CRAFT_CODE";
            this.colC_COOL_CRAFT_CODE.Name = "colC_COOL_CRAFT_CODE";
            this.colC_COOL_CRAFT_CODE.Visible = true;
            this.colC_COOL_CRAFT_CODE.VisibleIndex = 2;
            this.colC_COOL_CRAFT_CODE.Width = 86;
            // 
            // colC_COOL_CRAFT
            // 
            this.colC_COOL_CRAFT.Caption = "缓冷工艺";
            this.colC_COOL_CRAFT.FieldName = "C_COOL_CRAFT";
            this.colC_COOL_CRAFT.Name = "colC_COOL_CRAFT";
            this.colC_COOL_CRAFT.Visible = true;
            this.colC_COOL_CRAFT.VisibleIndex = 3;
            // 
            // colC_HOT_T
            // 
            this.colC_HOT_T.Caption = "热装温度/℃";
            this.colC_HOT_T.FieldName = "C_HOT_T";
            this.colC_HOT_T.Name = "colC_HOT_T";
            this.colC_HOT_T.Visible = true;
            this.colC_HOT_T.VisibleIndex = 6;
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
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(527, 9);
            this.btn_out.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(100, 29);
            this.btn_out.TabIndex = 134;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // FrmQB_HLYQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 881);
            this.Controls.Add(this.gc_cool);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQB_HLYQ";
            this.Text = "缓冷要求";
            this.Load += new System.EventHandler(this.FrmQB_HLYQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fil_STlGRD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cooldate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCraft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imcbo_CoolCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Heat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fil_STlGRD1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_cool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_cooldate;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_Hot;
        private DevExpress.XtraEditors.SimpleButton txt_Stop;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Rest;
        private DevExpress.XtraEditors.ButtonEdit fil_STlGRD;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ButtonEdit fil_STlGRD1;
        private DevExpress.XtraGrid.GridControl gc_cool;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_cool;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colN_COOL_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_HEAT;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_COOL_CRAFT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_COOL_CRAFT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_HOT_T;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.MemoEdit txt_CoolCraft;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.ImageComboBoxEdit imcbo_CoolCode;
        private DevExpress.XtraEditors.TextEdit txt_Heat;
        private DevExpress.XtraEditors.TextEdit txt_Type;
        private DevExpress.XtraEditors.SimpleButton btn_out;
    }
}