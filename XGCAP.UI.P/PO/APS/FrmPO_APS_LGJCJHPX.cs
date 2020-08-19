using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using XGCAP.UI.P.PO.ViewModel;
using System.Reflection;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;

namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APS_LGJCJHPX : Form
    {
        public FrmPO_APS_LGJCJHPX()
        {
            InitializeComponent();
        }
        #region 实例化功能设计对象 
        private static Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();//浇次计划
        private static Bll_TSP_PLAN_SMS bll_plan_sms = new Bll_TSP_PLAN_SMS();//炉次计划
        private Bll_TPP_LG_PLAN bllTppLgPlan = new Bll_TPP_LG_PLAN();
        private Bll_TPA_HL_ACT bll_hl_act = new Bll_TPA_HL_ACT();
        private Bll_TRP_PLAN_ROLL bll_trp_pan = new Bll_TRP_PLAN_ROLL();//生产计划
        #endregion

        #region 加载默认计划列表 
        private List<Mod_TSP_CAST_PLAN> jc_cast_plan = new List<Mod_TSP_CAST_PLAN>();//浇次计划 
        private List<Mod_TSP_PLAN_SMS> sms_plan = new List<Mod_TSP_PLAN_SMS>();//炉次计划

        private int jcRowHand = 0;//浇次表焦点行

        #region 查询浇次计划
        /// <summary>
        /// 查询浇次计划方法
        /// </summary>
        /// <param name="strCCMID">连铸机</param>
        private void BindLsbGrid(string strCCMID, int n_status, string dt)
        {
            jc_cast_plan = bll_cast_plan.GetModelList(strCCMID, n_status, dt).OrderBy(a => a.N_SORT).ToList();
            if (jc_cast_plan.Count > 0)
            {
                jcminsort = (int)jc_cast_plan.Min(a => a.N_SORT);
                this.lbl_minjcsort.Text = jcminsort.ToString();
                try
                {
                    this.lbl_minlcsort.Text = ((int)bll_plan_sms.GetModelListByJcID(jc_cast_plan[0].C_ID).Min(a => a.N_SORT)).ToString();//报错
                }
                catch (Exception)
                {

                    this.lbl_minlcsort.Text = "1";//报错
                }
                try
                {
                    try
                    {
                        dt_jc_start_time = Convert.ToDateTime(bll_plan_sms.GetStartTime(strCCMID).Rows[0]["D_P_END_TIME"].ToString());
                        if (dt_jc_start_time < System.DateTime.Now.AddMinutes(20))
                        {
                            dt_jc_start_time = System.DateTime.Now.AddMinutes(20);

                        }
                    }
                    catch (Exception)
                    {
                        dt_jc_start_time = System.DateTime.Now.AddMinutes(20);


                    }
                    if (chk_sfzd.Checked == false)
                    {
                        this.dateEdit1.Text = dt_jc_start_time.ToString();
                    }

                    this.gridControl6.DataSource = jc_cast_plan;
                    this.gridView6.OptionsView.ColumnAutoWidth = false;
                    SetGridViewRowNum.SetRowNum(gridView6);
                    //this.gridView6.RefreshData();
                    this.gridView6.BestFitColumns();
                    if (jcRowHand > gridView6.RowCount)
                    {
                        jcRowHand = gridView6.RowCount;
                    }
                    this.gridView6.FocusedRowHandle = jcRowHand;
                    // this.gridView6.RowCellStyle += GridView6_RowCellStyle;
                    //this.gridView6.RowStyle += GridView6_RowStyle;
                    this.gridView6.CustomDrawCell += GridView6_CustomDrawCell;


                }
                catch (Exception)
                {


                }

            }
            else
            {
                this.gridControl6.DataSource = null;
                this.gridView6.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gridView6);
                this.gridView6.BestFitColumns();
            }


        }

        private void GridView6_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {


                int hand = e.RowHandle;
                if (hand < 0) return;
                //string aa = e.Column.FieldName;
                //string dd= e.CellValue.ToString();
                if (e.Column.FieldName == "C_RH_SFJS" && Convert.ToDecimal(e.CellValue.ToString().Trim() == "" ? "0" : e.CellValue.ToString()) > 130)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.Yellow;
                }
                string ss = gridView6.GetRowCellValue(hand, "C_BY3").ToString();
                if (e.Column.FieldName == "C_BY3" && gridView6.GetRowCellValue(hand, "C_BY3").ToString() == "False")
                {
                    e.Appearance.BackColor = Color.OrangeRed;
                    e.Appearance.BackColor2 = Color.Orange;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GridView6_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {


                int hand = e.RowHandle;
                if (hand < 0) return;
                if (Convert.ToDecimal(gridView6.GetRowCellValue(hand, "C_RH_SFJS").ToString()) > 130)
                {
                    e.Appearance.ForeColor = Color.Red;
                }
                string ss = gridView6.GetRowCellValue(hand, "C_BY3").ToString();
                if (gridView6.GetRowCellValue(hand, "C_BY3").ToString() == "False")
                {
                    e.Appearance.BackColor = Color.LightSkyBlue;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GridView6_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {


                int hand = e.RowHandle;
                if (hand < 0) return;
                if (Convert.ToDecimal(gridView6.GetRowCellValue(hand, "C_RH_SFJS").ToString()) > 130)
                {
                    e.Appearance.ForeColor = Color.Red;
                }
                string ss = gridView6.GetRowCellValue(hand, "C_BY3").ToString();
                if (gridView6.GetRowCellValue(hand, "C_BY3").ToString() == "False")
                {
                    e.Appearance.BackColor = Color.Yellow;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        #endregion

        #region 查询炉次计划
        /// <summary>
        /// 查询炉次计划方法
        /// </summary>
        /// <param name="strCFK">浇次表主键</param>
        private void BindLcLsbGrid(string strCFK)
        {
            if (strCFK == "")
            {
                this.gridControl7.DataSource = null;
            }
            else
            {
                sms_plan = bll_plan_sms.GetModelListByJcID(strCFK).OrderBy(a => a.N_SORT).ToList();
                this.gridControl7.DataSource = sms_plan;
            }
            this.gridView7.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView7);
            this.gridView7.UpdateSummary();
            this.gridView7.RefreshData();
            this.gridView7.BestFitColumns();
            this.gridView7.RowStyle += GridView7_RowStyle;

        }

        private void GridView7_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                int hand = e.RowHandle;
                if (hand < 0) return;
                if (gridView7.GetRowCellValue(hand, "C_STATE").ToString() == "1")
                {
                    e.Appearance.ForeColor = Color.Red;// 改变行字体颜色
                }
                if (gridView7.GetRowCellValue(hand, "C_STATE").ToString() == "2")
                {
                    e.Appearance.ForeColor = Color.Blue;// 改变行字体颜色
                }

                if (gridView7.GetRowCellValue(hand, "C_CTRL_NO").ToString() != "")
                {
                    e.Appearance.BackColor = Color.Yellow;// 改变行字体颜色
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region 初始化浇次计划
        /*
         初始化：钢种分类、
         品名、
         整浇次的重量、
         机时产量、
         连铸生产所需时间
         */
        /// <summary>
        /// 初始化待排产的浇次计划列表
        /// </summary>
        /// <param name="lst_jc_cast_plan">浇次计划</param> 
        /// <returns>初始化后的浇次计划列表</returns>
        public List<Mod_TSP_CAST_PLAN> Initialize_List(List<Mod_TSP_CAST_PLAN> lst_jc_cast_plan)
        {
            #region 浇次计划初始化
            for (int i = 0; i < lst_jc_cast_plan.Count; i++)
            {
                lst_jc_cast_plan[i].N_STATUS = 0;//浇次计划未排产0，系统已排产1，人为排产2
                lst_jc_cast_plan[i].N_JSCN = 114;
                lst_jc_cast_plan[i].N_ZJCLZL = lst_jc_cast_plan[i].N_MLZL * lst_jc_cast_plan[i].N_ZJCLS;
                lst_jc_cast_plan[i].N_CCM_TIME = Math.Round(Convert.ToDecimal(lst_jc_cast_plan[i].N_MLZL * lst_jc_cast_plan[i].N_ZJCLS / lst_jc_cast_plan[i].N_JSCN), 2);//连铸生产需求时间

                List<Mod_TSP_PLAN_SMS> lst_lc_plan_sms = bll_plan_sms.GetModelListByJcID(lst_jc_cast_plan[i].C_ID);
                //根据炉次计划分出浇次计划的钢种类型
                try
                {
                    #region 区分浇次计划的钢种类型
                    if (lst_lc_plan_sms.Where(a => a.C_STL_GRD_TYPE.Contains("含硼钛废钢") || a.C_STL_GRD_TYPE.Contains("硅铝镇静钢")).ToList().Count > 0)
                    {
                        lst_jc_cast_plan[i].C_STL_GRD_TYPE = "硅铝镇静钢";
                        if (lst_lc_plan_sms.Where(a => a.C_PROD_NAME.Contains("轴承钢")).ToList().Count > 0)
                        {
                            lst_jc_cast_plan[i].C_PROD_NAME = "轴承钢";
                        }
                        else if (lst_lc_plan_sms.Where(a => a.C_PROD_NAME.Contains("弹簧钢")).ToList().Count > 0)
                        {
                            lst_jc_cast_plan[i].C_PROD_NAME = "弹簧钢";
                        }
                        else
                        {
                            lst_jc_cast_plan[i].C_PROD_NAME = lst_lc_plan_sms.ToList()[0].C_PROD_NAME;
                        }


                    }
                    if (lst_lc_plan_sms.Where(a => a.C_STL_GRD_TYPE.Contains("半沸腾钢") || a.C_STL_GRD_TYPE.Contains("超低碳钢")).ToList().Count > 0)
                    {
                        lst_jc_cast_plan[i].C_STL_GRD_TYPE = "铝镇静钢";
                        lst_jc_cast_plan[i].C_PROD_NAME = "超低碳钢";
                    }
                    else
                    {
                        lst_jc_cast_plan[i].C_STL_GRD_TYPE = lst_lc_plan_sms.ToList()[0].C_STL_GRD_TYPE;
                        if (lst_lc_plan_sms.Where(a => a.C_PROD_NAME.Contains("轴承钢")).ToList().Count > 0)
                        {
                            lst_jc_cast_plan[i].C_PROD_NAME = "轴承钢";
                        }
                        else if (lst_lc_plan_sms.Where(a => a.C_PROD_NAME.Contains("弹簧钢")).ToList().Count > 0)
                        {
                            lst_jc_cast_plan[i].C_PROD_NAME = "弹簧钢";
                        }
                        else
                        {
                            lst_jc_cast_plan[i].C_PROD_NAME = lst_lc_plan_sms.ToList()[0].C_PROD_NAME;
                        }
                    }
                    #endregion
                }
                catch (Exception ex)
                {

                }


            }
            return lst_jc_cast_plan;
            #endregion
        }
        #endregion

        #region 将浇次计划按连铸进行排序，并初始化计划时间
        /// <summary>
        /// 将浇次计划进行自动排序，并获取排序后的计划
        /// </summary>
        /// <param name="c_ccm">连铸机主键</param>
        /// <param name="dt_start">连铸浇次计划开始时间</param>
        /// <param name="lst">需要排序的浇次计划</param>
        /// <returns>排序后的浇次计划</returns>
        public List<Mod_TSP_CAST_PLAN> Sort_JC_plan(string c_ccm, DateTime dt_start, List<Mod_TSP_CAST_PLAN> plan_lst)
        {
            int cousort = 0;
            bll_hl_act.RstHLACT();//初始化缓冷实绩
            bll_hl_act.CleanGXPlan();//初始化工序实绩
            var lst1 = plan_lst.Where(a => a.C_CCM_ID == c_ccm && a.N_STATUS == this.rbtn_status.SelectedIndex + 1).OrderBy(a => a.N_SORT).ToList();//获取待排序的浇次计划
            int jc_min_sort = Convert.ToInt32(this.lbl_minjcsort.Text);
            int lcsort = 0;
            DateTime d_start_time = dt_start;//指定开始时间
            for (int o = 0; o < lst1.Count; o++)
            {
                if (o == 0)
                {
                    lcsort = Convert.ToInt32(bll_plan_sms.GetModelListByJcID(lst1[o].C_ID).Min(a => a.N_SORT));
                }
                lst1[o].N_SORT = jc_min_sort;
                lst1[o].D_P_START_TIME = d_start_time;
                //同时更新炉次计划的开始结束时间和序号
                lst1[o].D_P_END_TIME = UpdateLcPlan(lst1[o].C_ID, Convert.ToDateTime(lst1[o].D_P_START_TIME), Convert.ToDouble(lst1[o].N_PRODUCE_TIME), jc_min_sort, lcsort);
                jc_min_sort = jc_min_sort + 1;
                d_start_time = Convert.ToDateTime(lst1[o].D_P_END_TIME).AddHours(Convert.ToDouble(lst1[o].N_PRODUCE_TIME));

                lcsort = lcsort + (int)lst1[o].N_ZJCLS;

                int RHLS = 0;
                int dhl = 0;
                int tl = 0;
                int hl = 0;
                int xm = 0;
                string remark = "";
                List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(lst1[o].C_ID);
                var lst = lstlc.GroupBy(a => new { a.C_STL_GRD, a.C_STD_CODE }).Select(a => new { num = a.Count(), a.First().C_STL_GRD, a.First().C_STD_CODE, a.First().C_RH, a.First().C_DFP_HL, a.First().C_HL, a.First().C_TL, a.First().C_XM }).ToList();
                if (lst.Count > 0)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        remark = remark + lst[i].C_STL_GRD + "~" + lst[i].C_STD_CODE + "~" + lst[i].num.ToString() + "\n";
                        //if (lst[i].C_RH == "Y")
                        //{
                        //    if (i+1<lst.Count)
                        //    {
                        //        RHLS = i + 1 + 1;//浇次RH炉数为最后一炉RH计划+1炉
                        //    }
                        //    else
                        //    {
                        //        RHLS = lst.Count;
                        //    }

                        //}
                        if (lst[i].C_DFP_HL == "Y")
                        {
                            dhl = dhl + lst[i].num;
                        }
                        if (lst[i].C_TL == "Y")
                        {
                            tl = tl + lst[i].num;
                        }
                        if (lst[i].C_HL == "Y")
                        {
                            hl = hl + lst[i].num;
                        }
                        if (lst[i].C_XM == "Y")
                        {
                            xm = xm + lst[i].num;
                        }

                    }
                }
                lst1[o].N_ZJCLS = lstlc.Count;
                lst1[o].N_ZJCLZL = lstlc.Count * lst1[o].N_MLZL;
                lst1[o].C_REMARK = remark;
                //lst1[o].N_RH = RHLS;
                lst1[o].N_DHL = dhl;
                lst1[o].N_HL = hl;
                lst1[o].N_TL = tl;
                if (tl > 0)
                {
                    lst1[o].C_TL = "Y";
                }
                else
                {
                    lst1[o].C_TL = "N";
                }
                lst1[o].N_XM = xm;


            }

            return plan_lst;
        }
        #endregion

        #region 根据浇次计划更新炉次计划

        /// <summary>
        /// 根据浇次计划更新炉次计划的生产时间和顺序
        /// </summary>
        /// <param name="c_jc_id">浇次计划主键</param>
        /// <param name="dt_strat_time">浇次计划的开始时间</param>
        /// <param name="N_tjsj">停机时间</param>
        /// <param name="n_jc_sort">浇次序号</param>
        /// <param name="n_lc_min_sort">该浇次炉次计划起始序号</param>
        /// <returns>返回本浇次最后一炉计划结束时间</returns>
        public DateTime UpdateLcPlan(string c_jc_id, DateTime dt_strat_time, double N_tjsj, int n_jc_sort, int n_lc_min_sort)
        {
            DateTime dt = dt_strat_time;
            DateTime dt_end_time = dt_strat_time;//浇次结束时间
            List<Mod_TSP_PLAN_SMS> lst = new List<Mod_TSP_PLAN_SMS>();
            lst = bll_plan_sms.GetModelListByJcID(c_jc_id).OrderBy(a => a.N_SORT).ToList();
            Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(c_jc_id);
            if (lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    lst[i].N_JC_SORT = modjc.N_SORT;
                    lst[i].C_CCM_ID = modjc.C_CCM_ID;
                    lst[i].C_CCM_DESC = modjc.C_CCM_CODE;
                    if (N_tjsj > 0 && i == lst.Count - 1)
                    {
                        lst[i].N_PRODUCE_TIME = Convert.ToDecimal(N_tjsj);//如果浇次结束后需要停机的在最后一炉添加停机时间
                    }
                    else
                    {
                        lst[i].N_PRODUCE_TIME = 0;
                    }

                    Mod_TPB_SCLX modlx = bll_lx.GetModel(lst[i].C_CCM_ID);
                    lst[i].C_ZL_ID = modlx.C_ZL;
                    if (lst[i].C_ROUTE.Contains("LF"))
                    {
                        lst[i].C_LF_ID = modlx.C_LF;
                    }
                    else
                    {
                        lst[i].C_LF_ID = "";
                    }
                    if (lst[i].C_ROUTE.Contains("RH"))
                    {
                        lst[i].C_RH_ID = modlx.C_RH;
                    }
                    else
                    {
                        lst[i].C_RH_ID = "";
                    }
                    if (lst[i].C_CCM_DESC.Contains("5") && lst[i].C_QUA == null)
                    {
                        lst[i].C_QUA = "18";
                    }
                    else
                    {
                        lst[i].C_QUA = "20";
                    }
                    DataTable dtdown = bll_plan_sms.GetDownPlan(lst[i].C_ID);
                    if (dtdown.Rows.Count == 0)
                    {
                        lst[i].N_SORT = n_lc_min_sort + 1;
                    }
                    lst[i].N_JC_SORT = n_jc_sort;
                    lst[i].D_P_START_TIME = dt;
                    lst[i].D_P_END_TIME = Convert.ToDateTime(dt).AddHours(Convert.ToDouble(lst[i].N_SLAB_WGT / lst[i].N_JSCN));

                    DataTable dtlgjh = Cls_APS_PC.GetLGJH(lst[i].C_STD_CODE, lst[i].C_STL_GRD, lst[i].C_CCM_DESC);
                    if (dtlgjh.Rows.Count == 0)
                    {
                        lst[i].C_REMARK1 = "没有炼钢记号！";
                    }
                    else
                    {
                        lst[i].C_REMARK1 = "";
                    }

                    bll_plan_sms.Update(lst[i]);
                    dt = Convert.ToDateTime(lst[i].D_P_END_TIME).AddHours(Convert.ToDouble(lst[i].N_PRODUCE_TIME));//下已炉的开始时间
                    dt_end_time = Convert.ToDateTime(lst[i].D_P_END_TIME);
                    n_lc_min_sort = Convert.ToInt32(lst[i].N_SORT);
                }

            }

            return dt_end_time;
        }
        #endregion

        #region 调整浇次计划整浇次炉数
        ///// <summary>
        ///// 调整浇次计划炉数
        ///// </summary>
        ///// <param name="jc_id">浇次主键</param>
        ///// <param name="num">调整后的浇次炉数</param>
        ///// <param name="sfcangejc">是否调整其他浇次计划</param>
        //public void ChangeJCLs(string jc_id, int num, string sfcangejc)
        //{
        //    #region 获取当前浇次计划产品的整浇次炉数信息
        //    int zjcls = 20;
        //    int zjclsmin = 18;
        //    int zjclsmax = 22;
        //    #endregion

        //    decimal? fzh = null;
        //    List<Mod_TSP_PLAN_SMS> lst = bll_plan_sms.GetModelListByJcID(jc_id);//当前浇次的炉次计划
        //    DataTable dt_sms = bll_plan_sms.GetList_sms_group(jc_id).Tables[0];
        //    Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(jc_id);
        //    int d_value = Convert.ToInt32(mod.N_ZJCLS) - num;//原来浇次数-调整后的炉数；正数减少浇次炉数，负数是增加炉次计划

        //    if (d_value > 0)//将该浇次炉数调少
        //    {
        //        if ((mod.N_ZJCLS - mod.N_ORDER_LS) >= d_value)//该浇次的非计划炉数比减少的炉数多
        //        {
        //            var lst1 = lst.Where(a => a.C_STATE == "1").OrderByDescending(a => a.N_SORT).ToList();
        //            for (int i = 0; i < d_value; i++)
        //            {
        //                bll_plan_sms.Delete(lst1[i].C_ID);
        //            }
        //        }
        //        else
        //        {
        //            lst = lst.OrderByDescending(a => a.N_SORT).ToList();
        //            for (int i = 0; i < d_value; i++)
        //            {
        //                if (lst[i].C_STATE == "1")
        //                {
        //                    bll_plan_sms.Delete(lst[i].C_ID);//非计划删除 
        //                }
        //                if (lst[i].C_STATE == "0")//计划炉次计划
        //                {
        //                    List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelList("").Where(a => a.N_GROUP == mod.N_GROUP && a.N_JC_SORT > mod.N_SORT && a.C_STL_GRD == mod.C_STL_GRD && a.C_STD_CODE == mod.C_STD_CODE && a.C_STATE == "1").OrderByDescending(a => a.N_JC_SORT).ThenBy(a => a.N_SORT).ToList();
        //                    if (lstlc.Count > 0)//有可替换的炉次计划
        //                    {
        //                        //替换
        //                        bll_plan_sms.Delete(lst[i].C_ID);//计划删除

        //                        lstlc[0].C_STATE = "0";
        //                        bll_plan_sms.Update(lstlc[0]);
        //                        mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次
        //                        Mod_TSP_CAST_PLAN modupdate = bll_cast_plan.GetModel(lstlc[0].C_FK);
        //                        modupdate.N_ORDER_LS = modupdate.N_ORDER_LS + 1;
        //                        bll_cast_plan.Update(modupdate);

        //                    }
        //                    else//没有可替换的
        //                    {
        //                        List<Mod_TSP_CAST_PLAN> lstinsert = bll_cast_plan.GetModelList(_strCCMID, this.rbtn_status.SelectedIndex).Where(a => a.N_GROUP == mod.N_GROUP && a.C_ID != mod.C_ID && a.N_SORT > mod.N_SORT && a.N_ZJCLS < zjcls).OrderByDescending(a => a.N_SORT).ToList();//有没有可以插入当前浇次多余的炉次计划的浇次计划,按顺序向下找

        //                        if (lstinsert.Count > 0)//有可转移的浇次计划
        //                        {
        //                            bll_plan_sms.Delete(lst[i].C_ID);//计划删除

        //                            Mod_TSP_PLAN_SMS modadd = new Mod_TSP_PLAN_SMS();
        //                            modadd = lst[i];
        //                            modadd.C_FK = lstinsert[0].C_ID;
        //                            modadd.C_ID = System.Guid.NewGuid().ToString();
        //                            modadd.N_SORT = bll_plan_sms.MaxSortBy(modadd.C_FK) + 1;
        //                            modadd.N_JC_SORT = lstinsert[0].N_SORT;
        //                            bll_plan_sms.Add(modadd);

        //                            lstinsert[0].N_ORDER_LS = lstinsert[0].N_ORDER_LS + 1;
        //                            lstinsert[0].N_ZJCLS = lstinsert[0].N_ZJCLS + 1;
        //                            lstinsert[0].N_ZJCLZL = lstinsert[0].N_ZJCLS * lstinsert[0].N_MLZL;
        //                            bll_cast_plan.Update(lstinsert[0]);
        //                            //炉次计划转移到目标浇次计划
        //                            mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次

        //                        }
        //                        else
        //                        {
        //                            //新增浇次计划
        //                            Mod_TSP_CAST_PLAN mod_add_jc = new Mod_TSP_CAST_PLAN();
        //                            mod_add_jc.N_SORT = bll_cast_plan.GetModelList(_strCCMID, this.rbtn_status.SelectedIndex).ToList().Count + 1;//插入到浇次计划的最后面

        //                            mod_add_jc.C_ID = System.Guid.NewGuid().ToString();
        //                            mod_add_jc.C_STL_GRD = lst[i].C_STL_GRD;
        //                            mod_add_jc.C_STD_CODE = lst[i].C_STD_CODE;
        //                            mod_add_jc.N_ORDER_LS = 1;
        //                            mod_add_jc.N_GROUP = lst[i].N_GROUP;
        //                            mod_add_jc.N_ZJCLS = zjclsmin;
        //                            mod_add_jc.N_ZJCLZL = mod_add_jc.N_ZJCLS * lst[i].N_SLAB_WGT;
        //                            mod_add_jc.C_STL_GRD_TYPE = lst[i].C_STL_GRD_TYPE;
        //                            mod_add_jc.C_PROD_NAME = lst[i].C_PROD_NAME;
        //                            mod_add_jc.C_CCM_ID = lst[i].C_CCM_ID;
        //                            mod_add_jc.C_RH = lst[i].C_RH;
        //                            mod_add_jc.C_DFP_HL = lst[i].C_DFP_HL;
        //                            mod_add_jc.C_HL = lst[i].C_HL;
        //                            mod_add_jc.C_XM = lst[i].C_XM;
        //                            mod_add_jc.N_MLZL = lst[i].N_SLAB_WGT;
        //                            string strRemark = "";
        //                            for (int s = 0; s < dt_sms.Rows.Count; s++)
        //                            {
        //                                strRemark += dt_sms.Rows[s]["C_STL_GRD"] + "~" + dt_sms.Rows[s]["C_STD_CODE"] + "~" + dt_sms.Rows[s]["COU"] + "\n";
        //                            }
        //                            mod_add_jc.C_REMARK = strRemark;
        //                            mod_add_jc.C_TL = lst[i].C_TL;
        //                            mod_add_jc.C_CCM_CODE = lst[i].C_CCM_DESC;
        //                            mod_add_jc.C_CCM_ID = lst[i].C_CCM_ID;
        //                            mod_add_jc.C_BY3 = lst[i].C_BY3;
        //                            mod_add_jc.C_SLAB_TYPE = lst[i].C_SLAB_TYPE;
        //                            bll_cast_plan.Add(mod_add_jc);
        //                            //新增炉次计划

        //                            bll_plan_sms.Delete(lst[i].C_ID);

        //                            //炉次计划转移到新增浇次计划
        //                            Mod_TSP_PLAN_SMS mod_add_lc = new Mod_TSP_PLAN_SMS();
        //                            mod_add_lc = lst[i];
        //                            mod_add_lc.C_ID = System.Guid.NewGuid().ToString();
        //                            mod_add_lc.C_FK = mod_add_jc.C_ID;
        //                            mod_add_lc.N_SORT = 1;
        //                            mod_add_lc.N_JC_SORT = mod_add_jc.N_SORT;
        //                            mod_add_lc.C_STATE = "0";
        //                            bll_plan_sms.Add(mod_add_lc);

        //                            for (int l = 1; l < mod_add_jc.N_ZJCLS; l++)
        //                            {
        //                                Mod_TSP_PLAN_SMS mod_add_lc2 = new Mod_TSP_PLAN_SMS();
        //                                mod_add_lc2 = lst[i];
        //                                mod_add_lc2.C_ID = System.Guid.NewGuid().ToString();
        //                                mod_add_lc2.C_FK = mod_add_jc.C_ID;
        //                                mod_add_lc2.N_SORT = l + 1;
        //                                mod_add_lc2.C_STATE = "1";
        //                                mod_add_lc2.N_JC_SORT = mod_add_jc.N_SORT;
        //                                bll_plan_sms.Add(mod_add_lc2);
        //                            }
        //                            mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次
        //                        }

        //                    }
        //                }
        //            }

        //        }
        //    }
        //    else//将该浇次炉数调大
        //    {
        //        int addls = d_value * -1;
        //        for (int j = 0; j < addls; j++)
        //        {
        //            List<Mod_TSP_CAST_PLAN> lst1 = bll_cast_plan.GetModelList(_strCCMID, this.rbtn_status.SelectedIndex).Where(a => a.N_GROUP == mod.N_GROUP && a.N_SORT > mod.N_SORT && a.C_CCM_ID == mod.C_CCM_ID).ToList();
        //            if (lst1.Count == 0)
        //            {
        //                Mod_TSP_PLAN_SMS modlc = lst[lst.Count - 1];//复制最后一条炉次计划
        //                modlc.C_ID = System.Guid.NewGuid().ToString();
        //                modlc.N_SORT = modlc.N_SORT + j + 1;//更新炉次计划序号
        //                modlc.C_STATE = "1";//增加的计划为非计划炉次计划
        //                bll_plan_sms.Add(modlc);
        //            }
        //            else
        //            {

        //                //查找可替换的炉次计划（浇次序号在当前浇次后面的）
        //                Mod_TSP_PLAN_SMS modlc = lst[lst.Count - 1];//复制最后一条炉次计划
        //                List<Mod_TSP_PLAN_SMS> lstth = bll_plan_sms.GetModelList("").Where(a => a.N_GROUP == modlc.N_GROUP && a.N_JC_SORT > modlc.N_JC_SORT && a.C_STATE == "0" && a.C_STL_GRD == modlc.C_STL_GRD && a.C_STD_CODE == modlc.C_STD_CODE).OrderByDescending(a => a.N_JC_SORT).ThenByDescending(a => a.N_SORT).ToList();
        //                if (lstth.Count > 0)
        //                {

        //                    modlc.C_ID = System.Guid.NewGuid().ToString();
        //                    modlc.N_SORT = modlc.N_SORT + j + 1;//更新炉次计划序号
        //                    modlc.C_STATE = "0";//增加的计划为非计划炉次计划
        //                    mod.N_ORDER_LS++;
        //                    bll_plan_sms.Add(modlc);


        //                    lstth[0].C_STATE = "1";
        //                    bll_plan_sms.Update(lstth[0]);

        //                    Mod_TSP_CAST_PLAN modjcth = bll_cast_plan.GetModel(lstth[0].C_FK);
        //                    modjcth.N_ORDER_LS--;
        //                    bll_cast_plan.Update(modjcth);
        //                }
        //                else
        //                {
        //                    Mod_TSP_PLAN_SMS modlc1 = lst[lst.Count - 1];//复制最后一条炉次计划
        //                    modlc1.C_ID = System.Guid.NewGuid().ToString();
        //                    modlc1.N_SORT = modlc1.N_SORT + j + 1;//更新炉次计划序号
        //                    modlc1.C_STATE = "1";//增加的计划为非计划炉次计划
        //                    bll_plan_sms.Add(modlc1);
        //                }
        //            }

        //        }
        //    }
        //    mod.N_ZJCLS = Convert.ToInt32(num);//调整后的整浇次炉数
        //    mod.N_ZJCLZL = mod.N_ZJCLS * mod.N_MLZL;
        //    fzh = mod.N_GROUP;
        //    bll_cast_plan.Update(mod);
        //}

        #endregion

        /// <summary>
        /// 更新浇次计划信息(备注，时间，rh,xm,tl,hl等)
        /// </summary>
        /// <param name="JC_ID">浇次主键</param>
        /// <param name="sfzz">是否终止计划1是，0否</param>
        /// 更新前先得更新炉次计划
        public void UpdateJCByLC(string JC_ID, string sfzz)
        {

            Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(JC_ID);

            string remark = "";
            List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(JC_ID);
            if (lstlc.Count == 0)
            {
                modjc.N_STATUS = 0;

            }
            else if (lstlc.Where(a => a.N_CREAT_PLAN > 1).ToList().Count == lstlc.Count && lstlc.Where(a => a.N_CREAT_PLAN < 4).ToList().Count > 0)
            {
                modjc.N_STATUS = 2;//标记浇次计划已下调度，但不能标记浇次计划完成

            }
            else if (lstlc.Where(a => a.N_CREAT_PLAN == 4).ToList().Count == lstlc.Count && sfzz == "1")
            {
                modjc.N_STATUS = 3;
            }

            modjc.N_ORDER_LS = lstlc.Where(a => a.C_STATE == "0" && a.N_STATUS == 1).ToList().Count;
            var lst = lstlc.GroupBy(a => new { a.C_STL_GRD, a.C_STD_CODE }).Select(a => new { num = a.Count(), a.First().C_STL_GRD, a.First().C_STD_CODE, a.First().C_RH, a.First().C_DFP_HL, a.First().C_HL, a.First().C_XM }).ToList();
            if (lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (i == 0)
                    {
                        remark = lst[i].C_STL_GRD + "~" + lst[i].C_STD_CODE + "~" + lst[i].num.ToString();
                    }
                    else
                    {
                        remark = remark + "\n" + lst[i].C_STL_GRD + "~" + lst[i].C_STD_CODE + "~" + lst[i].num.ToString();
                    }
                }
            }
            modjc.C_REMARK = remark;
            bll_cast_plan.Update(modjc);
            // bll_cast_plan.UpdateJCPlan(JC_ID);

        }



        #region 调整浇次计划整浇次炉数
        /// <summary>
        /// 调整浇次计划炉数
        /// </summary>
        /// <param name="jc_id">浇次主键</param>
        /// <param name="num">调整后的浇次炉数</param>
        /// <param name="sfcangejc">是否调整其他浇次计划</param>
        public void ChangeJCLs1(string jc_id, int num, string sfcangejc)
        {
            #region 获取当前浇次计划产品的整浇次炉数信息
            int zjcls = 20;
            int zjclsmin = 18;
            int zjclsmax = 22;
            #endregion

            decimal? fzh = null;
            List<Mod_TSP_PLAN_SMS> lst = bll_plan_sms.GetModelListByJcID(jc_id);//当前浇次的炉次计划
            DataTable dt_sms = bll_plan_sms.GetList_sms_group(jc_id).Tables[0];
            Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(jc_id);
            int d_value = Convert.ToInt32(mod.N_ZJCLS) - num;//原来浇次数-调整后的炉数；正数减少浇次炉数，负数是增加炉次计划

            if (d_value > 0)//将该浇次炉数调少
            {
                if ((mod.N_ZJCLS - mod.N_ORDER_LS) >= d_value)//该浇次的非计划炉数比减少的炉数多
                {
                    var lst1 = lst.Where(a => a.C_STATE == "1").OrderByDescending(a => a.N_SORT).ToList();
                    for (int i = 0; i < d_value; i++)
                    {
                        bll_plan_sms.Delete(lst1[i].C_ID);
                    }
                }
                else
                {
                    lst = lst.OrderByDescending(a => a.N_SORT).ToList();
                    for (int i = 0; i < d_value; i++)
                    {
                        if (lst[i].C_STATE == "1")
                        {
                            bll_plan_sms.Delete(lst[i].C_ID);//非计划删除 
                        }
                        if (lst[i].C_STATE == "0")//计划炉次计划
                        {
                            List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelList("").Where(a => a.N_GROUP == mod.N_GROUP && a.N_JC_SORT > mod.N_SORT && a.C_STL_GRD == mod.C_STL_GRD && a.C_STD_CODE == mod.C_STD_CODE && a.C_STATE == "1").OrderByDescending(a => a.N_JC_SORT).ThenBy(a => a.N_SORT).ToList();
                            if (lstlc.Count > 0)//有可替换的炉次计划
                            {
                                //替换
                                bll_plan_sms.Delete(lst[i].C_ID);//计划删除

                                lstlc[0].C_STATE = "0";
                                bll_plan_sms.Update(lstlc[0]);
                                mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次
                                Mod_TSP_CAST_PLAN modupdate = bll_cast_plan.GetModel(lstlc[0].C_FK);
                                modupdate.N_ORDER_LS = modupdate.N_ORDER_LS + 1;
                                bll_cast_plan.Update(modupdate);

                            }
                            else//没有可替换的
                            {
                                List<Mod_TSP_CAST_PLAN> lstinsert = bll_cast_plan.GetModelList(mod.C_CCM_ID, 1, "").Where(a => a.N_GROUP == mod.N_GROUP && a.C_ID != mod.C_ID && a.N_SORT > mod.N_SORT && a.N_ZJCLS < zjcls).OrderByDescending(a => a.N_SORT).ToList();//有没有可以插入当前浇次多余的炉次计划的浇次计划,按顺序向下找

                                if (lstinsert.Count > 0)//有可转移的浇次计划
                                {
                                    bll_plan_sms.Delete(lst[i].C_ID);//计划删除

                                    Mod_TSP_PLAN_SMS modadd = new Mod_TSP_PLAN_SMS();
                                    modadd = lst[i];
                                    modadd.C_FK = lstinsert[0].C_ID;
                                    modadd.C_ID = System.Guid.NewGuid().ToString();
                                    modadd.N_SORT = bll_plan_sms.MaxSortBy(modadd.C_FK) + 1;
                                    modadd.N_JC_SORT = lstinsert[0].N_SORT;
                                    bll_plan_sms.Add(modadd);

                                    lstinsert[0].N_ORDER_LS = lstinsert[0].N_ORDER_LS + 1;
                                    lstinsert[0].N_ZJCLS = lstinsert[0].N_ZJCLS + 1;
                                    lstinsert[0].N_ZJCLZL = lstinsert[0].N_ZJCLS * lstinsert[0].N_MLZL;
                                    bll_cast_plan.Update(lstinsert[0]);
                                    //炉次计划转移到目标浇次计划
                                    mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次

                                }
                                else
                                {
                                    //新增浇次计划
                                    Mod_TSP_CAST_PLAN mod_add_jc = new Mod_TSP_CAST_PLAN();
                                    mod_add_jc.N_SORT = bll_cast_plan.GetModelList(mod.C_CCM_ID, 1, "").Where(a => a.C_CCM_ID == mod.C_CCM_ID).ToList().Count + 1;//插入到浇次计划的最后面
                                    mod_add_jc.C_ID = System.Guid.NewGuid().ToString();
                                    mod_add_jc.C_STL_GRD = lst[i].C_STL_GRD;
                                    mod_add_jc.C_STD_CODE = lst[i].C_STD_CODE;
                                    mod_add_jc.N_ORDER_LS = 1;
                                    mod_add_jc.N_GROUP = lst[i].N_GROUP;
                                    mod_add_jc.N_ZJCLS = zjclsmin;
                                    mod_add_jc.N_ZJCLZL = mod_add_jc.N_ZJCLS * lst[i].N_SLAB_WGT;
                                    mod_add_jc.C_STL_GRD_TYPE = lst[i].C_STL_GRD_TYPE;
                                    mod_add_jc.C_PROD_NAME = lst[i].C_PROD_NAME;
                                    mod_add_jc.C_CCM_ID = lst[i].C_CCM_ID;
                                    mod_add_jc.C_RH = lst[i].C_RH;
                                    mod_add_jc.C_DFP_HL = lst[i].C_DFP_HL;
                                    mod_add_jc.C_HL = lst[i].C_HL;
                                    mod_add_jc.C_XM = lst[i].C_XM;
                                    mod_add_jc.N_MLZL = lst[i].N_SLAB_WGT;
                                    string strRemark = "";
                                    for (int s = 0; s < dt_sms.Rows.Count; s++)
                                    {
                                        strRemark += dt_sms.Rows[s]["C_STL_GRD"] + "~" + dt_sms.Rows[s]["C_STD_CODE"] + "~" + dt_sms.Rows[s]["COU"] + "\n";
                                    }
                                    mod_add_jc.C_REMARK = strRemark;
                                    mod_add_jc.C_TL = lst[i].C_TL;
                                    mod_add_jc.C_CCM_CODE = lst[i].C_CCM_DESC;
                                    mod_add_jc.C_CCM_ID = lst[i].C_CCM_ID;
                                    mod_add_jc.C_BY3 = lst[i].C_BY3;
                                    mod_add_jc.C_SLAB_TYPE = lst[i].C_SLAB_TYPE;
                                    mod_add_jc.N_STATUS = 1;
                                    mod_add_jc.N_RH = lst[i].C_RH == "Y" ? (decimal)mod_add_jc.N_ZJCLS : 0;
                                    mod_add_jc.N_TL = lst[i].C_TL == "Y" ? (decimal)mod_add_jc.N_ZJCLS : 0;
                                    mod_add_jc.N_DHL = lst[i].C_DFP_HL == "Y" ? (decimal)mod_add_jc.N_ZJCLS : 0;
                                    mod_add_jc.N_XM = lst[i].C_XM == "Y" ? (decimal)mod_add_jc.N_ZJCLS : 0;
                                    mod_add_jc.N_HL = lst[i].C_HL == "Y" ? (decimal)mod_add_jc.N_ZJCLS : 0;
                                    mod_add_jc.N_JSCN = lst[i].N_JSCN;
                                    bll_cast_plan.Add(mod_add_jc);
                                    //新增炉次计划

                                    bll_plan_sms.Delete(lst[i].C_ID);

                                    //炉次计划转移到新增浇次计划
                                    Mod_TSP_PLAN_SMS mod_add_lc = new Mod_TSP_PLAN_SMS();
                                    mod_add_lc = lst[i];
                                    mod_add_lc.C_ID = System.Guid.NewGuid().ToString();
                                    mod_add_lc.C_FK = mod_add_jc.C_ID;
                                    mod_add_lc.N_SORT = 1;
                                    mod_add_lc.N_JC_SORT = mod_add_jc.N_SORT;
                                    mod_add_lc.C_STATE = "0";
                                    bll_plan_sms.Add(mod_add_lc);

                                    for (int l = 1; l < mod_add_jc.N_ZJCLS; l++)
                                    {
                                        Mod_TSP_PLAN_SMS mod_add_lc2 = new Mod_TSP_PLAN_SMS();
                                        mod_add_lc2 = lst[i];
                                        mod_add_lc2.C_ID = System.Guid.NewGuid().ToString();
                                        mod_add_lc2.C_FK = mod_add_jc.C_ID;
                                        mod_add_lc2.N_SORT = l + 1;
                                        mod_add_lc2.C_STATE = "1";
                                        mod_add_lc2.N_JC_SORT = mod_add_jc.N_SORT;
                                        bll_plan_sms.Add(mod_add_lc2);
                                    }
                                    mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次

                                    UpdateJCByLC(mod_add_jc.C_ID, "0");

                                }

                            }
                        }
                    }

                }
            }
            else//将该浇次炉数调大
            {
                int addls = d_value * -1;
                for (int j = 0; j < addls; j++)
                {
                    List<Mod_TSP_CAST_PLAN> lst1 = bll_cast_plan.GetModelList(mod.C_CCM_ID, 1, "").Where(a => a.N_GROUP == mod.N_GROUP && a.N_SORT > mod.N_SORT && a.C_CCM_ID == mod.C_CCM_ID).ToList();
                    if (lst1.Count == 0)
                    {
                        Mod_TSP_PLAN_SMS modlc = lst[lst.Count - 1];//复制最后一条炉次计划
                        modlc.C_ID = System.Guid.NewGuid().ToString();
                        modlc.N_SORT = modlc.N_SORT + j + 1;//更新炉次计划序号
                        modlc.C_STATE = "1";//增加的计划为非计划炉次计划
                        bll_plan_sms.Add(modlc);
                    }
                    else
                    {
                        //查找可替换的炉次计划（浇次序号在当前浇次后面的）
                        Mod_TSP_PLAN_SMS modlc = lst[lst.Count - 1];//复制最后一条炉次计划
                        List<Mod_TSP_PLAN_SMS> lstth = bll_plan_sms.GetModelList("").Where(a => a.N_GROUP == modlc.N_GROUP && a.N_JC_SORT > modlc.N_JC_SORT && a.C_STATE == "0" && a.C_STL_GRD == modlc.C_STL_GRD && a.C_STD_CODE == modlc.C_STD_CODE).OrderByDescending(a => a.N_JC_SORT).ThenByDescending(a => a.N_SORT).ToList();
                        if (lstth.Count > 0)
                        {
                            modlc.C_ID = System.Guid.NewGuid().ToString();
                            modlc.N_SORT = modlc.N_SORT + j + 1;//更新炉次计划序号
                            modlc.C_STATE = "0";//增加的计划为非计划炉次计划
                            mod.N_ORDER_LS++;
                            bll_plan_sms.Add(modlc);

                            lstth[0].C_STATE = "1";
                            bll_plan_sms.Update(lstth[0]);

                            Mod_TSP_CAST_PLAN modjcth = bll_cast_plan.GetModel(lstth[0].C_FK);
                            modjcth.N_ORDER_LS--;
                            bll_cast_plan.Update(modjcth);
                        }
                        else
                        {
                            Mod_TSP_PLAN_SMS modlc1 = lst[lst.Count - 1];//复制最后一条炉次计划
                            modlc1.C_ID = System.Guid.NewGuid().ToString();
                            modlc1.N_SORT = modlc1.N_SORT + j + 1;//更新炉次计划序号
                            modlc1.C_STATE = "1";//增加的计划为非计划炉次计划
                            bll_plan_sms.Add(modlc1);
                        }
                    }

                }

            }
            mod.N_ZJCLS = Convert.ToInt32(num);//调整后的整浇次炉数
            mod.N_ZJCLZL = mod.N_ZJCLS * mod.N_MLZL;
            fzh = mod.N_GROUP;
            bll_cast_plan.Update(mod);
        }

        #endregion

        #region 根据已排产计划获取本次排产炼钢计划的开始时间
        /// <summary>
        /// 根据已排产炉次计划获取本次排产首条计划的开始时间
        /// </summary>
        /// <param name="c_ccm">连铸机ID</param>
        /// <returns>计划开始时间</returns>
        public DateTime? GetStartTime(string c_ccm)
        {
            DateTime? dt = null;
            #region 初始化连铸浇次计划的首条计划的开始时间
            try
            {
                sms_plan = bll_plan_sms.GetModelList(" N_CREAT_PLAN<3 ");//已排产未完成的计划 
                var sms_list = sms_plan.Where(a => a.C_CCM_ID == c_ccm).OrderByDescending(a => a.D_P_END_TIME).ToList();//已排产炉次计划并按计划时间倒序
                if (sms_list.Count > 0)
                {
                    dt = Convert.ToDateTime(sms_list[0].D_P_END_TIME).AddHours(Convert.ToDouble(sms_list[0].N_PRODUCE_TIME));
                    if (dt == null || dt <= System.DateTime.Now)
                    {
                        dt = System.DateTime.Now;
                    }
                }
                else
                {
                    dt = System.DateTime.Now;
                }
            }
            catch (Exception)
            {
                dt = System.DateTime.Now;
            }


            #endregion
            return dt;
        }
        #endregion


        #endregion

        public int jcminsort = 1;//浇次起始序号
        public int lcminsort = 1;//炉次起始序号
        #region 拖动
        #region 浇次计划列表鼠标拖动方法
        /// <summary>
        /// 浇次计划 行托动方法
        /// </summary>
        /// <param name="lst">加载的数据</param>
        /// <param name="gvSource">gridview</param>
        private void InitDrop()
        {
            var dropPlanToReq = new GridViewDragDropHelper(
                this.gridView6, gridView6, (row1, row2) =>
                {
                    if (row1 == row2) return;

                    var plan1 = gridView6.GetRow(row1) as Mod_TSP_CAST_PLAN;
                    if (row2 < jc_cast_plan.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gridView6.RowCount)
                        {
                            row2 = gridView6.RowCount - 1;
                        }
                        var plan2 = gridView6.GetRow(row2) as Mod_TSP_CAST_PLAN;
                        if (plan2 == null)
                            return;
                        jc_cast_plan.Remove(plan1);
                        var left = jc_cast_plan.TakeWhile(x => x.N_SORT < plan2.N_SORT).ToList();
                        var right = jc_cast_plan.Where(x => left.Contains(x) == false).ToList();
                        jc_cast_plan.Clear();
                        jc_cast_plan.AddRange(left);
                        jc_cast_plan.Add(plan1);
                        jc_cast_plan.AddRange(right);
                    }
                    else
                    {
                        jc_cast_plan.Remove(plan1);
                        jc_cast_plan.Add(plan1);
                    }

                    for (int i = 0; i < jc_cast_plan.Count; i++)
                    {
                        jc_cast_plan[i].N_SORT = jcminsort + i;
                    }

                    DateTime dtb = jc_cast_plan.Min(a => a.D_P_START_TIME) == null ? System.DateTime.Now.AddHours(1) : (DateTime)jc_cast_plan.Min(a => a.D_P_START_TIME);
                    int ljls = 0;
                    for (int i = 0; i < jc_cast_plan.Count; i++)
                    {
                        if (jc_cast_plan[i].C_PROD_NAME == "超低碳钢" && jc_cast_plan[i].C_RH == "Y")
                        {
                            ljls = 0;
                        }
                        else
                        {
                            ljls = (int)(ljls + jc_cast_plan[i].N_ZJCLS);
                        }
                        jc_cast_plan[i].D_P_START_TIME = dtb;
                        jc_cast_plan[i].D_P_END_TIME = dtb.AddHours((double)(jc_cast_plan[i].N_MLZL * jc_cast_plan[i].N_ZJCLS / jc_cast_plan[i].N_JSCN));
                        //if (ljls >= 32)
                        //{
                        //    jc_cast_plan[i].N_PRODUCE_TIME = 4;
                        //    ljls = 0;
                        //}
                        //else
                        //{
                        //    jc_cast_plan[i].N_PRODUCE_TIME = 0;
                        //}
                        dtb = Convert.ToDateTime(jc_cast_plan[i].D_P_END_TIME).AddHours((double)jc_cast_plan[i].N_PRODUCE_TIME);
                    }




                    gridView6.RefreshData();
                });

            dropPlanToReq.AllowDrop = true;


        }
        #endregion

        #region 炉次计划列表鼠标拖动方法
        /// <summary>
        /// 炉次计划 行托动方法
        /// </summary>
        /// <param name="lst">加载的数据</param>
        /// <param name="gvSource">gridview</param>
        private void InitDrop_Lc()
        {
            var dropPlanToReq = new GridViewDragDropHelper(
                this.gridView7, gridView7, (row1, row2) =>
                {
                    if (row1 == row2) return;

                    var plan1 = gridView7.GetRow(row1) as Mod_TSP_PLAN_SMS;
                    if (row2 < sms_plan.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gridView7.RowCount)
                        {
                            row2 = gridView7.RowCount - 1;
                        }
                        var plan2 = gridView7.GetRow(row2) as Mod_TSP_PLAN_SMS;
                        if (plan2 == null)
                            return;
                        sms_plan.Remove(plan1);
                        var left = sms_plan.TakeWhile(x => x.N_SORT < plan2.N_SORT).ToList();
                        var right = sms_plan.Where(x => left.Contains(x) == false).ToList();
                        sms_plan.Clear();
                        sms_plan.AddRange(left);
                        sms_plan.Add(plan1);
                        sms_plan.AddRange(right);
                    }
                    else
                    {
                        sms_plan.Remove(plan1);
                        sms_plan.Add(plan1);
                    }

                    for (int i = 0; i < sms_plan.Count; i++)
                    {
                        sms_plan[i].N_SORT = minsort + i;
                    }
                    //foreach (var item in sms_plan)
                    //{
                    //    item.N_SORT = sms_plan.IndexOf(item) + 1;
                    //}

                    gridView7.RefreshData();
                });

            dropPlanToReq.AllowDrop = true;


        }
        #endregion
        #endregion

        /// <summary>
        /// 浇次计划排产查询连铸主键
        /// </summary>
        private string _strCCMID
        {
            get
            {
                var index = this.icbo_lz3.SelectedIndex;
                if (index >= 0)
                    return this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();

                return string.Empty;
            }
        }
        string str_meunname = "";
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPO_APS_Order_LGFX_Load(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now.AddDays(1 - DateTime.Now.Day).Date;
            dtp_start_date.Text = dt1.ToString("yyyy-MM-dd");

            string dt = "";
            if (this.rbtn_status.SelectedIndex == 2)
            {
                dt = dtp_start_date.Text;
            }
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            CommonSub.BindIcboNoAll("", "CC", icbo_lz3);
            //icbo_lz3.SelectedIndex = 2;
            CommonSub.BindIcboNoAll("", "CC", icbo_lz4);

            this.icbo_lz3.SelectedIndex = 2;
            if (this.icbo_lz3.SelectedIndex >= 0)
            {
                string strccm = this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();
                BindLsbGrid(strccm, this.rbtn_status.SelectedIndex + 1, dt);
                //BindLcLsbGrid("");
                try
                {
                    InitDrop();
                    InitDrop_Lc();
                }
                catch (Exception ex)
                {
                }
            }

            str_meunname = RV.UI.UserInfo.menuName;

        }

        /// <summary>
        ///  按浇次验证炉次计划顺序是否正确
        /// </summary>
        /// <param name="C_JC_ID">浇次主键</param>
        /// <returns></returns>
        public bool CheckLCPlanSort(string C_JC_ID)
        {
            Mod_TSP_CAST_PLAN mod_jc = bll_cast_plan.GetModel(C_JC_ID);
            mod_jc.C_BY3 = "";//炉次计划顺序是否正确
            #region 验证两炉计划是否能否相邻生产
            if (mod_jc != null)
            {

                List<Mod_TSP_PLAN_SMS> lstsms = bll_plan_sms.GetModelListByJcID(C_JC_ID).OrderBy(a => a.N_SORT).ToList();
                if (lstsms.Count > 0)
                {
                    bool flag = true;

                    //标记浇次计划不正确
                    #region 验证是否有首尾炉计划
                    for (int i = 0; i < lstsms.Count; i++)
                    {
                        lstsms[i].C_CTRL_NO = "";//标记上下炉次不能衔接，清空
                        bll_plan_sms.Update(lstsms[i]);
                        if (i == 0)
                        {
                            DataTable dtswl = GetSWLSteel(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, "首");
                            DataRow[] dr = dtswl.Select(" C_B_E_STOVE_STEEL ='" + lstsms[i].C_STL_GRD + "' AND C_BORDER_STD_CODE='" + lstsms[i].C_STD_CODE + "'");
                            if (dtswl.Rows.Count > 0 && dr.Count() == 0)
                            {

                                flag = false;
                                lstsms[i].C_CTRL_NO = "当前计划需要首炉计划！";
                                bll_plan_sms.Update(lstsms[i]);
                                break;
                            }
                        }
                        if (i == 1)
                        {
                            DataTable dtswl = GetSWLSteel(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, "首");
                            if (dtswl.Rows.Count > 0)
                            {
                                //验证上一炉
                                if (lstsms[i].C_STL_GRD != lstsms[i - 1].C_STL_GRD || lstsms[i].C_STD_CODE != lstsms[i - 1].C_STD_CODE)
                                {
                                    string C_STD_CODE2 = lstsms[i - 1].C_STD_CODE;
                                    if (C_STD_CODE2.Contains("Q/XG") || C_STD_CODE2.Contains("GB/T") || C_STD_CODE2.Contains("Q/邢钢"))
                                    {
                                        C_STD_CODE2 = C_STD_CODE2.Split('-')[0].Split('.')[0];

                                    }
                                    DataRow[] dr = dtswl.Select(" C_B_E_STOVE_STEEL ='" + lstsms[i - 1].C_STL_GRD + "' AND C_BORDER_STD_CODE='" + C_STD_CODE2 + "'");
                                    if (dr.Count() == 0)
                                    {

                                        flag = false;
                                        lstsms[i].C_CTRL_NO = "当前计划需要首炉计划！";
                                        bll_plan_sms.Update(lstsms[i]);
                                        break;
                                    }
                                }
                            }
                        }
                        if (i > 0 && i < lstsms.Count - 1)
                        {                  //从第二行开始进行验证
                            string C_STL_GRD1 = lstsms[i - 1].C_STL_GRD;//上一行钢种
                            string C_STD_CODE1 = lstsms[i - 1].C_STD_CODE;//上一行标准

                            string C_STL_GRD = lstsms[i].C_STL_GRD;//本行钢种
                            string C_STD_CODE = lstsms[i].C_STD_CODE;//本行标准
                                                                     //验证能否相邻生产
                            bool res = Cls_APS_PC.CheckProduceBroder(C_STL_GRD1, C_STD_CODE1, C_STL_GRD, C_STD_CODE);
                            if (res == false)
                            {

                                flag = false;
                                //标记炉次计划顺序不正确
                                lstsms[i].C_CTRL_NO = "和上炉计划不能连浇！";
                                bll_plan_sms.Update(lstsms[i]);
                            }
                            #region 验证首尾炉


                            //DataTable dtswl = GetSWLSteel(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, "首");
                            //if (dtswl.Rows.Count > 0)
                            //{
                            //    //验证上一炉
                            //    if (lstsms[i].C_STL_GRD != lstsms[i - 1].C_STL_GRD || lstsms[i].C_STD_CODE != lstsms[i - 1].C_STD_CODE)
                            //    {
                            //        string C_STD_CODE2 = lstsms[i - 1].C_STD_CODE;
                            //        if (C_STD_CODE2.Contains("Q/XG") || C_STD_CODE2.Contains("GB/T") || C_STD_CODE2.Contains("Q/邢钢"))
                            //        {
                            //            C_STD_CODE2 = C_STD_CODE2.Split('-')[0].Split('.')[0];

                            //        }
                            //        DataRow[] dr = dtswl.Select(" C_B_E_STOVE_STEEL ='" + lstsms[i - 1].C_STL_GRD + "' AND C_BORDER_STD_CODE='" + C_STD_CODE2 + "'");
                            //        if (dr.Count()==0)
                            //        {

                            //            flag = false;
                            //            lstsms[i].C_CTRL_NO = "当前计划需要首炉计划！";
                            //            bll_plan_sms.Update(lstsms[i]);
                            //            break;
                            //        }
                            //    }
                            //}

                            ////验证下一炉
                            //DataTable dtwl = GetSWLSteel(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, "尾");
                            //if (dtwl.Rows.Count > 0)
                            //{
                            //    //验证上一炉
                            //    if (lstsms[i].C_STL_GRD != lstsms[i +1].C_STL_GRD || lstsms[i].C_STD_CODE != lstsms[i + 1].C_STD_CODE)
                            //    {
                            //        string C_STD_CODE2 = lstsms[i + 1].C_STD_CODE;
                            //        if (C_STD_CODE2.Contains("Q/XG") || C_STD_CODE2.Contains("GB/T") || C_STD_CODE2.Contains("Q/邢钢"))
                            //        {
                            //            C_STD_CODE2 = C_STD_CODE2.Split('-')[0].Split('.')[0];

                            //        }
                            //        DataRow[] dr = dtwl.Select(" C_B_E_STOVE_STEEL ='" + lstsms[i + 1].C_STL_GRD + "' AND C_BORDER_STD_CODE='" + C_STD_CODE2 + "'");
                            //        if (dr.Count() == 0)
                            //        {

                            //            flag = false;
                            //            lstsms[i].C_CTRL_NO = "当前计划需要尾炉计划！";
                            //            bll_plan_sms.Update(lstsms[i]);
                            //            break;
                            //        }
                            //    }
                            //}
                            #endregion
                        }
                        if (i == lstsms.Count - 2)
                        {
                            //验证下一炉
                            DataTable dtwl = GetSWLSteel(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, "尾");
                            if (dtwl.Rows.Count > 0)
                            {
                                //验证上一炉
                                if (lstsms[i].C_STL_GRD != lstsms[i + 1].C_STL_GRD || lstsms[i].C_STD_CODE != lstsms[i + 1].C_STD_CODE)
                                {
                                    string C_STD_CODE2 = lstsms[i + 1].C_STD_CODE;
                                    if (C_STD_CODE2.Contains("Q/XG") || C_STD_CODE2.Contains("GB/T") || C_STD_CODE2.Contains("Q/邢钢"))
                                    {
                                        C_STD_CODE2 = C_STD_CODE2.Split('-')[0].Split('.')[0];

                                    }
                                    DataRow[] dr = dtwl.Select(" C_B_E_STOVE_STEEL ='" + lstsms[i + 1].C_STL_GRD + "' AND C_BORDER_STD_CODE='" + C_STD_CODE2 + "'");
                                    if (dr.Count() == 0)
                                    {

                                        flag = false;
                                        lstsms[i].C_CTRL_NO = "当前计划需要尾炉计划！";
                                        bll_plan_sms.Update(lstsms[i]);
                                        break;
                                    }
                                }
                            }
                        }
                        if (i == lstsms.Count - 1)
                        {
                            DataTable dtswl = GetSWLSteel(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, "尾");
                            if (dtswl.Rows.Count > 0)
                            {

                                flag = false;
                                lstsms[i].C_CTRL_NO = "当前计划需要尾炉计划！";
                                bll_plan_sms.Update(lstsms[i]);
                                break;
                            }
                        }
                    }


                    #endregion
                    if (!flag)
                    {

                        mod_jc.C_BY3 = "炉次计划有误！";
                    }

                    return flag;
                }
                else
                {
                    mod_jc.C_BY3 = "炉次计划有误！";
                    return false;
                }

            }
            else
            {
                mod_jc.C_BY3 = "炉次计划有误！";
                // bll_cast_plan.Update(mod_jc);
                return false;
            }
            #endregion


        }

        private Bll_TPB_ENDTOEND_GRD bll_swl = new Bll_TPB_ENDTOEND_GRD();
        /// <summary>
        /// 验证钢种的首尾炉钢种
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        ///  <param name="TYPE">类型：首尾炉，首炉，尾炉（模糊查询）</param>
        /// <returns></returns>
        public DataTable GetSWLSteel(string C_STL_GRD, string C_STD_CODE, string TYPE)
        {
            return bll_swl.GetSWLSteel(C_STL_GRD, C_STD_CODE, TYPE);
        }

        /// <summary>
        /// 浇次计划焦点行改变后加载对应的炉次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView6_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            try
            {
                int selectedHandle;
                selectedHandle = this.gridView6.GetSelectedRows()[0];

                if (selectedHandle >= 0)
                {

                    string c_cid = this.gridView6.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    lbl_id.Text = c_cid;
                    // txt_zjcls.Text = this.gridView6.GetRowCellValue(selectedHandle, "N_ZJCLS").ToString();
                    BindLcLsbGrid(c_cid);//加载炉次计划顺序
                    Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(c_cid);
                    minsort = bll_plan_sms.GetMinSort(lbl_id.Text);
                }


            }
            catch (Exception ex)
            {
                lbl_id.Text = "";
                BindLcLsbGrid("");//加载炉次计划顺序

            }
        }
        DateTime dt_jc_start_time = DateTime.Now;//查询的计划的开始时间
        int minsort = 1;
        private void btn_query_jc_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DateTime? D_STRAT_TIME = null;

                try
                {
                    bll_plan_sms.UpdateCCMTime(_strCCMID);
                    UpdateFinishJC(_strCCMID);
                    bll_plan_sms.UpdateJcSort();
                }
                catch (Exception ex)
                {


                }

                string dt = "";
                if (this.rbtn_status.SelectedIndex == 2)
                {
                    dt = this.dtp_start_date.Text.Trim();
                }
                BindLsbGrid(_strCCMID, this.rbtn_status.SelectedIndex + 1, dt);
                this.gridView6.FocusedRowHandle = jcRowHand;

                //try
                //{
                //    InitDrop();
                //    InitDrop_Lc();
                //}
                //catch (Exception ex)
                //{
                //}

                WaitingFrom.CloseWait();

                //  minsort = (int)sms_plan.Min(a => a.N_SORT);

            }
            catch (Exception ex)
            {

            }
        }
        private void UpdateALLLCTIME()
        {
            List<Mod_TSP_PLAN_SMS> list = bll_plan_sms.GetModelList("").Where(a => a.D_START_TIME_SJ != null).ToList();
            if (list.Count > 0)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].D_START_TIME_SJ != null)
                    {
                        list[j].D_P_START_TIME = list[j].D_START_TIME_SJ;
                        list[j].D_P_END_TIME = list[j].D_END_TIME_SJ;
                        bll_plan_sms.Update(list[j]);
                    }
                }
            }

        }


        /// <summary>
        /// 更新已完成炉次计划和对应的浇次计划的生产时间及状态（浇次计划状态为已下调度）
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        private void UpdateFinishJC(string C_CCM_ID)
        {
            #region MyRegion
            int n_lcsort = 0;
            DateTime? dt_b = null;//当前浇次的开始时间
            List<Mod_TSP_CAST_PLAN> litjc = bll_cast_plan.GetModelList(C_CCM_ID, 2, "").OrderBy(a => a.N_SORT).ToList();

            for (int i = 0; i < litjc.Count; i++)
            {
                Mod_TSP_CAST_PLAN modLastjc = bll_cast_plan.GetLastModel(litjc[i].C_CCM_ID, Convert.ToInt32(litjc[i].N_SORT));//上一个浇次计划
                List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(modLastjc.C_ID).OrderByDescending(a => a.N_SORT).ToList();

                try
                {
                    dt_b = Convert.ToDateTime(lstlc[0].D_P_END_TIME).AddHours(Convert.ToDouble(lstlc[0].N_PRODUCE_TIME));
                }
                catch (Exception ex)
                {


                }


                int jc_status = 0;//浇次计划生产状态
                List<Mod_TSP_PLAN_SMS> list = bll_plan_sms.GetModelListByJcID(litjc[i].C_ID).OrderBy(a => a.N_SORT).ToList();
                if (list.Count > 0)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j].D_START_TIME_SJ != null)
                        {
                            list[j].N_JC_SORT = litjc[i].N_SORT;//浇次序号
                            list[j].C_INITIALIZE_ITEM_ID = (n_lcsort + 1).ToString();
                            list[j].D_P_START_TIME = list[j].D_START_TIME_SJ;
                            list[j].D_P_END_TIME = list[j].D_END_TIME_SJ;
                            bll_plan_sms.Update(list[j]);
                            n_lcsort = n_lcsort + 1;
                            dt_b = Convert.ToDateTime(list[j].D_P_END_TIME).AddHours(Convert.ToDouble(list[j].N_PRODUCE_TIME));
                        }
                        else
                        {
                            list[j].D_P_START_TIME = dt_b;
                            list[j].D_P_END_TIME = Convert.ToDateTime(dt_b).AddHours(Convert.ToDouble(list[j].N_SLAB_WGT / list[j].N_JSCN));
                            bll_plan_sms.Update(list[j]);
                            dt_b = Convert.ToDateTime(list[j].D_P_END_TIME).AddHours(Convert.ToDouble(list[j].N_PRODUCE_TIME));
                        }
                    }

                    litjc[i].N_ZJCLS = list.Count;
                    litjc[i].N_ZJCLZL = list.Count * litjc[i].N_MLZL;
                    bll_cast_plan.Update(litjc[i]);
                }
                // btnFinishOrder(litjc[i].C_ID);
            }
            #endregion


            //DateTime d_start_time = RV.UI.ServerTime.timeNow();
            //DateTime d_end_time = RV.UI.ServerTime.timeNow();
            //List<Mod_TSP_CAST_PLAN> lstjc = bll_cast_plan.GetModelList(C_CCM_ID, null);
            //if (lstjc.Count > 0)
            //{

            //    for (int i = 0; i < lstjc.Count; i++)
            //    {
            //        List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(lstjc[i].C_ID);
            //        if (lstjc[i].N_STATUS == 3)
            //        {
            //            d_start_time = Convert.ToDateTime(lstlc.Min(a => a.D_P_START_TIME));
            //            d_end_time = Convert.ToDateTime(lstlc.Max(a => a.D_P_END_TIME));
            //            lstjc[i].D_P_START_TIME = d_start_time;
            //            lstjc[i].D_P_END_TIME = d_end_time.AddHours(Convert.ToDouble(lstjc[i].N_PRODUCE_TIME));
            //            d_end_time = Convert.ToDateTime(lstjc[i].D_P_END_TIME);

            //        }
            //        else
            //        {
            //            if (lstlc.Count > 0)
            //            {
            //                for (int j = 0; j < lstlc.Count; j++)
            //                {
            //                    if (lstlc[j].N_CREAT_PLAN < 4)
            //                    {

            //                    }
            //                }
            //            }
            //        }



            //    }
            //}

        }


        /// <summary>
        /// 更新已完成炉次计划和对应的浇次计划的生产时间及状态（浇次计划状态为已下调度）
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        private void UpdateFinish5CCM(int N_STATUS, DateTime? D_STRAT_TIME)
        {
            int n_lcsort = 0;
            List<Mod_TSP_CAST_PLAN> litjc = bll_cast_plan.GetModelList("77B9FDA79B884D07AA2B3601D1DA11A2", N_STATUS, "").OrderBy(a => a.N_SORT).ToList();
            if (D_STRAT_TIME == null)
            {
                D_STRAT_TIME = bll_plan_sms.GetModelListByJcID(litjc[0].C_ID).Where(a => a.D_P_START_TIME != null).Min(a => a.D_P_START_TIME);
            }

            for (int i = 0; i < litjc.Count; i++)
            {
                DateTime? D_P = D_STRAT_TIME;
                int jc_status = 0;//浇次计划生产状态
                List<Mod_TSP_PLAN_SMS> list = bll_plan_sms.GetModelListByJcID(litjc[i].C_ID).OrderBy(a => a.N_SORT).ToList();
                if (list.Count > 0)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j].D_START_TIME_SJ != null)
                        {
                            D_STRAT_TIME = list[j].D_END_TIME_SJ;
                        }
                        else
                        {
                            list[j].N_JC_SORT = litjc[i].N_SORT;//浇次序号
                            list[j].C_INITIALIZE_ITEM_ID = (n_lcsort + 1).ToString();
                            list[j].D_P_START_TIME = D_STRAT_TIME;
                            list[j].D_P_END_TIME = Convert.ToDateTime(D_STRAT_TIME).AddMinutes(38);
                            bll_plan_sms.Update(list[j]);
                            n_lcsort = n_lcsort + 1;
                            D_STRAT_TIME = list[j].D_P_END_TIME;
                        }

                    }

                    DateTime? D_E = D_STRAT_TIME;
                    litjc[i].D_P_START_TIME = D_P;
                    litjc[i].D_P_END_TIME = D_E;
                    litjc[i].N_ZJCLS = list.Count;
                    litjc[i].N_ZJCLZL = list.Count * litjc[i].N_MLZL;
                    bll_cast_plan.Update(litjc[i]);

                    D_STRAT_TIME = Convert.ToDateTime(D_STRAT_TIME).AddHours(Convert.ToDouble(litjc[i].N_PRODUCE_TIME));
                }
                btnFinishOrder(litjc[i].C_ID);
            }


        }



        /// <summary>
        /// 根据已经完成的炉次计划动态跟新未完成炉次计划的计划连铸生产时间
        /// </summary>
        /// <param name="C_CCM_ID">连铸机主键</param>
        private void UpdateLCPlanTime(string C_CCM_ID)
        {
            DateTime? d_last_end_time = null;//最新炉次计划的结束时间
            int jcsort = 0;
            List<Mod_TSP_PLAN_SMS> lstwc = bll_plan_sms.GetLCPlan(C_CCM_ID, 4).Where(a => a.D_END_TIME_SJ != null).OrderByDescending(a => a.D_END_TIME_SJ).ToList();
            if (lstwc.Count > 0)
            {
                d_last_end_time = Convert.ToDateTime(lstwc[0].D_END_TIME_SJ).AddHours(Convert.ToDouble(lstwc[0].N_PRODUCE_TIME));
                jcsort = (int)lstwc[0].N_JC_SORT;

                List<Mod_TSP_PLAN_SMS> lstwwc = bll_plan_sms.GetModelListByJcID(lstwc[0].C_FK).Where(a => a.D_START_TIME_SJ == null).OrderBy(a => a.N_SORT).ToList();
                for (int j = 0; j < lstwwc.Count; j++)
                {
                    if (d_last_end_time < RV.UI.ServerTime.timeNow().AddHours(-5))
                    {
                        d_last_end_time = RV.UI.ServerTime.timeNow();
                    }
                    lstwwc[j].D_P_START_TIME = d_last_end_time;
                    lstwwc[j].D_P_END_TIME = Convert.ToDateTime(d_last_end_time).AddHours(Convert.ToDouble(lstwwc[j].N_SLAB_WGT / lstwwc[j].N_JSCN));
                    d_last_end_time = Convert.ToDateTime(lstwwc[j].D_P_END_TIME).AddHours(Convert.ToDouble(lstwwc[j].N_PRODUCE_TIME));
                    bll_plan_sms.Update(lstwwc[j]);
                }
                Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(lstwc[0].C_FK);
                modjc.D_P_START_TIME = lstwwc.Min(a => a.D_P_START_TIME);
                modjc.D_P_END_TIME = d_last_end_time;
                bll_cast_plan.Update(modjc);
            }

            List<Mod_TSP_CAST_PLAN> lstjc = bll_cast_plan.GetModelListBySort(C_CCM_ID, jcsort).OrderBy(a => a.N_SORT).ToList();
            if (lstjc.Count > 0)
            {
                for (int i = 0; i < lstjc.Count; i++)
                {
                    if (d_last_end_time < RV.UI.ServerTime.timeNow().AddHours(-5))
                    {
                        d_last_end_time = RV.UI.ServerTime.timeNow();
                    }
                    lstjc[i].D_P_START_TIME = d_last_end_time;
                    List<Mod_TSP_PLAN_SMS> lstwwc = bll_plan_sms.GetModelListByJcID(lstjc[i].C_ID).OrderBy(a => a.N_SORT).ToList();
                    for (int j = 0; j < lstwwc.Count; j++)
                    {

                        lstwwc[j].D_P_START_TIME = d_last_end_time;
                        lstwwc[j].D_P_END_TIME = Convert.ToDateTime(d_last_end_time).AddHours(Convert.ToDouble(lstwwc[j].N_SLAB_WGT / lstwwc[j].N_JSCN));
                        d_last_end_time = Convert.ToDateTime(lstwwc[j].D_P_END_TIME).AddHours(Convert.ToDouble(lstwwc[j].N_PRODUCE_TIME));
                        bll_plan_sms.Update(lstwwc[j]);
                    }
                    lstjc[i].D_P_END_TIME = d_last_end_time;
                    bll_cast_plan.Update(lstjc[i]);

                }
            }

        }


        /// <summary>
        /// 是否人为指定时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_sfzd_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_sfzd.Checked)
            {
                if (this.dateEdit1.Text.Trim() == "")
                {
                    this.dateEdit1.Text = System.DateTime.Now.AddHours(0.5).ToString("yyyy-MM-dd hh:mm:ss");
                    MessageBox.Show("请指定计划的开始时间！");
                    this.chk_sfzd.Focus();
                }
                if (Convert.ToDateTime(this.dateEdit1.Text) < System.DateTime.Now)
                {
                    this.dateEdit1.Text = System.DateTime.Now.AddHours(0.5).ToString("yyyy-MM-dd hh:mm:ss");
                    MessageBox.Show("请指定计划的开始时间不能小于当前时间！");
                    this.chk_sfzd.Focus();
                }
            }
        }

        /// <summary>
        /// 保存浇次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveJcPlan_Click(object sender, EventArgs e)
        {
            try
            {
                //验证是否需要存档
                bll_plan_sms.UpdateLCJSCN();//更新机时产能
                bool isbc = false;
                for (int i = 0; i < jc_cast_plan.Count; i++)
                {

                    Mod_TSP_CAST_PLAN modjcyz = bll_cast_plan.GetModel(jc_cast_plan[i].C_ID);
                    if (jc_cast_plan[i].C_REMARK != modjcyz.C_REMARK || jc_cast_plan[i].N_SORT != modjcyz.N_SORT)
                    {
                        isbc = true;
                        break;
                    }
                }
                if (isbc)
                {
                    if (cbo_tz_remark.Text.Trim() == "")
                    {
                        MessageBox.Show("请输入计划调整的原因！");
                        return;
                    }

                    WaitingFrom.ShowWait("计划正在存档，请稍后...");


                    bll_cast_plan.P_LG_PLAN_REMARK("", txt_tz_remark.Text, RV.UI.UserInfo.userName, this.icbo_lz3.Properties.Items[icbo_lz3.SelectedIndex].Value.ToString(), "计划调整", cbo_tz_remark.Text);

                    WaitingFrom.ShowWait("计划正在存档，请稍候...");
                    string P_IP = Common.UserLog.GetLocalIP();
                    string P_OPER_CONTEXT = "计划调整";
                    string P_EMP_ID = RV.UI.UserInfo.userID;
                    string P_CCM_ID = "";
                    string P_TYPE = "计划调整";
                    string c_cd_no = bll_cast_plan.P_CD_LOG(P_IP, P_OPER_CONTEXT, P_EMP_ID, P_CCM_ID, P_TYPE);  //存档编号
                    if (c_cd_no != "0")
                    {
                        string res = bll_cast_plan.P_LG_PLAN_CD(c_cd_no, "计划调整", P_EMP_ID);
                    }

                    WaitingFrom.CloseWait();


                    WaitingFrom.CloseWait();

                }

                WaitingFrom.ShowWait("正在重新初始化浇次计划，请稍后...");
                string result1 = bll_plan_sms.P_INI_SMS();

                decimal minsort = Convert.ToDecimal(jc_cast_plan.Min(a => a.N_SORT));//获取当前未排计划的最小浇次序号;
                decimal minsortyp = minsort;
                for (int i = 0; i < jc_cast_plan.Count; i++)
                {
                    List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(jc_cast_plan[i].C_ID).Where(a => a.N_CREAT_PLAN > 1).ToList();
                    if (lstlc.Count > 0)
                    {
                        minsortyp = Convert.ToDecimal(jc_cast_plan[i].N_SORT);
                    }
                }
                WaitingFrom.CloseWait();
                if (minsortyp > minsort)
                {
                    MessageBox.Show("已经下发炉次计划的浇次计划顺序不能更改！");
                    return;
                }

                if (jc_cast_plan == null)
                {
                    return;
                }
                for (int i = 0; i < jc_cast_plan.Count; i++)
                {
                    Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(jc_cast_plan[i].C_ID);//实时查询数据库浇次信息
                    if (jc_cast_plan[i].N_STATUS != modjc.N_STATUS)
                    {
                        MessageBox.Show("系统数据有变化，请先查询后再进行保存！");
                        return;
                    }
                    if (jc_cast_plan[i].D_P_START_TIME == null || jc_cast_plan[i].N_SORT == null)
                    {
                        MessageBox.Show("请先生成排序后再保存计划！");
                        return;
                    }
                }
                if (chk_sfzd.Checked == true)
                {
                    if (this.dateEdit1.Text.Trim() == "")
                    {
                        MessageBox.Show("请输入指定的开始时间！");
                        return;
                    }
                    else
                    {
                        dt_jc_start_time = Convert.ToDateTime(this.dateEdit1.Text);
                        if (dt_jc_start_time < System.DateTime.Now)
                        {
                            MessageBox.Show("计划开始时间不能小于当前时间，请重新指定计划开始时间！");
                            return;
                        }
                    }
                }
                WaitingFrom.ShowWait("正在保存，请稍后...");
                string c_ccm = this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();
                jc_cast_plan = Sort_JC_plan(c_ccm, dt_jc_start_time, jc_cast_plan);//浇次计划刷新时间
                this.gridView6.RefreshData();

                for (int i = 0; i < jc_cast_plan.Count; i++)
                {


                    jc_cast_plan[i].C_BY3 = CheckLCPlanSort(jc_cast_plan[i].C_ID).ToString();//检查浇次计划能否下发

                    if (c_ccm == "77B9FDA79B884D07AA2B3601D1DA11A2")
                    {
                        jc_cast_plan[i].N_RH = GetUpdateJCRHNum(jc_cast_plan[i].C_ID);//更新5#连铸浇次过RH炉数
                    }

                    bll_cast_plan.Update(jc_cast_plan[i]);
                }
                if (c_ccm == "77B9FDA79B884D07AA2B3601D1DA11A2")//更新RH炉寿命
                {
                    UpdateRHNum(jc_cast_plan[0].C_ID);
                }
                Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "保存浇次计划");//添加操作日志
                string result = bll_plan_sms.P_SLAB_CAN_USETIMEG();//更新炉次计划的可用时间
                btn_query_jc_Click(null, null);
                MessageBox.Show("计划已保存！");

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 完成浇次计划
        /// </summary>
        public void btnFinishOrder(string C_JC_ID)
        {
            Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(C_JC_ID);

            List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(C_JC_ID);
            int a = lstlc.Count;
            if (a > 0)
            {
                int res = 0;
                for (int i = 0; i < a; i++)
                {
                    if (lstlc[i].N_CREAT_PLAN == 4)
                    {
                        res = res + 1;
                    }
                }
                if (a == res)
                {
                    modjc.N_STATUS = 3;
                    bll_cast_plan.Update(modjc);
                }
            }


        }



        /// <summary>
        /// 保存编辑的炉次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveLcPlan_Click(object sender, EventArgs e)
        {
            if (sms_plan == null)
            {
                return;
            }
            for (int i = 0; i < sms_plan.Count; i++)
            {
                Mod_TSP_PLAN_SMS mod = sms_plan[i];
                bll_plan_sms.Update(mod);
            }
            MessageBox.Show("计划已保存！");
        }




        private void btn_zjcls_Click(object sender, EventArgs e)
        {
            try
            {


                UpdateJCByLC(lbl_id.Text, "0");
                btn_query_jc_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_query_lcjh_Click(object sender, EventArgs e)
        {

        }


        private void rbtn_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtn_status.SelectedIndex == 1)
            {
                btn_cancle_plan.Enabled = true;
                btn_end_jc.Enabled = true;


                btnSaveJcPlan.Enabled = false;
            }
            else
            {
                btn_cancle_plan.Enabled = false;
                btn_end_jc.Enabled = false;


                btnSaveJcPlan.Enabled = true;
            }

            btn_query_jc_Click(null, null);
        }

        private void gridView6_DoubleClick(object sender, EventArgs e)
        {
            if (jc_cast_plan.Where(a => a.C_ID == lbl_id.Text).ToList().Count == 0)
            {
                return;
            }
            Point ms = Control.MousePosition;
            this.dplanl_tj.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            this.dplanl_tj.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dplanl_tj.FloatLocation = new System.Drawing.Point(ms.X, ms.Y);
            Mod_TSP_CAST_PLAN mod = jc_cast_plan.Where(a => a.C_ID == lbl_id.Text).ToList()[0];
            this.txt_tjsj.Text = mod.N_PRODUCE_TIME.ToString();
            this.txt_tj_remark.Text = mod.C_TJ_REMARK;
            this.txt_fzh.Text = mod.N_GROUP.ToString();

        }

        private void btn_save_tj_Click(object sender, EventArgs e)
        {
            var lst = jc_cast_plan.Where(a => a.C_ID == lbl_id.Text).ToList();
            if (lst.Count > 0)
            {
                lst[0].N_PRODUCE_TIME = Convert.ToDecimal(this.txt_tjsj.Text);
                lst[0].C_TJ_REMARK = this.txt_tj_remark.Text;
                lst[0].N_GROUP = Convert.ToDecimal(this.txt_fzh.Text);
                this.dplanl_tj.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }
        }

        /// <summary>
        /// 下发调度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_plan_xf_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_strCCMID))
                {
                    MessageBox.Show("请选择需要下发浇次计划的铸机！");
                    return;
                }

                Mod_TSP_CAST_PLAN model = bll_cast_plan.GetModel_XF(_strCCMID);
                List<Mod_TSP_PLAN_SMS> lst = bll_plan_sms.GetModelListByJcID(model.C_ID);
                string C_REMARK1 = "";
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].N_CREAT_PLAN < 4 && lst[i].D_P_START_TIME < RV.UI.ServerTime.timeNow().AddHours(-1))
                    {
                        MessageBox.Show("炉次计划连铸计划开始时间不正确，请重新保存后再下发！");
                        return;
                    }
                    string c_std_code = lst[i].C_STD_CODE;
                    if (lst[i].C_FREE2 == "SWRH77B~普通要求-11-16")
                    {
                        c_std_code = "普通要求-11-16";
                    }
                    if (lst[i].C_FREE2 == "SWRH77B~普通要求-5.5-10.5")
                    {
                        c_std_code = "普通要求-5.5-10.5";
                    }
                    DataTable dtlgjh = Cls_APS_PC.GetLGJH(c_std_code, lst[i].C_STL_GRD, lst[i].C_CCM_DESC);
                    if (dtlgjh.Rows.Count == 0)
                    {
                        C_REMARK1 = "没有炼钢记号！";
                        lst[i].C_REMARK1 = "没有炼钢记号！";

                        MessageBox.Show(lst[i].C_STD_CODE + "~" + lst[i].C_STL_GRD + "~" + lst[i].C_CCM_DESC + "没有炼钢记号！");
                        return;

                    }
                    else
                    {
                        lst[i].C_REMARK1 = "";
                    }
                    bll_plan_sms.Update(lst[i]);
                }


                if (model != null)
                {
                    if (model.D_P_START_TIME == null || model.N_SORT == null)
                    {
                        MessageBox.Show("请先对计划进行排序！");
                        return;
                    }
                    if (DialogResult.No == MessageBox.Show("确认下发" + model.C_REMARK + "的浇次计划给调度吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }

                    string result = bllTppLgPlan.CreatStaPlan(model.C_CCM_ID, model.C_ID);

                    if (result == "1")
                    {
                        MessageBox.Show("下发成功！");
                        BindLsbGrid(_strCCMID, this.rbtn_status.SelectedIndex + 1, "");
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
                }
                else
                {
                    MessageBox.Show("没有需要下发的浇次信息！");
                }

            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 取消调度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancle_plan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_strCCMID))
                {
                    MessageBox.Show("请选择需要取消调度的浇次计划的铸机！");
                    return;
                }

                List<Mod_TSP_CAST_PLAN> lst = ((List<Mod_TSP_CAST_PLAN>)gridView6.DataSource).ToList();

                int i_index = gridView6.FocusedRowHandle;

                if (lst.Count > 0)
                {
                    int count = bll_cast_plan.Get_YXF_Count(lst[i_index].C_CCM_ID, Convert.ToInt32(lst[i_index].N_SORT));

                    if (count > 0)
                    {
                        MessageBox.Show("该浇次不是最后一个下发的浇次信息，请按顺序撤回浇次信息！");
                        return;
                    }

                    Mod_TSP_CAST_PLAN model = bll_cast_plan.GetModel(lst[i_index].C_ID);

                    if (model == null)
                    {
                        MessageBox.Show("没有获取到浇次信息！");
                        return;
                    }

                    int num = bll_plan_sms.Get_Count(model.C_ID);
                    if (num > 0)
                    {
                        if (DialogResult.No == MessageBox.Show("" + model.C_CCM_CODE + "钢种为" + model.C_STL_GRD + "标准为" + model.C_STD_CODE + "的浇次计划，还有" + num + "炉未下发MES，确认从调度撤回吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                        {
                            return;
                        }

                        string result = bllTppLgPlan.Back_WXF(model.C_CCM_ID, model.C_ID);

                        if (result == "1")
                        {
                            MessageBox.Show("撤销成功！");
                            BindLsbGrid(_strCCMID, this.rbtn_status.SelectedIndex + 1, "");
                        }
                        else
                        {
                            MessageBox.Show(result);
                        }
                    }
                    else
                    {
                        MessageBox.Show("该浇次已全部下发MES，不能撤回，如需撤回，请先撤回下发到mes的炉次计划！");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("没有需要撤销的浇次信息！");
                }

            }
            catch (Exception)
            {

            }
        }


        DevExpress.Utils.AppearanceDefault appNotPass2 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Yellow, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);

        private void gridView7_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                string strResult = gridView7.GetRowCellValue(e.RowHandle, "N_CREAT_PLAN").ToString();
                if (strResult == "3")
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                }

            }
            catch
            {

            }
        }
        /// <summary>
        /// 调整浇次连铸机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_changeCCM_Click(object sender, EventArgs e)
        {
            if (this.icbo_lz3.EditValue == this.icbo_lz4.EditValue)
            {
                MessageBox.Show("请选择不同的连铸机进行调整！");
                return;
            }
            #region 验证当前浇次能否调整连铸（原则：浇次计划未排、所有炉次计划未排）
            Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(lbl_id.Text.Trim());
            if (modjc.N_STATUS != 1)
            {
                MessageBox.Show("当前浇次计划不能调整连铸！");
                return;
            }
            else
            {
                //验证当前浇次的炉次计划是否有下发的
                int ga = bll_plan_sms.GetModelListByJcID(lbl_id.Text.Trim()).Where(a => a.N_CREAT_PLAN > 1).ToList().Count;
                if (ga > 0)
                {
                    MessageBox.Show("当前浇次计划存在已下发的炉次计划，不能进行连铸机调整！");
                    return;
                }

            }


            #endregion

            if (DialogResult.No == MessageBox.Show("是否将当前选中的浇次计划调整到连铸：" + this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Description.ToString(), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            #region MyRegion


            //#region 3#\4#连铸可以调到3、4、6#连铸
            //if (this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Description == "3#铸机" || this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Description == "4#铸机")
            //{
            //    if (this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Description == "5#铸机" || this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Description == "7#铸机")
            //    {
            //        MessageBox.Show("该浇次计划不能调整到连铸：" + this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Description);
            //        return;
            //    }
            //}
            //#endregion
            ////获取目标连铸最大浇次序号
            //int max_jc_sort = bll_cast_plan.Max_jc_sort(this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Value.ToString());

            //Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(lbl_id.Text.Trim());
            //modjc.C_CCM_ID = this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Value.ToString();
            //modjc.C_CCM_CODE = this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Description.ToString();
            //modjc.N_SORT = max_jc_sort + 1;
            //int maxlcsort = bll_plan_sms.GetMaxSort(this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Value.ToString());//炉次计划最大序号
            //List<Mod_TSP_PLAN_SMS> lstsms = bll_plan_sms.GetModelListByJcID(modjc.C_ID).Where(a => a.N_CREAT_PLAN == 1).OrderBy(a => a.N_SORT).ToList();
            //for (int i = 0; i < lstsms.Count; i++)
            //{
            //    lstsms[i].C_CCM_ID = this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Value.ToString();
            //    lstsms[i].C_CCM_DESC = this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Description.ToString();
            //    lstsms[i].N_SORT = maxlcsort + 1 + i;
            //    lstsms[i].N_JC_SORT = modjc.N_SORT;
            //    bll_plan_sms.Update(lstsms[i]);
            //}
            //bll_cast_plan.Update(modjc);
            #endregion


            string res = ChangeCCM(lbl_id.Text.Trim(), this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Value.ToString(), "");

            MessageBox.Show(res);
            if (res == "选中计划已调整到目标连铸！")
            {
                //调整成功后将当前选中浇次停用

                Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "调整浇次连铸机", lbl_id.Text.Trim());//添加操作日志
                DeleteJCJH(lbl_id.Text.Trim());
                Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "调整连铸后删除浇次计划", lbl_id.Text.Trim());//添加操作日志
                btn_query_jc_Click(null, null);
                // btnSaveJcPlan_Click(null, null);
            }


        }



        private Bll_TB_STA bll_sta = new Bll_TB_STA();
        private Bll_TPB_SCLX bll_lx = new Bll_TPB_SCLX();
        private Bll_TPB_SLAB_CAPACITY bll_jscn = new Bll_TPB_SLAB_CAPACITY();
        private Bll_TB_MATRL_MAIN bll_wl = new Bll_TB_MATRL_MAIN();//物料信息表
        /// <summary>
        /// 调整浇次计划连铸信息
        /// </summary>
        /// <param name="c_id">浇次计划主键</param>
        /// <param name="c_ccm_id">调整后连铸主键</param>
        /// <param name="c_remark">调整说明</param>
        public string ChangeCCM(string c_id, string c_ccm_id, string c_remark)
        {
            #region 判断是否能够调整连铸
            bool flag = true;
            string Remark = "";
            Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(c_id);//待调整连铸的浇次计划
            List<Mod_TSP_PLAN_SMS> lstsms = bll_plan_sms.GetModelListByJcID(c_id);//当前浇次的炉次计划
            int maxjcsort = bll_cast_plan.Max_jc_sort(c_ccm_id) + 1;//目标连铸的浇次最大序号
            int maxlcsort = bll_plan_sms.GetMaxSort(c_ccm_id) + 1;//目标连铸的最大炉次序号
            Mod_TB_STA mod_sta = bll_sta.GetModel(c_ccm_id);
            Mod_TPB_SCLX modlx = bll_lx.GetModel(c_ccm_id);
            #region 验证
            int cou = lstsms.Where(a => a.N_CREAT_PLAN > 1).ToList().Count;//判断浇次计划是否有炉次计划已排产，有已排产炉次计划的浇次计划得先终止当前浇次计划后再调整连铸
            if (cou > 0)
            {
                flag = false;
                return "请先终止当前浇次计划后再调整连铸！";
            }

            //浇次计划必须在未排状态
            if (mod.N_STATUS != 1)
            {
                flag = false;
                return "浇次计划必须在未排状态进行调整！";
            }
            //不锈不能调
            if (mod.C_SLAB_TYPE == "不锈钢")
            {
                flag = false;
                return "不锈钢计划不能调整连铸！";
            }
            if (mod.C_CCM_ID == c_ccm_id)
            {
                flag = false;
                return "请选择需要调整的连铸！";
            }
            //有过RH炉计划的不能调
            if (mod.C_RH == "Y")
            {
                flag = false;
                return "过真空的浇次计划不能调整！";
            }
            #endregion

            //3#4#可互相调
            if ((mod.C_CCM_ID == "890EAA2949E743AFB26C06B8D4209B17" && c_ccm_id == "5263048C90B44B4D9934C513CE028250") || (mod.C_CCM_ID == "5263048C90B44B4D9934C513CE028250" && c_ccm_id == "890EAA2949E743AFB26C06B8D4209B17"))//浇次计划是3#、4#连铸的
            {

                Mod_TSP_CAST_PLAN mod_new = mod;
                mod_new.C_ID = System.Guid.NewGuid().ToString();
                mod_new.C_CCM_ID = c_ccm_id;
                mod_new.C_CCM_CODE = mod_sta.C_STA_DESC;
                mod_new.N_SORT = maxjcsort;
                if (bll_cast_plan.Add(mod_new))//添加新的浇次计划
                {
                    Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "浇次调整连铸生成新的浇次计划", mod_new.C_ID);//添加操作日志
                    //mod.N_STATUS = 0;
                    //bll_cast_plan.Update(mod);
                    //添加新的炉次计划
                    for (int i = 0; i < lstsms.Count; i++)
                    {
                        Mod_TSP_PLAN_SMS mod_sms_new = lstsms[i];
                        mod_sms_new.C_ID = System.Guid.NewGuid().ToString();
                        mod_sms_new.C_CCM_ID = c_ccm_id;
                        mod_sms_new.C_CCM_DESC = mod_sta.C_STA_DESC;
                        mod_sms_new.C_FK = mod_new.C_ID;
                        mod_sms_new.N_JC_SORT = maxjcsort;
                        mod_sms_new.N_SORT = maxlcsort + i;

                        mod_sms_new.C_ZL_ID = modlx.C_ZL;
                        mod_sms_new.C_LF_ID = modlx.C_LF;
                        mod_sms_new.C_RH_ID = modlx.C_RH;

                        mod_sms_new.C_EMP_ID = RV.UI.UserInfo.UserID;
                        bll_plan_sms.Add(mod_sms_new);
                        //lstsms[i].N_STATUS = 0;
                        //bll_plan_sms.Update(lstsms[i]);
                    }
                }

                return "选中计划已调整到目标连铸！";
            }
            //3#4#》6#连铸断面要变化
            else if ((mod.C_CCM_ID == "890EAA2949E743AFB26C06B8D4209B17" || mod.C_CCM_ID == "5263048C90B44B4D9934C513CE028250") && c_ccm_id == "01C145B259E740F6A258AF313DD9268C")
            {
                //判断断面是否需要变化，6#连铸机断面为150*150，如果没有150断面不允许调整
                #region 判断是否能够调整到6#连铸机进行生产


                //根据浇次计划按钢种、执行标准进行分组
                var sms_stl = lstsms
             .GroupBy(x => new { x.C_STL_GRD, x.C_STD_CODE, x.C_ROUTE })
             .Select(a => new
             {
                 STL_GRD = a.Key.C_STL_GRD,
                 STD_CODE = a.Key.C_STD_CODE,
                 ROUTE = a.Key.C_ROUTE
             }).ToList();
                for (int i = 0; i < sms_stl.Count; i++)
                {
                    string c_slab_size = "150*150";
                    DataTable dtCcmSlab = bll_wl.GetCCMSlab(sms_stl[i].STL_GRD, sms_stl[i].STD_CODE, sms_stl[i].ROUTE, c_slab_size);
                    if (dtCcmSlab.Rows.Count == 0)
                    {

                        return sms_stl[i].STL_GRD + "【" + sms_stl[i].STD_CODE + "】" + "没有断面为150*150的钢坯物料编码，请在NC维护后再调整！";

                    }
                }
                #endregion

                Mod_TSP_CAST_PLAN mod_new = mod;
                mod_new.C_ID = System.Guid.NewGuid().ToString();
                mod_new.C_CCM_ID = c_ccm_id;
                mod_new.C_CCM_CODE = mod_sta.C_STA_DESC;
                mod_new.N_SORT = maxjcsort;
                if (bll_cast_plan.Add(mod_new))//添加新的浇次计划
                {
                    Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "浇次调整连铸生成新的浇次计划", mod_new.C_ID);//添加操作日志
                    //mod.N_STATUS = 0;
                    //bll_cast_plan.Update(mod);
                    //添加新的炉次计划
                    for (int i = 0; i < lstsms.Count; i++)
                    {
                        Mod_TSP_PLAN_SMS mod_sms_new = lstsms[i];
                        mod_sms_new.C_ID = System.Guid.NewGuid().ToString();
                        mod_sms_new.C_CCM_ID = c_ccm_id;
                        mod_sms_new.C_CCM_DESC = mod_sta.C_STA_DESC;
                        mod_sms_new.C_FK = mod_new.C_ID;
                        mod_sms_new.N_JC_SORT = maxjcsort;
                        mod_sms_new.N_SORT = maxlcsort + i;

                        mod_sms_new.C_ZL_ID = modlx.C_ZL;
                        mod_sms_new.C_LF_ID = modlx.C_LF;
                        mod_sms_new.C_RH_ID = modlx.C_RH;
                        mod_sms_new.C_EMP_ID = RV.UI.UserInfo.UserID;

                        string c_slab_size = "150*150";
                        DataTable dtCcmSlab = bll_wl.GetCCMSlab(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, lstsms[i].C_ROUTE, c_slab_size);
                        if (dtCcmSlab.Rows.Count >= 0)
                        {
                            mod_sms_new.C_MATRL_NO = dtCcmSlab.Rows[0]["C_MAT_CODE"].ToString();
                            mod_sms_new.C_MATRL_NAME = dtCcmSlab.Rows[0]["C_MAT_NAME"].ToString();
                            mod_sms_new.C_SLAB_SIZE = dtCcmSlab.Rows[0]["C_SLAB_SIZE"].ToString();
                            mod_sms_new.C_SLAB_LENGTH = dtCcmSlab.Rows[0]["N_LTH"].ToString();
                            mod_sms_new.N_SLAB_PW = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_HSL"].ToString());

                        }

                        bll_plan_sms.Add(mod_sms_new);
                        //lstsms[i].N_STATUS = 0;
                        //bll_plan_sms.Update(lstsms[i]);
                    }
                }
                return "选中计划已调整到目标连铸！";

            }
            //6#》3#4#提示是否变化
            else if ((c_ccm_id == "890EAA2949E743AFB26C06B8D4209B17" || c_ccm_id == "5263048C90B44B4D9934C513CE028250") && mod.C_CCM_ID == "01C145B259E740F6A258AF313DD9268C")
            {
                //判断断面是否需要变化，6#连铸机断面为150*150，如果没有150断面不允许调整

                if (DialogResult.No == MessageBox.Show("是否需要系统将连铸钢坯断面自动调整为160*160！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {

                    Mod_TSP_CAST_PLAN mod_new = mod;
                    mod_new.C_ID = System.Guid.NewGuid().ToString();
                    mod_new.C_CCM_ID = c_ccm_id;
                    mod_new.C_CCM_CODE = mod_sta.C_STA_DESC;
                    mod_new.N_SORT = maxjcsort;
                    if (bll_cast_plan.Add(mod_new))//添加新的浇次计划
                    {
                        Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "浇次调整连铸生成新的浇次计划", mod_new.C_ID);//添加操作日志
                        //mod.N_STATUS = 0;
                        //bll_cast_plan.Update(mod);
                        //添加新的炉次计划
                        for (int i = 0; i < lstsms.Count; i++)
                        {
                            Mod_TSP_PLAN_SMS mod_sms_new = lstsms[i];
                            mod_sms_new.C_ID = System.Guid.NewGuid().ToString();
                            mod_sms_new.C_CCM_ID = c_ccm_id;
                            mod_sms_new.C_CCM_DESC = mod_sta.C_STA_DESC;
                            mod_sms_new.C_FK = mod_new.C_ID;
                            mod_sms_new.N_JC_SORT = maxjcsort;
                            mod_sms_new.N_SORT = maxlcsort + i;

                            mod_sms_new.C_ZL_ID = modlx.C_ZL;
                            mod_sms_new.C_LF_ID = modlx.C_LF;
                            mod_sms_new.C_RH_ID = modlx.C_RH;

                            mod_sms_new.C_EMP_ID = RV.UI.UserInfo.UserID;
                            bll_plan_sms.Add(mod_sms_new);
                            //lstsms[i].N_STATUS = 0;
                            //bll_plan_sms.Update(lstsms[i]);
                        }
                    }

                }
                else
                {
                    #region 判断是否能够调整到3#\4#连铸机进行生产


                    //根据浇次计划按钢种、执行标准进行分组
                    var sms_stl = lstsms
                 .GroupBy(x => new { x.C_STL_GRD, x.C_STD_CODE, x.C_ROUTE })
                 .Select(a => new
                 {
                     STL_GRD = a.Key.C_STL_GRD,
                     STD_CODE = a.Key.C_STD_CODE,
                     ROUTE = a.Key.C_ROUTE
                 }).ToList();
                    bool isChange = true;
                    for (int i = 0; i < sms_stl.Count; i++)
                    {
                        string c_slab_size = "160*160";
                        DataTable dtCcmSlab = bll_wl.GetCCMSlab(sms_stl[i].STL_GRD, sms_stl[i].STD_CODE, sms_stl[i].ROUTE, c_slab_size);
                        if (dtCcmSlab.Rows.Count == 0)
                        {
                            isChange = false;
                            return sms_stl[i].STL_GRD + "【" + sms_stl[i].STD_CODE + "】" + "没有断面为160*160的钢坯物料编码，请在NC维护后再调整！";

                        }
                    }
                    #endregion

                    Mod_TSP_CAST_PLAN mod_new = mod;
                    mod_new.C_ID = System.Guid.NewGuid().ToString();
                    mod_new.C_CCM_ID = c_ccm_id;
                    mod_new.C_CCM_CODE = mod_sta.C_STA_DESC;
                    mod_new.N_SORT = maxjcsort;
                    if (bll_cast_plan.Add(mod_new))//添加新的浇次计划
                    {
                        Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "浇次调整连铸生成新的浇次计划", mod_new.C_ID);//添加操作日志
                        //mod.N_STATUS = 0;
                        //bll_cast_plan.Update(mod);
                        //添加新的炉次计划
                        for (int i = 0; i < lstsms.Count; i++)
                        {
                            Mod_TSP_PLAN_SMS mod_sms_new = lstsms[i];
                            mod_sms_new.C_ID = System.Guid.NewGuid().ToString();
                            mod_sms_new.C_CCM_ID = c_ccm_id;
                            mod_sms_new.C_CCM_DESC = mod_sta.C_STA_DESC;
                            mod_sms_new.C_FK = mod_new.C_ID;
                            mod_sms_new.N_JC_SORT = maxjcsort;
                            mod_sms_new.N_SORT = maxlcsort + i;

                            mod_sms_new.C_ZL_ID = modlx.C_ZL;
                            mod_sms_new.C_LF_ID = modlx.C_LF;
                            mod_sms_new.C_RH_ID = modlx.C_RH;

                            mod_sms_new.C_EMP_ID = RV.UI.UserInfo.UserID;

                            string c_slab_size = "160*160";
                            DataTable dtCcmSlab = bll_wl.GetCCMSlab(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, lstsms[i].C_ROUTE, c_slab_size);
                            if (dtCcmSlab.Rows.Count >= 0)
                            {
                                mod_sms_new.C_MATRL_NO = dtCcmSlab.Rows[0]["C_MAT_CODE"].ToString();
                                mod_sms_new.C_MATRL_NAME = dtCcmSlab.Rows[0]["C_MAT_NAME"].ToString();
                                mod_sms_new.C_SLAB_SIZE = dtCcmSlab.Rows[0]["C_SLAB_SIZE"].ToString();
                                mod_sms_new.C_SLAB_LENGTH = dtCcmSlab.Rows[0]["N_LTH"].ToString();
                                mod_sms_new.N_SLAB_PW = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_HSL"].ToString());

                            }

                            bll_plan_sms.Add(mod_sms_new);
                            //lstsms[i].N_STATUS = 0;
                            //bll_plan_sms.Update(lstsms[i]);
                        }
                    }

                }

                return "选中计划已调整到目标连铸！";
            }
            //5#连铸调整到7#连铸或7#连铸调整到5#连铸
            else if ((mod.C_CCM_ID == "77B9FDA79B884D07AA2B3601D1DA11A2" && c_ccm_id == "B531146364EE43AFA7D84B5C8B7EE2FC") || (mod.C_CCM_ID == "B531146364EE43AFA7D84B5C8B7EE2FC" && c_ccm_id == "77B9FDA79B884D07AA2B3601D1DA11A2"))
            {
                DataTable dttz = bll_plan_sms.GetGroupPlan(c_id);
                decimal n_mlzl_e = 0;//调整后的炉次重量
                if (c_ccm_id == "77B9FDA79B884D07AA2B3601D1DA11A2")//5#连铸
                {
                    n_mlzl_e = 76;
                }
                else
                {
                    n_mlzl_e = 46;
                }
                if (dttz.Rows.Count > 0)
                {

                    Mod_TSP_CAST_PLAN mod_newjc = mod;
                    mod_newjc.C_ID = System.Guid.NewGuid().ToString();
                    mod_newjc.C_CCM_ID = c_ccm_id;
                    mod_newjc.C_CCM_CODE = mod_sta.C_STA_DESC;
                    mod_newjc.N_MLZL = n_mlzl_e;
                    mod_newjc.N_SORT = maxjcsort;
                    bll_cast_plan.Add(mod_newjc);
                    int sort = maxlcsort;
                    string remark = "";
                    decimal totalwgt = 0;
                    int totalls = 0;
                    for (int i = 0; i < dttz.Rows.Count; i++)
                    {
                        decimal n_slab_wgt = Convert.ToDecimal(dttz.Rows[i]["N_SLAB_WGT"].ToString());
                        int ls = (int)Math.Ceiling(n_slab_wgt / n_mlzl_e);
                        totalls = totalls + ls;
                        totalwgt = totalwgt + ls * n_mlzl_e;
                        if (remark.Trim() == "")
                        {
                            remark = dttz.Rows[i]["C_STL_GRD"].ToString() + "~" + dttz.Rows[i]["C_STD_CODE"].ToString() + "~" + ls.ToString();
                        }
                        else
                        {
                            remark = "\r\n" + dttz.Rows[i]["C_STL_GRD"].ToString() + "~" + dttz.Rows[i]["C_STD_CODE"].ToString() + "~" + ls.ToString();
                        }
                        Mod_TSP_PLAN_SMS mod_newlc = lstsms.Where(a => a.C_STL_GRD == dttz.Rows[i]["C_STL_GRD"].ToString() && a.C_STD_CODE == dttz.Rows[i]["C_STD_CODE"].ToString() && a.C_MATRL_NO == dttz.Rows[i]["C_MATRL_NO"].ToString()).ToList()[0];
                        for (int j = 0; j < ls; j++)
                        {
                            mod_newlc.C_ID = System.Guid.NewGuid().ToString();
                            mod_newlc.N_SLAB_WGT = n_mlzl_e;
                            mod_newlc.C_STATE = dttz.Rows[i]["C_STATE"].ToString();
                            mod_newlc.N_JC_SORT = mod_newjc.N_SORT;
                            mod_newlc.N_SORT = sort;
                            mod_newlc.C_FK = mod_newjc.C_ID;
                            mod_newlc.C_EMP_ID = RV.UI.UserInfo.userID;
                            mod_newlc.N_STATUS = 1;
                            mod_newlc.C_ZL_ID = modlx.C_ZL;
                            mod_newlc.C_LF_ID = modlx.C_LF;
                            mod_newlc.C_RH_ID = modlx.C_RH;
                            bll_plan_sms.Add(mod_newlc);
                            sort = sort + 1;
                        }
                    }

                    Mod_TSP_CAST_PLAN mod_newjc2 = bll_cast_plan.GetModel(mod_newjc.C_ID);
                    mod_newjc2.N_TOTAL_WGT = totalwgt;
                    mod_newjc2.N_ZJCLZL = totalwgt;
                    mod_newjc2.N_ZJCLS = totalls;
                    mod_newjc2.N_STATUS = 1;
                    mod_newjc2.C_REMARK = remark;
                    bll_cast_plan.Update(mod_newjc2);

                    Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "浇次调整连铸生成新的浇次计划", mod_newjc.C_ID);//添加操作日志
                }

                return "选中计划已调整到目标连铸！";
            }
            else
            {
                flag = false;
                return "请选择正确的连铸机！";
            }

            #endregion

        }

        /// <summary>
        /// 选中炉次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView7_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            int index = gridView7.FocusedRowHandle;
            if (index < 0)
            {
                return;
            }
            string C_STL_GRD = gridView7.GetRowCellValue(index, "C_STL_GRD").ToString();
            string C_STD_CODE = gridView7.GetRowCellValue(index, "C_STD_CODE").ToString();
            string C_ROUTE = gridView7.GetRowCellValue(index, "C_ROUTE").ToString();
            int N_GROUP = Convert.ToInt32(gridView7.GetRowCellValue(index, "N_GROUP").ToString());
            #region 加载可修改的物料信息
            string wllj = "";
            if (C_ROUTE.Contains("LF") && C_ROUTE.Contains("RH"))
            {
                wllj = "(BLR)";
            }
            if (C_ROUTE.Contains("LF") && !C_ROUTE.Contains("RH"))
            {
                wllj = "(BL)";
            }
            if (!C_ROUTE.Contains("LF") && C_ROUTE.Contains("RH"))
            {
                wllj = "(BR)";
            }
            DataTable dtgpwl = null;//bll_wl.GetGPWL( C_STL_GRD,  C_STD_CODE, "", wllj);
            if (C_ROUTE.Contains("KP"))
            {
                dtgpwl = bll_wl.GetGPWL(C_STL_GRD, "", null, "6", wllj, "大方坯连铸坯").Tables[0];
            }
            else
            {
                dtgpwl = bll_wl.GetGPWL(C_STL_GRD, "", null, "6", wllj, "小方坯连铸坯").Tables[0];
            }
            this.gridControl5.DataSource = dtgpwl;
            this.gridView5.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView5);
            this.gridView5.BestFitColumns();
            #endregion

            #region 加载同组的可以变更的炉次计划

            List<Mod_TSP_PLAN_SMS> lst = bll_plan_sms.GetListByJcGroup(N_GROUP);
            List<Mod_TSP_PLAN_SMS> lstkg = new List<Mod_TSP_PLAN_SMS>();
            var changelst = lst.Where(a => a.C_STL_GRD != C_STL_GRD || a.C_STD_CODE != C_STD_CODE).GroupBy(a => new { a.C_STD_CODE, a.C_STL_GRD, a.C_MATRL_NO }).ToList();
            if (changelst.Count > 0)
            {
                for (int i = 0; i < changelst.Count; i++)
                {
                    //  Mod_TSP_PLAN_SMS mod = bll_plan_sms.GetModelList();
                }
            }

            #endregion

        }

        private void gridView7_DoubleClick(object sender, EventArgs e)
        {

            int index = gridView7.FocusedRowHandle;
            if (index < 0)
            {
                return;
            }
            string C_STL_GRD = gridView7.GetRowCellValue(index, "C_STL_GRD").ToString();
            string C_STD_CODE = gridView7.GetRowCellValue(index, "C_STD_CODE").ToString();
            string C_ROUTE = gridView7.GetRowCellValue(index, "C_ROUTE").ToString();
            int N_GROUP = Convert.ToInt32(gridView7.GetRowCellValue(index, "N_GROUP").ToString());
            #region 加载可修改的物料信息
            string wllj = "";
            DataTable dtgpwl = null;
            if (C_ROUTE.Contains("KP"))
            {
                if (C_ROUTE.Contains("LF") && C_ROUTE.Contains("RH"))
                {
                    wllj = "(BLR)";
                }
                if (C_ROUTE.Contains("LF") && !C_ROUTE.Contains("RH"))
                {
                    wllj = "(BL)";
                }
                if (!C_ROUTE.Contains("LF") && C_ROUTE.Contains("RH"))
                {
                    wllj = "(BR)";
                }
                //bll_wl.GetGPWL( C_STL_GRD,  C_STD_CODE, "", wllj);
                dtgpwl = bll_wl.GetGPWL(C_STL_GRD, "", null, "6", wllj, "大方坯连铸坯").Tables[0];
            }
            else
            {
                dtgpwl = bll_wl.GetGPWL(C_STL_GRD, "", null, "6", wllj, "小方坯连铸坯").Tables[0];
            }
            this.gridControl5.DataSource = dtgpwl;
            this.gridView5.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView5);
            this.gridView5.BestFitColumns();
            #endregion

            #region 加载同组的可以变更的炉次计划

            List<Mod_TSP_PLAN_SMS> lst = bll_plan_sms.GetListByJcGroup(N_GROUP);
            List<Mod_TSP_PLAN_SMS> lstkg = new List<Mod_TSP_PLAN_SMS>();
            var changelst = lst.Where(a => a.N_GROUP == N_GROUP && (a.C_STL_GRD != C_STL_GRD || a.C_STD_CODE != C_STD_CODE)).GroupBy(a => new { a.C_STD_CODE, a.C_STL_GRD, a.C_MATRL_NO }).ToList();
            if (changelst.Count > 0)
            {
                for (int i = 0; i < changelst.Count; i++)
                {
                    Mod_TSP_PLAN_SMS mod = new Mod_TSP_PLAN_SMS();
                    mod.N_GROUP = changelst[i].First().N_GROUP;
                    mod.C_STD_CODE = changelst[i].First().C_STD_CODE;
                    mod.C_STL_GRD = changelst[i].First().C_STL_GRD;
                    mod.C_STL_GRD_TYPE = changelst[i].First().C_STL_GRD_TYPE;
                    mod.C_MATRL_NO = changelst[i].First().C_MATRL_NO;
                    mod.C_MATRL_NAME = changelst[i].First().C_MATRL_NAME;
                    mod.C_ROUTE = changelst[i].First().C_ROUTE;
                    mod.C_SLAB_SIZE = changelst[i].First().C_SLAB_SIZE;
                    mod.C_SLAB_LENGTH = changelst[i].First().C_SLAB_LENGTH;
                    mod.C_MATRL_CODE_KP = changelst[i].First().C_MATRL_CODE_KP;
                    mod.C_MATRL_NAME_KP = changelst[i].First().C_MATRL_NAME_KP;
                    mod.C_KP_SIZE = changelst[i].First().C_KP_SIZE;
                    mod.N_KP_LENGTH = changelst[i].First().N_KP_LENGTH;
                    mod.N_KP_PW = changelst[i].First().N_KP_PW;
                    mod.N_SLAB_PW = changelst[i].First().N_SLAB_PW;
                    mod.C_TL = changelst[i].First().C_TL;
                    mod.C_RH = changelst[i].First().C_RH;
                    mod.C_RH_ID = changelst[i].First().C_RH_ID;
                    mod.C_DFP_HL = changelst[i].First().C_DFP_HL;
                    mod.C_HL = changelst[i].First().C_HL;
                    mod.C_LF_ID = changelst[i].First().C_LF_ID;
                    mod.C_XM = changelst[i].First().C_XM;
                    mod.C_ZL_ID = changelst[i].First().C_ZL_ID;
                    mod.C_SL = changelst[i].First().C_SL;
                    mod.C_BY1 = changelst[i].First().C_BY1;
                    mod.C_WL = changelst[i].First().C_WL;
                    mod.C_BY2 = changelst[i].First().C_BY2;
                    mod.C_ORDER_NO = changelst[i].First().C_ORDER_NO;
                    mod.C_STATE = "1";
                    mod.C_STL_GRD_TYPE = changelst[i].First().C_STL_GRD_TYPE;
                    mod.C_PROD_NAME = changelst[i].First().C_PROD_NAME;
                    mod.C_PROD_KIND = changelst[i].First().C_PROD_KIND;
                    mod.C_FREE1 = changelst[i].First().C_FREE1;
                    mod.C_FREE2 = changelst[i].First().C_FREE2;
                    lstkg.Add(mod);
                }
            }

            #endregion
            this.gridControl1.DataSource = lstkg;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
        }

        private void btn_end_jc_Click(object sender, EventArgs e)
        {
            if (cbo_zz_remark.Text.Trim() == "" || txt_remark.Text.Trim() == "")
            {
                MessageBox.Show("请输入终止当前浇次计划的原因！");
                if (cbo_zz_remark.Text.Trim() == "")
                {
                    cbo_zz_remark.Focus();
                }
                else
                {
                    txt_remark.Focus();
                }
                return;
            }
            if (DialogResult.No == MessageBox.Show("是否终止当前选中的浇次计划,计划终止后将不能恢复！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {

                return;

            }
            //将当前选中的计划撤回，撤回浇次计划中炉次计划未下发MES的炉次计划
            Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(lbl_id.Text);//
            mod.C_TZ_REMARK = mod.C_TZ_REMARK.Trim() == "" ? txt_remark.Text : mod.C_TZ_REMARK.Trim() + "；" + txt_remark.Text + "[" + RV.UI.ServerTime.timeNow() + "]";
            mod.D_PLAN_KY_TIME = RV.UI.ServerTime.timeNow();//计划终止或删除时间
            //终止计划
            if (cbo_zz_remark.Text.Trim() != "")
            {
                //记录终止计划原因
                bll_cast_plan.P_LG_PLAN_REMARK(lbl_id.Text, txt_remark.Text, RV.UI.UserInfo.userName, this.icbo_lz3.Properties.Items[icbo_lz3.SelectedIndex].Value.ToString(), "终止计划", cbo_zz_remark.Text.Trim());
            }

            //string remark = "";
            //int RHLS = 0;
            //int dhl = 0;
            //int hl = 0;
            //int xm = 0;

            int n_max_sort = bll_cast_plan.Max_jc_sort(mod.C_CCM_ID);
            //获取当前浇次计划已经投放MES的炉次计划数量
            var lstlc = bll_plan_sms.GetModelListByJcID(lbl_id.Text);//当前浇次的炉次计划

            var lstlc2 = bll_plan_sms.GetModelListByJcID(lbl_id.Text).Where(a => a.N_CREAT_PLAN <= 2).ToList();//可以终止的浇次计划

            if (lstlc2.Count > 0 && lstlc2.Count < lstlc.Count)//判断当前浇次是否可以终止
            {
                Mod_TSP_CAST_PLAN mod_new = mod;
                mod_new.C_ID = System.Guid.NewGuid().ToString();
                mod_new.N_SORT = n_max_sort + 1;
                mod_new.N_STATUS = 1;
                bll_cast_plan.Add(mod_new);//添加新增浇次计划
                for (int i = 0; i < lstlc.Count; i++)
                {
                    if (lstlc[i].N_CREAT_PLAN == 1 || lstlc[i].N_CREAT_PLAN == 2)
                    {
                        lstlc[i].N_STATUS = 0;
                        lstlc[i].C_REMARK2 = "终止计划，原因：" + txt_remark.Text.Trim();
                        if (lstlc[i].N_CREAT_PLAN == 1)
                        {
                            bll_plan_sms.Update(lstlc[i]);
                            Mod_TSP_PLAN_SMS modlc_new = lstlc[i];
                            modlc_new.C_ID = System.Guid.NewGuid().ToString();
                            modlc_new.N_STATUS = 1;
                            modlc_new.N_CREAT_PLAN = 1;
                            modlc_new.C_FK = mod_new.C_ID;
                            bll_plan_sms.Add(modlc_new);
                        }
                        if (lstlc[i].N_CREAT_PLAN == 2)
                        {
                            if (bll_tpp_cast_plan.DeletePlan(lstlc[i].C_ID))
                            {
                                bll_plan_sms.Update(lstlc[i]);
                                Mod_TSP_PLAN_SMS modlc_new = lstlc[i];
                                modlc_new.C_ID = System.Guid.NewGuid().ToString();
                                modlc_new.N_STATUS = 1;
                                modlc_new.N_CREAT_PLAN = 1;
                                modlc_new.C_FK = mod_new.C_ID;
                                bll_plan_sms.Add(modlc_new);
                            }
                        }
                    }
                }

                var sms_plan2 = bll_plan_sms.GetModelListByJcID(lbl_id.Text);

                for (int i = 0; i < sms_plan2.Count; i++)
                {
                    sms_plan2[i].N_SORT = minsort + i + 1;
                    bll_plan_sms.Update(sms_plan2[i]);
                }

                UpdateJCByLC(this.lbl_id.Text, "1");

                //  UpdateFinishJC(_strCCMID);//将浇次计划标记为完成
                Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "终止浇次计划");//添加操作日志
                btn_query_jc_Click(null, null);
            }
            else if (lstlc2.Count == 0)
            {
                UpdateJCByLC(this.lbl_id.Text, "1");
                Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "终止浇次计划");//添加操作日志
                btn_query_jc_Click(null, null);
            }
            else
            {
                MessageBox.Show("当前浇次计划不能终止！");
                return;
            }
        }
        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sort_Click(object sender, EventArgs e)
        {
            string c_ccm = this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();
            List<Mod_TSP_CAST_PLAN> lstplan = new List<Mod_TSP_CAST_PLAN>();
            lstplan = bll_cast_plan.GetModelList(c_ccm, null, "");
            for (int i = 0; i < lstplan.Count; i++)
            {
                UpdateJCByLC(lstplan[i].C_ID, "0");
            }

            for (int i = 0; i < lstplan.Count; i++)
            {
                List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(lstplan[i].C_ID);
                if (lstlc.Count > 0)
                {
                    for (int j = 0; j < lstlc.Count; j++)//更新炉次计划的过程时间
                    {
                        decimal d_time = 2;
                        if (lstlc[j].C_DFP_HL != "N")
                        {
                            d_time = d_time + 2 + lstlc[j].N_DFP_HL_TIME;
                        }
                        if (lstlc[j].C_XM == "Y" && lstlc[j].C_DFP_HL != "N")
                        {
                            d_time = d_time + 24 + 5;
                        }
                        if (lstlc[j].C_KP == "Y")
                        {
                            d_time = d_time + 5;
                        }

                        if (lstlc[j].C_HL != "N")
                        {
                            d_time = d_time + 2 + lstlc[j].N_HL_TIME;
                        }
                        lstlc[j].D_CAN_USE_TIME = Convert.ToDateTime(lstlc[j].D_P_END_TIME).AddHours(Convert.ToDouble(d_time));
                        bll_plan_sms.Update(lstlc[j]);
                    }
                }
            }
        }

        #region ComputationProcessTime重新计算工序时间

        #region 按连铸刷新浇次计划时间
        /// <summary>
        /// 按连铸机更新浇次计划（序号、时间）
        /// </summary>
        /// <param name="C_CCM"></param>
        public void UpdateJCByCCM(string C_CCM)
        {
            int maxjcsort = bll_cast_plan.Max_jc_sortbywc(C_CCM);

            //首先将未完成浇次计划的已完成的炉次计划时间进行更新
            List<Mod_TSP_CAST_PLAN> lstplan = new List<Mod_TSP_CAST_PLAN>();
            lstplan = bll_cast_plan.GetListWWC(C_CCM);
            DateTime? d_start = null;//计划开始时间
            DateTime? d_end = null;//计划结束时间

            for (int i = 0; i < lstplan.Count; i++)
            {
                lstplan[i].N_SORT = maxjcsort + i + 1;
                bll_cast_plan.Update(lstplan[i]);
                List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(lstplan[i].C_ID);
                if (lstlc.Count > 0)
                {
                    for (int j = 0; j < lstlc.Count; j++)//更新炉次计划的过程时间
                    {
                        //if (lstlc[j].N_CREAT_PLAN < 4)
                        //{

                        lstlc[j].N_JC_SORT = lstplan[i].N_SORT;
                        if (lstlc[j].D_START_TIME_SJ != null)
                        {
                            lstlc[j].D_P_START_TIME = lstlc[j].D_START_TIME_SJ;
                        }
                        if (lstlc[j].D_END_TIME_SJ != null)
                        {
                            lstlc[j].D_P_END_TIME = lstlc[j].D_END_TIME_SJ;
                        }
                        decimal d_time = 2;
                        if (lstlc[j].C_DFP_HL != "N")
                        {
                            d_time = d_time + 2 + lstlc[j].N_DFP_HL_TIME;
                        }
                        if (lstlc[j].C_XM == "Y" && lstlc[j].C_DFP_HL != "N")
                        {
                            d_time = d_time + 2 + 1;
                        }
                        else
                        {
                            d_time = d_time + 12 + 1;
                        }
                        if (lstlc[j].C_HL != "N")
                        {
                            d_time = d_time + 2 + lstlc[j].N_HL_TIME;
                        }
                        lstlc[j].D_CAN_USE_TIME = Convert.ToDateTime(lstlc[j].D_P_END_TIME).AddHours(Convert.ToDouble(d_time));
                        bll_plan_sms.Update(lstlc[j]);
                        //}

                    }
                }


            }

            for (int i = 0; i < lstplan.Count; i++)
            {
                UpdateJCByLC(lstplan[i].C_ID, "0");

            }




        }

        #endregion

        #region 刷新已排产完工时间

        #endregion

        #endregion

        /// <summary>
        /// 确定调整钢种
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tzgz_Click(object sender, EventArgs e)
        {

            int index = gridView7.FocusedRowHandle;
            if (index < 0)
            {
                return;
            }
            string C_STL_GRD = gridView7.GetRowCellValue(index, "C_STL_GRD").ToString();
            string C_STD_CODE = gridView7.GetRowCellValue(index, "C_STD_CODE").ToString();
            string C_ROUTE = gridView7.GetRowCellValue(index, "C_ROUTE").ToString();
            int N_GROUP = Convert.ToInt32(gridView7.GetRowCellValue(index, "N_GROUP").ToString());
            string C_STATE = gridView7.GetRowCellValue(index, "C_STATE").ToString();
            if (C_STATE == "1")//当前选中计划是非计划炉次计划
            {

            }
            else//当前选中计划是有计划炉次计划
            {

            }
        }


        private void btn_out1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl6, "浇次计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void btn_out2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl7, "炉次计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void btn_save_lc_Click(object sender, EventArgs e)
        {
            //
            WaitingFrom.ShowWait("正在保存，请稍后...");
            if (sms_plan.Count > 0)
            {
                for (int i = 0; i < sms_plan.Count; i++)
                {
                    //DataTable dtdown = bll_plan_sms.GetDownPlan(sms_plan[i].C_ID);
                    //if (dtdown.Rows.Count == 0)
                    //{
                    //    // int maxsort = bll_plan_sms.GetMaxSortYXMES(sms_plan[i].C_CCM_ID);
                    //    Mod_TSP_PLAN_SMS modlc = bll_plan_sms.GetModel(sms_plan[i].C_ID);
                    //    // if (sms_plan[i].N_CREAT_PLAN < 3 && modlc.N_CREAT_PLAN == sms_plan[i].N_CREAT_PLAN)//没有下发MES并状态和数据库状态一致才能修改
                    //    if (modlc.N_CREAT_PLAN == sms_plan[i].N_CREAT_PLAN)//没有下发MES并状态和数据库状态一致才能修改
                    //    {
                    //if (maxsort < sms_plan[i].N_SORT)
                    //{
                    bll_plan_sms.Update(sms_plan[i]);
                    //}
                    //}


                    //}

                }
                MessageBox.Show("数据已保存！");
            }
            WaitingFrom.CloseWait();
        }

        #region 撤回连铸所有未下调度的炉次计划和浇次计划，连铸主键为空时撤回所有未下调度的计划
        /// <summary>
        /// 撤回所有未排产的浇次计划
        /// </summary>
        /// <param name="C_ID">浇次计划主键</param>
        public string DeleteJCJH(string C_ID)
        {

            Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(C_ID);

            List<Mod_TSP_PLAN_SMS> lstlc1 = bll_plan_sms.GetModelListByJcID(modjc.C_ID);
            if (lstlc1.Count == 0)
            {

                modjc.N_STATUS = 0;
                modjc.D_PLAN_KY_TIME = RV.UI.ServerTime.timeNow();
                bll_cast_plan.Update(modjc);
                Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "删除浇次计划", modjc.C_ID);//添加操作日志
                //bool res = bll_cast_plan.Delete(modjc.C_ID);
            }

            List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(modjc.C_ID).Where(a => a.N_CREAT_PLAN == 1).ToList();
            if (lstlc.Count > 0)
            {
                for (int j = 0; j < lstlc.Count; j++)
                {
                    lstlc[j].N_STATUS = 0;
                    lstlc[j].C_REMARK2 = "删除浇次计划";
                    bll_plan_sms.Update(lstlc[j]);
                    Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "删除浇次计划-炉次计划删除", modjc.C_ID);//添加操作日志
                }
                if (bll_plan_sms.GetModelListByJcID(modjc.C_ID).Where(a => a.N_CREAT_PLAN > 1).ToList().Count == 0)
                {
                    modjc.N_STATUS = 0;
                    bll_cast_plan.Update(modjc);
                    Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "删除浇次计划", modjc.C_ID);//添加操作日志
                    //bool res = bll_cast_plan.Delete(modjc.C_ID);
                }
                else
                {
                    modjc.N_ZJCLS = bll_plan_sms.GetModelListByJcID(modjc.C_ID).Where(a => a.N_CREAT_PLAN > 1).ToList().Count;
                    bll_cast_plan.Update(modjc);
                    Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "删除浇次计划-剩余炉次计划数：" + modjc.N_ZJCLS, modjc.C_ID);//添加操作日志
                }
                return "已删除当前浇次未下调度的炉次计划！";
            }
            else
            {
                return "当前浇次已经下发调度，不能删除！";
            }


        }
        #endregion

        /// <summary>
        /// 删除浇次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_plan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_strCCMID))
            {
                MessageBox.Show("请选择连铸机！");
                return;
            }

            WaitingFrom.ShowWait("");
            if (radioGroup3.SelectedIndex == 0)
            {
                if (DialogResult.No == MessageBox.Show("是否删除当前选中的浇次及其对应的炉次计划！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                DeleteJCJH(lbl_id.Text.Trim());
                Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "删除浇次计划", lbl_id.Text.Trim());//添加操作日志
            }
            else
            {
                if (DialogResult.No == MessageBox.Show("是否删除当前连铸所有未排的浇次计划及对应的炉次计划！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                for (int i = 0; i < jc_cast_plan.Count; i++)
                {
                    List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(jc_cast_plan[i].C_ID).Where(a => a.N_CREAT_PLAN > 1).ToList();
                    if (lstlc.Count == 0)
                    {
                        DeleteJCJH(jc_cast_plan[i].C_ID);
                        Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "删除浇次计划", lbl_id.Text.Trim());//添加操作日志
                    }

                }
            }

            WaitingFrom.CloseWait();
            btn_query_jc_Click(null, null);
        }


        /// <summary>
        /// 添加当前浇次的炉次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_lc_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("数据正在加载，请稍后。。。");
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            int index = gridView6.FocusedRowHandle;
            if (index < 0)
            {
                WaitingFrom.CloseWait();
                return;
            }
            Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(lbl_id.Text.Trim());
            if (modjc.N_STATUS != 1)
            {
                MessageBox.Show("请先将本浇次取消调度后再添加炉次计划！");
                WaitingFrom.CloseWait();
                return;
            }
            int index2 = gridView7.FocusedRowHandle;
            // int N_GROUP = (int)modjc.N_GROUP;
            string C_CCM_ID = modjc.C_CCM_ID;
            int N_GROUP = Convert.ToInt32(gridView7.GetRowCellValue(index2, "N_GROUP").ToString());
            //string C_CCM_ID = gridView7.GetRowCellValue(index, "C_CCM_ID").ToString();
            string D_DT_B = Convert.ToDateTime(modjc.D_ZZ_START_TIME).ToString("yyyy-MM-dd");
            string D_DT_E = Convert.ToDateTime(modjc.D_ZZ_END_TIME).ToString("yyyy-MM-dd");
            int SFWC = 0;
            DataTable dt = Cls_APS_PC.GetOrderiNFO(N_GROUP, C_CCM_ID, SFWC, D_DT_B, D_DT_E);
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
            WaitingFrom.CloseWait();

        }

        // private Bll_TPB_SCLX bll_lx = new Bll_TPB_SCLX();

        /// <summary>
        /// 根据组号生成可增加或调整的炉次计划
        /// </summary>
        /// <param name="N_GROUP">浇次分组号</param>
        /// <param name="C_CCM_ID">连铸机主键</param>
        /// <returns>可增加的浇次计划</returns>
        public List<Mod_TSP_PLAN_SMS> MakeSmsPlanByGroupNo(int N_GROUP, string C_CCM_ID)
        {
            List<Mod_TSP_PLAN_SMS> lstsms = new List<Mod_TSP_PLAN_SMS>();
            DataTable lsttrp = bll_trp_pan.GetListByGroup(N_GROUP, C_CCM_ID);

            if (lsttrp.Rows.Count > 0)
            {
                for (int i = 0; i < lsttrp.Rows.Count; i++)
                {
                    Mod_TSP_PLAN_SMS mod = new Mod_TSP_PLAN_SMS();
                    mod.C_ORDER_NO = lsttrp.Rows[i]["C_INITIALIZE_ITEM_ID"].ToString();
                    mod.C_HL = lsttrp.Rows[i]["C_SFHL"].ToString();
                    mod.C_DFP_HL = lsttrp.Rows[i]["C_SFHL_D"].ToString();
                    mod.C_XM = lsttrp.Rows[i]["C_SFXM"].ToString();
                    mod.C_MATRL_NO = lsttrp.Rows[i]["C_MATRL_CODE_SLAB"].ToString();
                    mod.C_MATRL_NAME = lsttrp.Rows[i]["C_MATRL_NAME_SLAB"].ToString();
                    mod.C_SLAB_SIZE = lsttrp.Rows[i]["C_SLAB_SIZE"].ToString();
                    mod.C_SLAB_LENGTH = lsttrp.Rows[i]["N_SLAB_LENGTH"].ToString();
                    mod.N_SLAB_PW = Convert.ToDecimal(lsttrp.Rows[i]["N_SLAB_PW"]);
                    mod.C_ROUTE = lsttrp.Rows[i]["C_ROUTE"].ToString();
                    mod.C_STL_GRD = lsttrp.Rows[i]["C_STL_GRD_SLAB"].ToString();
                    mod.C_STD_CODE = lsttrp.Rows[i]["C_STD_CODE_SLAB"].ToString();
                    mod.C_MATRL_CODE_KP = lsttrp.Rows[i]["C_MATRL_CODE_KP"].ToString();
                    mod.C_MATRL_NAME_KP = lsttrp.Rows[i]["C_MATRL_NAME_KP"].ToString();
                    mod.C_KP_SIZE = lsttrp.Rows[i]["C_KP_SIZE"].ToString();
                    mod.N_KP_LENGTH = Convert.ToDecimal(lsttrp.Rows[i]["N_KP_LENGTH"]);
                    mod.N_KP_PW = Convert.ToDecimal(lsttrp.Rows[i]["N_KP_PW"]);
                    mod.N_GROUP = Convert.ToDecimal(lsttrp.Rows[i]["N_GROUP"]);
                    mod.C_SL = lsttrp.Rows[i]["C_SL"].ToString();
                    mod.C_WL = lsttrp.Rows[i]["C_WL"].ToString();
                    mod.N_JSCN = Convert.ToDecimal(lsttrp.Rows[i]["N_MACH_WGT_CCM"].ToString() == "" ? "88" : lsttrp.Rows[i]["N_MACH_WGT_CCM"].ToString());
                    mod.N_ZJCLS = Convert.ToDecimal(lsttrp.Rows[i]["N_ZJCLS"]);
                    mod.C_BY1 = lsttrp.Rows[i]["C_BY1"].ToString();
                    mod.C_BY2 = lsttrp.Rows[i]["C_BY2"].ToString();
                    mod.C_BY3 = lsttrp.Rows[i]["C_BY3"].ToString();
                    mod.C_DFP_RZ = (lsttrp.Rows[i]["C_DFP_RZ"].ToString() == "" || lsttrp.Rows[i]["C_DFP_RZ"].ToString() == "否") ? "N" : "Y";
                    mod.C_RZP_RZ = (lsttrp.Rows[i]["C_RZP_RZ"].ToString() == "" || lsttrp.Rows[i]["C_RZP_RZ"].ToString() == "否") ? "N" : "Y";
                    mod.C_DFP_YQ = lsttrp.Rows[i]["C_DFP_YQ"].ToString();
                    mod.C_RZP_YQ = lsttrp.Rows[i]["C_RZP_YQ"].ToString();
                    mod.C_CCM_DESC = lsttrp.Rows[i]["C_CCM_CODE"].ToString();
                    mod.C_TL = lsttrp.Rows[i]["C_TL"].ToString();
                    mod.N_ZJCLS_MIN = Convert.ToDecimal(lsttrp.Rows[i]["N_ZJCLS_MIN"]);
                    mod.N_ZJCLS_MAX = Convert.ToDecimal(lsttrp.Rows[i]["N_ZJCLS_MAX"]);
                    mod.C_STL_GRD_TYPE = lsttrp.Rows[i]["C_STL_GRD_TYPE"].ToString();
                    mod.C_PROD_NAME = lsttrp.Rows[i]["C_PROD_NAME"].ToString();
                    mod.C_PROD_KIND = lsttrp.Rows[i]["C_PROD_KIND"].ToString();
                    mod.C_RH = lsttrp.Rows[i]["C_RH"].ToString();
                    mod.C_DFP_HL = lsttrp.Rows[i]["C_DFP_HL"].ToString();
                    mod.C_HL = lsttrp.Rows[i]["C_HL"].ToString();
                    mod.C_XM = lsttrp.Rows[i]["C_XM"].ToString();
                    mod.C_CCM_ID = lsttrp.Rows[i]["C_CCM_ID"].ToString();
                    mod.N_HL_TIME = Convert.ToDecimal(lsttrp.Rows[i]["N_HL_TIME"]);
                    mod.N_DFP_HL_TIME = Convert.ToDecimal(lsttrp.Rows[i]["N_DFP_HL_TIME"]);
                    //mod.C_LF = lsttrp.Rows[i]["C_LF"].ToString();
                    //mod.C_KP = lsttrp.Rows[i]["C_KP"].ToString();
                    mod.C_STATE = "1";
                    Mod_TPB_SCLX modlx = bll_lx.GetModel(mod.C_CCM_ID);
                    mod.C_ZL_ID = modlx.C_ZL;
                    mod.C_LF_ID = modlx.C_LF;
                    mod.C_RH_ID = modlx.C_RH;
                    lstsms.Add(mod);
                }
            }

            return lstsms;

        }
        /// <summary>
        /// 添加炉次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tzgz_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认添加当前选中的炉次计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            // this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            int index = gridView7.FocusedRowHandle;
            if (index < 0)
            {
                return;
            }
            Mod_TSP_PLAN_SMS modchange = null;
            // Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(lbl_id.Text.Trim());

            int rowhandle = gridView1.FocusedRowHandle;

            string C_STL_GRD = gridView1.GetRowCellValue(rowhandle, "C_STL_GRD_SLAB").ToString();
            string C_STD_CODE = gridView1.GetRowCellValue(rowhandle, "C_STD_CODE_SLAB").ToString();
            string C_BY1 = gridView1.GetRowCellValue(rowhandle, "C_BY1").ToString();
            string C_BY2 = gridView1.GetRowCellValue(rowhandle, "C_BY2").ToString();
            string C_MATRL_CODE_SLAB = gridView1.GetRowCellValue(rowhandle, "C_MATRL_CODE_SLAB").ToString();


            WaitingFrom.ShowWait("");
            int rowhandle2 = gridView7.FocusedRowHandle;
            int N_GROUP = Convert.ToInt32(gridView7.GetRowCellValue(rowhandle2, "N_GROUP").ToString());
            //int N_JC_SORT = Convert.ToInt32(gridView7.GetRowCellValue(rowhandle2, "N_JC_SORT").ToString());//浇次序号
            // Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(this.lbl_id.Text);

            Cls_APS_PC.AddLCJH(C_STL_GRD, C_STD_CODE, C_BY1, C_BY2, C_MATRL_CODE_SLAB, this.lbl_id.Text, Convert.ToInt32(this.txt_add_ls.Text));
            Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "添加炉次计划", this.lbl_id.Text);//添加操作日志
            this.txt_add_ls.Text = "";
            memoEdit1.Text = "";
            UpdateJCByLC(this.lbl_id.Text, "0");
            // btn_sort_Click(null,null);
            btn_query_jc_Click(null, null);
            WaitingFrom.CloseWait();
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }
        /// <summary>
        /// 修改物料信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_wl_Click(object sender, EventArgs e)
        {
            dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;

            int index = gridView7.FocusedRowHandle;
            if (index < 0)
            {
                return;
            }
            string C_STL_GRD = gridView7.GetRowCellValue(index, "C_STL_GRD").ToString();
            string C_STD_CODE = gridView7.GetRowCellValue(index, "C_STD_CODE").ToString();
            string C_ROUTE = gridView7.GetRowCellValue(index, "C_ROUTE").ToString();
            int N_GROUP = Convert.ToInt32(gridView7.GetRowCellValue(index, "N_GROUP").ToString());

            #region 加载可修改的物料信息
            string wllj = "";
            DataTable dtgpwl = null;
            if (C_ROUTE.Contains("KP"))
            {
                if (C_ROUTE.Contains("LF") && C_ROUTE.Contains("RH"))
                {
                    wllj = "(BLR)";
                }
                if (C_ROUTE.Contains("LF") && !C_ROUTE.Contains("RH"))
                {
                    wllj = "(BL)";
                }
                if (!C_ROUTE.Contains("LF") && C_ROUTE.Contains("RH"))
                {
                    wllj = "(BR)";
                }
                //bll_wl.GetGPWL( C_STL_GRD,  C_STD_CODE, "", wllj);
                dtgpwl = bll_wl.GetGPWL(C_STL_GRD, "", null, "6", wllj, "大方坯连铸坯").Tables[0];
            }
            else
            {
                dtgpwl = bll_wl.GetGPWL(C_STL_GRD, "", null, "6", wllj, "小方坯连铸坯").Tables[0];
            }
            this.gridControl5.DataSource = dtgpwl;
            this.gridView5.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView5);
            this.gridView5.BestFitColumns();
            #endregion
        }
        /// <summary>
        /// 修改物料信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tzwl_Click_1(object sender, EventArgs e)
        {

            if (this.radioGroup2.SelectedIndex == 0)
            {
                if (DialogResult.No == MessageBox.Show("是否确认修改选中计划的物料信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                WaitingFrom.ShowWait("");
                int index = gridView7.FocusedRowHandle;
                int thisindex = gridView5.FocusedRowHandle;
                string C_ID = gridView7.GetRowCellValue(index, "C_ID").ToString();
                Mod_TSP_PLAN_SMS mod = bll_plan_sms.GetModel(C_ID);
                if (mod != null && mod.N_CREAT_PLAN < 2)
                {
                    mod.C_MATRL_NO = gridView5.GetRowCellValue(thisindex, "C_ID").ToString();
                    mod.C_MATRL_NAME = gridView5.GetRowCellValue(thisindex, "C_MAT_NAME").ToString();
                    mod.C_SLAB_SIZE = gridView5.GetRowCellValue(thisindex, "C_SLAB_SIZE").ToString();
                    mod.C_SLAB_LENGTH = gridView5.GetRowCellValue(thisindex, "N_LTH").ToString();
                    mod.N_SLAB_PW = Convert.ToDecimal(gridView5.GetRowCellValue(thisindex, "N_HSL").ToString());

                    DataTable dtdown = bll_plan_sms.GetDownPlan(mod.C_ID);
                    if (dtdown.Rows.Count == 0)
                    {
                        bll_plan_sms.Update(mod);
                    }
                    else
                    {
                        MessageBox.Show("请先将浇次计划取消调度后，再修改物料信息！");
                    }
                }
                txt_update_ls.Text = "";
                dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                btn_query_jc_Click(null, null);
                WaitingFrom.CloseWait();
            }
            else if (this.radioGroup2.SelectedIndex == 1)
            {
                if (DialogResult.No == MessageBox.Show("是否确认修改选中浇次计划的所有当前钢种的物料信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                WaitingFrom.ShowWait("");
                int index = gridView7.FocusedRowHandle;
                int thisindex = gridView5.FocusedRowHandle;
                string C_ID = gridView7.GetRowCellValue(index, "C_ID").ToString();
                Mod_TSP_PLAN_SMS mod = bll_plan_sms.GetModel(C_ID);
                List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(mod.C_FK).Where(a => a.C_MATRL_NO == mod.C_MATRL_NO).ToList();
                if (lstlc.Count > 0)
                {
                    for (int i = 0; i < lstlc.Count; i++)
                    {
                        if (lstlc[i] != null && lstlc[i].N_CREAT_PLAN < 2)
                        {
                            lstlc[i].C_MATRL_NO = gridView5.GetRowCellValue(thisindex, "C_ID").ToString();
                            lstlc[i].C_MATRL_NAME = gridView5.GetRowCellValue(thisindex, "C_MAT_NAME").ToString();
                            lstlc[i].C_SLAB_SIZE = gridView5.GetRowCellValue(thisindex, "C_SLAB_SIZE").ToString();
                            lstlc[i].C_SLAB_LENGTH = gridView5.GetRowCellValue(thisindex, "N_LTH").ToString();
                            lstlc[i].N_SLAB_PW = Convert.ToDecimal(gridView5.GetRowCellValue(thisindex, "N_HSL").ToString());

                            DataTable dtdown = bll_plan_sms.GetDownPlan(lstlc[i].C_ID);
                            if (dtdown.Rows.Count == 0)
                            {
                                bll_plan_sms.Update(lstlc[i]);
                            }

                        }
                    }
                }

                txt_update_ls.Text = "";
                dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                btn_query_jc_Click(null, null);
                WaitingFrom.CloseWait();
            }
            else
            {
                if (this.txt_update_ls.Text.Trim() == "")
                {
                    MessageBox.Show("请输入需要修改物料的炉数！");
                    return;
                }
                if (Convert.ToInt32(this.txt_update_ls.Text) <= 0)
                {
                    MessageBox.Show("请输入需要修改物料的正确炉数！");
                    return;
                }
                if (DialogResult.No == MessageBox.Show("是否确认修改选中浇次计划的所有当前钢种的物料信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                WaitingFrom.ShowWait("");
                int index = gridView7.FocusedRowHandle;
                int thisindex = gridView5.FocusedRowHandle;
                string C_ID = gridView7.GetRowCellValue(index, "C_ID").ToString();
                Mod_TSP_PLAN_SMS mod = bll_plan_sms.GetModel(C_ID);
                List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(mod.C_FK).Where(a => a.C_MATRL_NO == mod.C_MATRL_NO && a.C_STD_CODE == mod.C_STD_CODE && a.N_CREAT_PLAN < 2).OrderByDescending(a => a.N_SORT).ToList();
                if (Convert.ToInt32(this.txt_update_ls.Text) > lstlc.Count)
                {

                    MessageBox.Show("输入的炉数超出可改的炉数！");
                    this.txt_update_ls.Text = lstlc.Count.ToString();
                    return;
                }
                if (lstlc.Count > 0)
                {
                    for (int i = 0; i < Convert.ToInt32(this.txt_update_ls.Text); i++)
                    {
                        if (lstlc[i] != null && lstlc[i].N_CREAT_PLAN < 2)
                        {
                            lstlc[i].C_MATRL_NO = gridView5.GetRowCellValue(thisindex, "C_ID").ToString();
                            lstlc[i].C_MATRL_NAME = gridView5.GetRowCellValue(thisindex, "C_MAT_NAME").ToString();
                            lstlc[i].C_SLAB_SIZE = gridView5.GetRowCellValue(thisindex, "C_SLAB_SIZE").ToString();
                            lstlc[i].C_SLAB_LENGTH = gridView5.GetRowCellValue(thisindex, "N_LTH").ToString();
                            lstlc[i].N_SLAB_PW = Convert.ToDecimal(gridView5.GetRowCellValue(thisindex, "N_HSL").ToString());

                            DataTable dtdown = bll_plan_sms.GetDownPlan(lstlc[i].C_ID);
                            if (dtdown.Rows.Count == 0)
                            {
                                bll_plan_sms.Update(lstlc[i]);
                            }

                        }
                    }
                }

                txt_update_ls.Text = "";
                dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                btn_query_jc_Click(null, null);
                WaitingFrom.CloseWait();
            }
        }
        private Bll_TPP_CAST_PLAN bll_tpp_cast_plan = new Bll_TPP_CAST_PLAN();
        /// <summary>
        /// 删除选中的炉次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_lc_Click(object sender, EventArgs e)
        {
            List<Mod_TSP_PLAN_SMS> listsmsd = bll_plan_sms.GetModelListByJcID(this.lbl_id.Text).Where(a => a.N_CREAT_PLAN > 2).ToList();
            if (listsmsd.Count > 0)
            {

                if (memoEdit2.Text.Trim() == "")
                {
                    MessageBox.Show("当前浇次已经开始生产，删除炉次计划需填写备注！");
                    memoEdit2.Focus();
                    return;
                }
            }


            if (txtDeleteLS.Text.Trim() == "")
            {
                MessageBox.Show("请输入需要删除的炉数！");
                return;
            }
            if (Convert.ToInt32(txtDeleteLS.Text.Trim()) <= 0)
            {
                MessageBox.Show("请输入正确的删除的炉数！");
                return;
            }

            if (DialogResult.No == MessageBox.Show("是否确认删除选中的炉次计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            int index = gridView7.FocusedRowHandle;
            if (index < 0)
            {
                return;
            }
            if (Convert.ToInt32(gridView7.GetRowCellValue(index, "N_CREAT_PLAN").ToString()) >= 3)
            {
                MessageBox.Show("当前计划已下MES，不能删除！");
                return;
            }
            WaitingFrom.ShowWait("");
            string C_STL_GRD = gridView7.GetRowCellValue(index, "C_STL_GRD").ToString();
            string C_STD_CODE = gridView7.GetRowCellValue(index, "C_STD_CODE").ToString();
            string C_MATRL_NO = gridView7.GetRowCellValue(index, "C_MATRL_NO").ToString();
            List<Mod_TSP_PLAN_SMS> listsms = bll_plan_sms.GetModelListByJcID(this.lbl_id.Text).Where(a => a.C_STL_GRD == C_STL_GRD && a.C_STD_CODE == C_STD_CODE && a.C_MATRL_NO == C_MATRL_NO && a.N_CREAT_PLAN <= 2).OrderByDescending(a => a.N_SORT).ToList();
            if (Convert.ToInt32(txtDeleteLS.Text.Trim()) > listsms.Count)
            {
                MessageBox.Show("删除的炉数不能超过当前钢种的总炉数！");
                return;
            }
            for (int i = 0; i < Convert.ToInt32(txtDeleteLS.Text.Trim()); i++)
            {
                if (listsms[i].N_CREAT_PLAN == 1)
                {
                    //bll_plan_sms.Delete(listsms[i].C_ID);
                    listsms[i].N_STATUS = 0;
                    listsms[i].C_REMARK2 = memoEdit2.Text;
                    bll_plan_sms.Update(listsms[i]);
                    Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "删除炉次计划", listsms[i].C_ID);//添加操作日志

                }
                if (listsms[i].N_CREAT_PLAN == 2)
                {
                    if (bll_tpp_cast_plan.DeletePlan(listsms[i].C_ID))
                    {
                        //bll_plan_sms.Delete(listsms[i].C_ID);
                        listsms[i].N_STATUS = 0;
                        listsms[i].C_REMARK2 = memoEdit2.Text;
                        bll_plan_sms.Update(listsms[i]);
                        Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "删除炉次计划", listsms[i].C_ID);//添加操作日志
                    }
                }

            }
            Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "删除炉次计划", this.lbl_id.Text);//添加操作日志
            UpdateJCByLC(this.lbl_id.Text, "0");
            btn_query_jc_Click(null, null);
            WaitingFrom.CloseWait();

        }

        private void btn_add_lc_new_Click(object sender, EventArgs e)
        {
            // Cls_APS_PC.AddLCJH(string C_STL_GRD, string C_STD_CODE, string C_SLAB_SIZE, int N_SLAB_LENGTH, string C_JC_ID, int N_LS);
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_add_lc_Click(null, null);
        }

        private void gridView6_Click(object sender, EventArgs e)
        {
            jcRowHand = gridView6.FocusedRowHandle;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            UpdateFinishJC(_strCCMID);

            UpdateLCPlanTime(_strCCMID);

            UpdateALLLCTIME();
        }



        /// <summary>
        /// 跟新连铸的浇次序号和炉次序号
        /// </summary>
        /// <param name="C_CCM_ID">连铸机</param>
        public void UpdateCCMSort(string C_CCM_ID)
        {
            List<Mod_TSP_CAST_PLAN> lstjc = bll_cast_plan.GetModelList(C_CCM_ID, 3, "").OrderBy(a => a.N_SORT).ToList();
        }


        /// <summary>
        /// 复制选中的浇次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copy_plan_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否复制选中的浇次计划！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            if (lbl_id.Text.Trim() == "")
            {
                return;
            }

            Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(lbl_id.Text.Trim());

            Mod_TSP_CAST_PLAN modjc_new = modjc;
            modjc_new.C_ID = System.Guid.NewGuid().ToString();
            modjc_new.N_SORT = bll_cast_plan.Max_jc_sort(modjc.C_CCM_ID) + 1;
            modjc_new.N_STATUS = 1;
            bll_cast_plan.Add(modjc_new);

            var lstlc = bll_plan_sms.GetModelListByJcID(lbl_id.Text.Trim());
            int maxsort = bll_plan_sms.GetMaxSort(modjc.C_CCM_ID) + 1;
            for (int i = 0; i < lstlc.Count; i++)
            {
                Mod_TSP_PLAN_SMS modlc = lstlc[i];
                modlc.C_ID = System.Guid.NewGuid().ToString();
                modlc.C_FK = modjc_new.C_ID;
                modlc.N_SORT = maxsort + i;
                modlc.N_JC_SORT = modjc_new.N_SORT;
                modlc.N_CREAT_PLAN = 1;
                modlc.N_CREAT_ZG_PLAN = 0;
                modlc.C_STATE = "1";
                modlc.N_PRODUCE_TIME = 0;
                bll_plan_sms.Add(modlc);

            }
            Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "复制浇次计划");//添加操作日志
            MessageBox.Show("计划已经复制！");
            btnSaveJcPlan_Click(null, null);

        }

        /// <summary>
        /// 调整到下一个浇次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_downlcplan_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否将当前浇次的最后一炉计划调整到下一个浇次计划中！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(lbl_id.Text);//当前浇次计划
            List<Mod_TSP_PLAN_SMS> lstplansms = bll_plan_sms.GetModelListByJcID(lbl_id.Text).OrderByDescending(a => a.N_SORT).ToList();
            Mod_TSP_CAST_PLAN modnext = bll_cast_plan.GetNextModel(mod.C_CCM_ID, (int)mod.N_SORT);
            if (modnext != null && lstplansms.Count > 0)
            {
                lstplansms[0].C_FK = modnext.C_ID;
                bll_plan_sms.Update(lstplansms[0]);
            }
            Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "炉次计划" + lstplansms[0].C_ID + "调整到下一浇次！");//添加操作日志
            gridView6_FocusedRowObjectChanged(null, null);
            MessageBox.Show("计划调整成功！");

        }
        /// <summary>
        /// 调整到上一浇次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_uplcplan_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否将当前浇次的最后一炉计划调整到上一个浇次计划中！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(lbl_id.Text);//当前浇次计划
            List<Mod_TSP_PLAN_SMS> lstplansms = bll_plan_sms.GetModelListByJcID(lbl_id.Text).OrderBy(a => a.N_SORT).ToList();
            Mod_TSP_CAST_PLAN modnext = bll_cast_plan.GetLastModel(mod.C_CCM_ID, (int)mod.N_SORT);
            if (modnext != null && lstplansms.Count > 0)
            {
                lstplansms[0].C_FK = modnext.C_ID;
                bll_plan_sms.Update(lstplansms[0]);
            }
            Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "炉次计划" + lstplansms[0].C_ID + "调整到上一浇次！");//添加操作日志
            gridView6_FocusedRowObjectChanged(null, null);
            MessageBox.Show("计划调整成功！");
        }

        private void btn_waste_record_Click(object sender, EventArgs e)
        {
            int index = gridView7.FocusedRowHandle;
            if (index < 0)
            {
                MessageBox.Show("请选择需要回炉或甩废的炉次计划！");
                return;
            }
            if (Convert.ToInt32(gridView7.GetRowCellValue(index, "N_CREAT_PLAN").ToString()) < 3)
            {
                MessageBox.Show("当前计划未下MES，不能执行当前操作！");
                return;
            }

            if (Convert.ToDateTime(gridView7.GetRowCellValue(index, "D_P_END_TIME").ToString()).AddHours(12) > RV.UI.ServerTime.timeNow())
            {
                MessageBox.Show("当前计划结束时间超出12小时后才能执行当前操作！");
                return;
            }

            string C_ID = gridView7.GetRowCellValue(index, "C_ID").ToString();



            if (this.memoEdit2.Text.Trim() == "")
            {
                MessageBox.Show("请输入回炉或甩废原因！");
                memoEdit2.Focus();
                return;
            }
            if (DialogResult.No == MessageBox.Show("是否将当前炉次记录为回炉或甩废！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            Mod_TSP_PLAN_SMS modlc = bll_plan_sms.GetModel(C_ID);
            modlc.N_NEW_STATUS = 2;
            modlc.N_CREAT_PLAN = 4;
            modlc.C_REMARK4 = this.memoEdit2.Text.Trim();
            bll_plan_sms.Update(modlc);

            Common.UserLog.AddLog(str_meunname, this.Name, this.Text, "回炉甩废记录", modlc.C_ID);//添加操作日志
        }


        /// <summary>
        /// 计划存档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_plan_cd_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认当前浇次计划排产正确并确定将当前计划存档！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            WaitingFrom.ShowWait("计划正在存档，请稍候...");
            string P_IP = Common.UserLog.GetLocalIP();
            string P_OPER_CONTEXT = "计划存档";
            string P_EMP_ID = RV.UI.UserInfo.userID;
            string P_CCM_ID = "";
            string P_TYPE = "计划存档";
            string c_cd_no = bll_cast_plan.P_CD_LOG(P_IP, P_OPER_CONTEXT, P_EMP_ID, P_CCM_ID, P_TYPE);  //存档编号
            if (c_cd_no != "0")
            {
                string res = bll_cast_plan.P_LG_PLAN_CD(c_cd_no, "计划存档", P_EMP_ID);
            }

            WaitingFrom.CloseWait();
            MessageBox.Show("计划已存档，存档编号：" + c_cd_no);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            List<Mod_TSP_CAST_PLAN> lstjc = bll_cast_plan.GetModelList("  t.c_ccm_id='77B9FDA79B884D07AA2B3601D1DA11A2' ");
            for (int i = 0; i < lstjc.Count; i++)
            {
                UpdateJCRHNum(lstjc[i].C_ID);
            }

        }
        public int GetUpdateJCRHNum(string c_jc_id)
        {
            List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(c_jc_id);
            int RHLS = 0;
            if (lstlc.Count > 0)
            {
                for (int j = 0; j < lstlc.Count; j++)
                {
                    if (lstlc[j].C_RH == "Y")
                    {
                        if (j + 1 < lstlc.Count)
                        {
                            RHLS = j + 1 + 1;//浇次RH炉数为最后一炉RH计划+1炉
                        }
                        else
                        {
                            RHLS = lstlc.Count;
                        }

                    }
                    if (lstlc[j].C_STL_GRD == "Q55SiCrA-1" && lstlc[j].C_STD_CODE == "JSKZ-138-70")
                    {
                        return 0;
                    }

                }
            }


            return RHLS;

        }

        public bool UpdateJCRHNum(string c_jc_id)
        {
            Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(c_jc_id);
            List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(c_jc_id);
            int RHLS = 0;
            if (lstlc.Count > 0)
            {
                for (int j = 0; j < lstlc.Count; j++)
                {
                    if (lstlc[j].C_RH == "Y")
                    {
                        if (j + 1 < lstlc.Count)
                        {
                            RHLS = j + 1 + 1;//浇次RH炉数为最后一炉RH计划+1炉
                        }
                        else
                        {
                            RHLS = lstlc.Count;
                        }

                    }

                }
            }

            mod.N_RH = RHLS;
            return bll_cast_plan.Update(mod);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            List<Mod_TSP_CAST_PLAN> lstjc = bll_cast_plan.GetModelList("  t.c_ccm_id='77B9FDA79B884D07AA2B3601D1DA11A2' ");
            int rhsm = 0;//RH炉寿命
            for (int i = 0; i < lstjc.Count; i++)
            {

                if (rhsm >= 130 && lstjc[i].N_RH == 0)
                {
                    rhsm = 0;
                }
                else
                {
                    rhsm = rhsm + (int)lstjc[i].N_RH;

                }
                lstjc[i].C_RH_SFJS = rhsm.ToString();
                bll_cast_plan.Update(lstjc[i]);
            }
        }
        /// <summary>
        /// 人为标记更换新的RH槽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_updateRH_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            UpdateRHNum(this.lbl_id.Text);
            string dt = "";
            if (this.rbtn_status.SelectedIndex == 2)
            {
                dt = this.dtp_start_date.Text.Trim();
            }
            BindLsbGrid(_strCCMID, this.rbtn_status.SelectedIndex + 1, dt);
            WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 更新RH炉寿命
        /// </summary>
        /// <param name="C_JC_ID"></param>
        public void UpdateRHNum(string C_JC_ID)
        {
            Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(C_JC_ID);
            mod.C_RH_SFJS = mod.N_RH.ToString();
            bll_cast_plan.Update(mod);
            List<Mod_TSP_CAST_PLAN> lstjc = bll_cast_plan.GetModelList("  t.c_ccm_id='77B9FDA79B884D07AA2B3601D1DA11A2' and t.n_sort> " + mod.N_SORT);
            int rhsm = (int)mod.N_RH;//RH炉寿命
            for (int i = 0; i < lstjc.Count; i++)
            {

                if (rhsm >= 130 && lstjc[i].N_RH == 0)
                {
                    rhsm = 0;
                }
                else
                {
                    rhsm = rhsm + (int)lstjc[i].N_RH;

                }
                lstjc[i].C_RH_SFJS = rhsm.ToString();
                bll_cast_plan.Update(lstjc[i]);
            }


        }


    }
}
