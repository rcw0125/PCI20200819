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

namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APS_ZG_PLAN_LOG : Form
    {
        private Bll_TB_ZG_PLAN_LOG bllZgPlanLog = new Bll_TB_ZG_PLAN_LOG();

        public FrmPO_APS_ZG_PLAN_LOG()
        {
            InitializeComponent();
        }

        private void FrmPO_APS_ZG_PLAN_LOG_Load(object sender, EventArgs e)
        {
            string strPcName = bllZgPlanLog.Get_Pc_Name();

            txt_PC_Name.Text = strPcName;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_PC_Name.Text.Trim()))
            {
                MessageBox.Show("排产名称不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(txt_PC_Reason.Text.Trim()))
            {
                MessageBox.Show("排产原因不能为空！");
                return;
            }

            Mod_TB_ZG_PLAN_LOG model = new Mod_TB_ZG_PLAN_LOG();
            model.C_EMP_ID = RV.UI.UserInfo.userID;
            model.C_EMP_NAME = RV.UI.UserInfo.userName;
            model.C_PLAN_NAME = txt_PC_Name.Text.Trim();
            model.C_REASON = txt_PC_Reason.Text.Trim();
            model.D_MOD_DT = RV.UI.ServerTime.timeNow();
            if (bllZgPlanLog.Add(model))
            {
                MessageBox.Show("添加成功！");
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }

        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
