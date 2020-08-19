using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;
using MODEL;
using XGCAP.UI.P.PO.APS;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_ZGJH_SD : Form
    {
        private Bll_TRP_PLAN_ROLL bllTrpPlanRoll = new Bll_TRP_PLAN_ROLL();
        private Bll_TPP_ZG_PLAN bllTppZgPlan = new Bll_TPP_ZG_PLAN();
        private Bll_TRP_PLAN_ROLL_ITEM bllTrpPlanRollItem = new Bll_TRP_PLAN_ROLL_ITEM();
        private Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();

        private Bll_TSC_SLAB_MAIN bll_slab_main = new Bll_TSC_SLAB_MAIN();
        public FrmPO_ZGJH_SD()
        {
            InitializeComponent();
        }
        private List<Mod_TRP_PLAN_ROLL_ITEM> lst = null;
        private void FrmPO_ZGJH_SD_Load(object sender, EventArgs e)
        {
            CommonSub.BindIcbo("", "ZX", icbo_ZX_WXF);

            CommonSub.BindIcboNoAll("", "ZX", icbo_ZX_YXF);
            icbo_ZX_YXF.SelectedIndex = 0;

            CommonSub.BindIcbo_XF("", "ZX", icbo_XF_ZX);
            CommonSub.BindIcboNoAll("", "CC", icbo_lz3);
            dt_Start.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            dt_End.Text = DateTime.Now.ToString("yyyy-MM-dd");
            simpleButton1_Click(null, null);
            try
            {
                InitDrop();
            }
            catch (Exception ex)
            {


            }
            gv_PDJG.CustomColumnDisplayText += Gv_PDJG_CustomColumnDisplayText;
        }

        private void Gv_PDJG_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "C_MOVE_TYPE")
            {
                switch (e.DisplayText)
                {
                    case "S":
                        e.DisplayText = "已销售";
                        break;
                    case "N":
                        e.DisplayText = "待入库";
                        break;
                    case "DZ":
                        e.DisplayText = "待轧";
                        break;
                    case "NP":
                        e.DisplayText = "待开坯";
                        break;
                    case "R":
                        e.DisplayText = "入炉";
                        break;
                    case "C":
                        e.DisplayText = "出炉";
                        break;
                    case "EX":
                        e.DisplayText = "消耗";
                        break;
                    case "M":
                        e.DisplayText = "调拨中";
                        break;
                    case "E":
                        e.DisplayText = "入库";
                        break;
                    case "DX":
                        e.DisplayText = "待修磨";
                        break;
                    case "0":
                        e.DisplayText = "销售占用";
                        break;
                    case "1":
                        e.DisplayText = "销售实绩";
                        break;
                }
            }
        }

        private Bll_TPB_CHANGESPEC_TIME bll_changegg = new Bll_TPB_CHANGESPEC_TIME();

        #region 浇次计划列表鼠标拖动方法
        /// <summary>
        /// 浇次计划 行托动方法
        /// </summary>
        /// <param name="lst">加载的数据</param>
        /// <param name="gvSource">gridview</param>
        private void InitDrop()
        {
            var dropPlanToReq = new GridViewDragDropHelper(
                this.gv_Item, gv_Item, (row1, row2) =>
                {
                    if (row1 == row2) return;

                    var plan1 = gv_Item.GetRow(row1) as Mod_TRP_PLAN_ROLL_ITEM;
                    if (row2 < lst.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gv_Item.RowCount)
                        {
                            row2 = gv_Item.RowCount - 1;
                        }
                        var plan2 = gv_Item.GetRow(row2) as Mod_TRP_PLAN_ROLL_ITEM;
                        if (plan2 == null)
                            return;
                        lst.Remove(plan1);
                        var left = lst.TakeWhile(x => x.N_SORT < plan2.N_SORT).ToList();
                        var right = lst.Where(x => left.Contains(x) == false).ToList();
                        lst.Clear();
                        lst.AddRange(left);
                        lst.Add(plan1);
                        lst.AddRange(right);
                    }
                    else
                    {
                        lst.Remove(plan1);
                        lst.Add(plan1);
                    }
                    int n_minsort = (int)lst.Min(a => a.N_SORT);//最小排序号
                    DateTime dtB = (DateTime)lst.Min(a => a.D_P_START_TIME);//最小时间
                    string C_SPEC = "";//上一条计划的规格

                    for (int i = 0; i < lst.Count; i++)
                    {
                        int hggTime = 0;
                        if (C_SPEC != "" && C_SPEC != lst[i].C_SPEC)
                        {
                            hggTime = bll_changegg.Get_Time2(lst[i].C_STA_ID, C_SPEC, lst[i].C_SPEC);//换规格时间
                            C_SPEC = lst[i].C_SPEC;
                        }
                        lst[i].N_SORT = n_minsort;
                        lst[i].D_P_START_TIME = dtB;
                        lst[i].D_P_END_TIME = dtB.AddHours(((double)(lst[i].N_WGT / lst[i].N_MACH_WGT)));
                        dtB = ((DateTime)lst[i].D_P_END_TIME).AddMinutes(hggTime);
                        n_minsort = n_minsort + 1;
                    }




                    gv_Item.RefreshData();
                });

            dropPlanToReq.AllowDrop = true;


        }
        #endregion


        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            BindPlan();
        }

        /// <summary>
        /// 查询未下发的计划
        /// </summary>
        private void BindPlan()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Plan.DataSource = null;

                string strLineID = "";
                if (this.icbo_ZX_WXF.SelectedIndex > 0)
                {
                    strLineID = icbo_ZX_WXF.Properties.Items[this.icbo_ZX_WXF.SelectedIndex].Value.ToString();
                }

                DataTable dt = bllTrpPlanRoll.Get_Plan_WXF(strLineID, txt_gz_wxf.Text.Trim(), txt_bz_wxf.Text.Trim(), rbtn_state_Plan.SelectedIndex.ToString(), txt_Spec.Text.Trim(), 0, "").Tables[0];
                this.gc_Plan.DataSource = dt;
                this.gv_Plan.OptionsView.ColumnAutoWidth = false;
                this.gv_Plan.OptionsSelection.MultiSelect = true;

                SetGridViewRowNum.SetRowNum(gv_Plan);

                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        private void gv_Plan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_Plan.GetDataRow(e.FocusedRowHandle);
            if (dr != null)
            {
                txt_Wgt.Text = (Convert.ToDecimal(dr["N_WGT"].ToString()) - Convert.ToDecimal(dr["N_ISSUE_WGT"].ToString())).ToString();
                icbo_XF_ZX.EditValue = dr["C_STA_ID"].ToString();
            }
        }

        /// <summary>
        /// 下发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_xf_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Plan.GetDataRow(gv_Plan.FocusedRowHandle);
            if (dr != null)
            {
                decimal i_wgt = 0;
                if (!decimal.TryParse(txt_Wgt.Text.Trim(), out i_wgt))
                {
                    MessageBox.Show("下发重量只能填写整数！");
                    return;
                }
                else
                {
                    if (Convert.ToDecimal(txt_Wgt.Text.Trim()) <= 0)
                    {
                        MessageBox.Show("下发重量必须大于0！");
                        return;
                    }
                }

                if (DialogResult.No == MessageBox.Show("是否确认下发计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                string strLineID = "";
                if (dr["C_STA_ID"].ToString() != icbo_XF_ZX.EditValue.ToString())
                {
                    if (!string.IsNullOrEmpty(txt_Remark.Text.Trim()))
                    {
                        strLineID = icbo_XF_ZX.EditValue.ToString();
                    }
                    else
                    {
                        MessageBox.Show("下发的轧线和分配的轧线不一致，请填写备注信息！");
                        return;
                    }
                }
                else
                {
                    strLineID = dr["C_STA_ID"].ToString();
                }

                string result = bllTppZgPlan.DownPlan(dr["C_ID"].ToString(), Convert.ToDecimal(txt_Wgt.Text.Trim()), dt_Plan_Start.Text.Trim(), txt_Remark.Text.Trim(), strLineID);
                if (result == "1")
                {
                    MessageBox.Show("计划下发成功！");
                    BindPlan();
                    BindItem();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            else
            {
                MessageBox.Show("选择要下发的计划！");
                return;
            }
        }

        /// <summary>
        /// 查询已下发计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BindItem();
        }

        private void BindItem()
        {


            try
            {
                WaitingFrom.ShowWait("");

                string strLineID = "";
                if (this.icbo_ZX_YXF.SelectedIndex >= 0)
                {
                    strLineID = icbo_ZX_YXF.Properties.Items[this.icbo_ZX_YXF.SelectedIndex].Value.ToString();
                }

                string s_State = "1";

                if (icbo_status.SelectedIndex >= 0)
                {
                    s_State = icbo_status.Properties.Items[this.icbo_status.SelectedIndex].Value.ToString();
                }

                lst = bllTrpPlanRollItem.GetModelList(dt_Start.Text.Trim() + " 00:00:01", dt_End.Text.Trim() + " 23:59:59", txt_gz_yxf.Text.Trim(), txt_bz_yxf.Text.Trim(), strLineID, s_State);

                for (int i = 0; i < lst.Count; i++)
                {
                    lst[i].N_SORT = i + 1;
                }
                this.modTRPPLANROLLITEMBindingSource.DataSource = lst;
                this.gv_Item.OptionsView.ColumnAutoWidth = false;
                this.gv_Item.OptionsSelection.MultiSelect = true;

                SetGridViewRowNum.SetRowNum(gv_Item);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {


            }
        }

        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_canale_Click(object sender, EventArgs e)
        {
            int selectedHandle = 0;
            try
            {
                int[] aa = this.gv_Item.GetSelectedRows();
                if (aa.Length > 0)
                {
                    selectedHandle = this.gv_Item.GetSelectedRows()[0];
                    if (selectedHandle >= 0)
                    {
                        string c_cid = this.gv_Item.GetRowCellValue(selectedHandle, "C_ID").ToString();
                        if (DialogResult.No == MessageBox.Show("是否确认撤回计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                        {
                            return;
                        }
                        string result = bllTppZgPlan.BackPlan(c_cid);
                        if (result == "1")
                        {
                            MessageBox.Show("撤销成功！");
                            BindPlan();
                            BindItem();
                        }
                        else
                        {
                            MessageBox.Show(result);
                            return;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("选择要撤回的计划！");
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("选择要撤回的计划！");
                return;

            }
        }



        private void icbo_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (icbo_status.SelectedIndex == 0)
            {
                btn_canale.Enabled = true;
                btn_save.Enabled = true;
            }
            else
            {
                btn_canale.Enabled = false;
                btn_save.Enabled = false;

            }
        }
        /// <summary>
        /// 保存排序修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                bllTrpPlanRollItem.Update(lst[i].C_ID, (DateTime)lst[i].D_P_START_TIME, (DateTime)lst[i].D_P_END_TIME, (int)lst[i].N_SORT);
            }

        }


        private void btn_out1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_Plan);
        }

        private void btn_out2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_Item);
        }
        private void btn_AssePlanQuery_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Grd.Text))
            {
                MessageBox.Show("请选输入钢种进行查询!");
                return;
            }
            DataTable dt = bll_slab_main.GetKZgp("", "", txt_Grd.Text, txt_Std.Text);
            // DataTable dt = bllTrpPlanRoll.GetSlabInventory(txt_Grd.Text, txt_Spec.Text, txt_Std.Text);
            this.gc_PDJG.DataSource = dt;
            this.gv_PDJG.OptionsView.ColumnAutoWidth = false;
            this.gv_PDJG.OptionsSelection.MultiSelect = true;
            SetGridViewRowNum.SetRowNum(gv_Plan);
            this.gv_PDJG.OptionsView.ColumnAutoWidth = false;
            this.gv_PDJG.BestFitColumns();
        }

        private void rbtn_state_Plan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtn_state_Plan.SelectedIndex == 0)
            {
                btn_cancle_pc.Enabled = true;
                btn_xf.Enabled = true;
            }
            else
            {
                btn_cancle_pc.Enabled = false;
                btn_xf.Enabled = false;
            }
        }

        private void btn_cancle_pc_Click(object sender, EventArgs e)
        {

            DataRow dr = gv_Plan.GetDataRow(gv_Plan.FocusedRowHandle);
            if (dr != null)
            {

                if (DialogResult.No == MessageBox.Show("是否确认撤回选中的计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                bool result = Cls_APS_PC.CancleZGPlan(dr["C_ID"].ToString());
                if (result)
                {
                    MessageBox.Show("计划成功撤回！");
                    BindPlan();
                    BindItem();
                }
                else
                {
                    MessageBox.Show("撤回失败！");
                }
            }
            else
            {
                MessageBox.Show("选择要撤回的计划！");
                return;
            }

        }

        private void btn_query_jc_Click(object sender, EventArgs e)
        {
            try
            {
                string _strCCMID = "";
                if (this.icbo_lz3.SelectedIndex > 0)
                {
                    _strCCMID = this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();
                }
                WaitingFrom.ShowWait("");
                BindLsbGrid(_strCCMID, this.rbtn_status.SelectedIndex + 1);
                WaitingFrom.CloseWait();


            }
            catch (Exception ex)
            {

            }
        }

        #region 查询浇次计划
        /// <summary>
        /// 查询浇次计划方法
        /// </summary>
        /// <param name="strCCMID">连铸机</param>
        private void BindLsbGrid(string strCCMID, int n_status)
        {
            var jc_cast_plan = bll_cast_plan.GetModelList(strCCMID, n_status,"").OrderBy(a => a.N_SORT).ToList();

            this.gridControl6.DataSource = jc_cast_plan;
            this.gridView6.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView6);

            //this.gridView6.RefreshData();
            this.gridView6.BestFitColumns();

        }

        #endregion

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl6, "浇次计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
