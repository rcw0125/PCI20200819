namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_XNJGQR
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
            this.gc_SQLB = new DevExpress.XtraGrid.GridControl();
            this.gv_SQLB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_BATCH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_TICK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID_ZY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT_ZY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID_JS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT_JS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_PHYSICS_GROUP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_CHECK_STATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_RECHECK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_QR = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.rbtn_isty_wh = new DevExpress.XtraEditors.RadioGroup();
            this.dte_End1 = new DevExpress.XtraEditors.DateEdit();
            this.dte_Begin1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Query_Sam = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo_Sam = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SQLB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SQLB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_wh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo_Sam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_SQLB
            // 
            this.gc_SQLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SQLB.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_SQLB.Location = new System.Drawing.Point(0, 39);
            this.gc_SQLB.MainView = this.gv_SQLB;
            this.gc_SQLB.Margin = new System.Windows.Forms.Padding(2);
            this.gc_SQLB.Name = "gc_SQLB";
            this.gc_SQLB.Size = new System.Drawing.Size(1124, 579);
            this.gc_SQLB.TabIndex = 60;
            this.gc_SQLB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SQLB});
            // 
            // gv_SQLB
            // 
            this.gv_SQLB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_BATCH_NO,
            this.colC_TICK_NO,
            this.colC_STL_GRD,
            this.colC_SPEC,
            this.colC_EMP_ID,
            this.colD_MOD_DT,
            this.colC_EMP_ID_ZY,
            this.colD_MOD_DT_ZY,
            this.colC_EMP_ID_JS,
            this.colD_MOD_DT_JS,
            this.colC_PHYSICS_GROUP_ID,
            this.colC_CHECK_STATE,
            this.colN_RECHECK,
            this.colN_STATUS,
            this.colC_REMARK,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gv_SQLB.GridControl = this.gc_SQLB;
            this.gv_SQLB.Name = "gv_SQLB";
            this.gv_SQLB.OptionsBehavior.Editable = false;
            this.gv_SQLB.OptionsSelection.MultiSelect = true;
            this.gv_SQLB.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_SQLB.OptionsView.ColumnAutoWidth = false;
            this.gv_SQLB.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "主键";
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_BATCH_NO
            // 
            this.colC_BATCH_NO.Caption = "批号";
            this.colC_BATCH_NO.FieldName = "C_BATCH_NO";
            this.colC_BATCH_NO.Name = "colC_BATCH_NO";
            this.colC_BATCH_NO.Visible = true;
            this.colC_BATCH_NO.VisibleIndex = 1;
            // 
            // colC_TICK_NO
            // 
            this.colC_TICK_NO.Caption = "钩号";
            this.colC_TICK_NO.FieldName = "C_TICK_NO";
            this.colC_TICK_NO.Name = "colC_TICK_NO";
            this.colC_TICK_NO.Visible = true;
            this.colC_TICK_NO.VisibleIndex = 2;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 3;
            // 
            // colC_SPEC
            // 
            this.colC_SPEC.Caption = "规格";
            this.colC_SPEC.FieldName = "C_SPEC";
            this.colC_SPEC.Name = "colC_SPEC";
            this.colC_SPEC.Visible = true;
            this.colC_SPEC.VisibleIndex = 4;
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "送样人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "送样时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            // 
            // colC_EMP_ID_ZY
            // 
            this.colC_EMP_ID_ZY.Caption = "制样人";
            this.colC_EMP_ID_ZY.FieldName = "C_EMP_ID_ZY";
            this.colC_EMP_ID_ZY.Name = "colC_EMP_ID_ZY";
            // 
            // colD_MOD_DT_ZY
            // 
            this.colD_MOD_DT_ZY.Caption = "制样时间";
            this.colD_MOD_DT_ZY.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT_ZY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT_ZY.FieldName = "D_MOD_DT_ZY";
            this.colD_MOD_DT_ZY.Name = "colD_MOD_DT_ZY";
            // 
            // colC_EMP_ID_JS
            // 
            this.colC_EMP_ID_JS.Caption = "样品接收人";
            this.colC_EMP_ID_JS.FieldName = "C_EMP_ID_JS";
            this.colC_EMP_ID_JS.Name = "colC_EMP_ID_JS";
            this.colC_EMP_ID_JS.Visible = true;
            this.colC_EMP_ID_JS.VisibleIndex = 10;
            // 
            // colD_MOD_DT_JS
            // 
            this.colD_MOD_DT_JS.Caption = "样品接收时间";
            this.colD_MOD_DT_JS.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT_JS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT_JS.FieldName = "D_MOD_DT_JS";
            this.colD_MOD_DT_JS.Name = "colD_MOD_DT_JS";
            this.colD_MOD_DT_JS.Visible = true;
            this.colD_MOD_DT_JS.VisibleIndex = 11;
            this.colD_MOD_DT_JS.Width = 92;
            // 
            // colC_PHYSICS_GROUP_ID
            // 
            this.colC_PHYSICS_GROUP_ID.Caption = "物理性能外键";
            this.colC_PHYSICS_GROUP_ID.FieldName = "C_PHYSICS_GROUP_ID";
            this.colC_PHYSICS_GROUP_ID.Name = "colC_PHYSICS_GROUP_ID";
            this.colC_PHYSICS_GROUP_ID.Width = 96;
            // 
            // colC_CHECK_STATE
            // 
            this.colC_CHECK_STATE.Caption = "状态";
            this.colC_CHECK_STATE.FieldName = "C_CHECK_STATE";
            this.colC_CHECK_STATE.Name = "colC_CHECK_STATE";
            this.colC_CHECK_STATE.Visible = true;
            this.colC_CHECK_STATE.VisibleIndex = 9;
            // 
            // colN_RECHECK
            // 
            this.colN_RECHECK.Caption = "第几次复检";
            this.colN_RECHECK.FieldName = "N_RECHECK";
            this.colN_RECHECK.Name = "colN_RECHECK";
            this.colN_RECHECK.Visible = true;
            this.colN_RECHECK.VisibleIndex = 8;
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.Caption = "是否确认";
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
            this.colN_STATUS.Visible = true;
            this.colN_STATUS.VisibleIndex = 13;
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.Caption = "备注";
            this.colC_REMARK.FieldName = "C_REMARK";
            this.colC_REMARK.Name = "colC_REMARK";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "项目编码";
            this.gridColumn1.FieldName = "C_CODE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "项目名称";
            this.gridColumn2.FieldName = "C_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "确认状态";
            this.gridColumn3.FieldName = "C_QRZT";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "处置意见";
            this.gridColumn4.FieldName = "C_DISPOSAL";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 12;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "检验项目";
            this.gridColumn5.FieldName = "C_ITEM_NAME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            // 
            // btn_QR
            // 
            this.btn_QR.ImageUri.Uri = "Apply;Size16x16";
            this.btn_QR.Location = new System.Drawing.Point(745, 8);
            this.btn_QR.Name = "btn_QR";
            this.btn_QR.Size = new System.Drawing.Size(75, 23);
            this.btn_QR.TabIndex = 38;
            this.btn_QR.Text = "确认";
            this.btn_QR.Click += new System.EventHandler(this.btn_QR_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.rbtn_isty_wh);
            this.panelControl4.Controls.Add(this.btn_QR);
            this.panelControl4.Controls.Add(this.dte_End1);
            this.panelControl4.Controls.Add(this.dte_Begin1);
            this.panelControl4.Controls.Add(this.labelControl5);
            this.panelControl4.Controls.Add(this.labelControl6);
            this.panelControl4.Controls.Add(this.btn_Query_Sam);
            this.panelControl4.Controls.Add(this.txt_BatchNo_Sam);
            this.panelControl4.Controls.Add(this.labelControl9);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1124, 39);
            this.panelControl4.TabIndex = 58;
            // 
            // rbtn_isty_wh
            // 
            this.rbtn_isty_wh.Location = new System.Drawing.Point(527, 6);
            this.rbtn_isty_wh.Name = "rbtn_isty_wh";
            this.rbtn_isty_wh.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_isty_wh.Properties.Appearance.Options.UseBackColor = true;
            this.rbtn_isty_wh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rbtn_isty_wh.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "未确认"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "已确认")});
            this.rbtn_isty_wh.Size = new System.Drawing.Size(131, 27);
            this.rbtn_isty_wh.TabIndex = 130;
            // 
            // dte_End1
            // 
            this.dte_End1.EditValue = null;
            this.dte_End1.Location = new System.Drawing.Point(207, 9);
            this.dte_End1.Margin = new System.Windows.Forms.Padding(2);
            this.dte_End1.Name = "dte_End1";
            this.dte_End1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_End1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_End1.Properties.DisplayFormat.FormatString = "G";
            this.dte_End1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_End1.Properties.EditFormat.FormatString = "G";
            this.dte_End1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_End1.Properties.Mask.EditMask = "G";
            this.dte_End1.Size = new System.Drawing.Size(147, 20);
            this.dte_End1.TabIndex = 36;
            // 
            // dte_Begin1
            // 
            this.dte_Begin1.EditValue = null;
            this.dte_Begin1.Location = new System.Drawing.Point(39, 9);
            this.dte_Begin1.Margin = new System.Windows.Forms.Padding(2);
            this.dte_Begin1.Name = "dte_Begin1";
            this.dte_Begin1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Begin1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Begin1.Properties.DisplayFormat.FormatString = "G";
            this.dte_Begin1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_Begin1.Properties.EditFormat.FormatString = "G";
            this.dte_Begin1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_Begin1.Properties.Mask.EditMask = "G";
            this.dte_Begin1.Size = new System.Drawing.Size(147, 20);
            this.dte_Begin1.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(192, 12);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(9, 14);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "~";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 12);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "时间";
            // 
            // btn_Query_Sam
            // 
            this.btn_Query_Sam.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query_Sam.Location = new System.Drawing.Point(664, 8);
            this.btn_Query_Sam.Name = "btn_Query_Sam";
            this.btn_Query_Sam.Size = new System.Drawing.Size(75, 23);
            this.btn_Query_Sam.TabIndex = 30;
            this.btn_Query_Sam.Text = "查询";
            this.btn_Query_Sam.Click += new System.EventHandler(this.btn_Query_Sam_Click);
            // 
            // txt_BatchNo_Sam
            // 
            this.txt_BatchNo_Sam.Location = new System.Drawing.Point(394, 9);
            this.txt_BatchNo_Sam.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BatchNo_Sam.Name = "txt_BatchNo_Sam";
            this.txt_BatchNo_Sam.Size = new System.Drawing.Size(128, 20);
            this.txt_BatchNo_Sam.TabIndex = 19;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(364, 12);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 14);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "批号";
            // 
            // FrmQC_XNJGQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 618);
            this.Controls.Add(this.gc_SQLB);
            this.Controls.Add(this.panelControl4);
            this.Name = "FrmQC_XNJGQR";
            this.Text = "FrmQC_XNJGQR";
            this.Load += new System.EventHandler(this.FrmQC_XNJGQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SQLB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SQLB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_wh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo_Sam.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_SQLB;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SQLB;
        private DevExpress.XtraEditors.SimpleButton btn_QR;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.DateEdit dte_End1;
        private DevExpress.XtraEditors.DateEdit dte_Begin1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btn_Query_Sam;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo_Sam;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_BATCH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colC_TICK_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID_ZY;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT_ZY;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID_JS;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT_JS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_PHYSICS_GROUP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_CHECK_STATE;
        private DevExpress.XtraGrid.Columns.GridColumn colN_RECHECK;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.RadioGroup rbtn_isty_wh;
    }
}