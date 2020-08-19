using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL;
using MODEL;
using Common;

namespace XGCAP.UI.P.PP
{
    public partial class FrmPP_LCJH_EDIT_PLAN : Form
    {
        public FrmPP_LCJH_EDIT_PLAN()
        {
            InitializeComponent();
        }
        private Bll_TSP_PLAN_SMS bllTspPlanSms = new Bll_TSP_PLAN_SMS();
        private Bll_TPP_LG_PLAN bllTppLgPlan = new Bll_TPP_LG_PLAN();
        private Bll_TPP_CAST_PLAN bllTppCastPlan = new Bll_TPP_CAST_PLAN();

        CommonSub commonSub = new CommonSub();

        private void FrmPP_LCJH_EDIT_PLAN_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            BindStove();
        }

        private void BindStove()
        {
            if (string.IsNullOrEmpty(txt_Stove.Text.Trim()))
            {
                MessageBox.Show("请输入需要修改计划的炉号！");
                return;
            }

            WaitingFrom.ShowWait("");

            DataTable dt = bllTspPlanSms.Get_Plan_ByStove(txt_Stove.Text.Trim());

            this.gc_Plan.DataSource = dt;

            gv_Plan.Columns["C_ZL_ID"].ColumnEdit = commonSub.GetGWIdByGXDescItemComboBox("ZL");
            gv_Plan.Columns["C_LF_ID"].ColumnEdit = commonSub.GetGWIdByGXDescItemComboBox("LF");
            gv_Plan.Columns["C_RH_ID"].ColumnEdit = commonSub.GetGWIdByGXDescItemComboBox("RH");
            gv_Plan.Columns["C_CCM_ID"].ColumnEdit = commonSub.GetGWIdByGXDescItemComboBox("CC");

            SetGridViewRowNum.SetRowNum(gv_Plan);

            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 修改工艺路线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Plan.GetDataRow(gv_Plan.FocusedRowHandle);

            if (dr == null)
            {
                MessageBox.Show("请选择需要修改的计划！");
                return;
            }

            if (string.IsNullOrEmpty(txt_Reason.Text.Trim()))
            {
                MessageBox.Show("请填写修改原因！");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("确认修改炉号：" + dr["炉号"].ToString() + "的炼钢计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                string result = bllTppLgPlan.Update_Plan(dr, Application.StartupPath, txt_Reason.Text.Trim());

                if (result == "1")
                {
                    MessageBox.Show("计划修改成功！");
                    BindStove();
                }
                else
                {
                    MessageBox.Show(result);
                    return;
                }

            }
        }

        private void gv_Plan_DoubleClick(object sender, EventArgs e)
        {
            if (gv_Plan.FocusedColumn.GetTextCaption() == "钢种")
            {
                int handle = gv_Plan.FocusedRowHandle;
                if (handle >= 0)
                {
                    FrmPP_SELECT_WL frm = new FrmPP_SELECT_WL();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        gv_Plan.SetRowCellValue(handle, "钢种", frm.str_GZ);
                        gv_Plan.SetRowCellValue(handle, "执行标准", frm.str_BZ);
                        gv_Plan.SetRowCellValue(handle, "断面", frm.str_SlabSize);
                        gv_Plan.SetRowCellValue(handle, "定尺", frm.str_Length);
                        gv_Plan.SetRowCellValue(handle, "C_MATRL_NO", frm.mat_code);
                        gv_Plan.SetRowCellValue(handle, "C_MATRL_NAME", frm.mat_name);
                        gv_Plan.SetRowCellValue(handle, "C_PK_INVBASDOC", frm.str_NC_PK);

                        frm.Close();
                    }
                }
            }
        }
    }
}
