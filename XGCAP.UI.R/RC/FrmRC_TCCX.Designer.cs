namespace XGCAP.UI.R.RC
{
    partial class FrmRC_TCCX
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
            this.gc_GPGP = new DevExpress.XtraGrid.GridControl();
            this.gv_GPGP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dte_End = new DevExpress.XtraEditors.DateEdit();
            this.dte_Begin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Stove1 = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPGP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPGP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_GPGP
            // 
            this.gc_GPGP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GPGP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_GPGP.Location = new System.Drawing.Point(0, 45);
            this.gc_GPGP.MainView = this.gv_GPGP;
            this.gc_GPGP.Margin = new System.Windows.Forms.Padding(2);
            this.gc_GPGP.Name = "gc_GPGP";
            this.gc_GPGP.Size = new System.Drawing.Size(975, 507);
            this.gc_GPGP.TabIndex = 58;
            this.gc_GPGP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GPGP});
            // 
            // gv_GPGP
            // 
            this.gv_GPGP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn7,
            this.gridColumn6,
            this.gridColumn10});
            this.gv_GPGP.GridControl = this.gc_GPGP;
            this.gv_GPGP.Name = "gv_GPGP";
            this.gv_GPGP.OptionsBehavior.Editable = false;
            this.gv_GPGP.OptionsView.ColumnAutoWidth = false;
            this.gv_GPGP.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "开坯号";
            this.gridColumn1.FieldName = "C_BATCH_NO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "炉号";
            this.gridColumn2.FieldName = "C_STOVE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "入炉支数";
            this.gridColumn3.FieldName = "N_QUA_JOIN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "入炉重量";
            this.gridColumn4.FieldName = "N_WGT_JOIN";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "入炉状态";
            this.gridColumn5.FieldName = "N_ROLL_STATE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "出炉支数";
            this.gridColumn8.FieldName = "N_QUA_EXIT";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "出炉重量";
            this.gridColumn9.FieldName = "N_WGT_EXIT";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "操作人";
            this.gridColumn7.FieldName = "C_EMP_ID";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "操作时间";
            this.gridColumn6.FieldName = "D_MOD_DT";
            this.gridColumn6.GroupFormat.FormatString = "d";
            this.gridColumn6.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 9;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.dte_End);
            this.panelControl3.Controls.Add(this.dte_Begin);
            this.panelControl3.Controls.Add(this.labelControl16);
            this.panelControl3.Controls.Add(this.labelControl17);
            this.panelControl3.Controls.Add(this.btn_out);
            this.panelControl3.Controls.Add(this.txt_Stove1);
            this.panelControl3.Controls.Add(this.btn_Query1);
            this.panelControl3.Controls.Add(this.labelControl15);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(975, 45);
            this.panelControl3.TabIndex = 57;
            // 
            // dte_End
            // 
            this.dte_End.EditValue = null;
            this.dte_End.Location = new System.Drawing.Point(227, 11);
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
            this.dte_End.TabIndex = 141;
            // 
            // dte_Begin
            // 
            this.dte_Begin.EditValue = null;
            this.dte_Begin.Location = new System.Drawing.Point(62, 11);
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
            this.dte_Begin.TabIndex = 140;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(215, 14);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(9, 14);
            this.labelControl16.TabIndex = 139;
            this.labelControl16.Text = "~";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(10, 13);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(48, 14);
            this.labelControl17.TabIndex = 138;
            this.labelControl17.Text = "操作时间";
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(671, 9);
            this.btn_out.Margin = new System.Windows.Forms.Padding(2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(75, 22);
            this.btn_out.TabIndex = 137;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // txt_Stove1
            // 
            this.txt_Stove1.Location = new System.Drawing.Point(447, 10);
            this.txt_Stove1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Stove1.Name = "txt_Stove1";
            this.txt_Stove1.Size = new System.Drawing.Size(139, 20);
            this.txt_Stove1.TabIndex = 49;
            // 
            // btn_Query1
            // 
            this.btn_Query1.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query1.Location = new System.Drawing.Point(591, 9);
            this.btn_Query1.Name = "btn_Query1";
            this.btn_Query1.Size = new System.Drawing.Size(75, 23);
            this.btn_Query1.TabIndex = 48;
            this.btn_Query1.Text = "查询";
            this.btn_Query1.Click += new System.EventHandler(this.btn_Query1_Click);
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(378, 13);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(65, 14);
            this.labelControl15.TabIndex = 48;
            this.labelControl15.Text = "炉号/开坯号";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "操作部门";
            this.gridColumn10.FieldName = "STA";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 7;
            // 
            // FrmRC_TCCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 552);
            this.Controls.Add(this.gc_GPGP);
            this.Controls.Add(this.panelControl3);
            this.Name = "FrmRC_TCCX";
            this.Text = "FrmRC_TCCX";
            this.Load += new System.EventHandler(this.FrmRC_TCCX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_GPGP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GPGP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_GPGP;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GPGP;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_out;
        private DevExpress.XtraEditors.TextEdit txt_Stove1;
        private DevExpress.XtraEditors.SimpleButton btn_Query1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.DateEdit dte_End;
        private DevExpress.XtraEditors.DateEdit dte_Begin;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}