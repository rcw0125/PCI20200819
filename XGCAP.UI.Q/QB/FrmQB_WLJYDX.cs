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
    public partial class FrmQB_WLJYDX : Form
    {
        public FrmQB_WLJYDX()
        {
            InitializeComponent();
        }
        Bll_TQB_PHYSICS_QUALITATIVE blltqbphysics = new Bll_TQB_PHYSICS_QUALITATIVE();
        Bll_TQB_PHYSICS_GROUP bll_PHYSICS_GROUP = new Bll_TQB_PHYSICS_GROUP();
        Bll_TQB_PHYSICS_CONFIGURE bll_PHYSICS_CONFIGURE = new Bll_TQB_PHYSICS_CONFIGURE();


        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_QB_WLJYDX_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                
                DataSet dt = bll_PHYSICS_GROUP.GetList("");
                imgcbo_XM.Properties.Items.Clear();
                imgcbo_XM1.Properties.Items.Clear();
                imgcbo_XM1.Properties.Items.Add("全部", "全部", -1);
                foreach (DataRow item in dt.Tables[0].Rows)//绑定物理检验项目下拉框
                {
                    imgcbo_XM.Properties.Items.Add(item["C_NAME"].ToString(), item["C_ID"], -1);
                    imgcbo_XM1.Properties.Items.Add(item["C_NAME"].ToString(), item["C_ID"], -1);

                }
                imgcbo_XM1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            NewMethod();
        }
        /// <summary>
        /// 查询
        /// </summary>
        private void NewMethod()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = blltqbphysics.GetList(imgcbo_XM1.EditValue.ToString()).Tables[0];
                this.gc_WLJY.DataSource = dt;
                gv_WLJY.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_WLJY);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 绑定性能名下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_XM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                DataSet dt_wljyxmpz = bll_PHYSICS_CONFIGURE.GetList_Query(imgcbo_XM.EditValue.ToString());

                imgcbo_XNMC.Properties.Items.Clear();
                foreach (DataRow item in dt_wljyxmpz.Tables[0].Rows)//不合格原因下拉框查询
                {
                    imgcbo_XNMC.Properties.Items.Add(item["c_name"].ToString(), item["c_id"], -1);
                }
                imgcbo_XNMC.SelectedIndex = 0;
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

            try
            {
                if (string.IsNullOrEmpty(imgcbo_XNMC.Text.Trim()))
                {
                    MessageBox.Show("性能名称不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(txt_Resulet.Text.Trim()))
                {
                    MessageBox.Show("结果不能为空！");
                    return;
                }

                Mod_TQB_PHYSICS_QUALITATIVE mod = new Mod_TQB_PHYSICS_QUALITATIVE();
                 
                mod.C_PHYSICS_GROUP_ID = imgcbo_XM.EditValue.ToString();
                mod.C_CHARACTER_ID = imgcbo_XNMC.EditValue.ToString();
                mod.C_NAME = imgcbo_XNMC.Text;
                mod.C_RESULT = txt_Resulet.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_CHARACTER_ID", mod.C_CHARACTER_ID);
                ht.Add("C_NAME", mod.C_NAME);
                ht.Add("C_RESULT", mod.C_RESULT);
                ht.Add("N_STATUS", "1");

                if (Common.CheckRepeat.CheckTable("TQB_PHYSICS_QUALITATIVE", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (blltqbphysics.Add(mod))
                {
                    MessageBox.Show("添加成功！");
                    NewMethod();
                    ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
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
                    DataRow dr = gv_WLJY.GetDataRow(gv_WLJY.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_PHYSICS_QUALITATIVE", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
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
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            NewMethod();
        }
    }
}
