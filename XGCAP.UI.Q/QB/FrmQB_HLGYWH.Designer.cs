namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_HLGYWH
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
            this.gc_cool = new DevExpress.XtraGrid.GridControl();
            this.gv_cool = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_COOL_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_HEAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_COOL_CRAFT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_COOL_CRAFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_HOT_T = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.txt_CoolCode1 = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_Type = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Hot = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_Heat = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.txt_cooldate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CoolCraft = new DevExpress.XtraEditors.MemoEdit();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.txt_CoolCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_cool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCode1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Heat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cooldate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCraft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_cool
            // 
            this.gc_cool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_cool.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_cool.Location = new System.Drawing.Point(0, 150);
            this.gc_cool.MainView = this.gv_cool;
            this.gc_cool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_cool.Name = "gc_cool";
            this.gc_cool.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_cool.Size = new System.Drawing.Size(1263, 443);
            this.gc_cool.TabIndex = 60;
            this.gc_cool.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_cool});
            // 
            // gv_cool
            // 
            this.gv_cool.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colN_COOL_DT,
            this.colC_HEAT,
            this.colC_TYPE,
            this.colC_COOL_CRAFT_CODE,
            this.colC_COOL_CRAFT,
            this.colC_HOT_T,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_cool.GridControl = this.gc_cool;
            this.gv_cool.Name = "gv_cool";
            this.gv_cool.OptionsBehavior.Editable = false;
            this.gv_cool.OptionsView.ColumnAutoWidth = false;
            this.gv_cool.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "主键";
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colN_COOL_DT
            // 
            this.colN_COOL_DT.Caption = "缓冷时间";
            this.colN_COOL_DT.FieldName = "N_COOL_DT";
            this.colN_COOL_DT.Name = "colN_COOL_DT";
            this.colN_COOL_DT.Visible = true;
            this.colN_COOL_DT.VisibleIndex = 1;
            // 
            // colC_HEAT
            // 
            this.colC_HEAT.Caption = "是否热装";
            this.colC_HEAT.FieldName = "C_HEAT";
            this.colC_HEAT.Name = "colC_HEAT";
            this.colC_HEAT.Visible = true;
            this.colC_HEAT.VisibleIndex = 2;
            // 
            // colC_TYPE
            // 
            this.colC_TYPE.Caption = "类型";
            this.colC_TYPE.FieldName = "C_TYPE";
            this.colC_TYPE.Name = "colC_TYPE";
            this.colC_TYPE.Visible = true;
            this.colC_TYPE.VisibleIndex = 3;
            // 
            // colC_COOL_CRAFT_CODE
            // 
            this.colC_COOL_CRAFT_CODE.Caption = "缓冷工艺代码";
            this.colC_COOL_CRAFT_CODE.FieldName = "C_COOL_CRAFT_CODE";
            this.colC_COOL_CRAFT_CODE.Name = "colC_COOL_CRAFT_CODE";
            this.colC_COOL_CRAFT_CODE.Visible = true;
            this.colC_COOL_CRAFT_CODE.VisibleIndex = 0;
            this.colC_COOL_CRAFT_CODE.Width = 103;
            // 
            // colC_COOL_CRAFT
            // 
            this.colC_COOL_CRAFT.Caption = "缓冷工艺";
            this.colC_COOL_CRAFT.FieldName = "C_COOL_CRAFT";
            this.colC_COOL_CRAFT.Name = "colC_COOL_CRAFT";
            this.colC_COOL_CRAFT.Visible = true;
            this.colC_COOL_CRAFT.VisibleIndex = 4;
            this.colC_COOL_CRAFT.Width = 65;
            // 
            // colC_HOT_T
            // 
            this.colC_HOT_T.Caption = "热装温度/℃";
            this.colC_HOT_T.FieldName = "C_HOT_T";
            this.colC_HOT_T.Name = "colC_HOT_T";
            this.colC_HOT_T.Visible = true;
            this.colC_HOT_T.VisibleIndex = 5;
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
            this.colC_REMARK.VisibleIndex = 6;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "维护人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 7;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "维护时间";
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 8;
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
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.btn_Update);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.txt_Stop);
            this.panelControl2.Controls.Add(this.txt_CoolCode1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 112);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1263, 38);
            this.panelControl2.TabIndex = 59;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 14);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "缓冷工艺代码";
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(283, 8);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 50;
            this.btn_Update.Text = "修改";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(202, 8);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 8;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txt_Stop
            // 
            this.txt_Stop.ImageUri.Uri = "Cancel;Size16x16";
            this.txt_Stop.Location = new System.Drawing.Point(364, 8);
            this.txt_Stop.Name = "txt_Stop";
            this.txt_Stop.Size = new System.Drawing.Size(75, 23);
            this.txt_Stop.TabIndex = 10;
            this.txt_Stop.Text = "停用";
            this.txt_Stop.Click += new System.EventHandler(this.txt_Stop_Click);
            // 
            // txt_CoolCode1
            // 
            this.txt_CoolCode1.Location = new System.Drawing.Point(90, 9);
            this.txt_CoolCode1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CoolCode1.Name = "txt_CoolCode1";
            this.txt_CoolCode1.Size = new System.Drawing.Size(100, 20);
            this.txt_CoolCode1.TabIndex = 52;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.imgcbo_Type);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txt_Hot);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.imgcbo_Heat);
            this.panelControl1.Controls.Add(this.txt_cooldate);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txt_CoolCraft);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Controls.Add(this.txt_CoolCode);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1263, 112);
            this.panelControl1.TabIndex = 58;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(380, 9);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 14);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "类型";
            // 
            // imgcbo_Type
            // 
            this.imgcbo_Type.Location = new System.Drawing.Point(410, 8);
            this.imgcbo_Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_Type.Name = "imgcbo_Type";
            this.imgcbo_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_Type.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("大方坯连铸坯", "大方坯连铸坯", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("小方坯连铸坯", "小方坯连铸坯", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("热轧钢坯", "热轧钢坯", -1)});
            this.imgcbo_Type.Size = new System.Drawing.Size(100, 20);
            this.imgcbo_Type.TabIndex = 33;
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(706, 80);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "缓冷工艺代码";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(60, 68);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "备注";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(356, 40);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 14);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "缓冷工艺";
            // 
            // txt_Hot
            // 
            this.txt_Hot.Location = new System.Drawing.Point(90, 37);
            this.txt_Hot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Hot.Name = "txt_Hot";
            this.txt_Hot.Size = new System.Drawing.Size(100, 20);
            this.txt_Hot.TabIndex = 35;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(36, 40);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 14);
            this.labelControl9.TabIndex = 34;
            this.labelControl9.Text = "热装温度";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(196, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "缓冷时间";
            // 
            // imgcbo_Heat
            // 
            this.imgcbo_Heat.Location = new System.Drawing.Point(250, 8);
            this.imgcbo_Heat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_Heat.Name = "imgcbo_Heat";
            this.imgcbo_Heat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_Heat.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("是", "是", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("否", "否", -1)});
            this.imgcbo_Heat.Size = new System.Drawing.Size(100, 20);
            this.imgcbo_Heat.TabIndex = 29;
            // 
            // txt_cooldate
            // 
            this.txt_cooldate.EditValue = "";
            this.txt_cooldate.Location = new System.Drawing.Point(250, 37);
            this.txt_cooldate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cooldate.Name = "txt_cooldate";
            this.txt_cooldate.Properties.Mask.EditMask = "d";
            this.txt_cooldate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_cooldate.Properties.MaxLength = 5;
            this.txt_cooldate.Size = new System.Drawing.Size(100, 20);
            this.txt_cooldate.TabIndex = 31;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(196, 11);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "是否热装";
            // 
            // txt_CoolCraft
            // 
            this.txt_CoolCraft.Location = new System.Drawing.Point(410, 38);
            this.txt_CoolCraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CoolCraft.Name = "txt_CoolCraft";
            this.txt_CoolCraft.Size = new System.Drawing.Size(284, 65);
            this.txt_CoolCraft.TabIndex = 23;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(90, 65);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(260, 39);
            this.txt_Remark.TabIndex = 27;
            // 
            // txt_CoolCode
            // 
            this.txt_CoolCode.Location = new System.Drawing.Point(90, 10);
            this.txt_CoolCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CoolCode.Name = "txt_CoolCode";
            this.txt_CoolCode.Properties.Mask.BeepOnError = true;
            this.txt_CoolCode.Properties.Mask.EditMask = "[a-zA-Z]+\\d+";
            this.txt_CoolCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_CoolCode.Properties.Mask.ShowPlaceHolders = false;
            this.txt_CoolCode.Size = new System.Drawing.Size(100, 20);
            this.txt_CoolCode.TabIndex = 25;
            // 
            // FrmQB_HLGYWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 593);
            this.Controls.Add(this.gc_cool);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_HLGYWH";
            this.Text = "缓冷工艺维护";
            this.Load += new System.EventHandler(this.FrmQB_HLGYWH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_cool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCode1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Heat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cooldate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCraft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_cool;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_cool;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton txt_Stop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_Type;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_Hot;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_Heat;
        private DevExpress.XtraEditors.TextEdit txt_cooldate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txt_CoolCraft;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_CoolCode1;
        private DevExpress.XtraEditors.TextEdit txt_CoolCode;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colN_COOL_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_HEAT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_COOL_CRAFT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_COOL_CRAFT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_HOT_T;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
    }
}