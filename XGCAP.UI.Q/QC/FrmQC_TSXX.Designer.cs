namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_TSXX
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gc_SJXX = new DevExpress.XtraGrid.GridControl();
            this.gv_SJXX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_STOVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_BATCH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_TICK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.N_WGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.D_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_MAT_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_QX = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.img_Tsxx_Query = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dt_End = new DevExpress.XtraEditors.DateEdit();
            this.dt_Start = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.image_TSXX = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Query_Main = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SJXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SJXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Tsxx_Query.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_TSXX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gc_SJXX);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 694);
            this.panel1.TabIndex = 0;
            // 
            // gc_SJXX
            // 
            this.gc_SJXX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SJXX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_SJXX.Location = new System.Drawing.Point(0, 79);
            this.gc_SJXX.MainView = this.gv_SJXX;
            this.gc_SJXX.Margin = new System.Windows.Forms.Padding(2);
            this.gc_SJXX.Name = "gc_SJXX";
            this.gc_SJXX.Size = new System.Drawing.Size(1084, 615);
            this.gc_SJXX.TabIndex = 51;
            this.gc_SJXX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SJXX});
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
            this.D_MOD_DT,
            this.C_MAT_CODE,
            this.C_MAT_DESC,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn6});
            this.gv_SJXX.GridControl = this.gc_SJXX;
            this.gv_SJXX.Name = "gv_SJXX";
            this.gv_SJXX.OptionsBehavior.Editable = false;
            this.gv_SJXX.OptionsSelection.MultiSelect = true;
            this.gv_SJXX.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_SJXX.OptionsView.ColumnAutoWidth = false;
            this.gv_SJXX.OptionsView.ShowFooter = true;
            this.gv_SJXX.OptionsView.ShowGroupPanel = false;
            // 
            // colC_STOVE
            // 
            this.colC_STOVE.Caption = "炉号";
            this.colC_STOVE.FieldName = "C_STOVE";
            this.colC_STOVE.Name = "colC_STOVE";
            this.colC_STOVE.Visible = true;
            this.colC_STOVE.VisibleIndex = 3;
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
            this.C_STL_GRD.VisibleIndex = 5;
            // 
            // N_WGT
            // 
            this.N_WGT.Caption = "重量";
            this.N_WGT.FieldName = "N_WGT";
            this.N_WGT.Name = "N_WGT";
            this.N_WGT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "N_WGT", "{0:0.##}")});
            this.N_WGT.Visible = true;
            this.N_WGT.VisibleIndex = 12;
            // 
            // colC_STD_CODE
            // 
            this.colC_STD_CODE.Caption = "执行标准";
            this.colC_STD_CODE.FieldName = "C_STD_CODE";
            this.colC_STD_CODE.Name = "colC_STD_CODE";
            this.colC_STD_CODE.Visible = true;
            this.colC_STD_CODE.VisibleIndex = 6;
            // 
            // colC_SPEC
            // 
            this.colC_SPEC.Caption = "规格";
            this.colC_SPEC.FieldName = "C_SPEC";
            this.colC_SPEC.Name = "colC_SPEC";
            this.colC_SPEC.Visible = true;
            this.colC_SPEC.VisibleIndex = 4;
            // 
            // D_MOD_DT
            // 
            this.D_MOD_DT.Caption = "生产时间";
            this.D_MOD_DT.DisplayFormat.FormatString = "G";
            this.D_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.D_MOD_DT.FieldName = "D_PRODUCE_DATE";
            this.D_MOD_DT.Name = "D_MOD_DT";
            this.D_MOD_DT.Visible = true;
            this.D_MOD_DT.VisibleIndex = 18;
            // 
            // C_MAT_CODE
            // 
            this.C_MAT_CODE.Caption = "物料编码";
            this.C_MAT_CODE.FieldName = "C_MAT_CODE";
            this.C_MAT_CODE.Name = "C_MAT_CODE";
            this.C_MAT_CODE.Visible = true;
            this.C_MAT_CODE.VisibleIndex = 10;
            // 
            // C_MAT_DESC
            // 
            this.C_MAT_DESC.Caption = "物料描述";
            this.C_MAT_DESC.FieldName = "C_MAT_DESC";
            this.C_MAT_DESC.Name = "C_MAT_DESC";
            this.C_MAT_DESC.Visible = true;
            this.C_MAT_DESC.VisibleIndex = 11;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "表面判定等级";
            this.gridColumn3.FieldName = "C_JUDGE_LEV_BP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 13;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "自由项2";
            this.gridColumn4.FieldName = "C_ZYX2";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 16;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "自由项1";
            this.gridColumn5.FieldName = "C_ZYX1";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 15;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "综合判定等级";
            this.gridColumn10.FieldName = "C_JUDGE_LEV_ZH";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 14;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "包装要求";
            this.gridColumn11.FieldName = "C_BZYQ";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 17;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "特殊信息";
            this.gridColumn1.FieldName = "C_PCINFO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "特殊信息操作人";
            this.gridColumn2.FieldName = "C_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 8;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "特殊信息操作时间";
            this.gridColumn6.FieldName = "C_PLANT_DESC";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 9;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_QX);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.img_Tsxx_Query);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dt_End);
            this.panelControl1.Controls.Add(this.dt_Start);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.image_TSXX);
            this.panelControl1.Controls.Add(this.btn_Query_Main);
            this.panelControl1.Controls.Add(this.txt_BatchNo);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 79);
            this.panelControl1.TabIndex = 49;
            // 
            // btn_QX
            // 
            this.btn_QX.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_QX.Location = new System.Drawing.Point(308, 38);
            this.btn_QX.Name = "btn_QX";
            this.btn_QX.Size = new System.Drawing.Size(112, 23);
            this.btn_QX.TabIndex = 31;
            this.btn_QX.Text = "取消特殊信息";
            this.btn_QX.Click += new System.EventHandler(this.btn_QX_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(544, 11);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "特殊信息";
            // 
            // img_Tsxx_Query
            // 
            this.img_Tsxx_Query.Location = new System.Drawing.Point(596, 8);
            this.img_Tsxx_Query.Name = "img_Tsxx_Query";
            this.img_Tsxx_Query.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.img_Tsxx_Query.Size = new System.Drawing.Size(148, 20);
            this.img_Tsxx_Query.TabIndex = 28;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 43);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "特殊信息";
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(227, 8);
            this.dt_End.Margin = new System.Windows.Forms.Padding(2);
            this.dt_End.Name = "dt_End";
            this.dt_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_End.Properties.DisplayFormat.FormatString = "G";
            this.dt_End.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_End.Properties.EditFormat.FormatString = "G";
            this.dt_End.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_End.Properties.Mask.EditMask = "G";
            this.dt_End.Size = new System.Drawing.Size(147, 20);
            this.dt_End.TabIndex = 26;
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(63, 8);
            this.dt_Start.Margin = new System.Windows.Forms.Padding(2);
            this.dt_Start.Name = "dt_Start";
            this.dt_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Start.Properties.DisplayFormat.FormatString = "G";
            this.dt_Start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Start.Properties.EditFormat.FormatString = "G";
            this.dt_Start.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Start.Properties.Mask.EditMask = "G";
            this.dt_Start.Size = new System.Drawing.Size(147, 20);
            this.dt_Start.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(214, 10);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(9, 14);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "~";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "生产时间";
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Edit;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(227, 38);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 22;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // image_TSXX
            // 
            this.image_TSXX.Location = new System.Drawing.Point(62, 40);
            this.image_TSXX.Name = "image_TSXX";
            this.image_TSXX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.image_TSXX.Size = new System.Drawing.Size(148, 20);
            this.image_TSXX.TabIndex = 21;
            // 
            // btn_Query_Main
            // 
            this.btn_Query_Main.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query_Main.Location = new System.Drawing.Point(759, 6);
            this.btn_Query_Main.Name = "btn_Query_Main";
            this.btn_Query_Main.Size = new System.Drawing.Size(75, 23);
            this.btn_Query_Main.TabIndex = 20;
            this.btn_Query_Main.Text = "查询";
            this.btn_Query_Main.Click += new System.EventHandler(this.btn_Query_Main_Click);
            // 
            // txt_BatchNo
            // 
            this.txt_BatchNo.Location = new System.Drawing.Point(407, 8);
            this.txt_BatchNo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BatchNo.Name = "txt_BatchNo";
            this.txt_BatchNo.Size = new System.Drawing.Size(128, 20);
            this.txt_BatchNo.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(379, 11);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "批号";
            // 
            // FrmQC_TSXX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 694);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQC_TSXX";
            this.Text = "FrmQC_TSXX";
            this.Load += new System.EventHandler(this.FrmQC_TSXX_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_SJXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SJXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Tsxx_Query.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_TSXX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gc_SJXX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SJXX;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STOVE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_BATCH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn C_TICK_NO;
        private DevExpress.XtraGrid.Columns.GridColumn C_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn N_WGT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn D_MOD_DT;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn C_MAT_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.ImageComboBoxEdit image_TSXX;
        private DevExpress.XtraEditors.SimpleButton btn_Query_Main;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ImageComboBoxEdit img_Tsxx_Query;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dt_End;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btn_QX;
    }
}