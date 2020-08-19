namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_LCP_ADD
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
            this.gc_Plan = new DevExpress.XtraGrid.GridControl();
            this.gv_Plan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Grd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Spec = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MatName = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Gp = new DevExpress.XtraGrid.GridControl();
            this.gv_Gp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Plan)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Spec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Gp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Gp)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_Plan);
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(662, 564);
            this.panelControl1.TabIndex = 0;
            // 
            // gc_Plan
            // 
            this.gc_Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Plan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Plan.Location = new System.Drawing.Point(2, 36);
            this.gc_Plan.MainView = this.gv_Plan;
            this.gc_Plan.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Plan.Name = "gc_Plan";
            this.gc_Plan.Size = new System.Drawing.Size(658, 526);
            this.gc_Plan.TabIndex = 61;
            this.gc_Plan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Plan});
            // 
            // gv_Plan
            // 
            this.gv_Plan.GridControl = this.gc_Plan;
            this.gv_Plan.Name = "gv_Plan";
            this.gv_Plan.OptionsBehavior.Editable = false;
            this.gv_Plan.OptionsView.ColumnAutoWidth = false;
            this.gv_Plan.OptionsView.ShowGroupPanel = false;
            this.gv_Plan.OptionsView.ShowViewCaption = true;
            this.gv_Plan.ViewCaption = "计划信息";
            this.gv_Plan.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Plan_FocusedRowChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.labelControl3);
            this.flowLayoutPanel1.Controls.Add(this.txt_Grd);
            this.flowLayoutPanel1.Controls.Add(this.labelControl4);
            this.flowLayoutPanel1.Controls.Add(this.txt_Spec);
            this.flowLayoutPanel1.Controls.Add(this.labelControl1);
            this.flowLayoutPanel1.Controls.Add(this.txt_MatName);
            this.flowLayoutPanel1.Controls.Add(this.btn_Query);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(658, 34);
            this.flowLayoutPanel1.TabIndex = 60;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "钢种";
            // 
            // txt_Grd
            // 
            this.txt_Grd.Location = new System.Drawing.Point(37, 6);
            this.txt_Grd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Grd.Name = "txt_Grd";
            this.txt_Grd.Size = new System.Drawing.Size(118, 20);
            this.txt_Grd.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(161, 7);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "规格";
            // 
            // txt_Spec
            // 
            this.txt_Spec.Location = new System.Drawing.Point(191, 6);
            this.txt_Spec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Spec.Name = "txt_Spec";
            this.txt_Spec.Size = new System.Drawing.Size(94, 20);
            this.txt_Spec.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(291, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "物料名称";
            // 
            // txt_MatName
            // 
            this.txt_MatName.Location = new System.Drawing.Point(345, 6);
            this.txt_MatName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatName.Name = "txt_MatName";
            this.txt_MatName.Size = new System.Drawing.Size(142, 20);
            this.txt_MatName.TabIndex = 23;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(493, 4);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 0;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(662, 0);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 564);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_Gp);
            this.panelControl2.Controls.Add(this.flowLayoutPanel2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(667, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(369, 564);
            this.panelControl2.TabIndex = 2;
            // 
            // gc_Gp
            // 
            this.gc_Gp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Gp.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Gp.Location = new System.Drawing.Point(2, 36);
            this.gc_Gp.MainView = this.gv_Gp;
            this.gc_Gp.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Gp.Name = "gc_Gp";
            this.gc_Gp.Size = new System.Drawing.Size(365, 526);
            this.gc_Gp.TabIndex = 62;
            this.gc_Gp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Gp});
            // 
            // gv_Gp
            // 
            this.gv_Gp.GridControl = this.gc_Gp;
            this.gv_Gp.Name = "gv_Gp";
            this.gv_Gp.OptionsBehavior.Editable = false;
            this.gv_Gp.OptionsView.ColumnAutoWidth = false;
            this.gv_Gp.OptionsView.ShowGroupPanel = false;
            this.gv_Gp.OptionsView.ShowViewCaption = true;
            this.gv_Gp.ViewCaption = "改判信息";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.btn_Add);
            this.flowLayoutPanel2.Controls.Add(this.btn_Stop);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(365, 34);
            this.flowLayoutPanel2.TabIndex = 61;
            // 
            // btn_Add
            // 
            this.btn_Add.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(7, 4);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 24;
            this.btn_Add.Text = "添加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Stop.Location = new System.Drawing.Point(88, 4);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 25;
            this.btn_Stop.Text = "停用";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // FrmQB_LCP_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 564);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQB_LCP_ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "联产品信息维护";
            this.Load += new System.EventHandler(this.FrmQB_LCP_ADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Plan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Plan)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Spec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Gp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Gp)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Grd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Spec;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_MatName;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraGrid.GridControl gc_Plan;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Plan;
        private DevExpress.XtraGrid.GridControl gc_Gp;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Gp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
    }
}