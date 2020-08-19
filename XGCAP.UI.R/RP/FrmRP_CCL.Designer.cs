namespace XGCAP.UI.R.RP
{
    partial class FrmRP_CCL
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
            this.gc_ZGSJ = new DevExpress.XtraGrid.GridControl();
            this.gv_ZGSJ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txt_ElseType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ElseCon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Condition2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Condition = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Percentage = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_TB = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Kind = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZGSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZGSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ElseType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ElseCon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Condition2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Condition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Percentage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Kind.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_ZGSJ
            // 
            this.gc_ZGSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ZGSJ.Location = new System.Drawing.Point(0, 76);
            this.gc_ZGSJ.MainView = this.gv_ZGSJ;
            this.gc_ZGSJ.Name = "gc_ZGSJ";
            this.gc_ZGSJ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gc_ZGSJ.Size = new System.Drawing.Size(953, 374);
            this.gc_ZGSJ.TabIndex = 29;
            this.gc_ZGSJ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ZGSJ});
            // 
            // gv_ZGSJ
            // 
            this.gv_ZGSJ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gv_ZGSJ.GridControl = this.gc_ZGSJ;
            this.gv_ZGSJ.Name = "gv_ZGSJ";
            this.gv_ZGSJ.OptionsBehavior.Editable = false;
            this.gv_ZGSJ.OptionsView.ShowGroupPanel = false;
            this.gv_ZGSJ.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gv_ZGSJ_CustomColumnDisplayText);
            this.gv_ZGSJ.Click += new System.EventHandler(this.gv_ZGSJ_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "C_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "品种";
            this.gridColumn3.FieldName = "C_PROD_KIND";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "类别";
            this.gridColumn2.FieldName = "C_PROD_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "百分比";
            this.gridColumn4.FieldName = "C_PERCENTAGE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "条件";
            this.gridColumn5.FieldName = "C_CONDITION";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "条件2";
            this.gridColumn6.FieldName = "C_CONDITION2";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "其他条件";
            this.gridColumn7.FieldName = "C_ELSECON";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "其他类别";
            this.gridColumn8.FieldName = "C_ELSETYPE";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "成材率配置类型";
            this.gridColumn9.FieldName = "N_TYPE";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txt_ElseType);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.txt_ElseCon);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txt_Condition2);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.txt_Condition);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.txt_Percentage);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txt_Name);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btn_TB);
            this.panelControl2.Controls.Add(this.txt_Kind);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(953, 76);
            this.panelControl2.TabIndex = 28;
            // 
            // txt_ElseType
            // 
            this.txt_ElseType.Location = new System.Drawing.Point(279, 40);
            this.txt_ElseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ElseType.Name = "txt_ElseType";
            this.txt_ElseType.Properties.MaxLength = 30;
            this.txt_ElseType.Size = new System.Drawing.Size(144, 20);
            this.txt_ElseType.TabIndex = 253;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(225, 43);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 252;
            this.labelControl6.Text = "其他类别";
            // 
            // txt_ElseCon
            // 
            this.txt_ElseCon.Location = new System.Drawing.Point(65, 40);
            this.txt_ElseCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ElseCon.Name = "txt_ElseCon";
            this.txt_ElseCon.Properties.MaxLength = 30;
            this.txt_ElseCon.Size = new System.Drawing.Size(144, 20);
            this.txt_ElseCon.TabIndex = 251;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 43);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 250;
            this.labelControl5.Text = "其他条件";
            // 
            // txt_Condition2
            // 
            this.txt_Condition2.Location = new System.Drawing.Point(503, 40);
            this.txt_Condition2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Condition2.Name = "txt_Condition2";
            this.txt_Condition2.Properties.MaxLength = 30;
            this.txt_Condition2.Size = new System.Drawing.Size(144, 20);
            this.txt_Condition2.TabIndex = 249;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(466, 43);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 14);
            this.labelControl4.TabIndex = 248;
            this.labelControl4.Text = "条件2";
            // 
            // txt_Condition
            // 
            this.txt_Condition.Location = new System.Drawing.Point(715, 11);
            this.txt_Condition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Condition.Name = "txt_Condition";
            this.txt_Condition.Properties.MaxLength = 30;
            this.txt_Condition.Size = new System.Drawing.Size(144, 20);
            this.txt_Condition.TabIndex = 247;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(685, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 246;
            this.labelControl3.Text = "条件";
            // 
            // txt_Percentage
            // 
            this.txt_Percentage.Location = new System.Drawing.Point(503, 11);
            this.txt_Percentage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Percentage.Name = "txt_Percentage";
            this.txt_Percentage.Properties.MaxLength = 30;
            this.txt_Percentage.Size = new System.Drawing.Size(144, 20);
            this.txt_Percentage.TabIndex = 245;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(461, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 244;
            this.labelControl2.Text = "百分比";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(279, 11);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.MaxLength = 30;
            this.txt_Name.Size = new System.Drawing.Size(144, 20);
            this.txt_Name.TabIndex = 243;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(249, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 242;
            this.labelControl1.Text = "类别";
            // 
            // btn_TB
            // 
            this.btn_TB.ImageUri.Uri = "Refresh;Size16x16";
            this.btn_TB.Location = new System.Drawing.Point(877, 10);
            this.btn_TB.Name = "btn_TB";
            this.btn_TB.Size = new System.Drawing.Size(54, 23);
            this.btn_TB.TabIndex = 241;
            this.btn_TB.Text = "保存";
            this.btn_TB.Click += new System.EventHandler(this.btn_TB_Click);
            // 
            // txt_Kind
            // 
            this.txt_Kind.Location = new System.Drawing.Point(65, 11);
            this.txt_Kind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Kind.Name = "txt_Kind";
            this.txt_Kind.Properties.MaxLength = 30;
            this.txt_Kind.Size = new System.Drawing.Size(144, 20);
            this.txt_Kind.TabIndex = 230;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(35, 14);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(24, 14);
            this.labelControl13.TabIndex = 228;
            this.labelControl13.Text = "品种";
            // 
            // FrmRP_CCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.gc_ZGSJ);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmRP_CCL";
            this.Text = "FrmRP_CCL";
            this.Load += new System.EventHandler(this.FrmRP_CCL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ZGSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ZGSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ElseType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ElseCon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Condition2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Condition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Percentage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Kind.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_ZGSJ;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ZGSJ;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_TB;
        private DevExpress.XtraEditors.TextEdit txt_Kind;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.TextEdit txt_ElseType;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_ElseCon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_Condition2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Condition;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Percentage;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}