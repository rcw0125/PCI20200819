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
    public partial class FrmQR_TM_NC_PCI_KC : Form
    {
        private Bll_Common bllCommon = new Bll_Common();
        private Bll_TRC_ROLL_PDD bllRollPdd = new Bll_TRC_ROLL_PDD();

        private DataTable dt;

        public FrmQR_TM_NC_PCI_KC()
        {
            InitializeComponent();
        }

        private void FrmQR_TM_NC_PCI_KC_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            dt = new DataTable();
            dt.Columns.Add("仓库");
            dt.Columns.Add("物料号");
            dt.Columns.Add("物料名称");
            dt.Columns.Add("规格");
            dt.Columns.Add("钢种");
            dt.Columns.Add("批次号");
            dt.Columns.Add("质量等级");
            dt.Columns.Add("NC账存卷数");
            dt.Columns.Add("NC账存数量");
            dt.Columns.Add("CAP账存卷数");
            dt.Columns.Add("CAP账存数量");
            dt.Columns.Add("条码账存卷数");
            dt.Columns.Add("条码账存数量");
            dt.Columns.Add("条码实盘卷数");
            dt.Columns.Add("条码实盘数量");
            dt.Columns.Add("NC与CAP卷数账差");
            dt.Columns.Add("NC与CAP数量账差");
            dt.Columns.Add("条码与CAP数量账差");
            dt.Columns.Add("条码与CAP卷数账差");
            dt.Columns.Add("CAP与实盘卷数差异");
            dt.Columns.Add("CAP与实盘数量差异");
            dt.Columns.Add("原因备注");
            dt.Columns.Add("自由项1");
            dt.Columns.Add("自由项2");
            dt.Columns.Add("自由项3");
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
                WaitingFrom.ShowWait("");

                dt.Clear();

                DataTable dt_TM = GetTM();
                DataTable dt_NC = GetNC();
                DataTable dt_PCI = GetPCI();                

                //  TM_CK   TM_WLH  TM_WLMC   TM_GG   TM_PH   TM_PCH   TM_SX   TM_COU   TM_ZL   TM_ZYX1   TM_ZYX2   TM_ZYX3
                //  PCI_CK   PCI_PCH   PCI_GG  PCI_COU   PCI_WGT  PCI_PH  PCI_SX  PCI_WLH  PCI_WLMC  PCI_ZYX1  PCI_ZYX2  PCI_ZYX3
                //  NC_CK   NC_PCH   NC_PH   NC_GG   NC_SX   NC_WGT   NC_COU   NC_WLH   NC_WLMC   NC_ZYX1   NC_ZYX2   NC_ZYX3

                for (int i = 0; i < dt_TM.Rows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["仓库"] = dt_TM.Rows[i]["TM_CK"].ToString();
                    dr["物料号"] = dt_TM.Rows[i]["TM_WLH"].ToString();
                    dr["物料名称"] = dt_TM.Rows[i]["TM_WLMC"].ToString();
                    dr["规格"] = dt_TM.Rows[i]["TM_GG"].ToString();
                    dr["钢种"] = dt_TM.Rows[i]["TM_PH"].ToString();
                    dr["批次号"] = dt_TM.Rows[i]["TM_PCH"].ToString();
                    dr["质量等级"] = dt_TM.Rows[i]["TM_SX"].ToString();
                    dr["条码账存卷数"] = dt_TM.Rows[i]["TM_COU"].ToString();
                    dr["条码账存数量"] = dt_TM.Rows[i]["TM_ZL"].ToString();
                    dr["自由项1"] = dt_TM.Rows[i]["TM_ZYX1"].ToString();
                    dr["自由项2"] = dt_TM.Rows[i]["TM_ZYX2"].ToString();
                    dr["自由项3"] = dt_TM.Rows[i]["TM_ZYX3"].ToString();

                    DataRow[] row_PCI = dt_PCI.Select("PCI_CK = '" + dt_TM.Rows[i]["TM_CK"].ToString() + "' and PCI_PCH = '" + dt_TM.Rows[i]["TM_PCH"].ToString() + "' and PCI_GG = '" + dt_TM.Rows[i]["TM_GG"].ToString() + "' and PCI_PH = '" + dt_TM.Rows[i]["TM_PH"].ToString() + "' and PCI_SX = '" + dt_TM.Rows[i]["TM_SX"].ToString() + "' and PCI_WLH = '" + dt_TM.Rows[i]["TM_WLH"].ToString() + "' and PCI_ZYX1 = '" + dt_TM.Rows[i]["TM_ZYX1"].ToString() + "' and PCI_ZYX2 = '" + dt_TM.Rows[i]["TM_ZYX2"].ToString() + "' and PCI_ZYX3 = '" + dt_TM.Rows[i]["TM_ZYX3"].ToString() + "' ");

                    if (row_PCI.Length > 1)
                    {
                        MessageBox.Show("批次号：" + dt_TM.Rows[i]["TM_PCH"].ToString() + "信息有误！");
                        return;
                    }
                    else if (row_PCI.Length == 1)
                    {
                        foreach (var item in row_PCI)
                        {
                            dr["CAP账存卷数"] = item["PCI_COU"].ToString();
                            dr["CAP账存数量"] = item["PCI_WGT"].ToString();
                            dr["条码与CAP数量账差"] = (Convert.ToDecimal(dr["条码账存数量"].ToString()) - Convert.ToDecimal(item["PCI_WGT"].ToString())).ToString();
                            dr["条码与CAP卷数账差"] = (Convert.ToDecimal(dr["条码账存卷数"].ToString()) - Convert.ToDecimal(item["PCI_COU"].ToString())).ToString();
                        }

                        dt_PCI.Rows.Remove(row_PCI[0]);
                    }
                    else
                    {
                        dr["CAP账存卷数"] = "0";
                        dr["CAP账存数量"] = "0";
                        dr["条码与CAP数量账差"] = dr["条码账存数量"].ToString();
                        dr["条码与CAP卷数账差"] = dr["条码账存卷数"].ToString();
                    }


                    DataRow[] row_NC = dt_NC.Select("NC_CK = '" + dt_TM.Rows[i]["TM_CK"].ToString() + "' and NC_PCH = '" + dt_TM.Rows[i]["TM_PCH"].ToString() + "' and NC_GG = '" + dt_TM.Rows[i]["TM_GG"].ToString() + "' and NC_PH = '" + dt_TM.Rows[i]["TM_PH"].ToString() + "' and NC_SX = '" + dt_TM.Rows[i]["TM_SX"].ToString() + "' and NC_WLH = '" + dt_TM.Rows[i]["TM_WLH"].ToString() + "' and NC_ZYX1 = '" + dt_TM.Rows[i]["TM_ZYX1"].ToString() + "' and NC_ZYX2 = '" + dt_TM.Rows[i]["TM_ZYX2"].ToString() + "' and NC_ZYX3 = '" + dt_TM.Rows[i]["TM_ZYX3"].ToString() + "' ");

                    if (row_NC.Length > 1)
                    {
                        MessageBox.Show("批次号：" + dt_TM.Rows[i]["TM_PCH"].ToString() + "信息有误！");
                        return;
                    }
                    else if (row_NC.Length == 1)
                    {
                        foreach (var item in row_NC)
                        {
                            dr["NC账存卷数"] = item["NC_COU"].ToString();
                            dr["NC账存数量"] = item["NC_WGT"].ToString();
                            dr["NC与CAP数量账差"] = (Convert.ToDecimal(item["NC_WGT"].ToString()) - Convert.ToDecimal(dr["CAP账存数量"].ToString())).ToString();
                            dr["NC与CAP卷数账差"] = (Convert.ToDecimal(item["NC_COU"].ToString()) - Convert.ToDecimal(dr["CAP账存卷数"].ToString())).ToString();
                        }

                        dt_NC.Rows.Remove(row_NC[0]);
                    }
                    else
                    {
                        dr["NC账存卷数"] = "0";
                        dr["NC账存数量"] = "0";
                        dr["NC与CAP数量账差"] = (0 - Convert.ToDecimal(dr["CAP账存数量"].ToString())).ToString();
                        dr["NC与CAP卷数账差"] = (0 - Convert.ToDecimal(dr["CAP账存卷数"].ToString())).ToString();
                    }

                    dt.Rows.Add(dr);
                }

                for (int i = 0; i < dt_PCI.Rows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["仓库"] = dt_PCI.Rows[i]["PCI_CK"].ToString();
                    dr["物料号"] = dt_PCI.Rows[i]["PCI_WLH"].ToString();
                    dr["物料名称"] = dt_PCI.Rows[i]["PCI_WLMC"].ToString();
                    dr["规格"] = dt_PCI.Rows[i]["PCI_GG"].ToString();
                    dr["钢种"] = dt_PCI.Rows[i]["PCI_PH"].ToString();
                    dr["批次号"] = dt_PCI.Rows[i]["PCI_PCH"].ToString();
                    dr["质量等级"] = dt_PCI.Rows[i]["PCI_SX"].ToString();
                    dr["条码账存卷数"] = "0";
                    dr["条码账存数量"] = "0";
                    dr["自由项1"] = dt_PCI.Rows[i]["PCI_ZYX1"].ToString();
                    dr["自由项2"] = dt_PCI.Rows[i]["PCI_ZYX2"].ToString();
                    dr["自由项3"] = dt_PCI.Rows[i]["PCI_ZYX3"].ToString();
                    dr["CAP账存卷数"] = dt_PCI.Rows[i]["PCI_COU"].ToString();
                    dr["CAP账存数量"] = dt_PCI.Rows[i]["PCI_WGT"].ToString();
                    dr["条码与CAP数量账差"] = (0 - Convert.ToDecimal(dt_PCI.Rows[i]["PCI_WGT"].ToString())).ToString();
                    dr["条码与CAP卷数账差"] = (0 - Convert.ToDecimal(dt_PCI.Rows[i]["PCI_COU"].ToString())).ToString();

                    DataRow[] row_NC = dt_NC.Select("NC_CK = '" + dt_PCI.Rows[i]["PCI_CK"].ToString() + "' and NC_PCH = '" + dt_PCI.Rows[i]["PCI_PCH"].ToString() + "' and NC_GG = '" + dt_PCI.Rows[i]["PCI_GG"].ToString() + "' and NC_PH = '" + dt_PCI.Rows[i]["PCI_PH"].ToString() + "' and NC_SX = '" + dt_PCI.Rows[i]["PCI_SX"].ToString() + "' and NC_WLH = '" + dt_PCI.Rows[i]["PCI_WLH"].ToString() + "' and NC_ZYX1 = '" + dt_PCI.Rows[i]["PCI_ZYX1"].ToString() + "' and NC_ZYX2 = '" + dt_PCI.Rows[i]["PCI_ZYX2"].ToString() + "' and NC_ZYX3 = '" + dt_PCI.Rows[i]["PCI_ZYX3"].ToString() + "' ");

                    if (row_NC.Length > 1)
                    {
                        MessageBox.Show("批次号：" + dt_PCI.Rows[i]["PCI_PCH"].ToString() + "信息有误！");
                        return;
                    }
                    else if (row_NC.Length == 1)
                    {
                        foreach (var item in row_NC)
                        {
                            dr["NC账存卷数"] = item["NC_COU"].ToString();
                            dr["NC账存数量"] = item["NC_WGT"].ToString();
                            dr["NC与CAP数量账差"] = (Convert.ToDecimal(item["NC_WGT"].ToString()) - Convert.ToDecimal(dr["CAP账存数量"].ToString())).ToString();
                            dr["NC与CAP卷数账差"] = (Convert.ToDecimal(item["NC_COU"].ToString()) - Convert.ToDecimal(dr["CAP账存卷数"].ToString())).ToString();
                        }

                        dt_NC.Rows.Remove(row_NC[0]);
                    }
                    else
                    {
                        dr["NC账存卷数"] = "0";
                        dr["NC账存数量"] = "0";
                        dr["NC与CAP数量账差"] = (0 - Convert.ToDecimal(dr["CAP账存数量"].ToString())).ToString();
                        dr["NC与CAP卷数账差"] = (0 - Convert.ToDecimal(dr["CAP账存卷数"].ToString())).ToString();
                    }

                    dt.Rows.Add(dr);
                }

                for (int i = 0; i < dt_NC.Rows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["仓库"] = dt_NC.Rows[i]["NC_CK"].ToString();
                    dr["物料号"] = dt_NC.Rows[i]["NC_WLH"].ToString();
                    dr["物料名称"] = dt_NC.Rows[i]["NC_WLMC"].ToString();
                    dr["规格"] = dt_NC.Rows[i]["NC_GG"].ToString();
                    dr["钢种"] = dt_NC.Rows[i]["NC_PH"].ToString();
                    dr["批次号"] = dt_NC.Rows[i]["NC_PCH"].ToString();
                    dr["质量等级"] = dt_NC.Rows[i]["NC_SX"].ToString();
                    dr["条码账存卷数"] = "0";
                    dr["条码账存数量"] = "0";
                    dr["自由项1"] = dt_NC.Rows[i]["NC_ZYX1"].ToString();
                    dr["自由项2"] = dt_NC.Rows[i]["NC_ZYX2"].ToString();
                    dr["自由项3"] = dt_NC.Rows[i]["NC_ZYX3"].ToString();
                    dr["CAP账存卷数"] = "0";
                    dr["CAP账存数量"] = "0";
                    dr["条码与CAP数量账差"] = "0";
                    dr["条码与CAP卷数账差"] = "0";
                    dr["NC账存卷数"] = dt_NC.Rows[i]["NC_COU"].ToString();
                    dr["NC账存数量"] = dt_NC.Rows[i]["NC_WGT"].ToString();
                    dr["NC与CAP数量账差"] = (Convert.ToDecimal(dt_NC.Rows[i]["NC_WGT"].ToString()) - 0).ToString();
                    dr["NC与CAP卷数账差"] = (Convert.ToDecimal(dt_NC.Rows[i]["NC_COU"].ToString()) - 0).ToString();

                    dt.Rows.Add(dr);
                }

                dt.DefaultView.Sort = "仓库,物料号,批次号 ASC";
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

        /// <summary>
        /// 获取条码库存
        /// </summary>
        /// <returns></returns>
        private DataTable GetTM()
        {
            DataTable dtTM = bllCommon.Get_TM_KCList().Tables[0];

            return dtTM;
        }

        /// <summary>
        /// 获取NC库存
        /// </summary>
        /// <returns></returns>
        private DataTable GetNC()
        {
            DataTable dtNC = bllCommon.Get_NC_KCList().Tables[0];

            return dtNC;
        }

        /// <summary>
        /// 获取PCI库存
        /// </summary>
        /// <returns></returns>
        private DataTable GetPCI()
        {
            DataTable dtPCI = bllCommon.Get_PCI_KCList().Tables[0];

            return dtPCI;
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_KC, "库存信息-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void gv_KC_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {

                string str_Value1 = gv_KC.GetRowCellValue(e.RowHandle, "NC与CAP卷数账差").ToString();
                string str_Value2 = gv_KC.GetRowCellValue(e.RowHandle, "NC与CAP数量账差").ToString();
                string str_Value3 = gv_KC.GetRowCellValue(e.RowHandle, "条码与CAP数量账差").ToString();
                string str_Value4 = gv_KC.GetRowCellValue(e.RowHandle, "条码与CAP卷数账差").ToString();
                string str_Value5 = gv_KC.GetRowCellValue(e.RowHandle, "CAP与实盘卷数差异").ToString();
                string str_Value6 = gv_KC.GetRowCellValue(e.RowHandle, "CAP与实盘数量差异").ToString();

                if (string.IsNullOrEmpty(str_Value1))
                {
                    str_Value1 = "0";
                }

                if (string.IsNullOrEmpty(str_Value2))
                {
                    str_Value2 = "0";
                }

                if (string.IsNullOrEmpty(str_Value3))
                {
                    str_Value3 = "0";
                }

                if (string.IsNullOrEmpty(str_Value4))
                {
                    str_Value4 = "0";
                }

                if (string.IsNullOrEmpty(str_Value5))
                {
                    str_Value5 = "0";
                }

                if (string.IsNullOrEmpty(str_Value6))
                {
                    str_Value6 = "0";
                }

                if (Convert.ToDouble(str_Value1) != 0 || Convert.ToDouble(str_Value2) != 0 || Convert.ToDouble(str_Value3) != 0 || Convert.ToDouble(str_Value4) != 0 || Convert.ToDouble(str_Value5) != 0 || Convert.ToDouble(str_Value6) != 0)
                {
                    e.Appearance.BackColor = Color.Red;
                }

            }
            catch
            {

            }
        }

        /// <summary>
        /// 下发条码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Down_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");

                if (DialogResult.No == MessageBox.Show("确认下发条码吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                string result = bllRollPdd.Down_RF(dt);

                if (result == "1")
                {
                    MessageBox.Show("下发成功！");
                }
                else
                {
                    MessageBox.Show(result);
                }

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}