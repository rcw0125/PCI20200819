using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using BLL;

namespace XGCAP.UI.R.RR
{
    public partial class FrmRR_LGKP : DevExpress.XtraReports.UI.XtraReport
    {
        public FrmRR_LGKP()
        {
            InitializeComponent();

        }

        Bll_TRC_ROLL_MAIN bll_TRC_ROLL_MAIN = new Bll_TRC_ROLL_MAIN();
        Bll_TRC_COGDOWN_MAIN bll_TRC_COGDOWN_MAIN = new Bll_TRC_COGDOWN_MAIN();


        public FrmRR_LGKP(string batchNO)
        {
            InitializeComponent();
            var m = bll_TRC_ROLL_MAIN.GetModels(batchNO);
            xrTableCell13.Text = m.C_BATCH_NO;
            if (!string.IsNullOrWhiteSpace(m.C_PLANT))
                xrTableCell14.Text = m.C_PLANT;
            else
                xrTableCell14.Text = m.C_STOVE;
            var dt = bll_TRC_ROLL_MAIN.GetSlab(m.C_STOVE);
            xrTableCell15.Text = m.C_SPEC_SLAB + "*";
            if (dt.Rows.Count > 0)
                xrTableCell15.Text += dt.Rows[0]["N_LEN"].ToString();
            xrTableCell6.Text = m.C_STL_GRD;
            xrTableCell16.Text = m.N_QUA_TOTAL_VIRTUAL.ToString();
            xrTableCell10.Text = m.C_STD_CODE;
            xrTableCell20.Text = "备注：" + m.C_REMARK;
            xrTableCell8.Text = bll_TRC_ROLL_MAIN.GetUserName(m.C_EMP_ID);
            xrTableCell55.Text = DateTime.Now.Year + "年" + DateTime.Now.Month + "月" + DateTime.Now.Day + "日";
            xrTableCell56.Text = "异常信息：";
            if (dt.Rows.Count > 0)
                xrTableCell56.Text += dt.Rows[0]["C_KP_ID"] == DBNull.Value ? "" : dt.Rows[0]["C_KP_ID"].ToString();
        }

        public FrmRR_LGKP(string batchNO, int type)
        {
            InitializeComponent();
            var m = bll_TRC_COGDOWN_MAIN.GetModels(batchNO);
            xrTableCell13.Text = m.C_BATCH_NO;
            if (!string.IsNullOrWhiteSpace(m.C_PLANT))
                xrTableCell14.Text = m.C_PLANT;
            else
                xrTableCell14.Text = m.C_STOVE;
            var dt = bll_TRC_ROLL_MAIN.GetSlabs(m.C_STOVE);
            xrTableCell15.Text = m.C_SPEC_SLAB + "*";
            if (dt.Rows.Count > 0)
                xrTableCell15.Text += dt.Rows[0]["N_LEN"].ToString();
            xrTableCell6.Text = m.C_STL_GRD;
            xrTableCell16.Text = m.N_QUA_TOTAL_VIRTUAL.ToString();
            xrTableCell10.Text = m.C_STD_CODE;
            xrTableCell20.Text = "备注：" + m.C_REMARK;
            xrTableCell8.Text = bll_TRC_ROLL_MAIN.GetUserName(m.C_EMP_ID);
            xrTableCell55.Text = DateTime.Now.Year + "年" + DateTime.Now.Month + "月" + DateTime.Now.Day + "日";
            xrTableCell56.Text = "异常信息：";
            if (dt.Rows.Count > 0)
                xrTableCell56.Text += dt.Rows[0]["C_KP_ID"] == DBNull.Value ? "" : dt.Rows[0]["C_KP_ID"].ToString();
        }

    }
}
