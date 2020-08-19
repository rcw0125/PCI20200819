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
    /// <summary>
    /// 2018-04-23 zmc
    /// </summary>
    public partial class FrmQB_BZWDLB : Form
    {
        public FrmQB_BZWDLB()
        {
            InitializeComponent();
        }
        Bll_TQB_STD_FILE_TYPE bll = new Bll_TQB_STD_FILE_TYPE();

        private string strMenuName;
        string max = "";
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQA0102_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                DataTable dt = bll.GetList_Max("").Tables[0];
                max = dt.Rows[0]["code"].ToString();
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void NewMethod()
        {
            DataTable dt = bll.GetList("").Tables[0];
            this.gc_BZWDLB.DataSource = dt;
            gv_BZWDLB.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_BZWDLB);
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Type.Text.Trim()))
            {
                MessageBox.Show("文档类别不能为空！");
                return;
            }

            #region 检测是否重复添加
            System.Collections.Hashtable ht = new System.Collections.Hashtable();            
            ht.Add("C_FILE_TYPE_NAME", txt_Type.Text.Trim());
            ht.Add("N_STATUS", "1");
            if (Common.CheckRepeat.CheckTable("TQB_STD_FILE_TYPE", ht) > 0)
            {
                MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            Mod_TQB_STD_FILE_TYPE mod = new Mod_TQB_STD_FILE_TYPE();
            if (string.IsNullOrEmpty(max))
            {
                max = "101";
            }
            else
            {
                max = (Convert.ToInt32(max) + 1).ToString();
            }
            mod.C_FILE_TYPE_CODE ="F"+max;
            mod.C_FILE_TYPE_NAME = txt_Type.Text.Trim();
            mod.C_REMARK = txt_Remark.Text.Trim();
            mod.C_EMP_ID = RV.UI.UserInfo.UserID;
            mod.D_MOD_DT = RV.UI.ServerTime.timeNow();

            try
            {
                bll.Add(mod);
                NewMethod();
                MessageBox.Show("添加成功！");
                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加标准文档类别");//添加操作日志
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
            DataRow dr = this.gv_BZWDLB.GetDataRow(this.gv_BZWDLB.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_BZWDLB_EDIT frm = new FrmQB_BZWDLB_EDIT();
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
            DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    DataRow dr = this.gv_BZWDLB.GetDataRow(this.gv_BZWDLB.FocusedRowHandle);
                    if (dr == null) return;
                    Mod_TQB_STD_FILE_TYPE mod = bll.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    bll.Update(mod);
                    NewMethod();
                    MessageBox.Show("已停用！");

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用标准文档类别");//添加操作日志
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
    }
}
