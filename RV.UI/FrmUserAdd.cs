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
    public partial class FrmUserAdd : Form
    {

        private string strDeptID = "0";
        private string strDeptName = "";

        public FrmUserAdd()
        {
            InitializeComponent();
        }

        private void FrmUserAdd_Load(object sender, EventArgs e)
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
                BllTS_USER bll = new BllTS_USER();

                if (string.IsNullOrEmpty(txt_UserName.Text.Trim()))
                {
                    MessageBox.Show("姓名不能为空！");
                    return;
                }

                if (string.IsNullOrEmpty(txt_LoginName.Text.Trim()))
                {
                    MessageBox.Show("账号不能为空！");
                    return;
                }
                else
                {
                    if (bll.Exists(txt_LoginName.Text.Trim()))
                    {
                        MessageBox.Show("该账号已存在，不能重复添加！");
                        return;
                    }
                }

                //if (string.IsNullOrEmpty(txt_Email.Text.Trim()))
                //{
                //    MessageBox.Show("邮箱不能为空！");
                //    return;
                //}

                //if (string.IsNullOrEmpty(txt_Tel.Text.Trim()))
                //{
                //    MessageBox.Show("电话不能为空！");
                //    return;
                //}

                ModTS_USER mod = new ModTS_USER();
                mod.C_NAME = txt_UserName.Text.Trim();//姓名
                mod.C_ACCOUNT = txt_LoginName.Text.Trim();//登录名
                mod.C_PASSWORD = Common.MD5("123456");//密码
                mod.C_EMAIL = txt_Email.Text.Trim();//邮箱
                mod.C_MOBILE = txt_Tel.Text.Trim();//电话
                mod.N_TYPE = 3;//用户类型（1内部，2新用户,3PCI用户）
                mod.N_STATUS = 1;//状态(1正常，2，3，4冻结)
                mod.C_EMP_ID = UserInfo.userID;//系统操作人编号
                mod.C_EMP_NAME = UserInfo.userName;//系统操作人姓名
                mod.D_MOD_DT = ServerTime.timeNow();//系系统操作时间

                if (bll.Add(mod))
                {
                    txt_UserName.Text = "";
                    txt_LoginName.Text = "";
                    txt_Email.Text = "";
                    txt_Tel.Text = "";

                    if (!string.IsNullOrEmpty(btnEdit_Dept.Text.Trim()))
                    {
                        BllTS_USER_DEPT bllUserDept = new BllTS_USER_DEPT();

                        ModTS_USER_DEPT model = new ModTS_USER_DEPT();
                        model.C_DEPT_ID = strDeptID;
                        model.C_USER_ID = mod.C_ACCOUNT;
                        bllUserDept.Add(model);
                    }

                    MessageBox.Show("添加成功!");
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

        private void btnEdit_Dept_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmSetDept frm = new FrmSetDept("");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    strDeptID = frm.strDeptID;
                    strDeptName = frm.strDeptName;

                    btnEdit_Dept.Text = frm.strDeptName;

                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
