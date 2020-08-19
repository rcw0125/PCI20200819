namespace XGCAP.UI.P.PQ
{
    partial class FrmPB_LGGTT
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.schedulerControl2 = new DevExpress.XtraScheduler.SchedulerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_from = new DevExpress.XtraEditors.DateEdit();
            this.lbl_id = new DevExpress.XtraEditors.LabelControl();
            this.btn_query = new DevExpress.XtraEditors.SimpleButton();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_from.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_from.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.Lime, "None", "&None");
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important");
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business");
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal");
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation");
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend");
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required");
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation");
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday");
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary");
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call");
            this.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))), "LS", "LS");
            this.schedulerStorage1.Appointments.Mappings.End = "D_P_END_TIME";
            this.schedulerStorage1.Appointments.Mappings.Location = "N_SLAB_WGT";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "C_CCM_ID";
            this.schedulerStorage1.Appointments.Mappings.Start = "D_P_START_TIME";
            this.schedulerStorage1.Appointments.Mappings.Subject = "C_STL_GRD";
            this.schedulerStorage1.Resources.Mappings.Caption = "C_STA_DESC";
            this.schedulerStorage1.Resources.Mappings.Id = "C_ID";
            // 
            // schedulerControl2
            // 
            this.schedulerControl2.DataStorage = this.schedulerStorage1;
            this.schedulerControl2.Location = new System.Drawing.Point(518, 121);
            this.schedulerControl2.Name = "schedulerControl2";
            this.schedulerControl2.Size = new System.Drawing.Size(8, 8);
            this.schedulerControl2.Start = new System.DateTime(2018, 10, 31, 0, 0, 0, 0);
            this.schedulerControl2.TabIndex = 1;
            this.schedulerControl2.Text = "schedulerControl2";
            this.schedulerControl2.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl2.Views.FullWeekView.Enabled = true;
            this.schedulerControl2.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl2.Views.WeekView.Enabled = false;
            this.schedulerControl2.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 60);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.dt_from);
            this.panelControl2.Controls.Add(this.lbl_id);
            this.panelControl2.Controls.Add(this.btn_query);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(796, 51);
            this.panelControl2.TabIndex = 52;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 18);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 205;
            this.labelControl1.Text = "排产日期";
            // 
            // dt_from
            // 
            this.dt_from.EditValue = null;
            this.dt_from.Location = new System.Drawing.Point(84, 15);
            this.dt_from.Margin = new System.Windows.Forms.Padding(4);
            this.dt_from.Name = "dt_from";
            this.dt_from.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_from.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_from.Size = new System.Drawing.Size(145, 24);
            this.dt_from.TabIndex = 204;
            // 
            // lbl_id
            // 
            this.lbl_id.Location = new System.Drawing.Point(479, 18);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 18);
            this.lbl_id.TabIndex = 194;
            // 
            // btn_query
            // 
            this.btn_query.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_query.Location = new System.Drawing.Point(251, 13);
            this.btn_query.Margin = new System.Windows.Forms.Padding(4);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(81, 29);
            this.btn_query.TabIndex = 193;
            this.btn_query.Text = "查询";
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.DataStorage = this.schedulerStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 60);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(800, 390);
            this.schedulerControl1.Start = new System.DateTime(2018, 10, 31, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 3;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler4);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler5);
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler6);
            // 
            // FrmPB_LGGTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.schedulerControl2);
            this.Name = "FrmPB_LGGTT";
            this.Text = "炼钢计划";
            this.Load += new System.EventHandler(this.FrmPB_LGGTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_from.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_from.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_from;
        private DevExpress.XtraEditors.LabelControl lbl_id;
        private DevExpress.XtraEditors.SimpleButton btn_query;
    }
}