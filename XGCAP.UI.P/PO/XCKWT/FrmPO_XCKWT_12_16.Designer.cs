namespace XGCAP.UI.P.PO.XCKWT
{
    partial class FrmPO_XCKWT_12_16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPO_XCKWT_12_16));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Query_Main = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gc_SJXX = new DevExpress.XtraGrid.GridControl();
            this.gv_SJXX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_STOVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_BATCH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_TICK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.N_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SHIFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_GROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.D_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_STL_GRD_BEFORE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_STD_CODE_BEFORE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_CODE_BEFORE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_DESC_BEFORE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SJXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SJXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            this.lblTitle.Appearance.Options.UseTextOptions = true;
            this.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1479, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "     天车";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Query_Main);
            this.panelControl1.Controls.Add(this.txt_BatchNo);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(513, 37);
            this.panelControl1.TabIndex = 49;
            // 
            // btn_Query_Main
            // 
            this.btn_Query_Main.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query_Main.Location = new System.Drawing.Point(181, 7);
            this.btn_Query_Main.Name = "btn_Query_Main";
            this.btn_Query_Main.Size = new System.Drawing.Size(75, 23);
            this.btn_Query_Main.TabIndex = 20;
            this.btn_Query_Main.Text = "查询";
            this.btn_Query_Main.Click += new System.EventHandler(this.btn_Query_Main_Click_1);
            // 
            // txt_BatchNo
            // 
            this.txt_BatchNo.Location = new System.Drawing.Point(42, 8);
            this.txt_BatchNo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BatchNo.Name = "txt_BatchNo";
            this.txt_BatchNo.Size = new System.Drawing.Size(128, 20);
            this.txt_BatchNo.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(14, 11);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "批号";
            // 
            // gc_SJXX
            // 
            this.gc_SJXX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SJXX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_SJXX.Location = new System.Drawing.Point(0, 37);
            this.gc_SJXX.MainView = this.gv_SJXX;
            this.gc_SJXX.Margin = new System.Windows.Forms.Padding(2);
            this.gc_SJXX.Name = "gc_SJXX";
            this.gc_SJXX.Size = new System.Drawing.Size(513, 602);
            this.gc_SJXX.TabIndex = 50;
            this.gc_SJXX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SJXX,
            this.gridView1});
            // 
            // gv_SJXX
            // 
            this.gv_SJXX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_STOVE,
            this.colC_BATCH_NO,
            this.C_TICK_NO,
            this.C_STL_GRD,
            this.N_WGT,
            this.colC_STD_CODE,
            this.colC_SPEC,
            this.colC_SHIFT,
            this.colC_GROUP,
            this.D_MOD_DT,
            this.C_STL_GRD_BEFORE,
            this.C_STD_CODE_BEFORE,
            this.C_MAT_CODE,
            this.C_MAT_CODE_BEFORE,
            this.C_MAT_DESC,
            this.C_MAT_DESC_BEFORE});
            this.gv_SJXX.GridControl = this.gc_SJXX;
            this.gv_SJXX.Name = "gv_SJXX";
            this.gv_SJXX.OptionsBehavior.Editable = false;
            this.gv_SJXX.OptionsView.ColumnAutoWidth = false;
            this.gv_SJXX.OptionsView.ShowGroupPanel = false;
            // 
            // colC_STOVE
            // 
            this.colC_STOVE.Caption = "炉号";
            this.colC_STOVE.FieldName = "C_STOVE";
            this.colC_STOVE.Name = "colC_STOVE";
            this.colC_STOVE.Visible = true;
            this.colC_STOVE.VisibleIndex = 0;
            // 
            // colC_BATCH_NO
            // 
            this.colC_BATCH_NO.Caption = "批号";
            this.colC_BATCH_NO.FieldName = "C_BATCH_NO";
            this.colC_BATCH_NO.Name = "colC_BATCH_NO";
            this.colC_BATCH_NO.Visible = true;
            this.colC_BATCH_NO.VisibleIndex = 1;
            // 
            // C_TICK_NO
            // 
            this.C_TICK_NO.Caption = "钩号";
            this.C_TICK_NO.FieldName = "C_TICK_NO";
            this.C_TICK_NO.Name = "C_TICK_NO";
            this.C_TICK_NO.Visible = true;
            this.C_TICK_NO.VisibleIndex = 2;
            // 
            // C_STL_GRD
            // 
            this.C_STL_GRD.Caption = "钢种";
            this.C_STL_GRD.FieldName = "C_STL_GRD";
            this.C_STL_GRD.Name = "C_STL_GRD";
            this.C_STL_GRD.Visible = true;
            this.C_STL_GRD.VisibleIndex = 3;
            // 
            // N_WGT
            // 
            this.N_WGT.Caption = "重量";
            this.N_WGT.FieldName = "N_WGT";
            this.N_WGT.Name = "N_WGT";
            this.N_WGT.Visible = true;
            this.N_WGT.VisibleIndex = 12;
            // 
            // colC_STD_CODE
            // 
            this.colC_STD_CODE.Caption = "执行标准";
            this.colC_STD_CODE.FieldName = "C_STD_CODE";
            this.colC_STD_CODE.Name = "colC_STD_CODE";
            this.colC_STD_CODE.Visible = true;
            this.colC_STD_CODE.VisibleIndex = 5;
            // 
            // colC_SPEC
            // 
            this.colC_SPEC.Caption = "规格";
            this.colC_SPEC.FieldName = "C_SPEC";
            this.colC_SPEC.Name = "colC_SPEC";
            this.colC_SPEC.Visible = true;
            this.colC_SPEC.VisibleIndex = 11;
            // 
            // colC_SHIFT
            // 
            this.colC_SHIFT.Caption = "班次";
            this.colC_SHIFT.FieldName = "C_SHIFT";
            this.colC_SHIFT.Name = "colC_SHIFT";
            this.colC_SHIFT.Visible = true;
            this.colC_SHIFT.VisibleIndex = 13;
            // 
            // colC_GROUP
            // 
            this.colC_GROUP.Caption = "班组";
            this.colC_GROUP.FieldName = "C_GROUP";
            this.colC_GROUP.Name = "colC_GROUP";
            this.colC_GROUP.Visible = true;
            this.colC_GROUP.VisibleIndex = 14;
            // 
            // D_MOD_DT
            // 
            this.D_MOD_DT.Caption = "生产时间";
            this.D_MOD_DT.FieldName = "D_MOD_DT";
            this.D_MOD_DT.Name = "D_MOD_DT";
            this.D_MOD_DT.Visible = true;
            this.D_MOD_DT.VisibleIndex = 15;
            // 
            // C_STL_GRD_BEFORE
            // 
            this.C_STL_GRD_BEFORE.Caption = "改判前钢种";
            this.C_STL_GRD_BEFORE.FieldName = "C_STL_GRD_BEFORE";
            this.C_STL_GRD_BEFORE.Name = "C_STL_GRD_BEFORE";
            this.C_STL_GRD_BEFORE.Visible = true;
            this.C_STL_GRD_BEFORE.VisibleIndex = 4;
            // 
            // C_STD_CODE_BEFORE
            // 
            this.C_STD_CODE_BEFORE.Caption = "改判前标准";
            this.C_STD_CODE_BEFORE.FieldName = "C_STD_CODE_BEFORE";
            this.C_STD_CODE_BEFORE.Name = "C_STD_CODE_BEFORE";
            this.C_STD_CODE_BEFORE.Visible = true;
            this.C_STD_CODE_BEFORE.VisibleIndex = 6;
            // 
            // C_MAT_CODE
            // 
            this.C_MAT_CODE.Caption = "物料编码";
            this.C_MAT_CODE.FieldName = "C_MAT_CODE";
            this.C_MAT_CODE.Name = "C_MAT_CODE";
            this.C_MAT_CODE.Visible = true;
            this.C_MAT_CODE.VisibleIndex = 7;
            // 
            // C_MAT_CODE_BEFORE
            // 
            this.C_MAT_CODE_BEFORE.Caption = "改判前物料编码";
            this.C_MAT_CODE_BEFORE.FieldName = "C_MAT_CODE_BEFORE";
            this.C_MAT_CODE_BEFORE.Name = "C_MAT_CODE_BEFORE";
            this.C_MAT_CODE_BEFORE.Visible = true;
            this.C_MAT_CODE_BEFORE.VisibleIndex = 8;
            // 
            // C_MAT_DESC
            // 
            this.C_MAT_DESC.Caption = "物料描述";
            this.C_MAT_DESC.FieldName = "C_MAT_DESC";
            this.C_MAT_DESC.Name = "C_MAT_DESC";
            this.C_MAT_DESC.Visible = true;
            this.C_MAT_DESC.VisibleIndex = 9;
            // 
            // C_MAT_DESC_BEFORE
            // 
            this.C_MAT_DESC_BEFORE.Caption = "改判前物料描述";
            this.C_MAT_DESC_BEFORE.FieldName = "C_MAT_DESC_BEFORE";
            this.C_MAT_DESC_BEFORE.Name = "C_MAT_DESC_BEFORE";
            this.C_MAT_DESC_BEFORE.Visible = true;
            this.C_MAT_DESC_BEFORE.VisibleIndex = 10;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_SJXX;
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gc_SJXX);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(966, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 639);
            this.panel1.TabIndex = 2;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl1.Location = new System.Drawing.Point(961, 26);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 639);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.Controls.Add(this.pnlMain, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 639);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.labelControl3);
            this.pnlMain.Controls.Add(this.labelControl2);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.labelControl1);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.labelControl17);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(31, 22);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(897, 594);
            this.pnlMain.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.AccessibleDescription = "76,99";
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(715, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl3.Size = new System.Drawing.Size(116, 235);
            this.labelControl3.TabIndex = 60147;
            this.labelControl3.Text = "99\r\n\r\n至\r\n\r\n76";
            // 
            // labelControl2
            // 
            this.labelControl2.AccessibleDescription = "51,75";
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(507, 129);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl2.Size = new System.Drawing.Size(116, 235);
            this.labelControl2.TabIndex = 60146;
            this.labelControl2.Text = "75\r\n\r\n至\r\n\r\n51";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 23);
            this.label5.TabIndex = 60145;
            this.label5.Text = "东";
            // 
            // labelControl1
            // 
            this.labelControl1.AccessibleDescription = "26,50";
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(304, 129);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(116, 235);
            this.labelControl1.TabIndex = 60144;
            this.labelControl1.Text = "50\r\n\r\n至\r\n\r\n26";
            this.labelControl1.Click += new System.EventHandler(this.lab_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(46, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 60143;
            this.label4.Text = "612/16区";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(178, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 60140;
            this.label3.Text = "货位：99  零星材";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(387, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 60142;
            this.label2.Text = "北";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(391, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 60141;
            this.label1.Text = "南";
            // 
            // labelControl17
            // 
            this.labelControl17.AccessibleDescription = "1,25";
            this.labelControl17.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl17.Appearance.Options.UseBackColor = true;
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Appearance.Options.UseTextOptions = true;
            this.labelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl17.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl17.Location = new System.Drawing.Point(94, 129);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl17.Size = new System.Drawing.Size(116, 235);
            this.labelControl17.TabIndex = 60101;
            this.labelControl17.Text = "25\r\n\r\n至\r\n\r\n1";
            this.labelControl17.Click += new System.EventHandler(this.lab_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageIndex = 8;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 21);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.ToolTip = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmPO_XCKWT_12_16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmPO_XCKWT_12_16";
            this.Text = "线材库位图";
            this.Load += new System.EventHandler(this.FrmPO_XCKWT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SJXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SJXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Query_Main;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gc_SJXX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SJXX;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STOVE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_BATCH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn C_TICK_NO;
        private DevExpress.XtraGrid.Columns.GridColumn C_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn N_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SHIFT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_GROUP;
        private DevExpress.XtraGrid.Columns.GridColumn D_MOD_DT;
        private DevExpress.XtraGrid.Columns.GridColumn C_STL_GRD_BEFORE;
        private DevExpress.XtraGrid.Columns.GridColumn C_STD_CODE_BEFORE;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_CODE_BEFORE;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_DESC_BEFORE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlMain;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}