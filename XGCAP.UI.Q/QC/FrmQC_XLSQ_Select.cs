using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using BLL;
using Common;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_XLSQ_Select : Form
    {
        public FrmQC_XLSQ_Select()
        {
            InitializeComponent();
        }
        Bll_TQC_ROLL_COMMUTE bll = new Bll_TQC_ROLL_COMMUTE();

        Bll_TRC_ROLL_PRODCUT bll_roll_product = new Bll_TRC_ROLL_PRODCUT();
        Bll_TQC_UPDATE_MATERIAL bll_Update = new Bll_TQC_UPDATE_MATERIAL();
        Bll_TQC_UPDATE_MATERIAL_LOG bll_Update_Log = new Bll_TQC_UPDATE_MATERIAL_LOG();
        private string strMenuName;
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC_XLSQ_Load(object sender, EventArgs e)
        {
            //UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            dte_Begin1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        /// <summary>
        /// 查询修料申请
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query1();
        }

        private void Query1()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bll_Update.GetList_Query_date_log(dte_Begin1.DateTime, dte_End1.DateTime, txt_BatchNo1.Text.Trim(), txt_STLGRD.Text.Trim(), imgcbo_Type.Text.Trim()).Tables[0];
                dt.Columns.Add("总修料时间", typeof(double));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(dt.Rows[i]["修料申请时间"].ToString()) && !string.IsNullOrEmpty(dt.Rows[i]["还料确认时间"].ToString()) && !string.IsNullOrEmpty(dt.Rows[i]["质量确认时间"].ToString()))
                    {
                        DateTime date = Convert.ToDateTime(dt.Rows[i]["还料确认时间"].ToString());
                        if ((Convert.ToDateTime(dt.Rows[i]["还料确认时间"].ToString())) >= (Convert.ToDateTime(dt.Rows[i]["质量确认时间"].ToString())))
                        {
                            date = Convert.ToDateTime(dt.Rows[i]["还料确认时间"].ToString());
                        }
                        if ((Convert.ToDateTime(dt.Rows[i]["质量确认时间"].ToString())) >= (Convert.ToDateTime(dt.Rows[i]["还料确认时间"].ToString())))
                        {
                            date = Convert.ToDateTime(dt.Rows[i]["质量确认时间"].ToString());
                        }
                        System.TimeSpan da = date - Convert.ToDateTime(dt.Rows[i]["修料申请时间"].ToString());
                        double ts = Math.Round(da.TotalHours);
                        dt.Rows[i]["总修料时间"] = ts;
                    }
                }
                gc_XL.DataSource = dt;
                gv_XL.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_XL);


                gv_XL.Columns[10].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;//求和
                gv_XL.Columns[11].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;//求和
                gv_XL.Columns[12].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;//求和

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 申请
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Apply_Click(object sender, EventArgs e)
        {
            try
            {

                int[] rownumber = gv_XL.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要确认的信息！");
                    return;
                }
                string strs = "";
                string rollID = "";
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];

                    strs = strs + gv_XL.GetRowCellValue(selectedHandle, "C_ROLL_PRODUCT_ID").ToString() + ",";
                    rollID = rollID + gv_XL.GetRowCellValue(selectedHandle, "C_ID").ToString() + ",";
                }

                // int obj = bll.TransaTSXX(strs, "3", "", rollID);
                // if (obj == 1)
                // {
                //     MessageBox.Show("确认成功！");
                //     Query1();
                // }
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
            OutToExcel.ToExcel(gc_XL, "修料记录-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
