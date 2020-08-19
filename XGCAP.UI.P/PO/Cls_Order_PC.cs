using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BLL;
using XGCAP.UI.P.PO.APS;

namespace XGCAP.UI.P.PO
{
    public class Cls_Order_PC
    {
        private static Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();//销售订单池
        private static Bll_TPP_INITIALIZE_STA bll_TPP_INITIALIZE_STA = new Bll_TPP_INITIALIZE_STA();//方案初始化工序工位
        private static Bll_TPB_LINE_SPEC bll_line_spec = new Bll_TPB_LINE_SPEC();//规格产线数据表
        private static Bll_TPB_SLAB_CAPACITY bll_slab_Cap = new Bll_TPB_SLAB_CAPACITY();//钢种连铸生产信息
        private static Bll_TQB_SLAB_LEN_MATCH bllslabmatch = new Bll_TQB_SLAB_LEN_MATCH();//订单钢坯规格匹配
        private static Bll_TPB_ENDTOEND_GRD bll_swlgz = new Bll_TPB_ENDTOEND_GRD();//首尾炉钢种
        private static Bll_TQB_RINSE_TANK_GRD bll_xcgz = new Bll_TQB_RINSE_TANK_GRD();//洗槽钢种
        private static Bll_TQB_COPING bll_xm = new Bll_TQB_COPING();//修磨要求
        private static Bll_TQB_ROUTE bll_gylx = new Bll_TQB_ROUTE();//工艺路线
        private static Bll_TMO_ORDER_PJ_LOG bll_ddpj = new Bll_TMO_ORDER_PJ_LOG();//订单评价日志
        private static Bll_TQB_COOL_BASIC bll_hlyq = new Bll_TQB_COOL_BASIC();//订单缓冷要求
        private static Bll_TPB_CAST_STOVE bll_zjcls = new Bll_TPB_CAST_STOVE();//整浇次炉数
        private static Bll_TB_STA bll_gw = new Bll_TB_STA();//工位
        private static Bll_TQB_TSBZ_CF bll_tscf = new Bll_TQB_TSBZ_CF();//铁水成分要求
        private static Bll_TPB_SLABWH bllTPB_SLABWH = new Bll_TPB_SLABWH();
        private static Bll_TPP_LGPC_LSB bll_lsb = new Bll_TPP_LGPC_LSB();
        private static Bll_TPP_LGPC_LCLSB bll_lclsb = new Bll_TPP_LGPC_LCLSB();
        private static Bll_TPP_INITIALIZE_LINE bll_line = new Bll_TPP_INITIALIZE_LINE();
        private static Bll_TB_MATRL_MAIN bll_wl = new Bll_TB_MATRL_MAIN();
        private static Bll_TPB_BORDER_GRD bll_xlgz = new Bll_TPB_BORDER_GRD();//相邻钢种
        private static Bll_TRP_PLAN_ROLL bll_trp_roll = new Bll_TRP_PLAN_ROLL();//已下发计划

        private static Bll_TB_SLAB_MATRAL bllSlabMatral = new Bll_TB_SLAB_MATRAL();
        /// <summary>
        /// 获取当前时间的当旬时间的第一天
        /// </summary>
        /// <returns></returns>
        public static string[] GetDXFristDay()
        {


            DateTime? dt11 = null;
            DateTime? dt12 = null;
            DateTime dt = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());

            DateTime dt1 = Convert.ToDateTime(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToShortDateString());
            DateTime dt2 = Convert.ToDateTime(dt1.AddMonths(1).AddDays(-1).ToShortDateString());
            double ts = (dt - dt1).TotalDays;   //相差天数
            if (ts < 10)
            {
                dt11 = dt1;
                dt12 = dt1.AddDays(9);
            }
            else if (ts > 10 && ts <= 20)
            {
                dt11 = dt1.AddDays(10);
                dt12 = dt1.AddDays(19);
            }
            else
            {
                dt11 = dt1.AddDays(20);
                dt12 = dt2;
            }

            return new string[] { Convert.ToDateTime(dt11).ToString("yyyy-MM-dd"), Convert.ToDateTime(dt12).ToString("yyyy-MM-dd") };

        }


        /// <summary>
        ///将订单按可混浇进行分组
        /// </summary>
        public static string Order_Grouping()
        {
            bool clear = bll_order.ClearGroupNo();
            DataTable dtpcOrdercl = bll_order.GetLGWPOrder();
            #region 按照可混浇规则进行钢种排产分组
            for (int j = 0; j < dtpcOrdercl.Rows.Count; j++)
            {
                Mod_TMO_ORDER mod = bll_order.GetModel(dtpcOrdercl.Rows[j]["C_ID"].ToString());
                if (mod.N_GROUP == null && dtpcOrdercl.Rows[j]["N_GROUP"].ToString().Trim() == "")
                {
                    string ss = dtpcOrdercl.Select("", "N_GROUP DESC")[0]["N_GROUP"].ToString().Trim() == "" ? "0" : dtpcOrdercl.Select("", "N_GROUP DESC")[0]["N_GROUP"].ToString().Trim();//获取未排产炼钢订单中最大分组序号
                    int a = Convert.ToInt32(ss) + 1;//新的分组序号
                    //按相邻钢种获取分组号
                    dtpcOrdercl.Rows[j]["N_GROUP"] = a;
                    mod.N_GROUP = a;
                    bll_order.Update(mod);
                    for (int k = 0; k < dtpcOrdercl.Rows.Count; k++)
                    {
                        if (dtpcOrdercl.Rows[k]["N_GROUP"].ToString().Trim() == "")
                        {
                            //判断当前钢种和此钢种能否混浇分在同一连铸
                            //注：可能5#连铸和7#连铸/3#连铸和4#连铸能直接替换*********** && bll_gw.Get_STA_DESC(mod.C_CCM_NO) == dtpcOrdercl.Rows[k]["C_CCM_NO"].ToString()//&& bll_gw.Get_STA_DESC(mod.C_CCM_NO) == dtpcOrdercl.Rows[k]["C_CCM_NO"].ToString()
                            if (mod.C_CCM_NO == dtpcOrdercl.Rows[k]["C_CCM_NO"].ToString() && ((mod.C_STL_GRD == dtpcOrdercl.Rows[k]["C_STL_GRD"].ToString() && mod.C_STD_CODE == dtpcOrdercl.Rows[k]["C_STD_CODE"].ToString()) || (bll_xlgz.NFHJ(mod.C_STL_GRD, mod.C_STD_CODE, dtpcOrdercl.Rows[k]["C_STL_GRD"].ToString(), dtpcOrdercl.Rows[k]["C_STD_CODE"].ToString()))))
                            {
                                dtpcOrdercl.Rows[k]["N_GROUP"] = a;
                                Mod_TMO_ORDER mod1 = bll_order.GetModel(dtpcOrdercl.Rows[k]["C_ID"].ToString());
                                mod1.N_GROUP = a;
                                bll_order.Update(mod1);
                            }
                            else
                            {
                                Mod_TMO_ORDER mod1 = bll_order.GetModel(dtpcOrdercl.Rows[k]["C_ID"].ToString());
                                mod1.N_GROUP = null;
                                bll_order.Update(mod1);
                            }

                        }
                    }

                }
            }
            #endregion
            return "分组成功！";
        }

        /// <summary>
        /// 返回整浇次炉数
        /// </summary>
        /// <param name="C_CCM_ID">连铸主键</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>整浇次炉数</returns>
        public static int GetZJCLS(string C_CCM_ID, string C_STL_GRD, string C_STD_CODE)
        {
            if (C_CCM_ID != "")
            {
                DataTable dtzjcls = bll_zjcls.GetList(C_CCM_ID, C_STL_GRD, C_STD_CODE).Tables[0];
                if (dtzjcls.Rows.Count > 0)
                {
                    if (dtzjcls.Rows[0]["N_STOVE_NUM"].ToString().Trim() != "")
                    {
                        return Convert.ToInt32(dtzjcls.Rows[0]["N_STOVE_NUM"].ToString());
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }

            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 判断钢种是否可以用于洗槽
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>Y/N</returns>
        public static string GetNFXC(string C_STL_GRD, string C_STD_CODE)
        {
            #region 可以洗槽的钢种
            DataTable dtxc = bll_xcgz.GetXCGZ(C_STL_GRD, C_STD_CODE).Tables[0];
            if (dtxc.Rows.Count > 0)
            {
                return "Y";
            }
            else
            {
                return "N";
            }
            #endregion
        }

        /// <summary>
        /// 获取钢种缓冷要求
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_TYPE">钢坯类型 大方坯连铸坯、热轧钢坯\小方坯连铸坯</param>
        /// <returns>缓冷要求</returns>
        public static DataTable GetHLCode(string C_STL_GRD, string C_STD_CODE, string C_TYPE)
        {

            #region 订单缓冷要求
            DataTable dthl = null;
            if (bll_hlyq.GetHLYQ(C_STL_GRD, C_STD_CODE, C_TYPE).Tables[0].Rows.Count > 0)
            {
                dthl = bll_hlyq.GetHLYQ(C_STL_GRD, C_STD_CODE, C_TYPE).Tables[0];
            }
            else
            {
                dthl = bll_hlyq.GetHLYQ(C_STL_GRD, "", C_TYPE).Tables[0];
            }
            return dthl;

            #endregion
        }

        /// <summary>
        /// 获得产品修磨工艺代码
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>修磨工艺代码</returns>
        public static string GetXMCode(string C_STL_GRD, string C_STD_CODE)
        {
            #region 订单钢坯修磨要求
            DataTable dtxm = bll_xm.GetXMYQ(C_STL_GRD, C_STD_CODE).Tables[0];
            if (dtxm.Rows.Count > 0)
            {
                return dtxm.Rows[0]["C_COPING_CRAFT"].ToString();
            }
            else
            {
                return "";
            }
            #endregion
        }

        /// <summary>
        ///获取产品的首尾炉过度产品
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_TYPE">首炉/尾炉</param>
        /// <returns>过度产品</returns>
        public static DataTable GetSWLGZ(string C_STL_GRD, string C_STD_CODE, string C_TYPE)
        {

            return bll_swlgz.GetSWLSteel(C_STL_GRD, C_STD_CODE, C_TYPE);
        }

        /// <summary>
        /// 返回产品的生产工艺路线
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <returns>工艺路线</returns>
        public static string GetGYLX(string C_STL_GRD, string C_STD_CODE, string C_ROUTE_TYPE)
        {
            #region 订单工艺路线信息
            DataTable dtgylx = bll_gylx.GetGYLX(C_STL_GRD, C_STD_CODE, C_ROUTE_TYPE);
            if (dtgylx.Rows.Count > 0)
            {
                return dtgylx.Rows[0]["C_ROUTE_DESC"].ToString();

            }
            else
            {
                return "";
            }
            #endregion
        }

        /// <summary>
        /// 获取产品可生产的产线和对应的机时产能
        /// 原则：产能优先，同规格在优先同一产线
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_SPEC">规格</param>
        /// <returns>产线和对应的机时产能</returns>
        public static DataTable GetZGInfo(string C_STL_GRD, string C_STD_CODE, string C_SPEC)
        {
            #region 轧线机时产能
            //1：自动分配订单轧线信息和对应轧线的机时产量
            DataTable dtzxcn = bll_line_spec.GetSteelLine(C_STL_GRD, C_STD_CODE, C_SPEC, "");
            if (dtzxcn.Rows.Count > 0)
            {
                dtzxcn.DefaultView.Sort = "N_CAPACITY DESC ";//按产能从高到低进行排序
                dtzxcn = dtzxcn.DefaultView.ToTable();
                //mod.C_LINE_NO = dtzxcn.Rows[0]["C_STA_ID"].ToString();
                //mod.N_MACH_WGT = Convert.ToDecimal(dtzxcn.Rows[0]["N_CAPACITY"].ToString());
                return dtzxcn;
            }

            else
            {
                return null;
            }
            #endregion
        }


        /// <summary>
        /// 获取产品的炼钢生产信息（连铸机/机时产能）
        /// </summary>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_KP">是否开坯Y/N</param>
        /// <returns>炼钢生产信息（连铸机/机时产能）</returns>
        public static DataTable GetLgInfo(string C_STL_GRD, string C_STD_CODE, string C_KP)
        {
            //2：自动分配订单连铸信息和对应的铸机机时产能
            //匹配订单连铸钢坯信息
            //连铸机时产量
            DataTable dtSteelCCM = bll_slab_Cap.GetSteelCCM(C_STL_GRD, C_STD_CODE, "", C_KP);
            if (dtSteelCCM.Rows.Count > 0)
            {
                dtSteelCCM.DefaultView.Sort = "N_CAPACITY DESC ";//按产能从高到低进行排序
                dtSteelCCM = dtSteelCCM.DefaultView.ToTable();
                return dtSteelCCM;
                //strCCM = dtSteelCCM.Rows[0]["C_STA_ID"].ToString();
                //mod.C_CCM_NO = dtSteelCCM.Rows[0]["C_STA_ID"].ToString();
                //if (dtSteelCCM.Rows[0]["N_CAPACITY"].ToString().Trim() == "")
                //{
                //    mod.N_MACH_WGT_CCM = 88;
                //}
                //else
                //{
                //    mod.N_MACH_WGT_CCM = Convert.ToDecimal(dtSteelCCM.Rows[0]["N_CAPACITY"].ToString());
                //}

                //mod.C_BY3 = dtSteelCCM.Rows[0]["C_TYPE"].ToString(); //排产颜色

            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 将选中的订单进行最后评价，并记录日志
        /// </summary>
        /// <param name="dtdchs">待评价订单</param>
        /// <param name="C_TYPE">工艺路线类型</param>
        public static void OrderPj(DataTable dtdchs)
        {
            int totalCount = dtdchs.Rows.Count;

            for (int j = 0; j < dtdchs.Rows.Count; j++)
            {

                Mod_TMO_ORDER mod = bll_order.GetModel(dtdchs.Rows[j]["C_ID"].ToString());
                string strOrderPJLog = "订单主键：" + mod.C_ID + "！订单信息： " + mod.C_STL_GRD + "|" + mod.C_STD_CODE + "|" + mod.C_SPEC + "；";
                bool sfpj = true;
                if (mod.C_LINE_NO.Trim() == "" || mod.N_MACH_WGT == null)
                {
                    strOrderPJLog = "\r\n没有维护轧钢机时产能！";

                    sfpj = false;
                }
                if (mod.C_CCM_NO.Trim() == "" || mod.N_MACH_WGT_CCM == null)
                {
                    strOrderPJLog = strOrderPJLog + "\r\n没有维护炼钢机时产能！";


                    sfpj = false;
                }
                if (mod.C_MATRL_CODE_SLAB.Trim() == "")
                {
                    strOrderPJLog = strOrderPJLog + "\r\n没有匹配到钢坯物料信息！";

                    sfpj = false;
                }
                if (mod.C_ROUTE.Trim() == "")
                {
                    strOrderPJLog = strOrderPJLog + "\r\n没有维护工艺路线！";

                    sfpj = false;
                }
                if (sfpj == true)//订单可以评价
                {
                    mod.C_SFPJ = "Y";
                    bll_order.Update(mod);

                }
            }
        }
        private static Bll_Common bll_com = new Bll_Common();//通用方法
        private static Bll_TQB_REPLACE_SLAB bll_Rpalce_Slab = new Bll_TQB_REPLACE_SLAB();//替代钢种

        private static Bll_TPB_STEEL_PRO_CONDITION bll_sctj = new Bll_TPB_STEEL_PRO_CONDITION();//钢种生产条件
        private static Bll_TQB_STD_MAIN bll_std_man = new Bll_TQB_STD_MAIN();//执行标准

        private static Bll_TQB_STD_SPEC bll_GZGG = new Bll_TQB_STD_SPEC();//钢种执行标准规格
        private static Bll_TB_STA bll_sta = new Bll_TB_STA();

        private static Bll_TPB_Y_GRD bll_Y_CCM = new Bll_TPB_Y_GRD();
        /// <summary>
        /// 对订单进行评价
        /// </summary>
        /// <param name="mod">订单实体</param>
        /// <param name="C_TYPE">实验/正常</param>
        public static void OrderPj(Mod_TMO_ORDER mod, string C_TYPE)
        {
            bool flag = true;
            string falsetype = "";//评价失败
            string strCCM = "";//当前订单匹配到的连铸主键

            mod.D_SC_MOD_DT = RV.UI.ServerTime.timeNow();
            #region 验证线材物料名称是否错误
            if (!mod.C_MAT_NAME.Contains("来料"))
            {
                if (mod.N_TYPE == 8)
                {
                    DataTable dtkind = bll_std_man.GetProdType(mod.C_STL_GRD, mod.C_STD_CODE);
                    if (dtkind.Rows.Count > 0)
                    {
                        string type = dtkind.Rows[0]["C_PROD_KIND"].ToString();
                        if (type.Contains("精品") && !mod.C_MAT_CODE.Contains("802"))
                        {
                            flag = false;
                            falsetype = "该订单物料编码不对！";
                        }
                    }
                    //直径
                    Mod_TB_MATRL_MAIN modwl = bll_wl.GetModel(mod.C_MAT_CODE);
                    mod.N_DIAMETER = modwl.N_THK;
                }
                //验证订单物料编码是否错误或NC没有维护BOM

                if (flag)
                {
                    if (!bll_wl.IsCanUse(mod.C_MAT_CODE))
                    {
                        flag = false;
                        falsetype = "订单物料编码是否错误或NC没有维护BOM！";
                    }
                }
            }


            #endregion

            #region 计划钢种代生产钢坯
            DataTable dtreplacegz = bll_Rpalce_Slab.GetReplaceSlab(mod.C_STL_GRD, mod.C_STD_CODE);
            if (dtreplacegz.Rows.Count > 0)
            {
                mod.C_STL_GRD_SLAB = dtreplacegz.Rows[0]["C_STL_GRD_SLAB"].ToString();
                mod.C_STD_CODE_SLAB = dtreplacegz.Rows[0]["C_STD_CODE_SLAB"].ToString();

                DataTable dtzyx = bll_com.GetZYX(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB);
                if (dtzyx.Rows.Count > 0)
                {
                    mod.C_BY1 = dtzyx.Rows[0]["ZYX1"].ToString();//自由项1
                    mod.C_BY2 = dtzyx.Rows[0]["ZYX2"].ToString();//自由项2
                }

            }
            else
            {
                mod.C_STL_GRD_SLAB = mod.C_STL_GRD;
                mod.C_STD_CODE_SLAB = mod.C_STD_CODE;

                if (mod.C_STL_GRD_SLAB == "GCr15")
                {
                    DataTable dtzyx = bll_com.GetZYX(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB);
                    if (dtzyx.Rows.Count > 0)
                    {
                        mod.C_BY1 = dtzyx.Rows[0]["ZYX1"].ToString();//自由项1
                        mod.C_BY2 = dtzyx.Rows[0]["ZYX2"].ToString();//自由项2
                    }
                }
                else
                {
                    mod.C_BY1 = mod.C_FREE1;
                    mod.C_BY2 = mod.C_FREE2;
                }

            }

            #region 钢种生产条件

            if (!mod.C_MAT_NAME.Contains("来料"))
            {
                if (flag)
                {
                    DataTable dtsctj = bll_sctj.GetSCTJ(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB);
                    if (dtsctj.Rows.Count > 0)
                    {
                        mod.C_STL_GRD_TYPE = dtsctj.Rows[0]["C_STL_GRD_TYPE"].ToString();//钢种类别
                        if (!mod.C_ORDER_NO.Contains("TW"))
                        {
                            try
                            {
                                mod.N_GROUP = Convert.ToDecimal(dtsctj.Rows[0]["N_GROUP"].ToString());//自由项2
                            }
                            catch (Exception)
                            {

                                flag = false;
                                falsetype = "【可混浇维护】组号没有维护！";
                            }
                        }


                    }
                    else
                    {
                        flag = false;
                        falsetype = "钢种生产条件没有维护！";
                    }
                }
            }
            else
            {
                mod.N_GROUP = 0;
            }
            if (flag)
            {
                DataTable dtzxbz = bll_std_man.GetProdType(mod.C_STL_GRD, mod.C_STD_CODE);
                if (dtzxbz.Rows.Count > 0)
                {
                    mod.C_PROD_KIND = dtzxbz.Rows[0]["C_PROD_KIND"].ToString();
                    mod.C_PROD_NAME = dtzxbz.Rows[0]["C_PROD_NAME"].ToString();
                    mod.C_BY4 = dtzxbz.Rows[0]["C_IS_BXG"].ToString();//是否是不锈钢
                }
                else
                {
                    flag = false;
                    falsetype = "钢种执行标准没有维护！";
                }
            }
            #endregion


            #endregion
            if (C_TYPE == "试验")
            {
                if (flag)
                {
                    DataTable dtlxtype = bll_gylx.GetGYLX(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, "试验");
                    if (dtlxtype.Rows.Count == 0)
                    {
                        flag = false;
                        falsetype = "改产品没有维护试验工艺路线！";
                    }
                }
            }


            if (flag)
            {
                #region 是否需要生产首尾炉钢种产品

                DataTable dtsl = GetSWLGZ(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, "首炉");
                if (dtsl != null && dtsl.Rows.Count > 0)
                {

                    string slorder = "";//首炉生产钢种的订单
                    for (int m = 0; m < dtsl.Rows.Count; m++)
                    {
                        if (slorder.Trim().Length > 0)
                        {
                            slorder = slorder + "|" + dtsl.Rows[m]["C_B_E_STOVE_STEEL"].ToString() + "~" + dtsl.Rows[m]["C_BORDER_STD_CODE"].ToString();
                        }
                        else
                        {
                            slorder = dtsl.Rows[m]["C_B_E_STOVE_STEEL"].ToString() + "~" + dtsl.Rows[m]["C_BORDER_STD_CODE"].ToString();
                        }
                    }

                    mod.C_SL = slorder;//需要生产首炉产品 = 
                }
                else
                {
                    mod.C_SL = "";

                }
                DataTable dtwl = GetSWLGZ(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, "尾炉");
                string wlorder = "";//尾炉生产钢种的订单
                if (dtwl != null && dtwl.Rows.Count > 0)
                {

                    for (int m = 0; m < dtwl.Rows.Count; m++)
                    {
                        if (wlorder.Trim().Length > 0)
                        {
                            wlorder = wlorder + "|" + dtwl.Rows[m]["C_B_E_STOVE_STEEL"].ToString() + "~" + dtwl.Rows[m]["C_BORDER_STD_CODE"].ToString();
                        }
                        else
                        {
                            wlorder = dtwl.Rows[m]["C_B_E_STOVE_STEEL"].ToString() + "~" + dtwl.Rows[m]["C_BORDER_STD_CODE"].ToString();
                        }

                    }
                    mod.C_WL = wlorder; ;//需要生产尾炉产品
                }
                else
                {
                    mod.C_WL = "";

                }
                #endregion
            }
            if (flag)
            {
                #region 订单工艺路线信息
                mod.C_ROUTE = GetGYLX(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, C_TYPE);
                if (mod.C_ROUTE.Trim().Length > 0)
                {
                    if (mod.C_ROUTE.Contains("RH"))
                    {
                        mod.C_RH = "Y";
                    }
                    else
                    {
                        mod.C_RH = "N";
                    }

                    if (mod.C_ROUTE.Contains("LF"))
                    {
                        mod.C_LF = "Y";
                    }
                    else
                    {
                        mod.C_LF = "N";
                    }

                    if (mod.C_ROUTE.Contains("TL>HTL"))
                    {
                        mod.C_TL = "Y";
                    }
                    else
                    {
                        mod.C_TL = "N";
                    }

                    if (mod.C_ROUTE.Contains("KP"))
                    {
                        mod.C_KP = "Y";
                    }
                    else
                    {
                        mod.C_KP = "N";
                    }

                    if (mod.C_ROUTE.Contains(">DHL"))//大方坯缓冷
                    {
                        mod.C_DFP_HL = "Y";
                    }
                    else
                    {
                        mod.C_DFP_HL = "N";
                    }
                    if (mod.C_ROUTE.Contains(">HL"))//小方坯缓冷
                    {
                        mod.C_HL = "Y";
                    }
                    else
                    {
                        mod.C_HL = "N";
                    }


                    if (mod.C_ROUTE.Contains(">XM"))//小方坯缓冷
                    {
                        mod.C_XM = "Y";
                    }
                    else
                    {
                        mod.C_XM = "N";
                    }
                }
                else
                {
                    mod.C_ROUTE = "";
                    mod.C_RH = "";
                    mod.C_KP = "";
                    mod.C_DFP_HL = "";
                    mod.C_HL = "";
                    mod.C_XM = "";
                    flag = false;
                    falsetype = "工艺路线没有维护！";
                }
                #endregion
            }
            if (flag)
            {
                #region 轧线机时产能(没有找到产线的自动分配到默认产线)
                //1：自动分配订单轧线信息和对应轧线的机时产量
                DataTable dtzxcn = GetZGInfo(mod.C_STL_GRD, mod.C_STD_CODE, mod.C_SPEC);
                if (dtzxcn != null && dtzxcn.Rows.Count > 0)
                {
                    if (dtzxcn.Rows.Count == 1)
                    {
                        mod.C_LINE_NO = dtzxcn.Rows[0]["C_STA_ID"].ToString();
                        mod.N_MACH_WGT = Convert.ToDecimal(dtzxcn.Rows[0]["N_CAPACITY"].ToString());
                    }

                    else
                    {
                        mod.C_LINE_NO = dtzxcn.Rows[0]["C_STA_ID"].ToString();
                        mod.N_MACH_WGT = Convert.ToDecimal(dtzxcn.Rows[0]["N_CAPACITY"].ToString());
                        for (int i = 0; i < dtzxcn.Rows.Count; i++)
                        {
                            if (dtzxcn.Rows[i]["C_STA_ID"].ToString() == bll_order.GetLine(mod.C_SPEC))//匹配多条记录时将同规格的分配到同一产线
                            {
                                mod.C_LINE_NO = dtzxcn.Rows[i]["C_STA_ID"].ToString();
                                mod.N_MACH_WGT = Convert.ToDecimal(dtzxcn.Rows[i]["N_CAPACITY"].ToString());
                            }
                        }

                    }
                    Mod_TB_STA modsta = bll_sta.GetModel(mod.C_LINE_NO);

                    mod.C_ROLL_CODE = modsta.C_STA_CODE;
                    mod.C_ROLL_DESC = modsta.C_STA_DESC;

                }
                else
                {
                    mod.C_LINE_NO = null;
                    mod.N_MACH_WGT = 50;

                }
                #endregion
            }
            if (flag)
            {
                #region 订单钢坯连铸信息
                //2：自动分配订单连铸信息和对应的铸机机时产能
                //匹配订单连铸钢坯信息
                //连铸机时产量

                DataTable DTCCM = bll_Y_CCM.GetCCM(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB);
                if (DTCCM.Rows.Count > 0)
                {
                    mod.C_CCM_NO = DTCCM.Rows[0]["C_ID"].ToString();
                    mod.C_CCM_CODE = DTCCM.Rows[0]["C_STA_CODE"].ToString();
                    mod.C_CCM_DESC = DTCCM.Rows[0]["C_STA_DESC"].ToString();
                    // mod.N_MACH_WGT_CCM = 114;
                    DataTable dtjscn = bll_slab_Cap.GetSteelCCM(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, "", "");
                    if (dtjscn.Rows.Count > 0)
                    {
                        mod.N_MACH_WGT_CCM = Convert.ToDecimal(dtjscn.Rows[0]["N_CAPACITY"].ToString());
                    }
                    else
                    {
                        mod.N_MACH_WGT_CCM = 114;
                    }

                }
                else
                {

                    if (mod.C_ROUTE.Contains("KP") || mod.C_SPEC.Contains("280*325"))
                    {
                        //5#连铸机
                        mod.C_CCM_NO = "77B9FDA79B884D07AA2B3601D1DA11A2";
                        mod.C_CCM_CODE = "5#CC";
                        mod.C_CCM_DESC = "5#铸机";
                        mod.N_MACH_WGT_CCM = 114;

                    }
                    else
                    {


                        if (mod.C_BY4 == "1")//不锈钢--6#CC
                        {
                            mod.C_CCM_NO = "01C145B259E740F6A258AF313DD9268C";
                            mod.C_CCM_CODE = "6#CC";
                            mod.C_CCM_DESC = "6#铸机";
                            mod.N_MACH_WGT_CCM = 45;
                        }
                        else
                        {
                            if (mod.C_PROD_NAME.Contains("普碳钢"))//3#CCM
                            {
                                mod.C_CCM_NO = "890EAA2949E743AFB26C06B8D4209B17";
                                mod.C_CCM_CODE = "3#CC";
                                mod.C_CCM_DESC = "3#铸机";
                                mod.N_MACH_WGT_CCM = 88;
                            }
                            else//4#CCM
                            {
                                mod.C_CCM_NO = "5263048C90B44B4D9934C513CE028250";
                                mod.C_CCM_CODE = "4#CC";
                                mod.C_CCM_DESC = "4#铸机";
                                mod.N_MACH_WGT_CCM = 88;
                            }
                        }
                    }


                }
                #endregion
            }
            if (flag)
            {
                #region 钢种整浇次炉数
                mod.N_ZJCLS = GetZJCLS(mod.C_CCM_NO, mod.C_STL_GRD, mod.C_STD_CODE);
                if (mod.N_ZJCLS == null || mod.N_ZJCLS == 0)
                {
                    mod.N_ZJCLS = 20;
                }
                #endregion
            }
            if (flag)
            {
                #region 可以洗槽的钢种
                mod.C_XC = GetNFXC(mod.C_STL_GRD, mod.C_STD_CODE);
                #endregion
            }
            if (flag)
            {
                #region 获取可代轧钢坯
                mod.C_REMARK5 = GetReplaceSlab(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB);
                #endregion
            }
            if (flag)
            {
                #region 订单钢坯修磨要求
                mod.C_XM_YQ = GetXMCode(mod.C_STL_GRD, mod.C_STD_CODE);
                #endregion
            }
            if (flag)
            {
                #region 订单缓冷要求

                mod.N_DFP_HL_TIME = 0;
                mod.N_HL_TIME = 0;
                if (mod.C_KP == "Y")
                {
                    if (mod.C_DFP_HL == "Y")
                    {
                        DataTable dthl = GetHLCode(mod.C_STL_GRD, mod.C_STD_CODE, "大方坯连铸坯");
                        if (dthl != null && dthl.Rows.Count > 0)
                        {
                            mod.N_DFP_HL_TIME = Convert.ToInt32(dthl.Rows[0]["N_COOL_DT"].ToString());
                        }
                    }
                    if (mod.C_HL == "Y")
                    {
                        DataTable dthl2 = GetHLCode(mod.C_STL_GRD, mod.C_STD_CODE, "热轧钢坯");
                        if (dthl2 != null && dthl2.Rows.Count > 0)
                        {
                            mod.N_HL_TIME = Convert.ToInt32(dthl2.Rows[0]["N_COOL_DT"].ToString());
                        }
                    }


                }
                else
                {
                    if (mod.C_HL == "Y")
                    {
                        DataTable dthl2 = GetHLCode(mod.C_STL_GRD, mod.C_STD_CODE, "小方坯连铸坯");
                        if (dthl2 != null && dthl2.Rows.Count > 0)
                        {
                            mod.N_HL_TIME = Convert.ToInt32(dthl2.Rows[0]["N_COOL_DT"].ToString());
                        }
                    }
                }
                #endregion
            }
            if (flag)
            {
                #region 连铸坯信息，钢坯定尺信息
                //连铸坯信息，开坯信息
                string strType = "";
                if (mod.N_TYPE == 6)
                {
                    strType = "钢坯";
                }
                string wllj = "";
                if (mod.C_MAT_NAME.Contains("来料"))
                {
                    if (mod.N_TYPE == 8)//线材计划
                    {
                        #region 根据物料表查找钢坯物料信息
                        if (mod.C_ROUTE.Contains("KP"))
                        {
                            //先获取连铸坯物料信息
                            DataTable dtCcmSlab = bll_wl.GetSlabLL(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, mod.C_ROUTE, "280*325");
                            if (dtCcmSlab.Rows.Count > 0)
                            {
                                mod.C_MATRL_CODE_SLAB = dtCcmSlab.Rows[0]["C_MAT_CODE"].ToString();
                                mod.C_MATRL_NAME_SLAB = dtCcmSlab.Rows[0]["C_MAT_NAME"].ToString();
                                mod.C_SLAB_SIZE = dtCcmSlab.Rows[0]["C_SLAB_SIZE"].ToString();
                                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_LTH"].ToString());
                                mod.N_SLAB_PW = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_HSL"].ToString());
                                //根据连铸坯物料找热轧坯物料信息（来料加工）
                                DataTable dtKPSlab = bll_wl.GetRZSlabLL(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, mod.C_SLAB_SIZE, mod.N_SLAB_LENGTH.ToString());
                                if (dtKPSlab.Rows.Count > 0)
                                {
                                    mod.C_MATRL_CODE_KP = dtKPSlab.Rows[0]["C_MAT_CODE"].ToString();
                                    mod.C_MATRL_NAME_KP = dtKPSlab.Rows[0]["C_MAT_NAME"].ToString();
                                    mod.C_KP_SIZE = dtKPSlab.Rows[0]["C_SLAB_SIZE"].ToString();
                                    mod.N_KP_LENGTH = Convert.ToDecimal(dtKPSlab.Rows[0]["N_LTH"].ToString());
                                    mod.N_KP_PW = Convert.ToDecimal(dtKPSlab.Rows[0]["N_HSL"].ToString());
                                }
                            }
                            else
                            {
                                mod.C_MATRL_CODE_SLAB = "";
                                mod.C_MATRL_NAME_SLAB = "";
                                mod.C_SLAB_SIZE = "";
                                mod.N_SLAB_LENGTH = null;
                                mod.N_SLAB_PW = null;
                                mod.C_MATRL_CODE_KP = "";
                                mod.C_MATRL_NAME_KP = "";
                                mod.C_KP_SIZE = "";
                                mod.N_KP_LENGTH = null;
                                mod.N_KP_PW = null;
                                flag = false;
                                falsetype = "钢坯定尺匹配数据没有维护！";
                            }
                        }
                        else
                        {
                            //查询连铸坯物料信息
                            DataTable dt = bllSlabMatral.GetList(mod.C_STL_GRD, mod.C_STD_CODE, mod.C_ROUTE).Tables[0];
                            string c_slab_size = "160*160";
                            if (mod.C_CCM_NO == "01C145B259E740F6A258AF313DD9268C")//6#连铸机
                            {
                                c_slab_size = "150*150";
                            }
                            DataTable dtCcmSlab = new DataTable();
                            if (mod.C_MAT_NAME.Contains("来料"))
                            {
                                dtCcmSlab = bll_wl.GetSlabLL(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, mod.C_ROUTE, dt.Rows[0]["C_SLAB_SIZE"].ToString());
                            }
                            else
                            {
                                dtCcmSlab = bll_wl.GetSlabLL(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, mod.C_ROUTE, c_slab_size);
                            }
                            
                            if (dtCcmSlab.Rows.Count > 0)
                            {
                                mod.C_MATRL_CODE_SLAB = dtCcmSlab.Rows[0]["C_MAT_CODE"].ToString();
                                mod.C_MATRL_NAME_SLAB = dtCcmSlab.Rows[0]["C_MAT_NAME"].ToString();
                                mod.C_SLAB_SIZE = dtCcmSlab.Rows[0]["C_SLAB_SIZE"].ToString();
                                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_LTH"].ToString());
                                mod.N_SLAB_PW = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_HSL"].ToString());
                                mod.C_MATRL_CODE_KP = "";
                                mod.C_MATRL_NAME_KP = "";
                                mod.C_KP_SIZE = "";
                                mod.N_KP_LENGTH = null;
                                mod.N_KP_PW = null;
                            }
                            else
                            {
                                mod.C_MATRL_CODE_SLAB = "";
                                mod.C_MATRL_NAME_SLAB = "";
                                mod.C_SLAB_SIZE = "";
                                mod.N_SLAB_LENGTH = null;
                                mod.N_SLAB_PW = null;
                                mod.C_MATRL_CODE_KP = "";
                                mod.C_MATRL_NAME_KP = "";
                                mod.C_KP_SIZE = "";
                                mod.N_KP_LENGTH = null;
                                mod.N_KP_PW = null;
                                flag = false;
                                falsetype = "钢坯定尺信息没有维护！";
                            }


                        }
                        #endregion
                    }
                }
                else
                {
                    if (mod.N_TYPE == 8)//线材计划
                    {
                        #region 根据物料表查找钢坯物料信息
                        if (mod.C_ROUTE.Contains("KP"))
                        {
                            //先获取连铸坯物料信息
                            DataTable dtCcmSlab = bll_wl.GetCCMSlab(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, mod.C_ROUTE, "280*325");
                            if (dtCcmSlab.Rows.Count > 0)
                            {
                                mod.C_MATRL_CODE_SLAB = dtCcmSlab.Rows[0]["C_MAT_CODE"].ToString();
                                mod.C_MATRL_NAME_SLAB = dtCcmSlab.Rows[0]["C_MAT_NAME"].ToString();
                                mod.C_SLAB_SIZE = dtCcmSlab.Rows[0]["C_SLAB_SIZE"].ToString();
                                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_LTH"].ToString());
                                mod.N_SLAB_PW = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_HSL"].ToString());
                                //根据连铸坯物料找热轧坯物料信息
                                DataTable dtKPSlab = bll_wl.GetRZSlab(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, mod.C_SLAB_SIZE, mod.N_SLAB_LENGTH.ToString());
                                if (dtKPSlab.Rows.Count > 0)
                                {
                                    mod.C_MATRL_CODE_KP = dtKPSlab.Rows[0]["C_MAT_CODE"].ToString();
                                    mod.C_MATRL_NAME_KP = dtKPSlab.Rows[0]["C_MAT_NAME"].ToString();
                                    mod.C_KP_SIZE = dtKPSlab.Rows[0]["C_SLAB_SIZE"].ToString();
                                    mod.N_KP_LENGTH = Convert.ToDecimal(dtKPSlab.Rows[0]["N_LTH"].ToString());
                                    mod.N_KP_PW = Convert.ToDecimal(dtKPSlab.Rows[0]["N_HSL"].ToString());
                                }
                            }
                            else
                            {
                                mod.C_MATRL_CODE_SLAB = "";
                                mod.C_MATRL_NAME_SLAB = "";
                                mod.C_SLAB_SIZE = "";
                                mod.N_SLAB_LENGTH = null;
                                mod.N_SLAB_PW = null;
                                mod.C_MATRL_CODE_KP = "";
                                mod.C_MATRL_NAME_KP = "";
                                mod.C_KP_SIZE = "";
                                mod.N_KP_LENGTH = null;
                                mod.N_KP_PW = null;
                                flag = false;
                                falsetype = "钢坯定尺匹配数据没有维护！";
                            }
                        }
                        else
                        {
                            //查询连铸坯物料信息
                            string c_slab_size = "160*160";
                            if (mod.C_CCM_NO == "01C145B259E740F6A258AF313DD9268C")//6#连铸机
                            {
                                c_slab_size = "150*150";
                            }
                            DataTable dtCcmSlab = bll_wl.GetCCMSlab(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, mod.C_ROUTE, c_slab_size);
                            if (dtCcmSlab.Rows.Count > 0)
                            {
                                mod.C_MATRL_CODE_SLAB = dtCcmSlab.Rows[0]["C_MAT_CODE"].ToString();
                                mod.C_MATRL_NAME_SLAB = dtCcmSlab.Rows[0]["C_MAT_NAME"].ToString();
                                mod.C_SLAB_SIZE = dtCcmSlab.Rows[0]["C_SLAB_SIZE"].ToString();
                                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_LTH"].ToString());
                                mod.N_SLAB_PW = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_HSL"].ToString());
                                mod.C_MATRL_CODE_KP = "";
                                mod.C_MATRL_NAME_KP = "";
                                mod.C_KP_SIZE = "";
                                mod.N_KP_LENGTH = null;
                                mod.N_KP_PW = null;
                            }
                            else
                            {
                                mod.C_MATRL_CODE_SLAB = "";
                                mod.C_MATRL_NAME_SLAB = "";
                                mod.C_SLAB_SIZE = "";
                                mod.N_SLAB_LENGTH = null;
                                mod.N_SLAB_PW = null;
                                mod.C_MATRL_CODE_KP = "";
                                mod.C_MATRL_NAME_KP = "";
                                mod.C_KP_SIZE = "";
                                mod.N_KP_LENGTH = null;
                                mod.N_KP_PW = null;
                                flag = false;
                                falsetype = "钢坯定尺信息没有维护！";
                            }


                        }
                        #endregion
                    }
                    else//钢坯计划
                    {
                        //销售钢坯的物料编码
                        if (mod.C_MAT_CODE.Substring(0, 3) == "614")//热轧钢坯
                        {

                            Mod_TB_MATRL_MAIN modmatralkp = bll_wl.GetModel(mod.C_MAT_CODE);
                            mod.C_MATRL_CODE_KP = modmatralkp.C_ID;
                            mod.C_MATRL_NAME_KP = modmatralkp.C_MAT_NAME;
                            mod.C_KP_SIZE = modmatralkp.C_SLAB_SIZE;
                            mod.N_KP_LENGTH = modmatralkp.N_LTH;
                            mod.N_KP_PW = modmatralkp.N_HSL;

                            //连铸坯物料

                            DataTable dtCcmSlab = bll_wl.GetCCMSlabByRZsLAB(mod.C_STL_GRD_SLAB, mod.C_STD_CODE_SLAB, mod.C_KP_SIZE, mod.N_KP_LENGTH.ToString());
                            if (dtCcmSlab.Rows.Count > 0)
                            {
                                mod.C_MATRL_CODE_SLAB = dtCcmSlab.Rows[0]["C_MAT_CODE"].ToString();
                                mod.C_MATRL_NAME_SLAB = dtCcmSlab.Rows[0]["C_MAT_NAME"].ToString();
                                mod.C_SLAB_SIZE = dtCcmSlab.Rows[0]["C_SLAB_SIZE"].ToString();
                                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_LTH"].ToString());
                                mod.N_SLAB_PW = Convert.ToDecimal(dtCcmSlab.Rows[0]["N_HSL"].ToString());
                            }
                            else
                            {
                                mod.C_MATRL_CODE_SLAB = "";
                                mod.C_MATRL_NAME_SLAB = "";
                                mod.C_SLAB_SIZE = "";
                                mod.N_SLAB_LENGTH = null;
                                mod.N_SLAB_PW = null;
                                mod.C_MATRL_CODE_KP = "";
                                mod.C_MATRL_NAME_KP = "";
                                mod.C_KP_SIZE = "";
                                mod.N_KP_LENGTH = null;
                                mod.N_KP_PW = null;
                                flag = false;
                                falsetype = "钢坯定尺信息没有维护！";
                            }
                        }
                        else//连铸坯
                        {
                            Mod_TB_MATRL_MAIN modmatral = bll_wl.GetModel(mod.C_MAT_CODE);
                            mod.C_MATRL_CODE_SLAB = modmatral.C_ID;
                            mod.C_MATRL_NAME_SLAB = modmatral.C_MAT_NAME;
                            mod.C_SLAB_SIZE = modmatral.C_SLAB_SIZE;
                            mod.N_SLAB_LENGTH = modmatral.N_LTH;
                            mod.N_SLAB_PW = modmatral.N_HSL;

                            mod.C_MATRL_CODE_KP = "";
                            mod.C_MATRL_NAME_KP = "";
                            mod.C_KP_SIZE = "";
                            mod.N_KP_LENGTH = null;
                            mod.N_KP_PW = 0;
                        }

                    }
                }

                #endregion
            }

            if (flag)
            {
                //质量设计号
                mod.C_DESIGN_NO = bll_std_man.GetDESIGN_NO(mod.C_STL_GRD, mod.C_STD_CODE);
            }
            if (flag)
            {
                if (!mod.C_MAT_NAME.Contains("来料"))
                {
                    //炼钢记号
                    DataTable dtlgjh = Cls_APS_PC.GetLGJH(mod.C_STD_CODE_SLAB, mod.C_STL_GRD_SLAB, mod.C_CCM_DESC);
                    if (dtlgjh.Rows.Count == 0)
                    {
                        flag = false;
                        falsetype = "炼钢记号没有维护！";
                    }
                }
            }
            if (flag)
            {
                #region 验证订单钢种执行标准规格是否正确
                if (mod.N_TYPE == 8)
                {
                    DataTable dtgzgg = bll_GZGG.GetGZGG(mod.C_STL_GRD, mod.C_STD_CODE, mod.C_SPEC);
                    if (dtgzgg.Rows.Count <= 0)
                    {
                        flag = false;
                        falsetype = "该订单生产规格标准没有维护！";
                    }

                    if (mod.C_PACK.Trim() == "A1" && mod.N_DIAMETER >= 16)
                    {
                        flag = false;
                        falsetype = "包装要求规格φ16以上不能为A1！";
                    }
                    if (mod.C_PACK.Trim() == "")
                    {
                        flag = false;
                        falsetype = "包装要求没有维护！";
                    }
                }
                if (mod.N_TYPE != 10)
                {
                    if (!bll_order.IsCanUpdate(mod.C_ID))//验证订单能否更改
                    {
                        flag = false;
                        falsetype = "订单状态已过期！";
                    }
                }


                #endregion
            }
            if (flag)
            {
                mod.D_PJ_DATE = RV.UI.ServerTime.timeNow();
                mod.C_SFPJ = "Y";
            }
            else
            {
                mod.C_SFPJ = "N";
            }
            mod.C_REMARK = falsetype;



            Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
            modlog.C_EMP_ID = RV.UI.UserInfo.userID;
            modlog.C_ORDER_NO = mod.C_ORDER_NO;
            modlog.C_TYPE = "订单评价";
            modlog.C_RESULT = flag ? "评价成功" : "评价失败";
            modlog.C_MSG = falsetype;
            bll_ddpj.Add(modlog);

            bll_order.Update(mod);


        }

        private static Bll_TPB_REPLACE_GRD bll_dz = new Bll_TPB_REPLACE_GRD();

        /// <summary>
        /// 获取线材可代轧钢坯
        /// </summary>
        /// <param name="C_STL_GRD"></param>
        /// <param name="C_STD_CODE"></param>
        /// <returns></returns>
        public static string GetReplaceSlab(string C_STL_GRD, string C_STD_CODE)
        {
            string str_dz = C_STL_GRD + "|" + C_STD_CODE;
            DataTable dtdz = bll_dz.BindDZSlab(C_STL_GRD, C_STD_CODE);
            if (dtdz.Rows.Count > 0)
            {
                for (int i = 0; i < dtdz.Rows.Count; i++)
                {
                    str_dz = str_dz + ";" + dtdz.Rows[i]["C_REPLACE_GRD"].ToString() + "|" + dtdz.Rows[i]["C_REPLACE_STD_CODE"].ToString();
                }
            }
            return str_dz;

        }


        /// <summary>
        /// 根据大方坯连铸物料编码获取开坯物料编码
        /// </summary>
        /// <param name="C_MATRAL_NO">大方坯连铸物料编码</param>
        /// <param name="LX">工艺路线</param>
        /// <returns></returns>
        public static DataTable GetKPMatral(string C_MATRAL_NO, string LX)
        {
            Mod_TB_MATRL_MAIN mod_lz = bll_wl.GetModel(C_MATRAL_NO);
            DataTable dt = null;
            if (mod_lz.N_LTH == 6000)//150*150*11500
            {
                dt = bll_wl.GetKPMatral(mod_lz.C_STL_GRD, "150*150*11.5", LX);
            }

            if (mod_lz.N_LTH == 6120)//外销坯150*150*12000//自备坯160*160*10500
            {
                dt = bll_wl.GetKPMatral(mod_lz.C_STL_GRD, "160*160*10.5", LX);
            }
            if (mod_lz.N_LTH == 5850)//150*150*11080/160*160*10300
            {
                dt = bll_wl.GetKPMatral(mod_lz.C_STL_GRD, "150*150*11.08", LX);
                if (dt.Rows.Count == 0)
                {
                    dt = bll_wl.GetKPMatral(mod_lz.C_STL_GRD, "160*160*10.3", LX);
                }

            }
            return dt;
        }


        /// <summary>
        /// 更新订单的物料信息
        /// </summary>
        /// <param name="mod">订单对象</param>
        //public static bool UpdateOrderMatral(Mod_TMO_ORDER mod)
        //{

        //    string strType = "";
        //    if (mod.N_TYPE == 6)
        //    {
        //        strType = "钢坯";
        //    }
        //    string wllj = "";
        //    if (mod.C_ROUTE.Contains("LF") && mod.C_ROUTE.Contains("RH"))
        //    {
        //        wllj = "(BLR)";
        //    }
        //    if (mod.C_ROUTE.Contains("LF") && !mod.C_ROUTE.Contains("RH"))
        //    {
        //        wllj = "(BL)";
        //    }
        //    if (!mod.C_ROUTE.Contains("LF") && mod.C_ROUTE.Contains("RH"))
        //    {
        //        wllj = "(BR)";
        //    }
        //    if (mod.N_TYPE == 8)
        //    {
        //        #region 根据物料表查找钢坯物料信息
        //        if (mod.C_ROUTE.Contains("KP"))
        //        {
        //            //开坯物料
        //            DataTable dtgpwl = GetCCMMatral(mod.C_STL_GRD_SLAB, wllj, "大方坯连铸坯");
        //            if (dtgpwl != null && dtgpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_SLAB_WIDTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_WTH"].ToString());
        //                mod.N_SLAB_THICK = Convert.ToDecimal(dtgpwl.Rows[0]["N_THK"].ToString());
        //                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_SLAB_SIZE = dtgpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_SLAB_PW = Convert.ToDecimal(dtgpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //            #region 获取热轧钢坯物料信息
        //            DataTable dtkpwl = GetKPMatral(mod.C_MATRL_CODE_SLAB, wllj);
        //            if (dtkpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_KP = dtkpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_KP = dtkpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_KP_LENGTH = Convert.ToDecimal(dtkpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_KP_SIZE = dtkpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_KP_PW = Convert.ToDecimal(dtkpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //            #endregion
        //        }
        //        else
        //        {
        //            DataTable dtgpwl = GetCCMMatral(mod.C_STL_GRD_SLAB, wllj, "小方坯连铸坯");
        //            if (dtgpwl != null && dtgpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_SLAB_WIDTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_WTH"].ToString());
        //                mod.N_SLAB_THICK = Convert.ToDecimal(dtgpwl.Rows[0]["N_THK"].ToString());
        //                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_SLAB_SIZE = dtgpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_SLAB_PW = Convert.ToDecimal(dtgpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //        }
        //        #endregion
        //    }
        //    else
        //    {
        //        //销售钢坯的物料编码
        //        if (mod.C_MAT_CODE.Substring(0, 3) == "614")//热轧钢坯
        //        {

        //            Mod_TB_MATRL_MAIN modmatralkp = bll_wl.GetModel(mod.C_MAT_CODE);
        //            mod.C_MATRL_CODE_KP = modmatralkp.C_ID;
        //            mod.C_MATRL_NAME_KP = modmatralkp.C_MAT_NAME;
        //            mod.C_KP_SIZE = modmatralkp.C_SLAB_SIZE;
        //            mod.N_KP_LENGTH = modmatralkp.N_LTH;
        //            mod.N_KP_PW = modmatralkp.N_HSL;

        //            //连铸坯物料

        //            DataTable dtgpwl = GetCCMMatral(mod.C_STL_GRD, wllj, "大方坯连铸坯");
        //            if (dtgpwl != null && dtgpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_SLAB_WIDTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_WTH"].ToString());
        //                mod.N_SLAB_THICK = Convert.ToDecimal(dtgpwl.Rows[0]["N_THK"].ToString());
        //                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_SLAB_SIZE = dtgpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_SLAB_PW = Convert.ToDecimal(dtgpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //        }
        //        else//连铸坯
        //        {
        //            Mod_TB_MATRL_MAIN modmatral = bll_wl.GetModel(mod.C_MAT_CODE);
        //            mod.C_MATRL_CODE_SLAB = modmatral.C_ID;
        //            mod.C_MATRL_NAME_SLAB = modmatral.C_MAT_NAME;
        //            mod.C_SLAB_SIZE = modmatral.C_SLAB_SIZE;
        //            mod.N_SLAB_LENGTH = modmatral.N_LTH;
        //            mod.N_SLAB_PW = modmatral.N_HSL;

        //            mod.C_MATRL_CODE_KP = "";
        //            mod.C_MATRL_NAME_KP = "";
        //            mod.C_KP_SIZE = "";
        //            mod.N_KP_LENGTH = null;
        //            mod.N_KP_PW = 0;
        //        }

        //    }

        //    return bll_order.Update(mod);

        //}


        /// <summary>
        /// 更新订单的物料信息
        /// </summary>
        /// <param name="mod">订单对象</param>
        //public static bool UpdateRollPlanMatral(Mod_TRP_PLAN_ROLL mod)
        //{

        //    string strType = "";
        //    if (mod.N_TYPE == 6)
        //    {
        //        strType = "钢坯";
        //    }
        //    string wllj = "";
        //    if (mod.C_ROUTE.Contains("LF") && mod.C_ROUTE.Contains("RH"))
        //    {
        //        wllj = "(BLR)";
        //    }
        //    if (mod.C_ROUTE.Contains("LF") && !mod.C_ROUTE.Contains("RH"))
        //    {
        //        wllj = "(BL)";
        //    }
        //    if (!mod.C_ROUTE.Contains("LF") && mod.C_ROUTE.Contains("RH"))
        //    {
        //        wllj = "(BR)";
        //    }
        //    if (mod.N_TYPE == 8)
        //    {
        //        #region 根据物料表查找钢坯物料信息
        //        if (mod.C_ROUTE.Contains("KP"))
        //        {
        //            //开坯物料
        //            DataTable dtgpwl = GetCCMMatral(mod.C_STL_GRD_SLAB, wllj, "大方坯连铸坯");
        //            if (dtgpwl != null && dtgpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_SLAB_WIDTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_WTH"].ToString());
        //                mod.N_SLAB_THICK = Convert.ToDecimal(dtgpwl.Rows[0]["N_THK"].ToString());
        //                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_SLAB_SIZE = dtgpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_SLAB_PW = Convert.ToDecimal(dtgpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //            #region 获取热轧钢坯物料信息
        //            DataTable dtkpwl = GetKPMatral(mod.C_MATRL_CODE_SLAB, wllj);
        //            if (dtkpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_KP = dtkpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_KP = dtkpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_KP_LENGTH = Convert.ToDecimal(dtkpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_KP_SIZE = dtkpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_KP_PW = Convert.ToDecimal(dtkpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //            #endregion
        //        }
        //        else
        //        {
        //            DataTable dtgpwl = GetCCMMatral(mod.C_STL_GRD_SLAB, wllj, "小方坯连铸坯");
        //            if (dtgpwl != null && dtgpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_SLAB_WIDTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_WTH"].ToString());
        //                mod.N_SLAB_THICK = Convert.ToDecimal(dtgpwl.Rows[0]["N_THK"].ToString());
        //                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_SLAB_SIZE = dtgpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_SLAB_PW = Convert.ToDecimal(dtgpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //        }
        //        #endregion
        //    }
        //    else
        //    {
        //        //销售钢坯的物料编码
        //        if (mod.C_MAT_CODE.Substring(0, 3) == "614")//热轧钢坯
        //        {

        //            Mod_TB_MATRL_MAIN modmatralkp = bll_wl.GetModel(mod.C_MAT_CODE);
        //            mod.C_MATRL_CODE_KP = modmatralkp.C_ID;
        //            mod.C_MATRL_NAME_KP = modmatralkp.C_MAT_NAME;
        //            mod.C_KP_SIZE = modmatralkp.C_SLAB_SIZE;
        //            mod.N_KP_LENGTH = modmatralkp.N_LTH;
        //            mod.N_KP_PW = modmatralkp.N_HSL;

        //            //连铸坯物料

        //            DataTable dtgpwl = GetCCMMatral(mod.C_STL_GRD_SLAB, wllj, "大方坯连铸坯");
        //            if (dtgpwl != null && dtgpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_SLAB_WIDTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_WTH"].ToString());
        //                mod.N_SLAB_THICK = Convert.ToDecimal(dtgpwl.Rows[0]["N_THK"].ToString());
        //                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_SLAB_SIZE = dtgpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_SLAB_PW = Convert.ToDecimal(dtgpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //        }
        //        else//连铸坯
        //        {
        //            Mod_TB_MATRL_MAIN modmatral = bll_wl.GetModel(mod.C_MAT_CODE);
        //            mod.C_MATRL_CODE_SLAB = modmatral.C_ID;
        //            mod.C_MATRL_NAME_SLAB = modmatral.C_MAT_NAME;
        //            mod.C_SLAB_SIZE = modmatral.C_SLAB_SIZE;
        //            mod.N_SLAB_LENGTH = modmatral.N_LTH;
        //            mod.N_SLAB_PW = modmatral.N_HSL;

        //            mod.C_MATRL_CODE_KP = "";
        //            mod.C_MATRL_NAME_KP = "";
        //            mod.C_KP_SIZE = "";
        //            mod.N_KP_LENGTH = null;
        //            mod.N_KP_PW = 0;
        //        }

        //    }

        //    return bll_trp_roll.Update(mod);

        //}

        /// <summary>
        /// 根据钢种、执行标准、连铸机获取钢坯物料编码
        /// </summary>
        /// <param name="C_MAT_CODE">计划物料编码</param>
        /// <param name="C_STL_GRD">钢种</param>
        /// <param name="C_STD_CODE">执行标准</param>
        /// <param name="C_CCM">连铸机</param>
        /// <param name="C_ROUTE">工艺路线</param>
        /// <returns></returns>
        //public Mod_Order_Matral GetSlabInfoByCCM(string C_MAT_CODE, string C_STL_GRD, string C_STD_CODE, int N_TYPE, string C_CCM, string C_ROUTE)
        //{
        //    string strType = "";
        //    if (N_TYPE == 6)
        //    {
        //        strType = "钢坯";
        //    }
        //    string wllj = "";
        //    #region 钢坯工艺路线
        //    if (C_ROUTE.Contains("KP"))
        //    {
        //        if (C_ROUTE.Contains("LF") && C_ROUTE.Contains("RH"))
        //        {
        //            wllj = "(BLR)";
        //        }
        //        if (C_ROUTE.Contains("LF") && !C_ROUTE.Contains("RH"))
        //        {
        //            wllj = "(BL)";
        //        }
        //        if (!C_ROUTE.Contains("LF") && C_ROUTE.Contains("RH"))
        //        {
        //            wllj = "(BR)";
        //        }
        //    }
        //    #endregion

        //    Mod_Order_Matral mod = new Mod_Order_Matral();

        //    if (N_TYPE == 8)//线材计划
        //    {
        //        #region 根据物料表查找钢坯物料信息
        //        if (C_ROUTE.Contains("KP"))
        //        {
        //            //开坯物料
        //            DataTable dtgpwl = GetCCMMatral(C_STL_GRD, wllj, "大方坯连铸坯");
        //            if (dtgpwl != null && dtgpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_SLAB_SIZE = dtgpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_SLAB_PW = Convert.ToDecimal(dtgpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //            #region 获取热轧钢坯物料信息
        //            DataTable dtkpwl = GetKPMatral(mod.C_MATRL_CODE_SLAB, wllj);
        //            if (dtkpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_KP = dtkpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_KP = dtkpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_KP_LENGTH = Convert.ToDecimal(dtkpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_KP_SIZE = dtkpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_KP_PW = Convert.ToDecimal(dtkpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //            #endregion
        //        }
        //        else
        //        {
        //            DataTable dtgpwl = GetCCMMatral(C_STL_GRD, wllj, "小方坯连铸坯");
        //            if (dtgpwl != null && dtgpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_SLAB_SIZE = dtgpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_SLAB_PW = Convert.ToDecimal(dtgpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //        }
        //        #endregion
        //    }
        //    else
        //    {
        //        //销售钢坯的物料编码
        //        if (C_MAT_CODE.Substring(0, 3) == "614")//热轧钢坯
        //        {

        //            Mod_TB_MATRL_MAIN modmatralkp = bll_wl.GetModel(C_MAT_CODE);
        //            mod.C_MATRL_CODE_KP = modmatralkp.C_ID;
        //            mod.C_MATRL_NAME_KP = modmatralkp.C_MAT_NAME;
        //            mod.C_KP_SIZE = modmatralkp.C_SLAB_SIZE;
        //            mod.N_KP_LENGTH = modmatralkp.N_LTH;
        //            mod.N_KP_PW = modmatralkp.N_HSL;

        //            //连铸坯物料

        //            DataTable dtgpwl = GetCCMMatral(C_STL_GRD, wllj, "大方坯连铸坯");
        //            if (dtgpwl != null && dtgpwl.Rows.Count > 0)
        //            {
        //                mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
        //                mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
        //                mod.N_SLAB_LENGTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_LTH"].ToString());
        //                mod.C_SLAB_SIZE = dtgpwl.Rows[0]["C_SLAB_SIZE"].ToString();
        //                mod.N_SLAB_PW = Convert.ToDecimal(dtgpwl.Rows[0]["N_HSL"].ToString());
        //            }
        //        }
        //        else//连铸坯
        //        {
        //            Mod_TB_MATRL_MAIN modmatral = bll_wl.GetModel(C_MAT_CODE);
        //            mod.C_MATRL_CODE_SLAB = modmatral.C_ID;
        //            mod.C_MATRL_NAME_SLAB = modmatral.C_MAT_NAME;
        //            mod.C_SLAB_SIZE = modmatral.C_SLAB_SIZE;
        //            mod.N_SLAB_LENGTH = modmatral.N_LTH;
        //            mod.N_SLAB_PW = modmatral.N_HSL;

        //            mod.C_MATRL_CODE_KP = "";
        //            mod.C_MATRL_NAME_KP = "";
        //            mod.C_KP_SIZE = "";
        //            mod.N_KP_LENGTH = null;
        //            mod.N_KP_PW = 0;
        //        }

        //    }


        //    return mod;


        //}


    }
}
