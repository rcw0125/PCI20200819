namespace XGCAP.UI.Q.QR
{
    partial class FrmQR_CKCZSCX
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Batch_Result = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_GZ = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_BZ = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Main = new DevExpress.XtraGrid.GridControl();
            this.gv_Main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_HTH = new DevExpress.XtraEditors.TextEdit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HTH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelControl4);
            this.flowLayoutPanel1.Controls.Add(this.txt_HTH);
            this.flowLayoutPanel1.Controls.Add(this.labelControl3);
            this.flowLayoutPanel1.Controls.Add(this.txt_Batch_Result);
            this.flowLayoutPanel1.Controls.Add(this.labelControl1);
            this.flowLayoutPanel1.Controls.Add(this.txt_GZ);
            this.flowLayoutPanel1.Controls.Add(this.labelControl2);
            this.flowLayoutPanel1.Controls.Add(this.txt_BZ);
            this.flowLayoutPanel1.Controls.Add(this.btn_Query);
            this.flowLayoutPanel1.Controls.Add(this.btn_out);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1343, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(170, 6);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "批号";
            // 
            // txt_Batch_Result
            // 
            this.txt_Batch_Result.Location = new System.Drawing.Point(198, 4);
            this.txt_Batch_Result.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txt_Batch_Result.Name = "txt_Batch_Result";
            this.txt_Batch_Result.Size = new System.Drawing.Size(124, 20);
            this.txt_Batch_Result.TabIndex = 35;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(326, 6);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "钢种";
            // 
            // txt_GZ
            // 
            this.txt_GZ.Location = new System.Drawing.Point(354, 4);
            this.txt_GZ.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txt_GZ.Name = "txt_GZ";
            this.txt_GZ.Size = new System.Drawing.Size(124, 20);
            this.txt_GZ.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(482, 6);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 134;
            this.labelControl2.Text = "标准";
            // 
            // txt_BZ
            // 
            this.txt_BZ.Location = new System.Drawing.Point(510, 4);
            this.txt_BZ.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txt_BZ.Name = "txt_BZ";
            this.txt_BZ.Size = new System.Drawing.Size(124, 20);
            this.txt_BZ.TabIndex = 135;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(638, 2);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 22);
            this.btn_Query.TabIndex = 36;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_out
            // 
            this.btn_out.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_out.Location = new System.Drawing.Point(717, 2);
            this.btn_out.Margin = new System.Windows.Forms.Padding(2);
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
            this.gc_Main.Size = new System.Drawing.Size(1343, 651);
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
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(2, 6);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 136;
            this.labelControl4.Text = "合同号";
            // 
            // txt_HTH
            // 
            this.txt_HTH.Location = new System.Drawing.Point(42, 4);
            this.txt_HTH.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txt_HTH.Name = "txt_HTH";
            this.txt_HTH.Size = new System.Drawing.Size(124, 20);
            this.txt_HTH.TabIndex = 137;
            // 
            // FrmQR_CKCZSCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 680);
            this.Controls.Add(this.gc_Main);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQR_CKCZSCX";
            this.Text = "品质追溯";
            this.Load += new System.EventHandler(this.FrmQR_CFXN_CX_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Batch_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HTH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Batch_Result;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_GZ;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_BZ;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_out;
        private DevExpress.XtraGrid.GridControl gc_Main;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Main;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_HTH;
    }
}