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
    public partial class FrmRC_TBWGD4 : Form
    {
        public FrmRC_TBWGD4()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //staID = bll_TB_STA.GetStaIdByCode(arr[0]);
            //slbwhCode = arr[1];
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
        Bll_Interface_FR bll_Interface_FR = new Bll_Interface_FR();

        private void btn_A2_Click(object sender, EventArgs e)
        {
           
        }


        private void btn_QueryNC_Click(object sender, EventArgs e)
        {

        }

        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            string batchNo = txt_Batch_No.Text;
            string gh = txt_Gh.Text;

            if (string.IsNullOrWhiteSpace(batchNo))
            {
                MessageBox.Show("请输入批次号进行查询！");
                return;
            }

            DataTable roll = bll_Interface_FR.RollPro(batchNo, gh).Tables[0];
            this.gc_RollPro.DataSource = roll;
            this.gv_RollPro.OptionsView.ColumnAutoWidth = false;
            this.gv_RollPro.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_RollPro);
            gv_RollPro.OptionsSelection.MultiSelect = true;
            gv_RollPro.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int[] rownumber = gv_RollPro.GetSelectedRows();//获取选中行号数组；
            string batchNo = "";
            List<string> ids = new List<string>();
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    DataRow drRoll = gv_RollPro.GetDataRow(selectedHandle);
                    ids.Add(drRoll["C_ID"].ToString());
                    batchNo = drRoll["C_BATCH_NO"].ToString();
                }
            }

            if (bll_TRC_ROLL_WGD.DelRollProduct(ids, batchNo, Application.StartupPath) > 0)
            {
                MessageBox.Show("操作成功");
                btn_query_zg_Click(null, null);
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
    }
}
