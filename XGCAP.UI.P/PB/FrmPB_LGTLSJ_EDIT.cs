using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_LGTLSJ_EDIT : Form
    {
        public FrmPB_LGTLSJ_EDIT()
        {
            InitializeComponent();
        }
        Bll_TPB_STEEL_SMELT_TIME bll_TPB_STEEL_SMELT_TIME = new Bll_TPB_STEEL_SMELT_TIME();
        private string strMenuName;
        CommonSub commonSub = new CommonSub();
        public string c_id;
        private void FrmPB_LGTLSJ_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TPB_STEEL_SMELT_TIME mod = bll_TPB_STEEL_SMELT_TIME.GetModel(c_id);
            commonSub.ImageComboBoxEditBindGX("", cbo_GX, "'CC','ZL','LF','RH'");
            cbo_GX.Enabled = false;
            cbo_GX.EditValue = mod.C_PRO_ID;
            commonSub.ImageComboBoxEditBindGW(cbo_GX.EditValue.ToString(), cbo_GW);
            cbo_GW.Enabled = false;
            cbo_GW.EditValue = mod.C_STA_ID;
            txt_JSCN.Text = (mod.N_SMELT_TIME).ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TPB_STEEL_SMELT_TIME mod = bll_TPB_STEEL_SMELT_TIME.GetModel(c_id);
                mod.C_STA_ID = cbo_GW.EditValue.ToString();
                mod.C_PRO_ID = cbo_GX.EditValue.ToString();
                mod.N_SMELT_TIME = Convert.ToDecimal(txt_JSCN.Text);
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                if (mod.N_SMELT_TIME==0)
                {
                    MessageBox.Show("保存失败，冶炼时间不能为0！");
                    return;
                }
                bll_TPB_STEEL_SMELT_TIME.Update(mod);
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改炼钢冶炼时间");//添加操作日志
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
