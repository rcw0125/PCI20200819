using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.R.RR
{
    public partial class FrmRP_GPYC : Form
    {
        private Bll_TSC_SLAB_MAIN bllSlabMain = new Bll_TSC_SLAB_MAIN();

        public FrmRP_GPYC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRP_GPYC_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        private void BindResult()
        {
            gc_Main.DataSource = null;
            gv_Main.Columns.Clear();
            WaitingFrom.ShowWait("");

            DataTable dt = bllSlabMain.Get_Slab_YC(Convert.ToDateTime(dt_Start.Text.ToString()), Convert.ToDateTime(dt_End.Text.ToString()), txt_Stove.Text.Trim().ToString(), txt_GZ.Text.Trim().ToString()).Tables[0];

            gc_Main.DataSource = dt;

            SetGridViewRowNum.SetRowNum(gv_Main);
            WaitingFrom.CloseWait();
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
                BindResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_Main, "钢坯异常" + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
