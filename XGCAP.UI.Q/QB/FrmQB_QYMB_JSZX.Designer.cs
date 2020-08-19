namespace XGCAP.UI.Q.QB
{
    partial class FrmQB_QYMB_JSZX
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
            this.gc_Main = new DevExpress.XtraGrid.GridControl();
            this.gv_Main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Del_Main = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add_Main = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BZ = new DevExpress.XtraEditors.TextEdit();
            this.txt_GZ = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrl = new DevExpress.XtraEditors.ButtonEdit();
            this.btn_Bz = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del_Item = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add_Item = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Item = new DevExpress.XtraGrid.GridControl();
            this.gv_Item = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_Main);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(500, 633);
            this.panelControl1.TabIndex = 0;
            // 
            // gc_Main
            // 
            this.gc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Main.Location = new System.Drawing.Point(2, 79);
            this.gc_Main.MainView = this.gv_Main;
            this.gc_Main.Name = "gc_Main";
            this.gc_Main.Size = new System.Drawing.Size(496, 552);
            this.gc_Main.TabIndex = 1;
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
            this.panelControl2.Controls.Add(this.btn_Del_Main);
            this.panelControl2.Controls.Add(this.btn_Add_Main);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.txt_BZ);
            this.panelControl2.Controls.Add(this.txt_GZ);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(496, 77);
            this.panelControl2.TabIndex = 0;
            // 
            // btn_Del_Main
            // 
            this.btn_Del_Main.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Del_Main.Location = new System.Drawing.Point(260, 42);
            this.btn_Del_Main.Name = "btn_Del_Main";
            this.btn_Del_Main.Size = new System.Drawing.Size(95, 25);
            this.btn_Del_Main.TabIndex = 6;
            this.btn_Del_Main.Text = "删除";
            this.btn_Del_Main.Click += new System.EventHandler(this.btn_Del_Main_Click);
            // 
            // btn_Add_Main
            // 
            this.btn_Add_Main.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add_Main.Location = new System.Drawing.Point(135, 42);
            this.btn_Add_Main.Name = "btn_Add_Main";
            this.btn_Add_Main.Size = new System.Drawing.Size(95, 25);
            this.btn_Add_Main.TabIndex = 5;
            this.btn_Add_Main.Text = "添加";
            this.btn_Add_Main.Click += new System.EventHandler(this.btn_Add_Main_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Zoom;Size16x16";
            this.simpleButton1.Location = new System.Drawing.Point(11, 42);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(95, 25);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_BZ
            // 
            this.txt_BZ.Location = new System.Drawing.Point(308, 8);
            this.txt_BZ.Name = "txt_BZ";
            this.txt_BZ.Size = new System.Drawing.Size(172, 24);
            this.txt_BZ.TabIndex = 3;
            // 
            // txt_GZ
            // 
            this.txt_GZ.Location = new System.Drawing.Point(48, 8);
            this.txt_GZ.Name = "txt_GZ";
            this.txt_GZ.Size = new System.Drawing.Size(172, 24);
            this.txt_GZ.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(242, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "执行标准";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "钢种";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(500, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 633);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_Save);
            this.panelControl3.Controls.Add(this.labelControl13);
            this.panelControl3.Controls.Add(this.txtUrl);
            this.panelControl3.Controls.Add(this.btn_Bz);
            this.panelControl3.Controls.Add(this.btn_Del_Item);
            this.panelControl3.Controls.Add(this.btn_Add_Item);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(506, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(753, 79);
            this.panelControl3.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(157, 27);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(95, 25);
            this.btn_Save.TabIndex = 42;
            this.btn_Save.Text = "保存";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(394, 32);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(60, 18);
            this.labelControl13.TabIndex = 40;
            this.labelControl13.Text = "导入文件";
            this.labelControl13.Visible = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(462, 29);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtUrl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtUrl.Size = new System.Drawing.Size(154, 24);
            this.txtUrl.TabIndex = 41;
            this.txtUrl.Visible = false;
            this.txtUrl.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtUrl_ButtonClick);
            // 
            // btn_Bz
            // 
            this.btn_Bz.ImageUri.Uri = "EditDataSource;Size16x16";
            this.btn_Bz.Location = new System.Drawing.Point(624, 27);
            this.btn_Bz.Name = "btn_Bz";
            this.btn_Bz.Size = new System.Drawing.Size(106, 27);
            this.btn_Bz.TabIndex = 39;
            this.btn_Bz.Text = "导入模板";
            this.btn_Bz.Visible = false;
            this.btn_Bz.Click += new System.EventHandler(this.btn_Bz_Click);
            // 
            // btn_Del_Item
            // 
            this.btn_Del_Item.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Del_Item.Location = new System.Drawing.Point(274, 26);
            this.btn_Del_Item.Name = "btn_Del_Item";
            this.btn_Del_Item.Size = new System.Drawing.Size(95, 25);
            this.btn_Del_Item.TabIndex = 10;
            this.btn_Del_Item.Text = "删除";
            this.btn_Del_Item.Click += new System.EventHandler(this.btn_Del_Item_Click);
            // 
            // btn_Add_Item
            // 
            this.btn_Add_Item.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add_Item.Location = new System.Drawing.Point(38, 27);
            this.btn_Add_Item.Name = "btn_Add_Item";
            this.btn_Add_Item.Size = new System.Drawing.Size(95, 25);
            this.btn_Add_Item.TabIndex = 9;
            this.btn_Add_Item.Text = "添加";
            this.btn_Add_Item.Click += new System.EventHandler(this.btn_Add_Item_Click);
            // 
            // gc_Item
            // 
            this.gc_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Item.Location = new System.Drawing.Point(506, 79);
            this.gc_Item.MainView = this.gv_Item;
            this.gc_Item.Name = "gc_Item";
            this.gc_Item.Size = new System.Drawing.Size(753, 554);
            this.gc_Item.TabIndex = 3;
            this.gc_Item.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Item});
            // 
            // gv_Item
            // 
            this.gv_Item.GridControl = this.gc_Item;
            this.gv_Item.Name = "gv_Item";
            this.gv_Item.OptionsView.ColumnAutoWidth = false;
            this.gv_Item.OptionsView.ShowGroupPanel = false;
            // 
            // FrmQB_QYMB_JSZX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 633);
            this.Controls.Add(this.gc_Item);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQB_QYMB_JSZX";
            this.Text = "取样模板维护(技术中心)";
            this.Load += new System.EventHandler(this.FrmQB_QYMB_JSZX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GZ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_Main;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Main;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txt_BZ;
        private DevExpress.XtraEditors.TextEdit txt_GZ;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Del_Main;
        private DevExpress.XtraEditors.SimpleButton btn_Add_Main;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gc_Item;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Item;
        private DevExpress.XtraEditors.SimpleButton btn_Del_Item;
        private DevExpress.XtraEditors.SimpleButton btn_Add_Item;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.ButtonEdit txtUrl;
        private DevExpress.XtraEditors.SimpleButton btn_Bz;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
    }
}