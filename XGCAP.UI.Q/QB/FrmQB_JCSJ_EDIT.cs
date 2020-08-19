using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_JCSJ_EDIT : Form
    {


        public FrmQB_JCSJ_EDIT()
        { 
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_CHECKTYPE type_bll = new Bll_TQB_CHECKTYPE();
        Bll_TQB_CHARACTER bll = new Bll_TQB_CHARACTER();
        public string c_id;
        private void FrmQB_JCSJ_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName; 

            Mod_TQB_CHARACTER mod = bll.GetModel(c_id); 
            txt_Name.Text = mod.C_NAME;
            txt_Unit.Text = mod.C_UNIT; 
            txt_Book_Show.Text = mod.C_BOOK_SHOW;
            txt_Formula.Text = mod.C_FORMULA;
            imgcbo_Quantitative.EditValue = mod.C_QUANTITATIVE;
            txt_Remark.Text = mod.C_REMARK;
            txt_SXH.Text = mod.N_ORDER.ToString();
            txt_XSWS.Text = mod.C_DIGIT;
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {
             
            if (string.IsNullOrEmpty(txt_Name.Text.Trim()))
            {
                MessageBox.Show("项目名称不能为空！");
                return;
            }             
            try
            {
                Mod_TQB_CHARACTER mod = bll.GetModel(c_id); 
                mod.C_NAME = txt_Name.Text.Trim();
                mod.C_UNIT = txt_Unit.Text.Trim();
                mod.C_DIGIT = txt_XSWS.Text.Trim();
                mod.C_BOOK_SHOW = txt_Book_Show.Text.Trim();
                mod.C_FORMULA = txt_Formula.Text.Trim();
                mod.C_QUANTITATIVE = imgcbo_Quantitative.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                mod.N_ORDER = Convert.ToInt32(txt_SXH.Text.Trim());
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_ID", mod.C_ID);
                ht.Add("N_STATUS",1);
                ht.Add("C_TYPE_ID", mod.C_TYPE_ID);
                ht.Add("C_CODE", mod.C_CODE);
                if (Common.CheckRepeat.CheckTable("TQB_CHARACTER", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion

                bll.Update(mod);

                MessageBox.Show("保存成功！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改检验基础数据");//添加操作日志
                this.DialogResult = DialogResult.Cancel;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        } 
    }
}
