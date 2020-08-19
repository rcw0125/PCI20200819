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
namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_HLGYWH_EDIT : Form
    {
        public FrmQB_HLGYWH_EDIT()
        {
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_COOL_BASIC bll = new Bll_TQB_COOL_BASIC();
        public string c_id;
        private void FrmQB_HLGYWH_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;

            Mod_TQB_COOL_BASIC mod = bll.GetModel(c_id);

            imgcbo_Type.Text = mod.C_TYPE; 
            txt_CoolCode.Text = mod.C_COOL_CRAFT_CODE;
            txt_CoolCraft.Text = mod.C_COOL_CRAFT;
            txt_cooldate.Text = mod.N_COOL_DT.ToString();
            imgcbo_Heat.Text = mod.C_HEAT;
            txt_Hot.Text = mod.C_HOT_T;
            txt_Remark.Text = mod.C_REMARK;
             
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imgcbo_Type.Text.Trim()))
            {
                MessageBox.Show("类型不能为空！");
                return;
            } 
            if (string.IsNullOrEmpty(txt_CoolCode.Text.Trim()))
            {
                MessageBox.Show("缓冷工艺代码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_CoolCraft.Text.Trim()))
            {
                MessageBox.Show("缓冷工艺不能为空！");
                return;
            }
            try
            {
                Mod_TQB_COOL_BASIC mod = bll.GetModel(c_id);
                mod.C_TYPE = imgcbo_Type.Text.Trim(); 
                mod.C_COOL_CRAFT_CODE = txt_CoolCode.Text.Trim();
                mod.C_COOL_CRAFT = txt_CoolCraft.Text.Trim();
                if (!string.IsNullOrEmpty(txt_cooldate.Text.Trim()))
                {
                    mod.N_COOL_DT = Convert.ToDecimal(txt_cooldate.Text.Trim());
                }
                mod.C_HEAT = imgcbo_Heat.Text.Trim();
                mod.C_HOT_T = txt_Hot.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_ID", mod.C_ID);
                ht.Add("C_COOL_CRAFT_CODE", txt_CoolCode.Text.Trim());
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_COOL_BASIC", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                bll.Update(mod);
                MessageBox.Show("保存成功！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改缓冷工艺要求");//添加操作日志
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
