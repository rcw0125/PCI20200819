namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_XMGYWH
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CraftFlow = new DevExpress.XtraEditors.MemoEdit();
            this.txt_CopingCraft = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CopingCraft1 = new DevExpress.XtraEditors.TextEdit();
            this.gc_Coping = new DevExpress.XtraGrid.GridControl();
            this.modTQBCOPINGBASICBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv_Coping = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_COPING_CRAFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_CRAFT_FLOW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CraftFlow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CopingCraft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CopingCraft1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Coping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modTQBCOPINGBASICBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Coping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.txt_Remark);
            this.panelControl2.Controls.Add(this.btn_Add);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txt_CraftFlow);
            this.panelControl2.Controls.Add(this.txt_CopingCraft);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 79);
            this.panelControl2.TabIndex = 67;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(36, 32);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 59;
            this.labelControl7.Text = "备注";
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(66, 35);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(154, 34);
            this.txt_Remark.TabIndex = 60;
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(625, 46);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 54;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 57;
            this.labelControl6.Text = "修磨工艺";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(226, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 55;
            this.labelControl5.Text = "工艺流程";
            // 
            // txt_CraftFlow
            // 
            this.txt_CraftFlow.Location = new System.Drawing.Point(280, 10);
            this.txt_CraftFlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CraftFlow.Name = "txt_CraftFlow";
            this.txt_CraftFlow.Size = new System.Drawing.Size(339, 59);
            this.txt_CraftFlow.TabIndex = 56;
            // 
            // txt_CopingCraft
            // 
            this.txt_CopingCraft.Location = new System.Drawing.Point(66, 9);
            this.txt_CopingCraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CopingCraft.Name = "txt_CopingCraft";
            this.txt_CopingCraft.Size = new System.Drawing.Size(154, 20);
            this.txt_CopingCraft.TabIndex = 58;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(226, 6);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 53;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(388, 6);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 29;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Update);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_CopingCraft1);
            this.panelControl1.Controls.Add(this.btn_Query);
            this.panelControl1.Controls.Add(this.btn_Stop);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 79);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 37);
            this.panelControl1.TabIndex = 68;
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(307, 6);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 61;
            this.btn_Update.Text = "修改";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 59;
            this.labelControl1.Text = "修磨工艺";
            // 
            // txt_CopingCraft1
            // 
            this.txt_CopingCraft1.Location = new System.Drawing.Point(66, 7);
            this.txt_CopingCraft1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CopingCraft1.Name = "txt_CopingCraft1";
            this.txt_CopingCraft1.Size = new System.Drawing.Size(154, 20);
            this.txt_CopingCraft1.TabIndex = 60;
            // 
            // gc_Coping
            // 
            this.gc_Coping.DataSource = this.modTQBCOPINGBASICBindingSource;
            this.gc_Coping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Coping.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_Coping.Location = new System.Drawing.Point(0, 116);
            this.gc_Coping.MainView = this.gv_Coping;
            this.gc_Coping.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_Coping.Name = "gc_Coping";
            this.gc_Coping.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_Coping.Size = new System.Drawing.Size(800, 334);
            this.gc_Coping.TabIndex = 69;
            this.gc_Coping.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Coping});
            // 
            // modTQBCOPINGBASICBindingSource
            // 
            this.modTQBCOPINGBASICBindingSource.DataSource = typeof(MODEL.Mod_TQB_COPING_BASIC);
            // 
            // gv_Coping
            // 
            this.gv_Coping.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_COPING_CRAFT,
            this.colC_CRAFT_FLOW,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_Coping.GridControl = this.gc_Coping;
            this.gv_Coping.Name = "gv_Coping";
            this.gv_Coping.OptionsBehavior.Editable = false;
            this.gv_Coping.OptionsView.ColumnAutoWidth = false;
            this.gv_Coping.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "主键";
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_COPING_CRAFT
            // 
            this.colC_COPING_CRAFT.Caption = "修磨工艺";
            this.colC_COPING_CRAFT.FieldName = "C_COPING_CRAFT";
            this.colC_COPING_CRAFT.Name = "colC_COPING_CRAFT";
            this.colC_COPING_CRAFT.Visible = true;
            this.colC_COPING_CRAFT.VisibleIndex = 0;
            // 
            // colC_CRAFT_FLOW
            // 
            this.colC_CRAFT_FLOW.Caption = "工艺流程";
            this.colC_CRAFT_FLOW.FieldName = "C_CRAFT_FLOW";
            this.colC_CRAFT_FLOW.Name = "colC_CRAFT_FLOW";
            this.colC_CRAFT_FLOW.Visible = true;
            this.colC_CRAFT_FLOW.VisibleIndex = 1;
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
            this.colC_REMARK.VisibleIndex = 2;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "维护人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 3;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "维护时间";
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 4;
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
            // FrmQB_XMGYWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gc_Coping);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmQB_XMGYWH";
            this.Text = "修磨工艺维护";
            this.Load += new System.EventHandler(this.FrmQB_XMGYWH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CraftFlow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CopingCraft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CopingCraft1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Coping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modTQBCOPINGBASICBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Coping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txt_CraftFlow;
        private DevExpress.XtraEditors.TextEdit txt_CopingCraft;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_CopingCraft1;
        private DevExpress.XtraGrid.GridControl gc_Coping;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Coping;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private System.Windows.Forms.BindingSource modTQBCOPINGBASICBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_COPING_CRAFT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_CRAFT_FLOW;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
    }
}