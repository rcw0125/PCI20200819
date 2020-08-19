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

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_GYLX : Form
    {
        private Bll_TQB_ROUTE bllRoute = new Bll_TQB_ROUTE();
        private Bll_TQB_STD_MAIN bllStdMain = new Bll_TQB_STD_MAIN();

        private string strMenuName;
        string strPhyCode;

        public FrmQB_GYLX()
        {
            InitializeComponent();
        }

        private void FrmQB_GYLX_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strPhyCode = RV.UI.QueryString.parameter;

        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                BindList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void BindList()
        {
            try
            {
                gc_Route.DataSource = null;
                string RH = "";
                string DHL = "";
                string KP = "";
                string HL = "";
                string XM = "";
                if (chk_RH1.Checked)
                {
                    RH = "RH";
                }
                if (chk_DFPHL1.Checked)
                {
                    DHL = "DHL";
                }
                if (chk_KP1.Checked)
                {
                    KP = "KP";
                }
                if (chk_HL1.Checked)
                {
                    HL = "HL";
                }
                if (chk_XM1.Checked)
                {
                    XM = "XM";
                }
                WaitingFrom.ShowWait("");
                DataTable dt = bllRoute.GetList(RH, DHL, KP, HL, XM, txt_Std_Query.Text.Trim(), txt_Grd1.Text.Trim(), strPhyCode).Tables[0];

                gc_Route.DataSource = dt;
                gv_Route.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Route);
                WaitingFrom.CloseWait();
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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否保存？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
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
                    Mod_TQB_ROUTE model = new Mod_TQB_ROUTE();
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
                    model.C_SPEC = txt_Spec.Text.Trim();
                    model.C_CUSTFILE_NAME = btn_KHMC.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.C_REMARK = txt_Remark.Text.Trim();
                    model.C_IS_BXG = strPhyCode;
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
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
                    if (bllRoute.Add(model))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加工艺路线信息");//添加操作日志

                        MessageBox.Show("添加成功！");
                        BindList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else//如果点击“取消”按钮
            {
                return;
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
        /// 停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    Bll_Common bllCommon = new Bll_Common();

                    DataRow dr = gv_Route.GetDataRow(gv_Route.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bllCommon.DataDisabled("tqb_route", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用工艺路线信息");//添加操作日志
                            BindList();
                            MessageBox.Show("已成功停用！");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else//如果点击“取消”按钮
            {
                return;
            }



        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            btnEdit_Std.Text = "";
            txt_Grd.Text = "";
            cbo_Type.SelectedIndex = 0;
            txt_LX.Text = "";
            txt_Remark.Text = "";
            try
            {
                foreach (var item in this.groupControl1.Controls)
                {
                    if (item is DevExpress.XtraEditors.CheckEdit)
                    {

                        ((DevExpress.XtraEditors.CheckEdit)item).Checked = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        string strGYLX = "";

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

        private void chk_RHL_CheckedChanged(object sender, EventArgs e)
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
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_Route.GetDataRow(this.gv_Route.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_GYLX_EDIT frm = new FrmQB_GYLX_EDIT(strPhyCode);
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    BindList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 选择客户信息
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
