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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_CFCX : Form
    {
        private Bll_TQC_QUA_RESULT bllTqcQuaResult = new Bll_TQC_QUA_RESULT();

        private string strMenuName;

        public FrmQC_CFCX()
        {
            InitializeComponent();
        }

        private void FrmQC_CFCX_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        private void BindList()
        {
            WaitingFrom.ShowWait("");

            DataTable dt = bllTqcQuaResult.Get_CF_List(txt_Stove.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim()).Tables[0];

            dt.Columns["钢种"].SetOrdinal(4);
            dt.Columns["物料编码"].SetOrdinal(5);
            dt.Columns["物料描述"].SetOrdinal(6);
            dt.Columns["断面"].SetOrdinal(7);
            dt.Columns["长度"].SetOrdinal(8);
            dt.Columns["执行标准"].SetOrdinal(9);

            //dt.Columns["C"].SetOrdinal(10);
            //dt.Columns["Si"].SetOrdinal(11);
            //dt.Columns["Mn"].SetOrdinal(12);
            //dt.Columns["P"].SetOrdinal(13);
            //dt.Columns["S"].SetOrdinal(14);

            gc_CF.DataSource = dt;

            gv_CF.Columns["C_STOVE"].Visible = false;

            SetGridViewRowNum.SetRowNum(gv_CF);

            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_CG_Click(object sender, EventArgs e)
        {
            BindList();
        }
        
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_CF, "成分原始记录-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
