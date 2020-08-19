using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    /// <summary>
    /// 2018-04-27 zmc
    /// </summary>
    public partial class FrmQB_XMYQ : Form
    {
        string strPhyCode;
        public FrmQB_XMYQ()
        {
            InitializeComponent();
        }
        Bll_TQB_STD_MAIN bll_stdmain = new Bll_TQB_STD_MAIN();
        Bll_TQB_COPING bll_coping = new Bll_TQB_COPING();
        Bll_TQB_COPING_BASIC bll_CopingBasic = new Bll_TQB_COPING_BASIC();
        private void FrmQB_XMYQ_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strPhyCode = RV.UI.QueryString.parameter;
            strMenuName = RV.UI.UserInfo.menuName;
            txt_CraftFlow.ReadOnly = true;
            DataSet dt = bll_CopingBasic.GetList(" C_IS_BXG='"+ strPhyCode + "' ");
            imcbo_CopingCraft.Properties.Items.Clear();
            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imcbo_CopingCraft.Properties.Items.Add(item["C_COPING_CRAFT"].ToString(), item["C_ID"], -1);
            }
        }


        private string strMenuName;

        /// <summary>
        /// 跳转到查询钢种界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_STlGRD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_GZ frm = new FrmQB_SELECT_GZ(strPhyCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnEdite_STlGRD.Text = frm.str_c_grd;
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
            DataSet dt = bll_stdmain.GetList_Std(strPhyCode, btnEdite_STlGRD.Text);
            imgcbo_STD.Properties.Items.Clear();
            imgcbo_STD.Properties.Items.Add("全部", "全部", -1);
            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imgcbo_STD.Properties.Items.Add(item["C_STD_CODE"].ToString(), item["C_STD_CODE"], -1);
            }
            imgcbo_STD.SelectedIndex = 0;   
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            
            NewMethod1();
        }

        private void NewMethod1()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_coping.GetList(strPhyCode,btnEdite_STlGRD1.Text).Tables[0];
                this.gc_Coping.DataSource = dt;
                gv_Coping.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Coping);
                WaitingFrom.CloseWait();
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
        private void txt_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_Coping.GetDataRow(gv_Coping.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_COPING", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用修磨要求");//添加操作日志
                            MessageBox.Show("已停用！");
                            NewMethod1();
                        }
                    }
                }
                else//如果点击“取消”按钮
                {
                    return;
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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btnEdite_STlGRD.Text.Trim()))
                {
                    MessageBox.Show("钢种不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(imgcbo_STD.Text.Trim()))
                {
                    MessageBox.Show("执行标准不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(imcbo_CopingCraft.Text.Trim()))
                {
                    MessageBox.Show("修磨工艺不能为空！");
                    return;
                }
                Mod_TQB_COPING mod = new Mod_TQB_COPING();
                mod.C_COPING_BASIC_ID = imcbo_CopingCraft.EditValue.ToString();
                mod.C_STL_GRD = btnEdite_STlGRD.Text.Trim();
                mod.C_STD_CODE = imgcbo_STD.Text.Trim();
                mod.C_SPCIFICATION_MIN = txt_Min.Text.Trim();
                mod.C_SPCIFICATION_MAX = txt_Max.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_CUSTFILE_NAME = btn_KHMC.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID; 
                mod.C_IS_BXG = strPhyCode;
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STL_GRD", btnEdite_STlGRD.Text.Trim());
                ht.Add("C_STD_CODE", imgcbo_STD.Text.Trim());
                ht.Add("C_SPCIFICATION_MIN", mod.C_SPCIFICATION_MIN);
                ht.Add("C_SPCIFICATION_MAX", mod.C_SPCIFICATION_MAX);
                ht.Add("C_CUSTFILE_NAME", mod.C_CUSTFILE_NAME);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_COPING", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion

                bll_coping.Add(mod);
                NewMethod1();
                MessageBox.Show("添加成功！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加修磨要求");//添加操作日志

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdite_STlGRD1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_GZ frm = new FrmQB_SELECT_GZ(strPhyCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnEdite_STlGRD1.Text = frm.str_c_grd;
                    frm.Close();
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
            DataRow dr = this.gv_Coping.GetDataRow(this.gv_Coping.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_XMYQ_EDIT frm = new FrmQB_XMYQ_EDIT(strPhyCode);
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    NewMethod1();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 获取修磨要求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imcbo_CopingCraft_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mod_TQB_COPING_BASIC mod = bll_CopingBasic.GetModel(imcbo_CopingCraft.EditValue.ToString());
            if (mod != null)
            {
                txt_CraftFlow.Text = mod.C_CRAFT_FLOW;
            }
            else
            {
                txt_CraftFlow.Text = null;
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
    }
}
