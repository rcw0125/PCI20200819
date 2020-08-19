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
    public partial class FrmQB_XMGYWH_EDIT : Form
    {
        private string strPhyCode;
        public FrmQB_XMGYWH_EDIT(string str_ID)
        { 
            InitializeComponent();
            strPhyCode = str_ID;
        }
        private string strMenuName;
        Bll_TQB_COPING_BASIC bll = new Bll_TQB_COPING_BASIC();
        public string c_id;
        private void FrmQB_XMGYWH_EDIT_Load(object sender, EventArgs e)
        { 
            strMenuName = RV.UI.UserInfo.menuName;

            Mod_TQB_COPING_BASIC mod = bll.GetModel(c_id);
            txt_CopingCraft.Text = mod.C_COPING_CRAFT;
            txt_CraftFlow.Text = mod.C_CRAFT_FLOW;
            txt_Remark.Text = mod.C_REMARK;

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_CopingCraft.Text.Trim()))
            {
                MessageBox.Show("修磨工艺不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_CraftFlow.Text.Trim()))
            {
                MessageBox.Show("工艺流程不能为空！");
                return;
            }
            try
            {
                Mod_TQB_COPING_BASIC mod = bll.GetModel(c_id);
                mod.C_COPING_CRAFT = txt_CopingCraft.Text.Trim();
                mod.C_CRAFT_FLOW = txt_CraftFlow.Text.Trim(); 
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID; 
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_ID", mod.C_ID);
                ht.Add("C_COPING_CRAFT", txt_CopingCraft.Text.Trim());
                ht.Add("C_IS_BXG", strPhyCode);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_COPING_BASIC", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion

                bll.Update(mod); 
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改修磨工艺");//添加操作日志
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
