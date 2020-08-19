namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_XLSQ_Select
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
            this.txt_STLGRD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            this.dte_End1 = new DevExpress.XtraEditors.DateEdit();
            this.dte_Begin1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gc_XL = new DevExpress.XtraGrid.GridControl();
            this.gv_XL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_Type = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STLGRD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_XL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_XL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Type.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_STLGRD
            // 
            this.txt_STLGRD.Location = new System.Drawing.Point(614, 6);
            this.txt_STLGRD.Margin = new System.Windows.Forms.Padding(2);
            this.txt_STLGRD.Name = "txt_STLGRD";
            this.txt_STLGRD.Size = new System.Drawing.Size(128, 20);
            this.txt_STLGRD.TabIndex = 138;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(586, 9);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 137;
            this.labelControl4.Text = "钢种";
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(959, 5);
            this.btn_out.Margin = new System.Windows.Forms.Padding(2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(75, 22);
            this.btn_out.TabIndex = 136;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // dte_End1
            // 
            this.dte_End1.EditValue = null;
            this.dte_End1.Location = new System.Drawing.Point(264, 6);
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
            this.dte_End1.TabIndex = 60;
            // 
            // dte_Begin1
            // 
            this.dte_Begin1.EditValue = null;
            this.dte_Begin1.Location = new System.Drawing.Point(99, 6);
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
            this.dte_Begin1.TabIndex = 59;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(252, 9);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(9, 14);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "~";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 9);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "修料申请时间";
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(879, 5);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 23;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txt_BatchNo1
            // 
            this.txt_BatchNo1.Location = new System.Drawing.Point(448, 6);
            this.txt_BatchNo1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BatchNo1.Name = "txt_BatchNo1";
            this.txt_BatchNo1.Size = new System.Drawing.Size(128, 20);
            this.txt_BatchNo1.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(420, 9);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "批号";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.txt_STLGRD);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.btn_out);
            this.panel1.Controls.Add(this.txt_BatchNo1);
            this.panel1.Controls.Add(this.dte_End1);
            this.panel1.Controls.Add(this.btn_Query);
            this.panel1.Controls.Add(this.dte_Begin1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.imgcbo_Type);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 36);
            this.panel1.TabIndex = 54;
            // 
            // gc_XL
            // 
            this.gc_XL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_XL.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_XL.Location = new System.Drawing.Point(0, 36);
            this.gc_XL.MainView = this.gv_XL;
            this.gc_XL.Margin = new System.Windows.Forms.Padding(2);
            this.gc_XL.Name = "gc_XL";
            this.gc_XL.Size = new System.Drawing.Size(1225, 696);
            this.gc_XL.TabIndex = 55;
            this.gc_XL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_XL});
            // 
            // gv_XL
            // 
            this.gv_XL.GridControl = this.gc_XL;
            this.gv_XL.Name = "gv_XL";
            this.gv_XL.OptionsBehavior.Editable = false;
            this.gv_XL.OptionsView.ColumnAutoWidth = false;
            this.gv_XL.OptionsView.ShowFooter = true;
            this.gv_XL.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(748, 9);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 139;
            this.labelControl5.Text = "修料状态";
            // 
            // imgcbo_Type
            // 
            this.imgcbo_Type.EditValue = "未完成";
            this.imgcbo_Type.Location = new System.Drawing.Point(800, 6);
            this.imgcbo_Type.Margin = new System.Windows.Forms.Padding(2);
            this.imgcbo_Type.Name = "imgcbo_Type";
            this.imgcbo_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_Type.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("未完成", "未完成", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("已完成", "已完成", -1)});
            this.imgcbo_Type.Size = new System.Drawing.Size(72, 20);
            this.imgcbo_Type.TabIndex = 140;
            // 
            // FrmQC_XLSQ_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 732);
            this.Controls.Add(this.gc_XL);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQC_XLSQ_Select";
            this.Text = "FrmQC_XL";
            this.Load += new System.EventHandler(this.FrmQC_XLSQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_STLGRD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_End1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Begin1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_XL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_XL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Type.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dte_End1;
        private DevExpress.XtraEditors.DateEdit dte_Begin1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_out;
        private DevExpress.XtraEditors.TextEdit txt_STLGRD;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_Type;
        private DevExpress.XtraGrid.GridControl gc_XL;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_XL;
    }
}