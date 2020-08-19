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
    public partial class FrmQC_FJQR : Form
    {
        public FrmQC_FJQR()
        {
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQC_COMPRE_ITEM_RESULT bll_item_result = new Bll_TQC_COMPRE_ITEM_RESULT();//综合判定项目结果明细
        Bll_TQC_RECHECK bll_recheck = new Bll_TQC_RECHECK();//复检申请
        private Bll_TQC_COMPRE_ROLL bllTqcCompreRoll = new Bll_TQC_COMPRE_ROLL();
        Bll_TRC_ROLL_PRODCUT bllRollPro = new Bll_TRC_ROLL_PRODCUT();

        private Bll_Common bllCommon = new Bll_Common();

        private void FrmQC_FJQR_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;


            dte_Begin1.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }


        /// <summary>
        /// 复检申请查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Sam_Click(object sender, EventArgs e)
        {
            Query_SQ();
        }
        /// <summary>
        /// 复检申请查询
        /// </summary>
        private void Query_SQ()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = new DataTable();
                if (rbtn_isty_wh.SelectedIndex == 2)
                {
                    dt = bll_recheck.GetList_Query(Convert.ToDateTime(dte_Begin1.DateTime), Convert.ToDateTime(dte_End1.DateTime), "", txt_BatchNo_Sam.Text.Trim(), 2).Tables[0];
                }

                if (rbtn_isty_wh.SelectedIndex == 1)
                {
                    dt = bll_recheck.GetList_Query(Convert.ToDateTime(dte_Begin1.DateTime), Convert.ToDateTime(dte_End1.DateTime), "", txt_BatchNo_Sam.Text.Trim(), 1).Tables[0];
                }
                if (rbtn_isty_wh.SelectedIndex == 0)
                {
                    dt = bll_recheck.GetList_Query(Convert.ToDateTime(dte_Begin1.DateTime), Convert.ToDateTime(dte_End1.DateTime), "", txt_BatchNo_Sam.Text.Trim(), 0).Tables[0];
                }

                this.gc_SQLB.DataSource = dt;
                gv_SQLB.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SQLB);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QR_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_SQLB.GetSelectedRows();//获取选中行号数组；
                int[] number_tick_no = gv_GH.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要确认的信息！");
                    return;
                }
                if (rbtn_isty_wh.SelectedIndex == 0)
                {
                    if (rownumber.Length != number_tick_no.Length)
                    {
                        MessageBox.Show("选择的批号和钩号不一致！");
                        return;
                    }
                }
                if (rbtn_isty_wh.SelectedIndex == 2)
                {
                    MessageBox.Show("已是最终确认状态！");
                    return;
                }
                DataRow row = gv_SQLB.GetDataRow(rownumber[0]);
                DataTable dt_main = null;
                string[] str_tick_no = new string[rownumber.Length];
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow dr = gv_SQLB.GetDataRow(rownumber[i]);
                    dt_main = gv_SQLB.GetDataRow(rownumber[i]).Table;

                    if (dr["C_BATCH_NO"].ToString() != row["C_BATCH_NO"].ToString())
                    {
                        MessageBox.Show("批次不同，请重新选择！");

                        return;
                    }
                    if (rbtn_isty_wh.SelectedIndex == 0)
                    {
                        str_tick_no[i] = gv_GH.GetRowCellValue(number_tick_no[i], "C_TICK_NO").ToString();
                    }
                    if (rbtn_isty_wh.SelectedIndex == 1)
                    {
                        str_tick_no[i] = gv_SQLB.GetRowCellValue(rownumber[i], "C_ID").ToString();
                    }
                }
                if (DialogResult.OK != MessageBox.Show("是否确认已选中的数据？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }
                string result = "";
                if (rbtn_isty_wh.SelectedIndex == 1)
                {
                    result = bllTqcCompreRoll.Recheck_QR(dt_main, rownumber, str_tick_no, txt_QRZT.Text.Trim(), 2);
                }
                if (rbtn_isty_wh.SelectedIndex == 0)
                {
                    result = bllTqcCompreRoll.Recheck_SL(dt_main, rownumber, str_tick_no, "", 1);
                }

                if (result == "1")
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "确认复检申请信息");//添加操作日志

                    MessageBox.Show("已确认！");
                    Query_SQ();
                }
                else
                {
                    MessageBox.Show("操作失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 钩号信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_SQLB_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                this.gc_GH.DataSource = null;
                int[] rownumber = gv_SQLB.GetSelectedRows();//获取选中行号数组； 
                if (rownumber.Length == 0) return;
                DataRow row = gv_SQLB.GetDataRow(rownumber[0]);
                DataTable dt = bllRollPro.GetList_Tick_No(row["C_BATCH_NO"].ToString()).Tables[0];
                DataTable dt_GH = bllRollPro.GetList_TickNo_Check(row["C_BATCH_NO"].ToString()).Tables[0];

                this.gc_GH.DataSource = dt;
                gv_GH.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_isty_wh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query_SQ();
        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {

                    Bll_Common bllCommon = new Bll_Common();
                    DataRow dr_StdMain = gv_SQLB.GetDataRow(gv_SQLB.FocusedRowHandle);
                    int[] rownumber = gv_SQLB.GetSelectedRows();//获取选中行号数组；
                    if (rownumber.Length == 0)
                    {
                        MessageBox.Show("请选择需要添加的信息！");
                        return;
                    }

                    for (int si = 0; si < rownumber.Length; si++)
                    {
                        DataRow dr = gv_SQLB.GetDataRow(rownumber[si]);
                        bllCommon.DataDisabled("TQC_RECHECK", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow());
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用复检信息");//添加操作日志
                    }
                    Query_SQ();
                    MessageBox.Show("已删除！");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else//如果点击“取消”按钮
            {
                return;
            }

        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_SQLB, "复检信息" + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}

