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
    public partial class FrmQB_SYSBWH_EDIT : Form
    {


        public FrmQB_SYSBWH_EDIT()
        {

            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_PHYSICS_EQUIPMENT bll = new Bll_TQB_PHYSICS_EQUIPMENT();
        Bll_TQB_PHYSICS_GROUP bll_group = new Bll_TQB_PHYSICS_GROUP();
        public string c_id;
        private void FrmQB_SYSBWH_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            try
            {
                DataSet ds = bll_group.GetList("");
                imgcbo_Name.Properties.Items.Clear();
                foreach (DataRow item in ds.Tables[0].Rows)//性能名称下拉框绑定
                {
                    imgcbo_Name.Properties.Items.Add(item["C_NAME"].ToString(), item["C_ID"], -1);
                }

                Mod_TQB_PHYSICS_EQUIPMENT mod = bll.GetModel(c_id);
                txt_Name.Text = mod.C_EQ_NAME;
                txt_num.Text = mod.C_EQ_NUMBER;
                txt_Code.Text = mod.C_EQ_CODE;
                imgcbo_Name.EditValue = mod.C_PHYSICS_GROUP_ID;
                txt_Remark.Text = mod.C_REMARK;
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {
            if (imgcbo_Name.SelectedIndex == -1)
            {
                MessageBox.Show("性能名称不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Name.Text.Trim()))
            {
                MessageBox.Show("设备名称不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_num.Text.Trim()))
            {
                MessageBox.Show("设备型号不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Code.Text.Trim()))
            {
                MessageBox.Show("设备编码不能为空！");
                return;
            }
            try
            {
                Mod_TQB_PHYSICS_EQUIPMENT mod = bll.GetModel(c_id); 
                mod.C_PHYSICS_GROUP_ID = imgcbo_Name.EditValue.ToString();
                mod.C_EQ_NAME = txt_Name.Text.Trim();
                mod.C_EQ_NUMBER = txt_num.Text.Trim();
                mod.C_EQ_CODE = txt_Code.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();

                if (bll.Update(mod))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改实验设备信息");//添加操作日志

                      
                    MessageBox.Show("保存成功！");
                    this.DialogResult = DialogResult.Cancel;
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
