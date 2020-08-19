namespace XGCAP.UI.P.PB
{
    partial class FrmPB_CNLR
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
            this.gc_CN = new DevExpress.XtraGrid.GridControl();
            this.gv_CN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_DC = new DevExpress.XtraEditors.SimpleButton();
            this.rbtn_isty_wh = new DevExpress.XtraEditors.RadioGroup();
            this.dte_Time = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_CJ = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_wh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Time.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_CJ.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_CN
            // 
            this.gc_CN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_CN.Location = new System.Drawing.Point(0, 35);
            this.gc_CN.MainView = this.gv_CN;
            this.gc_CN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_CN.Name = "gc_CN";
            this.gc_CN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gc_CN.Size = new System.Drawing.Size(1202, 591);
            this.gc_CN.TabIndex = 64;
            this.gc_CN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CN});
            // 
            // gv_CN
            // 
            this.gv_CN.GridControl = this.gc_CN;
            this.gv_CN.Name = "gv_CN";
            this.gv_CN.OptionsView.ColumnAutoWidth = false;
            this.gv_CN.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_DC);
            this.panelControl2.Controls.Add(this.rbtn_isty_wh);
            this.panelControl2.Controls.Add(this.dte_Time);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.imgcbo_CJ);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.btn_Add);
            this.panelControl2.Controls.Add(this.btn_Update);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1202, 35);
            this.panelControl2.TabIndex = 63;
            // 
            // btn_DC
            // 
            this.btn_DC.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_DC.Location = new System.Drawing.Point(809, 5);
            this.btn_DC.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_DC.Name = "btn_DC";
            this.btn_DC.Size = new System.Drawing.Size(64, 23);
            this.btn_DC.TabIndex = 130;
            this.btn_DC.Text = "导出";
            this.btn_DC.Click += new System.EventHandler(this.btn_DC_Click);
            // 
            // rbtn_isty_wh
            // 
            this.rbtn_isty_wh.Location = new System.Drawing.Point(170, 2);
            this.rbtn_isty_wh.Name = "rbtn_isty_wh";
            this.rbtn_isty_wh.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_isty_wh.Properties.Appearance.Options.UseBackColor = true;
            this.rbtn_isty_wh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rbtn_isty_wh.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "上旬"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "中旬"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "下旬")});
            this.rbtn_isty_wh.Size = new System.Drawing.Size(134, 27);
            this.rbtn_isty_wh.TabIndex = 129;
            // 
            // dte_Time
            // 
            this.dte_Time.EditValue = null;
            this.dte_Time.Location = new System.Drawing.Point(41, 5);
            this.dte_Time.Margin = new System.Windows.Forms.Padding(2);
            this.dte_Time.Name = "dte_Time";
            this.dte_Time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Time.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Time.Properties.CalendarTimeProperties.Mask.EditMask = "yyyy-MM";
            this.dte_Time.Properties.DisplayFormat.FormatString = "yyyy-MM";
            this.dte_Time.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dte_Time.Properties.EditFormat.FormatString = "";
            this.dte_Time.Properties.Mask.EditMask = "";
            this.dte_Time.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dte_Time.Size = new System.Drawing.Size(124, 20);
            this.dte_Time.TabIndex = 61;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "日期";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(315, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "车间";
            // 
            // imgcbo_CJ
            // 
            this.imgcbo_CJ.Location = new System.Drawing.Point(345, 6);
            this.imgcbo_CJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_CJ.Name = "imgcbo_CJ";
            this.imgcbo_CJ.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_CJ.Properties.MaxLength = 50;
            this.imgcbo_CJ.Size = new System.Drawing.Size(124, 20);
            this.imgcbo_CJ.TabIndex = 29;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(483, 5);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 4;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(566, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.ImageUri.Uri = "Save;Size16x16";
            this.btn_Update.Location = new System.Drawing.Point(728, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "保存";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(647, 5);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "删除";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // FrmPB_CNLR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 626);
            this.Controls.Add(this.gc_CN);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmPB_CNLR";
            this.Text = "FrmPB_CNLR";
            this.Load += new System.EventHandler(this.FrmPB_CNLR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_CN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_wh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Time.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_CJ.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_CN;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CN;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_CJ;
        private DevExpress.XtraEditors.DateEdit dte_Time;
        private DevExpress.XtraEditors.RadioGroup rbtn_isty_wh;
        private DevExpress.XtraEditors.SimpleButton btn_DC;
    }
}