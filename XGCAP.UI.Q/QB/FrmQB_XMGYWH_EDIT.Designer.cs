namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_XMGYWH_EDIT
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
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.txt_CraftFlow = new DevExpress.XtraEditors.MemoEdit();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Seave = new DevExpress.XtraEditors.SimpleButton();
            this.txt_CopingCraft = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CraftFlow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CopingCraft.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_Remark);
            this.panelControl1.Controls.Add(this.txt_CraftFlow);
            this.panelControl1.Controls.Add(this.btn_cancel);
            this.panelControl1.Controls.Add(this.btn_Seave);
            this.panelControl1.Controls.Add(this.txt_CopingCraft);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(371, 178);
            this.panelControl1.TabIndex = 39;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(48, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 84;
            this.labelControl7.Text = "备注";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 82;
            this.labelControl6.Text = "修磨工艺";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 80;
            this.labelControl5.Text = "工艺流程";
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(78, 86);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(275, 48);
            this.txt_Remark.TabIndex = 85;
            // 
            // txt_CraftFlow
            // 
            this.txt_CraftFlow.Location = new System.Drawing.Point(78, 33);
            this.txt_CraftFlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CraftFlow.Name = "txt_CraftFlow";
            this.txt_CraftFlow.Size = new System.Drawing.Size(275, 48);
            this.txt_CraftFlow.TabIndex = 81;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_cancel.Location = new System.Drawing.Point(278, 139);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 73;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Seave
            // 
            this.btn_Seave.ImageUri.Uri = "Save;Size16x16";
            this.btn_Seave.Location = new System.Drawing.Point(198, 139);
            this.btn_Seave.Name = "btn_Seave";
            this.btn_Seave.Size = new System.Drawing.Size(75, 23);
            this.btn_Seave.TabIndex = 1;
            this.btn_Seave.Text = "保存";
            this.btn_Seave.Click += new System.EventHandler(this.btn_Seave_Click);
            // 
            // txt_CopingCraft
            // 
            this.txt_CopingCraft.Location = new System.Drawing.Point(78, 9);
            this.txt_CopingCraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CopingCraft.Name = "txt_CopingCraft";
            this.txt_CopingCraft.Size = new System.Drawing.Size(100, 20);
            this.txt_CopingCraft.TabIndex = 83;
            // 
            // FrmQB_XMGYWH_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 178);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQB_XMGYWH_EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改";
            this.Load += new System.EventHandler(this.FrmQB_XMGYWH_EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CraftFlow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CopingCraft.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Seave;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.MemoEdit txt_CraftFlow;
        private DevExpress.XtraEditors.TextEdit txt_CopingCraft;
    }
}