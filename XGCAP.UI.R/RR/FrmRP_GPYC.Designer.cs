﻿namespace XGCAP.UI.R.RR
{
    partial class FrmRP_GPYC
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dt_Start = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dt_End = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Stove = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_GZ = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Main = new DevExpress.XtraGrid.GridControl();
            this.gv_Main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelControl6);
            this.flowLayoutPanel1.Controls.Add(this.dt_Start);
            this.flowLayoutPanel1.Controls.Add(this.labelControl5);
            this.flowLayoutPanel1.Controls.Add(this.dt_End);
            this.flowLayoutPanel1.Controls.Add(this.labelControl3);
            this.flowLayoutPanel1.Controls.Add(this.txt_Stove);
            this.flowLayoutPanel1.Controls.Add(this.labelControl1);
            this.flowLayoutPanel1.Controls.Add(this.txt_GZ);
            this.flowLayoutPanel1.Controls.Add(this.btn_Query);
            this.flowLayoutPanel1.Controls.Add(this.btn_out);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1023, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(2, 6);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "生产时间";
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(54, 4);
            this.dt_Start.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
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
            this.dt_Start.TabIndex = 37;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(205, 6);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(9, 14);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "~";
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(218, 4);
            this.dt_End.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
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
            this.dt_End.TabIndex = 38;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(369, 6);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 14);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "炉/批号";
            // 
            // txt_Stove
            // 
            this.txt_Stove.Location = new System.Drawing.Point(414, 4);
            this.txt_Stove.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txt_Stove.Name = "txt_Stove";
            this.txt_Stove.Size = new System.Drawing.Size(124, 20);
            this.txt_Stove.TabIndex = 35;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(542, 6);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "钢种";
            // 
            // txt_GZ
            // 
            this.txt_GZ.Location = new System.Drawing.Point(570, 4);
            this.txt_GZ.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txt_GZ.Name = "txt_GZ";
            this.txt_GZ.Size = new System.Drawing.Size(124, 20);
            this.txt_GZ.TabIndex = 37;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(698, 2);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 22);
            this.btn_Query.TabIndex = 36;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(777, 2);
            this.btn_out.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(75, 22);
            this.btn_out.TabIndex = 133;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // gc_Main
            // 
            this.gc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Main.Location = new System.Drawing.Point(0, 29);
            this.gc_Main.MainView = this.gv_Main;
            this.gc_Main.Name = "gc_Main";
            this.gc_Main.Size = new System.Drawing.Size(1023, 570);
            this.gc_Main.TabIndex = 2;
            this.gc_Main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Main});
            // 
            // gv_Main
            // 
            this.gv_Main.GridControl = this.gc_Main;
            this.gv_Main.Name = "gv_Main";
            this.gv_Main.OptionsBehavior.Editable = false;
            this.gv_Main.OptionsView.ColumnAutoWidth = false;
            this.gv_Main.OptionsView.ShowGroupPanel = false;
            // 
            // FrmRP_GPYC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 599);
            this.Controls.Add(this.gc_Main);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRP_GPYC";
            this.Text = "异常炉次跟踪";
            this.Load += new System.EventHandler(this.FrmRP_GPYC_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dt_End;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Stove;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_GZ;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_out;
        private DevExpress.XtraGrid.GridControl gc_Main;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Main;
    }
}