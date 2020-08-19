namespace XGCAP.UI.Q.QR
{
    partial class FrmQR_ZXGP_CX
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_Start = new DevExpress.XtraEditors.DateEdit();
            this.txt_GZ = new DevExpress.XtraEditors.TextEdit();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Batch_Result = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dt_End = new DevExpress.XtraEditors.DateEdit();
            this.txt_BZ = new DevExpress.XtraEditors.TextEdit();
            this.gc_List = new DevExpress.XtraGrid.GridControl();
            this.gv_List = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dt_Start);
            this.panel1.Controls.Add(this.txt_GZ);
            this.panel1.Controls.Add(this.btn_out);
            this.panel1.Controls.Add(this.txt_Batch_Result);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.btn_Query);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.dt_End);
            this.panel1.Controls.Add(this.txt_BZ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 45);
            this.panel1.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 14);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 18);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "生产时间";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(713, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "钢种";
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(82, 10);
            this.dt_Start.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
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
            this.dt_Start.TabIndex = 37;
            // 
            // txt_GZ
            // 
            this.txt_GZ.Location = new System.Drawing.Point(750, 9);
            this.txt_GZ.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.txt_GZ.Name = "txt_GZ";
            this.txt_GZ.Size = new System.Drawing.Size(165, 24);
            this.txt_GZ.TabIndex = 37;
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(1234, 8);
            this.btn_out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(100, 28);
            this.btn_out.TabIndex = 133;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // txt_Batch_Result
            // 
            this.txt_Batch_Result.Location = new System.Drawing.Point(542, 9);
            this.txt_Batch_Result.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.txt_Batch_Result.Name = "txt_Batch_Result";
            this.txt_Batch_Result.Size = new System.Drawing.Size(165, 24);
            this.txt_Batch_Result.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(283, 14);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(11, 18);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "~";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(921, 13);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 134;
            this.labelControl2.Text = "标准";
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(1129, 8);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(100, 28);
            this.btn_Query.TabIndex = 36;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(505, 13);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "批号";
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(301, 10);
            this.dt_End.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
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
            this.dt_End.TabIndex = 38;
            // 
            // txt_BZ
            // 
            this.txt_BZ.Location = new System.Drawing.Point(958, 9);
            this.txt_BZ.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.txt_BZ.Name = "txt_BZ";
            this.txt_BZ.Size = new System.Drawing.Size(165, 24);
            this.txt_BZ.TabIndex = 135;
            // 
            // gc_List
            // 
            this.gc_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_List.Location = new System.Drawing.Point(0, 45);
            this.gc_List.MainView = this.gv_List;
            this.gc_List.Name = "gc_List";
            this.gc_List.Size = new System.Drawing.Size(1425, 643);
            this.gc_List.TabIndex = 7;
            this.gc_List.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_List});
            // 
            // gv_List
            // 
            this.gv_List.GridControl = this.gc_List;
            this.gv_List.Name = "gv_List";
            this.gv_List.OptionsBehavior.Editable = false;
            this.gv_List.OptionsView.ColumnAutoWidth = false;
            this.gv_List.OptionsView.ShowFooter = true;
            this.gv_List.OptionsView.ShowGroupPanel = false;
            // 
            // FrmQR_ZXGP_CX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 688);
            this.Controls.Add(this.gc_List);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQR_ZXGP_CX";
            this.Text = "在线改判查询";
            this.Load += new System.EventHandler(this.FrmQR_ZXGP_CX_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraEditors.TextEdit txt_GZ;
        private DevExpress.XtraEditors.SimpleButton btn_out;
        private DevExpress.XtraEditors.TextEdit txt_Batch_Result;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dt_End;
        private DevExpress.XtraEditors.TextEdit txt_BZ;
        private DevExpress.XtraGrid.GridControl gc_List;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_List;
    }
}