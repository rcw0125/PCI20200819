using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_Order_Initialize : Form
    {
        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();//销售订单池
        private Bll_TPP_INITIALIZE_STA bll_TPP_INITIALIZE_STA = new Bll_TPP_INITIALIZE_STA();//方案初始化工序工位
        private Bll_TPB_LINE_SPEC bll_line_spec = new Bll_TPB_LINE_SPEC();//规格产线数据表
        private Bll_TPB_SLAB_CAPACITY bll_slab_Cap = new Bll_TPB_SLAB_CAPACITY();//钢种连铸生产信息
        private Bll_TQB_SLAB_LEN_MATCH bllslabmatch = new Bll_TQB_SLAB_LEN_MATCH();//订单钢坯规格匹配
        private Bll_TPB_ENDTOEND_GRD bll_swlgz = new Bll_TPB_ENDTOEND_GRD();//首尾炉钢种
        private Bll_TQB_RINSE_TANK_GRD bll_xcgz = new Bll_TQB_RINSE_TANK_GRD();//洗槽钢种
        private Bll_TQB_COPING bll_xm = new Bll_TQB_COPING();//修磨要求
        private Bll_TQB_ROUTE bll_gylx = new Bll_TQB_ROUTE();//工艺路线
        private Bll_TMO_ORDER_PJ_LOG bll_ddpj = new Bll_TMO_ORDER_PJ_LOG();//订单评价日志
        private Bll_TQB_COOL_BASIC bll_hlyq = new Bll_TQB_COOL_BASIC();//订单缓冷要求
        private Bll_TPB_CAST_STOVE bll_zjcls = new Bll_TPB_CAST_STOVE();//整浇次炉数
        private Bll_TB_STA bll_gw = new Bll_TB_STA();//工位
        private Bll_TQB_TSBZ_CF bll_tscf = new Bll_TQB_TSBZ_CF();//铁水成分要求
        private Bll_TPB_SLABWH bllTPB_SLABWH = new Bll_TPB_SLABWH();
        private Bll_TPP_LGPC_LSB bll_lsb = new Bll_TPP_LGPC_LSB();
        private Bll_TPP_LGPC_LCLSB bll_lclsb = new Bll_TPP_LGPC_LCLSB();
        private Bll_TPP_INITIALIZE_LINE bll_line = new Bll_TPP_INITIALIZE_LINE();
        private Bll_TB_MATRL_MAIN bll_wl = new Bll_TB_MATRL_MAIN();
        private Bll_TPB_BORDER_GRD bll_xlgz = new Bll_TPB_BORDER_GRD();//相邻钢种

        public FrmPO_Order_Initialize()
        {
            InitializeComponent();
        }

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

        DataTable dtOrder = null;

        private void btn_query_order_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            double? gg_min = null;//规格最小值
            if (this.txt_gg_min.Text.Trim() != "")
            {
                gg_min = Convert.ToDouble(this.txt_gg_min.Text.Trim());
            }
            double? gg_max = null;//规格最大值
            if (this.txt_gg_max.Text.Trim() != "" && Convert.ToDouble(this.txt_gg_max.Text.Trim()) > 0)
            {
                gg_max = Convert.ToDouble(this.txt_gg_max.Text.Trim());
            }
            string strJQMin = this.dtp_form1.EditValue == null ? "" : this.dtp_form1.EditValue.ToString();
            string strJQMax = this.dtp_end1.EditValue == null ? "" : this.dtp_end1.EditValue.ToString();
            dtOrder = bll_order.GetListByWhere("N", 2, null, null, "", this.txt_hth.Text.Trim(), "", this.txt_gz1.Text.Trim(), this.txt_zxbz1.Text.Trim(), "", gg_min, gg_max, "", "", this.txt_customer.Text.Trim(), "", "", "", "", strJQMin, strJQMax).Tables[0];

            this.gc_tmo_order.DataSource = dtOrder;
            this.gv_tmo_order.OptionsView.ColumnAutoWidth = false;
            this.gv_tmo_order.OptionsSelection.MultiSelect = true;
            gv_tmo_order.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gv_tmo_order);
            this.gv_tmo_order.BestFitColumns();
            WaitingFrom.CloseWait();
        }

        DataTable DTypj = null;
        private void btn_query2_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
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
            DTypj = bll_order.GetListByWhere("Y", 2, null, null, "", this.txt_hth1.Text.Trim(), "", this.txt_gz2.Text.Trim(), this.txt_zxbz2.Text.Trim(), "", null, null, "", "", this.txt_customer1.Text.Trim(), "", "", "", "", "", "").Tables[0];

            this.gc_tmo_order_pj.DataSource = DTypj;
            this.gv_tmo_order_pj.OptionsView.ColumnAutoWidth = false;
            this.gv_tmo_order_pj.OptionsSelection.MultiSelect = true;
            gv_tmo_order_pj.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gv_tmo_order_pj);
            this.gv_tmo_order_pj.BestFitColumns();
            WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 订单系统自动评价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_auto_pj_Click(object sender, EventArgs e)
        {
            //对未排产订单进行处理（订单排产剩余重量>0）N_WGT-N_ISSUE_WGT-N_LINE_MATCH_WGT
            WaitingFrom.ShowWait("");

            // string group= bll_order.GroupingOrder();//订单重新分组

            DataTable dtdchs = dtOrder.Clone();//选中的需要评价的订单
            int[] rownumber = this.gv_tmo_order.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    DataRow dr = dtdchs.NewRow();
                    dr.ItemArray = this.gv_tmo_order.GetDataRow(i).ItemArray;
                    dtdchs.Rows.Add(dr);
                }
                dtdchs.DefaultView.Sort = " D_DELIVERY_DT, C_LEV ";//将选中的订单按照排产目标进行排序
                dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表
                #region 订单自动处理
                for (int j = 0; j < dtdchs.Rows.Count; j++)
                {
                    Mod_TMO_ORDER mod = bll_order.GetModel(dtdchs.Rows[j]["C_ID"].ToString());
                    string strCCM = "";//当前订单匹配到的连铸主键

                    #region 是否需要生产首尾炉钢种产品

                    DataTable dtsl = bll_swlgz.GetSWLSteel(mod.C_STL_GRD, mod.C_STD_CODE, "首炉");
                    if (dtsl.Rows.Count > 0)
                    {
                        mod.C_SL = "Y";//需要生产首炉产品
                        string slorder = "";//首炉生产钢种的订单
                        for (int m = 0; m < dtsl.Rows.Count; m++)
                        {
                            DataRow[] dr = dtdchs.Select(" C_STL_GRD='" + dtsl.Rows[m]["C_STL_GRD"] + "' AND C_STD_CODE='" + dtsl.Rows[m]["C_STD_CODE"] + "' ");
                            if (dr.Length > 0)
                            {
                                if (slorder.Trim().Length > 0)
                                {
                                    slorder = slorder + "|" + dr[0]["C_STL_GRD"].ToString() + "~" + slorder + dr[0]["C_STD_CODE"].ToString();
                                }
                                else
                                {
                                    slorder = dr[0]["C_STL_GRD"].ToString() + "~" + slorder + dr[0]["C_STD_CODE"].ToString();
                                }
                            }


                        }
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
                        for (int m = 0; m < dtwl.Rows.Count; m++)
                        {
                            DataRow[] dr = dtdchs.Select(" C_STL_GRD='" + dtwl.Rows[m]["C_STL_GRD"] + "' AND C_STD_CODE='" + dtwl.Rows[m]["C_STD_CODE"] + "' ");
                            if (dr.Length > 0)
                            {
                                if (wlorder.Trim().Length > 0)
                                {
                                    wlorder = wlorder + "|" + dr[0]["C_STL_GRD"].ToString() + "~" + wlorder + dr[0]["C_STD_CODE"].ToString();
                                }
                                else
                                {
                                    wlorder = dr[0]["C_STL_GRD"].ToString() + "~" + wlorder + dr[0]["C_STD_CODE"].ToString();
                                }
                            }
                        }
                        mod.C_BY2 = wlorder;
                    }
                    else
                    {
                        mod.C_WL = "N";
                        mod.C_BY2 = "";
                    }

                    #endregion

                    #region 钢种整浇次炉数

                    if (strCCM != "")
                    {
                        DataTable dtzjcls = bll_zjcls.GetList(strCCM, mod.C_STL_GRD, mod.C_STD_CODE).Tables[0];
                        if (dtzjcls.Rows.Count > 0)
                        {
                            if (dtzjcls.Rows[0]["N_STOVE_NUM"].ToString().Trim() != "")
                            {
                                mod.N_ZJCLS = Convert.ToInt32(dtzjcls.Rows[0]["N_STOVE_NUM"].ToString());
                            }
                            else
                            {
                                mod.N_ZJCLS = 0;
                            }
                        }
                        else
                        {
                            mod.N_ZJCLS = 0;
                        }

                    }
                    else
                    {
                        mod.N_ZJCLS = 0;
                    }


                    #endregion

                    #region 可以洗槽的钢种
                    DataTable dtxc = bll_xcgz.GetXCGZ(mod.C_STL_GRD, mod.C_STD_CODE).Tables[0];
                    if (dtxc.Rows.Count > 0)
                    {
                        mod.C_XC = "Y";
                    }
                    else
                    {
                        mod.C_XC = "N";
                    }
                    #endregion

                    #region 订单钢坯修磨要求
                    DataTable dtxm = bll_xm.GetXMYQ(mod.C_STL_GRD, mod.C_STD_CODE).Tables[0];
                    if (dtxm.Rows.Count > 0)
                    {
                        mod.C_XM = dtxm.Rows[0]["C_COPING_CRAFT"].ToString();
                    }
                    else
                    {
                        mod.C_XM = "";
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
                    mod.C_DFP_HL = "";
                    mod.N_HL_TIME = 0;
                    mod.C_HL = "";
                    if (dthl.Rows.Count > 0)
                    {
                        for (int i = 0; i < dthl.Rows.Count; i++)
                        {
                            if (dthl.Rows[i]["C_TYPE"].ToString().Contains("大方坯"))
                            {
                                mod.N_DFP_HL_TIME = Convert.ToInt32(dthl.Rows[i]["N_COOL_DT"].ToString());
                                mod.C_DFP_HL = dthl.Rows[i]["C_COOL_CRAFT_CODE"].ToString();
                            }
                            else
                            {
                                mod.N_HL_TIME = Convert.ToInt32(dthl.Rows[i]["N_COOL_DT"].ToString());
                                mod.C_HL = dthl.Rows[i]["C_COOL_CRAFT_CODE"].ToString();
                            }
                        }
                    }

                    #endregion

                    #region 订单铁水条件

                    #endregion

                    #region 订单工艺路线信息
                    DataTable dtgylx = bll_gylx.GetGYLX(mod.C_STL_GRD, mod.C_STD_CODE,"");
                    if (dtgylx.Rows.Count > 0)
                    {
                        mod.C_ROUTE = dtgylx.Rows[0]["C_ROUTE_DESC"].ToString();
                        if (dtgylx.Rows[0]["C_ROUTE_DESC"].ToString().Contains("RH"))
                        {
                            mod.C_RH = "Y";
                        }
                        else
                        {
                            mod.C_RH = "N";
                        }

                        if (dtgylx.Rows[0]["C_ROUTE_DESC"].ToString().Contains("KP"))
                        {
                            mod.C_KP = "Y";
                        }
                        else
                        {
                            mod.C_KP = "N";
                        }
                    }
                    else
                    {
                        mod.C_ROUTE = "";
                        mod.C_RH = "";
                        mod.C_KP = "";
                        //bll_order.Update(mod);
                        //continue;
                    }
                    #endregion

                    #region 轧线机时产能
                    //1：自动分配订单轧线信息和对应轧线的机时产量
                    DataTable dtzxcn = GetZG(mod.C_STL_GRD, mod.C_STD_CODE, mod.C_SPEC, "");
                    if (dtzxcn.Rows.Count > 0)
                    {
                        dtzxcn.DefaultView.Sort = "N_CAPACITY DESC ";//按产能从高到低进行排序
                        dtzxcn = dtzxcn.DefaultView.ToTable();
                        mod.C_LINE_NO = dtzxcn.Rows[0]["C_STA_ID"].ToString();
                        mod.N_MACH_WGT = Convert.ToDecimal(dtzxcn.Rows[0]["N_CAPACITY"].ToString());
                    }
                    else
                    {
                        mod.C_LINE_NO = null;
                        mod.N_MACH_WGT = null;
                        //bll_order.Update(mod);
                        //continue;
                    }
                    #endregion

                    #region 订单连铸钢坯信息
                    //2：自动分配订单连铸信息和对应的铸机机时产能
                    //匹配订单连铸钢坯信息
                    //连铸机时产量
                    DataTable dtSteelCCM = bll_slab_Cap.GetSteelCCM(mod.C_STL_GRD, mod.C_STD_CODE, "", mod.C_KP);
                    if (dtSteelCCM.Rows.Count > 0)
                    {
                        dtSteelCCM.DefaultView.Sort = "N_CAPACITY DESC ";//按产能从高到低进行排序
                        dtSteelCCM = dtSteelCCM.DefaultView.ToTable();
                        strCCM = dtSteelCCM.Rows[0]["C_STA_ID"].ToString();
                        mod.C_CCM_NO = dtSteelCCM.Rows[0]["C_STA_ID"].ToString();
                        if (dtSteelCCM.Rows[0]["N_CAPACITY"].ToString().Trim() == "")
                        {
                            mod.N_MACH_WGT_CCM = 88;
                        }
                        else
                        {
                            mod.N_MACH_WGT_CCM = Convert.ToDecimal(dtSteelCCM.Rows[0]["N_CAPACITY"].ToString());
                        }

                        mod.C_BY3 = dtSteelCCM.Rows[0]["C_TYPE"].ToString(); //排产颜色

                    }
                    else
                    {
                        mod.C_CCM_NO = "";
                        mod.N_MACH_WGT_CCM = null;
                        //bll_order.Update(mod);
                        //continue;
                    }

                    #region 连铸坯信息，钢坯定尺信息
                    //连铸坯信息，开坯信息
                    string strType = "";
                    if (mod.N_TYPE == 6)
                    {
                        strType = "钢坯";
                    }
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


                
                    #region 根据物料表查找钢坯物料信息
                    if (mod.C_ROUTE.Contains("KP"))
                    {
                        //开坯物料
                        DataTable dtgpwl = bll_wl.GetGPWL(mod.C_STL_GRD, "", null, "6", wllj, "大方坯连铸坯").Tables[0];
                        if (dtgpwl.Rows.Count > 0)
                        {
                            mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
                            mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
                            mod.N_SLAB_WIDTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_WTH"].ToString());
                            mod.N_SLAB_THICK = Convert.ToDecimal(dtgpwl.Rows[0]["N_THK"].ToString());
                            mod.N_SLAB_LENGTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_LTH"].ToString());
                            mod.C_SLAB_SIZE = dtgpwl.Rows[0]["C_SLAB_SIZE"].ToString();
                            mod.N_SLAB_PW = Convert.ToDecimal(dtgpwl.Rows[0]["N_HSL"].ToString());
                        }

                        else
                        {
                            //continue;
                        }

                        DataTable dtgpwlkp = bll_wl.GetGPWL(mod.C_STL_GRD, "", null, "6", wllj, "热轧钢坯").Tables[0];
                        if (dtgpwl.Rows.Count > 0)
                        {
                            mod.C_MATRL_CODE_KP = dtgpwlkp.Rows[0]["C_ID"].ToString();
                            mod.C_MATRL_NAME_KP = dtgpwlkp.Rows[0]["C_MAT_NAME"].ToString();
                            mod.N_KP_LENGTH = Convert.ToDecimal(dtgpwlkp.Rows[0]["N_LTH"].ToString());
                            mod.C_KP_SIZE = dtgpwlkp.Rows[0]["C_SLAB_SIZE"].ToString();
                            mod.N_KP_PW = Convert.ToDecimal(dtgpwlkp.Rows[0]["N_HSL"].ToString());

                        }
                        else
                        {
                            // continue;
                        }
                    }
                    else
                    {
                        DataTable dtgpwl = bll_wl.GetGPWL(mod.C_STL_GRD, "", null, "6", wllj, "小方坯连铸坯").Tables[0];
                        if (dtgpwl.Rows.Count > 0)
                        {
                            mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
                            mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
                            mod.N_SLAB_WIDTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_WTH"].ToString());
                            mod.N_SLAB_THICK = Convert.ToDecimal(dtgpwl.Rows[0]["N_THK"].ToString());
                            mod.N_SLAB_LENGTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_LTH"].ToString());
                            mod.C_SLAB_SIZE = dtgpwl.Rows[0]["C_SLAB_SIZE"].ToString();
                            mod.N_SLAB_PW = Convert.ToDecimal(dtgpwl.Rows[0]["N_HSL"].ToString());
                        }

                        else
                        {
                            // continue;
                        }
                    }



                    #endregion


                    #region MyRegion

                    //DataTable dt = bllslabmatch.GetOrderSlabSize(mod.C_STL_GRD, mod.C_STD_CODE, strType).Tables[0];
                    //if (dt.Rows.Count > 0)
                    //{


                    //    mod.C_SLAB_SIZE = dt.Rows[0]["C_SLAB_SIZE"].ToString();
                    //    mod.N_SLAB_LENGTH = Convert.ToDecimal(dt.Rows[0]["C_COLD_LEN"].ToString());
                    //    mod.N_SLAB_PW = Convert.ToDecimal(dt.Rows[0]["C_THE_WEIGHT"].ToString().Trim() == "" ? "0" : dt.Rows[0]["C_THE_WEIGHT"].ToString());
                    //    #region 查找连铸钢坯物料编码
                    //    DataTable dtgpwl = bll_wl.GetGPWL(mod.C_STL_GRD, mod.C_SLAB_SIZE, Convert.ToInt32(mod.N_SLAB_LENGTH), "6", wllj).Tables[0];
                    //    if (dtgpwl.Rows.Count > 0)
                    //    {
                    //        mod.C_MATRL_CODE_SLAB = dtgpwl.Rows[0]["C_ID"].ToString();
                    //        mod.C_MATRL_NAME_SLAB = dtgpwl.Rows[0]["C_MAT_NAME"].ToString();
                    //        mod.N_SLAB_WIDTH = Convert.ToDecimal(dtgpwl.Rows[0]["N_WTH"].ToString());
                    //        mod.N_SLAB_THICK = Convert.ToDecimal(dtgpwl.Rows[0]["N_THK"].ToString());
                    //    }
                    //    else
                    //    {
                    //        continue;
                    //    }

                    //    #endregion
                    //    mod.C_KP_SIZE = dt.Rows[0]["C_SLAB_SIZE_KP"].ToString();
                    //    decimal? kplent = null;
                    //    if (dt.Rows[0]["C_COLD_LEN_KP"].ToString() != "")
                    //    {
                    //        kplent = Convert.ToDecimal(dt.Rows[0]["C_COLD_LEN_KP"].ToString());

                    //        #region 查找连铸钢坯物料编码
                    //        DataTable dtgpwl2 = bll_wl.GetGPWL(mod.C_STL_GRD, mod.C_KP_SIZE, Convert.ToInt32(kplent), "6", wllj).Tables[0];
                    //        if (dtgpwl.Rows.Count > 0)
                    //        {
                    //            mod.C_MATRL_CODE_KP = dtgpwl2.Rows[0]["C_ID"].ToString();
                    //            mod.C_MATRL_NAME_KP = dtgpwl2.Rows[0]["C_MAT_NAME"].ToString();
                    //        }
                    //        else
                    //        {
                    //            continue;
                    //        }
                    //        #endregion
                    //    }
                    //    mod.N_KP_LENGTH = kplent;
                    //    decimal? kpdz = null;
                    //    if (dt.Rows[0]["C_THE_WEIGHT_KP"].ToString().Trim() != "")
                    //    {
                    //        kpdz = Convert.ToDecimal(dt.Rows[0]["C_THE_WEIGHT_KP"].ToString().Trim());
                    //    }
                    //    mod.N_KP_PW = kpdz;
                    //}
                    //else
                    //{
                    //    mod.C_SLAB_SIZE = null;
                    //    mod.N_SLAB_LENGTH = null;
                    //    mod.N_SLAB_PW = null;
                    //    mod.C_KP_SIZE = "";
                    //    mod.N_KP_LENGTH = null;
                    //    mod.N_KP_PW = null;
                    //    bll_order.Update(mod);
                    //    continue;

                    //}
                    #endregion
                    #endregion
                    #endregion

                    #region 按照可混浇规则进行钢种排产分组

                    // Mod_TMO_ORDER mod = bll_order.GetModel(dtdchs.Rows[j]["C_ID"].ToString());
                    if (mod.N_GROUP == null && dtdchs.Rows[j]["N_GROUP"].ToString().Trim() == "")
                    {
                        string ss = dtdchs.Select("", "N_GROUP DESC")[0]["N_GROUP"].ToString().Trim() == "" ? "0" : dtdchs.Select("", "N_GROUP DESC")[0]["N_GROUP"].ToString().Trim();//获取未排产炼钢订单中最大分组序号
                        int a = Convert.ToInt32(ss) + 1;//新的分组序号
                        dtdchs.Rows[j]["N_GROUP"] = a;
                        mod.N_GROUP = a;
                        bll_order.Update(mod);

                        for (int k = 0; k < dtdchs.Rows.Count; k++)
                        {
                            if (dtdchs.Rows[k]["N_GROUP"].ToString().Trim() == "")
                            {
                                //判断当前钢种和此钢种能否混浇分在同一连铸
                                //注：可能5#连铸和7#连铸/3#连铸和4#连铸能直接替换***********
                                if (mod.C_STL_GRD == dtdchs.Rows[k]["C_STL_GRD"].ToString() && mod.C_STD_CODE == dtdchs.Rows[k]["C_STD_CODE"].ToString() && bll_gw.Get_STA_DESC(mod.C_CCM_NO) == dtdchs.Rows[k]["C_CCM_NO"].ToString())
                                {
                                    dtdchs.Rows[k]["N_GROUP"] = a;
                                    Mod_TMO_ORDER mod1 = bll_order.GetModel(dtdchs.Rows[k]["C_ID"].ToString());
                                    mod1.N_GROUP = a;
                                    bll_order.Update(mod1);
                                }
                                else if (bll_xlgz.NFHJ(mod.C_STL_GRD, mod.C_STD_CODE, dtdchs.Rows[k]["C_STL_GRD"].ToString(), dtdchs.Rows[k]["C_STD_CODE"].ToString()) && bll_gw.Get_STA_DESC(mod.C_CCM_NO) == dtdchs.Rows[k]["C_CCM_NO"].ToString())
                                {

                                    dtdchs.Rows[k]["N_GROUP"] = a;
                                    Mod_TMO_ORDER mod1 = bll_order.GetModel(dtdchs.Rows[k]["C_ID"].ToString());
                                    mod1.N_GROUP = a;
                                    bll_order.Update(mod1);
                                }
                            }
                        }

                    }

                    #endregion

                    mod.C_LF_ID = "";
                    mod.C_ZL_ID = "";
                    mod.C_RH_ID = "";
                    Mod_TPP_INITIALIZE_LINE modline = bll_line.GetListByLZID(mod.C_CCM_NO);
                    if (modline != null)
                    {
                        mod.C_LF_ID = modline.C_JL_STA_ID;
                        mod.C_ZL_ID = modline.C_ZL_STA_ID;
                        mod.C_RH_ID = modline.C_ZK_STA_ID;
                    }

                    #region 匹配订单的炼钢记号

                    #endregion

                    bll_order.Update(mod);


                }
                #endregion

                int totalnum = dtdchs.Rows.Count;
                int sucessnum = 0;
                bool delete = bll_ddpj.DeleteLog();//删除之前评价失败记录
                for (int i = 0; i < dtdchs.Rows.Count; i++)
                {
                    Mod_TMO_ORDER mod = bll_order.GetModel(dtdchs.Rows[i]["C_ID"].ToString());
                    #region 订单自动评价
                    if (OrderPj(mod, "自动"))
                    {
                        mod.C_SFPJ = "Y";
                        sucessnum = sucessnum + 1;
                    }
                    else
                    {
                        mod.C_SFPJ = "N";
                    }
                    #endregion

                    bll_order.Update(mod);
                }
                MessageBox.Show("订单系统已评价：" + totalnum.ToString() + "；成功评价：" + sucessnum.ToString() + "；\r\n订单评价失败原因请查看系统评价日志！");
            }
            else
            {
                MessageBox.Show("请选择需要评价的订单！");
            }
            string group = bll_order.GroupingOrder();//订单重新分组
            WaitingFrom.CloseWait();
            btn_query_order_Click(null, null);

        }

        /// <summary>
        /// 判断订单能否评价，将不能评价的订单原因插入日志表
        /// </summary>
        /// <param name="mod">订单实体</param>
        ///  <param name="c_type">评价类型：人工/系统</param>
        /// <returns>能否评价结果</returns>
        public bool OrderPj(Mod_TMO_ORDER mod, string c_type)
        {


            string strOrderPJLog = "订单主键：" + mod.C_ID + "！订单信息： " + mod.C_STL_GRD + "|" + mod.C_STD_CODE + "|" + mod.C_SPEC + "；";
            bool sfpj = true;
            if (mod.C_STD_CODE.Trim() == "")
            {
                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                modlog.C_ORDER_NO = mod.C_ORDER_NO;
                modlog.C_TYPE = "钢种标准";
                modlog.C_RESULT = "失败";
                modlog.C_MSG = "订单钢种录入错误或订单标准没有维护！";
                bll_ddpj.Add(modlog);

                strOrderPJLog = strOrderPJLog + "\r\n订单钢种录入错误或订单标准没有维护！";
                sfpj = false;
            }
            if (mod.C_LINE_NO.Trim() == "" || mod.N_MACH_WGT == null)
            {
                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                modlog.C_ORDER_NO = mod.C_ORDER_NO;
                modlog.C_TYPE = "轧线机时产能";
                modlog.C_RESULT = "失败";
                modlog.C_MSG = "订单轧线未能分配！";
                bll_ddpj.Add(modlog);

                strOrderPJLog = strOrderPJLog + "\r\n订单轧线未能分配！";
                sfpj = false;
            }

            if (mod.C_CCM_NO.Trim() == "" || mod.N_MACH_WGT_CCM == null)
            {
                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                modlog.C_ORDER_NO = mod.C_ORDER_NO;
                modlog.C_TYPE = "连铸机时产能";
                modlog.C_RESULT = "失败";
                modlog.C_MSG = "订单连铸机时产能未维护！";
                bll_ddpj.Add(modlog);

                strOrderPJLog = strOrderPJLog + "\r\n订单连铸机时产能未维护！";
                sfpj = false;
            }
            if (mod.C_MATRL_CODE_SLAB.Trim() == "")
            {
                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                modlog.C_ORDER_NO = mod.C_ORDER_NO;
                modlog.C_TYPE = "没有对应的钢坯物料信息";
                modlog.C_RESULT = "失败";
                modlog.C_MSG = "订单钢坯物料信息未维护！";
                bll_ddpj.Add(modlog);
                strOrderPJLog = strOrderPJLog + "\r\n订单钢坯物料信息未维护！";
                sfpj = false;
            }

            if (mod.C_KP_SIZE.Trim() != "" && mod.C_MATRL_CODE_KP.Trim() == "")
            {
                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                modlog.C_ORDER_NO = mod.C_ORDER_NO;
                modlog.C_TYPE = "没有对应的开坯钢坯物料信息";
                modlog.C_RESULT = "失败";
                modlog.C_MSG = "订单开坯钢坯物料信息未维护！";
                bll_ddpj.Add(modlog);
                strOrderPJLog = strOrderPJLog + "\r\n订单开坯钢坯物料信息未维护！";
                sfpj = false;
            }

            if (mod.C_SLAB_SIZE.Trim() == "")
            {
                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                modlog.C_ORDER_NO = mod.C_ORDER_NO;
                modlog.C_TYPE = "钢坯定尺匹配";
                modlog.C_RESULT = "失败";
                modlog.C_MSG = "订单钢坯定尺信息未维护！";
                bll_ddpj.Add(modlog);
                strOrderPJLog = strOrderPJLog + "\r\n订单钢坯定尺信息未维护！";
                sfpj = false;
            }
            if (mod.C_ROUTE.Trim() == "")
            {
                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                modlog.C_ORDER_NO = mod.C_ORDER_NO;
                modlog.C_TYPE = "工艺路线";
                modlog.C_RESULT = "失败";
                modlog.C_MSG = "订单工艺路线未维护！";
                bll_ddpj.Add(modlog);

                strOrderPJLog = strOrderPJLog + "\r\n订单工艺路线未维护！";
                sfpj = false;
            }
            if (mod.C_SL == "Y" && mod.C_BY1 != "Y")
            {
                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                modlog.C_ORDER_NO = mod.C_ORDER_NO;
                modlog.C_TYPE = "首炉钢种订单";
                modlog.C_RESULT = "失败";
                modlog.C_MSG = "没有需要生产首炉钢种的订单！";
                bll_ddpj.Add(modlog);

                strOrderPJLog = strOrderPJLog + "\r\n没有需要生产首炉钢种的订单！";
                sfpj = false;
            }
            if (mod.C_WL == "Y" && mod.C_BY2 != "Y")
            {
                Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                modlog.C_ORDER_NO = mod.C_ORDER_NO;
                modlog.C_TYPE = "尾炉钢种订单";
                modlog.C_RESULT = "失败";
                modlog.C_MSG = "没有需要生产尾炉钢种的订单！";
                bll_ddpj.Add(modlog);
                strOrderPJLog = strOrderPJLog + "\r\n没有需要生产尾炉钢种的订单！";
                sfpj = false;
            }
            //if (mod.C_BY3!="Y")//钢种铁水条件没有维护
            //{
            //    Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
            //    modlog.C_EMP_ID = RV.UI.UserInfo.userID;
            //    modlog.C_ORDER_NO = mod.C_ORDER_NO;
            //    modlog.C_TYPE = "钢种铁水条件";
            //    modlog.C_RESULT = "失败";
            //    modlog.C_MSG = "订单钢种没有维护铁水条件！";
            //    bll_ddpj.Add(modlog);
            //    strOrderPJLog = strOrderPJLog + "\r\n订单钢种没有维护铁水条件！";
            //    sfpj = false;
            //}
            if (sfpj == false)//订单可以评价
            {
                //插入订单评价日志
                //Mod_TMO_ORDER_PJ_LOG modlog = new Mod_TMO_ORDER_PJ_LOG();
                //modlog.C_EMP_ID = RV.UI.UserInfo.userID;
                //modlog.C_ORDER_NO = mod.C_ORDER_NO;
                //modlog.C_TYPE = c_type;
                //modlog.C_RESULT = "失败";
                //modlog.C_MSG = strOrderPJLog;
                //bll_ddpj.Add(modlog);
            }

            return sfpj;

        }

        /// <summary>
        /// 订单手动分配轧线信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fp_zx_Click(object sender, EventArgs e)
        {

            DataTable dtdchs = DTypj.Clone();//选中的需要评价的订单
            int[] rownumber = this.gv_tmo_order_pj.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    DataRow dr = dtdchs.NewRow();
                    dr.ItemArray = this.gv_tmo_order_pj.GetDataRow(i).ItemArray;
                    dtdchs.Rows.Add(dr);
                }
                dtdchs.DefaultView.Sort = " D_DELIVERY_DT, C_LEV ";//将选中的订单按照排产目标进行排序
                dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表

                int selectNum = dtdchs.Rows.Count;
                int cgNum = 0;
                for (int j = 0; j < dtdchs.Rows.Count; j++)
                {
                    Mod_TMO_ORDER mod = bll_order.GetModel(dtdchs.Rows[j]["C_ID"].ToString());
                    mod.C_LINE_NO = this.icbo_zx1.Properties.Items[this.icbo_zx1.SelectedIndex].Value.ToString();

                    DataTable dtcxcn = GetZG(mod.C_STL_GRD, mod.C_STD_CODE, mod.C_SPEC, this.icbo_zx1.Properties.Items[this.icbo_zx1.SelectedIndex].Description.ToString());
                    if (dtcxcn.Rows.Count > 0)
                    {
                        mod.N_MACH_WGT = Convert.ToDecimal(dtcxcn.Rows[0]["N_CAPACITY"].ToString());
                        bool res = bll_order.Update(mod);
                        cgNum = cgNum + 1;
                    }
                    //else
                    //{
                    //    mod.C_LINE_NO = "";
                    //    mod.N_MACH_WGT = null;
                    //    bool res = bll_order.Update(mod);
                    //}

                }
                MessageBox.Show("产线调整成功!\r\n" + "共选择订单数：" + selectNum.ToString() + "\r\n成功分配订单数：" + cgNum.ToString());

                btn_query2_Click(null, null);
            }
        }


        #region 订单评价
        /// <summary>
        /// 获取订单生产产线信息
        /// </summary>
        /// <param name="strGZ">订单钢种</param>
        /// <param name="ZXBZ">订单执行标准</param>
        /// <param name="strSpec">订单规格</param>
        /// <param name="strCX">订单产线</param>
        /// <returns>订单生产产线信息</returns>
        public DataTable GetZG(string strGZ, string ZXBZ, string strSpec, string strCX)
        {

            DataTable dtcxgg = bll_line_spec.GetSteelLine(strGZ, ZXBZ, strSpec, strCX);
            return dtcxgg;
        }


        #endregion

        private void FrmPO_Order_Initialize_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            BindIcbo("", "ZX", icbo_zx1);
            BindIcbo("", "CC", icbo_lz1);
            BindIcbo("", "ZX", icbo_zx2);
            BindIcbo("", "CC", icbo_lz2);
        }


        private void BindCK()
        {

            this.icbo_ck.Properties.Items.Clear();
            DataTable dt = bllTPB_SLABWH.GetListByStatus(1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                icbo_ck.Properties.Items.Add("");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    icbo_ck.Properties.Items.Add(dt.Rows[i]["C_SLABWH_NAME"].ToString(), dt.Rows[i]["C_SLABWH_CODE"].ToString(), -1);
                }
                icbo_ck.SelectedIndex = 0;
            }
            else
            {
                icbo_ck.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 订单手动调整连铸生产信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fp_lz_Click(object sender, EventArgs e)
        {
            DataTable dtdchs = DTypj.Clone();//选中的需要评价的订单
            int[] rownumber = this.gv_tmo_order_pj.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    DataRow dr = dtdchs.NewRow();
                    dr.ItemArray = this.gv_tmo_order_pj.GetDataRow(i).ItemArray;
                    dtdchs.Rows.Add(dr);
                }
                dtdchs.DefaultView.Sort = " D_DELIVERY_DT, C_LEV ";//将选中的订单按照排产目标进行排序
                dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表
                int selectNum = dtdchs.Rows.Count;
                int cgNum = 0;
                for (int j = 0; j < dtdchs.Rows.Count; j++)
                {
                    Mod_TMO_ORDER mod = bll_order.GetModel(dtdchs.Rows[j]["C_ID"].ToString());
                    mod.C_CCM_NO = this.icbo_lz1.Properties.Items[this.icbo_lz1.SelectedIndex].Value.ToString();

                    //连铸机时产量
                    DataTable dtSteelCCM = bll_slab_Cap.GetSteelCCM(mod.C_STL_GRD, mod.C_STD_CODE, mod.C_CCM_NO, mod.C_KP);
                    if (dtSteelCCM.Rows.Count > 0)
                    {
                        mod.N_MACH_WGT_CCM = Convert.ToDecimal(dtSteelCCM.Rows[0]["N_CAPACITY"].ToString());

                        string strType = "";
                        //连铸坯信息，开坯信息
                        if (mod.N_TYPE == 6)
                        {
                            strType = "钢坯";
                        }
                        DataTable dt = bllslabmatch.GetOrderSlabSize(mod.C_STL_GRD, mod.C_STD_CODE, strType).Tables[0];
                        if (dt.Rows.Count > 0)
                        {
                            mod.C_SLAB_SIZE = dt.Rows[0]["C_SLAB_SIZE"].ToString();
                            mod.N_SLAB_LENGTH = Convert.ToDecimal(dt.Rows[0]["C_COLD_LEN"].ToString());
                            mod.N_SLAB_PW = Convert.ToDecimal(dt.Rows[0]["C_THE_WEIGHT"].ToString().Trim() == "" ? "0" : dt.Rows[0]["C_THE_WEIGHT"].ToString());
                            mod.C_KP_SIZE = dt.Rows[0]["C_SLAB_SIZE_KP"].ToString();
                            decimal? kplent = null;
                            if (dt.Rows[0]["C_COLD_LEN_KP"].ToString() != "")
                            {
                                kplent = Convert.ToDecimal(dt.Rows[0]["C_COLD_LEN_KP"].ToString());
                            }
                            mod.N_KP_LENGTH = kplent;
                            decimal? kpdz = null;
                            if (dt.Rows[0]["C_THE_WEIGHT_KP"].ToString().Trim() != "")
                            {
                                kpdz = Convert.ToDecimal(dt.Rows[0]["C_THE_WEIGHT_KP"].ToString().Trim());
                            }
                            mod.N_KP_PW = kpdz;
                        }

                        bll_order.Update(mod);
                        cgNum = cgNum + 1;
                    }
                    //else
                    //{
                    //    mod.C_CCM_NO = "";
                    //    mod.N_MACH_WGT_CCM = null;
                    //    bll_order.Update(mod);
                    //}


                }
                MessageBox.Show("连铸调整成功!\r\n" + "共选择订单数：" + selectNum.ToString() + "\r\n成功分配订单数：" + cgNum.ToString());
                btn_query2_Click(null, null);
            }
        }
        /// <summary>
        /// 订单人工评价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_order_pj_Click(object sender, EventArgs e)
        {
            DataTable dtdchs = dtOrder.Clone();//选中的需要评价的订单
            int[] rownumber = this.gv_tmo_order.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    DataRow dr = dtdchs.NewRow();
                    dr.ItemArray = this.gv_tmo_order.GetDataRow(i).ItemArray;
                    dtdchs.Rows.Add(dr);
                }
                dtdchs.DefaultView.Sort = " D_DELIVERY_DT, C_LEV ";//将选中的订单按照排产目标进行排序
                dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表
                int pjCount = 0;
                for (int j = 0; j < dtdchs.Rows.Count; j++)
                {

                    Mod_TMO_ORDER mod = bll_order.GetModel(dtdchs.Rows[j]["C_ID"].ToString());
                    string strOrderPJLog = "订单主键：" + mod.C_ID + "！订单信息： " + mod.C_STL_GRD + "|" + mod.C_STD_CODE + "|" + mod.C_SPEC + "；";
                    bool sfpj = true;
                    if (mod.C_LINE_NO.Trim() == "")
                    {
                        strOrderPJLog = strOrderPJLog + "\r\n订单轧线未能分配！";
                        sfpj = false;
                    }
                    if (mod.N_MACH_WGT == null)
                    {
                        strOrderPJLog = strOrderPJLog + "\r\n订单轧线机时产能未维护！";
                        sfpj = false;
                    }
                    if (mod.C_CCM_NO.Trim() == "")
                    {
                        strOrderPJLog = strOrderPJLog + "\r\n订单连铸信息未能分配！";
                        sfpj = false;
                    }
                    if (mod.N_MACH_WGT_CCM == null)
                    {
                        strOrderPJLog = strOrderPJLog + "\r\n订单连铸机时产能未维护！";
                        sfpj = false;
                    }
                    if (mod.C_SLAB_SIZE.Trim() == "")
                    {
                        strOrderPJLog = strOrderPJLog + "\r\n订单钢坯定尺信息未维护！";
                        sfpj = false;
                    }
                    if (mod.C_ROUTE.Trim() == "")
                    {
                        strOrderPJLog = strOrderPJLog + "\r\n订单工艺路线未维护！";
                        sfpj = false;
                    }
                    if (sfpj == true)//订单可以评价
                    {
                        mod.C_SFPJ = "Y";
                        bll_order.Update(mod);
                        pjCount = pjCount + 1;
                    }
                    else//订单不能评价
                    {
                        //插入订单评价日志
                    }
                }
                MessageBox.Show("订单评价成功：" + pjCount.ToString());
            }
        }

        DataTable dtYPJ_order = null;
        /// <summary>
        /// 刷新订单炼钢顺序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtYPJ_order = bll_order.GetListByWhere("Y", 2, 0, null, "", "", "", "", "", "", null, null, "", "", "", "", "", "", "", "", "").Tables[0];
            DataTable dt_R_Order = dtYPJ_order.Copy();//需要处理的订单列表
        }
        /// <summary>
        /// 取消订单评价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_calcle_pj_Click(object sender, EventArgs e)
        {
            if (DTypj == null)
            {
                return;
            }
            bll_lclsb.DeleteByCCM("");
            bll_lsb.Delete();
            DataTable dtdchs = DTypj.Clone();//选中的需要评价的订单
            int[] rownumber = this.gv_tmo_order_pj.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    DataRow dr = dtdchs.NewRow();
                    dr.ItemArray = this.gv_tmo_order_pj.GetDataRow(i).ItemArray;
                    dtdchs.Rows.Add(dr);
                }
                dtdchs.DefaultView.Sort = " D_DELIVERY_DT, C_LEV ";//将选中的订单按照排产目标进行排序
                dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表

                for (int j = 0; j < dtdchs.Rows.Count; j++)
                {
                    Mod_TMO_ORDER mod = bll_order.GetModel(dtdchs.Rows[j]["C_ID"].ToString());
                    mod.C_SFPJ = "N";
                    mod.N_SORT = null;
                    bll_order.Update(mod);
                }
                btn_query2_Click(null, null);
            }
        }

        private void btn_queryLog_Click(object sender, EventArgs e)
        {

            FrmPO_Order_Initialize_log frm = new FrmPO_Order_Initialize_log();
            frm.ShowDialog();


        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            // OutToExcel.ToExcel(this, this.gc_tmo_order);
            OutToExcel.ToExcel(this.gc_tmo_order);
        }

        private void btn_out_pj_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_tmo_order_pj);
        }

        private void btn_tj2_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (rbtn_tj.SelectedIndex == 0)//按产线统计
            {
                dt = bll_order.Get_List_ACX("").Tables[0];
                this.gc_tj2.DataSource = dt;
                this.gc_tj2.MainView = gv_tj_zg;
                this.gv_tj_zg.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gv_tj_zg);
                this.gv_tj_zg.BestFitColumns();

            }
            if (rbtn_tj.SelectedIndex == 1)
            {
                dt = bll_order.Get_List_ACXGG("").Tables[0];
                this.gc_tj2.DataSource = dt;
                this.gc_tj2.MainView = gv_tj_gg;
                this.gv_tj_gg.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gv_tj_gg);
                this.gv_tj_gg.BestFitColumns();
            }
            if (rbtn_tj.SelectedIndex == 2)
            {
                dt = bll_order.Get_List_ALZ("").Tables[0];
                this.gc_tj2.DataSource = dt;
                this.gc_tj2.MainView = gv_tj_lz;
                this.gv_tj_lz.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gv_tj_lz);
                this.gv_tj_lz.BestFitColumns();
            }
            if (rbtn_tj.SelectedIndex == 3)
            {
                dt = bll_order.Get_List_ALZGZ("").Tables[0];
                this.gc_tj2.DataSource = dt;
                this.gc_tj2.MainView = gv_tj_gz;
                this.gv_tj_gz.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gv_tj_gz);
                this.gv_tj_gz.BestFitColumns();
            }
        }

        private void btn_tscf_Click(object sender, EventArgs e)
        {
            DataTable dt = bll_tscf.GetTSCFByOrder();
            this.gc_cf.DataSource = dt;
            this.gv_cf.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_cf);
            this.gv_cf.BestFitColumns();
        }

        private void btn_query_bygroup_Click(object sender, EventArgs e)
        {
            FrmPO_LogGroup frm = new FrmPO_LogGroup();
            frm.ShowDialog();
        }
        /// <summary>
        /// 订单分配库存坯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ppgp_Click(object sender, EventArgs e)
        {
            if (DTypj == null)
            {
                return;
            }
            bll_lclsb.DeleteByCCM("");
            bll_lsb.Delete();

            if (DialogResult.Yes == MessageBox.Show("是否自动匹配库存钢坯钢坯？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {

            }
            DataTable dtdchs = DTypj.Clone();//选中的需要评价的订单
            int[] rownumber = this.gv_tmo_order_pj.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    DataRow dr = dtdchs.NewRow();
                    dr.ItemArray = this.gv_tmo_order_pj.GetDataRow(i).ItemArray;
                    dtdchs.Rows.Add(dr);
                }
                dtdchs.DefaultView.Sort = " D_DELIVERY_DT, C_LEV ";//将选中的订单按照排产目标进行排序
                dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表
                for (int i = 0; i < dtdchs.Rows.Count; i++)
                {
                    #region sql
                    //1：502
                    //2：511
                    //3：514
                    //4：515
                    //5：530
                    //待排钢坯重量：本次轧钢计划-（上次已排炼钢未生产+当前库存钢坯-上次轧钢已排未生产）--库存钢坯

                    //  上次已排炼钢未生产 tsp_plan_sms
                    //  当前库存钢坯 tsc_slab_main
                    //上次轧钢已排未生产 trp_plan_roll

                    string sql = @"SELECT * FROM (
SELECT SUM(1) N_NUM,
       T.C_STOVE,
       T.C_STL_GRD,
       T.C_SPEC,
       T.N_LEN,
       SUM(T.N_WGT) N_WGT,
       T.C_SLABWH_CODE,
       MIN(T.D_CCM_DATE)
  FROM TSC_SLAB_MAIN T
 WHERE T.C_MOVE_TYPE = 'E'
   AND T.C_MAT_TYPE = '合格品'
   AND T.C_SLABWH_CODE = '553' AND(C_ISXM = 'Y' OR C_XMGX IS NULL) AND T.T.C_ORD_NO IS NULL
 GROUP BY T.C_STOVE, T.C_STL_GRD, T.C_SPEC, T.N_LEN, T.C_SLABWH_CODE) A ORDER BY A.N_NUM, A.C_STOVE, A.C_STL_GRD ";//钢坯库存信息
                    #endregion
                }


            }
        }
        private Bll_TSC_SLAB_MAIN bll_gp = new Bll_TSC_SLAB_MAIN();
        /// <summary>
        /// 查询钢坯库库存钢坯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tj1_Click(object sender, EventArgs e)
        {
            DataSet ds = bll_gp.GetList("E", "", "", txt_gz6.Text.Trim(), this.txt_bz6.Text.Trim());
            gc_order_gp.DataSource = ds.Tables[0];

            this.gv_order_gp.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_order_gp);
            this.gv_order_gp.BestFitColumns();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //对未排产订单进行处理（订单排产剩余重量>0）N_WGT-N_ISSUE_WGT-N_LINE_MATCH_WGT
            WaitingFrom.ShowWait("");
            DataTable dtdchs = bll_order.GetLGWPOrder();
            #region 订单自动处理
            for (int j = 0; j < dtdchs.Rows.Count; j++)
            {

                Mod_TMO_ORDER mod = bll_order.GetModel(dtdchs.Rows[j]["C_ID"].ToString());
                Cls_Order_PC.OrderPj(mod,"");
            }
            #endregion

            MessageBox.Show("评价完成！");
            //DataTable dtdchs = dtOrder.Clone();//选中的需要评价的订单
            //int[] rownumber = this.gv_tmo_order.GetSelectedRows();//获取选中行号数组；
            //if (rownumber.Length > 0)
            //{
            //    for (int i = 0; i < rownumber.Length; i++)
            //    {
            //        int selectedHandle = rownumber[i];
            //        DataRow dr = dtdchs.NewRow();
            //        dr.ItemArray = this.gv_tmo_order.GetDataRow(i).ItemArray;
            //        dtdchs.Rows.Add(dr);
            //    }
            //    dtdchs.DefaultView.Sort = " D_DELIVERY_DT, C_LEV ";//将选中的订单按照排产目标进行排序
            //    dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表
            //    #region 订单自动处理
            //    for (int j = 0; j < dtdchs.Rows.Count; j++)
            //    {

            //        Mod_TMO_ORDER mod = bll_order.GetModel(dtdchs.Rows[j]["C_ID"].ToString());
            //        Cls_Order_PC.OrderPj(mod);
            //    }
            //    #endregion


            //    MessageBox.Show("评价完成！");
            //}
            WaitingFrom.CloseWait();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Order_Grouping());
        }

        /// <summary>
        ///将订单按可混浇进行分组
        /// </summary>
        public string Order_Grouping()
        {
            bool clear = bll_order.ClearGroupNo();
            List<Mod_TMO_ORDER> list = bll_order.GetModelList().OrderBy(a => a.C_STL_GRD).ThenBy(a => a.C_STD_CODE).ToList();
            #region 按照可混浇规则进行钢种排产分组
            for (int j = 0; j < list.Count; j++)
            {
                Mod_TMO_ORDER mod = list[j];//获取订单
                if (list[j].N_GROUP == null)
                {
                    List<Mod_TMO_ORDER> list1 = list.Where(f => f.N_GROUP == null).ToList();
                    decimal? ss = list1.Where(f => f.N_GROUP != null).Max(m => m.N_GROUP);//获取未排产炼钢订单中最大分组序号
                    int a = Convert.ToInt32(ss) + 1;//新的分组序号
                    //按相邻钢种获取分组号
                    list[j].N_GROUP = a;

                    for (int k = 0; k < list.Count; k++)
                    {
                        if (list[j].C_CCM_NO == list[k].C_CCM_NO && ((list[j].C_STL_GRD == list[k].C_STL_GRD && list[j].C_STD_CODE == list[k].C_STD_CODE) || (bll_xlgz.NFHJ(list[j].C_STL_GRD, list[j].C_STD_CODE, list[k].C_STL_GRD, list[k].C_STD_CODE))))
                        {
                            list[k].N_GROUP = a;
                        }
                    }

                }
            }
            #endregion
            List<Mod_TMO_ORDER> list2 = list;
            return "分组成功！";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            DataTable dtdchs = dtOrder.Clone();//选中的需要评价的订单
            int[] rownumber = this.gv_tmo_order.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    DataRow dr = dtdchs.NewRow();
                    dr.ItemArray = this.gv_tmo_order.GetDataRow(i).ItemArray;
                    dtdchs.Rows.Add(dr);
                }
                dtdchs.DefaultView.Sort = " D_DELIVERY_DT, C_LEV ";//将选中的订单按照排产目标进行排序
                dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表
                #region 订单自动处理
                for (int j = 0; j < dtdchs.Rows.Count; j++)
                {
                    Cls_Order_PC.OrderPj(dtdchs);
                }
                #endregion
            }
            WaitingFrom.CloseWait();
        }

        private void btn_order_pj1_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            string res = bll_order.ManageOrder();
            MessageBox.Show(res);
            btn_query_order_Click(null, null);
            btn_query2_Click(null, null);
            WaitingFrom.CloseWait();
        }
    }
}

