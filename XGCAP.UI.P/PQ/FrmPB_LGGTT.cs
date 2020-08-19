using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DevExpress.XtraScheduler;

namespace XGCAP.UI.P.PQ
{
    public partial class FrmPB_LGGTT : Form
    {
        public FrmPB_LGGTT()
        {
            InitializeComponent();
        }
        Bll_TSP_PLAN_SMS bll_lcjh = new Bll_TSP_PLAN_SMS();//炉次计划
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        private void FrmPB_LGGTT_Load(object sender, EventArgs e)
        {
            this.dt_from.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
            InitGrantView(schedulerControl1);
            Query();
            schedulerControl1.Start = dt_from.DateTime;
        }
        private void Query()
        {
            DataTable dt = bll_TB_STA.GetListByGX("CC").Tables[0];
            this.schedulerStorage1.Resources.DataSource = dt;
            DataTable xqdt = bll_lcjh.GetJCJH("","","");
            this.schedulerStorage1.Appointments.DataSource = xqdt;
        }
        /// <summary>
        /// 甘特图初始化设置
        /// </summary>
        /// <param name="sc"></param>
        private void InitGrantView(DevExpress.XtraScheduler.SchedulerControl sc)
        {
            //设置资源
            sc.GroupType = SchedulerGroupType.Resource;

            //设置甘特图
            sc.ActiveViewType = SchedulerViewType.Gantt;

            //设置资源+-按钮不可见

            sc.ResourceNavigator.Visibility = ResourceNavigatorVisibility.Auto;

            //设置Resource 字体不旋转
            sc.OptionsView.ResourceHeaders.RotateCaption = false;
            sc.OptionsView.ResourceHeaders.Height = 60;
            sc.OptionsView.ShowOnlyResourceAppointments = true;


            //行为设置

            sc.OptionsBehavior.MouseWheelScrollAction = MouseWheelScrollAction.Auto;

            sc.OptionsBehavior.RecurrentAppointmentDeleteAction = RecurrentAppointmentAction.Cancel;
            sc.OptionsBehavior.RecurrentAppointmentEditAction = RecurrentAppointmentAction.Cancel;
            sc.OptionsBehavior.RemindersFormDefaultAction = RemindersFormDefaultAction.DismissAll;

            //自定义动作设置

            //禁止块冲突
            sc.OptionsCustomization.AllowAppointmentConflicts = AppointmentConflictsMode.Allowed;
            //不允许复制
            sc.OptionsCustomization.AllowAppointmentCopy = UsedAppointmentType.None;
            //不允许创建
            sc.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None;
            //不允许删除
            sc.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None;
            //不允许拖到
            sc.OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.None;
            //不允许不同资源间创建
            sc.OptionsCustomization.AllowAppointmentDragBetweenResources = UsedAppointmentType.None;
            //允许编辑
            //sc.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.All;
            //不允许多个选择
            sc.OptionsCustomization.AllowAppointmentMultiSelect = false;
            //不允许改变大小
            sc.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.None;
            //不允许依赖窗体弹出
            sc.OptionsCustomization.AllowDisplayAppointmentDependencyForm = AllowDisplayAppointmentDependencyForm.Never;
            //允许Appointment窗体弹出
            sc.OptionsCustomization.AllowDisplayAppointmentForm = AllowDisplayAppointmentForm.Never;
            //不允许编辑文字
            sc.OptionsCustomization.AllowInplaceEditor = UsedAppointmentType.None;

            //GrantView
            //sc.Views.GanttView.CellsAutoHeightOptions.Enabled = false;//设置单元格不自适应高度 

            //sc.Views.GanttView.CellsAutoHeightOptions.MinHeight = 40;//设置最小高度


            //设置Appointment 的高度不自适应
            //sc.Views.GanttView.AppointmentDisplayOptions.AppointmentAutoHeight = false;
            sc.Views.GanttView.AppointmentDisplayOptions.AppointmentHeight = 40;
            //sc.Views.GanttView.AppointmentDisplayOptions.AppointmentInterspacing = 1;
            sc.Views.GanttView.AppointmentDisplayOptions.ContinueArrowDisplayType = AppointmentContinueArrowDisplayType.Never;
            //不显示开始时间
            sc.Views.GanttView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never;
            //不显示结束时间
            sc.Views.GanttView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never;
            //不显示进度条
            sc.Views.GanttView.AppointmentDisplayOptions.PercentCompleteDisplayType = PercentCompleteDisplayType.None;
            //不显示恢复
            sc.Views.GanttView.AppointmentDisplayOptions.ShowRecurrence = false;
            //不显示提醒
            sc.Views.GanttView.AppointmentDisplayOptions.ShowReminder = false;
            sc.Views.GanttView.AppointmentDisplayOptions.SnapToCellsMode = AppointmentSnapToCellsMode.Never;
            //不显示状态
            sc.Views.GanttView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Never;
            //显示样式
            sc.Views.GanttView.AppointmentDisplayOptions.TimeDisplayType = AppointmentTimeDisplayType.Text;


            //显示颜色

            sc.Views.GanttView.Appearance.Dependency.ForeColor = Color.Red;

            sc.Views.GanttView.Appearance.SelectedDependency.ForeColor = Color.Blue;


            sc.Views.GanttView.Scales.Clear();//清空

            DevExpress.XtraScheduler.TimeScaleDay td = new TimeScaleDay();
            td.DisplayFormat = "yyyy-MM-dd";
            td.Enabled = true;


            DevExpress.XtraScheduler.TimeScaleHour tm = new TimeScaleHour();
            tm.Enabled = true;


            sc.Views.GanttView.Scales.Add(td);
            sc.Views.GanttView.Scales.Add(tm);
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            schedulerControl1.Start = dt_from.DateTime;
        }
    }
}
