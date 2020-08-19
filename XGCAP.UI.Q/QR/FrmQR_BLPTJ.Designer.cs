namespace XGCAP.UI.Q.QR
{
    partial class FrmQR_BLPTJ
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
            this.gc_PDJG = new DevExpress.XtraGrid.GridControl();
            this.gv_PDJG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_STOVE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STA_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SLAB_SIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_LEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MAT_CODE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MAT_NAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_JUDGE_LEV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REASON_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REASON_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REASON_DEPMT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REASON_DEPMT_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SUGGESTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dte_End = new DevExpress.XtraEditors.DateEdit();
            this.dte_Begin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Stove = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PDJG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PDJG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_PDJG
            // 
            this.gc_PDJG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_PDJG.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_PDJG.Location = new System.Drawing.Point(0, 39);
            this.gc_PDJG.MainView = this.gv_PDJG;
            this.gc_PDJG.Margin = new System.Windows.Forms.Padding(2);
            this.gc_PDJG.Name = "gc_PDJG";
            this.gc_PDJG.Size = new System.Drawing.Size(1094, 609);
            this.gc_PDJG.TabIndex = 10;
            this.gc_PDJG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_PDJG});
            // 
            // gv_PDJG
            // 
            this.gv_PDJG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_STOVE1,
            this.colC_STA_ID1,
            this.colC_STL_GRD1,
            this.colC_SLAB_SIZE,
            this.colN_WGT,
            this.colN_LEN1,
            this.colC_STD_CODE1,
            this.colC_MAT_CODE1,
            this.colC_MAT_NAME1,
            this.colC_JUDGE_LEV,
            this.colC_REASON_NAME,
            this.colC_REASON_CODE,
            this.colC_REASON_DEPMT_ID,
            this.colC_REASON_DEPMT_DESC,
            this.colC_SUGGESTION,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT});
            this.gv_PDJG.GridControl = this.gc_PDJG;
            this.gv_PDJG.Name = "gv_PDJG";
            this.gv_PDJG.OptionsBehavior.Editable = false;
            this.gv_PDJG.OptionsView.ColumnAutoWidth = false;
            this.gv_PDJG.OptionsView.ShowGroupPanel = false;
            // 
            // colC_STOVE1
            // 
            this.colC_STOVE1.Caption = "炉号";
            this.colC_STOVE1.FieldName = "C_STOVE";
            this.colC_STOVE1.Name = "colC_STOVE1";
            this.colC_STOVE1.Visible = true;
            this.colC_STOVE1.VisibleIndex = 2;
            // 
            // colC_STA_ID1
            // 
            this.colC_STA_ID1.Caption = "铸机号 ";
            this.colC_STA_ID1.FieldName = "C_STA_ID";
            this.colC_STA_ID1.Name = "colC_STA_ID1";
            this.colC_STA_ID1.Visible = true;
            this.colC_STA_ID1.VisibleIndex = 3;
            // 
            // colC_STL_GRD1
            // 
            this.colC_STL_GRD1.Caption = "钢种";
            this.colC_STL_GRD1.FieldName = "C_STL_GRD";
            this.colC_STL_GRD1.Name = "colC_STL_GRD1";
            this.colC_STL_GRD1.Visible = true;
            this.colC_STL_GRD1.VisibleIndex = 0;
            // 
            // colC_SLAB_SIZE
            // 
            this.colC_SLAB_SIZE.Caption = "断面";
            this.colC_SLAB_SIZE.FieldName = "C_SLAB_SIZE";
            this.colC_SLAB_SIZE.Name = "colC_SLAB_SIZE";
            this.colC_SLAB_SIZE.Visible = true;
            this.colC_SLAB_SIZE.VisibleIndex = 4;
            // 
            // colN_WGT
            // 
            this.colN_WGT.Caption = "单重";
            this.colN_WGT.FieldName = "N_WGT";
            this.colN_WGT.Name = "colN_WGT";
            this.colN_WGT.Visible = true;
            this.colN_WGT.VisibleIndex = 5;
            // 
            // colN_LEN1
            // 
            this.colN_LEN1.Caption = "定尺";
            this.colN_LEN1.FieldName = "N_LEN";
            this.colN_LEN1.Name = "colN_LEN1";
            this.colN_LEN1.Visible = true;
            this.colN_LEN1.VisibleIndex = 6;
            // 
            // colC_STD_CODE1
            // 
            this.colC_STD_CODE1.Caption = "执行标准";
            this.colC_STD_CODE1.FieldName = "C_STD_CODE";
            this.colC_STD_CODE1.Name = "colC_STD_CODE1";
            this.colC_STD_CODE1.Visible = true;
            this.colC_STD_CODE1.VisibleIndex = 1;
            // 
            // colC_MAT_CODE1
            // 
            this.colC_MAT_CODE1.Caption = "物料编码 ";
            this.colC_MAT_CODE1.FieldName = "C_MAT_CODE";
            this.colC_MAT_CODE1.Name = "colC_MAT_CODE1";
            this.colC_MAT_CODE1.Visible = true;
            this.colC_MAT_CODE1.VisibleIndex = 7;
            // 
            // colC_MAT_NAME1
            // 
            this.colC_MAT_NAME1.Caption = "物料描述";
            this.colC_MAT_NAME1.FieldName = "C_MAT_NAME";
            this.colC_MAT_NAME1.Name = "colC_MAT_NAME1";
            this.colC_MAT_NAME1.Visible = true;
            this.colC_MAT_NAME1.VisibleIndex = 8;
            // 
            // colC_JUDGE_LEV
            // 
            this.colC_JUDGE_LEV.Caption = "表面判定等级";
            this.colC_JUDGE_LEV.FieldName = "C_JUDGE_LEV";
            this.colC_JUDGE_LEV.Name = "colC_JUDGE_LEV";
            this.colC_JUDGE_LEV.Visible = true;
            this.colC_JUDGE_LEV.VisibleIndex = 9;
            // 
            // colC_REASON_NAME
            // 
            this.colC_REASON_NAME.Caption = "不合格原因名称";
            this.colC_REASON_NAME.FieldName = "C_REASON_NAME";
            this.colC_REASON_NAME.Name = "colC_REASON_NAME";
            this.colC_REASON_NAME.Visible = true;
            this.colC_REASON_NAME.VisibleIndex = 10;
            // 
            // colC_REASON_CODE
            // 
            this.colC_REASON_CODE.Caption = "不合格原因代码";
            this.colC_REASON_CODE.FieldName = "C_REASON_CODE";
            this.colC_REASON_CODE.Name = "colC_REASON_CODE";
            this.colC_REASON_CODE.Visible = true;
            this.colC_REASON_CODE.VisibleIndex = 11;
            // 
            // colC_REASON_DEPMT_ID
            // 
            this.colC_REASON_DEPMT_ID.Caption = "责任单位代码";
            this.colC_REASON_DEPMT_ID.FieldName = "C_REASON_DEPMT_ID";
            this.colC_REASON_DEPMT_ID.Name = "colC_REASON_DEPMT_ID";
            this.colC_REASON_DEPMT_ID.Visible = true;
            this.colC_REASON_DEPMT_ID.VisibleIndex = 12;
            // 
            // colC_REASON_DEPMT_DESC
            // 
            this.colC_REASON_DEPMT_DESC.Caption = "责任单位描述";
            this.colC_REASON_DEPMT_DESC.FieldName = "C_REASON_DEPMT_DESC";
            this.colC_REASON_DEPMT_DESC.Name = "colC_REASON_DEPMT_DESC";
            this.colC_REASON_DEPMT_DESC.Visible = true;
            this.colC_REASON_DEPMT_DESC.VisibleIndex = 13;
            // 
            // colC_SUGGESTION
            // 
            this.colC_SUGGESTION.Caption = "处置意见";
            this.colC_SUGGESTION.FieldName = "C_SUGGESTION";
            this.colC_SUGGESTION.Name = "colC_SUGGESTION";
            this.colC_SUGGESTION.Visible = true;
            this.colC_SUGGESTION.VisibleIndex = 14;
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.Caption = "使用状态 ";
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.Caption = "备注";
            this.colC_REMARK.FieldName = "C_REMARK";
            this.colC_REMARK.Name = "colC_REMARK";
            this.colC_REMARK.Visible = true;
            this.colC_REMARK.VisibleIndex = 15;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "判定人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 16;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "判定时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 17;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dte_End);
            this.panelControl2.Controls.Add(this.dte_Begin);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.labelControl14);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.txt_Stove);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1094, 39);
            this.panelControl2.TabIndex = 9;
            // 
            // dte_End
            // 
            this.dte_End.EditValue = null;
            this.dte_End.Location = new System.Drawing.Point(243, 9);
            this.dte_End.Margin = new System.Windows.Forms.Padding(2);
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
            this.dte_End.Size = new System.Drawing.Size(147, 20);
            this.dte_End.TabIndex = 54;
            // 
            // dte_Begin
            // 
            this.dte_Begin.EditValue = null;
            this.dte_Begin.Location = new System.Drawing.Point(71, 9);
            this.dte_Begin.Margin = new System.Windows.Forms.Padding(2);
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
            this.dte_Begin.Size = new System.Drawing.Size(147, 20);
            this.dte_Begin.TabIndex = 53;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(226, 9);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(9, 14);
            this.labelControl13.TabIndex = 52;
            this.labelControl13.Text = "~";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(15, 9);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(48, 14);
            this.labelControl14.TabIndex = 51;
            this.labelControl14.Text = "判定时间";
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(584, 9);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(81, 22);
            this.btn_Query.TabIndex = 50;
            this.btn_Query.Text = "查询";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(398, 9);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 14);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "炉号";
            // 
            // txt_Stove
            // 
            this.txt_Stove.Location = new System.Drawing.Point(430, 9);
            this.txt_Stove.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Stove.Name = "txt_Stove";
            this.txt_Stove.Size = new System.Drawing.Size(146, 20);
            this.txt_Stove.TabIndex = 19;
            // 
            // FrmQR_BLPTJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 648);
            this.Controls.Add(this.gc_PDJG);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmQR_BLPTJ";
            this.Text = "不良品统计查询";
            ((System.ComponentModel.ISupportInitialize)(this.gc_PDJG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PDJG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_PDJG;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PDJG;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STOVE1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STA_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SLAB_SIZE;
        private DevExpress.XtraGrid.Columns.GridColumn colN_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn colN_LEN1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MAT_CODE1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MAT_NAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_JUDGE_LEV;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_DEPMT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_DEPMT_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SUGGESTION;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit dte_End;
        private DevExpress.XtraEditors.DateEdit dte_Begin;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_Stove;
    }
}