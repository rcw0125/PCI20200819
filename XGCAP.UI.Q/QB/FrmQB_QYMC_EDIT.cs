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
    public partial class FrmQB_QYMC_EDIT : Form
    {


        public FrmQB_QYMC_EDIT()
        {

            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_SAMPLING bll = new Bll_TQB_SAMPLING();


        public string c_id;
        private void FrmQB_QYMC_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TQB_SAMPLING mod = bll.GetModel(c_id);
            txt_Name.Text = mod.C_SAMPLING_NAME;
            txt_Remark.Text = mod.C_REMARK;
            cbo_jcbm.Text = mod.C_CHECK_DEPMT;
            txt_SXH.Text = mod.N_SAMPLING_SN.ToString();

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
            //if (cbo_jcbm.SelectedIndex == -1)
            //{
            //    MessageBox.Show("检测部门不能为空！");
            //    return;
            //}

            try
            {
                Mod_TQB_SAMPLING mod = bll.GetModel(c_id);


                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_ID", c_id);
                ht.Add("C_SAMPLING_NAME", txt_Name.Text);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_SAMPLING", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion

                mod.C_SAMPLING_NAME = txt_Name.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.N_SAMPLING_SN = Convert.ToDecimal(txt_SXH.Text.Trim());
                mod.C_CHECK_DEPMT = cbo_jcbm.Text;
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                bll.Update(mod);
                MessageBox.Show("修改成功！");
                this.DialogResult = DialogResult.Cancel;
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改取样名称信息");//添加操作日志
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
