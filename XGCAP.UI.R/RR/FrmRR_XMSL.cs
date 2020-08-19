using BLL;
using System;

namespace XGCAP.UI.R.RR
{
    public partial class FrmRR_XMSL : DevExpress.XtraReports.UI.XtraReport
    {
        public FrmRR_XMSL()
        {
            InitializeComponent();
        }
        Bll_TRC_PLAN_REGROUND bll_TRC_PLAN_REGROUND = new Bll_TRC_PLAN_REGROUND();
        Bll_TPB_SLABWH_LOC bll_TPB_SLABWH_LOC = new Bll_TPB_SLABWH_LOC();
        public FrmRR_XMSL(string id)
        {
            InitializeComponent();
            var m = bll_TRC_PLAN_REGROUND.GetModel(id);
            var m1 = bll_TPB_SLABWH_LOC.GetNameByCode(m.C_SLABWH_LOC_CODE);
            //var m2 = bll_TPB_SLABWH_LOC.GetNameByCode(m.C_SLABWH_XLLOC_CODE);
            xrbz.Text = m.C_REMARK;
            xrGZ.Text = m.C_STL_GRD;
            xrHG.Text = m.C_EMP_CODE;
            xrJTH.Text = m.C_EXTEND17 == "" ? "抛丸探伤" : m.C_EXTEND17;
            if (m.C_BATCH_NO=="")
            {
                xrLH.Text = m.C_STOVE;
            }
            else
            {
                xrLH.Text = m.C_BATCH_NO;
            }
            xrRQ.Text = m.D_QR_DATE.ToString();
            xrSL.Text = m.C_EXTEND18 == "" ? "无" : m.C_EXTEND18;
            xrSLHW.Text = m1.C_SLABWH_LOC_NAME;
            //if (m2 != null)
            //{
            //    xrXLHW.Text = m2.C_SLABWH_LOC_NAME;
            //}
            xrXLHW.Text = m.C_SLABWH_XLLOC_CODE;
            xrXMFS.Text = m.C_EXTEND16==""?"抛丸探伤": m.C_EXTEND16;
            xrXYH.Text = m.C_STD_CODE;
            xrZS.Text = m.N_QUA_VIRTUAL.ToString();

        }
    }
}
