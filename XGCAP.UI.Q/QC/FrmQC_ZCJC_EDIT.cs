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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_ZCJC_EDIT : Form
    {

        public FrmQC_ZCJC_EDIT()
        {
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_TRUCK bll = new Bll_TQB_TRUCK();
        public string c_id;
        private void FrmQC_ZCJC_EDIT_Load(object sender, EventArgs e)
        {
            try
            { 
                strMenuName = RV.UI.UserInfo.menuName;

                Mod_TQB_TRUCK mod = bll.GetModel(c_id);
                txt_CH.Text = mod.C_TRUCK_NUM;
                txt_FYPC.Text = mod.C_SHIPMENT_BATCH;
                txt_GZ.Text = mod.C_STL_GRD;
                txt_ZCJS.Text = mod.C_LOADING_QUANTITY;
                txt_ZCQCS.Text = mod.C_CRE_ABRADE;
                txt_ZCQGH.Text = mod.C_CRE_ABRADE_TICK;
                txt_ZCHCS.Text = mod.C_BACK_ABRADE;
                txt_ZCHGH.Text = mod.C_BACK_ABRADE_TICK;
                txt_Remark.Text = mod.C_REMARK;
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

            if (string.IsNullOrEmpty(txt_CH.Text.Trim()))
            {
                MessageBox.Show("车号不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_FYPC.Text.Trim()))
            {
                MessageBox.Show("发运批次不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(txt_GZ.Text.Trim()))
            {
                MessageBox.Show("钢种不能为空！");
                return;
            } 
            try
            {

                Mod_TQB_TRUCK mod = bll.GetModel(c_id);
                mod.D_TRUCK_DT = RV.UI.ServerTime.timeNow();
                mod.C_TRUCK_NUM = txt_CH.Text.Trim();
                mod.C_SHIPMENT_BATCH = txt_FYPC.Text.Trim();
                mod.C_STL_GRD = txt_GZ.Text.Trim();
                mod.C_LOADING_QUANTITY = txt_ZCJS.Text.Trim();
                mod.C_CRE_ABRADE = txt_ZCQCS.Text.Trim();
                mod.C_CRE_ABRADE_TICK = txt_ZCQGH.Text.Trim();
                mod.C_BACK_ABRADE = txt_ZCHCS.Text.Trim();
                mod.C_BACK_ABRADE_TICK = txt_ZCHGH.Text.Trim();
                mod.C_SUPERINTENDENT = RV.UI.UserInfo.UserID;
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                mod.C_REMARK = txt_Remark.Text.Trim();
                bll.Update(mod); 
                MessageBox.Show("保存成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改装车检查信息");//添加操作日志
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
