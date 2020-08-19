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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_PJGXWH : Form
    {
        
        public FrmQC_PJGXWH()
        {
            InitializeComponent();
        }
        Bll_TQC_RATING_PROCESS bll = new Bll_TQC_RATING_PROCESS();
        private string strMenuName;
        private void FrmQC_PJGXWH_Load(object sender, EventArgs e)
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
            try
            {
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Query()
        {
            DataTable dt = bll.GetList("").Tables[0]; 
            this.gc_PJGX.DataSource = dt;
            gv_PJGX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_PJGX);
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text.Trim()))
            {
                MessageBox.Show("工序不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Type.Text.Trim()))
            {
                MessageBox.Show("评级项目不能为空！");
                return;
            }
            Mod_TQC_RATING_PROCESS mod = new Mod_TQC_RATING_PROCESS();

           

            mod.C_NAME = txt_Name.Text.Trim();
            mod.C_TYPE = txt_Type.Text.Trim();
            mod.C_REMARK = txt_Remark.Text.Trim();
            mod.C_EMP_ID = RV.UI.UserInfo.UserID;
            mod.D_MOD_DT = RV.UI.ServerTime.timeNow();

            #region 检测是否重复添加    
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add("C_NAME", mod.C_NAME);
            ht.Add("C_TYPE", mod.C_TYPE);
            ht.Add("N_STATUS", "1");
            if (Common.CheckRepeat.CheckTable("TQC_RATING_PROCESS", ht) > 0)
            {
                MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            try
            {
                bll.Add(mod);
                MessageBox.Show("添加成功！");
                Query(); 

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加评级工序");//添加操作日志
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
            DataRow dr = this.gv_PJGX.GetDataRow(this.gv_PJGX.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQC_PJGXWH_Edit frm = new FrmQC_PJGXWH_Edit();
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    Query();
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
            DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    Bll_Common bllCommon = new Bll_Common();

                    DataRow dr = gv_PJGX.GetDataRow(gv_PJGX.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bllCommon.DataDisabled("TQC_RATING_PROCESS", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用工序信息");//添加操作日志
                            Query();
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
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);

        }
    }
}
