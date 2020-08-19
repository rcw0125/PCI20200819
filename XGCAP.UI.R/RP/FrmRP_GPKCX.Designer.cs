namespace XGCAP.UI.R.RP
{
    partial class FrmRP_GPKCX
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
            this.btn_query = new DevExpress.XtraEditors.SimpleButton();
            this.icbo_lz = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.image_Store = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_bz = new DevExpress.XtraEditors.TextEdit();
            this.txt_size = new DevExpress.XtraEditors.TextEdit();
            this.txt_lh = new DevExpress.XtraEditors.TextEdit();
            this.txt_gz = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_lz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Store.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_size.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_query);
            this.panel1.Controls.Add(this.icbo_lz);
            this.panel1.Controls.Add(this.image_Store);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txt_bz);
            this.panel1.Controls.Add(this.txt_size);
            this.panel1.Controls.Add(this.txt_lh);
            this.panel1.Controls.Add(this.txt_gz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 46);
            this.panel1.TabIndex = 0;
            // 
            // btn_query
            // 
            this.btn_query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_query.Location = new System.Drawing.Point(912, 11);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(61, 23);
            this.btn_query.TabIndex = 161;
            this.btn_query.Text = "查询";
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // icbo_lz
            // 
            this.icbo_lz.Location = new System.Drawing.Point(42, 12);
            this.icbo_lz.Name = "icbo_lz";
            this.icbo_lz.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbo_lz.Size = new System.Drawing.Size(88, 20);
            this.icbo_lz.TabIndex = 1;
            // 
            // image_Store
            // 
            this.image_Store.Location = new System.Drawing.Point(164, 12);
            this.image_Store.Name = "image_Store";
            this.image_Store.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.image_Store.Size = new System.Drawing.Size(129, 20);
            this.image_Store.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(590, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "执行标准";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(777, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "断面";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(298, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "炉号";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "连铸";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(427, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "钢种";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(135, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "仓库";
            // 
            // txt_bz
            // 
            this.txt_bz.Location = new System.Drawing.Point(643, 12);
            this.txt_bz.Name = "txt_bz";
            this.txt_bz.Size = new System.Drawing.Size(129, 20);
            this.txt_bz.TabIndex = 1;
            // 
            // txt_size
            // 
            this.txt_size.Location = new System.Drawing.Point(806, 12);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(101, 20);
            this.txt_size.TabIndex = 1;
            // 
            // txt_lh
            // 
            this.txt_lh.Location = new System.Drawing.Point(327, 12);
            this.txt_lh.Name = "txt_lh";
            this.txt_lh.Size = new System.Drawing.Size(95, 20);
            this.txt_lh.TabIndex = 1;
            // 
            // txt_gz
            // 
            this.txt_gz.Location = new System.Drawing.Point(456, 12);
            this.txt_gz.Name = "txt_gz";
            this.txt_gz.Size = new System.Drawing.Size(129, 20);
            this.txt_gz.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 46);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1261, 609);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmRP_GPKCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 655);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRP_GPKCX";
            this.Text = "钢坯库数据查询";
            this.Load += new System.EventHandler(this.FrmRP_GPKCX_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_lz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Store.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_size.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ImageComboBoxEdit image_Store;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_bz;
        private DevExpress.XtraEditors.TextEdit txt_size;
        private DevExpress.XtraEditors.TextEdit txt_lh;
        private DevExpress.XtraEditors.TextEdit txt_gz;
        private DevExpress.XtraEditors.SimpleButton btn_query;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbo_lz;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}