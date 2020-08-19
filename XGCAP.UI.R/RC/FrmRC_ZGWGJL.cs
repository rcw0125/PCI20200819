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

namespace XGCAP.UI.R.RP
{
    public partial class FrmRC_ZGWGJL : Form
    {
        public FrmRC_ZGWGJL()
        {
            InitializeComponent();
            staID = bll_TB_STA.GetStaIdByCode(RV.UI.QueryString.parameter);
            staCode = RV.UI.QueryString.parameter;
        }

        string staID = "";//轧线工位ID
        private string staCode = "";

        CommonSub sub = new CommonSub();
        Bll_TRC_ROLL_WGD bll_TRC_ROLL_WGD = new Bll_TRC_ROLL_WGD();
        Bll_TRC_ROLL_MAIN bll_TRC_ROLL_MAIN = new Bll_TRC_ROLL_MAIN();
        Bll_Interface_NC_Roll_A1 bll_Interface_NC_Roll_A1 = new Bll_Interface_NC_Roll_A1();
        Bll_Interface_NC_Roll_A2 bll_Interface_NC_Roll_A2 = new Bll_Interface_NC_Roll_A2();
        Bll_Interface_NC_Roll_A3 bll_Interface_NC_Roll_A3 = new Bll_Interface_NC_Roll_A3();
        Bll_Interface_NC_Roll_A4 bll_Interface_NC_Roll_A4 = new Bll_Interface_NC_Roll_A4();
        Bll_Interface_NC_Roll_46 bll_Interface_NC_Roll_46 = new Bll_Interface_NC_Roll_46();
        Bll_TRP_PLAN_ROLL_ITEM bllPlanRollItem = new Bll_TRP_PLAN_ROLL_ITEM();
        Bll_TB_MATRL_MAIN bll_TB_MATRL_MAIN = new Bll_TB_MATRL_MAIN();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();
        Bll_TPB_LINEWH bll_TPB_LINEWH = new Bll_TPB_LINEWH();
        Bll_TQB_CHECKSTATE bll_TQB_CHECKSTATE = new Bll_TQB_CHECKSTATE();
        Bll_TRC_WARM_FURNACE bll_TRC_WARM_FURNACE = new Bll_TRC_WARM_FURNACE();
        Bll_TB_STD_CONFIG bll_TB_STD_CONFIG = new Bll_TB_STD_CONFIG();
        Bll_TRC_ROLL_WGD_HANDLER bll_TRC_ROLL_WGD_HANDLER = new Bll_TRC_ROLL_WGD_HANDLER();


        private void FrmRC_ZGWGJL_Load(object sender, EventArgs e)
        {
            dt_Time.DateTime = DateTime.Now.AddDays(-2);
            dt_TimeE.DateTime = DateTime.Now.AddDays(1);
            BindAssePutStoreData();
            BindWGDData();
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            sub.ImageComboBoxEditBindNCBC(cbo_BC, staCode);
            sub.ImageComboBoxEditBindNCBZ(cbo_BZ, staCode);
            sub.BCBZBindEdit(cbo_BC, cbo_BZ, staCode);
            Remind();
        }

        private void Remind()
        {
            string result = bll_TRC_ROLL_WGD.GetNotUpLoadWgdCount(staID).ToString();
            if (result != "0")
            {
                this.sync_Info.Text = string.Format("有{0}条完工单记录未上传NC，请联系系统管理员！", result);
                //this.btn_SL.Enabled = false;
            }
            else
            {
                this.sync_Info.Text = "";
                // this.btn_SL.Enabled = true;
            }
        }

        /// <summary>
        /// 绑定轧钢所有已完成组坯出炉记录
        /// </summary>
        public void BindAssePutStoreData()
        {
            this.gc_ZGWGD.DataSource = null;
            string whereSql = "";//"  AND  TRM.N_QUA_TOTAL_VIRTUAL=TRM.N_QUA_EXIT ";
            whereSql += " AND TRM.C_STA_ID = '" + staID + "' ";
            //if (!string.IsNullOrWhiteSpace(this.txt_Stove.Text))
            //    whereSql += " AND TRM.C_BATCH_NO='" + this.txt_Stove.Text + "'   ";
            DataTable dt = bll_TRC_ROLL_WGD.GetAssePutStoreData(whereSql, true).Tables[0];
            this.gc_ZGWGD.DataSource = dt;
            this.gv_ZGWGD.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_ZGWGD);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                if (dr != null)
                {
                    int num = Convert.ToInt32(dr["N_QUA_EXIT"] == DBNull.Value ? 0 : dr["N_QUA_EXIT"]);
                    txt_HGZS.Text = num.ToString();
                    object obj = bll_TRC_ROLL_WGD.GetOutTime(dr["C_ID"].ToString());
                    dt_ExecStart.DateTime = obj == null ? DateTime.Now : DateTime.Parse(obj.ToString());
                    this.dt_ExecEnd.DateTime = DateTime.Now;
                }
            }
            txt_CastOff.Text = "0";
            txt_Cutting.Text = "0";
        }

        /// <summary>
        /// 绑定完工单
        /// </summary>
        public void BindWGDData()
        {
            this.gc_WGD.DataSource = null;
            DataTable dt = bll_TRC_ROLL_WGD.GetWgdData(staID, dt_Time.DateTime, dt_TimeE.DateTime, txt_UpStove.Text).Tables[0];
            this.gc_WGD.DataSource = dt;
            this.gv_WGD.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_WGD);
            Remind();
        }

        private void btn_SL_Click(object sender, EventArgs e)
        {

            WaitingFrom.ShowWait("");

            string strMenuName = RV.UI.UserInfo.menuName;

            UserLog.AddLog(strMenuName, this.Name + "生产实绩", "生产实绩", "完工记录");//添加操作日志

            int compareDt = DateTime.Compare(this.dt_ExecStart.DateTime, this.dt_ExecEnd.DateTime);
            if (this.dt_ExecStart.DateTime == DateTime.MinValue || this.dt_ExecEnd.DateTime == DateTime.MinValue)
            {
                MessageBox.Show("日期错误!");
                BindAssePutStoreData();
            }

            if (compareDt > 0)
            {
                MessageBox.Show("日期错误!");
                return;
            }

            int errorNum = 0;//TryParse 输出参数
                             //撤回支数
                             //string num = this.txt_HGZS.Text.Trim();
                             //if (!Int32.TryParse(num, out errorNum))
                             //{
                             //    MessageBox.Show("完工支数只能是整数!");
                             //    return;
                             //}


            //if (int.Parse(num) <= 0)
            //{
            //    MessageBox.Show("完工支数不能小于0");
            //    return;
            //}

            string whereSql = " AND TRM.C_STA_ID = '" + staID + "' ";
            DataTable dt = bll_TRC_ROLL_WGD.GetAssePutStoreData(whereSql, true).Tables[0];
            if (DialogResult.No == MessageBox.Show("确认完工吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                string stove = dt.Rows[0]["C_STOVE"].ToString();
                string batchNo = dt.Rows[0]["C_BATCH_NO"].ToString();
                string planID = dt.Rows[0]["C_PLAN_ID"].ToString();
                decimal wgt = 2;
                string grd = dt.Rows[0]["C_STL_GRD"].ToString();
                string spec = dt.Rows[0]["C_SPEC"].ToString();
                string std = dt.Rows[0]["C_STD_CODE"].ToString();
                string ids = dt.Rows[0]["C_ID"].ToString();
                string qua = dt.Rows[0]["N_QUA_EXIT"].ToString();
                DateTime start = dt_ExecStart.DateTime;
                DateTime end = dt_ExecEnd.DateTime;
                string shift = cbo_BC.EditValue.ToString();
                string group = cbo_BZ.EditValue.ToString();
                string shiftName = cbo_BC.Text;
                string groupName = cbo_BZ.Text;
                string castOffQua = txt_CastOff.Text;
                string cuttingQua = txt_Cutting.Text;
                string result = bll_TRC_ROLL_WGD.WgdHandler(stove, batchNo, planID, int.Parse(qua), wgt, grd, spec, std, ids, staID, start, end, shift, group, shiftName, groupName
                    , castOffQua, cuttingQua);


                if (result == "1")
                {
                    BindAssePutStoreData();
                    BindWGDData();
                    MessageBox.Show("操作成功!");
                    //#region 同步完工单
                    //string sqlWhere = @"   N_SCRF=2  
                                                 
                    //                              AND  C_STA_ID='" + staID + "'         ";
                    //var dtNC = bll_TRC_ROLL_WGD.GetList(sqlWhere).Tables[0];

                    //NcRollA1 ncA1 = new NcRollA1();
                    //NcRollA2 ncA2 = new NcRollA2();
                    //NcRollA3 ncA3 = new NcRollA3();
                    //NcRollA4 ncA4 = new NcRollA4();
                    //int errorStatus = 1;
                    //string errorId = "";

                    //if (dtNC != null && dtNC.Rows.Count > 0)
                    //{
                    //    for (int i = 0; i < dtNC.Rows.Count; i++)
                    //    {
                    //        string id = dtNC.Rows[i]["C_MAIN_ID"].ToString();
                    //        errorId = id;
                    //        var wgd = bll_TRC_ROLL_WGD.GetModel(id, 1);
                    //        var plan = bllPlanRollItem.GetModel_Item(wgd.C_PLAN_ID);
                    //        var a1Sta = bll_TB_STA.GetModel(plan.C_STA_ID);
                    //        ncA1.bmid = "1001NC10000000000345";
                    //        ncA1.jhrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                    //        ncA1.jhxxsl = plan.N_WGT.ToString();
                    //        var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
                    //        ncA1.jhyid = matrl.C_PLANEMP;
                    //        ncA1.jldwid = matrl.C_PK_MEASDOC;
                    //        ncA1.pk_produce = matrl.C_PK_PRODUCE;
                    //        ncA1.scbmid = a1Sta.C_SSBMID;
                    //        ncA1.shrid = "1006AA100000000ERS2A";//plan.C_EMP_ID;
                    //        ncA1.shrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                    //        ncA1.slrq = DateTime.Parse(plan.D_NEED_DT == null ? DateTime.Now.ToString() : plan.D_NEED_DT.ToString());
                    //        ncA1.wlbmid = matrl.C_PK_INVBASDOC;
                    //        ncA1.xdrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
                    //        ncA1.xqrq = DateTime.Parse(plan.D_DELIVERY_DT == null ? DateTime.Now.ToString() : plan.D_DELIVERY_DT.ToString());
                    //        ncA1.xqsl = plan.N_WGT.ToString();
                    //        ncA1.zdrq = DateTime.Now;
                    //        ncA1.zyx1 = plan.C_FREE_TERM;
                    //        ncA1.zyx2 = plan.C_FREE_TERM2;
                    //        ncA1.zyx3 = plan.C_PACK;
                    //        ncA1.zyx5 = plan.C_ID;
                    //        ncA1.jhfaid = matrl.C_PK_PSID;
                    //        string a1Name = plan.C_ID + "_A1.xml";
                    //        var resultA1 = bll_Interface_NC_Roll_A1.SendXml_ROLL_A1("", a1Name, ncA1, Application.StartupPath);
                    //        if (resultA1[0] != "1")
                    //        {
                    //            bll_TRC_ROLL_WGD.UpdateIfStatus(1, id, resultA1[1]);
                    //            //continue;
                    //        }

                    //        DataTable factDt2 = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                    //        bool bol = false;
                    //        for (int j = 0; j < factDt2.Rows.Count; j++)
                    //        {
                    //            string slabWh = bll_TPB_LINEWH.GetList_id(factDt2.Rows[j]["C_LINEWH_CODE"].ToString()).ToString();
                    //            if (string.IsNullOrEmpty(slabWh))
                    //            {
                    //                bol = true;
                    //                break;
                    //            }
                    //        }

                    //        if (bol)
                    //            continue;

                    //        errorStatus = 2;
                    //        var main = bll_TRC_ROLL_MAIN.GetModel(id);
                    //        var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);
                    //        var matrl2 = bll_TB_MATRL_MAIN.GetModel(main.C_MAT_SLAB_CODE);
                    //        ncA2.wlbmid = matrl.C_PK_INVBASDOC;
                    //        ncA2.pk_produce = matrl.C_PK_PRODUCE;
                    //        ncA2.invcode = matrl.C_ID;
                    //        ncA2.pch = main.C_BATCH_NO;
                    //        ncA2.scbmid = a2Sta.C_SSBMID;
                    //        ncA2.gzzxid = a2Sta.C_ERP_PK;
                    //        ncA2.bcid = wgd.C_PRODUCE_SHIFT;
                    //        ncA2.bzid = wgd.C_PRODUCE_GROUP;
                    //        ncA2.jhkgrq = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                    //        ncA2.jhwgrq = DateTime.Parse(wgd.D_PRODUCE_DATE_E == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_E.ToString());
                    //        ncA2.jhkssj = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                    //        ncA2.jhjssj = DateTime.Parse(wgd.D_PRODUCE_DATE_E == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_E.ToString());
                    //        ncA2.sjkgrq = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                    //        ncA2.sjwgrq = DateTime.Parse(wgd.D_PRODUCE_DATE_E == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_E.ToString());
                    //        ncA2.sjkssj = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                    //        ncA2.sjjssj = DateTime.Parse(wgd.D_PRODUCE_DATE_E == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_E.ToString());
                    //        ncA2.jhwgsl = main.N_WGT_EXIT == 0 ? main.N_WGT_ELIM.ToString() : main.N_WGT_EXIT.ToString();
                    //        ncA2.fjhsl = main.N_QUA_EXIT == 0 ? main.N_QUA_ELIM.ToString() : main.N_QUA_EXIT.ToString();
                    //        ncA2.jldwid = matrl.C_PK_MEASDOC;
                    //        ncA2.fjlid = matrl.C_FJLDW;
                    //        ncA2.sjwgsl = (main.N_WGT_TOTAL_VIRTUAL - main.N_WGT_TOTAL).ToString();
                    //        ncA2.freeitemvalue1 = plan.C_FREE_TERM;
                    //        ncA2.freeitemvalue2 = plan.C_FREE_TERM2;
                    //        ncA2.freeitemvalue3 = plan.C_PACK;
                    //        ncA2.zdrid = RV.UI.UserInfo.userAccount;
                    //        ncA2.freeitemvalue5 = plan.C_ID;
                    //        string a2Name = Guid.NewGuid() + "_A2.xml";
                    //        if (bll_TRC_ROLL_WGD.IsA2Repeat(wgd.C_BATCH_NO, "") > 0)
                    //        {
                    //        }
                    //        var resultA2 = bll_Interface_NC_Roll_A2.SendXml_ROLL_A2("", a2Name, ncA2, Application.StartupPath);
                    //        if (resultA2[0] != "1")
                    //        {
                    //            bll_TRC_ROLL_WGD.UpdateIfStatus(1, id, resultA2[1]);
                    //        }

                    //        if (main.N_WGT_EXIT == 0)
                    //        {
                    //            if (bll_TRC_ROLL_WGD.UpdateUpLoadStatus(3, id) > 0)
                    //                MessageBox.Show("同步成功");
                    //            return;
                    //        }

                    //        errorStatus = 3;
                    //        ncA3.hpch = main.C_BATCH_NO;
                    //        ncA3.hzdrid = RV.UI.UserInfo.userAccount;
                    //        ncA3.hwlbmid = matrl.C_PK_INVBASDOC;
                    //        ncA3.hjldwid = matrl.C_PK_MEASDOC;
                    //        ncA3.hzdrq = DateTime.Parse(wgd.D_MOD_DT == null ? DateTime.Now.ToString() : wgd.D_MOD_DT.ToString());
                    //        ncA3.hfreeitemvalue1 = plan.C_FREE_TERM;
                    //        ncA3.hfreeitemvalue2 = plan.C_FREE_TERM2;
                    //        ncA3.hfreeitemvalue3 = plan.C_PACK;

                    //        DataTable consumeDt = new DataTable();
                    //        DataTable a3Dt = bll_TRC_WARM_FURNACE.GetSlabMainInfo(wgd.C_MAIN_ID, out consumeDt);
                    //        DataTable a3DtZyx = bll_TB_STD_CONFIG.GetZYX(a3Dt.Rows[0]["C_STL_GRD"].ToString(), a3Dt.Rows[0]["C_STD_CODE"].ToString()).Tables[0];
                    //        var m = bll_TB_MATRL_MAIN.GetModel(a3Dt.Rows[0]["C_MAT_CODE"].ToString());
                    //        ncA3.kgyid = RV.UI.UserInfo.userAccount;
                    //        ncA3.ckckid = bll_TPB_SLABWH.GetList_id(a3Dt.Rows[0]["c_slabwh_code"].ToString());
                    //        ncA3.wlbmid = matrl2.C_PK_INVBASDOC;
                    //        ncA3.jldwid = matrl2.C_PK_MEASDOC;
                    //        ncA3.fjldwid = matrl2.C_FJLDW;
                    //        ncA3.ljcksl = a3Dt.Rows[0]["N_WGT"].ToString();
                    //        ncA3.fljcksl = a3Dt.Rows[0]["N_QUA"].ToString();
                    //        ncA3.pch = a3Dt.Rows[0]["C_BATCH_NO"].ToString() == "" ? a3Dt.Rows[0]["C_STOVE"].ToString() : a3Dt.Rows[0]["C_BATCH_NO"].ToString();
                    //        ncA3.gzzxid = a2Sta.C_ERP_PK;
                    //        ncA3.freeitemvalue1 = a3Dt.Rows[0]["C_ZYX1"].ToString();
                    //        ncA3.freeitemvalue2 = a3Dt.Rows[0]["C_ZYX2"].ToString();
                    //        object objOutTime = bll_TRC_WARM_FURNACE.GetOutTime(main.C_ID);
                    //        ncA3.flrq = DateTime.Parse(wgd.D_MOD_DT == null ? DateTime.Now.ToString() : wgd.D_MOD_DT.ToString()).ToString("yyyy-MM-dd");
                    //        string a3Name = Guid.NewGuid() + "_A3.xml";
                    //        if (bll_TRC_ROLL_WGD.IsA3Repeat(wgd.C_BATCH_NO, "") > 0)
                    //        {

                    //        }
                    //        var resultA3 = bll_Interface_NC_Roll_A3.SendXml_ROLL_A3("", a3Name, ncA3, Application.StartupPath);
                    //        if (resultA3[0] != "1")
                    //        {
                    //            bll_TRC_ROLL_WGD.UpdateIfStatus(1, id, resultA3[1]);
                    //        }
                    //        bll_TRC_WARM_FURNACE.ConsumeSlab(consumeDt);

                    //        errorStatus = 4;
                    //        DataTable a4FactDt = bll_TRC_ROLL_WGD.GetWgdFact(wgd.C_BATCH_NO, 1).Tables[0];
                    //        var a4M = bll_TB_MATRL_MAIN.GetModel(wgd.C_MAT_CODE);
                    //        var a4Sta = bll_TB_STA.GetModel(wgd.C_STA_ID);
                    //        ncA4.zdrid = RV.UI.UserInfo.userAccount;
                    //        ncA4.rq = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                    //        ncA4.gzzxbmid = a4Sta.C_STA_ERPCODE;
                    //        ncA4.scbmid = a4Sta.C_SSBMID;
                    //        ncA4.pch = wgd.C_BATCH_NO;
                    //        ncA4.wlbmid = a4M.C_PK_INVBASDOC;
                    //        ncA4.jldwid = a4M.C_PK_MEASDOC;
                    //        ncA4.gzzxid = a4Sta.C_ERP_PK;
                    //        ncA4.ccxh = wgd.C_BATCH_NO;
                    //        ncA4.pk_produce = a4M.C_PK_PRODUCE;
                    //        ncA4.ksrq = DateTime.Parse(wgd.D_PRODUCE_DATE_B == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_B.ToString());
                    //        ncA4.jsrq = DateTime.Parse(wgd.D_PRODUCE_DATE_E == null ? DateTime.Now.ToString() : wgd.D_PRODUCE_DATE_E.ToString());
                    //        ncA4.hgsl = a4FactDt.Rows[0]["WGT"].ToString();
                    //        ncA4.fhgsl = a4FactDt.Rows[0]["QUA"].ToString();
                    //        object wgdHandlerStatus = bll_TRC_ROLL_WGD_HANDLER.GetWgdHandlerStatus(wgd.C_ID);
                    //        if (wgdHandlerStatus != null)
                    //        {
                    //            string status = wgdHandlerStatus.ToString();
                    //            ncA4.sflfcp = int.Parse(status) == 2 ? "Y" : "N";
                    //            ncA4.sffsgp = int.Parse(status) == 2 ? "Y" : "N";
                    //        }
                    //        else
                    //        {
                    //            ncA4.sflfcp = "N";
                    //            ncA4.sffsgp = "N";
                    //        }
                    //        ncA4.freeitemvalue1 = wgd.C_FREE_TERM;
                    //        ncA4.freeitemvalue2 = wgd.C_FREE_TERM2;
                    //        ncA4.freeitemvalue3 = wgd.C_PACK;
                    //        string a4Name = Guid.NewGuid() + "_A4.xml";
                    //        if (bll_TRC_ROLL_WGD.IsA4Repeat(wgd.C_BATCH_NO, "") > 0)
                    //        {

                    //        }
                    //        var resultA4 = bll_Interface_NC_Roll_A4.SendXml_ROLL_A4("", a4Name, ncA4, Application.StartupPath);
                    //        if (resultA4[0] != "1")
                    //        {
                    //            bll_TRC_ROLL_WGD.UpdateIfStatus(1, id, resultA4[1]);
                    //        }

                    //        errorStatus = 5;
                    //        decimal wgdWgt = 0;
                    //        DataTable factDt = bll_TRC_ROLL_WGD.GetWgdFactAttrDP(wgd.C_BATCH_NO).Tables[0];
                    //        List<NcRoll46> nc46s = new List<NcRoll46>();
                    //        for (int j = 0; j < factDt.Rows.Count; j++)
                    //        {
                    //            NcRoll46 nc46 = new NcRoll46();
                    //            var a46M = bll_TB_MATRL_MAIN.GetModel(factDt.Rows[j]["C_MAT_CODE"].ToString());
                    //            nc46.cwarehouseid = bll_TPB_LINEWH.GetList_id(factDt.Rows[j]["C_LINEWH_CODE"].ToString()).ToString();
                    //            nc46.taccounttime = DateTime.Parse(wgd.D_MOD_DT == null ? DateTime.Now.ToString() : wgd.D_MOD_DT.ToString());
                    //            nc46.coperatorid = RV.UI.UserInfo.userAccount;
                    //            //if (wgd.C_MRSX == "DP")
                    //            //{ }
                    //            nc46.ccheckstate_bid = bll_TQB_CHECKSTATE.GetModelByName("DP", "1001").C_ID;
                    //            //else
                    //            //    nc46.ccheckstate_bid = bll_TQB_CHECKSTATE.GetModelByName(factDt.Rows[j]["C_JUDGE_LEV_BP"].ToString(), "1001").C_ID;
                    //            nc46.cworkcenterid = bll_TB_STA.Get_NC_ID(wgd.C_STA_ID);
                    //            nc46.dbizdate = DateTime.Parse(wgd.D_MOD_DT == null ? DateTime.Now.ToString() : wgd.D_MOD_DT.ToString());
                    //            nc46.vbatchcode = wgd.C_BATCH_NO;
                    //            nc46.cinvbasid = a46M.C_PK_INVBASDOC;
                    //            nc46.pk_produce = a46M.C_PK_PRODUCE;
                    //            nc46.ninnum = factDt.Rows[j]["WGT"].ToString();
                    //            nc46.ninassistnum = factDt.Rows[j]["QUA"].ToString();
                    //            nc46.castunitid = a46M.C_FJLDW;
                    //            nc46.vfree1 = factDt.Rows[j]["C_ZYX1"].ToString();
                    //            nc46.vfree2 = factDt.Rows[j]["C_ZYX2"].ToString();
                    //            nc46.vfree3 = factDt.Rows[j]["C_BZYQ"].ToString();
                    //            nc46s.Add(nc46);
                    //            wgdWgt += decimal.Parse(factDt.Rows[j]["WGT"].ToString());
                    //        }

                    //        string a46Name = Guid.NewGuid() + "_A46.xml";

                    //        var resultA46 = bll_Interface_NC_Roll_46.SendXml_ROLL_46("", a46Name, nc46s, Application.StartupPath);
                    //        if (resultA46[0] != "1")
                    //        {
                    //            bll_TRC_ROLL_WGD.UpdateIfStatus(1, id, resultA46[1]);
                    //        }

                    //        if (bll_TRC_ROLL_WGD.Is46Repeat(wgd.C_BATCH_NO, "") > 0)
                    //        {
                    //            bll_TRC_ROLL_WGD.UpdateRollPlanItemWgt(plan.C_ID, wgdWgt);
                    //            bll_TRC_ROLL_WGD.UpdateUpLoadStatus(3, id);
                    //        }
                    //    }
                    //}


                    //#endregion
                }
                else
                {
                    BindAssePutStoreData();
                    BindWGDData();
                    MessageBox.Show("操作失败!");
                }
            }
            WaitingFrom.CloseWait();

        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认撤回吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            DataTable dt = bll_TRC_ROLL_WGD.GetWgdData(staID, dt_ExecStart.DateTime, dt_ExecEnd.DateTime, "").Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                string result = bll_TRC_ROLL_WGD.WgdBackHandler(dt.Rows[0]);
                if (result == "1")
                {
                    BindAssePutStoreData();
                    BindWGDData();
                    MessageBox.Show("操作成功!");
                }
                else
                {
                    BindAssePutStoreData();
                    BindWGDData();
                    MessageBox.Show("操作失败!");
                }
            }
            else
            {
                MessageBox.Show("完工单记录为空");
            }
        }

        private void btn_AsseQuery_Click(object sender, EventArgs e)
        {
            BindAssePutStoreData();
            BindWGDData();
            Remind();
        }

        private void btn_WgdQuery_Click(object sender, EventArgs e)
        {
            BindWGDData();
            Remind();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.dt_ExecEnd.DateTime = DateTime.Now;
        }

        private void btn_out_toExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_WGD, "完工单" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_ZGWGD, "轧钢组坯计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void gv_WGD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_WGD.GetDataRow(gv_WGD.FocusedRowHandle);
                if (dr != null)
                {
                    this.txt_UpSuccess.Text = dr["N_QUA_SUCCESS"].ToString();
                    this.txt_UpCastOff.Text = dr["N_QUA_CASTOFF"].ToString();
                    this.txt_UpCutting.Text = dr["N_QUA_CUTTING"].ToString();
                    this.dt_UpdateStart.DateTime = DateTime.Parse(dr["D_PRODUCE_DATE_B"].ToString());
                    //this.dt_UpdateEnd.DateTime = DateTime.Parse(dr["D_PRODUCE_DATE_E"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认修改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            string strMenuName = RV.UI.UserInfo.menuName;

            UserLog.AddLog(strMenuName, this.Name + "修改实绩", "修改实绩", "完工记录");//添加操作日志

            int selectedAllowGrd = this.gv_WGD.FocusedRowHandle;//获取可轧钢种焦点行索引
            if (selectedAllowGrd < 0)
            {
                MessageBox.Show("请选择一条完工单修改!");
                return;
            }
            string id = this.gv_WGD.GetRowCellValue(selectedAllowGrd, "C_MAIN_ID").ToString();//ID
            decimal produceQua = decimal.Parse(this.gv_WGD.GetRowCellValue(selectedAllowGrd, "N_QUA_PRODUCE").ToString());//支数
            decimal success = this.txt_UpSuccess.Text == "" ? 0 : decimal.Parse(this.txt_UpSuccess.Text);
            decimal castOff = this.txt_UpCastOff.Text == "" ? 0 : decimal.Parse(this.txt_UpCastOff.Text);
            decimal cutting = this.txt_UpCutting.Text == "" ? 0 : decimal.Parse(this.txt_UpCutting.Text);
            DateTime start = this.dt_UpdateStart.DateTime;
            DateTime end = this.dt_UpdateEnd.DateTime;
            if (bll_TRC_ROLL_WGD.UpdateWgdQua(id, success, castOff, cutting, RV.UI.UserInfo.userID, start, end))
            {
                BindAssePutStoreData();
                BindWGDData();
                MessageBox.Show("操作成功!");
            }
            else
            {
                MessageBox.Show("操作失败!");
            }

        }

        private void txt_UpCastOff_Leave(object sender, EventArgs e)
        {
            int selectedAllowGrd = this.gv_WGD.FocusedRowHandle;//获取可轧钢种焦点行索引        
            decimal produceQua = decimal.Parse(this.gv_WGD.GetRowCellValue(selectedAllowGrd, "N_QUA_PRODUCE").ToString());//支数        
            decimal castOff = this.txt_UpCastOff.Text == "" ? 0 : decimal.Parse(this.txt_UpCastOff.Text);
            decimal cutting = this.txt_UpCutting.Text == "" ? 0 : decimal.Parse(this.txt_UpCutting.Text);
            this.txt_UpSuccess.Text = (produceQua - castOff - cutting).ToString();
        }

        private void txt_UpCutting_Leave(object sender, EventArgs e)
        {
            int selectedAllowGrd = this.gv_WGD.FocusedRowHandle;//获取可轧钢种焦点行索引        
            decimal produceQua = decimal.Parse(this.gv_WGD.GetRowCellValue(selectedAllowGrd, "N_QUA_PRODUCE").ToString());//支数        
            decimal castOff = this.txt_UpCastOff.Text == "" ? 0 : decimal.Parse(this.txt_UpCastOff.Text);
            decimal cutting = this.txt_UpCutting.Text == "" ? 0 : decimal.Parse(this.txt_UpCutting.Text);
            this.txt_UpSuccess.Text = (produceQua - castOff - cutting).ToString();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.dt_ExecEnd.DateTime = DateTime.Now;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Remind();
            //if (this.btn_SL.Enabled == true)
            //{
            //    MessageBox.Show("请手动下发完工单至NC");
            //}
        }
    }
}
