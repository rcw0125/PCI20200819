namespace XGCAP.UI.P.PO.APS
{
    partial class FrmPO_APS_ZG_PLAN_LOG
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
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_PC_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_PC_Reason = new DevExpress.XtraEditors.MemoEdit();
            this.btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PC_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PC_Reason.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Add;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(121, 250);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 29);
            this.btn_Save.TabIndex = 24;
            this.btn_Save.Text = "确定";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(23, 17);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 18);
            this.labelControl7.TabIndex = 160;
            this.labelControl7.Text = "本次排产名称";
            // 
            // txt_PC_Name
            // 
            this.txt_PC_Name.Location = new System.Drawing.Point(121, 14);
            this.txt_PC_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PC_Name.Name = "txt_PC_Name";
            this.txt_PC_Name.Properties.ReadOnly = true;
            this.txt_PC_Name.Size = new System.Drawing.Size(231, 24);
            this.txt_PC_Name.TabIndex = 161;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 61);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 162;
            this.labelControl1.Text = "排产原因";
            // 
            // txt_PC_Reason
            // 
            this.txt_PC_Reason.Location = new System.Drawing.Point(121, 58);
            this.txt_PC_Reason.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PC_Reason.Name = "txt_PC_Reason";
            this.txt_PC_Reason.Size = new System.Drawing.Size(231, 169);
            this.txt_PC_Reason.TabIndex = 163;
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Cancle.Location = new System.Drawing.Point(252, 250);
            this.btn_Cancle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(100, 29);
            this.btn_Cancle.TabIndex = 164;
            this.btn_Cancle.Text = "取消";
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // FrmPO_APS_ZG_PLAN_LOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 303);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_PC_Name);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_PC_Reason);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPO_APS_ZG_PLAN_LOG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "轧钢排产记录";
            this.Load += new System.EventHandler(this.FrmPO_APS_ZG_PLAN_LOG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_PC_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PC_Reason.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_PC_Name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txt_PC_Reason;
        private DevExpress.XtraEditors.SimpleButton btn_Cancle;
    }
}