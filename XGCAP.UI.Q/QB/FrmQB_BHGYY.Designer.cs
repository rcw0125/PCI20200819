namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_BHGYY
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Type = new DevExpress.XtraEditors.TextEdit();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gc_BHGLX = new DevExpress.XtraGrid.GridControl();
            this.gv_BHGLX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_REASON_TYPE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REASON_TYPE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_BHGMC = new DevExpress.XtraGrid.GridControl();
            this.gv_BHGMC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_REASON_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REASON_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.btn_NameAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btn_NameStop = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_BHGLX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BHGLX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_BHGMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BHGMC)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.labelControl3);
            this.flowLayoutPanel1.Controls.Add(this.txt_Type);
            this.flowLayoutPanel1.Controls.Add(this.btn_Add);
            this.flowLayoutPanel1.Controls.Add(this.btn_Stop);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1002, 34);
            this.flowLayoutPanel1.TabIndex = 43;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "原因类型";
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(61, 6);
            this.txt_Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(100, 20);
            this.txt_Type.TabIndex = 20;
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(167, 4);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 21;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(248, 4);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 44;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_BHGLX);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(485, 463);
            this.panelControl1.TabIndex = 44;
            // 
            // gc_BHGLX
            // 
            this.gc_BHGLX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_BHGLX.Location = new System.Drawing.Point(2, 2);
            this.gc_BHGLX.MainView = this.gv_BHGLX;
            this.gc_BHGLX.Name = "gc_BHGLX";
            this.gc_BHGLX.Size = new System.Drawing.Size(481, 459);
            this.gc_BHGLX.TabIndex = 45;
            this.gc_BHGLX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_BHGLX});
            // 
            // gv_BHGLX
            // 
            this.gv_BHGLX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_REASON_TYPE_CODE,
            this.colC_REASON_TYPE_NAME,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_BHGLX.GridControl = this.gc_BHGLX;
            this.gv_BHGLX.Name = "gv_BHGLX";
            this.gv_BHGLX.OptionsBehavior.Editable = false;
            this.gv_BHGLX.OptionsView.ColumnAutoWidth = false;
            this.gv_BHGLX.OptionsView.ShowGroupPanel = false;
            this.gv_BHGLX.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_BHGLX_FocusedRowChanged);
            // 
            // colC_REASON_TYPE_CODE
            // 
            this.colC_REASON_TYPE_CODE.Caption = "不合格原因类型";
            this.colC_REASON_TYPE_CODE.FieldName = "C_REASON_TYPE_CODE";
            this.colC_REASON_TYPE_CODE.Name = "colC_REASON_TYPE_CODE";
            this.colC_REASON_TYPE_CODE.Width = 93;
            // 
            // colC_REASON_TYPE_NAME
            // 
            this.colC_REASON_TYPE_NAME.Caption = "不合格原因名称";
            this.colC_REASON_TYPE_NAME.FieldName = "C_REASON_TYPE_NAME";
            this.colC_REASON_TYPE_NAME.Name = "colC_REASON_TYPE_NAME";
            this.colC_REASON_TYPE_NAME.Visible = true;
            this.colC_REASON_TYPE_NAME.VisibleIndex = 0;
            this.colC_REASON_TYPE_NAME.Width = 109;
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.Caption = "使用状态";
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.Caption = "备注";
            this.colC_REMARK.FieldName = "C_REMARK";
            this.colC_REMARK.Name = "colC_REMARK";
            this.colC_REMARK.Visible = true;
            this.colC_REMARK.VisibleIndex = 1;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人员";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 2;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "操作时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 3;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(485, 34);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 463);
            this.splitterControl1.TabIndex = 45;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_BHGMC);
            this.panelControl2.Controls.Add(this.flowLayoutPanel2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(490, 34);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(512, 463);
            this.panelControl2.TabIndex = 46;
            // 
            // gc_BHGMC
            // 
            this.gc_BHGMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_BHGMC.Location = new System.Drawing.Point(2, 39);
            this.gc_BHGMC.MainView = this.gv_BHGMC;
            this.gc_BHGMC.Name = "gc_BHGMC";
            this.gc_BHGMC.Size = new System.Drawing.Size(508, 422);
            this.gc_BHGMC.TabIndex = 46;
            this.gc_BHGMC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_BHGMC});
            // 
            // gv_BHGMC
            // 
            this.gv_BHGMC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_REASON_NAME,
            this.colC_REASON_CODE,
            this.colN_STATUS1,
            this.colC_REMARK1,
            this.colC_EMP_ID1,
            this.colD_MOD_DT1});
            this.gv_BHGMC.GridControl = this.gc_BHGMC;
            this.gv_BHGMC.Name = "gv_BHGMC";
            this.gv_BHGMC.OptionsBehavior.Editable = false;
            this.gv_BHGMC.OptionsView.ColumnAutoWidth = false;
            this.gv_BHGMC.OptionsView.ShowGroupPanel = false;
            // 
            // colC_REASON_NAME
            // 
            this.colC_REASON_NAME.Caption = "不合格原因名称";
            this.colC_REASON_NAME.FieldName = "C_REASON_NAME";
            this.colC_REASON_NAME.Name = "colC_REASON_NAME";
            this.colC_REASON_NAME.Visible = true;
            this.colC_REASON_NAME.VisibleIndex = 0;
            this.colC_REASON_NAME.Width = 125;
            // 
            // colC_REASON_CODE
            // 
            this.colC_REASON_CODE.Caption = "不合格原因代码";
            this.colC_REASON_CODE.FieldName = "C_REASON_CODE";
            this.colC_REASON_CODE.Name = "colC_REASON_CODE";
            // 
            // colN_STATUS1
            // 
            this.colN_STATUS1.Caption = "使用状态";
            this.colN_STATUS1.FieldName = "N_STATUS";
            this.colN_STATUS1.Name = "colN_STATUS1";
            // 
            // colC_REMARK1
            // 
            this.colC_REMARK1.Caption = "备注";
            this.colC_REMARK1.FieldName = "C_REMARK";
            this.colC_REMARK1.Name = "colC_REMARK1";
            this.colC_REMARK1.Visible = true;
            this.colC_REMARK1.VisibleIndex = 1;
            // 
            // colC_EMP_ID1
            // 
            this.colC_EMP_ID1.Caption = "操作人员";
            this.colC_EMP_ID1.FieldName = "C_EMP_ID";
            this.colC_EMP_ID1.Name = "colC_EMP_ID1";
            this.colC_EMP_ID1.Visible = true;
            this.colC_EMP_ID1.VisibleIndex = 2;
            // 
            // colD_MOD_DT1
            // 
            this.colD_MOD_DT1.Caption = "操作时间";
            this.colD_MOD_DT1.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT1.FieldName = "D_MOD_DT";
            this.colD_MOD_DT1.Name = "colD_MOD_DT1";
            this.colD_MOD_DT1.Visible = true;
            this.colD_MOD_DT1.VisibleIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.labelControl1);
            this.flowLayoutPanel2.Controls.Add(this.txt_Name);
            this.flowLayoutPanel2.Controls.Add(this.btn_NameAdd);
            this.flowLayoutPanel2.Controls.Add(this.btn_NameStop);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(508, 37);
            this.flowLayoutPanel2.TabIndex = 44;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "原因名称";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(61, 6);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 20;
            // 
            // btn_NameAdd
            // 
            this.btn_NameAdd.ImageUri.Uri = "Add;Size16x16";
            this.btn_NameAdd.Location = new System.Drawing.Point(167, 7);
            this.btn_NameAdd.Name = "btn_NameAdd";
            this.btn_NameAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_NameAdd.TabIndex = 21;
            this.btn_NameAdd.Text = "添加";
            this.btn_NameAdd.Click += new System.EventHandler(this.btn_NameAdd_Click);
            // 
            // btn_NameStop
            // 
            this.btn_NameStop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_NameStop.Location = new System.Drawing.Point(248, 7);
            this.btn_NameStop.Name = "btn_NameStop";
            this.btn_NameStop.Size = new System.Drawing.Size(75, 23);
            this.btn_NameStop.TabIndex = 44;
            this.btn_NameStop.Text = "停用";
            this.btn_NameStop.Click += new System.EventHandler(this.btn_NameStop_Click);
            // 
            // FrmQB_BHGYY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 497);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmQB_BHGYY";
            this.Text = "不合格原因维护";
            this.Load += new System.EventHandler(this.FrmQB0801_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_BHGLX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BHGLX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_BHGMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BHGMC)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Type;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_BHGLX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_BHGLX;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gc_BHGMC;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_BHGMC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.SimpleButton btn_NameAdd;
        private DevExpress.XtraEditors.SimpleButton btn_NameStop;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_TYPE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_TYPE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT1;
    }
}