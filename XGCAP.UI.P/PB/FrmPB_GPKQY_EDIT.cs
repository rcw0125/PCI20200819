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
    public partial class FrmPB_GPKQY_EDIT : Form
    {
        public FrmPB_GPKQY_EDIT()
        {
            InitializeComponent();
        }
        private BLL.Bll_TPB_SLABWH_AREA Bll_TPB_SLABWH_AREA = new BLL.Bll_TPB_SLABWH_AREA();//钢坯库区域信息
        private string strMenuName;
        CommonSub commonSub = new CommonSub();
        public string c_id;
        private void FrmPB_GPKQY_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TPB_SLABWH_AREA mod = Bll_TPB_SLABWH_AREA.GetModel(c_id);
            txt_QYBH.Text = mod.C_SLABWH_AREA_CODE;
            txt_QYMS.Text = mod.C_SLABWH_AREA_NAME;
            txt_Remark.Text = mod.C_REMARK;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Mod_TPB_SLABWH_AREA mod = Bll_TPB_SLABWH_AREA.GetModel(c_id);
                mod.C_SLABWH_AREA_CODE = txt_QYBH.Text;
                mod.C_SLABWH_AREA_NAME = txt_QYMS.Text;
                mod.C_REMARK = txt_Remark.Text;
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                Bll_TPB_SLABWH_AREA.Update(mod);
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
