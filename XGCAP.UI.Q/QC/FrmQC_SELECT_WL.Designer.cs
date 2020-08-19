namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_SELECT_WL
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
            this.txt_STD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Spec = new DevExpress.XtraEditors.TextEdit();
            this.txt_GZ = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.txt_mat_code = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.gv_Matrl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.C_MAT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_SLAB_SIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Matrl = new DevExpress.XtraGrid.GridControl();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Len = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Spec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mat_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matrl)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Len.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_STD
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.txt_STD, true);
            this.txt_STD.Location = new System.Drawing.Point(414, 7);
            this.txt_STD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.txt_STD.Name = "txt_STD";
            this.txt_STD.Size = new System.Drawing.Size(99, 20);
            this.txt_STD.TabIndex = 46;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 33);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "规格";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(362, 8);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "执行标准";
            // 
            // txt_Spec
            // 
            this.txt_Spec.Location = new System.Drawing.Point(34, 32);
            this.txt_Spec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.txt_Spec.Name = "txt_Spec";
            this.txt_Spec.Size = new System.Drawing.Size(99, 20);
            this.txt_Spec.TabIndex = 48;
            // 
            // txt_GZ
            // 
            this.txt_GZ.Location = new System.Drawing.Point(246, 6);
            this.txt_GZ.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GZ.Name = "txt_GZ";
            this.txt_GZ.Size = new System.Drawing.Size(112, 20);
            this.txt_GZ.TabIndex = 44;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(282, 32);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 0;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(218, 8);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "钢种";
            // 
            // btn_OK
            // 
            this.btn_OK.ImageUri.Uri = "Apply;Size16x16";
            this.btn_OK.Location = new System.Drawing.Point(363, 32);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 40;
            this.btn_OK.Text = "确定";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_mat_code
            // 
            this.txt_mat_code.Location = new System.Drawing.Point(58, 7);
            this.txt_mat_code.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.txt_mat_code.Name = "txt_mat_code";
            this.txt_mat_code.Size = new System.Drawing.Size(156, 20);
            this.txt_mat_code.TabIndex = 42;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(6, 8);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 41;
            this.labelControl8.Text = "物料编码";
            // 
            // gv_Matrl
            // 
            this.gv_Matrl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.C_MAT_CODE,
            this.C_MAT_NAME,
            this.C_STL_GRD,
            this.C_SLAB_SIZE,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gv_Matrl.GridControl = this.gc_Matrl;
            this.gv_Matrl.Name = "gv_Matrl";
            this.gv_Matrl.OptionsBehavior.Editable = false;
            this.gv_Matrl.OptionsView.ColumnAutoWidth = false;
            this.gv_Matrl.OptionsView.ShowGroupPanel = false;
            this.gv_Matrl.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Matrl_FocusedRowChanged);
            this.gv_Matrl.DoubleClick += new System.EventHandler(this.gv_Matrl_DoubleClick);
            // 
            // C_MAT_CODE
            // 
            this.C_MAT_CODE.Caption = "物料编码";
            this.C_MAT_CODE.FieldName = "物料编码";
            this.C_MAT_CODE.Name = "C_MAT_CODE";
            this.C_MAT_CODE.Visible = true;
            this.C_MAT_CODE.VisibleIndex = 0;
            // 
            // C_MAT_NAME
            // 
            this.C_MAT_NAME.Caption = "物料名称";
            this.C_MAT_NAME.FieldName = "物料名称";
            this.C_MAT_NAME.Name = "C_MAT_NAME";
            this.C_MAT_NAME.Visible = true;
            this.C_MAT_NAME.VisibleIndex = 1;
            // 
            // C_STL_GRD
            // 
            this.C_STL_GRD.Caption = "钢种";
            this.C_STL_GRD.FieldName = "钢种";
            this.C_STL_GRD.Name = "C_STL_GRD";
            this.C_STL_GRD.Visible = true;
            this.C_STL_GRD.VisibleIndex = 2;
            // 
            // C_SLAB_SIZE
            // 
            this.C_SLAB_SIZE.Caption = "规格";
            this.C_SLAB_SIZE.FieldName = "规格";
            this.C_SLAB_SIZE.Name = "C_SLAB_SIZE";
            this.C_SLAB_SIZE.Visible = true;
            this.C_SLAB_SIZE.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "执行标准";
            this.gridColumn1.FieldName = "执行标准";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "自由项1";
            this.gridColumn2.FieldName = "自由项1";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "自由项2";
            this.gridColumn3.FieldName = "自由项2";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "定尺";
            this.gridColumn4.FieldName = "定尺";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // gc_Matrl
            // 
            this.gc_Matrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Matrl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Matrl.Location = new System.Drawing.Point(0, 63);
            this.gc_Matrl.MainView = this.gv_Matrl;
            this.gc_Matrl.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Matrl.Name = "gc_Matrl";
            this.gc_Matrl.Size = new System.Drawing.Size(930, 390);
            this.gc_Matrl.TabIndex = 44;
            this.gc_Matrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Matrl});
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelControl8);
            this.flowLayoutPanel2.Controls.Add(this.txt_mat_code);
            this.flowLayoutPanel2.Controls.Add(this.labelControl2);
            this.flowLayoutPanel2.Controls.Add(this.txt_GZ);
            this.flowLayoutPanel2.Controls.Add(this.labelControl1);
            this.flowLayoutPanel2.Controls.Add(this.txt_STD);
            this.flowLayoutPanel2.Controls.Add(this.labelControl3);
            this.flowLayoutPanel2.Controls.Add(this.txt_Spec);
            this.flowLayoutPanel2.Controls.Add(this.labelControl4);
            this.flowLayoutPanel2.Controls.Add(this.txt_Len);
            this.flowLayoutPanel2.Controls.Add(this.btn_Query);
            this.flowLayoutPanel2.Controls.Add(this.btn_OK);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(930, 63);
            this.flowLayoutPanel2.TabIndex = 43;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(137, 33);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 51;
            this.labelControl4.Text = "定尺";
            // 
            // txt_Len
            // 
            this.txt_Len.Location = new System.Drawing.Point(165, 32);
            this.txt_Len.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.txt_Len.Name = "txt_Len";
            this.txt_Len.Size = new System.Drawing.Size(112, 20);
            this.txt_Len.TabIndex = 52;
            // 
            // FrmQC_SELECT_WL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 453);
            this.Controls.Add(this.gc_Matrl);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "FrmQC_SELECT_WL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请选择物料编码";
            this.Load += new System.EventHandler(this.FrmQC_SELECT_WL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_STD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Spec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mat_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matrl)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Len.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_mat_code;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.TextEdit txt_GZ;
        private DevExpress.XtraEditors.TextEdit txt_Spec;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_STD;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Matrl;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn C_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn C_SLAB_SIZE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.GridControl gc_Matrl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Len;
    }
}