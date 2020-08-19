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
    public partial class FrmQC_XLSQ : Form
    {
        public FrmQC_XLSQ()
        {
            InitializeComponent();
        }
        Bll_TQC_ROLL_COMMUTE bll = new Bll_TQC_ROLL_COMMUTE();
        Bll_TRC_ROLL_PRODCUT bll_roll_product = new Bll_TRC_ROLL_PRODCUT();
        Bll_TQC_UPDATE_MATERIAL bll_Update = new Bll_TQC_UPDATE_MATERIAL();
        Bll_TQC_UPDATE_MATERIAL_LOG bll_Update_Log = new Bll_TQC_UPDATE_MATERIAL_LOG();
        Bll_TQC_UPD_MATERIAL_MAIN bllUpdMain = new Bll_TQC_UPD_MATERIAL_MAIN();
        Bll_TQC_RECHECK bllRecheck = new Bll_TQC_RECHECK();
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
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            Query();
        }
        private void Query()
        {
            try
            {
                gc_SJXX.DataSource = null;
                WaitingFrom.ShowWait("");
                DataTable dt = new DataTable();
                if (imgcbo_Type.EditValue.ToString()=="复检")
                {
                    dt = bllRecheck.GetList_XLSQ(dte_Begin1.DateTime, dte_End1.DateTime, txt_BatchNo.Text.Trim()).Tables[0];
                }
                if (imgcbo_Type.EditValue.ToString()=="线材库检")
                {
                    dt = bllRecheck.GetList_XCKJ(dte_Begin1.DateTime, dte_End1.DateTime, txt_BatchNo.Text.Trim()).Tables[0];
                }
                gc_SJXX.DataSource = dt;

                gv_SJXX.BestFitColumns();

                gv_SJXX.Columns[0].Visible = false;
                SetGridViewRowNum.SetRowNum(gv_SJXX);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                DataTable dt = bllUpdMain.GetList(txt_BatchNo1.Text.Trim()).Tables[0];


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
                DataRow dr = gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
                if (dr == null) return;
                Mod_TQC_UPD_MATERIAL_MAIN mod = new Mod_TQC_UPD_MATERIAL_MAIN();
                mod.C_BATCH_NO = dr["批号"].ToString();
                mod.C_REMARK = txt_CZYJ.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_BATCH_NO", mod.C_BATCH_NO);
                ht.Add("N_STATUS", 1);
                if (Common.CheckRepeat.CheckTable("TQC_UPD_MATERIAL_MAIN", ht) > 0)
                {
                    if (DialogResult.OK != MessageBox.Show("该批号已申请'" + mod.C_BATCH_NO + "'，是否确认继续申请！", "提示", MessageBoxButtons.OKCancel))
                    {
                        return;
                    }
                    else
                    {
                        DataTable dt = bll_Update.GetList_CXXL(dr["批号"].ToString()).Tables[0];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Mod_TQC_UPDATE_MATERIAL mod_update = bll_Update.GetModel(dt.Rows[i]["C_ID"].ToString());
                            mod_update.N_STATUS = 0;
                            mod_update.C_EMP_ID = RV.UI.UserInfo.UserID;
                            mod_update.D_MOD_DT = RV.UI.ServerTime.timeNow();
                            bll_Update.Update(mod_update);
                        }

                    }
                }
                #endregion
                if (bllUpdMain.Add(mod))
                {


                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加修料申请");//添加操作日志

                    MessageBox.Show("申请成功！");
                    Query();
                    Query1();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 取消申请
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QXSQ_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否取消？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    Bll_Common bllCommon = new Bll_Common();

                    DataRow dr = gv_XL.GetDataRow(gv_XL.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bllCommon.DataDisabled("TQC_UPD_MATERIAL_MAIN", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消修料申请信息");//添加操作日志
                            Query();
                            Query1();
                            MessageBox.Show("已取消申请！");
                        }
                    }
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
        /// 回传处置意见
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_SJXX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_CZYJ.Text = "";
            DataRow dr = gv_SJXX.GetDataRow(gv_SJXX.FocusedRowHandle);
            if (dr == null) return;
            txt_CZYJ.Text = dr["处置意见"].ToString();

        }
    }
}
