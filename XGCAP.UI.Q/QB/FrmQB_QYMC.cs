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
    public partial class FrmQB_QYMC : Form
    {
        public FrmQB_QYMC()
        {
            InitializeComponent();
        }
        Bll_TQB_SAMPLING bll = new Bll_TQB_SAMPLING();

        private string strMenuName;
        string max = "";
        string order = "";
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB_QYMC_Load(object sender, EventArgs e)
        {
            NewMethod();

        }

        private void NewMethod()
        {
            try
            {
                WaitingFrom.ShowWait("");
                repositoryItemImageComboBox1.Items.Clear();
                repositoryItemImageComboBox1.Items.Add("质控部", "质控部", -1);
                repositoryItemImageComboBox1.Items.Add("技术中心", "技术中心", -1);
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                DataTable dt_max = bll.GetList_Max("").Tables[0];
                max = dt_max.Rows[0]["max"].ToString();
                order = dt_max.Rows[0]["ord"].ToString();
                DataTable dt = bll.GetList("").Tables[0];

                this.gc_QYMC.DataSource = dt;
                gv_QYMC.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_QYMC);
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
                if (string.IsNullOrEmpty(max))
                {
                    max = "1001";
                }
                else
                {
                    max = (Convert.ToInt32(max) + 1).ToString();
                }
                if (string.IsNullOrEmpty(order))
                {
                    order = "1";
                }
                else
                {
                    order = (Convert.ToInt32(order) + 1).ToString();
                }
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_SAMPLING_NAME", txt_Name.Text);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_SAMPLING", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                Mod_TQB_SAMPLING mod = new Mod_TQB_SAMPLING();
                mod.C_SAMPLING_CODE = "S" + max;
                mod.C_SAMPLING_NAME = txt_Name.Text.Trim();
                mod.N_SAMPLING_SN = Convert.ToDecimal(order);
                mod.C_CHECK_DEPMT = cbo_jcbm.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                bll.Add(mod);
                MessageBox.Show("添加成功！");
                FrmQB_QYMC_Load(null, null);
                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加取样名称");//添加操作日志

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
                    DataRow dr = this.gv_QYMC.GetDataRow(this.gv_QYMC.FocusedRowHandle);
                    if (dr == null) return;
                    Mod_TQB_SAMPLING mod = bll.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    bll.Update(mod);
                    MessageBox.Show("已停用！");
                    FrmQB_QYMC_Load(null, null);

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用取样名称信息");//添加操作日志
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
             
                DataRow dr = this.gv_QYMC.GetDataRow(this.gv_QYMC.FocusedRowHandle);
                if (dr == null) return;
                try
                {
                    FrmQB_QYMC_EDIT frm = new FrmQB_QYMC_EDIT();
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
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
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
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            NewMethod();
        }
    }
}
