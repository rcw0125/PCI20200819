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
    public partial class FrmQB_HLYQ_EDIT : Form
    {
        private string strMenuName;
        public string c_id;
        string strPhyCode = "";
        public FrmQB_HLYQ_EDIT(string sys_id)
        {
            InitializeComponent();
            strPhyCode = sys_id;
        }

        Bll_TQB_COOL bll_cool = new Bll_TQB_COOL();
        Bll_TQB_STD_MAIN bll_stdmain = new Bll_TQB_STD_MAIN();
        Bll_TQB_COOL_BASIC bll_CoolBasic = new Bll_TQB_COOL_BASIC();


        private void FrmQB_HLYQ_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;

            txt_Type.ReadOnly = true;
            txt_Heat.ReadOnly = true;
            txt_Hot.ReadOnly = true;
            txt_cooldate.ReadOnly = true;
            txt_CoolCraft.ReadOnly = true;

            DataSet dt = bll_CoolBasic.GetList("");
            imcbo_CoolCode.Properties.Items.Clear();
            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imcbo_CoolCode.Properties.Items.Add(item["C_COOL_CRAFT_CODE"].ToString(), item["C_ID"], -1);
            }

            Mod_TQB_COOL mod = bll_cool.GetModel(c_id);
            imcbo_CoolCode.EditValue = mod.C_COOL_BASIC_ID;
            fil_STlGRD.Text = mod.C_STL_GRD;
            txt_Remark.Text = mod.C_REMARK;

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(fil_STlGRD.Text.Trim()))
            {
                MessageBox.Show("钢种不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(imcbo_CoolCode.Text.Trim()))
            {
                MessageBox.Show("缓冷工艺代码不能为空！");
                return;
            }

            try
            {
                Mod_TQB_COOL mod = bll_cool.GetModel(c_id);
                mod.C_COOL_BASIC_ID = imcbo_CoolCode.EditValue.ToString();
                mod.C_STL_GRD = fil_STlGRD.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_IS_BXG = strPhyCode;
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_ID", c_id);
                ht.Add("C_STL_GRD", fil_STlGRD.Text.Trim()); 
                ht.Add("C_COOL_BASIC_ID", mod.C_COOL_BASIC_ID); 
                ht.Add("C_IS_BXG", strPhyCode);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_COOL", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                bll_cool.Update(mod);
                MessageBox.Show("保存成功！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改缓冷要求");//添加操作日志
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
        /// 钢种选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fil_STlGRD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_GZ frm = new FrmQB_SELECT_GZ(strPhyCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    fil_STlGRD.Text = frm.str_c_grd;
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        /// <summary>
        /// 获取缓冷要求基础数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imcbo_CoolCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mod_TQB_COOL_BASIC mod = bll_CoolBasic.GetModel(imcbo_CoolCode.EditValue.ToString());
            if (mod != null)
            {
                txt_Type.Text = mod.C_TYPE;
                txt_Heat.Text = mod.C_HEAT;
                txt_Hot.Text = mod.C_HOT_T;
                txt_cooldate.Text = mod.N_COOL_DT.ToString();
                txt_CoolCraft.Text = mod.C_COOL_CRAFT;
                txt_Remark.Text = mod.C_REMARK;
            }
            else
            {
                txt_Type.Text = null;
                txt_Heat.Text = null;
                txt_Hot.Text = null;
                txt_cooldate.Text = null;
                txt_CoolCraft.Text = null;
                txt_Remark.Text = null;
            }
        }
    }
}
