namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_SELECT_KDXX
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cust_no = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_cust_name = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.gc_StdMain = new DevExpress.XtraGrid.GridControl();
            this.gv_StdMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cust_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cust_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StdMain)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelControl2);
            this.flowLayoutPanel2.Controls.Add(this.txt_cust_no);
            this.flowLayoutPanel2.Controls.Add(this.labelControl1);
            this.flowLayoutPanel2.Controls.Add(this.txt_cust_name);
            this.flowLayoutPanel2.Controls.Add(this.btn_Query);
            this.flowLayoutPanel2.Controls.Add(this.btn_OK);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(624, 42);
            this.flowLayoutPanel2.TabIndex = 41;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "客户代码";
            // 
            // txt_cust_no
            // 
            this.txt_cust_no.Location = new System.Drawing.Point(60, 6);
            this.txt_cust_no.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cust_no.Name = "txt_cust_no";
            this.txt_cust_no.Size = new System.Drawing.Size(87, 20);
            this.txt_cust_no.TabIndex = 39;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(152, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "客户名称";
            // 
            // txt_cust_name
            // 
            this.txt_cust_name.Location = new System.Drawing.Point(205, 6);
            this.txt_cust_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cust_name.Name = "txt_cust_name";
            this.txt_cust_name.Size = new System.Drawing.Size(219, 20);
            this.txt_cust_name.TabIndex = 39;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(429, 7);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 0;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.ImageUri.Uri = "Apply;Size16x16";
            this.btn_OK.Location = new System.Drawing.Point(510, 7);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 40;
            this.btn_OK.Text = "确定";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // gc_StdMain
            // 
            this.gc_StdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_StdMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_StdMain.Location = new System.Drawing.Point(0, 42);
            this.gc_StdMain.MainView = this.gv_StdMain;
            this.gc_StdMain.Margin = new System.Windows.Forms.Padding(2);
            this.gc_StdMain.Name = "gc_StdMain";
            this.gc_StdMain.Size = new System.Drawing.Size(624, 265);
            this.gc_StdMain.TabIndex = 42;
            this.gc_StdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_StdMain});
            // 
            // gv_StdMain
            // 
            this.gv_StdMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.gv_StdMain.GridControl = this.gc_StdMain;
            this.gv_StdMain.Name = "gv_StdMain";
            this.gv_StdMain.OptionsBehavior.Editable = false;
            this.gv_StdMain.OptionsView.ShowGroupPanel = false;
            this.gv_StdMain.Click += new System.EventHandler(this.gv_StdMain_Click);
            this.gv_StdMain.DoubleClick += new System.EventHandler(this.gv_StdMain_DoubleClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "客户编码";
            this.gridColumn2.FieldName = "C_NO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "客户名称";
            this.gridColumn3.FieldName = "C_NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // FrmQB_SELECT_KDXX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 307);
            this.Controls.Add(this.gc_StdMain);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQB_SELECT_KDXX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择客户名称";
            this.Load += new System.EventHandler(this.FrmQB_SELECT_ZXBZ_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cust_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cust_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StdMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_cust_name;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraGrid.GridControl gc_StdMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_StdMain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_cust_no;
    }
}