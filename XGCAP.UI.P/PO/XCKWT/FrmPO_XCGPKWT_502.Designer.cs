﻿namespace XGCAP.UI.P.PO.XCKWT
{
    partial class FrmPO_XCGPKWT_502
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPO_XCGPKWT_502));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gc_GPSJ = new DevExpress.XtraGrid.GridControl();
            this.gv_GPSJ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.C_STA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STOVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_LEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.N_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MAT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MAT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.D_WE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Stove = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).BeginInit();
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
            this.lblTitle.Text = "    线材一车间合格钢坯库";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gc_GPSJ);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(977, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 639);
            this.panel1.TabIndex = 2;
            // 
            // gc_GPSJ
            // 
            this.gc_GPSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GPSJ.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_GPSJ.Location = new System.Drawing.Point(0, 41);
            this.gc_GPSJ.MainView = this.gv_GPSJ;
            this.gc_GPSJ.Margin = new System.Windows.Forms.Padding(2);
            this.gc_GPSJ.Name = "gc_GPSJ";
            this.gc_GPSJ.Size = new System.Drawing.Size(502, 598);
            this.gc_GPSJ.TabIndex = 10;
            this.gc_GPSJ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GPSJ});
            // 
            // gv_GPSJ
            // 
            this.gv_GPSJ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.C_STA_ID,
            this.colC_STOVE,
            this.colC_STL_GRD,
            this.colC_SPEC,
            this.colN_LEN,
            this.N_WGT,
            this.colC_STD_CODE,
            this.colC_MAT_CODE,
            this.colC_MAT_NAME,
            this.D_WE_DATE,
            this.COU});
            this.gv_GPSJ.GridControl = this.gc_GPSJ;
            this.gv_GPSJ.Name = "gv_GPSJ";
            this.gv_GPSJ.OptionsBehavior.Editable = false;
            this.gv_GPSJ.OptionsView.ColumnAutoWidth = false;
            this.gv_GPSJ.OptionsView.ShowGroupPanel = false;
            // 
            // C_STA_ID
            // 
            this.C_STA_ID.Caption = "铸机号";
            this.C_STA_ID.FieldName = "C_STA_ID";
            this.C_STA_ID.Name = "C_STA_ID";
            this.C_STA_ID.Visible = true;
            this.C_STA_ID.VisibleIndex = 0;
            // 
            // colC_STOVE
            // 
            this.colC_STOVE.Caption = "炉号";
            this.colC_STOVE.FieldName = "C_STOVE";
            this.colC_STOVE.Name = "colC_STOVE";
            this.colC_STOVE.Visible = true;
            this.colC_STOVE.VisibleIndex = 1;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 2;
            // 
            // colC_SPEC
            // 
            this.colC_SPEC.Caption = "断面";
            this.colC_SPEC.FieldName = "C_SPEC";
            this.colC_SPEC.Name = "colC_SPEC";
            this.colC_SPEC.Visible = true;
            this.colC_SPEC.VisibleIndex = 3;
            // 
            // colN_LEN
            // 
            this.colN_LEN.Caption = "定尺";
            this.colN_LEN.FieldName = "N_LEN";
            this.colN_LEN.Name = "colN_LEN";
            this.colN_LEN.Visible = true;
            this.colN_LEN.VisibleIndex = 4;
            // 
            // N_WGT
            // 
            this.N_WGT.Caption = "重量";
            this.N_WGT.FieldName = "N_WGT";
            this.N_WGT.Name = "N_WGT";
            this.N_WGT.Visible = true;
            this.N_WGT.VisibleIndex = 5;
            // 
            // colC_STD_CODE
            // 
            this.colC_STD_CODE.Caption = "执行标准";
            this.colC_STD_CODE.FieldName = "C_STD_CODE";
            this.colC_STD_CODE.Name = "colC_STD_CODE";
            this.colC_STD_CODE.Visible = true;
            this.colC_STD_CODE.VisibleIndex = 6;
            // 
            // colC_MAT_CODE
            // 
            this.colC_MAT_CODE.Caption = "物料编码";
            this.colC_MAT_CODE.FieldName = "C_MAT_CODE";
            this.colC_MAT_CODE.Name = "colC_MAT_CODE";
            this.colC_MAT_CODE.Visible = true;
            this.colC_MAT_CODE.VisibleIndex = 7;
            // 
            // colC_MAT_NAME
            // 
            this.colC_MAT_NAME.Caption = "物料描述";
            this.colC_MAT_NAME.FieldName = "C_MAT_NAME";
            this.colC_MAT_NAME.Name = "colC_MAT_NAME";
            this.colC_MAT_NAME.Visible = true;
            this.colC_MAT_NAME.VisibleIndex = 8;
            // 
            // D_WE_DATE
            // 
            this.D_WE_DATE.Caption = "入库时间";
            this.D_WE_DATE.FieldName = "D_WE_DATE";
            this.D_WE_DATE.Name = "D_WE_DATE";
            this.D_WE_DATE.Visible = true;
            this.D_WE_DATE.VisibleIndex = 9;
            // 
            // COU
            // 
            this.COU.Caption = "支数";
            this.COU.FieldName = "COU";
            this.COU.Name = "COU";
            this.COU.Visible = true;
            this.COU.VisibleIndex = 10;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Query);
            this.panelControl1.Controls.Add(this.txt_Stove);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(502, 41);
            this.panelControl1.TabIndex = 9;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(175, 10);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 52;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click_1);
            // 
            // txt_Stove
            // 
            this.txt_Stove.Location = new System.Drawing.Point(42, 11);
            this.txt_Stove.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Stove.Name = "txt_Stove";
            this.txt_Stove.Size = new System.Drawing.Size(128, 20);
            this.txt_Stove.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(14, 14);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "炉号";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl1.Location = new System.Drawing.Point(972, 26);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 639);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.labelControl7);
            this.pnlMain.Controls.Add(this.labelControl8);
            this.pnlMain.Controls.Add(this.labelControl5);
            this.pnlMain.Controls.Add(this.labelControl4);
            this.pnlMain.Controls.Add(this.labelControl36);
            this.pnlMain.Controls.Add(this.labelControl31);
            this.pnlMain.Controls.Add(this.labelControl32);
            this.pnlMain.Controls.Add(this.labelControl33);
            this.pnlMain.Controls.Add(this.labelControl25);
            this.pnlMain.Controls.Add(this.labelControl26);
            this.pnlMain.Controls.Add(this.labelControl27);
            this.pnlMain.Controls.Add(this.labelControl28);
            this.pnlMain.Controls.Add(this.labelControl29);
            this.pnlMain.Controls.Add(this.labelControl24);
            this.pnlMain.Controls.Add(this.labelControl23);
            this.pnlMain.Controls.Add(this.labelControl13);
            this.pnlMain.Controls.Add(this.labelControl17);
            this.pnlMain.Controls.Add(this.labelControl18);
            this.pnlMain.Controls.Add(this.labelControl22);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(32, 22);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(907, 594);
            this.pnlMain.TabIndex = 0;
            // 
            // labelControl36
            // 
            this.labelControl36.AccessibleDescription = "5020105";
            this.labelControl36.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl36.Appearance.Options.UseBackColor = true;
            this.labelControl36.Appearance.Options.UseTextOptions = true;
            this.labelControl36.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl36.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl36.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl36.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl36.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl36.Location = new System.Drawing.Point(83, 300);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl36.Size = new System.Drawing.Size(92, 45);
            this.labelControl36.TabIndex = 60348;
            this.labelControl36.Text = "5020105";
            this.labelControl36.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl31
            // 
            this.labelControl31.AccessibleDescription = "5020401";
            this.labelControl31.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl31.Appearance.Options.UseBackColor = true;
            this.labelControl31.Appearance.Options.UseTextOptions = true;
            this.labelControl31.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl31.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl31.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl31.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl31.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl31.Location = new System.Drawing.Point(440, 92);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl31.Size = new System.Drawing.Size(92, 45);
            this.labelControl31.TabIndex = 60345;
            this.labelControl31.Text = "5020401";
            this.labelControl31.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl32
            // 
            this.labelControl32.AccessibleDescription = "5020301";
            this.labelControl32.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl32.Appearance.Options.UseBackColor = true;
            this.labelControl32.Appearance.Options.UseTextOptions = true;
            this.labelControl32.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl32.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl32.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl32.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl32.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl32.Location = new System.Drawing.Point(322, 92);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl32.Size = new System.Drawing.Size(92, 45);
            this.labelControl32.TabIndex = 60344;
            this.labelControl32.Text = "5020301";
            this.labelControl32.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl33
            // 
            this.labelControl33.AccessibleDescription = "5020202";
            this.labelControl33.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl33.Appearance.Options.UseBackColor = true;
            this.labelControl33.Appearance.Options.UseTextOptions = true;
            this.labelControl33.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl33.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl33.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl33.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl33.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl33.Location = new System.Drawing.Point(202, 144);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl33.Size = new System.Drawing.Size(92, 45);
            this.labelControl33.TabIndex = 60343;
            this.labelControl33.Text = "5020202";
            this.labelControl33.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl25
            // 
            this.labelControl25.AccessibleDescription = "5020501";
            this.labelControl25.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl25.Appearance.Options.UseBackColor = true;
            this.labelControl25.Appearance.Options.UseTextOptions = true;
            this.labelControl25.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl25.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl25.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl25.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl25.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl25.Location = new System.Drawing.Point(563, 92);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl25.Size = new System.Drawing.Size(92, 45);
            this.labelControl25.TabIndex = 60341;
            this.labelControl25.Text = "5020501";
            this.labelControl25.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl26
            // 
            this.labelControl26.AccessibleDescription = "5020203";
            this.labelControl26.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl26.Appearance.Options.UseBackColor = true;
            this.labelControl26.Appearance.Options.UseTextOptions = true;
            this.labelControl26.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl26.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl26.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl26.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl26.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl26.Location = new System.Drawing.Point(202, 196);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl26.Size = new System.Drawing.Size(92, 45);
            this.labelControl26.TabIndex = 60340;
            this.labelControl26.Text = "5020203";
            this.labelControl26.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl27
            // 
            this.labelControl27.AccessibleDescription = "5020201";
            this.labelControl27.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl27.Appearance.Options.UseBackColor = true;
            this.labelControl27.Appearance.Options.UseTextOptions = true;
            this.labelControl27.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl27.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl27.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl27.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl27.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl27.Location = new System.Drawing.Point(202, 92);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl27.Size = new System.Drawing.Size(92, 45);
            this.labelControl27.TabIndex = 60339;
            this.labelControl27.Text = "5020201";
            this.labelControl27.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl28
            // 
            this.labelControl28.AccessibleDescription = "5020503";
            this.labelControl28.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl28.Appearance.Options.UseBackColor = true;
            this.labelControl28.Appearance.Options.UseTextOptions = true;
            this.labelControl28.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl28.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl28.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl28.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl28.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl28.Location = new System.Drawing.Point(563, 196);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl28.Size = new System.Drawing.Size(92, 45);
            this.labelControl28.TabIndex = 60338;
            this.labelControl28.Text = "5020503";
            this.labelControl28.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl29
            // 
            this.labelControl29.AccessibleDescription = "5020502";
            this.labelControl29.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl29.Appearance.Options.UseBackColor = true;
            this.labelControl29.Appearance.Options.UseTextOptions = true;
            this.labelControl29.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl29.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl29.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl29.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl29.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl29.Location = new System.Drawing.Point(563, 144);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl29.Size = new System.Drawing.Size(92, 45);
            this.labelControl29.TabIndex = 60337;
            this.labelControl29.Text = "5020502";
            this.labelControl29.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl24
            // 
            this.labelControl24.AccessibleDescription = "5020204";
            this.labelControl24.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl24.Appearance.Options.UseBackColor = true;
            this.labelControl24.Appearance.Options.UseTextOptions = true;
            this.labelControl24.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl24.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl24.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl24.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl24.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl24.Location = new System.Drawing.Point(202, 248);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl24.Size = new System.Drawing.Size(92, 45);
            this.labelControl24.TabIndex = 60336;
            this.labelControl24.Text = "5020204";
            this.labelControl24.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl23
            // 
            this.labelControl23.AccessibleDescription = "5020205";
            this.labelControl23.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl23.Appearance.Options.UseBackColor = true;
            this.labelControl23.Appearance.Options.UseTextOptions = true;
            this.labelControl23.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl23.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl23.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl23.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl23.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl23.Location = new System.Drawing.Point(202, 300);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl23.Size = new System.Drawing.Size(92, 45);
            this.labelControl23.TabIndex = 60335;
            this.labelControl23.Text = "5020205";
            this.labelControl23.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.AccessibleDescription = "5020104";
            this.labelControl13.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl13.Appearance.Options.UseBackColor = true;
            this.labelControl13.Appearance.Options.UseTextOptions = true;
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl13.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl13.Location = new System.Drawing.Point(83, 248);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl13.Size = new System.Drawing.Size(92, 45);
            this.labelControl13.TabIndex = 60334;
            this.labelControl13.Text = "5020104";
            this.labelControl13.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl17
            // 
            this.labelControl17.AccessibleDescription = "5020103";
            this.labelControl17.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl17.Appearance.Options.UseBackColor = true;
            this.labelControl17.Appearance.Options.UseTextOptions = true;
            this.labelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl17.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl17.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.labelControl17.Location = new System.Drawing.Point(83, 196);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl17.Size = new System.Drawing.Size(92, 45);
            this.labelControl17.TabIndex = 60333;
            this.labelControl17.Text = "5020103";
            this.labelControl17.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl18
            // 
            this.labelControl18.AccessibleDescription = "5020102";
            this.labelControl18.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl18.Appearance.Options.UseBackColor = true;
            this.labelControl18.Appearance.Options.UseTextOptions = true;
            this.labelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl18.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl18.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl18.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl18.Location = new System.Drawing.Point(83, 144);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl18.Size = new System.Drawing.Size(92, 45);
            this.labelControl18.TabIndex = 60332;
            this.labelControl18.Text = "5020102";
            this.labelControl18.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl22
            // 
            this.labelControl22.AccessibleDescription = "5020101";
            this.labelControl22.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl22.Appearance.Options.UseBackColor = true;
            this.labelControl22.Appearance.Options.UseTextOptions = true;
            this.labelControl22.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl22.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl22.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl22.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl22.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl22.Location = new System.Drawing.Point(83, 92);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl22.Size = new System.Drawing.Size(92, 45);
            this.labelControl22.TabIndex = 60331;
            this.labelControl22.Text = "5020101";
            this.labelControl22.Click += new System.EventHandler(this.lab_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 23);
            this.label5.TabIndex = 60160;
            this.label5.Text = "东";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(78, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 60139;
            this.label4.Text = "502";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(170, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 60136;
            this.label3.Text = "货位：19";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(48, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 60138;
            this.label2.Text = "北";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(381, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 60137;
            this.label1.Text = "南";
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
            // labelControl4
            // 
            this.labelControl4.AccessibleDescription = "5020504";
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(563, 248);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl4.Size = new System.Drawing.Size(92, 45);
            this.labelControl4.TabIndex = 60352;
            this.labelControl4.Text = "5020504";
            this.labelControl4.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.AccessibleDescription = "5020505";
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(563, 299);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl5.Size = new System.Drawing.Size(92, 45);
            this.labelControl5.TabIndex = 60353;
            this.labelControl5.Text = "5020505";
            this.labelControl5.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.AccessibleDescription = "5020507";
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(563, 401);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl7.Size = new System.Drawing.Size(92, 45);
            this.labelControl7.TabIndex = 60355;
            this.labelControl7.Text = "5020507";
            this.labelControl7.Click += new System.EventHandler(this.lab_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.AccessibleDescription = "5020506";
            this.labelControl8.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.labelControl8.Appearance.Options.UseBackColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl8.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(563, 350);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl8.Size = new System.Drawing.Size(92, 45);
            this.labelControl8.TabIndex = 60354;
            this.labelControl8.Text = "5020506";
            this.labelControl8.Click += new System.EventHandler(this.lab_Click);
            // 
            // FrmPO_XCGPKWT_502
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmPO_XCGPKWT_502";
            this.Text = "线材钢坯库位图";
            this.Load += new System.EventHandler(this.FrmPO_XCKWT_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlMain;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gc_GPSJ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GPSJ;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STOVE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colN_LEN;
        private DevExpress.XtraGrid.Columns.GridColumn N_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MAT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MAT_NAME;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.TextEdit txt_Stove;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl36;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraGrid.Columns.GridColumn C_STA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn COU;
        private DevExpress.XtraGrid.Columns.GridColumn D_WE_DATE;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}