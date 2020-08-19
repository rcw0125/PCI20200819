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
using MODEL;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_CF_YSZ_CX : Form
    {
        public FrmQR_CF_YSZ_CX()
        {
            InitializeComponent();
        }
        Bll_TQC_COMPRE_ITEM_RESULT bllItemResult = new Bll_TQC_COMPRE_ITEM_RESULT();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQR_CF_YSZ_CX_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        private void BindResult()
        {
            gc_Main.DataSource = null;
            gv_Main.Columns.Clear();
            WaitingFrom.ShowWait("");
            DataTable dt = bllItemResult.GetList_CF_Name().Tables[0];
            DataTable dt_Item = bllItemResult.GetList_XC(dt_Start.DateTime, dt_End.DateTime, txt_Stove.Text.Trim(), txt_GZ.Text.Trim(), txt_Batch.Text.Trim()).Tables[0];
            DataTable dt_value = bllItemResult.GetList_CF_YSZ_Value().Tables[0];
            DataTable new_DataTable = new DataTable();
            DataColumn new_d_col = new DataColumn();
            new_DataTable.Columns.Add("生产日期", typeof(string));
            new_DataTable.Columns.Add("批号", typeof(string));
            new_DataTable.Columns.Add("线材钢种", typeof(string));
            new_DataTable.Columns.Add("线材标准", typeof(string));
            new_DataTable.Columns.Add("规格", typeof(string));
            new_DataTable.Columns.Add("支数", typeof(string));
            new_DataTable.Columns.Add("重量", typeof(string));
            new_DataTable.Columns.Add("连铸机", typeof(string));
            new_DataTable.Columns.Add("炉号", typeof(string));
            new_DataTable.Columns.Add("开坯号", typeof(string));
            new_DataTable.Columns.Add("钢坯钢种", typeof(string));
            new_DataTable.Columns.Add("钢坯标准", typeof(string));
            new_DataTable.Columns.Add("断面", typeof(string));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                new_d_col = new DataColumn();
                new_d_col.ColumnName = dt.Rows[i]["C_NAME"].ToString();
                new_d_col.Caption = dt.Rows[i]["C_NAME"].ToString();

                new_DataTable.Columns.Add(new_d_col);
            }

            DataRow new_dr;
            DataRow[] drs;
            foreach (DataRow dr in dt_Item.Rows)
            {
                new_dr = new_DataTable.NewRow();
                new_dr["生产日期"] = dr["生产日期"].ToString();
                new_dr["批号"] = dr["批号"].ToString();
                new_dr["线材钢种"] = dr["线材钢种"].ToString();
                new_dr["线材标准"] = dr["线材标准"].ToString();
                new_dr["规格"] = dr["规格"].ToString();
                new_dr["支数"] = dr["支数"].ToString();
                new_dr["重量"] = dr["重量"].ToString();
                new_dr["连铸机"] = dr["连铸机"].ToString();
                new_dr["炉号"] = dr["炉号"].ToString();
                new_dr["开坯号"] = dr["开坯号"].ToString();
                new_dr["钢坯钢种"] = dr["钢坯钢种"].ToString();
                new_dr["钢坯标准"] = dr["钢坯标准"].ToString();
                new_dr["断面"] = dr["断面"].ToString();
                drs = dt_value.Select(" C_STOVE = '" + dr["炉号"].ToString() + "' ");
                for (int i = 0; i < drs.Length; i++)
                {
                    new_dr[drs[i]["C_NAME"].ToString()] = drs[i]["N_ORIGINALVALUE"].ToString();
                }
                new_DataTable.Rows.Add(new_dr);
            }

            new_DataTable.DefaultView.Sort = "批号 ASC";

            new_DataTable = new_DataTable.DefaultView.ToTable();

            gc_Main.DataSource = new_DataTable;
            gv_Main.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Main);
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                BindResult();
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
            OutToExcel.ToExcel(gc_Main, "成分原始值" + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
