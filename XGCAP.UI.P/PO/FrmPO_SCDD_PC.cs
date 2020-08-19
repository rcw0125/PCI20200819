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
using XGCAP.UI.P.PO.ViewModel;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_SCDD_PC : Form
    {
        private PO_SCDD_PC_ViewModel _viewModel = new PO_SCDD_PC_ViewModel();

        /// <summary>
        /// 浇次计划数据源
        /// </summary>
        public List<Mod_TPP_LGPC_LSB> GridSource { get; set; } = new List<Mod_TPP_LGPC_LSB>();

        /// <summary>
        /// 炉次计划数据源
        /// </summary>
        public List<Mod_TPP_LGPC_LCLSB> GridLsSource { get; set; } = new List<Mod_TPP_LGPC_LCLSB>();

        public FrmPO_SCDD_PC()
        {
            InitializeComponent();
        }

        private string _strCCMID
        {
            get
            {
                var index = this.icbo_lz3.SelectedIndex;
                if (index > 0)
                    return this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();

                return string.Empty;
            }
        }

        private string _lsbId
        {
            get
            {
                var current = this.gridView1.GetFocusedRow() as Mod_TPP_LGPC_LSB;
                return current?.C_ID;
            }
        }


        private void FrmPO_SCDD_PC_Load(object sender, EventArgs e)
        {
            InitDrop();
            CommonSub.BindIcbo("", "CC", icbo_lz3);

            _viewModel.Init(_strCCMID);

            BindLsbGrid();
            BindLslLsbGrid();
        }

        private void BindLsbGrid()
        {
            GridSource.Clear();
            GridSource.AddRange(this._viewModel.LSBList.OrderBy(w => w.N_SORT).ThenBy(w => w.N_GROUP));
            this.modTPPLGPCLSBBindingSource.DataSource = GridSource;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.UpdateSummary();
            this.gridView1.RefreshData();
            this.gridView1.BestFitColumns();

            if (GridSource.Count > 0)
            {
                lbl_info.Text = $"订单需排产量（按整炉计算）：{GridSource.FirstOrDefault().N_TOTAL_WGT}" +
                    $"；订单需排炉数：{ GridSource.FirstOrDefault().N_ORDER_LS}";
            }
            else
            {
                lbl_info.Text = "";
            }
        }

        private void BindLslLsbGrid()
        {
            GridLsSource.Clear();
            this.modTPPLGPCLCLSBBindingSource.DataSource = GridLsSource;
            GridLsSource.AddRange(this._viewModel.LCLSBList.Where(x => x.C_FK == _lsbId).OrderBy(w => w.N_SORT));
            SetGridViewRowNum.SetRowNum(gridView2);
            this.gridView2.UpdateSummary();
            this.gridView2.BestFitColumns();

            if (GridLsSource.Any())
            {
                // 默认选中第一个炉次计划
                this.gridView2.FocusedRowHandle = 0;
            }
        }

        private void InitDrop()
        {
            var dropPlanToReq = new GridViewDragDropHelper(
                gridView1, gridView1, (row1, row2) =>
                {
                    if (row1 == row2) return;

                    var plan1 = this.gridView1.GetRow(row1) as Mod_TPP_LGPC_LSB;
                    if (row2 < GridSource.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gridView1.RowCount)
                        {
                            row2 = gridView1.RowCount - 1;
                        }
                        var plan2 = this.gridView1.GetRow(row2) as Mod_TPP_LGPC_LSB;
                        if (plan2 == null)
                            return;
                        GridSource.Remove(plan1);
                        var left = GridSource.TakeWhile(x => x.N_SORT < plan2.N_SORT).ToList();
                        var right = GridSource.Where(x => left.Contains(x) == false).ToList();
                        GridSource.Clear();
                        GridSource.AddRange(left);
                        GridSource.Add(plan1);
                        GridSource.AddRange(right);
                    }
                    else
                    {
                        GridSource.Remove(plan1);
                        GridSource.Add(plan1);
                    }

                    foreach (var item in GridSource)
                    {
                        item.N_SORT = GridSource.IndexOf(item) + 1;
                    }

                    this.gridView1.RefreshData();
                });

            dropPlanToReq.AllowDrop = true;

            var dropPlanToReq2 = new GridViewDragDropHelper(
               gridView2, gridView2, (row1, row2) =>
               {
                   if (row1 == row2) return;

                   var plan1 = this.gridView2.GetRow(row1) as Mod_TPP_LGPC_LCLSB;
                   if (row2 < GridLsSource.Count)
                   {
                       row2 = row2 < 0 ? 0 : row2;
                       var plan2 = this.gridView2.GetRow(row2) as Mod_TPP_LGPC_LCLSB;
                       if (plan2 == null)
                           return;
                       GridLsSource.Remove(plan1);
                       var left = GridLsSource.TakeWhile(x => x.N_SORT < plan2.N_SORT).ToList();
                       var right = GridLsSource.Where(x => left.Contains(x) == false).ToList();
                       GridLsSource.Clear();
                       GridLsSource.AddRange(left);
                       GridLsSource.Add(plan1);
                       GridLsSource.AddRange(right);
                   }
                   else
                   {
                       GridLsSource.Remove(plan1);
                       GridLsSource.Add(plan1);
                   }

                   foreach (var item in GridLsSource)
                   {
                       item.N_SORT = GridLsSource.IndexOf(item) + 1;
                   }

                   this.gridView2.RefreshData();
               });

            dropPlanToReq2.AllowDrop = true;
        }

        private void ChangedSort<T>()
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {


        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            _viewModel.Init(_strCCMID);
            this.BindLsbGrid();
            BindLslLsbGrid();
            WaitingFrom.CloseWait();
        }

        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            var dr = this.gridView1.GetRow(e.RowHandle) as Mod_TPP_LGPC_LSB;

            if (dr == null) return;
            if (dr.C_BY3 == "酱色")
                e.Appearance.ForeColor = Color.DarkRed;// 改变行字体颜色
            if (dr.C_BY3 == "绿色")
                e.Appearance.ForeColor = Color.YellowGreen;// 改变行字体颜色
            if (dr.C_BY3 == "黄色")
                e.Appearance.ForeColor = Color.Gold;// 改变行字体颜色
            if (dr.C_BY3 == "蓝色")
                e.Appearance.ForeColor = Color.Blue;// 改变行字体颜色
        }

        /// <summary>
        /// 调整选择行的整浇次炉数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zjcls_Click(object sender, EventArgs e)
        {
            var current = this.gridView1.GetFocusedRow() as Mod_TPP_LGPC_LSB;
            decimal ls = (decimal)txt_zjcls.EditValue;

            // 验证
            if (current == null || ls == current.N_ZJCLS)
            {
                return;
            }

            //try
            //{
            this._viewModel.ChangedLs(current, ls);

            this.BindLsbGrid();
            this.BindLslLsbGrid();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }


        /// <summary>
        /// 浇次计划下发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 查询炉次计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_lc_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");

            WaitingFrom.CloseWait();

        }

        private void icbo_lz3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.icbo_lz3.SelectedIndex >= 0)
            {
                this.txt_lz.Text = this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Description.ToString();
            }
            else
            {
                this.txt_lz.Text = "";
            }

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbo_gz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            BindLslLsbGrid();
            var current = this.gridView1.GetFocusedRow() as Mod_TPP_LGPC_LSB;
            if (current != null)
            {
                txt_zjcls.EditValue = (int)(current.N_ZJCLS ?? 0);
            }
        }

        private void btnSavePlan_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("正在保存数据");
            this._viewModel.SaveJCPlan();
            WaitingFrom.CloseWait();
        }
    }
}

