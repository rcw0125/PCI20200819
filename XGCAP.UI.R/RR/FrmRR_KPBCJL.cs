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
    public partial class FrmRR_KPBCJL : Form
    {
        public FrmRR_KPBCJL()
        {
            InitializeComponent();
        }

        Bll_TRC_COGDOWN_PRODUCT bll_TRC_COGDOWN_PRODUCT = new Bll_TRC_COGDOWN_PRODUCT();
        CommonSub sub = new CommonSub();
        private string staCode = "1#KP";

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
            DataTable dt = bll_TRC_COGDOWN_PRODUCT.GetBcJl(rqStart, rqEnd, shift,img_prodLine.EditValue.ToString());
            dt.Columns.Add("CONSUME");
            dt.Columns.Add("R");
            DataTable dt2 = bll_TRC_COGDOWN_PRODUCT.GetConSume(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var row = dt2.Select(" C_COGDOWN_MAIN_ID='" + dt.Rows[i]["C_COGDOWN_ID"] + "' ");
                    if (row != null && row.Count() > 0)
                    {
                        dt.Rows[i]["CONSUME"] = row[0]["CONSUME"].ToString();
                        dt.Rows[i]["R"] =Math.Round((decimal.Parse(dt.Rows[i]["YIELD"].ToString()) / decimal.Parse(dt.Rows[i]["CONSUME"].ToString())),3)*100;
                    }
                }
            }
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
            DataTable dt = bll_TRC_COGDOWN_PRODUCT.GetProdLine("%#KP");
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

        private void FrmRR_KPBCJL_Load(object sender, EventArgs e)
        {
            sub.ImageComboBoxEditBindNCBC(cbo_PutShift, staCode);
            cbo_PutShift.Properties.Items.Add("全部", "全部", -1);
            LoadingProdLine();
        }

        private void btn_out_toExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_KDZGZ, "开坯班次记录" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
