namespace XGCAP.UI.R.RP
{
    partial class FrmRP_NOTLIMIT
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
            this.gc_ZGSJ = new DevExpress.XtraGrid.GridControl();
            this.gv_ZGSJ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.image_Type = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_TB = new DevExpress.XtraEditors.SimpleButton();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZGSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZGSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_ZGSJ
            // 
            this.gc_ZGSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ZGSJ.Location = new System.Drawing.Point(0, 38);
            this.gc_ZGSJ.MainView = this.gv_ZGSJ;
            this.gc_ZGSJ.Name = "gc_ZGSJ";
            this.gc_ZGSJ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gc_ZGSJ.Size = new System.Drawing.Size(776, 467);
            this.gc_ZGSJ.TabIndex = 27;
            this.gc_ZGSJ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ZGSJ});
            // 
            // gv_ZGSJ
            // 
            this.gv_ZGSJ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2});
            this.gv_ZGSJ.GridControl = this.gc_ZGSJ;
            this.gv_ZGSJ.Name = "gv_ZGSJ";
            this.gv_ZGSJ.OptionsBehavior.Editable = false;
            this.gv_ZGSJ.OptionsView.ShowGroupPanel = false;
            this.gv_ZGSJ.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gv_ZGSJ_CustomColumnDisplayText);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "C_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "名称";
            this.gridColumn3.FieldName = "C_NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "类型";
            this.gridColumn2.FieldName = "C_TYPE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.image_Type);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btn_TB);
            this.panelControl2.Controls.Add(this.txt_name);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(776, 38);
            this.panelControl2.TabIndex = 26;
            // 
            // image_Type
            // 
            this.image_Type.EditValue = "1";
            this.image_Type.Location = new System.Drawing.Point(229, 11);
            this.image_Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image_Type.Name = "image_Type";
            this.image_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.image_Type.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("钢种", "1", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("物料编码", "2", -1)});
            this.image_Type.Size = new System.Drawing.Size(101, 20);
            this.image_Type.TabIndex = 243;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(198, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 242;
            this.labelControl1.Text = "类型";
            // 
            // btn_TB
            // 
            this.btn_TB.ImageUri.Uri = "Refresh;Size16x16";
            this.btn_TB.Location = new System.Drawing.Point(336, 10);
            this.btn_TB.Name = "btn_TB";
            this.btn_TB.Size = new System.Drawing.Size(75, 23);
            this.btn_TB.TabIndex = 241;
            this.btn_TB.Text = "保存";
            this.btn_TB.Click += new System.EventHandler(this.btn_TB_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(41, 11);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.MaxLength = 30;
            this.txt_name.Size = new System.Drawing.Size(144, 20);
            this.txt_name.TabIndex = 230;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(11, 14);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(24, 14);
            this.labelControl13.TabIndex = 228;
            this.labelControl13.Text = "名称";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Cancel;Size16x16";
            this.simpleButton1.Location = new System.Drawing.Point(417, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 244;
            this.simpleButton1.Text = "删除";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmRP_NOTLIMIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 505);
            this.Controls.Add(this.gc_ZGSJ);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmRP_NOTLIMIT";
            this.Text = "FrmRP_NOTLIMIT";
            this.Load += new System.EventHandler(this.FrmRP_NOTLIMIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZGSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZGSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_ZGSJ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ZGSJ;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_TB;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.ImageComboBoxEdit image_Type;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}