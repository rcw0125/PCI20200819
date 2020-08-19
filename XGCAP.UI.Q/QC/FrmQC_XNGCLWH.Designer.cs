namespace XGCAP.UI.Q.QC
{
    partial class FrmQC_XNGCLWH
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
            this.gc_ZYXX = new DevExpress.XtraGrid.GridControl();
            this.gv_ZYXX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BatchNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.imgcbo_Name = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gc_right = new DevExpress.XtraGrid.GridControl();
            this.gv_right = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZYXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZYXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_ZYXX);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(726, 648);
            this.panelControl1.TabIndex = 10;
            // 
            // gc_ZYXX
            // 
            this.gc_ZYXX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ZYXX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_ZYXX.Location = new System.Drawing.Point(2, 40);
            this.gc_ZYXX.MainView = this.gv_ZYXX;
            this.gc_ZYXX.Margin = new System.Windows.Forms.Padding(2);
            this.gc_ZYXX.Name = "gc_ZYXX";
            this.gc_ZYXX.Size = new System.Drawing.Size(722, 606);
            this.gc_ZYXX.TabIndex = 10;
            this.gc_ZYXX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ZYXX});
            // 
            // gv_ZYXX
            // 
            this.gv_ZYXX.GridControl = this.gc_ZYXX;
            this.gv_ZYXX.Name = "gv_ZYXX";
            this.gv_ZYXX.OptionsBehavior.Editable = false;
            this.gv_ZYXX.OptionsView.ColumnAutoWidth = false;
            this.gv_ZYXX.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.txt_BatchNo);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(722, 38);
            this.panelControl2.TabIndex = 9;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(176, 7);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 17;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // txt_BatchNo
            // 
            this.txt_BatchNo.Location = new System.Drawing.Point(44, 8);
            this.txt_BatchNo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BatchNo.Name = "txt_BatchNo";
            this.txt_BatchNo.Size = new System.Drawing.Size(128, 20);
            this.txt_BatchNo.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 11);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "批号";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "性能名称";
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Add;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(203, 10);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 30;
            this.btn_Save.Text = "添加";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // imgcbo_Name
            // 
            this.imgcbo_Name.Location = new System.Drawing.Point(69, 11);
            this.imgcbo_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgcbo_Name.Name = "imgcbo_Name";
            this.imgcbo_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcbo_Name.Size = new System.Drawing.Size(128, 20);
            this.imgcbo_Name.TabIndex = 32;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(726, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 648);
            this.splitterControl1.TabIndex = 11;
            this.splitterControl1.TabStop = false;
            // 
            // gc_right
            // 
            this.gc_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_right.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_right.Location = new System.Drawing.Point(731, 40);
            this.gc_right.MainView = this.gv_right;
            this.gc_right.Margin = new System.Windows.Forms.Padding(2);
            this.gc_right.Name = "gc_right";
            this.gc_right.Size = new System.Drawing.Size(474, 608);
            this.gc_right.TabIndex = 14;
            this.gc_right.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_right});
            // 
            // gv_right
            // 
            this.gv_right.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gv_right.GridControl = this.gc_right;
            this.gv_right.Name = "gv_right";
            this.gv_right.OptionsBehavior.Editable = false;
            this.gv_right.OptionsView.ColumnAutoWidth = false;
            this.gv_right.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "批号";
            this.gridColumn1.FieldName = "C_BATCH_NO";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "执行标准";
            this.gridColumn2.FieldName = "C_STD_CODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "钢种";
            this.gridColumn3.FieldName = "C_STL_GRD";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "钩号";
            this.gridColumn4.FieldName = "C_TICK_NO";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "规格";
            this.gridColumn5.FieldName = "C_SPEC";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.btn_Save);
            this.panelControl3.Controls.Add(this.imgcbo_Name);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(731, 0);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(474, 40);
            this.panelControl3.TabIndex = 13;
            // 
            // FrmQC_XNGCLWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 648);
            this.Controls.Add(this.gc_right);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQC_XNGCLWH";
            this.Text = "性能结果录入项目添加";
            this.Load += new System.EventHandler(this.FrmQC_XNGCLWH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZYXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZYXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcbo_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_ZYXX;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ZYXX;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.TextEdit txt_BatchNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcbo_Name;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl gc_right;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_right;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}