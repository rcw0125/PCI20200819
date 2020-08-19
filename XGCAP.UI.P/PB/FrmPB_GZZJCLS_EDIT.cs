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
    public partial class FrmPB_GZZJCLS_EDIT : Form
    {
        public FrmPB_GZZJCLS_EDIT()
        {
            InitializeComponent();
        }
        Bll_TPB_CAST_STOVE bll_TPB_SLAB_CAPACITY = new Bll_TPB_CAST_STOVE();
        CommonSub commonSub = new CommonSub();
        private string strMenuName;
        public string c_id;
        private void FrmPB_GZZJCLS_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TPB_CAST_STOVE mod = bll_TPB_SLAB_CAPACITY.GetModel(c_id);
            commonSub.ImageComboBoxEditBindGW("", cbo_GW2);//绑定工位
            cbo_GW2.EditValue = mod.C_STA_ID;
            cbo_GW2.Enabled = false;
            txt_GZ2.Text = mod.C_STL_GRD;
            txt_GZ2.Enabled = false;
            txt_ZXBZ2.Text = mod.C_STD_CODE;
            txt_ZXBZ2.Enabled = false;
            txt_MIN.Text = mod.N_STOVE_MIN_NUM.ToString();
            txt_MAX.Text = mod.N_STOVE_MAX_NUM.ToString();
            txt_MBLS.Text = mod.N_TARGET_NUM.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TPB_CAST_STOVE mod = bll_TPB_SLAB_CAPACITY.GetModel(c_id);
                mod.N_STOVE_MAX_NUM = Convert.ToDecimal(txt_MAX.Text);
                mod.N_STOVE_MIN_NUM = Convert.ToDecimal(txt_MIN.Text);
                mod.N_TARGET_NUM = Convert.ToDecimal(txt_MBLS.Text);
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                if (mod.N_STOVE_MAX_NUM == 0)
                {
                    MessageBox.Show("保存失败！最大炉数不能为0！");
                    return;
                }
                if (mod.N_STOVE_MIN_NUM == 0)
                {
                    MessageBox.Show("保存失败！最小炉数不能为0！");
                    return;
                }
                if (mod.N_TARGET_NUM == 0)
                {
                    MessageBox.Show("保存失败！目标炉数不能为0！");
                    return;
                }
                bll_TPB_SLAB_CAPACITY.Update(mod);
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改钢种整浇次炉数！");//添加操作日志
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
