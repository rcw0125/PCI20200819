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
    public partial class FrmPP_JHTZ : Form
    {
        Bll_TB_PRO bll_TB_PRO = new Bll_TB_PRO();
        Bll_TPP_INITIALIZE_ITEM bll_TPP_INITIALIZE_ITEM = new Bll_TPP_INITIALIZE_ITEM();
        Bll_TPP_PRODUCTION_PLAN bll_TPP_PRODUCTION_PLAN = new Bll_TPP_PRODUCTION_PLAN();
        Bll_TRP_PLAN_ROLL bll_TRP_PLAN_ROLL = new Bll_TRP_PLAN_ROLL();
        Bll_TSP_PLAN_SMS bll_TSP_PLAN_SMS = new Bll_TSP_PLAN_SMS();
        Bll_TPB_STATION_CAPACITY bll_TPB_STATION_CAPACITY = new Bll_TPB_STATION_CAPACITY();
        Bll_TPB_SLAB_CAPACITY bll_TPB_SLAB_CAPACITY = new Bll_TPB_SLAB_CAPACITY();
        Bll_TPB_CHANGESPEC_TIME bll_TPB_CHANGESPEC_TIME = new Bll_TPB_CHANGESPEC_TIME();
        Bll_TPP_TURNAROUND_PLAN bll_TPP_TURNAROUND_PLAN = new Bll_TPP_TURNAROUND_PLAN();
        private Bll_TPP_PROD_INITIALIZE bll_TPP_PROD_INITIALIZE = new Bll_TPP_PROD_INITIALIZE();//初始化主表（档期表）
        CommonSub commonSub = new CommonSub();

        public FrmPP_JHTZ()
        {
            InitializeComponent();
        }

        private void FrmPP_JHTZ_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                BindYearMonth(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 获取工序id
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public string GetGXid(string pro)
        {
            DataTable dt = bll_TB_PRO.GetListByStatus(1, pro, "").Tables[0];
            string cid = "";
            if (dt.Rows.Count > 0)
            {
                cid = dt.Rows[0]["C_ID"].ToString();
            }
            return cid;
        }
        /// <summary>
        /// 从当月开始加载年月
        /// </summary>
        /// <param name="MonNum">加载月数</param>
        public void BindYearMonth(int MonNum)
        {
            cbo_yyyyMM.Properties.Items.Clear();
            for (int i = 0; i < MonNum; i++)
            {
                cbo_yyyyMM.Properties.Items.Add(System.DateTime.Now.AddMonths(i).ToString("yyyy-MM"));
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                Query1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 轧钢计划
        /// </summary>
        private void Query1()
        {
            if (cbo_QS.Text == "")
            {
                return;
            }
            DataTable dt = null;
            dt = bll_TRP_PLAN_ROLL.GetList(0, cbo_FA.EditValue.ToString(), cbo_GW1.EditValue.ToString()).Tables[0];
            this.gc_ZGJH.DataSource = dt;
            this.gv_ZGJH.OptionsView.ColumnAutoWidth = false;
            colC_STA_ID.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            this.gv_ZGJH.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ZGJH);
        }

        /// <summary>
        /// 轧钢计划点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_ZGJH_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedHandle = this.gv_ZGJH.FocusedRowHandle;//获取焦点行索引
                if (selectedHandle < 0)
                {
                    return;
                }
                txt_XZSL1.Text = this.gv_ZGJH.GetRowCellValue(selectedHandle, "N_WGT").ToString();//数量
                commonSub.ImageComboBoxEditBindLGGW(GetGXid("ZG"), cbo_FA.EditValue.ToString(), cbo_XZGW1);
                commonSub.ComboBoxEditBindPCSX(cbo_FA.Text, this.gv_ZGJH.GetRowCellValue(selectedHandle, "C_STA_ID").ToString(), cbo_SCSX1);
                cbo_XZGW1.EditValue = "";
                string sta = this.gv_ZGJH.GetRowCellValue(this.gv_ZGJH.FocusedRowHandle, "C_STA_ID").ToString();
                if (cbo_XZGW1.EditValue.ToString() == sta)
                {
                    cbo_SCSX1.Properties.Items.RemoveAt(cbo_SCSX1.Properties.Items.Count - 1);
                }
                cbo_XZGW1.EditValue = sta;
                cbo_SCSX1.EditValue = this.gv_ZGJH.GetRowCellValue(selectedHandle, "N_SORT").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 调整轧钢生产顺序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_XGZG_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                if (cbo_SCSX1.Text.Trim() == "")
                {
                    MessageBox.Show("请选择要调整的生产顺序！");
                    return;
                }

                ResetSortZG();

                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        /// <summary>
        /// 重新计算顺序
        /// </summary>
        private void ResetSortZG()
        {
            DataRow dr = gv_ZGJH.GetDataRow(gv_ZGJH.FocusedRowHandle);

            if (dr != null)
            {
                if (cbo_XZGW1.EditValue.ToString() != dr["C_STA_ID"].ToString())//跨产线
                {
                    int count = bll_TRP_PLAN_ROLL.GetFACount(cbo_QS.Text, cbo_XZGW1.EditValue.ToString());//该方案下该工位计划数量

                    string stype = "";
                    if (Convert.ToInt32(cbo_SCSX1.Text.ToString()) > count)
                    {
                        stype = "0";//添加到另一条产线计划最后
                    }
                    else
                    {
                        stype = "1";
                    }

                    if (stype == "1")
                    {
                        bll_TRP_PLAN_ROLL.Update_CX(dr["C_ID"].ToString(), cbo_XZGW1.EditValue.ToString(), dr["C_INITIALIZE_ITEM_ID"].ToString(), Convert.ToInt32(cbo_SCSX1.Text.ToString()), stype);
                    }

                    bll_TRP_PLAN_ROLL.Update_CX(dr["C_ID"].ToString(), cbo_XZGW1.EditValue.ToString(), dr["C_INITIALIZE_ITEM_ID"].ToString(), Convert.ToInt32(cbo_SCSX1.Text.ToString()), "0");

                    bll_TRP_PLAN_ROLL.Update(dr["C_STA_ID"].ToString(), dr["C_INITIALIZE_ITEM_ID"].ToString(), Convert.ToInt32(dr["N_SORT"].ToString()));
                }
                else//未跨产线
                {
                    string stype = "";
                    if (Convert.ToInt32(cbo_SCSX1.Text.ToString()) > Convert.ToInt32(dr["N_SORT"].ToString()))
                    {
                        stype = "0";
                    }
                    else
                    {
                        stype = "1";
                    }

                    bll_TRP_PLAN_ROLL.Update(dr["C_ID"].ToString(), dr["C_STA_ID"].ToString(), dr["C_INITIALIZE_ITEM_ID"].ToString(), Convert.ToInt32(cbo_SCSX1.Text.ToString()), Convert.ToInt32(dr["N_SORT"].ToString()), stype);
                    bll_TRP_PLAN_ROLL.Update(dr["C_ID"].ToString(), dr["C_STA_ID"].ToString(), dr["C_INITIALIZE_ITEM_ID"].ToString(), Convert.ToInt32(cbo_SCSX1.Text.ToString()));
                }

                Query1();
            }
        }

        private void cbo_FA_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                commonSub.ImageComboBoxEditBindLGGW(GetGXid("ZG"), cbo_FA.EditValue.ToString(), cbo_GW1);
                cbo_GW1.Properties.Items.Add("", "", 0);
                cbo_GW1.EditValue = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 重置轧钢计划时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ResetZG_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认重置？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                if (MessageBox.Show("确定重新计算方案：" + cbo_FA.Text + "的计划时间？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    bll_TRP_PLAN_ROLL.ResetTime(cbo_FA.EditValue.ToString());

                    MessageBox.Show("时间重置成功！");

                    Query1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbo_XZGW1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sta = this.gv_ZGJH.GetRowCellValue(this.gv_ZGJH.FocusedRowHandle, "C_STA_ID").ToString();
                commonSub.ComboBoxEditBindPCSX(cbo_FA.Text, cbo_XZGW1.EditValue.ToString(), cbo_SCSX1);
                if (sta == cbo_XZGW1.EditValue.ToString())
                {
                    cbo_SCSX1.Properties.Items.RemoveAt(cbo_SCSX1.Properties.Items.Count - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbo_yyyyMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDQ(cbo_yyyyMM.Text.Trim(), this.cbo_type.Text.Trim());
        }
        /// <summary>
        /// 根据年月加载档期信息
        /// </summary>
        /// <param name="YM">选择的年月</param>
        /// <param name="type">类型</param>
        public void BindDQ(String YM, string type)
        {
            DataTable dt = bll_TPP_PROD_INITIALIZE.GetListByYM(YM, type);
            cbo_QS.Properties.Items.Clear();
            cbo_QS.Text = "";
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo_QS.Properties.Items.Add(dt.Rows[i]["C_ISSUE"].ToString());
                }
            }
        }

        private void cbo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDQ(cbo_yyyyMM.Text.Trim(), this.cbo_type.Text.Trim());
        }

        private void cbo_QS_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindFA(cbo_QS.Text);
        }

        public void BindFA(string qs)
        {
            DataTable dt = bll_TPP_INITIALIZE_ITEM.GetListByQS(qs).Tables[0];
            cbo_FA.Properties.Items.Clear();
            cbo_FA.Text = "";
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo_FA.Properties.Items.Add(dt.Rows[i]["C_ITEM_NAME"].ToString(), dt.Rows[i]["C_ID"].ToString(), 0);
                }
            }
        }
    }
}
