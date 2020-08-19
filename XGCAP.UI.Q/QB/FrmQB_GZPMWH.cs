using Common;
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

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_GZPMWH : Form
    {
        public FrmQB_GZPMWH()
        {
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_STL_GRD_NAME bll = new Bll_TQB_STL_GRD_NAME();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB_GZPMWH_Load(object sender, EventArgs e)
        {
            try
            {
                strMenuName = RV.UI.UserInfo.menuName;
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewMethod()
        {
            WaitingFrom.ShowWait("");
            DataTable dt = bll.GetList("").Tables[0];
            this.gc_Main.DataSource = dt;
            gv_Main.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Main);
            WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("请输入名称！");
                return;
            }
            try
            {
                Mod_TQB_STL_GRD_NAME mod = new Mod_TQB_STL_GRD_NAME();
                mod.C_NAME = txt_Name.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                mod.N_SORT = Convert.ToDecimal(txt_stor.Text.Trim());
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_NAME", txt_Name.Text.Trim());
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_STL_GRD_NAME", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (bll.Add(mod))
                {
                    MessageBox.Show("添加成功！");
                    NewMethod();
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钢种品名");//添加操作日志
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
                    DataRow dr = gv_Main.GetDataRow(gv_Main.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_STL_GRD_NAME", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用钢种品名");//添加操作日志
                            MessageBox.Show("已停用！");
                            NewMethod();
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
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_Main.GetDataRow(this.gv_Main.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_GZPMWH_EDIT frm = new FrmQB_GZPMWH_EDIT();
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
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
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
    }
}
