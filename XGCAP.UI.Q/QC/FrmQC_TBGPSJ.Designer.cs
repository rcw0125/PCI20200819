namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_TBGPSJ
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
            this.gc_Slab = new DevExpress.XtraGrid.GridControl();
            this.gv_Slab = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Stove = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Tb = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Slab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Slab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Slab
            // 
            this.gc_Slab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Slab.Location = new System.Drawing.Point(0, 44);
            this.gc_Slab.MainView = this.gv_Slab;
            this.gc_Slab.Name = "gc_Slab";
            this.gc_Slab.Size = new System.Drawing.Size(1008, 517);
            this.gc_Slab.TabIndex = 22;
            this.gc_Slab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Slab});
            // 
            // gv_Slab
            // 
            this.gv_Slab.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn9,
            this.gridColumn10});
            this.gv_Slab.GridControl = this.gc_Slab;
            this.gv_Slab.Name = "gv_Slab";
            this.gv_Slab.OptionsBehavior.Editable = false;
            this.gv_Slab.OptionsView.ColumnAutoWidth = false;
            this.gv_Slab.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "炉号";
            this.gridColumn2.FieldName = "MATERIALID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "支数";
            this.gridColumn9.FieldName = "BLOOM_COUNT";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "重量";
            this.gridColumn10.FieldName = "CAL_WEIGHT";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Tb);
            this.panelControl1.Controls.Add(this.btn_Query);
            this.panelControl1.Controls.Add(this.txt_Stove);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1008, 44);
            this.panelControl1.TabIndex = 21;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(207, 6);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(83, 28);
            this.btn_Query.TabIndex = 17;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txt_Stove
            // 
            this.txt_Stove.Location = new System.Drawing.Point(54, 8);
            this.txt_Stove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stove.Name = "txt_Stove";
            this.txt_Stove.Size = new System.Drawing.Size(134, 24);
            this.txt_Stove.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 11);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 18);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "炉号";
            // 
            // btn_Tb
            // 
            this.btn_Tb.ImageUri.Uri = "Recurrence;Size16x16";
            this.btn_Tb.Location = new System.Drawing.Point(312, 6);
            this.btn_Tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tb.Name = "btn_Tb";
            this.btn_Tb.Size = new System.Drawing.Size(83, 28);
            this.btn_Tb.TabIndex = 28;
            this.btn_Tb.Text = "同步";
            this.btn_Tb.Click += new System.EventHandler(this.btn_Tb_Click);
            // 
            // FrmQC_TBGPSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.gc_Slab);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQC_TBGPSJ";
            this.Text = "同步钢坯实绩";
            this.Load += new System.EventHandler(this.FrmQC_TBGPSJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Slab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Slab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Slab;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Slab;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.TextEdit txt_Stove;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_Tb;
    }
}