namespace XGCAP.UI.P.PO
{
    partial class FrmPO_TWLDD_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPO_TWLDD_ADD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Mat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_GZ = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_STD = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Main = new DevExpress.XtraGrid.GridControl();
            this.gv_Main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_OK);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txt_Mat);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txt_GZ);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txt_STD);
            this.panel1.Controls.Add(this.btn_Query);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.ImageUri.Uri = "Apply;Size16x16";
            this.btn_OK.Location = new System.Drawing.Point(568, 10);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 72;
            this.btn_OK.Text = "确定";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 71;
            this.labelControl1.Text = "物料编码";
            // 
            // txt_Mat
            // 
            this.txt_Mat.Location = new System.Drawing.Point(64, 11);
            this.txt_Mat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Mat.Name = "txt_Mat";
            this.txt_Mat.Size = new System.Drawing.Size(121, 20);
            this.txt_Mat.TabIndex = 70;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(195, 14);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 68;
            this.labelControl3.Text = "钢种";
            // 
            // txt_GZ
            // 
            this.txt_GZ.Location = new System.Drawing.Point(223, 11);
            this.txt_GZ.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GZ.Name = "txt_GZ";
            this.txt_GZ.Size = new System.Drawing.Size(99, 20);
            this.txt_GZ.TabIndex = 67;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(331, 14);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 66;
            this.labelControl4.Text = "执行标准";
            // 
            // txt_STD
            // 
            this.txt_STD.Location = new System.Drawing.Point(383, 11);
            this.txt_STD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.txt_STD.Name = "txt_STD";
            this.txt_STD.Size = new System.Drawing.Size(99, 20);
            this.txt_STD.TabIndex = 69;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(487, 10);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 65;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // gc_Main
            // 
            this.gc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Main.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Main.Location = new System.Drawing.Point(0, 41);
            this.gc_Main.MainView = this.gv_Main;
            this.gc_Main.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Main.Name = "gc_Main";
            this.gc_Main.Size = new System.Drawing.Size(800, 409);
            this.gc_Main.TabIndex = 43;
            this.gc_Main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Main});
            // 
            // gv_Main
            // 
            this.gv_Main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn7});
            this.gv_Main.GridControl = this.gc_Main;
            this.gv_Main.Name = "gv_Main";
            this.gv_Main.OptionsBehavior.Editable = false;
            this.gv_Main.OptionsView.ColumnAutoWidth = false;
            this.gv_Main.OptionsView.ShowGroupPanel = false;
            this.gv_Main.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Main_FocusedRowChanged);
            this.gv_Main.DoubleClick += new System.EventHandler(this.gv_Main_DoubleClick);
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
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "物料编码";
            this.gridColumn5.FieldName = "C_MAT_CODE";
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
            this.gridColumn1.Caption = "执行标准";
            this.gridColumn1.FieldName = "C_STD_CODE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "自由项1";
            this.gridColumn2.FieldName = "C_ZYX1";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "自由项2";
            this.gridColumn7.FieldName = "C_ZYX2";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // FrmPO_TWLDD_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gc_Main);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPO_TWLDD_ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TWLDD_ADD";
            this.Load += new System.EventHandler(this.FrmPO_TWLDD_ADD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_GZ;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_STD;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Mat;
        private DevExpress.XtraGrid.GridControl gc_Main;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Main;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
    }
}