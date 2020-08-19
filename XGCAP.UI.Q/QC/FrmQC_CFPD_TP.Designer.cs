namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_CFPD_TP
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
            this.txt_GZ = new DevExpress.XtraEditors.TextEdit();
            this.txt_LH = new DevExpress.XtraEditors.TextEdit();
            this.txt_BZ = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gc_CF = new DevExpress.XtraGrid.GridControl();
            this.gv_CF = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CF)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txt_GZ);
            this.panelControl1.Controls.Add(this.txt_LH);
            this.panelControl1.Controls.Add(this.txt_BZ);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(384, 62);
            this.panelControl1.TabIndex = 0;
            // 
            // txt_GZ
            // 
            this.txt_GZ.Location = new System.Drawing.Point(242, 36);
            this.txt_GZ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_GZ.Name = "txt_GZ";
            this.txt_GZ.Properties.ReadOnly = true;
            this.txt_GZ.Size = new System.Drawing.Size(121, 20);
            this.txt_GZ.TabIndex = 11;
            // 
            // txt_LH
            // 
            this.txt_LH.Location = new System.Drawing.Point(63, 11);
            this.txt_LH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_LH.Name = "txt_LH";
            this.txt_LH.Properties.ReadOnly = true;
            this.txt_LH.Size = new System.Drawing.Size(124, 20);
            this.txt_LH.TabIndex = 10;
            // 
            // txt_BZ
            // 
            this.txt_BZ.Location = new System.Drawing.Point(62, 36);
            this.txt_BZ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_BZ.Name = "txt_BZ";
            this.txt_BZ.Properties.ReadOnly = true;
            this.txt_BZ.Size = new System.Drawing.Size(125, 20);
            this.txt_BZ.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(203, 37);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "钢种：";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 36);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 14);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "标准：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 13);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "炉号：";
            // 
            // gc_CF
            // 
            this.gc_CF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CF.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_CF.Location = new System.Drawing.Point(0, 62);
            this.gc_CF.MainView = this.gv_CF;
            this.gc_CF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_CF.Name = "gc_CF";
            this.gc_CF.Size = new System.Drawing.Size(384, 415);
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
            // FrmQC_CFPD_TP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 477);
            this.Controls.Add(this.gc_CF);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQC_CFPD_TP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "成分信息";
            this.Load += new System.EventHandler(this.FrmQC_CFPD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
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
    }
}