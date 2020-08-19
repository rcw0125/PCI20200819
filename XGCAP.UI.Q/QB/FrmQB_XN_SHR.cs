using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_XN_SHR : Form
    {
        private Bll_TQB_XN_CHECK_USER bllCheckUser = new Bll_TQB_XN_CHECK_USER();

        public FrmQB_XN_SHR()
        {
            InitializeComponent();
        }

        private void FrmQB_XN_SHR_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void BindInfo()
        {
            DataTable dt = bllCheckUser.GetAllList().Tables[0];

            gc_User.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_User);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_User.Text.Trim()))
            {
                MessageBox.Show("审核人不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(icbo_Dept.Text.Trim()))
            {
                MessageBox.Show("部门不能为空！");
                return;
            }

            Mod_TQB_XN_CHECK_USER modUser = new Mod_TQB_XN_CHECK_USER();
            modUser.C_USER_NAME = txt_User.Text.Trim();
            modUser.C_DEPT = icbo_Dept.Text.Trim();

            if(bllCheckUser.Add(modUser))
            {
                MessageBox.Show("删除成功！");

                BindInfo();
            }
            
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_User.GetDataRow(gv_User.FocusedRowHandle);
            if (dr != null)
            {
                Mod_TQB_XN_CHECK_USER modUser = bllCheckUser.GetModel(dr["C_ID"].ToString());

                modUser.N_STATUS = 0;

                if (bllCheckUser.Update(modUser))
                {
                    MessageBox.Show("删除成功！");

                    BindInfo();
                }
            }
        }
    }
}
