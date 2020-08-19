namespace XGCAP.UI.P.PB
{
    partial class FrmPB_ZXGSWH01
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
            this.cbo_GW1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.txt_BZ = new DevExpress.XtraEditors.TextEdit();
            this.btn_SaveDetails = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Online_Num = new DevExpress.XtraEditors.TextEdit();
            this.lab_GX = new DevExpress.XtraEditors.LabelControl();
            this.txt_PGH = new DevExpress.XtraEditors.TextEdit();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.lab_GXDM = new DevExpress.XtraEditors.LabelControl();
            this.lab_BZ = new DevExpress.XtraEditors.LabelControl();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.gc_CXGS = new DevExpress.XtraGrid.GridControl();
            this.gv_CXGS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_PRO_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_START_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Online_Num.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PGH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CXGS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CXGS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbo_GW1);
            this.panelControl1.Controls.Add(this.txt_BZ);
            this.panelControl1.Controls.Add(this.btn_SaveDetails);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_Online_Num);
            this.panelControl1.Controls.Add(this.lab_GX);
            this.panelControl1.Controls.Add(this.txt_PGH);
            this.panelControl1.Controls.Add(this.lbl_ID);
            this.panelControl1.Controls.Add(this.lab_GXDM);
            this.panelControl1.Controls.Add(this.lab_BZ);
            this.panelControl1.Controls.Add(this.btn_Reset);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1028, 49);
            this.panelControl1.TabIndex = 33;
            // 
            // cbo_GW1
            // 
            this.cbo_GW1.Location = new System.Drawing.Point(48, 11);
            this.cbo_GW1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_GW1.Name = "cbo_GW1";
            this.cbo_GW1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GW1.Size = new System.Drawing.Size(108, 20);
            this.cbo_GW1.TabIndex = 118;
            // 
            // txt_BZ
            // 
            this.txt_BZ.Location = new System.Drawing.Point(494, 11);
            this.txt_BZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_BZ.Name = "txt_BZ";
            this.txt_BZ.Size = new System.Drawing.Size(255, 20);
            this.txt_BZ.TabIndex = 117;
            // 
            // btn_SaveDetails
            // 
            this.btn_SaveDetails.ImageUri.Uri = "Save;Size16x16";
            this.btn_SaveDetails.Location = new System.Drawing.Point(754, 10);
            this.btn_SaveDetails.Name = "btn_SaveDetails";
            this.btn_SaveDetails.Size = new System.Drawing.Size(71, 23);
            this.btn_SaveDetails.TabIndex = 116;
            this.btn_SaveDetails.Text = "保存";
            this.btn_SaveDetails.Click += new System.EventHandler(this.btn_SaveDetails_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(307, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 111;
            this.labelControl1.Text = "在线钩数";
            // 
            // txt_Online_Num
            // 
            this.txt_Online_Num.Location = new System.Drawing.Point(360, 11);
            this.txt_Online_Num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Online_Num.Name = "txt_Online_Num";
            this.txt_Online_Num.Properties.Mask.EditMask = "n0";
            this.txt_Online_Num.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Online_Num.Size = new System.Drawing.Size(100, 20);
            this.txt_Online_Num.TabIndex = 115;
            // 
            // lab_GX
            // 
            this.lab_GX.Location = new System.Drawing.Point(161, 14);
            this.lab_GX.Name = "lab_GX";
            this.lab_GX.Size = new System.Drawing.Size(36, 14);
            this.lab_GX.TabIndex = 111;
            this.lab_GX.Text = "总钩数";
            // 
            // txt_PGH
            // 
            this.txt_PGH.Location = new System.Drawing.Point(202, 11);
            this.txt_PGH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PGH.Name = "txt_PGH";
            this.txt_PGH.Properties.Mask.EditMask = "n0";
            this.txt_PGH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_PGH.Size = new System.Drawing.Size(100, 20);
            this.txt_PGH.TabIndex = 115;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Location = new System.Drawing.Point(907, 14);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 14);
            this.lbl_ID.TabIndex = 112;
            this.lbl_ID.Visible = false;
            // 
            // lab_GXDM
            // 
            this.lab_GXDM.Location = new System.Drawing.Point(19, 14);
            this.lab_GXDM.Name = "lab_GXDM";
            this.lab_GXDM.Size = new System.Drawing.Size(24, 14);
            this.lab_GXDM.TabIndex = 112;
            this.lab_GXDM.Text = "产线";
            // 
            // lab_BZ
            // 
            this.lab_BZ.Location = new System.Drawing.Point(465, 14);
            this.lab_BZ.Name = "lab_BZ";
            this.lab_BZ.Size = new System.Drawing.Size(24, 14);
            this.lab_BZ.TabIndex = 113;
            this.lab_BZ.Text = "备注";
            // 
            // btn_Reset
            // 
            this.btn_Reset.ImageUri.Uri = "Reset;Size16x16";
            this.btn_Reset.Location = new System.Drawing.Point(830, 10);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(71, 23);
            this.btn_Reset.TabIndex = 114;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // gc_CXGS
            // 
            this.gc_CXGS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CXGS.Location = new System.Drawing.Point(0, 49);
            this.gc_CXGS.MainView = this.gv_CXGS;
            this.gc_CXGS.Name = "gc_CXGS";
            this.gc_CXGS.Size = new System.Drawing.Size(1028, 550);
            this.gc_CXGS.TabIndex = 36;
            this.gc_CXGS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CXGS});
            // 
            // gv_CXGS
            // 
            this.gv_CXGS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_EMP_ID,
            this.colC_ID,
            this.colC_STA_ID,
            this.colC_PRO_DESC,
            this.colC_REMARK,
            this.colN_STATUS,
            this.colD_START_DATE,
            this.colD_MOD_DT,
            this.gridColumn1});
            this.gv_CXGS.GridControl = this.gc_CXGS;
            this.gv_CXGS.Name = "gv_CXGS";
            this.gv_CXGS.OptionsBehavior.Editable = false;
            this.gv_CXGS.OptionsView.ShowGroupPanel = false;
            this.gv_CXGS.Click += new System.EventHandler(this.gv_CXGS_Click);
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 4;
            // 
            // colC_ID
            // 
            this.colC_ID.Caption = "主键";
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_STA_ID
            // 
            this.colC_STA_ID.Caption = "产线";
            this.colC_STA_ID.FieldName = "C_STA_ID";
            this.colC_STA_ID.Name = "colC_STA_ID";
            this.colC_STA_ID.Visible = true;
            this.colC_STA_ID.VisibleIndex = 0;
            // 
            // colC_PRO_DESC
            // 
            this.colC_PRO_DESC.Caption = "钩数";
            this.colC_PRO_DESC.FieldName = "N_HOOK_NUM";
            this.colC_PRO_DESC.Name = "colC_PRO_DESC";
            this.colC_PRO_DESC.Visible = true;
            this.colC_PRO_DESC.VisibleIndex = 1;
            // 
            // colC_REMARK
            // 
            this.colC_REMARK.Caption = "备注";
            this.colC_REMARK.FieldName = "C_REMARK";
            this.colC_REMARK.Name = "colC_REMARK";
            this.colC_REMARK.Visible = true;
            this.colC_REMARK.VisibleIndex = 3;
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.Caption = "状态";
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
            // 
            // colD_START_DATE
            // 
            this.colD_START_DATE.Caption = "启用时间";
            this.colD_START_DATE.FieldName = "D_START_DATE";
            this.colD_START_DATE.Name = "colD_START_DATE";
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "操作时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "在线钩数";
            this.gridColumn1.FieldName = "N_ONLINE_NUM";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // FrmPB_ZXGSWH01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 599);
            this.Controls.Add(this.gc_CXGS);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPB_ZXGSWH01";
            this.Text = "轧钢钩数维护";
            this.Load += new System.EventHandler(this.FrmPB_ZXGSWH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Online_Num.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PGH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CXGS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CXGS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GW1;
        private DevExpress.XtraEditors.TextEdit txt_BZ;
        private DevExpress.XtraEditors.SimpleButton btn_SaveDetails;
        private DevExpress.XtraEditors.LabelControl lab_GX;
        private DevExpress.XtraEditors.TextEdit txt_PGH;
        private DevExpress.XtraEditors.LabelControl lab_GXDM;
        private DevExpress.XtraEditors.LabelControl lab_BZ;
        private DevExpress.XtraEditors.SimpleButton btn_Reset;
        private DevExpress.XtraGrid.GridControl gc_CXGS;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CXGS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_PRO_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colC_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colD_START_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Online_Num;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}