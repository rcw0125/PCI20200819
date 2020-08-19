namespace XGCAP.UI.Q.QR
{
    partial class FrmQR_GPKJCX
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.rbtn_isty_wh = new DevExpress.XtraEditors.RadioGroup();
            this.txt_Query1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.dte_End = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.dte_Begin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Stove1 = new DevExpress.XtraEditors.TextEdit();
            this.gc_GPKJ = new DevExpress.XtraGrid.GridControl();
            this.gv_GPKJ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SLAB_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STOVE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SLAB_SIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_LEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MAT_CODE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_MAT_NAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_WAREHOUSE_IN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SHIFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_GROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REASON_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REASON_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REASON_DEPMT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REASON_DEPMT_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SUGGESTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_CHECK_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_CHECK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_AUDIT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_wh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPKJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPKJ)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.rbtn_isty_wh);
            this.panelControl2.Controls.Add(this.txt_Query1);
            this.panelControl2.Controls.Add(this.labelControl14);
            this.panelControl2.Controls.Add(this.dte_End);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.dte_Begin);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txt_Stove1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(950, 41);
            this.panelControl2.TabIndex = 37;
            // 
            // rbtn_isty_wh
            // 
            this.rbtn_isty_wh.Location = new System.Drawing.Point(541, 5);
            this.rbtn_isty_wh.Name = "rbtn_isty_wh";
            this.rbtn_isty_wh.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_isty_wh.Properties.Appearance.Options.UseBackColor = true;
            this.rbtn_isty_wh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rbtn_isty_wh.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "未确认"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "已确认")});
            this.rbtn_isty_wh.Size = new System.Drawing.Size(131, 27);
            this.rbtn_isty_wh.TabIndex = 128;
            // 
            // txt_Query1
            // 
            this.txt_Query1.ImageUri.Uri = "Zoom;Size16x16";
            this.txt_Query1.Location = new System.Drawing.Point(681, 9);
            this.txt_Query1.Name = "txt_Query1";
            this.txt_Query1.Size = new System.Drawing.Size(75, 23);
            this.txt_Query1.TabIndex = 55;
            this.txt_Query1.Text = "查询";
            this.txt_Query1.Click += new System.EventHandler(this.txt_Query1_Click);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(14, 9);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(48, 14);
            this.labelControl14.TabIndex = 46;
            this.labelControl14.Text = "库检时间";
            // 
            // dte_End
            // 
            this.dte_End.EditValue = null;
            this.dte_End.Location = new System.Drawing.Point(239, 9);
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
            this.dte_End.TabIndex = 52;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(223, 9);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(9, 14);
            this.labelControl13.TabIndex = 47;
            this.labelControl13.Text = "~";
            // 
            // dte_Begin
            // 
            this.dte_Begin.EditValue = null;
            this.dte_Begin.Location = new System.Drawing.Point(69, 9);
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
            this.dte_Begin.TabIndex = 51;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(393, 9);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "炉号";
            // 
            // txt_Stove1
            // 
            this.txt_Stove1.Location = new System.Drawing.Point(424, 9);
            this.txt_Stove1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Stove1.Name = "txt_Stove1";
            this.txt_Stove1.Size = new System.Drawing.Size(112, 20);
            this.txt_Stove1.TabIndex = 49;
            // 
            // gc_GPKJ
            // 
            this.gc_GPKJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GPKJ.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_GPKJ.Location = new System.Drawing.Point(0, 41);
            this.gc_GPKJ.MainView = this.gv_GPKJ;
            this.gc_GPKJ.Margin = new System.Windows.Forms.Padding(2);
            this.gc_GPKJ.Name = "gc_GPKJ";
            this.gc_GPKJ.Size = new System.Drawing.Size(950, 409);
            this.gc_GPKJ.TabIndex = 44;
            this.gc_GPKJ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GPKJ});
            // 
            // gv_GPKJ
            // 
            this.gv_GPKJ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_SLAB_ID,
            this.colC_STOVE1,
            this.colC_STL_GRD1,
            this.colN_WGT,
            this.colC_STD_CODE1,
            this.colC_SLAB_SIZE,
            this.colN_LEN1,
            this.colC_MAT_CODE1,
            this.colC_MAT_NAME1,
            this.colD_WAREHOUSE_IN,
            this.colC_SHIFT,
            this.colC_GROUP,
            this.colC_REASON_NAME,
            this.colC_REASON_CODE,
            this.colC_REASON_DEPMT_ID,
            this.colC_REASON_DEPMT_DESC,
            this.colC_SUGGESTION,
            this.colN_STATUS,
            this.colC_REMARK,
            this.colC_EMP_ID,
            this.colD_MOD_DT,
            this.colC_CHECK_EMP_ID,
            this.colD_CHECK_DT,
            this.C_AUDIT});
            this.gv_GPKJ.GridControl = this.gc_GPKJ;
            this.gv_GPKJ.Name = "gv_GPKJ";
            this.gv_GPKJ.OptionsView.ColumnAutoWidth = false;
            this.gv_GPKJ.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "主键";
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_SLAB_ID
            // 
            this.colC_SLAB_ID.FieldName = "C_SLAB_ID";
            this.colC_SLAB_ID.Name = "colC_SLAB_ID";
            // 
            // colC_STOVE1
            // 
            this.colC_STOVE1.Caption = "炉号";
            this.colC_STOVE1.FieldName = "C_STOVE";
            this.colC_STOVE1.Name = "colC_STOVE1";
            this.colC_STOVE1.Visible = true;
            this.colC_STOVE1.VisibleIndex = 0;
            // 
            // colC_STL_GRD1
            // 
            this.colC_STL_GRD1.Caption = "钢种";
            this.colC_STL_GRD1.FieldName = "C_STL_GRD";
            this.colC_STL_GRD1.Name = "colC_STL_GRD1";
            this.colC_STL_GRD1.Visible = true;
            this.colC_STL_GRD1.VisibleIndex = 1;
            // 
            // colN_WGT
            // 
            this.colN_WGT.Caption = "重量";
            this.colN_WGT.FieldName = "N_WGT";
            this.colN_WGT.Name = "colN_WGT";
            this.colN_WGT.Visible = true;
            this.colN_WGT.VisibleIndex = 3;
            // 
            // colC_STD_CODE1
            // 
            this.colC_STD_CODE1.Caption = "执行标准";
            this.colC_STD_CODE1.FieldName = "C_STD_CODE";
            this.colC_STD_CODE1.Name = "colC_STD_CODE1";
            this.colC_STD_CODE1.Visible = true;
            this.colC_STD_CODE1.VisibleIndex = 2;
            // 
            // colC_SLAB_SIZE
            // 
            this.colC_SLAB_SIZE.Caption = "断面";
            this.colC_SLAB_SIZE.FieldName = "C_SLAB_SIZE";
            this.colC_SLAB_SIZE.Name = "colC_SLAB_SIZE";
            this.colC_SLAB_SIZE.Visible = true;
            this.colC_SLAB_SIZE.VisibleIndex = 4;
            // 
            // colN_LEN1
            // 
            this.colN_LEN1.Caption = "定尺";
            this.colN_LEN1.FieldName = "N_LEN";
            this.colN_LEN1.Name = "colN_LEN1";
            this.colN_LEN1.Visible = true;
            this.colN_LEN1.VisibleIndex = 5;
            // 
            // colC_MAT_CODE1
            // 
            this.colC_MAT_CODE1.Caption = "物料编码";
            this.colC_MAT_CODE1.FieldName = "C_MAT_CODE";
            this.colC_MAT_CODE1.Name = "colC_MAT_CODE1";
            this.colC_MAT_CODE1.Visible = true;
            this.colC_MAT_CODE1.VisibleIndex = 6;
            // 
            // colC_MAT_NAME1
            // 
            this.colC_MAT_NAME1.Caption = "物料描述";
            this.colC_MAT_NAME1.FieldName = "C_MAT_NAME";
            this.colC_MAT_NAME1.Name = "colC_MAT_NAME1";
            this.colC_MAT_NAME1.Visible = true;
            this.colC_MAT_NAME1.VisibleIndex = 7;
            // 
            // colD_WAREHOUSE_IN
            // 
            this.colD_WAREHOUSE_IN.Caption = "入库时间";
            this.colD_WAREHOUSE_IN.DisplayFormat.FormatString = "G";
            this.colD_WAREHOUSE_IN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_WAREHOUSE_IN.FieldName = "D_WAREHOUSE_IN";
            this.colD_WAREHOUSE_IN.Name = "colD_WAREHOUSE_IN";
            this.colD_WAREHOUSE_IN.Visible = true;
            this.colD_WAREHOUSE_IN.VisibleIndex = 8;
            // 
            // colC_SHIFT
            // 
            this.colC_SHIFT.Caption = "班次";
            this.colC_SHIFT.FieldName = "C_SHIFT";
            this.colC_SHIFT.Name = "colC_SHIFT";
            // 
            // colC_GROUP
            // 
            this.colC_GROUP.Caption = "班组";
            this.colC_GROUP.FieldName = "C_GROUP";
            this.colC_GROUP.Name = "colC_GROUP";
            // 
            // colC_REASON_NAME
            // 
            this.colC_REASON_NAME.Caption = "不合格原因名称";
            this.colC_REASON_NAME.FieldName = "C_REASON_NAME";
            this.colC_REASON_NAME.Name = "colC_REASON_NAME";
            this.colC_REASON_NAME.Visible = true;
            this.colC_REASON_NAME.VisibleIndex = 9;
            // 
            // colC_REASON_CODE
            // 
            this.colC_REASON_CODE.Caption = "不合格原因代码";
            this.colC_REASON_CODE.FieldName = "C_REASON_CODE";
            this.colC_REASON_CODE.Name = "colC_REASON_CODE";
            this.colC_REASON_CODE.Visible = true;
            this.colC_REASON_CODE.VisibleIndex = 10;
            // 
            // colC_REASON_DEPMT_ID
            // 
            this.colC_REASON_DEPMT_ID.Caption = "责任单位代码";
            this.colC_REASON_DEPMT_ID.FieldName = "C_REASON_DEPMT_ID";
            this.colC_REASON_DEPMT_ID.Name = "colC_REASON_DEPMT_ID";
            this.colC_REASON_DEPMT_ID.Visible = true;
            this.colC_REASON_DEPMT_ID.VisibleIndex = 11;
            // 
            // colC_REASON_DEPMT_DESC
            // 
            this.colC_REASON_DEPMT_DESC.Caption = "责任单位描述";
            this.colC_REASON_DEPMT_DESC.FieldName = "C_REASON_DEPMT_DESC";
            this.colC_REASON_DEPMT_DESC.Name = "colC_REASON_DEPMT_DESC";
            this.colC_REASON_DEPMT_DESC.Visible = true;
            this.colC_REASON_DEPMT_DESC.VisibleIndex = 12;
            // 
            // colC_SUGGESTION
            // 
            this.colC_SUGGESTION.Caption = "处置意见";
            this.colC_SUGGESTION.FieldName = "C_SUGGESTION";
            this.colC_SUGGESTION.Name = "colC_SUGGESTION";
            this.colC_SUGGESTION.Visible = true;
            this.colC_SUGGESTION.VisibleIndex = 13;
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
            this.colC_REMARK.VisibleIndex = 16;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "库检人员";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 14;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "库检时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 15;
            // 
            // colC_CHECK_EMP_ID
            // 
            this.colC_CHECK_EMP_ID.Caption = "确认人";
            this.colC_CHECK_EMP_ID.FieldName = "C_CHECK_EMP_ID";
            this.colC_CHECK_EMP_ID.Name = "colC_CHECK_EMP_ID";
            this.colC_CHECK_EMP_ID.Visible = true;
            this.colC_CHECK_EMP_ID.VisibleIndex = 18;
            // 
            // colD_CHECK_DT
            // 
            this.colD_CHECK_DT.Caption = "确认时间";
            this.colD_CHECK_DT.DisplayFormat.FormatString = "G";
            this.colD_CHECK_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_CHECK_DT.FieldName = "D_CHECK_DT";
            this.colD_CHECK_DT.Name = "colD_CHECK_DT";
            this.colD_CHECK_DT.Visible = true;
            this.colD_CHECK_DT.VisibleIndex = 17;
            // 
            // C_AUDIT
            // 
            this.C_AUDIT.Caption = "审核意见";
            this.C_AUDIT.FieldName = "C_AUDIT";
            this.C_AUDIT.Name = "C_AUDIT";
            this.C_AUDIT.Visible = true;
            this.C_AUDIT.VisibleIndex = 19;
            // 
            // FrmQR_GPKJCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.gc_GPKJ);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmQR_GPKJCX";
            this.Text = "钢坯库检结果查询";
            this.Load += new System.EventHandler(this.FrmQC_KJQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_wh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPKJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPKJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.RadioGroup rbtn_isty_wh;
        private DevExpress.XtraEditors.SimpleButton txt_Query1;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.DateEdit dte_End;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.DateEdit dte_Begin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Stove1;
        private DevExpress.XtraGrid.GridControl gc_GPKJ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GPKJ;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SLAB_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STOVE1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD1;
        private DevExpress.XtraGrid.Columns.GridColumn colN_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SLAB_SIZE;
        private DevExpress.XtraGrid.Columns.GridColumn colN_LEN1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MAT_CODE1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_MAT_NAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colD_WAREHOUSE_IN;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SHIFT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_GROUP;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_DEPMT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REASON_DEPMT_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SUGGESTION;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_CHECK_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_CHECK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn C_AUDIT;
    }
}