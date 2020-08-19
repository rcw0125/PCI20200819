using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_LCP_ADD : Form
    {
        private Bll_TB_MATRL_MAIN bllTbMatrlMain = new Bll_TB_MATRL_MAIN();
        private Bll_TQB_GP_LCP_BASIS bllTqbGpLcpBasis = new Bll_TQB_GP_LCP_BASIS();

        private string str_Plan_Code = "";
        private string strMenuName;

        public FrmQB_LCP_ADD()
        {
            InitializeComponent();
        }

        private void FrmQB_LCP_ADD_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindPlan();
        }

        /// <summary>
        /// 计划信息
        /// </summary>
        private void BindPlan()
        {
            WaitingFrom.ShowWait("");

            str_Plan_Code = "";

            gc_Plan.DataSource = null;

            DataTable dt = bllTbMatrlMain.GetList_LCP("", txt_MatName.Text.Trim(), txt_Grd.Text.Trim(), txt_Spec.Text.Trim()).Tables[0];

            gc_Plan.DataSource = dt;

            SetGridViewRowNum.SetRowNum(gv_Plan);

            WaitingFrom.CloseWait();
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
                FrmQB_SELECT_WL frm = new FrmQB_SELECT_WL();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.Close();

                    bool result = AddLcp(frm.mat_code);

                    if (result)
                    {
                        MessageBox.Show("添加成功！");

                        BindGp(str_Plan_Code);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool AddLcp(string strMatCode)
        {
            Mod_TQB_GP_LCP_BASIS model = new Mod_TQB_GP_LCP_BASIS();
            model.C_MAT_CODE_PLAN = str_Plan_Code;
            model.C_MAT_CODE_GP = strMatCode;
            return bllTqbGpLcpBasis.Add(model);
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
                    DataRow dr = gv_Gp.GetDataRow(gv_Gp.FocusedRowHandle);
                    if (dr != null)
                    {
                        Bll_Common bllCommon = new Bll_Common();

                        if (bllCommon.DataDisabled("TQB_GP_LCP_BASIS", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用联产品信息");//添加操作日志

                            MessageBox.Show("已成功停用！");

                            BindGp(str_Plan_Code);
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

        private void gv_Plan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_Plan.GetDataRow(e.FocusedRowHandle);
            if (dr != null)
            {
                str_Plan_Code = dr["物料编码"].ToString();

                BindGp(str_Plan_Code);
            }
            else
            {
                gc_Gp.DataSource = null;
            }
        }

        /// <summary>
        /// 绑定改判信息
        /// </summary>
        /// <param name="str_MatCode"></param>
        private void BindGp(string str_MatCode)
        {
            DataTable dt = bllTqbGpLcpBasis.Get_Gp_List(str_MatCode).Tables[0];

            gc_Gp.DataSource = dt;

            gv_Gp.Columns["C_ID"].Visible = false;

            SetGridViewRowNum.SetRowNum(gv_Gp);
        }
    }
}
