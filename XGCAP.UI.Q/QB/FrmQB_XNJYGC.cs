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
    public partial class FrmQB_XNJYGC : Form
    {
        public FrmQB_XNJYGC()
        {
            InitializeComponent();
        }
        Bll_TQB_PHYSICS_GROUP bll_group = new Bll_TQB_PHYSICS_GROUP();
        Bll_TQB_XN_CHECK_PROCEDURE bll_xn_proce = new Bll_TQB_XN_CHECK_PROCEDURE();
        Bll_TQB_SAMPLING_GROUP bll_SAMPLING_GROUP = new Bll_TQB_SAMPLING_GROUP();
        private string strMenuName;


        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB_XNJYGC_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                DataSet ds = bll_group.GetList("");
                imgcbo_Name.Properties.Items.Clear();
                imgcbo_XNMC.Properties.Items.Clear();
                imgcbo_XNMC.Properties.Items.Add("全部", "全部", -1);
                foreach (DataRow item in ds.Tables[0].Rows)//性能名称下拉框绑定
                {
                    imgcbo_Name.Properties.Items.Add(item["C_NAME"].ToString(), item["C_ID"], -1);
                    imgcbo_XNMC.Properties.Items.Add(item["C_NAME"].ToString(), item["C_ID"], -1);
                }
                imgcbo_XNMC.SelectedIndex = 0;
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
            WaitingFrom.ShowWait("");
            NewMethod();
            WaitingFrom.CloseWait();
        }

        private void NewMethod()
        {
            try
            {
                string str = imgcbo_XNMC.EditValue.ToString();
                DataTable dt = bll_xn_proce.GetList_ID(str).Tables[0];
                gc_JYGC.DataSource = dt;
                gv_JYGC.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_JYGC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgcbo_Name.SelectedIndex == -1)
                {
                    MessageBox.Show("性能名称不能为空！");
                    return;
                }
               
                if (string.IsNullOrEmpty(txt_Order.Text.Trim()))
                {
                    MessageBox.Show("顺序号不能为空！");
                    return;
                }

                string max = bll_xn_proce.GetList_MAX();
                if (string.IsNullOrEmpty(max))
                {
                    max = "100";
                }
                else
                {
                    max = (Convert.ToInt32(max) + 1).ToString();
                }

                Mod_TQB_XN_CHECK_PROCEDURE mod = new Mod_TQB_XN_CHECK_PROCEDURE();
                mod.C_ID = "GCL_" + max;
                mod.C_CODE = "000GCL_" + max;
                mod.C_PHYSICS_GROUP_ID = imgcbo_Name.EditValue.ToString();
                if (imgcbo_QYMC.Text.Trim() == "")
                {
                    mod.C_NAME = txt_XMMX.Text.Trim();
                }
                else
                {
                    mod.C_NAME = "(" + imgcbo_QYMC.Text.Trim() + ")" + txt_XMMX.Text.Trim();
                }
                
                mod.C_DESC_ITEM = txt_XMMX.Text.Trim();
                mod.N_ORDER = Convert.ToInt32(txt_Order.Text.Trim());
                mod.C_DESC = imgcbo_QYMC.Text.Trim();
                
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_PHYSICS_GROUP_ID", mod.C_PHYSICS_GROUP_ID);
                ht.Add("C_DESC", mod.C_DESC);
                ht.Add("C_DESC_ITEM", mod.C_DESC_ITEM);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_XN_CHECK_PROCEDURE", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (bll_xn_proce.Add(mod))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加性能检验过程量信息");//添加操作日志
                    MessageBox.Show("添加成功！");
                }
                NewMethod();
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
                imgcbo_QYMC.Properties.Items.Clear();
                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
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
                    DataRow dr = gv_JYGC.GetDataRow(gv_JYGC.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_XN_CHECK_PROCEDURE", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用性能检验过程信息");//添加操作日志
                            NewMethod();
                            MessageBox.Show("已停用！");
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_JYGC.GetDataRow(this.gv_JYGC.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_XNJYGC_EDIT frm = new FrmQB_XNJYGC_EDIT();
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
        /// 项目名称下拉框绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imgcbo_Name.Text.ToString()=="")
            {
                imgcbo_QYMC.Properties.Items.Clear();
                return;
            }
            DataSet ds = bll_SAMPLING_GROUP.GetList_Group(imgcbo_Name.EditValue.ToString());
            imgcbo_QYMC.Properties.Items.Clear();
            imgcbo_QYMC.Properties.Items.Add("", "", -1);
            foreach (DataRow item in ds.Tables[0].Rows)//性能名称下拉框绑定
            {
                imgcbo_QYMC.Properties.Items.Add(item["C_NAME"].ToString(), item["C_ID"], -1);
            } 
        }
    }
}
