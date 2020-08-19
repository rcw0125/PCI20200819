using BLL;
using Common;
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
    public partial class FrmRF_ZGWGDCH : Form
    {
        public FrmRF_ZGWGDCH()
        {
            InitializeComponent();
        }

        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TRC_ROLL_WGD bll_TRC_ROLL_WGD = new Bll_TRC_ROLL_WGD();
        Bll_TRC_ROLL_WGD_ITEM bll_TRC_ROLL_WGD_ITEM = new Bll_TRC_ROLL_WGD_ITEM();

        private void FrmRF_ZGWGDCH_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 绑定完工单数据
        /// </summary>
        public void BindWgdVData()
        {
            string whereSql = "  ";
            if (!string.IsNullOrWhiteSpace(txt_Stove.Text))
                whereSql += "   C_BATCH_NO = '" + txt_Stove.Text + "' ";

            // whereSql += "  AND C_STA_ID='" + staID + "'";

            DataTable dt = bll_TRC_ROLL_WGD.GetList(whereSql).Tables[0];
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView1);
        }

        private void btn_AsseQuery_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_Stove.Text))
            {
                MessageBox.Show("请输入批次号");
                return;
            }
            BindWgdVData();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;

            UserLog.AddLog(strMenuName, this.Name + "撤回完工单", "撤回完工单", "撤回完工单");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认撤回吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            int selectedPlanHandle = this.gridView1.FocusedRowHandle;//获取计划焦点行索引
            string batchNo = this.gridView1.GetRowCellValue(selectedPlanHandle, "C_BATCH_NO").ToString();//获取焦点主键
            if (bll_TRC_ROLL_WGD.BackWgd(batchNo))
            {
                BindWgdVData();
                MessageBox.Show("操作成功");
            }
            else
            {
                MessageBox.Show("操作成功");
            }
        }
    }
}
