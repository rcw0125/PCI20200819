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
    public partial class FrmQB_BHGYY : Form
    {
        /// <summary>
        /// 2018-04-23 zmc
        /// </summary>
        public FrmQB_BHGYY()
        {
            InitializeComponent();
        }
        Bll_TQB_FAULT_REASON_TYPE bll_type = new Bll_TQB_FAULT_REASON_TYPE();
        Bll_TQB_FAULT_REASON_DETAILS bll_name = new Bll_TQB_FAULT_REASON_DETAILS();

        private string strMenuName;

        /// <summary>
        /// 查询不合格原因类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB0801_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this,RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void NewMethod()
        {

            DataTable dt = bll_type.GetList("").Tables[0];
            this.gc_BHGLX.DataSource = dt;
            gv_BHGLX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_BHGLX);

        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Type.Text.Trim()))
                {
                    MessageBox.Show("原因类型不能为空！", "提示");
                    return;
                }

                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_REASON_TYPE_NAME", txt_Type.Text);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_FAULT_REASON_TYPE", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion

                Mod_TQB_FAULT_REASON_TYPE mod = new Mod_TQB_FAULT_REASON_TYPE();
            
                mod.C_REASON_TYPE_NAME = txt_Type.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                bll_type.Add(mod);
                NewMethod();
                MessageBox.Show("添加成功！", "提示");

                UserLog.AddLog(strMenuName, this.Name, this.Text, "添加不合格原因类型");//添加操作日志

                ClearContent.ClearFlowLayoutPanel(flowLayoutPanel1.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 不合格原因类型停用
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
                    DataRow dr = this.gv_BHGLX.GetDataRow(this.gv_BHGLX.FocusedRowHandle);
                    if (dr == null) return;
                    Mod_TQB_FAULT_REASON_TYPE mod = bll_type.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    bll_type.Update(mod);
                    NewMethod();
                    MessageBox.Show("已停用！", "提示");

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用不合格原因类型");//添加操作日志
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
        /// 查询不合格原因明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_BHGLX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = this.gv_BHGLX.GetDataRow(this.gv_BHGLX.FocusedRowHandle);
                if (dr == null) return;
                string str = dr["C_ID"].ToString();
                DataTable dt = bll_name.GetList("C_REASON_TYPE_ID='" + str + "'").Tables[0];
                this.gc_BHGMC.DataSource = dt;
                gv_BHGMC.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_BHGMC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 不合格原因名称添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NameAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Name.Text.Trim()))
                {
                    MessageBox.Show("原因名称不能为空！", "提示");
                    return;
                }

                DataRow dr = this.gv_BHGLX.GetDataRow(this.gv_BHGLX.FocusedRowHandle);
                if (dr == null) return;

                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_REASON_TYPE_ID", dr["C_ID"].ToString());
                ht.Add("C_REASON_NAME", txt_Name.Text);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_FAULT_REASON_DETAILS", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion

                Mod_TQB_FAULT_REASON_DETAILS mod = new Mod_TQB_FAULT_REASON_DETAILS();
                mod.C_ID = "";
                mod.C_REASON_TYPE_ID = dr["C_ID"].ToString();
                mod.C_REASON_NAME = txt_Name.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                bll_name.Add(mod);
                gv_BHGLX_FocusedRowChanged(null, null);
                MessageBox.Show("添加成功！", "提示");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加不合格原因名称");//添加操作日志

                ClearContent.ClearFlowLayoutPanel(flowLayoutPanel2.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 不合格原因名称停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NameStop_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    DataRow dr = this.gv_BHGMC.GetDataRow(this.gv_BHGMC.FocusedRowHandle);
                    if (dr == null) return;
                    Mod_TQB_FAULT_REASON_DETAILS mod = bll_name.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    bll_name.Update(mod);
                    gv_BHGLX_FocusedRowChanged(null, null);
                    MessageBox.Show("已停用！", "提示");

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用不合格原因名称");//添加操作日志
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
