namespace XGCAP.UI.P.PB
{
    partial class FrmPB_LGYLSJ1
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_JSCN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lab_GW1 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_GW = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbo_GX = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.gc_GWJSCL = new DevExpress.XtraGrid.GridControl();
            this.gv_GWJSCL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_SMELT_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_START_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_EMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_MOD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_DCYLSJ = new DevExpress.XtraEditors.SimpleButton();
            this.btn_UpdateGW = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Query2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_GW2 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbo_GX2 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_JSCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GWJSCL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GWJSCL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.txt_JSCN);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.lab_GW1);
            this.panelControl1.Controls.Add(this.cbo_GW);
            this.panelControl1.Controls.Add(this.cbo_GX);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1222, 56);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(404, 22);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "冶炼时间";
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(558, 18);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(77, 27);
            this.btn_Save.TabIndex = 75;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_JSCN
            // 
            this.txt_JSCN.Location = new System.Drawing.Point(471, 19);
            this.txt_JSCN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_JSCN.Name = "txt_JSCN";
            this.txt_JSCN.Properties.Mask.EditMask = "n0";
            this.txt_JSCN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_JSCN.Properties.MaxLength = 3;
            this.txt_JSCN.Size = new System.Drawing.Size(82, 24);
            this.txt_JSCN.TabIndex = 79;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(7, 22);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 18);
            this.labelControl6.TabIndex = 77;
            this.labelControl6.Text = "工序";
            // 
            // lab_GW1
            // 
            this.lab_GW1.Location = new System.Drawing.Point(184, 22);
            this.lab_GW1.Margin = new System.Windows.Forms.Padding(4);
            this.lab_GW1.Name = "lab_GW1";
            this.lab_GW1.Size = new System.Drawing.Size(30, 18);
            this.lab_GW1.TabIndex = 78;
            this.lab_GW1.Text = "工位";
            // 
            // cbo_GW
            // 
            this.cbo_GW.Location = new System.Drawing.Point(221, 19);
            this.cbo_GW.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbo_GW.Name = "cbo_GW";
            this.cbo_GW.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GW.Size = new System.Drawing.Size(176, 24);
            this.cbo_GW.TabIndex = 80;
            // 
            // cbo_GX
            // 
            this.cbo_GX.Location = new System.Drawing.Point(44, 19);
            this.cbo_GX.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbo_GX.Name = "cbo_GX";
            this.cbo_GX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GX.Size = new System.Drawing.Size(133, 24);
            this.cbo_GX.TabIndex = 81;
            this.cbo_GX.SelectedValueChanged += new System.EventHandler(this.cbo_GX_SelectedValueChanged);
            // 
            // gc_GWJSCL
            // 
            this.gc_GWJSCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_GWJSCL.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GWJSCL.Location = new System.Drawing.Point(0, 108);
            this.gc_GWJSCL.MainView = this.gv_GWJSCL;
            this.gc_GWJSCL.Margin = new System.Windows.Forms.Padding(4);
            this.gc_GWJSCL.Name = "gc_GWJSCL";
            this.gc_GWJSCL.Size = new System.Drawing.Size(1222, 446);
            this.gc_GWJSCL.TabIndex = 51;
            this.gc_GWJSCL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_GWJSCL});
            // 
            // gv_GWJSCL
            // 
            this.gv_GWJSCL.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colC_ID,
            this.colC_STA_ID,
            this.colC_STL_GRD,
            this.colN_SMELT_TIME,
            this.colD_START_DATE,
            this.colN_STATUS,
            this.colC_EMP_ID,
            this.colD_MOD_DT,
            this.colC_STD_CODE});
            this.gv_GWJSCL.GridControl = this.gc_GWJSCL;
            this.gv_GWJSCL.Name = "gv_GWJSCL";
            this.gv_GWJSCL.OptionsBehavior.Editable = false;
            this.gv_GWJSCL.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GWJSCL.OptionsView.ShowGroupPanel = false;
            // 
            // colC_ID
            // 
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            // 
            // colC_STA_ID
            // 
            this.colC_STA_ID.Caption = "工位";
            this.colC_STA_ID.FieldName = "C_STA_ID";
            this.colC_STA_ID.Name = "colC_STA_ID";
            this.colC_STA_ID.Visible = true;
            this.colC_STA_ID.VisibleIndex = 0;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            // 
            // colN_SMELT_TIME
            // 
            this.colN_SMELT_TIME.Caption = "冶炼时间";
            this.colN_SMELT_TIME.FieldName = "N_SMELT_TIME";
            this.colN_SMELT_TIME.Name = "colN_SMELT_TIME";
            this.colN_SMELT_TIME.Visible = true;
            this.colN_SMELT_TIME.VisibleIndex = 1;
            // 
            // colD_START_DATE
            // 
            this.colD_START_DATE.Caption = "启用时间";
            this.colD_START_DATE.DisplayFormat.FormatString = "G";
            this.colD_START_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_START_DATE.FieldName = "D_START_DATE";
            this.colD_START_DATE.Name = "colD_START_DATE";
            this.colD_START_DATE.Visible = true;
            this.colD_START_DATE.VisibleIndex = 2;
            // 
            // colN_STATUS
            // 
            this.colN_STATUS.Caption = "状态";
            this.colN_STATUS.FieldName = "N_STATUS";
            this.colN_STATUS.Name = "colN_STATUS";
            // 
            // colC_EMP_ID
            // 
            this.colC_EMP_ID.Caption = "操作人";
            this.colC_EMP_ID.FieldName = "C_EMP_ID";
            this.colC_EMP_ID.Name = "colC_EMP_ID";
            this.colC_EMP_ID.Visible = true;
            this.colC_EMP_ID.VisibleIndex = 3;
            // 
            // colD_MOD_DT
            // 
            this.colD_MOD_DT.Caption = "操作时间";
            this.colD_MOD_DT.DisplayFormat.FormatString = "G";
            this.colD_MOD_DT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_MOD_DT.FieldName = "D_MOD_DT";
            this.colD_MOD_DT.Name = "colD_MOD_DT";
            this.colD_MOD_DT.Visible = true;
            this.colD_MOD_DT.VisibleIndex = 4;
            // 
            // colC_STD_CODE
            // 
            this.colC_STD_CODE.Caption = "执行标准";
            this.colC_STD_CODE.FieldName = "C_STD_CODE";
            this.colC_STD_CODE.Name = "colC_STD_CODE";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_DCYLSJ);
            this.panelControl2.Controls.Add(this.btn_UpdateGW);
            this.panelControl2.Controls.Add(this.btn_Query2);
            this.panelControl2.Controls.Add(this.btn_Stop);
            this.panelControl2.Controls.Add(this.cbo_GW2);
            this.panelControl2.Controls.Add(this.cbo_GX2);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 56);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1222, 52);
            this.panelControl2.TabIndex = 52;
            // 
            // btn_DCYLSJ
            // 
            this.btn_DCYLSJ.ImageUri.Uri = "ExportToXLS;Size16x16";
            this.btn_DCYLSJ.Location = new System.Drawing.Point(659, 13);
            this.btn_DCYLSJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_DCYLSJ.Name = "btn_DCYLSJ";
            this.btn_DCYLSJ.Size = new System.Drawing.Size(77, 27);
            this.btn_DCYLSJ.TabIndex = 246;
            this.btn_DCYLSJ.Text = "导出";
            this.btn_DCYLSJ.Click += new System.EventHandler(this.btn_DCYLSJ_Click);
            // 
            // btn_UpdateGW
            // 
            this.btn_UpdateGW.ImageUri.Uri = "Save;Size16x16";
            this.btn_UpdateGW.Location = new System.Drawing.Point(489, 12);
            this.btn_UpdateGW.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UpdateGW.Name = "btn_UpdateGW";
            this.btn_UpdateGW.Size = new System.Drawing.Size(77, 27);
            this.btn_UpdateGW.TabIndex = 139;
            this.btn_UpdateGW.Text = "修改";
            this.btn_UpdateGW.Click += new System.EventHandler(this.btn_UpdateGW_Click);
            // 
            // btn_Query2
            // 
            this.btn_Query2.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query2.Location = new System.Drawing.Point(404, 12);
            this.btn_Query2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_Query2.Name = "btn_Query2";
            this.btn_Query2.Size = new System.Drawing.Size(77, 27);
            this.btn_Query2.TabIndex = 72;
            this.btn_Query2.Text = "查询";
            this.btn_Query2.Click += new System.EventHandler(this.btn_Query2_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(574, 13);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(77, 27);
            this.btn_Stop.TabIndex = 48;
            this.btn_Stop.Text = "删除";
            this.btn_Stop.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cbo_GW2
            // 
            this.cbo_GW2.Location = new System.Drawing.Point(220, 14);
            this.cbo_GW2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbo_GW2.Name = "cbo_GW2";
            this.cbo_GW2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GW2.Size = new System.Drawing.Size(176, 24);
            this.cbo_GW2.TabIndex = 74;
            // 
            // cbo_GX2
            // 
            this.cbo_GX2.Location = new System.Drawing.Point(44, 14);
            this.cbo_GX2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbo_GX2.Name = "cbo_GX2";
            this.cbo_GX2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GX2.Size = new System.Drawing.Size(133, 24);
            this.cbo_GX2.TabIndex = 74;
            this.cbo_GX2.SelectedValueChanged += new System.EventHandler(this.cbo_GX2_SelectedValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(183, 18);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 18);
            this.labelControl5.TabIndex = 73;
            this.labelControl5.Text = "工位";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 18);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 18);
            this.labelControl7.TabIndex = 72;
            this.labelControl7.Text = "工序";
            // 
            // FrmPB_LGYLSJ1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 554);
            this.Controls.Add(this.gc_GWJSCL);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPB_LGYLSJ1";
            this.Text = "炼钢冶炼时间";
            this.Load += new System.EventHandler(this.FrmPB_LGYLSJ1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_JSCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_GWJSCL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_GWJSCL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GW2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GX2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_GWJSCL;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_GWJSCL;
        private DevExpress.XtraGrid.Columns.GridColumn colC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colN_SMELT_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colD_START_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colN_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colC_EMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colD_MOD_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Query2;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GW2;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GX2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.TextEdit txt_JSCN;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lab_GW1;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GW;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbo_GX;
        private DevExpress.XtraEditors.SimpleButton btn_UpdateGW;
        private DevExpress.XtraEditors.SimpleButton btn_DCYLSJ;
    }
}