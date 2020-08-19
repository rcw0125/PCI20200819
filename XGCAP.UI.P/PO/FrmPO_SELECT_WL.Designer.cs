﻿namespace XGCAP.UI.P.PO
{
    partial class FrmPO_SELECT_WL
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Std = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Grd = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.gc_StdMain = new DevExpress.XtraGrid.GridControl();
            this.gv_StdMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Std.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StdMain)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelControl1);
            this.flowLayoutPanel2.Controls.Add(this.txt_Std);
            this.flowLayoutPanel2.Controls.Add(this.labelControl2);
            this.flowLayoutPanel2.Controls.Add(this.txt_Grd);
            this.flowLayoutPanel2.Controls.Add(this.btn_Query);
            this.flowLayoutPanel2.Controls.Add(this.btn_OK);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1091, 51);
            this.flowLayoutPanel2.TabIndex = 41;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "执行标准";
            // 
            // txt_Std
            // 
            this.txt_Std.Location = new System.Drawing.Point(76, 11);
            this.txt_Std.Margin = new System.Windows.Forms.Padding(3, 6, 3, 2);
            this.txt_Std.Name = "txt_Std";
            this.txt_Std.Properties.MaxLength = 50;
            this.txt_Std.Properties.ReadOnly = true;
            this.txt_Std.Size = new System.Drawing.Size(152, 24);
            this.txt_Std.TabIndex = 39;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(235, 13);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "钢种";
            // 
            // txt_Grd
            // 
            this.txt_Grd.Location = new System.Drawing.Point(272, 11);
            this.txt_Grd.Margin = new System.Windows.Forms.Padding(3, 6, 3, 2);
            this.txt_Grd.Name = "txt_Grd";
            this.txt_Grd.Properties.MaxLength = 50;
            this.txt_Grd.Properties.ReadOnly = true;
            this.txt_Grd.Size = new System.Drawing.Size(124, 24);
            this.txt_Grd.TabIndex = 38;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(403, 9);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(100, 29);
            this.btn_Query.TabIndex = 0;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.ImageUri.Uri = "Apply;Size16x16";
            this.btn_OK.Location = new System.Drawing.Point(511, 9);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 29);
            this.btn_OK.TabIndex = 40;
            this.btn_OK.Text = "确定";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // gc_StdMain
            // 
            this.gc_StdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_StdMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_StdMain.Location = new System.Drawing.Point(0, 51);
            this.gc_StdMain.MainView = this.gv_StdMain;
            this.gc_StdMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_StdMain.Name = "gc_StdMain";
            this.gc_StdMain.Size = new System.Drawing.Size(1091, 547);
            this.gc_StdMain.TabIndex = 42;
            this.gc_StdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_StdMain});
            // 
            // gv_StdMain
            // 
            this.gv_StdMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn1});
            this.gv_StdMain.GridControl = this.gc_StdMain;
            this.gv_StdMain.Name = "gv_StdMain";
            this.gv_StdMain.OptionsBehavior.Editable = false;
            this.gv_StdMain.OptionsView.ColumnAutoWidth = false;
            this.gv_StdMain.OptionsView.ShowGroupPanel = false;
            this.gv_StdMain.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_StdMain_FocusedRowChanged);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "钢种";
            this.gridColumn3.FieldName = "C_STL_GRD";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "断面";
            this.gridColumn4.FieldName = "C_SLAB_SIZE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "物料编码";
            this.gridColumn5.FieldName = "C_MATRAL_CODE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "物料名称";
            this.gridColumn6.FieldName = "C_MAT_NAME";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "定尺";
            this.gridColumn1.FieldName = "N_LTH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // FrmPO_SELECT_WL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 598);
            this.Controls.Add(this.gc_StdMain);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPO_SELECT_WL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择热轧坯物料";
            this.Load += new System.EventHandler(this.FrmPO_SELECT_WL_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Std.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StdMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Std;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Grd;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraGrid.GridControl gc_StdMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_StdMain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}