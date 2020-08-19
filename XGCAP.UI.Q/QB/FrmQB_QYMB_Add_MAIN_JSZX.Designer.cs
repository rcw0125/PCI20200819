namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_QYMB_Add_MAIN_JSZX
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_GZ = new DevExpress.XtraEditors.ButtonEdit();
            this.txt_BZ = new DevExpress.XtraEditors.TextEdit();
            this.txt_Spec_Min = new DevExpress.XtraEditors.TextEdit();
            this.txt_Spec_Max = new DevExpress.XtraEditors.TextEdit();
            this.btn_Sure = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_GZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Spec_Min.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Spec_Max.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "钢种";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "执行标准";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 136);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 18);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "规格最大值";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 18);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "规格最小值";
            // 
            // btn_GZ
            // 
            this.btn_GZ.Location = new System.Drawing.Point(98, 19);
            this.btn_GZ.Name = "btn_GZ";
            this.btn_GZ.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn_GZ.Size = new System.Drawing.Size(235, 24);
            this.btn_GZ.TabIndex = 5;
            this.btn_GZ.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // txt_BZ
            // 
            this.txt_BZ.Location = new System.Drawing.Point(98, 56);
            this.txt_BZ.Name = "txt_BZ";
            this.txt_BZ.Properties.ReadOnly = true;
            this.txt_BZ.Size = new System.Drawing.Size(235, 24);
            this.txt_BZ.TabIndex = 6;
            // 
            // txt_Spec_Min
            // 
            this.txt_Spec_Min.Location = new System.Drawing.Point(98, 96);
            this.txt_Spec_Min.Name = "txt_Spec_Min";
            this.txt_Spec_Min.Size = new System.Drawing.Size(235, 24);
            this.txt_Spec_Min.TabIndex = 7;
            // 
            // txt_Spec_Max
            // 
            this.txt_Spec_Max.Location = new System.Drawing.Point(98, 133);
            this.txt_Spec_Max.Name = "txt_Spec_Max";
            this.txt_Spec_Max.Size = new System.Drawing.Size(235, 24);
            this.txt_Spec_Max.TabIndex = 8;
            // 
            // btn_Sure
            // 
            this.btn_Sure.Location = new System.Drawing.Point(99, 176);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(75, 31);
            this.btn_Sure.TabIndex = 10;
            this.btn_Sure.Text = "确认";
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.Location = new System.Drawing.Point(213, 176);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(75, 31);
            this.btn_Cancle.TabIndex = 11;
            this.btn_Cancle.Text = "取消";
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // FrmQB_QYMB_Add_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 227);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Sure);
            this.Controls.Add(this.txt_Spec_Max);
            this.Controls.Add(this.txt_Spec_Min);
            this.Controls.Add(this.txt_BZ);
            this.Controls.Add(this.btn_GZ);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQB_QYMB_Add_MAIN_JSZX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "取样模板添加(技术中心)";
            this.Load += new System.EventHandler(this.FrmQB_QYMB_Add_MAIN_JSZX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_GZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Spec_Min.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Spec_Max.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ButtonEdit btn_GZ;
        private DevExpress.XtraEditors.TextEdit txt_BZ;
        private DevExpress.XtraEditors.TextEdit txt_Spec_Min;
        private DevExpress.XtraEditors.TextEdit txt_Spec_Max;
        private DevExpress.XtraEditors.SimpleButton btn_Sure;
        private DevExpress.XtraEditors.SimpleButton btn_Cancle;
    }
}