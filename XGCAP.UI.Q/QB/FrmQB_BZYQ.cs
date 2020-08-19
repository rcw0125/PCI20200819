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
    /// 2018-04-26 zmc
    /// </summary>
    public partial class FrmQB_BZYQ : Form
    {
        public FrmQB_BZYQ()
        {
            InitializeComponent();
        }
        Bll_TQB_PACK bll = new Bll_TQB_PACK();

        private string strMenuName;

        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB_BZYQ_Load(object sender, EventArgs e)
        {
            try
            {
                strMenuName = RV.UI.UserInfo.menuName;
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
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
            NewMethod();

        }

        private void NewMethod()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll.GetList(txt_PackName1.Text).Tables[0];
                this.gc_Pack.DataSource = dt;
                gv_Pack.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Pack);
                WaitingFrom.CloseWait();
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
                    DataRow dr = this.gv_Pack.GetDataRow(this.gv_Pack.FocusedRowHandle);
                    Mod_TQB_PACK mod = bll.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    bll.Update(mod);
                    btn_Query_Click(null, null);
                    MessageBox.Show("已停用！");
                    btn_Query_Click(null, null);
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用包装要求");//添加操作日志
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
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_PackCode.Text.Trim()))
            {
                MessageBox.Show("包装类别代码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_PackName.Text.Trim()))
            {
                MessageBox.Show("包装类别名称不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(memo_PackDesc.Text.Trim()))
            {
                MessageBox.Show("包装方式说明不能为空！");
                return;
            }
            try
            {

                Mod_TQB_PACK mod = new Mod_TQB_PACK();
                mod.C_PACK_TYPE_CODE = txt_PackCode.Text.Trim();
                mod.C_PACK_TYPE_NAME = txt_PackName.Text.Trim();
                mod.C_PACK_DESC = memo_PackDesc.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_PACK_TYPE_CODE", mod.C_PACK_TYPE_CODE);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_PACK", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                bll.Add(mod);
                btn_Query_Click(null, null);
                MessageBox.Show("添加成功！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加包装要求");//添加操作日志

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
                txt_PackCode.ReadOnly = false;
                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
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
            DataRow dr = this.gv_Pack.GetDataRow(this.gv_Pack.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_BZYQ_EDIT frm = new FrmQB_BZYQ_EDIT();
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

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_Pack, "包装要求" + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
