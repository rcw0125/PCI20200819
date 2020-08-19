using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XGCAP.UI.P.PO.ViewModel;
using BLL;

namespace XGCAP.UI.P.PO
{
    public partial class FrmTEST : Form
    {
        public FrmTEST()
        {
            InitializeComponent();
        }

        public List<Mod_TPP_LGPC_LSB> lst = new List<Mod_TPP_LGPC_LSB>();
        public Bll_TPP_LGPC_LSB bll_plan = new Bll_TPP_LGPC_LSB();
        private void FrmTEST_Load(object sender, EventArgs e)
        {
          
            CommonSub.BindIcbo("", "CC", icbo_lz3);
            
            BindLsbGrid();
            InitDrop();
        }


        private void BindLsbGrid()
        {
            lst = bll_plan.GetModelList("").Where(a=>a.C_CCM_ID==_strCCMID).OrderBy(a=>a.N_SORT).ToList();
            //lst.AddRange(this._viewModel.LSBList.OrderBy(w => w.N_SORT).ThenBy(w => w.N_GROUP));

            this.modTPPLGPCLSBBindingSource.DataSource = lst;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.UpdateSummary();
            this.gridView1.RefreshData();
            this.gridView1.BestFitColumns();

        }
        /// <summary>
        /// 浇次计划数据源
        /// </summary>
       // public List<Mod_TPP_LGPC_LSB> GridSource { get; set; } = new List<Mod_TPP_LGPC_LSB>();
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

        private void InitDrop()
        {
            var dropPlanToReq = new GridViewDragDropHelper(
                gridView1, gridView1, (row1, row2) =>
                {
                    if (row1 == row2) return;

                    var plan1 = this.gridView1.GetRow(row1) as Mod_TPP_LGPC_LSB;
                    if (row2 < lst.Count)
                    {
                        row2 = row2 < 0 ? 0 : row2;
                        if (row2 >= gridView1.RowCount)
                        {
                            row2 = gridView1.RowCount - 1;
                        }
                        var plan2 = this.gridView1.GetRow(row2) as Mod_TPP_LGPC_LSB;
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

                    foreach (var item in lst)
                    {
                        item.N_SORT = lst.IndexOf(item) + 1;
                    }

                    this.gridView1.RefreshData();
                });

            dropPlanToReq.AllowDrop = true;

           
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            BindLsbGrid();
        }
    }
}
