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

namespace XGCAP.UI.R.RC
{
    public partial class FrmRC_WGD_CX : Form
    {
        private Bll_TRC_ROLL_WGD bllTrcRollWgd = new Bll_TRC_ROLL_WGD();

        public FrmRC_WGD_CX()
        {
            InitializeComponent();
        }

        private void FrmRC_WGD_CX_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            CommonSub.BindIcbo("", "ZX", icbo_ZX);
            icbo_ZX.SelectedIndex = 0;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        /// <summary>
        /// 查询完工单信息
        /// </summary>
        private void BindInfo()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bllTrcRollWgd.Get_WGD_List(dt_Start.Text.Trim(), dt_End.Text.Trim(), txt_BatchNo.Text.Trim(), icbo_ZX.EditValue.ToString()).Tables[0];

                gc_WGD.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_WGD);

                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        private void btn_out_toExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_WGD, "完工记录" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
