using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PQ
{
    public partial class FrmPQ_KPJHCX : Form
    {
        public FrmPQ_KPJHCX()
        {
            InitializeComponent();
        }
        Bll_TSP_PLAN_SMS bll = new Bll_TSP_PLAN_SMS();
        Bll_TB_STA bll_sta = new Bll_TB_STA();
        private List<Mod_TSP_PLAN_SMS> lst = null;
        CommonSub sub = new CommonSub();
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        /// <summary>
        /// 查询生产影响记录
        /// </summary>
        public void BindInfo()
        {
            WaitingFrom.ShowWait("");
            lst = bll.GetModelList(cbo_GW.EditValue.ToString(), txt_stove.Text.Trim(), txt_grd.Text, dt_st.DateTime, dt_et.DateTime);
            this.gc_GP.DataSource = lst;
            this.gv_GP.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_GP.OptionsSelection.MultiSelect = true;//允许多选
            gv_GP.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            gridColumn18.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_GP.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GP);
            WaitingFrom.CloseWait();
        }

        private void FrmPQ_KPJHCX_Load(object sender, EventArgs e)
        {
            sub.ImageComboBoxEditBindGWByGX("KP", cbo_GW);
            cbo_GW.Properties.Items.Add("全部", "", 0);
            cbo_GW.SelectedIndex = 0;
            sub.ImageComboBoxEditBindGWByGX("KP", cbo_KP);
            cbo_KP.SelectedIndex = 0;
            sub.ImageComboBoxEditBindGWByGX("KP", cbo_kp2);
            cbo_kp2.SelectedIndex = 0;
            dt_st.EditValue = DateTime.Now.AddYears(-2).ToShortDateString();
            dt_et.EditValue = DateTime.Now.AddDays(30).ToShortDateString();
            // dt_KSSJ.EditValue = DateTime.Now;
            BindInfo();
            InitDrop();
        }
        #region 浇次计划列表鼠标拖动方法
        /// <summary>
        /// 浇次计划 行托动方法
        /// </summary>
        /// <param name="lst">加载的数据</param>
        /// <param name="gvSource">gridview</param>
        private void InitDrop()
        {
            var dropPlanToReq = new GridViewDragDropHelper(
                this.gv_GP, gv_GP, (row1, row2) =>
                {
                    if (row1 == row2) return;
                    DateTime st = Convert.ToDateTime(dt_KSSJ.EditValue);
                    var plan1 = gv_GP.GetRow(row1) as Mod_TSP_PLAN_SMS;
                    if (row2 < lst.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gv_GP.RowCount)
                        {
                            row2 = gv_GP.RowCount - 1;
                        }
                        var plan2 = gv_GP.GetRow(row2) as Mod_TSP_PLAN_SMS;
                        if (plan2 == null)
                            return;
                        lst.Remove(plan1);
                        var left = lst.TakeWhile(x => x.N_KP_SORT < plan2.N_KP_SORT).ToList();
                        var right = lst.Where(x => left.Contains(x) == false).ToList();
                        lst.Clear();
                        lst.AddRange(left);
                        lst.Add(plan1);
                        lst.AddRange(right);
                    }
                    else
                    {
                        lst.Remove(plan1);
                        lst.Add(plan1);
                    }
                    for (int i = 0; i < lst.Count; i++)
                    {
                        lst[i].N_KP_SORT = i + 1;
                        if (i == 0)
                        {
                            lst[i].D_KP_START_TIME = st;
                            //if (lst[i].D_DFPHL_END_TIME != null)
                            //{
                            //    if (Convert.ToDateTime(lst[i].D_KP_START_TIME).AddHours(-2) < lst[i].D_DFPHL_END_TIME)
                            //    {
                            //        lst[i].D_KP_START_TIME = Convert.ToDateTime(lst[i].D_DFPHL_END_TIME).AddHours(2);
                            //    }
                            //}
                            //else
                            //{
                            //    if (Convert.ToDateTime(lst[i].D_KP_START_TIME).AddHours(-2) < lst[i].D_P_END_TIME)
                            //    {
                            //        lst[i].D_KP_START_TIME = Convert.ToDateTime(lst[i].D_P_END_TIME).AddHours(2);
                            //    }
                            //}

                            if (Convert.ToDateTime(lst[i].D_KP_START_TIME) < lst[i].D_KP_CAN_START_TIME)
                            {
                                lst[i].D_KP_START_TIME = Convert.ToDateTime(lst[i].D_KP_CAN_START_TIME);
                            }

                        }
                        else
                        {
                            DateTime time = Convert.ToDateTime(lst[i - 1].D_KP_END_TIME);
                            if (lst[i].N_KP_JRL_HOUR != lst[i - 1].N_KP_JRL_HOUR)
                            {
                                lst[i].D_KP_START_TIME = time.AddHours(Convert.ToDouble(lst[i].N_KP_JRL_HOUR));
                            }
                            else
                            {
                                lst[i].D_KP_START_TIME = time;
                            }

                            if (Convert.ToDateTime(lst[i].D_KP_START_TIME) < lst[i].D_KP_CAN_START_TIME)
                            {
                                lst[i].D_KP_START_TIME = Convert.ToDateTime(lst[i].D_KP_CAN_START_TIME);
                            }
                            //if (lst[i].D_DFPHL_END_TIME != null)
                            //{
                            //    if (Convert.ToDateTime(lst[i].D_KP_START_TIME).AddHours(-2) < lst[i].D_DFPHL_END_TIME)
                            //    {
                            //        lst[i].D_KP_START_TIME = Convert.ToDateTime(lst[i].D_DFPHL_END_TIME).AddHours(2);
                            //    }
                            //}
                            //else
                            //{
                            //    if (Convert.ToDateTime(lst[i].D_KP_START_TIME).AddHours(-2) < lst[i].D_P_END_TIME)
                            //    {
                            //        lst[i].D_KP_START_TIME = Convert.ToDateTime(lst[i].D_P_END_TIME).AddHours(2);
                            //    }
                            //}
                        }
                        decimal sl = Convert.ToDecimal(lst[i].N_SLAB_WGT) / 114;
                        lst[i].D_KP_END_TIME = Convert.ToDateTime(lst[i].D_KP_START_TIME).AddHours(Convert.ToDouble(sl));
                    }
                    gv_GP.RefreshData();
                    gv_GP.ClearSelection();
                });

            dropPlanToReq.AllowDrop = true;


        }
        #endregion

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll.GetKPSTA().Tables[0];
                foreach (DataRow item in dt.Rows)
                {
                    Mod_TB_STA sta = bll_sta.GetModel(item["C_KP_ID"].ToString());
                    List<Mod_TSP_PLAN_SMS> list = lst.Where(x => x.C_KP_ID == item["C_KP_ID"].ToString()).ToList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        Mod_TSP_PLAN_SMS mod = bll.GetModel(list[i].C_ID);
                        mod.N_KP_SORT = i + 1;
                        mod.D_KP_START_TIME = list[i].D_KP_START_TIME;
                        mod.D_KP_CAN_START_TIME = list[i].D_KP_CAN_START_TIME;
                        if (mod.D_KP_START_TIME == null)
                        {
                            return;
                        }
                        if (mod.D_KP_CAN_START_TIME > Convert.ToDateTime(mod.D_KP_START_TIME))
                        {
                            MessageBox.Show(sta.C_STA_DESC + ",序号(" + list[i].N_KP_SORT + ")" + "开坯开始时间不能在可开坯时间之前");
                            return;
                        }
                        if (mod.C_DFP_HL == "N")
                        {
                            if (mod.D_P_END_TIME > Convert.ToDateTime(mod.D_KP_START_TIME).AddHours(-2))
                            {
                                MessageBox.Show(sta.C_STA_DESC + ",序号(" + list[i].N_KP_SORT + ")" + "开坯开始时间不能在连铸结束时间后2个小时之内");
                                return;
                            }
                        }
                        else
                        {
                            if (mod.D_DFPHL_END_TIME > Convert.ToDateTime(mod.D_KP_START_TIME).AddHours(-2))
                            {
                                MessageBox.Show(sta.C_STA_DESC + ",序号(" + list[i].N_KP_SORT + ")" + "开坯时间不能在大方坯缓冷结束时间后2个小时之内");
                                return;
                            }
                        }
                        decimal sl = Convert.ToDecimal(mod.N_SLAB_WGT) / 114;
                        mod.D_KP_END_TIME = list[i].D_KP_END_TIME;
                        //mod.D_KP_END_TIME = Convert.ToDateTime(mod.D_KP_START_TIME).AddHours(Convert.ToDouble(sl));
                        //time = Convert.ToDateTime(mod.D_KP_END_TIME);
                        if (mod.C_HL == "Y")
                        {
                            int N_HL_TIME = (int)mod.N_HL_TIME;
                            mod.D_HL_START_TIME = Convert.ToDateTime(mod.D_KP_END_TIME).AddHours(2);
                            mod.D_HL_END_TIME = Convert.ToDateTime(mod.D_HL_START_TIME).AddHours(N_HL_TIME);
                            if (mod.C_XM == "Y")
                            {
                                mod.D_XM_CAN_START_TIME = Convert.ToDateTime(mod.D_HL_END_TIME).AddHours(2);
                            }
                        }
                        bll.Update(mod);
                    }
                }
                string result = bll.P_SLAB_CAN_USETIMEG();
                WaitingFrom.CloseWait();
                MessageBox.Show("保存成功");
                BindInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btn_SX_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            #region 版本1
            ////List<Mod_TSP_PLAN_SMS> 
            ////分开坯线进行排序
            //if (lst.Count>0)
            //{
            //    int wfcou = lst.Where(a => a.C_KP_ID.Trim() == "").ToList().Count;
            //    if (wfcou>0)
            //    {
            //        MessageBox.Show("有"+wfcou.ToString()+"条开坯计划未分连铸机,\r\n请分配连铸机后再进行排序！");
            //        return;
            //    }
            //    //获取订单开坯机
            //    var groupList = lst
            //       .GroupBy(x => new { x.C_KP_ID })
            //       .Select(group => new
            //       {
            //           Keys = group.Key,
            //           KP_ID = group.Key.C_KP_ID
            //       }).ToList();
            //    for (int i = 0; i < groupList.Count; i++)
            //    {
            //        string c_kp_id = groupList[i].KP_ID;//开坯机主键
            //        //按开坯机进行排序
            //        List<Mod_TSP_PLAN_SMS> lstpx = lst.Where(a => a.C_KP_ID == c_kp_id).ToList();
            //        //获取开坯计划排序开始时间
            //        // SELECT M.C_STL_GRD, M.N_KP_JRL_HOUR, M.D_KP_END_TIME_SJ FROM(SELECT T.C_ID, T.D_KP_START_TIME_SJ, T.D_KP_END_TIME_SJ, T.N_KP_JRL_HOUR, T.C_STL_GRD, T.C_STD_CODE, T.D_P_START_TIME, T.D_P_END_TIME, T.N_ORDER_WGT, T.N_SORT FROM TSP_PLAN_SMS T WHERE T.D_KP_END_TIME_SJ IS NOT NULL AND T.C_KP = 'Y' AND T.N_STATUS = 1 AND T.C_KP_ID = CUR.C_KP_ID ORDER BY T.D_KP_END_TIME_SJ DESC) M WHERE ROWNUM = 1;
            //        DataTable dt = bll.GetNewKPPlan(c_kp_id);
            //        DateTime d_start_time = Convert.ToDateTime(this.dt_KSSJ.Text);//计划排序开始时间
            //        int jrhour = 4;
            //        if (dt.Rows.Count>0)
            //        {
            //            jrhour = Convert.ToInt32(dt.Rows[0]["N_KP_JRL_HOUR"].ToString());
            //        }
            //        //优先排产加热炉时间为6小时的热坯计划，没有6小时的排4小时的计划（热坯计划为大方坯不缓冷的、连铸结束时间小于10小时的计划）
            //        //加热炉时间为6小时的计划原则上集中生产 有订单的  N_ORDER_WGT>0
            //    }
            //}
            string result = bll.P_KP_PLAN_SORTING();
            #endregion
            //#region 版本2
            //bll.UPsortstatus();
            //int sort = 0;
            //DateTime dateTime = dt_KSSJ.DateTime;
            //DataTable dt = bll.GetQuery(cbo_GW.EditValue.ToString(), dateTime, 2, 0, 2).Tables[0];
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataTable dt1 = bll.GetQuery(cbo_GW.EditValue.ToString(), dateTime, 1, 1, 6).Tables[0];//1有订单6小时热轧坯
            //    sort++;
            //    if (dt1.Rows.Count > 0)
            //    {
            //        dateTime = UpSort(sort, dt1, dateTime);
            //        continue;
            //    }
            //    DataTable dt2 = bll.GetQuery(cbo_GW.EditValue.ToString(), dateTime, 0, 1, 6).Tables[0];//2无订单6小时热轧坯
            //    if (dt2.Rows.Count > 0)
            //    {
            //        dateTime = UpSort(sort, dt2, dateTime);
            //        continue;
            //    }
            //    int jrhour = 4;
            //    if (sort==1)
            //    {
            //        DataTable jrdt = bll.GetNewKPPlan(cbo_GW.EditValue.ToString());
            //        if (jrdt.Rows.Count > 0)
            //        {
            //            jrhour = Convert.ToInt32(jrdt.Rows[0]["N_KP_JRL_HOUR"].ToString());
            //        }
            //    }
            //    else
            //    {
            //        DataTable jrdt=  bll.GetLastsort(cbo_GW.EditValue.ToString(),sort-1);
            //        if (jrdt.Rows.Count > 0)
            //        {
            //            jrhour = Convert.ToInt32(jrdt.Rows[0]["N_KP_JRL_HOUR"].ToString());
            //        }
            //    }
            //    if (jrhour == 6)
            //    {
            //        DataTable dt3 = bll.GetQuery(cbo_GW.EditValue.ToString(), dateTime, 1, 0, 6).Tables[0];//3有订单6小时坯
            //        if (dt3.Rows.Count > 0)
            //        {
            //            dateTime = UpSort(sort, dt3, dateTime);
            //            continue;
            //        }
            //        DataTable dt4 = bll.GetQuery(cbo_GW.EditValue.ToString(), dateTime, 0, 0, 6).Tables[0];//4无订单6小时坯
            //        if (dt4.Rows.Count > 0)
            //        {
            //            dateTime = UpSort(sort, dt4, dateTime);
            //            continue;
            //        }
            //    }
            //    DataTable dt5 = bll.GetQuery(cbo_GW.EditValue.ToString(), dateTime, 1, 1, 4).Tables[0];//5有订单4小时热轧坯
            //    if (dt5.Rows.Count > 0)
            //    {
            //        dateTime = UpSort(sort, dt5, dateTime);
            //        continue;
            //    }
            //    DataTable dt7 = bll.GetQuery(cbo_GW.EditValue.ToString(), dateTime, 1, 0, 4).Tables[0];//7有订单4小时坯
            //    if (dt7.Rows.Count > 0)
            //    {
            //        dateTime = UpSort(sort, dt7, dateTime);
            //        continue;
            //    }
            //    DataTable dt6 = bll.GetQuery(cbo_GW.EditValue.ToString(), dateTime, 0, 1, 4).Tables[0];//6无订单4小时热轧坯
            //    if (dt6.Rows.Count > 0)
            //    {
            //        dateTime = UpSort(sort, dt6, dateTime);
            //        continue;
            //    }
            //    DataTable dt8 = bll.GetQuery(cbo_GW.EditValue.ToString(), dateTime, 0, 0, 4).Tables[0];//8无订单4小时坯
            //    if (dt8.Rows.Count > 0)
            //    {
            //        dateTime = UpSort(sort, dt8, dateTime);
            //        continue;
            //    }
            //    DataTable dt9 = bll.GetQuery(cbo_GW.EditValue.ToString(), dateTime, 1, 0, 6).Tables[0];//3有订单6小时坯
            //    if (dt9.Rows.Count > 0)
            //    {
            //        dateTime = UpSort(sort, dt9, dateTime);
            //        continue;
            //    }
            //    DataTable dt10 = bll.GetQuery(cbo_GW.EditValue.ToString(), dateTime, 0, 0, 6).Tables[0];//4无订单6小时坯
            //    if (dt10.Rows.Count > 0)
            //    {
            //        dateTime = UpSort(sort, dt10, dateTime);
            //        continue;
            //    }
            //}
            //#endregion
            WaitingFrom.CloseWait();
            MessageBox.Show("排序成功!");
            BindInfo();
        }

        private DateTime UpSort(int sort, DataTable dt, DateTime date)
        {
            Mod_TSP_PLAN_SMS mod = bll.GetModel(dt.Rows[0]["C_ID"].ToString());
            mod.N_KP_SORT = sort;
            mod.N_SFKPPC = 1;
            mod.D_KP_START_TIME = date;
            if (mod.D_KP_CAN_START_TIME > mod.D_KP_START_TIME)
            {
                mod.D_KP_START_TIME = mod.D_KP_CAN_START_TIME;
            }
            decimal sl = Convert.ToDecimal(mod.N_SLAB_WGT) / 114;
            mod.D_KP_END_TIME = Convert.ToDateTime(mod.D_KP_START_TIME).AddHours(Convert.ToDouble(sl));
            bll.Update(mod);
            return Convert.ToDateTime(mod.D_KP_END_TIME);
        }

        private void btn_QR_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            int[] row = gv_GP.GetSelectedRows();
            foreach (var item in row)
            {
                string id = gv_GP.GetRowCellValue(item, "C_ID").ToString();
                Mod_TSP_PLAN_SMS mod = bll.GetModel(id);
                mod.C_KP_ID = cbo_KP.EditValue.ToString();
                bll.Update(mod);
            }
            MessageBox.Show("确认成功");
            WaitingFrom.CloseWait();
            BindInfo();
        }

        private void btn_SCDFPHL_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            //DataTable dt = bll.GetListByKP("").Tables[0];
            //DateTime st = dt_KSSJ.DateTime;
            //DateTime time = dt_KSSJ.DateTime;
            //foreach (DataRow item in dt.Rows)
            //{
            //    Mod_TSP_PLAN_SMS mod = bll.GetModel(item["C_ID"].ToString());
            //    if (mod.C_DFP_HL == "Y")
            //    {
            //        mod.D_DFPHL_START_TIME = Convert.ToDateTime(mod.D_P_END_TIME).AddHours(2);
            //        mod.D_DFPHL_END_TIME = Convert.ToDateTime(mod.D_DFPHL_START_TIME).AddHours(Convert.ToDouble(mod.N_DFP_HL_TIME));
            //        bll.Update(mod);
            //    }
            //}
            string result = bll.P_INI_SMS();
            WaitingFrom.CloseWait();
            BindInfo();
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            if (txt_HH.Text == "" || txt_HH.Text.Trim() == "0")
            {
                MessageBox.Show("行号不能为空或为0");
                return;
            }
            int[] row = gv_GP.GetSelectedRows();
            DateTime st = Convert.ToDateTime(lst[0].D_XM_START_TIME);
            int bj1 = 0;
            int bj2 = 0;
            foreach (var item in row.Reverse())
            {
                int hang = item;
                if (item >= Convert.ToInt32(txt_HH.Text) - 1)
                {
                    if (bj1 != 0)
                    {
                        hang = hang + bj1;
                    }
                    bj1++;
                }
                else
                {
                    bj2++;
                }


                var plan1 = gv_GP.GetRow(hang) as Mod_TSP_PLAN_SMS;
                if (item < lst.Count)
                {
                    //hang = hang < 0 ? 0 : hang;
                    if (hang >= gv_GP.RowCount)
                    {
                        hang = gv_GP.RowCount - 1;
                    }
                    var plan2 = gv_GP.GetRow(Convert.ToInt32(txt_HH.Text) - bj2) as Mod_TSP_PLAN_SMS;
                    if (plan2 == null)
                        return;
                    lst.Remove(plan1);
                    var left = lst.TakeWhile(x => x.N_KP_SORT < plan2.N_KP_SORT).ToList();
                    var right = lst.Where(x => left.Contains(x) == false).ToList();
                    if (bj2 == 0)
                    {
                        plan2 = gv_GP.GetRow(Convert.ToInt32(txt_HH.Text) - 1) as Mod_TSP_PLAN_SMS;
                        left = lst.TakeWhile(x => x.N_KP_SORT < plan2.N_KP_SORT).ToList();
                        right = lst.Where(x => left.Contains(x) == false).ToList();
                    }
                    else
                    {
                        left = lst.TakeWhile(x => x.N_KP_SORT <= plan2.N_KP_SORT).ToList();
                        right = lst.Where(x => left.Contains(x) == false).ToList();
                    }
                    lst.Clear();
                    lst.AddRange(left);
                    lst.Add(plan1);
                    lst.AddRange(right);
                }
                else
                {
                    lst.Remove(plan1);
                    lst.Add(plan1);
                }
                for (int i = 0; i < lst.Count; i++)
                {
                    lst[i].N_KP_SORT = i + 1;
                    if (i == 0)
                    {
                        lst[i].D_KP_START_TIME = st;
                        if (Convert.ToDateTime(lst[i].D_KP_START_TIME) < lst[i].D_KP_CAN_START_TIME)
                        {
                            lst[i].D_KP_START_TIME = Convert.ToDateTime(lst[i].D_KP_CAN_START_TIME);
                        }
                    }
                    else
                    {
                        DateTime time = Convert.ToDateTime(lst[i - 1].D_KP_END_TIME);
                        if (lst[i].N_KP_JRL_HOUR != lst[i - 1].N_KP_JRL_HOUR)
                        {
                            lst[i].D_KP_START_TIME = time.AddHours(Convert.ToDouble(lst[i].N_KP_JRL_HOUR));
                        }
                        else
                        {
                            lst[i].D_KP_START_TIME = time;
                        }
                        if (Convert.ToDateTime(lst[i].D_KP_START_TIME) < lst[i].D_KP_CAN_START_TIME)
                        {
                            lst[i].D_KP_START_TIME = Convert.ToDateTime(lst[i].D_KP_CAN_START_TIME);
                        }
                    }
                    decimal sl = Convert.ToDecimal(lst[i].N_SLAB_WGT) / 114;
                    lst[i].D_KP_END_TIME = Convert.ToDateTime(lst[i].D_KP_START_TIME).AddHours(Convert.ToDouble(sl));
                }
            }
            gv_GP.RefreshData();
            gv_GP.ClearSelection();
        }

        private void gv_GP_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                int hand = e.RowHandle;
                if (hand < 0) return;
                if (gv_GP.GetRowCellValue(hand, "N_ORDER_WGT").ToString() == "0")
                {
                    e.Appearance.ForeColor = Color.Red;// 改变行字体颜色
                                                       //e.Appearance.BackColor2 = Color.Blue;// 添加渐变颜色
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cbo_GW_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SELECT M.C_STL_GRD, M.N_KP_JRL_HOUR, M.D_KP_END_TIME_SJ FROM(SELECT T.C_ID, T.D_KP_START_TIME_SJ, T.D_KP_END_TIME_SJ, T.N_KP_JRL_HOUR, T.C_STL_GRD, T.C_STD_CODE, T.D_P_START_TIME, T.D_P_END_TIME, T.N_ORDER_WGT, T.N_SORT FROM TSP_PLAN_SMS T WHERE T.D_KP_END_TIME_SJ IS NOT NULL AND T.C_KP = 'Y' AND T.N_STATUS = 1 AND T.C_KP_ID = CUR.C_KP_ID ORDER BY T.D_KP_END_TIME_SJ DESC) M WHERE ROWNUM = 1;
            DataTable dt = bll.GetNewKPPlan(cbo_GW.EditValue.ToString());
            if (dt.Rows.Count > 0)
            {
                this.dt_KSSJ.Text = dt.Rows[0]["D_KP_END_TIME_SJ"].ToString();
            }
            else
            {
                this.dt_KSSJ.Text = System.DateTime.Now.ToString();
            }
        }
    }
}
