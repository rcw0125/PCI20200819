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
using MODEL;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_XCKJGL : Form
    {
        public FrmQC_XCKJGL()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_TRC_Roll_Product = new Bll_TRC_ROLL_PRODCUT();
        Bll_TQB_WAREHOUSE_CAUSE bll_cause = new Bll_TQB_WAREHOUSE_CAUSE();
        Bll_TQB_WAREHOUSE_CAUSE_OPINION bll_opinion = new Bll_TQB_WAREHOUSE_CAUSE_OPINION();
        Bll_TQC_WAREHOUSE_CHECK_ROLL bll_we_check_roll = new Bll_TQC_WAREHOUSE_CHECK_ROLL();
        Bll_TQC_UPD_MATERIAL_MAIN bllUpdMaterial = new Bll_TQC_UPD_MATERIAL_MAIN();
        Bll_TQC_UPDATE_MATERIAL bll_Update = new Bll_TQC_UPDATE_MATERIAL();

        private string strMenuName;

        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC008_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
                dte_Begin1.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
                DataSet dt = bll_cause.GetList_Group("");
                imgcbo_YYLX.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)//原因类型
                {
                    imgcbo_YYLX.Properties.Items.Add(item["C_CAUSE_TYPE"].ToString(), item["C_CAUSE_TYPE"], -1);
                }
                DataSet dt_opinion = bll_opinion.GetList("");
                imgcbo_CZYJ.Properties.Items.Clear();
                foreach (DataRow item in dt_opinion.Tables[0].Rows)//处置意见
                {
                    imgcbo_CZYJ.Properties.Items.Add(item["C_CAUSE_OPINION"].ToString(), item["C_ID"], -1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 线材实绩查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_TRC_Roll_Product.GetList_KJ(Convert.ToDateTime(dte_Begin1.DateTime), Convert.ToDateTime(dte_End1.DateTime), txt_BatchNo.Text).Tables[0];
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
        /// 库检原因名称查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_YYLX_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dt = bll_cause.GetList_name(imgcbo_YYLX.EditValue.ToString());
                imgcbo_YYMC.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)//原因名称下拉框查询
                {
                    imgcbo_YYMC.Properties.Items.Add(item["C_CAUSE_NAME"].ToString(), item["C_ID"], -1);
                }
                imgcbo_YYMC.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 查询线材库检信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (this.rbtn_isty_wh.SelectedIndex == 0)//未确认 查询
                {
                    dt = bll_we_check_roll.GetList_Query(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_BatchNo1.Text).Tables[0];
                }
                else//已确认
                {
                    dt = bll_we_check_roll.GetList_Query1(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_BatchNo1.Text).Tables[0];
                }
                gc_PDJG.DataSource = dt;
                gv_PDJG.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_PDJG);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 库检申请
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_KJSQ_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要保存的信息！");
                    return;
                }

                DataRow row = gv_SJXX.GetDataRow(rownumber[0]);
                if (imgcbo_YYMC.EditValue == null)
                {
                    MessageBox.Show("库检原因不能为空！", "提示");
                    return;
                }
                if (imgcbo_ZRBM.EditValue == null)
                {
                    MessageBox.Show("责任单位不能为空！", "提示");
                    return;
                }
                if (imgcbo_CZYJ.EditValue == null)
                {
                    MessageBox.Show("处置意见不能为空！", "提示");
                    return;
                }
                if (DialogResult.OK != MessageBox.Show("是否确认保存已选中的数据？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow dr = gv_SJXX.GetDataRow(rownumber[i]);
                    if (dr["C_BATCH_NO"].ToString() != row["C_BATCH_NO"].ToString())
                    {
                        MessageBox.Show("请选择相同的批号！"); 
                        return;
                    }
                    Mod_TQC_WAREHOUSE_CHECK_ROLL mod = new Mod_TQC_WAREHOUSE_CHECK_ROLL();
                    mod.C_ROLL_ID = dr["C_ID"].ToString();
                    mod.C_STOVE = dr["C_STOVE"].ToString();
                    mod.C_BATCH_NO = dr["C_BATCH_NO"].ToString();
                    mod.C_TICK_NO = dr["C_TICK_NO"].ToString();
                    mod.C_STL_GRD = dr["C_STL_GRD"].ToString();
                    mod.N_WGT = Convert.ToDecimal(dr["N_WGT"]);
                    mod.C_STD_CODE = dr["C_STD_CODE"].ToString();
                    mod.C_SPEC = dr["C_SPEC"].ToString();
                    mod.C_MAT_CODE = dr["C_MAT_CODE"].ToString();
                    mod.C_MAT_NAME = dr["C_MAT_DESC"].ToString();
                    mod.D_WAREHOUSE_IN = Convert.ToDateTime(dr["D_MOD_DT"]);
                    mod.C_SHIFT = dr["C_SHIFT"].ToString();
                    mod.C_GROUP = dr["C_GROUP"].ToString();
                    mod.C_REASON_NAME = imgcbo_YYMC.Text;
                    mod.C_REASON_CODE = imgcbo_YYMC.EditValue.ToString();
                    mod.C_REASON_DEPMT_ID = imgcbo_ZRBM.Text;
                    mod.C_REASON_DEPMT_DESC = imgcbo_ZRBM.Text;
                    mod.C_SUGGESTION = imgcbo_CZYJ.Text;
                    mod.C_REMARK = txt_Remark.Text;
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    if (bll_we_check_roll.Add(mod))
                    {
                        Mod_TRC_ROLL_PRODCUT mod_roll = bll_TRC_Roll_Product.GetModel(dr["C_ID"].ToString());
                        mod_roll.C_IS_DEPOT = "Y";
                        bll_TRC_Roll_Product.Update(mod_roll);
                    }
                   
                }
                Mod_TQC_UPD_MATERIAL_MAIN mod_UpdMaterial = new Mod_TQC_UPD_MATERIAL_MAIN();
                mod_UpdMaterial.C_BATCH_NO = row["C_BATCH_NO"].ToString();
                mod_UpdMaterial.C_REMARK = txt_Remark.Text.Trim();
                mod_UpdMaterial.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod_UpdMaterial.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_BATCH_NO", mod_UpdMaterial.C_BATCH_NO);
                ht.Add("N_STATUS", 1);
                if (Common.CheckRepeat.CheckTable("TQC_UPD_MATERIAL_MAIN", ht) > 0)
                {
                    if (DialogResult.OK != MessageBox.Show(" 批号'" + mod_UpdMaterial.C_BATCH_NO + "'已申请修料，是否确认继续申请！", "提示", MessageBoxButtons.OKCancel))
                    {
                        return;
                    }
                    else
                    {
                        DataTable dt = bll_Update.GetList_CXXL(row["C_BATCH_NO"].ToString()).Tables[0];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Mod_TQC_UPDATE_MATERIAL mod_update = bll_Update.GetModel(dt.Rows[i]["C_ID"].ToString());
                            mod_update.N_STATUS =0;
                            mod_update.C_EMP_ID = RV.UI.UserInfo.UserID;
                            mod_update.D_MOD_DT = RV.UI.ServerTime.timeNow();
                            bll_Update.Update(mod_update);
                        }

                    }
                }
                #endregion
                bllUpdMaterial.Add(mod_UpdMaterial);
                MessageBox.Show("申请成功！", "提示"); 

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "线材库检申请");//添加操作日志

                btn_Query_Main_Click(null, null);
                btn_Query1_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 取消库检
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QXKJ_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_PDJG.GetDataRow(this.gv_PDJG.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择要取消申请的库检信息!", "提示");
                    return;
                }
                if (dr["C_CHECK_EMP_ID"].ToString() != "")
                {
                    MessageBox.Show("库检已确认，不能取消!", "提示");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("确定要取消申请\n批号:'" + dr["C_BATCH_NO"].ToString() + "'？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    Mod_TRC_ROLL_PRODCUT mod_roll = bll_TRC_Roll_Product.GetModel(dr["C_ROLL_ID"].ToString());
                    mod_roll.C_IS_DEPOT = "N";
                    bll_TRC_Roll_Product.Update(mod_roll);
                    bll_we_check_roll.Delete(dr["C_ID"].ToString());
                    btn_Query_Main_Click(null, null);
                    btn_Query1_Click(null, null);
                    MessageBox.Show("已取消!", "提示");

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消线材库检申请");//添加操作日志
                }
                else//如果点击“取消”按钮
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl3.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
