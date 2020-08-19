namespace RV.UI
{
    partial class FrmRight
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
            this.bscTSMODULE = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.tl_Module = new DevExpress.XtraTreeList.TreeList();
            this.colC_MODULEID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_PARENTMODULEID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_MODULENAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bscTSMODULE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tl_Module)).BeginInit();
            this.SuspendLayout();
            // 
            // bscTSMODULE
            // 
            this.bscTSMODULE.DataSource = typeof(RV.MODEL.ModTS_MODULE);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Zoom;Size16x16";
            this.simpleButton1.Location = new System.Drawing.Point(12, 9);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 28);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1103, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(118, 9);
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
            this.colC_MODULEID,
            this.colC_PARENTMODULEID,
            this.colC_MODULENAME});
            this.tl_Module.Cursor = System.Windows.Forms.Cursors.Default;
            this.tl_Module.DataSource = this.bscTSMODULE;
            this.tl_Module.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_Module.ImageIndexFieldName = "N_IMAGEINDEX";
            this.tl_Module.Location = new System.Drawing.Point(0, 45);
            this.tl_Module.Name = "tl_Module";
            this.tl_Module.OptionsBehavior.PopulateServiceColumns = true;
            this.tl_Module.OptionsView.ShowCheckBoxes = true;
            this.tl_Module.Size = new System.Drawing.Size(1103, 592);
            this.tl_Module.TabIndex = 1;
            this.tl_Module.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.tl_Module_BeforeCheckNode);
            this.tl_Module.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tl_Module_AfterCheckNode);
            // 
            // colC_MODULEID
            // 
            this.colC_MODULEID.FieldName = "C_MODULEID";
            this.colC_MODULEID.Name = "colC_MODULEID";
            this.colC_MODULEID.Width = 100;
            // 
            // colC_PARENTMODULEID
            // 
            this.colC_PARENTMODULEID.FieldName = "C_PARENTMODULEID";
            this.colC_PARENTMODULEID.Name = "colC_PARENTMODULEID";
            this.colC_PARENTMODULEID.Width = 82;
            // 
            // colC_MODULENAME
            // 
            this.colC_MODULENAME.Caption = "功能列表";
            this.colC_MODULENAME.FieldName = "C_MODULENAME";
            this.colC_MODULENAME.MinWidth = 34;
            this.colC_MODULENAME.Name = "colC_MODULENAME";
            this.colC_MODULENAME.OptionsColumn.AllowEdit = false;
            this.colC_MODULENAME.Visible = true;
            this.colC_MODULENAME.VisibleIndex = 0;
            this.colC_MODULENAME.Width = 82;
            // 
            // FrmRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 637);
            this.Controls.Add(this.tl_Module);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmRight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "权限分配";
            this.Load += new System.EventHandler(this.FrmRight_Load);
            this.Shown += new System.EventHandler(this.FrmRight_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bscTSMODULE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tl_Module)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bscTSMODULE;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList tl_Module;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_MODULEID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_PARENTMODULEID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_MODULENAME;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
    }
}