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

namespace XGCAP.UI.P.PP
{
    public partial class FrmPP_GYLX_SELECT : Form
    {
        private Bll_TPP_LG_PLAN bllTppLgPlan = new Bll_TPP_LG_PLAN();
        private Bll_TB_STA bllTbSta = new Bll_TB_STA();

        private string str_LD = "";
        private string str_LF = "";
        private string str_RH = "";
        private string str_CC = "";

        public FrmPP_GYLX_SELECT(string ld, string lf, string rh, string cc)
        {
            InitializeComponent();

            str_LD = ld;
            str_LF = lf;
            str_RH = rh;
            str_CC = cc;
        }

        private void FrmPP_GYLX_SELECT_Load(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void BindInfo()
        {
            CommonSub.BindIcbo("", "ZL", icbo_LD);
            CommonSub.BindIcbo("", "LF", icbo_LF);
            CommonSub.BindIcbo("", "RH", icbo_RH);
            CommonSub.BindIcbo("", "CC", icbo_CC);

            if (!string.IsNullOrEmpty(str_LD))
            {
                icbo_LD.EditValue = str_LD;
            }

            if (!string.IsNullOrEmpty(str_LF))
            {
                icbo_LF.EditValue = str_LF;
            }

            if (!string.IsNullOrEmpty(str_RH))
            {
                icbo_RH.EditValue = str_RH;
            }

            if (!string.IsNullOrEmpty(str_CC))
            {
                icbo_CC.EditValue = str_CC;
            }
        }

        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sure_Click(object sender, EventArgs e)
        {
            string ld_id = "";
            string lf_id = "";
            string rh_id = "";
            string cc_id = "";

            if (string.IsNullOrEmpty(icbo_LD.Text.ToString()))
            {
                MessageBox.Show("请选择转炉！");
                return;
            }
            else
            {
                ld_id = icbo_LD.EditValue.ToString();
            }

            if (string.IsNullOrEmpty(icbo_CC.Text.ToString()))
            {
                MessageBox.Show("连铸不能为空！");
                return;
            }
            else
            {
                cc_id = icbo_CC.EditValue.ToString();
            }

            if (!string.IsNullOrEmpty(icbo_LF.Text))
            {
                lf_id = icbo_LF.EditValue.ToString();
            }

            if (!string.IsNullOrEmpty(icbo_RH.Text))
            {
                rh_id = icbo_RH.EditValue.ToString();
            }


            string a = bllTppLgPlan.UpdateGYLX(icbo_LD.EditValue.ToString(), icbo_LF.EditValue.ToString(), icbo_RH.EditValue.ToString(), icbo_CC.EditValue.ToString());

            if (a == "1")
            {
                MessageBox.Show("修改成功！");

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
                return;
            }
        }
    }
}
