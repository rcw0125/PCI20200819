namespace XGCAP.UI.P.PO.APS
{
    partial class FrmPO_APS_Select_WL
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
            this.gc_Matrl = new DevExpress.XtraGrid.GridControl();
            this.gv_Matrl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_STL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Std = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matrl)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Std.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Matrl
            // 
            this.gc_Matrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Matrl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Matrl.Location = new System.Drawing.Point(0, 34);
            this.gc_Matrl.MainView = this.gv_Matrl;
            this.gc_Matrl.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Matrl.Name = "gc_Matrl";
            this.gc_Matrl.Size = new System.Drawing.Size(1217, 532);
            this.gc_Matrl.TabIndex = 46;
            this.gc_Matrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Matrl});
            // 
            // gv_Matrl
            // 
            this.gv_Matrl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.C_MAT_CODE,
            this.C_MAT_NAME,
            this.C_STL_GRD,
            this.C_SPEC,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gv_Matrl.GridControl = this.gc_Matrl;
            this.gv_Matrl.Name = "gv_Matrl";
            this.gv_Matrl.OptionsBehavior.Editable = false;
            this.gv_Matrl.OptionsView.ColumnAutoWidth = false;
            this.gv_Matrl.OptionsView.ShowGroupPanel = false;
            this.gv_Matrl.Click += new System.EventHandler(this.gv_Matrl_Click);
            this.gv_Matrl.DoubleClick += new System.EventHandler(this.gv_Matrl_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "执行标准";
            this.gridColumn1.FieldName = "C_STD_CODE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // C_MAT_CODE
            // 
            this.C_MAT_CODE.Caption = "钢种";
            this.C_MAT_CODE.FieldName = "C_STL_GRD";
            this.C_MAT_CODE.Name = "C_MAT_CODE";
            this.C_MAT_CODE.Visible = true;
            this.C_MAT_CODE.VisibleIndex = 0;
            // 
            // C_MAT_NAME
            // 
            this.C_MAT_NAME.Caption = "工艺路线";
            this.C_MAT_NAME.FieldName = "C_ROUTE_DESC";
            this.C_MAT_NAME.Name = "C_MAT_NAME";
            this.C_MAT_NAME.Visible = true;
            this.C_MAT_NAME.VisibleIndex = 2;
            // 
            // C_STL_GRD
            // 
            this.C_STL_GRD.Caption = "物料描述";
            this.C_STL_GRD.FieldName = "C_MAT_NAME";
            this.C_STL_GRD.Name = "C_STL_GRD";
            this.C_STL_GRD.Visible = true;
            this.C_STL_GRD.VisibleIndex = 3;
            // 
            // C_SPEC
            // 
            this.C_SPEC.Caption = "断面";
            this.C_SPEC.FieldName = "C_SLAB_SIZE";
            this.C_SPEC.Name = "C_SPEC";
            this.C_SPEC.Visible = true;
            this.C_SPEC.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "长度";
            this.gridColumn2.FieldName = "N_LTH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "自由项1";
            this.gridColumn3.FieldName = "C_ZYX1";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "自由项2";
            this.gridColumn4.FieldName = "C_ZYX2";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "主键";
            this.gridColumn5.FieldName = "C_ID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelControl3);
            this.flowLayoutPanel2.Controls.Add(this.txt_STL);
            this.flowLayoutPanel2.Controls.Add(this.labelControl1);
            this.flowLayoutPanel2.Controls.Add(this.txt_Std);
            this.flowLayoutPanel2.Controls.Add(this.btn_Query);
            this.flowLayoutPanel2.Controls.Add(this.btn_OK);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1217, 34);
            this.flowLayoutPanel2.TabIndex = 45;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "钢种";
            // 
            // txt_STL
            // 
            this.txt_STL.Location = new System.Drawing.Point(36, 6);
            this.txt_STL.Margin = new System.Windows.Forms.Padding(2);
            this.txt_STL.Name = "txt_STL";
            this.txt_STL.Size = new System.Drawing.Size(93, 20);
            this.txt_STL.TabIndex = 44;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(134, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "执行标准";
            // 
            // txt_Std
            // 
            this.txt_Std.Location = new System.Drawing.Point(187, 6);
            this.txt_Std.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Std.Name = "txt_Std";
            this.txt_Std.Size = new System.Drawing.Size(114, 20);
            this.txt_Std.TabIndex = 39;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(306, 7);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 0;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.ImageUri.Uri = "Apply;Size16x16";
            this.btn_OK.Location = new System.Drawing.Point(387, 7);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 40;
            this.btn_OK.Text = "确定";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // FrmPO_APS_Select_WL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 566);
            this.Controls.Add(this.gc_Matrl);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "FrmPO_APS_Select_WL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择物料信息";
            this.Load += new System.EventHandler(this.FrmPO_APS_Select_WL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matrl)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Std.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Matrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Matrl;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn C_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn C_SPEC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_STL;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Std;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}