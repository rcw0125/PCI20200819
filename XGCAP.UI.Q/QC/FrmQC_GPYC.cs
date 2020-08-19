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
    public partial class FrmQC_GPYC : Form
    {
        public FrmQC_GPYC()
        {
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TSC_SLAB_MAIN bll_slab = new Bll_TSC_SLAB_MAIN();
        Bll_TQC_SLAB_YC bll_YC = new Bll_TQC_SLAB_YC();
        Bll_TQC_SLAB_YC_LOG bll_YC_LOG = new Bll_TQC_SLAB_YC_LOG();
        private void FrmQC_GPYC_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strMenuName = RV.UI.UserInfo.menuName;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Stove.Text.Trim()))
            {
                MessageBox.Show("请输入炉号进行查询");
                return;
            }
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_slab.GetList_StoveYCGP(txt_Stove.Text.Trim()).Tables[0];
                gc_GPSJ.DataSource = dt;
                gv_GPSJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPSJ);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {
            try
            { 
                DataRow dr = this.gv_GPSJ.GetDataRow(this.gv_GPSJ.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择需要库检的数据！", "提示");
                    return;
                }
                Mod_TQC_SLAB_YC mod = new Mod_TQC_SLAB_YC();
                mod.C_ID = System.Guid.NewGuid().ToString();
                mod.C_STOVE = dr["C_STOVE"].ToString();
                mod.C_STL_GRD = dr["C_STL_GRD"].ToString(); 
                mod.C_STD_CODE = dr["C_STD_CODE"].ToString(); 
                mod.N_LEN = Convert.ToDecimal(dr["N_LEN"]);
                mod.C_MAT_CODE = dr["C_MAT_CODE"].ToString();
                mod.C_MAT_NAME = dr["C_MAT_NAME"].ToString(); 
                mod.C_SPEC = dr["C_SPEC"].ToString(); 
                mod.C_REASON = txt_YY.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STOVE", mod.C_STOVE); 
                ht.Add("N_STATUS", 1);
                if (Common.CheckRepeat.CheckTable("TQC_SLAB_YC", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (bll_YC.Add(mod))
                {
                    MessageBox.Show("添加成功");
                    Mod_TQC_SLAB_YC_LOG mod_log = new Mod_TQC_SLAB_YC_LOG();
                    mod_log.C_ID = System.Guid.NewGuid().ToString();
                    mod_log.C_STOVE = dr["C_STOVE"].ToString();
                    mod_log.C_STL_GRD = dr["C_STL_GRD"].ToString();
                    mod_log.C_STD_CODE = dr["C_STD_CODE"].ToString();
                    mod_log.N_LEN = Convert.ToDecimal(dr["N_LEN"]);
                    mod_log.C_MAT_CODE = dr["C_MAT_CODE"].ToString();
                    mod_log.C_MAT_NAME = dr["C_MAT_NAME"].ToString();
                    mod_log.C_SPEC = dr["C_SPEC"].ToString();
                    mod_log.C_REASON = txt_YY.Text.Trim();
                    mod_log.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod_log.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    mod_log.C_TYPE = "添加";
                    bll_YC_LOG.Add(mod_log);
                    NewMethod();
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
            NewMethod();

        }

        private void NewMethod()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_YC.GetList_SlabYC(txt_Stove1.Text.Trim()).Tables[0];
                gc_GPYC.DataSource = dt;
                gv_GPYC.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPYC);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {

                    DataRow dr = this.gv_GPYC.GetDataRow(this.gv_GPYC.FocusedRowHandle);
                    if (dr == null)
                    {
                        MessageBox.Show("请选择需要删除的信息！");
                        return;
                    }

                    if (bll_YC.Delete(dr["C_ID"].ToString()))
                    {
                        MessageBox.Show("删除成功！");
                        Mod_TQC_SLAB_YC_LOG mod_log = new Mod_TQC_SLAB_YC_LOG();
                        mod_log.C_ID = System.Guid.NewGuid().ToString();
                        mod_log.C_STOVE = dr["C_STOVE"].ToString();
                        mod_log.C_STL_GRD = dr["C_STL_GRD"].ToString();
                        mod_log.C_STD_CODE = dr["C_STD_CODE"].ToString();
                        mod_log.N_LEN = Convert.ToDecimal(dr["N_LEN"]);
                        mod_log.C_MAT_CODE = dr["C_MAT_CODE"].ToString();
                        mod_log.C_MAT_NAME = dr["C_MAT_NAME"].ToString();
                        mod_log.C_SPEC = dr["C_SPEC"].ToString();
                        mod_log.C_REASON = txt_YY.Text.Trim();
                        mod_log.C_EMP_ID = RV.UI.UserInfo.UserID;
                        mod_log.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        mod_log.C_TYPE = "取消";
                        bll_YC_LOG.Add(mod_log);

                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消钢坯异常信息");//添加操作日志
                        NewMethod();
                    }
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
