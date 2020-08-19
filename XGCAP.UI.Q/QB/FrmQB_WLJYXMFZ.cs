using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_WLJYXMFZ : Form
    {
        Bll_TQB_PHYSICS_GROUP bll = new Bll_TQB_PHYSICS_GROUP();

        private string strMenuName;
        string max = "";
        public FrmQB_WLJYXMFZ()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 页面初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB0002_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;
                
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
                WaitingFrom.ShowWait("");
                NewMethod();
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewMethod()
        {
            DataTable dt_max = bll.GetList_Max().Tables[0];
            max = dt_max.Rows[0]["code"].ToString();
            DataTable dt = bll.GetList(txt_Name1.Text).Tables[0];
            this.gc_wljyfz.DataSource = dt;
            gv_wljyfz.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_wljyfz);
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

                if (string.IsNullOrEmpty(txt_Name.Text.Trim()))
                {
                    MessageBox.Show("项目名称不能为空！");
                    return;
                }
                if (cbo_jcbm.SelectedIndex == -1)
                {
                    MessageBox.Show("检测部门不能为空！");
                    return;
                }
                DataTable dt = bll.GetList_Name(txt_Name.Text.Trim()).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("项目名称已存在！");
                    return;
                }


                Mod_TQB_PHYSICS_GROUP mod = new Mod_TQB_PHYSICS_GROUP();
                if (string.IsNullOrEmpty(max))
                {
                    max = "1";
                }
                else
                {
                    max = (Convert.ToInt32(max) + 1).ToString();
                }

                string str = "R" + max;
                mod.C_CODE = str;
                mod.C_NAME = txt_Name.Text.Trim();
                mod.C_CHECK_DEPMT = cbo_jcbm.Text;
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;


                bll.Add(mod);
                MessageBox.Show("添加成功！");
                NewMethod1();
                NewMethod();
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加物理性能分组信息");//添加操作日志
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
                    DataRow dr = this.gv_wljyfz.GetDataRow(this.gv_wljyfz.FocusedRowHandle);
                    Mod_TQB_PHYSICS_GROUP mod = bll.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    bll.Update(mod);
                    MessageBox.Show("已停用！");
                    NewMethod();

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用物理性能分组信息");//添加操作日志
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
            DataRow dr = this.gv_wljyfz.GetDataRow(this.gv_wljyfz.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_WLJYXMFZ_EDIT frm = new FrmQB_WLJYXMFZ_EDIT();
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
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            NewMethod1();
        }
        /// <summary>
        /// 重置
        /// </summary>
        private void NewMethod1()
        {
            ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
        }
    }
}
