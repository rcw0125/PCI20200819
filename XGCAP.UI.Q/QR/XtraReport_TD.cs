using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace XGCAP.UI.Q.QR
{
    public partial class XtraReport_TD : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_TD()
        {
            InitializeComponent();
        }

        public XtraReport_TD(string strType)
        {
            InitializeComponent();

            DataSet_XC_TD ds = new DataSet_XC_TD();
            DataTable dt = ds.Tables["DataTable_Title"];
            DataRow dr = dt.NewRow();
            dr["C_MAT_DESC"] = "1";
            dr["C_STD_CODE"] = "2";
            dr["C_CON_NO"] = "3";
            dr["C_ZSH"] = "4";
            dr["C_DHDW"] = "5";
            dr["C_SHDW"] = "6";
            dr["C_CH"] = "7";
            dr["C_WGT"] = "8";
            dr["C_NUM"] = "9";
            dt.Rows.Add(dr);

            this.DataSource = ds;
        }
    }
}
