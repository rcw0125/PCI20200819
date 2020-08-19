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

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_Order_Manage_OLD : Form
    {
        public FrmPO_Order_Manage_OLD()
        {
            InitializeComponent();
        }
        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();//订单池
        private Bll_TPP_INITIALIZE_STA bll_TPP_INITIALIZE_STA = new Bll_TPP_INITIALIZE_STA();//方案初始化工序工位
        private Bll_TPB_BORDER_GRD bll_xlgz = new Bll_TPB_BORDER_GRD();//相邻钢种
        private Bll_TB_STA bll_gw = new Bll_TB_STA();//工位
        private Bll_TPP_LGPC_LSB bll_lsb = new Bll_TPP_LGPC_LSB();
        private Bll_TPP_LGPC_LCLSB bll_lclsb = new Bll_TPP_LGPC_LCLSB();
        private Bll_TRP_PLAN_ROLL bll_roll_plan = new Bll_TRP_PLAN_ROLL();//轧钢计划表
        private Bll_TSP_PLAN_SMS bll_sms = new Bll_TSP_PLAN_SMS();
        /// <summary>
        /// 加载工位信息到ImageComboBoxEdit
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <param name="cbo">ImageComboBoxEdit</param>
        public void BindIcbo(string strIniID, string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetGXGWByIni(strIniID, strGX);
            if (dt.Rows.Count > 0)
            {
                cbo.Properties.Items.Add("", "", -1);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_STA_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }


        DataTable DTypj = null;
        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_order_wcsh_Click(object sender, EventArgs e)
        {
            string strzx = "";//查询轧线
            if (this.icbo_zx2.SelectedIndex > 0)
            {
                strzx = this.icbo_zx2.Properties.Items[this.icbo_zx2.SelectedIndex].Value.ToString().Trim();
            }
            string strlz = "";//查询连铸
            if (this.icbo_lz2.SelectedIndex > 0)
            {
                strlz = this.icbo_lz2.Properties.Items[this.icbo_lz2.SelectedIndex].Value.ToString().Trim();
            }
            string  iSFPW ="";
            if (rbtn_SFPW.SelectedIndex == 0)
            {
                iSFPW = "Y";
            }
            else
            {
                iSFPW = "N";
            }
            WaitingFrom.ShowWait("");
            DTypj = bll_order.GetLGPCOrder(this.txt_gz2.Text.Trim(), this.txt_zxbz2.Text.Trim(), strlz, iSFPW);
            //DTypj = bll_order.GetListByWhere("Y", 2, 0, iSFPW, "", "", "", this.txt_gz2.Text.Trim(), this.txt_zxbz2.Text.Trim(), "", null, null, strzx, strlz, "", "", "", "", "", "", "").Tables[0];
            this.gc_tmo_order_pj.DataSource = DTypj;
            gc_tmo_order_pj.MainView = gv_tmo_order_pj;
            this.gv_tmo_order_pj.OptionsView.ColumnAutoWidth = false;
            this.gv_tmo_order_pj.OptionsSelection.MultiSelect = true;
            gv_tmo_order_pj.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gv_tmo_order_pj);
            this.gv_tmo_order_pj.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 系统炼钢排产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否让系统重新将未排连铸计划的订单重新排产？\r\n重新排产后之前未下发排产结果将不再保存！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                WaitingFrom.ShowWait("");
                OrderLGAuto(DTypj);
                WaitingFrom.CloseWait();
                FrmPO_SCDD_PC frm = new FrmPO_SCDD_PC();
                frm.ShowDialog();

            }
            //else
            //{
            //    FrmPO_SCDD_PC frm = new FrmPO_SCDD_PC();
            //    frm.ShowDialog();
            //}

        }

        /// <summary>
        /// 炼钢数据表
        /// </summary>
        /// <param name="dt"></param>
        public void OrderLGAuto(DataTable dt)
        {
            try
            {
                //获取未完成炼钢计划的计划结束时间和计划钢种

                DateTime lastdt = System.DateTime.Now;//计划结束时间
                DataTable dtpcOrdercl = dt.Copy();
                dtpcOrdercl.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dtpcOrdercl.Rows.Add(dt.Rows[i].ItemArray);
                }
                dtpcOrdercl.DefaultView.Sort = " C_CCM_NO, D_DELIVERY_DT,C_ORDER_LEV,C_STL_GRD,C_STD_CODE ";//将选中的订单按照排产目标进行排序
                dtpcOrdercl = dtpcOrdercl.DefaultView.ToTable();//获取的需要初始化的表

                #region 按照可混浇规则进行钢种排产分组
                //for (int j = 0; j < dtpcOrdercl.Rows.Count; j++)
                //{
                //    Mod_TMO_ORDER mod = bll_order.GetModel(dtpcOrdercl.Rows[j]["C_ID"].ToString());
                //    if (mod.N_GROUP == null && dtpcOrdercl.Rows[j]["N_GROUP"].ToString().Trim() == "")
                //    {
                //        string ss = dtpcOrdercl.Select("", "N_GROUP DESC")[0]["N_GROUP"].ToString().Trim() == "" ? "0" : dtpcOrdercl.Select("", "N_GROUP DESC")[0]["N_GROUP"].ToString().Trim();//获取未排产炼钢订单中最大分组序号
                //        int a = Convert.ToInt32(ss) + 1;//新的分组序号
                //        dtpcOrdercl.Rows[j]["N_GROUP"] = a;
                //        mod.N_GROUP = a;
                //        bll_order.Update(mod);

                //        for (int k = 0; k < dtpcOrdercl.Rows.Count; k++)
                //        {
                //            if (dtpcOrdercl.Rows[k]["N_GROUP"].ToString().Trim() == "")
                //            {
                //                //判断当前钢种和此钢种能否混浇分在同一连铸
                //                //注：可能5#连铸和7#连铸/3#连铸和4#连铸能直接替换***********
                //                if (mod.C_STL_GRD == dtpcOrdercl.Rows[k]["C_STL_GRD"].ToString() && mod.C_STD_CODE == dtpcOrdercl.Rows[k]["C_STD_CODE"].ToString() && bll_gw.Get_STA_DESC(mod.C_CCM_NO) == dtpcOrdercl.Rows[k]["C_CCM_NO"].ToString())
                //                {
                //                    dtpcOrdercl.Rows[k]["N_GROUP"] = a;
                //                    Mod_TMO_ORDER mod1 = bll_order.GetModel(dtpcOrdercl.Rows[k]["C_ID"].ToString());
                //                    mod1.N_GROUP = a;
                //                    bll_order.Update(mod1);
                //                }
                //                else if (bll_xlgz.NFHJ(mod.C_STL_GRD, mod.C_STD_CODE, dtpcOrdercl.Rows[k]["C_STL_GRD"].ToString(), dtpcOrdercl.Rows[k]["C_STD_CODE"].ToString()) && bll_gw.Get_STA_DESC(mod.C_CCM_NO) == dtpcOrdercl.Rows[k]["C_CCM_NO"].ToString())
                //                {

                //                    dtpcOrdercl.Rows[k]["N_GROUP"] = a;
                //                    Mod_TMO_ORDER mod1 = bll_order.GetModel(dtpcOrdercl.Rows[k]["C_ID"].ToString());
                //                    mod1.N_GROUP = a;
                //                    bll_order.Update(mod1);
                //                }
                //            }
                //        }

                //    }
                //}
                #endregion

                dtpcOrdercl.DefaultView.Sort = " N_GROUP ";
                DataTable dt3 = dtpcOrdercl.DefaultView.ToTable();//分组后待排产炼钢订单

                #region 分组完成后进行炼钢排产
                DataTable dtDP = bll_order.GetInfoByGroup("").Tables[0];
                if (dtDP.Rows.Count > 0)
                {
                    bll_lclsb.DeleteByCCM("");
                    bll_lsb.Delete();
                    int srot = 0;
                    for (int k = 0; k < dtDP.Rows.Count; k++)
                    {
                        #region 5#cc||7#cc
                        if (dtDP.Rows[k]["连铸代码"].ToString() == "5#CC" || dtDP.Rows[k]["连铸代码"].ToString() == "7#CC")
                        {
                            decimal mlzl = 75;
                            if (Convert.ToDecimal(dtDP.Rows[k]["整浇次炉数"].ToString()) == 0)//没维护整浇次炉数的数据
                            {
                                int n_zjcls = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(dtDP.Rows[k]["炉数"].ToString()) / 18));//整浇次炉数;最后一个浇次不足哦5炉按15炉排
                                for (int i = 0; i < n_zjcls; i++)
                                {
                                    srot = srot + 1;
                                    Mod_TPP_LGPC_LSB mod = new Mod_TPP_LGPC_LSB();
                                    mod.C_CCM_CODE = dtDP.Rows[k]["连铸代码"].ToString();
                                    mod.C_CCM_ID = dtDP.Rows[k]["连铸主键"].ToString();
                                    mod.N_GROUP = Convert.ToInt32(dtDP.Rows[k]["组号"].ToString());
                                    mod.N_MLZL = mlzl;
                                    mod.N_SORT = srot;
                                    mod.N_TOTAL_WGT = Convert.ToDecimal(dtDP.Rows[k]["待产总量"].ToString());
                                    mod.N_ORDER_LS = Convert.ToDecimal(dtDP.Rows[k]["炉数"].ToString());
                                    if (i == n_zjcls - 1)
                                    {
                                        if ((mod.N_ORDER_LS - 18 * i) <= 15)
                                        {
                                            mod.N_ZJCLS = 15;
                                            mod.N_ZJCLZL = 15 * mlzl;
                                        }
                                        else
                                        {
                                            mod.N_ZJCLS = mod.N_ORDER_LS - 18 * i;
                                            mod.N_ZJCLZL = (mod.N_ORDER_LS - 18 * i) * mlzl;
                                        }
                                    }
                                    else
                                    {
                                        mod.N_ZJCLS = 18;
                                        mod.N_ZJCLZL = 18 * mlzl;
                                    }
                                    mod.N_JSCN = Convert.ToDecimal(dtDP.Rows[k]["机时产能"].ToString());
                                    mod.C_STL_GRD = dtDP.Rows[k]["牌号"].ToString();
                                    bll_lsb.Add(mod);
                                }
                            }
                            else
                            {
                                int n_zjcls = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(dtDP.Rows[k]["炉数"].ToString()) / Convert.ToDecimal(dtDP.Rows[k]["整浇次炉数"].ToString())));//整浇次炉数
                                for (int i = 0; i < n_zjcls; i++)
                                {
                                    srot = srot + 1;
                                    Mod_TPP_LGPC_LSB mod = new Mod_TPP_LGPC_LSB();
                                    mod.C_CCM_CODE = dtDP.Rows[k]["连铸代码"].ToString();
                                    mod.C_CCM_ID = dtDP.Rows[k]["连铸主键"].ToString();
                                    mod.N_GROUP = Convert.ToInt32(dtDP.Rows[k]["组号"].ToString());
                                    mod.N_MLZL = mlzl;
                                    mod.N_SORT = srot;
                                    mod.N_TOTAL_WGT = Convert.ToDecimal(dtDP.Rows[k]["待产总量"].ToString());
                                    mod.N_ORDER_LS = Convert.ToDecimal(dtDP.Rows[k]["炉数"].ToString());
                                    mod.N_ZJCLS = Convert.ToDecimal(dtDP.Rows[k]["整浇次炉数"].ToString());
                                    mod.N_ZJCLZL = mod.N_ZJCLS * mlzl;
                                    mod.N_JSCN = Convert.ToDecimal(dtDP.Rows[k]["机时产能"].ToString());
                                    mod.C_STL_GRD = dtDP.Rows[k]["牌号"].ToString();
                                    bll_lsb.Add(mod);
                                }
                            }
                        }
                        #endregion
                        #region 其他
                        else
                        {
                            decimal mlzl = 46;
                            if (Convert.ToDecimal(dtDP.Rows[k]["整浇次炉数"].ToString()) == 0)//没维护整浇次炉数的数据
                            {
                                int n_zjcls = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(dtDP.Rows[k]["炉数"].ToString()) / 20));//整浇次炉数;最后一个浇次不足哦5炉按15炉排
                                for (int i = 0; i < n_zjcls; i++)
                                {
                                    srot = srot + 1;
                                    Mod_TPP_LGPC_LSB mod = new Mod_TPP_LGPC_LSB();
                                    mod.C_CCM_CODE = dtDP.Rows[k]["连铸代码"].ToString();
                                    mod.C_CCM_ID = dtDP.Rows[k]["连铸主键"].ToString();
                                    mod.N_GROUP = Convert.ToInt32(dtDP.Rows[k]["组号"].ToString());
                                    mod.N_MLZL = mlzl;
                                    mod.N_SORT = srot;
                                    mod.N_TOTAL_WGT = Convert.ToDecimal(dtDP.Rows[k]["待产总量"].ToString());
                                    mod.N_ORDER_LS = Convert.ToDecimal(dtDP.Rows[k]["炉数"].ToString());
                                    if (i == n_zjcls - 1)
                                    {
                                        if ((mod.N_ORDER_LS - 20 * i) <= 15)
                                        {
                                            mod.N_ZJCLS = 15;
                                            mod.N_ZJCLZL = 15 * mlzl;
                                        }
                                        else
                                        {
                                            mod.N_ZJCLS = mod.N_ORDER_LS - 20 * i;
                                            mod.N_ZJCLZL = (mod.N_ORDER_LS - 20 * i) * mlzl;
                                        }
                                    }
                                    else
                                    {
                                        mod.N_ZJCLS = 20;
                                        mod.N_ZJCLZL = 20 * mlzl;
                                    }
                                    mod.N_JSCN = Convert.ToDecimal(dtDP.Rows[k]["机时产能"].ToString());
                                    mod.C_STL_GRD = dtDP.Rows[k]["牌号"].ToString();
                                    bll_lsb.Add(mod);
                                }
                            }
                            else
                            {
                                int n_zjcls = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(dtDP.Rows[k]["炉数"].ToString()) / Convert.ToDecimal(dtDP.Rows[k]["整浇次炉数"].ToString())));//整浇次炉数
                                for (int i = 0; i < n_zjcls; i++)
                                {
                                    srot = srot + 1;
                                    Mod_TPP_LGPC_LSB mod = new Mod_TPP_LGPC_LSB();
                                    mod.C_CCM_CODE = dtDP.Rows[k]["连铸代码"].ToString();
                                    mod.C_CCM_ID = dtDP.Rows[k]["连铸主键"].ToString();
                                    mod.N_GROUP = Convert.ToInt32(dtDP.Rows[k]["组号"].ToString());
                                    mod.N_MLZL = mlzl;
                                    mod.N_SORT = srot;
                                    mod.N_TOTAL_WGT = Convert.ToDecimal(dtDP.Rows[k]["待产总量"].ToString());
                                    mod.N_ORDER_LS = Convert.ToDecimal(dtDP.Rows[k]["炉数"].ToString());
                                    mod.N_ZJCLS = Convert.ToDecimal(dtDP.Rows[k]["整浇次炉数"].ToString());
                                    mod.N_ZJCLZL = mod.N_ZJCLS * mlzl;
                                    mod.N_JSCN = Convert.ToDecimal(dtDP.Rows[k]["机时产能"].ToString());
                                    mod.C_STL_GRD = dtDP.Rows[k]["牌号"].ToString();
                                    bll_lsb.Add(mod);
                                }
                            }
                        }
                        #endregion
                        //for (int m = 0; m <Convert.ToInt32(dtDP.Rows[k]["浇次数"].ToString()); m++)
                        //{
                        //    srot = srot + 1;
                        //    Mod_TPP_LGPC_LSB mod = new Mod_TPP_LGPC_LSB();
                        //    mod.C_CCM_CODE = dtDP.Rows[k]["连铸代码"].ToString();
                        //    mod.C_CCM_ID = dtDP.Rows[k]["连铸主键"].ToString();
                        //    mod.N_GROUP = Convert.ToInt32(dtDP.Rows[k]["组号"].ToString());
                        //    decimal mlzl = 46;
                        //    if (dtDP.Rows[k]["连铸代码"].ToString()== "5#CC"|| dtDP.Rows[k]["连铸代码"].ToString() == "7#CC")
                        //    {
                        //        mlzl = 75;
                        //    }
                        //    mod.N_MLZL = mlzl;
                        //    mod.N_SORT = srot;
                        //    mod.N_TOTAL_WGT = Convert.ToDecimal(dtDP.Rows[k]["待产总量"].ToString());
                        //    mod.N_ZJCLS = Convert.ToDecimal(dtDP.Rows[k]["整浇次炉数"].ToString());
                        //    mod.N_ZJCLZL= Convert.ToDecimal(dtDP.Rows[k]["整浇次重量"].ToString());
                        //    mod.N_ORDER_LS= Convert.ToDecimal(dtDP.Rows[k]["炉数"].ToString());
                        //    mod.N_JSCN = Convert.ToDecimal(dtDP.Rows[k]["机时产能"].ToString());
                        //    mod.C_STL_GRD= dtDP.Rows[k]["牌号"].ToString();
                        //    bll_lsb.Add(mod);
                        //}
                    }
                    //DataTable lsb = bll_lsb.GetList("").Tables[0];
                    //FrmPO_SCDD_PC frm = new FrmPO_SCDD_PC(lsb);
                    //frm.ShowDialog();

                }
                #endregion

            }
            catch (Exception ex)
            {


            }

        }

        private void FrmPO_Order_Manage_Load(object sender, EventArgs e)
        {
            BindIcbo("", "ZX", icbo_zx2);
            BindIcbo("", "ZX", icbo_zx4);
            BindIcbo("", "CC", icbo_lz2);
        }


        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        public DataTable OrderPC(DataTable dt)
        {

            DataTable dtpcOrdercl = dt.Copy();
            dtpcOrdercl.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtpcOrdercl.Rows.Add(dt.Rows[i].ItemArray);
            }
            dtpcOrdercl.DefaultView.Sort = " 连铸,组号  ";//将选中的订单按照排产目标进行排序
            dtpcOrdercl = dtpcOrdercl.DefaultView.ToTable();//获取的需要初始化的表

            return dtpcOrdercl;
        }
        /// <summary>
        /// 轧钢计划排产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zgpc_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("钢坯计划未排产的订单将不参与系统自动排产！\r\n单击{Yes}系统将未下发的订单重新排产！\r\n单击{No}系统直接弹出轧钢计划下发界面！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {



            }
            else
            {

            }
        }
        DataTable dtzg = null;
        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            string strzx = "";//查询轧线
            if (this.icbo_zx4.SelectedIndex > 0)
            {
                strzx = this.icbo_zx4.Properties.Items[this.icbo_zx4.SelectedIndex].Value.ToString().Trim();
            }

            string isKP = "N";
            if (rbtn_zg.SelectedIndex == 1)
            {
                isKP = "Y";
            }
            else if (rbtn_zg.SelectedIndex == 2)
            {
                isKP = "YP";
            }
            else
            {
                isKP = "N";
            }

            dtzg = bll_order.GetZGPCOrder(this.txt_gz4.Text.Trim(), this.txt_bz4.Text.Trim(), strzx, isKP);

            this.gridControl1.DataSource = dtzg;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
        }
        /// <summary>
        /// 轧钢排产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zgpc_Click_1(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            ZGPC(dtzg);
            WaitingFrom.CloseWait();
            MessageBox.Show("轧钢计划已排！");
            //if (DialogResult.Yes == MessageBox.Show("系统已排轧钢计划，是否弹出轧钢计划管理页面？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            //{
            //    FrmPO_ZGJH frm = new FrmPO_ZGJH();
            //    frm.ShowDialog();
            //}
        }
        /// <summary>
        /// 轧钢自动排产
        /// </summary>
        /// <param name="dt"></param>
        public void ZGPC(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Mod_TMO_ORDER modorder = bll_order.GetModel(dt.Rows[i]["C_ID"].ToString());

                    decimal dpcwgt = Convert.ToDecimal(dt.Rows[i]["N_R_WGT"].ToString());//轧钢待排产的重量（N_WGT - N_ROLL_PROD_WGT - N_LINE_MATCH_WGT）
                    decimal kpcwgt = Convert.ToDecimal(dt.Rows[i]["N_R_KP_WGT"].ToString());//轧钢本次可排产的重量（N_SMS_PROD_WGT + N_SLAB_MATCH_WGT）

                    decimal kcgpl = Convert.ToDecimal(dt.Rows[i]["N_SLAB_MATCH_WGT"].ToString());//该计划试用库存钢坯重量

                    if (kpcwgt > 0 && dpcwgt > 0)//当前订单可以排产
                    {
                        decimal kcp = (kcgpl - bll_roll_plan.GetZYPWgt(dt.Rows[i]["C_ID"].ToString(), "1"));//使用库存坯下计划量
                        if (kcp > 0)//使用库存坯排产的计划
                        {
                            #region 添加轧钢计划
                            Mod_TRP_PLAN_ROLL modplan = new Mod_TRP_PLAN_ROLL();
                            modplan.C_INITIALIZE_ITEM_ID = dt.Rows[i]["C_ID"].ToString();//订单表主键
                            modplan.C_ORDER_NO = dt.Rows[i]["C_ORDER_NO"].ToString();//订单号
                            modplan.N_WGT = kcp;//订单排产量
                            modplan.N_STATUS = 0;
                            modplan.C_MAT_CODE = dt.Rows[i]["C_MAT_CODE"].ToString();//物料编码
                            modplan.C_MAT_NAME = dt.Rows[i]["C_MAT_NAME"].ToString();//物料名称
                            modplan.C_TECH_PROT = dt.Rows[i]["C_TECH_PROT"].ToString();//客户协议号
                            modplan.C_SPEC = dt.Rows[i]["C_SPEC"].ToString();//规格
                            modplan.C_STL_GRD = dt.Rows[i]["C_STL_GRD"].ToString();//钢种
                            modplan.C_STD_CODE = dt.Rows[i]["C_STD_CODE"].ToString();//执行标准
                            //modplan.N_USER_LEV=dt.Rows[i][" N_USER_LEV,"].ToString();//客户等级
                            //modplan.N_STL_GRD_LEV=dt.Rows[i][" C_LEV，"].ToString();//钢种等级
                            //modplan.N_ORDER_LEV=dt.Rows[i][" C_ORDER_LEV,"].ToString();//订单等级
                            modplan.D_NEED_DT = Convert.ToDateTime(dt.Rows[i]["D_NEED_DT"].ToString());//需求日期
                            modplan.D_DELIVERY_DT = Convert.ToDateTime(dt.Rows[i]["D_DELIVERY_DT"].ToString());//计划交货日期
                            modplan.D_DT = Convert.ToDateTime(dt.Rows[i]["D_DT"].ToString());//订单日期
                            modplan.N_PROD_TIME = Convert.ToDecimal(kcp / Convert.ToDecimal(dt.Rows[i]["N_MACH_WGT"].ToString()));//理论生产需时
                            modplan.N_SORT = 0;//生产排序
                            modplan.C_CUST_NO = dt.Rows[i]["C_CUST_NO"].ToString();//客户编码
                            modplan.C_CUST_NAME = dt.Rows[i]["C_CUST_NAME"].ToString();//客户名称
                            modplan.C_SALE_CHANNEL = dt.Rows[i]["C_SALE_CHANNEL"].ToString();//分销类别（直销/经销）
                            modplan.C_PACK = dt.Rows[i]["C_PACK"].ToString();//包装要求
                            modplan.C_DESIGN_NO = dt.Rows[i]["C_DESIGN_NO"].ToString();//质量设计号
                            modplan.N_GROUP_WGT = 0;//组批量
                            modplan.C_LINE_DESC = dt.Rows[i]["C_LINE_NO"].ToString();//工位
                            modplan.C_STA_ID = dt.Rows[i]["C_STA_ID"].ToString();//工位
                            modplan.C_LINE_CODE = bll_gw.Get_NC_ID(modplan.C_STA_ID);//nc工位主键

                            modplan.C_EMP_ID = RV.UI.UserInfo.userID;//操作人
                            modplan.D_MOD_DT = RV.UI.ServerTime.timeNow();//操作时间
                            modplan.N_MACH_WGT = Convert.ToDecimal(dt.Rows[i]["N_MACH_WGT"].ToString());//机时产量（轧钢）
                            modplan.C_INITIALIZE_ID = "1";//计划标识0连铸坯1自由坯
                            modplan.C_FREE_TERM = dt.Rows[i]["C_FREE1"].ToString();//自由项
                            modplan.C_FREE_TERM2 = dt.Rows[i]["C_FREE2"].ToString();//自由项2
                            modplan.C_AREA = dt.Rows[i]["C_AREA"].ToString();//区域
                            modplan.C_PCLX = modplan.C_AREA.Contains("出口") ? "1" : "0";//批次类型0普通材，1出口材
                            bll_roll_plan.Add(modplan);
                            modorder.N_ROLL_PROD_WGT = modorder.N_ROLL_PROD_WGT + kcp;
                            #endregion

                        }

                        decimal lzp = 0;
                        if (dpcwgt - kpcwgt > 0)
                        {
                            lzp = kpcwgt - kcp;//使用连铸坯排产量
                        }
                        else
                        {
                            lzp = dpcwgt - kcp;//使用连铸坯排产量
                        }
                        if (lzp > 0)//使用连铸坯排产的计划
                        {
                            #region 添加轧钢计划

                            Mod_TRP_PLAN_ROLL modplan = new Mod_TRP_PLAN_ROLL();
                            modplan.C_INITIALIZE_ITEM_ID = dt.Rows[i]["C_ID"].ToString();//订单表主键
                            modplan.C_ORDER_NO = dt.Rows[i]["C_ORDER_NO"].ToString();//订单号
                            modplan.N_WGT = lzp;//订单排产量
                            modplan.N_STATUS = 0;
                            modplan.C_MAT_CODE = dt.Rows[i]["C_MAT_CODE"].ToString();//物料编码
                            modplan.C_MAT_NAME = dt.Rows[i]["C_MAT_NAME"].ToString();//物料名称
                            modplan.C_TECH_PROT = dt.Rows[i]["C_TECH_PROT"].ToString();//客户协议号
                            modplan.C_SPEC = dt.Rows[i]["C_SPEC"].ToString();//规格
                            modplan.C_STL_GRD = dt.Rows[i]["C_STL_GRD"].ToString();//钢种
                            modplan.C_STD_CODE = dt.Rows[i]["C_STD_CODE"].ToString();//执行标准
                            //modplan.N_USER_LEV=dt.Rows[i][" N_USER_LEV,"].ToString();//客户等级
                            //modplan.N_STL_GRD_LEV=dt.Rows[i][" C_LEV，"].ToString();//钢种等级
                            //modplan.N_ORDER_LEV=dt.Rows[i][" C_ORDER_LEV,"].ToString();//订单等级
                            modplan.D_NEED_DT = Convert.ToDateTime(dt.Rows[i]["D_NEED_DT"].ToString());//需求日期
                            modplan.D_DELIVERY_DT = Convert.ToDateTime(dt.Rows[i]["D_DELIVERY_DT"].ToString());//计划交货日期
                            modplan.D_DT = Convert.ToDateTime(dt.Rows[i]["D_DT"].ToString());//订单日期
                            decimal kkk = Convert.ToDecimal(lzp / Convert.ToDecimal(dt.Rows[i]["N_MACH_WGT"].ToString()));
                            modplan.N_PROD_TIME = Convert.ToDecimal(lzp / Convert.ToDecimal(dt.Rows[i]["N_MACH_WGT"].ToString()));//理论生产需时
                            modplan.N_SORT = 0;//生产排序
                            modplan.C_CUST_NO = dt.Rows[i]["C_CUST_NO"].ToString();//客户编码
                            modplan.C_CUST_NAME = dt.Rows[i]["C_CUST_NAME"].ToString();//客户名称
                            modplan.C_SALE_CHANNEL = dt.Rows[i]["C_SALE_CHANNEL"].ToString();//分销类别（直销/经销）
                            modplan.C_PACK = dt.Rows[i]["C_PACK"].ToString();//包装要求
                            modplan.C_DESIGN_NO = dt.Rows[i]["C_DESIGN_NO"].ToString();//质量设计号
                            modplan.N_GROUP_WGT = 0;//组批量
                            modplan.C_LINE_DESC = dt.Rows[i]["C_LINE_NO"].ToString();//工位
                            modplan.C_STA_ID = dt.Rows[i]["C_STA_ID"].ToString();//工位
                            modplan.C_LINE_CODE = bll_gw.Get_NC_ID(modplan.C_STA_ID);//nc工位主键
                            modplan.C_EMP_ID = RV.UI.UserInfo.userID;//操作人
                            modplan.D_MOD_DT = RV.UI.ServerTime.timeNow();//操作时间
                            modplan.N_MACH_WGT = Convert.ToDecimal(dt.Rows[i]["N_MACH_WGT"].ToString());//机时产量（轧钢）
                            modplan.C_INITIALIZE_ID = "0";//计划标识0连铸坯1自由坯
                            modplan.C_FREE_TERM = dt.Rows[i]["C_FREE1"].ToString();//自由项
                            modplan.C_FREE_TERM2 = dt.Rows[i]["C_FREE2"].ToString();//自由项2
                            modplan.C_AREA = dt.Rows[i]["C_AREA"].ToString();//区域
                            modplan.C_PCLX = modplan.C_AREA.Contains("出口") ? "1" : "0";//批次类型0普通材，1出口材
                        
                            #endregion

                            //根据计划号得出该计划钢坯生产结束时间
                            DataTable dtscsj = bll_sms.GetOrderCCTime(modplan.C_INITIALIZE_ITEM_ID);
                            if (dtscsj.Rows.Count > 0)
                            {
                                DateTime? dtbegin = null;
                                try
                                {
                                    dtbegin = Convert.ToDateTime(dtscsj.Rows[0]["D_P_START_TIME"].ToString());//钢坯开始生产时间
                                }
                                catch (Exception)
                                {

                                    dtbegin = System.DateTime.Now;
                                }
                             
                                DateTime dtend = Convert.ToDateTime(dtscsj.Rows[0]["D_P_END_TIME"].ToString());//钢坯生产结束时间
                                DateTime lasttime = dtend;//工序最后时间
                                #region 判断是否开坯，是添加开坯计划
                                if (dt.Rows[i]["C_KP"].ToString() == "Y")
                                {

                                    #region 判断开坯前是否缓冷，缓冷时间，添加大方坯缓冷计划
                                    if (dt.Rows[i]["C_DFP_HL"].ToString().Trim() != "")
                                    {
                                        modplan.C_SFHL_D = dt.Rows[i]["C_DFP_HL"].ToString();//大方坯是否缓冷
                                        double hltime = Convert.ToDouble(dt.Rows[i]["N_DFP_HL_TIME"].ToString()) == 0 ? 48 : Convert.ToDouble(dt.Rows[i]["N_DFP_HL_TIME"].ToString());
                                        modplan.D_DHL_START_TIME = dtend;//缓冷计划开始时间
                                        modplan.D_DHL_END_TIME = Convert.ToDateTime(dtend.AddHours(hltime));//缓冷计划结束时间
                                        lasttime = Convert.ToDateTime(dtend.AddHours(hltime));
                                    }
                                    #endregion
                                    double hktokp = 3;//缓冷到开坯的运转时间
                                    modplan.C_SFKP = "Y";//大方坯是否开坯
                                    modplan.D_KP_START_TIME = lasttime.AddHours(hktokp);//开坯计划开始时间
                                    double kpjscl = 114;//开坯的机时产量
                                    modplan.D_KP_END_TIME = Convert.ToDateTime(modplan.D_KP_START_TIME).AddHours(Convert.ToDouble(modplan.N_WGT) / kpjscl);//开坯计划结束时间
                                    lasttime = Convert.ToDateTime(modplan.D_KP_START_TIME).AddHours(Convert.ToDouble(modplan.N_WGT) / kpjscl);
                                }
                                if (dt.Rows[i]["C_HL"].ToString().Trim() != "")//开坯后是否缓冷
                                {
                                    double kptohl = 3;//开坯到缓冷时间
                                    modplan.C_SFHL = "Y";//小方坯是否缓冷
                                    modplan.D_HL_START_TIME = lasttime.AddHours(kptohl);//缓冷计划开始时间
                                    double xhltime = Convert.ToDouble(dt.Rows[i]["N_HL_TIME"].ToString()) == 0 ? 48 : Convert.ToDouble(dt.Rows[i]["N_HL_TIME"].ToString());
                                    modplan.D_HL_END_TIME = lasttime.AddHours(kptohl).AddHours(xhltime);//缓冷计划结束时间
                                    lasttime = Convert.ToDateTime(modplan.D_HL_END_TIME);
                                }
                                if (dt.Rows[i]["C_HL"].ToString().Trim() != "")//需要修磨
                                {
                                    double toXM = 3;
                                    double xujscn = 80;//修磨的平均机时产能
                                    modplan.C_SFXM = "Y";//是否修磨
                                    modplan.D_XM_START_TIME = lasttime.AddHours(toXM);//修磨计划开始时间
                                    modplan.D_XM_END_TIME = lasttime.AddHours(toXM).AddHours(Convert.ToDouble(modplan.N_WGT) / xujscn); ;//修磨计划结束时间
                                    lasttime = Convert.ToDateTime(modplan.D_XM_END_TIME);
                                }

                                double tozg = 3;//到轧线的消耗时间
                                modplan.D_P_START_TIME = lasttime.AddHours(3);
                                modplan.D_P_END_TIME = lasttime.AddHours(3).AddHours(Convert.ToDouble( modplan.N_PROD_TIME));
                                #endregion
                                
                            }
                            bll_roll_plan.Add(modplan);
                            modorder.N_ROLL_PROD_WGT = modorder.N_ROLL_PROD_WGT + lzp;
                            bll_order.Update(modorder);
                        }


                    }
                }


            }


        }

        private void btn_fx_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            string strlz = "";//查询连铸
            if (this.icbo_lz2.SelectedIndex > 0)
            {
                strlz = this.icbo_lz2.Properties.Items[this.icbo_lz2.SelectedIndex].Value.ToString().Trim();
            }
            DataTable dt = bll_order.KPC_DD_FX(strlz);
            this.gc_tmo_order_pj.DataSource = dt;

            gc_tmo_order_pj.MainView = gridView2;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView2);
            this.gridView2.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        private void btn_out_pj_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_tmo_order_pj);
        }
    }
}
