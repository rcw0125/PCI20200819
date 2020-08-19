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
using System.Collections;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;

namespace RV.UI
{
    public partial class Login : Form
    {
        private BllTS_USER bllUser = new BllTS_USER();
        private BllTS_USER_FUN_PCI bllUserFun = new BllTS_USER_FUN_PCI();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //txt_Name.Text = "system";
            //txt_Pwd.Text = "123456";
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                ModTS_USER modUser = bllUser.GetModel(txt_Name.Text.Trim(), Common.MD5(txt_Pwd.Text.Trim()));

                if (modUser != null)
                {
                    if (modUser.N_STATUS != 1)
                    {
                        MessageBox.Show("该账号已经冻结，请联系管理员！");
                        return;
                    }

                    UserInfo.userID = modUser.C_ID;
                    UserInfo.userAccount = modUser.C_ACCOUNT;
                    UserInfo.userName = modUser.C_NAME;

                    this.DialogResult = DialogResult.OK;
                    //Main frm = new Main();
                    //frm.ShowDialog();
                    //this.Dispose();
                    //this.Close();

                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 工位id翻译成描述
        /// </summary>
        /// <returns></returns>
        public RepositoryItemImageComboBox GetUserName()
        {
            var dt = bllUser.GetList().Tables[0];
            var repo = new RepositoryItemImageComboBox();
            foreach (DataRow item in dt.Rows)
            {
                var list = new ImageComboBoxItem(item["C_NAME"].ToString(), item["C_ACCOUNT"]);
                repo.Items.Add(list);
            }
            return repo;
        }
    }
}
