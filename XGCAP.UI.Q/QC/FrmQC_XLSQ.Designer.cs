namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_XLSQ
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dte_End1 = new DevExpress.XtraEditors.DateEdit();
            this.dte_Begin1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Query_Main = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_Type = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_QXSQ = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Apply = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CZYJ = new DevExpress.XtraEditors.MemoEdit();
            this.gc_XL = new DevExpress.XtraGrid.GridControl();
            this.gv_XL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_SJXX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_SJXX = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CZYJ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_XL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_XL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SJXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SJXX)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.dte_End1);
            this.panelControl1.Controls.Add(this.dte_Begin1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btn_Query_Main);
            this.panelControl1.Controls.Add(this.txt_BatchNo);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.imgcbo_Type);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1225, 40);
            this.panelControl1.TabIndex = 49;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(521, 12);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 57;
            this.labelControl6.Text = "状态";
            // 
            // dte_End1
            // 
            this.dte_End1.EditValue = null;
            this.dte_End1.Location = new System.Drawing.Point(206, 9);
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
            this.dte_End1.TabIndex = 56;
            // 
            // dte_Begin1
            // 
            this.dte_Begin1.EditValue = null;
            this.dte_Begin1.Location = new System.Drawing.Point(41, 9);
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
            this.dte_Begin1.TabIndex = 55;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(194, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(9, 14);
            this.labelControl1.TabIndex = 54;
            this.labelControl1.Text = "~";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 12);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 53;
            this.labelControl2.Text = "时间";
            // 
            // btn_Query_Main
            // 
            this.btn_Query_Main.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query_Main.Location = new System.Drawing.Point(682, 8);
            this.btn_Query_Main.Name = "btn_Query_Main";
            this.btn_Query_Main.Size = new System.Drawing.Size(75, 23);
            this.btn_Query_Main.TabIndex = 20;
            this.btn_Query_Main.Text = "查询";
            this.btn_Query_Main.Click += new System.EventHandler(this.btn_Query_Main_Click);
            // 
            // txt_BatchNo
            // 
            this.txt_BatchNo.Location = new System.Drawing.Point(385, 9);
            this.txt_BatchNo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BatchNo.Name = "txt_BatchNo";
            this.txt_BatchNo.Size = new System.Drawing.Size(128, 20);
            this.txt_BatchNo.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(357, 12);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "批号";
            // 
            // imgcbo_Type
            // 
            this.imgcbo_Type.EditValue = "复检";
            this.imgcbo_Type.Location = new System.Drawing.Point(549, 9);
            this.imgcbo_Type.Margin = new System.Windows.Forms.Padding(2);
            this.imgcbo_Type.Name = "imgcbo_Type";
            this.imgcbo_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_Type.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("复检", "复检", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("线材库检", "线材库检", -1)});
            this.imgcbo_Type.Size = new System.Drawing.Size(128, 20);
            this.imgcbo_Type.TabIndex = 58;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 306);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1225, 5);
            this.splitterControl1.TabIndex = 51;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.btn_QXSQ);
            this.panelControl2.Controls.Add(this.btn_Apply);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.txt_BatchNo1);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.txt_CZYJ);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 311);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1225, 94);
            this.panelControl2.TabIndex = 52;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 8);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "处置意见";
            // 
            // btn_QXSQ
            // 
            this.btn_QXSQ.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_QXSQ.Location = new System.Drawing.Point(287, 64);
            this.btn_QXSQ.Name = "btn_QXSQ";
            this.btn_QXSQ.Size = new System.Drawing.Size(86, 23);
            this.btn_QXSQ.TabIndex = 24;
            this.btn_QXSQ.Text = "取消申请";
            this.btn_QXSQ.Click += new System.EventHandler(this.btn_QXSQ_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.ImageUri.Uri = "Apply;Size16x16";
            this.btn_Apply.Location = new System.Drawing.Point(418, 31);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(75, 23);
            this.btn_Apply.TabIndex = 24;
            this.btn_Apply.Text = "申请";
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(206, 64);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 23;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txt_BatchNo1
            // 
            this.txt_BatchNo1.Location = new System.Drawing.Point(65, 65);
            this.txt_BatchNo1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BatchNo1.Name = "txt_BatchNo1";
            this.txt_BatchNo1.Size = new System.Drawing.Size(128, 20);
            this.txt_BatchNo1.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 68);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "批号";
            // 
            // txt_CZYJ
            // 
            this.txt_CZYJ.Location = new System.Drawing.Point(65, 5);
            this.txt_CZYJ.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CZYJ.Name = "txt_CZYJ";
            this.txt_CZYJ.Size = new System.Drawing.Size(348, 49);
            this.txt_CZYJ.TabIndex = 26;
            // 
            // gc_XL
            // 
            this.gc_XL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_XL.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_XL.Location = new System.Drawing.Point(0, 405);
            this.gc_XL.MainView = this.gv_XL;
            this.gc_XL.Margin = new System.Windows.Forms.Padding(2);
            this.gc_XL.Name = "gc_XL";
            this.gc_XL.Size = new System.Drawing.Size(1225, 327);
            this.gc_XL.TabIndex = 53;
            this.gc_XL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_XL});
            // 
            // gv_XL
            // 
            this.gv_XL.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn18});
            this.gv_XL.GridControl = this.gc_XL;
            this.gv_XL.Name = "gv_XL";
            this.gv_XL.OptionsBehavior.Editable = false;
            this.gv_XL.OptionsView.ColumnAutoWidth = false;
            this.gv_XL.OptionsView.ShowFooter = true;
            this.gv_XL.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "批号";
            this.gridColumn2.FieldName = "C_BATCH_NO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "C_ID";
            this.gridColumn20.FieldName = "C_ID";
            this.gridColumn20.Name = "gridColumn20";
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "操作人";
            this.gridColumn21.FieldName = "C_EMP_ID";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 2;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "操作时间";
            this.gridColumn22.DisplayFormat.FormatString = "G";
            this.gridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn22.FieldName = "D_MOD_DT";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 3;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "处置意见";
            this.gridColumn18.FieldName = "C_REMARK";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 1;
            // 
            // gv_SJXX
            // 
            this.gv_SJXX.GridControl = this.gc_SJXX;
            this.gv_SJXX.Name = "gv_SJXX";
            this.gv_SJXX.OptionsBehavior.Editable = false;
            this.gv_SJXX.OptionsView.ColumnAutoWidth = false;
            this.gv_SJXX.OptionsView.ShowFooter = true;
            this.gv_SJXX.OptionsView.ShowGroupPanel = false;
            this.gv_SJXX.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_SJXX_FocusedRowChanged);
            // 
            // gc_SJXX
            // 
            this.gc_SJXX.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_SJXX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_SJXX.Location = new System.Drawing.Point(0, 40);
            this.gc_SJXX.MainView = this.gv_SJXX;
            this.gc_SJXX.Margin = new System.Windows.Forms.Padding(2);
            this.gc_SJXX.Name = "gc_SJXX";
            this.gc_SJXX.Size = new System.Drawing.Size(1225, 266);
            this.gc_SJXX.TabIndex = 50;
            this.gc_SJXX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SJXX});
            // 
            // FrmQC_XLSQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 732);
            this.Controls.Add(this.gc_XL);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gc_SJXX);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQC_XLSQ";
            this.Text = "FrmQC_XL";
            this.Load += new System.EventHandler(this.FrmQC_XLSQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CZYJ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_XL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_XL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SJXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SJXX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dte_End1;
        private DevExpress.XtraEditors.DateEdit dte_Begin1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Query_Main;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Apply;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gc_XL;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_XL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txt_CZYJ;
        private DevExpress.XtraEditors.SimpleButton btn_QXSQ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SJXX;
        private DevExpress.XtraGrid.GridControl gc_SJXX;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_Type;
    }
}