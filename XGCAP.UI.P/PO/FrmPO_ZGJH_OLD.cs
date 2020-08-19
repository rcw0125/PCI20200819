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
    public partial class FrmPO_ZGJH_OLD : Form
    {
        private Bll_TRP_PLAN_ROLL bll_plan = new Bll_TRP_PLAN_ROLL();//轧钢计划表
        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();//订单表
        public FrmPO_ZGJH_OLD()
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
            WaitingFrom.ShowWait("");
            string strLineID = "";
            if (this.icbo_zx4.SelectedIndex > 0)
            {
                strLineID = icbo_zx4.Properties.Items[this.icbo_zx4.SelectedIndex].Value.ToString();
            }
            string strSFZP = "";
            int SFXF = 0;
            if (this.rbtn_zg.SelectedIndex == 0)
            {
                SFXF = 0;
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



            DataTable dt = bll_plan.GetZGJH(strLineID, SFXF, txt_gz4.Text.Trim(), "", txt_bz4.Text.Trim(), strSFZP).Tables[0];
            AutoSort(dt);
            dt = bll_plan.GetZGJH(strLineID, this.rbtn_zg.SelectedIndex, txt_gz4.Text.Trim(), "", txt_bz4.Text.Trim(), strSFZP).Tables[0];
            dtzgjh = dt;
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
            WaitingFrom.CloseWait();
        }


        public void AutoSort(DataTable dt)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    int n_sort = bll_plan.GetMaxSort(dt.Rows[0]["C_STA_ID"].ToString());
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Mod_TRP_PLAN_ROLL modpx = bll_plan.GetModel(gridView1.GetRowCellValue(i, "C_ID").ToString());
                        modpx.N_SORT = n_sort + i;
                        bll_plan.Update(modpx);
                    }
                }
            }
            catch (Exception)
            {

            }


        }

        private void FrmPO_ZGJH_OLD_Load(object sender, EventArgs e)
        {
            CommonSub.BindIcbo("", "ZX", icbo_zx4);
            rbtn_zg_SelectedIndexChanged(null,null);
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = this.gridView1.FocusedRowHandle;
                if (rowIndex == 0)
                {
                    MessageBox.Show("已经是第一行了!", "提示");
                    return;
                }
                int A = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex, "N_SORT").ToString());//获取当前行的序号
                gridView1.SetRowCellValue(rowIndex - 1, "N_SORT", A);
                gridView1.SetRowCellValue(rowIndex, "N_SORT", A - 1);
                #region 保存当前排序
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    Mod_TRP_PLAN_ROLL modpx = bll_plan.GetModel(gridView1.GetRowCellValue(i, "C_ID").ToString());
                    modpx.N_SORT = Convert.ToInt32(gridView1.GetRowCellValue(i, "N_SORT").ToString());
                    bll_plan.Update(modpx);
                }
                btn_query_zg_Click(null, null);
                #endregion

                this.gridView1.SelectRow(rowIndex - 1);
                this.gridView1.FocusedRowHandle = rowIndex - 1;



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
                int rowIndex = this.gridView1.FocusedRowHandle;
                if (rowIndex == this.gridView1.RowCount - 1)
                {
                    MessageBox.Show("已经是最后一行了!", "提示");
                    return;
                }
                int A = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex, "N_SORT").ToString());//获取当前行的序号
                gridView1.SetRowCellValue(rowIndex + 1, "N_SORT", A);
                gridView1.SetRowCellValue(rowIndex, "N_SORT", A + 1);
                #region 保存当前排序
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    Mod_TRP_PLAN_ROLL modpx = bll_plan.GetModel(gridView1.GetRowCellValue(i, "C_ID").ToString());
                    modpx.N_SORT = Convert.ToInt32(gridView1.GetRowCellValue(i, "N_SORT").ToString());
                    bll_plan.Update(modpx);
                }
                btn_query_zg_Click(null, null);
                #endregion

                this.gridView1.SelectRow(rowIndex + 1);
                this.gridView1.FocusedRowHandle = rowIndex + 1;



            }
            catch (Exception)
            {

            }
        }

        private void btn_xf_Click(object sender, EventArgs e)
        {
            try
            {
                //for (int i = 0; i < Convert.ToInt32(this.txt_num.Text); i++)
                //{
                //    Mod_TRP_PLAN_ROLL modpx = bll_plan.GetModel(gridView1.GetRowCellValue(i, "C_ID").ToString());
                //    modpx.N_STATUS = 1;
                //    bll_plan.Update(modpx);
                //}


                WaitingFrom.ShowWait("");
                DataTable dtdchs = dtzgjh.Clone();//选中的需要评价的订单
                int[] rownumber = this.gridView1.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length > 0)
                {
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        DataRow dr = dtdchs.NewRow();
                        dr.ItemArray = this.gridView1.GetDataRow(i).ItemArray;
                        dtdchs.Rows.Add(dr);
                    }
                    dtdchs.DefaultView.Sort = " N_SORT ";//将选中的订单按照排产目标进行排序
                    dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表
                }
                for (int j = 0; j < dtdchs.Rows.Count; j++)
                {
                    string C_PLAN_ID = dtdchs.Rows[j]["C_ID"].ToString();
                    Mod_TRP_PLAN_ROLL modPlan = bll_plan.GetModel(C_PLAN_ID);
                    modPlan.N_STATUS = 1;
                    bll_plan.Update(modPlan);
                }
                btn_query_zg_Click(null, null);
                WaitingFrom.CloseWait();




            }
            catch (Exception)
            {

                btn_query_zg_Click(null, null);
            }

        }

        private void btn_canale_Click(object sender, EventArgs e)
        {
            try
            {
                //for (int i = 0; i < Convert.ToInt32(this.txt_num.Text); i++)
                //{
                //    Mod_TRP_PLAN_ROLL modpx = bll_plan.GetModel(gridView1.GetRowCellValue(i, "C_ID").ToString());
                //    modpx.N_STATUS = 0;
                //    bll_plan.Update(modpx);
                //}


                WaitingFrom.ShowWait("");
                DataTable dtdchs = dtzgjh.Clone();//选中的需要评价的订单
                int[] rownumber = this.gridView1.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length > 0)
                {
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        DataRow dr = dtdchs.NewRow();
                        dr.ItemArray = this.gridView1.GetDataRow(i).ItemArray;
                        dtdchs.Rows.Add(dr);
                    }
                    dtdchs.DefaultView.Sort = " N_SORT ";//将选中的订单按照排产目标进行排序
                    dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表
                }
                for (int j = 0; j < dtdchs.Rows.Count; j++)
                {
                    string C_PLAN_ID = dtdchs.Rows[j]["C_ID"].ToString();
                    Mod_TRP_PLAN_ROLL modPlan = bll_plan.GetModel(C_PLAN_ID);
                    modPlan.N_STATUS = 0;
                    bll_plan.Update(modPlan);
                }
                btn_query_zg_Click(null, null);
                WaitingFrom.CloseWait();
                

            }
            catch (Exception)
            {

                btn_query_zg_Click(null, null);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            DataTable dtdchs = dtzgjh.Clone();//选中的需要评价的订单
            int[] rownumber = this.gridView1.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    DataRow dr = dtdchs.NewRow();
                    dr.ItemArray = this.gridView1.GetDataRow(i).ItemArray;
                    dtdchs.Rows.Add(dr);
                }
                dtdchs.DefaultView.Sort = " N_SORT ";//将选中的订单按照排产目标进行排序
                dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表
            }
            for (int j = 0; j < dtdchs.Rows.Count; j++)
            {
                string C_PLAN_ID = dtdchs.Rows[j]["C_ID"].ToString();
                Mod_TRP_PLAN_ROLL modPlan = bll_plan.GetModel(C_PLAN_ID);
                decimal WGT = Convert.ToDecimal(modPlan.N_WGT);
                string orderId = modPlan.C_INITIALIZE_ITEM_ID;
                bll_order.BackZGWGT(orderId, WGT);
                bll_plan.Delete(C_PLAN_ID);
            }
            btn_query_zg_Click(null, null);
            WaitingFrom.CloseWait();
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
    }
}
