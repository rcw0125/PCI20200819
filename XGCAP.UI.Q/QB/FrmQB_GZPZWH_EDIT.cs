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
    public partial class FrmQB_GZPZWH_EDIT : Form
    {
         
        public FrmQB_GZPZWH_EDIT()
        { 
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_STL_GRD_TYPE bll = new Bll_TQB_STL_GRD_TYPE();
        public string c_id;
        private void FrmQB_BZYQ_EDIT_Load(object sender, EventArgs e)
        { 
            strMenuName = RV.UI.UserInfo.menuName;

            Mod_TQB_STL_GRD_TYPE mod = bll.GetModel(c_id);
            txt_Name.Text = mod.C_TYPE_NAME;
            txt_stor.Text = mod.N_SORT.ToString();
            txt_Remark.Text = mod.C_REMARK; 
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_Name.Text.Trim()))
            {
                MessageBox.Show("名称不能为空！");
                return;
            } 
            try
            {
                Mod_TQB_STL_GRD_TYPE mod = bll.GetModel(c_id);

                mod.C_TYPE_NAME = txt_Name.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                mod.N_SORT = Convert.ToDecimal(txt_stor.Text.Trim());
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_ID",c_id);
                ht.Add("C_TYPE_NAME", txt_Name.Text.Trim());
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_STL_GRD_TYPE", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion 
                if (bll.Update(mod))
                { 
                    MessageBox.Show("保存成功！");

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改钢种品种");//添加操作日志 
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
