using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APS_LGPC_NEW : Form
    {
        public FrmPO_APS_LGPC_NEW()
        {
            InitializeComponent();
        }

        private void FrmPO_APS_LGPC_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            WaitingFrom.ShowWait("页面正在加载，请稍候...");
            dhl_plan = bll_dhl.GetModelList("");//已排产大方坯缓冷未完成计划
            kp_plan = bll_kp.GetModelList("");//已排产大方坯开坯未完成
            hl_plan = bll_hl.GetModelList("");//已排产热轧坯缓冷未完成计划
            xm_plan = bll_xm.GetModelList("");//已排产修磨未完成计划
            sms_plan = bll_plan_sms.GetModelList(" N_CREAT_PLAN<3 AND N_STATUS = 1  ");//已排产未完成的计划
            hl_acl = bll_hl_act.GetModelList("");//已排产未完成的计划
            lc_plan = bll_lc.GetModelList("");//获得临时表所有的炉次计划

            CommonSub.BindIcboNoAll("", "CC", icbo_lz3);
            CommonSub.BindIcboNoAll("", "CC", icbo_lz4);
            icbo_lz3.SelectedIndex = 2;
            BindLsbGrid(_strCCMID);
            try
            {
                InitDrop();
                InitDrop_Lc();
            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.ToString());
            }
            WaitingFrom.CloseWait();
            this.dateEdit1.Text = GetStartTime(_strCCMID).ToString();
            
        }


        #region 方法
        #region 实例化功能设计对象
        private Bll_TPC_PLAN_SMS bll_plan = new Bll_TPC_PLAN_SMS();
        private static Bll_TSP_PLAN_SMS bll_plan_sms = new Bll_TSP_PLAN_SMS();
        private static Bll_TPP_LGPC_LSB bll_jc = new Bll_TPP_LGPC_LSB();//未排产浇次计划表
        private static Bll_TPP_LGPC_LCLSB bll_lc = new Bll_TPP_LGPC_LCLSB();//未排产临时计划表
        private static Bll_TPA_DHL_PLAN bll_dhl = new Bll_TPA_DHL_PLAN();//大方坯缓冷计划表
        private static Bll_TPA_KP_PLAN bll_kp = new Bll_TPA_KP_PLAN();//开坯计划表
        private static Bll_TPA_HL_PLAN bll_hl = new Bll_TPA_HL_PLAN();//热轧坯缓冷计划表
        private static Bll_TPA_XM_PLAN bll_xm = new Bll_TPA_XM_PLAN();//修磨计划表
        private static Bll_TPA_HL_ACT bll_hl_act = new Bll_TPA_HL_ACT();//缓冷实绩
        private static Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();//浇次计划
        private Bll_TPC_PLAN_SMS bll_tpc_plan_sms = new Bll_TPC_PLAN_SMS();//炼钢排产计划
        #endregion

        #region 加载默认计划列表
        private List<Mod_TPP_LGPC_LSB> jc_plan = new List<Mod_TPP_LGPC_LSB>();//待排产浇次计划
        private List<Mod_TPP_LGPC_LCLSB> lc_plan = new List<Mod_TPP_LGPC_LCLSB>();//待排产炉次计划
        private List<Mod_TPA_DHL_PLAN> dhl_plan = new List<Mod_TPA_DHL_PLAN>();//已排产大方坯缓冷未完成计划
        private List<Mod_TPA_KP_PLAN> kp_plan = new List<Mod_TPA_KP_PLAN>();//已排产大方坯开坯未完成
        private List<Mod_TPA_HL_PLAN> hl_plan = new List<Mod_TPA_HL_PLAN>();//已排产热轧坯缓冷未完成计划
        private List<Mod_TPA_XM_PLAN> xm_plan = new List<Mod_TPA_XM_PLAN>();//已排产修磨未完成计划
        private List<Mod_TSP_PLAN_SMS> sms_plan = new List<Mod_TSP_PLAN_SMS>();//已排产未完成的计划
        private List<Mod_TPA_HL_ACT> hl_acl = new List<Mod_TPA_HL_ACT>();//已排产未完成的计划
        private List<Mod_TPP_LGPC_LSB> jc_plan_sort = new List<Mod_TPP_LGPC_LSB>();//待排产浇次计划
        private List<Mod_TPP_LGPC_LCLSB> lc_plan_sort = new List<Mod_TPP_LGPC_LCLSB>();//待排产炉次计划
        #endregion


        #region 排产操作方法

        #region 浇次计划内的炉次计划自动排序
        public void UpdateLCSort(List<Mod_TPP_LGPC_LSB> lstjc, List<Mod_TPP_LGPC_LCLSB> lstlc)
        {


        }


        #endregion

        #region 查询浇次计划
        /// <summary>
        /// 查询浇次计划方法
        /// </summary>
        /// <param name="strCCMID">连铸机</param>
        private void BindLsbGrid(string strCCMID)
        {
            jc_plan = bll_jc.GetModelList("").Where(a => a.C_CCM_ID == strCCMID).OrderBy(a => a.N_SORT).ToList();
            jc_plan = Initialize_List(jc_plan);
            this.modTPPLGPCLSBBindingSource.DataSource = jc_plan;
            this.gridView6.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView6);
            this.gridView6.UpdateSummary();
            this.gridView6.RefreshData();
            this.gridView6.BestFitColumns();
            this.gridView6.RowStyle += GridView6_RowStyle;

        }

        private void GridView6_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                int hand = e.RowHandle;
                if (hand < 0) return;
                if (gridView6.GetRowCellValue(hand, "N_ORDER_LS").ToString() == "0")
                {
                    e.Appearance.ForeColor = Color.Red;// 改变行字体颜色
                                                       //e.Appearance.BackColor2 = Color.Blue;// 添加渐变颜色
                }

                if (gridView6.GetRowCellValue(hand, "C_BY3").ToString() == "False")
                {
                    e.Appearance.BackColor = Color.Yellow;// 改变行字体颜色
                                                      
                }
            }
            catch (Exception ex)
            {

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
            this.modTPPLGPCLCLSBBindingSource.DataSource = null;
            //  lc_plan = bll_lc.GetModelListByJcID(strCFK).OrderBy(a => a.N_SORT).ToList();
            lc_plan_sort = bll_lc.GetModelListByJcID(strCFK).OrderBy(a => a.N_SORT).ToList();
            // lc_plan.Where(a => a.C_FK == strCFK).OrderBy(a => a.N_SORT).ToList();
            this.modTPPLGPCLCLSBBindingSource.DataSource = lc_plan_sort;
            this.gridView7.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView7);
            this.gridView7.UpdateSummary();
            this.gridView7.RefreshData();
            this.gridView7.BestFitColumns();
            this.gridView7.RowStyle += GridView7_RowStyle1;

        }

        private void GridView7_RowStyle1(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
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
                if (gridView7.GetRowCellValue(hand, "C_CTRL_NO").ToString().Trim() != "")
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

        /// <summary>
        /// 初始化待排产的浇次计划列表
        /// </summary>
        /// <param name="lst_jc_plan">浇次计划</param>
        /// <param name="lst_lc_plan">炉次计划</param>
        /// <returns>初始化后的浇次计划列表</returns>
        public List<Mod_TPP_LGPC_LSB> Initialize_List(List<Mod_TPP_LGPC_LSB> lst_jc_plan)
        {
            #region 浇次计划初始化
            for (int i = 0; i < lst_jc_plan.Count; i++)
            {
                lst_jc_plan[i].N_STATUS = 0;//浇次计划未排产0，系统已排产1，人为排产2
                lst_jc_plan[i].N_JSCN = lst_jc_plan[i].N_JSCN == null ? (lst_jc_plan[i].C_CCM_CODE == "5#CC" ? 114 : 88) : lst_jc_plan[i].N_JSCN;
                lst_jc_plan[i].N_ZJCLZL = lst_jc_plan[i].N_MLZL * lst_jc_plan[i].N_ZJCLS;
                lst_jc_plan[i].N_CCM_TIME = Math.Round(Convert.ToDecimal(lst_jc_plan[i].N_MLZL * lst_jc_plan[i].N_ZJCLS / lst_jc_plan[i].N_JSCN), 2);//连铸生产需求时间

                List<Mod_TPP_LGPC_LCLSB> lst_lc_plan = bll_lc.GetModelListByJcID(lst_jc_plan[i].C_ID);

                //根据炉次计划分出浇次计划的钢种类型
                try
                {
                    #region 区分浇次计划的钢种类型
                    if (lst_lc_plan.Where(a => a.C_STL_GRD_TYPE.Contains("含硼钛废钢") || a.C_STL_GRD_TYPE.Contains("硅铝镇静钢")).ToList().Count > 0)
                    {
                        lst_jc_plan[i].C_STL_GRD_TYPE = "硅铝镇静钢";
                        if (lst_lc_plan.Where(a => a.C_PROD_NAME.Contains("轴承钢")).ToList().Count > 0)
                        {
                            lst_jc_plan[i].C_PROD_NAME = "轴承钢";
                        }
                        else if (lst_lc_plan.Where(a => a.C_PROD_NAME.Contains("弹簧钢")).ToList().Count > 0)
                        {
                            lst_jc_plan[i].C_PROD_NAME = "弹簧钢";
                        }
                        else
                        {
                            lst_jc_plan[i].C_PROD_NAME = lst_lc_plan.ToList()[0].C_PROD_NAME;
                        }


                    }
                    if (lst_lc_plan.Where(a => a.C_STL_GRD_TYPE.Contains("半沸腾钢") || a.C_STL_GRD_TYPE.Contains("超低碳钢") || a.C_PROD_NAME.Contains("纯铁") || a.C_STL_GRD.Contains("DT4") || a.C_STL_GRD.Contains("XGYT") || a.C_STL_GRD.Contains("CH1T")).ToList().Count > 0)
                    {
                        lst_jc_plan[i].C_STL_GRD_TYPE = "铝镇静钢";
                        lst_jc_plan[i].C_PROD_NAME = "超低碳钢";
                    }
                    else
                    {
                        lst_jc_plan[i].C_STL_GRD_TYPE = lst_lc_plan.ToList()[0].C_STL_GRD_TYPE;
                        if (lst_lc_plan.Where(a => a.C_PROD_NAME.Contains("轴承钢")).ToList().Count > 0)
                        {
                            lst_jc_plan[i].C_PROD_NAME = "轴承钢";
                        }
                        else if (lst_lc_plan.Where(a => a.C_PROD_NAME.Contains("弹簧钢")).ToList().Count > 0)
                        {
                            lst_jc_plan[i].C_PROD_NAME = "弹簧钢";
                        }
                        else
                        {
                            lst_jc_plan[i].C_PROD_NAME = lst_lc_plan.ToList()[0].C_PROD_NAME;
                        }
                    }

                    #endregion
                }
                catch (Exception)
                {


                }


            }
            return lst_jc_plan;
            #endregion
        }
        #endregion

        #region 将浇次计划按连铸进行排序，并初始化计划时间
        /// <summary>
        /// 将浇次计划按照排序号初始化浇次和炉次计划时间计算
        /// </summary>
        /// <param name="c_ccm">连铸机主键</param>
        /// <param name="dt_start">连铸浇次计划开始时间</param>
        /// <param name="lst">需要排序的浇次计划</param>
        /// <returns>排序后的浇次计划</returns>
        public List<Mod_TPP_LGPC_LSB> Sort_JC_plan(string c_ccm, DateTime dt_start, List<Mod_TPP_LGPC_LSB> plan_lst)
        {
            var lst1 = plan_lst.Where(a => a.C_CCM_ID == c_ccm).OrderBy(a => a.C_CCM_ID).ThenBy(a => a.N_SORT).ToList();//获取待排序的浇次计划
            int sort = 1;
            DateTime d_start_time = dt_start;//指定开始时间
            for (int l = 0; l < lst1.Count; l++)
            {
                lst1[l].N_SORT = sort;
                lst1[l].D_P_START_TIME = d_start_time;
                //同时更新炉次计划的开始结束时间和序号
                lst1[l].D_P_END_TIME = UpdateLcPlan(lst1[l].C_ID, Convert.ToDateTime(lst1[l].D_P_START_TIME), Convert.ToDouble(lst1[l].N_PRODUCE_TIME), sort);
                sort = sort + 1;
                d_start_time = Convert.ToDateTime(lst1[l].D_P_END_TIME).AddHours(Convert.ToDouble(lst1[l].N_PRODUCE_TIME));
                foreach (var item in plan_lst)
                {
                    if (item.C_ID == lst1[l].C_ID)
                    {
                        item.N_SORT = lst1[l].N_SORT;
                        item.D_P_START_TIME = lst1[l].D_P_START_TIME;
                        item.D_P_END_TIME = lst1[l].D_P_END_TIME;

                    }
                }
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
        /// <returns>返回本浇次最后一炉计划结束时间</returns>
        public DateTime UpdateLcPlan(string c_jc_id, DateTime dt_strat_time, double N_tjsj, int n_jc_sort)
        {
            DateTime dt = dt_strat_time;
            DateTime dt_end_time = dt_strat_time;//浇次结束时间
            List<Mod_TPP_LGPC_LCLSB> lst = new List<Mod_TPP_LGPC_LCLSB>();
            lst = bll_lc.GetModelListByJcID(c_jc_id).OrderBy(a => a.N_SORT).ToList();
            if (lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (N_tjsj > 0 && i == lst.Count - 1)
                    {
                        lst[i].N_PRODUCE_TIME = Convert.ToDecimal(N_tjsj);//如果浇次结束后需要停机的在最后一炉添加停机时间
                    }
                    else
                    {
                        lst[i].N_PRODUCE_TIME = 0;
                    }
                    lst[i].N_SORT = i + 1;
                    lst[i].N_JC_SORT = n_jc_sort;
                    lst[i].D_P_START_TIME = dt;
                    lst[i].D_P_END_TIME = Convert.ToDateTime(dt).AddHours(Convert.ToDouble(lst[i].N_SLAB_WGT / lst[i].N_JSCN));
                    bll_lc.Update(lst[i]);
                    dt = Convert.ToDateTime(lst[i].D_P_END_TIME).AddHours(Convert.ToDouble(lst[i].N_PRODUCE_TIME));//下已炉的开始时间
                    dt_end_time = Convert.ToDateTime(lst[i].D_P_END_TIME);
                }

            }

            return dt_end_time;
        }
        #endregion

        #region 调整浇次计划整浇次炉数
        /// <summary>
        /// 调整浇次计划炉数
        /// </summary>
        /// <param name="jc_id">浇次主键</param>
        /// <param name="num">调整后的浇次炉数</param>
        /// <param name="sfcangejc">是否调整其他浇次计划</param>
        public void ChangeJCLs(string jc_id, int num, string sfcangejc)
        {
            #region 获取当前浇次计划产品的整浇次炉数信息
            int zjcls = 20;
            int zjclsmin = 18;
            int zjclsmax = 22;
            #endregion

            decimal? fzh = null;
            List<Mod_TPP_LGPC_LCLSB> lst = bll_lc.GetModelListByJcID(jc_id);//当前浇次的炉次计划
            DataTable dt_sms = bll_lc.GetList_sms_group(jc_id).Tables[0];
            Mod_TPP_LGPC_LSB mod = bll_jc.GetModel(jc_id);
            int d_value = Convert.ToInt32(mod.N_ZJCLS) - num;//原来浇次数-调整后的炉数；正数减少浇次炉数，负数是增加炉次计划

            if (d_value > 0)//将该浇次炉数调少
            {
                if ((mod.N_ZJCLS - mod.N_ORDER_LS) >= d_value)//该浇次的非计划炉数比减少的炉数多
                {
                    var lst1 = lst.Where(a => a.C_STATE == "1").OrderByDescending(a => a.N_SORT).ToList();
                    for (int i = 0; i < d_value; i++)
                    {
                        bll_lc.Delete(lst1[i].C_ID);
                    }
                }
                else
                {
                    lst = lst.OrderByDescending(a => a.N_SORT).ToList();
                    for (int i = 0; i < d_value; i++)
                    {
                        if (lst[i].C_STATE == "1")
                        {
                            bll_lc.Delete(lst[i].C_ID);//非计划删除 
                        }
                        if (lst[i].C_STATE == "0")//计划炉次计划
                        {
                            List<Mod_TPP_LGPC_LCLSB> lstlc = bll_lc.GetModelList("").Where(a => a.N_GROUP == mod.N_GROUP && a.N_JC_SORT > mod.N_SORT && a.C_STL_GRD == mod.C_STL_GRD && a.C_STD_CODE == mod.C_STD_CODE && a.C_STATE == "1").OrderByDescending(a => a.N_JC_SORT).ThenBy(a => a.N_SORT).ToList();
                            if (lstlc.Count > 0)//有可替换的炉次计划
                            {
                                //替换
                                bll_lc.Delete(lst[i].C_ID);//计划删除

                                lstlc[0].C_STATE = "0";
                                bll_lc.Update(lstlc[0]);
                                mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次
                                Mod_TPP_LGPC_LSB modupdate = bll_jc.GetModel(lstlc[0].C_FK);
                                modupdate.N_ORDER_LS = modupdate.N_ORDER_LS + 1;
                                bll_jc.Update(modupdate);

                            }
                            else//没有可替换的
                            {
                                List<Mod_TPP_LGPC_LSB> lstinsert = bll_jc.GetModelList("").Where(a => a.N_GROUP == mod.N_GROUP && a.C_ID != mod.C_ID && a.N_SORT > mod.N_SORT && a.N_ZJCLS < zjcls).OrderByDescending(a => a.N_SORT).ToList();//有没有可以插入当前浇次多余的炉次计划的浇次计划,按顺序向下找

                                if (lstinsert.Count > 0)//有可转移的浇次计划
                                {
                                    bll_lc.Delete(lst[i].C_ID);//计划删除

                                    Mod_TPP_LGPC_LCLSB modadd = new Mod_TPP_LGPC_LCLSB();
                                    modadd = lst[i];
                                    modadd.C_FK = lstinsert[0].C_ID;
                                    modadd.C_ID = System.Guid.NewGuid().ToString();
                                    modadd.N_SORT = bll_lc.MaxSortBy(modadd.C_FK) + 1;
                                    modadd.N_JC_SORT = lstinsert[0].N_SORT;
                                    bll_lc.Add(modadd);

                                    lstinsert[0].N_ORDER_LS = lstinsert[0].N_ORDER_LS + 1;
                                    lstinsert[0].N_ZJCLS = lstinsert[0].N_ZJCLS + 1;
                                    lstinsert[0].N_ZJCLZL = lstinsert[0].N_ZJCLS * lstinsert[0].N_MLZL;
                                    bll_jc.Update(lstinsert[0]);
                                    //炉次计划转移到目标浇次计划
                                    mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次

                                }
                                else
                                {
                                    //新增浇次计划
                                    Mod_TPP_LGPC_LSB mod_add_jc = new Mod_TPP_LGPC_LSB();
                                    mod_add_jc.N_SORT = bll_jc.GetModelList("").Where(a => a.C_CCM_ID == mod.C_CCM_ID).ToList().Count + 1;//插入到浇次计划的最后面

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

                                    bll_jc.Add(mod_add_jc);
                                    //新增炉次计划

                                    bll_lc.Delete(lst[i].C_ID);

                                    //炉次计划转移到新增浇次计划
                                    Mod_TPP_LGPC_LCLSB mod_add_lc = new Mod_TPP_LGPC_LCLSB();
                                    mod_add_lc = lst[i];
                                    mod_add_lc.C_ID = System.Guid.NewGuid().ToString();
                                    mod_add_lc.C_FK = mod_add_jc.C_ID;
                                    mod_add_lc.N_SORT = 1;
                                    mod_add_lc.N_JC_SORT = mod_add_jc.N_SORT;
                                    mod_add_lc.C_STATE = "0";
                                    bll_lc.Add(mod_add_lc);

                                    for (int l = 1; l < mod_add_jc.N_ZJCLS; l++)
                                    {
                                        Mod_TPP_LGPC_LCLSB mod_add_lc2 = new Mod_TPP_LGPC_LCLSB();
                                        mod_add_lc2 = lst[i];
                                        mod_add_lc2.C_ID = System.Guid.NewGuid().ToString();
                                        mod_add_lc2.C_FK = mod_add_jc.C_ID;
                                        mod_add_lc2.N_SORT = l + 1;
                                        mod_add_lc2.C_STATE = "1";
                                        mod_add_lc2.N_JC_SORT = mod_add_jc.N_SORT;
                                        bll_lc.Add(mod_add_lc2);
                                    }
                                    mod.N_ORDER_LS = mod.N_ORDER_LS - 1;//当前浇次计划的计划炉次
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
                    List<Mod_TPP_LGPC_LSB> lst1 = bll_jc.GetModelList("").Where(a => a.N_GROUP == mod.N_GROUP && a.N_SORT > mod.N_SORT && a.C_CCM_ID == mod.C_CCM_ID).ToList();
                    if (lst1.Count == 0)
                    {
                        Mod_TPP_LGPC_LCLSB modlc = lst[lst.Count - 1];//复制最后一条炉次计划
                        modlc.C_ID = System.Guid.NewGuid().ToString();
                        modlc.N_SORT = modlc.N_SORT + j + 1;//更新炉次计划序号
                        modlc.C_STATE = "1";//增加的计划为非计划炉次计划
                        bll_lc.Add(modlc);
                    }
                    else
                    {
                        //查找可替换的炉次计划（浇次序号在当前浇次后面的）
                        Mod_TPP_LGPC_LCLSB modlc = lst[lst.Count - 1];//复制最后一条炉次计划
                        List<Mod_TPP_LGPC_LCLSB> lstth = bll_lc.GetModelList("").Where(a => a.N_GROUP == modlc.N_GROUP && a.N_JC_SORT > modlc.N_JC_SORT && a.C_STATE == "0" && a.C_STL_GRD == modlc.C_STL_GRD && a.C_STD_CODE == modlc.C_STD_CODE).OrderByDescending(a => a.N_JC_SORT).ThenByDescending(a => a.N_SORT).ToList();
                        if (lstth.Count > 0)
                        {
                            modlc.C_ID = System.Guid.NewGuid().ToString();
                            modlc.N_SORT = modlc.N_SORT + j + 1;//更新炉次计划序号
                            modlc.C_STATE = "0";//增加的计划为非计划炉次计划
                            mod.N_ORDER_LS++;
                            bll_lc.Add(modlc);

                            lstth[0].C_STATE = "1";
                            bll_lc.Update(lstth[0]);

                            Mod_TPP_LGPC_LSB modjcth = bll_jc.GetModel(lstth[0].C_FK);
                            modjcth.N_ORDER_LS--;
                            bll_jc.Update(modjcth);
                        }
                        else
                        {
                            Mod_TPP_LGPC_LCLSB modlc1 = lst[lst.Count - 1];//复制最后一条炉次计划
                            modlc1.C_ID = System.Guid.NewGuid().ToString();
                            modlc1.N_SORT = modlc1.N_SORT + j + 1;//更新炉次计划序号
                            modlc1.C_STATE = "1";//增加的计划为非计划炉次计划
                            bll_lc.Add(modlc1);
                        }
                    }

                }



            }
            mod.N_ZJCLS = Convert.ToInt32(num);//调整后的整浇次炉数
            mod.N_ZJCLZL = mod.N_ZJCLS * mod.N_MLZL;
            fzh = mod.N_GROUP;
            bll_jc.Update(mod);
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
            if (this.chk_sfzd.Checked)
            {

                if (this.dateEdit1.Text.Trim() == "")
                {
                    return System.DateTime.Now.AddHours(1);
                }
                if (Convert.ToDateTime(this.dateEdit1.Text) < System.DateTime.Now)
                {
                    return System.DateTime.Now.AddHours(1);

                }
                dt = Convert.ToDateTime(this.dateEdit1.Text);
            }
            else
            {
                try
                {
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

            }
            #endregion
            return dt;
        }
        #endregion

        #region 确定已排产连铸计划连续过RH的炉数
        /// <summary>
        /// 获得当前排产浇次计划连续过RH的总数
        /// </summary>
        /// <param name="c_ccm">连铸主键</param>
        /// <returns>连续RH炉数</returns>
        public int GetRHNum(string c_ccm)
        {
            return bll_cast_plan.GetRHSM(c_ccm);

        }

        #endregion

        #region 获取已排计划的最后一个浇次的钢种类型
        /// <summary>
        /// 获取已排计划的最后一个浇次的钢种类型
        /// </summary>
        /// <param name="c_ccm">连铸机主键</param>
        /// <returns></returns>
        public string[] GetJCType(string c_ccm)
        {
            string str_type = "";
            string str_pro_name = "";
            DataTable dtGGType = bll_cast_plan.GetGGType(c_ccm);
            if (dtGGType.Rows.Count > 0)
            {
                str_type = dtGGType.Rows[0]["C_STL_GRD_TYPE"].ToString();
                str_pro_name = dtGGType.Rows[0]["C_PROD_NAME"].ToString();
            }

            return new string[] { str_type, str_pro_name };
        }
        #endregion

        #region 从未排产的浇次计划中获取下个可排产的浇次计划列表
        /// <summary>
        /// 从未排产的浇次计划中获取下个可排产的浇次计划列表
        /// </summary>
        /// <param name="wplst">未排产浇次计划</param>
        /// <param name="c_stl_type">钢种类型</param>
        /// <param name="c_prod_name">品名</param>
        /// <returns>返回可排产的浇次计划列表</returns>
        public List<Mod_TPP_LGPC_LSB> GetNextJC(List<Mod_TPP_LGPC_LSB> wplst, string c_stl_type, string c_prod_name)
        {
            #region 获取可排计划
            List<Mod_TPP_LGPC_LSB> kpjc = wplst;//可排产浇次计划

            if (c_stl_type == "硅铝镇静钢" && c_prod_name == "弹簧钢")
            {
                //只能排硅铝镇静钢的非轴承钢浇次计划
                kpjc = wplst.Where(a => a.C_STL_GRD_TYPE == "硅铝镇静钢" && a.C_PROD_NAME != "轴承钢").OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
                if (kpjc.Count == 0)
                {
                    kpjc = wplst.Where(a => a.C_STL_GRD_TYPE == "硅铝镇静钢").OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
                }

            }
            if (c_stl_type == "硅铝镇静钢" && c_prod_name == "轴承钢")
            {
                //只能排硅铝镇静钢的非弹簧钢的浇次计划
                kpjc = wplst.Where(a => a.C_STL_GRD_TYPE == "硅铝镇静钢").OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "硅铝镇静钢" && c_prod_name != "弹簧钢" && c_prod_name != "轴承钢")
            {
                //可排所有浇次计划除超低碳（超低碳需有过渡浇次）
                kpjc = wplst.Where(a => a.C_PROD_NAME != "超低碳钢").OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "铝镇静钢" && c_prod_name == "超低碳")
            {
                //超低碳
                kpjc = wplst.Where(a => a.C_PROD_NAME == "超低碳").OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "铝镇静钢" && c_prod_name == "弹簧钢")
            {
                //只能排硅铝镇静钢的非轴承钢浇次计划或同类
                kpjc = wplst.Where(a => ((a.C_STL_GRD_TYPE == "硅铝镇静钢") || (a.C_STL_GRD_TYPE == "铝镇静钢" && a.C_PROD_NAME != "超低碳"))).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "铝镇静钢" && c_prod_name == "轴承钢")
            {
                //只能排硅铝镇静钢的非弹簧钢的浇次计划或同类
                kpjc = wplst.Where(a => ((a.C_STL_GRD_TYPE == "硅铝镇静钢" && a.C_PROD_NAME != "弹簧钢" && a.C_PROD_NAME != "轴承钢") || (a.C_STL_GRD_TYPE == "铝镇静钢" && a.C_PROD_NAME != "超低碳"))).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "铝镇静钢" && c_prod_name != "弹簧钢" && c_prod_name != "轴承钢" && c_prod_name != "超低碳")
            {
                //只能排硅铝镇静钢的非弹簧钢的浇次计划或同类
                kpjc = wplst.Where(a => ((a.C_STL_GRD_TYPE == "硅铝镇静钢" && a.C_PROD_NAME != "弹簧钢" && a.C_PROD_NAME != "轴承钢") || (a.C_STL_GRD_TYPE == "铝镇静钢"))).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            if (c_stl_type == "硅镇静钢" && c_prod_name != "轴承钢" && c_prod_name != "弹簧钢")
            {
                //只能排硅铝镇静钢的非弹簧钢的浇次计划或同类
                kpjc = wplst.Where(a => a.C_STL_GRD_TYPE == "硅铝镇静钢" && a.C_PROD_NAME != "弹簧钢" && a.C_PROD_NAME != "轴承钢").OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();
            }
            #endregion

            return kpjc;

        }
        #endregion

        #region 验证5#CCM钢种能否衔接
        /// <summary>
        /// 验证浇次计划之间的衔接
        /// </summary>
        /// <param name="lst">浇次计划</param>
        public List<Mod_TPP_LGPC_LSB> CheckPlan(List<Mod_TPP_LGPC_LSB> lst)
        {
            string c_stl_type = "";//钢类类
            string c_prod_name = "";//品名
            string str_rh = "";//是否过RH
            string c_remark = "";
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                c_stl_type = lst[i].C_STL_GRD_TYPE;
                c_prod_name = lst[i].C_PROD_NAME;
                str_rh = lst[i].C_RH;
                c_remark = lst[i].C_REMARK;
                if (i == 0)
                {
                    return lst;
                }
                if (c_stl_type == "铝镇静钢")
                {

                    if (lst[i - 1].C_STL_GRD_TYPE.Contains("硅铝镇静钢") && (lst[i - 1].C_PROD_NAME.Contains("轴承钢") || lst[i - 1].C_PROD_NAME.Contains("弹簧钢")))
                    {
                        lst[i].C_PROD_KIND = "钢种不能衔接";
                    }
                }

                if (c_prod_name == "弹簧钢" && str_rh == "N")
                {
                    if (!lst[i - 1].C_REMARK.Contains("82B"))
                    {
                        lst[i].C_PROD_KIND = "钢种不能衔接";
                    }
                }
                if (c_stl_type == "铝镇静钢" && c_prod_name.Contains("超低碳") && !c_remark.Contains("CH1T"))
                {
                    if (lst[i - 1].C_STL_GRD_TYPE != "铝镇静钢" && !lst[i - 1].C_PROD_NAME.Contains("超低碳"))
                    {
                        lst[i].C_PROD_KIND = "钢种不能衔接";
                    }
                }

                #region 验证大方坯能否缓冷

                #endregion

            }
            return lst;
        }

        #endregion

        #region 获取当前计划缓冷坑剩余容量
        /// <summary>
        ///当前浇次计划需大方坯缓冷时缓冷坑的剩余容量
        /// </summary>
        /// <param name="dtHLB">计划开始缓冷的时间</param>
        /// <param name="plan_qua">每炉计划支数</param>
        /// <returns>剩余总容量</returns>
        public int DHL_Left_Cap(DateTime dtHLB, int plan_qua)
        {
            #region 大方坯缓冷坑剩余容量
            int dhlrl = Convert.ToInt32(hl_acl.Where(a => a.C_SLAB_TYPE == "大方坯").Sum(a => a.N_CAP_QUA));//大方坯缓冷坑的总容量
            var dflrl = dhl_plan.Where(a => a.D_OVER_TIME > dtHLB);//当前浇次计划排产时还没有缓冷结束的缓冷计划
            int gg = dflrl.Count();
            if (gg==0)
            {
                return 0;
            }
            var g = dflrl.GroupBy(x => x.C_WH_CODE);
            var results = g.Select(x => new
            {
                Key = x.Key,
                Name = x.First().C_WH_CODE,
                Count = x.Sum(s => s.N_QUA)
            });
            foreach (var item in results)
            {
                string key = item.Key;
                string name = item.Name;

                if (name=="")
                {
                    return 0;
                }

                int cap = Convert.ToInt32(hl_acl.Where(a => a.C_WH_CODE == name).ToList()[0].N_CAP_QUA);
                int rl = Convert.ToInt32(item.Count);//已使用容量
                if ((cap - rl) < plan_qua)
                {
                    rl = cap;
                }
                dhlrl = dhlrl - rl;//大方坯缓冷坑的当前剩余容量
            }
            return dhlrl;
            #endregion

        }

        #endregion

        #region 获取当前计划可开坯剩余量
        /// <summary>
        ///获取当前时间剩余的可开坯计划量
        /// </summary>
        /// <param name="dtB">计划时间</param>
        /// <returns>剩余可开坯量</returns>
        public double Get_KP_Left(DateTime dtB)
        {
            return Convert.ToDouble(kp_plan.Where(a => a.D_CAN_START_TIME <= dtB && a.D_START_TIME > dtB).Sum(a => a.N_WGT));//当前时间可以开坯但是没有开坯的，是开坯库存量

        }


        #endregion

        #region 获取当前计划需缓冷的大方坯总支数
        /// <summary>
        ///获取当前浇次计划的大方坯需缓冷总支数
        /// </summary>
        /// <param name="c_id">浇次计划临时表主键</param>
        /// <param name="plan_qua">每炉计划大方坯支数</param>
        /// <returns>大方坯缓冷总支数</returns>
        public int jcjh_dhlzs(string c_id, int plan_qua)
        {

            var lc_plan_item = lc_plan.Where(a => a.C_FK == c_id).ToList();//当前浇次计划的炉次计划
            return lc_plan_item.Where(a => a.C_DFP_HL == "Y").ToList().Count * plan_qua;//当前浇次计划需入坑支数

        }
        #endregion

        #region 获取当前计划热轧钢坯缓冷坑剩余容量

        /// <summary>
        ///当前浇次计划需热轧坯缓冷时缓冷坑的剩余容量
        /// </summary>
        /// <param name="dtHL">计划开始缓冷的时间</param>
        /// <param name="plan_qua">每炉计划支数</param>
        /// <returns>剩余总容量</returns>
        public int HL_Left_Cap(DateTime dtHL, int plan_qua)
        {
            #region 大方坯缓冷坑剩余容量
            int hlrl = Convert.ToInt32(hl_acl.Where(a => a.C_SLAB_TYPE == "小方坯").Sum(a => a.N_CAP_QUA));//小方坯缓冷坑的总容量
            var flrl = dhl_plan.Where(a => a.D_OVER_TIME > dtHL);//当前浇次计划排产时还没有缓冷结束的缓冷计划
            var g = flrl.GroupBy(x => x.C_WH_CODE);
            var results = g.Select(x => new
            {
                Key = x.Key,
                Name = x.First().C_WH_CODE,
                Count = x.Sum(s => s.N_QUA)
            });
            foreach (var item in results)
            {
                string key = item.Key;
                string name = item.Name;
                if (name=="")
                {
                    return 0;
                }
                int cap = Convert.ToInt32(hl_acl.Where(a => a.C_WH_CODE == name).ToList()[0].N_CAP_QUA);
                int rl = Convert.ToInt32(item.Count);//已使用容量

                if ((cap - rl) < plan_qua)//坑容量不足一炉时标记已满
                {
                    rl = cap;
                }
                hlrl = hlrl - rl;//大方坯缓冷坑的当前剩余容量
            }
            return hlrl;
            #endregion

        }
        #endregion

        #region 获取当前计划需缓冷的热轧坯总支数
        /// <summary>
        ///获取当前浇次计划的大方坯需缓冷总支数
        /// </summary>
        /// <param name="c_id">浇次计划临时表主键</param>
        /// <param name="plan_qua">每炉计划热轧钢坯支数</param>
        /// <returns>大方坯缓冷总支数</returns>
        public int jcjh_hlzs(string c_id, int plan_qua)
        {

            var lc_plan_item = lc_plan.Where(a => a.C_FK == c_id).ToList();//当前浇次计划的炉次计划
            return lc_plan_item.Where(a => a.C_HL == "Y").ToList().Count * plan_qua;//当前浇次计划需入坑支数

        }
        #endregion

        #region 获取当前连铸已下浇次的最大浇次序号
        public Int64 GetMaxJCSort(string C_Ccm)
        {
            return 0;

        }

        #endregion

        #region 获取当前浇次计划待修磨量（可修磨时间）
        /// <summary>
        /// 修磨计划剩余计划量
        /// </summary>
        /// <param name="dt_xm">当前计划时间</param>
        /// <param name="type">修磨钢坯类型，碳钢、不锈钢</param>
        /// <param name="jscn">机时产能</param>
        /// <returns>剩余计划可执行时间</returns>
        public double xm_syl(DateTime dt_xm, string type, double jscn)
        {
            double xmjhl = Convert.ToDouble(xm_plan.Where(a => a.C_XM_TYPE == type && a.D_END_TIME >= dt_xm).Sum(a => a.N_WGT));//当前计划开始时已排计划的修磨剩余计划量
            return Math.Round(xmjhl / jscn, 2);
        }

        #endregion

        #region 获取5#连铸未排计划超低碳生产浇次数（含生产超低碳需要的过渡浇次数）

        /// <summary>
        /// 获取5#连铸未排超低碳计划连续生产的总时间（含生产超低碳需要的过渡浇次数）
        /// </summary>
        /// <param name="lst">5#连铸未排浇次计划</param>
        /// <returns>返回超低碳生产需要总时间</returns>
        public double GetCDTJH(List<Mod_TPP_LGPC_LSB> lst)
        {
            lst = lst.Where(a => (a.C_PROD_NAME == "超低碳钢" || a.C_STL_GRD == "DT4") && a.C_RH == "Y" && a.N_STATUS == 0).ToList();//过RH炉的超低碳钢 生产时含CHIT的浇次排第一个浇次 CH1T前可生产DT4
            if (lst.Count > 0)
            {
                return Convert.ToDouble(lst.Sum(a => a.N_ZJCLS) * lst.Max(a => a.N_MLZL) / lst.Min(a => a.N_JSCN));//连续生产过RH超低碳所需要的时间
            }
            else
            {
                return 0;
            }


        }

        #endregion

        #region 5#CCM浇次计划排产
        /// <summary>
        /// 5#CCM浇次计划排产
        /// </summary>
        /// <param name="lst">待排产5#连铸计划</param>
        /// <param name="RHNUM">排产开始前已下达计划的RH炉生产炉数</param>
        /// <param name="RHSM">RH炉寿命</param>
        /// <param name="c_stl_type">排产前已下达的上一个浇次计划的钢种类型</param>
        /// <param name="c_prod_name">排产前已下达的上一个浇次计划的钢种品名</param>
        /// <returns>排序结果</returns>
        public List<Mod_TPP_LGPC_LSB> Jc_plan_PC_5CCM(List<Mod_TPP_LGPC_LSB> lst, int RHNUM, int RHSM, DateTime dtB, string c_stl_type, string c_prod_name)
        {
            string strSFRH = "";

            #region 重新初始化各工序计划
            dhl_plan = bll_dhl.GetModelList(" AND N_STATUS<>2 ");//已排产大方坯缓冷未完成计划
            kp_plan = bll_kp.GetModelList("  AND N_STATUS<>2  ");//已排产大方坯开坯未完成
            hl_plan = bll_hl.GetModelList("  AND N_STATUS<>2  ");//已排产热轧坯缓冷未完成计划
            xm_plan = bll_xm.GetModelList("  AND N_STATUS<>2  ");//已排产修磨未完成计划
            sms_plan = bll_plan_sms.GetModelList(" N_CREAT_PLAN<3 ");//已排产未完成的计划
            hl_acl = bll_hl_act.GetModelList("");//已排产未完成的计划
            #endregion
            lst = lst.OrderByDescending(a => a.N_ORDER_LS).ToList();
            //当剩余计划中超低碳钢未开始生产时优先将需缓冷和需要修磨的计划提前排产并超出生产超低碳钢生产时间后排产超低碳的钢种
            //没有需要集中生产的钢种后，为了保证订单交期，在条件满足的前提下优先排产生产周期长，混交钢种多（设计订单钢种多）的浇次计划；
            int sort = 1;
            int lxls = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].N_SORT = null;
            }
            for (int i = 0; i < lst.Count; i++)
            {
                Mod_TPP_LGPC_LSB modpc = new Mod_TPP_LGPC_LSB();//实例需要排产的浇次计划

                #region 下一个排产浇次选择计划池
                //下一个排产浇次选择计划池
                var nestPlanlst = GetNextJC(lst.Where(a => a.N_STATUS == 0).ToList(), c_stl_type, c_prod_name).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();//从未排产lst中找可排产的浇次计划，按生产周期从长到短进行排序
                if (nestPlanlst.Count == 0)
                {
                    nestPlanlst = lst.Where(a => a.N_STATUS == 0).OrderByDescending(a => a.N_DFP_HL_TIME + a.N_HL_TIME + a.N_XM_TIME).ToList();//按生产周期从长到短进行排序

                }
                #endregion

                //在nestPlanlst中找出合适的浇次计划
                //大方坯缓冷坑是否可用（优先满坑）坑满排修磨
                int leftDFPcap = DHL_Left_Cap(dtB, 19);//当前大方坯缓冷坑剩余容量 19是每炉的计划钢坯支数
                //计算开坯计划结束时间
                double kp_left = Get_KP_Left(dtB);//计划排产时可开坯剩余量,警戒线设为1000T
                                                  //计算热轧坯缓冷坑是否可用(热送热轧的量不能超过缓冷坑量)
                double cdt_pro_time = GetCDTJH(lst);//剩余过RH过RH的超低碳生产时间（超低碳连续生产5天，修磨剩余时间准备6天以上，安全时间设置1天）
                //计算修磨是否能够衔接
                double xmsysj = xm_syl(dtB, "碳钢", 400 / 24);//当前计划开始时的修磨机剩余可修磨时间，400是修磨机的日产能
                                                            //有超低碳时修磨量先攒够开超低碳的时间
                #region 选择计划
                string sfXM = "Y";//是否安排修磨计划
                string sfHL = "Y";//热轧坯能否缓冷
                string nfDHL = "Y";//大方坯能否缓冷
                string nfRZ = "Y";//大方坯能否热装热轧并缓冷

                #region 判断是否优先过RH炉
                if (RHNUM < RHSM)
                {
                    var RHlst = nestPlanlst.Where(a => a.C_RH == "Y").OrderByDescending(a => a.N_RH).ToList();//查找合适的可以大方坯缓冷的浇次计划
                    if (RHlst.Count > 0)
                    {
                        nestPlanlst = nestPlanlst.Where(a => a.C_RH == "Y").OrderByDescending(a => a.N_RH).ToList();
                    }
                    else
                    {
                        nestPlanlst = nestPlanlst.Where(a => a.C_RH == "N").OrderByDescending(a => a.N_RH).ToList();
                    }
                }
                if (RHNUM >= RHSM)
                {
                    var RHlst = nestPlanlst.Where(a => a.C_RH == "N").OrderByDescending(a => a.N_RH).ToList();//查找合适的可以大方坯缓冷的浇次计划
                    if (RHlst.Count > 0)
                    {
                        nestPlanlst = nestPlanlst.Where(a => a.C_RH == "N").OrderByDescending(a => a.N_RH).ToList();
                    }
                    else
                    {
                        nestPlanlst = nestPlanlst.Where(a => a.C_RH == "Y").OrderByDescending(a => a.N_RH).ToList();
                    }
                }
                #endregion

                #region 能否安排大方坯缓冷的浇次计划
                if (kp_left <= 1000)
                {
                    nfDHL = "N";//保证开坯连续
                    var dhllst = nestPlanlst.Where(a => a.C_DFP_HL == "N").OrderByDescending(a => a.N_DHL).ToList();//查找合适的可以大方坯缓冷的浇次计划
                    if (dhllst.Count > 0)
                    {
                        nestPlanlst = nestPlanlst.Where(a => a.C_DFP_HL == "N").OrderByDescending(a => a.N_DHL).ToList();//查找合适的可以大方坯缓冷的浇次计划
                    }
                    else
                    {
                        //yc_remark = yc_remark + "~开坯计划不能连续";//排产异常备注
                        nestPlanlst = nestPlanlst.Where(a => a.C_DFP_HL == "Y").OrderByDescending(a => a.N_DHL).ToList();//查找合适的可以大方坯缓冷的浇次计划
                    }
                }
                else
                {
                    //yc_remark = yc_remark + "~开坯计划不能连续";//排产异常备注
                    var nlst = nestPlanlst.Where(a => a.C_DFP_HL == "Y" && a.N_DHL * 19 <= leftDFPcap).OrderByDescending(a => a.N_DHL).ToList();//查找合适的可以大方坯缓冷的浇次计划
                    if (nlst.Count == 0)
                    {
                        nfDHL = "N";//大方坯缓冷坑容量不够
                        nestPlanlst = nestPlanlst.Where(a => a.C_DFP_HL == "N" || (a.C_DFP_HL == "Y" && a.N_DHL * 19 > leftDFPcap)).ToList();//查找合适的可以大方坯缓冷的浇次计划
                        //yc_remark = yc_remark + "~没有足够的大方坯缓冷坑";//排产异常备注
                    }
                    else
                    {
                        nestPlanlst = nestPlanlst.Where(a => a.C_DFP_HL == "Y" && a.N_DHL * 19 <= leftDFPcap).OrderByDescending(a => a.N_DHL).ToList();//查找合适的可以大方坯缓冷的浇次计划
                    }
                }
                #endregion

                #region 排产计划时有没有预留的热轧坯缓冷坑
                int leftHLcap = 0;//当前浇次计划可用的热轧钢坯缓冷坑
                if (nfDHL == "N")
                {
                    leftHLcap = HL_Left_Cap(dtB, 38);//当前浇次计划可用的热轧钢坯缓冷坑
                }
                else
                {
                    leftHLcap = HL_Left_Cap(dtB.AddHours(72), 38);//将热轧坯入坑时间延后72小时
                }
                var dhllst2 = nestPlanlst.Where(a => a.C_HL == "Y" && a.N_DFP_RZ * 38 <= leftHLcap).OrderByDescending(a => a.N_DHL).ToList();//验证热送热轧时热轧钢坯缓冷坑是否有容量
                if (dhllst2.Count == 0)
                {
                    sfHL = "N";
                    nestPlanlst = nestPlanlst.Where(a => a.C_HL == "N").OrderByDescending(a => a.N_DHL).ToList();//验证
                }
                else
                {
                    sfHL = "Y";
                    nestPlanlst = nestPlanlst.Where(a => a.C_HL == "Y" && a.N_DFP_RZ * 38 <= leftHLcap).OrderByDescending(a => a.N_DHL).ToList();//验证
                }
                #endregion

                #region 是否安排需要修磨的计划
                var cdtlst = nestPlanlst.Where(a => a.C_PROD_NAME == "超低碳钢").ToList();
                if (cdtlst.Count > 0)//有过RH的超低碳钢未排
                {
                    int leftxm = Convert.ToInt32(nestPlanlst.Where(a => a.C_XM == "Y").Sum(a => a.N_XM));//剩余计划的修磨炉数
                    if (leftxm > 0)
                    {
                        if (strSFRH == "Y" && sfHL == "N" && nfDHL == "N" && xmsysj > cdt_pro_time + 150)
                        {
                            //生产超低碳
                            nestPlanlst = nestPlanlst.Where(a => a.C_PROD_NAME == "超低碳钢").ToList();
                        }
                        else
                        {
                            nestPlanlst = nestPlanlst.Where(a => a.C_XM == "Y").ToList();
                        }
                    }
                    else
                    {
                        if (strSFRH == "Y" && sfHL == "N" && nfDHL == "N")//超低碳
                        {
                            nestPlanlst = nestPlanlst.Where(a => a.C_PROD_NAME == "超低碳钢").ToList();
                        }
                    }

                }
                else//没有超低碳计划
                {
                    if (xmsysj > 150)//设定150为修磨安全警戒线，先不安排修磨计划
                    {
                        var xmlst = nestPlanlst.Where(a => a.C_XM == "N").ToList();
                        if (xmlst.Count > 0)
                        {
                            nestPlanlst = nestPlanlst.Where(a => a.C_XM == "N").ToList();
                        }
                    }
                    else//必须安排修磨计划
                    {
                        var xmlst = nestPlanlst.Where(a => a.C_XM == "Y").ToList();
                        if (xmlst.Count > 0)
                        {
                            nestPlanlst = nestPlanlst.Where(a => a.C_XM == "Y").ToList();
                        }

                    }
                }

                #endregion


                #endregion
                if (nestPlanlst.Count > 0)
                {
                    modpc = nestPlanlst[0];
                    #region 在list中将待排产的浇次排产
                    for (int j = 0; j < lst.Count; j++)
                    {
                        if (lst[j].C_ID == modpc.C_ID)
                        {
                            c_stl_type = modpc.C_STL_GRD_TYPE;
                            c_prod_name = modpc.C_PROD_NAME;
                            lst[j].N_STATUS = 1;
                            lst[j].N_SORT = sort;
                            // lst[j].C_PROD_KIND = yc_remark;
                            lst[j].D_P_START_TIME = dtB;
                            lst[j].D_P_END_TIME = dtB.AddHours(Math.Round(Convert.ToDouble(lst[j].N_ZJCLS * lst[j].N_MLZL / lst[j].N_JSCN), 2));
                            RHNUM = RHNUM + Convert.ToInt32(lst[j].N_RH);
                            var lst_lc = lc_plan.Where(a => a.C_FK == lst[j].C_ID).ToList();
                            if (lst_lc.Count > 0)
                            {
                                #region 将炉次计划的工序计划插入到工序计划list表中
                                DateTime D_P_START_TIME = (DateTime)lst[j].D_P_START_TIME;
                                for (int lc = 0; lc < lst_lc.Count; lc++)
                                {
                                    #region 更新炉次计划时间
                                    lst_lc[lc].N_SORT = lc + 1;
                                    lst_lc[lc].N_JC_SORT = lst[j].N_SORT;
                                    lst_lc[lc].N_USE_WGT = lst_lc[lc].N_SLAB_WGT;
                                    lst_lc[lc].D_P_START_TIME = D_P_START_TIME;
                                    lst_lc[lc].D_P_END_TIME = D_P_START_TIME.AddHours(Convert.ToDouble(lst_lc[lc].N_SLAB_WGT / lst_lc[lc].N_JSCN));
                                    D_P_START_TIME = (DateTime)lst_lc[lc].D_P_END_TIME;
                                    #endregion
                                    #region 插入大方坯缓冷计划
                                    if (lst_lc[lc].C_DFP_HL == "Y")
                                    {
                                        DateTime? D_OVER_TIME = null;//进入坑的坑的结束时间
                                        Mod_TPA_DHL_PLAN mod_dhl = new Mod_TPA_DHL_PLAN();
                                        mod_dhl.C_ID = System.Guid.NewGuid().ToString();
                                        mod_dhl.C_FK = lst_lc[lc].C_ID;
                                        mod_dhl.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                                        mod_dhl.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                                        mod_dhl.C_CCM = lst_lc[lc].C_CCM_DESC;
                                        mod_dhl.C_HLYQ = lst_lc[lc].C_DFP_YQ;
                                        mod_dhl.N_HL_TIME = lst_lc[lc].N_DFP_HL_TIME;
                                        mod_dhl.N_QUA = 19;
                                        mod_dhl.C_HLYQ = lst_lc[lc].C_DFP_YQ;
                                        mod_dhl.D_START_TIME = Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2);
                                        mod_dhl.D_END_TIME = Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2).AddHours(Convert.ToDouble(mod_dhl.N_HL_TIME));//计划缓冷结束时间
                                        var lstdhl = dhl_plan.Where(a => a.D_OVER_TIME > mod_dhl.D_START_TIME && a.C_WH_CODE != "0" && a.D_START_TIME < mod_dhl.D_START_TIME).GroupBy(a => new { a.C_WH_CODE, a.N_NUM }).Select(a => new { wh = a.First().C_WH_CODE, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), num = a.Max(p => p.N_NUM), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.left >= mod_dhl.N_QUA).OrderByDescending(a => a.over_time).ToList();//查找缓冷未结束的有空闲的坑按缓冷结束时间倒序;
                                        if (lstdhl.Count > 0)
                                        {
                                            mod_dhl.C_WH_CODE = lstdhl[0].wh;
                                            mod_dhl.N_TOTAL_QUA = 19 + lstdhl[0].total_qua;
                                            mod_dhl.N_NUM = lstdhl[0].num;
                                            mod_dhl.N_CAP = lstdhl[0].cap;
                                            D_OVER_TIME = lstdhl[0].over_time;

                                            if (mod_dhl.D_END_TIME > lstdhl[0].over_time)
                                            {
                                                D_OVER_TIME = mod_dhl.D_END_TIME;
                                            }
                                            mod_dhl.D_OVER_TIME = D_OVER_TIME;
                                            dhl_plan.Add(mod_dhl);
                                            //跟新当前坑的结束时间
                                            var lstUpdateOverTime = dhl_plan.Where(a => a.C_WH_CODE == mod_dhl.C_WH_CODE && a.N_NUM == mod_dhl.N_NUM).ToList();
                                            for (int k = 0; k < lstUpdateOverTime.Count; k++)
                                            {
                                                foreach (var item in dhl_plan)
                                                {
                                                    if (item.C_ID == lstUpdateOverTime[k].C_ID)
                                                    {
                                                        item.D_OVER_TIME = D_OVER_TIME;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            var lstdhl2 = dhl_plan.Where(a => a.C_WH_CODE != "0").GroupBy(a => new { a.C_WH_CODE }).Select(a => new { wh = a.First().C_WH_CODE, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), num = a.Max(p => p.N_NUM), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.over_time < mod_dhl.D_START_TIME).OrderBy(a => a.over_time).ToList();//查找已缓冷结束的坑
                                            if (lstdhl2.Count > 0)
                                            {
                                                mod_dhl.C_WH_CODE = lstdhl2[0].wh;
                                                mod_dhl.N_TOTAL_QUA = 19;
                                                mod_dhl.N_NUM = lstdhl2[0].num + 1;
                                                D_OVER_TIME = mod_dhl.D_END_TIME;
                                                mod_dhl.N_CAP = lstdhl2[0].cap;
                                                mod_dhl.D_OVER_TIME = D_OVER_TIME;
                                                dhl_plan.Add(mod_dhl);
                                                //更新当前坑的结束时间

                                            }
                                            else
                                            {
                                                var list1 = dhl_plan.GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();
                                                var list2 = hl_acl.Where(a => a.C_SLAB_TYPE == "大方坯" && a.N_QUA == 0).GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();

                                                var expectedList = list2.Except(list1).ToList().OrderBy(a => a.C_WH_CODE).ToList();

                                                //从没有使用过的缓冷坑找一个坑使用
                                                var lstdhl_act = hl_acl.Where(a => a.C_WH_CODE == expectedList[0].C_WH_CODE).ToList();
                                                if (lstdhl_act.Count > 0)
                                                {
                                                    foreach (var item in hl_acl)
                                                    {
                                                        if (item.C_ID == lstdhl_act[0].C_ID)
                                                        {
                                                            item.N_QUA = Convert.ToDecimal(mod_dhl.N_QUA);
                                                        }
                                                    }

                                                    mod_dhl.C_WH_CODE = expectedList[0].C_WH_CODE;
                                                    mod_dhl.N_TOTAL_QUA = 19;
                                                    mod_dhl.N_CAP = lstdhl_act[0].N_CAP_QUA;
                                                    mod_dhl.N_NUM = dhl_plan.Where(a => a.C_WH_CODE == mod_dhl.C_WH_CODE).Max(a => a.N_NUM) == null ? 0 : dhl_plan.Where(a => a.C_WH_CODE == mod_dhl.C_WH_CODE).Max(a => a.N_NUM) + 1;
                                                    mod_dhl.D_OVER_TIME = mod_dhl.D_END_TIME;
                                                    dhl_plan.Add(mod_dhl);
                                                }
                                                else
                                                {
                                                    hl_acl[0].N_QUA = Convert.ToDecimal(mod_dhl.N_QUA);
                                                    mod_dhl.C_WH_CODE = "0";
                                                    mod_dhl.N_TOTAL_QUA = 19;
                                                    mod_dhl.N_CAP = 10000;
                                                    mod_dhl.N_NUM = 1;
                                                    mod_dhl.D_OVER_TIME = mod_dhl.D_END_TIME;
                                                    dhl_plan.Add(mod_dhl);
                                                }
                                            }
                                        }

                                        lst_lc[lc].D_DFPHL_START_TIME = mod_dhl.D_START_TIME;
                                        lst_lc[lc].D_DFPHL_END_TIME = mod_dhl.D_OVER_TIME;

                                    }
                                    #endregion
                                    #region 插入开坯计划
                                    Mod_TPA_KP_PLAN mod_kp = new Mod_TPA_KP_PLAN();
                                    mod_kp.C_ID = System.Guid.NewGuid().ToString();
                                    mod_kp.C_FK = lst_lc[lc].C_ID;
                                    mod_kp.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                                    mod_kp.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                                    mod_kp.C_CCM = lst_lc[lc].C_CCM_DESC;
                                    mod_kp.D_CAN_START_TIME = lst_lc[lc].C_DFP_HL == "Y" ? Convert.ToDateTime(lst_lc[lc].D_DFPHL_END_TIME).AddHours(1) : Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2);//可开坯时间
                                    mod_kp.N_WGT = lst_lc[lc].N_SLAB_WGT;
                                    mod_kp.N_CN = 114;//机时产能
                                    mod_kp.C_DHL = lst_lc[lc].C_HL;//热轧钢坯是否缓冷
                                    mod_kp.C_DFP_RZ = lst_lc[lc].C_DFP_RZ;//大方坯是否热装
                                    mod_kp.C_DFP_YQ = lst_lc[lc].C_DFP_YQ;//大方坯缓冷要求
                                    mod_kp.C_MATRL_CODE_SLAB = lst_lc[lc].C_MATRL_NO;
                                    mod_kp.C_MATRL_NAME_SLAB = lst_lc[lc].C_MATRL_NAME;
                                    mod_kp.C_MATRL_CODE_KP = lst_lc[lc].C_MATRL_CODE_KP;
                                    mod_kp.C_MATRL_NAME_KP = lst_lc[lc].C_MATRL_NAME_KP;
                                    mod_kp.C_KP_SIZE = lst_lc[lc].C_KP_SIZE;
                                    mod_kp.N_KP_LENGTH = lst_lc[lc].N_KP_LENGTH;
                                    mod_kp.N_KP_PW = lst_lc[lc].N_KP_PW;
                                    mod_kp.N_SLAB_LENGTH = Convert.ToDecimal(lst_lc[lc].C_SLAB_LENGTH);
                                    mod_kp.C_SLAB_SIZE = lst_lc[lc].C_SLAB_SIZE;
                                    mod_kp.N_SLAB_PW = lst_lc[lc].N_SLAB_PW;

                                    if (mod_kp.C_DFP_RZ == "Y" || mod_kp.C_DFP_YQ.Trim() != "")
                                    {
                                        //必需热轧
                                        DateTime? dtjhkssj = null;
                                        var lstlastkp = kp_plan.Where(a => a.D_START_TIME <= Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2)).ToList();
                                        if (lstlastkp.Count > 0)
                                        {
                                            dtjhkssj = (DateTime)kp_plan.Where(a => a.D_START_TIME <= Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2)).Max(a => a.D_END_TIME);
                                            if (dtjhkssj < Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2))
                                            {
                                                dtjhkssj = Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2);
                                            }
                                            mod_kp.N_SORT = kp_plan.Where(a => a.D_START_TIME <= Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2)).Max(a => a.N_SORT) + 1;//开坯计划排序号
                                        }
                                        else
                                        {
                                            mod_kp.N_SORT = 1;

                                        }

                                        mod_kp.D_START_TIME = dtjhkssj;//开坯计划开始时间
                                        try
                                        {
                                            mod_kp.D_END_TIME = ((DateTime)dtjhkssj).AddHours((double)(mod_kp.N_WGT / mod_kp.N_CN));//开坯计划结束时间
                                        }
                                        catch (Exception)
                                        {

                                            mod_kp.D_END_TIME = Convert.ToDateTime(mod_kp.D_START_TIME).AddHours(0.5);
                                        }

                                        //将当前计划之后的计划时间全都重新计算
                                        var updatelist = kp_plan.Where(a => a.N_SORT > mod_kp.N_SORT - 1).OrderBy(a => a.N_SORT).ToList();
                                        if (updatelist.Count > 0)
                                        {
                                            DateTime dtB2 = (DateTime)mod_kp.D_END_TIME;
                                            for (int m = 0; m < updatelist.Count; m++)
                                            {
                                                updatelist[m].N_SORT = updatelist[m].N_SORT + 1;
                                                updatelist[m].D_START_TIME = dtB2;
                                                updatelist[m].D_END_TIME = dtB2.AddHours((double)(updatelist[m].N_WGT / updatelist[m].N_CN));
                                                dtB2 = (DateTime)updatelist[m].D_END_TIME;
                                                foreach (var item in kp_plan)
                                                {
                                                    if (item.C_ID == updatelist[m].C_ID)
                                                    {
                                                        item.N_SORT = updatelist[m].N_SORT;
                                                        item.D_START_TIME = updatelist[m].D_START_TIME;
                                                        item.D_END_TIME = updatelist[m].D_END_TIME;
                                                    }
                                                }

                                            }

                                        }

                                    }
                                    else
                                    {
                                        int kpsort = 0;
                                        DateTime dtjhkssj = (DateTime)mod_kp.D_CAN_START_TIME;
                                        if (kp_plan.Count == 0)
                                        {
                                            dtjhkssj = (DateTime)mod_kp.D_CAN_START_TIME;
                                        }
                                        else
                                        {
                                            dtjhkssj = (DateTime)kp_plan.Max(a => a.D_END_TIME);
                                            kpsort = (int)kp_plan.Max(a => a.N_SORT);
                                        }
                                        if (dtjhkssj < mod_kp.D_CAN_START_TIME)
                                        {
                                            dtjhkssj = (DateTime)mod_kp.D_CAN_START_TIME;
                                        }
                                        mod_kp.N_SORT = kpsort + 1;//开坯计划排序号
                                        mod_kp.D_START_TIME = dtjhkssj;//开坯计划开始时间
                                        mod_kp.D_END_TIME = dtjhkssj.AddHours((double)(mod_kp.N_WGT / mod_kp.N_CN));//开坯计划结束时间
                                    }
                                    kp_plan.Add(mod_kp);
                                    lst_lc[lc].D_KP_START_TIME = mod_kp.D_START_TIME;
                                    lst_lc[lc].D_KP_END_TIME = mod_kp.D_END_TIME;
                                    if (lst_lc[lc].C_HL == "N" && lst_lc[lc].C_XM == "N")
                                    {
                                        lst_lc[lc].D_CAN_USE_TIME = ((DateTime)mod_kp.D_START_TIME).AddHours(2);
                                    }
                                    #endregion
                                    #region 插入热轧坯缓冷计划
                                    if (lst_lc[lc].C_HL == "Y")
                                    {
                                        DateTime? D_OVER_TIME = null;//进入坑的坑的结束时间
                                        Mod_TPA_HL_PLAN mod_hl = new Mod_TPA_HL_PLAN();
                                        mod_hl.C_ID = System.Guid.NewGuid().ToString();
                                        mod_hl.C_FK = lst_lc[lc].C_ID;
                                        mod_hl.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                                        mod_hl.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                                        mod_hl.C_CCM = lst_lc[lc].C_CCM_DESC;
                                        mod_hl.C_HLYQ = lst_lc[lc].C_RZP_YQ;
                                        mod_hl.N_HL_TIME = lst_lc[lc].N_HL_TIME;
                                        mod_hl.N_QUA = 38;
                                        mod_hl.C_HLYQ = lst_lc[lc].C_DFP_YQ;
                                        mod_hl.D_START_TIME = Convert.ToDateTime(lst_lc[lc].D_KP_START_TIME).AddHours(2);
                                        mod_hl.D_END_TIME = Convert.ToDateTime(lst_lc[lc].D_KP_START_TIME).AddHours(2).AddHours(Convert.ToDouble(mod_hl.N_HL_TIME));//计划缓冷结束时间

                                        var lstdhl = hl_plan.Where(a => a.D_OVER_TIME > mod_hl.D_START_TIME && a.C_WH_CODE != "0" && a.D_START_TIME < mod_hl.D_START_TIME).GroupBy(a => new { a.C_WH_CODE, a.N_NUM }).Select(a => new { wh = a.First().C_WH_CODE, num = a.First().N_NUM, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.left >= mod_hl.N_QUA).OrderByDescending(a => a.over_time).ToList();//查找缓冷未结束的有空闲的坑按缓冷结束时间倒序;
                                        if (lstdhl.Count > 0)
                                        {
                                            mod_hl.C_WH_CODE = lstdhl[0].wh;
                                            mod_hl.N_TOTAL_QUA = 38 + lstdhl[0].total_qua;
                                            mod_hl.N_NUM = lstdhl[0].num;
                                            mod_hl.N_CAP = lstdhl[0].cap;
                                            D_OVER_TIME = lstdhl[0].over_time;
                                            if (mod_hl.D_END_TIME > lstdhl[0].over_time)
                                            {
                                                D_OVER_TIME = mod_hl.D_END_TIME;
                                            }
                                            mod_hl.D_OVER_TIME = D_OVER_TIME;
                                            hl_plan.Add(mod_hl);
                                            //跟新当前坑的结束时间
                                            var lstUpdateOverTime = hl_plan.Where(a => a.C_WH_CODE == mod_hl.C_WH_CODE && a.N_NUM == mod_hl.N_NUM).ToList();
                                            for (int k = 0; k < lstUpdateOverTime.Count; k++)
                                            {
                                                foreach (var item in hl_plan)
                                                {
                                                    if (item.C_ID == lstUpdateOverTime[k].C_ID)
                                                    {
                                                        item.D_OVER_TIME = D_OVER_TIME;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            var lstdhl2 = hl_plan.Where(a => a.C_WH_CODE != "0").GroupBy(a => new { a.C_WH_CODE }).Select(a => new { wh = a.First().C_WH_CODE, num = a.First().N_NUM, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.over_time < mod_hl.D_START_TIME).OrderBy(a => a.over_time).ToList();//查找缓冷坑缓冷已结束的坑
                                            if (lstdhl2.Count > 0)
                                            {
                                                mod_hl.C_WH_CODE = lstdhl2[0].wh;
                                                mod_hl.N_TOTAL_QUA = 38;
                                                mod_hl.N_NUM = lstdhl2[0].num + 1;
                                                D_OVER_TIME = mod_hl.D_END_TIME;
                                                mod_hl.N_CAP = lstdhl2[0].cap;
                                                mod_hl.D_OVER_TIME = D_OVER_TIME;
                                                hl_plan.Add(mod_hl);
                                                //更新当前坑的结束时间

                                            }
                                            else
                                            {
                                                var list1 = hl_plan.GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();
                                                var list2 = hl_acl.Where(a => a.C_SLAB_TYPE == "小方坯" && a.N_QUA == 0).GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();

                                                var expectedList = list2.Except(list1).ToList().OrderBy(a => a.C_WH_CODE).ToList();
                                                if (expectedList.Count > 0)
                                                {
                                                    //从没有使用过的缓冷坑找一个坑使用
                                                    var lstdhl_act = hl_acl.Where(a => a.C_WH_CODE == expectedList[0].C_WH_CODE).ToList();
                                                    if (lstdhl_act.Count > 0)
                                                    {
                                                        foreach (var item in hl_acl)
                                                        {
                                                            if (item.C_ID == lstdhl_act[0].C_ID)
                                                            {
                                                                item.N_QUA = Convert.ToDecimal(mod_hl.N_QUA);
                                                            }
                                                        }
                                                        //从没有使用过的缓冷坑找一个坑使用
                                                        mod_hl.C_WH_CODE = expectedList[0].C_WH_CODE;
                                                        mod_hl.N_TOTAL_QUA = 38;
                                                        mod_hl.N_CAP = lstdhl_act[0].N_CAP_QUA;
                                                        mod_hl.N_NUM = dhl_plan.Where(a => a.C_WH_CODE == mod_hl.C_WH_CODE).Max(a => a.N_NUM) == null ? 0 : dhl_plan.Where(a => a.C_WH_CODE == mod_hl.C_WH_CODE).Max(a => a.N_NUM) + 1;
                                                        mod_hl.D_OVER_TIME = mod_hl.D_END_TIME;
                                                        hl_plan.Add(mod_hl);
                                                    }
                                                    else
                                                    {
                                                        hl_acl[0].N_QUA = Convert.ToDecimal(mod_hl.N_QUA);
                                                        mod_hl.C_WH_CODE = "0";
                                                        mod_hl.N_TOTAL_QUA = 38;
                                                        mod_hl.N_CAP = 10000;
                                                        mod_hl.N_NUM = 1;
                                                        mod_hl.D_OVER_TIME = mod_hl.D_END_TIME;
                                                        hl_plan.Add(mod_hl);
                                                    }
                                                }
                                                else
                                                {
                                                    hl_acl[0].N_QUA = Convert.ToDecimal(mod_hl.N_QUA);
                                                    mod_hl.C_WH_CODE = "0";
                                                    mod_hl.N_TOTAL_QUA = 38;
                                                    mod_hl.N_CAP = 10000;
                                                    mod_hl.N_NUM = 1;
                                                    mod_hl.D_OVER_TIME = mod_hl.D_END_TIME;
                                                    hl_plan.Add(mod_hl);
                                                }
                                            }
                                        }

                                        lst_lc[lc].D_HL_START_TIME = mod_hl.D_START_TIME;
                                        lst_lc[lc].D_HL_END_TIME = mod_hl.D_OVER_TIME;
                                        if (lst_lc[lc].C_XM == "N")
                                        {
                                            lst_lc[lc].D_CAN_USE_TIME = ((DateTime)mod_hl.D_OVER_TIME).AddHours(2);
                                        }

                                    }
                                    #endregion
                                    #region 插入修磨计划
                                    if (lst_lc[lc].C_XM == "Y")
                                    {
                                        Mod_TPA_XM_PLAN mod_xm = new Mod_TPA_XM_PLAN();
                                        mod_xm.C_ID = System.Guid.NewGuid().ToString();
                                        mod_xm.C_FK = lst_lc[lc].C_ID;
                                        mod_xm.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                                        mod_xm.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                                        mod_xm.C_CCM = lst_lc[lc].C_CCM_DESC;
                                        mod_xm.D_PLAN_DATE = lst_lc[lc].C_HL == "Y" ? Convert.ToDateTime(lst_lc[lc].D_HL_END_TIME).AddHours(1) : Convert.ToDateTime(lst_lc[lc].D_KP_END_TIME).AddHours(12);//可修磨时间
                                        mod_xm.N_WGT = lst_lc[lc].N_SLAB_WGT;
                                        mod_xm.C_XM_TYPE = "碳钢";
                                        mod_xm.N_CN = 400 / 24;//机时产能
                                        mod_xm.C_XMYQ = lst_lc[lc].C_XM;
                                        DateTime maxxmtime = (DateTime)mod_xm.D_PLAN_DATE;
                                        DateTime? kcxmtime = xm_plan.Where(a => a.C_XM_TYPE == "碳钢").Max(a => a.D_END_TIME);//找出已排计划最大修磨结束时间
                                        if (kcxmtime != null && kcxmtime >= maxxmtime)
                                        {
                                            maxxmtime = (DateTime)kcxmtime;
                                        }
                                        mod_xm.D_START_TIME = maxxmtime;
                                        mod_xm.D_END_TIME = maxxmtime.AddHours((double)(mod_xm.N_WGT / mod_xm.N_CN));
                                        xm_plan.Add(mod_xm);

                                        lst_lc[lc].D_XM_START_TIME = mod_xm.D_START_TIME;
                                        lst_lc[lc].D_XM_END_TIME = mod_xm.D_END_TIME;
                                        lst_lc[lc].D_CAN_USE_TIME = ((DateTime)mod_xm.D_END_TIME).AddHours(2);

                                    }
                                    #endregion
                                }
                                #endregion
                            }

                            if (RHNUM >= RHSM)
                            {
                                if (lst[j].C_RH == "N")
                                {
                                    RHNUM = 0;
                                    lst[j].C_RH_SFJS = "Y";
                                }
                            }
                            sort = sort + 1;
                            if (c_stl_type != "超低碳钢")
                            {
                                lxls = lxls + Convert.ToInt32(lst[j].N_ZJCLS);
                            }
                            if (lxls >= 32)
                            {
                                lst[j].N_PRODUCE_TIME = 4;//化冷钢时间
                                lxls = 0;
                            }
                            dtB = Convert.ToDateTime(lst[j].D_P_END_TIME).AddHours(Convert.ToDouble(lst[j].N_PRODUCE_TIME));
                            break;
                        }
                    }
                    #endregion
                }
            }
            return lst;
        }
        #endregion

        #region 更新各个工序计划LIST
        public List<Mod_TPP_LGPC_LSB> Sort_GX_Plan(List<Mod_TPP_LGPC_LSB> lst)
        {
            #region 重新初始化各工序计划
            dhl_plan = bll_dhl.GetModelList(" AND N_STATUS<>2 ");//已排产大方坯缓冷未完成计划
            kp_plan = bll_kp.GetModelList("  AND N_STATUS<>2  ");//已排产大方坯开坯未完成
            hl_plan = bll_hl.GetModelList("  AND N_STATUS<>2  ");//已排产热轧坯缓冷未完成计划
            xm_plan = bll_xm.GetModelList("  AND N_STATUS<>2  ");//已排产修磨未完成计划
            sms_plan = bll_plan_sms.GetModelList(" N_CREAT_PLAN<3 ");//已排产未完成的计划
            hl_acl = bll_hl_act.GetModelList("");//已排产未完成的计划
            #endregion
            #region 在list中将待排产的浇次排产
            for (int j = 0; j < lst.Count; j++)
            {
                List<Mod_TPP_LGPC_LCLSB> lst_lc = bll_lc.GetModelListByJcID(lst[j].C_ID);
                if (lst_lc.Count > 0)
                {
                    #region 将炉次计划的工序计划插入到工序计划list表中
                    DateTime D_P_START_TIME = (DateTime)lst[j].D_P_START_TIME;
                    for (int lc = 0; lc < lst_lc.Count; lc++)
                    {
                        #region 更新炉次计划时间
                        lst_lc[lc].N_SORT = lc + 1;
                        lst_lc[lc].N_JC_SORT = lst[j].N_SORT;
                        lst_lc[lc].N_USE_WGT = lst_lc[lc].N_SLAB_WGT;
                        lst_lc[lc].D_P_START_TIME = D_P_START_TIME;
                        lst_lc[lc].D_P_END_TIME = D_P_START_TIME.AddHours(Convert.ToDouble(lst_lc[lc].N_SLAB_WGT / lst_lc[lc].N_JSCN));
                        D_P_START_TIME = (DateTime)lst_lc[lc].D_P_END_TIME;
                        foreach (var item in lc_plan)
                        {
                            if (item.C_ID == lst_lc[lc].C_ID)
                            {
                                item.N_JC_SORT = lst_lc[lc].N_SORT;
                                item.N_JC_SORT = lst_lc[lc].N_JC_SORT;
                                item.D_P_START_TIME = lst_lc[lc].D_P_START_TIME;
                                item.D_P_END_TIME = lst_lc[lc].D_P_END_TIME;
                                item.N_USE_WGT = lst_lc[lc].N_USE_WGT;
                                bll_lc.Update(item);
                            }
                        }
                        #endregion
                        #region 插入大方坯缓冷计划
                        if (lst_lc[lc].C_DFP_HL == "Y")
                        {
                            DateTime? D_OVER_TIME = null;//进入坑的坑的结束时间
                            Mod_TPA_DHL_PLAN mod_dhl = new Mod_TPA_DHL_PLAN();
                            mod_dhl.C_ID = System.Guid.NewGuid().ToString();
                            mod_dhl.C_FK = lst_lc[lc].C_ID;
                            mod_dhl.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                            mod_dhl.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                            mod_dhl.C_CCM = lst_lc[lc].C_CCM_DESC;
                            mod_dhl.C_HLYQ = lst_lc[lc].C_DFP_YQ;
                            mod_dhl.N_HL_TIME = lst_lc[lc].N_DFP_HL_TIME;
                            mod_dhl.N_QUA = 19;
                            mod_dhl.C_HLYQ = lst_lc[lc].C_DFP_YQ;
                            mod_dhl.D_START_TIME = Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2);
                            mod_dhl.D_END_TIME = Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2).AddHours(Convert.ToDouble(mod_dhl.N_HL_TIME));//计划缓冷结束时间
                            var lstdhl = dhl_plan.Where(a => a.D_OVER_TIME > mod_dhl.D_START_TIME && a.C_WH_CODE != "0" && a.D_START_TIME < mod_dhl.D_START_TIME).GroupBy(a => new { a.C_WH_CODE, a.N_NUM }).Select(a => new { wh = a.First().C_WH_CODE, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), num = a.Max(p => p.N_NUM), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.left >= mod_dhl.N_QUA).OrderByDescending(a => a.over_time).ToList();//查找缓冷未结束的有空闲的坑按缓冷结束时间倒序;
                            if (lstdhl.Count > 0)
                            {
                                mod_dhl.C_WH_CODE = lstdhl[0].wh;
                                mod_dhl.N_TOTAL_QUA = 19 + lstdhl[0].total_qua;
                                mod_dhl.N_NUM = lstdhl[0].num;
                                mod_dhl.N_CAP = lstdhl[0].cap;
                                D_OVER_TIME = lstdhl[0].over_time;

                                if (mod_dhl.D_END_TIME > lstdhl[0].over_time)
                                {
                                    D_OVER_TIME = mod_dhl.D_END_TIME;
                                }
                                mod_dhl.D_OVER_TIME = D_OVER_TIME;
                                dhl_plan.Add(mod_dhl);
                                //跟新当前坑的结束时间
                                var lstUpdateOverTime = dhl_plan.Where(a => a.C_WH_CODE == mod_dhl.C_WH_CODE && a.N_NUM == mod_dhl.N_NUM).ToList();
                                for (int k = 0; k < lstUpdateOverTime.Count; k++)
                                {
                                    foreach (var item in dhl_plan)
                                    {
                                        if (item.C_ID == lstUpdateOverTime[k].C_ID)
                                        {
                                            item.D_OVER_TIME = D_OVER_TIME;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                var lstdhl2 = dhl_plan.Where(a => a.C_WH_CODE != "0").GroupBy(a => new { a.C_WH_CODE }).Select(a => new { wh = a.First().C_WH_CODE, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), num = a.Max(p => p.N_NUM), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.over_time < mod_dhl.D_START_TIME).OrderBy(a => a.over_time).ToList();//查找已缓冷结束的坑
                                if (lstdhl2.Count > 0)
                                {
                                    mod_dhl.C_WH_CODE = lstdhl2[0].wh;
                                    mod_dhl.N_TOTAL_QUA = 19;
                                    mod_dhl.N_NUM = lstdhl2[0].num + 1;
                                    D_OVER_TIME = mod_dhl.D_END_TIME;
                                    mod_dhl.N_CAP = lstdhl2[0].cap;
                                    mod_dhl.D_OVER_TIME = D_OVER_TIME;
                                    dhl_plan.Add(mod_dhl);
                                    //更新当前坑的结束时间

                                }
                                else
                                {
                                    var list1 = dhl_plan.GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();
                                    var list2 = hl_acl.Where(a => a.C_SLAB_TYPE == "大方坯" && a.N_QUA == 0).GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();

                                    var expectedList = list2.Except(list1).ToList().OrderBy(a => a.C_WH_CODE).ToList();

                                    //从没有使用过的缓冷坑找一个坑使用
                                    var lstdhl_act = hl_acl.Where(a => a.C_WH_CODE == expectedList[0].C_WH_CODE).ToList();
                                    if (lstdhl_act.Count > 0)
                                    {
                                        foreach (var item in hl_acl)
                                        {
                                            if (item.C_ID == lstdhl_act[0].C_ID)
                                            {
                                                item.N_QUA = Convert.ToDecimal(mod_dhl.N_QUA);
                                            }
                                        }

                                        mod_dhl.C_WH_CODE = expectedList[0].C_WH_CODE;
                                        mod_dhl.N_TOTAL_QUA = 19;
                                        mod_dhl.N_CAP = lstdhl_act[0].N_CAP_QUA;
                                        mod_dhl.N_NUM = dhl_plan.Where(a => a.C_WH_CODE == mod_dhl.C_WH_CODE).Max(a => a.N_NUM) == null ? 0 : dhl_plan.Where(a => a.C_WH_CODE == mod_dhl.C_WH_CODE).Max(a => a.N_NUM) + 1;
                                        mod_dhl.D_OVER_TIME = mod_dhl.D_END_TIME;
                                        dhl_plan.Add(mod_dhl);
                                    }
                                    else
                                    {
                                        hl_acl[0].N_QUA = Convert.ToDecimal(mod_dhl.N_QUA);
                                        mod_dhl.C_WH_CODE = "0";
                                        mod_dhl.N_TOTAL_QUA = 19;
                                        mod_dhl.N_CAP = 10000;
                                        mod_dhl.N_NUM = 1;
                                        mod_dhl.D_OVER_TIME = mod_dhl.D_END_TIME;
                                        dhl_plan.Add(mod_dhl);
                                    }
                                }
                            }

                            lst_lc[lc].D_DFPHL_START_TIME = mod_dhl.D_START_TIME;
                            lst_lc[lc].D_DFPHL_END_TIME = mod_dhl.D_OVER_TIME;
                            foreach (var item in lc_plan)
                            {
                                if (item.C_ID == lst_lc[lc].C_ID)
                                {
                                    item.D_DFPHL_START_TIME = lst_lc[lc].D_DFPHL_START_TIME;
                                    item.D_DFPHL_END_TIME = lst_lc[lc].D_DFPHL_END_TIME;
                                    bll_lc.Delete(item.C_ID);
                                    bll_lc.Add(item);

                                }
                            }
                        }
                        #endregion
                        #region 插入开坯计划


                        Mod_TPA_KP_PLAN mod_kp = new Mod_TPA_KP_PLAN();
                        mod_kp.C_ID = System.Guid.NewGuid().ToString();
                        mod_kp.C_FK = lst_lc[lc].C_ID;
                        mod_kp.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                        mod_kp.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                        mod_kp.C_CCM = lst_lc[lc].C_CCM_DESC;
                        mod_kp.D_CAN_START_TIME = lst_lc[lc].C_DFP_HL == "Y" ? Convert.ToDateTime(lst_lc[lc].D_DFPHL_END_TIME).AddHours(1) : Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2);//可开坯时间
                        mod_kp.N_WGT = lst_lc[lc].N_SLAB_WGT;
                        mod_kp.N_CN = 114;//机时产能
                        mod_kp.C_DHL = lst_lc[lc].C_HL;//热轧钢坯是否缓冷
                        mod_kp.C_DFP_RZ = lst_lc[lc].C_DFP_RZ;//大方坯是否热装
                        mod_kp.C_DFP_YQ = lst_lc[lc].C_DFP_YQ;//大方坯缓冷要求

                        mod_kp.C_MATRL_CODE_SLAB = lst_lc[lc].C_MATRL_NO;
                        mod_kp.C_MATRL_NAME_SLAB = lst_lc[lc].C_MATRL_NAME;
                        mod_kp.C_MATRL_CODE_KP = lst_lc[lc].C_MATRL_CODE_KP;
                        mod_kp.C_MATRL_NAME_KP = lst_lc[lc].C_MATRL_NAME_KP;
                        mod_kp.C_KP_SIZE = lst_lc[lc].C_KP_SIZE;
                        mod_kp.N_KP_LENGTH = lst_lc[lc].N_KP_LENGTH;
                        mod_kp.N_KP_PW = lst_lc[lc].N_KP_PW;

                        mod_kp.N_SLAB_LENGTH = Convert.ToDecimal(lst_lc[lc].C_SLAB_LENGTH);
                        mod_kp.C_SLAB_SIZE = lst_lc[lc].C_SLAB_SIZE;
                        mod_kp.N_SLAB_PW = lst_lc[lc].N_SLAB_PW;

                        if (mod_kp.C_DFP_RZ == "Y" || mod_kp.C_DFP_YQ.Trim() != "")
                        {
                            //必需热轧
                            DateTime? dtjhkssj = null;
                            var lstlastkp = kp_plan.Where(a => a.D_START_TIME <= Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2)).ToList();
                            if (lstlastkp.Count > 0)
                            {
                                dtjhkssj = (DateTime)kp_plan.Where(a => a.D_START_TIME <= Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2)).Max(a => a.D_END_TIME);
                                if (dtjhkssj < Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2))
                                {
                                    dtjhkssj = Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2);
                                }
                                mod_kp.N_SORT = kp_plan.Where(a => a.D_START_TIME <= Convert.ToDateTime(lst_lc[lc].D_P_START_TIME).AddHours(2)).Max(a => a.N_SORT) + 1;//开坯计划排序号
                            }
                            else
                            {
                                mod_kp.N_SORT = 1;

                            }
                            mod_kp.D_START_TIME = dtjhkssj;//开坯计划开始时间
                            try
                            {
                                mod_kp.D_END_TIME = ((DateTime)dtjhkssj).AddHours((double)(mod_kp.N_WGT / mod_kp.N_CN));//开坯计划结束时间......
                            }
                            catch (Exception)
                            {

                                mod_kp.D_END_TIME = System.DateTime.Now;
                            }

                            //将当前计划之后的计划时间全都重新计算
                            var updatelist = kp_plan.Where(a => a.N_SORT > mod_kp.N_SORT - 1).OrderBy(a => a.N_SORT).ToList();
                            if (updatelist.Count > 0)
                            {
                                DateTime dtB2 = (DateTime)mod_kp.D_END_TIME;
                                for (int m = 0; m < updatelist.Count; m++)
                                {
                                    updatelist[m].N_SORT = updatelist[m].N_SORT + 1;
                                    updatelist[m].D_START_TIME = dtB2;
                                    updatelist[m].D_END_TIME = dtB2.AddHours((double)(updatelist[m].N_WGT / updatelist[m].N_CN));
                                    dtB2 = (DateTime)updatelist[m].D_END_TIME;
                                    foreach (var item in kp_plan)
                                    {
                                        if (item.C_ID == updatelist[m].C_ID)
                                        {
                                            item.N_SORT = updatelist[m].N_SORT;
                                            item.D_START_TIME = updatelist[m].D_START_TIME;
                                            item.D_END_TIME = updatelist[m].D_END_TIME;

                                        }
                                    }

                                }

                            }

                        }
                        else
                        {
                            int kpsort = 0;
                            DateTime dtjhkssj = (DateTime)mod_kp.D_CAN_START_TIME;
                            if (kp_plan.Count == 0)
                            {
                                dtjhkssj = (DateTime)mod_kp.D_CAN_START_TIME;
                            }
                            else
                            {
                                dtjhkssj = (DateTime)kp_plan.Max(a => a.D_END_TIME);
                                kpsort = (int)kp_plan.Max(a => a.N_SORT);
                            }

                            if (dtjhkssj < mod_kp.D_CAN_START_TIME)
                            {
                                dtjhkssj = (DateTime)mod_kp.D_CAN_START_TIME;

                            }
                            mod_kp.N_SORT = kpsort + 1;//开坯计划排序号
                            mod_kp.D_START_TIME = dtjhkssj;//开坯计划开始时间
                            mod_kp.D_END_TIME = dtjhkssj.AddHours((double)(mod_kp.N_WGT / mod_kp.N_CN));//开坯计划结束时间
                        }
                        kp_plan.Add(mod_kp);
                        lst_lc[lc].D_KP_START_TIME = mod_kp.D_START_TIME;
                        lst_lc[lc].D_KP_END_TIME = mod_kp.D_END_TIME;
                        if (lst_lc[lc].C_HL == "N" && lst_lc[lc].C_XM == "N")
                        {
                            lst_lc[lc].D_CAN_USE_TIME = ((DateTime)mod_kp.D_START_TIME).AddHours(2);
                        }
                        foreach (var item in lc_plan)
                        {
                            if (item.C_ID == lst_lc[lc].C_ID)
                            {
                                item.D_KP_START_TIME = lst_lc[lc].D_KP_START_TIME;
                                item.D_KP_END_TIME = lst_lc[lc].D_KP_END_TIME;
                                item.D_CAN_USE_TIME = lst_lc[lc].D_CAN_USE_TIME;
                                bll_lc.Delete(item.C_ID);
                                bll_lc.Add(item);
                            }
                        }

                        #endregion
                        #region 插入热轧坯缓冷计划
                        if (lst_lc[lc].C_HL == "Y")
                        {
                            DateTime? D_OVER_TIME = null;//进入坑的坑的结束时间
                            Mod_TPA_HL_PLAN mod_hl = new Mod_TPA_HL_PLAN();
                            mod_hl.C_ID = System.Guid.NewGuid().ToString();
                            mod_hl.C_FK = lst_lc[lc].C_ID;
                            mod_hl.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                            mod_hl.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                            mod_hl.C_CCM = lst_lc[lc].C_CCM_DESC;
                            mod_hl.C_HLYQ = lst_lc[lc].C_RZP_YQ;
                            mod_hl.N_HL_TIME = lst_lc[lc].N_HL_TIME;
                            mod_hl.N_QUA = 38;
                            mod_hl.C_HLYQ = lst_lc[lc].C_DFP_YQ;
                            mod_hl.D_START_TIME = Convert.ToDateTime(lst_lc[lc].D_KP_START_TIME).AddHours(2);
                            mod_hl.D_END_TIME = Convert.ToDateTime(lst_lc[lc].D_KP_START_TIME).AddHours(2).AddHours(Convert.ToDouble(mod_hl.N_HL_TIME));//计划缓冷结束时间


                            var lstdhl = hl_plan.Where(a => a.D_OVER_TIME > mod_hl.D_START_TIME && a.C_WH_CODE != "0" && a.D_START_TIME < mod_hl.D_START_TIME).GroupBy(a => new { a.C_WH_CODE, a.N_NUM }).Select(a => new { wh = a.First().C_WH_CODE, num = a.First().N_NUM, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.left >= mod_hl.N_QUA).OrderByDescending(a => a.over_time).ToList();//查找缓冷未结束的有空闲的坑按缓冷结束时间倒序;
                            if (lstdhl.Count > 0)
                            {
                                mod_hl.C_WH_CODE = lstdhl[0].wh;
                                mod_hl.N_TOTAL_QUA = 38 + lstdhl[0].total_qua;
                                mod_hl.N_NUM = lstdhl[0].num;
                                mod_hl.N_CAP = lstdhl[0].cap;
                                D_OVER_TIME = lstdhl[0].over_time;

                                if (mod_hl.D_END_TIME > lstdhl[0].over_time)
                                {
                                    D_OVER_TIME = mod_hl.D_END_TIME;
                                }
                                mod_hl.D_OVER_TIME = D_OVER_TIME;
                                hl_plan.Add(mod_hl);
                                //跟新当前坑的结束时间
                                var lstUpdateOverTime = hl_plan.Where(a => a.C_WH_CODE == mod_hl.C_WH_CODE && a.N_NUM == mod_hl.N_NUM).ToList();
                                for (int k = 0; k < lstUpdateOverTime.Count; k++)
                                {
                                    foreach (var item in hl_plan)
                                    {
                                        if (item.C_ID == lstUpdateOverTime[k].C_ID)
                                        {
                                            item.D_OVER_TIME = D_OVER_TIME;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                var lstdhl2 = hl_plan.Where(a => a.C_WH_CODE != "0").GroupBy(a => new { a.C_WH_CODE }).Select(a => new { wh = a.First().C_WH_CODE, num = a.First().N_NUM, total_qua = a.Sum(p => p.N_QUA), cap = a.Max(p => p.N_CAP), left = a.Max(p => p.N_CAP) - a.Sum(p => p.N_QUA), over_time = a.Max(p => p.D_END_TIME) }).ToList().Where(a => a.over_time < mod_hl.D_START_TIME).OrderBy(a => a.over_time).ToList();//查找缓冷坑缓冷已结束的坑
                                if (lstdhl2.Count > 0)
                                {
                                    mod_hl.C_WH_CODE = lstdhl2[0].wh;
                                    mod_hl.N_TOTAL_QUA = 38;
                                    mod_hl.N_NUM = lstdhl2[0].num + 1;
                                    D_OVER_TIME = mod_hl.D_END_TIME;
                                    mod_hl.N_CAP = lstdhl2[0].cap;
                                    mod_hl.D_OVER_TIME = D_OVER_TIME;
                                    hl_plan.Add(mod_hl);
                                    //更新当前坑的结束时间

                                }
                                else
                                {
                                    var list1 = hl_plan.GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();
                                    var list2 = hl_acl.Where(a => a.C_SLAB_TYPE == "小方坯" && a.N_QUA == 0).GroupBy(a => a.C_WH_CODE).Select(a => new { a.First().C_WH_CODE }).ToList();

                                    var expectedList = list2.Except(list1).ToList().OrderBy(a => a.C_WH_CODE).ToList();
                                    if (expectedList.Count > 0)
                                    {

                                        //从没有使用过的缓冷坑找一个坑使用
                                        var lstdhl_act = hl_acl.Where(a => a.C_WH_CODE == expectedList[0].C_WH_CODE).ToList();
                                        if (lstdhl_act.Count > 0)
                                        {
                                            foreach (var item in hl_acl)
                                            {
                                                if (item.C_ID == lstdhl_act[0].C_ID)
                                                {
                                                    item.N_QUA = Convert.ToDecimal(mod_hl.N_QUA);
                                                }
                                            }
                                            //从没有使用过的缓冷坑找一个坑使用
                                            mod_hl.C_WH_CODE = expectedList[0].C_WH_CODE;
                                            mod_hl.N_TOTAL_QUA = 38;
                                            mod_hl.N_CAP = lstdhl_act[0].N_CAP_QUA;
                                            mod_hl.N_NUM = dhl_plan.Where(a => a.C_WH_CODE == mod_hl.C_WH_CODE).Max(a => a.N_NUM) == null ? 0 : dhl_plan.Where(a => a.C_WH_CODE == mod_hl.C_WH_CODE).Max(a => a.N_NUM) + 1;
                                            mod_hl.D_OVER_TIME = mod_hl.D_END_TIME;
                                            hl_plan.Add(mod_hl);
                                        }
                                        else
                                        {
                                            hl_acl[0].N_QUA = Convert.ToDecimal(mod_hl.N_QUA);
                                            mod_hl.C_WH_CODE = "0";
                                            mod_hl.N_TOTAL_QUA = 38;
                                            mod_hl.N_CAP = 10000;
                                            mod_hl.N_NUM = 1;
                                            mod_hl.D_OVER_TIME = mod_hl.D_END_TIME;
                                            hl_plan.Add(mod_hl);
                                        }
                                    }

                                }
                            }

                            lst_lc[lc].D_HL_START_TIME = mod_hl.D_START_TIME;
                            lst_lc[lc].D_HL_END_TIME = mod_hl.D_OVER_TIME;
                            if (lst_lc[lc].C_XM == "N")
                            {
                                if (mod_hl.D_OVER_TIME == null)
                                {
                                    lst_lc[lc].D_CAN_USE_TIME = null;
                                }
                                else
                                {
                                    lst_lc[lc].D_CAN_USE_TIME = ((DateTime)mod_hl.D_OVER_TIME).AddHours(2);
                                }

                            }
                            foreach (var item in lc_plan)
                            {
                                if (item.C_ID == lst_lc[lc].C_ID)
                                {
                                    item.D_HL_START_TIME = lst_lc[lc].D_HL_START_TIME;
                                    item.D_HL_END_TIME = lst_lc[lc].D_HL_END_TIME;
                                    item.D_CAN_USE_TIME = lst_lc[lc].D_CAN_USE_TIME;
                                    bll_lc.Delete(item.C_ID);
                                    bll_lc.Add(item);
                                }
                            }
                        }

                        #endregion
                        #region 插入修磨计划
                        if (lst_lc[lc].C_XM == "Y")
                        {
                            Mod_TPA_XM_PLAN mod_xm = new Mod_TPA_XM_PLAN();
                            mod_xm.C_ID = System.Guid.NewGuid().ToString();
                            mod_xm.C_FK = lst_lc[lc].C_ID;
                            mod_xm.C_STL_GRD = lst_lc[lc].C_STL_GRD;
                            mod_xm.C_STD_CODE = lst_lc[lc].C_STD_CODE;
                            mod_xm.C_CCM = lst_lc[lc].C_CCM_DESC;
                            mod_xm.D_PLAN_DATE = lst_lc[lc].C_HL == "Y" ? Convert.ToDateTime(lst_lc[lc].D_HL_END_TIME).AddHours(1) : Convert.ToDateTime(lst_lc[lc].D_KP_END_TIME).AddHours(12);//可修磨时间
                            mod_xm.N_WGT = lst_lc[lc].N_SLAB_WGT;
                            mod_xm.C_XM_TYPE = "碳钢";
                            mod_xm.N_CN = 400 / 24;//机时产能
                                                   //mod_xm.C_XMYQ = lst_lc[lc].C_XM;

                            DateTime maxxmtime = (DateTime)mod_xm.D_PLAN_DATE;
                            DateTime? maxsytime = xm_plan.Where(a => a.C_XM_TYPE == "碳钢").Max(a => a.D_END_TIME);//找出已排计划最大修磨结束时间
                            if (maxsytime != null && maxsytime >= maxxmtime)

                            {
                                maxxmtime = (DateTime)maxsytime;
                            }
                            mod_xm.D_START_TIME = maxxmtime;
                            mod_xm.D_END_TIME = maxxmtime.AddHours((double)(mod_xm.N_WGT / mod_xm.N_CN));
                            xm_plan.Add(mod_xm);

                            lst_lc[lc].D_XM_START_TIME = mod_xm.D_START_TIME;
                            lst_lc[lc].D_XM_END_TIME = mod_xm.D_END_TIME;

                            lst_lc[lc].D_CAN_USE_TIME = ((DateTime)mod_xm.D_END_TIME).AddHours(2);

                            foreach (var item in lc_plan)
                            {
                                if (item.C_ID == lst_lc[lc].C_ID)
                                {
                                    item.D_XM_START_TIME = lst_lc[lc].D_XM_START_TIME;
                                    item.D_XM_END_TIME = lst_lc[lc].D_XM_END_TIME;
                                    item.D_CAN_USE_TIME = lst_lc[lc].D_CAN_USE_TIME;
                                    bll_lc.Delete(item.C_ID);
                                    bll_lc.Add(item);
                                }
                            }
                        }
                        #endregion
                    }
                    #endregion
                }
                bll_jc.Update(lst[j]);
            }
            #endregion
            return lst;

        }
        #endregion

        #region 下达浇次计划

        /// <summary>
        /// 下发浇次计划
        /// </summary>
        /// <param name="c_id">浇次计划主键</param>
        /// <param name="max_lc_sort">当前浇次排产时炉次计划最大排序号</param>
        /// <param name="max_jc_sort">当前浇次排产时最大排序号</param>
        /// <returns>返回排产后炉次最大序号，浇次最大序号</returns>
        public int[] Down_Jc_Plan(string c_id, int max_lc_sort, int max_jc_sort)
        {
            //获取浇次计划
            Mod_TPP_LGPC_LSB mod_jc_ls = jc_plan.Where(a => a.C_ID == c_id).ToList()[0];  //bll_jc.GetModel(c_id);
            Mod_TSP_CAST_PLAN mod_jc = CopyObject.Mapper<Mod_TSP_CAST_PLAN, Mod_TPP_LGPC_LSB>(mod_jc_ls);
            mod_jc.N_SORT = max_jc_sort + 1;
            mod_jc.C_RH_SFJS = "0";//RH炉寿命默认为0
            max_jc_sort = max_jc_sort + 1;
            mod_jc.N_STATUS = 1;
            //获取当前炉次计划最大序号
            bll_cast_plan.Add(mod_jc);//将临时浇次计划插入浇次计划表

            #region 插入操作日志
            Cls_APS_PC.WritePlanLog("炼钢生产顺序", "浇次计划确认", mod_jc_ls.C_CCM_ID, c_id);//保存连铸机主键、浇次计划主键
            #endregion

            List<Mod_TPP_LGPC_LCLSB> lst_lc = lc_plan.Where(a => a.C_FK == c_id).ToList(); //bll_lc.GetModelListByJcID(c_id);
            if (lst_lc.Count > 0)
            {
                for (int i = 0; i < lst_lc.Count; i++)
                {
                    Mod_TSP_PLAN_SMS mod_sms = CopyObject.Mapper<Mod_TSP_PLAN_SMS, Mod_TPP_LGPC_LCLSB>(lst_lc[i]);
                    mod_sms.N_SORT = max_lc_sort + 1;//
                    max_lc_sort = max_lc_sort + 1;
                    if (mod_sms.C_RZP_RZ.Trim() == "")
                    {
                        mod_sms.C_RZP_RZ = "N";
                    }
                    if (mod_sms.C_DFP_RZ.Trim() == "")
                    {
                        mod_sms.C_DFP_RZ = "N";
                    }
                    mod_sms.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod_sms.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bll_plan_sms.Add(mod_sms);//插入炉次计划表
                    #region  插入工序计划
                    //添加大方坯缓冷计划
                    var dhl_planadd = dhl_plan.Where(a => a.C_FK == mod_sms.C_ID).ToList();
                    if (dhl_planadd.Count > 0)
                    {
                        bll_dhl.Add(dhl_planadd[0]);
                    }
                    //添加开坯工序计划
                    var kp_list = kp_plan.Where(a => a.C_FK == mod_sms.C_ID).ToList();
                    if (kp_list.Count > 0)
                    {
                        bll_kp.Add(kp_list[0]);
                    }
                    //添加热轧钢坯缓冷计划
                    var hl_list = hl_plan.Where(a => a.C_FK == mod_sms.C_ID).ToList();
                    if (hl_list.Count > 0)
                    {
                        bll_hl.Add(hl_list[0]);
                    }
                    //添加修磨工序计划
                    var xm_list = xm_plan.Where(a => a.C_FK == mod_sms.C_ID).ToList();
                    if (xm_list.Count > 0)
                    {
                        bll_xm.Add(xm_list[0]);
                    }

                    #endregion

                    bll_lc.Delete(lst_lc[i].C_ID);//将临时炉次计划删除
                }
               
                bll_jc.Delete(c_id);//删除临时浇次计划表
            }
            return new int[2] { max_lc_sort, max_jc_sort };
        }
        #endregion
        #endregion


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

                    var plan1 = gridView6.GetRow(row1) as Mod_TPP_LGPC_LSB;
                    if (row2 < jc_plan.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gridView6.RowCount)
                        {
                            row2 = gridView6.RowCount - 1;
                        }
                        var plan2 = gridView6.GetRow(row2) as Mod_TPP_LGPC_LSB;
                        if (plan2 == null)
                            return;
                        jc_plan.Remove(plan1);
                        var left = jc_plan.TakeWhile(x => x.N_SORT < plan2.N_SORT).ToList();
                        var right = jc_plan.Where(x => left.Contains(x) == false).ToList();
                        jc_plan.Clear();
                        jc_plan.AddRange(left);
                        jc_plan.Add(plan1);
                        jc_plan.AddRange(right);
                    }
                    else
                    {
                        jc_plan.Remove(plan1);
                        jc_plan.Add(plan1);
                    }

                    foreach (var item in jc_plan)
                    {
                        item.N_SORT = jc_plan.IndexOf(item) + 1;
                    }
                    DateTime dtb = jc_plan.Min(a => a.D_P_START_TIME) == null ? System.DateTime.Now.AddHours(1) : (DateTime)jc_plan.Min(a => a.D_P_START_TIME);
                    int ljls = 0;
                    for (int i = 0; i < jc_plan.Count; i++)
                    {
                        if (jc_plan[i].C_PROD_NAME == "超低碳钢" && jc_plan[i].C_RH == "Y")
                        {
                            ljls = 0;
                        }
                        else
                        {
                            ljls = (int)(ljls + jc_plan[i].N_ZJCLS);
                        }
                        jc_plan[i].D_P_START_TIME = dtb;
                        jc_plan[i].D_P_END_TIME = dtb.AddHours((double)(jc_plan[i].N_MLZL * jc_plan[i].N_ZJCLS / jc_plan[i].N_JSCN));
                        //if (ljls >= 32)
                        //{
                        //    jc_plan[i].N_PRODUCE_TIME = 4;
                        //    ljls = 0;
                        //}
                        //else
                        //{
                        //    jc_plan[i].N_PRODUCE_TIME = 0;
                        //}
                        dtb = Convert.ToDateTime(jc_plan[i].D_P_END_TIME).AddHours((double)jc_plan[i].N_PRODUCE_TIME);
                    }

                    gridView6.RefreshData();
                });

            dropPlanToReq.AllowDrop = true;


        }
        #endregion

        #region 浇次计划列表鼠标拖动方法
        /// <summary>
        /// 浇次计划 行托动方法
        /// </summary>
        /// <param name="lst">加载的数据</param>
        /// <param name="gvSource">gridview</param>
        private void InitDrop_Lc()
        {
            var dropPlanToReq = new GridViewDragDropHelper(
                this.gridView7, gridView7, (row1, row2) =>
                {
                    if (row1 == row2) return;

                    var plan1 = gridView7.GetRow(row1) as Mod_TPP_LGPC_LCLSB;
                    if (row2 < jc_plan.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gridView7.RowCount)
                        {
                            row2 = gridView7.RowCount - 1;
                        }
                        var plan2 = gridView7.GetRow(row2) as Mod_TPP_LGPC_LCLSB;
                        if (plan2 == null)
                            return;
                        lc_plan_sort.Remove(plan1);
                        var left = lc_plan_sort.TakeWhile(x => x.N_SORT < plan2.N_SORT).ToList();
                        var right = lc_plan_sort.Where(x => left.Contains(x) == false).ToList();
                        lc_plan_sort.Clear();
                        lc_plan_sort.AddRange(left);
                        lc_plan_sort.Add(plan1);
                        lc_plan_sort.AddRange(right);
                    }
                    else
                    {
                        lc_plan_sort.Remove(plan1);
                        lc_plan_sort.Add(plan1);
                    }

                    foreach (var item in lc_plan_sort)
                    {
                        item.N_SORT = lc_plan_sort.IndexOf(item) + 1;
                    }
                    DateTime dtb = System.DateTime.Now;
                    var dthh = lc_plan_sort.Min(a => a.D_P_START_TIME);
                    if (dthh != null)
                    {
                        dtb = (DateTime)lc_plan_sort.Min(a => a.D_P_START_TIME);//获取本浇次连铸计划的开始时间
                    }

                    for (int i = 0; i < lc_plan_sort.Count; i++)
                    {
                        lc_plan_sort[i].D_P_START_TIME = dtb;
                        lc_plan_sort[i].D_P_END_TIME = dtb.AddHours(Convert.ToDouble(lc_plan_sort[i].N_SLAB_WGT / lc_plan_sort[i].N_JSCN));
                        dtb = (DateTime)lc_plan_sort[i].D_P_END_TIME;
                    }

                    gridView7.RefreshData();
                });

            dropPlanToReq.AllowDrop = true;


        }
        #endregion

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
        /// <summary>
        /// 查询浇次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_jc_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("正在加载数据，请稍候...");
            try
            {
                bll_hl_act.RstHLACT();//初始化缓冷实绩
                bll_hl_act.CleanGXPlan();//初始化工序实绩
                dhl_plan = bll_dhl.GetModelList(" AND N_STATUS<>2 ");//已排产大方坯缓冷未完成计划
                kp_plan = bll_kp.GetModelList("  AND N_STATUS<>2  ");//已排产大方坯开坯未完成
                hl_plan = bll_hl.GetModelList("  AND N_STATUS<>2  ");//已排产热轧坯缓冷未完成计划
                xm_plan = bll_xm.GetModelList("  AND N_STATUS<>2  ");//已排产修磨未完成计划
                sms_plan = bll_plan_sms.GetModelList(" N_CREAT_PLAN<3 ");//已排产未完成的计划

                hl_acl = bll_hl_act.GetModelList("");//已排产未完成的计划
                lc_plan = bll_lc.GetModelList("");//获得临时表所有的炉次计划
               // BindLsbGrid(_strCCMID);
                jc_plan = bll_jc.GetModelList("").Where(a => a.C_CCM_ID == _strCCMID).OrderBy(a => a.N_SORT).ToList();
                this.dateEdit1.Text = GetStartTime(_strCCMID).ToString();

                for (int i = 0; i < jc_plan.Count; i++)
                {
                    UpdateJCByLC(jc_plan[i].C_ID);
                }
                jc_plan = bll_jc.GetModelList("").Where(a => a.C_CCM_ID == _strCCMID).OrderBy(a => a.N_SORT).ToList();
                jc_plan = Initialize_List(jc_plan);
                this.modTPPLGPCLSBBindingSource.DataSource = jc_plan;
                this.gridView6.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gridView6);
                this.gridView6.UpdateSummary();
                this.gridView6.RefreshData();
                this.gridView6.BestFitColumns();
                this.gridView6.RowStyle += GridView6_RowStyle;

            }
            catch (Exception)
            {
            }
            finally
            {
                WaitingFrom.CloseWait();

            }

        }

        /// <summary>
        /// 更新浇次计划信息
        /// </summary>
        /// <param name="JC_ID"></param>
        public void UpdateJCByLC(string JC_ID)
        {

            Mod_TPP_LGPC_LSB modjc = bll_jc.GetModel(JC_ID);
            modjc.C_RH = "N";
            int RHLS = 0;
            int dhl = 0;
            int hl = 0;
            int xm = 0;
            string remark = "";
            List<Mod_TPP_LGPC_LCLSB> lstlc = bll_lc.GetModelListByJcID(JC_ID).OrderBy(a=>a.N_SORT).ToList();
            var lst = lstlc.GroupBy(a => new { a.C_STL_GRD, a.C_STD_CODE }).Select(a => new { num = a.Count(), a.First().C_STL_GRD, a.First().C_STD_CODE, a.First().C_RH, a.First().C_DFP_HL, a.First().C_HL, a.First().C_XM }).ToList();
            if (lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (remark == "")
                    {
                        remark = lst[i].C_STL_GRD + "~" + lst[i].C_STD_CODE + "~" + lst[i].num.ToString();
                    }
                    else
                    {
                        remark = remark + "\n" + lst[i].C_STL_GRD + "~" + lst[i].C_STD_CODE + "~" + lst[i].num.ToString();
                    }
                    if (lst[i].C_RH == "Y")
                    {
                        modjc.C_RH = "Y";
                        RHLS = RHLS + lst[i].num;
                    }
                    if (lst[i].C_DFP_HL == "Y")
                    {
                        dhl = dhl + lst[i].num;
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
           
            modjc.D_P_START_TIME = lstlc.Min(a => a.D_P_START_TIME);
            modjc.D_P_END_TIME= lstlc.Max(a => a.D_P_END_TIME);
            modjc.N_ZJCLS = lstlc.Count;
            modjc.N_ZJCLZL = lstlc.Count * modjc.N_MLZL;
            modjc.C_REMARK = remark;
            modjc.N_RH = RHLS;
            modjc.N_DHL = dhl;
            modjc.N_HL = hl;
            modjc.N_XM = xm;
            modjc.C_BY3 = CheckLCPlanSort(JC_ID).ToString();//更新
            bll_jc.Update(modjc);

        }
        /// <summary>
        /// 调整炉数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zjcls_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("正在处理数据，请稍候...");
            try
            {
                if (DialogResult.No == MessageBox.Show("是否调整当前选中的浇次计划的炉数！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int ls = Convert.ToInt32(txt_zjcls.Text);
                ChangeJCLs(lbl_id.Text, ls, "N");
                UpdateJCByLC(lbl_id.Text);
                btn_query_jc_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                WaitingFrom.CloseWait();
            }
        }
        /// <summary>
        /// 是否人工指定开始时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_sfzd_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_sfzd.Checked)
            {
                if (this.dateEdit1.Text.Trim() == "")
                {
                    this.dateEdit1.Text = System.DateTime.Now.AddHours(1).ToString("yyyy-MM-dd hh:mm:ss");

                    this.chk_sfzd.Focus();
                }

            }
        }
        /// <summary>
        /// 浇次计划自动排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_rf_time_Click(object sender, EventArgs e)
        {
            if (jc_plan == null)
            {
                return;
            }
            if (this.dateEdit1.Text.Trim() == "")
            {
                MessageBox.Show("请指定计划开始时间！");
                return;
            }
            if (DialogResult.No == MessageBox.Show("是否需要系统自动重新排序！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            bll_hl_act.RstHLACT();//初始化缓冷实绩
            bll_hl_act.CleanGXPlan();//初始化工序实绩
            string c_ccm = this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();
            DateTime dt = Convert.ToDateTime(GetStartTime(c_ccm));//指定当前连铸浇次计划开始时间
            WaitingFrom.ShowWait("系统正在进行自动排序，请稍候...");
            for (int i = 0; i < jc_plan.Count; i++)
            {
                jc_plan[i].N_STATUS = 0;
            }

            //系统自动进行排序
            int RHLS = GetRHNum(c_ccm);//获取当前RH炉的寿命
            string[] ss = GetJCType(c_ccm);

            jc_plan = Jc_plan_PC_5CCM(jc_plan, RHLS, 130, dt, ss[0], ss[1]).OrderBy(a => a.N_SORT).ToList();

            jc_plan = CheckPlan(jc_plan);
            this.modTPPLGPCLSBBindingSource.DataSource = null;
            this.modTPPLGPCLSBBindingSource.DataSource = jc_plan;
            this.gridView6.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView6);
            this.gridView6.UpdateSummary();
            this.gridView6.RefreshData();
            this.gridView6.BestFitColumns();
            WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 保存排序后的计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveJcPlan_Click(object sender, EventArgs e)
        {
            DateTime? D_DT_B = null;
            if (chk_sfzd.Checked)
            {
                D_DT_B = Convert.ToDateTime(this.dateEdit1.EditValue.ToString());
            }
            jc_plan = jc_plan.OrderBy(a => a.N_SORT).ToList();
            if (D_DT_B!=null)
            {
                for (int i = 0; i < jc_plan.Count; i++)
                {
                    jc_plan[i].D_P_START_TIME = D_DT_B;
                    jc_plan[i].D_P_END_TIME =Convert.ToDateTime( D_DT_B ).AddHours(Convert.ToDouble( (jc_plan[i].N_ZJCLZL / jc_plan[i].N_JSCN)));
                    D_DT_B =Convert.ToDateTime( jc_plan[i].D_P_END_TIME).AddHours(Convert.ToDouble(jc_plan[i].N_PRODUCE_TIME));
                    bll_jc.Update(jc_plan[i]);
                }
            }
            else
            {
                for (int i = 0; i < jc_plan.Count; i++)
                {
                    if (jc_plan[i].D_P_START_TIME == null || jc_plan[i].N_SORT == null)
                    {
                        MessageBox.Show("请先生成排序后再保存计划！");
                        return;
                    }
                }
            }
            if (DialogResult.No == MessageBox.Show("是否保存当前修改的浇次计划！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            WaitingFrom.ShowWait("正在保存数据，请稍候...");
            jc_plan = Sort_GX_Plan(jc_plan);//将各工序计划刷新
            jc_plan = CheckPlan(jc_plan);
            for (int i = 0; i < jc_plan.Count; i++)
            {
                UpdateJCByLC(jc_plan[i].C_ID);
               
                
            }
            btn_query_jc_Click(null, null);
            WaitingFrom.CloseWait();
        }

        private Bll_TPB_ENDTOEND_GRD bll_swl = new Bll_TPB_ENDTOEND_GRD();
        /// <summary>
        ///  按浇次验证炉次计划顺序是否正确
        /// </summary>
        /// <param name="C_JC_ID">浇次主键</param>
        /// <returns></returns>
        public bool CheckLCPlanSort(string C_JC_ID)
        {
            Mod_TPP_LGPC_LSB mod_jc = bll_jc.GetModel(C_JC_ID);
            mod_jc.C_BY3 = "";//炉次计划顺序是否正确
            #region 验证两炉计划是否能否相邻生产
            if (mod_jc != null)
            {
                List<Mod_TPP_LGPC_LCLSB> lstsms = bll_lc.GetModelListByJcID(C_JC_ID).OrderBy(a => a.N_SORT).ToList();
                if (lstsms.Count > 0)
                {
                    bool flag = true;

                    //标记浇次计划不正确
                    #region 验证是否有首尾炉计划
                    for (int i = 0; i < lstsms.Count; i++)
                    {
                        lstsms[i].C_CTRL_NO = "";//标记上下炉次不能衔接，清空
                        bll_lc.Update(lstsms[i]);
                        if (i == 0)
                        {
                            DataTable dtswl = bll_swl.GetSWLSteel(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, "首");
                            if (dtswl.Rows.Count > 0)
                            {

                                flag = false;
                                lstsms[i].C_CTRL_NO = "当前计划需要首炉计划！";
                                bll_lc.Update(lstsms[i]);
                                break;
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
                                bll_lc.Update(lstsms[i]);
                            }

                            DataTable dtswl = bll_swl.GetSWLSteel(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, "首");
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
                                        bll_lc.Update(lstsms[i]);
                                        break;
                                    }
                                }
                            }

                            //验证下一炉
                            DataTable dtwl = bll_swl.GetSWLSteel(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, "尾");
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
                                        bll_lc.Update(lstsms[i]);
                                        break;
                                    }
                                }
                            }
                        }
                        if (i == lstsms.Count - 1)
                        {
                            DataTable dtswl = bll_swl.GetSWLSteel(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE, "尾");
                            if (dtswl.Rows.Count > 0)
                            {

                                flag = false;
                                lstsms[i].C_CTRL_NO = "当前计划需要尾炉计划！";
                                bll_lc.Update(lstsms[i]);
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

        ///// <summary>
        ///// 更新浇次计划信息
        ///// </summary>
        ///// <param name="JC_ID"></param>
        //public void UpdateJCByLC(string JC_ID)
        //{

        //    Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(JC_ID);
        //    int RHLS = 0;
        //    int dhl = 0;
        //    int hl = 0;
        //    int xm = 0;
        //    string remark = "";
        //    List<Mod_TSP_PLAN_SMS> lstlc = bll_plan_sms.GetModelListByJcID(JC_ID);
        //    modjc.N_ZJCLS = lstlc.Count;
        //    modjc.N_ORDER_LS = lstlc.Where(a => a.C_STATE == "0").ToList().Count;
        //    modjc.N_ZJCLZL = lstlc.Count * modjc.N_MLZL;
        //    modjc.N_TOTAL_WGT = lstlc.Count * modjc.N_MLZL;
        //    var lst = lstlc.GroupBy(a => new { a.C_STL_GRD, a.C_STD_CODE }).Select(a => new { num = a.Count(), a.First().C_STL_GRD, a.First().C_STD_CODE, a.First().C_RH, a.First().C_DFP_HL, a.First().C_HL, a.First().C_XM }).ToList();
        //    if (lst.Count > 0)
        //    {
        //        for (int i = 0; i < lst.Count; i++)
        //        {
        //            if (i == 0)
        //            {
        //                remark = lst[i].C_STL_GRD + "~" + lst[i].C_STD_CODE + "~" + lst[i].num.ToString();
        //            }
        //            else
        //            {
        //                remark = remark + "\n" + lst[i].C_STL_GRD + "~" + lst[i].C_STD_CODE + "~" + lst[i].num.ToString();
        //            }

        //            if (lst[i].C_RH == "Y")
        //            {
        //                RHLS = RHLS + lst[i].num;
        //            }
        //            if (lst[i].C_DFP_HL == "Y")
        //            {
        //                dhl = dhl + lst[i].num;
        //            }
        //            if (lst[i].C_HL == "Y")
        //            {
        //                hl = hl + lst[i].num;
        //            }
        //            if (lst[i].C_XM == "Y")
        //            {
        //                xm = xm + lst[i].num;
        //            }

        //        }
        //    }



        //    modjc.C_REMARK = remark;
        //    modjc.N_RH = RHLS;
        //    modjc.N_DHL = dhl;
        //    modjc.N_HL = hl;
        //    modjc.N_XM = xm;
        //    bll_cast_plan.Update(modjc);

        //}


        /// <summary>
        /// 确认计划下发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_down_plan_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.txt_jcs.Text) > jc_plan.Count)
            {
                MessageBox.Show("下发浇次数超出实际数！");
                return;
            }

            for (int i = 0; i < jc_plan.Count; i++)
            {
                if (jc_plan[i].D_P_START_TIME == null || jc_plan[i].N_SORT == null)
                {
                    MessageBox.Show("请先生成排序后再保存计划！");
                    return;
                }
            }
            if (DialogResult.No == MessageBox.Show("是否保存并下发当前生产生成的浇次计划！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            WaitingFrom.ShowWait("系统正在对排序后的计划进行保存，请稍候...");
            jc_plan = Sort_GX_Plan(jc_plan);//将各工序计划刷新
            WaitingFrom.CloseWait();
            WaitingFrom.ShowWait("系统正在对保存后的计划进行排产，请稍候...");
            if (jc_plan.Count > 0)
            {
                int max_lc_sort = bll_plan_sms.GetMaxSort(_strCCMID);
                int max_jc_sort = bll_cast_plan.Max_jc_sort(_strCCMID);
                int[] sort = new int[2] { max_lc_sort, max_jc_sort };
                // for (int i = 0; i < jc_plan.Count; i++)
                for (int i = 0; i < Convert.ToInt32(this.txt_jcs.Text); i++)
                {
                    sort = Down_Jc_Plan(jc_plan[i].C_ID, sort[0], sort[1]);
                    // jc_plan.RemoveAt(i);
                }
                //将已下发的连铸计划标记为已排产
               // bll_tpc_plan_sms.DownPlanByCCM(_strCCMID);

                MessageBox.Show("计划已排产！");

                btn_query_jc_Click(null, null);
            }
            WaitingFrom.CloseWait();
        }

        private void gridView6_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            try
            {
                int selectedHandle;
                selectedHandle = this.gridView6.GetSelectedRows()[0];
                string c_cid = this.gridView6.GetRowCellValue(selectedHandle, "C_ID").ToString();
                lbl_id.Text = c_cid;
                //txt_zjcls.Text = this.gridView6.GetRowCellValue(selectedHandle, "N_ZJCLS").ToString();
                BindLcLsbGrid(c_cid);//加载炉次计划顺序
            }
            catch (Exception ex)
            {
                lbl_id.Text = "";
                this.modTPPLGPCLCLSBBindingSource.DataSource = null;

            }
        }

        /// <summary>
        /// 保存炉次计划排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveLcPlan_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("正在保存炉次计划，请稍候...");
            if (lc_plan == null)
            {
                return;
            }
            for (int i = 0; i < lc_plan_sort.Count; i++)
            {
                Mod_TPP_LGPC_LCLSB mod = lc_plan_sort[i];
                bll_lc.Update(mod);
            }
            MessageBox.Show("计划已保存！");
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 查询生成的大方坯缓冷计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_dhl_Click(object sender, EventArgs e)
        {
            if (dhl_plan == null)
            {
                return;
            }
            WaitingFrom.ShowWait("正在加载数据，请稍候...");
            var lst = dhl_plan.OrderBy(a => a.D_START_TIME);
            this.gridControl1.DataSource = lst;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 查询生成的开坯计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_kp_Click(object sender, EventArgs e)
        {
            if (kp_plan == null)
            {
                return;
            }
            WaitingFrom.ShowWait("正在加载数据，请稍候...");
            var lst = kp_plan.OrderBy(a => a.D_START_TIME);
            this.gridControl2.DataSource = lst;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView2);
            this.gridView2.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 查询生成的缓冷计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_hl_Click(object sender, EventArgs e)
        {
            if (hl_plan == null)
            {
                return;
            }
            WaitingFrom.ShowWait("正在加载数据，请稍候...");
            var lst = hl_plan.OrderBy(a => a.D_START_TIME);
            this.gridControl3.DataSource = lst;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView3);
            this.gridView3.BestFitColumns();
            WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 查询生成的修磨工序计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_xm_Click(object sender, EventArgs e)
        {
            if (xm_plan == null)
            {
                return;
            }
            WaitingFrom.ShowWait("正在加载数据，请稍候...");
            var lst = xm_plan.OrderBy(a => a.D_START_TIME);
            this.gridControl4.DataSource = lst;
            this.gridView4.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView4);
            this.gridView4.BestFitColumns();
            WaitingFrom.CloseWait();
        }


        #region 添加浇次
        private Bll_TPB_SLAB_CAPACITY bll_slab_Cap = new Bll_TPB_SLAB_CAPACITY();//钢种连铸生产信息
        private Bll_TQB_SLAB_LEN_MATCH bllslabmatch = new Bll_TQB_SLAB_LEN_MATCH();//订单钢坯规格匹配
        private Bll_TPB_ENDTOEND_GRD bll_swlgz = new Bll_TPB_ENDTOEND_GRD();//首尾炉钢种
        private Bll_TQB_RINSE_TANK_GRD bll_xcgz = new Bll_TQB_RINSE_TANK_GRD();//洗槽钢种
        private Bll_TQB_COPING bll_xmyq = new Bll_TQB_COPING();//修磨要求
        private Bll_TQB_ROUTE bll_gylx = new Bll_TQB_ROUTE();//工艺路线
        private Bll_TMO_ORDER_PJ_LOG bll_ddpj = new Bll_TMO_ORDER_PJ_LOG();//订单评价日志
        private Bll_TQB_COOL_BASIC bll_hlyq = new Bll_TQB_COOL_BASIC();//订单缓冷要求
        private Bll_TPB_CAST_STOVE bll_zjcls = new Bll_TPB_CAST_STOVE();//整浇次炉数
        private Bll_TPB_BORDER_GRD bll_xlgz = new Bll_TPB_BORDER_GRD();//相邻钢种
        private Bll_TQB_STD_MAIN bll_std_main = new Bll_TQB_STD_MAIN();//执行标准
        private Bll_TB_MATRL_MAIN bll_wl = new Bll_TB_MATRL_MAIN();//物料信息表
        private Bll_TB_STA bll_sta = new Bll_TB_STA();
        /// <summary>
        /// 根据钢种和执行标准获取产品生产信息
        /// </summary>
        /// <param name="c_stl_grd">钢种</param>
        /// <param name="c_std_code">执行标准</param>
        public Cls_Pro_Info GetProInfo(string c_stl_grd, string c_std_code)
        {
            Cls_Pro_Info mod = new Cls_Pro_Info();
            mod.C_STL_GRD = c_stl_grd;
            mod.C_STD_CODE = c_std_code;
            //获取生产工艺路线
            #region 订单工艺路线信息
            DataTable dtgylx = bll_std_main.GetSCTJ(c_stl_grd, c_std_code);
            if (dtgylx.Rows.Count > 0)
            {
                mod.C_ROUTE = dtgylx.Rows[0]["C_ROUTE_DESC"].ToString();
                if (mod.C_ROUTE.Trim() != "")
                {
                    #region 脱硫
                    if (mod.C_ROUTE.Contains("TL>HTL"))
                    {
                        mod.C_TL = "Y";
                    }
                    else
                    {
                        mod.C_TL = "N";
                    }
                    #endregion
                    #region RH

                    if (mod.C_ROUTE.Contains("RH"))
                    {
                        mod.C_RH = "Y";
                    }
                    else
                    {
                        mod.C_RH = "N";
                    }
                    #endregion
                    #region DHL
                    if (mod.C_ROUTE.Contains("DHL"))
                    {
                        mod.C_DFP_HL = "Y";
                    }
                    else
                    {
                        mod.C_DFP_HL = "N";
                    }
                    #endregion
                    #region KP
                    if (mod.C_ROUTE.Contains("KP"))
                    {
                        mod.C_KP = "Y";
                    }
                    else
                    {
                        mod.C_KP = "N";
                    }
                    #endregion
                    #region HL
                    if (mod.C_ROUTE.Contains(">HL"))
                    {
                        mod.C_HL = "Y";
                    }
                    else
                    {
                        mod.C_HL = "N";
                    }
                    #endregion
                    #region XM
                    if (mod.C_ROUTE.Contains(">XM"))
                    {
                        mod.C_XM = "Y";
                    }
                    else
                    {
                        mod.C_XM = "N";
                    }
                    #endregion
                }
                else
                {
                    mod.C_ROUTE = "";
                    mod.C_TL = "";
                    mod.C_RH = "";
                    mod.C_DFP_HL = "";
                    mod.C_KP = "";
                    mod.C_HL = "";
                    mod.C_XM = "";

                }
                mod.C_STL_GRD_TYPE = dtgylx.Rows[0]["C_STL_GRD_TYPE"].ToString();//钢类
                mod.C_PROD_NAME = dtgylx.Rows[0]["C_PROD_NAME"].ToString();//品名
                mod.C_BXG = dtgylx.Rows[0]["C_IS_BXG"].ToString();//品名
            }
            #endregion

            #region 是否需要生产首尾炉钢种产品

            DataTable dtsl = bll_swlgz.GetSWLSteel(mod.C_STL_GRD, mod.C_STD_CODE, "首炉");
            if (dtsl.Rows.Count > 0)
            {
                mod.C_SL = "Y";//需要生产首炉产品
                string slorder = "";//首炉生产钢种的订单
                slorder = dtsl.Rows[0]["C_STL_GRD"].ToString() + "~" + dtsl.Rows[0]["C_STD_CODE"].ToString();
                mod.C_BY1 = slorder;
            }
            else
            {
                mod.C_SL = "N";
                mod.C_BY1 = "";
            }
            DataTable dtwl = bll_swlgz.GetSWLSteel(mod.C_STL_GRD, mod.C_STD_CODE, "尾炉");
            string wlorder = "";//尾炉生产钢种的订单
            if (dtwl.Rows.Count > 0)
            {
                mod.C_WL = "Y";//需要生产尾炉产品

                wlorder = dtwl.Rows[0]["C_STL_GRD"].ToString() + "~" + dtwl.Rows[0]["C_STD_CODE"].ToString();
                mod.C_BY2 = wlorder;
            }
            else
            {
                mod.C_WL = "N";
                mod.C_BY2 = "";
            }

            #endregion

            #region 订单钢坯修磨要求
            DataTable dtxm = bll_xmyq.GetXMYQ(mod.C_STL_GRD, mod.C_STD_CODE).Tables[0];
            if (dtxm.Rows.Count > 0)
            {
                mod.C_XMYQ = dtxm.Rows[0]["C_COPING_CRAFT"].ToString();
            }
            else
            {
                mod.C_XMYQ = "";
            }
            #endregion

            #region 订单缓冷要求
            DataTable dthl = null;
            if (bll_hlyq.GetHLYQ(mod.C_STL_GRD, mod.C_STD_CODE, "").Tables[0].Rows.Count > 0)
            {
                dthl = bll_hlyq.GetHLYQ(mod.C_STL_GRD, mod.C_STD_CODE, "").Tables[0];
            }
            else
            {
                dthl = bll_hlyq.GetHLYQ(mod.C_STL_GRD, "", "").Tables[0];
            }
            mod.N_DFP_HL_TIME = 0;
            mod.C_DFP_HL_YQ = "";
            mod.N_HL_TIME = 0;
            mod.C_HL_YQ = "";
            if (dthl.Rows.Count > 0)
            {
                for (int i = 0; i < dthl.Rows.Count; i++)
                {
                    if (dthl.Rows[i]["C_TYPE"].ToString().Contains("大方坯"))
                    {
                        mod.N_DFP_HL_TIME = Convert.ToInt32(dthl.Rows[i]["N_COOL_DT"].ToString());
                        mod.C_DFP_HL_YQ = dthl.Rows[i]["C_COOL_CRAFT_CODE"].ToString();
                    }
                    else
                    {
                        mod.N_HL_TIME = Convert.ToInt32(dthl.Rows[i]["N_COOL_DT"].ToString());
                        mod.C_HL_YQ = dthl.Rows[i]["C_COOL_CRAFT_CODE"].ToString();
                    }
                }
            }

            #endregion

            return mod;

        }
        /// <summary>
        /// 获取连铸物料信息
        /// </summary>
        /// <param name="mod"></param>
        /// <returns></returns>
        public List<Mod_TB_MATRL_MAIN> GetCcmSlabInfo(Cls_Pro_Info mod)
        {
            #region 根据物料表查找钢坯物料信息
            string wllj = "";
            if (mod.C_ROUTE.Contains("LF") && mod.C_ROUTE.Contains("RH"))
            {
                wllj = "(BLR)";
            }
            if (mod.C_ROUTE.Contains("LF") && !mod.C_ROUTE.Contains("RH"))
            {
                wllj = "(BL)";
            }
            if (!mod.C_ROUTE.Contains("LF") && mod.C_ROUTE.Contains("RH"))
            {
                wllj = "(BR)";
            }
            if (mod.C_ROUTE.Contains("KP"))
            {
                return bll_wl.GetGPWLList(mod.C_STL_GRD, "", null, "6", wllj, "大方坯连铸坯");
            }
            else
            {
                return bll_wl.GetGPWLList(mod.C_STL_GRD, "", null, "6", wllj, "小方坯连铸坯");

            }
            #endregion

        }

        /// <summary>
        /// 获取开坯物料信息
        /// </summary>
        /// <param name="mod"></param>
        /// <returns></returns>
        public List<Mod_TB_MATRL_MAIN> GetKPSlabInfo(Cls_Pro_Info mod)
        {
            #region 根据物料表查找钢坯物料信息
            string wllj = "";
            if (mod.C_ROUTE.Contains("LF") && mod.C_ROUTE.Contains("RH"))
            {
                wllj = "(BLR)";
            }
            if (mod.C_ROUTE.Contains("LF") && !mod.C_ROUTE.Contains("RH"))
            {
                wllj = "(BL)";
            }
            if (!mod.C_ROUTE.Contains("LF") && mod.C_ROUTE.Contains("RH"))
            {
                wllj = "(BR)";
            }
            if (mod.C_ROUTE.Contains("KP"))
            {

                return bll_wl.GetGPWLList(mod.C_STL_GRD, "", null, "6", wllj, "热轧钢坯");

            }
            else
            {
                return null;
            }

            #endregion

        }

        /// <summary>
        /// 获取产品连铸相关的生产信息
        /// </summary>
        /// <param name="mod">产品生产信息</param>
        /// <param name="c_ccm_id">连铸主键</param>
        /// <returns>产品生产信息</returns>
        public Cls_Pro_Info GetCcmInfo(Cls_Pro_Info mod, string c_ccm_id)
        {
            //机时产量
            DataTable dtSteelCCM = bll_slab_Cap.GetSteelCCM(mod.C_STL_GRD, mod.C_STD_CODE, c_ccm_id, mod.C_KP);
            if (dtSteelCCM.Rows.Count > 0)
            {
                mod.C_BY3 = dtSteelCCM.Rows[0]["C_TYPE"].ToString();
                mod.N_JSCN = Convert.ToDecimal(dtSteelCCM.Rows[0]["N_CAPACITY"].ToString());
            }
            else
            {
                mod.C_BY3 = "白色";
                if (mod.C_KP == "Y")
                {
                    mod.N_JSCN = 114;
                }
                else
                {
                    mod.N_JSCN = 93;
                }
            }
            //整浇次炉数
            List<Mod_TPB_CAST_STOVE> lstZJCLS = bll_zjcls.GetZJCList(c_ccm_id, mod.C_STL_GRD, mod.C_STD_CODE);
            if (lstZJCLS.Count > 0)
            {
                mod.N_ZJCLS = lstZJCLS[0].N_TARGET_NUM;
                mod.N_ZJCLS_MIN = lstZJCLS[0].N_STOVE_MIN_NUM;
                mod.N_ZJCLS_MAX = lstZJCLS[0].N_STOVE_MAX_NUM;
            }
            else
            {
                if (mod.C_KP == "Y")
                {
                    mod.N_ZJCLS = 18;
                    mod.N_ZJCLS_MIN = 15;
                    mod.N_ZJCLS_MAX = 20;
                }
                else
                {
                    mod.N_ZJCLS = 26;
                    mod.N_ZJCLS_MIN = 24;
                    mod.N_ZJCLS_MAX = 26;
                }
            }
            return mod;
        }
        #endregion

        /// <summary>
        /// 添加非计划浇次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_jc_Click(object sender, EventArgs e)
        {



        }


        Cls_Pro_Info modinfo = new Cls_Pro_Info();//添加浇次计划生产信息
        List<Mod_TB_MATRL_MAIN> ccmwllist = new List<Mod_TB_MATRL_MAIN>();//连铸生产物料信息
        List<Mod_TB_MATRL_MAIN> kpwllist = new List<Mod_TB_MATRL_MAIN>();//开坯生产物料信息
        ///// <summary>
        ///// 选择钢种和执行标准
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnEdit_STL_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    FrmPO_select_GZ frm = new FrmPO_select_GZ();
        //    if (frm.ShowDialog() == DialogResult.OK)
        //    {
        //        btnEdit_STL.Text = frm.str_GRD;
        //        txt_STD.Text = frm.str_STD;
        //        frm.Close();
        //    }
        //}


        ///// <summary>
        ///// 重新选择标准
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void txt_STD_EditValueChanged(object sender, EventArgs e)
        //{
        //    modinfo = GetProInfo(btnEdit_STL.Text.Trim(), txt_STD.Text.Trim());
        //    this.txt_GYLX.Text = modinfo.C_ROUTE;
        //    JZWL();
        //    BindCcm(modinfo.C_KP);
        //    this.txt_GYLX.Text = modinfo.C_ROUTE;
        //}

        private void btnEdit_STL_EditValueChanged(object sender, EventArgs e)
        {
            //modinfo = GetProInfo(btnEdit_STL.Text.Trim(), txt_STD.Text.Trim());
            //this.txt_GYLX.Text = modinfo.C_ROUTE;
            //JZWL();
            //BindCcm(modinfo.C_KP);
            //this.txt_GYLX.Text = modinfo.C_ROUTE;
        }

        ///// <summary>
        ///// 加载物料信息
        ///// </summary>
        //public void JZWL()
        //{
        //    ccmwllist = GetCcmSlabInfo(modinfo);
        //    if (ccmwllist != null)
        //    {
        //        this.cbo_slab_len.Properties.Items.Clear();
        //        for (int i = 0; i < ccmwllist.Count; i++)
        //        {
        //            this.cbo_slab_len.Properties.Items.Add(ccmwllist[i].N_LTH);
        //        }
        //        this.cbo_slab_len.SelectedIndex = 0;
        //    }
        //    else
        //    {
        //        this.cbo_slab_len.Properties.Items.Clear();
        //        this.cbo_slab_len.Text = "";
        //    }
        //    kpwllist = GetKPSlabInfo(modinfo);
        //    if (kpwllist != null)
        //    {
        //        this.cbo_kp_len.Properties.Items.Clear();
        //        for (int i = 0; i < kpwllist.Count; i++)
        //        {
        //            this.cbo_kp_len.Properties.Items.Add(kpwllist[i].N_LTH);
        //        }
        //        this.cbo_kp_len.SelectedIndex = 0;
        //    }
        //    else
        //    {
        //        this.cbo_kp_len.Properties.Items.Clear();
        //        this.cbo_kp_len.Text = "";
        //    }
        //}


        ///// <summary>
        ///// 加载连铸
        ///// </summary>
        ///// <param name="sfkp"></param>
        //public void BindCcm(string sfkp)
        //{
        //    this.icbo_lz2.Properties.Items.Clear();
        //    var lst = bll_sta.GetStaList("");
        //    if (sfkp == "Y")
        //    {
        //        var lst2 = lst.Where(a => a.C_STA_CODE == "5#CC" || a.C_STA_CODE == "7#CC").OrderBy(a => a.N_SORT).ToList();
        //        for (int i = 0; i < lst2.Count; i++)
        //        {
        //            icbo_lz2.Properties.Items.Add(lst2[i].C_STA_CODE, lst2[i].C_ID, -1);
        //        }
        //        icbo_lz2.SelectedIndex = 0;
        //    }
        //    else
        //    {
        //        var lst2 = lst.Where(a => a.C_STA_CODE == "3#CC" || a.C_STA_CODE == "4#CC" || a.C_STA_CODE == "6#CC").OrderBy(a => a.N_SORT).ToList();
        //        for (int i = 0; i < lst2.Count; i++)
        //        {
        //            icbo_lz2.Properties.Items.Add(lst2[i].C_STA_CODE, lst2[i].C_ID, -1);
        //        }
        //        icbo_lz2.SelectedIndex = 0;
        //    }
        //}

        ///// <summary>
        ///// 选择连铸
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void icbo_lz2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    modinfo = GetCcmInfo(modinfo, icbo_lz2.Properties.Items[this.icbo_lz2.SelectedIndex].Value.ToString());
        //    this.txt_ls.Text = modinfo.N_ZJCLS.ToString();
        //}
        /// <summary>
        ///// 根据连铸坯长加载连铸物料信息
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void cbo_slab_len_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbo_slab_len.Text.Trim() != "")
        //    {
        //        Mod_TB_MATRL_MAIN modwl = ccmwllist.Where(a => a.N_LTH == Convert.ToDecimal(cbo_slab_len.Text)).ToList()[0];
        //        this.txt_slab_wl_id.Text = modwl.C_ID;
        //        this.txt_slab_wl_mc.Text = modwl.C_MAT_NAME;
        //        this.txt_slab_size.Text = modwl.C_SLAB_SIZE;
        //        modinfo.C_MATRL_NO = modwl.C_ID;
        //        modinfo.C_MATRL_NAME = modwl.C_MAT_NAME;
        //        modinfo.C_SLAB_SIZE = modwl.C_SLAB_SIZE;
        //        modinfo.C_SLAB_LENGTH = cbo_slab_len.Text;
        //        modinfo.N_SLAB_PW = modwl.N_HSL;
        //    }
        //    else
        //    {
        //        this.txt_slab_wl_id.Text = "";
        //        this.txt_slab_wl_mc.Text = "";
        //        this.txt_slab_size.Text = "";
        //        modinfo.C_MATRL_NO = "";
        //        modinfo.C_MATRL_NAME = "";
        //        modinfo.C_SLAB_SIZE = "";
        //        modinfo.C_SLAB_LENGTH = "";
        //        modinfo.N_SLAB_PW = 0;
        //    }
        //}

        //private void cbo_kp_len_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbo_kp_len.Text.Trim() != "")
        //    {
        //        Mod_TB_MATRL_MAIN modwl = kpwllist.Where(a => a.N_LTH == Convert.ToDecimal(cbo_kp_len.Text)).ToList()[0];
        //        this.txt_kp_wl_id.Text = modwl.C_ID;
        //        this.txt_kp_wl_mc.Text = modwl.C_MAT_NAME;
        //        this.txt_kp_size.Text = modwl.C_SLAB_SIZE;
        //        modinfo.C_MATRL_CODE_KP = modwl.C_ID;
        //        modinfo.C_MATRL_NAME_KP = modwl.C_MAT_NAME;
        //        modinfo.C_KP_SIZE = modwl.C_SLAB_SIZE;
        //        modinfo.N_KP_LENGTH = Convert.ToDecimal(cbo_kp_len.Text);
        //        modinfo.N_KP_PW = modwl.N_HSL;
        //    }
        //    else
        //    {
        //        this.txt_kp_wl_id.Text = "";
        //        this.txt_kp_wl_mc.Text = "";
        //        this.txt_kp_size.Text = "";
        //        modinfo.C_MATRL_CODE_KP = "";
        //        modinfo.C_MATRL_NAME_KP = "";
        //        modinfo.C_KP_SIZE = "";
        //        modinfo.N_KP_LENGTH = 0;
        //        modinfo.N_KP_PW = 0;
        //    }
        //}

        ///// <summary>
        ///// 选择连铸
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void txt_ls_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (txt_ls.Text.Trim() != "")
        //    {
        //        if (Convert.ToInt32(txt_ls.Text) > 0)
        //        {
        //            if (this.icbo_lz2.Properties.Items[this.icbo_lz2.SelectedIndex].Description.Contains("5#"))
        //            {
        //                txt_jc_wgt.Text = (Convert.ToInt32(txt_ls.Text) * 77).ToString();
        //            }
        //            else
        //            {
        //                txt_jc_wgt.Text = (Convert.ToInt32(txt_ls.Text) * 47).ToString();
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// 添加非计划浇次计划
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btn_Seave_Click(object sender, EventArgs e)
        //{
        //    //先将浇次计划添加到浇次计划LIST中
        //    Mod_TPP_LGPC_LSB mod_jc = new Mod_TPP_LGPC_LSB();
        //    mod_jc.C_ID = System.Guid.NewGuid().ToString();
        //    mod_jc.C_CCM_ID = this.icbo_lz2.Properties.Items[this.icbo_lz2.SelectedIndex].Value.ToString();
        //    mod_jc.C_CCM_CODE = this.icbo_lz2.Properties.Items[this.icbo_lz2.SelectedIndex].Description;
        //    mod_jc.N_GROUP = jc_plan.Where(a => a.C_CCM_ID == mod_jc.C_CCM_ID).Max(a => a.N_GROUP) + 1;
        //    mod_jc.N_ZJCLS = Convert.ToDecimal(this.txt_ls.Text);
        //    mod_jc.N_ZJCLZL = Convert.ToDecimal(this.txt_jc_wgt.Text);
        //    mod_jc.N_MLZL = mod_jc.C_CCM_CODE == "5#CC" ? 77 : 47;
        //    mod_jc.N_SORT = jc_plan.Where(a => a.C_CCM_ID == mod_jc.C_CCM_ID).Max(a => a.N_SORT) + 1;
        //    mod_jc.C_STL_GRD = modinfo.C_STL_GRD;
        //    mod_jc.N_JSCN = modinfo.N_JSCN;
        //    mod_jc.C_BY1 = modinfo.C_BY1;
        //    mod_jc.C_BY2 = modinfo.C_BY2;
        //    mod_jc.C_BY3 = modinfo.C_BY3;
        //    mod_jc.C_RH = modinfo.C_RH;
        //    mod_jc.C_DFP_HL = modinfo.C_DFP_HL;
        //    mod_jc.C_HL = modinfo.C_HL;
        //    mod_jc.C_XM = modinfo.C_XM;
        //    mod_jc.N_ORDER_LS = 0;
        //    mod_jc.C_STD_CODE = modinfo.C_STD_CODE;
        //    mod_jc.C_STL_GRD_TYPE = modinfo.C_STL_GRD_TYPE;
        //    mod_jc.C_PROD_KIND = modinfo.C_PROD_KIND;
        //    mod_jc.C_PROD_NAME = modinfo.C_PROD_NAME;
        //    mod_jc.N_DFP_HL_TIME = modinfo.N_DFP_HL_TIME;
        //    mod_jc.N_HL_TIME = modinfo.N_HL_TIME;
        //    mod_jc.C_TL = modinfo.C_TL;
        //    mod_jc.C_REMARK = mod_jc.C_STL_GRD + "~" + mod_jc.C_STD_CODE + "~" + mod_jc.N_ZJCLS;
        //    jc_plan.Add(mod_jc);

        //    for (int i = 0; i < mod_jc.N_ZJCLS; i++)
        //    {
        //        Mod_TPP_LGPC_LCLSB mod_lc = new Mod_TPP_LGPC_LCLSB();
        //        mod_lc.C_ID = System.Guid.NewGuid().ToString();
        //        mod_lc.C_FK = mod_jc.C_ID;
        //        mod_lc.N_SLAB_WGT = mod_jc.N_MLZL;
        //        mod_lc.C_CCM_ID = mod_jc.C_CCM_ID;
        //        mod_lc.C_CCM_DESC = mod_jc.C_CCM_CODE;
        //        mod_lc.C_PROD_NAME = mod_jc.C_PROD_NAME;
        //        mod_lc.C_STL_GRD = mod_jc.C_STL_GRD;
        //        mod_lc.C_MATRL_NO = modinfo.C_MATRL_NO;
        //        mod_lc.C_MATRL_NAME = modinfo.C_MATRL_NAME;
        //        mod_lc.C_SLAB_SIZE = modinfo.C_SLAB_SIZE;
        //        mod_lc.C_SLAB_LENGTH = modinfo.C_SLAB_LENGTH;
        //        mod_lc.N_SORT = i + 1;
        //        mod_lc.C_BY1 = modinfo.C_BY1;
        //        mod_lc.C_BY2 = modinfo.C_BY2;
        //        mod_lc.C_BY3 = modinfo.C_BY3;
        //        mod_lc.C_RH = modinfo.C_RH;
        //        mod_lc.C_DFP_HL = modinfo.C_DFP_HL;
        //        mod_lc.C_HL = modinfo.C_HL;
        //        mod_lc.N_DFP_HL_TIME = modinfo.N_DFP_HL_TIME;
        //        mod_lc.N_HL_TIME = modinfo.N_HL_TIME;
        //        mod_lc.N_JSCN = modinfo.N_JSCN;
        //        mod_lc.C_ROUTE = modinfo.C_ROUTE;
        //        mod_lc.N_SLAB_PW = modinfo.N_SLAB_PW;
        //        mod_lc.C_MATRL_CODE_KP = modinfo.C_MATRL_CODE_KP;
        //        mod_lc.C_MATRL_NAME_KP = modinfo.C_MATRL_NAME_KP;
        //        mod_lc.C_KP_SIZE = modinfo.C_KP_SIZE;
        //        mod_lc.N_KP_LENGTH = modinfo.N_KP_LENGTH;
        //        mod_lc.N_KP_PW = modinfo.N_KP_PW;
        //        mod_lc.N_USE_WGT = modinfo.N_SLAB_WGT;

        //        mod_lc.C_DFP_RZ = modinfo.C_DFP_RZ;//?
        //        mod_lc.C_RZP_RZ = modinfo.C_RZP_RZ;//?
        //        mod_lc.C_DFP_YQ = modinfo.C_DFP_YQ;//?
        //        mod_lc.C_RZP_YQ = modinfo.C_RZP_YQ;//?
        //        mod_lc.C_STL_GRD_TYPE = modinfo.C_STL_GRD_TYPE;
        //        mod_lc.C_PROD_KIND = modinfo.C_PROD_KIND;
        //        mod_lc.C_TL = modinfo.C_TL;
        //        mod_lc.N_JSCN = modinfo.N_JSCN;
        //        mod_lc.C_FREE2 = modinfo.C_FREE2;//?
        //        mod_lc.N_GROUP = modinfo.N_GROUP;
        //        mod_lc.N_ZJCLS = modinfo.N_ZJCLS;
        //        mod_lc.N_ZJCLS_MIN = modinfo.N_ZJCLS_MIN;
        //        mod_lc.N_ZJCLS_MAX = modinfo.N_ZJCLS_MAX;
        //        mod_lc.C_SL = modinfo.C_SL;
        //        mod_lc.C_WL = modinfo.C_WL;
        //        mod_lc.N_JC_SORT = mod_jc.N_SORT;
        //        mod_lc.C_FREE1 = modinfo.C_FREE1;//?
        //        lc_plan.Add(mod_lc);
        //    }

        //}

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //dockPanel_addjc.Visibility=
        }

        private void btn_delete_jc_Click(object sender, EventArgs e)
        {
            //将没有计划的订单删除
           
                if (DialogResult.No == MessageBox.Show("是否删除当前选中的浇次计划！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                jc_plan.Remove(jc_plan.Where(a => a.C_ID == lbl_id.Text).ToList()[0]);
                bll_jc.Delete(lbl_id.Text);
                var lc_delete = lc_plan.Where(a => a.C_FK == lbl_id.Text).ToList();
                for (int i = 0; i < lc_delete.Count; i++)
                {
                    lc_plan.Remove(lc_delete[i]);
                    bll_lc.Delete(lc_delete[i].C_ID);
                }
                MessageBox.Show("计划已删除！");
                jc_plan = Initialize_List(jc_plan);
                this.modTPPLGPCLSBBindingSource.DataSource = jc_plan;
                this.gridView6.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gridView6);
                this.gridView6.UpdateSummary();
                this.gridView6.RefreshData();
                this.gridView6.BestFitColumns();
            
        }


        public void update_GXsort()
        {
            //重新生成工序计划
            string c_ccm = this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();
            List<Mod_TSP_CAST_PLAN> lstplan = new List<Mod_TSP_CAST_PLAN>();
            lstplan = bll_cast_plan.GetModelList(c_ccm, 2,"");
            Cls_Tsp_GX_Plan.Sort_GX_Plan(lstplan);


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string c_ccm = this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();
            List<Mod_TSP_CAST_PLAN> lstplan = new List<Mod_TSP_CAST_PLAN>();
            lstplan = bll_cast_plan.GetModelList(c_ccm, 2,"");
            Cls_Tsp_GX_Plan.Sort_GX_Plan(lstplan);
        }

        private void gridView6_DoubleClick(object sender, EventArgs e)
        {
            Point ms = Control.MousePosition;
            this.dplan_xh.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            this.dplan_xh.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dplan_xh.FloatLocation = new System.Drawing.Point(ms.X, ms.Y);
            Mod_TPP_LGPC_LSB mod = jc_plan.Where(a => a.C_ID == lbl_id.Text).ToList()[0];
            this.txt_xh.Text = mod.N_SORT.ToString();
            //this.txt_tj_remark.Text = mod.C_TJ_REMARK;
        }

        /// <summary>
        /// 确定更改序号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_xh_Click(object sender, EventArgs e)
        {
            int totalnum = jc_plan.Count;//总数
            int bsort = 0;//调整序号前的序号
            int esort = Convert.ToInt32(this.txt_xh.Text);//调整序号后的序号
            Mod_TPP_LGPC_LSB mod = jc_plan.Where(a => a.C_ID == lbl_id.Text).ToList()[0];
            bsort = (int)mod.N_SORT;
            if (Convert.ToInt32(this.txt_xh.Text) >= totalnum)
            {
                this.txt_xh.Text = mod.N_SORT.ToString();
                return;
            }
            if (Convert.ToInt32(this.txt_xh.Text) <= 0)
            {
                this.txt_xh.Text = mod.N_SORT.ToString();
                return;
            }
            if (bsort < esort)//向后调整
            {
                var lstupdate = jc_plan.Where(a => a.N_SORT > bsort && a.N_SORT <= esort).ToList();
                for (int i = 0; i < lstupdate.Count; i++)
                {
                    lstupdate[i].N_SORT = lstupdate[i].N_SORT - 1;
                }
            }
            else
            {
                var lstupdate = jc_plan.Where(a => a.N_SORT >= esort && a.N_SORT < bsort).ToList();
                for (int i = 0; i < lstupdate.Count; i++)
                {
                    lstupdate[i].N_SORT = lstupdate[i].N_SORT + 1;
                }
            }

            var lst = jc_plan.Where(a => a.C_ID == lbl_id.Text).ToList();
            if (lst.Count > 0)
            {
                lst[0].N_SORT = Convert.ToInt32(this.txt_xh.Text);
                this.dplan_xh.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }
            jc_plan = jc_plan.OrderBy(a => a.N_SORT).ToList();

            DateTime dtb = jc_plan.Min(a => a.D_P_START_TIME) == null ? System.DateTime.Now.AddHours(1) : (DateTime)jc_plan.Min(a => a.D_P_START_TIME);
            int ljls = 0;
            for (int i = 0; i < jc_plan.Count; i++)
            {
                if (jc_plan[i].C_PROD_NAME == "超低碳钢" && jc_plan[i].C_RH == "Y")
                {
                    ljls = 0;
                }
                else
                {
                    ljls = (int)(ljls + jc_plan[i].N_ZJCLS);
                }
                jc_plan[i].D_P_START_TIME = dtb;
                jc_plan[i].D_P_END_TIME = dtb.AddHours((double)(jc_plan[i].N_MLZL * jc_plan[i].N_ZJCLS / jc_plan[i].N_JSCN));
                if (ljls >= 32)
                {
                    jc_plan[i].N_PRODUCE_TIME = 4;
                    ljls = 0;
                }
                else
                {
                    jc_plan[i].N_PRODUCE_TIME = 0;
                }
                dtb = Convert.ToDateTime(jc_plan[i].D_P_END_TIME).AddHours((double)jc_plan[i].N_PRODUCE_TIME);
            }
            this.modTPPLGPCLSBBindingSource.DataSource = null;
            this.modTPPLGPCLSBBindingSource.DataSource = jc_plan;
            this.gridView6.RefreshData();

        }

        /// <summary>
        /// 加载连铸物料信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView7_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            modTBMATRLMAINBindingSource.DataSource = null;
            int index = gridView7.FocusedRowHandle;
            if (index < 0)
            {
                return;
            }
            try
            {
                string C_STL_GRD = gridView7.GetRowCellValue(index, "C_STL_GRD").ToString();
                string C_ROUTE = gridView7.GetRowCellValue(index, "C_ROUTE").ToString();

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
                DataTable dtgpwl = null;
                if (C_ROUTE.Contains("KP"))
                {
                    dtgpwl = bll_wl.GetGPWL(C_STL_GRD, "", null, "6", wllj, "大方坯连铸坯").Tables[0];
                }
                else
                {
                    dtgpwl = bll_wl.GetGPWL(C_STL_GRD, "", null, "6", wllj, "小方坯连铸坯").Tables[0];
                }
                modTBMATRLMAINBindingSource.DataSource = dtgpwl;
                this.gridView5.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gridView1);
                this.gridView5.BestFitColumns();
            }
            catch (Exception)
            {


            }

        }
        /// <summary>
        /// 修改选中炉次计划的钢坯物料信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView5_DoubleClick(object sender, EventArgs e)
        {
            int index = gridView7.FocusedRowHandle;
            int thisindex = gridView5.FocusedRowHandle;
            string C_ID = gridView7.GetRowCellValue(index, "C_ID").ToString();
            var lst = lc_plan.Where(a => a.C_ID == C_ID).ToList();
            if (lst.Count > 0)
            {
                lst[0].C_MATRL_NO = gridView5.GetRowCellValue(thisindex, "C_ID").ToString();
                lst[0].C_MATRL_NAME = gridView5.GetRowCellValue(thisindex, "C_MAT_NAME").ToString();
                lst[0].C_SLAB_SIZE = gridView5.GetRowCellValue(thisindex, "C_SLAB_SIZE").ToString();
                lst[0].C_SLAB_LENGTH = gridView5.GetRowCellValue(thisindex, "N_LTH").ToString();
                lst[0].N_SLAB_PW = Convert.ToDecimal(gridView5.GetRowCellValue(thisindex, "N_HSL").ToString());
                gridView6_FocusedRowObjectChanged(null, null);
            }
        }

        private void gridView7_DoubleClick(object sender, EventArgs e)
        {

         
            int index = gridView7.FocusedRowHandle;
            string C_ID = gridView7.GetRowCellValue(index, "C_ID").ToString();
            string c_state = gridView7.GetRowCellValue(index, "C_STATE").ToString();
            if (c_state == "1")
            {

            }

        }
        /// <summary>
        /// 复制list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public T CopyList<T>(T obj)
        {
            object retval;
            using (MemoryStream ms = new MemoryStream())
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                xml.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                retval = xml.Deserialize(ms);
                ms.Close();
            }
            return (T)retval;
        }
        /// <summary>
        /// 复制计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copy_jc_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否复制选中的浇次计划！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            if (lbl_id.Text.Trim() == "")
            {
                return;
            }

            Mod_TPP_LGPC_LSB modjc = CopyList(jc_plan).Where(a => a.C_ID == lbl_id.Text).ToList()[0];
            modjc.C_ID = System.Guid.NewGuid().ToString();
            modjc.N_SORT = jc_plan.Max(a => a.N_SORT) + 1;
            modjc.N_PRODUCE_TIME = 0;
            modjc.N_ORDER_LS = 0;
            jc_plan.Add(modjc);
            bll_jc.Add(modjc);

            var lstlc = CopyList(lc_plan).Where(a => a.C_FK == lbl_id.Text).ToList();
            for (int i = 0; i < lstlc.Count; i++)
            {
                Mod_TPP_LGPC_LCLSB modlc = lstlc[i];
                modlc.C_ID = System.Guid.NewGuid().ToString();
                modlc.C_FK = modjc.C_ID;
                modlc.N_JC_SORT = modjc.N_SORT;
                modlc.C_STATE = "1";
                modlc.N_PRODUCE_TIME = 0;
                lc_plan.Add(modlc);
                bll_lc.Add(modlc);

            }
            MessageBox.Show("计划已经复制！");
            jc_plan = Initialize_List(jc_plan);
            this.modTPPLGPCLSBBindingSource.DataSource = jc_plan;
            this.gridView6.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView6);
            this.gridView6.UpdateSummary();
            this.gridView6.RefreshData();
            this.gridView6.BestFitColumns();




        }

        private void btn_change_wl_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_lc_Click(object sender, EventArgs e)
        {

            this.dockPanel3.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            int index = gridView6.FocusedRowHandle;
            if (index < 0)
            {
                return;
            }
            Mod_TPP_LGPC_LSB modjc = bll_jc.GetModel(lbl_id.Text.Trim());
            //int N_GROUP = (int)modjc.N_GROUP;
            string C_CCM_ID = modjc.C_CCM_ID;
            int N_GROUP = Convert.ToInt32(gridView7.GetRowCellValue(0, "N_GROUP").ToString());
            //string C_CCM_ID = gridView7.GetRowCellValue(index, "C_CCM_ID").ToString();
            string D_DT_B = Convert.ToDateTime(modjc.D_ZZ_START_TIME).ToString("yyyy-MM-dd");
            string D_DT_E = Convert.ToDateTime(modjc.D_ZZ_END_TIME).ToString("yyyy-MM-dd");
            int SFWC = 0;
            DataTable dt = Cls_APS_PC.GetOrderiNFO(N_GROUP, C_CCM_ID, SFWC, D_DT_B, D_DT_E);
            this.gridControl9.DataSource = dt;
            this.gridView11.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView11);
            this.gridView11.BestFitColumns();
        }

        private void btn_tzgz_Click(object sender, EventArgs e)
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
            Mod_TSP_CAST_PLAN modjc = bll_cast_plan.GetModel(lbl_id.Text.Trim());

            int rowhandle = gridView11.FocusedRowHandle;

            string C_STL_GRD = gridView11.GetRowCellValue(rowhandle, "C_STL_GRD_SLAB").ToString();
            string C_STD_CODE = gridView11.GetRowCellValue(rowhandle, "C_STD_CODE_SLAB").ToString();
            string C_BY1 = gridView11.GetRowCellValue(rowhandle, "C_BY1").ToString();
            string C_BY2 = gridView11.GetRowCellValue(rowhandle, "C_BY2").ToString();

            string C_MATRL_CODE_SLAB = gridView11.GetRowCellValue(rowhandle, "C_MATRL_CODE_SLAB").ToString();


            WaitingFrom.ShowWait("");
            int rowhandle2 = gridView7.FocusedRowHandle;
            int N_GROUP = Convert.ToInt32(gridView7.GetRowCellValue(rowhandle2, "N_GROUP").ToString());
            //int N_JC_SORT = Convert.ToInt32(gridView7.GetRowCellValue(rowhandle, "N_/JC_SORT").ToString());//浇次序号
            Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(this.lbl_id.Text);

            Cls_APS_PC.AddLCJHLSB(C_STL_GRD, C_STD_CODE, C_BY1, C_BY2, C_MATRL_CODE_SLAB, this.lbl_id.Text, Convert.ToInt32(this.txt_add_ls.Text));
            this.txt_add_ls.Text = "";
            UpdateJCByLC(this.lbl_id.Text);
            // btn_sort_Click(null,null);
            btn_query_jc_Click(null, null);
            WaitingFrom.CloseWait();
            this.dockPanel3.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }

        private void btn_delete_lc_Click(object sender, EventArgs e)
        {
            if (txtDeleteLS.Text.Trim() == "")
            {
                MessageBox.Show("请输入删除的炉数！");
                return;
            }
            if (Convert.ToInt32(txtDeleteLS.Text) <= 0)
            {
                MessageBox.Show("请输入正确的炉数！");
                return;
            }
            int index = gridView7.FocusedRowHandle;
            if (index < 0)
            {
                return;
            }
            WaitingFrom.ShowWait("");
            string C_ID = gridView7.GetRowCellValue(index, "C_ID").ToString();
            string c_stl_grd = gridView7.GetRowCellValue(index, "C_STL_GRD").ToString();
            string c_std_code = gridView7.GetRowCellValue(index, "C_STD_CODE").ToString();
            string c_slab_size = gridView7.GetRowCellValue(index, "C_SLAB_SIZE").ToString();
            string C_SLAB_LENGTH = gridView7.GetRowCellValue(index, "C_SLAB_LENGTH").ToString();

            List<Mod_TPP_LGPC_LCLSB> lstdelete = bll_lc.GetModelListByJcID(this.lbl_id.Text).Where(a => a.C_STL_GRD == c_stl_grd && a.C_STD_CODE == c_std_code && a.C_SLAB_SIZE == c_slab_size && a.C_SLAB_LENGTH == C_SLAB_LENGTH).OrderByDescending(a => a.N_SORT).ToList();
            if (Convert.ToInt32(txtDeleteLS.Text) > lstdelete.Count)
            {
                MessageBox.Show("您要删除的炉次计划数超出该浇次最大数量！");
                txtDeleteLS.Text = lstdelete.Count.ToString();
                return;
            }
            if (DialogResult.No == MessageBox.Show("是否确认删除炉次计划：" + c_stl_grd + "~" + c_std_code + "~" + c_slab_size + "*" + C_SLAB_LENGTH + "；" + txtDeleteLS.Text + "炉" + "？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            for (int i = 0; i < Convert.ToInt32(txtDeleteLS.Text); i++)
            {
                bll_lc.Delete(lstdelete[i].C_ID);
            }
            //Mod_TPP_LGPC_LCLSB mod_sms = bll_lc.GetModel(C_ID);
            //if (mod_sms.N_CREAT_PLAN == 1)
            //{
            //    bll_lc.Delete(C_ID);
            //}
            UpdateJCByLC(this.lbl_id.Text);
            btn_query_jc_Click(null, null);

            WaitingFrom.CloseWait();
        }

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

        private void btn_tzwl_Click(object sender, EventArgs e)
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
                Mod_TPP_LGPC_LCLSB mod = bll_lc.GetModel(C_ID);
                if (mod != null)
                {
                    mod.C_MATRL_NO = gridView5.GetRowCellValue(thisindex, "C_ID").ToString();
                    mod.C_MATRL_NAME = gridView5.GetRowCellValue(thisindex, "C_MAT_NAME").ToString();
                    mod.C_SLAB_SIZE = gridView5.GetRowCellValue(thisindex, "C_SLAB_SIZE").ToString();
                    mod.C_SLAB_LENGTH = gridView5.GetRowCellValue(thisindex, "N_LTH").ToString();
                    mod.N_SLAB_PW = Convert.ToDecimal(gridView5.GetRowCellValue(thisindex, "N_HSL").ToString());
                    bll_lc.Update(mod);
                   
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
                Mod_TPP_LGPC_LCLSB mod = bll_lc.GetModel(C_ID);
                List<Mod_TPP_LGPC_LCLSB> lstlc = bll_lc.GetModelListByJcID(mod.C_FK).Where(a => a.C_MATRL_NO == mod.C_MATRL_NO).ToList();
                if (lstlc.Count > 0)
                {
                    for (int i = 0; i < lstlc.Count; i++)
                    {
                        if (lstlc[i] != null)
                        {
                            lstlc[i].C_MATRL_NO = gridView5.GetRowCellValue(thisindex, "C_ID").ToString();
                            lstlc[i].C_MATRL_NAME = gridView5.GetRowCellValue(thisindex, "C_MAT_NAME").ToString();
                            lstlc[i].C_SLAB_SIZE = gridView5.GetRowCellValue(thisindex, "C_SLAB_SIZE").ToString();
                            lstlc[i].C_SLAB_LENGTH = gridView5.GetRowCellValue(thisindex, "N_LTH").ToString();
                            lstlc[i].N_SLAB_PW = Convert.ToDecimal(gridView5.GetRowCellValue(thisindex, "N_HSL").ToString());
                            bll_lc.Update(lstlc[i]);
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
                Mod_TPP_LGPC_LCLSB mod = bll_lc.GetModel(C_ID);
                List<Mod_TPP_LGPC_LCLSB> lstlc = bll_lc.GetModelListByJcID(mod.C_FK).Where(a => a.C_MATRL_NO == mod.C_MATRL_NO && a.C_STD_CODE == mod.C_STD_CODE ).OrderByDescending(a => a.N_SORT).ToList();
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
                        if (lstlc[i] != null )
                        {
                            lstlc[i].C_MATRL_NO = gridView5.GetRowCellValue(thisindex, "C_ID").ToString();
                            lstlc[i].C_MATRL_NAME = gridView5.GetRowCellValue(thisindex, "C_MAT_NAME").ToString();
                            lstlc[i].C_SLAB_SIZE = gridView5.GetRowCellValue(thisindex, "C_SLAB_SIZE").ToString();
                            lstlc[i].C_SLAB_LENGTH = gridView5.GetRowCellValue(thisindex, "N_LTH").ToString();
                            lstlc[i].N_SLAB_PW = Convert.ToDecimal(gridView5.GetRowCellValue(thisindex, "N_HSL").ToString());
                            bll_lc.Update(lstlc[i]);
                        }
                    }
                }

                txt_update_ls.Text = "";
                dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                btn_query_jc_Click(null, null);
                WaitingFrom.CloseWait();
            }
        }

        private void btn_changeCCM_Click(object sender, EventArgs e)
        {
            if (this.icbo_lz3.EditValue == this.icbo_lz4.EditValue)
            {
                MessageBox.Show("请选择不同的连铸机进行调整！");
                return;
            }
            if (DialogResult.No == MessageBox.Show("是否将当前选中的浇次计划调整到连铸：" + this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Description.ToString(), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
           

           string res=  ChangeCCM(lbl_id.Text.Trim(), this.icbo_lz4.Properties.Items[this.icbo_lz4.SelectedIndex].Value.ToString(), "");
            MessageBox.Show(res);
            if (res== "选中计划已调整到目标连铸！")
            {
                jc_plan.Remove(jc_plan.Where(a => a.C_ID == lbl_id.Text).ToList()[0]);
                bll_jc.Delete(lbl_id.Text);
                var lc_delete = lc_plan.Where(a => a.C_FK == lbl_id.Text).ToList();
                for (int i = 0; i < lc_delete.Count; i++)
                {
                    lc_plan.Remove(lc_delete[i]);
                    bll_lc.Delete(lc_delete[i].C_ID);
                }

                Common.UserLog.AddLog(RV.UI.UserInfo.menuName, this.Name, this.Text, "调整浇次连铸机");//添加操作日志

                btn_query_jc_Click(null, null);
            }
            
           // btnSaveJcPlan_Click(null, null);
        }
        private Bll_TPB_SCLX bll_lx = new Bll_TPB_SCLX();
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
            Mod_TPP_LGPC_LSB mod = bll_jc.GetModel(c_id);//待调整连铸的浇次计划
            List<Mod_TPP_LGPC_LCLSB> lstsms = bll_lc.GetModelListByJcID(c_id);//当前浇次的炉次计划
            int maxjcsort = bll_cast_plan.Max_jc_sort(c_ccm_id) + 1;//目标连铸的浇次最大序号
            int maxlcsort = bll_plan_sms.GetMaxSort(c_ccm_id) + 1;//目标连铸的最大炉次序号
            Mod_TB_STA mod_sta = bll_sta.GetModel(c_ccm_id);
            Mod_TPB_SCLX modlx = bll_lx.GetModel(c_ccm_id);
            #region 验证
           

            
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

                Mod_TPP_LGPC_LSB mod_new = mod;
                mod_new.C_ID = System.Guid.NewGuid().ToString();
                mod_new.C_CCM_ID = c_ccm_id;
                mod_new.C_CCM_CODE = mod_sta.C_STA_DESC;
                mod_new.N_SORT = maxjcsort;
                if (bll_jc.Add(mod_new))//添加新的浇次计划
                {
                    //mod.N_STATUS = 0;
                    //bll_cast_plan.Update(mod);
                    //添加新的炉次计划
                    for (int i = 0; i < lstsms.Count; i++)
                    {
                        Mod_TPP_LGPC_LCLSB mod_sms_new = lstsms[i];
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
                        bll_lc.Add(mod_sms_new);
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
             .GroupBy(x => new { x.C_STL_GRD, x.C_STD_CODE ,x.C_ROUTE })
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

                Mod_TPP_LGPC_LSB mod_new = mod;
                mod_new.C_ID = System.Guid.NewGuid().ToString();
                mod_new.C_CCM_ID = c_ccm_id;
                mod_new.C_CCM_CODE = mod_sta.C_STA_DESC;
                mod_new.N_SORT = maxjcsort;
                if (bll_jc.Add(mod_new))//添加新的浇次计划
                {
                    //mod.N_STATUS = 0;
                    //bll_cast_plan.Update(mod);
                    //添加新的炉次计划
                    for (int i = 0; i < lstsms.Count; i++)
                    {
                        Mod_TPP_LGPC_LCLSB mod_sms_new = lstsms[i];
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
                        DataTable dtCcmSlab = bll_wl.GetCCMSlab(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE,lstsms[i].C_ROUTE, c_slab_size);
                        if (dtCcmSlab.Rows.Count >= 0)
                        {
                            mod_sms_new.C_MATRL_NO = dtCcmSlab.Rows[0]["C_MAT_CODE"].ToString();
                            mod_sms_new.C_MATRL_NAME = dtCcmSlab.Rows[0]["C_MAT_NAME"].ToString();
                            mod_sms_new.C_SLAB_SIZE = dtCcmSlab.Rows[0]["C_SLAB_SIZE"].ToString();
                            mod_sms_new.C_SLAB_LENGTH = dtCcmSlab.Rows[0]["N_LTH"].ToString();
                            mod_sms_new.N_SLAB_PW = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_HSL"].ToString());

                        }

                        bll_lc.Add(mod_sms_new);
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

                    Mod_TPP_LGPC_LSB mod_new = mod;
                    mod_new.C_ID = System.Guid.NewGuid().ToString();
                    mod_new.C_CCM_ID = c_ccm_id;
                    mod_new.C_CCM_CODE = mod_sta.C_STA_DESC;
                    mod_new.N_SORT = maxjcsort;
                    if (bll_jc.Add(mod_new))//添加新的浇次计划
                    {
                        //mod.N_STATUS = 0;
                        //bll_cast_plan.Update(mod);
                        //添加新的炉次计划
                        for (int i = 0; i < lstsms.Count; i++)
                        {
                            Mod_TPP_LGPC_LCLSB mod_sms_new = lstsms[i];
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
                            bll_lc.Add(mod_sms_new);
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
                        DataTable dtCcmSlab = bll_wl.GetCCMSlab(sms_stl[i].STL_GRD, sms_stl[i].STD_CODE,sms_stl[i].ROUTE, c_slab_size);
                        if (dtCcmSlab.Rows.Count == 0)
                        {
                            isChange = false;
                            return sms_stl[i].STL_GRD + "【" + sms_stl[i].STD_CODE + "】" + "没有断面为160*160的钢坯物料编码，请在NC维护后再调整！";

                        }
                    }
                    #endregion

                    Mod_TPP_LGPC_LSB mod_new = mod;
                    mod_new.C_ID = System.Guid.NewGuid().ToString();
                    mod_new.C_CCM_ID = c_ccm_id;
                    mod_new.C_CCM_CODE = mod_sta.C_STA_DESC;
                    mod_new.N_SORT = maxjcsort;
                    if (bll_jc.Add(mod_new))//添加新的浇次计划
                    {
                        //mod.N_STATUS = 0;
                        //bll_cast_plan.Update(mod);
                        //添加新的炉次计划
                        for (int i = 0; i < lstsms.Count; i++)
                        {
                            Mod_TPP_LGPC_LCLSB mod_sms_new = lstsms[i];
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
                            DataTable dtCcmSlab = bll_wl.GetCCMSlab(lstsms[i].C_STL_GRD, lstsms[i].C_STD_CODE,lstsms[i].C_ROUTE, c_slab_size);
                            if (dtCcmSlab.Rows.Count >= 0)
                            {
                                mod_sms_new.C_MATRL_NO = dtCcmSlab.Rows[0]["C_MAT_CODE"].ToString();
                                mod_sms_new.C_MATRL_NAME = dtCcmSlab.Rows[0]["C_MAT_NAME"].ToString();
                                mod_sms_new.C_SLAB_SIZE = dtCcmSlab.Rows[0]["C_SLAB_SIZE"].ToString();
                                mod_sms_new.C_SLAB_LENGTH = dtCcmSlab.Rows[0]["N_LTH"].ToString();
                                mod_sms_new.N_SLAB_PW = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_HSL"].ToString());

                            }

                            bll_lc.Add(mod_sms_new);
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
                DataTable dttz = bll_lc.GetGroupPlan(c_id);
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

                    Mod_TPP_LGPC_LSB mod_newjc = mod;
                    mod_newjc.C_ID = System.Guid.NewGuid().ToString();
                    mod_newjc.C_CCM_ID = c_ccm_id;
                    mod_newjc.C_CCM_CODE = mod_sta.C_STA_DESC;
                    mod_newjc.N_MLZL = n_mlzl_e;
                    mod_newjc.N_SORT = maxjcsort;

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
                        Mod_TPP_LGPC_LCLSB mod_newlc = lstsms.Where(a => a.C_STL_GRD == dttz.Rows[i]["C_STL_GRD"].ToString() && a.C_STD_CODE == dttz.Rows[i]["C_STD_CODE"].ToString() && a.C_MATRL_NO == dttz.Rows[i]["C_MATRL_NO"].ToString()).ToList()[0];
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
                            bll_lc.Add(mod_newlc);
                            sort = sort + 1;
                        }
                    }

                    mod_newjc.N_TOTAL_WGT = totalwgt;
                    mod_newjc.N_ZJCLZL = totalwgt;
                    mod_newjc.N_ZJCLS = totalls;
                    mod_newjc.N_STATUS = 1;
                    mod_newjc.C_REMARK = remark;

                    bll_jc.Add(mod_newjc);
                  
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



    }
}
