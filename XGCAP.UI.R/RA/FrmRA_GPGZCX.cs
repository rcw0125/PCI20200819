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

namespace XGCAP.UI.R.RA
{
    public partial class FrmRA_GPGZCX : Form
    {
        public FrmRA_GPGZCX()
        {
            InitializeComponent();
        }
        private Bll_TSC_SLAB_STACK bllTscSlabStack = new Bll_TSC_SLAB_STACK();
        private Bll_TSC_SLAB_MOVE bllTscSlabMove = new Bll_TSC_SLAB_MOVE();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRA_GPGZCX_Load(object sender, EventArgs e)
        {
            //dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            //dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QuerySlabFk_Click(object sender, EventArgs e)
        {
            Query_SQ();
        }
        /// <summary>
        /// 查询
        /// </summary>
        private void Query_SQ()
        {
            try
            {
                if (txt_Stove_Fk.Text.Trim()=="" && txt_Grd.Text.Trim()=="" && txt_STD.Text.Trim()=="")
                {
                    MessageBox.Show("请输入炉号/批号或钢种或执行标准！");
                    return;
                }
                gc_Move.DataSource = null;
                gv_Move.Columns.Clear();
                WaitingFrom.ShowWait("");
                DataTable dt = new DataTable();
                if (rbtn_isty_wh.SelectedIndex == 0)
                {
                     dt = bllTscSlabMove.Get_DB("", "" ,txt_Stove_Fk.Text.Trim(), txt_STD.Text.Trim(), txt_Grd.Text.Trim()).Tables[0];
                   
                }
                if (rbtn_isty_wh.SelectedIndex == 1)
                {
                    dt = bllTscSlabStack.Get_DD("", "", txt_Stove_Fk.Text.Trim(), txt_Grd.Text.Trim(), txt_STD.Text.Trim()).Tables[0];
                }

                this.gc_Move.DataSource = dt;
                gv_Move.Columns["C_GROUP"].Caption = "操作班次";
                gv_Move.Columns["C_SHIFT"].Caption = "操作班组";
                gv_Move.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Move);
                WaitingFrom.CloseWait();
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
            Common.OutToExcel.ToExcel(this.gc_Move);
        }
        /// <summary>
        /// 选择出入库或倒垛
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_isty_wh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query_SQ();
        }
    }
}
