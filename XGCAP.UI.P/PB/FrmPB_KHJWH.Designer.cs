namespace XGCAP.UI.P.PB
{
    partial class FrmPB_KHJWH
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
            this.gc_Route = new DevExpress.XtraGrid.GridControl();
            this.gv_Route = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_DCZLTSFG = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.txt_group = new DevExpress.XtraEditors.TextEdit();
            this.txt_std = new DevExpress.XtraEditors.TextEdit();
            this.txt_grd = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_gp = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Route)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Route)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_group.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_std.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_grd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Route
            // 
            this.gc_Route.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Route.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gc_Route.Location = new System.Drawing.Point(0, 108);
            this.gc_Route.MainView = this.gv_Route;
            this.gc_Route.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gc_Route.Name = "gc_Route";
            this.gc_Route.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5});
            this.gc_Route.Size = new System.Drawing.Size(1365, 598);
            this.gc_Route.TabIndex = 63;
            this.gc_Route.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Route});
            // 
            // gv_Route
            // 
            this.gv_Route.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_Route.GridControl = this.gc_Route;
            this.gv_Route.Name = "gv_Route";
            this.gv_Route.OptionsBehavior.Editable = false;
            this.gv_Route.OptionsView.ColumnAutoWidth = false;
            this.gv_Route.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "钢种";
            this.gridColumn1.FieldName = "C_STL_GRD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "执行标准";
            this.gridColumn2.FieldName = "C_STD_CODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "分组";
            this.gridColumn3.FieldName = "N_GROUP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
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
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btn_DCZLTSFG);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.txt_group);
            this.panelControl2.Controls.Add(this.txt_std);
            this.panelControl2.Controls.Add(this.txt_grd);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 60);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1365, 48);
            this.panelControl2.TabIndex = 62;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(405, 16);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "分组";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(204, 19);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "执行标准";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "钢种";
            // 
            // btn_DCZLTSFG
            // 
            this.btn_DCZLTSFG.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_DCZLTSFG.Location = new System.Drawing.Point(662, 11);
            this.btn_DCZLTSFG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_DCZLTSFG.Name = "btn_DCZLTSFG";
            this.btn_DCZLTSFG.Size = new System.Drawing.Size(77, 27);
            this.btn_DCZLTSFG.TabIndex = 11;
            this.btn_DCZLTSFG.Text = "导出";
            this.btn_DCZLTSFG.Click += new System.EventHandler(this.btn_DCZLTSFG_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(577, 11);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(77, 27);
            this.btn_Query.TabIndex = 8;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txt_group
            // 
            this.txt_group.EditValue = "";
            this.txt_group.Location = new System.Drawing.Point(443, 13);
            this.txt_group.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_group.Name = "txt_group";
            this.txt_group.Properties.DisplayFormat.FormatString = "d";
            this.txt_group.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_group.Properties.EditFormat.FormatString = "d";
            this.txt_group.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_group.Properties.Mask.EditMask = "f0";
            this.txt_group.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_group.Properties.MaxLength = 3;
            this.txt_group.Size = new System.Drawing.Size(126, 24);
            this.txt_group.TabIndex = 1;
            // 
            // txt_std
            // 
            this.txt_std.EditValue = "";
            this.txt_std.Location = new System.Drawing.Point(271, 13);
            this.txt_std.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_std.Name = "txt_std";
            this.txt_std.Properties.MaxLength = 20;
            this.txt_std.Size = new System.Drawing.Size(126, 24);
            this.txt_std.TabIndex = 1;
            // 
            // txt_grd
            // 
            this.txt_grd.EditValue = "";
            this.txt_grd.Location = new System.Drawing.Point(70, 13);
            this.txt_grd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_grd.Name = "txt_grd";
            this.txt_grd.Properties.MaxLength = 20;
            this.txt_grd.Size = new System.Drawing.Size(126, 24);
            this.txt_grd.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.txt_gp);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1365, 60);
            this.panelControl1.TabIndex = 61;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(32, 21);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(30, 18);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "分组";
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(204, 16);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(77, 27);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_gp
            // 
            this.txt_gp.EditValue = "";
            this.txt_gp.Location = new System.Drawing.Point(70, 18);
            this.txt_gp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_gp.Name = "txt_gp";
            this.txt_gp.Properties.DisplayFormat.FormatString = "d";
            this.txt_gp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_gp.Properties.EditFormat.FormatString = "d";
            this.txt_gp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_gp.Properties.Mask.EditMask = "f0";
            this.txt_gp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_gp.Properties.MaxLength = 3;
            this.txt_gp.Size = new System.Drawing.Size(126, 24);
            this.txt_gp.TabIndex = 1;
            // 
            // FrmPB_KHJWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 706);
            this.Controls.Add(this.gc_Route);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPB_KHJWH";
            this.Text = "可混浇维护";
            this.Load += new System.EventHandler(this.FrmPB_KHJWH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Route)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Route)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_group.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_std.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_grd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Route;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Route;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_DCZLTSFG;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txt_gp;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_group;
        private DevExpress.XtraEditors.TextEdit txt_std;
        private DevExpress.XtraEditors.TextEdit txt_grd;
    }
}