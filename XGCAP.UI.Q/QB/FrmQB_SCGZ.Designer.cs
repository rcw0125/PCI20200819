namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_SCGZ
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gc_std_main = new DevExpress.XtraGrid.GridControl();
            this.gv_std_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.C_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup2 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Std = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Grd = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_std_check = new DevExpress.XtraGrid.GridControl();
            this.gv_std_check = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colc_std_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_std1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_grd1 = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_std_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_std_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Std.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_std_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_std_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_std1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_grd1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_std_main);
            this.panelControl1.Controls.Add(this.flowLayoutPanel2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(497, 547);
            this.panelControl1.TabIndex = 1;
            // 
            // gc_std_main
            // 
            this.gc_std_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_std_main.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_std_main.Location = new System.Drawing.Point(2, 39);
            this.gc_std_main.MainView = this.gv_std_main;
            this.gc_std_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_std_main.Name = "gc_std_main";
            this.gc_std_main.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup2,
            this.repositoryItemCheckEdit2});
            this.gc_std_main.Size = new System.Drawing.Size(493, 506);
            this.gc_std_main.TabIndex = 66;
            this.gc_std_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_std_main});
            // 
            // gv_std_main
            // 
            this.gv_std_main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.C_STD_CODE,
            this.C_STL_GRD});
            this.gv_std_main.GridControl = this.gc_std_main;
            this.gv_std_main.Name = "gv_std_main";
            this.gv_std_main.OptionsBehavior.Editable = false;
            this.gv_std_main.OptionsView.ColumnAutoWidth = false;
            this.gv_std_main.OptionsView.ShowGroupPanel = false;
            // 
            // C_STD_CODE
            // 
            this.C_STD_CODE.Caption = "执行标准";
            this.C_STD_CODE.FieldName = "C_STD_CODE";
            this.C_STD_CODE.Name = "C_STD_CODE";
            this.C_STD_CODE.Visible = true;
            this.C_STD_CODE.VisibleIndex = 1;
            // 
            // C_STL_GRD
            // 
            this.C_STL_GRD.Caption = "钢种";
            this.C_STL_GRD.FieldName = "C_STL_GRD";
            this.C_STL_GRD.Name = "C_STL_GRD";
            this.C_STL_GRD.Visible = true;
            this.C_STL_GRD.VisibleIndex = 0;
            // 
            // repositoryItemRadioGroup2
            // 
            this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.labelControl1);
            this.flowLayoutPanel2.Controls.Add(this.txt_Std);
            this.flowLayoutPanel2.Controls.Add(this.labelControl2);
            this.flowLayoutPanel2.Controls.Add(this.txt_Grd);
            this.flowLayoutPanel2.Controls.Add(this.btn_Query);
            this.flowLayoutPanel2.Controls.Add(this.btn_Add);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(493, 37);
            this.flowLayoutPanel2.TabIndex = 65;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "执行标准";
            // 
            // txt_Std
            // 
            this.txt_Std.Location = new System.Drawing.Point(60, 6);
            this.txt_Std.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Std.Name = "txt_Std";
            this.txt_Std.Size = new System.Drawing.Size(114, 20);
            this.txt_Std.TabIndex = 45;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(179, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "钢种";
            // 
            // txt_Grd
            // 
            this.txt_Grd.Location = new System.Drawing.Point(208, 6);
            this.txt_Grd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Grd.Name = "txt_Grd";
            this.txt_Grd.Size = new System.Drawing.Size(93, 20);
            this.txt_Grd.TabIndex = 44;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(306, 7);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 41;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(387, 7);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 46;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(497, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 547);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_std_check);
            this.panelControl2.Controls.Add(this.flowLayoutPanel1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(502, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(565, 547);
            this.panelControl2.TabIndex = 3;
            // 
            // gc_std_check
            // 
            this.gc_std_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_std_check.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_std_check.Location = new System.Drawing.Point(2, 39);
            this.gc_std_check.MainView = this.gv_std_check;
            this.gc_std_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_std_check.Name = "gc_std_check";
            this.gc_std_check.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_std_check.Size = new System.Drawing.Size(561, 506);
            this.gc_std_check.TabIndex = 66;
            this.gc_std_check.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_std_check});
            // 
            // gv_std_check
            // 
            this.gv_std_check.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colc_std_code,
            this.colC_STL_GRD,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_std_check.GridControl = this.gc_std_check;
            this.gv_std_check.Name = "gv_std_check";
            this.gv_std_check.OptionsBehavior.Editable = false;
            this.gv_std_check.OptionsView.ColumnAutoWidth = false;
            this.gv_std_check.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "主键";
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colc_std_code
            // 
            this.colc_std_code.Caption = "执行标准";
            this.colc_std_code.FieldName = "C_STD_CODE";
            this.colc_std_code.Name = "colc_std_code";
            this.colc_std_code.Visible = true;
            this.colc_std_code.VisibleIndex = 1;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 0;
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.Caption = "备注";
            this.colC_REMARK.FieldName = "C_REMARK";
            this.colC_REMARK.Name = "colC_REMARK";
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "维护人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 2;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "维护时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.GroupFormat.FormatString = "G";
            this.colD_MOD_DT.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 3;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.labelControl3);
            this.flowLayoutPanel1.Controls.Add(this.txt_std1);
            this.flowLayoutPanel1.Controls.Add(this.labelControl4);
            this.flowLayoutPanel1.Controls.Add(this.txt_grd1);
            this.flowLayoutPanel1.Controls.Add(this.btn_Query1);
            this.flowLayoutPanel1.Controls.Add(this.btn_Del);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 37);
            this.flowLayoutPanel1.TabIndex = 65;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "执行标准";
            // 
            // txt_std1
            // 
            this.txt_std1.Location = new System.Drawing.Point(60, 6);
            this.txt_std1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_std1.Name = "txt_std1";
            this.txt_std1.Size = new System.Drawing.Size(114, 20);
            this.txt_std1.TabIndex = 49;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(179, 7);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "钢种";
            // 
            // txt_grd1
            // 
            this.txt_grd1.Location = new System.Drawing.Point(208, 6);
            this.txt_grd1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_grd1.Name = "txt_grd1";
            this.txt_grd1.Size = new System.Drawing.Size(93, 20);
            this.txt_grd1.TabIndex = 48;
            // 
            // btn_Query1
            // 
            this.btn_Query1.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query1.Location = new System.Drawing.Point(306, 7);
            this.btn_Query1.Name = "btn_Query1";
            this.btn_Query1.Size = new System.Drawing.Size(75, 23);
            this.btn_Query1.TabIndex = 45;
            this.btn_Query1.Text = "查询";
            this.btn_Query1.Click += new System.EventHandler(this.btn_Query1_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Del.Location = new System.Drawing.Point(387, 7);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "删除";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // FrmQB_SCGZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 547);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_SCGZ";
            this.Text = "涮槽钢种维护";
            this.Load += new System.EventHandler(this.FrmQB_SCGZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_std_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_std_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Std.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_std_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_std_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_std1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_grd1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_std_main;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_std_main;
        private DevExpress.XtraGrid.Columns.GridColumn C_STD_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn C_STL_GRD;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Std;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Grd;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gc_std_check;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_std_check;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colc_std_code;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_Query1;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_std1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_grd1;
    }
}