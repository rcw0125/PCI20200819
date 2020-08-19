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
    public partial class FrmQB_GYLX_EDIT : Form
    {
        public string strPhyCode;
        public FrmQB_GYLX_EDIT(string str_id)
        {
            InitializeComponent();
            strPhyCode = str_id;
        }
        private string strMenuName;
        private Bll_TQB_ROUTE bllRoute = new Bll_TQB_ROUTE();
        private Bll_TQB_STD_MAIN bllStdMain = new Bll_TQB_STD_MAIN();
        private Bll_TB_SLAB_MATRAL bllSlabMatral = new Bll_TB_SLAB_MATRAL();

        public string c_id;
        string strGYLX = "";
        string strLX = "";
        private void FrmQB_GPDCWH_EDIT_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;


            try
            {
                Mod_TQB_ROUTE mod = bllRoute.GetModel(c_id);

                btnEdit_Std.Text = mod.C_STD_CODE;
                txt_Grd.Text = mod.C_STL_GRD;
                cbo_Type.Text = mod.C_ROUTE_TYPE;
                txt_LX.Text = mod.C_ROUTE_DESC;
                txt_Remark.Text = mod.C_REMARK;
                txt_Spec.Text = mod.C_SPEC;
                btn_KHMC.Text = mod.C_CUSTFILE_NAME;
                strGYLX = txt_LX.Text;
                strLX = mod.C_ROUTE_DESC;
                string[] gylx = strGYLX.Split('>');
                foreach (var item in this.groupControl1.Controls)
                {
                    if (item is DevExpress.XtraEditors.CheckEdit)
                    {
                        if (gylx.Contains(((DevExpress.XtraEditors.CheckEdit)item).Tag.ToString()))
                        {
                            ((DevExpress.XtraEditors.CheckEdit)item).Checked = true;
                        }
                        else
                        {
                            ((DevExpress.XtraEditors.CheckEdit)item).Checked = false;
                        }
                    }
                }

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

            try
            {
                if (string.IsNullOrEmpty(btnEdit_Std.Text.Trim()))
                {
                    MessageBox.Show("请选择执行标准！");
                    return;
                }
                if (string.IsNullOrEmpty(cbo_Type.Text.Trim()))
                {
                    MessageBox.Show("请选择工艺路线类型！");
                    return;
                }
                if (string.IsNullOrEmpty(txt_LX.Text.Trim()))
                {
                    MessageBox.Show("请选择工艺路线！");
                    return;
                }
                Mod_TQB_ROUTE model = bllRoute.GetModel(c_id);
                string[] std;
                if (btnEdit_Std.Text.Contains("Q/XG") || btnEdit_Std.Text.Contains("GB/T"))
                {
                    if (btnEdit_Std.Text.Contains("."))
                    {
                        std = btnEdit_Std.Text.Trim().Split('.');
                        model.C_STD_CODE = std[0];
                    }
                    else
                    {
                        std = btnEdit_Std.Text.Trim().Split('-');
                        model.C_STD_CODE = std[0];
                    }
                }
                else
                {
                    model.C_STD_CODE = btnEdit_Std.Text.Trim();
                }
                model.C_STL_GRD = txt_Grd.Text.Trim();
                model.C_ROUTE_TYPE = cbo_Type.Text.Trim();
                model.C_ROUTE_DESC = txt_LX.Text.Trim();
                model.C_IS_BXG = strPhyCode;
                model.C_SPEC = txt_Spec.Text.Trim();
                model.C_CUSTFILE_NAME = btn_KHMC.Text.Trim();
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                model.C_REMARK = txt_Remark.Text.Trim();
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_ID", c_id);
                ht.Add("C_STD_CODE", model.C_STD_CODE);
                ht.Add("C_STL_GRD", model.C_STL_GRD);
                ht.Add("C_SPEC", model.C_SPEC);
                ht.Add("C_ROUTE_TYPE", model.C_ROUTE_TYPE);
                ht.Add("C_CUSTFILE_NAME", model.C_CUSTFILE_NAME);
                ht.Add("N_STATUS", "1");
                ht.Add("C_IS_BXG", strPhyCode);
                if (Common.CheckRepeat.CheckTable("TQB_ROUTE", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (bllRoute.Update(model))
                {
                    DataTable dt = bllSlabMatral.GetList(model.C_STL_GRD, model.C_STD_CODE, strLX).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Mod_TB_SLAB_MATRAL mod_slab = bllSlabMatral.GetModel(dt.Rows[i]["C_ID"].ToString());
                            mod_slab.C_ROUTE_DESC = txt_LX.Text.Trim();
                            bllSlabMatral.Update(mod_slab);
                        }
                    }

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工艺路线信息");//添加操作日志

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
        /// <summary>
        /// 确定工艺路线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {

                if (chk_TL.Checked == false && chk_HTL.Checked == false)
                {
                    MessageBox.Show("请选择脱硫或混铁炉！");
                    return;
                }
                if (chk_ZL.Checked == false && chk_AOD.Checked == false)
                {
                    MessageBox.Show("请选择转炉或熔化炉！");
                    return;
                }
                if (chk_CC.Checked == false)
                {
                    MessageBox.Show("请选择连铸！");
                    return;
                }
                strGYLX = "";
                if (this.chk_TL.Checked)
                {
                    if (strGYLX.Trim() != "")
                    {
                        strGYLX = strGYLX + ">" + chk_TL.Tag.ToString();
                    }
                    else
                    {
                        strGYLX = chk_TL.Tag.ToString();
                    }

                }
                if (this.chk_HTL.Checked)
                {
                    if (strGYLX.Trim() != "")
                    {
                        strGYLX = strGYLX + ">" + chk_HTL.Tag.ToString();
                    }
                    else
                    {
                        strGYLX = chk_HTL.Tag.ToString();
                    }

                }
                if (this.chk_TLP.Checked)
                {
                    strGYLX = strGYLX + ">" + chk_TLP.Tag.ToString();


                }
                if (this.chk_AOD.Checked)
                {

                    strGYLX = strGYLX + ">" + chk_AOD.Tag.ToString();


                }
                if (this.chk_ZL.Checked)
                {

                    strGYLX = strGYLX + ">" + chk_ZL.Tag.ToString();


                }

                if (this.chk_LF.Checked)
                {

                    strGYLX = strGYLX + ">" + chk_LF.Tag.ToString();


                }

                if (this.chk_RH.Checked)
                {

                    strGYLX = strGYLX + ">" + chk_RH.Tag.ToString();


                }
                if (this.chk_CC.Checked)
                {

                    strGYLX = strGYLX + ">" + chk_CC.Tag.ToString();


                }


                if (this.chk_DFPHL.Checked)
                {
                    strGYLX = strGYLX + ">" + chk_DFPHL.Tag.ToString();
                }



                if (this.chk_KP.Checked)
                {
                    strGYLX = strGYLX + ">" + chk_KP.Tag.ToString();
                }

                if (this.chk_HL.Checked)
                {

                    strGYLX = strGYLX + ">" + chk_HL.Tag.ToString();

                }
                if (this.ckh_PWCFTS2.Checked)
                {

                    strGYLX = strGYLX + ">" + ckh_PWCFTS2.Tag.ToString();


                }

                if (this.ckh_PWCSBTS.Checked)
                {

                    strGYLX = strGYLX + ">" + ckh_PWCSBTS.Tag.ToString();


                }

                if (this.chk_PWCSBCFTS.Checked)
                {
                    strGYLX = strGYLX + ">" + chk_PWCSBCFTS.Tag.ToString();
                }


                if (this.chk_XM.Checked)
                {
                    strGYLX = strGYLX + ">" + chk_XM.Tag.ToString();

                }
                if (this.ckh_PWCFTS.Checked)
                {

                    strGYLX = strGYLX + ">" + ckh_PWCFTS.Tag.ToString();


                }

                if (this.chk_ZZ.Checked)
                {
                    strGYLX = strGYLX + ">" + chk_ZZ.Tag.ToString();

                }

                this.txt_LX.Text = strGYLX;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 脱硫
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_TL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_TL.Checked)
                {
                    chk_TL.ForeColor = Color.Red;
                }
                else
                {
                    chk_TL.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 混铁炉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_HTL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_HTL.Checked)
                {
                    chk_HTL.ForeColor = Color.Red;
                }
                else
                {
                    chk_HTL.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 脱磷
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_TLP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_TLP.Checked)
                {
                    chk_TLP.ForeColor = Color.Red;
                }
                else
                {
                    chk_TLP.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// AOD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_AOD_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_AOD.Checked)
                {
                    chk_ZL.Checked = false;
                }

                if (chk_AOD.Checked)
                {
                    chk_AOD.ForeColor = Color.Red;
                }
                else
                {
                    chk_AOD.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 转炉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_ZL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_ZL.Checked)
                {
                    chk_AOD.Checked = false;
                }
                if (chk_ZL.Checked)
                {
                    chk_ZL.ForeColor = Color.Red;
                }
                else
                {
                    chk_ZL.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 精炼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_LF_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_ZL.Checked)
                {
                    chk_LF.ForeColor = Color.Red;
                }
                else
                {
                    chk_LF.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 过真空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_RH_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_RH.Checked)
                {
                    chk_RH.ForeColor = Color.Red;
                }
                else
                {
                    chk_RH.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 连铸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_CC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_CC.Checked)
                {
                    chk_CC.ForeColor = Color.Red;
                }
                else
                {
                    chk_CC.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 大方坯缓冷
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_DFPHL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_DFPHL.Checked)
                {
                    chk_DFPHL.ForeColor = Color.Red;
                }
                else
                {
                    chk_DFPHL.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        /// <summary>
        /// 开坯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_KP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_KP.Checked)
                {
                    chk_KP.ForeColor = Color.Red;
                }
                else
                {
                    chk_KP.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 缓冷
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_HL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_HL.Checked)
                {
                    chk_HL.ForeColor = Color.Red;
                }
                else
                {
                    chk_HL.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 修磨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_XM_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_XM.Checked)
                {
                    chk_XM.ForeColor = Color.Red;
                }
                else
                {
                    chk_XM.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 轧制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_ZZ_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_ZZ.Checked)
                {
                    chk_ZZ.ForeColor = Color.Red;
                }
                else
                {
                    chk_ZZ.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 执行标准选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Std_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_ZXBZ frm = new FrmQB_SELECT_ZXBZ(strPhyCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnEdit_Std.Text = frm.str_STD;
                    txt_Grd.Text = frm.str_GRD;
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        /// <summary>
        /// 抛丸磁粉探伤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckh_PWCFTS2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ckh_PWCFTS2.Checked)
                {
                    ckh_PWCSBTS.Checked = false;
                    chk_PWCSBCFTS.Checked = false;
                }

                if (ckh_PWCFTS2.Checked)
                {
                    ckh_PWCFTS2.ForeColor = Color.Red;
                }
                else
                {
                    ckh_PWCFTS2.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 抛丸超声波探伤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckh_PWCSBTS_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ckh_PWCSBTS.Checked)
                {
                    ckh_PWCFTS2.Checked = false;
                    chk_PWCSBCFTS.Checked = false;
                }

                if (ckh_PWCSBTS.Checked)
                {
                    ckh_PWCSBTS.ForeColor = Color.Red;
                }
                else
                {
                    ckh_PWCSBTS.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 抛丸磁粉探伤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ckh_PWCFTS_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ckh_PWCFTS.Checked)
                {
                    ckh_PWCFTS.ForeColor = Color.Red;
                }
                else
                {
                    ckh_PWCFTS.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chk_PWCSBCFTS_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_PWCSBCFTS.Checked)
                {
                    ckh_PWCSBTS.Checked = false;
                    ckh_PWCFTS2.Checked = false;
                }

                if (chk_PWCSBCFTS.Checked)
                {
                    chk_PWCSBCFTS.ForeColor = Color.Red;
                }
                else
                {
                    chk_PWCSBCFTS.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
