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
    public partial class FrmUserManage : Form
    {
        private BllTS_USER bllUser = new BllTS_USER();
        private BllTS_USER_DEPT bllTsUserDept = new BllTS_USER_DEPT();

        public FrmUserManage()
        {
            InitializeComponent();
        }

        private void FrmUserManage_Load(object sender, EventArgs e)
        {
            BindList();
        }

        /// <summary>
        /// 绑定用户信息列表
        /// </summary>
        private void BindList()
        {
            try
            {
                DataTable dt = bllUser.GetUserList().Tables[0];

                gc_User.DataSource = dt;

                //添加行号
                gv_User.IndicatorWidth = 50;

                gv_User.BestFitColumns();
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
            BindList();
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
                DataRow dr = gv_User.GetDataRow(gv_User.FocusedRowHandle);

                if (dr != null)
                {
                    if (UserInfo.userID == dr["用户名"].ToString() && UserInfo.userID != "system")
                    {
                        MessageBox.Show("自己不能修改自己权限！");
                        return;
                    }

                    FrmRight frm = new FrmRight(dr["用户名"].ToString(), "1");
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 分配角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Role_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_User.GetDataRow(gv_User.FocusedRowHandle);

                if (dr != null)
                {
                    if (UserInfo.userID == dr["用户名"].ToString() && UserInfo.userID != "system")
                    {
                        MessageBox.Show("自己不能修改自己角色！");
                        return;
                    }

                    FrmSetRole frm = new FrmSetRole(dr["用户名"].ToString());
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUserAdd frm = new FrmUserAdd();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_User.GetDataRow(gv_User.FocusedRowHandle);

                if (dr != null)
                {
                    FrmUserEdit frm = new FrmUserEdit(dr["用户名"].ToString());
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_User_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                //添加行号
                gv_User.IndicatorWidth = 50;

                e.Info.ImageIndex = -1;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
            catch
            {

            }
        }

        private void gv_User_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control & e.KeyCode == Keys.C)
                {
                    Clipboard.SetDataObject(gv_User.GetFocusedRowCellValue(gv_User.FocusedColumn));
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_User.GetDataRow(gv_User.FocusedRowHandle);

                if (dr != null)
                {
                    if (UserInfo.userID == dr["用户名"].ToString() && UserInfo.userID != "system")
                    {
                        MessageBox.Show("自己不能修改自己部门！");
                        return;
                    }

                    FrmSetDept frm = new FrmSetDept(dr["用户名"].ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ModTS_USER_DEPT model = bllTsUserDept.Get_Model(dr["用户名"].ToString());
                        if (model != null)
                        {
                            model.C_DEPT_ID = frm.strDeptID;
                            bllTsUserDept.Update(model);
                        }
                        else
                        {
                            model = new ModTS_USER_DEPT();
                            model.C_DEPT_ID = frm.strDeptID;
                            model.C_USER_ID = dr["用户名"].ToString();

                            bllTsUserDept.Add(model);
                        }

                        BindList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
