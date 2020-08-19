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
    public partial class FrmPP_LCJH : Form
    {
        public FrmPP_LCJH()
        {
            InitializeComponent();
        }
        private Bll_TSP_PLAN_SMS bllTspPlanSms = new Bll_TSP_PLAN_SMS();
        private Bll_TPP_LG_PLAN bllTppLgPlan = new Bll_TPP_LG_PLAN();
        private Bll_TPP_CAST_PLAN bllTppCastPlan = new Bll_TPP_CAST_PLAN();

        CommonSub commonSub = new CommonSub();

        private void FrmPP_LCJH_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            dt_Plan_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_Plan_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            CommonSub.BindIcbo_XF("", "CC", icbo_lz);

            lbl_LX.Text = "";
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            BindWXF();
        }

        private void BindWXF()
        {
            if (string.IsNullOrEmpty(icbo_lz.Text.ToString()))
            {
                MessageBox.Show("请选择需要查看的连铸！");
                return;
            }

            WaitingFrom.ShowWait("");

            DataTable dt = bllTspPlanSms.Get_Stove_JH_ITEM(icbo_lz.EditValue.ToString(), "", "0", "", "");

            this.gc_WXF.DataSource = dt;

            gv_WXF.Columns["C_ZL_ID"].ColumnEdit = commonSub.GetGWIdByGXDescItemComboBox("ZL");
            gv_WXF.Columns["C_LF_ID"].ColumnEdit = commonSub.GetGWIdByGXDescItemComboBox("LF");
            gv_WXF.Columns["C_RH_ID"].ColumnEdit = commonSub.GetGWIdByGXDescItemComboBox("RH");

            SetGridViewRowNum.SetRowNum(gv_WXF);

            WaitingFrom.CloseWait();
        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                string strResult = gv_WXF.GetRowCellValue(e.RowHandle, "计划状态").ToString();
                if (strResult == "已下发")
                {
                    e.Appearance.BackColor = Color.Yellow;//改变背景色
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 下发计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Down_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Num.Text.Trim()))
            {
                MessageBox.Show("请填写准备下发的计划炉数！");
                return;
            }

            int result = 0;
            if (!int.TryParse(txt_Num.Text.Trim(), out result))
            {
                MessageBox.Show("炉数只能填写整数！");
                return;
            }

            if (DialogResult.No == MessageBox.Show("确认下发" + icbo_lz.Text.ToString() + "的" + txt_Num.Text.Trim() + "炉计划给MES？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            WaitingFrom.ShowWait("正在下发，请稍等...");

            string a = bllTppLgPlan.SendPlanToMes(icbo_lz.EditValue.ToString(), Convert.ToInt32(txt_Num.Text.Trim()), Application.StartupPath);

            WaitingFrom.CloseWait();

            if (a == "1")
            {
                MessageBox.Show("下发成功！");

                BindWXF();
            }
            else if (a == "0")
            {
                MessageBox.Show("下发失败！");
                return;
            }
            else
            {
                MessageBox.Show(a);
                return;
            }
        }

        /// <summary>
        /// 修改工艺路线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //FrmPP_GYLX_SELECT frm = new FrmPP_GYLX_SELECT(str_ld_id, str_lf_id, str_rh_id, str_cc_id);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    BindWXF();
            //}

            DataTable dt = ((DataView)gv_WXF.DataSource).ToTable();

            if (string.IsNullOrEmpty(icbo_lz.Text.ToString()))
            {
                MessageBox.Show("请选择需要修改路线的连铸！");
                return;
            }

            string result = bllTppLgPlan.UpdateGYLX_New(dt, icbo_lz.EditValue.ToString());

            if (result == "1")
            {
                MessageBox.Show("工艺路线修改成功！");
                BindWXF();
            }
            else
            {
                MessageBox.Show("工艺路线修改失败！");
                return;
            }
        }

        /// <summary>
        /// 查询已下发计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_YXF_Click(object sender, EventArgs e)
        {
            BindYXF();
        }

        private void BindYXF()
        {
            if (string.IsNullOrEmpty(icbo_ZL_YXF.Text.ToString()))
            {
                MessageBox.Show("请选择需要查看的连铸！");
                return;
            }

            WaitingFrom.ShowWait("");

            DataTable dt = bllTspPlanSms.Get_Stove_JH_YXF_ITEM(icbo_ZL_YXF.EditValue.ToString(), "", "1", dt_Plan_Start.Text.Trim(), dt_Plan_End.Text.Trim());

            this.gc_YXF.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_YXF);

            WaitingFrom.CloseWait();
        }

        private void btn_Back_YXF_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_YXF.GetDataRow(gv_YXF.FocusedRowHandle);

            if (dr == null)
            {
                MessageBox.Show("请选择需要撤销的数据！");
                return;
            }

            if (string.IsNullOrEmpty(icbo_ZL_YXF.Text.ToString())|| icbo_ZL_YXF.Text.ToString()=="全部")
            {
                MessageBox.Show("请选择需要撤销的连铸！");
                return;
            }

            if (DialogResult.No == MessageBox.Show("确认撤销炉号：" + dr["炉号"].ToString() + "及之后的计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int count = bllTppCastPlan.Get_Stove_State(dr["炉号"].ToString());

            if (count > 0)
            {
                MessageBox.Show("炉号：" + dr["炉号"].ToString() + "的计划已执行，不能撤销");
                return;
            }
            else
            {
                WaitingFrom.ShowWait("正在撤销，请稍等...");

                string a = bllTppLgPlan.Back_YXF(icbo_ZL_YXF.EditValue.ToString(), dr["炉号"].ToString());

                WaitingFrom.CloseWait();

                if (a == "1")
                {
                    MessageBox.Show("撤销成功！");
                    BindYXF();
                }
                else
                {
                    MessageBox.Show("撤销失败！");
                    return;
                }
            }
        }

        private void gv_WXF_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //string strLX = "";

            //str_ld_id = "";
            //str_lf_id = "";
            //str_rh_id = "";
            //str_cc_id = "";

            //DataRow dr = gv_WXF.GetDataRow(e.FocusedRowHandle);

            //if (dr != null)
            //{
            //    strLX = "工艺路线：";
            //    if (!string.IsNullOrEmpty(dr["转炉"].ToString()))
            //    {
            //        strLX = strLX + dr["转炉"].ToString() + ">>>";

            //        str_ld_id = dr["C_ZL_ID"].ToString();
            //    }

            //    if (!string.IsNullOrEmpty(dr["精炼"].ToString()))
            //    {
            //        strLX = strLX + dr["精炼"].ToString() + ">>>";

            //        str_lf_id = dr["C_LF_ID"].ToString();
            //    }

            //    if (!string.IsNullOrEmpty(dr["真空"].ToString()))
            //    {
            //        strLX = strLX + dr["真空"].ToString() + ">>>";

            //        str_rh_id = dr["C_RH_ID"].ToString();
            //    }

            //    if (!string.IsNullOrEmpty(dr["连铸"].ToString()))
            //    {
            //        strLX = strLX + dr["连铸"].ToString();

            //        str_cc_id = dr["C_CCM_ID"].ToString();
            //    }
            //}

            //lbl_LX.Text = strLX;
        }

        private void btn_out2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_YXF);
        }

        private void btn_out1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_WXF);
        }

        /// <summary>
        /// 同步炼钢记号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tb_lgjh_Click(object sender, EventArgs e)
        {
            bllTspPlanSms.P_TB_LGJH();
        }
    }
}
