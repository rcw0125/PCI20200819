namespace XGCAP.UI.Q.QR
{
    partial class FrmQR_XNCX
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dt_Start_Result = new DevExpress.XtraEditors.DateEdit();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Result = new DevExpress.XtraEditors.SimpleButton();
            this.dt_End_Result = new DevExpress.XtraEditors.DateEdit();
            this.txt_STLGRD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_Name = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.txt_Batch_Result = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gc_Result = new DevExpress.XtraGrid.GridControl();
            this.gv_Result = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STLGRD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1227, 46);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.dt_Start_Result);
            this.panel1.Controls.Add(this.btn_out);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.btn_Result);
            this.panel1.Controls.Add(this.dt_End_Result);
            this.panel1.Controls.Add(this.txt_STLGRD);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.imgcbo_Name);
            this.panel1.Controls.Add(this.txt_Batch_Result);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 43);
            this.panel1.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 10);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "录入时间";
            // 
            // dt_Start_Result
            // 
            this.dt_Start_Result.EditValue = null;
            this.dt_Start_Result.Location = new System.Drawing.Point(63, 7);
            this.dt_Start_Result.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.dt_Start_Result.Name = "dt_Start_Result";
            this.dt_Start_Result.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Start_Result.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_Start_Result.Properties.DisplayFormat.FormatString = "G";
            this.dt_Start_Result.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Start_Result.Properties.EditFormat.FormatString = "G";
            this.dt_Start_Result.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Start_Result.Properties.Mask.EditMask = "G";
            this.dt_Start_Result.Size = new System.Drawing.Size(147, 20);
            this.dt_Start_Result.TabIndex = 37;
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(959, 6);
            this.btn_out.Margin = new System.Windows.Forms.Padding(2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(75, 22);
            this.btn_out.TabIndex = 133;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(214, 10);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(9, 14);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "~";
            // 
            // btn_Result
            // 
            this.btn_Result.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Result.Location = new System.Drawing.Point(880, 6);
            this.btn_Result.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(75, 22);
            this.btn_Result.TabIndex = 36;
            this.btn_Result.Text = "查询";
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // dt_End_Result
            // 
            this.dt_End_Result.EditValue = null;
            this.dt_End_Result.Location = new System.Drawing.Point(227, 7);
            this.dt_End_Result.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.dt_End_Result.Name = "dt_End_Result";
            this.dt_End_Result.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_End_Result.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_End_Result.Properties.DisplayFormat.FormatString = "G";
            this.dt_End_Result.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_End_Result.Properties.EditFormat.FormatString = "G";
            this.dt_End_Result.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_End_Result.Properties.Mask.EditMask = "G";
            this.dt_End_Result.Size = new System.Drawing.Size(147, 20);
            this.dt_End_Result.TabIndex = 38;
            // 
            // txt_STLGRD
            // 
            this.txt_STLGRD.Location = new System.Drawing.Point(752, 7);
            this.txt_STLGRD.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txt_STLGRD.Name = "txt_STLGRD";
            this.txt_STLGRD.Size = new System.Drawing.Size(124, 20);
            this.txt_STLGRD.TabIndex = 35;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(379, 10);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 39;
            this.labelControl8.Text = "性能名称";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(724, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "钢种";
            // 
            // imgcbo_Name
            // 
            this.imgcbo_Name.Location = new System.Drawing.Point(433, 7);
            this.imgcbo_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.imgcbo_Name.Name = "imgcbo_Name";
            this.imgcbo_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_Name.Size = new System.Drawing.Size(130, 20);
            this.imgcbo_Name.TabIndex = 40;
            // 
            // txt_Batch_Result
            // 
            this.txt_Batch_Result.Location = new System.Drawing.Point(596, 7);
            this.txt_Batch_Result.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txt_Batch_Result.Name = "txt_Batch_Result";
            this.txt_Batch_Result.Size = new System.Drawing.Size(124, 20);
            this.txt_Batch_Result.TabIndex = 35;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(568, 10);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "批号";
            // 
            // gc_Result
            // 
            this.gc_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Result.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Result.Location = new System.Drawing.Point(0, 46);
            this.gc_Result.MainView = this.gv_Result;
            this.gc_Result.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Result.Name = "gc_Result";
            this.gc_Result.Size = new System.Drawing.Size(1227, 619);
            this.gc_Result.TabIndex = 1;
            this.gc_Result.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Result});
            // 
            // gv_Result
            // 
            this.gv_Result.GridControl = this.gc_Result;
            this.gv_Result.Name = "gv_Result";
            this.gv_Result.OptionsBehavior.Editable = false;
            this.gv_Result.OptionsView.ColumnAutoWidth = false;
            this.gv_Result.OptionsView.ShowGroupPanel = false;
            // 
            // FrmQR_XNCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 665);
            this.Controls.Add(this.gc_Result);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQR_XNCX";
            this.Text = "性能结果查询";
            this.Load += new System.EventHandler(this.FrmQR_XNCX_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STLGRD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dt_Start_Result;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dt_End_Result;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_Name;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Batch_Result;
        private DevExpress.XtraEditors.SimpleButton btn_Result;
        private DevExpress.XtraEditors.SimpleButton btn_out;
        private DevExpress.XtraGrid.GridControl gc_Result;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Result;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_STLGRD;
        private System.Windows.Forms.Panel panel1;
    }
}