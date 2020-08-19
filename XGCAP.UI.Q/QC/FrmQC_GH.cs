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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_GH : Form
    {
        public FrmQC_GH()
        {
            InitializeComponent();
        }
        Bll_TPB_HOOK bll_hook = new Bll_TPB_HOOK();
        CommonSub common = new CommonSub();
        private string strMenuName;
        private void FrmQC_GH_Load(object sender, EventArgs e)
        {
            try
            {

                common.ImageComboBoxEditBindGWByGXstr("'ZX'", imgcbo_CX);
                imgcbo_CX.SelectedIndex = 0;
                strMenuName = RV.UI.UserInfo.menuName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            NewMethod();
        }
        /// <summary>
        /// 查询
        /// </summary>
        private void NewMethod()
        {
            try
            {
                DataTable dt = bll_hook.GetList_Query("",imgcbo_CX.EditValue.ToString()).Tables[0];
                gc_Hook.DataSource = dt;
                gv_Hook.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Hook);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imgcbo_CX.Text.Trim()))
            {
                MessageBox.Show("产线不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_GH.Text.Trim()))
            {
                MessageBox.Show("钩号不能为空！");
                return;
            }
            if (txt_GH.Text.Trim()=="0")
            {
                MessageBox.Show("钩号不能为0！");
                return;
            }
            try
            {
                Mod_TPB_HOOK mod = new Mod_TPB_HOOK();
                mod.C_STA_ID = imgcbo_CX.EditValue.ToString();
                mod.N_HOOK_NO = Convert.ToInt32(txt_GH.Text.Trim());
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STA_ID", imgcbo_CX.EditValue.ToString());
                ht.Add("N_HOOK_NO", txt_GH.Text.Trim());
                ht.Add("N_STATUS", 1);
                if (Common.CheckRepeat.CheckTable("TPB_HOOK", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (bll_hook.Add(mod))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钩号");//添加操作日志

                    MessageBox.Show("添加成功！");
                    NewMethod();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {

                    DataRow dr = this.gv_Hook.GetDataRow(this.gv_Hook.FocusedRowHandle);
                    if (dr == null)
                    {
                        MessageBox.Show("请选择需要删除的信息！");
                        return;
                    }
                   
                    if (bll_hook.Delete(dr["C_ID"].ToString()))
                    {
                        MessageBox.Show("删除成功！");
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除钩号");//添加操作日志
                        NewMethod(); 
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
