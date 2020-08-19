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
    /// <summary>
    /// 2018-05-09 zmc
    /// </summary>
    public partial class FrmQC_GPBMPD : Form
    {
        private string strMenuName;

        public FrmQC_GPBMPD()
        {
            InitializeComponent();
        }
        Bll_TSC_SLAB_MAIN bll_SLAB = new Bll_TSC_SLAB_MAIN();
        Bll_TQB_CHECKSTATE bll_checkstate = new Bll_TQB_CHECKSTATE();
        Bll_TQB_FAULT_REASON_TYPE bll_fault_type = new Bll_TQB_FAULT_REASON_TYPE();
        Bll_TQB_FAULT_REASON_DETAILS bll_fault_detatis = new Bll_TQB_FAULT_REASON_DETAILS();
        Bll_TQC_FACE_SLAB bll_face_slab = new Bll_TQC_FACE_SLAB();
        Bll_TQC_FACE_SLAB_LOG bll_face_slab_log = new Bll_TQC_FACE_SLAB_LOG();

        private void FrmQC_GPBMPD_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;
                 
                dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
                dte_Begin1.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
                DataSet dt = bll_checkstate.GetList_GP("");
                imgcbo_PDDJ.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)//判定等级下拉框
                {
                    imgcbo_PDDJ.Properties.Items.Add(item["C_CHECKSTATE_NAME"].ToString(), item["C_ID"], -1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 钢坯实绩查询  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                string STA = imgcbo_LZJ.EditValue.ToString();
                string stove = txt_Stove_NO.Text;
                DataTable dt = bll_SLAB.GetList_Query(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), STA, stove).Tables[0];
                this.gc_GPSJ.DataSource = dt;
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
        /// 判定等级下拉框点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_PDDJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (imgcbo_PDDJ.SelectedIndex == -1) return;
                if (imgcbo_PDDJ.SelectedItem.ToString() == "合格品")//不合格类型选择'合格品'则 设为只读
                {
                    imgcbo_ZRDW.ReadOnly = true;
                    imgcbo_BHGLX.ReadOnly = true;//只读
                    imgcbo_BHGYY.ReadOnly = true;
                    imgcbo_BHGLX.Text = null;//空值
                    imgcbo_BHGYY.Text = null;
                    imgcbo_ZRDW.Text = null;
                }
                else
                {
                    imgcbo_ZRDW.ReadOnly = false;
                    imgcbo_BHGLX.ReadOnly = false;
                    imgcbo_BHGYY.ReadOnly = false;
                    DataSet dt_type = bll_fault_type.GetList("");
                    imgcbo_BHGLX.Properties.Items.Clear();
                    imgcbo_BHGYY.Properties.Items.Clear();
                    foreach (DataRow item in dt_type.Tables[0].Rows)//不合格类型下拉框查询
                    {
                        imgcbo_BHGLX.Properties.Items.Add(item["C_REASON_TYPE_CODE"].ToString(), item["C_ID"], -1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 判定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Decide_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_GPSJ.GetDataRow(this.gv_GPSJ.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择需要判定的钢坯实绩！");
                    return;
                }
                if (txt_PDZS.Text == "0")
                {
                    MessageBox.Show("判定支数不能为0！");
                    return;
                }
                if (txt_PDZS.Value > Convert.ToInt32(dr["COU"]))
                {
                    MessageBox.Show("判定支数不能大于实绩支数！");
                    return;
                }
                if (imgcbo_PDDJ.EditValue == null)
                {
                    MessageBox.Show("判定等级不能为空！");
                    return;
                }
                if (imgcbo_PDDJ.SelectedItem.ToString() != "合格品")
                {
                    if (imgcbo_BHGLX.EditValue == null)
                    {
                        MessageBox.Show("不合格类型不能为空！");
                        return;
                    }
                    if (imgcbo_BHGYY.EditValue == null)
                    {
                        MessageBox.Show("不合格原因不能为空！");
                        return;
                    }
                    if (string.IsNullOrEmpty(imgcbo_ZRDW.Text.Trim()))
                    {
                        MessageBox.Show("责任部门不能为空！");
                        return;
                    }
                }

                DataSet ds = bll_SLAB.GetList_count(dr["C_STA_ID"].ToString(), dr["C_STOVE"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_SPEC"].ToString(), dr["N_LEN"].ToString() , dr["C_STD_CODE"].ToString(), dr["C_MAT_CODE"].ToString(), dr["C_MAT_NAME"].ToString(), Convert.ToInt32(txt_PDZS.Value));
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //DataTable dt_SLAB = bll_SLAB.GetList_id(ds.Tables[0].Rows[i]["C_ID"].ToString()).Tables[0];
                    Mod_TSC_SLAB_MAIN mod_tsc = bll_SLAB.GetModel(ds.Tables[0].Rows[i]["C_ID"].ToString());
                    Mod_TQC_FACE_SLAB mod = new Mod_TQC_FACE_SLAB(); 
                    mod.C_SLAB_ID = mod_tsc.C_ID;
                    mod.C_STOVE = mod_tsc.C_STOVE;
                    mod.C_STA_ID = mod_tsc.C_STA_ID;
                    mod.C_STL_GRD = mod_tsc.C_STL_GRD;
                    mod.C_SLAB_SIZE = mod_tsc.C_SPEC;
                    mod.N_WGT = Convert.ToInt32(mod_tsc.N_WGT);
                    mod.N_LEN = Convert.ToInt32(mod_tsc.N_LEN);
                    mod.C_STD_CODE = mod_tsc.C_STD_CODE;
                    mod.C_MAT_CODE = mod_tsc.C_MAT_CODE;
                    mod.C_MAT_NAME = mod_tsc.C_MAT_NAME;
                    mod.C_JUDGE_LEV = imgcbo_PDDJ.Text.Trim();
                    mod.C_REASON_NAME = imgcbo_BHGYY.Text.Trim();
                    mod.C_REASON_CODE = imgcbo_BHGLX.Text.Trim();
                    mod.C_REASON_DEPMT_ID = imgcbo_ZRDW.EditValue?.ToString();
                    mod.C_REASON_DEPMT_DESC = imgcbo_ZRDW.Text;
                    mod.C_SUGGESTION = txt_CZYJ.Text.Trim();
                    mod.C_REMARK = txt_Remark.Text.Trim();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    bll_face_slab.Add(mod); 

                    mod_tsc.C_STOCK_STATE = "F";//修改钢坯实绩表 库存状态 F为已判定
                    mod_tsc.C_QF_NAME = RV.UI.UserInfo.UserID;
                    mod_tsc.C_MAT_TYPE = imgcbo_PDDJ.Text;
                    bool res = bll_SLAB.Update(mod_tsc); 

                    Mod_TQC_FACE_SLAB_LOG mod_log = new Mod_TQC_FACE_SLAB_LOG(); 
                    mod_log.C_SLAB_ID = mod_tsc.C_ID;
                    mod_log.C_STOVE = mod_tsc.C_STOVE;
                    mod_log.C_STA_ID = mod_tsc.C_STA_ID;
                    mod_log.C_STL_GRD = mod_tsc.C_STL_GRD;
                    mod_log.C_SLAB_SIZE = mod_tsc.C_SPEC;
                    mod_log.N_WGT =Convert.ToDecimal( mod_tsc.N_WGT);
                    mod_log.N_LEN = Convert.ToDecimal(mod_tsc.N_LEN);
                    mod_log.C_STD_CODE = mod_tsc.C_STD_CODE;
                    mod_log.C_MAT_CODE = mod_tsc.C_MAT_CODE;
                    mod_log.C_MAT_NAME = mod_tsc.C_MAT_NAME;
                    mod_log.C_JUDGE_LEV = imgcbo_PDDJ.Text.Trim();
                    mod_log.C_REASON_NAME = imgcbo_BHGYY.Text.Trim();
                    mod_log.C_REASON_CODE = imgcbo_BHGLX.Text.Trim();
                    mod_log.C_REASON_DEPMT_ID = imgcbo_ZRDW.EditValue?.ToString();
                    mod_log.C_REASON_DEPMT_DESC = imgcbo_ZRDW.Text;
                    mod_log.C_SUGGESTION = txt_CZYJ.Text.Trim();
                    mod_log.C_REMARK = "判定";
                    mod_log.C_EMP_ID = RV.UI.UserInfo.UserID;
                    bll_face_slab_log.Add(mod_log);

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钢坯表面判定信息");//添加操作日志

                }
                MessageBox.Show("判定成功");
                btn_Query1_Click(null, null);
                btn_Query_Click(null, null);
                btn_Rest_Click(null,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 不合格类型下拉框点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_BHGLX_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dt_detatis = bll_fault_detatis.GetList_type(imgcbo_BHGLX.EditValue?.ToString());
                imgcbo_BHGYY.Properties.Items.Clear();
                foreach (DataRow item in dt_detatis.Tables[0].Rows)//不合格原因下拉框查询
                {
                    imgcbo_BHGYY.Properties.Items.Add(item["C_REASON_NAME"].ToString(), item["C_ID"], -1);
                }
                imgcbo_BHGYY.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_repeal_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否撤销？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    DataRow dr = this.gv_PDJG.GetDataRow(this.gv_PDJG.FocusedRowHandle);
                    if (dr == null) return;
                    Mod_TSC_SLAB_MAIN mod_tsc = bll_SLAB.GetModel(dr["C_SLAB_ID"].ToString());
                    mod_tsc.C_STOCK_STATE = "W";
                     
                    Mod_TQC_FACE_SLAB mod_face_slab = bll_face_slab.GetModel(dr["C_ID"].ToString()); 

                    Mod_TQC_FACE_SLAB_LOG mod_log = new Mod_TQC_FACE_SLAB_LOG();
                    mod_log.C_SLAB_ID = mod_tsc.C_ID;
                    mod_log.C_STOVE = mod_face_slab.C_STOVE;
                    mod_log.C_STA_ID = mod_face_slab.C_STA_ID;
                    mod_log.C_STL_GRD = mod_face_slab.C_STL_GRD;
                    mod_log.C_SLAB_SIZE = mod_face_slab.C_SLAB_SIZE;
                    mod_log.N_WGT = mod_face_slab.N_WGT;
                    mod_log.N_LEN = mod_face_slab.N_LEN;
                    mod_log.C_STD_CODE = mod_face_slab.C_STD_CODE;
                    mod_log.C_MAT_CODE = mod_face_slab.C_MAT_CODE;
                    mod_log.C_MAT_NAME = mod_face_slab.C_MAT_NAME;
                    mod_log.C_JUDGE_LEV = mod_face_slab.C_JUDGE_LEV;
                    mod_log.C_REASON_NAME = mod_face_slab.C_REASON_NAME;
                    mod_log.C_REASON_CODE = mod_face_slab.C_REASON_CODE;
                    mod_log.C_REASON_DEPMT_ID = mod_face_slab.C_REASON_DEPMT_ID;
                    mod_log.C_REASON_DEPMT_DESC = mod_face_slab.C_REASON_DEPMT_DESC;
                    mod_log.C_SUGGESTION = mod_face_slab.C_SUGGESTION;
                    mod_log.C_REMARK = "撤销";
                    mod_log.C_EMP_ID = RV.UI.UserInfo.UserID;
                    bll_face_slab_log.Add(mod_log);
                    bll_SLAB.Update(mod_tsc);//轧钢实绩还原 
                    bll_face_slab.Delete(dr["C_ID"].ToString());//删除判定结果中的记录
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "撤销钢坯表面判定信息");//添加操作日志
                    btn_Query1_Click(null, null);
                    btn_Query_Click(null, null);
                    btn_Rest_Click(null,null);
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
        /// 判定结果查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                string stove = txt_Stove.Text.Trim();
                DataTable dt = bll_face_slab.GetList_Stove(Convert.ToDateTime(dte_Begin1.DateTime), Convert.ToDateTime(dte_End1.DateTime), stove).Tables[0];
                this.gc_PDJG.DataSource = dt;
                gv_PDJG.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_PDJG);
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
                txt_PDZS.Text = "0";
                ClearContent.ClearFlowLayoutPanel(panelControl3.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void NewMethod()
        {
            try
            {
                DataRow dr = this.gv_GPSJ.GetDataRow(this.gv_GPSJ.FocusedRowHandle);
                if (dr == null) return;
                txt_PDZS.Text = dr["COU"].ToString();
                txt_PDZS.Properties.MaxValue = Convert.ToInt32(dr["COU"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 获取支数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_GPSJ_Click(object sender, EventArgs e)
        {
            NewMethod();
        }
    }
}
