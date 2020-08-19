using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using Common;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_TSXXWH : Form
    {
        public FrmQC_TSXXWH()
        {
            InitializeComponent();
        }
        string strMenuName;
        Bll_TQC_SPECIFIC_CONTENT bllSpecificContent = new Bll_TQC_SPECIFIC_CONTENT();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC_TSXX_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            Query();
        } 
        /// <summary>
        /// 查询
        /// </summary>
        private void Query()
        {
            try
            { 
                WaitingFrom.ShowWait("");

                DataTable dt = bllSpecificContent.GetList("").Tables[0];

                gc_TSXX.DataSource = dt;
                gv_TSXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_TSXX);

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
            if (string.IsNullOrEmpty(txt_LRBM.Text.Trim()))
            {
                MessageBox.Show("内容不能为空！");
                return;
            }

            Mod_TQC_SPECIFIC_CONTENT mod = new Mod_TQC_SPECIFIC_CONTENT(); 
            mod.C_LR_BM = txt_QXBM.Text.Trim();
            mod.C_CONTENT = txt_Content.Text.Trim();
            mod.C_QX_BM = txt_LRBM.Text.Trim();
            mod.C_REMARK = txt_QXBM.Text.Trim();
            mod.C_EMP_ID = RV.UI.UserInfo.UserID;
            mod.D_MOD_DT = RV.UI.ServerTime.timeNow();

            #region 检测是否重复添加    
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add("C_LR_BM", txt_LRBM.Text);
            ht.Add("C_CONTENT", txt_LRBM.Text);
            ht.Add("C_QX_BM", txt_LRBM.Text); 
            ht.Add("N_STATUS", "1");
            if (Common.CheckRepeat.CheckTable("TQC_SPECIFIC_CONTENT", ht) > 0)
            {
                MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            try
            {
                bllSpecificContent.Add(mod);
                MessageBox.Show("添加成功！");
                Query();
                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加特殊信息");//添加操作日志
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
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_TSXX.GetDataRow(gv_TSXX.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQC_SPECIFIC_CONTENT", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用特殊信息");//添加操作日志
                            MessageBox.Show("已停用！");
                            Query();
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
