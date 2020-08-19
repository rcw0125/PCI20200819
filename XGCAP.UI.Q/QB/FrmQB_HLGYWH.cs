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
    public partial class FrmQB_HLGYWH : Form
    {
        public FrmQB_HLGYWH()
        {
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_COOL_BASIC bll = new Bll_TQB_COOL_BASIC();
        private void FrmQB_HLGYWH_Load(object sender, EventArgs e)
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
                DataTable dt = bll.GetList_CraftCode(txt_CoolCode1.Text.Trim()).Tables[0];
                gc_cool.DataSource = dt;
                gv_cool.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_cool);
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
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imgcbo_Type.Text.Trim()))
            {
                MessageBox.Show("类型不能为空！");
                return;
            } 
            if (string.IsNullOrEmpty(txt_CoolCode.Text.Trim()))
            {
                MessageBox.Show("缓冷工艺代码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_CoolCraft.Text.Trim()))
            {
                MessageBox.Show("缓冷工艺不能为空！");
                return;
            }
            try
            {
                Mod_TQB_COOL_BASIC mod = new Mod_TQB_COOL_BASIC();
                mod.C_TYPE = imgcbo_Type.Text.Trim();
                mod.C_COOL_CRAFT_CODE = txt_CoolCode.Text.Trim();
                mod.C_COOL_CRAFT = txt_CoolCraft.Text.Trim();
                mod.N_COOL_DT = Convert.ToInt32(txt_cooldate.Text);
                mod.C_HEAT = imgcbo_Heat.Text.Trim();
                mod.C_HOT_T = txt_Hot.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_COOL_CRAFT_CODE", txt_CoolCode.Text.Trim());
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_COOL_BASIC", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                bll.Add(mod);
                NewMethod();
                MessageBox.Show("保存成功！");

                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加缓冷工艺要求");//添加操作日志 

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
            DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_cool.GetDataRow(gv_cool.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_COOL_BASIC", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用缓冷工艺要求");//添加操作日志
                            MessageBox.Show("已停用！");
                            btn_Query_Click(null, null);
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
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_cool.GetDataRow(this.gv_cool.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_HLGYWH_EDIT frm = new FrmQB_HLGYWH_EDIT();
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
