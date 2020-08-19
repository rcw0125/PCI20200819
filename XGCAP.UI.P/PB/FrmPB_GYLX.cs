using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using BLL;
using Common;

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_GYLX : Form
    {
        public FrmPB_GYLX()
        {
            InitializeComponent();
        }
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        CommonSub commonSub = new CommonSub();
        Bll_TPB_SCLX bll_TPB_SCLX = new Bll_TPB_SCLX();
        private void FrmPB_GYLX_Load(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindGWByGX("ZL", cbo_ZL3);
            commonSub.ImageComboBoxEditBindGWByGX("ZL", cbo_ZL4);
            commonSub.ImageComboBoxEditBindGWByGX("ZL", cbo_ZL5);
            commonSub.ImageComboBoxEditBindGWByGX("ZL", cbo_ZL6);
            commonSub.ImageComboBoxEditBindGWByGX("ZL", cbo_ZL7);
            commonSub.ImageComboBoxEditBindGWByGX("LF", cbo_LF3);
            commonSub.ImageComboBoxEditBindGWByGX("LF", cbo_LF4);
            commonSub.ImageComboBoxEditBindGWByGX("LF", cbo_LF5);
            commonSub.ImageComboBoxEditBindGWByGX("LF", cbo_LF6);
            commonSub.ImageComboBoxEditBindGWByGX("LF", cbo_LF7);
            commonSub.ImageComboBoxEditBindGWByGX("RH", cbo_RH3);
            commonSub.ImageComboBoxEditBindGWByGX("RH", cbo_RH4);
            commonSub.ImageComboBoxEditBindGWByGX("RH", cbo_RH5);
            commonSub.ImageComboBoxEditBindGWByGX("RH", cbo_RH6);
            commonSub.ImageComboBoxEditBindGWByGX("RH", cbo_RH7);
            cbo_ZL3.Properties.Items.Add("","",0);
            cbo_ZL4.Properties.Items.Add("","",0);
            cbo_ZL5.Properties.Items.Add("","",0);
            cbo_ZL6.Properties.Items.Add("","",0);
            cbo_ZL7.Properties.Items.Add("","",0);
            cbo_LF3.Properties.Items.Add("","",0);
            cbo_LF4.Properties.Items.Add("","",0);
            cbo_LF5.Properties.Items.Add("","",0);
            cbo_LF6.Properties.Items.Add("","",0);
            cbo_LF7.Properties.Items.Add("","",0);
            cbo_RH3.Properties.Items.Add("","",0);
            cbo_RH4.Properties.Items.Add("","",0);
            cbo_RH5.Properties.Items.Add("","",0);
            cbo_RH6.Properties.Items.Add("","",0);
            cbo_RH7.Properties.Items.Add("", "", 0);
            Query();
        }

        private void Query()
        {
            DataTable dt = bll_TPB_SCLX.GetAllList().Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                string sta = bll_TB_STA.Get_STA_CODE(item["C_CC"].ToString());
                if (sta == "3#CC")
                {
                    cbo_ZL3.EditValue = item["C_ZL"].ToString();
                    cbo_RH3.EditValue = item["C_RH"].ToString();
                    cbo_LF3.EditValue = item["C_LF"].ToString();
                }
                if (sta == "4#CC")
                {
                    cbo_ZL4.EditValue = item["C_ZL"].ToString();
                    cbo_RH4.EditValue = item["C_RH"].ToString();
                    cbo_LF4.EditValue = item["C_LF"].ToString();
                }
                if (sta == "5#CC")
                {
                    cbo_ZL5.EditValue = item["C_ZL"].ToString();
                    cbo_RH5.EditValue = item["C_RH"].ToString();
                    cbo_LF5.EditValue = item["C_LF"].ToString();
                }
                if (sta == "6#CC")
                {
                    cbo_ZL6.EditValue = item["C_ZL"].ToString();
                    cbo_RH6.EditValue = item["C_RH"].ToString();
                    cbo_LF6.EditValue = item["C_LF"].ToString();
                }
                if (sta == "7#CC")
                {
                    cbo_ZL7.EditValue = item["C_ZL"].ToString();
                    cbo_RH7.EditValue = item["C_RH"].ToString();
                    cbo_LF7.EditValue = item["C_LF"].ToString();
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cbo_ZL3.Text.Contains("AOD") == true || cbo_ZL4.Text.Contains("AOD") == true || cbo_ZL5.Text.Contains("AOD") == true || cbo_ZL7.Text.Contains("AOD") == true)
            {
                MessageBox.Show("AOD只能在6#铸机选择！");
                return;
            }
            if (cbo_ZL3.Text.Contains("4") == true || cbo_ZL4.Text.Contains("4") == true || cbo_ZL6.Text.Contains("4") == true)
            {
                MessageBox.Show("4#ZL只能在5#铸机和7#铸机选择！");
                return;
            }
            if (cbo_LF3.Text.Contains("3")==true|| cbo_LF4.Text.Contains("3") == true || cbo_LF6.Text.Contains("3") == true || cbo_LF7.Text.Contains("3") == true)
            {
                MessageBox.Show("3#LF只能在5#铸机选择！");
                return;
            }
            if (cbo_RH3.Text!="" || cbo_RH4.Text != "" || cbo_RH6.Text != "" || cbo_RH7.Text != "")
            {
                MessageBox.Show("1#RH只能在5#铸机选择！");
                return;
            }
            string sta = "";
            bll_TPB_SCLX.Delete();
            Mod_TPB_SCLX mod_TPB_SCLX = new Mod_TPB_SCLX();
            sta= bll_TB_STA.GetStaIdByCode("3#CC");
            mod_TPB_SCLX.C_CC = sta;
            mod_TPB_SCLX.C_EMP_ID = RV.UI.UserInfo.userID;
            mod_TPB_SCLX.C_LF = cbo_LF3.EditValue.ToString();
            mod_TPB_SCLX.C_RH = cbo_RH3.EditValue.ToString();
            mod_TPB_SCLX.C_ZL = cbo_ZL3.EditValue.ToString();
            bll_TPB_SCLX.Add(mod_TPB_SCLX);
            sta = bll_TB_STA.GetStaIdByCode("4#CC");
            mod_TPB_SCLX.C_CC = sta;
            mod_TPB_SCLX.C_EMP_ID = RV.UI.UserInfo.userID;
            mod_TPB_SCLX.C_LF = cbo_LF4.EditValue.ToString();
            mod_TPB_SCLX.C_RH = cbo_RH4.EditValue.ToString();
            mod_TPB_SCLX.C_ZL = cbo_ZL4.EditValue.ToString();
            bll_TPB_SCLX.Add(mod_TPB_SCLX);
            sta = bll_TB_STA.GetStaIdByCode("5#CC");
            mod_TPB_SCLX.C_CC = sta;
            mod_TPB_SCLX.C_EMP_ID = RV.UI.UserInfo.userID;
            mod_TPB_SCLX.C_LF = cbo_LF5.EditValue.ToString();
            mod_TPB_SCLX.C_RH = cbo_RH5.EditValue.ToString();
            mod_TPB_SCLX.C_ZL = cbo_ZL5.EditValue.ToString();
            bll_TPB_SCLX.Add(mod_TPB_SCLX);
            sta = bll_TB_STA.GetStaIdByCode("6#CC");
            mod_TPB_SCLX.C_CC = sta;
            mod_TPB_SCLX.C_EMP_ID = RV.UI.UserInfo.userID;
            mod_TPB_SCLX.C_LF = cbo_LF6.EditValue.ToString();
            mod_TPB_SCLX.C_RH = cbo_RH6.EditValue.ToString();
            mod_TPB_SCLX.C_ZL = cbo_ZL6.EditValue.ToString();
            bll_TPB_SCLX.Add(mod_TPB_SCLX);
            sta = bll_TB_STA.GetStaIdByCode("7#CC");
            mod_TPB_SCLX.C_CC = sta;
            mod_TPB_SCLX.C_EMP_ID = RV.UI.UserInfo.userID;
            mod_TPB_SCLX.C_LF = cbo_LF7.EditValue.ToString();
            mod_TPB_SCLX.C_RH = cbo_RH7.EditValue.ToString();
            mod_TPB_SCLX.C_ZL = cbo_ZL7.EditValue.ToString();
            bll_TPB_SCLX.Add(mod_TPB_SCLX);
            MessageBox.Show("保存成功！");
            Query();
        }
    }
}
