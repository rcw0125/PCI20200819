namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_GH
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
            this.gc_Hook = new DevExpress.XtraGrid.GridControl();
            this.gv_Hook = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_id1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.N_HOOK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.imgcbo_CX = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btn_Query_Main = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_GH = new DevExpress.XtraEditors.TextEdit();
            this.产线 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.操作人员 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.操作时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Hook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Hook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_CX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_Hook
            // 
            this.gc_Hook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Hook.Location = new System.Drawing.Point(0, 41);
            this.gc_Hook.MainView = this.gv_Hook;
            this.gc_Hook.Name = "gc_Hook";
            this.gc_Hook.Size = new System.Drawing.Size(1160, 565);
            this.gc_Hook.TabIndex = 7;
            this.gc_Hook.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Hook});
            // 
            // gv_Hook
            // 
            this.gv_Hook.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_id1,
            this.N_HOOK_NO,
            this.产线,
            this.操作人员,
            this.操作时间});
            this.gv_Hook.GridControl = this.gc_Hook;
            this.gv_Hook.Name = "gv_Hook";
            this.gv_Hook.OptionsBehavior.Editable = false;
            this.gv_Hook.OptionsView.ColumnAutoWidth = false;
            this.gv_Hook.OptionsView.ShowGroupPanel = false;
            // 
            // c_id1
            // 
            this.c_id1.Caption = "ID";
            this.c_id1.FieldName = "C_ID";
            this.c_id1.Name = "c_id1";
            // 
            // N_HOOK_NO
            // 
            this.N_HOOK_NO.Caption = "钩号";
            this.N_HOOK_NO.FieldName = "N_HOOK_NO";
            this.N_HOOK_NO.Name = "N_HOOK_NO";
            this.N_HOOK_NO.Visible = true;
            this.N_HOOK_NO.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Del);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Controls.Add(this.imgcbo_CX);
            this.panelControl1.Controls.Add(this.btn_Query_Main);
            this.panelControl1.Controls.Add(this.txt_GH);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1160, 41);
            this.panelControl1.TabIndex = 8;
            // 
            // btn_Del
            // 
            this.btn_Del.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Del.Location = new System.Drawing.Point(487, 7);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 114;
            this.btn_Del.Text = "删除";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(406, 7);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // imgcbo_CX
            // 
            this.imgcbo_CX.EditValue = "全部";
            this.imgcbo_CX.Location = new System.Drawing.Point(40, 8);
            this.imgcbo_CX.Name = "imgcbo_CX";
            this.imgcbo_CX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_CX.Size = new System.Drawing.Size(100, 20);
            this.imgcbo_CX.TabIndex = 21;
            // 
            // btn_Query_Main
            // 
            this.btn_Query_Main.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query_Main.Location = new System.Drawing.Point(325, 7);
            this.btn_Query_Main.Name = "btn_Query_Main";
            this.btn_Query_Main.Size = new System.Drawing.Size(75, 23);
            this.btn_Query_Main.TabIndex = 20;
            this.btn_Query_Main.Text = "查询";
            this.btn_Query_Main.Click += new System.EventHandler(this.btn_Query_Main_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 11);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "车间";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(158, 11);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "钩号";
            // 
            // txt_GH
            // 
            this.txt_GH.Location = new System.Drawing.Point(186, 8);
            this.txt_GH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GH.Name = "txt_GH";
            this.txt_GH.Properties.Mask.EditMask = "d";
            this.txt_GH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_GH.Properties.MaxLength = 5;
            this.txt_GH.Size = new System.Drawing.Size(128, 20);
            this.txt_GH.TabIndex = 16;
            // 
            // 产线
            // 
            this.产线.Caption = "产线";
            this.产线.FieldName = "C_STA_DESC";
            this.产线.Name = "产线";
            this.产线.Visible = true;
            this.产线.VisibleIndex = 0;
            // 
            // 操作人员
            // 
            this.操作人员.Caption = "操作人员";
            this.操作人员.FieldName = "C_EMP_ID";
            this.操作人员.Name = "操作人员";
            this.操作人员.Visible = true;
            this.操作人员.VisibleIndex = 2;
            // 
            // 操作时间
            // 
            this.操作时间.Caption = "操作时间";
            this.操作时间.FieldName = "D_MOD_DT";
            this.操作时间.GroupFormat.FormatString = "G";
            this.操作时间.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.操作时间.Name = "操作时间";
            this.操作时间.Visible = true;
            this.操作时间.VisibleIndex = 3;
            // 
            // FrmQC_GH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 606);
            this.Controls.Add(this.gc_Hook);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQC_GH";
            this.Text = "钩号";
            this.Load += new System.EventHandler(this.FrmQC_GH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Hook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Hook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_CX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_Hook;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Hook;
        private DevExpress.XtraGrid.Columns.GridColumn c_id1;
        private DevExpress.XtraGrid.Columns.GridColumn N_HOOK_NO;
        private DevExpress.XtraGrid.Columns.GridColumn 产线;
        private DevExpress.XtraGrid.Columns.GridColumn 操作人员;
        private DevExpress.XtraGrid.Columns.GridColumn 操作时间;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_CX;
        private DevExpress.XtraEditors.SimpleButton btn_Query_Main;
        private DevExpress.XtraEditors.TextEdit txt_GH;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}