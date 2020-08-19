namespace XGCAP.UI.P.PR
{
    partial class FrmPR_JHQTJ_MX
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_query_zg = new DevExpress.XtraEditors.SimpleButton();
            this.gc_MX = new DevExpress.XtraGrid.GridControl();
            this.gv_MX = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_MX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MX)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_out);
            this.panelControl1.Controls.Add(this.dt_End);
            this.panelControl1.Controls.Add(this.dt_Start);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_query_zg);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(875, 37);
            this.panelControl1.TabIndex = 2;
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(480, 6);
            this.btn_out.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(70, 22);
            this.btn_out.TabIndex = 236;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(223, 7);
            this.dt_End.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dt_End.TabIndex = 223;
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(58, 7);
            this.dt_Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dt_Start.TabIndex = 222;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(211, 9);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(9, 14);
            this.labelControl2.TabIndex = 221;
            this.labelControl2.Text = "~";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 9);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 220;
            this.labelControl1.Text = "出库时间";
            // 
            // btn_query_zg
            // 
            this.btn_query_zg.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_query_zg.Location = new System.Drawing.Point(386, 5);
            this.btn_query_zg.Name = "btn_query_zg";
            this.btn_query_zg.Size = new System.Drawing.Size(75, 23);
            this.btn_query_zg.TabIndex = 218;
            this.btn_query_zg.Text = "查询";
            this.btn_query_zg.Click += new System.EventHandler(this.btn_query_zg_Click);
            // 
            // gc_MX
            // 
            this.gc_MX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_MX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_MX.Location = new System.Drawing.Point(0, 37);
            this.gc_MX.MainView = this.gv_MX;
            this.gc_MX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_MX.Name = "gc_MX";
            this.gc_MX.Size = new System.Drawing.Size(875, 487);
            this.gc_MX.TabIndex = 3;
            this.gc_MX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_MX});
            // 
            // gv_MX
            // 
            this.gv_MX.GridControl = this.gc_MX;
            this.gv_MX.Name = "gv_MX";
            this.gv_MX.OptionsBehavior.Editable = false;
            this.gv_MX.OptionsView.ColumnAutoWidth = false;
            this.gv_MX.OptionsView.ShowGroupPanel = false;
            // 
            // FrmPR_JHQTJ_MX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 524);
            this.Controls.Add(this.gc_MX);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPR_JHQTJ_MX";
            this.Text = "FrmPR_JHQTJ_MX";
            this.Load += new System.EventHandler(this.FrmPR_JHQTJ_MX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_MX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_out;
        private DevExpress.XtraEditors.DateEdit dt_End;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_query_zg;
        private DevExpress.XtraGrid.GridControl gc_MX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_MX;
    }
}