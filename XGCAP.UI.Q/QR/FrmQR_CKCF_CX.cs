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
    public partial class FrmQR_CKCF_CX : Form
    {
        public FrmQR_CKCF_CX()
        {
            InitializeComponent();
        }
        Bll_TQC_COMPRE_ITEM_RESULT bllItemResult = new Bll_TQC_COMPRE_ITEM_RESULT();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQR_CKCF_CX_Load(object sender, EventArgs e)
        {

        }

        private void BindResult()
        {
            gc_Main.DataSource = null;
            gv_Main.Columns.Clear();
            WaitingFrom.ShowWait("");

            DataTable dt_Stove = bllItemResult.GetList_Stove(txt_Hth.Text.Trim(), txt_Stove.Text.Trim(), txt_GZ.Text.Trim(), txt_BZ.Text.Trim()).Tables[0];

            if (dt_Stove.Rows.Count > 0)
            {
                string strStove = "";
                foreach (DataRow dr in dt_Stove.Rows)
                {
                    strStove += "'" + dr["C_STOVE"].ToString() + "',";
                }

                if (strStove.Length > 0)
                {
                    strStove = strStove.Substring(0, strStove.Length - 1);
                }

                DataTable dt = bllItemResult.GetList_CK_CF(strStove).Tables[0];
                DataTable dt_Item = bllItemResult.GetList_CK_CF_Item(strStove).Tables[0];
                DataTable dt_value = bllItemResult.GetList_CK_CF_Value(strStove).Tables[0];
                DataTable new_DataTable = new DataTable();
                DataColumn new_d_col = new DataColumn();
                new_DataTable.Columns.Add("生产日期", typeof(string));
                new_DataTable.Columns.Add("连铸机", typeof(string));
                new_DataTable.Columns.Add("炉号", typeof(string));
                new_DataTable.Columns.Add("开坯号", typeof(string));
                new_DataTable.Columns.Add("钢种", typeof(string));
                new_DataTable.Columns.Add("执行标准", typeof(string));
                new_DataTable.Columns.Add("断面", typeof(string));
                new_DataTable.Columns.Add("物料编码", typeof(string));
                new_DataTable.Columns.Add("物料描述", typeof(string));
                new_DataTable.Columns.Add("自由项1", typeof(string));
                new_DataTable.Columns.Add("自由项2", typeof(string));
                new_DataTable.Columns.Add("支数", typeof(string));
                new_DataTable.Columns.Add("重量", typeof(string));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    new_d_col = new DataColumn();
                    new_d_col.ColumnName = dt.Rows[i]["C_NAME"].ToString();
                    new_d_col.Caption = dt.Rows[i]["C_NAME"].ToString();

                    new_DataTable.Columns.Add(new_d_col);
                }

                DataRow new_dr;
                DataRow[] drs;
                foreach (DataRow dr in dt_Stove.Rows)
                {
                    DataRow[] drCC = dt_Item.Select(" 炉号 = '" + dr["C_STOVE"].ToString() + "' and 钢种 = '" + dr["C_STL_GRD"].ToString() + "' and 执行标准 = '" + dr["C_STD_CODE"].ToString() + "' ");

                    new_dr = new_DataTable.NewRow();

                    if (drCC.Length > 0)
                    {
                        new_dr["生产日期"] = drCC[0]["生产日期"].ToString();
                        new_dr["连铸机"] = drCC[0]["连铸机"].ToString();
                    }
                    new_dr["钢种"] = dr["C_STL_GRD"].ToString();
                    new_dr["执行标准"] = dr["C_STD_CODE"].ToString();
                    new_dr["炉号"] = dr["C_STOVE"].ToString();
                    new_dr["开坯号"] = dr["C_BATCH_NO"].ToString();
                    new_dr["物料编码"] = dr["C_MAT_CODE"].ToString();
                    new_dr["物料描述"] = dr["C_MAT_NAME"].ToString();
                    new_dr["断面"] = dr["C_SPEC"].ToString();
                    if (drCC.Length > 0)
                    {
                        new_dr["自由项1"] = drCC[0]["自由项1"].ToString();
                        new_dr["自由项2"] = drCC[0]["自由项2"].ToString();
                    }
                    new_dr["支数"] = dr["N_NUM"].ToString();
                    new_dr["重量"] = dr["N_JZ"].ToString();

                    drs = dt_value.Select(" C_STOVE = '" + dr["C_STOVE"].ToString() + "' and C_STL_GRD = '" + dr["C_STL_GRD"].ToString() + "' and C_STD_CODE = '" + dr["C_STD_CODE"].ToString() + "' ");

                    for (int i = 0; i < drs.Length; i++)
                    {
                        new_dr[drs[i]["C_NAME"].ToString()] = drs[i]["C_VALUE"].ToString();
                    }

                    new_DataTable.Rows.Add(new_dr);
                }

                new_DataTable.DefaultView.Sort = "炉号 ASC";

                new_DataTable = new_DataTable.DefaultView.ToTable();

                gc_Main.DataSource = new_DataTable;
                gv_Main.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Main);
            }

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
                if (!string.IsNullOrEmpty(txt_Hth.Text.Trim()))
                {
                    BindResult();
                }
                else
                {
                    MessageBox.Show("请输入合同号！");
                    return;
                }
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
            OutToExcel.ToExcel(gc_Main, "钢坯成分查询" + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
