using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RV.BLL;
using RV.MODEL;

namespace RV.UI
{
    public partial class FrmSetRole : Form
    {
        private BllTS_ROLE_PCI bllRole = new BllTS_ROLE_PCI();
        private BllTS_USER_ROLE_PCI bllUserRole = new BllTS_USER_ROLE_PCI();

        private string strUserID = "0";
        public FrmSetRole(string str)
        {
            InitializeComponent();

            strUserID = str;
        }

        private void FrmSetRole_Load(object sender, EventArgs e)
        {
            BindRole();
        }

        /// <summary>
        /// 绑定角色列表
        /// </summary>
        private void BindRole()
        {
            try
            {
                DataTable dt = bllRole.GetUserRoleList(strUserID).Tables[0];

                gc_Role.DataSource = dt;
                gv_Role.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sure_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = gc_Role.DataSource as DataTable;

                string strRoleID = string.Empty;

                if (dt.Rows.Count > 0)
                {
                    bllUserRole.Delete(strUserID);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["C_CHECKSTATE"].ToString() == "1")
                        {
                            string strID = dt.Rows[i]["C_ID"].ToString();
                            ModTS_USER_ROLE_PCI mod = new ModTS_USER_ROLE_PCI();
                            mod.C_ROLE_ID = strID;
                            mod.C_USER_ID = strUserID;
                            mod.C_EMP_ID = UserInfo.userID;

                            bllUserRole.Add(mod);

                            strRoleID += "'" + strID + "',";
                        }
                    }

                    if (strRoleID.Length > 0)
                    {
                        bllUserRole.SaveFun(strRoleID.Substring(0, strRoleID.Length - 1), strUserID);

                        MessageBox.Show("角色分配成功！");
                    }

                }
                else
                {
                    MessageBox.Show("请选择角色！");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("角色分配失败，请重新分配！");
            }
        }
    }
}
