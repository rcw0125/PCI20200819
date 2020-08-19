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
    public partial class Frm_TBWGDA3 : Form
    {
        public Frm_TBWGDA3()
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
            Bind();
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
                ncA3.ckckid = bll_TPB_SLABWH.GetList_id(a3Dt.Rows[0]["c_slabwh_code"].ToString());
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

                if (bll_TRC_ROLL_WGD.UpdateUpLoadStatus(3, id) > 0)
                    MessageBox.Show("同步成功");
            }
            catch (Exception ex)
            {
                bll_TRC_ROLL_WGD.UpdateIfStatus(errorStatus, errorId, ex.Message);
                MessageBox.Show("同步失败");
            }

            Bind();

        }

        private void Frm_TBWGDA3_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {
            var dt = bll_TRC_ROLL_WGD.GetNotA3("3");
            string sqlWhere = " ";

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0)
                        sqlWhere += "  TRW.C_BATCH_NO = '" + dt.Rows[i]["pch"].ToString() + "'  ";
                    else
                    {
                        sqlWhere += " OR  TRW.C_BATCH_NO = '" + dt.Rows[i]["pch"].ToString() + "'  ";
                    }
                }
            }
            else
            {
                MessageBox.Show("无记录");
                this.gc_NC.DataSource = null;
                return;
            }

            this.gc_NC.DataSource = bll_TRC_ROLL_WGD.GetList(sqlWhere).Tables[0];
            gv_NC.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_NC);
        }
    }
}
