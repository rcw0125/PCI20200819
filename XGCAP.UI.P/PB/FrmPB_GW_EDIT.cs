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
    public partial class FrmPB_GW_EDIT : Form
    {
        public FrmPB_GW_EDIT()
        {
            InitializeComponent();
        }
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();//工位
        private string strMenuName;
        CommonSub commonSub = new CommonSub();
        public string c_id;
        private void FrmPB_GW_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TB_STA mod = bll_TB_STA.GetModel(c_id);
            txt_GWDM.Text = mod.C_STA_CODE;
            txt_GW.Text = mod.C_STA_DESC;
            txt_ERPGWDM.Text = mod.C_STA_ERPCODE;
            txt_MESGWDM.Text = mod.C_STA_MESCODE;
            txt_Remark_GW.Text = mod.C_REMARK;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TB_STA mod = bll_TB_STA.GetModel(c_id);
                mod.C_STA_CODE = txt_GWDM.Text;
                mod.C_STA_DESC = txt_GW.Text;
                mod.C_STA_ERPCODE = txt_ERPGWDM.Text;
                mod.C_STA_MESCODE = txt_MESGWDM.Text;
                mod.C_REMARK = txt_Remark_GW.Text;
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                bll_TB_STA.Update(mod);
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工位");//添加操作日志
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
