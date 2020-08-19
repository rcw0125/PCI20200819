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
    public partial class FrmTBWGDA3KP : Form
    {
        public FrmTBWGDA3KP()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_WGD bll_TRC_ROLL_WGD = new Bll_TRC_ROLL_WGD();
        Bll_TRC_COGDOWN_MAIN bll_TRC_COGDOWN_MAIN = new Bll_TRC_COGDOWN_MAIN();
        Bll_TRC_COGDOWN_MAIN_ITEM bll_TRC_COGDOWN_MAIN_ITEM = new Bll_TRC_COGDOWN_MAIN_ITEM();
        Bll_TRP_PLAN_COGDOWN bll_TRP_PLAN_COGDOWN = new Bll_TRP_PLAN_COGDOWN();
        Bll_TB_MATRL_MAIN bll_TB_MATRL_MAIN = new Bll_TB_MATRL_MAIN();
        Bll_TRC_COGDOWN_PRODUCT bll_TRC_COGDOWN_PRODUCT = new Bll_TRC_COGDOWN_PRODUCT();
        Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_Interface_NC_Roll_A3 bll_Interface_NC_Roll_A3 = new Bll_Interface_NC_Roll_A3();
        private void btn_QueryNC_Click(object sender, EventArgs e)
        {
            Bind();
        }
        private void Bind()
        {
            var dt = bll_TRC_ROLL_WGD.GetNotA3("4");
            string sqlWhere = " ";

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0)
                        sqlWhere += " AND  TCP.C_BATCH_NO = '" + dt.Rows[i]["pch"].ToString() + "'  ";
                    else
                    {
                        sqlWhere += " OR  TCP.C_BATCH_NO = '" + dt.Rows[i]["pch"].ToString() + "'  ";
                    }
                }
            }
            else
            {
                MessageBox.Show("无记录");
                this.gc_NC.DataSource = null;
                return;
            }

            this.gc_NC.DataSource = bll_TRC_COGDOWN_MAIN.GetCogDownFact(3,"",sqlWhere).Tables[0];
            gv_NC.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_NC);
        }

        private void btn_A3_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认同步吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            NcRollA2 ncA2 = new NcRollA2();
            NcRollA3 ncA3 = new NcRollA3();
            NcRollA4 ncA4 = new NcRollA4();
            NcRollA1 ncA1 = new NcRollA1();
            try
            {
                int selectedPlanHandle = this.gv_NC.FocusedRowHandle;//获取计划焦点行索引
                int selectedAllowGrd = this.gv_NC.FocusedRowHandle;//获取可轧钢种焦点行索引
                if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
                {
                    MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                    return;
                }
                string id = this.gv_NC.GetRowCellValue(selectedPlanHandle, "C_COGDOWN_ID").ToString();//获取焦点
                var main = bll_TRC_COGDOWN_MAIN.GetModel(id);
                var plan = bll_TRP_PLAN_COGDOWN.GetModel(main.C_PLAN_ID);
                var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);                                
                var matrl2 = bll_TB_MATRL_MAIN.GetModel(main.C_MAT_SLAB_CODE);
                var product = bll_TRC_COGDOWN_PRODUCT.GetModelByCOGID(id);
                var a2Sta = bll_TB_STA.GetModel(main.C_STA_ID);
                #region A3
                //int status = 3;
                ncA3.hpch = main.C_BATCH_NO;
                ncA3.hzdrid = bll_TRC_COGDOWN_MAIN.GetUser();
                ncA3.hwlbmid = matrl.C_PK_INVBASDOC;
                ncA3.hjldwid = matrl.C_PK_MEASDOC;
                ncA3.hzdrq = DateTime.Parse(product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.ToString());
                ncA3.hfreeitemvalue1 = plan.C_FREE1;
                ncA3.hfreeitemvalue2 = plan.C_FREE2;
                ncA3.hfreeitemvalue3 = plan.C_PACK;

                DataTable a3Dt =bll_TRC_COGDOWN_MAIN_ITEM.GetSlabMainInfoKp(main.C_ID);
                //DataTable a3DtZyx = bll_TB_STD_CONFIG.GetZYX(a3Dt.Rows[0]["C_STL_GRD"].ToString(), a3Dt.Rows[0]["C_STD_CODE"].ToString()).Tables[0];
                //var m = GetMatrlModel(a3Dt.Rows[0]["C_MAT_CODE"].ToString());
                ncA3.kgyid = bll_TRC_COGDOWN_MAIN.GetUser();
                ncA3.ckckid = bll_TPB_SLABWH.GetList_id(a3Dt.Rows[0]["C_SLABWH_CODE"].ToString()).ToString();
                ncA3.wlbmid = matrl2.C_PK_INVBASDOC;
                ncA3.jldwid = matrl2.C_PK_MEASDOC;
                ncA3.fjldwid = matrl2.C_FJLDW;
                ncA3.ljcksl = a3Dt.Rows[0]["N_WGT"].ToString();
                ncA3.fljcksl = a3Dt.Rows[0]["N_QUA"].ToString();
                ncA3.pch = a3Dt.Rows[0]["C_STOVE"].ToString();
                ncA3.gzzxid = a2Sta.C_ERP_PK;
                ncA3.freeitemvalue1 = a3Dt.Rows[0]["C_ZYX1"].ToString();
                ncA3.freeitemvalue2 = a3Dt.Rows[0]["C_ZYX2"].ToString();
                object objOutTime = bll_TRC_COGDOWN_MAIN.GetOutTimeKp(main.C_ID);
                ncA3.flrq = product.D_QR_DATE == null ? DateTime.Now.ToString() : product.D_QR_DATE.Value.ToString("yyyy-MM-dd");
                string a3Name = Guid.NewGuid() + "_A3.xml";
                if (bll_TRC_COGDOWN_MAIN.IsA3Repeat(main.C_BATCH_NO, "") > 0)
                {

                }
                var resultA3 = bll_Interface_NC_Roll_A3.SendXml_ROLL_A3("", a3Name, ncA3, Application.StartupPath);
                if (resultA3[0] != "1")
                {
                    bll_TRC_COGDOWN_MAIN.UpdateIfStatusCogDown(3, product.C_BATCH_NO, resultA3[1]);
                    bll_TRC_COGDOWN_MAIN.InsertLog(main.C_BATCH_NO, string.Format("计划物料编码:{0}，消耗物料编码:{1}", matrl.C_ID, matrl2.C_ID));
                    MessageBox.Show("同步失败");
                    return;
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("同步异常"+ex.ToString());
            }

            Bind();

        }

        private void FrmTBWGDA3KP_Load(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
