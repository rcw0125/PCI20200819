﻿using BLL;
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
    public partial class FrmPB_MLZL_EDIT : Form
    {
        public FrmPB_MLZL_EDIT()
        {
            InitializeComponent();
        }
        Bll_TPB_CAST_STOVE_WGT bll_TPB_CAST_STOVE_WGT = new Bll_TPB_CAST_STOVE_WGT();
        private string strMenuName;
        CommonSub commonSub = new CommonSub();
        public string c_id;
        private void FrmPB_MLZL_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TPB_CAST_STOVE_WGT mod = bll_TPB_CAST_STOVE_WGT.GetModel(c_id);
            commonSub.ImageComboBoxEditBindGWByGX("ZL", cbo_GW);
            cbo_GW.EditValue = mod.C_STA_ID;
            cbo_GW.Enabled = false;
            txt_TIME.Text = mod.N_STA_WGT.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                Mod_TPB_CAST_STOVE_WGT mod = bll_TPB_CAST_STOVE_WGT.GetModel(c_id);
                mod.C_STA_ID = cbo_GW.EditValue.ToString();
                mod.N_STA_WGT = Convert.ToDecimal(txt_TIME.Text);
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                if (mod.N_STA_WGT == 0)
                {
                    MessageBox.Show("保存失败，重量不能为0！");
                    return;
                }
                bll_TPB_CAST_STOVE_WGT.Update(mod);
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改换浇次时间");//添加操作日志
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
