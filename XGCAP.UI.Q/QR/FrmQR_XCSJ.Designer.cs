namespace XGCAP.UI.Q.QR
{
    partial class FrmQR_XCSJ
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
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btn_DC = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_STL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_STD = new DevExpress.XtraEditors.TextEdit();
            this.imgcbo_CJ = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dte_End = new DevExpress.XtraEditors.DateEdit();
            this.dte_Begin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gc_PDJG = new DevExpress.XtraGrid.GridControl();
            this.gv_PDJG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.C_JUDGE_LEV_BP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_DP_SHIFT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_DP_EMP_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_DP_GROUP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_CODE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_DESC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_LINEWH_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_BATCH_NO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_JUDGE_LEV_ZH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_STL_GRD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_SPEC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_STOVE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_ZYX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_ZYX21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_BZYQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.N_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.N_NUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_sta_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gc_Sj = new DevExpress.XtraGrid.GridControl();
            this.gv_Sj = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_CJ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PDJG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PDJG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Sj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sj)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(739, 35);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(85, 29);
            this.btn_Query.TabIndex = 35;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txt_BatchNo1
            // 
            this.txt_BatchNo1.Location = new System.Drawing.Point(52, 38);
            this.txt_BatchNo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_BatchNo1.Name = "txt_BatchNo1";
            this.txt_BatchNo1.Size = new System.Drawing.Size(196, 24);
            this.txt_BatchNo1.TabIndex = 19;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(15, 41);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(30, 18);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "批号";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btn_DC);
            this.panelControl4.Controls.Add(this.labelControl5);
            this.panelControl4.Controls.Add(this.txt_STL);
            this.panelControl4.Controls.Add(this.labelControl4);
            this.panelControl4.Controls.Add(this.txt_STD);
            this.panelControl4.Controls.Add(this.imgcbo_CJ);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Controls.Add(this.dte_End);
            this.panelControl4.Controls.Add(this.dte_Begin);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.labelControl9);
            this.panelControl4.Controls.Add(this.txt_BatchNo1);
            this.panelControl4.Controls.Add(this.btn_Query);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1808, 82);
            this.panelControl4.TabIndex = 4;
            // 
            // btn_DC
            // 
            this.btn_DC.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_DC.Location = new System.Drawing.Point(832, 35);
            this.btn_DC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_DC.Name = "btn_DC";
            this.btn_DC.Size = new System.Drawing.Size(85, 29);
            this.btn_DC.TabIndex = 46;
            this.btn_DC.Text = "导出";
            this.btn_DC.Click += new System.EventHandler(this.btn_DC_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(255, 41);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 18);
            this.labelControl5.TabIndex = 44;
            this.labelControl5.Text = "钢种";
            // 
            // txt_STL
            // 
            this.txt_STL.Location = new System.Drawing.Point(292, 38);
            this.txt_STL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_STL.Name = "txt_STL";
            this.txt_STL.Size = new System.Drawing.Size(183, 24);
            this.txt_STL.TabIndex = 45;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(480, 41);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 18);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "执行标准";
            // 
            // txt_STD
            // 
            this.txt_STD.Location = new System.Drawing.Point(549, 38);
            this.txt_STD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_STD.Name = "txt_STD";
            this.txt_STD.Size = new System.Drawing.Size(183, 24);
            this.txt_STD.TabIndex = 43;
            // 
            // imgcbo_CJ
            // 
            this.imgcbo_CJ.EditValue = "全部";
            this.imgcbo_CJ.Location = new System.Drawing.Point(549, 8);
            this.imgcbo_CJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgcbo_CJ.Name = "imgcbo_CJ";
            this.imgcbo_CJ.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_CJ.Size = new System.Drawing.Size(183, 24);
            this.imgcbo_CJ.TabIndex = 41;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(511, 11);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "工厂";
            // 
            // dte_End
            // 
            this.dte_End.EditValue = null;
            this.dte_End.Location = new System.Drawing.Point(279, 8);
            this.dte_End.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dte_End.Name = "dte_End";
            this.dte_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_End.Properties.DisplayFormat.FormatString = "G";
            this.dte_End.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_End.Properties.EditFormat.FormatString = "G";
            this.dte_End.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_End.Properties.Mask.EditMask = "G";
            this.dte_End.Size = new System.Drawing.Size(196, 24);
            this.dte_End.TabIndex = 39;
            // 
            // dte_Begin
            // 
            this.dte_Begin.EditValue = null;
            this.dte_Begin.Location = new System.Drawing.Point(52, 8);
            this.dte_Begin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dte_Begin.Name = "dte_Begin";
            this.dte_Begin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Begin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Begin.Properties.DisplayFormat.FormatString = "G";
            this.dte_Begin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_Begin.Properties.EditFormat.FormatString = "G";
            this.dte_Begin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_Begin.Properties.Mask.EditMask = "G";
            this.dte_Begin.Size = new System.Drawing.Size(196, 24);
            this.dte_Begin.TabIndex = 38;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(257, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 18);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "~";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "时间";
            // 
            // gc_PDJG
            // 
            this.gc_PDJG.Dock = System.Windows.Forms.DockStyle.Left;
            this.gc_PDJG.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_PDJG.Location = new System.Drawing.Point(0, 82);
            this.gc_PDJG.MainView = this.gv_PDJG;
            this.gc_PDJG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_PDJG.Name = "gc_PDJG";
            this.gc_PDJG.Size = new System.Drawing.Size(1193, 902);
            this.gc_PDJG.TabIndex = 5;
            this.gc_PDJG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_PDJG});
            // 
            // gv_PDJG
            // 
            this.gv_PDJG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.C_JUDGE_LEV_BP1,
            this.C_DP_SHIFT1,
            this.C_DP_EMP_ID1,
            this.C_DP_GROUP1,
            this.DT,
            this.C_MAT_CODE1,
            this.C_MAT_DESC1,
            this.C_LINEWH_CODE,
            this.C_BATCH_NO1,
            this.C_JUDGE_LEV_ZH1,
            this.C_STL_GRD1,
            this.C_SPEC1,
            this.C_STOVE1,
            this.C_ZYX1,
            this.C_ZYX21,
            this.C_BZYQ,
            this.N_WGT,
            this.N_NUM,
            this.c_sta_desc,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4});
            this.gv_PDJG.GridControl = this.gc_PDJG;
            this.gv_PDJG.Name = "gv_PDJG";
            this.gv_PDJG.OptionsBehavior.Editable = false;
            this.gv_PDJG.OptionsView.ColumnAutoWidth = false;
            this.gv_PDJG.OptionsView.ShowGroupPanel = false;
            this.gv_PDJG.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_PDJG_FocusedRowChanged);
            // 
            // C_JUDGE_LEV_BP1
            // 
            this.C_JUDGE_LEV_BP1.Caption = "表判等级";
            this.C_JUDGE_LEV_BP1.FieldName = "C_JUDGE_LEV_BP";
            this.C_JUDGE_LEV_BP1.Name = "C_JUDGE_LEV_BP1";
            this.C_JUDGE_LEV_BP1.Visible = true;
            this.C_JUDGE_LEV_BP1.VisibleIndex = 14;
            // 
            // C_DP_SHIFT1
            // 
            this.C_DP_SHIFT1.Caption = "打牌班次";
            this.C_DP_SHIFT1.FieldName = "C_DP_SHIFT";
            this.C_DP_SHIFT1.Name = "C_DP_SHIFT1";
            this.C_DP_SHIFT1.Visible = true;
            this.C_DP_SHIFT1.VisibleIndex = 16;
            // 
            // C_DP_EMP_ID1
            // 
            this.C_DP_EMP_ID1.Caption = "打牌操作人";
            this.C_DP_EMP_ID1.FieldName = "C_NAME";
            this.C_DP_EMP_ID1.Name = "C_DP_EMP_ID1";
            this.C_DP_EMP_ID1.Visible = true;
            this.C_DP_EMP_ID1.VisibleIndex = 18;
            // 
            // C_DP_GROUP1
            // 
            this.C_DP_GROUP1.Caption = "打牌班组";
            this.C_DP_GROUP1.FieldName = "C_DP_GROUP";
            this.C_DP_GROUP1.Name = "C_DP_GROUP1";
            this.C_DP_GROUP1.Visible = true;
            this.C_DP_GROUP1.VisibleIndex = 17;
            // 
            // DT
            // 
            this.DT.Caption = "打牌时间";
            this.DT.DisplayFormat.FormatString = "G";
            this.DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DT.FieldName = "DT";
            this.DT.Name = "DT";
            this.DT.Visible = true;
            this.DT.VisibleIndex = 19;
            // 
            // C_MAT_CODE1
            // 
            this.C_MAT_CODE1.Caption = "物料编码";
            this.C_MAT_CODE1.FieldName = "C_MAT_CODE";
            this.C_MAT_CODE1.Name = "C_MAT_CODE1";
            this.C_MAT_CODE1.Visible = true;
            this.C_MAT_CODE1.VisibleIndex = 8;
            // 
            // C_MAT_DESC1
            // 
            this.C_MAT_DESC1.Caption = "物料描述";
            this.C_MAT_DESC1.FieldName = "C_MAT_DESC";
            this.C_MAT_DESC1.Name = "C_MAT_DESC1";
            this.C_MAT_DESC1.Visible = true;
            this.C_MAT_DESC1.VisibleIndex = 9;
            // 
            // C_LINEWH_CODE
            // 
            this.C_LINEWH_CODE.Caption = "仓库编码";
            this.C_LINEWH_CODE.FieldName = "C_LINEWH_CODE";
            this.C_LINEWH_CODE.Name = "C_LINEWH_CODE";
            this.C_LINEWH_CODE.Visible = true;
            this.C_LINEWH_CODE.VisibleIndex = 10;
            // 
            // C_BATCH_NO1
            // 
            this.C_BATCH_NO1.Caption = "批号";
            this.C_BATCH_NO1.FieldName = "C_BATCH_NO";
            this.C_BATCH_NO1.Name = "C_BATCH_NO1";
            this.C_BATCH_NO1.Visible = true;
            this.C_BATCH_NO1.VisibleIndex = 3;
            // 
            // C_JUDGE_LEV_ZH1
            // 
            this.C_JUDGE_LEV_ZH1.Caption = "综合判定等级";
            this.C_JUDGE_LEV_ZH1.FieldName = "C_JUDGE_LEV_ZH";
            this.C_JUDGE_LEV_ZH1.Name = "C_JUDGE_LEV_ZH1";
            this.C_JUDGE_LEV_ZH1.Visible = true;
            this.C_JUDGE_LEV_ZH1.VisibleIndex = 15;
            // 
            // C_STL_GRD1
            // 
            this.C_STL_GRD1.Caption = "钢种";
            this.C_STL_GRD1.FieldName = "C_STL_GRD";
            this.C_STL_GRD1.Name = "C_STL_GRD1";
            this.C_STL_GRD1.Visible = true;
            this.C_STL_GRD1.VisibleIndex = 4;
            // 
            // C_SPEC1
            // 
            this.C_SPEC1.Caption = "规格";
            this.C_SPEC1.FieldName = "C_SPEC";
            this.C_SPEC1.Name = "C_SPEC1";
            this.C_SPEC1.Visible = true;
            this.C_SPEC1.VisibleIndex = 6;
            // 
            // C_STOVE1
            // 
            this.C_STOVE1.Caption = "炉号";
            this.C_STOVE1.FieldName = "C_STOVE";
            this.C_STOVE1.Name = "C_STOVE1";
            this.C_STOVE1.Visible = true;
            this.C_STOVE1.VisibleIndex = 2;
            // 
            // C_ZYX1
            // 
            this.C_ZYX1.Caption = "自由项1";
            this.C_ZYX1.FieldName = "C_ZYX1";
            this.C_ZYX1.Name = "C_ZYX1";
            // 
            // C_ZYX21
            // 
            this.C_ZYX21.Caption = "自由项2";
            this.C_ZYX21.FieldName = "C_ZYX2";
            this.C_ZYX21.Name = "C_ZYX21";
            // 
            // C_BZYQ
            // 
            this.C_BZYQ.Caption = "包装要求";
            this.C_BZYQ.FieldName = "C_BZYQ";
            this.C_BZYQ.Name = "C_BZYQ";
            // 
            // N_WGT
            // 
            this.N_WGT.Caption = "重量";
            this.N_WGT.FieldName = "N_WGT";
            this.N_WGT.Name = "N_WGT";
            this.N_WGT.Visible = true;
            this.N_WGT.VisibleIndex = 12;
            // 
            // N_NUM
            // 
            this.N_NUM.Caption = "支数";
            this.N_NUM.FieldName = "N_NUM";
            this.N_NUM.Name = "N_NUM";
            this.N_NUM.Visible = true;
            this.N_NUM.VisibleIndex = 13;
            // 
            // c_sta_desc
            // 
            this.c_sta_desc.Caption = "工厂";
            this.c_sta_desc.FieldName = "C_STA_DESC";
            this.c_sta_desc.Name = "c_sta_desc";
            this.c_sta_desc.Visible = true;
            this.c_sta_desc.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "执行标准";
            this.gridColumn2.FieldName = "C_STD_CODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "仓库描述";
            this.gridColumn1.FieldName = "C_LINEWH_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "生产时间";
            this.gridColumn3.FieldName = "D_PRODUCE_DATE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "状态";
            this.gridColumn4.FieldName = "C_MOVE_TYPE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(1193, 82);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 902);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            // 
            // gc_Sj
            // 
            this.gc_Sj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Sj.Location = new System.Drawing.Point(1199, 82);
            this.gc_Sj.MainView = this.gv_Sj;
            this.gc_Sj.Name = "gc_Sj";
            this.gc_Sj.Size = new System.Drawing.Size(609, 902);
            this.gc_Sj.TabIndex = 7;
            this.gc_Sj.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Sj});
            // 
            // gv_Sj
            // 
            this.gv_Sj.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gv_Sj.GridControl = this.gc_Sj;
            this.gv_Sj.Name = "gv_Sj";
            this.gv_Sj.OptionsBehavior.Editable = false;
            this.gv_Sj.OptionsView.ColumnAutoWidth = false;
            this.gv_Sj.OptionsView.ShowFooter = true;
            this.gv_Sj.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "批号";
            this.gridColumn5.FieldName = "批号";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "钩号";
            this.gridColumn6.FieldName = "钩号";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "重量";
            this.gridColumn7.FieldName = "重量";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "重量", "{0:0.##}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "钢种";
            this.gridColumn8.FieldName = "钢种";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "执行标准";
            this.gridColumn9.FieldName = "执行标准";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "规格";
            this.gridColumn10.FieldName = "规格";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "物料编码";
            this.gridColumn11.FieldName = "物料编码";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "物料名称";
            this.gridColumn12.FieldName = "物料名称";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 7;
            // 
            // FrmQR_XCSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 984);
            this.Controls.Add(this.gc_Sj);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gc_PDJG);
            this.Controls.Add(this.panelControl4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmQR_XCSJ";
            this.Text = "线材实绩查询";
            this.Load += new System.EventHandler(this.FrmQC001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_CJ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PDJG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PDJG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Sj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txt_BatchNo1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gc_PDJG;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PDJG;
        private DevExpress.XtraGrid.Columns.GridColumn C_JUDGE_LEV_BP1;
        private DevExpress.XtraGrid.Columns.GridColumn C_DP_SHIFT1;
        private DevExpress.XtraGrid.Columns.GridColumn C_DP_EMP_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn C_DP_GROUP1;
        private DevExpress.XtraGrid.Columns.GridColumn DT;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_CODE1;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_DESC1;
        private DevExpress.XtraGrid.Columns.GridColumn C_LINEWH_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn C_BATCH_NO1;
        private DevExpress.XtraGrid.Columns.GridColumn C_JUDGE_LEV_ZH1;
        private DevExpress.XtraGrid.Columns.GridColumn C_STL_GRD1;
        private DevExpress.XtraGrid.Columns.GridColumn C_SPEC1;
        private DevExpress.XtraGrid.Columns.GridColumn C_STOVE1;
        private DevExpress.XtraGrid.Columns.GridColumn C_ZYX1;
        private DevExpress.XtraGrid.Columns.GridColumn C_ZYX21;
        private DevExpress.XtraEditors.DateEdit dte_End;
        private DevExpress.XtraEditors.DateEdit dte_Begin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn C_BZYQ;
        private DevExpress.XtraGrid.Columns.GridColumn N_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn N_NUM;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_CJ;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn c_sta_desc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_STL;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_STD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btn_DC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl gc_Sj;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Sj;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
    }
}