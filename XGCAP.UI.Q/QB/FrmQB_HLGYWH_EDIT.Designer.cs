namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_HLGYWH_EDIT
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
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Seave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_Type = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Hot = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imgcbo_Heat = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.txt_cooldate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CoolCraft = new DevExpress.XtraEditors.MemoEdit();
            this.txt_Remark = new DevExpress.XtraEditors.MemoEdit();
            this.txt_CoolCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Heat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cooldate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCraft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_cancel.Location = new System.Drawing.Point(276, 219);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 75;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Seave
            // 
            this.btn_Seave.ImageUri.Uri = "Save;Size16x16";
            this.btn_Seave.Location = new System.Drawing.Point(196, 219);
            this.btn_Seave.Name = "btn_Seave";
            this.btn_Seave.Size = new System.Drawing.Size(75, 23);
            this.btn_Seave.TabIndex = 74;
            this.btn_Seave.Text = "保存";
            this.btn_Seave.Click += new System.EventHandler(this.btn_Seave_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(60, 74);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 14);
            this.labelControl8.TabIndex = 86;
            this.labelControl8.Text = "类型";
            // 
            // imgcbo_Type
            // 
            this.imgcbo_Type.Location = new System.Drawing.Point(90, 73);
            this.imgcbo_Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_Type.Name = "imgcbo_Type";
            this.imgcbo_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_Type.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("大方坯连铸坯", "大方坯连铸坯", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("小方坯连铸坯", "小方坯连铸坯", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("热轧钢坯", "热轧钢坯", -1)});
            this.imgcbo_Type.Size = new System.Drawing.Size(100, 20);
            this.imgcbo_Type.TabIndex = 87;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "缓冷工艺代码";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(60, 178);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 80;
            this.labelControl5.Text = "备注";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(36, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 14);
            this.labelControl7.TabIndex = 84;
            this.labelControl7.Text = "缓冷工艺";
            // 
            // txt_Hot
            // 
            this.txt_Hot.Location = new System.Drawing.Point(90, 40);
            this.txt_Hot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Hot.Name = "txt_Hot";
            this.txt_Hot.Size = new System.Drawing.Size(100, 20);
            this.txt_Hot.TabIndex = 89;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(36, 43);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 14);
            this.labelControl9.TabIndex = 88;
            this.labelControl9.Text = "热装温度";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(196, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "缓冷时间";
            // 
            // imgcbo_Heat
            // 
            this.imgcbo_Heat.Location = new System.Drawing.Point(250, 11);
            this.imgcbo_Heat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_Heat.Name = "imgcbo_Heat";
            this.imgcbo_Heat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_Heat.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("是", "是", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("否", "否", -1)});
            this.imgcbo_Heat.Size = new System.Drawing.Size(100, 20);
            this.imgcbo_Heat.TabIndex = 83;
            // 
            // txt_cooldate
            // 
            this.txt_cooldate.Location = new System.Drawing.Point(250, 43);
            this.txt_cooldate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cooldate.Name = "txt_cooldate";
            this.txt_cooldate.Properties.Mask.EditMask = "d";
            this.txt_cooldate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_cooldate.Size = new System.Drawing.Size(100, 20);
            this.txt_cooldate.TabIndex = 85;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(196, 14);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 82;
            this.labelControl6.Text = "是否热装";
            // 
            // txt_CoolCraft
            // 
            this.txt_CoolCraft.Location = new System.Drawing.Point(90, 102);
            this.txt_CoolCraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CoolCraft.Name = "txt_CoolCraft";
            this.txt_CoolCraft.Size = new System.Drawing.Size(260, 68);
            this.txt_CoolCraft.TabIndex = 77;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(90, 175);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(260, 39);
            this.txt_Remark.TabIndex = 81;
            // 
            // txt_CoolCode
            // 
            this.txt_CoolCode.Location = new System.Drawing.Point(90, 11);
            this.txt_CoolCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CoolCode.Name = "txt_CoolCode";
            this.txt_CoolCode.Properties.Mask.EditMask = "[a-zA-Z]+\\d+";
            this.txt_CoolCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_CoolCode.Properties.Mask.ShowPlaceHolders = false;
            this.txt_CoolCode.Size = new System.Drawing.Size(100, 20);
            this.txt_CoolCode.TabIndex = 79;
            // 
            // FrmQB_HLGYWH_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 262);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.imgcbo_Type);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_Hot);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.imgcbo_Heat);
            this.Controls.Add(this.txt_cooldate);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_CoolCraft);
            this.Controls.Add(this.txt_Remark);
            this.Controls.Add(this.txt_CoolCode);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Seave);
            this.Name = "FrmQB_HLGYWH_EDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改";
            this.Load += new System.EventHandler(this.FrmQB_HLGYWH_EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Heat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cooldate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCraft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoolCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Seave;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_Type;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_Hot;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_Heat;
        private DevExpress.XtraEditors.TextEdit txt_cooldate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txt_CoolCraft;
        private DevExpress.XtraEditors.MemoEdit txt_Remark;
        private DevExpress.XtraEditors.TextEdit txt_CoolCode;
    }
}