
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

namespace XGCAP.UI.P.PR
{
    public partial class FrmPR_LG_GTT : Form
    {
        public FrmPR_LG_GTT()
        {
            InitializeComponent();
        }

        private Bll_TPC_PLAN_SMS bll_tpc_plan_sms = new Bll_TPC_PLAN_SMS();//炼钢排产计划

        private void FrmPR_LG_GTT_Load(object sender, EventArgs e)
        {


            //初始化甘特图
            InitGrantView(this.schedulerControl1);

            #region 重组连铸计划
            List<Task> tasks = new List<Task>();
            List<TaskDetails> taskDetails = new List<TaskDetails>();
            //获取炼钢计划
            var ds = bll_tpc_plan_sms.GetTaskPlan();
            var planDt = ds.Tables[0];
            var planDetailsDt = ds.Tables[1];
            var factDetailsDt = ds.Tables[2];
            if (planDt.Rows.Count > 0)
            {
                //连铸计划
                foreach (DataRow planRow in planDt.Rows)
                {
                    Task task = new Task();
                    task.ID = planRow["ID"].ToString();
                    task.Name = planRow["NAME"].ToString().Substring(0, 2) + "计划";
                    tasks.Add(task);

                    Task task1 = new Task();
                    task1.ID = planRow["ID"].ToString() + "_Fact";
                    task1.Name = planRow["NAME"].ToString().Substring(0, 2) + "实绩";
                    tasks.Add(task1);

                    //连铸小计划
                    DataRow[] detailRows = planDetailsDt.Select(" C_CCM_ID='" + task.ID + "' ");
                    foreach (var detailsRow in detailRows)
                    {
                        TaskDetails taskDetail = new TaskDetails();
                        taskDetail.ID = detailsRow["C_ID"].ToString();
                        taskDetail.Start = DateTime.Parse(detailsRow["D_P_START_TIME"].ToString());
                        taskDetail.End = DateTime.Parse(detailsRow["D_P_END_TIME"].ToString());
                        taskDetail.Subject = detailsRow["C_STL_GRD"].ToString();
                        taskDetail.Description = "1";
                        taskDetail.Label = "0";
                        taskDetail.ParentID = task.ID;
                        taskDetails.Add(taskDetail);
                    }

                    //连铸小计划
                    DataRow[] factRows = factDetailsDt.Select(" C_CCM_ID='" + task.ID + "' ");
                    foreach (var factRow in factRows)
                    {
                        TaskDetails taskDetail = new TaskDetails();
                        taskDetail.ID = factRow["C_ID"].ToString();
                        taskDetail.Start = DateTime.Parse(factRow["D_P_START_TIME"].ToString());
                        taskDetail.End = DateTime.Parse(factRow["D_P_END_TIME"].ToString());
                        taskDetail.Subject = factRow["C_STOVE_NO"].ToString() + "\r\n" + factRow["C_STL_GRD"].ToString();
                        taskDetail.Description = "2";
                        taskDetail.Label = "1";
                        taskDetail.ParentID = task1.ID;
                        taskDetails.Add(taskDetail);
                    }
                }
            }

            #endregion

            //任务属性映射
            var sourceMap = this.schedulerStorage1.Resources.Mappings;
            sourceMap.Caption = "Name";
            sourceMap.Id = "ID";
            //数据绑定
            this.schedulerStorage1.Resources.DataSource = tasks;


            /*日程属性映射*/
            var appointMentMap = this.schedulerStorage1.Appointments.Mappings;
            appointMentMap.ResourceId = "ParentID";/*资源ID*/
            appointMentMap.AppointmentId = "ID";/*任务ID*/
            appointMentMap.Start = "Start";
            appointMentMap.End = "End";
            appointMentMap.Description = "Description";
            appointMentMap.AllDay = "AllDay";
            appointMentMap.Label = "Label";
            appointMentMap.Subject = "Subject";
            appointMentMap.PercentComplete = "PercentComplete";
            /*数据绑定*/
            this.schedulerStorage1.Appointments.DataSource = taskDetails;


        }




        private void InitGrantView(DevExpress.XtraScheduler.SchedulerControl sc)
        {

            //设置资源
            sc.GroupType = SchedulerGroupType.Resource;

            //设置甘特图
            sc.ActiveViewType = SchedulerViewType.Gantt;

            //设置Resource 字体不旋转
            sc.OptionsView.ResourceHeaders.RotateCaption = false;
            sc.OptionsView.ResourceHeaders.Height = 60;
            sc.OptionsView.ShowOnlyResourceAppointments = true;

            sc.Start = DateTime.Now;

            sc.DataStorage.Appointments.Labels.Clear();
            var label1 = sc.DataStorage.Appointments.Labels.CreateNewLabel("1", "Label");
            label1.SetColor(Color.LightBlue);
            sc.DataStorage.Appointments.Labels.Add(label1);
            var label2 = sc.DataStorage.Appointments.Labels.CreateNewLabel("0", "Label");
            label2.SetColor(Color.Yellow);
            sc.DataStorage.Appointments.Labels.Add(label2);

            //设置资源+-按钮不可见
            sc.ResourceNavigator.Visibility = ResourceNavigatorVisibility.Never;

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
            sc.Views.GanttView.CellsAutoHeightOptions.Enabled = false;//设置单元格不自适应高度 

            sc.Views.GanttView.CellsAutoHeightOptions.MinHeight = 40;//设置最小高度

            //高度
            sc.Views.GanttView.AppointmentDisplayOptions.AppointmentHeight = 40;
            //设置Appointment 的高度不自适应
            sc.Views.GanttView.AppointmentDisplayOptions.AppointmentAutoHeight = false;
            sc.Views.GanttView.AppointmentDisplayOptions.AppointmentHeight = 40;
            sc.Views.GanttView.AppointmentDisplayOptions.AppointmentInterspacing = 1;
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



        }

        private void schedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            e.Menu.Items.Clear();
        }
    }
    

    public class Task
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }

    public class TaskDetails
    {
        public string ID { get; set; }
        public string ParentID { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public string Label { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

    }



}
