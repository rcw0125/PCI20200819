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
    /// 2018-04-19 zmc
    /// </summary>
    public partial class FrmQB_JYLB : Form
    {
        Bll_TQB_CHECKTYPE bll = new Bll_TQB_CHECKTYPE();//检验类别
        Bll_TQB_CHARACTER bll_character = new Bll_TQB_CHARACTER();//检验基础数据
        private string strMenuName;
        string max = "";
        public FrmQB_JYLB()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 页面初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB0001_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID); 
            NewMethod();
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
            strMenuName = RV.UI.UserInfo.menuName;
            DataTable dt_max = bll.GetList_Max("").Tables[0];
            max = dt_max.Rows[0]["code"].ToString();

            WaitingFrom.ShowWait("");
            DataTable dt = bll.GetList("").Tables[0];

            gc_JYLB.DataSource = dt;
            gv_JYLB.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_JYLB);
            WaitingFrom.CloseWait();


        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_TypeName.Text.Trim()))
            {
                MessageBox.Show("类别名称不能为空！");
                return;
            }
            DataTable dt = bll.GetList_Name(txt_TypeName.Text.Trim()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("项目名称已存在！");
                return;
            }
            if (string.IsNullOrEmpty(max))
            {
                max = "1";
            }
            else
            {
                max = (Convert.ToInt32(max) + 1).ToString();
            }

            string str = "A" + max;
            Mod_TQB_CHECKTYPE mod = new Mod_TQB_CHECKTYPE();

            mod.C_TYPE_CODE = str;
            mod.C_TYPE_NAME = txt_TypeName.Text.Trim();
            mod.C_REMARK = txt_Remark.Text.Trim();
            mod.C_EMP_ID = RV.UI.UserInfo.UserID;
            try
            {
                if (bll.Add(mod))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加检验类别");//添加操作日志

                    MessageBox.Show("添加成功！");
                }


                NewMethod1();
                NewMethod();

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
                DataRow dr = this.gv_JYLB.GetDataRow(this.gv_JYLB.FocusedRowHandle);
                if (dr==null) return;
                Mod_TQB_CHECKTYPE mod = bll.GetModel(dr["C_ID"].ToString());
                if (bll_character.GetRecordCount(dr["C_ID"].ToString()) > 0)
                {
                    MessageBox.Show("该检验类别正在使用，请勿修改！");
                    return; 

                }
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    mod.N_STATUS = 0;
                    bll.Update(mod);
                    MessageBox.Show("已停用！");
                    NewMethod();

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用检验类别");//添加操作日志
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
            DataRow dr = this.gv_JYLB.GetDataRow(this.gv_JYLB.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                if (bll_character.GetRecordCount(dr["C_ID"].ToString()) == 0)
                {

                    FrmQB_JYLB_EDIT frm = new FrmQB_JYLB_EDIT();
                    frm.id = dr["C_ID"].ToString();
                    frm.name = dr["C_TYPE_NAME"].ToString();
                    frm.remark = dr["C_REMARK"].ToString();
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        frm.Close();
                        NewMethod();
                    }
                }
                else
                {
                    MessageBox.Show("该检验类别正在使用，请勿修改！");
                    NewMethod();
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
                NewMethod1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void NewMethod1()
        {
            ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
        }
    }
}
