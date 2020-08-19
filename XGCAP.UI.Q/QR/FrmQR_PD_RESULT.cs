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
    public partial class FrmQR_PD_RESULT : Form
    {
        private Bll_Common bllCommon = new Bll_Common();
        private Bll_TRC_ROLL_PDD bllRollPdd = new Bll_TRC_ROLL_PDD();
        private Bll_TRC_ROLL_PDD_ITEM bllRollPddItem = new Bll_TRC_ROLL_PDD_ITEM();

        public FrmQR_PD_RESULT()
        {
            InitializeComponent();
        }

        private void FrmQR_PD_RESULT_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindMain();
        }

        private void BindMain()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Main.DataSource = null;

                DataTable dt = bllRollPdd.GetList(dt_Start.Text.Trim(), dt_End.Text.Trim()).Tables[0];

                gc_Main.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Main);

                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        private void gv_Main_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_Main.GetDataRow(e.FocusedRowHandle);
                if (dr != null)
                {
                    BindItem(dr["C_YSDH"].ToString());
                }
                else
                {
                    gc_KC.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindItem(string strYSDH)
        {
            DataTable dt = bllRollPddItem.Get_List(strYSDH).Tables[0];

            gc_KC.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_KC);
        }

        /// <summary>
        /// 同步条码盘点结果信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Down_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");

                if (DialogResult.No == MessageBox.Show("确认同步条码盘点结果吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                string result = bllRollPdd.TB_RF_PD_Result();

                if (result == "1")
                {
                    MessageBox.Show("同步成功！");
                    BindMain();
                }
                else
                {
                    MessageBox.Show(result);
                    return;
                }

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_KC_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                string str_Value1 = gv_KC.GetRowCellValue(e.RowHandle, "C_NC_CAP_SL").ToString();
                string str_Value2 = gv_KC.GetRowCellValue(e.RowHandle, "C_NC_CAP_ZL").ToString();
                string str_Value3 = gv_KC.GetRowCellValue(e.RowHandle, "C_RF_CAP_SL").ToString();
                string str_Value4 = gv_KC.GetRowCellValue(e.RowHandle, "C_RF_CAP_ZL").ToString();
                string str_Value5 = gv_KC.GetRowCellValue(e.RowHandle, "C_CAP_SJ_SL").ToString();
                string str_Value6 = gv_KC.GetRowCellValue(e.RowHandle, "C_CAP_SJ_ZL").ToString();

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
    }
}