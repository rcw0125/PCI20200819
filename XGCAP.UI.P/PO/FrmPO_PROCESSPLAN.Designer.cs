namespace XGCAP.UI.P.PO
{
    partial class FrmPO_PROCESSPLAN
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
            this.btn_QueryNC = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STL_GRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_STD_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_P_START_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_P_END_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_DFPHL_START_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_DFPHL_END_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_KP_START_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_KP_END_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_PROD_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_PRODUCE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_ARRIVE_ZG_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_DFP_HL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_HL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_XM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_HL_START_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_HL_END_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_PLAN_KY_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_XM_START_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_XM_END_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_DFP_RZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_RZP_RZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btn_QueryNC);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1201, 48);
            this.panelControl1.TabIndex = 20;
            // 
            // btn_QueryNC
            // 
            this.btn_QueryNC.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_QueryNC.Location = new System.Drawing.Point(13, 13);
            this.btn_QueryNC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btn_QueryNC.Name = "btn_QueryNC";
            this.btn_QueryNC.Size = new System.Drawing.Size(100, 29);
            this.btn_QueryNC.TabIndex = 201;
            this.btn_QueryNC.Text = "查询";
            this.btn_QueryNC.Click += new System.EventHandler(this.btn_QueryNC_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1201, 688);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colC_STL_GRD,
            this.colC_STD_CODE,
            this.colD_P_START_TIME,
            this.colD_P_END_TIME,
            this.colD_DFPHL_START_TIME,
            this.colD_DFPHL_END_TIME,
            this.colD_KP_START_TIME,
            this.colD_KP_END_TIME,
            this.colN_PROD_TIME,
            this.colN_PRODUCE_TIME,
            this.colD_ARRIVE_ZG_TIME,
            this.colC_DFP_HL,
            this.colC_HL,
            this.colC_XM,
            this.colD_HL_START_TIME,
            this.colD_HL_END_TIME,
            this.colD_PLAN_KY_TIME,
            this.colD_XM_START_TIME,
            this.colD_XM_END_TIME,
            this.colC_DFP_RZ,
            this.colC_RZP_RZ,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "是否停用";
            this.gridColumn1.FieldName = "N_STATUS";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 130;
            // 
            // colC_STL_GRD
            // 
            this.colC_STL_GRD.Caption = "钢种";
            this.colC_STL_GRD.FieldName = "C_STL_GRD";
            this.colC_STL_GRD.Name = "colC_STL_GRD";
            this.colC_STL_GRD.Visible = true;
            this.colC_STL_GRD.VisibleIndex = 1;
            this.colC_STL_GRD.Width = 68;
            // 
            // colC_STD_CODE
            // 
            this.colC_STD_CODE.Caption = "执行标准";
            this.colC_STD_CODE.FieldName = "C_STD_CODE";
            this.colC_STD_CODE.Name = "colC_STD_CODE";
            this.colC_STD_CODE.Visible = true;
            this.colC_STD_CODE.VisibleIndex = 2;
            this.colC_STD_CODE.Width = 78;
            // 
            // colD_P_START_TIME
            // 
            this.colD_P_START_TIME.Caption = "连铸计划开始时间";
            this.colD_P_START_TIME.DisplayFormat.FormatString = "G";
            this.colD_P_START_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_P_START_TIME.FieldName = "D_P_START_TIME";
            this.colD_P_START_TIME.Name = "colD_P_START_TIME";
            this.colD_P_START_TIME.Visible = true;
            this.colD_P_START_TIME.VisibleIndex = 3;
            this.colD_P_START_TIME.Width = 153;
            // 
            // colD_P_END_TIME
            // 
            this.colD_P_END_TIME.Caption = "连铸计划结束时间";
            this.colD_P_END_TIME.DisplayFormat.FormatString = "G";
            this.colD_P_END_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_P_END_TIME.FieldName = "D_P_END_TIME";
            this.colD_P_END_TIME.Name = "colD_P_END_TIME";
            this.colD_P_END_TIME.Visible = true;
            this.colD_P_END_TIME.VisibleIndex = 4;
            this.colD_P_END_TIME.Width = 150;
            // 
            // colD_DFPHL_START_TIME
            // 
            this.colD_DFPHL_START_TIME.Caption = "大方坯缓冷计划开始时间";
            this.colD_DFPHL_START_TIME.DisplayFormat.FormatString = "G";
            this.colD_DFPHL_START_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_DFPHL_START_TIME.FieldName = "D_DFPHL_START_TIME";
            this.colD_DFPHL_START_TIME.Name = "colD_DFPHL_START_TIME";
            this.colD_DFPHL_START_TIME.Visible = true;
            this.colD_DFPHL_START_TIME.VisibleIndex = 5;
            this.colD_DFPHL_START_TIME.Width = 189;
            // 
            // colD_DFPHL_END_TIME
            // 
            this.colD_DFPHL_END_TIME.Caption = "大方坯缓冷计划结束时间";
            this.colD_DFPHL_END_TIME.DisplayFormat.FormatString = "G";
            this.colD_DFPHL_END_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_DFPHL_END_TIME.FieldName = "D_DFPHL_END_TIME";
            this.colD_DFPHL_END_TIME.Name = "colD_DFPHL_END_TIME";
            this.colD_DFPHL_END_TIME.Visible = true;
            this.colD_DFPHL_END_TIME.VisibleIndex = 6;
            this.colD_DFPHL_END_TIME.Width = 193;
            // 
            // colD_KP_START_TIME
            // 
            this.colD_KP_START_TIME.Caption = "开坯计划开始时间";
            this.colD_KP_START_TIME.DisplayFormat.FormatString = "G";
            this.colD_KP_START_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_KP_START_TIME.FieldName = "D_KP_START_TIME";
            this.colD_KP_START_TIME.Name = "colD_KP_START_TIME";
            this.colD_KP_START_TIME.Visible = true;
            this.colD_KP_START_TIME.VisibleIndex = 7;
            this.colD_KP_START_TIME.Width = 140;
            // 
            // colD_KP_END_TIME
            // 
            this.colD_KP_END_TIME.Caption = "开坯计划结束时间";
            this.colD_KP_END_TIME.DisplayFormat.FormatString = "G";
            this.colD_KP_END_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_KP_END_TIME.FieldName = "D_KP_END_TIME";
            this.colD_KP_END_TIME.Name = "colD_KP_END_TIME";
            this.colD_KP_END_TIME.Visible = true;
            this.colD_KP_END_TIME.VisibleIndex = 8;
            this.colD_KP_END_TIME.Width = 150;
            // 
            // colN_PROD_TIME
            // 
            this.colN_PROD_TIME.FieldName = "N_PROD_TIME";
            this.colN_PROD_TIME.Name = "colN_PROD_TIME";
            this.colN_PROD_TIME.Width = 52;
            // 
            // colN_PRODUCE_TIME
            // 
            this.colN_PRODUCE_TIME.FieldName = "N_PRODUCE_TIME";
            this.colN_PRODUCE_TIME.Name = "colN_PRODUCE_TIME";
            this.colN_PRODUCE_TIME.Width = 52;
            // 
            // colD_ARRIVE_ZG_TIME
            // 
            this.colD_ARRIVE_ZG_TIME.FieldName = "D_ARRIVE_ZG_TIME";
            this.colD_ARRIVE_ZG_TIME.Name = "colD_ARRIVE_ZG_TIME";
            this.colD_ARRIVE_ZG_TIME.Width = 52;
            // 
            // colC_DFP_HL
            // 
            this.colC_DFP_HL.FieldName = "C_DFP_HL";
            this.colC_DFP_HL.Name = "colC_DFP_HL";
            this.colC_DFP_HL.Visible = true;
            this.colC_DFP_HL.VisibleIndex = 15;
            this.colC_DFP_HL.Width = 37;
            // 
            // colC_HL
            // 
            this.colC_HL.FieldName = "C_HL";
            this.colC_HL.Name = "colC_HL";
            this.colC_HL.Visible = true;
            this.colC_HL.VisibleIndex = 16;
            this.colC_HL.Width = 37;
            // 
            // colC_XM
            // 
            this.colC_XM.FieldName = "C_XM";
            this.colC_XM.Name = "colC_XM";
            this.colC_XM.Visible = true;
            this.colC_XM.VisibleIndex = 17;
            this.colC_XM.Width = 109;
            // 
            // colD_HL_START_TIME
            // 
            this.colD_HL_START_TIME.Caption = "缓冷开始时间";
            this.colD_HL_START_TIME.DisplayFormat.FormatString = "G";
            this.colD_HL_START_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_HL_START_TIME.FieldName = "D_HL_START_TIME";
            this.colD_HL_START_TIME.Name = "colD_HL_START_TIME";
            this.colD_HL_START_TIME.Visible = true;
            this.colD_HL_START_TIME.VisibleIndex = 9;
            this.colD_HL_START_TIME.Width = 78;
            // 
            // colD_HL_END_TIME
            // 
            this.colD_HL_END_TIME.Caption = "缓冷结束时间";
            this.colD_HL_END_TIME.DisplayFormat.FormatString = "G";
            this.colD_HL_END_TIME.FieldName = "D_HL_END_TIME";
            this.colD_HL_END_TIME.Name = "colD_HL_END_TIME";
            this.colD_HL_END_TIME.Visible = true;
            this.colD_HL_END_TIME.VisibleIndex = 10;
            this.colD_HL_END_TIME.Width = 78;
            // 
            // colD_PLAN_KY_TIME
            // 
            this.colD_PLAN_KY_TIME.FieldName = "D_PLAN_KY_TIME";
            this.colD_PLAN_KY_TIME.Name = "colD_PLAN_KY_TIME";
            this.colD_PLAN_KY_TIME.Width = 52;
            // 
            // colD_XM_START_TIME
            // 
            this.colD_XM_START_TIME.Caption = "修磨开始时间";
            this.colD_XM_START_TIME.DisplayFormat.FormatString = "G";
            this.colD_XM_START_TIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colD_XM_START_TIME.FieldName = "D_XM_START_TIME";
            this.colD_XM_START_TIME.Name = "colD_XM_START_TIME";
            this.colD_XM_START_TIME.Visible = true;
            this.colD_XM_START_TIME.VisibleIndex = 11;
            this.colD_XM_START_TIME.Width = 52;
            // 
            // colD_XM_END_TIME
            // 
            this.colD_XM_END_TIME.Caption = "修磨结束时间";
            this.colD_XM_END_TIME.DisplayFormat.FormatString = "G";
            this.colD_XM_END_TIME.FieldName = "D_XM_END_TIME";
            this.colD_XM_END_TIME.Name = "colD_XM_END_TIME";
            this.colD_XM_END_TIME.Visible = true;
            this.colD_XM_END_TIME.VisibleIndex = 12;
            this.colD_XM_END_TIME.Width = 111;
            // 
            // colC_DFP_RZ
            // 
            this.colC_DFP_RZ.Caption = "大方坯能否热装";
            this.colC_DFP_RZ.FieldName = "C_DFP_RZ";
            this.colC_DFP_RZ.Name = "colC_DFP_RZ";
            this.colC_DFP_RZ.Visible = true;
            this.colC_DFP_RZ.VisibleIndex = 13;
            this.colC_DFP_RZ.Width = 94;
            // 
            // colC_RZP_RZ
            // 
            this.colC_RZP_RZ.Caption = "热轧坯能否热装";
            this.colC_RZP_RZ.FieldName = "C_RZP_RZ";
            this.colC_RZP_RZ.Name = "colC_RZP_RZ";
            this.colC_RZP_RZ.Visible = true;
            this.colC_RZP_RZ.VisibleIndex = 14;
            this.colC_RZP_RZ.Width = 83;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "排序时间";
            this.gridColumn2.DisplayFormat.FormatString = "G";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "CalCulateTimeStart";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 76;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.FieldName = "C_ID";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "支数";
            this.gridColumn4.FieldName = "C_QUA";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 73;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Apply;Size16x16";
            this.simpleButton1.Location = new System.Drawing.Point(135, 13);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(171, 29);
            this.simpleButton1.TabIndex = 202;
            this.simpleButton1.Text = "工序计划时间设置";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmPO_PROCESSPLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 736);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPO_PROCESSPLAN";
            this.Text = "FrmPO_PROCESSPLAN";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_QueryNC;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STL_GRD;
        private DevExpress.XtraGrid.Columns.GridColumn colC_STD_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colD_P_START_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colD_P_END_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colD_DFPHL_START_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colD_DFPHL_END_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colD_KP_START_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colD_KP_END_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colN_PROD_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colN_PRODUCE_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colD_ARRIVE_ZG_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_DFP_HL;
        private DevExpress.XtraGrid.Columns.GridColumn colC_HL;
        private DevExpress.XtraGrid.Columns.GridColumn colC_XM;
        private DevExpress.XtraGrid.Columns.GridColumn colD_HL_START_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colD_HL_END_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colD_PLAN_KY_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colD_XM_START_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colD_XM_END_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colC_DFP_RZ;
        private DevExpress.XtraGrid.Columns.GridColumn colC_RZP_RZ;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}