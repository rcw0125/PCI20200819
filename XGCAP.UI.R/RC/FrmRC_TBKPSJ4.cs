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
    public partial class FrmRC_TBKPSJ4 : Form
    {
        public FrmRC_TBKPSJ4()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staID = bll_TB_STA.GetStaIdByCode(arr[0]);
            slbwhCode = arr[1];
        }


        string staID = "";//工位ID
        string slbwhCode = "";//合格坯仓库库位编码

        private Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        private Bll_TRC_COGDOWN_MAIN bll_TRC_COGDOWN_MAIN = new Bll_TRC_COGDOWN_MAIN();
        private readonly Bll_TB_MATRL_MAIN bll_TB_MATRL_MAIN = new Bll_TB_MATRL_MAIN();
        private readonly Bll_Interface_NC_Roll_A1 bll_Interface_NC_Roll_A1 = new Bll_Interface_NC_Roll_A1();
        private readonly Bll_TRP_PLAN_COGDOWN bll_TRP_PLAN_COGDOWN = new Bll_TRP_PLAN_COGDOWN();

        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindToSlabList();
        }


        /// <summary>
        /// 绑定已调拨钢坯数据
        /// </summary>
        public void BindToSlabList()
        {
            try
            {
                DataTable dt = bll_TRC_COGDOWN_MAIN.GetCogDownFact(1, staID).Tables[0];
                this.gc_TBKPSJ.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_TBKPSJ);
            }
            catch
            {

            }
        }

        private void btn_A1_Click(object sender, EventArgs e)
        {
            int selectedPlanHandle = this.gv_TBKPSJ.FocusedRowHandle;//获取计划焦点行索引
            int selectedAllowGrd = this.gv_TBKPSJ.FocusedRowHandle;//获取可轧钢种焦点行索引
            if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
            {
                MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                return;
            }

            string id = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_COGDOWN_ID").ToString();//获取焦点id
            var  model = bll_TRC_COGDOWN_MAIN.GetModel(id);
            NcRollA1 ncA1 = new NcRollA1();
            var plan = bll_TRP_PLAN_COGDOWN.GetModel(model.C_PLAN_ID);
            var a1Sta = bll_TB_STA.GetModel(plan.C_STA_ID);
            ncA1.bmid = "1001NC1000000000038P";
            ncA1.jhrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
            ncA1.jhxxsl = plan.N_WGT.ToString();
            var matrl = bll_TB_MATRL_MAIN.GetModel(plan.C_MAT_CODE);
            ncA1.jhyid = matrl.C_PLANEMP;
            ncA1.jldwid = matrl.C_PK_MEASDOC;
            ncA1.pk_produce = matrl.C_PK_PRODUCE;
            ncA1.scbmid = a1Sta.C_SSBMID;
            ncA1.shrid = RV.UI.UserInfo.userID;
            ncA1.shrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
            ncA1.slrq = DateTime.Parse(plan.D_NEED_DT == null ? DateTime.Now.ToString() : plan.D_NEED_DT.ToString());
            ncA1.wlbmid = matrl.C_PK_INVBASDOC;
            ncA1.xdrq = DateTime.Parse(plan.D_P_START_TIME == null ? DateTime.Now.ToString() : plan.D_P_START_TIME.ToString());
            ncA1.xqrq = DateTime.Parse(plan.D_DELIVERY_DT == null ? DateTime.Now.ToString() : plan.D_DELIVERY_DT.ToString());
            ncA1.xqsl = plan.N_WGT.ToString();
            ncA1.zdrq = DateTime.Now;
            ncA1.zyx1 = plan.C_FREE1;
            ncA1.zyx2 = plan.C_FREE2;
            ncA1.zyx3 = plan.C_PACK;
            ncA1.zyx5 = plan.C_ID;
            string a1Name = plan.C_ID + "_A1.xml";
            var arrReault = bll_Interface_NC_Roll_A1.SendXml_ROLL_A1("", a1Name, ncA1, Application.StartupPath);
            if (arrReault[0] != "1")
            {
                bll_TRC_COGDOWN_MAIN.UpdateIfStatus(2, model.C_BATCH_NO, arrReault[1]);
            }
        }
    }
}
