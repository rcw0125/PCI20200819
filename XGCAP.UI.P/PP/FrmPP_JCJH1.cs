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
    public partial class FrmPP_JCJH1 : Form
    {
        public FrmPP_JCJH1()
        {
            InitializeComponent();
           
        }
        private Bll_TSP_PLAN_SMS bll_lcjh = new Bll_TSP_PLAN_SMS();//炉次计划

        private void FrmPP_JCJH1_Load(object sender, EventArgs e)
        {
            CommonSub.BindIcbo("", "CC", icbo_lz3);
        }
        string strCCMID = "";
        private void btn_query_Click(object sender, EventArgs e)
        {
            
            int index = this.icbo_lz3.SelectedIndex;
            if (index > 0)
            {
                strCCMID = this.icbo_lz3.Properties.Items[index].Value.ToString();
            }
            else
            {
                MessageBox.Show("请选择需要查看的连铸！");
                this.icbo_lz3.Focus();
                return;
            }
            WaitingFrom.ShowWait("");
            DataTable dt = bll_lcjh.GetJCJH(strCCMID, this.radioGroup1.SelectedIndex, null, null);
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            //gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView1);
            //this.gridView1.BestFitColumns();
            this.gridView1.ColumnWidthChanged += GridView1_ColumnWidthChanged;
            gridView1_Click(null, null);
            this.gridView1.RowCellStyle += GridView1_RowCellStyle;
            WaitingFrom.CloseWait();

        }

        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            int hand = e.RowHandle;
            if (hand < 0) return;
            DataRow dr = this.gridView1.GetDataRow(hand);
            if (dr == null) return;
            if (gridView1.GetRowCellValue(hand, "C_BY3").ToString() == "酱色")
            {
                e.Appearance.ForeColor = Color.DarkRed;// 改变行字体颜色
            }
            if (gridView1.GetRowCellValue(hand, "C_BY3").ToString() == "绿色")
            {
                e.Appearance.ForeColor = Color.Green;// 改变行字体颜色
            }

            if (gridView1.GetRowCellValue(hand, "C_BY3").ToString() == "黄色")
            {
                e.Appearance.ForeColor = Color.Yellow;// 改变行字体颜色
            }
            if (gridView1.GetRowCellValue(hand, "C_BY3").ToString() == "蓝色")
            {
                e.Appearance.ForeColor = Color.Blue;// 改变行字体颜色
            }
        }

        private void GridView1_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            this.gridView1.OptionsView.RowAutoHeight = true;
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                if (gridView1.Columns[i].FieldName == "C_STL_GRD")
                {
                    //设置所有列可编辑
                    gridView1.Columns[i].OptionsColumn.AllowEdit = true;
                    //RepositoryItemMemoEdit对每一列进行设置
                    DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryitemmemoedi1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                    gridView1.Columns[i].ColumnEdit = repositoryitemmemoedi1;
                    repositoryitemmemoedi1.LinesCount = 0;

                    //设置列不可编辑
                    gridView1.Columns[i].OptionsColumn.AllowEdit = false;
                }

            }

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            int selectedHandle = this.gridView1.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.gridControl2.DataSource = null;
                return;
            }
            this.gridView1.ClearSelection();
            this.lbl_id.Text = this.gridView1.GetRowCellValue(selectedHandle, "C_CAST_NO").ToString();//获取焦点行主键
            this.gridView1.SelectRow(selectedHandle);
            this.gridView1.FocusedRowHandle = selectedHandle;

            DataTable dt = bll_lcjh.GetLCJH("", this.lbl_id.Text);
            this.gridControl2.DataSource = dt;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            //gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView2);
            this.gridView2.BestFitColumns();

        }
        private Bll_TPP_LG_PLAN bll_lg = new Bll_TPP_LG_PLAN();
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            string strCCMID = "";
            int index = this.icbo_lz3.SelectedIndex;
            if (index > 0)
            {
                strCCMID = this.icbo_lz3.Properties.Items[index].Value.ToString();
            }
            else
            {
                MessageBox.Show("请选择需要查看的连铸！");
                this.icbo_lz3.Focus();
                return;

            }

            bll_lcjh.ClearTime(strCCMID);
            string msg = bll_lg.UpdatePlanTime("", "");
            btn_query_Click(null, null);
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gridControl1);
        }

        /// <summary>
        ///删除炉次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_lc_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否确定删除当前选中的炉次计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                int rowIndex = this.gridView2.FocusedRowHandle;
                if (rowIndex >= 0)
                {
                    string C_ID = gridView2.GetRowCellValue(rowIndex, "C_ID").ToString();//获取当前行的序号
                    Mod_TSP_PLAN_SMS moddq = bll_lcjh.GetModel(C_ID);
                    string C_CCM_ID = moddq.C_CCM_ID;// gridView2.GetRowCellValue(rowIndex, "C_CCM_ID").ToString();
                    string C_STL_GRD = moddq.C_STL_GRD;// gridView2.GetRowCellValue(rowIndex, "C_STL_GRD").ToString();
                    string C_STD_CODE = moddq.C_STD_CODE;// gridView2.GetRowCellValue(rowIndex, "C_STD_CODE").ToString();
                    string C_CAST_NO = moddq.C_CAST_NO;// gridView2.GetRowCellValue(rowIndex, "C_CAST_NO").ToString();
                    int n_sort = Convert.ToInt32(moddq.N_SORT);//当前行的序号
                    //判断当前选中的炉次计划能否删除
                    string C_STATUS = moddq.C_STATE;// gridView1.GetRowCellValue(rowIndex, "C_STATE").ToString();//判断当前选中炉次计划是否是有订单计划 0 有
                    // T.N_CREAT_PLAN < 2
                    if (Convert.ToInt32(moddq.N_CREAT_PLAN) == 2)
                    {
                        MessageBox.Show("计划炼钢已经排产！");
                        return;
                    }
                    if (C_STATUS == "1")//没有订单的炉次计划
                    {

                        bll_lcjh.Delete(C_ID);
                        bll_lcjh.UpdateSort(C_CCM_ID, n_sort-1);
                    }
                    else//有订单的炉次计划
                    {
                        DataTable dtjc = bll_lcjh.GetWPLC(C_CCM_ID, C_STL_GRD, C_STD_CODE, n_sort, C_CAST_NO);//查找是否有没有订单的炉次计划
                        if (dtjc.Rows.Count > 0)
                        {
                            Mod_TSP_PLAN_SMS mod1 = bll_lcjh.GetModel(dtjc.Rows[0]["C_ID"].ToString());//将需要置换的炉次获取
                            moddq.N_SORT = mod1.N_SORT;
                            moddq.C_CAST_NO = mod1.C_CAST_NO;
                            moddq.C_INITIALIZE_ITEM_ID = mod1.C_INITIALIZE_ITEM_ID;
                            bll_lcjh.Update(moddq);
                            bll_lcjh.Delete(dtjc.Rows[0]["C_ID"].ToString());
                            bll_lcjh.UpdateSort(C_CCM_ID, n_sort-1);
                        }
                        else
                        {
                            MessageBox.Show("当前炉次计划有生产订单，不能单独删除！");
                        }
                    }
                    WaitingFrom.ShowWait("");
                    btn_query_Click(null, null);
                    WaitingFrom.CloseWait();
                }

            }
        }

        private void btn_tj_Click(object sender, EventArgs e)
        {

        }

        private void btn_qxtj_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 删除浇次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deletezjc_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否将当前连铸所有未排产的炉次计划全部撤回重排？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                string strCCMID = "";
                int index = this.icbo_lz3.SelectedIndex;
                if (index > 0)
                {
                    strCCMID = this.icbo_lz3.Properties.Items[index].Value.ToString();
                }
                else
                {
                    MessageBox.Show("请选择需要查看的连铸！");
                    this.icbo_lz3.Focus();
                    return;
                }
                DataTable dt = bll_lcjh.GetWPC(strCCMID);
                if (dt.Rows.Count>0)
                {
                    WaitingFrom.ShowWait("");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DeleteLCJH(dt.Rows[i]["C_ID"].ToString());
                    }
                    btn_query_Click(null, null);
                    WaitingFrom.CloseWait();
                    MessageBox.Show("当前连铸炉次计划已删除！");
                }
                else
                {
                    MessageBox.Show("当前连铸没有可删除的炉次计划！");
                }

            }
        }
        Bll_TSP_PLAN_SMS_ITEM blllcitem = new Bll_TSP_PLAN_SMS_ITEM();
        Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();

        /// <summary>
        /// 根据炉次主键删除炉次计划
        /// </summary>
        /// <param name="C_LCID">炉次计划主键</param>
        public void DeleteLCJH(string C_LCID)
        {
            DataTable dtitem = blllcitem.GetLc(C_LCID);
            for (int i = 0; i < dtitem.Rows.Count; i++)
            {
                string orderid = dtitem.Rows[i]["C_PRODUCTION_PLAN_ID"].ToString();//要返回的订单主键
                decimal wgt = Convert.ToDecimal(dtitem.Rows[i]["N_WGT"].ToString());//要返回的炼钢排产量

                int a = bll_order.BackLGWGT(orderid, wgt);

            }
            blllcitem.Delete(C_LCID);
            bll_lcjh.Delete(C_LCID);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string strCCMID = "";
            int index = this.icbo_lz3.SelectedIndex;
            if (index > 0)
            {
                strCCMID = this.icbo_lz3.Properties.Items[index].Value.ToString();
            }
            else
            {
                MessageBox.Show("请选择需要查看的连铸！");
                this.icbo_lz3.Focus();
                return;
            }
            if (txt_jcs.Text.Trim()==""||Convert.ToInt32(txt_jcs.Text)==0)
            {
                MessageBox.Show("请输入要下发的浇次数量！");
                this.txt_jcs.Focus();
                return;
            }
            //bll_lg.CreatStaPlan(strCCMID,Convert.ToInt32( txt_jcs.Text));
            btn_query_Click(null,null);
        }
        /// <summary>
        /// 整浇次上移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                int A = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex, "C_CTRL_NO").ToString());//获取当前行的序号
                int thisLs = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex, "N_LS").ToString());//获取当前行的炉数
                string thisjczj = gridView1.GetRowCellValue(rowIndex, "C_CAST_NO").ToString(); 


                int upsort = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex - 1, "C_CTRL_NO").ToString());//获取当前行上一行的浇次序号
                int upLs = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex-1, "N_LS").ToString());//获取当前行上一行的的炉数
                string upjczj = gridView1.GetRowCellValue(rowIndex-1, "C_CAST_NO").ToString();

                gridView1.SetRowCellValue(rowIndex - 1, "C_CTRL_NO", A);
                gridView1.SetRowCellValue(rowIndex, "C_CTRL_NO", A - 1);
                #region 保存当前排序
                bll_lcjh.JCSY(thisjczj, upsort.ToString(), upLs);

                bll_lcjh.JCXY(upjczj, A.ToString(), thisLs);

               
                btn_query_Click(null, null);
                #endregion

                this.gridView1.SelectRow(rowIndex - 1);
                this.gridView1.FocusedRowHandle = rowIndex - 1;

                

            }
            catch (Exception)
            {

            }
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
               
                #region 保存当前排序
                int A = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex, "C_CTRL_NO").ToString());//获取当前行的序号
                int thisLs = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex, "N_LS").ToString());//获取当前行的炉数
                string thisjczj = gridView1.GetRowCellValue(rowIndex, "C_CAST_NO").ToString();


                int upsort = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex + 1, "C_CTRL_NO").ToString());//获取当前行上一行的浇次序号
                int upLs = Convert.ToInt32(gridView1.GetRowCellValue(rowIndex + 1, "N_LS").ToString());//获取当前行上一行的的炉数
                string upjczj = gridView1.GetRowCellValue(rowIndex + 1, "C_CAST_NO").ToString();

                gridView1.SetRowCellValue(rowIndex + 1, "N_SORT", A);
                gridView1.SetRowCellValue(rowIndex, "N_SORT", A + 1);
              
                bll_lcjh.JCXY(thisjczj, upsort.ToString(), upLs);

                bll_lcjh.JCSY(upjczj, A.ToString(), thisLs);

                btn_query_Click(null, null);
                #endregion
                this.gridView1.SelectRow(rowIndex + 1);
                this.gridView1.FocusedRowHandle = rowIndex + 1;

                // btn_lc_Click(null, null);
            }
            catch (Exception)
            {

            }
        }

        private void btn_save_sort_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            bll_lcjh.ClearTime(strCCMID);
            string msg = bll_lg.UpdatePlanTime("", "");
            btn_query_Click(null, null);
            WaitingFrom.CloseWait();
        }

        private void btn_lc_up_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = this.gridView2.FocusedRowHandle;
                if (rowIndex == 0)
                {
                    MessageBox.Show("已经是第一行了!", "提示");
                    return;
                }
                int A = Convert.ToInt32(gridView2.GetRowCellValue(rowIndex, "N_SORT").ToString());//获取当前行的序号

               
                gridView2.SetRowCellValue(rowIndex - 1, "N_SORT", A);
                gridView2.SetRowCellValue(rowIndex, "N_SORT", A - 1);
                #region 保存当前排序
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    Mod_TSP_PLAN_SMS modpx = bll_lcjh.GetModel(gridView2.GetRowCellValue(i, "C_ID").ToString());
                    modpx.N_SORT = Convert.ToInt32(gridView2.GetRowCellValue(i, "N_SORT").ToString());
                    bll_lcjh.Update(modpx);
                }
                WaitingFrom.ShowWait("");
                gridView1_Click(null, null);
                WaitingFrom.CloseWait();
                #endregion
                this.gridView2.SelectRow(rowIndex - 1);
                this.gridView2.FocusedRowHandle = rowIndex - 1;

            }
            catch (Exception)
            {

            }
        }

        private void btn_lc_down_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = this.gridView2.FocusedRowHandle;
                if (rowIndex == 0)
                {
                    MessageBox.Show("已经是最后一行了!", "提示");
                    return;
                }
                int A = Convert.ToInt32(gridView2.GetRowCellValue(rowIndex, "N_SORT").ToString());//获取当前行的序号
                
                gridView2.SetRowCellValue(rowIndex + 1, "N_SORT", A);
                gridView2.SetRowCellValue(rowIndex, "N_SORT", A + 1);
                #region 保存当前排序
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    Mod_TSP_PLAN_SMS modpx = bll_lcjh.GetModel(gridView2.GetRowCellValue(i, "C_ID").ToString());
                    modpx.N_SORT = Convert.ToInt32(gridView2.GetRowCellValue(i, "N_SORT").ToString());
                    bll_lcjh.Update(modpx);
                }
                WaitingFrom.ShowWait("");
                gridView1_Click(null, null);
                WaitingFrom.CloseWait();
                #endregion
                this.gridView2.SelectRow(rowIndex + 1);
                this.gridView2.FocusedRowHandle = rowIndex + 1;

            }
            catch (Exception)
            {

            }
        }
    }
}
