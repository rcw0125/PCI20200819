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
    public partial class FrmRC_TBWGD5 : Form
    {
        public FrmRC_TBWGD5()
        {
            InitializeComponent();
        }

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

        private void btn_QueryNC_Click(object sender, EventArgs e)
        {
            BindWgd();
        }

        public void BindWgd()
        {
            string batchNo = txt_Batch_No.Text;
            if (string.IsNullOrWhiteSpace(batchNo))
            {
                MessageBox.Show("请输入批次号进行查询！");
                return;
            }

            string sqlWhere = "    AND N_IF_EXEC_STATUS>1 AND C_BATCH_NO='" + batchNo + "'      ";
            this.gc_NC.DataSource = bll_TRC_ROLL_WGD.GetList(sqlWhere).Tables[0];
            gv_NC.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_NC);
        }

        private void btn_A4_Click(object sender, EventArgs e)
        {
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
    }
}
