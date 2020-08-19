using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using BLL;
using Common;

namespace XGCAP.UI.P.PP
{
    public partial class FrmPP_JCJH : Form
    {
        Bll_TPP_INITIALIZE_ITEM bll_TPP_INITIALIZE_ITEM = new Bll_TPP_INITIALIZE_ITEM();
        Bll_TPP_CAST bll_tpp_cast = new Bll_TPP_CAST();
        Bll_TB_PRO bll_TB_PRO = new Bll_TB_PRO();
        Bll_TSP_PLAN_SMS bll_tsp_plan = new Bll_TSP_PLAN_SMS();
        CommonSub commonSub = new CommonSub();
        private Bll_TPP_PROD_INITIALIZE bll_TPP_PROD_INITIALIZE = new Bll_TPP_PROD_INITIALIZE();//初始化主表（档期表）

        public FrmPP_JCJH()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPP_JCJH_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                cbo_QS.EditValue = "";
                cbo_FA.EditValue = "";
                cbo_GW2.EditValue = "";
                BindYearMonth(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        /// <summary>
        /// 绑定工位下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_FA_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bll_TB_PRO.GetListByStatus(1, "CC", "").Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string cid = dt.Rows[0]["C_ID"].ToString();
                    commonSub.BindCCM(cid, cbo_FA.EditValue.ToString(), cbo_GW2);
                    cbo_GW2.EditValue = "全部";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bll_tpp_cast.GetList_Code(cbo_FA.EditValue.ToString(), cbo_GW2.EditValue?.ToString()).Tables[0];
                this.gc_SJXX.DataSource = dt;
                gv_SJXX.BestFitColumns();

                SetGridViewRowNum.SetRowNum(gv_SJXX);
                gv_SJXX_FocusedRowChanged(null, null);

                if (dt.Rows.Count > 0)
                {
                    cbo_SCSX1.Text = dt.Rows[0]["N_SORT"].ToString();
                }
                else
                {
                    return;
                }
                if (dt.Rows.Count == 0)
                {
                    cbo_SCSX1.Text = "";
                }
                else
                {
                    return;
                }
                DataSet dt_NUM = bll_tpp_cast.GetList_Number(dt.Rows[0]["C_CCM_ID"].ToString(), dt.Rows[0]["C_INITIALIZE_ITEM"].ToString());

                if (dt_NUM == null) return;
                cbo_SCSX1.Properties.Items.Clear();

                foreach (DataRow item in dt_NUM.Tables[0].Rows)//判定等级下拉框
                {
                    cbo_SCSX1.Properties.Items.Add(item["N_SORT"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        /// <summary>
        /// 修改生产顺序
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

                DataRow dr = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
                if (dr == null) return;
                string stype = "";
                if (Convert.ToInt32(cbo_SCSX1.Text.ToString()) > Convert.ToInt32(dr["N_SORT"].ToString()))
                {
                    stype = "0";
                }
                else
                {
                    stype = "1";
                }
                bll_tpp_cast.Update_SX(dr["C_ID"].ToString(), dr["C_CCM_ID"].ToString(), dr["C_INITIALIZE_ITEM"].ToString(), Convert.ToInt32(cbo_SCSX1.Text.ToString()), Convert.ToInt32(dr["N_SORT"].ToString()), stype);
                Mod_TPP_CAST mod = bll_tpp_cast.GetModel(dr["C_ID"].ToString());
                mod.N_SORT = Convert.ToInt32(cbo_SCSX1.Text.ToString());
                bll_tpp_cast.Update(mod);//修改浇次计划顺序

                bll_tpp_cast.Update_LG_Plan(dr["C_INITIALIZE_ITEM"].ToString(), dr["C_CCM_ID"].ToString());

                btn_Query_Main_Click(null, null);
                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }
        /// <summary>
        /// 回传绑定生产顺序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_SJXX_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
                if (dr != null)
                {
                    cbo_SCSX1.Text = dr["N_SORT"].ToString();
                }
                else
                {
                    return;
                }
                DataSet dt = bll_tpp_cast.GetList_Number(dr["C_CCM_ID"].ToString(), dr["C_INITIALIZE_ITEM"].ToString());

                if (dt == null) return;
                cbo_SCSX1.Properties.Items.Clear();

                foreach (DataRow item in dt.Tables[0].Rows)//判定等级下拉框
                {
                    cbo_SCSX1.Properties.Items.Add(item["N_SORT"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
        }
        /// <summary>
        /// 明细查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_SJXX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
                if (dr == null) return;
                string str = dr["C_CAST_NO"].ToString();
                DataTable dt = bll_tsp_plan.GetList_CAST_NO(str).Tables[0];
                this.gc_JCMX.DataSource = dt;
                gv_JCMX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_JCMX);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        /// <summary>
        /// 获取浇次明细顺序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gc_JCMX_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_JCMX.GetDataRow(this.gv_JCMX.FocusedRowHandle);
                if (dr != null)
                {
                    cbo_SCSX.Text = dr["N_SORT"].ToString();
                }
                else
                {
                    return;
                }
                DataSet dt = bll_tsp_plan.GetList_Number(dr["C_CAST_NO"].ToString());

                if (dt == null) return;
                cbo_SCSX.Properties.Items.Clear();

                foreach (DataRow item in dt.Tables[0].Rows)//判定等级下拉框
                {
                    cbo_SCSX.Properties.Items.Add(item["N_SORT"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
       
        }
        /// <summary>
        /// 明细顺序修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                DataRow dr = this.gv_JCMX.GetDataRow(this.gv_JCMX.FocusedRowHandle);
                string stype = "";
                if (Convert.ToInt32(cbo_SCSX.Text.ToString()) > Convert.ToInt32(dr["N_SORT"].ToString()))
                {
                    stype = "0";
                }
                else
                {
                    stype = "1";
                }
                bll_tsp_plan.Update_SX(dr["C_ID"].ToString(), dr["C_CAST_NO"].ToString(), Convert.ToInt32(cbo_SCSX.Text.ToString()), Convert.ToInt32(dr["N_SORT"].ToString()), stype);
                Mod_TSP_PLAN_SMS mod = bll_tsp_plan.GetModel(dr["C_ID"].ToString());
                mod.N_SORT = Convert.ToInt32(cbo_SCSX.Text.ToString());
                bll_tsp_plan.Update(mod);
                gv_SJXX_FocusedRowChanged(null, null);
                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void btn_ResetLG_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认重置时间？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                if (MessageBox.Show("确定重新计算方案：" + cbo_FA.Text.ToString() + "的计划时间？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    bll_tsp_plan.ResetTime(cbo_FA.EditValue.ToString(),"");

                    MessageBox.Show("时间重置成功！");

                    btn_Query_Main_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
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

        private void cbo_QS_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BindFA(cbo_QS.Text);
        }

        private void cbo_FA_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = bll_TB_PRO.GetListByStatus(1, "CC", "").Tables[0];
            if (dt.Rows.Count > 0)
            {
                string cid = dt.Rows[0]["C_ID"].ToString();
                commonSub.BindCCM(cid, cbo_FA.EditValue.ToString(), cbo_GW2);
                cbo_GW2.EditValue = "全部";
            }
        }
    }
}
