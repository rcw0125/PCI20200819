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
    public partial class FrmQB_XNJYGC_EDIT : Form
    {

        public FrmQB_XNJYGC_EDIT()
        {
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_PHYSICS_GROUP bll_group = new Bll_TQB_PHYSICS_GROUP();
        Bll_TQB_XN_CHECK_PROCEDURE bll_xn_proce = new Bll_TQB_XN_CHECK_PROCEDURE();
        Bll_TQB_SAMPLING_GROUP bll_SAMPLING_GROUP = new Bll_TQB_SAMPLING_GROUP();
        public string c_id;
        private void FrmQB_XNJYGC_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            DataSet ds = bll_group.GetList("");
            imgcbo_Name.Properties.Items.Clear(); 
            foreach (DataRow item in ds.Tables[0].Rows)//性能名称下拉框绑定
            {
                imgcbo_Name.Properties.Items.Add(item["C_NAME"].ToString(), item["C_ID"], -1); 
            }
            Mod_TQB_XN_CHECK_PROCEDURE mod = bll_xn_proce.GetModel(c_id); 
            imgcbo_Name.EditValue = mod.C_PHYSICS_GROUP_ID;
            txt_Order.Text = mod.N_ORDER.ToString();
            imgcbo_QYMC.Text = mod.C_DESC;
            txt_XMMX.Text = mod.C_DESC_ITEM;

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
            //if (string.IsNullOrEmpty(imgcbo_QYMC.Text.Trim()))
            //{
            //    MessageBox.Show("项目类别不能为空！");
            //    return;
            //}
            if (string.IsNullOrEmpty(txt_Order.Text.Trim()))
            {
                MessageBox.Show("顺序号不能为空！");
                return;
            }

            try
            {
                Mod_TQB_XN_CHECK_PROCEDURE mod = bll_xn_proce.GetModel(c_id);
                mod.C_PHYSICS_GROUP_ID = imgcbo_Name.EditValue.ToString();
                mod.C_NAME = "(" + imgcbo_QYMC.Text.Trim() + ")" + txt_XMMX.Text.Trim();
                mod.C_DESC_ITEM = txt_XMMX.Text.Trim();
                mod.N_ORDER = Convert.ToInt32(txt_Order.Text.Trim());
                mod.C_DESC = imgcbo_QYMC.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_ID", mod.C_ID);
                ht.Add("C_PHYSICS_GROUP_ID", mod.C_PHYSICS_GROUP_ID);
                ht.Add("C_NAME", mod.C_NAME);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_XN_CHECK_PROCEDURE", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (bll_xn_proce.Update(mod))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改性能检验过程量信息");//添加操作日志

                    MessageBox.Show("保存成功！");
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
        /// <summary>
        /// 项目类别下拉框绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imgcbo_Name.Text.ToString() == "")
            {
                imgcbo_QYMC.Properties.Items.Clear();
                return;
            }
            DataSet ds = bll_SAMPLING_GROUP.GetList_Group(imgcbo_Name.EditValue.ToString());
            imgcbo_QYMC.Properties.Items.Clear();
            imgcbo_QYMC.Properties.Items.Add("", "", -1);
            foreach (DataRow item in ds.Tables[0].Rows)//性能名称下拉框绑定
            {
                imgcbo_QYMC.Properties.Items.Add(item["C_NAME"].ToString(), item["C_ID"], -1);
            }
        }
    }
}
