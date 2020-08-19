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
    public partial class FrmQR_CFXN_CX : Form
    {
        public FrmQR_CFXN_CX()
        {
            InitializeComponent();
        }
        Bll_TQC_COMPRE_ITEM_RESULT bllItemResult = new Bll_TQC_COMPRE_ITEM_RESULT();

        private DataTable new_DataTable;

        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQR_CFXN_CX_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            new_DataTable = new DataTable();
        }

        private void BindResult()
        {
            gc_Main.DataSource = null;
            gv_Main.Columns.Clear();
            WaitingFrom.ShowWait("");
            string begin = "";
            string end = "";
            if (chk_SJ.Checked)
            {
                begin = dt_Start.Text.Trim();
                end = dt_End.Text.Trim();
            }
            else
            {
                if (string.IsNullOrEmpty(txt_Stove.Text.Trim()) && string.IsNullOrEmpty(txt_Batch_Result.Text.Trim()) && string.IsNullOrEmpty(txt_GZ.Text.Trim()) && string.IsNullOrEmpty(txt_BZ.Text.Trim()))
                {
                    MessageBox.Show("请输入查询条件再进行查询！");
                    return;
                }
            }

            DataTable dt = bllItemResult.GetList_CFXN(begin, end, txt_Stove.Text.Trim(), txt_Batch_Result.Text.Trim(), txt_GZ.Text.Trim(), txt_BZ.Text.Trim()).Tables[0];
            DataTable dt_Item = bllItemResult.GetList_CFXN_Item(begin, end, txt_Stove.Text.Trim(), txt_Batch_Result.Text.Trim(), txt_GZ.Text.Trim(), txt_BZ.Text.Trim()).Tables[0];
            DataTable dt_value = bllItemResult.GetList_CFXN_Value(begin, end, txt_Stove.Text.Trim(), txt_Batch_Result.Text.Trim(), txt_GZ.Text.Trim(), txt_BZ.Text.Trim()).Tables[0];

            new_DataTable = new DataTable();

            DataColumn new_d_col = new DataColumn();
            new_DataTable.Columns.Add("生产日期", typeof(string));
            new_DataTable.Columns.Add("部门", typeof(string));
            new_DataTable.Columns.Add("线材生产批次号", typeof(string));
            new_DataTable.Columns.Add("钢种", typeof(string));
            new_DataTable.Columns.Add("执行标准", typeof(string));
            new_DataTable.Columns.Add("钢种类别", typeof(string));
            new_DataTable.Columns.Add("线材规格", typeof(string));
            new_DataTable.Columns.Add("线材物料编码", typeof(string));
            new_DataTable.Columns.Add("线材物料描述", typeof(string));
            new_DataTable.Columns.Add("钢坯炉号", typeof(string));
            new_DataTable.Columns.Add("钢坯开坯号", typeof(string));
            new_DataTable.Columns.Add("钢坯物料编码", typeof(string));
            new_DataTable.Columns.Add("钢坯物料描述", typeof(string));
            new_DataTable.Columns.Add("自由项1", typeof(string));
            new_DataTable.Columns.Add("自由项2", typeof(string));
            new_DataTable.Columns.Add("自由项3", typeof(string));
            new_DataTable.Columns.Add("总件数", typeof(Int32));
            new_DataTable.Columns.Add("总重量", typeof(decimal));
            new_DataTable.Columns.Add("合格件数", typeof(Int32));
            new_DataTable.Columns.Add("合格重量", typeof(decimal));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                new_d_col = new DataColumn();
                new_d_col.ColumnName = dt.Rows[i]["C_NAME"].ToString();
                new_d_col.Caption = dt.Rows[i]["C_NAME"].ToString();

                if (dt.Rows[i]["C_TYPE"].ToString() == "成分")
                {
                    new_d_col.DataType = typeof(decimal);
                }

                new_DataTable.Columns.Add(new_d_col);
            }

            new_DataTable.Columns.Add("冷顶锻", typeof(string));
            new_DataTable.Columns.Add("热顶锻试验", typeof(string));
            new_DataTable.Columns.Add("冷弯试验", typeof(string));

            DataRow new_dr;
            DataRow[] drs;
            foreach (DataRow dr in dt_Item.Rows)
            {
                new_dr = new_DataTable.NewRow();
                new_dr["生产日期"] = dr["生产日期"].ToString();
                new_dr["部门"] = dr["部门"].ToString();
                new_dr["钢种"] = dr["钢种"].ToString();
                new_dr["执行标准"] = dr["执行标准"].ToString();
                new_dr["钢种类别"] = dr["钢种类别"].ToString();
                new_dr["钢坯炉号"] = dr["钢坯炉号"].ToString();
                new_dr["钢坯开坯号"] = dr["钢坯开坯号"].ToString();
                new_dr["钢坯物料编码"] = dr["钢坯物料编码"].ToString();
                new_dr["钢坯物料描述"] = dr["钢坯物料描述"].ToString();
                new_dr["线材生产批次号"] = dr["线材生产批次号"].ToString();
                new_dr["线材规格"] = dr["线材规格"].ToString();
                new_dr["线材物料编码"] = dr["线材物料编码"].ToString();
                new_dr["线材物料描述"] = dr["线材物料描述"].ToString();
                new_dr["自由项1"] = dr["自由项1"].ToString();
                new_dr["自由项2"] = dr["自由项2"].ToString();
                new_dr["自由项3"] = dr["自由项3"].ToString();
                new_dr["总件数"] = dr["总件数"].ToString();
                new_dr["总重量"] = dr["总重量"].ToString();
                new_dr["合格件数"] = dr["合格件数"].ToString();
                new_dr["合格重量"] = dr["合格重量"].ToString();
                drs = dt_value.Select(" C_STOVE = '" + dr["钢坯炉号"].ToString() + "' and C_BATCH_NO = '" + dr["线材生产批次号"].ToString() + "' and C_STL_GRD = '" + dr["钢种"].ToString() + "' and C_STD_CODE = '" + dr["执行标准"].ToString() + "' ");
                for (int i = 0; i < drs.Length; i++)
                {
                    new_dr[drs[i]["C_NAME"].ToString()] = drs[i]["C_VALUE"].ToString();
                }
                new_DataTable.Rows.Add(new_dr);
            }

            new_DataTable.DefaultView.Sort = "线材生产批次号 ASC";

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
            OutToExcel.ToExcel(gc_Main, "品质追溯" + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
