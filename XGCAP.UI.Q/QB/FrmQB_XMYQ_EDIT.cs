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
    public partial class FrmQB_XMYQ_EDIT : Form
    {
        string strPhyCode="";
        public FrmQB_XMYQ_EDIT(string sys_id)
        {
            InitializeComponent();
            strPhyCode = sys_id;
        }
        private string strMenuName;
        Bll_TQB_STD_MAIN bll_stdmain = new Bll_TQB_STD_MAIN();
        Bll_TQB_COPING bll_coping = new Bll_TQB_COPING();
        Bll_TQB_COPING_BASIC bll_CopingBasic = new Bll_TQB_COPING_BASIC();
        public string c_id;
        private void FrmQB_XMYQ_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            Mod_TQB_COPING mod = bll_coping.GetModel(c_id);
            imgcbo_STD.Text = mod.C_STD_CODE;
            DataSet dt = bll_CopingBasic.GetList(" C_IS_BXG='" + strPhyCode + "' ");
            txt_CopingCraft.Properties.Items.Clear();
            foreach (DataRow item in dt.Tables[0].Rows)
            {
                txt_CopingCraft.Properties.Items.Add(item["C_COPING_CRAFT"].ToString(), item["C_ID"], -1);
            }
            txt_CopingCraft.EditValue = mod.C_COPING_BASIC_ID;
            txt_CraftFlow.ReadOnly = true;  
            btnEdite_STlGRD.Text = mod.C_STL_GRD;
            txt_Min.Text = mod.C_SPCIFICATION_MIN;
            txt_Max.Text = mod.C_SPCIFICATION_MAX;
            txt_Remark.Text = mod.C_REMARK;
            NewMethod();


        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(btnEdite_STlGRD.Text.Trim()))
            {
                MessageBox.Show("钢种不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(imgcbo_STD.Text.Trim()))
            {
                MessageBox.Show("执行标准不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_CopingCraft.Text.Trim()))
            {
                MessageBox.Show("修磨工艺不能为空！");
                return;
            }

            try
            {
                Mod_TQB_COPING mod = bll_coping.GetModel(c_id);
                mod.C_COPING_BASIC_ID = txt_CopingCraft.EditValue.ToString();
                mod.C_STL_GRD = btnEdite_STlGRD.Text.Trim();
                mod.C_STD_CODE = imgcbo_STD.Text.Trim();
                mod.C_SPCIFICATION_MIN = txt_Min.Text.Trim();
                mod.C_SPCIFICATION_MAX = txt_Max.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_CUSTFILE_NAME = btn_KHMC.Text.Trim();
                mod.C_IS_BXG = strPhyCode;
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_ID", c_id);
                ht.Add("C_STL_GRD", btnEdite_STlGRD.Text.Trim());
                ht.Add("C_STD_CODE", imgcbo_STD.Text.Trim());
                ht.Add("C_SPCIFICATION_MIN", mod.C_SPCIFICATION_MIN);
                ht.Add("C_SPCIFICATION_MAX", mod.C_SPCIFICATION_MAX); 
                ht.Add("C_CUSTFILE_NAME", mod.C_CUSTFILE_NAME);
                ht.Add("C_IS_BXG", strPhyCode);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_COPING", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                bll_coping.Update(mod);
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改修磨要求");//添加操作日志
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 执行标准下拉框绑定
        /// </summary>
        private void NewMethod()
        {
            DataSet dt = bll_stdmain.GetList_Std(strPhyCode, btnEdite_STlGRD.Text);
            imgcbo_STD.Properties.Items.Clear();
            imgcbo_STD.Properties.Items.Add("全部", "全部", -1);
            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imgcbo_STD.Properties.Items.Add(item["C_STD_CODE"].ToString(), item["C_STD_CODE"], -1);
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
        /// 获取钢种
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdite_STlGRD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_GZ frm = new FrmQB_SELECT_GZ(strPhyCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnEdite_STlGRD.Text = frm.str_c_grd;
                    frm.Close();
                    NewMethod();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 获取工艺要求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_CopingCraft_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mod_TQB_COPING_BASIC mod = bll_CopingBasic.GetModel(txt_CopingCraft.EditValue.ToString());
            if (mod != null)
            {
                txt_CraftFlow.Text = mod.C_CRAFT_FLOW;
            }
            else
            {
                txt_CraftFlow.Text = null;
            }
        }
        /// <summary>
        /// 选择客户名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_KHMC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_KDXX frm = new FrmQB_SELECT_KDXX();
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    this.btn_KHMC.Text = frm.str_NAME;
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         
    }
}
