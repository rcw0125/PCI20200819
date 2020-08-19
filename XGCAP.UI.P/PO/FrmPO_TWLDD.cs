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
using XGCAP.UI.P.PO.APS;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_TWLDD : Form
    {
        public FrmPO_TWLDD()
        {
            InitializeComponent();
        }
        private string strMenuName;
        string Spec = "";
        Bll_TMO_ORDER bll_Order = new Bll_TMO_ORDER();
        Bll_TRP_PLAN_ROLL bll_roll = new Bll_TRP_PLAN_ROLL();
        private void FrmPO_TWLDD_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;
             
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_Order.GetList_TWOrderAdd( txt_GZ.Text.Trim(), txt_STD.Text.Trim()).Tables[0];
                gc_Order.DataSource = dt;
                gv_Order.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Order);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_mat_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                FrmPO_TWLDD_ADD frm = new FrmPO_TWLDD_ADD();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btn_mat_code.Text = frm.str_MatCode;
                    txt_mat_name.Text = frm.str_MatName;
                    txt_STD1.Text = frm.str_STD;
                    txt_Grd.Text = frm.str_STLGRD;
                    txt_ZYX1.Text = frm.str_ZYX1;
                    txt_ZYX2.Text = frm.str_ZYX2;
                    Spec = frm.str_Spec;
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btn_mat_code.Text.Trim()))
            {
                MessageBox.Show("物料编码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_group.Text.Trim()))
            {
                MessageBox.Show("组号不能为空！");
                return;
            }
            try
            {
                Mod_TMO_ORDER mod = new Mod_TMO_ORDER();
                mod.C_ID = System.Guid.NewGuid().ToString();
                mod.C_ORDER_NO = "TW" + RV.UI.ServerTime.timeNow().ToString("yyyyMMddHHmmssfff");
                mod.C_MAT_CODE = btn_mat_code.Text.Trim();
                mod.C_MAT_NAME = txt_mat_name.Text.Trim();
                mod.C_STL_GRD = txt_Grd.Text.Trim();
                mod.C_STD_CODE = txt_STD1.Text.Trim();
                mod.C_FREE1 = txt_ZYX1.Text.Trim();
                mod.C_FREE2 = txt_ZYX2.Text.Trim();
                mod.C_SPEC = Spec;
                mod.N_TYPE = 10;
                mod.C_CUST_NAME = "TW";
                mod.N_WGT = 100;
                mod.N_GROUP =Convert.ToInt32( txt_group.Text);
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.C_EMP_NAME = RV.UI.UserInfo.UserName;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();

                if (bll_Order.Add(mod))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加头尾订单");//添加操作日志

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

                    DataRow dr = this.gv_Order.GetDataRow(this.gv_Order.FocusedRowHandle);
                    if (dr == null)
                    {
                        MessageBox.Show("请选择需要删除的信息！");
                        return;
                    }
                    Mod_TMO_ORDER mod = bll_Order.GetModel(dr["C_ID"].ToString());
                    mod.N_TYPE = 11; 
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    if (bll_Order.Update(mod))
                    {
                        Mod_TRP_PLAN_ROLL modroll= bll_roll.GetModelByOrderNo(mod.C_ORDER_NO);
                        modroll.N_STATUS = 3;
                        bll_roll.Update(modroll);
                        MessageBox.Show("删除成功！");
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除首尾炉订单");//添加操作日志
                        NewMethod();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            btn_mat_code.Text = "";
            txt_mat_name.Text = "";
            txt_STD1.Text ="";
            txt_Grd.Text = "";
            txt_ZYX1.Text = "";
            txt_ZYX2.Text = "";
            Spec = "";
        }
       
        private void btn_order_pj1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否评价该头尾炉计划？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {

                    DataRow dr = this.gv_Order.GetDataRow(this.gv_Order.FocusedRowHandle);
                    if (dr == null)
                    {
                        MessageBox.Show("请选择需要评价的计划！");
                        return;
                    }
                    Mod_TMO_ORDER mod = bll_Order.GetModel(dr["C_ID"].ToString());
                    Cls_Order_PC.OrderPj(mod, "正常");
                    MessageBox.Show("计划已评价");
                    WaitingFrom.ShowWait("数据正在加载，请稍后。。。");
                    NewMethod();
                    WaitingFrom.CloseWait();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

           
        }

        private void btn_pc_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否下达该头尾炉计划？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {

                    DataRow dr = this.gv_Order.GetDataRow(this.gv_Order.FocusedRowHandle);
                    if (dr == null)
                    {
                        MessageBox.Show("请选择需要下达的计划！");
                        return;
                    }
                    Mod_TMO_ORDER mod = bll_Order.GetModel(dr["C_ID"].ToString());
                    Cls_APS_PC.DownOrder(mod.C_ID, mod.N_WGT);
                    MessageBox.Show("计划已下达");
                    WaitingFrom.ShowWait("数据正在加载，请稍后。。。");
                    NewMethod();
                    WaitingFrom.CloseWait();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
