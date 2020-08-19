using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_GWLSCN_EDIT : Form
    {
        public FrmPB_GWLSCN_EDIT()
        {
            InitializeComponent();
        }
        private string strMenuName;
        private Bll_TPB_STA_HISTORY_CAP bll = new Bll_TPB_STA_HISTORY_CAP();
        private Bll_TB_STA bllsta = new Bll_TB_STA();//工位
        CommonSub commonSub = new CommonSub();
        public string c_id;
        private void FrmPB_GWLSCN_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            commonSub.ImageComboBoxEditBindGX("", cbo_GX, "'CC','ZL','LF','RH','ZX'");//绑定工序
            Mod_TPB_STA_HISTORY_CAP mod = bll.GetModel(c_id);
            cbo_GX.EditValue = mod.C_PRO_ID;
            commonSub.ImageComboBoxEditBindGW(cbo_GX.EditValue.ToString(), cbo_GW);//绑定工位
            cbo_GW.EditValue = mod.C_STA_ID;
            cbo_GX.Enabled = false;
            cbo_GW.Enabled = false;
            txt_cn.Text = mod.N_CAPACITY.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TPB_STA_HISTORY_CAP mod = bll.GetModel(c_id);
                mod.C_PRO_ID = cbo_GX.EditValue.ToString();
                mod.C_STA_ID = cbo_GW.EditValue.ToString();
                mod.N_CAPACITY = Convert.ToDecimal(txt_cn.Text);
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                if (mod.N_CAPACITY==0)
                {
                    MessageBox.Show("保存失败！产能不能为空");
                    return;
                }
                bll.Update(mod);
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工位历史产能");//添加操作日志
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
