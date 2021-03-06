﻿namespace XGCAP.UI.P.PB
{
    partial class FrmPB_LGHJCSJ
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
            this.gc_GWCN = new DevExpress.XtraGrid.GridControl();
            this.gv_GWCN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_CAPACITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_QueryMain = new DevExpress.XtraEditors.SimpleButton();
            this.btn_UpdateGW = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cn = new DevExpress.XtraEditors.TextEdit();
            this.cbo_GW = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_DCHJCSJ = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GWCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GWCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_GWCN
            // 
            this.gc_GWCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GWCN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GWCN.Location = new System.Drawing.Point(0, 103);
            this.gc_GWCN.MainView = this.gv_GWCN;
            this.gc_GWCN.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GWCN.Name = "gc_GWCN";
            this.gc_GWCN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gc_GWCN.Size = new System.Drawing.Size(1148, 477);
            this.gc_GWCN.TabIndex = 11;
            this.gc_GWCN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GWCN});
            // 
            // gv_GWCN
            // 
            this.gv_GWCN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_STA_ID,
            this.colN_CAPACITY,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_GWCN.GridControl = this.gc_GWCN;
            this.gv_GWCN.Name = "gv_GWCN";
            this.gv_GWCN.OptionsBehavior.Editable = false;
            this.gv_GWCN.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_STA_ID
            // 
            this.colC_STA_ID.Caption = "连铸";
            this.colC_STA_ID.FieldName = "C_STA_ID";
            this.colC_STA_ID.Name = "colC_STA_ID";
            this.colC_STA_ID.Visible = true;
            this.colC_STA_ID.VisibleIndex = 0;
            // 
            // colN_CAPACITY
            // 
            this.colN_CAPACITY.Caption = "换浇次时间";
            this.colN_CAPACITY.FieldName = "N_TIME";
            this.colN_CAPACITY.Name = "colN_CAPACITY";
            this.colN_CAPACITY.Visible = true;
            this.colN_CAPACITY.VisibleIndex = 1;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 2;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "操作时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_DCHJCSJ);
            this.panelControl2.Controls.Add(this.btn_QueryMain);
            this.panelControl2.Controls.Add(this.btn_UpdateGW);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 53);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1148, 50);
            this.panelControl2.TabIndex = 12;
            // 
            // btn_QueryMain
            // 
            this.btn_QueryMain.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_QueryMain.Location = new System.Drawing.Point(15, 15);
            this.btn_QueryMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_QueryMain.Name = "btn_QueryMain";
            this.btn_QueryMain.Size = new System.Drawing.Size(77, 27);
            this.btn_QueryMain.TabIndex = 138;
            this.btn_QueryMain.Text = "查询";
            this.btn_QueryMain.Click += new System.EventHandler(this.btn_QueryMain_Click_1);
            // 
            // btn_UpdateGW
            // 
            this.btn_UpdateGW.ImageUri.Uri = "Save;Size16x16";
            this.btn_UpdateGW.Location = new System.Drawing.Point(100, 15);
            this.btn_UpdateGW.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UpdateGW.Name = "btn_UpdateGW";
            this.btn_UpdateGW.Size = new System.Drawing.Size(77, 27);
            this.btn_UpdateGW.TabIndex = 137;
            this.btn_UpdateGW.Text = "修改";
            this.btn_UpdateGW.Click += new System.EventHandler(this.btn_UpdateGW_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(185, 15);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(77, 27);
            this.btn_Stop.TabIndex = 135;
            this.btn_Stop.Text = "删除";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_cn);
            this.panelControl1.Controls.Add(this.cbo_GW);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1148, 53);
            this.panelControl1.TabIndex = 10;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(397, 15);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(77, 27);
            this.btn_Save.TabIndex = 91;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(247, 21);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "时间";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "工位";
            // 
            // txt_cn
            // 
            this.txt_cn.Location = new System.Drawing.Point(305, 18);
            this.txt_cn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cn.Name = "txt_cn";
            this.txt_cn.Properties.Mask.EditMask = "n0";
            this.txt_cn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_cn.Properties.MaxLength = 3;
            this.txt_cn.Size = new System.Drawing.Size(84, 24);
            this.txt_cn.TabIndex = 1;
            // 
            // cbo_GW
            // 
            this.cbo_GW.Location = new System.Drawing.Point(59, 18);
            this.cbo_GW.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_GW.Name = "cbo_GW";
            this.cbo_GW.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GW.Size = new System.Drawing.Size(175, 24);
            this.cbo_GW.TabIndex = 1;
            // 
            // btn_DCHJCSJ
            // 
            this.btn_DCHJCSJ.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_DCHJCSJ.Location = new System.Drawing.Point(270, 15);
            this.btn_DCHJCSJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_DCHJCSJ.Name = "btn_DCHJCSJ";
            this.btn_DCHJCSJ.Size = new System.Drawing.Size(77, 27);
            this.btn_DCHJCSJ.TabIndex = 245;
            this.btn_DCHJCSJ.Text = "导出";
            this.btn_DCHJCSJ.Click += new System.EventHandler(this.btn_DCHJCSJ_Click);
            // 
            // FrmPB_LGHJCSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 580);
            this.Controls.Add(this.gc_GWCN);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPB_LGHJCSJ";
            this.Text = "连铸换浇次时间";
            this.Load += new System.EventHandler(this.FrmPB_LZHJCSJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_GWCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GWCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_GWCN;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GWCN;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colN_CAPACITY;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_cn;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GW;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_UpdateGW;
        private DevExpress.XtraEditors.SimpleButton btn_QueryMain;
        private DevExpress.XtraEditors.SimpleButton btn_DCHJCSJ;
    }
}