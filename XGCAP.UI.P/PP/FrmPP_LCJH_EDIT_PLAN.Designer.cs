namespace XGCAP.UI.P.PP
{
    partial class FrmPP_LCJH_EDIT_PLAN
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
            this.gc_Plan = new DevExpress.XtraGrid.GridControl();
            this.gv_Plan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn53 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn54 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Stove = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_query = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Reason = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Reason.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Plan
            // 
            this.gc_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Plan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_Plan.Location = new System.Drawing.Point(0, 144);
            this.gc_Plan.MainView = this.gv_Plan;
            this.gc_Plan.Margin = new System.Windows.Forms.Padding(4);
            this.gc_Plan.Name = "gc_Plan";
            this.gc_Plan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gc_Plan.Size = new System.Drawing.Size(1371, 577);
            this.gc_Plan.TabIndex = 65;
            this.gc_Plan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Plan});
            // 
            // gv_Plan
            // 
            this.gv_Plan.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gv_Plan.Appearance.OddRow.Options.UseBackColor = true;
            this.gv_Plan.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gv_Plan.Appearance.Preview.Options.UseBackColor = true;
            this.gv_Plan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn30,
            this.gridColumn53,
            this.gridColumn54,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_Plan.GridControl = this.gc_Plan;
            this.gv_Plan.Name = "gv_Plan";
            this.gv_Plan.OptionsCustomization.AllowSort = false;
            this.gv_Plan.OptionsView.ColumnAutoWidth = false;
            this.gv_Plan.OptionsView.ShowGroupPanel = false;
            this.gv_Plan.DoubleClick += new System.EventHandler(this.gv_Plan_DoubleClick);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "C_ID";
            this.gridColumn5.FieldName = "C_ID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "订单主键";
            this.gridColumn8.FieldName = "订单主键";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "计划量";
            this.gridColumn9.FieldName = "计划量";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "C_CCM_ID";
            this.gridColumn10.FieldName = "C_CCM_ID";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "C_CCM_DESC";
            this.gridColumn11.FieldName = "C_CCM_DESC";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "钢种";
            this.gridColumn12.FieldName = "钢种";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "执行标准";
            this.gridColumn13.FieldName = "执行标准";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "N_SORT";
            this.gridColumn14.FieldName = "N_SORT";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "排产时间";
            this.gridColumn15.FieldName = "排产时间";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 13;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "计划状态";
            this.gridColumn16.FieldName = "计划状态";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 8;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "转炉";
            this.gridColumn17.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn17.FieldName = "C_ZL_ID";
            this.gridColumn17.MaxWidth = 80;
            this.gridColumn17.MinWidth = 80;
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 9;
            this.gridColumn17.Width = 80;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "精炼";
            this.gridColumn18.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn18.FieldName = "C_LF_ID";
            this.gridColumn18.MaxWidth = 80;
            this.gridColumn18.MinWidth = 80;
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 10;
            this.gridColumn18.Width = 80;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "真空";
            this.gridColumn19.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn19.FieldName = "C_RH_ID";
            this.gridColumn19.MaxWidth = 80;
            this.gridColumn19.MinWidth = 80;
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 11;
            this.gridColumn19.Width = 80;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "连铸";
            this.gridColumn20.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn20.FieldName = "C_CCM_ID";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 12;
            // 
            // gridColumn30
            // 
            this.gridColumn30.Caption = "炉号";
            this.gridColumn30.FieldName = "炉号";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.OptionsColumn.AllowEdit = false;
            this.gridColumn30.Visible = true;
            this.gridColumn30.VisibleIndex = 0;
            // 
            // gridColumn53
            // 
            this.gridColumn53.Caption = "断面";
            this.gridColumn53.FieldName = "断面";
            this.gridColumn53.Name = "gridColumn53";
            this.gridColumn53.OptionsColumn.AllowEdit = false;
            this.gridColumn53.Visible = true;
            this.gridColumn53.VisibleIndex = 3;
            // 
            // gridColumn54
            // 
            this.gridColumn54.Caption = "定尺";
            this.gridColumn54.FieldName = "定尺";
            this.gridColumn54.Name = "gridColumn54";
            this.gridColumn54.OptionsColumn.AllowEdit = false;
            this.gridColumn54.Visible = true;
            this.gridColumn54.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "物料编码";
            this.gridColumn1.FieldName = "C_MATRL_NO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "物料名称";
            this.gridColumn2.FieldName = "C_MATRL_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "C_PK_INVBASDOC";
            this.gridColumn3.FieldName = "C_PK_INVBASDOC";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_Edit);
            this.panelControl1.Controls.Add(this.txt_Stove);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btn_query);
            this.panelControl1.Controls.Add(this.txt_Reason);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1371, 144);
            this.panelControl1.TabIndex = 64;
            // 
            // btn_Edit
            // 
            this.btn_Edit.ImageUri.Uri = "Save;Size16x16";
            this.btn_Edit.Location = new System.Drawing.Point(454, 50);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(103, 29);
            this.btn_Edit.TabIndex = 207;
            this.btn_Edit.Text = "修改计划";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // txt_Stove
            // 
            this.txt_Stove.Location = new System.Drawing.Point(81, 16);
            this.txt_Stove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stove.Name = "txt_Stove";
            this.txt_Stove.Size = new System.Drawing.Size(140, 24);
            this.txt_Stove.TabIndex = 204;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(41, 19);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 203;
            this.labelControl2.Text = "炉号";
            // 
            // btn_query
            // 
            this.btn_query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_query.Location = new System.Drawing.Point(240, 14);
            this.btn_query.Margin = new System.Windows.Forms.Padding(4);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(81, 29);
            this.btn_query.TabIndex = 193;
            this.btn_query.Text = "查询";
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 55);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 208;
            this.labelControl1.Text = "修改原因";
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(81, 51);
            this.txt_Reason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(355, 69);
            this.txt_Reason.TabIndex = 209;
            // 
            // FrmPP_LCJH_EDIT_PLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 721);
            this.Controls.Add(this.gc_Plan);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPP_LCJH_EDIT_PLAN";
            this.Text = "修改炼钢计划";
            this.Load += new System.EventHandler(this.FrmPP_LCJH_EDIT_PLAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Plan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Plan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Reason.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Plan;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Plan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn53;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn54;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.TextEdit txt_Stove;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_query;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txt_Reason;
    }
}