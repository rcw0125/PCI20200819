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
    public partial class FrmQC_TPGPSH_JSZX : Form
    {
        public FrmQC_TPGPSH_JSZX()
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
                DataTable dt = bllTPSlab.GetList_TP_ZKB(dte_Begin.DateTime, dte_End.DateTime, txt_Stove1.Text.Trim()).Tables[0];
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
        /// 审核通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SHTG_Click(object sender, EventArgs e)
        {
            try
            {

                int[] rownumber = gv_GPGP.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要审核的信息！");
                    return;
                }
                if (txt_CZYJ.Text.Trim() == "")
                {
                    MessageBox.Show("请输入处置意见！");
                    return;
                }
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strStove = gv_GPGP.GetRowCellValue(selectedHandle, "炉号").ToString();
                    string strSTLGRD = gv_GPGP.GetRowCellValue(selectedHandle, "改判前钢种").ToString();
                    string strSTD = gv_GPGP.GetRowCellValue(selectedHandle, "改判前标准").ToString();

                    string strXC = gv_GPGP.GetRowCellValue(selectedHandle, "线材厂审核人").ToString();
                    string strZKB = gv_GPGP.GetRowCellValue(selectedHandle, "质控部审核人").ToString();
                    string strLG = gv_GPGP.GetRowCellValue(selectedHandle, "炼钢厂审核人").ToString();
                    if (strXC == "")
                    {
                        MessageBox.Show("线材厂未审核！");
                        return;
                    }
                    if (strLG == "")
                    {
                        MessageBox.Show("炼钢厂未审核！");
                        return;
                    }
                    if (strZKB == "")
                    {
                        MessageBox.Show("质控部未审核！");
                        return;
                    }
                    DataTable dt = bllTPSlab.GetList_Stove(strStove, strSTLGRD, strSTD).Tables[0];
                    for (int s = 0; s < dt.Rows.Count; s++)
                    {
                        Mod_TQC_TP_SLAB_COMMUTE mod = bllTPSlab.GetModel(dt.Rows[s]["C_ID"].ToString());
                        mod.C_CHECK_JSZX = "Y";
                        mod.C_CZYJ_JSZX = txt_CZYJ.Text.Trim();
                        mod.C_JSZX_EMP_ID = RV.UI.UserInfo.UserName;
                        mod.D_CHECK_JSZX_DATE = RV.UI.ServerTime.timeNow();
                        bllTPSlab.Update(mod);
                    }

                }
                MessageBox.Show("审核成功！");
                btn_Query1_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 审核驳回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SHBH_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_GPGP.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要审核的信息！");
                    return;
                }
                if (txt_CZYJ.Text.Trim() == "")
                {
                    MessageBox.Show("请输入处置意见！");
                }
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strStove = gv_GPGP.GetRowCellValue(selectedHandle, "炉号").ToString();
                    string strSTLGRD = gv_GPGP.GetRowCellValue(selectedHandle, "改判前钢种").ToString();
                    string strSTD = gv_GPGP.GetRowCellValue(selectedHandle, "改判前标准").ToString();
                    DataTable dt = bllTPSlab.GetList_Stove(strStove, strSTLGRD, strSTD).Tables[0];
                    for (int s = 0; s < dt.Rows.Count; s++)
                    {
                        Mod_TQC_TP_SLAB_COMMUTE mod = bllTPSlab.GetModel(dt.Rows[s]["C_ID"].ToString());
                        mod.C_CHECK_JSZX = "N";
                        mod.C_CZYJ_JSZX = txt_CZYJ.Text.Trim();
                        mod.C_JSZX_EMP_ID = RV.UI.UserInfo.UserName;
                        mod.D_CHECK_JSZX_DATE = RV.UI.ServerTime.timeNow();
                        bllTPSlab.Update(mod);
                        Mod_TSC_SLAB_MAIN mod_slab = bll_slab.GetModel(dt.Rows[s]["C_SLAB_MAIN_ID"].ToString());
                        mod_slab.C_MOVE_TYPE = dt.Rows[s]["C_REMARK2"].ToString();
                        bll_slab.Update(mod_slab);
                    }
                }
                MessageBox.Show("已驳回！");
                btn_Query1_Click(null, null);
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
    }
}
