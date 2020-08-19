namespace XGCAP.UI.P.PO.XCKWT
{
    partial class FrmPO_XCGPKWT_511
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPO_XCGPKWT_511));
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
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
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
            this.pnlMain.Controls.Add(this.labelControl27);
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
            this.labelControl27.Location = new System.Drawing.Point(474, 138);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl27.Size = new System.Drawing.Size(129, 145);
            this.labelControl27.TabIndex = 60339;
            this.labelControl27.Text = "5020201";
            this.labelControl27.Click += new System.EventHandler(this.lab_Click);
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
            this.labelControl22.Location = new System.Drawing.Point(224, 138);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl22.Size = new System.Drawing.Size(125, 145);
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
            // FrmPO_XCGPKWT_511
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmPO_XCGPKWT_511";
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
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraGrid.Columns.GridColumn C_STA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn COU;
        private DevExpress.XtraGrid.Columns.GridColumn D_WE_DATE;
    }
}