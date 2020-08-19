namespace XGCAP.UI.P.PR
{
    partial class FrmPR_LGJCRemark
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gc_Lgfx = new DevExpress.XtraGrid.GridControl();
            this.gv_Lgfx = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.icbo_lz3 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            this.dt_End = new DevExpress.XtraEditors.DateEdit();
            this.dt_Start = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_query_zg = new DevExpress.XtraEditors.SimpleButton();
            this.rbtn_status = new DevExpress.XtraEditors.RadioGroup();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Lgfx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lgfx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_lz3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Lgfx
            // 
            this.gc_Lgfx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Lgfx.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode1.RelationName = "Level1";
            this.gc_Lgfx.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_Lgfx.Location = new System.Drawing.Point(0, 37);
            this.gc_Lgfx.MainView = this.gv_Lgfx;
            this.gc_Lgfx.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Lgfx.Name = "gc_Lgfx";
            this.gc_Lgfx.Size = new System.Drawing.Size(871, 437);
            this.gc_Lgfx.TabIndex = 4;
            this.gc_Lgfx.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Lgfx,
            this.gridView1});
            // 
            // gv_Lgfx
            // 
            this.gv_Lgfx.GridControl = this.gc_Lgfx;
            this.gv_Lgfx.Name = "gv_Lgfx";
            this.gv_Lgfx.OptionsBehavior.Editable = false;
            this.gv_Lgfx.OptionsView.ColumnAutoWidth = false;
            this.gv_Lgfx.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.rbtn_status);
            this.panelControl1.Controls.Add(this.icbo_lz3);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.btn_out);
            this.panelControl1.Controls.Add(this.dt_End);
            this.panelControl1.Controls.Add(this.dt_Start);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_query_zg);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(871, 37);
            this.panelControl1.TabIndex = 3;
            // 
            // icbo_lz3
            // 
            this.icbo_lz3.Location = new System.Drawing.Point(201, 11);
            this.icbo_lz3.Name = "icbo_lz3";
            this.icbo_lz3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbo_lz3.Size = new System.Drawing.Size(65, 20);
            this.icbo_lz3.TabIndex = 238;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(169, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 237;
            this.labelControl5.Text = "连铸";
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(740, 10);
            this.btn_out.Margin = new System.Windows.Forms.Padding(2);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(70, 22);
            this.btn_out.TabIndex = 236;
            this.btn_out.Text = "导出";
            // 
            // dt_End
            // 
            this.dt_End.EditValue = null;
            this.dt_End.Location = new System.Drawing.Point(502, 11);
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
            this.dt_End.TabIndex = 223;
            // 
            // dt_Start
            // 
            this.dt_Start.EditValue = null;
            this.dt_Start.Location = new System.Drawing.Point(330, 11);
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
            this.dt_Start.TabIndex = 222;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(485, 14);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(9, 14);
            this.labelControl2.TabIndex = 221;
            this.labelControl2.Text = "~";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(274, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 220;
            this.labelControl1.Text = "操作时间";
            // 
            // btn_query_zg
            // 
            this.btn_query_zg.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_query_zg.Location = new System.Drawing.Point(657, 10);
            this.btn_query_zg.Name = "btn_query_zg";
            this.btn_query_zg.Size = new System.Drawing.Size(75, 23);
            this.btn_query_zg.TabIndex = 218;
            this.btn_query_zg.Text = "查询";
            this.btn_query_zg.Click += new System.EventHandler(this.btn_query_zg_Click);
            // 
            // rbtn_status
            // 
            this.rbtn_status.Location = new System.Drawing.Point(12, 9);
            this.rbtn_status.Name = "rbtn_status";
            this.rbtn_status.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "计划调整"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "终止计划")});
            this.rbtn_status.Size = new System.Drawing.Size(149, 24);
            this.rbtn_status.TabIndex = 239;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_Lgfx;
            this.gridView1.Name = "gridView1";
            // 
            // FrmPR_LGJCRemark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 474);
            this.Controls.Add(this.gc_Lgfx);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPR_LGJCRemark";
            this.Text = "炼钢浇次计划调整终止备注查询";
            this.Load += new System.EventHandler(this.FrmPR_LGJCRemark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Lgfx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lgfx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_lz3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Lgfx;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Lgfx;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbo_lz3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_out;
        private DevExpress.XtraEditors.DateEdit dt_End;
        private DevExpress.XtraEditors.DateEdit dt_Start;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_query_zg;
        private DevExpress.XtraEditors.RadioGroup rbtn_status;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}