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
    public partial class FrmQB_GPDCWH : Form
    {
        private Bll_TQB_SLAB_LEN bllTqbSlabLen = new Bll_TQB_SLAB_LEN();
        private Bll_Common bllCommon = new Bll_Common();

        private string strMenuName;


 
        public FrmQB_GPDCWH()
        {
            InitializeComponent();
        }

        private void FrmQB_GPDCWH_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

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
                BindList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BindList()
        {
            WaitingFrom.ShowWait("");
            DataTable dt = bllTqbSlabLen.GetList(txt_Type1.Text).Tables[0];
            gc_Slab.DataSource = dt;
            gv_Slab.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Slab);
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Type.Text.Trim()))
            {
                MessageBox.Show("类别不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Slab.Text.Trim()))
            {
                MessageBox.Show("断面不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Len_Cool.Text.Trim()))
            {
                MessageBox.Show("冷坯参考长度不能为空！");
                return;
            }

            try
            {

                Mod_TQB_SLAB_LEN model = new Mod_TQB_SLAB_LEN();
                model.C_SLAB_SIZE = txt_Slab.Text.Trim();
                model.C_TYPE = txt_Type.Text.Trim();
                model.C_HOT_LEN = txt_Len_Hot.Text.Trim();
                model.C_COLD_LEN = txt_Len_Cool.Text.Trim();
                model.C_THE_WEIGHT = txt_Wgt.Text.Trim();
                model.C_REMARK = txt_Remark.Text.Trim();
                model.C_EMP_ID = RV.UI.UserInfo.userID;

                if (bllTqbSlabLen.Add(model))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钢坯定尺信息");//添加操作日志

                    MessageBox.Show("添加成功！");
                    BindList();
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
        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    DataRow dr = gv_Slab.GetDataRow(gv_Slab.FocusedRowHandle);
                    if (dr == null) return;
                    if (bllCommon.DataDisabled("TQB_SLAB_LEN", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用钢坯定尺信息");//添加操作日志
                        BindList();
                        MessageBox.Show("已成功停用！");
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
        private void btn_Reset_Click(object sender, EventArgs e)
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
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_Slab.GetDataRow(this.gv_Slab.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_GPDCWH_EDIT frm = new FrmQB_GPDCWH_EDIT();
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    BindList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
