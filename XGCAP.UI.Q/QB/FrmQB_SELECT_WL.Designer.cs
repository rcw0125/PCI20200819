namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_SELECT_WL
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Mat_Code = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Mat_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_GRD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_spec = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matrl)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mat_Code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mat_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GRD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_spec.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Matrl
            // 
            this.gc_Matrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Matrl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_Matrl.Location = new System.Drawing.Point(0, 34);
            this.gc_Matrl.MainView = this.gv_Matrl;
            this.gc_Matrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_Matrl.Name = "gc_Matrl";
            this.gc_Matrl.Size = new System.Drawing.Size(785, 334);
            this.gc_Matrl.TabIndex = 44;
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
            this.C_SPEC});
            this.gv_Matrl.GridControl = this.gc_Matrl;
            this.gv_Matrl.Name = "gv_Matrl";
            this.gv_Matrl.OptionsBehavior.Editable = false;
            this.gv_Matrl.OptionsView.ColumnAutoWidth = false;
            this.gv_Matrl.OptionsView.ShowGroupPanel = false;
            this.gv_Matrl.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Matrl_FocusedRowChanged);
            this.gv_Matrl.DoubleClick += new System.EventHandler(this.gv_Matrl_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "主键";
            this.gridColumn1.FieldName = "C_ID";
            this.gridColumn1.Name = "gridColumn1";
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
            this.C_MAT_NAME.Caption = "物料描述";
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
            // C_SPEC
            // 
            this.C_SPEC.Caption = "规格";
            this.C_SPEC.FieldName = "规格";
            this.C_SPEC.Name = "C_SPEC";
            this.C_SPEC.Visible = true;
            this.C_SPEC.VisibleIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelControl1);
            this.flowLayoutPanel2.Controls.Add(this.txt_Mat_Code);
            this.flowLayoutPanel2.Controls.Add(this.labelControl2);
            this.flowLayoutPanel2.Controls.Add(this.txt_Mat_Name);
            this.flowLayoutPanel2.Controls.Add(this.labelControl3);
            this.flowLayoutPanel2.Controls.Add(this.txt_GRD);
            this.flowLayoutPanel2.Controls.Add(this.labelControl4);
            this.flowLayoutPanel2.Controls.Add(this.txt_spec);
            this.flowLayoutPanel2.Controls.Add(this.btn_Query);
            this.flowLayoutPanel2.Controls.Add(this.btn_OK);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(785, 34);
            this.flowLayoutPanel2.TabIndex = 43;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "物料编码";
            // 
            // txt_Mat_Code
            // 
            this.txt_Mat_Code.Location = new System.Drawing.Point(60, 6);
            this.txt_Mat_Code.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Mat_Code.Name = "txt_Mat_Code";
            this.txt_Mat_Code.Size = new System.Drawing.Size(114, 20);
            this.txt_Mat_Code.TabIndex = 39;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(179, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "物料名称";
            // 
            // txt_Mat_Name
            // 
            this.txt_Mat_Name.Location = new System.Drawing.Point(232, 6);
            this.txt_Mat_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Mat_Name.Name = "txt_Mat_Name";
            this.txt_Mat_Name.Size = new System.Drawing.Size(93, 20);
            this.txt_Mat_Name.TabIndex = 38;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(330, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "钢种";
            // 
            // txt_GRD
            // 
            this.txt_GRD.Location = new System.Drawing.Point(359, 6);
            this.txt_GRD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_GRD.Name = "txt_GRD";
            this.txt_GRD.Size = new System.Drawing.Size(93, 20);
            this.txt_GRD.TabIndex = 44;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(457, 7);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 45;
            this.labelControl4.Text = "规格";
            // 
            // txt_spec
            // 
            this.txt_spec.Location = new System.Drawing.Point(486, 6);
            this.txt_spec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_spec.Name = "txt_spec";
            this.txt_spec.Size = new System.Drawing.Size(93, 20);
            this.txt_spec.TabIndex = 46;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(584, 7);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 0;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.ImageUri.Uri = "Apply;Size16x16";
            this.btn_OK.Location = new System.Drawing.Point(665, 7);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 40;
            this.btn_OK.Text = "确定";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // FrmQB_SELECT_WL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 368);
            this.Controls.Add(this.gc_Matrl);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "FrmQB_SELECT_WL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择物料编码";
            this.Load += new System.EventHandler(this.FrmQB_SELECT_WL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Matrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Matrl)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mat_Code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mat_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GRD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_spec.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Matrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Matrl;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_NAME;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Mat_Code;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Mat_Name;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_GRD;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_spec;
        private DevExpress.XtraGrid.Columns.GridColumn C_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn C_SPEC;
    }
}