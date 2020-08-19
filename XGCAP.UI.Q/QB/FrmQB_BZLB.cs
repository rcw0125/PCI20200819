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
    public partial class FrmQB_BZLB : Form
    {
        public FrmQB_BZLB()
        {
            InitializeComponent();
        }
        Bll_TQB_STD_TYPE bll = new Bll_TQB_STD_TYPE();

        private string strMenuName;
        string max = "";

        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB1001_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;
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
            DataTable dt_max = bll.GetList_Max("").Tables[0];
            max = dt_max.Rows[0]["max"].ToString();
            DataTable dt = bll.GetList("").Tables[0];
            this.gc_BZLB.DataSource = dt;
            gv_BZLB.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_BZLB);
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
                MessageBox.Show("类别名称不能为空！");
                return;
            }

            Mod_TQB_STD_TYPE mod = new Mod_TQB_STD_TYPE();

            if (string.IsNullOrEmpty(max))
            {
                max = "1";
            }
            else
            {
                max = (Convert.ToInt32(max) + 1).ToString();
            }

            mod.C_TYPE_CODE = max;
            mod.C_TYPE_NAME = txt_Name.Text.Trim();
            mod.C_REMARK = txt_Remark.Text.Trim();
            mod.C_EMP_ID = RV.UI.UserInfo.UserID;
            mod.D_MOD_DT = RV.UI.ServerTime.timeNow();

            #region 检测是否重复添加    
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add("C_TYPE_NAME", txt_Name.Text);
            ht.Add("N_STATUS", "1");
            if (Common.CheckRepeat.CheckTable("TQB_STD_TYPE", ht) > 0)
            {
                MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            try
            {
                bll.Add(mod);
                MessageBox.Show("添加成功！");
                NewMethod();
                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加标准类别");//添加操作日志
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
            DataRow dr = this.gv_BZLB.GetDataRow(this.gv_BZLB.FocusedRowHandle);
            if (dr == null) return;
            try
            { 
                FrmQB_BZLB_EDIT frm = new FrmQB_BZLB_EDIT();
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
                    DataRow dr = this.gv_BZLB.GetDataRow(this.gv_BZLB.FocusedRowHandle);
                    //if (dr == null) return;
                    Mod_TQB_STD_TYPE mod = bll.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    bll.Update(mod);
                    MessageBox.Show("已停用！");
                    NewMethod();
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用标准类别");//添加操作日志
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
