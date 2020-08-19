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
    public partial class FrmQB_ZZS_DY : Form
    {
        private Bll_TQB_ZZS_PRINT_ROWNUM bllPrint = new Bll_TQB_ZZS_PRINT_ROWNUM();

        public FrmQB_ZZS_DY()
        {
            InitializeComponent();
        }

        private void FrmQB_ZZS_DY_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BindModleList();
        }

        private void BindModleList()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bllPrint.GetList(txt_GZ.Text.Trim(), txt_BZ.Text.Trim()).Tables[0];

                gc_Dy.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Dy);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Main_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btnEdit_Stl_Grd.Text.Trim()))
                {
                    MessageBox.Show("请选择钢种！");
                    return;
                }

                if (string.IsNullOrEmpty(txt_Std_Code.Text.Trim()))
                {
                    MessageBox.Show("请选择执行标准！");
                    return;
                }

                if (string.IsNullOrEmpty(txt_Num.Text.Trim()))
                {
                    MessageBox.Show("请填写打印行数！");
                    return;
                }
                else
                {
                    int result = 0;
                    if (!int.TryParse(txt_Num.Text.Trim(), out result))
                    {
                        MessageBox.Show("打印行数只能填写大于零的整数！");
                        return;
                    }
                    else
                    {
                        if (Convert.ToInt32(txt_Num.Text.Trim()) <= 0)
                        {
                            MessageBox.Show("打印行数只能填写大于零的整数！");
                            return;
                        }
                    }
                }

                if (bllPrint.Exists(btnEdit_Stl_Grd.Text.Trim(), txt_Std_Code.Text.Trim()))
                {
                    MessageBox.Show("要添加的数据已存在，不能重复添加！");
                    return;
                }
                

                Mod_TQB_ZZS_PRINT_ROWNUM mod = new Mod_TQB_ZZS_PRINT_ROWNUM();
                mod.C_STL_GRD = btnEdit_Stl_Grd.Text.Trim();
                mod.C_STD_CODE = txt_Std_Code.Text.Trim();
                mod.N_ROWNUM = Convert.ToDecimal(txt_Num.Text.Trim());
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                mod.C_EMP_ID = RV.UI.UserInfo.userID;
                mod.N_STATUS = 1;

                if (bllPrint.Add(mod))
                {
                    MessageBox.Show("添加成功！");

                    btnEdit_Stl_Grd.Text = "";
                    txt_Std_Code.Text = "";

                    BindModleList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Main_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Dy.GetDataRow(gv_Dy.FocusedRowHandle);

                if (dr != null)
                {
                    Mod_TQB_ZZS_PRINT_ROWNUM mod = bllPrint.GetModel(dr["C_ID"].ToString());
                    if (mod != null)
                    {
                        mod.N_STATUS = 0;
                        mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        mod.C_EMP_ID = RV.UI.UserInfo.userID;

                        if (bllPrint.Update(mod))
                        {
                            MessageBox.Show("删除成功！");
                            BindModleList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择需要删除的数据！");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要删除的数据！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Stl_Grd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_ZXBZ frm = new FrmQB_SELECT_ZXBZ("");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnEdit_Stl_Grd.Text = frm.str_GRD;
                    txt_Std_Code.Text = frm.str_STD;
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
