namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_CFCX
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
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            this.dt_End = new DevExpress.XtraEditors.DateEdit();
            this.dt_Start = new DevExpress.XtraEditors.DateEdit();
            this.btn_Query_CG = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Stove = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gc_CF = new DevExpress.XtraGrid.GridControl();
            this.gv_CF = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CF)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_out);
            this.panelControl1.Controls.Add(this.dt_End);
            this.panelControl1.Controls.Add(this.dt_Start);
            this.panelControl1.Controls.Add(this.btn_Query_CG);
            this.panelControl1.Controls.Add(this.txt_Stove);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1334, 46);
            this.panelControl1.TabIndex = 19;
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(859, 7);
            this.btn_out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(83, 28);
            this.btn_out.TabIndex = 134;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(307, 9);
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
            this.dt_End.TabIndex = 19;
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(88, 9);
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
            this.dt_Start.TabIndex = 18;
            // 
            // btn_Query_CG
            // 
            this.btn_Query_CG.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query_CG.Location = new System.Drawing.Point(769, 6);
            this.btn_Query_CG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Query_CG.Name = "btn_Query_CG";
            this.btn_Query_CG.Size = new System.Drawing.Size(83, 28);
            this.btn_Query_CG.TabIndex = 17;
            this.btn_Query_CG.Text = "查询";
            this.btn_Query_CG.Click += new System.EventHandler(this.btn_Query_CG_Click);
            // 
            // txt_Stove
            // 
            this.txt_Stove.Location = new System.Drawing.Point(576, 9);
            this.txt_Stove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stove.Name = "txt_Stove";
            this.txt_Stove.Size = new System.Drawing.Size(171, 24);
            this.txt_Stove.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(524, 12);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 18);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "炉号：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(291, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 18);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "~";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 18);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "检验时间：";
            // 
            // gc_CF
            // 
            this.gc_CF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CF.Location = new System.Drawing.Point(0, 46);
            this.gc_CF.MainView = this.gv_CF;
            this.gc_CF.Name = "gc_CF";
            this.gc_CF.Size = new System.Drawing.Size(1334, 548);
            this.gc_CF.TabIndex = 20;
            this.gc_CF.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CF});
            // 
            // gv_CF
            // 
            this.gv_CF.GridControl = this.gc_CF;
            this.gv_CF.Name = "gv_CF";
            this.gv_CF.OptionsBehavior.Editable = false;
            this.gv_CF.OptionsView.ColumnAutoWidth = false;
            this.gv_CF.OptionsView.ShowGroupPanel = false;
            // 
            // FrmQC_CFCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 594);
            this.Controls.Add(this.gc_CF);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQC_CFCX";
            this.Text = "查询成分原始信息";
            this.Load += new System.EventHandler(this.FrmQC_CFCX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dt_End;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraEditors.SimpleButton btn_Query_CG;
        private DevExpress.XtraEditors.TextEdit txt_Stove;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gc_CF;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CF;
        private DevExpress.XtraEditors.SimpleButton btn_out;
    }
}