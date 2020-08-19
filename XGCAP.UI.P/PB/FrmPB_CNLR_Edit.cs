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
using Common;

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_CNLR_Edit : Form
    {
        public FrmPB_CNLR_Edit()
        {
            InitializeComponent();
        }
        private string strMenuName;
        public string c_id;
        Bll_TB_STA bllSta = new Bll_TB_STA();
        Bll_TPB_STA_CN bllStaCN = new Bll_TPB_STA_CN();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPB_CNLR_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            DataSet dt_sta = bllSta.Get_CN();
            imgcbo_STA.Properties.Items.Clear();
            foreach (DataRow item in dt_sta.Tables[0].Rows)//责任单位下拉框
            {
                imgcbo_STA.Properties.Items.Add(item["C_STA_DESC"].ToString(), item["C_STA_DESC"], -1);
            }
            Mod_TPB_STA_CN mod = bllStaCN.GetModel(c_id);
            dat_Time.DateTime = Convert.ToDateTime(mod.C_DATE);
            txt_CN.Text = mod.C_VALUE;
            imgcbo_STA.Text = mod.C_STA;

        }


        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(imgcbo_STA.Text.Trim()))
            {
                MessageBox.Show("请选择车间");
                return;
            }
            if (string.IsNullOrEmpty(txt_CN.Text.Trim()) || txt_CN.Text == "0")
            {
                MessageBox.Show("请输入产能");
                return;
            }
            try
            {


                Mod_TPB_STA_CN mod = bllStaCN.GetModel(c_id);
                mod.C_DATE = dat_Time.DateTime.ToString("yyyy-MM-dd");
                mod.C_STA = imgcbo_STA.Text.Trim();
                mod.C_VALUE = txt_CN.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_ID", c_id);
                ht.Add("C_DATE", mod.C_DATE);
                ht.Add("C_STA", mod.C_STA);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TPB_STA_CN", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion

                if (bllStaCN.Update(mod))
                {
                    MessageBox.Show("保存成功！");
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工序产能");//添加操作日志 
                    return;
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
