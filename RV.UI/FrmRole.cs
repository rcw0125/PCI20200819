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
    public partial class FrmRole : Form
    {
        private BllTS_ROLE_PCI bllRole = new BllTS_ROLE_PCI();

        public FrmRole()
        {
            InitializeComponent();
        }

        private void FrmRole_Load(object sender, EventArgs e)
        {
            BindRole();
        }

        private void BindRole()
        {
            try
            {
                gc_Role.DataSource = bllRole.GetRoleList().Tables[0];

                gv_Role.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_RoleName.Text.Trim()))
                {
                    if (bllRole.Exists(txt_RoleName.Text.Trim()))
                    {
                        MessageBox.Show("该角色已存在，不能重复添加！");
                        return;
                    }
                    else
                    {
                        ModTS_ROLE_PCI mod = new ModTS_ROLE_PCI();
                        mod.C_ROLE_NAME = txt_RoleName.Text.Trim();
                        mod.C_EMP_ID = UserInfo.userID;

                        if (bllRole.Add(mod))
                        {
                            MessageBox.Show("添加成功！");

                            BindRole();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Role.GetDataRow(gv_Role.FocusedRowHandle);

                if (dr != null)
                {
                    ModTS_ROLE_PCI mod = bllRole.GetModel(dr["C_ID"].ToString());

                    if (mod != null)
                    {
                        mod.N_STATUS = 0;
                        mod.C_EMP_ID = UserInfo.userID;
                        mod.D_MOD_DT = ServerTime.timeNow();

                        if (bllRole.Update(mod))
                        {
                            MessageBox.Show("停用成功！");

                            BindRole();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindRole();
        }

        /// <summary>
        /// 权限设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Right_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Role.GetDataRow(gv_Role.FocusedRowHandle);

                if (dr != null)
                {
                    FrmRight frm = new FrmRight(dr["C_ID"].ToString(), "2");
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
