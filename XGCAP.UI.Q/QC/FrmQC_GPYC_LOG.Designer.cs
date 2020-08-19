namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_GPYC_LOG
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
            this.gv_GPYC_Log = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_GPYC_Log = new DevExpress.XtraGrid.GridControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Stove = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dt_End = new DevExpress.XtraEditors.DateEdit();
            this.dt_Start = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPYC_Log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPYC_Log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_GPYC_Log
            // 
            this.gv_GPYC_Log.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn12,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn3,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn1});
            this.gv_GPYC_Log.GridControl = this.gc_GPYC_Log;
            this.gv_GPYC_Log.Name = "gv_GPYC_Log";
            this.gv_GPYC_Log.OptionsBehavior.Editable = false;
            this.gv_GPYC_Log.OptionsView.ColumnAutoWidth = false;
            this.gv_GPYC_Log.OptionsView.ShowFooter = true;
            this.gv_GPYC_Log.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "主键";
            this.gridColumn2.FieldName = "C_ID";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "炉号";
            this.gridColumn6.FieldName = "C_STOVE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "钢种";
            this.gridColumn7.FieldName = "C_STL_GRD";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "执行标准";
            this.gridColumn8.FieldName = "C_STD_CODE";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "物料编码";
            this.gridColumn9.FieldName = "C_MAT_CODE";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "物料描述";
            this.gridColumn12.FieldName = "C_MAT_NAME";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 4;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "断面";
            this.gridColumn17.FieldName = "C_SPEC";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 5;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "定尺";
            this.gridColumn18.FieldName = "N_LEN";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 6;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "原因";
            this.gridColumn3.FieldName = "C_REASON";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "操作人员";
            this.gridColumn19.FieldName = "C_EMP_ID";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 9;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "操作时间";
            this.gridColumn20.DisplayFormat.FormatString = "G";
            this.gridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn20.FieldName = "D_MOD_DT";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 10;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "备注";
            this.gridColumn21.FieldName = "C_REMARK";
            this.gridColumn21.Name = "gridColumn21";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "操作类型";
            this.gridColumn1.FieldName = "C_TYPE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            // 
            // gc_GPYC_Log
            // 
            this.gc_GPYC_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GPYC_Log.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_GPYC_Log.Location = new System.Drawing.Point(0, 45);
            this.gc_GPYC_Log.MainView = this.gv_GPYC_Log;
            this.gc_GPYC_Log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_GPYC_Log.Name = "gc_GPYC_Log";
            this.gc_GPYC_Log.Size = new System.Drawing.Size(1552, 785);
            this.gc_GPYC_Log.TabIndex = 18;
            this.gc_GPYC_Log.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GPYC_Log});
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(520, 13);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 53;
            this.labelControl2.Text = "炉号";
            // 
            // txt_Stove
            // 
            this.txt_Stove.Location = new System.Drawing.Point(558, 10);
            this.txt_Stove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stove.Name = "txt_Stove";
            this.txt_Stove.Size = new System.Drawing.Size(171, 24);
            this.txt_Stove.TabIndex = 54;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(745, 7);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(100, 29);
            this.btn_Query.TabIndex = 55;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_out);
            this.panel2.Controls.Add(this.dt_End);
            this.panel2.Controls.Add(this.dt_Start);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.btn_Query);
            this.panel2.Controls.Add(this.txt_Stove);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1552, 45);
            this.panel2.TabIndex = 17;
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(305, 11);
            this.dt_End.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dt_End.Size = new System.Drawing.Size(196, 24);
            this.dt_End.TabIndex = 59;
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(86, 11);
            this.dt_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dt_Start.Size = new System.Drawing.Size(196, 24);
            this.dt_Start.TabIndex = 58;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(289, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 18);
            this.labelControl1.TabIndex = 57;
            this.labelControl1.Text = "~";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 13);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 18);
            this.labelControl3.TabIndex = 56;
            this.labelControl3.Text = "操作时间：";
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(865, 7);
            this.btn_out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(102, 28);
            this.btn_out.TabIndex = 135;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // FrmQC_GPYC_LOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 830);
            this.Controls.Add(this.gc_GPYC_Log);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQC_GPYC_LOG";
            this.Text = "FrmQC_GPYC_LOG";
            this.Load += new System.EventHandler(this.FrmQC_GPYC_LOG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPYC_Log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPYC_Log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gv_GPYC_Log;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridControl gc_GPYC_Log;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Stove;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.DateEdit dt_End;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_out;
    }
}