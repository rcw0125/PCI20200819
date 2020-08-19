using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XGCAP.UI.Q.QB;
using BLL;
using MODEL;
using Common;
namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_CGSYGL_Add : Form
    {
        public FrmQC_CGSYGL_Add()
        {
            InitializeComponent();
        }
        private string strMenuName;
        CommonSub common = new CommonSub();
        private void FrmQC_CGSYGL_Add_Load(object sender, EventArgs e)
        {
            try
            {
                common.ImageComboBoxEditBindGWByGXstr("'ZX'", imgcbo_Plant);
                strMenuName = RV.UI.UserInfo.menuName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        Bll_TRC_ROLL_MAIN bll_trc_roll_main = new Bll_TRC_ROLL_MAIN();
        Bll_TQB_STD_MAIN bll_stdmain = new Bll_TQB_STD_MAIN();
        /// <summary>
        /// 钢种选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fil_STlGRD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_GZ frm = new FrmQB_SELECT_GZ("");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    fil_STlGRD.Text = frm.str_c_grd;
                    frm.Close();
                    NewMethod();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewMethod()
        {
            DataSet dt = bll_stdmain.GetList_Std("", fil_STlGRD.Text);
            imgcbo_STD.Properties.Items.Clear();
            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imgcbo_STD.Properties.Items.Add(item["C_STD_CODE"].ToString(), item["C_STD_CODE"], -1);
            }
            imgcbo_STD.SelectedIndex = 0;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {

            //if (string.IsNullOrEmpty(txt_Stove.Text.Trim()))
            //{
            //    MessageBox.Show("炉号不能为空！");
            //    return;
            //}
            if (string.IsNullOrEmpty(txt_Batch.Text.Trim()))
            {
                MessageBox.Show("批号不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(fil_STlGRD.Text.Trim()))
            {
                MessageBox.Show("钢种不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Spec.Text.Trim()))
            {
                MessageBox.Show("规格不能为空！");
                return;
            }
            if (Convert.ToDecimal(txt_Spec.Text.Trim()) == 0)
            {
                MessageBox.Show("规格不能为0！");
                return;
            }

            try
            {
                Mod_TRC_ROLL_MAIN mod = new Mod_TRC_ROLL_MAIN();
                mod.C_STA_ID = imgcbo_Plant.EditValue?.ToString();
                mod.C_STOVE = txt_Stove.Text.Trim();
                mod.C_BATCH_NO = txt_Batch.Text.Trim();
                mod.C_STL_GRD = fil_STlGRD.Text.Trim();
                mod.C_STD_CODE = imgcbo_STD.Text.Trim();
                if (!txt_Spec.Text.Contains("φ"))
                {
                    mod.C_SPEC = "φ" + txt_Spec.Text;
                }
                else
                {
                    mod.C_SPEC = txt_Spec.Text;
                } 
                mod.N_QUA_TOTAL_VIRTUAL = Convert.ToDecimal(txt_Count.Text.Trim());
                mod.N_WGT_TOTAL_VIRTUAL = Convert.ToDecimal(txt_WGT.Text.Trim());
                mod.C_SHIFT = txt_BC.Text.Trim();
                mod.C_GROUP = txt_BZ.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();

                mod.C_REMARK = "手动添加请勿删除！！";
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_BATCH_NO", mod.C_BATCH_NO); 
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TRC_ROLL_MAIN", ht) > 0)
                {
                    MessageBox.Show("批号已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (bll_trc_roll_main.Add(mod))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加组批实绩");//添加操作日志

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
    }
}
