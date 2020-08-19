using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PQ
{
    public partial class FrmPQ_KPXMCX : Form
    {
        public FrmPQ_KPXMCX()
        {
            InitializeComponent();
        }
        Bll_TPC_PLAN_SMS bll = new Bll_TPC_PLAN_SMS();
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        /// <summary>
        /// 查询生产影响记录
        /// </summary>
        public void BindInfo()
        {

            DataTable dt = bll.GetQuery().Tables[0];
            this.gc_GP.DataSource = dt;
            this.gv_GP.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_GP.OptionsSelection.MultiSelect = true;//允许多选
            gv_GP.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            this.gv_GP.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GP);
        }
    }
}
