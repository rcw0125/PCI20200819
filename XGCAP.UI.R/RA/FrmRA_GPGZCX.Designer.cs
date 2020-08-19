namespace XGCAP.UI.R.RA
{
    partial class FrmRA_GPGZCX
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
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Stove_Fk = new DevExpress.XtraEditors.TextEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Grd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_STD = new DevExpress.XtraEditors.TextEdit();
            this.rbtn_isty_wh = new DevExpress.XtraEditors.RadioGroup();
            this.btn_QuerySlabFk = new DevExpress.XtraEditors.SimpleButton();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gc_Move = new DevExpress.XtraGrid.GridControl();
            this.gv_Move = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove_Fk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_wh.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(11, 13);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 14);
            this.labelControl9.TabIndex = 244;
            this.labelControl9.Text = "炉号/开坯号";
            // 
            // txt_Stove_Fk
            // 
            this.txt_Stove_Fk.Location = new System.Drawing.Point(82, 10);
            this.txt_Stove_Fk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stove_Fk.Name = "txt_Stove_Fk";
            this.txt_Stove_Fk.Size = new System.Drawing.Size(108, 20);
            this.txt_Stove_Fk.TabIndex = 245;
            // 
            // labelControl29
            // 
            this.labelControl29.Location = new System.Drawing.Point(196, 13);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(24, 14);
            this.labelControl29.TabIndex = 246;
            this.labelControl29.Text = "钢种";
            // 
            // txt_Grd
            // 
            this.txt_Grd.Location = new System.Drawing.Point(226, 10);
            this.txt_Grd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Grd.Name = "txt_Grd";
            this.txt_Grd.Size = new System.Drawing.Size(100, 20);
            this.txt_Grd.TabIndex = 247;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(332, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 246;
            this.labelControl1.Text = "执行标准";
            // 
            // txt_STD
            // 
            this.txt_STD.Location = new System.Drawing.Point(386, 10);
            this.txt_STD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_STD.Name = "txt_STD";
            this.txt_STD.Size = new System.Drawing.Size(100, 20);
            this.txt_STD.TabIndex = 247;
            // 
            // rbtn_isty_wh
            // 
            this.rbtn_isty_wh.Location = new System.Drawing.Point(492, 9);
            this.rbtn_isty_wh.Name = "rbtn_isty_wh";
            this.rbtn_isty_wh.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_isty_wh.Properties.Appearance.Options.UseBackColor = true;
            this.rbtn_isty_wh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rbtn_isty_wh.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rbtn_isty_wh.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "出入库"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "倒垛")});
            this.rbtn_isty_wh.Size = new System.Drawing.Size(128, 23);
            this.rbtn_isty_wh.TabIndex = 249;
            this.rbtn_isty_wh.SelectedIndexChanged += new System.EventHandler(this.rbtn_isty_wh_SelectedIndexChanged);
            // 
            // btn_QuerySlabFk
            // 
            this.btn_QuerySlabFk.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_QuerySlabFk.Location = new System.Drawing.Point(626, 9);
            this.btn_QuerySlabFk.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_QuerySlabFk.Name = "btn_QuerySlabFk";
            this.btn_QuerySlabFk.Size = new System.Drawing.Size(75, 23);
            this.btn_QuerySlabFk.TabIndex = 239;
            this.btn_QuerySlabFk.Text = "查询";
            this.btn_QuerySlabFk.Click += new System.EventHandler(this.btn_QuerySlabFk_Click);
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(707, 9);
            this.btn_out.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(75, 23);
            this.btn_out.TabIndex = 248;
            this.btn_out.Text = "导出";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_out);
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Controls.Add(this.txt_Grd);
            this.panel1.Controls.Add(this.rbtn_isty_wh);
            this.panel1.Controls.Add(this.txt_STD);
            this.panel1.Controls.Add(this.labelControl29);
            this.panel1.Controls.Add(this.txt_Stove_Fk);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btn_QuerySlabFk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 47);
            this.panel1.TabIndex = 6;
            // 
            // gc_Move
            // 
            this.gc_Move.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Move.Location = new System.Drawing.Point(0, 47);
            this.gc_Move.MainView = this.gv_Move;
            this.gc_Move.Name = "gc_Move";
            this.gc_Move.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox2,
            this.repositoryItemComboBox2});
            this.gc_Move.Size = new System.Drawing.Size(1209, 628);
            this.gc_Move.TabIndex = 7;
            this.gc_Move.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Move});
            // 
            // gv_Move
            // 
            this.gv_Move.GridControl = this.gc_Move;
            this.gv_Move.Name = "gv_Move";
            this.gv_Move.OptionsBehavior.Editable = false;
            this.gv_Move.OptionsView.ColumnAutoWidth = false;
            this.gv_Move.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // FrmRA_GPGZCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 675);
            this.Controls.Add(this.gc_Move);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRA_GPGZCX";
            this.Text = "钢坯跟踪查询";
            this.Load += new System.EventHandler(this.FrmRA_GPGZCX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Stove_Fk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_isty_wh.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_Stove_Fk;
        private DevExpress.XtraEditors.SimpleButton btn_QuerySlabFk;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.TextEdit txt_Grd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_STD;
        private DevExpress.XtraEditors.SimpleButton btn_out;
        private DevExpress.XtraEditors.RadioGroup rbtn_isty_wh;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gc_Move;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Move;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
    }
}