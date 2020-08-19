using BLL;
using Common;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_ZGJH_SD_NEWS : Form
    {
        public FrmPO_ZGJH_SD_NEWS()
        {
            InitializeComponent();
        }

        private Bll_TRP_PLAN_ROLL bllTrpPlanRoll = new Bll_TRP_PLAN_ROLL();
        private Bll_TPP_ZG_PLAN bllTppZgPlan = new Bll_TPP_ZG_PLAN();
        private Bll_TRP_PLAN_ROLL_ITEM bllTrpPlanRollItem = new Bll_TRP_PLAN_ROLL_ITEM();
        private Bll_TRP_PLAN_ROLL_ITEM_INFO bllTrpPlanRollItemInfo = new Bll_TRP_PLAN_ROLL_ITEM_INFO();
        private Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();
        private Bll_TSC_SLAB_MAIN bll_slab_main = new Bll_TSC_SLAB_MAIN();
        private List<Mod_TRP_PLAN_ROLL_ITEM_INFO> lst = null;
        private List<Mod_TRP_PLAN_ROLL_ITEM> lst2 = null;
        private Bll_TPB_CHANGESPEC_TIME bll_changegg = new Bll_TPB_CHANGESPEC_TIME();

        private void FrmPO_ZGJH_SD_NEWS_Load(object sender, EventArgs e)
        {
            CommonSub.BindIcbo("", "ZX", icbo_ZX_WXF);

            CommonSub.BindIcboNoAll("", "ZX", icbo_ZX_YXF);
            icbo_ZX_YXF.SelectedIndex = 0;
            BindSpec();//加载线材计划查询的规格


            dtp_form1.Text = Cls_Order_PC.GetDXFristDay()[0];
            this.dtp_end1.Text = Cls_Order_PC.GetDXFristDay()[1];

            CommonSub.BindIcbo_XF("", "ZX", icbo_XF_ZX);
            CommonSub.BindIcboNoAll("", "CC", icbo_lz3);
            dt_Start.Text = Cls_Order_PC.GetDXFristDay()[0];// DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            dt_End.Text = Cls_Order_PC.GetDXFristDay()[1];// DateTime.Now.ToString("yyyy-MM-dd");


            simpleButton1_Click_1(null, null);
            try
            {
                InitDrop();
                InitDrop2();
            }
            catch (Exception ex)
            {


            }
            gv_PDJG.CustomColumnDisplayText += Gv_PDJG_CustomColumnDisplayText;
            this.btn_Cancel.Left = gc_Item_Info.Size.Width + 10;
            this.btn_SaveSort.Left = gc_Item_Info.Size.Width + this.btn_Cancel.Width + 12;
        }

        /// <summary>
        /// 绑定订单下发重量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Plan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_Plan.GetDataRow(e.FocusedRowHandle);
            if (dr != null)
            {
                txt_Wgt.Text = (Convert.ToDecimal(dr["N_WGT"].ToString()) - Convert.ToDecimal(dr["N_ISSUE_WGT"].ToString())).ToString();
                icbo_XF_ZX.EditValue = dr["C_STA_ID"].ToString();
            }
        }


        #region 加载线材计划查询的规格
        /// <summary>
        /// 加载线材计划查询的规格
        /// </summary>
        public void BindSpec()
        {
            DataTable dt = bllTrpPlanRoll.Get_Spec().Tables[0];
            this.txt_Spec.Properties.Items.Clear();

            CheckedListBoxItem[] itemListQuery = new CheckedListBoxItem[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                itemListQuery[i] = new CheckedListBoxItem(dt.Rows[i]["C_SPEC"].ToString(), dt.Rows[i]["C_SPEC"].ToString());
            }
            this.txt_Spec.Properties.Items.AddRange(itemListQuery);
        }
        #endregion

        #region 表格状态显示
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
        #endregion

        #region 浇次计划列表鼠标拖动方法
        /// <summary>
        /// 订单计划（中间表） 行托动方法
        /// </summary>
        /// <param name="lst">加载的数据</param>
        /// <param name="gvSource">gridview</param>
        private void InitDrop()
        {
            var dropPlanToReq = new GridViewDragDropHelper(
                this.gv_Item_Info, gv_Item_Info, (row1, row2) =>
                {
                    if (row1 == row2) return;

                    var plan1 = gv_Item_Info.GetRow(row1) as Mod_TRP_PLAN_ROLL_ITEM_INFO;
                    if (row2 < lst.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gv_Item_Info.RowCount)
                        {
                            row2 = gv_Item_Info.RowCount - 1;
                        }
                        var plan2 = gv_Item_Info.GetRow(row2) as Mod_TRP_PLAN_ROLL_ITEM_INFO;
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
                    gv_Item_Info.RefreshData();
                });

            dropPlanToReq.AllowDrop = true;
        }


        /// <summary>
        /// 计划 行托动方法
        /// </summary>
        /// <param name="lst">加载的数据</param>
        /// <param name="gvSource">gridview</param>
        private void InitDrop2()
        {
            var dropPlanToReq = new GridViewDragDropHelper(
                this.gv_Item, gv_Item, (row1, row2) =>
                {
                    if (row1 == row2) return;

                    var plan1 = gv_Item.GetRow(row1) as Mod_TRP_PLAN_ROLL_ITEM;
                    if (row2 < lst2.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gv_Item.RowCount)
                        {
                            row2 = gv_Item.RowCount - 1;
                        }
                        var plan2 = gv_Item.GetRow(row2) as Mod_TRP_PLAN_ROLL_ITEM;
                        if (plan2 == null)
                            return;
                        lst2.Remove(plan1);
                        var left = lst2.TakeWhile(x => x.N_SORT < plan2.N_SORT).ToList();
                        var right = lst2.Where(x => left.Contains(x) == false).ToList();
                        lst2.Clear();
                        lst2.AddRange(left);
                        lst2.Add(plan1);
                        lst2.AddRange(right);
                    }
                    else
                    {
                        lst2.Remove(plan1);
                        lst2.Add(plan1);
                    }
                    int n_minsort = (int)lst2.Min(a => a.N_SORT);//最小排序号
                    DateTime dtB = (DateTime)lst2.Min(a => a.D_P_START_TIME);//最小时间
                    string C_SPEC = "";//上一条计划的规格

                    for (int i = 0; i < lst2.Count; i++)
                    {
                        int hggTime = 0;
                        if (C_SPEC != "" && C_SPEC != lst2[i].C_SPEC)
                        {
                            hggTime = bll_changegg.Get_Time2(lst2[i].C_STA_ID, C_SPEC, lst2[i].C_SPEC);//换规格时间
                            C_SPEC = lst2[i].C_SPEC;
                        }
                        lst2[i].N_SORT = n_minsort;
                        lst2[i].D_P_START_TIME = dtB;
                        lst2[i].D_P_END_TIME = dtB.AddHours(((double)(lst2[i].N_WGT / lst2[i].N_MACH_WGT)));
                        dtB = ((DateTime)lst2[i].D_P_END_TIME).AddMinutes(hggTime);
                        n_minsort = n_minsort + 1;
                    }
                    gv_Item.RefreshData();
                });

            dropPlanToReq.AllowDrop = true;
        }
        #endregion


        /// <summary>
        /// 加载订单计划
        /// </summary>
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

                lst2 = bllTrpPlanRollItem.GetModelList(dt_Start.Text.Trim() + " 00:00:01", dt_End.Text.Trim() + " 23:59:59", txt_gz_yxf.Text.Trim(), txt_bz_yxf.Text.Trim(), strLineID, s_State);

                for (int i = 0; i < lst2.Count; i++)
                {
                    lst2[i].N_SORT = i + 1;
                }
                this.modTRPPLANROLLITEMbindingSource.DataSource = lst2;
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
        /// 加载订单计划中间表
        /// </summary>
        private void BindItemInfo()
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


                lst = bllTrpPlanRollItemInfo.GetModelList(dt_Start.Text.Trim() + " 00:00:01", dt_End.Text.Trim() + " 23:59:59", txt_gz_yxf.Text.Trim(), txt_bz_yxf.Text.Trim(), strLineID, s_State);

                for (int i = 0; i < lst.Count; i++)
                {
                    lst[i].N_SORT = i + 1;
                }
                this.modTRPPLANROLLITEMINFOBindingSource.DataSource = lst;
                this.gv_Item_Info.OptionsView.ColumnAutoWidth = false;
                this.gv_Item_Info.OptionsSelection.MultiSelect = true;
                gv_Item_Info.OptionsSelection.MultiSelect = true;
                gv_Item_Info.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                SetGridViewRowNum.SetRowNum(gv_Item_Info);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {


            }
        }

        /// <summary>
        /// 加载未下发的计划
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

                // rbtn_state_Plan.SelectedIndex 未下发，已下发，已完工，全部  rbtn_state_Plan.SelectedIndex.ToString()
                DataTable dt = bllTrpPlanRoll.Get_Plan_WXF(strLineID, txt_gz_wxf.Text.Trim(), txt_bz_wxf.Text.Trim(), rbtn_state_Plan.SelectedIndex.ToString(), txt_Spec.Text.Trim(), radioGroup1.SelectedIndex, txt_order_no.Text).Tables[0];
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

        /// <summary>
        /// 查询未下发订单计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_zg_Click_1(object sender, EventArgs e)
        {
            BindPlan();
        }

        /// <summary>
        /// 查询订单计划中间表 和 订单计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            BindItemInfo();
            BindItem();
        }

        /// <summary>
        /// 订单计划下发
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

                if (dr["C_PACK"].ToString().Trim() == "")
                {
                    MessageBox.Show("包装要求不能为空！");
                    return;
                }
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

                string result = bllTrpPlanRollItemInfo.DownPlan(dr["C_ID"].ToString(), Convert.ToDecimal(txt_Wgt.Text.Trim()), dt_Plan_Start.Text.Trim(), txt_Remark.Text.Trim(), strLineID, txt_HGG.Text.Trim());
                if (result == "1")
                {
                    txt_HGG.Text = "";
                    MessageBox.Show("计划下发成功！");
                    BindPlan();
                    BindItemInfo();
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
        /// 订单计划中间表撤回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_canale_Click(object sender, EventArgs e)
        {
            int selectedHandle = 0;
            try
            {
                int[] aa = this.gv_Item_Info.GetSelectedRows();
                if (aa.Length > 0)
                {
                    selectedHandle = this.gv_Item_Info.GetSelectedRows()[0];
                    if (selectedHandle >= 0)
                    {
                        string c_cid = this.gv_Item_Info.GetRowCellValue(selectedHandle, "C_ID").ToString();
                        if (DialogResult.No == MessageBox.Show("是否确认撤回计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                        {
                            return;
                        }
                        string result = bllTrpPlanRollItemInfo.BackPlan(c_cid);
                        if (result == "1")
                        {
                            MessageBox.Show("撤销成功！");
                            BindPlan();
                            BindItemInfo();
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

        /// <summary>
        /// 保存订单调整计划顺序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                bllTrpPlanRollItemInfo.UpdateSort(lst[i].C_ID, (DateTime)lst[i].D_P_START_TIME, (DateTime)lst[i].D_P_END_TIME, (int)lst[i].N_SORT);
            }
        }

        /// <summary>
        /// 合并订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Merge_Click(object sender, EventArgs e)
        {


            int[] rownumber = gv_Item_Info.GetSelectedRows();//获取选中行号数组；
                                                             //选择多行才能合并
            if (rownumber.Length == 1)
            {
                MessageBox.Show("两条订单以上才能合并");
            }

            //按顺序订单才能合并
            if (rownumber.Length > 1)
            {

                //下发量
                decimal wgt = 0;

                //按顺序
                if (rownumber[0] != 0)
                {
                    MessageBox.Show("必须按顺序执行合并");
                    return;
                }

                //相邻订单才能合并
                int len = rownumber.Length;
                for (int i = 0; i < len; i++)
                {
                    if (rownumber[i] != i)
                    {
                        MessageBox.Show("必须相邻订单才能合并");
                        return;
                    }
                }

                List<Mod_TRP_PLAN_ROLL_ITEM_INFO> all = new List<Mod_TRP_PLAN_ROLL_ITEM_INFO>();
                //（相同规格、钢种、执行标准、包装要求）订单才能合并
                for (int j = 0; j < len; j++)
                {
                    if (j != rownumber.Length - 1)
                    {
                        int selectedHandle = rownumber[j];
                        int selectedHandles = rownumber[j + 1];
                        Mod_TRP_PLAN_ROLL_ITEM_INFO model = (Mod_TRP_PLAN_ROLL_ITEM_INFO)this.modTRPPLANROLLITEMINFOBindingSource[selectedHandle];
                        all.Add(model);
                        Mod_TRP_PLAN_ROLL_ITEM_INFO models = (Mod_TRP_PLAN_ROLL_ITEM_INFO)this.modTRPPLANROLLITEMINFOBindingSource[selectedHandles];
                        if (model.C_SPEC != models.C_SPEC
                            || model.C_STL_GRD != models.C_STL_GRD
                            || model.C_STD_CODE != models.C_STD_CODE
                            || model.C_PACK != models.C_PACK)
                        {
                            MessageBox.Show("必须同规格、钢种、执行标准、包装要求才能合并");
                            return;
                        }
                    }
                    else
                    {
                        int selectedHandle = rownumber[j];
                        Mod_TRP_PLAN_ROLL_ITEM_INFO model = (Mod_TRP_PLAN_ROLL_ITEM_INFO)this.modTRPPLANROLLITEMINFOBindingSource[selectedHandle];
                        all.Add(model);
                    }
                }

                string area = "";
                var partial = all.Where(x => x.C_AREA == "国际贸易部");
                if (partial.Count() > 0)
                {
                    area = "国际贸易部";
                    if (partial.Count() != all.Count)
                    {
                        MessageBox.Show("地区包含国际贸易部，必须同区域才能合并。");
                        return;
                    }
                }

                if (DialogResult.No == MessageBox.Show("是否确认合并订单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                List<string> ids = new List<string>();
                //计算下发量
                for (int i = 0; i < len; i++)
                {
                    int selectedHandle = rownumber[i];
                    Mod_TRP_PLAN_ROLL_ITEM_INFO model = (Mod_TRP_PLAN_ROLL_ITEM_INFO)this.modTRPPLANROLLITEMINFOBindingSource[selectedHandle];
                    wgt += model.N_ISSUE_WGT.Value;
                    ids.Add(model.C_ID);
                }

                #region 下发订单明细预备
                Mod_TRP_PLAN_ROLL_ITEM_INFO modelInfo = (Mod_TRP_PLAN_ROLL_ITEM_INFO)this.modTRPPLANROLLITEMINFOBindingSource[rownumber[0]];
                string result = bllTrpPlanRollItemInfo.DownPlans(modelInfo, wgt, ids, area);
                if (result == "1")
                {
                    MessageBox.Show("计划下发成功！");
                    BindPlan();
                    BindItemInfo();
                    BindItem();
                }
                else
                {
                    MessageBox.Show(result);
                }
                #endregion


            }

        }

        /// <summary>
        /// 非合并下发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int[] rownumber = gv_Item_Info.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length == 0 || rownumber.Length > 1)
            {
                MessageBox.Show("请选择一条下发");
                return;
            }

            Mod_TRP_PLAN_ROLL_ITEM_INFO modelInfo = (Mod_TRP_PLAN_ROLL_ITEM_INFO)this.modTRPPLANROLLITEMINFOBindingSource[rownumber[0]];
            string result = bllTrpPlanRollItemInfo.DownPlans(modelInfo);
            if (result == "1")
            {
                MessageBox.Show("计划下发成功！");
                BindPlan();
                BindItemInfo();
                BindItem();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            int[] rownumber = gv_Item.GetSelectedRows();
            if (rownumber.Length == 0)
            {
                MessageBox.Show("请选择一条订单计划撤回");
                return;
            }
            Mod_TRP_PLAN_ROLL_ITEM model = (Mod_TRP_PLAN_ROLL_ITEM)this.modTRPPLANROLLITEMbindingSource[rownumber[0]];
            string result = bllTrpPlanRollItemInfo.BackPlans(model.C_ID);
            if (result == "1")
            {
                MessageBox.Show("撤回成功！");
                BindPlan();
                BindItemInfo();
                BindItem();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void icbo_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (icbo_status.SelectedIndex == 0)
            {
                //btn_canale.Enabled = true;
                //btn_save.Enabled = true;
                btn_Cancel.Enabled = true;
            }
            else
            {
                //btn_canale.Enabled = false;
                //btn_save.Enabled = false;
                btn_Cancel.Enabled = false;
            }
        }

        private void btn_SaveSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst2.Count; i++)
            {
                bllTrpPlanRollItem.Update(lst2[i].C_ID, (DateTime)lst2[i].D_P_START_TIME, (DateTime)lst2[i].D_P_END_TIME, (int)lst2[i].N_SORT);
            }
        }

        private void gv_Item_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gv_Item_Tool_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            //GridHitInfo hitInfo = gv_Item.CalcHitInfo(e.ControlMousePosition);
            //if (hitInfo.RowHandle < 0 || hitInfo.Column == null || hitInfo.HitTest != GridHitTest.RowCell)
            //{
            //    gv_Item_Tool.HideHint();
            //    return;
            //}
            //var row = lst2[hitInfo.RowHandle];
            //if (row.C_ORDER_NO == "合并订单")
            //{
            //    object obj = bllTrpPlanRollItemInfo.GetJoinOrder(row.C_ID);
            //    string message = obj == null ? "" : obj.ToString();
            //    e.Info = new ToolTipControlInfo("", message);
            //}
        }
    }
}
