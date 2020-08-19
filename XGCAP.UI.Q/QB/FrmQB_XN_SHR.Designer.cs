namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_XN_SHR
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_User = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.icbo_Dept = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.gc_User = new DevExpress.XtraGrid.GridControl();
            this.gv_User = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_User.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_Dept.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_User)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.labelControl8);
            this.flowLayoutPanel1.Controls.Add(this.txt_User);
            this.flowLayoutPanel1.Controls.Add(this.labelControl5);
            this.flowLayoutPanel1.Controls.Add(this.icbo_Dept);
            this.flowLayoutPanel1.Controls.Add(this.btn_Query);
            this.flowLayoutPanel1.Controls.Add(this.btn_Add);
            this.flowLayoutPanel1.Controls.Add(this.btn_Cancle);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1211, 37);
            this.flowLayoutPanel1.TabIndex = 123;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(3, 6);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 18);
            this.labelControl8.TabIndex = 120;
            this.labelControl8.Text = "审核人";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(54, 6);
            this.txt_User.Margin = new System.Windows.Forms.Padding(3, 6, 3, 2);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(111, 24);
            this.txt_User.TabIndex = 121;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(171, 6);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 18);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "部门";
            // 
            // icbo_Dept
            // 
            this.icbo_Dept.EditValue = "质控部";
            this.icbo_Dept.Location = new System.Drawing.Point(208, 6);
            this.icbo_Dept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.icbo_Dept.Name = "icbo_Dept";
            this.icbo_Dept.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbo_Dept.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("质控部", "质控部", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("技术中心", "技术中心", -1)});
            this.icbo_Dept.Size = new System.Drawing.Size(162, 24);
            this.icbo_Dept.TabIndex = 33;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(378, 4);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(100, 29);
            this.btn_Query.TabIndex = 30;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(486, 4);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 29);
            this.btn_Add.TabIndex = 122;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancle
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.btn_Cancle, true);
            this.btn_Cancle.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Cancle.Location = new System.Drawing.Point(594, 4);
            this.btn_Cancle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(100, 29);
            this.btn_Cancle.TabIndex = 123;
            this.btn_Cancle.Text = "删除";
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // gc_User
            // 
            this.gc_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_User.Location = new System.Drawing.Point(0, 37);
            this.gc_User.MainView = this.gv_User;
            this.gc_User.Name = "gc_User";
            this.gc_User.Size = new System.Drawing.Size(1211, 511);
            this.gc_User.TabIndex = 124;
            this.gc_User.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_User});
            // 
            // gv_User
            // 
            this.gv_User.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_User.GridControl = this.gc_User;
            this.gv_User.Name = "gv_User";
            this.gv_User.OptionsBehavior.Editable = false;
            this.gv_User.OptionsView.ColumnAutoWidth = false;
            this.gv_User.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "C_ID";
            this.gridColumn1.FieldName = "C_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "姓名";
            this.gridColumn2.FieldName = "C_USER_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "部门";
            this.gridColumn3.FieldName = "C_DEPT";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // FrmQB_XN_SHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 548);
            this.Controls.Add(this.gc_User);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmQB_XN_SHR";
            this.Text = "物理性能审核人";
            this.Load += new System.EventHandler(this.FrmQB_XN_SHR_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_User.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_Dept.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_User;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbo_Dept;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Cancle;
        private DevExpress.XtraGrid.GridControl gc_User;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_User;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}