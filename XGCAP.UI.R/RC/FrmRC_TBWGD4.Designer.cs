namespace XGCAP.UI.R.RC
{
    partial class FrmRC_TBWGD4
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
            this.gc_RollPro = new DevExpress.XtraGrid.GridControl();
            this.gv_RollPro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup2 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Batch_No = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_query_zg = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Gh = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_RollPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_RollPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_No.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Gh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_RollPro
            // 
            this.gc_RollPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_RollPro.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_RollPro.Location = new System.Drawing.Point(0, 41);
            this.gc_RollPro.MainView = this.gv_RollPro;
            this.gc_RollPro.Margin = new System.Windows.Forms.Padding(2);
            this.gc_RollPro.Name = "gc_RollPro";
            this.gc_RollPro.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup2});
            this.gc_RollPro.Size = new System.Drawing.Size(803, 482);
            this.gc_RollPro.TabIndex = 214;
            this.gc_RollPro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_RollPro});
            // 
            // gv_RollPro
            // 
            this.gv_RollPro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn12});
            this.gv_RollPro.GridControl = this.gc_RollPro;
            this.gv_RollPro.Name = "gv_RollPro";
            this.gv_RollPro.OptionsBehavior.Editable = false;
            this.gv_RollPro.OptionsCustomization.AllowSort = false;
            this.gv_RollPro.OptionsSelection.MultiSelect = true;
            this.gv_RollPro.OptionsView.ShowFooter = true;
            this.gv_RollPro.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "gridColumn11";
            this.gridColumn11.ColumnEdit = this.repositoryItemRadioGroup2;
            this.gridColumn11.Name = "gridColumn11";
            // 
            // repositoryItemRadioGroup2
            // 
            this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "批号";
            this.gridColumn3.FieldName = "C_BATCH_NO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "钩号";
            this.gridColumn4.FieldName = "C_TICK_NO";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "钢种";
            this.gridColumn5.FieldName = "C_STL_GRD";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "规格";
            this.gridColumn6.FieldName = "C_SPEC";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "执行标准";
            this.gridColumn7.FieldName = "C_STD_CODE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "重量";
            this.gridColumn8.FieldName = "N_WGT";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "主键";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "入库日期";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 6;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.txt_Batch_No);
            this.panel3.Controls.Add(this.labelControl5);
            this.panel3.Controls.Add(this.btn_query_zg);
            this.panel3.Controls.Add(this.labelControl7);
            this.panel3.Controls.Add(this.txt_Gh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 41);
            this.panel3.TabIndex = 213;
            // 
            // btn_save
            // 
            this.btn_save.ImageUri.Uri = "Save;Size16x16";
            this.btn_save.Location = new System.Drawing.Point(214, 8);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(79, 23);
            this.btn_save.TabIndex = 202;
            this.btn_save.Text = "删除";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_Batch_No
            // 
            this.txt_Batch_No.Location = new System.Drawing.Point(38, 9);
            this.txt_Batch_No.Name = "txt_Batch_No";
            this.txt_Batch_No.Size = new System.Drawing.Size(98, 20);
            this.txt_Batch_No.TabIndex = 186;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(8, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 185;
            this.labelControl5.Text = "批号";
            // 
            // btn_query_zg
            // 
            this.btn_query_zg.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_query_zg.Location = new System.Drawing.Point(147, 8);
            this.btn_query_zg.Name = "btn_query_zg";
            this.btn_query_zg.Size = new System.Drawing.Size(61, 23);
            this.btn_query_zg.TabIndex = 160;
            this.btn_query_zg.Text = "查询";
            this.btn_query_zg.Click += new System.EventHandler(this.btn_query_zg_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(536, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 156;
            this.labelControl7.Text = "钩号";
            this.labelControl7.Visible = false;
            // 
            // txt_Gh
            // 
            this.txt_Gh.Location = new System.Drawing.Point(567, 9);
            this.txt_Gh.Name = "txt_Gh";
            this.txt_Gh.Size = new System.Drawing.Size(98, 20);
            this.txt_Gh.TabIndex = 159;
            this.txt_Gh.Visible = false;
            // 
            // FrmRC_TBWGD4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 523);
            this.Controls.Add(this.gc_RollPro);
            this.Controls.Add(this.panel3);
            this.Name = "FrmRC_TBWGD4";
            this.Text = "FrmRC_TBWGD4";
            ((System.ComponentModel.ISupportInitialize)(this.gc_RollPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_RollPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_No.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Gh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_RollPro;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_RollPro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.TextEdit txt_Batch_No;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_query_zg;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_Gh;
    }
}