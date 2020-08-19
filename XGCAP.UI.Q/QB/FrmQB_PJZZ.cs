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

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_PJZZ : Form
    {
        private Bll_TQB_GRADE_RULE_STD bllTqbGradeRuleStd = new Bll_TQB_GRADE_RULE_STD();
        private Bll_TQB_GRADE_RULE bllTqbGradeRule = new Bll_TQB_GRADE_RULE();
        private Bll_TQB_CHECKTYPE bllTqbCheckType = new Bll_TQB_CHECKTYPE();
        private Bll_TQB_CHARACTER bllTqbCharacter = new Bll_TQB_CHARACTER();
        private Bll_Common bllCommon = new Bll_Common();

        private string strMenuName;


        private string str_STD_ID = "";
        private string str_TQB_GRADE_RULE_ID = "";

        public FrmQB_PJZZ()
        {
            InitializeComponent();
        }

        private void FrmQB_PJZZ_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                BindCheckType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BindStd()
        {
            gc_RuleStd.DataSource = null;

            DataTable dt = bllTqbGradeRuleStd.GetList(txt_Std.Text.Trim(), txt_Grd.Text.Trim()).Tables[0];
            gc_RuleStd.DataSource = dt;
            gv_RuleStd.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_RuleStd);
        }

        private void BindGradeDetails(string C_STD_ID)
        {
            DataTable dt = bllTqbGradeRule.GetGradeDetails(C_STD_ID).Tables[0];
            gc_Rule.DataSource = dt;
            gv_Rule.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Rule);
        }

        private void BindCheckType()
        {
            DataTable dt = bllTqbCheckType.GetAllList().Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                imgcbo_CheckType.Properties.Items.Add(dt.Rows[i]["C_TYPE_NAME"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
            }
        }

        private void BindCharacter(string C_TYPE_ID)
        {
            cbo_CharcterName.SelectedIndex = -1;
            cbo_CharcterName.Properties.Items.Clear();

            DataTable dt = bllTqbCharacter.GetCharacterNameList(C_TYPE_ID).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbo_CharcterName.Properties.Items.Add(dt.Rows[i]["C_NAME"].ToString());
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                BindStd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 添加评级标准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddStd_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(btnEdit_Std.Text.Trim()))
                {
                    MessageBox.Show("信息为空不能添加！");
                    return;
                }

                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STD_ID", str_STD_ID);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_GRADE_RULE_STD", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion

                Mod_TQB_GRADE_RULE_STD model = new Mod_TQB_GRADE_RULE_STD();
                model.C_STD_ID = str_STD_ID;
                model.C_EMP_ID = RV.UI.UserInfo.userID;

                if (bllTqbGradeRuleStd.Add(model))
                {
                    btnEdit_Std.Text = "";
                    txt_Std_Grd.Text = "";

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加需要评级的钢种和执行标准");//添加操作日志

                    MessageBox.Show("添加成功！");

                    BindStd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 停用评级标准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CancleStd_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    DataRow dr = gv_RuleStd.GetDataRow(gv_RuleStd.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bllCommon.DataDisabled("TQB_GRADE_RULE_STD", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用需要评级的钢种和执行标准");//添加操作日志

                            MessageBox.Show("已成功停用！");

                            BindStd();
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

        /// <summary>
        /// 保存评级明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveDetails_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_RuleStd.GetDataRow(gv_RuleStd.FocusedRowHandle);

                if (str_TQB_GRADE_RULE_ID == "")//新增
                {
                    if (string.IsNullOrEmpty(cbo_CharcterName.Text.Trim()))
                    {
                        MessageBox.Show("项目名称不能为空！");
                        return;
                    }

                    if (string.IsNullOrEmpty(txt_TargetMin.Text.Trim()) && string.IsNullOrEmpty(txt_TargetMax.Text.Trim()))
                    {
                        MessageBox.Show("目标值不能全为空！");
                        return;
                    }



                    Mod_TQB_GRADE_RULE model = new Mod_TQB_GRADE_RULE();
                    model.C_RULE_STD_ID = dr["C_ID"].ToString();
                    model.C_SPEC_MIN = txt_SpecMin.Text.Trim();
                    model.C_SPEC_INTERVAL = cbo_SpecInterval.Text.Trim();
                    model.C_SPEC_MAX = txt_SpecMax.Text.Trim();
                    model.C_CHARACTER_ID = bllTqbCharacter.GetItemID(cbo_CharcterName.Text.Trim());
                    model.C_LEV = imgcbo_Lev.Text.Trim();
                    model.C_TARGET_MIN = txt_TargetMin.Text.Trim();
                    model.C_TARGET_INTERVAL = cbo_TargetInterval.Text.Trim();
                    model.C_TARGET_MAX = txt_TargetMax.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;

                    if (bllTqbGradeRule.Add(model))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加评级准则明细信息");//添加操作日志

                        MessageBox.Show("添加成功！");
                        BindGradeDetails(dr["C_ID"].ToString());
                    }
                }
                else//修改
                {
                    if (string.IsNullOrEmpty(cbo_CharcterName.Text.Trim()))
                    {
                        MessageBox.Show("项目名称不能为空！");
                        return;
                    }

                    if (string.IsNullOrEmpty(txt_TargetMin.Text.Trim()) && string.IsNullOrEmpty(txt_TargetMax.Text.Trim()))
                    {
                        MessageBox.Show("目标值不能全为空！");
                        return;
                    }


                    Mod_TQB_GRADE_RULE model = bllTqbGradeRule.GetModel(str_TQB_GRADE_RULE_ID);
                    model.C_SPEC_MIN = txt_SpecMin.Text.Trim();
                    model.C_SPEC_INTERVAL = cbo_SpecInterval.Text.Trim();
                    model.C_SPEC_MAX = txt_SpecMax.Text.Trim();
                    model.C_CHARACTER_ID = bllTqbCharacter.GetItemID(cbo_CharcterName.Text.Trim());
                    model.C_LEV = imgcbo_Lev.Text.Trim();
                    model.C_TARGET_MIN = txt_TargetMin.Text.Trim();
                    model.C_TARGET_INTERVAL = cbo_TargetInterval.Text.Trim();
                    model.C_TARGET_MAX = txt_TargetMax.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();

                    if (bllTqbGradeRule.Update(model))
                    {
                        MessageBox.Show("修改成功！");
                        BindGradeDetails(dr["C_ID"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 停用评级明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CancleDetails_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    DataRow dr_RuleStd = gv_RuleStd.GetDataRow(gv_RuleStd.FocusedRowHandle);
                    DataRow dr = gv_Rule.GetDataRow(gv_Rule.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bllCommon.DataDisabled("TQB_GRADE_RULE", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用评级准则详细信息");//添加操作日志
                            BindStd();
                            MessageBox.Show("已停用！");

                            BindGradeDetails(dr_RuleStd["C_ID"].ToString());
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

        /// <summary>
        /// 选择执行标准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Std_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_ZXBZ frm = new FrmQB_SELECT_ZXBZ("");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    str_STD_ID = frm.str_STD_ID;
                    btnEdit_Std.Text = frm.str_STD;
                    txt_Std_Grd.Text = frm.str_GRD;
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void icbo_CheckType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (imgcbo_CheckType.EditValue != null)
                {
                    BindCharacter(imgcbo_CheckType.EditValue.ToString());
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            str_TQB_GRADE_RULE_ID = "";

            txt_SpecMin.Text = "";
            txt_SpecMax.Text = "";
            cbo_CharcterName.SelectedIndex = -1;
            txt_TargetMin.Text = "";
            txt_TargetMax.Text = "";
        }

        private void gv_RuleStd_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_RuleStd.GetDataRow(e.FocusedRowHandle);

                if (dr != null)
                {
                    BindGradeDetails(dr["C_ID"].ToString());

                    str_TQB_GRADE_RULE_ID = "";

                    txt_SpecMin.Text = "";
                    txt_SpecMax.Text = "";
                    cbo_CharcterName.SelectedIndex = -1;
                    txt_TargetMin.Text = "";
                    txt_TargetMax.Text = "";
                }
                else
                {
                    gc_Rule.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gv_Rule_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Rule.GetDataRow(gv_Rule.FocusedRowHandle);

                if (dr != null)
                {
                    str_TQB_GRADE_RULE_ID = dr["C_ID"].ToString();

                    txt_SpecMin.Text = dr["C_SPEC_MIN"].ToString();
                    cbo_SpecInterval.Text = dr["C_SPEC_INTERVAL"].ToString();
                    txt_SpecMax.Text = dr["C_SPEC_MAX"].ToString();

                    DataTable dt = bllTqbCharacter.GetTypeAndCharacter(dr["C_CHARACTER_ID"].ToString()).Tables[0];
                    imgcbo_CheckType.EditValue = dt.Rows[0]["TypeID"].ToString();

                    BindCharacter(imgcbo_CheckType.EditValue.ToString());

                    cbo_CharcterName.Text = dt.Rows[0]["C_NAME"].ToString();

                    imgcbo_Lev.Text = dr["C_LEV"].ToString();

                    txt_TargetMin.Text = dr["C_TARGET_MIN"].ToString();
                    cbo_TargetInterval.Text = dr["C_TARGET_INTERVAL"].ToString();
                    txt_TargetMax.Text = dr["C_TARGET_MAX"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
