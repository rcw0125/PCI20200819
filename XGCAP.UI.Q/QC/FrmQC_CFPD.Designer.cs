namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_CFPD
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gc_CF = new DevExpress.XtraGrid.GridControl();
            this.gv_CF = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_PH = new DevExpress.XtraEditors.TextEdit();
            this.txt_BZ = new DevExpress.XtraEditors.TextEdit();
            this.txt_LH = new DevExpress.XtraEditors.TextEdit();
            this.txt_GZ = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txt_GZ);
            this.panelControl1.Controls.Add(this.txt_LH);
            this.panelControl1.Controls.Add(this.txt_BZ);
            this.panelControl1.Controls.Add(this.txt_PH);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(512, 78);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(271, 46);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 18);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "钢种：";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(32, 45);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 18);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "标准：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(271, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "炉号：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "批号：";
            // 
            // gc_CF
            // 
            this.gc_CF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CF.Location = new System.Drawing.Point(0, 78);
            this.gc_CF.MainView = this.gv_CF;
            this.gc_CF.Name = "gc_CF";
            this.gc_CF.Size = new System.Drawing.Size(512, 518);
            this.gc_CF.TabIndex = 1;
            this.gc_CF.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CF});
            // 
            // gv_CF
            // 
            this.gv_CF.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gv_CF.GridControl = this.gc_CF;
            this.gv_CF.Name = "gv_CF";
            this.gv_CF.OptionsBehavior.Editable = false;
            this.gv_CF.OptionsView.ColumnAutoWidth = false;
            this.gv_CF.OptionsView.ShowGroupPanel = false;
            this.gv_CF.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gv_CF_RowStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "项目名称";
            this.gridColumn1.FieldName = "C_ITEM_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "项目值";
            this.gridColumn2.FieldName = "C_VALUE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "项目结果";
            this.gridColumn3.FieldName = "C_RESULT";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "区间";
            this.gridColumn4.FieldName = "C_INTERVAL";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // txt_PH
            // 
            this.txt_PH.Location = new System.Drawing.Point(82, 10);
            this.txt_PH.Name = "txt_PH";
            this.txt_PH.Properties.ReadOnly = true;
            this.txt_PH.Size = new System.Drawing.Size(167, 24);
            this.txt_PH.TabIndex = 8;
            // 
            // txt_BZ
            // 
            this.txt_BZ.Location = new System.Drawing.Point(82, 45);
            this.txt_BZ.Name = "txt_BZ";
            this.txt_BZ.Properties.ReadOnly = true;
            this.txt_BZ.Size = new System.Drawing.Size(167, 24);
            this.txt_BZ.TabIndex = 9;
            // 
            // txt_LH
            // 
            this.txt_LH.Location = new System.Drawing.Point(322, 10);
            this.txt_LH.Name = "txt_LH";
            this.txt_LH.Properties.ReadOnly = true;
            this.txt_LH.Size = new System.Drawing.Size(161, 24);
            this.txt_LH.TabIndex = 10;
            // 
            // txt_GZ
            // 
            this.txt_GZ.Location = new System.Drawing.Point(322, 45);
            this.txt_GZ.Name = "txt_GZ";
            this.txt_GZ.Properties.ReadOnly = true;
            this.txt_GZ.Size = new System.Drawing.Size(161, 24);
            this.txt_GZ.TabIndex = 11;
            // 
            // FrmQC_CFPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 596);
            this.Controls.Add(this.gc_CF);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQC_CFPD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "成分信息";
            this.Load += new System.EventHandler(this.FrmQC_CFPD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gc_CF;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CF;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_GZ;
        private DevExpress.XtraEditors.TextEdit txt_LH;
        private DevExpress.XtraEditors.TextEdit txt_BZ;
        private DevExpress.XtraEditors.TextEdit txt_PH;
    }
}