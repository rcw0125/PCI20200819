namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_ZXBZ_WLXN
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
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Wl = new DevExpress.XtraGrid.GridControl();
            this.gv_Wl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Query_WL = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Wl_Bz = new DevExpress.XtraGrid.GridControl();
            this.gv_Wl_Bz = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Bz = new DevExpress.XtraGrid.GridControl();
            this.gv_Bz = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query_STD = new DevExpress.XtraEditors.SimpleButton();
            this.txt_GZ = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ZXBZ = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Wl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Wl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Wl_Bz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Wl_Bz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Bz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Bz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ZXBZ.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.gc_Wl);
            this.panelControl5.Controls.Add(this.panelControl6);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl5.Location = new System.Drawing.Point(0, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(357, 724);
            this.panelControl5.TabIndex = 5;
            // 
            // gc_Wl
            // 
            this.gc_Wl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Wl.Location = new System.Drawing.Point(2, 52);
            this.gc_Wl.MainView = this.gv_Wl;
            this.gc_Wl.Name = "gc_Wl";
            this.gc_Wl.Size = new System.Drawing.Size(353, 670);
            this.gc_Wl.TabIndex = 1;
            this.gc_Wl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Wl});
            // 
            // gv_Wl
            // 
            this.gv_Wl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_Wl.GridControl = this.gc_Wl;
            this.gv_Wl.Name = "gv_Wl";
            this.gv_Wl.OptionsBehavior.Editable = false;
            this.gv_Wl.OptionsView.ColumnAutoWidth = false;
            this.gv_Wl.OptionsView.ShowGroupPanel = false;
            this.gv_Wl.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Wl_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "项目代码";
            this.gridColumn1.FieldName = "C_CODE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "项目名称";
            this.gridColumn2.FieldName = "C_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "C_ID";
            this.gridColumn3.FieldName = "C_ID";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.btn_Query_WL);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl6.Location = new System.Drawing.Point(2, 2);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(353, 50);
            this.panelControl6.TabIndex = 0;
            // 
            // btn_Query_WL
            // 
            this.btn_Query_WL.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query_WL.Location = new System.Drawing.Point(11, 10);
            this.btn_Query_WL.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Query_WL.Name = "btn_Query_WL";
            this.btn_Query_WL.Size = new System.Drawing.Size(100, 29);
            this.btn_Query_WL.TabIndex = 24;
            this.btn_Query_WL.Text = "查询";
            this.btn_Query_WL.Click += new System.EventHandler(this.btn_Query_WL_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(357, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 724);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_Wl_Bz);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(363, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(452, 724);
            this.panelControl1.TabIndex = 7;
            // 
            // gc_Wl_Bz
            // 
            this.gc_Wl_Bz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Wl_Bz.Location = new System.Drawing.Point(2, 52);
            this.gc_Wl_Bz.MainView = this.gv_Wl_Bz;
            this.gc_Wl_Bz.Name = "gc_Wl_Bz";
            this.gc_Wl_Bz.Size = new System.Drawing.Size(448, 670);
            this.gc_Wl_Bz.TabIndex = 1;
            this.gc_Wl_Bz.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Wl_Bz});
            // 
            // gv_Wl_Bz
            // 
            this.gv_Wl_Bz.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7});
            this.gv_Wl_Bz.GridControl = this.gc_Wl_Bz;
            this.gv_Wl_Bz.Name = "gv_Wl_Bz";
            this.gv_Wl_Bz.OptionsBehavior.Editable = false;
            this.gv_Wl_Bz.OptionsView.ColumnAutoWidth = false;
            this.gv_Wl_Bz.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "钢种";
            this.gridColumn6.FieldName = "C_STL_GRD";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "执行标准";
            this.gridColumn7.FieldName = "C_STD_CODE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_Del);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(448, 50);
            this.panelControl3.TabIndex = 0;
            // 
            // btn_Del
            // 
            this.btn_Del.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Del.Location = new System.Drawing.Point(16, 10);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(100, 29);
            this.btn_Del.TabIndex = 115;
            this.btn_Del.Text = "删除";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // splitterControl2
            // 
            this.splitterControl2.Location = new System.Drawing.Point(815, 0);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(6, 724);
            this.splitterControl2.TabIndex = 8;
            this.splitterControl2.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_Bz);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(821, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(656, 724);
            this.panelControl2.TabIndex = 9;
            // 
            // gc_Bz
            // 
            this.gc_Bz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Bz.Location = new System.Drawing.Point(2, 52);
            this.gc_Bz.MainView = this.gv_Bz;
            this.gc_Bz.Name = "gc_Bz";
            this.gc_Bz.Size = new System.Drawing.Size(652, 670);
            this.gc_Bz.TabIndex = 2;
            this.gc_Bz.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Bz});
            // 
            // gv_Bz
            // 
            this.gv_Bz.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn8});
            this.gv_Bz.GridControl = this.gc_Bz;
            this.gv_Bz.Name = "gv_Bz";
            this.gv_Bz.OptionsView.ColumnAutoWidth = false;
            this.gv_Bz.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "钢种";
            this.gridColumn4.FieldName = "C_STL_GRD";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "执行标准";
            this.gridColumn5.FieldName = "C_STD_CODE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btn_Add);
            this.panelControl4.Controls.Add(this.btn_Query_STD);
            this.panelControl4.Controls.Add(this.txt_GZ);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Controls.Add(this.txt_ZXBZ);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(652, 50);
            this.panelControl4.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(526, 11);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 29);
            this.btn_Add.TabIndex = 24;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Query_STD
            // 
            this.btn_Query_STD.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query_STD.Location = new System.Drawing.Point(418, 11);
            this.btn_Query_STD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Query_STD.Name = "btn_Query_STD";
            this.btn_Query_STD.Size = new System.Drawing.Size(100, 29);
            this.btn_Query_STD.TabIndex = 23;
            this.btn_Query_STD.Text = "查询";
            this.btn_Query_STD.Click += new System.EventHandler(this.btn_Query_STD_Click);
            // 
            // txt_GZ
            // 
            this.txt_GZ.Location = new System.Drawing.Point(279, 13);
            this.txt_GZ.Name = "txt_GZ";
            this.txt_GZ.Size = new System.Drawing.Size(132, 24);
            this.txt_GZ.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(243, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "钢种";
            // 
            // txt_ZXBZ
            // 
            this.txt_ZXBZ.Location = new System.Drawing.Point(69, 13);
            this.txt_ZXBZ.Name = "txt_ZXBZ";
            this.txt_ZXBZ.Size = new System.Drawing.Size(168, 24);
            this.txt_ZXBZ.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "执行标准";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "标准描述";
            this.gridColumn8.FieldName = "C_STD_DESC";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // FrmQB_ZXBZ_WLXN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 724);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitterControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl5);
            this.Name = "FrmQB_ZXBZ_WLXN";
            this.Text = "物理性能分组匹配执行标准";
            this.Load += new System.EventHandler(this.FrmQB_ZXBZ_WLXN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Wl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Wl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Wl_Bz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Wl_Bz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Bz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Bz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ZXBZ.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraGrid.GridControl gc_Wl;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Wl;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.SimpleButton btn_Query_WL;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_Wl_Bz;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Wl_Bz;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gc_Bz;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Bz;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Query_STD;
        private DevExpress.XtraEditors.TextEdit txt_GZ;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_ZXBZ;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}