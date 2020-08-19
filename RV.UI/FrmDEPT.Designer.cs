namespace RV.UI
{
    partial class FrmDEPT
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
            this.components = new System.ComponentModel.Container();
            this.modTSMODULEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gc_ANXX = new DevExpress.XtraGrid.GridControl();
            this.gv_ANXX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_MODULEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_PARENTMODULEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MODULENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_ASSEMBLYNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.modTSMODULEBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ANXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ANXX)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Controls.Add(this.panelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 562);
            this.panel2.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Indent = 19;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(0, 48);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(443, 514);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(443, 48);
            this.panelControl1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "部门导航";
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(425, 8);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 32);
            this.btn_Add.TabIndex = 128;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Del.Location = new System.Drawing.Point(533, 8);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(100, 32);
            this.btn_Del.TabIndex = 131;
            this.btn_Del.Text = "删除";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(443, 0);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 562);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gc_ANXX);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(449, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 562);
            this.panel3.TabIndex = 4;
            // 
            // gc_ANXX
            // 
            this.gc_ANXX.DataSource = this.modTSMODULEBindingSource;
            this.gc_ANXX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ANXX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_ANXX.Location = new System.Drawing.Point(0, 48);
            this.gc_ANXX.MainView = this.gv_ANXX;
            this.gc_ANXX.Margin = new System.Windows.Forms.Padding(4);
            this.gc_ANXX.Name = "gc_ANXX";
            this.gc_ANXX.Size = new System.Drawing.Size(772, 514);
            this.gc_ANXX.TabIndex = 4;
            this.gc_ANXX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ANXX});
            // 
            // gv_ANXX
            // 
            this.gv_ANXX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_MODULEID,
            this.colC_PARENTMODULEID,
            this.colC_MODULENAME,
            this.colC_ASSEMBLYNAME,
            this.colC_REMARK,
            this.colC_EMP_ID});
            this.gv_ANXX.GridControl = this.gc_ANXX;
            this.gv_ANXX.Name = "gv_ANXX";
            this.gv_ANXX.OptionsView.ShowGroupPanel = false;
            // 
            // colC_MODULEID
            // 
            this.colC_MODULEID.Caption = "C_ID";
            this.colC_MODULEID.FieldName = "C_ID";
            this.colC_MODULEID.Name = "colC_MODULEID";
            this.colC_MODULEID.OptionsColumn.AllowEdit = false;
            // 
            // colC_PARENTMODULEID
            // 
            this.colC_PARENTMODULEID.Caption = "C_PARENT_ID";
            this.colC_PARENTMODULEID.FieldName = "C_PARENT_ID";
            this.colC_PARENTMODULEID.Name = "colC_PARENTMODULEID";
            this.colC_PARENTMODULEID.OptionsColumn.AllowEdit = false;
            // 
            // colC_MODULENAME
            // 
            this.colC_MODULENAME.Caption = "部门代码";
            this.colC_MODULENAME.FieldName = "C_CODE";
            this.colC_MODULENAME.Name = "colC_MODULENAME";
            this.colC_MODULENAME.OptionsColumn.AllowEdit = false;
            this.colC_MODULENAME.Visible = true;
            this.colC_MODULENAME.VisibleIndex = 0;
            // 
            // colC_ASSEMBLYNAME
            // 
            this.colC_ASSEMBLYNAME.Caption = "部门名称";
            this.colC_ASSEMBLYNAME.FieldName = "C_NAME";
            this.colC_ASSEMBLYNAME.Name = "colC_ASSEMBLYNAME";
            this.colC_ASSEMBLYNAME.Visible = true;
            this.colC_ASSEMBLYNAME.VisibleIndex = 1;
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.Caption = "维护时间";
            this.colC_REMARK.DisplayFormat.FormatString = "G";
            this.colC_REMARK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colC_REMARK.FieldName = "D_MOD_DT";
            this.colC_REMARK.Name = "colC_REMARK";
            this.colC_REMARK.OptionsColumn.AllowEdit = false;
            this.colC_REMARK.Visible = true;
            this.colC_REMARK.VisibleIndex = 3;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "维护人";
            this.colC_EMP_ID.FieldName = "C_EMP_NAME";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.OptionsColumn.AllowEdit = false;
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Edit);
            this.panel4.Controls.Add(this.txt_Name);
            this.panel4.Controls.Add(this.labelControl1);
            this.panel4.Controls.Add(this.btn_Del);
            this.panel4.Controls.Add(this.btn_Add);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 48);
            this.panel4.TabIndex = 3;
            // 
            // btn_Edit
            // 
            this.btn_Edit.ImageUri.Uri = "Save;Size16x16";
            this.btn_Edit.Location = new System.Drawing.Point(641, 8);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 32);
            this.btn_Edit.TabIndex = 134;
            this.btn_Edit.Text = "修改";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(88, 12);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(330, 24);
            this.txt_Name.TabIndex = 133;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 132;
            this.labelControl1.Text = "部门名称";
            // 
            // FrmDEPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 562);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDEPT";
            this.Text = "部门管理";
            this.Load += new System.EventHandler(this.FrmDEPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modTSMODULEBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ANXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ANXX)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource modTSMODULEBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gc_ANXX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ANXX;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MODULEID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_PARENTMODULEID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MODULENAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ASSEMBLYNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
    }
}