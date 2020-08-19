using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_ZLTSFG_EDIT : Form
    {
        public FrmPB_ZLTSFG_EDIT()
        {
            InitializeComponent();
        }
        Bll_TPB_WASTE_RATIO bll_TPB_WASTE_RATIO = new Bll_TPB_WASTE_RATIO();
        CommonSub commonSub = new CommonSub();
        private string strMenuName;
        public string c_id;
        public decimal wgt;
        private void FrmPB_ZLTSFG_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TPB_WASTE_RATIO mod = bll_TPB_WASTE_RATIO.GetModel(c_id);
            //wgt = Convert.ToDecimal(mod.N_IRON_RATIO + mod.N_SCRAP_RATIO);
            commonSub.ImageComboBoxEditBindGW("", cbo_ZL1);//绑定工位
            cbo_ZL1.EditValue = mod.C_STA_ID;
            cbo_ZL1.Enabled = false;
            txt_CT.Text = mod.N_CG_WGT.ToString();
            txt_FG.Text = mod.N_FG_WGT.ToString();
            txt_TS.Text = mod.N_TS_WGT.ToString();
            txt_ZL.Text = mod.N_WGT.ToString();
            txt_Remark.Text = mod.C_REMARK.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ZL.Text == "0" || txt_ZL.Text == "")
                {
                    txt_ZL.Focus();
                    MessageBox.Show("每炉重量不能为空或不能等于0,请修改每炉重量!"); return;
                }
                if (txt_TS.Text == "0" || txt_TS.Text == "")
                {
                    txt_TS.Focus();
                    MessageBox.Show("铁水重量不能为空或不能等于0,请修改每炉重量！"); return;
                }
                if (txt_CT.Text == "0" || txt_CT.Text == "")
                {
                    txt_CT.Focus();
                    MessageBox.Show("出铁重量不能为空或不能等于0,请修改出铁重量！"); return;
                }
                if (Convert.ToDecimal(txt_TS.Text) > Convert.ToDecimal(txt_ZL.Text))
                {
                    txt_TS.Focus();
                    MessageBox.Show("铁水重量不能大于每炉重量,请修改铁水重量！"); return;
                }
                if (Convert.ToDecimal(txt_CT.Text) > Convert.ToDecimal(txt_ZL.Text))
                {
                    txt_CT.Focus();
                    MessageBox.Show("出铁重量不能大于每炉重量,请修改出铁重量！"); return;
                }
                Mod_TPB_WASTE_RATIO mod = bll_TPB_WASTE_RATIO.GetModel(c_id);
                mod.N_CG_WGT = Convert.ToDecimal(txt_CT.Text);
                mod.N_FG_WGT = Convert.ToDecimal(txt_FG.Text);
                mod.N_TS_WGT = Convert.ToDecimal(txt_TS.Text);
                mod.N_WGT = Convert.ToDecimal(txt_ZL.Text);
                mod.C_REMARK = txt_Remark.Text;
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                bll_TPB_WASTE_RATIO.Update(mod);
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改铁水废钢比例！");//添加操作日志
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
