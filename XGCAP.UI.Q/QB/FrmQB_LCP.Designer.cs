namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_LCP
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Grd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MatCode = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add_Main = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Main = new DevExpress.XtraGrid.GridControl();
            this.gv_Main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Tb = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete_Main = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Item = new DevExpress.XtraGrid.GridControl();
            this.gv_Item = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Delete_Item = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add_Item = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "钢种";
            // 
            // txt_Grd
            // 
            this.txt_Grd.Location = new System.Drawing.Point(37, 7);
            this.txt_Grd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Grd.Name = "txt_Grd";
            this.txt_Grd.Size = new System.Drawing.Size(121, 20);
            this.txt_Grd.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(167, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 132;
            this.labelControl2.Text = "物料号";
            // 
            // txt_MatCode
            // 
            this.txt_MatCode.Location = new System.Drawing.Point(207, 6);
            this.txt_MatCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatCode.Name = "txt_MatCode";
            this.txt_MatCode.Size = new System.Drawing.Size(137, 20);
            this.txt_MatCode.TabIndex = 133;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(10, 34);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 0;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Add_Main
            // 
            this.btn_Add_Main.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add_Main.Location = new System.Drawing.Point(97, 34);
            this.btn_Add_Main.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Add_Main.Name = "btn_Add_Main";
            this.btn_Add_Main.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_Main.TabIndex = 24;
            this.btn_Add_Main.Text = "增加";
            this.btn_Add_Main.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_Main);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(495, 558);
            this.panelControl1.TabIndex = 61;
            // 
            // gc_Main
            // 
            this.gc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Main.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_Main.Location = new System.Drawing.Point(2, 69);
            this.gc_Main.MainView = this.gv_Main;
            this.gc_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_Main.Name = "gc_Main";
            this.gc_Main.Size = new System.Drawing.Size(491, 487);
            this.gc_Main.TabIndex = 136;
            this.gc_Main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Main});
            // 
            // gv_Main
            // 
            this.gv_Main.GridControl = this.gc_Main;
            this.gv_Main.Name = "gv_Main";
            this.gv_Main.OptionsBehavior.Editable = false;
            this.gv_Main.OptionsView.ColumnAutoWidth = false;
            this.gv_Main.OptionsView.ShowGroupPanel = false;
            this.gv_Main.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Main_FocusedRowChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Tb);
            this.panelControl2.Controls.Add(this.btn_Delete_Main);
            this.panelControl2.Controls.Add(this.btn_Add_Main);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.txt_MatCode);
            this.panelControl2.Controls.Add(this.txt_Grd);
            this.panelControl2.Controls.Add(this.btn_Query);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(491, 67);
            this.panelControl2.TabIndex = 134;
            // 
            // btn_Tb
            // 
            this.btn_Tb.ImageUri.Uri = "Recurrence;Size16x16";
            this.btn_Tb.Location = new System.Drawing.Point(269, 34);
            this.btn_Tb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Tb.Name = "btn_Tb";
            this.btn_Tb.Size = new System.Drawing.Size(75, 23);
            this.btn_Tb.TabIndex = 135;
            this.btn_Tb.Text = "同步";
            this.btn_Tb.Click += new System.EventHandler(this.btn_Tb_Click);
            // 
            // btn_Delete_Main
            // 
            this.btn_Delete_Main.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Delete_Main.Location = new System.Drawing.Point(183, 34);
            this.btn_Delete_Main.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Delete_Main.Name = "btn_Delete_Main";
            this.btn_Delete_Main.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete_Main.TabIndex = 134;
            this.btn_Delete_Main.Text = "删除";
            this.btn_Delete_Main.Click += new System.EventHandler(this.btn_Delete_Main_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(495, 0);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 558);
            this.splitterControl1.TabIndex = 62;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gc_Item);
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(500, 0);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(425, 558);
            this.panelControl3.TabIndex = 63;
            // 
            // gc_Item
            // 
            this.gc_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Item.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_Item.Location = new System.Drawing.Point(2, 69);
            this.gc_Item.MainView = this.gv_Item;
            this.gc_Item.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_Item.Name = "gc_Item";
            this.gc_Item.Size = new System.Drawing.Size(421, 487);
            this.gc_Item.TabIndex = 138;
            this.gc_Item.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Item});
            // 
            // gv_Item
            // 
            this.gv_Item.GridControl = this.gc_Item;
            this.gv_Item.Name = "gv_Item";
            this.gv_Item.OptionsBehavior.Editable = false;
            this.gv_Item.OptionsView.ColumnAutoWidth = false;
            this.gv_Item.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btn_Delete_Item);
            this.panelControl4.Controls.Add(this.btn_Add_Item);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(421, 67);
            this.panelControl4.TabIndex = 0;
            // 
            // btn_Delete_Item
            // 
            this.btn_Delete_Item.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Delete_Item.Location = new System.Drawing.Point(109, 21);
            this.btn_Delete_Item.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Delete_Item.Name = "btn_Delete_Item";
            this.btn_Delete_Item.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete_Item.TabIndex = 135;
            this.btn_Delete_Item.Text = "删除";
            this.btn_Delete_Item.Click += new System.EventHandler(this.btn_Delete_Item_Click);
            // 
            // btn_Add_Item
            // 
            this.btn_Add_Item.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add_Item.Location = new System.Drawing.Point(17, 21);
            this.btn_Add_Item.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_Add_Item.Name = "btn_Add_Item";
            this.btn_Add_Item.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_Item.TabIndex = 25;
            this.btn_Add_Item.Text = "增加";
            this.btn_Add_Item.Click += new System.EventHandler(this.btn_Add_Item_Click);
            // 
            // FrmQB_LCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 558);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmQB_LCP";
            this.Text = "联产品信息";
            this.Load += new System.EventHandler(this.FrmQB_LCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Grd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_MatCode;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Add_Main;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_Main;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Main;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Delete_Main;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gc_Item;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Item;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_Delete_Item;
        private DevExpress.XtraEditors.SimpleButton btn_Add_Item;
        private DevExpress.XtraEditors.SimpleButton btn_Tb;
    }
}