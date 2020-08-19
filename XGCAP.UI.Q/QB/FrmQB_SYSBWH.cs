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
    public partial class FrmQB_SYSBWH : Form
    {
        public FrmQB_SYSBWH()
        {
            InitializeComponent();
        }
        Bll_TQB_PHYSICS_EQUIPMENT bll = new Bll_TQB_PHYSICS_EQUIPMENT();
        Bll_TQB_PHYSICS_GROUP bll_group = new Bll_TQB_PHYSICS_GROUP();

        private string strMenuName;

        /// <summary>
        /// 初始加载-查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB_SYSBWH_Load(object sender, EventArgs e)
        {
            NewMethod();

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
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                DataSet ds = bll_group.GetList("");
                imgcbo_Name.Properties.Items.Clear();
                foreach (DataRow item in ds.Tables[0].Rows)//性能名称下拉框绑定
                {
                    imgcbo_Name.Properties.Items.Add(item["C_NAME"].ToString(), item["C_ID"], -1);
                }

                DataTable dt = bll.GetList(txt_Name1.Text.Trim()).Tables[0];
                this.gc_SYSB.DataSource = dt;
                gv_SYSB.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SYSB);
                WaitingFrom.CloseWait();
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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (imgcbo_Name.SelectedIndex==-1)
            {
                MessageBox.Show("性能名称不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Name.Text.Trim()))
            {
                MessageBox.Show("设备名称不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_num.Text.Trim()))
            {
                MessageBox.Show("设备型号不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Code.Text.Trim()))
            {
                MessageBox.Show("设备编码不能为空！");
                return;
            }
            try
            {
               
                Mod_TQB_PHYSICS_EQUIPMENT mod = new Mod_TQB_PHYSICS_EQUIPMENT();
                mod.C_PHYSICS_GROUP_ID = imgcbo_Name.EditValue.ToString();
                mod.C_EQ_NAME = txt_Name.Text.Trim();
                mod.C_EQ_NUMBER = txt_num.Text.Trim();
                mod.C_EQ_CODE = txt_Code.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow(); 
                if (bll.Add(mod))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加实验设备信息");//添加操作日志

                    FrmQB_SYSBWH_Load(null, null);
                    MessageBox.Show("保存成功！");
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
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    Bll_Common bllCommon = new Bll_Common();

                    DataRow dr = gv_SYSB.GetDataRow(gv_SYSB.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bllCommon.DataDisabled("TQB_PHYSICS_EQUIPMENT", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用实验设备信息");//添加操作日志
                            NewMethod();
                            MessageBox.Show("已成功停用！");
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
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_SYSB.GetDataRow(this.gv_SYSB.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_SYSBWH_EDIT frm = new FrmQB_SYSBWH_EDIT();
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    NewMethod();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

