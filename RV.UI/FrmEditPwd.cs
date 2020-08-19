using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RV.MODEL;
using RV.BLL;

namespace RV.UI
{
    public partial class FrmEditPwd : Form
    {
        private BllTS_USER bll = new BllTS_USER();

        public FrmEditPwd()
        {
            InitializeComponent();
        }

        private void FrmEditPwd_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Pwd1.Text.Trim()))
                {
                    MessageBox.Show("密码不能为空！");
                    return;
                }

                if (string.IsNullOrEmpty(txt_Pwd2.Text.Trim()))
                {
                    MessageBox.Show("密码不能为空！");
                    return;
                }

                if (txt_Pwd1.Text.Trim() == txt_Pwd2.Text.Trim())
                {
                    ModTS_USER mod = bll.GetModel(UserInfo.userID);
                    if (mod != null)
                    {
                        mod.C_PASSWORD = Common.MD5(txt_Pwd1.Text.Trim());//密码
                        mod.D_MOD_DT = ServerTime.timeNow();//系统操作时间

                        if (bll.Update(mod))
                        {
                            MessageBox.Show("密码修改成功!");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
