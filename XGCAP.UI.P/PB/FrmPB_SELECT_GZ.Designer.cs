namespace XGCAP.UI.P.PB
{
    partial class FrmPB_SELECT_GZ
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
            this.gc_StdMain = new DevExpress.XtraGrid.GridControl();
            this.gv_StdMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_GRD = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GRD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_StdMain
            // 
            this.gc_StdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_StdMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gc_StdMain.Location = new System.Drawing.Point(0, 47);
            this.gc_StdMain.MainView = this.gv_StdMain;
            this.gc_StdMain.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gc_StdMain.Name = "gc_StdMain";
            this.gc_StdMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_StdMain.Size = new System.Drawing.Size(735, 437);
            this.gc_StdMain.TabIndex = 63;
            this.gc_StdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_StdMain});
            // 
            // gv_StdMain
            // 
            this.gv_StdMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_STL_GRD});
            this.gv_StdMain.GridControl = this.gc_StdMain;
            this.gv_StdMain.Name = "gv_StdMain";
            this.gv_StdMain.OptionsBehavior.Editable = false;
            this.gv_StdMain.OptionsView.ColumnAutoWidth = false;
            this.gv_StdMain.OptionsView.ShowGroupPanel = false;
            this.gv_StdMain.Click += new System.EventHandler(this.gv_StdMain_Click);
            this.gv_StdMain.DoubleClick += new System.EventHandler(this.gv_StdMain_DoubleClick);
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 0;
            this.colC_STL_GRD.Width = 180;
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
            this.flowLayoutPanel1.Controls.Add(this.txt_GRD);
            this.flowLayoutPanel1.Controls.Add(this.btn_Query);
            this.flowLayoutPanel1.Controls.Add(this.btn_Add);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(735, 47);
            this.flowLayoutPanel1.TabIndex = 62;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 9);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "钢种";
            // 
            // txt_GRD
            // 
            this.txt_GRD.Location = new System.Drawing.Point(47, 7);
            this.txt_GRD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_GRD.Name = "txt_GRD";
            this.txt_GRD.Properties.MaxLength = 50;
            this.txt_GRD.Size = new System.Drawing.Size(133, 24);
            this.txt_GRD.TabIndex = 20;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(188, 9);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(100, 29);
            this.btn_Query.TabIndex = 0;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Apply;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(296, 9);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 29);
            this.btn_Add.TabIndex = 24;
            this.btn_Add.Text = "确定";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // FrmPB_SELECT_GZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 484);
            this.Controls.Add(this.gc_StdMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPB_SELECT_GZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请选择钢种";
            this.Load += new System.EventHandler(this.FrmPB_SELECT_GZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_StdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GRD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_StdMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_StdMain;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_GRD;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
    }
}