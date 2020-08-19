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
    public partial class FrmQB_BZYQ_EDIT : Form
    {
         
        public FrmQB_BZYQ_EDIT()
        { 
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_PACK bll = new Bll_TQB_PACK(); public string c_id;
        private void FrmQB_BZYQ_EDIT_Load(object sender, EventArgs e)
        { 
            strMenuName = RV.UI.UserInfo.menuName;

            Mod_TQB_PACK mod = bll.GetModel(c_id);
            txt_PackCode.ReadOnly = true; 
            txt_PackCode.Text = mod.C_PACK_TYPE_CODE;
            txt_PackName.Text = mod.C_PACK_TYPE_NAME;
            txt_Remark.Text = mod.C_REMARK;
            memo_PackDesc.Text = mod.C_PACK_DESC;
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_PackName.Text.Trim()))
            {
                MessageBox.Show("包装类别名称不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(memo_PackDesc.Text.Trim()))
            {
                MessageBox.Show("包装方式说明不能为空！");
                return;
            }
            try
            {
                Mod_TQB_PACK mod = bll.GetModel(c_id);
                 
                mod.C_PACK_TYPE_NAME = txt_PackName.Text.Trim();
                mod.C_PACK_DESC = memo_PackDesc.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;

                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                
                bll.Update(mod);
                 
                MessageBox.Show("保存成功！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改包装要求");//添加操作日志 
                 
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
