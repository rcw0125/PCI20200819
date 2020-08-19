namespace RV.UI
{
    partial class FrmSetDept
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.tl_Module = new DevExpress.XtraTreeList.TreeList();
            this.colC_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_PARENT_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bscTsDept = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tl_Module)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscTsDept)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1103, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(21, 11);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 28);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "确定";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tl_Module
            // 
            this.tl_Module.AllowDrop = true;
            this.tl_Module.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colC_ID,
            this.colC_PARENT_ID,
            this.colC_NAME});
            this.tl_Module.Cursor = System.Windows.Forms.Cursors.Default;
            this.tl_Module.DataSource = this.bscTsDept;
            this.tl_Module.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_Module.ImageIndexFieldName = "";
            this.tl_Module.Location = new System.Drawing.Point(0, 45);
            this.tl_Module.Name = "tl_Module";
            this.tl_Module.Size = new System.Drawing.Size(1103, 592);
            this.tl_Module.TabIndex = 1;
            this.tl_Module.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tl_Module_FocusedNodeChanged);
            // 
            // colC_ID
            // 
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            this.colC_ID.Width = 100;
            // 
            // colC_PARENT_ID
            // 
            this.colC_PARENT_ID.FieldName = "C_PARENT_ID";
            this.colC_PARENT_ID.Name = "colC_PARENT_ID";
            this.colC_PARENT_ID.Width = 82;
            // 
            // colC_NAME
            // 
            this.colC_NAME.Caption = "部门列表";
            this.colC_NAME.FieldName = "C_NAME";
            this.colC_NAME.MinWidth = 34;
            this.colC_NAME.Name = "colC_NAME";
            this.colC_NAME.OptionsColumn.AllowEdit = false;
            this.colC_NAME.Visible = true;
            this.colC_NAME.VisibleIndex = 0;
            this.colC_NAME.Width = 82;
            // 
            // bscTsDept
            // 
            this.bscTsDept.DataSource = typeof(RV.MODEL.ModTS_DEPT);
            // 
            // FrmSetDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 637);
            this.Controls.Add(this.tl_Module);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmSetDept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置部门";
            this.Load += new System.EventHandler(this.FrmSetDept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tl_Module)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscTsDept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList tl_Module;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_PARENT_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_NAME;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private System.Windows.Forms.BindingSource bscTsDept;
    }
}