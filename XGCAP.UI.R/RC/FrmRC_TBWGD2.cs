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

namespace XGCAP.UI.R.RC
{
    public partial class FrmRC_TBWGD2 : Form
    {
        public FrmRC_TBWGD2()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staID = bll_TB_STA.GetStaIdByCode(arr[0]);
            slbwhCode = arr[1];
        }

        string staID = "";//轧线工位ID
        string slbwhCode = "";//待轧钢坯仓库库位编码
        Bll_TRC_ROLL_WGD bll_TRC_ROLL_WGD = new Bll_TRC_ROLL_WGD();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TRP_PLAN_ROLL bll_TRP_PLAN_ROLL = new Bll_TRP_PLAN_ROLL();
        Bll_TB_MATRL_MAIN bll_TB_MATRL_MAIN = new Bll_TB_MATRL_MAIN();
        Bll_Interface_NC_Roll_A1 bll_Interface_NC_Roll_A1 = new Bll_Interface_NC_Roll_A1();
        Bll_Interface_NC_Roll_A2 bll_Interface_NC_Roll_A2 = new Bll_Interface_NC_Roll_A2();
        Bll_Interface_NC_Roll_A3 bll_Interface_NC_Roll_A3 = new Bll_Interface_NC_Roll_A3();
        Bll_Interface_NC_Roll_A4 bll_Interface_NC_Roll_A4 = new Bll_Interface_NC_Roll_A4();
        Bll_Interface_NC_Roll_46 bll_Interface_NC_Roll_46 = new Bll_Interface_NC_Roll_46();
        Bll_TRC_ROLL_MAIN bll_TRC_ROLL_MAIN = new Bll_TRC_ROLL_MAIN();
        Bll_TRC_WARM_FURNACE bll_TRC_WARM_FURNACE = new Bll_TRC_WARM_FURNACE();
        Bll_TB_STD_CONFIG bll_TB_STD_CONFIG = new Bll_TB_STD_CONFIG();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        Bll_TRC_ROLL_WGD_HANDLER bll_TRC_ROLL_WGD_HANDLER = new Bll_TRC_ROLL_WGD_HANDLER();
        Bll_TPB_LINEWH bll_TPB_LINEWH = new Bll_TPB_LINEWH();
        Bll_TQB_CHECKSTATE bll_TQB_CHECKSTATE = new Bll_TQB_CHECKSTATE();
        Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();
        Bll_TRP_PLAN_ROLL_ITEM bllPlanRollItem = new Bll_TRP_PLAN_ROLL_ITEM();
        Bll_TRP_WGD_ITEMINFO bllTrpWgdItemInfo = new Bll_TRP_WGD_ITEMINFO();
        Bll_TRP_PLAN_ROLL_ITEM_INFO bllPlanRollItemInfo = new Bll_TRP_PLAN_ROLL_ITEM_INFO();

        private void btn_QueryNC_Click(object sender, EventArgs e)
        {
            BindWgd();
        }

        public void BindWgd()
        {
            string sqlWhere = "   N_SCRF=2  AND N_IF_EXEC_STATUS>1 AND C_STA_ID='" + staID + "'      ";
            this.gc_NC.DataSource = bll_TRC_ROLL_WGD.GetList(sqlWhere).Tables[0];
            gv_NC.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_NC);
        }

        private void FrmRC_TBWGD2_Load(object sender, EventArgs e)
        {
            BindWgd();
        }

        private void gv_NC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_NC.GetDataRow(gv_NC.FocusedRowHandle);
                if (dr != null)
                {
                    BtnEnabled(dr["N_IF_EXEC_STATUS"].ToString());
                    this.gridControl2.DataSource = bll_TRC_ROLL_WGD.GetSyncDetail(dr["C_BATCH_NO"].ToString());
                    gridView2.BestFitColumns();
                    SetGridViewRowNum.SetRowNum(gridView2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void BtnEnabled(string status)
        {
            this.btn_A2.Enabled = false;
            this.btn_A3.Enabled = false;
            this.btn_A4.Enabled = false;
            this.btn_46.Enabled = false;

            if (status == "2")
                this.btn_A2.Enabled = true;
            else if (status == "3")
                this.btn_A3.Enabled = true;
            else if (status == "4")
                this.btn_A4.Enabled = true;
            else if (status == "5")
                this.btn_46.Enabled = true;
        }

        private void btn_A2_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认同步吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            NcRollA1 ncA1 = new NcRollA1();
            NcRollA2 ncA2 = new NcRollA2();
            NcRollA3 ncA3 = new NcRollA3();
            NcRollA4 ncA4 = new NcRollA4();
            int errorStatus = 2;
            string errorId = "";

            try
            {
                int selectedPlanHandle = this.gv_NC.FocusedRowHandle;//获取计划焦点行索引
                int selectedAllowGrd = this.gv_NC.FocusedRowHandle;//获取可轧钢种焦点行索引
                if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
                {
                    MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                    return;
                }
                string id = this.gv_NC.GetRowCellValue(selectedPlanHandle, "C_MAIN_ID").ToString();//获取焦点
                errorId = id;
                var wgd = bll_TRC_ROLL_WGD.GetModel(id, 1);
                var plan = bllPlanRollItem.GetModel_Item(wgd.C_PLAN_ID);
                if (plan.N_IS_MERGE == 1)
                {
                    var wgdItemInfo = bllTrpWgdItemInfo.GetModelItem(wgd.C_MAIN_ID);
                    Mod_TRP_PLAN_ROLL_ITEM_INFO modPlan = bllPlanRollItemInfo.GetModel(wgdItemInfo.C_ITEM_INFO_ID);
                    var a1Sta = bll_TB_STA.GetModel(modPlan.C_STA_ID);
                    ncA1.bmid = "1001NC10000000000345";
                    ncA1.jhrq = DateTime.Parse(modPlan.D_P_START_TIME == null ? DateTime.Now.ToString() : modPlan.D_P_START_TIME.ToString());
                    ncA1.jhxxsl = modPlan.N_WGT.ToString();
                    var matrl = bll_TB_MATRL_MAIN.GetModel(modPlan.C_MAT_CODE);
                    ncA1.jhyid = matrl.C_PLANEMP;
                    ncA1.jldwid = matrl.C_PK_MEASDOC;
                    ncA1.pk_produce = matrl.C_PK_PRODUCE;
                    ncA1.scbmid = a1Sta.C_SSBMID;
                    ncA1.shrid = "1006AA100000000ERS2A";//plan.C_EMP_ID;
                    ncA1.shrq = DateTime.Parse(modPlan.D_P_START_TIME == null ? DateTime.Now.ToString() : modPlan.D_P_START_TIME.ToString());
                    ncA1.slrq = DateTime.Parse(modPlan.D_NEED_DT == null ? DateTime.Now.ToString() : modPlan.D_NEED_DT.ToString());
                    ncA1.wlbmid = matrl.C_PK_INVBASDOC;
                    ncA1.xdrq = DateTime.Parse(modPlan.D_P_START_TIME == null ? DateTime.Now.ToString() : modPlan.D_P_START_TIME.ToString());
                    ncA1.xqrq = DateTime.Parse(modPlan.D_DELIVERY_DT == null ? DateTime.Now.ToString() : modPlan.D_DELIVERY_DT.ToString());
                    ncA1.xqsl = modPlan.N_WGT.ToString();
                    ncA1.zdrq = DateTime.Now;
                    ncA1.zyx1 = modPlan.C_FREE_TERM;
                    ncA1.zyx2 = modPlan.C_FREE_TERM2;
                    ncA1.zyx3 = modPlan.C_PACK;
                    ncA1.zyx5 = modPlan.C_PLAN_ROLL_ID;
                    ncA1.jhfaid = matrl.C_PK_PSID;
                    ncA1.memo = modPlan.C_AREA;
                    string a1Name = modPlan.C_PLAN_ROLL_ID + "_A1.xml";
                    var resultA1 = bll_Interface_NC_Roll_A1.SendXml_ROLL_A1("", a1Name, ncA1, Application.StartupPath);
                    if (resultA1[0] != "1")
                    {
                        bll_TRC_ROLL_WGD.UpdateIfStatus(1, id, resultA1[1]);
                        //continue;
                    }

                    DataTable factDt2 = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                    for (int j = 0; j < factDt2.Rows.Count; j++)
                    {
                        string slabWh = bll_TPB_LINEWH.GetList_id(factDt2.Rows[j]["C_LINEWH_CODE"].ToString()).ToString();
                        if (string.IsNullOrEmpty(slabWh))
                        {
                            MessageBox.Show("线材无仓库");
                            return;
                        }
                    }

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
                    ncA2.freeitemvalue1 = modPlan.C_FREE_TERM;
                    ncA2.freeitemvalue2 = modPlan.C_FREE_TERM2;
                    ncA2.freeitemvalue3 = modPlan.C_PACK;
                    ncA2.zdrid = RV.UI.UserInfo.userAccount;
                    ncA2.freeitemvalue5 = modPlan.C_PLAN_ROLL_ID;
                    string a2Name = Guid.NewGuid() + "_A2.xml";
                    if (bll_TRC_ROLL_WGD.IsA2Repeat(main.C_BATCH_NO, "") > 0)
                    {
                        return;
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
                    ncA3.hfreeitemvalue1 = modPlan.C_FREE_TERM;
                    ncA3.hfreeitemvalue2 = modPlan.C_FREE_TERM2;
                    ncA3.hfreeitemvalue3 = modPlan.C_PACK;

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
                        return;
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
                        return;
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

                    if (bll_TRC_ROLL_WGD.Is46Repeat(main.C_BATCH_NO, "") > 0)
                    {
                        return;
                    }

                    string a46Name = Guid.NewGuid() + "_A46.xml";

                    var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, Application.StartupPath);
                    if (resultA46[0] != "1")
                    {
                        bll_TRC_ROLL_WGD.UpdateIfStatus(5, id, resultA46[1]);
                    }

                    bll_TRC_ROLL_WGD.UpdateRollPlanItemWgt(modPlan.C_ID, wgdWgt);

                    if (bll_TRC_ROLL_WGD.UpdateUpLoadStatus(3, id) > 0)
                        MessageBox.Show("同步成功");
                }
                else
                {
                    var a1Sta = bll_TB_STA.GetModel(plan.C_STA_ID);
                    var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                    var main = bll_TRC_ROLL_MAIN.GetModel(id);
                    var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);

                    ncA1.bmid = "1001NC10000000000345";
                    ncA1.jhrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                    ncA1.jhxxsl = plan.N_WGT.ToString();
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
                    for (int j = 0; j < factDt2.Rows.Count; j++)
                    {
                        string slabWh = bll_TPB_LINEWH.GetList_id(factDt2.Rows[j]["C_LINEWH_CODE"].ToString()).ToString();
                        if (string.IsNullOrEmpty(slabWh))
                        {
                            MessageBox.Show("线材无仓库");
                            return;
                        }
                    }

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
                        return;
                    }
                    var resultA2 = bll_Interface_NC_Roll_A2.SendXml_ROLL_A2("", a2Name, ncA2, Application.StartupPath);
                    if (resultA2[0] != "1")
                    {
                        bll_TRC_ROLL_WGD.UpdateIfStatus(2, id, resultA2[1]);
                        MessageBox.Show("同步失败");
                        return;
                    }

                    if (main.N_WGT_EXIT == 0)
                    {
                        if (bll_TRC_ROLL_WGD.UpdateUpLoadStatus(3, id) > 0)
                            MessageBox.Show("同步成功");
                        return;
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
                        return;
                    }
                    var resultA3 = bll_Interface_NC_Roll_A3.SendXml_ROLL_A3("", a3Name, ncA3, Application.StartupPath);
                    if (resultA3[0] != "1")
                    {
                        bll_TRC_ROLL_WGD.UpdateIfStatus(3, id, resultA3[1]);
                        MessageBox.Show("同步失败");
                        return;
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
                        return;
                    }
                    var resultA4 = bll_Interface_NC_Roll_A4.SendXml_ROLL_A4("", a4Name, ncA4, Application.StartupPath);
                    if (resultA4[0] != "1")
                    {
                        bll_TRC_ROLL_WGD.UpdateIfStatus(4, id, resultA4[1]);
                        MessageBox.Show("同步失败");
                        return;
                    }
                    errorStatus = 5;
                    DataTable factDt = factDt = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                    List<NcRoll46> nc46s = new List<NcRoll46>();
                    decimal wgdWgt = 0;
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
                    if (bll_TRC_ROLL_WGD.Is46Repeat(main.C_BATCH_NO, "") > 0)
                    {
                        return;
                    }
                    var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, Application.StartupPath);
                    if (resultA46[0] != "1")
                    {
                        bll_TRC_ROLL_WGD.UpdateIfStatus(5, id, resultA46[1]);
                        MessageBox.Show("同步失败");
                        return;
                    }

                    bll_TRC_ROLL_WGD.UpdateRollPlanItemWgt(plan.C_ID, wgdWgt);

                    if (bll_TRC_ROLL_WGD.UpdateUpLoadStatus(3, id) > 0)
                        MessageBox.Show("同步成功");
                }
            }
            catch (Exception ex)
            {
                bll_TRC_ROLL_WGD.UpdateIfStatus(errorStatus, errorId, ex.Message);
                MessageBox.Show("同步失败");
                BindWgd();
            }
            BindWgd();
        }

        private void btn_A3_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认同步吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            NcRollA1 ncA1 = new NcRollA1();
            NcRollA2 ncA2 = new NcRollA2();
            NcRollA3 ncA3 = new NcRollA3();
            NcRollA4 ncA4 = new NcRollA4();
            int errorStatus = 3;
            string errorId = "";

            try
            {
                int selectedPlanHandle = this.gv_NC.FocusedRowHandle;//获取计划焦点行索引
                int selectedAllowGrd = this.gv_NC.FocusedRowHandle;//获取可轧钢种焦点行索引
                if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
                {
                    MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                    return;
                }
                string id = this.gv_NC.GetRowCellValue(selectedPlanHandle, "C_MAIN_ID").ToString();//获取焦点
                errorId = id;
                var wgd = bll_TRC_ROLL_WGD.GetModel(id, 1);

                var plan = bllPlanRollItem.GetModel_Item(wgd.C_PLAN_ID);
                var roll = bll_TRC_ROLL_MAIN.GetModel(wgd.C_MAIN_ID);
                var a1Sta = bll_TB_STA.GetModel(plan.C_STA_ID);
                var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                var matrl2 = bll_TB_MATRL_MAIN.GetModel(roll.C_MAT_SLAB_CODE);
                var main = bll_TRC_ROLL_MAIN.GetModel(id);
                var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);

                DataTable factDt2 = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                for (int j = 0; j < factDt2.Rows.Count; j++)
                {
                    string slabWh = bll_TPB_LINEWH.GetList_id(factDt2.Rows[j]["C_LINEWH_CODE"].ToString()).ToString();
                    if (string.IsNullOrEmpty(slabWh))
                    {
                        MessageBox.Show("线材无仓库");
                        return;
                    }
                }

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
                    return;
                }
                var resultA3 = bll_Interface_NC_Roll_A3.SendXml_ROLL_A3("", a3Name, ncA3, Application.StartupPath);
                if (resultA3[0] != "1")
                {
                    bll_TRC_ROLL_WGD.UpdateIfStatus(3, id, resultA3[1]);
                    MessageBox.Show("同步失败");
                    return;
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
                    return;
                }
                var resultA4 = bll_Interface_NC_Roll_A4.SendXml_ROLL_A4("", a4Name, ncA4, Application.StartupPath);
                if (resultA4[0] != "1")
                {
                    bll_TRC_ROLL_WGD.UpdateIfStatus(4, id, resultA4[1]);
                    MessageBox.Show("同步失败");
                    return;
                }

                errorStatus = 5;
                DataTable factDt = factDt = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                List<NcRoll46> nc46s = new List<NcRoll46>();
                decimal wgdWgt = 0;
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
                if (bll_TRC_ROLL_WGD.Is46Repeat(main.C_BATCH_NO, "") > 0)
                {
                    return;
                }
                var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, Application.StartupPath);
                if (resultA46[0] != "1")
                {
                    bll_TRC_ROLL_WGD.UpdateIfStatus(5, id, resultA46[1]);
                    MessageBox.Show("同步失败");
                    return;
                }

                bll_TRC_ROLL_WGD.UpdateRollPlanItemWgt(plan.C_ID, wgdWgt);

                if (bll_TRC_ROLL_WGD.UpdateUpLoadStatus(3, id) > 0)
                    MessageBox.Show("同步成功");
            }
            catch (Exception ex)
            {
                bll_TRC_ROLL_WGD.UpdateIfStatus(errorStatus, errorId, ex.Message);
                MessageBox.Show("同步失败");
                BindWgd();
            }
            BindWgd();
        }

        private void btn_A4_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认同步吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            NcRollA1 ncA1 = new NcRollA1();
            NcRollA2 ncA2 = new NcRollA2();
            NcRollA3 ncA3 = new NcRollA3();
            NcRollA4 ncA4 = new NcRollA4();
            int errorStatus = 4;
            string errorId = "";


            try
            {
                int selectedPlanHandle = this.gv_NC.FocusedRowHandle;//获取计划焦点行索引
                int selectedAllowGrd = this.gv_NC.FocusedRowHandle;//获取可轧钢种焦点行索引
                if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
                {
                    MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                    return;
                }
                string id = this.gv_NC.GetRowCellValue(selectedPlanHandle, "C_MAIN_ID").ToString();//获取焦点
                errorId = id;
                var wgd = bll_TRC_ROLL_WGD.GetModel(id, 1);
                var plan = bllPlanRollItem.GetModel_Item(wgd.C_PLAN_ID);
                var a1Sta = bll_TB_STA.GetModel(plan.C_STA_ID);
                var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                var main = bll_TRC_ROLL_MAIN.GetModel(id);
                var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);

                DataTable factDt2 = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                for (int j = 0; j < factDt2.Rows.Count; j++)
                {
                    string slabWh = bll_TPB_LINEWH.GetList_id(factDt2.Rows[j]["C_LINEWH_CODE"].ToString()).ToString();
                    if (string.IsNullOrEmpty(slabWh))
                    {
                        MessageBox.Show("线材无仓库");
                        return;
                    }
                }

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
                    return;
                }
                var resultA4 = bll_Interface_NC_Roll_A4.SendXml_ROLL_A4("", a4Name, ncA4, Application.StartupPath);
                if (resultA4[0] != "1")
                {
                    bll_TRC_ROLL_WGD.UpdateIfStatus(4, id, resultA4[1]);
                    MessageBox.Show("同步失败");
                    return;
                }

                errorStatus = 5;
                DataTable factDt = factDt = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                List<NcRoll46> nc46s = new List<NcRoll46>();
                decimal wgdWgt = 0;
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
                if (bll_TRC_ROLL_WGD.Is46Repeat(main.C_BATCH_NO, "") > 0)
                {
                    return;
                }
                var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, Application.StartupPath);
                if (resultA46[0] != "1")
                {
                    bll_TRC_ROLL_WGD.UpdateIfStatus(5, id, resultA46[1]);
                    MessageBox.Show("同步失败");
                    return;
                }

                bll_TRC_ROLL_WGD.UpdateRollPlanItemWgt(plan.C_ID, wgdWgt);

                if (bll_TRC_ROLL_WGD.UpdateUpLoadStatus(3, id) > 0)
                    MessageBox.Show("同步成功");
            }
            catch (Exception ex)
            {
                bll_TRC_ROLL_WGD.UpdateIfStatus(errorStatus, errorId, ex.Message);
                MessageBox.Show("同步失败");
                BindWgd();
            }
            BindWgd();
        }

        private void btn_46_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认同步吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            NcRollA1 ncA1 = new NcRollA1();
            NcRollA2 ncA2 = new NcRollA2();
            NcRollA3 ncA3 = new NcRollA3();
            NcRollA4 ncA4 = new NcRollA4();
            int errorStatus = 5;
            string errorId = "";

            try
            {
                int selectedPlanHandle = this.gv_NC.FocusedRowHandle;//获取计划焦点行索引
                int selectedAllowGrd = this.gv_NC.FocusedRowHandle;//获取可轧钢种焦点行索引
                if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
                {
                    MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                    return;
                }
                string id = this.gv_NC.GetRowCellValue(selectedPlanHandle, "C_MAIN_ID").ToString();//获取焦点
                errorId = id;
                var wgd = bll_TRC_ROLL_WGD.GetModel(id, 1);
                var plan = bllPlanRollItem.GetModel_Item(wgd.C_PLAN_ID);
                var a1Sta = bll_TB_STA.GetModel(plan.C_STA_ID);
                var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                var main = bll_TRC_ROLL_MAIN.GetModel(id);
                var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);

                DataTable factDt2 = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                for (int j = 0; j < factDt2.Rows.Count; j++)
                {
                    string slabWh = bll_TPB_LINEWH.GetList_id(factDt2.Rows[j]["C_LINEWH_CODE"].ToString()).ToString();
                    if (string.IsNullOrEmpty(slabWh))
                    {
                        MessageBox.Show("线材无仓库");
                        return;
                    }
                }

                DataTable factDt = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                List<NcRoll46> nc46s = new List<NcRoll46>();
                decimal wgdWgt = 0;
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
                if (bll_TRC_ROLL_WGD.Is46Repeat(main.C_BATCH_NO, "") > 0)
                {
                    return;
                }
                var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, Application.StartupPath);
                if (resultA46[0] != "1")
                {
                    bll_TRC_ROLL_WGD.UpdateIfStatus(5, id, resultA46[1]);
                    MessageBox.Show("同步失败");
                    return;
                }

                bll_TRC_ROLL_WGD.UpdateRollPlanItemWgt(plan.C_ID, wgdWgt);

                if (bll_TRC_ROLL_WGD.UpdateUpLoadStatus(3, id) > 0)
                    MessageBox.Show("同步成功");
            }
            catch (Exception ex)
            {
                bll_TRC_ROLL_WGD.UpdateIfStatus(errorStatus, errorId, ex.Message);
                MessageBox.Show("同步失败");
                BindWgd();
            }
            BindWgd();
        }

        private void gv_NC_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_NC.GetDataRow(gv_NC.FocusedRowHandle);
                if (dr != null)
                {
                    BtnEnabled(dr["N_IF_EXEC_STATUS"].ToString());
                    this.gridControl2.DataSource = bll_TRC_ROLL_WGD.GetSyncDetail(dr["C_BATCH_NO"].ToString());
                    gridView2.BestFitColumns();
                    SetGridViewRowNum.SetRowNum(gridView2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
