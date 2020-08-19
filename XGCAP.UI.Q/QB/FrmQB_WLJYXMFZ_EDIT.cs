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
    public partial class FrmQB_WLJYXMFZ_EDIT : Form
    {


        public FrmQB_WLJYXMFZ_EDIT()
        {

            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_PHYSICS_GROUP bll = new Bll_TQB_PHYSICS_GROUP();
        public string c_id;
        private void FrmQB_WLJYXMFZ_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            try
            {
                Mod_TQB_PHYSICS_GROUP mod = bll.GetModel(c_id);
                txt_Name.Text = mod.C_NAME;
                txt_Remark.Text = mod.C_REMARK;
                cbo_jcbm.Text = mod.C_CHECK_DEPMT;
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
                Mod_TQB_PHYSICS_GROUP mod = bll.GetModel(c_id);

                 
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_ID", c_id);
                ht.Add("C_NAME", txt_Name.Text.Trim());
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_PHYSICS_GROUP", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion

                mod.C_NAME = txt_Name.Text.Trim();
                mod.C_CHECK_DEPMT = cbo_jcbm.Text;
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                bll.Update(mod);
                MessageBox.Show("修改成功！");
                this.DialogResult = DialogResult.Cancel;
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改性能分组信息");//添加操作日志
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
