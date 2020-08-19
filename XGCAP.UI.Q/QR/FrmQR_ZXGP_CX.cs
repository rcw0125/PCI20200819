using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_ZXGP_CX : Form
    {
        private Bll_TRC_ROLL_PRODCUT bllProduct = new Bll_TRC_ROLL_PRODCUT();

        public FrmQR_ZXGP_CX()
        {
            InitializeComponent();
        }

        private void FrmQR_ZXGP_CX_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindList();
        }

        private void BindList()
        {
            WaitingFrom.ShowWait("");

            DataTable dt = bllProduct.Get_ZXGP_List(txt_Batch_Result.Text.Trim(), txt_GZ.Text.Trim(), txt_BZ.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim()).Tables[0];

            gc_List.DataSource = dt;
            GetSum();
            SetGridViewRowNum.SetRowNum(gv_List);

            WaitingFrom.CloseWait();
        }

        private void GetSum()
        {
            for (int i = 0; i < gv_List.Columns.Count; i++)
            {
                if (gv_List.Columns[i].FieldName == "支数")
                {
                    gv_List.Columns[i].SummaryItem.DisplayFormat = "{0:0.##}";
                    gv_List.Columns[i].SummaryItem.FieldName = "支数";
                    gv_List.Columns[i].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                }

                if (gv_List.Columns[i].FieldName == "重量")
                {
                    gv_List.Columns[i].SummaryItem.DisplayFormat = "{0:0.##}";
                    gv_List.Columns[i].SummaryItem.FieldName = "重量";
                    gv_List.Columns[i].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                }

                if (gv_List.Columns[i].FieldName == "改判支数")
                {
                    gv_List.Columns[i].SummaryItem.DisplayFormat = "{0:0.##}";
                    gv_List.Columns[i].SummaryItem.FieldName = "改判支数";
                    gv_List.Columns[i].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                }

                if (gv_List.Columns[i].FieldName == "改判重量")
                {
                    gv_List.Columns[i].SummaryItem.DisplayFormat = "{0:0.##}";
                    gv_List.Columns[i].SummaryItem.FieldName = "改判重量";
                    gv_List.Columns[i].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                }
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_List, "在线改判查询" + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
