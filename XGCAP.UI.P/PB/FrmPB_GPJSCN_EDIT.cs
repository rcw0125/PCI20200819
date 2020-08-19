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
    public partial class FrmPB_GPJSCN_EDIT : Form
    {
        public FrmPB_GPJSCN_EDIT()
        {
            InitializeComponent();
        }
        Bll_TPB_SLAB_CAPACITY bll_TPB_SLAB_CAPACITY = new Bll_TPB_SLAB_CAPACITY();
        CommonSub commonSub = new CommonSub();
        private string strMenuName;
        public string c_id;
        private void FrmPB_GPJSCN_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TPB_SLAB_CAPACITY mod = bll_TPB_SLAB_CAPACITY.GetModel(c_id);
            commonSub.ImageComboBoxEditBindGW("", cbo_GW);//绑定工位
            cbo_GW.EditValue = mod.C_STA_ID;
            cbo_GW.Enabled = false;
            txt_Grd.Text = mod.C_STL_GRD;
            txt_Grd.Enabled = false;
            txt_Std.Text = mod.C_STD_CODE;
            txt_Std.Enabled = false;
            txt_JSCN.Text = mod.N_CAPACITY.ToString();
            cbo_DM.EditValue = mod.C_SPEC;
            cbo_DM.Enabled = false;
            cbo_ys.EditValue = mod.C_TYPE; 
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TPB_SLAB_CAPACITY mod = bll_TPB_SLAB_CAPACITY.GetModel(c_id);
                mod.N_CAPACITY = Convert.ToDecimal(txt_JSCN.Text);
                mod.C_TYPE = cbo_ys.EditValue.ToString();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                if (mod.N_CAPACITY == 0)
                {
                    MessageBox.Show("保存失败！产能不能为空");
                    return;
                }
                bll_TPB_SLAB_CAPACITY.Update(mod);
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
