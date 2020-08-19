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
    public partial class FrmQB_JYLB_EDIT : Form
    {
        public string id = "";
        public string name = "";
        public string remark = "";

        public FrmQB_JYLB_EDIT()
        {

            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_CHECKTYPE bll = new Bll_TQB_CHECKTYPE();//检验类别
        Bll_TQB_CHARACTER bll_character = new Bll_TQB_CHARACTER();//检验基础数据
        private void FrmQB_JYLB_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            txt_TypeName.Text = name;
            txt_Remark1.Text = remark;
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

                Mod_TQB_CHECKTYPE mod = bll.GetModel(id);
                DataTable dt = bll.GetList_Not_Name(txt_TypeName.Text.Trim(), mod.C_TYPE_NAME).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("项目名称已存在！"); 
                    return;
                }
                mod.C_TYPE_NAME = txt_TypeName.Text.Trim();
                mod.C_REMARK = txt_Remark1.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                bll.Update(mod);
                MessageBox.Show("修改成功！");
                UserLog.AddLog(strMenuName, this.Name, this.Text, "修改检验类别");//添加操作日志
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
