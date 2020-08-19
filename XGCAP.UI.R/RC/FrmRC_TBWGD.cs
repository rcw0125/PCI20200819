using BLL;
using Common;
using IDAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.R.RC
{
    public partial class FrmRC_TBWGD : Form
    {
        public FrmRC_TBWGD()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staID = bll_TB_STA.GetStaIdByCode(arr[0]);
            slbwhCode = arr[1];
        }

        string staID = "";//轧线工位ID
        string slbwhCode = "";//待轧钢坯仓库库位编码
        DataTable dtRF = null;
        DataTable dtNC = null;
        Bll_TRC_ROLL_WGD bll_TRC_ROLL_WGD = new Bll_TRC_ROLL_WGD();
        Bll_TRC_ROLL_WGD_HANDLER bll_TRC_ROLL_WGD_HANDLER = new Bll_TRC_ROLL_WGD_HANDLER();
        Dal_Interface_FR dal_Interface_FR = new Dal_Interface_FR();
        Bll_TRP_PLAN_ROLL bll_TRP_PLAN_ROLL = new Bll_TRP_PLAN_ROLL();
        Bll_TRC_ROLL_MAIN bll_TRC_ROLL_MAIN = new Bll_TRC_ROLL_MAIN();
        Bll_TB_MATRL_MAIN bll_TB_MATRL_MAIN = new Bll_TB_MATRL_MAIN();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();
        Bll_TPB_LINEWH bll_TPB_LINEWH = new Bll_TPB_LINEWH();
        Bll_TQB_CHECKSTATE bll_TQB_CHECKSTATE = new Bll_TQB_CHECKSTATE();
        Bll_TRC_WARM_FURNACE bll_TRC_WARM_FURNACE = new Bll_TRC_WARM_FURNACE();
        Bll_TB_STD_CONFIG bll_TB_STD_CONFIG = new Bll_TB_STD_CONFIG();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        Bll_Interface_NC_Roll_A1 bll_Interface_NC_Roll_A1 = new Bll_Interface_NC_Roll_A1();
        Bll_Interface_NC_Roll_A2 bll_Interface_NC_Roll_A2 = new Bll_Interface_NC_Roll_A2();
        Bll_Interface_NC_Roll_A3 bll_Interface_NC_Roll_A3 = new Bll_Interface_NC_Roll_A3();
        Bll_Interface_NC_Roll_A4 bll_Interface_NC_Roll_A4 = new Bll_Interface_NC_Roll_A4();
        Bll_Interface_NC_Roll_46 bll_Interface_NC_Roll_46 = new Bll_Interface_NC_Roll_46();
        Bll_TRP_PLAN_ROLL_ITEM bllPlanRollItem = new Bll_TRP_PLAN_ROLL_ITEM();

        private void FrmRC_TBWGD_Load(object sender, EventArgs e)
        {
            BindWgdFinished();
            BindWgd();
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }

        public void BindWgdFinished()
        {
            DataTable dt = bll_TRC_ROLL_WGD.GetWgdFinished(0).Tables[0];
            dtRF = bll_TRC_ROLL_WGD.GetWgdFinishedLoc(staID, dt);
            this.gc_WGD.DataSource = dtRF;
            SetGridViewRowNum.SetRowNum(gv_WGD);
        }

        public void BindWgd()
        {
            string sqlWhere = @"   N_SCRF=2  
                                                  AND ( N_IF_EXEC_STATUS=1 OR  N_IF_EXEC_STATUS IS NULL) 
                                                  AND  C_STA_ID='" + staID + "'     AND  N_IS_MERGE=0    ";
            dtNC = bll_TRC_ROLL_WGD.GetList(sqlWhere).Tables[0];
            this.gc_NC.DataSource = dtNC;
            SetGridViewRowNum.SetRowNum(gv_NC);
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindWgdFinished();
        }

        private void btn_QueryNC_Click(object sender, EventArgs e)
        {
            BindWgd();
        }

        private void btn_SyncNC_Click(object sender, EventArgs e)
        {
            NcRollA1 ncA1 = new NcRollA1();
            NcRollA2 ncA2 = new NcRollA2();
            NcRollA3 ncA3 = new NcRollA3();
            NcRollA4 ncA4 = new NcRollA4();
            int result = 0;
            int errorStatus = 1;
            string errorId = "";

            string strMenuName = RV.UI.UserInfo.menuName;

            UserLog.AddLog(strMenuName, slbwhCode + "同步NC", "同步NC", "同步NC");//添加操作日志

            try
            {
                WaitingFrom.ShowWait("");
                if (dtNC != null && dtNC.Rows.Count > 0)
                {
                    for (int i = 0; i < dtNC.Rows.Count; i++)
                    {
                        string id = dtNC.Rows[i]["C_MAIN_ID"].ToString();
                        errorId = id;
                        var wgd = bll_TRC_ROLL_WGD.GetModel(id, 1);
                        var plan = bllPlanRollItem.GetModel_Item(wgd.C_PLAN_ID);
                        if (plan.N_IS_MERGE == 1)
                        { continue; }
                        var a1Sta = bll_TB_STA.GetModel(plan.C_STA_ID);
                        ncA1.bmid = "1001NC10000000000345";
                        ncA1.jhrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                        ncA1.jhxxsl = plan.N_WGT.ToString();
                        var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                        ncA1.jhyid = matrl.C_PLANEMP;
                        ncA1.jldwid = matrl.C_PK_MEASDOC;
                        ncA1.pk_produce = matrl.C_PK_PRODUCE;
                        ncA1.scbmid = a1Sta.C_SSBMID;
                        ncA1.shrid = "1006AA100000000ERS2A";//plan.C_EMP_ID;
                        ncA1.shrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                        ncA1.slrq = DateTime.Parse(plan.D_NEED_DT == null ? DateTime.Now.ToString() : plan.D_NEED_DT.ToString());
                        ncA1.wlbmid = matrl.C_PK_INVBASDOC;
                        ncA1.xdrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                        ncA1.xqrq = DateTime.Parse(plan.D_DELIVERY_DT == null ? DateTime.Now.ToString() : plan.D_DELIVERY_DT.ToString());
                        ncA1.xqsl = plan.N_WGT.ToString();
                        ncA1.zdrq = DateTime.Now;
                        ncA1.zyx1 = plan.C_FREE_TERM;
                        ncA1.zyx2 = plan.C_FREE_TERM2;
                        ncA1.zyx3 = plan.C_PACK;
                        ncA1.zyx5 = plan.C_ID;
                        ncA1.memo = plan.C_AREA;
                        ncA1.jhfaid = matrl.C_PK_PSID;
                        string a1Name = plan.C_ID + "_A1.xml";
                        var resultA1 = bll_Interface_NC_Roll_A1.SendXml_ROLL_A1("", a1Name, ncA1, Application.StartupPath);
                        if (resultA1[0] != "1")
                        {
                            bll_TRC_ROLL_WGD.UpdateIfStatus(1, id, resultA1[1]);
                            //continue;
                        }

                        DataTable factDt2 = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                        bool bol = false;
                        for (int j = 0; j < factDt2.Rows.Count; j++)
                        {
                            string slabWh = bll_TPB_LINEWH.GetList_id(factDt2.Rows[j]["C_LINEWH_CODE"].ToString()).ToString();
                            if (string.IsNullOrEmpty(slabWh))
                            {
                                bol = true;
                                break;
                            }
                        }

                        if (bol)
                            continue;

                        errorStatus = 2;
                        var main = bll_TRC_ROLL_MAIN.GetModel(id);
                        var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);
                        var matrl2 = bll_TB_MATRL_MAIN.GetModel(main.C_MAT_SLAB_CODE);
                        ncA2.wlbmid = matrl.C_PK_INVBASDOC;
                        ncA2.pk_produce = matrl.C_PK_PRODUCE;
                        ncA2.invcode = matrl.C_ID;
                        ncA2.pch = main.C_BATCH_NO;
                        ncA2.scbmid = a2Sta.C_SSBMID;
                        ncA2.gzzxid = a2Sta.C_ERP_PK;
                        ncA2.bcid = wgd.C_PRODUCE_SHIFT;
                        ncA2.bzid = wgd.C_PRODUCE_GROUP;
                        ncA2.jhkgrq = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                        ncA2.jhwgrq = DateTime.Parse(wgd.D_PRODUCE_DATE_E == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_E.ToString());
                        ncA2.jhkssj = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                        ncA2.jhjssj = DateTime.Parse(wgd.D_PRODUCE_DATE_E == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_E.ToString());
                        ncA2.sjkgrq = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                        ncA2.sjwgrq = DateTime.Parse(wgd.D_PRODUCE_DATE_E == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_E.ToString());
                        ncA2.sjkssj = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                        ncA2.sjjssj = DateTime.Parse(wgd.D_PRODUCE_DATE_E == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_E.ToString());
                        ncA2.jhwgsl = main.N_WGT_EXIT == 0 ? main.N_WGT_ELIM.ToString() : main.N_WGT_EXIT.ToString();
                        ncA2.fjhsl = main.N_QUA_EXIT == 0 ? main.N_QUA_ELIM.ToString() : main.N_QUA_EXIT.ToString();
                        ncA2.jldwid = matrl.C_PK_MEASDOC;
                        ncA2.fjlid = matrl.C_FJLDW;
                        ncA2.sjwgsl = (main.N_WGT_TOTAL_VIRTUAL - main.N_WGT_TOTAL).ToString();
                        ncA2.freeitemvalue1 = plan.C_FREE_TERM;
                        ncA2.freeitemvalue2 = plan.C_FREE_TERM2;
                        ncA2.freeitemvalue3 = plan.C_PACK;
                        ncA2.zdrid = RV.UI.UserInfo.userAccount;
                        ncA2.freeitemvalue5 = plan.C_ID;
                        string a2Name = Guid.NewGuid() + "_A2.xml";
                        if (bll_TRC_ROLL_WGD.IsA2Repeat(main.C_BATCH_NO, "") > 0)
                        {

                        }
                        var resultA2 = bll_Interface_NC_Roll_A2.SendXml_ROLL_A2("", a2Name, ncA2, Application.StartupPath);
                        if (resultA2[0] != "1")
                        {
                            bll_TRC_ROLL_WGD.UpdateIfStatus(2, id, resultA2[1]);

                        }

                        if (main.N_WGT_EXIT == 0)
                        {
                            if (bll_TRC_ROLL_WGD.UpdateUpLoadStatus(3, id) > 0)
                                MessageBox.Show("同步成功");

                        }

                        errorStatus = 3;
                        ncA3.hpch = main.C_BATCH_NO;
                        ncA3.hzdrid = RV.UI.UserInfo.userAccount;
                        ncA3.hwlbmid = matrl.C_PK_INVBASDOC;
                        ncA3.hjldwid = matrl.C_PK_MEASDOC;
                        ncA3.hzdrq = DateTime.Parse(wgd.D_MOD_DT == null ? DateTime.Now.ToString() : wgd.D_MOD_DT.ToString());
                        ncA3.hfreeitemvalue1 = plan.C_FREE_TERM;
                        ncA3.hfreeitemvalue2 = plan.C_FREE_TERM2;
                        ncA3.hfreeitemvalue3 = plan.C_PACK;

                        DataTable consumeDt = new DataTable();
                        DataTable a3Dt = bll_TRC_WARM_FURNACE.GetSlabMainInfo(wgd.C_MAIN_ID, out consumeDt);
                        DataTable a3DtZyx = bll_TB_STD_CONFIG.GetZYX(a3Dt.Rows[0]["C_STL_GRD"].ToString(), a3Dt.Rows[0]["C_STD_CODE"].ToString()).Tables[0];
                        var m = bll_TB_MATRL_MAIN.GetModel(a3Dt.Rows[0]["C_MAT_CODE"].ToString());
                        ncA3.kgyid = RV.UI.UserInfo.userAccount;
                        ncA3.ckckid = bll_TPB_SLABWH.GetList_id(slbwhCode);
                        ncA3.wlbmid = matrl2.C_PK_INVBASDOC;
                        ncA3.jldwid = matrl2.C_PK_MEASDOC;
                        ncA3.fjldwid = matrl2.C_FJLDW;
                        ncA3.ljcksl = a3Dt.Rows[0]["N_WGT"].ToString();
                        ncA3.fljcksl = a3Dt.Rows[0]["N_QUA"].ToString();
                        ncA3.pch = a3Dt.Rows[0]["C_BATCH_NO"].ToString() == "" ? a3Dt.Rows[0]["C_STOVE"].ToString() : a3Dt.Rows[0]["C_BATCH_NO"].ToString();
                        ncA3.gzzxid = a2Sta.C_ERP_PK;
                        ncA3.freeitemvalue1 = a3Dt.Rows[0]["C_ZYX1"].ToString();
                        ncA3.freeitemvalue2 = a3Dt.Rows[0]["C_ZYX2"].ToString();
                        object objOutTime = bll_TRC_WARM_FURNACE.GetOutTime(main.C_ID);
                        ncA3.flrq = DateTime.Parse(wgd.D_MOD_DT == null ? DateTime.Now.ToString() : wgd.D_MOD_DT.ToString()).ToString("yyyy-MM-dd");
                        string a3Name = Guid.NewGuid() + "_A3.xml";
                        if (bll_TRC_ROLL_WGD.IsA3Repeat(main.C_BATCH_NO, "") > 0)
                        {

                        }
                        var resultA3 = bll_Interface_NC_Roll_A3.SendXml_ROLL_A3("", a3Name, ncA3, Application.StartupPath);
                        if (resultA3[0] != "1")
                        {
                            bll_TRC_ROLL_WGD.UpdateIfStatus(3, id, resultA3[1]);

                        }
                        bll_TRC_WARM_FURNACE.ConsumeSlab(consumeDt);

                        errorStatus = 4;
                        DataTable a4FactDt = bll_TRC_ROLL_WGD.GetWgdFact(wgd.C_BATCH_NO, 1).Tables[0];
                        var a4M = bll_TB_MATRL_MAIN.GetModel(wgd.C_MAT_CODE);
                        var a4Sta = bll_TB_STA.GetModel(wgd.C_STA_ID);
                        ncA4.zdrid = RV.UI.UserInfo.userAccount;
                        ncA4.rq = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                        ncA4.gzzxbmid = a4Sta.C_STA_ERPCODE;
                        ncA4.scbmid = a4Sta.C_SSBMID;
                        ncA4.pch = wgd.C_BATCH_NO;
                        ncA4.wlbmid = a4M.C_PK_INVBASDOC;
                        ncA4.jldwid = a4M.C_PK_MEASDOC;
                        ncA4.gzzxid = a4Sta.C_ERP_PK;
                        ncA4.ccxh = wgd.C_BATCH_NO;
                        ncA4.pk_produce = a4M.C_PK_PRODUCE;
                        ncA4.ksrq = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                        ncA4.jsrq = DateTime.Parse(wgd.D_PRODUCE_DATE_E == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_E.ToString());
                        ncA4.hgsl = a4FactDt.Rows[0]["WGT"].ToString();
                        ncA4.fhgsl = a4FactDt.Rows[0]["QUA"].ToString();
                        object wgdHandlerStatus = bll_TRC_ROLL_WGD_HANDLER.GetWgdHandlerStatus(wgd.C_ID);
                        if (wgdHandlerStatus != null)
                        {
                            string status = wgdHandlerStatus.ToString();
                            ncA4.sflfcp = int.Parse(status) == 2 ? "Y" : "N";
                            ncA4.sffsgp = int.Parse(status) == 2 ? "Y" : "N";
                        }
                        else
                        {
                            ncA4.sflfcp = "N";
                            ncA4.sffsgp = "N";
                        }
                        ncA4.freeitemvalue1 = wgd.C_FREE_TERM;
                        ncA4.freeitemvalue2 = wgd.C_FREE_TERM2;
                        ncA4.freeitemvalue3 = wgd.C_PACK;
                        string a4Name = Guid.NewGuid() + "_A4.xml";
                        if (bll_TRC_ROLL_WGD.IsA4Repeat(main.C_BATCH_NO, "") > 0)
                        {

                        }
                        var resultA4 = bll_Interface_NC_Roll_A4.SendXml_ROLL_A4("", a4Name, ncA4, Application.StartupPath);
                        if (resultA4[0] != "1")
                        {
                            bll_TRC_ROLL_WGD.UpdateIfStatus(4, id, resultA4[1]);

                        }

                        errorStatus = 5;
                        decimal wgdWgt = 0;
                        DataTable factDt = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                        List<NcRoll46> nc46s = new List<NcRoll46>();
                        for (int j = 0; j < factDt.Rows.Count; j++)
                        {
                            NcRoll46 nc46 = new NcRoll46();
                            var a46M = bll_TB_MATRL_MAIN.GetModel(factDt.Rows[j]["C_MAT_CODE"].ToString());
                            nc46.cwarehouseid = bll_TPB_LINEWH.GetList_id(factDt.Rows[j]["C_LINEWH_CODE"].ToString()).ToString();
                            nc46.taccounttime = DateTime.Parse(wgd.D_MOD_DT == null ? DateTime.Now.ToString() : wgd.D_MOD_DT.ToString());
                            nc46.coperatorid = RV.UI.UserInfo.userAccount;
                            //if (wgd.C_MRSX == "DP")
                            //{ }
                            nc46.ccheckstate_bid = bll_TQB_CHECKSTATE.GetModelByName("DP", "1001").C_ID;
                            //else
                            //    nc46.ccheckstate_bid = bll_TQB_CHECKSTATE.GetModelByName(factDt.Rows[j]["C_JUDGE_LEV_BP"].ToString(), "1001").C_ID;
                            nc46.cworkcenterid = bll_TB_STA.Get_NC_ID(wgd.C_STA_ID);
                            nc46.dbizdate = DateTime.Parse(wgd.D_MOD_DT == null ? DateTime.Now.ToString() : wgd.D_MOD_DT.ToString());
                            nc46.vbatchcode = wgd.C_BATCH_NO;
                            nc46.cinvbasid = a46M.C_PK_INVBASDOC;
                            nc46.pk_produce = a46M.C_PK_PRODUCE;
                            nc46.ninnum = factDt.Rows[j]["WGT"].ToString();
                            nc46.ninassistnum = factDt.Rows[j]["QUA"].ToString();
                            nc46.castunitid = a46M.C_FJLDW;
                            nc46.vfree1 = factDt.Rows[j]["C_ZYX1"].ToString();
                            nc46.vfree2 = factDt.Rows[j]["C_ZYX2"].ToString();
                            nc46.vfree3 = factDt.Rows[j]["C_BZYQ"].ToString();
                            nc46s.Add(nc46);
                            wgdWgt += decimal.Parse(factDt.Rows[j]["WGT"].ToString());
                        }

                        string a46Name = Guid.NewGuid() + "_A46.xml";

                        var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, Application.StartupPath);
                        if (resultA46[0] != "1")
                        {
                            bll_TRC_ROLL_WGD.UpdateIfStatus(5, id, resultA46[1]);
                        }

                        if (bll_TRC_ROLL_WGD.Is46Repeat(main.C_BATCH_NO, "") > 0)
                        {
                            bll_TRC_ROLL_WGD.UpdateRollPlanItemWgt(plan.C_ID, wgdWgt);

                            if (bll_TRC_ROLL_WGD.UpdateUpLoadStatus(3, id) > 0)
                                result++;
                        }

                    }
                }
                WaitingFrom.CloseWait();
                MessageBox.Show("同步成功" + result);
            }
            catch (Exception ex)
            {
                bll_TRC_ROLL_WGD.UpdateIfStatus(errorStatus, errorId, ex.Message);
                MessageBox.Show("同步错误");
            }
            BindWgd();
        }

        private void btn_SyncRF_Click(object sender, EventArgs e)
        {
            if (dtRF != null && dtRF.Rows.Count > 0)
            {
                WaitingFrom.ShowWait("");
                for (int i = 0; i < dtRF.Rows.Count; i++)
                {
                    dal_Interface_FR.TbKCList("", "", "", dtRF.Rows[i]["WGDH"].ToString(), "", "", "");
                    bll_TRC_ROLL_WGD.UpdateUpLoadStatus(2, dtRF.Rows[i]["WGDH"].ToString());
                    UserLog.AddLog(RV.UI.UserInfo.menuName, this.Name, this.Text, dtRF.Rows[i]["WGDH"].ToString() + "同步条码数据，时间："+DateTime.Now.ToLongDateString());
                }
                WaitingFrom.CloseWait();
                MessageBox.Show("同步成功");
            }
            else
            {
                MessageBox.Show("同步失败");
            }

            BindWgdFinished();
        }
    }
}
