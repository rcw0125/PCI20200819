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

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_GPDCWH_EDIT : Form
    {

        public FrmQB_GPDCWH_EDIT()
        {
            InitializeComponent();
        }
        private string strMenuName;
        private Bll_TQB_SLAB_LEN bllTqbSlabLen = new Bll_TQB_SLAB_LEN();
        private Bll_Common bllCommon = new Bll_Common();

        public string c_id;
        private void FrmQB_GPDCWH_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;

            Mod_TQB_SLAB_LEN mod = bllTqbSlabLen.GetModel(c_id);


            txt_Type.Text = mod.C_TYPE;
            txt_Slab.Text = mod.C_SLAB_SIZE;
            txt_Len_Hot.Text = mod.C_HOT_LEN;
            txt_Len_Cool.Text = mod.C_COLD_LEN;
            txt_Wgt.Text = mod.C_THE_WEIGHT;
            txt_Remark.Text = mod.C_REMARK;
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_Type.Text.Trim()))
            {
                MessageBox.Show("类别不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Slab.Text.Trim()))
            {
                MessageBox.Show("断面不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Len_Cool.Text.Trim()))
            {
                MessageBox.Show("冷坯参考长度不能为空！");
                return;
            }
            try
            {
                
                Mod_TQB_SLAB_LEN model = bllTqbSlabLen.GetModel(c_id);
                model.C_SLAB_SIZE = txt_Slab.Text.Trim();
                model.C_TYPE = txt_Type.Text.Trim();
                model.C_HOT_LEN = txt_Len_Hot.Text.Trim();
                model.C_COLD_LEN = txt_Len_Cool.Text.Trim();
                model.C_THE_WEIGHT = txt_Wgt.Text.Trim();
                model.C_REMARK = txt_Remark.Text.Trim();
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                model.D_MOD_DT = RV.UI.ServerTime.timeNow();

                if (bllTqbSlabLen.Update(model))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改钢坯定尺信息");//添加操作日志

                    MessageBox.Show("修改成功！");
                 }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
