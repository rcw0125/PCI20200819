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
    public partial class FrmQC_LLGPLR_Add : Form
    {
        Bll_TSC_SLAB_MAIN bll = new Bll_TSC_SLAB_MAIN();
        Bll_TSC_SLAB_WLGP_LOG bllWLGP_LOG = new Bll_TSC_SLAB_WLGP_LOG();
        public FrmQC_LLGPLR_Add()
        {
            InitializeComponent();
        }
        private string strMenuName;
        CommonSub commonSub = new CommonSub();
        private void FrmQC_LLGPLR_Add_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            commonSub.ImageComboBoxEditBindGPK(image_Store);
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_LH.Text.Trim()))
            {
                MessageBox.Show("炉号不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Grd.Text.Trim()))
            {
                MessageBox.Show("钢种不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_DM.Text.Trim()))
            {
                MessageBox.Show("断面不能为空！");
                return;
            }
            if (Convert.ToDecimal(txt_DC.Text.Trim()) == 0)
            {
                MessageBox.Show("规格不能为0！");
                return;
            }
            if (Convert.ToDecimal(txt_COU.Text.Trim()) < 0)
            {
                MessageBox.Show("支数不能小于0！");
                return;
            }
            if (string.IsNullOrEmpty(image_Store.Text.Trim()))
            {
                MessageBox.Show("请选择仓库！");
                return;
            }
            try
            {
                for (int i = 0; i < Convert.ToInt16(txt_COU.Text.Trim()); i++)
                {
                    Mod_TSC_SLAB_MAIN mod = new Mod_TSC_SLAB_MAIN();
                    mod.C_STOVE = txt_LH.Text.Trim();
                    mod.C_MAT_CODE = btn_mat_code.Text.Trim();
                    mod.C_MAT_NAME = txt_mat_name.Text.Trim();
                    mod.C_STL_GRD = txt_Grd.Text.Trim();
                    mod.C_STD_CODE = txt_Std.Text.Trim();
                    mod.C_SPEC = txt_DM.Text.Trim();
                    mod.N_LEN = Convert.ToDecimal(txt_DC.Text.Trim());
                    mod.N_WGT = Convert.ToDecimal(txt_DZ.Text.Trim());
                    mod.C_SLABWH_CODE = image_Store.EditValue.ToString();
                    mod.C_ZYX1 = txt_ZYX1.Text.Trim();
                    mod.C_ZYX2 = txt_ZYX2.Text.Trim();
                    mod.C_CCM_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_CCM_DATE = RV.UI.ServerTime.timeNow();
                    mod.C_SLAB_TYPE = "R";
                    mod.C_MOVE_TYPE = "M";
                    mod.C_STOCK_STATE = "F";
                    mod.C_MAT_TYPE = "合格品";
                    mod.C_JUDGE_LEV_ZH = "合格品";
                    mod.C_IS_PD = "Y";
                    mod.C_IS_QR = "Y";
                    mod.C_IS_TB = "Y";
                    mod.C_SLAB_TYPE_R = "外来钢坯";
                    if (bll.Add(mod))
                    {
                        Mod_TSC_SLAB_WLGP_LOG mod_LOG = new Mod_TSC_SLAB_WLGP_LOG();
                        mod_LOG.C_STOVE = txt_LH.Text.Trim();
                        mod_LOG.C_MAT_CODE = btn_mat_code.Text.Trim();
                        mod_LOG.C_MAT_NAME = txt_mat_name.Text.Trim();
                        mod_LOG.C_STL_GRD = txt_Grd.Text.Trim();
                        mod_LOG.C_STD_CODE = txt_Std.Text.Trim();
                        mod_LOG.C_SPEC = txt_DM.Text.Trim();
                        mod_LOG.N_LEN = Convert.ToDecimal(txt_DC.Text.Trim());
                        mod_LOG.N_WGT = Convert.ToDecimal(txt_DZ.Text.Trim());
                        mod_LOG.C_SLABWH_CODE = image_Store.EditValue.ToString();
                        mod_LOG.C_EMP_ID = RV.UI.UserInfo.UserID;
                        mod_LOG.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        mod_LOG.C_REMARK = "录入";
                        bllWLGP_LOG.Add(mod_LOG);
                    }

                }
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "外来钢坯添加记录");//添加操作日志 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 回传信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mat_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQC_SELECT_LLGPWL frm = new FrmQC_SELECT_LLGPWL();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btn_mat_code.Text = frm.mat_code;
                    txt_mat_name.Text = frm.mat_name;
                    txt_Grd.Text = frm.stl_grd;
                    txt_Std.Text = frm.std;
                    txt_DM.Text = frm.spec;
                    txt_DC.Text = frm.lennew;
                    txt_ZYX1.Text = frm.zyx1;
                    txt_ZYX2.Text = frm.zyx2;

                    frm.Close();
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
