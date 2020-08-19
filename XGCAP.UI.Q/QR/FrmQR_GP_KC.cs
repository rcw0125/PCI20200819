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

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_GP_KC : Form
    {
        private Bll_Common bllCommon = new Bll_Common();
        Bll_TB_MATRL_MAIN bllMain = new Bll_TB_MATRL_MAIN();
        private DataTable dt;

        public FrmQR_GP_KC()
        {
            InitializeComponent();
        }

        private void FrmQR_GP_KC_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("仓库");
            dt.Columns.Add("物料号");
            dt.Columns.Add("物料名称");
            dt.Columns.Add("规格");
            dt.Columns.Add("定尺");
            dt.Columns.Add("钢种");
            dt.Columns.Add("炉号");
            dt.Columns.Add("开坯号");
            dt.Columns.Add("质量等级");
            dt.Columns.Add("NC账存支数");
            dt.Columns.Add("NC账存重量");
            dt.Columns.Add("CAP账存支数");
            dt.Columns.Add("CAP账存重量");
            dt.Columns.Add("NC与CAP支数账差");
            dt.Columns.Add("NC与CAP重量账差");
            dt.Columns.Add("自由项1");
            dt.Columns.Add("自由项2");
            dt.Columns.Add("生产时间");
        }

        private DataTable GetNCSlab()
        {
            DataTable dtNC = bllCommon.Get_NC_Slab_KCList().Tables[0];

            return dtNC;
        }

        private DataTable GetPCISlab()
        {
            DataTable dtPCI = bllCommon.Get_PCI_Slab_KCList().Tables[0];

            return dtPCI;
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");

                dt.Clear();

                DataTable dt_NC = GetNCSlab();
                DataTable dt_PCI = GetPCISlab();

                for (int i = 0; i < dt_NC.Rows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["仓库"] = dt_NC.Rows[i]["NC_CK"].ToString();
                    dr["物料号"] = dt_NC.Rows[i]["NC_WLH"].ToString();
                    dr["物料名称"] = dt_NC.Rows[i]["NC_WLMC"].ToString();
                    dr["规格"] = dt_NC.Rows[i]["NC_SLAB_SIZE"].ToString();
                    dr["定尺"] = dt_NC.Rows[i]["NC_LEN"].ToString();
                    dr["钢种"] = dt_NC.Rows[i]["NC_PH"].ToString();
                    dr["炉号"] = dt_NC.Rows[i]["NC_STOVE"].ToString();
                    dr["开坯号"] = dt_NC.Rows[i]["NC_BATCH_NO"].ToString();
                    dr["质量等级"] = dt_NC.Rows[i]["NC_SX"].ToString();
                    dr["NC账存支数"] = dt_NC.Rows[i]["NC_COU"].ToString();
                    dr["NC账存重量"] = dt_NC.Rows[i]["NC_WGT"].ToString();
                    dr["自由项1"] = dt_NC.Rows[i]["NC_ZYX1"].ToString();
                    dr["自由项2"] = dt_NC.Rows[i]["NC_ZYX2"].ToString();
                    dr["生产时间"] = dt_NC.Rows[i]["生产时间"].ToString();

                    DataRow[] row_PCI = dt_PCI.Select("PCI_CK = '" + dt_NC.Rows[i]["NC_CK"].ToString() + "' and PCI_STOVE = '" + dt_NC.Rows[i]["NC_STOVE"].ToString() + "' and PCI_BATCH_NO = '" + dt_NC.Rows[i]["NC_BATCH_NO"].ToString() + "' and PCI_PH = '" + dt_NC.Rows[i]["NC_PH"].ToString() + "' and PCI_SLAB_SIZE = '" + dt_NC.Rows[i]["NC_SLAB_SIZE"].ToString() + "' and PCI_LEN = '" + dt_NC.Rows[i]["NC_LEN"].ToString() + "' and PCI_SX = '" + dt_NC.Rows[i]["NC_SX"].ToString() + "' and PCI_WLH = '" + dt_NC.Rows[i]["NC_WLH"].ToString() + "' and PCI_ZYX1 = '" + dt_NC.Rows[i]["NC_ZYX1"].ToString() + "' and PCI_ZYX2 = '" + dt_NC.Rows[i]["NC_ZYX2"].ToString() + "' ");

                    if (row_PCI.Length > 1)
                    {
                        MessageBox.Show("炉号：" + dt_NC.Rows[i]["NC_STOVE"].ToString() + "信息有误！");
                        return;
                    }
                    else if (row_PCI.Length == 1)
                    {
                        foreach (var item in row_PCI)
                        {
                            dr["CAP账存支数"] = item["PCI_COU"].ToString();
                            dr["CAP账存重量"] = item["PCI_WGT"].ToString();
                            dr["NC与CAP支数账差"] = (Convert.ToDecimal(dr["NC账存支数"].ToString()) - Convert.ToDecimal(item["PCI_COU"].ToString())).ToString();
                            dr["NC与CAP重量账差"] = (Convert.ToDecimal(dr["NC账存重量"].ToString()) - Convert.ToDecimal(item["PCI_WGT"].ToString())).ToString();
                        }

                        dt_PCI.Rows.Remove(row_PCI[0]);
                    }
                    else
                    {
                        dr["CAP账存支数"] = "0";
                        dr["CAP账存重量"] = "0";
                        dr["NC与CAP支数账差"] = dr["NC账存支数"].ToString();
                        dr["NC与CAP重量账差"] = dr["NC账存重量"].ToString();
                    }

                    dt.Rows.Add(dr);
                }

                for (int i = 0; i < dt_PCI.Rows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["仓库"] = dt_PCI.Rows[i]["PCI_CK"].ToString();
                    dr["物料号"] = dt_PCI.Rows[i]["PCI_WLH"].ToString();
                    dr["物料名称"] = dt_PCI.Rows[i]["PCI_WLMC"].ToString();
                    dr["规格"] = dt_PCI.Rows[i]["PCI_SLAB_SIZE"].ToString();
                    dr["定尺"] = dt_PCI.Rows[i]["PCI_LEN"].ToString();
                    dr["钢种"] = dt_PCI.Rows[i]["PCI_PH"].ToString();
                    dr["炉号"] = dt_PCI.Rows[i]["PCI_STOVE"].ToString();
                    dr["开坯号"] = dt_PCI.Rows[i]["PCI_BATCH_NO"].ToString();
                    dr["质量等级"] = dt_PCI.Rows[i]["PCI_SX"].ToString();
                    dr["NC账存支数"] = "0";
                    dr["NC账存重量"] = "0";
                    dr["自由项1"] = dt_PCI.Rows[i]["PCI_ZYX1"].ToString();
                    dr["自由项2"] = dt_PCI.Rows[i]["PCI_ZYX2"].ToString();
                    dr["CAP账存支数"] = dt_PCI.Rows[i]["PCI_COU"].ToString();
                    dr["CAP账存重量"] = dt_PCI.Rows[i]["PCI_WGT"].ToString();
                    dr["NC与CAP支数账差"] = (0 - Convert.ToDecimal(dr["CAP账存支数"].ToString())).ToString();
                    dr["NC与CAP重量账差"] = (0 - Convert.ToDecimal(dr["CAP账存重量"].ToString())).ToString();
                    dr["生产时间"] = dt_PCI.Rows[i]["生产时间"].ToString();

                    dt.Rows.Add(dr);
                }

                dt.DefaultView.Sort = "仓库,物料号,炉号 ASC";
                dt = dt.DefaultView.ToTable();

                gc_KC.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_KC);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_KC, "钢坯库存信息-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_XGZT_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.OKCancel))
            {
                return;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ((dt.Rows[i]["NC账存支数"].ToString() == "0" || dt.Rows[i]["NC账存重量"].ToString() == "0") && (dt.Rows[i]["仓库"].ToString() == "591" || dt.Rows[i]["仓库"].ToString() == "592" || dt.Rows[i]["仓库"].ToString() == "593" || dt.Rows[i]["仓库"].ToString() == "164" || dt.Rows[i]["仓库"].ToString() == "523"))
                {
                    bllCommon.Update_Stove(dt.Rows[i]["炉号"].ToString(), dt.Rows[i]["钢种"].ToString(), dt.Rows[i]["物料号"].ToString(), dt.Rows[i]["自由项1"].ToString(), dt.Rows[i]["自由项2"].ToString(), dt.Rows[i]["仓库"].ToString());
                }
            }
            MessageBox.Show("修改成功！");
            btn_Query_Click(null, null);
        }

        DevExpress.Utils.AppearanceDefault appNotPass1 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Red, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
        private void gv_KC_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                string str_Value1 = gv_KC.GetRowCellValue(e.RowHandle, "NC与CAP支数账差").ToString();
                string str_Value2 = gv_KC.GetRowCellValue(e.RowHandle, "NC与CAP重量账差").ToString();

                if (string.IsNullOrEmpty(str_Value1))
                {
                    str_Value1 = "0";
                }

                if (string.IsNullOrEmpty(str_Value2))
                {
                    str_Value2 = "0";
                }

                if (Convert.ToDouble(str_Value1) != 0 || Convert.ToDouble(str_Value2) != 0)
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass1);
                }

            }
            catch
            {

            }
        }

        /// <summary>
        /// 修改重量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Edit_Wgt_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                if (DialogResult.OK != MessageBox.Show("是否确认修改？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }
                DataRow[] rows = dt.Select("NC与CAP支数账差 = '0' and NC与CAP重量账差 not in('0','0.0','0.00','0.000','0.0000') ");

                string result = bllCommon.UpdateWgt(rows);

                if (result == "1")
                {
                    MessageBox.Show("重量更新成功！");
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }
        /// <summary>
        /// 同步物料编码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TBWL_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != MessageBox.Show("是否确认同步？", "提示", MessageBoxButtons.OKCancel))
            {
                return;
            }
            string result_Judge = bllMain.JUDGE_MATRL();//同步物料编码
            if (result_Judge == "1")
            {
                MessageBox.Show("同步成功");
            }
            else
            {
                MessageBox.Show("同步失败");
            }
        }
        /// <summary>
        /// 同步换算率
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TBHSL_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != MessageBox.Show("是否确认同步？", "提示", MessageBoxButtons.OKCancel))
            {
                return;
            }
            string result_Judge = bllMain.JUDGE_MATRL_HSL();//同步换算率
            if (result_Judge == "1")
            {
                MessageBox.Show("同步成功");
            }
            else
            {
                MessageBox.Show("同步失败");
            }
        }
    }
}
