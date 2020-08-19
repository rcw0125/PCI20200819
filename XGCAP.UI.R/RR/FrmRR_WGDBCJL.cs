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

namespace XGCAP.UI.R.RR
{
    public partial class FrmRR_WGDBCJL : Form
    {
        public FrmRR_WGDBCJL()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        }

        Bll_TRC_ROLL_WGD bll_TRC_ROLL_WGD = new Bll_TRC_ROLL_WGD();
        CommonSub sub = new CommonSub();

        private string staCode = "1#ZX";

        private void btn_AllowGrdQuery_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("正在加载，请稍后...");
            if (dt_rq.DateTime == DateTime.MinValue)
            {
                MessageBox.Show("请选择日期");
                return;
            }
            string rqStart = dt_rq.DateTime.AddDays(-1).ToString("yyyy-MM-dd") + " 20:00:00";
            string rqEnd = dt_rq2.DateTime.ToString("yyyy-MM-dd") + " 20:00:00";
            string shift = cbo_PutShift.Text;
            DataTable dt = bll_TRC_ROLL_WGD.GetWgdBCJL(rqStart, rqEnd, shift, img_prodLine.EditValue.ToString());
            this.gc_KDZGZ.DataSource = dt;
            this.gv_KDZGZ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_KDZGZ);
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 加载产线
        /// </summary>
        private void LoadingProdLine()
        {
            img_prodLine.Properties.Items.Clear();
            DataTable dt = bll_TRC_ROLL_WGD.GetProdLine("%#ZX");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    img_prodLine.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
                }
            }
            else
            {
                img_prodLine.Properties.Items.Clear();
            }
            img_prodLine.Properties.Items.Add("全部", "全部", -1);
        }

        private void FrmRR_WGDBCJL_Load(object sender, EventArgs e)
        {
            sub.ImageComboBoxEditBindNCBC(cbo_PutShift, staCode);
            cbo_PutShift.Properties.Items.Add("全部", "全部", -1);
            LoadingProdLine();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void cbo_PutShift_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_out_toExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_KDZGZ, "线材班次记录" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
