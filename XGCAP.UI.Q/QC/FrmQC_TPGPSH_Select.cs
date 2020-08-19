using Common;
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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_TPGPSH_Select : Form
    {
        public FrmQC_TPGPSH_Select()
        {
            InitializeComponent();
        }
        Bll_TSC_SLAB_MAIN bll_slab = new Bll_TSC_SLAB_MAIN();
        Bll_TQC_TP_SLAB_COMMUTE bllTPSlab = new Bll_TQC_TP_SLAB_COMMUTE();
        private string strMenuName;
        private string strPhyCode;
        private void FrmQC_TPGPSH_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            strPhyCode = RV.UI.QueryString.parameter;

            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bllTPSlab.GetList_TPJL(dte_Begin.DateTime, dte_End.DateTime, txt_Stove1.Text.Trim()).Tables[0];
                gc_GPGP.DataSource = dt;
                gv_GPGP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPGP);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        /// <summary>
        /// 双击查询成分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_GPGP_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gv_GPGP.FocusedColumn.GetTextCaption() == "炉号")
                {
                    int handle = gv_GPGP.FocusedRowHandle;
                    if (handle >= 0)
                    {
                        string strStove = gv_GPGP.GetRowCellValue(handle, "炉号").ToString();
                        string strStlGrd = gv_GPGP.GetRowCellValue(handle, "改判后钢种").ToString();
                        string strStdCode = gv_GPGP.GetRowCellValue(handle, "改判后标准").ToString();

                        FrmQC_CFPD_TP frm = new FrmQC_CFPD_TP(strStove, strStdCode, strStlGrd);
                        frm.ShowDialog();
                    }
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
            OutToExcel.ToExcel(gc_GPGP, "挑坯改判查询-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
