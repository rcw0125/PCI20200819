using Common;
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

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_ZGJH : Form
    {
        private Bll_TRP_PLAN_ROLL bll_plan = new Bll_TRP_PLAN_ROLL();//轧钢计划表
        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();//订单表
        private Bll_TRP_PLAN_ITEM bllTrpPlanItem = new Bll_TRP_PLAN_ITEM();
        private Bll_TPP_LG_PLAN bllTppLgPlan = new Bll_TPP_LG_PLAN();
        private Bll_TPP_ZG_PLAN bllTppZgPlan = new Bll_TPP_ZG_PLAN();

        public FrmPO_ZGJH()
        {
            InitializeComponent();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl1);
        }
        DataTable dtzgjh = null;
        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            BindPlan();
        }

        private void BindPlan()
        {
            WaitingFrom.ShowWait("");
            string strLineID = "";
            if (this.icbo_zx4.SelectedIndex > 0)
            {
                strLineID = icbo_zx4.Properties.Items[this.icbo_zx4.SelectedIndex].Value.ToString();
            }
            string strSFZP = "";
            int SFXF = 6;
            if (this.rbtn_zg.SelectedIndex == 0)
            {
                SFXF = 6;
                strSFZP = "";
            }
            if (this.rbtn_zg.SelectedIndex == 1)
            {
                SFXF = 1;
                strSFZP = "";
            }
            if (this.rbtn_zg.SelectedIndex == 2)
            {
                SFXF = 1;
                strSFZP = "Y";
            }


            this.gridControl1.DataSource = null;

            DataTable dt = bll_plan.GetZGJH(strLineID, SFXF, txt_gz4.Text.Trim(), "", txt_bz4.Text.Trim(), strSFZP).Tables[0];
            dtzgjh = dt;
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            //gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();

            BindPlanGroup(strLineID);

            WaitingFrom.CloseWait();
        }

        private void BindPlanGroup(string strLineID)
        {
            DataTable dt_ZX = bllTrpPlanItem.Get_ZX_List(strLineID).Tables[0];

            if (dt_ZX.Rows.Count > 0)
            {
                DataTable dt_Plan = bllTrpPlanItem.Get_Plan_Item_List(strLineID).Tables[0];

                List<Mod_TRP_PLAN_ITEM> lst = bllTrpPlanItem.DataTableToList(dt_Plan);

                List<Mod_TRP_PLAN_ITEM> lstResult = new List<Mod_TRP_PLAN_ITEM>();

                for (int i = 0; i < dt_ZX.Rows.Count; i++)
                {
                    var lstTemp = lst.Where(x => x.C_LINE_CODE == dt_ZX.Rows[i]["C_LINE_CODE"].ToString()).ToList();

                    for (int iTemp = 0; iTemp < lstTemp.Count; iTemp++)
                    {
                        if (lstResult.Count == 0)
                        {
                            lstResult.Add(lstTemp[i]);

                            continue;
                        }

                        int num = 0;

                        for (int iResult = 0; iResult < lstResult.Count; iResult++)
                        {
                            if (lstTemp[iTemp].C_SPEC == lstResult[iResult].C_SPEC && lstTemp[iTemp].D_P_START_TIME == lstResult[iResult].D_P_END_TIME && lstTemp[iTemp].C_LINE_CODE == lstResult[iResult].C_LINE_CODE)
                            {
                                lstResult[iResult].D_P_END_TIME = lstTemp[iTemp].D_P_END_TIME;
                                lstResult[iResult].N_ROLL_PROD_WGT = lstResult[iResult].N_ROLL_PROD_WGT + lstTemp[iTemp].N_ROLL_PROD_WGT;

                                num++;

                                break;
                            }
                        }

                        if (num == 0)
                        {
                            lstResult.Add(lstTemp[iTemp]);

                            continue;
                        }
                    }
                }

                gc_Item.DataSource = lstResult;
                SetGridViewRowNum.SetRowNum(gv_Item);
            }
            else
            {
                gc_Item.DataSource = null;
            }
        }


        private void FrmPO_ZGJH_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            CommonSub.BindIcbo("", "ZX", icbo_zx4);
            //rbtn_zg_SelectedIndexChanged(null, null);
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            try
            {
                //int rowIndex = this.gridView1.FocusedRowHandle;
                //if (rowIndex == 0)
                //{
                //    MessageBox.Show("已经是第一行了!", "提示");
                //    return;
                //}
                //int A = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex, "N_SORT").ToString());//获取当前行的序号
                //gridView1.SetRowCellValue(rowIndex - 1, "N_SORT", A);
                //gridView1.SetRowCellValue(rowIndex, "N_SORT", A - 1);
                //#region 保存当前排序
                //for (int i = 0; i < gridView1.RowCount; i++)
                //{
                //    Mod_TRP_PLAN_ROLL modpx = bll_plan.GetModel(gridView1.GetRowCellValue(i, "C_ID").ToString());
                //    modpx.N_SORT = Convert.ToInt32(gridView1.GetRowCellValue(i, "N_SORT").ToString());
                //    bll_plan.Update(modpx);
                //}
                //btn_query_zg_Click(null, null);
                //#endregion

                //this.gridView1.SelectRow(rowIndex - 1);
                //this.gridView1.FocusedRowHandle = rowIndex - 1;



            }
            catch (Exception)
            {

            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            //string strLineID = "";
            //if (this.icbo_zx4.SelectedIndex > 0)
            //{
            //    strLineID = icbo_zx4.Properties.Items[this.icbo_zx4.SelectedIndex].Value.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("请选择产线！");
            //    return;

            //}
            //DataTable dt = bll_plan.GetZGJH(strLineID, 0, "", "", "").Tables[0];
            //AutoSort(dt);
            //btn_query_zg_Click(null,null);
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            try
            {
                //int rowIndex = this.gridView1.FocusedRowHandle;
                //if (rowIndex == this.gridView1.RowCount - 1)
                //{
                //    MessageBox.Show("已经是最后一行了!", "提示");
                //    return;
                //}
                //int A = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex, "N_SORT").ToString());//获取当前行的序号
                //gridView1.SetRowCellValue(rowIndex + 1, "N_SORT", A);
                //gridView1.SetRowCellValue(rowIndex, "N_SORT", A + 1);
                //#region 保存当前排序
                //for (int i = 0; i < gridView1.RowCount; i++)
                //{
                //    Mod_TRP_PLAN_ROLL modpx = bll_plan.GetModel(gridView1.GetRowCellValue(i, "C_ID").ToString());
                //    modpx.N_SORT = Convert.ToInt32(gridView1.GetRowCellValue(i, "N_SORT").ToString());
                //    bll_plan.Update(modpx);
                //}
                //btn_query_zg_Click(null, null);
                //#endregion

                //this.gridView1.SelectRow(rowIndex + 1);
                //this.gridView1.FocusedRowHandle = rowIndex + 1;



            }
            catch (Exception)
            {

            }
        }

        private void btn_xf_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string strLineID = "";
            //    if (this.icbo_zx4.SelectedIndex > 0)
            //    {
            //        strLineID = icbo_zx4.Properties.Items[this.icbo_zx4.SelectedIndex].Value.ToString();
            //    }

            //    if (string.IsNullOrEmpty(strLineID))
            //    {
            //        MessageBox.Show("请选择需要下发的轧线！");
            //        return;
            //    }

            //    if (string.IsNullOrEmpty(txt_num.Text.Trim()))
            //    {
            //        MessageBox.Show("请填写准备下发的计划数量！");
            //        return;
            //    }

            //    int numPlan = 0;
            //    if (!int.TryParse(txt_num.Text.Trim(), out numPlan))
            //    {
            //        MessageBox.Show("计划数量只能填写整数！");
            //        return;
            //    }

            //    if (DialogResult.No == MessageBox.Show("确认下发" + txt_num.Text.Trim() + "条轧钢计划给MES？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            //    {
            //        return;
            //    }

            //    string result = bllTppZgPlan.DownPlan(strLineID, Convert.ToInt32(txt_num.Text.Trim()));

            //    if (result == "1")
            //    {
            //        MessageBox.Show("下发成功！");
            //        BindPlan();
            //    }
            //    else
            //    {
            //        MessageBox.Show(result);
            //    }

            //}
            //catch (Exception)
            //{

            //    btn_query_zg_Click(null, null);
            //}

        }

        private void btn_canale_Click(object sender, EventArgs e)
        {
            try
            {
                string strLineID = "";
                if (this.icbo_zx4.SelectedIndex > 0)
                {
                    strLineID = icbo_zx4.Properties.Items[this.icbo_zx4.SelectedIndex].Value.ToString();
                }

                if (string.IsNullOrEmpty(strLineID))
                {
                    MessageBox.Show("请选择需要撤销的轧线！");
                    return;
                }

                //string result = bllTppZgPlan.BackPlan(strLineID, Convert.ToInt32(txt_num.Text.Trim()));

                //if (result == "1")
                //{
                //    MessageBox.Show("撤销成功！");
                //    BindPlan();
                //}
                //else
                //{
                //    MessageBox.Show(result);
                //}
            }
            catch (Exception)
            {

                btn_query_zg_Click(null, null);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //WaitingFrom.ShowWait("");
            //DataTable dtdchs = dtzgjh.Clone();//选中的需要评价的订单
            //int[] rownumber = this.gridView1.GetSelectedRows();//获取选中行号数组；
            //if (rownumber.Length > 0)
            //{
            //    for (int i = 0; i < rownumber.Length; i++)
            //    {
            //        int selectedHandle = rownumber[i];
            //        DataRow dr = dtdchs.NewRow();
            //        dr.ItemArray = this.gridView1.GetDataRow(i).ItemArray;
            //        dtdchs.Rows.Add(dr);
            //    }
            //    dtdchs.DefaultView.Sort = " N_SORT ";//将选中的订单按照排产目标进行排序
            //    dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表
            //}
            //for (int j = 0; j < dtdchs.Rows.Count; j++)
            //{
            //    string C_PLAN_ID = dtdchs.Rows[j]["C_ID"].ToString();
            //    Mod_TRP_PLAN_ROLL modPlan = bll_plan.GetModel(C_PLAN_ID);
            //    decimal WGT = Convert.ToDecimal(modPlan.N_WGT);
            //    string orderId = modPlan.C_INITIALIZE_ITEM_ID;
            //    bll_order.BackZGWGT(orderId, WGT);
            //    bll_plan.Delete(C_PLAN_ID);
            //}
            //btn_query_zg_Click(null, null);
            //WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 删除计划
        /// </summary>
        /// <param name="C_PLAN_ID">计划主键</param>
        public void DeletePlan(string C_PLAN_ID)
        {
            //C_INITIALIZE_ITEM_ID

        }


        private void rbtn_zg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtn_zg.SelectedIndex == 0)
            {
                btn_canale.Enabled = false;
                btn_xf.Enabled = true;
                this.btn_delete.Enabled = true;
                btn_query_zg_Click(null, null);
            }
            else if (rbtn_zg.SelectedIndex == 1)
            {
                btn_canale.Enabled = true;
                btn_xf.Enabled = false;
                this.btn_delete.Enabled = false;
                btn_query_zg_Click(null, null);
            }
            else
            {
                btn_canale.Enabled = false;
                btn_xf.Enabled = false;
                this.btn_delete.Enabled = false;
                btn_query_zg_Click(null, null);
            }
        }

        private void btn_CreatPlan_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("正在生成轧钢计划，请稍后...");

            //string result = bllTppLgPlan.Update_ZG_Plan_New();
            string result = bllTppZgPlan.Update_ZG_Plan_New("0", "", "", "", "", "");

            WaitingFrom.CloseWait();

            if (result == "成功")
            {
                MessageBox.Show("计划生成成功！");
            }
            else
            {
                MessageBox.Show(result);
                return;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //try
            //{
            //    DataRow dr = gridView1.GetDataRow(e.FocusedRowHandle);
            //    if (dr != null)
            //    {
            //        DataTable dt = bllTrpPlanItem.Get_Item_List(dr["C_ID"].ToString()).Tables[0];

            //        gc_Item.DataSource = dt;
            //        SetGridViewRowNum.SetRowNum(gv_Item);
            //    }
            //    else
            //    {
            //        gc_Item.DataSource = null;
            //    }
            //}
            //catch
            //{

            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");

            string result = bllTppLgPlan.Update_ZG_Plan_New();

            WaitingFrom.CloseWait();

            if (result == "成功")
            {
                MessageBox.Show("计划生成成功！");
            }
            else
            {
                MessageBox.Show(result);
                return;
            }
        }

        /// <summary>
        /// 指定计划，重新生成计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Plan_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                string strLineID = "";
                if (this.icbo_zx4.SelectedIndex > 0)
                {
                    strLineID = icbo_zx4.Properties.Items[this.icbo_zx4.SelectedIndex].Value.ToString();
                }

                if (string.IsNullOrEmpty(strLineID))
                {
                    MessageBox.Show("请选择需要下发的轧线！");
                    return;
                }

                string strType = "1";
                string strGZ = dr["C_STL_GRD"].ToString();
                string strBZ = dr["C_STD_CODE"].ToString();
                string strGG = dr["C_SPEC"].ToString();
                string strPlanID = dr["C_ID"].ToString();

                if (DialogResult.No == MessageBox.Show("确认先生产：钢种" + strGZ + "标准" + strBZ + "规格" + strGG + "的计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                WaitingFrom.ShowWait("正在生成轧钢计划，请稍后...");

                string result = bllTppZgPlan.Update_ZG_Plan_New(strType, strLineID, strGZ, strBZ, strGG, strPlanID);

                if (result == "成功")
                {
                    MessageBox.Show("计划生成成功！");
                }
                else
                {
                    MessageBox.Show(result);
                    return;
                }

                WaitingFrom.CloseWait();
            }
            else
            {
                MessageBox.Show("请选择需要指定的下发计划！");
                return;
            }
        }
    }
}
