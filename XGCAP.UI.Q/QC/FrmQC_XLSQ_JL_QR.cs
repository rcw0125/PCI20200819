﻿using System;
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
    public partial class FrmQC_XLSQ_JL_QR : Form
    {
        public FrmQC_XLSQ_JL_QR()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_roll_product = new Bll_TRC_ROLL_PRODCUT();
        Bll_TQC_UPDATE_MATERIAL bll_Update = new Bll_TQC_UPDATE_MATERIAL();
        Bll_Interface_FR bll_Interface_FR = new Bll_Interface_FR();
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

                DataTable dt = bll_Update.GetList_Query_date(dte_Begin1.DateTime, dte_End1.DateTime, txt_BatchNo1.Text.Trim(), "0","0").Tables[0];

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
                    MessageBox.Show("请选择需要借料确认的信息！");
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
                MessageBox.Show("确认成功！");
                Query1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
