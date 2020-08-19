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
    public partial class FrmQC_XLSQ_JL : Form
    {
        public FrmQC_XLSQ_JL()
        {
            InitializeComponent();
        }
        Bll_TQC_UPD_MATERIAL_MAIN bllUpdMain = new Bll_TQC_UPD_MATERIAL_MAIN();
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
            dte_Begin.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
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

                DataTable dt = bll_roll_product.GetList_XL(dte_Begin1.DateTime, dte_End1.DateTime, txt_BatchNo1.Text.Trim()).Tables[0];

                gc_SJXX.DataSource = dt;
                gv_SJXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SJXX);

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
                    MessageBox.Show("请选择需要借料的信息！");
                    return;
                }
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow dr = gv_XL.GetDataRow(rownumber[i]);
                    Mod_TQC_UPDATE_MATERIAL mod = bll_Update.GetModel(dr["C_ID"].ToString());
                    mod.C_TYPE = "1";
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    if (bll_Update.Update(mod))
                    {
                        Mod_TQC_UPDATE_MATERIAL_LOG mod_log = new Mod_TQC_UPDATE_MATERIAL_LOG();
                        mod_log.C_ROLL_PRODUCT_ID = dr["C_ROLL_PRODUCT_ID"].ToString();
                        mod_log.C_TYPE = "1";
                        mod_log.C_EMP_ID = RV.UI.UserInfo.UserID;
                        bll_Update_Log.Add(mod_log);
                    }

                }
                MessageBox.Show("借料成功！");
                Query1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 借料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_JL_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要申请的！");
                    return;
                }
                string strs = "";
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];

                    strs = strs + gv_SJXX.GetRowCellValue(selectedHandle, "C_ID").ToString() + ",";
                }

                int obj = bll.TransaTSXX(strs, "0", "待修料", "","");
                if (obj == 1)
                {
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        string strID = gv_SJXX.GetRowCellValue(selectedHandle, "C_ID").ToString();
                        string strBatchNo = gv_SJXX.GetRowCellValue(selectedHandle, "C_BATCH_NO").ToString();
                        DataTable dt = bllUpdMain.GetList_BatchNo(strBatchNo).Tables[0];
                        Mod_TQC_UPDATE_MATERIAL_LOG mod_log = new Mod_TQC_UPDATE_MATERIAL_LOG();
                        mod_log.C_ROLL_PRODUCT_ID = strID;
                        mod_log.C_TYPE = "5";
                        mod_log.C_REMARK = gv_SJXX.GetRowCellValue(selectedHandle, "C_REMARK").ToString();
                        mod_log.C_EMP_ID = RV.UI.UserInfo.UserID;
                        mod_log.D_MOD_DT = Convert.ToDateTime(dt.Rows[0]["D_MOD_DT"]);
                        bll_Update_Log.Add(mod_log);
                    }

                    MessageBox.Show("借料申请成功！");
                    Query1();
                }
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
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bll_Update.GetList_Query_date(dte_Begin.DateTime, dte_End.DateTime, txt_BatchNo.Text.Trim(), "0","0").Tables[0];

                gc_XL.DataSource = dt;
                gv_XL.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_XL);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 终止借料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ZZJL_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
                if (dr==null) return;
                int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要取样的信息！");
                    return;
                }
                string strs = "";
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    if (gv_SJXX.GetRowCellValue(selectedHandle, "C_BATCH_NO").ToString()!=dr["C_BATCH_NO"].ToString())
                    {
                        MessageBox.Show("请选择相同的批号！");
                        return;
                    }
                    strs = strs + gv_SJXX.GetRowCellValue(selectedHandle, "C_ID").ToString() + ",";
                }
                if (!bllUpdMain.Update_BATCH_NO(dr["C_BATCH_NO"].ToString()))
                {
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        string strID = gv_SJXX.GetRowCellValue(selectedHandle, "C_ID").ToString();
                        string strBatchNo = gv_SJXX.GetRowCellValue(selectedHandle, "C_BATCH_NO").ToString();
                        DataTable dt = bllUpdMain.GetList_BatchNo(strBatchNo).Tables[0];
                        Mod_TQC_UPDATE_MATERIAL_LOG mod_log = new Mod_TQC_UPDATE_MATERIAL_LOG();
                        mod_log.C_ROLL_PRODUCT_ID = strID;
                        mod_log.C_TYPE = "4";
                        mod_log.C_REMARK = gv_SJXX.GetRowCellValue(selectedHandle, "C_REMARK").ToString();
                        mod_log.C_EMP_ID = RV.UI.UserInfo.UserID;
                        mod_log.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        if (bll_Update_Log.Add(mod_log))
                        {
                            Mod_TQC_UPDATE_MATERIAL_LOG mod = new Mod_TQC_UPDATE_MATERIAL_LOG();
                            mod_log.C_ROLL_PRODUCT_ID = strID;
                            mod_log.C_TYPE = "5";
                            mod_log.C_REMARK = gv_SJXX.GetRowCellValue(selectedHandle, "C_REMARK").ToString();
                            mod_log.C_EMP_ID = RV.UI.UserInfo.UserID;
                            mod_log.D_MOD_DT = Convert.ToDateTime(dt.Rows[0]["D_MOD_DT"]);
                            bll_Update_Log.Add(mod_log);
                        } 
                    } 
                    MessageBox.Show("借料申请成功！");
                    Query1();
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
