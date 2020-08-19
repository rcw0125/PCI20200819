using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;
using MODEL;

namespace XGCAP.UI.P.PP
{
    public partial class FrmPP_ZJDD : Form
    {
        Bll_TPP_INITIALIZE_ITEM bll_TPP_INITIALIZE_ITEM = new Bll_TPP_INITIALIZE_ITEM();
        private Bll_TPP_PROD_INITIALIZE bll_TPP_PROD_INITIALIZE = new Bll_TPP_PROD_INITIALIZE();//初始化主表（档期表）
        Bll_TB_PRO bll_TB_PRO = new Bll_TB_PRO();
        private Bll_TMO_ORDER bll_TMO_ORDER = new Bll_TMO_ORDER();
        private Bll_TPP_INITIALIZE_ORDER bll_ini_order = new Bll_TPP_INITIALIZE_ORDER();//初始化订单表
        CommonSub commonSub = new CommonSub();

        private string strMenuName;

        public FrmPP_ZJDD()
        {
            InitializeComponent();
        }

        private void FrmPP_ZJDD_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;

            this.dtp_dt1.Text = System.DateTime.Now.ToString("yyyy-MM") + "-01";
            this.dtp_dt2.Text = Convert.ToDateTime(this.dtp_dt1.Text).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
        }

        private void dtp_dt1_TextChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindFABYTIME(cbo_FA, this.dtp_dt1.Text.Trim(), this.dtp_dt2.Text.Trim(), this.radioGroup2.Properties.Items[radioGroup2.SelectedIndex].Description.ToString());
            cbo_FA.SelectedIndex = 0;
        }

        private void dtp_dt2_TextChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindFABYTIME(cbo_FA, this.dtp_dt1.Text.Trim(), this.dtp_dt2.Text.Trim(), this.radioGroup2.Properties.Items[radioGroup2.SelectedIndex].Description.ToString());
            cbo_FA.SelectedIndex = 0;
        }

        private void btnEdit_Std_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                XGCAP.UI.P.PB.FrmPB_SELECT_ZXBZ frm = new XGCAP.UI.P.PB.FrmPB_SELECT_ZXBZ();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnEdit_Std.Text = frm.str_STD;
                    txt_Std_Grd.Text = frm.str_GRD;
                    txt_MatCode.Text = frm.str_MatCode;
                    txt_MatName.Text = frm.str_MatName;
                    txt_Spec.Text = frm.str_Spec;
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
        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_FA.Text.Trim()))
            {
                MessageBox.Show("请选择方案号！");
                return;
            }

            if (string.IsNullOrEmpty(btnEdit_Std.Text.Trim()))
            {
                MessageBox.Show("请选择执行标准！");
                return;
            }

            if (string.IsNullOrEmpty(txt_Std_Grd.Text.Trim()))
            {
                MessageBox.Show("请填写钢种！");
                return;
            }

            if (string.IsNullOrEmpty(cbo_CC.Text.Trim()) || cbo_CC.Text == "全部")
            {
                MessageBox.Show("请选择连铸！");
                return;
            }

            if (string.IsNullOrEmpty(txt_Wgt.Text.Trim()))
            {
                MessageBox.Show("请填写重量！");
                return;
            }
            else
            {
                double result = 0;
                if (!double.TryParse(txt_Wgt.Text.Trim(), out result))
                {
                    MessageBox.Show("填写的重量不符合规范！");
                    return;
                }
            }

            Mod_TMO_ORDER modeOrder = new Mod_TMO_ORDER();
            modeOrder.C_ORDER_NO = "SD-" + DateTime.Now.ToString("yyyyMMddHHmmss");//订单号
            modeOrder.C_CON_NO = "SD-" + DateTime.Now.ToString("yyyyMMddHHmmss");//合同号
            modeOrder.C_STL_GRD = txt_Std_Grd.Text.Trim();//钢种
            modeOrder.C_STD_CODE = btnEdit_Std.Text.Trim();//执行标准
            modeOrder.N_STATUS = 2;//订单状态
            modeOrder.N_WGT = Convert.ToDecimal(txt_Wgt.Text.Trim());//订单重量
            modeOrder.N_TYPE = 6;//6钢坯；8线材
            modeOrder.C_EMP_ID = RV.UI.UserInfo.userID;
            modeOrder.C_MAT_CODE = txt_MatCode.Text.Trim();//物料编码
            modeOrder.C_MAT_NAME = txt_MatName.Text.Trim();//物料名称
            modeOrder.C_SPEC = txt_Spec.Text.Trim();//断面

            if (bll_TMO_ORDER.Add(modeOrder))
            {
                string s_id = bll_TMO_ORDER.Get_ID(modeOrder.C_ORDER_NO, modeOrder.C_CON_NO, modeOrder.C_STL_GRD, modeOrder.C_STD_CODE);

                Mod_TPP_INITIALIZE_ORDER modINITIALIZEORDER = new Mod_TPP_INITIALIZE_ORDER();
                modINITIALIZEORDER.C_INITIALIZE_ID = cbo_FA.EditValue.ToString();
                modINITIALIZEORDER.C_ORDER_ID = s_id;
                modINITIALIZEORDER.N_WGT = Convert.ToDecimal(txt_Wgt.Text.Trim());//订单重量
                modINITIALIZEORDER.C_CCM_STA_ID = cbo_CC.EditValue.ToString();
                modINITIALIZEORDER.C_EMP_ID = RV.UI.UserInfo.userID;
                bll_ini_order.Add(modINITIALIZEORDER);

                MessageBox.Show("订单手动增加成功！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "手动添加订单");//添加操作日志
            }
        }

        private void cbo_FA_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = bll_TB_PRO.GetListByStatus(1, "CC", "").Tables[0];
            if (dt.Rows.Count > 0)
            {
                string cid = dt.Rows[0]["C_ID"].ToString();
                commonSub.BindCCM(cid, cbo_FA.EditValue.ToString(), cbo_CC);
            }
        }
    }
}
