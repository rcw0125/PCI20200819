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
using DevExpress.XtraEditors.Controls;
using Common;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_XCBMPD : Form
    {
        /// <summary>
        /// 2018-05-03 zmc
        /// </summary>
        public FrmQC_XCBMPD()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_TRC_Roll_Product = new Bll_TRC_ROLL_PRODCUT();
        Bll_TQB_CHECKSTATE bll_checkstate = new Bll_TQB_CHECKSTATE();
        Bll_TQB_FAULT_REASON_TYPE bll_fault_type = new Bll_TQB_FAULT_REASON_TYPE();
        Bll_TQB_FAULT_REASON_DETAILS bll_fault_detatis = new Bll_TQB_FAULT_REASON_DETAILS();
        Bll_TQC_FACE_ROLL bll_face_roll = new Bll_TQC_FACE_ROLL();
        Bll_TQC_FACE_ROLL_LOG bll_face_roll_log = new Bll_TQC_FACE_ROLL_LOG();
        Bll_TB_STA bll_sta = new Bll_TB_STA();
        private string strMenuName;

        private void FrmQC001_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
                dte_Begin1.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
                DataSet dt = bll_checkstate.GetList("");
                imgcbo_PDDJ.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)//判定等级下拉框
                {
                    imgcbo_PDDJ.Properties.Items.Add(item["C_CHECKSTATE_NAME"].ToString(), item["C_ID"], -1);
                }
                DataSet dt_sta = bll_sta.GetList("");
                imgcbo_CJ.Properties.Items.Clear();
                imgcbo_CJ.Properties.Items.Add("全部", "全部", -1);
                foreach (DataRow item in dt_sta.Tables[0].Rows)// 
                {
                    imgcbo_CJ.Properties.Items.Add(item["C_STA_DESC"].ToString(), item["C_ID"], -1);
                } 
                imgcbo_CJ.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 轧钢实绩查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                string pland = imgcbo_CJ.EditValue.ToString();
                string batch = txt_BatchNo.Text;
                DataTable dt = bll_TRC_Roll_Product.GetList_Query(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), pland, batch).Tables[0];
                this.gc_SJXX.DataSource = dt;
                gv_SJXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SJXX);
                gv_SJXX_FocusedRowChanged(null, null);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 线材实绩信息明细-钩号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_SJXX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
                DataTable dt = new DataTable();
                if (dr != null)
                {
                    dt = bll_TRC_Roll_Product.GetList_Tick_No
                               (
                                   dr["C_PLANT_DESC"].ToString(), dr["c_batch_no"].ToString(),
                                   dr["C_STOVE"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_STD_CODE"].ToString(),
                                   dr["C_SPEC"].ToString(), dr["C_SHIFT"].ToString(), dr["C_GROUP"].ToString()
                               ).Tables[0];
                }
                else
                {
                    this.gc_right.DataSource = null;
                }


                this.gc_right.DataSource = dt;
                gv_right.BestFitColumns();

                gv_right.OptionsSelection.MultiSelect = true;
                gv_right.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

                SetGridViewRowNum.SetRowNum(gv_right);
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
        private void image_BHGLX_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dt_detatis = bll_fault_detatis.GetList_type(imgcbo_BHGLX.EditValue.ToString());
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
        /// 判定结果查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                string batch = txt_BatchNo1.Text;
                DataTable dt = bll_face_roll.GetList(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), batch).Tables[0];
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
        /// 判定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Decide_Click(object sender, EventArgs e)
        {
            try
            {

                if (imgcbo_PDDJ.EditValue == null)
                {
                    MessageBox.Show("判定顶级不能为空！");
                    return;
                }
                if (imgcbo_PDDJ.SelectedItem.ToString() != "A")
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

                    if (string.IsNullOrEmpty(imgcbo_ZRDW.Text))
                    {
                        MessageBox.Show("责任部门不能为空！");
                        return;
                    }
                }

                int[] rownumber = gv_right.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要表判的信息！");
                    return;
                }
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = gv_right.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    DataTable dt = bll_TRC_Roll_Product.GetList_ID(strID).Tables[0];
                    Mod_TQC_FACE_ROLL mod = new Mod_TQC_FACE_ROLL
                    {
                        C_ID = "",
                        C_ROLL_ID = dt.Rows[0]["C_ID"].ToString(),
                        C_STOVE = dt.Rows[0]["C_STOVE"].ToString(),
                        C_BATCH_NO = dt.Rows[0]["C_BATCH_NO"].ToString(),
                        C_TICK_NO = dt.Rows[0]["C_TICK_NO"].ToString(),
                        C_STL_GRD = dt.Rows[0]["C_STL_GRD"].ToString(),
                        N_WGT = Convert.ToInt32(dt.Rows[0]["N_WGT"]),
                        C_STD_CODE = dt.Rows[0]["C_STD_CODE"].ToString(),
                        C_SPEC = dt.Rows[0]["C_SPEC"].ToString(),
                        C_MAT_CODE = dt.Rows[0]["C_MAT_CODE"].ToString(),
                        C_MAT_NAME = dt.Rows[0]["C_MAT_DESC"].ToString(),
                        C_SHIFT = dt.Rows[0]["C_SHIFT"].ToString(),
                        C_GROUP = dt.Rows[0]["C_GROUP"].ToString(),
                        C_JUDGE_LEV = imgcbo_PDDJ.Text,

                        C_REASON_NAME = imgcbo_BHGYY.Text,
                        C_REASON_CODE = imgcbo_BHGLX.Text,
                        C_REASON_DEPMT_ID = imgcbo_ZRDW.EditValue.ToString(),
                        C_REASON_DEPMT_DESC = imgcbo_ZRDW.Text,
                        C_SUGGESTION = txt_CZYJ.Text,
                        C_REMARK = txt_Remark.Text,
                        C_EMP_ID = RV.UI.UserInfo.UserID
                    };
                    bll_face_roll.Add(mod);

                    Mod_TRC_ROLL_PRODCUT mod_trc = bll_TRC_Roll_Product.GetModel(strID);
                    mod_trc.C_JUDGE_LEV_BP = imgcbo_PDDJ.Text;
                    bool res = bll_TRC_Roll_Product.Update(mod_trc);

                    Mod_TQC_FACE_ROLL_LOG mod_log = new Mod_TQC_FACE_ROLL_LOG();//操作记录表
                    mod_log.C_ID = "";
                    mod_log.C_ROLL_ID = dt.Rows[0]["C_ID"].ToString();
                    mod_log.C_STOVE = dt.Rows[0]["C_STOVE"].ToString();
                    mod_log.C_BATCH_NO = dt.Rows[0]["C_BATCH_NO"].ToString();
                    mod_log.C_TICK_NO = dt.Rows[0]["C_TICK_NO"].ToString();
                    mod_log.C_STL_GRD = dt.Rows[0]["C_STL_GRD"].ToString();
                    mod_log.N_WGT = Convert.ToInt32(dt.Rows[0]["N_WGT"]);
                    mod_log.C_STD_CODE = dt.Rows[0]["C_STD_CODE"].ToString();
                    mod_log.C_SPEC = dt.Rows[0]["C_SPEC"].ToString();
                    mod_log.C_MAT_CODE = dt.Rows[0]["C_MAT_CODE"].ToString();
                    mod_log.C_MAT_NAME = dt.Rows[0]["C_MAT_DESC"].ToString();
                    mod_log.C_SHIFT = dt.Rows[0]["C_SHIFT"].ToString();
                    mod_log.C_GROUP = dt.Rows[0]["C_GROUP"].ToString();
                    mod_log.C_JUDGE_LEV = imgcbo_PDDJ.Text;
                    mod_log.C_REASON_NAME = imgcbo_BHGYY.Text;
                    mod_log.C_REASON_CODE = imgcbo_BHGLX.Text;
                    mod_log.C_REASON_DEPMT_ID = imgcbo_ZRDW.EditValue.ToString();
                    mod_log.C_REASON_DEPMT_DESC = imgcbo_ZRDW.Text;
                    mod_log.C_SUGGESTION = txt_CZYJ.Text;
                    mod_log.C_REMARK = "判定";
                    mod_log.C_EMP_ID = RV.UI.UserInfo.UserID;
                    bll_face_roll_log.Add(mod_log);//添加判定操作记录
                }

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "线材表面判定");//添加操作日志

                btn_Query_Main_Click(null, null);
                btn_Query_Click(null, null);
                MessageBox.Show("判定成功！");

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
                    Mod_TRC_ROLL_PRODCUT mod_trc = bll_TRC_Roll_Product.GetModel(dr["C_ROLL_ID"].ToString());
                    mod_trc.C_JUDGE_LEV_BP = "";
                    bll_TRC_Roll_Product.Update(mod_trc);//轧钢实绩还原
                    DataTable dt = bll_face_roll.GetList_ID(dr["C_ID"].ToString()).Tables[0];
                    bll_face_roll.Delete(dr["C_ID"].ToString());//删除判定结果中的记录
                    btn_Query_Main_Click(null, null);
                    btn_Query_Click(null, null);
                    Mod_TQC_FACE_ROLL_LOG mod_log = new Mod_TQC_FACE_ROLL_LOG();//操作记录表

                    mod_log.C_ROLL_ID = mod_trc.C_ID;
                    mod_log.C_STOVE = dt.Rows[0]["C_STOVE"].ToString();
                    mod_log.C_BATCH_NO = dt.Rows[0]["C_BATCH_NO"].ToString();
                    mod_log.C_TICK_NO = dt.Rows[0]["C_TICK_NO"].ToString();
                    mod_log.C_STL_GRD = dt.Rows[0]["C_STL_GRD"].ToString();
                    mod_log.N_WGT = Convert.ToInt32(dt.Rows[0]["N_WGT"]);
                    mod_log.C_STD_CODE = dt.Rows[0]["C_STD_CODE"].ToString();
                    mod_log.C_SPEC = dt.Rows[0]["C_SPEC"].ToString();
                    mod_log.C_MAT_CODE = dt.Rows[0]["C_MAT_CODE"].ToString();
                    mod_log.C_MAT_NAME = dt.Rows[0]["C_MAT_NAME"].ToString();
                    mod_log.C_SHIFT = dt.Rows[0]["C_SHIFT"].ToString();
                    mod_log.C_GROUP = dt.Rows[0]["C_GROUP"].ToString();
                    mod_log.C_JUDGE_LEV = dt.Rows[0]["C_JUDGE_LEV"].ToString();
                    mod_log.C_REASON_NAME = dt.Rows[0]["C_REASON_NAME"].ToString();
                    mod_log.C_REASON_CODE = dt.Rows[0]["C_REASON_CODE"].ToString();
                    mod_log.C_REASON_DEPMT_ID = dt.Rows[0]["C_REASON_DEPMT_ID"].ToString();
                    mod_log.C_REASON_DEPMT_DESC = dt.Rows[0]["C_REASON_DEPMT_DESC"].ToString();
                    mod_log.C_SUGGESTION = dt.Rows[0]["C_SUGGESTION"].ToString();
                    mod_log.C_REMARK = "撤销";
                    mod_log.C_EMP_ID = RV.UI.UserInfo.UserID;
                    bll_face_roll_log.Add(mod_log);//添加判定操作记录

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "撤销线材表面判定");//添加操作日志
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
        /// <summary>
        /// 判定等级点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_PDDJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (imgcbo_PDDJ.SelectedIndex == -1) return;
                if (imgcbo_PDDJ.SelectedItem.ToString() == "A")//不合格类型选择A则 设为只读
                {
                    imgcbo_ZRDW.ReadOnly = true;
                    imgcbo_BHGLX.ReadOnly = true;//只读
                    imgcbo_BHGYY.ReadOnly = true;
                    imgcbo_ZRDW.Text = "";
                    imgcbo_BHGLX.Text = "";//空值
                    imgcbo_BHGYY.Text = "";
                }
                else
                {
                    imgcbo_BHGLX.ReadOnly = false;
                    imgcbo_ZRDW.ReadOnly = false;
                    imgcbo_BHGYY.ReadOnly = false;
                    DataSet dt_type = bll_fault_type.GetList("");
                    imgcbo_BHGLX.Properties.Items.Clear();
                    imgcbo_BHGYY.Properties.Items.Clear();
                    foreach (DataRow item in dt_type.Tables[0].Rows)//进行二级联动查询不合格类型
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

    }
}
