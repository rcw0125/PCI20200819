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
    public partial class FrmQB_XMGYWH : Form
    {
        public FrmQB_XMGYWH()
        {
            InitializeComponent();
        }
        private string strMenuName;
        private string strPhyCode;
        Bll_TQB_COPING_BASIC bll = new Bll_TQB_COPING_BASIC();
        private void FrmQB_XMGYWH_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID); 
            strPhyCode = RV.UI.QueryString.parameter;
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
                DataTable dt = bll.GetList_CopingCraft(txt_CopingCraft1.Text.Trim(), strPhyCode).Tables[0];
                gc_Coping.DataSource = dt;
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
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CopingCraft.Text.Trim()))
            {
                MessageBox.Show("修磨工艺不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_CraftFlow.Text.Trim()))
            {
                MessageBox.Show("工艺流程不能为空！");
                return;
            }

            try
            {
                Mod_TQB_COPING_BASIC mod = new Mod_TQB_COPING_BASIC();

                mod.C_COPING_CRAFT = txt_CopingCraft.Text.Trim();
                mod.C_CRAFT_FLOW = txt_CraftFlow.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.C_IS_BXG = strPhyCode;
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_COPING_CRAFT", txt_CopingCraft.Text.Trim()); 
                ht.Add("C_IS_BXG", strPhyCode);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_COPING_BASIC", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion


                bll.Add(mod);
                MessageBox.Show("保存成功！");
                NewMethod();
                ClearContent.ClearFlowLayoutPanel(panelControl2.Controls);

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加修磨工艺");//添加操作日志
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
                FrmQB_XMGYWH_EDIT frm = new FrmQB_XMGYWH_EDIT(strPhyCode);
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
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_Coping.GetDataRow(gv_Coping.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_COPING_BASIC", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用修磨工艺");//添加操作日志
                            btn_Query_Click(null, null);
                            MessageBox.Show("已停用！");
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
    }
}
