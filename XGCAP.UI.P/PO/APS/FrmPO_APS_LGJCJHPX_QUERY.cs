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
    public partial class FrmPO_APS_LGJCJHPX_QUERY : Form
    {
        public FrmPO_APS_LGJCJHPX_QUERY()
        {
            InitializeComponent();
        }
        #region 实例化功能设计对象 
        private static Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();//浇次计划
        private static Bll_TSP_PLAN_SMS bll_plan_sms = new Bll_TSP_PLAN_SMS();//炉次计划
       
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
        private void BindLsbGrid(string strCCMID, int n_status)
        {
            jc_cast_plan = bll_cast_plan.GetModelList(strCCMID, n_status,"").OrderBy(a => a.N_SORT).ToList();
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
                    dt_jc_start_time = (DateTime)jc_cast_plan.Min(a => a.D_P_START_TIME);
                  
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
                                                       //e.Appearance.BackColor2 = Color.Blue;// 添加渐变颜色
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion
        
        #endregion

        public int jcminsort = 1;//浇次起始序号
        public int lcminsort = 1;//炉次起始序号
        

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
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPO_APS_Order_LGFX_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            CommonSub.BindIcboNoAll("", "CC", icbo_lz3);
            //icbo_lz3.SelectedIndex = 2;
           
            if (this.icbo_lz3.SelectedIndex >= 0)
            {
                string strccm = this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();
                BindLsbGrid(strccm, this.rbtn_status.SelectedIndex + 1);
                BindLcLsbGrid("");
                
            }



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
                    BindLcLsbGrid(c_cid);//加载炉次计划顺序
                    Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(c_cid);
                    minsort = bll_plan_sms.GetMaxSort(Convert.ToInt32(mod.N_SORT), mod.C_CCM_ID);
                }


            }
            catch (Exception)
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
                BindLsbGrid(_strCCMID, this.rbtn_status.SelectedIndex + 1);
                this.gridView6.FocusedRowHandle = jcRowHand;
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {

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


        private Bll_TB_STA bll_sta = new Bll_TB_STA();
        private Bll_TPB_SCLX bll_lx = new Bll_TPB_SCLX();
        private Bll_TPB_SLAB_CAPACITY bll_jscn = new Bll_TPB_SLAB_CAPACITY();
        /// <summary>
        /// 调整浇次计划连铸信息
        /// </summary>
        /// <param name="c_id">浇次计划主键</param>
        /// <param name="c_ccm_id">调整后连铸主键</param>
        /// <param name="c_remark">调整说明</param>
        public string ChangeCCM(string c_id, string c_ccm_id, string c_remark)
        {

            string c_ccm_desc = bll_sta.GetModel(c_ccm_id).C_STA_CODE;//连铸代码
            Mod_TSP_CAST_PLAN mod = bll_cast_plan.GetModel(c_id);
            List<Mod_TSP_PLAN_SMS> lst_sms = new List<Mod_TSP_PLAN_SMS>();//新浇次的炉次计划

            if (mod.N_MLZL > 50 && mod.N_MLZL < 60)//不锈钢
            {
                return "不锈钢计划只能在6#连铸生产！";
            }
            if (mod.C_RH == "Y")
            {
                return "过真空的浇次计划不能调整！";
            }
            decimal n_mlzl_e = 0;//调整后的炉次重量
            if (c_ccm_id == "77B9FDA79B884D07AA2B3601D1DA11A2")
            {
                n_mlzl_e = 77;
            }
            else
            {
                n_mlzl_e = 47;
            }
            Mod_TPB_SCLX modlx = bll_lx.GetModel(c_ccm_id);
            #region 添加新的浇次计划
            Mod_TSP_CAST_PLAN mod_cast = new Mod_TSP_CAST_PLAN();
            mod_cast = mod;
            mod_cast.C_ID = System.Guid.NewGuid().ToString();
            mod_cast.N_SORT = bll_cast_plan.Max_jc_sort(c_ccm_id) + 1;
            mod_cast.C_CCM_ID = c_ccm_id;
            mod_cast.C_CCM_CODE = c_ccm_desc;
            mod_cast.N_PRODUCE_TIME = 0;
            mod_cast.N_MLZL = n_mlzl_e;

            mod_cast.C_TZ_REMARK = c_remark;
            #endregion
            int lsxh = bll_plan_sms.GetMaxSort(c_ccm_id);
            int ypls = 0;
            var lcjh = bll_plan_sms.GetModelListByJcID(c_id);//当前浇次的炉次计划
                                                             //调整有计划的连铸计划
            var lst_lc = bll_plan_sms.GetModelListByJcID(c_id).Where(ba => ba.C_STATE == "0" && ba.N_CREAT_PLAN == 1).GroupBy(ca => new { ca.C_STL_GRD, ca.C_STD_CODE }).Select(ca => new { n_wgt = ca.Sum(p => p.N_SLAB_WGT), ca.First().C_STL_GRD, ca.First().C_STD_CODE }).ToList();
            if (lst_lc.Count > 0)
            {
                for (int i = 0; i < lst_lc.Count; i++)
                {
                    Mod_TSP_PLAN_SMS mod_sms = new Mod_TSP_PLAN_SMS();
                    decimal n_wgt = (decimal)lst_lc[i].n_wgt;//
                    ypls = (int)Math.Ceiling(n_wgt / n_mlzl_e);//应排炉数
                    mod_sms = lcjh[0];
                    mod_sms.N_SLAB_WGT = n_mlzl_e;//新的每炉重量
                    mod_sms.C_STATE = "0";
                    mod_sms.C_CCM_ID = c_ccm_id;
                    mod_sms.C_CCM_DESC = c_ccm_desc;
                    mod_sms.N_JC_SORT = mod_cast.N_SORT;
                    mod_sms.C_FK = mod_cast.C_ID;
                    mod_sms.C_LF_ID = modlx.C_LF;
                    mod_sms.C_RH_ID = modlx.C_RH;
                    mod_sms.C_ZL_ID = modlx.C_ZL;
                    mod_sms.N_PRODUCE_TIME = 0;
                    mod_sms.N_USE_WGT = n_mlzl_e;
                    List<Mod_TPB_SLAB_CAPACITY> lstjscn = bll_jscn.GetListByCCM(mod_sms.C_STL_GRD, mod_sms.C_STD_CODE, mod_sms.C_CCM_ID);
                    if (lstjscn.Count > 0)
                    {
                        mod_sms.N_JSCN = lstjscn[0].N_CAPACITY;

                    }
                    if (mod_sms.N_JSCN == 0)
                    {
                        mod_sms.N_JSCN = mod_sms.C_CCM_DESC == "5#CC" ? 114 : 88;
                    }
                    mod_cast.N_JSCN = mod_sms.N_JSCN;//?机时产量
                    mod_sms.N_PROD_TIME = n_mlzl_e / mod_sms.N_JSCN;//?生产时间
                    for (int j = 0; j < ypls; j++)
                    {
                        mod_sms.C_ID = System.Guid.NewGuid().ToString();
                        mod_sms.N_SORT = lsxh + 1;
                        lsxh = lsxh + 1;
                        bll_plan_sms.Add(mod_sms);
                    }
                }

            }
            //调整非计划的连铸计划
            var lst_lc_fjh = bll_plan_sms.GetModelListByJcID(c_id).Where(ba => ba.C_STATE == "1" && ba.N_CREAT_PLAN == 1).GroupBy(ca => new { ca.C_STL_GRD, ca.C_STD_CODE }).Select(ca => new { n_wgt = ca.Sum(p => p.N_SLAB_WGT), ca.First().C_STL_GRD, ca.First().C_STD_CODE }).ToList();
            if (lst_lc_fjh.Count > 0)
            {
                for (int i = 0; i < lst_lc_fjh.Count; i++)
                {
                    Mod_TSP_PLAN_SMS mod_sms = new Mod_TSP_PLAN_SMS();
                    decimal n_wgt = (decimal)lst_lc_fjh[i].n_wgt;//
                    ypls = (int)Math.Ceiling(n_wgt / n_mlzl_e);//应排炉数
                    mod_sms = lcjh[0];
                    mod_sms.N_SLAB_WGT = n_mlzl_e;//新的每炉重量
                    mod_sms.C_STATE = "1";
                    mod_sms.C_CCM_ID = c_ccm_id;
                    mod_sms.C_CCM_DESC = c_ccm_desc;
                    mod_sms.N_JC_SORT = mod_cast.N_SORT;
                    mod_sms.C_FK = mod_cast.C_ID;
                    mod_sms.C_LF_ID = modlx.C_LF;
                    mod_sms.C_RH_ID = modlx.C_RH;
                    mod_sms.C_ZL_ID = modlx.C_ZL;
                    mod_sms.N_PRODUCE_TIME = 0;
                    mod_sms.N_USE_WGT = n_mlzl_e;
                    List<Mod_TPB_SLAB_CAPACITY> lstjscn = bll_jscn.GetListByCCM(mod_sms.C_STL_GRD, mod_sms.C_STD_CODE, mod_sms.C_CCM_ID);
                    if (lstjscn.Count > 0)
                    {
                        mod_sms.N_JSCN = lstjscn[0].N_CAPACITY;

                    }
                    if (mod_sms.N_JSCN == 0)
                    {
                        mod_sms.N_JSCN = mod_sms.C_CCM_DESC == "5#CC" ? 114 : 88;
                    }
                    mod_cast.N_JSCN = mod_sms.N_JSCN;//?机时产量
                    mod_sms.N_PROD_TIME = n_mlzl_e / mod_sms.N_JSCN;//?生产时间
                    for (int j = 0; j < ypls; j++)
                    {
                        mod_sms.C_ID = System.Guid.NewGuid().ToString();
                        mod_sms.N_SORT = lsxh + 1;
                        lsxh = lsxh + 1;
                        bll_plan_sms.Add(mod_sms);
                    }
                }

            }

            bll_cast_plan.Add(mod_cast);

            int yls = lcjh.Where(a => a.N_CREAT_PLAN > 1).ToList().Count;//已排产炉数
            bll_plan_sms.DeleteByjcid(c_id);
            if (yls == 0)
            {
                bll_cast_plan.Delete(c_id);//删除当前浇次计划

            }
            else
            {
                bll_cast_plan.Update(c_id, yls);//修改当前浇次计划
            }


            return "调整连铸成功！";
        }
        private Bll_TB_MATRL_MAIN bll_wl = new Bll_TB_MATRL_MAIN();//物料信息表
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
        /// <summary>
        /// 确定调整物料信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tzwl_Click(object sender, EventArgs e)
        {

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
                    DataTable dtdown = bll_plan_sms.GetDownPlan(sms_plan[i].C_ID);
                    if (dtdown.Rows.Count == 0)
                    {
                        int maxsort = bll_plan_sms.GetMaxSortYXMES(sms_plan[i].C_CCM_ID);
                        Mod_TSP_PLAN_SMS modlc = bll_plan_sms.GetModel(sms_plan[i].C_ID);
                        if (sms_plan[i].N_CREAT_PLAN < 3 && modlc.N_CREAT_PLAN == sms_plan[i].N_CREAT_PLAN)//没有下发MES并状态和数据库状态一致才能修改
                        {
                            if (maxsort < sms_plan[i].N_SORT)
                            {
                                bll_plan_sms.Update(sms_plan[i]);
                            }
                        }


                    }

                }
                MessageBox.Show("数据已保存！");
            }
            WaitingFrom.CloseWait();
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


                dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                btn_query_jc_Click(null, null);
                WaitingFrom.CloseWait();
            }
        }
        private Bll_TPP_CAST_PLAN bll_tpp_cast_plan = new Bll_TPP_CAST_PLAN();
       
        private void btn_add_lc_new_Click(object sender, EventArgs e)
        {
            // Cls_APS_PC.AddLCJH(string C_STL_GRD, string C_STD_CODE, string C_SLAB_SIZE, int N_SLAB_LENGTH, string C_JC_ID, int N_LS);
        }

        
        private void gridView6_Click(object sender, EventArgs e)
        {
            jcRowHand = gridView6.FocusedRowHandle;
        }

     
        /// <summary>
        /// 跟新连铸的浇次序号和炉次序号
        /// </summary>
        /// <param name="C_CCM_ID">连铸机</param>
        public void UpdateCCMSort(string C_CCM_ID)
        {
            List<Mod_TSP_CAST_PLAN> lstjc = bll_cast_plan.GetModelList(C_CCM_ID, 3,"").OrderBy(a => a.N_SORT).ToList();
        }

      
       
    }
}
