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
    public partial class FrmPB_ZGHGGSJ_EDIT : Form
    {
        public FrmPB_ZGHGGSJ_EDIT()
        {
            InitializeComponent();
        }
        Bll_TPB_CHANGESPEC_TIME bll_TPB_CHANGESPEC_TIME = new Bll_TPB_CHANGESPEC_TIME();
        CommonSub commonSub = new CommonSub();
        private string strMenuName;
        public string c_id;
        private void FrmPB_ZGHGGSJ_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TPB_CHANGESPEC_TIME mod = bll_TPB_CHANGESPEC_TIME.GetModel(c_id);
            commonSub.ImageComboBoxEditBindGW("", cbo_CX2);//绑定工位
            cbo_CX2.EditValue = mod.C_STA_ID;
            cbo_CX2.Enabled = false;
            cbo_GHQ.Text = mod.C_B_SPEC;
            cbo_GHQ.Enabled = false;
            cbo_GHH.Text = mod.C_L_SPEC;
            cbo_GHH.Enabled = false;
            txt_SJ.Text = mod.N_TIME.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TPB_CHANGESPEC_TIME mod = bll_TPB_CHANGESPEC_TIME.GetModel(c_id);
                mod.N_TIME = Convert.ToDecimal(txt_SJ.Text);
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                if (mod.N_TIME == 0)
                {
                    MessageBox.Show("保存失败！时间不能为0！");
                    return;
                }
                bll_TPB_CHANGESPEC_TIME.Update(mod);
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改轧钢换规格时间！");//添加操作日志
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
