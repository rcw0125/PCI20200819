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

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_ZLSJJG_XC : Form
    {
        private Bll_TQD_DESIGN bllDesign = new Bll_TQD_DESIGN();

        public FrmQB_ZLSJJG_XC()
        {
            InitializeComponent();
        }
        int a = 0;
        private string str_id = "";
        Bll_TRC_ROLL_PRODCUT bll_RollMain = new Bll_TRC_ROLL_PRODCUT();
        Bll_TQB_CHARACTER bll_CharaCter = new Bll_TQB_CHARACTER();
        Bll_TQB_DESIGN_ITEM bll_Design_Item = new Bll_TQB_DESIGN_ITEM();
        Bll_TQB_DESIGN_ITEM_LOG bll_DescignLog = new Bll_TQB_DESIGN_ITEM_LOG();
        Bll_TQB_CHECKTYPE bll_CheckType = new Bll_TQB_CHECKTYPE();

        private void FrmQB_ZLSJJG_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            repositoryItemImageComboBox1.Items.Add("定性", "定性", -1);
            repositoryItemImageComboBox1.Items.Add("定量", "定量", -1);
            repositoryItemImageComboBox2.Items.Add("", "", -1);
            repositoryItemImageComboBox2.Items.Add("≤E", "≤E", -1);
            repositoryItemImageComboBox2.Items.Add("≤E≤", "≤E≤", -1);
            repositoryItemImageComboBox2.Items.Add("E≤", "E≤", -1);
            repositoryItemImageComboBox4.Items.Add("是", "是", -1);
            repositoryItemImageComboBox4.Items.Add("否", "否", -1);


        }
        /// <summary>
        /// 查询实绩信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_BatchNo.Text.Trim() == "")
                {
                    MessageBox.Show("请输入完整的批号，再进行查询！");
                    return;
                }
                WaitingFrom.ShowWait("");
                DataTable dt = bll_RollMain.GetQueryBatch(txt_BatchNo.Text.Trim()).Tables[0];
                gc_SJXX.DataSource = dt;
                gv_SJXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SJXX);
                NewMethod1();
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 查询检验基础数据成分信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CF_Click(object sender, EventArgs e)
        {
            NewMethod1();
        }

        /// <summary>
        /// 检验基础数据查询——成分
        /// </summary>
        private void NewMethod1()
        {
            DataTable dt_CharaCter = bll_CharaCter.GetList_JCSJ(txt_name.Text).Tables[0];
            this.gc_JCSJ.DataSource = dt_CharaCter;
            gv_JCSJ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_JCSJ);
        }
        /// <summary>
        /// 查询成分明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_GPSJ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod_CF();
        }
        /// <summary>
        /// 查询执行标准 成分
        /// </summary>
        /// <param name="str"></param>
        private void NewMethod_CF()
        {
            gc_StdCF.DataSource = null;
            DataRow dr = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
            if (dr["C_DESIGN_NO"].ToString() == "")
            {
                MessageBox.Show("质量设计号为空！");
                return;
            }
            DataTable dt_CX = bll_Design_Item.GetList_CF(dr["C_DESIGN_NO"].ToString()).Tables[0];
            str_id = dt_CX.Rows[0]["C_DESIGN_ID"].ToString();
            this.gc_StdCF.DataSource = dt_CX;
            gv_StdCF.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdCF);
        }
        /// <summary>
        /// 添加成分明细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_CF_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dr = this.gv_JCSJ.GetDataRow(this.gv_JCSJ.FocusedRowHandle);
                if (dr == null) return;
                Mod_TQB_DESIGN_ITEM mod = new Mod_TQB_DESIGN_ITEM();
                mod.C_DESIGN_ID = str_id;
                mod.C_CHARACTER_ID = dr["C_ID"].ToString();
                Mod_TQB_CHARACTER mod_character = bll_CharaCter.GetModel(mod.C_CHARACTER_ID);
                if (mod_character.C_NAME == "C")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 1;
                }
                else if (mod_character.C_NAME == "Si")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 2;
                }
                else if (mod_character.C_NAME == "Mn")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 3;
                }
                else if (mod_character.C_NAME == "P")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 4;
                }
                else if (mod_character.C_NAME == "S")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 5;
                }
                else if (mod_character.C_NAME == "Al")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 6;
                }
                //mod.C_TYPE = "成分";

                string strTypeName = bll_CheckType.Get_Type_Name(mod_character.C_TYPE_ID);
                mod.C_TYPE = strTypeName;

                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                if (bll_Design_Item.Add(mod))
                {
                    GetDesignLog_Add();
                }
                NewMethod_CF();// 查询执行标准 成分
                MessageBox.Show("添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_CF_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gv_StdCF.DataRowCount; i++)
                {
                    DataRow dr = this.gv_StdCF.GetDataRow(i);
                    if (dr == null) return;
                    Mod_TQB_DESIGN_ITEM mod = bll_Design_Item.GetModel(dr["C_ID"].ToString());

                    #region 目标值区间
                    if (!string.IsNullOrEmpty(dr["C_TARGET_INTERVAL"].ToString()))
                    {
                        mod.C_TARGET_INTERVAL = dr["C_TARGET_INTERVAL"].ToString();

                        if (dr["C_TARGET_INTERVAL"].ToString() == "≤E")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写目标最小值！");
                                return;
                            }
                            else
                            {
                                mod.C_TARGET_MIN = dr["C_TARGET_MIN"].ToString();//目标最小值
                            }
                        }
                        else if (dr["C_TARGET_INTERVAL"].ToString() == "≤E≤")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写目标最小值！");
                                return;
                            }

                            if (string.IsNullOrEmpty(dr["C_TARGET_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写目标最大值！");
                                return;
                            }

                            mod.C_TARGET_MIN = dr["C_TARGET_MIN"].ToString();//目标最小值
                            mod.C_TARGET_MAX = dr["C_TARGET_MAX"].ToString();//目标最大值
                        }
                        else if (dr["C_TARGET_INTERVAL"].ToString() == "E≤")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写目标最大值！");
                                return;
                            }
                            else
                            {
                                mod.C_TARGET_MAX = dr["C_TARGET_MAX"].ToString();//目标最大值
                            }
                        }
                    }
                    #endregion

                    mod.C_PREWARNING_VALUE = dr["C_PREWARNING_VALUE"].ToString();
                    #region 规格区间
                    if (!string.IsNullOrEmpty(dr["C_SPEC_INTERVAL"].ToString()))
                    {
                        mod.C_SPEC_INTERVAL = dr["C_SPEC_INTERVAL"].ToString();

                        if (dr["C_SPEC_INTERVAL"].ToString() == "≤E")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写规格最小值！");
                                return;
                            }
                            else
                            {
                                mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);//规格最小值
                            }
                        }
                        else if (dr["C_SPEC_INTERVAL"].ToString() == "≤E≤")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写规格最小值！");
                                return;
                            }

                            if (string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写规格最大值！");
                                return;
                            }

                            mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);//规格最小值
                            mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);//规格最大值
                        }
                        else if (dr["C_SPEC_INTERVAL"].ToString() == "E≤")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写规格最大值！");
                                return;
                            }
                            else
                            {
                                mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);//规格最大值
                            }
                        }
                    }
                    #endregion

                    if (!string.IsNullOrEmpty(dr["N_PRINT_ORDER"].ToString()))
                    {
                        mod.N_PRINT_ORDER = Convert.ToDecimal(dr["N_PRINT_ORDER"]);
                    }
                    mod.C_QUANTITATIVE = dr["C_QUANTITATIVE"].ToString();
                    mod.C_FORMULA = dr["C_FORMULA"].ToString();
                    mod.C_UNIT = dr["C_UNIT"].ToString();
                    if (!string.IsNullOrEmpty(dr["N_DIGIT"].ToString()))
                    {
                        mod.N_DIGIT = Convert.ToDecimal(dr["N_DIGIT"]);
                    }
                    mod.C_IS_DECIDE = dr["C_IS_DECIDE"].ToString();
                    mod.C_IS_PRINT = dr["C_IS_PRINT"].ToString();
                    mod.C_TEST_TEM = dr["C_TEST_TEM"].ToString();
                    mod.C_TEST_CONDITION = dr["C_TEST_CONDITION"].ToString();
                    mod.C_REMARK = dr["C_REMARK"].ToString();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    if (bll_Design_Item.Update(mod))
                    {
                        GetDesignLog_Add();
                    }
                }
                NewMethod_CF();// 查询执行标准 成分
                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 添加LOG表信息
        /// </summary>
        /// <param name="str"></param>
        private void GetDesignLog_Add()
        {
            if (a == 0)
            {
                DataRow dr_sj = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
                if (dr_sj == null) return;
                DataTable dt_CX = bll_Design_Item.GetList_CF(dr_sj["C_DESIGN_NO"].ToString()).Tables[0];
                for (int i = 0; i < dt_CX.Rows.Count; i++)
                {
                    a++;
                    Mod_TQB_DESIGN_ITEM_LOG mod_DesignLog = new Mod_TQB_DESIGN_ITEM_LOG();
                    mod_DesignLog.C_DESIGN_ID = dt_CX.Rows[i]["C_DESIGN_ID"].ToString();
                    mod_DesignLog.C_CHARACTER_ID = dt_CX.Rows[i]["C_CHARACTER_ID"].ToString();
                    mod_DesignLog.C_TARGET_MIN = dt_CX.Rows[i]["C_TARGET_MIN"].ToString();
                    mod_DesignLog.C_TARGET_INTERVAL = dt_CX.Rows[i]["C_TARGET_INTERVAL"].ToString();
                    mod_DesignLog.C_TARGET_MAX = dt_CX.Rows[i]["C_TARGET_MAX"].ToString();
                    mod_DesignLog.C_PREWARNING_VALUE = dt_CX.Rows[i]["C_PREWARNING_VALUE"].ToString();
                    mod_DesignLog.C_TYPE = dt_CX.Rows[i]["C_TYPE"].ToString();
                    mod_DesignLog.C_IS_DECIDE = dt_CX.Rows[i]["C_IS_DECIDE"].ToString();
                    mod_DesignLog.C_IS_PRINT = dt_CX.Rows[i]["C_IS_PRINT"].ToString();
                    if (!string.IsNullOrEmpty(dt_CX.Rows[i]["N_PRINT_ORDER"].ToString()))
                    {
                        mod_DesignLog.N_PRINT_ORDER = Convert.ToDecimal(dt_CX.Rows[i]["N_PRINT_ORDER"]);
                    }
                    if (!string.IsNullOrEmpty(dt_CX.Rows[i]["N_SPEC_MIN"].ToString()))
                    {
                        mod_DesignLog.N_SPEC_MIN = Convert.ToDecimal(dt_CX.Rows[i]["N_SPEC_MIN"]);
                    }
                    mod_DesignLog.C_SPEC_INTERVAL = dt_CX.Rows[i]["C_SPEC_INTERVAL"].ToString();
                    if (!string.IsNullOrEmpty(dt_CX.Rows[i]["N_SPEC_MAX"].ToString()))
                    {
                        mod_DesignLog.N_SPEC_MAX = Convert.ToDecimal(dt_CX.Rows[i]["N_SPEC_MAX"]);
                    }

                    mod_DesignLog.C_FORMULA = dt_CX.Rows[i]["C_FORMULA"].ToString();
                    mod_DesignLog.C_UNIT = dt_CX.Rows[i]["C_UNIT"].ToString();
                    if (!string.IsNullOrEmpty(dt_CX.Rows[i]["N_DIGIT"].ToString()))
                    {
                        mod_DesignLog.N_DIGIT = Convert.ToDecimal(dt_CX.Rows[i]["N_DIGIT"]);
                    }
                    mod_DesignLog.C_QUANTITATIVE = dt_CX.Rows[i]["C_QUANTITATIVE"].ToString();
                    mod_DesignLog.C_TEST_TEM = dt_CX.Rows[i]["C_TEST_TEM"].ToString();
                    mod_DesignLog.C_TEST_CONDITION = dt_CX.Rows[i]["C_TEST_CONDITION"].ToString();
                    mod_DesignLog.C_REMARK = dt_CX.Rows[i]["C_REMARK"].ToString();
                    mod_DesignLog.C_EMP_ID = dt_CX.Rows[i]["C_EMP_ID"].ToString();
                    if (!string.IsNullOrEmpty(dt_CX.Rows[i]["D_MOD_DT"].ToString()))
                    {
                        mod_DesignLog.D_MOD_DT = Convert.ToDateTime(dt_CX.Rows[i]["D_MOD_DT"]);
                    }

                    bll_DescignLog.Add(mod_DesignLog);
                }
            }

        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_CF_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_StdCF.GetDataRow(gv_StdCF.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_DESIGN_ITEM", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            MessageBox.Show("已停用！");
                            NewMethod_CF();
                            GetDesignLog_Add();
                        }
                    }
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

    }
}
