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
namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_PJGXWH_Edit : Form
    {
        public FrmQC_PJGXWH_Edit()
        {
            InitializeComponent();
        }
        Bll_TQC_RATING_PROCESS  bll = new Bll_TQC_RATING_PROCESS();
        private string strMenuName;
        public string c_id;
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC_PJGXWH_Edit_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName; 
            Mod_TQC_RATING_PROCESS mod = bll.GetModel(c_id);
            txt_Name.Text = mod.C_NAME;
            txt_Type.Text = mod.C_TYPE;
            txt_Remark.Text = mod.C_REMARK; 
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
                MessageBox.Show("工序不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Type.Text.Trim()))
            {
                MessageBox.Show("评级项目不能为空！");
                return;
            }
            try
            {
                Mod_TQC_RATING_PROCESS mod = bll.GetModel(c_id);
                mod.C_NAME = txt_Name.Text.Trim();
                mod.C_TYPE = txt_Type.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();

                ht.Add("C_NAME", c_id);
                ht.Add("C_ID", mod.C_NAME);
                ht.Add("C_TYPE", mod.C_TYPE);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQC_RATING_PROCESS", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (bll.Update(mod))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工序信息");//添加操作日志


                    MessageBox.Show("保存成功！");
                    this.DialogResult = DialogResult.Cancel;
                }
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
