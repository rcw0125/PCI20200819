namespace XGCAP.UI.Q.QR
{
    partial class FrmQR_ANQX
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
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gc_ANXX = new DevExpress.XtraGrid.GridControl();
            this.modTSMODULEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv_ANXX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_MODULEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_PARENTMODULEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MODULENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_ASSEMBLYNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MODULECLASS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_DISABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_IMAGEINDEX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MODULE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_QUERY_STR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lab_Name = new DevExpress.XtraEditors.LabelControl();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Saves = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ANXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modTSMODULEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ANXX)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(243, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 450);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gc_ANXX);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(248, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 450);
            this.panel3.TabIndex = 4;
            // 
            // gc_ANXX
            // 
            this.gc_ANXX.DataSource = this.modTSMODULEBindingSource;
            this.gc_ANXX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ANXX.Location = new System.Drawing.Point(0, 38);
            this.gc_ANXX.MainView = this.gv_ANXX;
            this.gc_ANXX.Name = "gc_ANXX";
            this.gc_ANXX.Size = new System.Drawing.Size(552, 412);
            this.gc_ANXX.TabIndex = 4;
            this.gc_ANXX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ANXX});
            // 
            // modTSMODULEBindingSource
            // 
            this.modTSMODULEBindingSource.DataSource = typeof(MODEL.Mod_TS_MODULE);
            // 
            // gv_ANXX
            // 
            this.gv_ANXX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_MODULEID,
            this.colC_PARENTMODULEID,
            this.colC_MODULENAME,
            this.colC_ASSEMBLYNAME,
            this.colC_MODULECLASS,
            this.colC_DISABLE,
            this.colN_IMAGEINDEX,
            this.colC_MODULE_TYPE,
            this.colC_QUERY_STR,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT,
            this.gridColumn1});
            this.gv_ANXX.GridControl = this.gc_ANXX;
            this.gv_ANXX.Name = "gv_ANXX";
            this.gv_ANXX.OptionsView.ShowGroupPanel = false;
            // 
            // colC_MODULEID
            // 
            this.colC_MODULEID.Caption = "模块编码";
            this.colC_MODULEID.FieldName = "C_MODULEID";
            this.colC_MODULEID.Name = "colC_MODULEID";
            this.colC_MODULEID.OptionsColumn.AllowEdit = false;
            this.colC_MODULEID.Visible = true;
            this.colC_MODULEID.VisibleIndex = 0;
            // 
            // colC_PARENTMODULEID
            // 
            this.colC_PARENTMODULEID.Caption = "父模块编码";
            this.colC_PARENTMODULEID.FieldName = "C_PARENTMODULEID";
            this.colC_PARENTMODULEID.Name = "colC_PARENTMODULEID";
            this.colC_PARENTMODULEID.OptionsColumn.AllowEdit = false;
            this.colC_PARENTMODULEID.Visible = true;
            this.colC_PARENTMODULEID.VisibleIndex = 1;
            // 
            // colC_MODULENAME
            // 
            this.colC_MODULENAME.Caption = "按钮名称";
            this.colC_MODULENAME.FieldName = "C_MODULENAME";
            this.colC_MODULENAME.Name = "colC_MODULENAME";
            this.colC_MODULENAME.Visible = true;
            this.colC_MODULENAME.VisibleIndex = 2;
            // 
            // colC_ASSEMBLYNAME
            // 
            this.colC_ASSEMBLYNAME.Caption = "装配件";
            this.colC_ASSEMBLYNAME.FieldName = "C_ASSEMBLYNAME";
            this.colC_ASSEMBLYNAME.Name = "colC_ASSEMBLYNAME";
            // 
            // colC_MODULECLASS
            // 
            this.colC_MODULECLASS.Caption = "按钮ID";
            this.colC_MODULECLASS.FieldName = "C_MODULECLASS";
            this.colC_MODULECLASS.Name = "colC_MODULECLASS";
            this.colC_MODULECLASS.Visible = true;
            this.colC_MODULECLASS.VisibleIndex = 3;
            // 
            // colC_DISABLE
            // 
            this.colC_DISABLE.Caption = "是否禁用";
            this.colC_DISABLE.FieldName = "C_DISABLE";
            this.colC_DISABLE.Name = "colC_DISABLE";
            // 
            // colN_IMAGEINDEX
            // 
            this.colN_IMAGEINDEX.Caption = "图片索引";
            this.colN_IMAGEINDEX.FieldName = "N_IMAGEINDEX";
            this.colN_IMAGEINDEX.Name = "colN_IMAGEINDEX";
            // 
            // colC_MODULE_TYPE
            // 
            this.colC_MODULE_TYPE.Caption = "模块类型";
            this.colC_MODULE_TYPE.FieldName = "C_MODULE_TYPE";
            this.colC_MODULE_TYPE.Name = "colC_MODULE_TYPE";
            // 
            // colC_QUERY_STR
            // 
            this.colC_QUERY_STR.Caption = "注入参数";
            this.colC_QUERY_STR.FieldName = "C_QUERY_STR";
            this.colC_QUERY_STR.Name = "colC_QUERY_STR";
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.Caption = "备注";
            this.colC_REMARK.FieldName = "C_REMARK";
            this.colC_REMARK.Name = "colC_REMARK";
            this.colC_REMARK.Visible = true;
            this.colC_REMARK.VisibleIndex = 5;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "维护人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.OptionsColumn.AllowEdit = false;
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 6;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "维护时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.OptionsColumn.AllowEdit = false;
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "顺序";
            this.gridColumn1.FieldName = "N_ORDER";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lab_Name);
            this.panel4.Controls.Add(this.btn_Del);
            this.panel4.Controls.Add(this.btn_Add);
            this.panel4.Controls.Add(this.btn_Saves);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(552, 38);
            this.panel4.TabIndex = 3;
            // 
            // lab_Name
            // 
            this.lab_Name.Location = new System.Drawing.Point(270, 14);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(0, 14);
            this.lab_Name.TabIndex = 132;
            // 
            // btn_Del
            // 
            this.btn_Del.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Del.Location = new System.Drawing.Point(87, 6);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 26);
            this.btn_Del.TabIndex = 131;
            this.btn_Del.Text = "删除";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(6, 6);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 26);
            this.btn_Add.TabIndex = 128;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Saves
            // 
            this.btn_Saves.ImageUri.Uri = "Save;Size16x16";
            this.btn_Saves.Location = new System.Drawing.Point(168, 6);
            this.btn_Saves.Name = "btn_Saves";
            this.btn_Saves.Size = new System.Drawing.Size(75, 26);
            this.btn_Saves.TabIndex = 130;
            this.btn_Saves.Text = "保存";
            this.btn_Saves.Click += new System.EventHandler(this.btn_Saves_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Controls.Add(this.panelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 450);
            this.panel2.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Indent = 19;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(243, 426);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(243, 24);
            this.panelControl1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "业务导航";
            // 
            // FrmQR_ANQX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmQR_ANQX";
            this.Text = "按钮权限";
            this.Load += new System.EventHandler(this.FrmQR_ANQX_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ANXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modTSMODULEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ANXX)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gc_ANXX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ANXX;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Saves;
        private System.Windows.Forms.BindingSource modTSMODULEBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MODULEID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_PARENTMODULEID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MODULENAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ASSEMBLYNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MODULECLASS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_DISABLE;
        private DevExpress.XtraGrid.Columns.GridColumn colN_IMAGEINDEX;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MODULE_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_QUERY_STR;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private DevExpress.XtraEditors.LabelControl lab_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}