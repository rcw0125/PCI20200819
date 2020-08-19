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
    public partial class FrmPB_NYKZCB_EDIT : Form
    {
        public FrmPB_NYKZCB_EDIT()
        {
            InitializeComponent();
        }
        Bll_TB_MATERIAL_COST bll = new Bll_TB_MATERIAL_COST();
        private string strMenuName;
        public string c_id;
        private void FrmPB_NYKZCB_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TB_MATERIAL_COST mod = bll.GetModel(c_id);
            txt_NYJZ1.Enabled = false;
            txt_NYJZ1.Text = mod.C_MATERIAL_NAME;
            txt_BZ.Text = mod.C_REMARK;
            txt_DJ.Text = mod.N_COST.ToString();
            txt_DW.Text = mod.C_UNIT;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TB_MATERIAL_COST mod = bll.GetModel(c_id);
                mod.C_MATERIAL_NAME = txt_NYJZ1.Text;
                mod.C_REMARK =txt_BZ.Text;
                mod.C_UNIT = txt_DW.Text;
                mod.N_COST = Convert.ToDecimal(txt_DJ.Text);
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                if (txt_DJ.Text == "0")
                {
                    MessageBox.Show("单价不能为0！");
                    return;
                }
                if (txt_DW.Text == "")
                {
                    MessageBox.Show("请输入单位！");
                    return;
                }
                bll.Update(mod);
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改能源介质成本");//添加操作日志
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
