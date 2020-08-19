namespace XGCAP.UI.P.PP
{
    partial class FrmPP_ZJDD
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_CC = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit_Std = new DevExpress.XtraEditors.ButtonEdit();
            this.txt_Std_Grd = new DevExpress.XtraEditors.TextEdit();
            this.txt_Wgt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Spec = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MatCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MatName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup2 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.dtp_dt2 = new DevExpress.XtraEditors.DateEdit();
            this.dtp_dt1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_FA = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_CC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit_Std.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Std_Grd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Wgt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Spec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_dt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_dt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_dt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_dt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_FA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(514, 60);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 197;
            this.labelControl2.Text = "钢种";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(271, 60);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 195;
            this.labelControl1.Text = "执行标准";
            // 
            // cbo_CC
            // 
            this.cbo_CC.Location = new System.Drawing.Point(85, 144);
            this.cbo_CC.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_CC.Name = "cbo_CC";
            this.cbo_CC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_CC.Properties.DisplayFormat.FormatString = "d";
            this.cbo_CC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbo_CC.Properties.EditFormat.FormatString = "d";
            this.cbo_CC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbo_CC.Size = new System.Drawing.Size(169, 24);
            this.cbo_CC.TabIndex = 7;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(42, 147);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(30, 18);
            this.labelControl9.TabIndex = 199;
            this.labelControl9.Text = "铸机";
            // 
            // btn_Save2
            // 
            this.btn_Save2.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save2.Location = new System.Drawing.Point(167, 186);
            this.btn_Save2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save2.Name = "btn_Save2";
            this.btn_Save2.Size = new System.Drawing.Size(100, 29);
            this.btn_Save2.TabIndex = 9;
            this.btn_Save2.Text = "添加";
            this.btn_Save2.Click += new System.EventHandler(this.btn_Save2_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Cancle.Location = new System.Drawing.Point(299, 186);
            this.btn_Cancle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(100, 29);
            this.btn_Cancle.TabIndex = 10;
            this.btn_Cancle.Text = "取消";
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btnEdit_Std
            // 
            this.btnEdit_Std.Location = new System.Drawing.Point(339, 57);
            this.btnEdit_Std.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit_Std.Name = "btnEdit_Std";
            this.btnEdit_Std.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEdit_Std.Properties.ReadOnly = true;
            this.btnEdit_Std.Size = new System.Drawing.Size(169, 24);
            this.btnEdit_Std.TabIndex = 5;
            this.btnEdit_Std.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEdit_Std_ButtonClick);
            // 
            // txt_Std_Grd
            // 
            this.txt_Std_Grd.Location = new System.Drawing.Point(551, 55);
            this.txt_Std_Grd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Std_Grd.Name = "txt_Std_Grd";
            this.txt_Std_Grd.Properties.ReadOnly = true;
            this.txt_Std_Grd.Size = new System.Drawing.Size(169, 24);
            this.txt_Std_Grd.TabIndex = 6;
            // 
            // txt_Wgt
            // 
            this.txt_Wgt.Location = new System.Drawing.Point(339, 141);
            this.txt_Wgt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Wgt.Name = "txt_Wgt";
            this.txt_Wgt.Size = new System.Drawing.Size(169, 24);
            this.txt_Wgt.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(299, 144);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 205;
            this.labelControl3.Text = "重量";
            // 
            // txt_Spec
            // 
            this.txt_Spec.Location = new System.Drawing.Point(551, 100);
            this.txt_Spec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Spec.Name = "txt_Spec";
            this.txt_Spec.Properties.ReadOnly = true;
            this.txt_Spec.Size = new System.Drawing.Size(169, 24);
            this.txt_Spec.TabIndex = 206;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(515, 103);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 18);
            this.labelControl4.TabIndex = 207;
            this.labelControl4.Text = "断面";
            // 
            // txt_MatCode
            // 
            this.txt_MatCode.Location = new System.Drawing.Point(339, 103);
            this.txt_MatCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatCode.Name = "txt_MatCode";
            this.txt_MatCode.Properties.ReadOnly = true;
            this.txt_MatCode.Size = new System.Drawing.Size(169, 24);
            this.txt_MatCode.TabIndex = 208;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(271, 106);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 18);
            this.labelControl5.TabIndex = 209;
            this.labelControl5.Text = "物料编码";
            // 
            // txt_MatName
            // 
            this.txt_MatName.Location = new System.Drawing.Point(85, 103);
            this.txt_MatName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatName.Name = "txt_MatName";
            this.txt_MatName.Properties.ReadOnly = true;
            this.txt_MatName.Size = new System.Drawing.Size(169, 24);
            this.txt_MatName.TabIndex = 210;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 106);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 18);
            this.labelControl6.TabIndex = 211;
            this.labelControl6.Text = "物料名称";
            // 
            // radioGroup2
            // 
            this.radioGroup2.EditValue = ((short)(1));
            this.radioGroup2.Location = new System.Drawing.Point(85, 12);
            this.radioGroup2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioGroup2.Name = "radioGroup2";
            this.radioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "月排产"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "旬排产")});
            this.radioGroup2.Size = new System.Drawing.Size(169, 28);
            this.radioGroup2.TabIndex = 219;
            // 
            // labelControl37
            // 
            this.labelControl37.Location = new System.Drawing.Point(522, 17);
            this.labelControl37.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(14, 18);
            this.labelControl37.TabIndex = 218;
            this.labelControl37.Text = "—";
            // 
            // dtp_dt2
            // 
            this.dtp_dt2.EditValue = null;
            this.dtp_dt2.Location = new System.Drawing.Point(551, 14);
            this.dtp_dt2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtp_dt2.Name = "dtp_dt2";
            this.dtp_dt2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_dt2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_dt2.Size = new System.Drawing.Size(169, 24);
            this.dtp_dt2.TabIndex = 216;
            this.dtp_dt2.TextChanged += new System.EventHandler(this.dtp_dt2_TextChanged);
            // 
            // dtp_dt1
            // 
            this.dtp_dt1.EditValue = null;
            this.dtp_dt1.Location = new System.Drawing.Point(339, 14);
            this.dtp_dt1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtp_dt1.Name = "dtp_dt1";
            this.dtp_dt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_dt1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_dt1.Size = new System.Drawing.Size(169, 24);
            this.dtp_dt1.TabIndex = 217;
            this.dtp_dt1.TextChanged += new System.EventHandler(this.dtp_dt1_TextChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(269, 17);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 18);
            this.labelControl7.TabIndex = 214;
            this.labelControl7.Text = "排产日期";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(47, 17);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 18);
            this.labelControl8.TabIndex = 215;
            this.labelControl8.Text = "类型";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(32, 63);
            this.labelControl23.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(45, 18);
            this.labelControl23.TabIndex = 212;
            this.labelControl23.Text = "方案号";
            // 
            // cbo_FA
            // 
            this.cbo_FA.Location = new System.Drawing.Point(85, 60);
            this.cbo_FA.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_FA.Name = "cbo_FA";
            this.cbo_FA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_FA.Size = new System.Drawing.Size(169, 24);
            this.cbo_FA.TabIndex = 213;
            this.cbo_FA.SelectedIndexChanged += new System.EventHandler(this.cbo_FA_SelectedIndexChanged);
            // 
            // FrmPP_ZJDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 241);
            this.Controls.Add(this.radioGroup2);
            this.Controls.Add(this.labelControl37);
            this.Controls.Add(this.dtp_dt2);
            this.Controls.Add(this.dtp_dt1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl23);
            this.Controls.Add(this.cbo_FA);
            this.Controls.Add(this.txt_MatName);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_MatCode);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_Spec);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_Wgt);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnEdit_Std);
            this.Controls.Add(this.txt_Std_Grd);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Save2);
            this.Controls.Add(this.cbo_CC);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPP_ZJDD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "手动增加订单";
            this.Load += new System.EventHandler(this.FrmPP_ZJDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_CC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit_Std.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Std_Grd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Wgt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Spec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_dt2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_dt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_dt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_dt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_FA.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_CC;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btn_Save2;
        private DevExpress.XtraEditors.SimpleButton btn_Cancle;
        private DevExpress.XtraEditors.ButtonEdit btnEdit_Std;
        private DevExpress.XtraEditors.TextEdit txt_Std_Grd;
        private DevExpress.XtraEditors.TextEdit txt_Wgt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Spec;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_MatCode;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_MatName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.RadioGroup radioGroup2;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private DevExpress.XtraEditors.DateEdit dtp_dt2;
        private DevExpress.XtraEditors.DateEdit dtp_dt1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_FA;
    }
}