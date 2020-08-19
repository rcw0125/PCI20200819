using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MODEL;
using BLL;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_GPYC_LOG : Form
    {
        public FrmQC_GPYC_LOG()
        {
            InitializeComponent();
        }
        private string strMenuName;

        Bll_TQC_SLAB_YC_LOG bll_YC_LOG = new Bll_TQC_SLAB_YC_LOG();

        private void FrmQC_GPYC_LOG_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strMenuName = RV.UI.UserInfo.menuName;

            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            NewMethod();

        }

        private void NewMethod()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bll_YC_LOG.Get_List(txt_Stove.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim()).Tables[0];
                gc_GPYC_Log.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_GPYC_Log);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_GPYC_Log, "钢坯异常操作记录-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
