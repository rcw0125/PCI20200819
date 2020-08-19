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
    public partial class FrmPB_GX_EDIT : Form
    {
        public FrmPB_GX_EDIT()
        {
            InitializeComponent();
        }
        Bll_TB_PRO bll_TB_PRO = new Bll_TB_PRO();//工序
        private string strMenuName;
        CommonSub commonSub = new CommonSub();
        public string c_id;
        private void FrmPB_GX_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TB_PRO mod = bll_TB_PRO.GetModel(c_id);
            txt_GXDM.Text= mod.C_PRO_CODE;
            txt_GXMS.Text = mod.C_PRO_DESC;
            txt_ERPGXDM.Text = mod.C_PRO_ERPCODE;
            txt_MESGXDM.Text = mod.C_PRO_MESCODE;
            txt_Remark.Text = mod.C_REMARK;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TB_PRO mod = bll_TB_PRO.GetModel(c_id);
                mod.C_PRO_CODE = txt_GXDM.Text;
                mod.C_PRO_DESC = txt_GXMS.Text;
                mod.C_PRO_ERPCODE = txt_ERPGXDM.Text;
                mod.C_PRO_MESCODE = txt_MESGXDM.Text;
                mod.C_REMARK = txt_Remark.Text;
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                bll_TB_PRO.Update(mod);
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改钢坯库区域");//添加操作日志
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
