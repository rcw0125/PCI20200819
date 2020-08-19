namespace XGCAP.UI.P.PO.GPKWT
{
    partial class FrmPO_GPKWTPZ
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
            this.txt_KW = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_EditLabel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Height = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Width = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.icbo_CK = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gc_KW = new DevExpress.XtraGrid.GridControl();
            this.gv_KW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Height.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Width.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_CK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_KW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KW)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_KW);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.btn_EditLabel);
            this.panel1.Controls.Add(this.btn_Del);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.txt_Height);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txt_Width);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.icbo_CK);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 66);
            this.panel1.TabIndex = 0;
            // 
            // txt_KW
            // 
            this.txt_KW.EditValue = "";
            this.txt_KW.Location = new System.Drawing.Point(560, 7);
            this.txt_KW.Margin = new System.Windows.Forms.Padding(2);
            this.txt_KW.Name = "txt_KW";
            this.txt_KW.Properties.ReadOnly = true;
            this.txt_KW.Size = new System.Drawing.Size(99, 20);
            this.txt_KW.TabIndex = 30;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(533, 10);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "库位";
            // 
            // btn_EditLabel
            // 
            this.btn_EditLabel.ImageUri.Uri = "Reset;Size16x16";
            this.btn_EditLabel.Location = new System.Drawing.Point(260, 35);
            this.btn_EditLabel.Name = "btn_EditLabel";
            this.btn_EditLabel.Size = new System.Drawing.Size(100, 23);
            this.btn_EditLabel.TabIndex = 28;
            this.btn_EditLabel.Text = "修改标签大小";
            this.btn_EditLabel.Click += new System.EventHandler(this.btn_EditLabel_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.ImageUri.Uri = "Delete;Size16x16";
            this.btn_Del.Location = new System.Drawing.Point(177, 34);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 27;
            this.btn_Del.Text = "删除标签";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(94, 34);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 26;
            this.btn_Save.Text = "保存配置";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(11, 34);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 25;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Height
            // 
            this.txt_Height.EditValue = "60";
            this.txt_Height.Location = new System.Drawing.Point(444, 7);
            this.txt_Height.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(75, 20);
            this.txt_Height.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(394, 10);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "标签高度";
            // 
            // txt_Width
            // 
            this.txt_Width.EditValue = "80";
            this.txt_Width.Location = new System.Drawing.Point(309, 7);
            this.txt_Width.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(75, 20);
            this.txt_Width.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(260, 10);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "标签宽度";
            // 
            // icbo_CK
            // 
            this.icbo_CK.Location = new System.Drawing.Point(39, 7);
            this.icbo_CK.Margin = new System.Windows.Forms.Padding(2);
            this.icbo_CK.Name = "icbo_CK";
            this.icbo_CK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbo_CK.Size = new System.Drawing.Size(213, 20);
            this.icbo_CK.TabIndex = 18;
            this.icbo_CK.SelectedIndexChanged += new System.EventHandler(this.icbo_CK_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "仓库";
            // 
            // gc_KW
            // 
            this.gc_KW.Dock = System.Windows.Forms.DockStyle.Left;
            this.gc_KW.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_KW.Location = new System.Drawing.Point(0, 66);
            this.gc_KW.MainView = this.gv_KW;
            this.gc_KW.Margin = new System.Windows.Forms.Padding(2);
            this.gc_KW.Name = "gc_KW";
            this.gc_KW.Size = new System.Drawing.Size(290, 728);
            this.gc_KW.TabIndex = 1;
            this.gc_KW.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_KW});
            // 
            // gv_KW
            // 
            this.gv_KW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gv_KW.GridControl = this.gc_KW;
            this.gv_KW.Name = "gv_KW";
            this.gv_KW.OptionsBehavior.Editable = false;
            this.gv_KW.OptionsView.ColumnAutoWidth = false;
            this.gv_KW.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "C_ID";
            this.gridColumn1.FieldName = "C_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "库位编号";
            this.gridColumn2.FieldName = "C_SLABWH_LOC_CODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "库位容量";
            this.gridColumn3.FieldName = "N_SLABWH_LOC_CAP";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "库位名称";
            this.gridColumn4.FieldName = "C_SLABWH_LOC_NAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(290, 66);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 728);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(295, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 728);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1500, 1500);
            this.panel4.TabIndex = 0;
            // 
            // FrmPO_GPKWTPZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 794);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gc_KW);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPO_GPKWTPZ";
            this.Text = "钢坯库位图配置";
            this.Load += new System.EventHandler(this.FrmPO_GPKWTPZ_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Height.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Width.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbo_CK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_KW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KW)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.TextEdit txt_Height;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Width;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbo_CK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gc_KW;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_KW;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btn_EditLabel;
        private DevExpress.XtraEditors.TextEdit txt_KW;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}