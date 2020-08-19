using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_QYMB_Add_MAIN_JSZX : Form
    {
        private Bll_TQB_SAMP_MODLE_JSZX bllTqbSampModleJszx = new Bll_TQB_SAMP_MODLE_JSZX();

        public FrmQB_QYMB_Add_MAIN_JSZX()
        {
            InitializeComponent();
        }

        private void FrmQB_QYMB_Add_MAIN_JSZX_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btn_GZ.Text.Trim()))
                {
                    MessageBox.Show("请填写钢种！");
                    return;
                }

                if (string.IsNullOrEmpty(txt_BZ.Text.Trim()))
                {
                    MessageBox.Show("请填写标准！");
                    return;
                }
                
                Mod_TQB_SAMP_MODLE_JSZX model = new Mod_TQB_SAMP_MODLE_JSZX();
                model.C_STL_GRD = btn_GZ.Text.Trim();
                model.C_STD_CODE = txt_BZ.Text.Trim();
                model.C_SPEC_MIN = txt_Spec_Min.Text.Trim();
                model.C_SPEC_MAX = txt_Spec_Max.Text.Trim();
                model.C_EMP_ID = RV.UI.UserInfo.userID;

                if (bllTqbSampModleJszx.Add(model))
                {
                    MessageBox.Show("添加成功！");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_ZXBZ frm = new FrmQB_SELECT_ZXBZ("");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btn_GZ.Text = frm.str_GRD;
                    txt_BZ.Text = frm.str_STD;
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
