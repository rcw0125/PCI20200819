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
    public partial class FrmQB_HLYQ : Form
    {
        /// <summary>
        /// 2018-04-26 zmc
        /// </summary>
        public FrmQB_HLYQ()
        {
            InitializeComponent();
        }
        Bll_TQB_COOL bll_cool = new Bll_TQB_COOL();
        Bll_TQB_STD_MAIN bll_stdmain = new Bll_TQB_STD_MAIN();
        Bll_TQB_COOL_BASIC bll_CoolBasic = new Bll_TQB_COOL_BASIC();
        private string strMenuName;
        string strPhyCode;
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB_HLYQ_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;
                strPhyCode = RV.UI.QueryString.parameter;
                txt_Type.ReadOnly = true;
                txt_Heat.ReadOnly = true;
                txt_Hot.ReadOnly = true;
                txt_cooldate.ReadOnly = true;
                txt_CoolCraft.ReadOnly = true;

                DataSet dt = bll_CoolBasic.GetList("");
                imcbo_CoolCode.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)
                {
                    imcbo_CoolCode.Properties.Items.Add(item["C_COOL_CRAFT_CODE"].ToString(), item["C_ID"], -1);
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
            NewMethod1();

        }

        private void NewMethod1()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_cool.GetList(strPhyCode, fil_STlGRD1.Text).Tables[0];
                this.gc_cool.DataSource = dt;
                gv_cool.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_cool);
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
        private void txt_Stop_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_cool.GetDataRow(gv_cool.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_COOL", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用缓冷要求");//添加操作日志
                            MessageBox.Show("已停用！");
                            btn_Query_Click(null, null);
                        }
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
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fil_STlGRD.Text.Trim()))
            {
                MessageBox.Show("钢种不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(imcbo_CoolCode.Text.Trim()))
            {
                MessageBox.Show("缓冷工艺代码不能为空！");
                return;
            }

            try
            {
                Mod_TQB_COOL mod = new Mod_TQB_COOL();

                mod.C_COOL_BASIC_ID = imcbo_CoolCode.EditValue.ToString();
                mod.C_STL_GRD = fil_STlGRD.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.C_IS_BXG = strPhyCode;
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STL_GRD", fil_STlGRD.Text.Trim());
                ht.Add("C_COOL_BASIC_ID", imcbo_CoolCode.EditValue.ToString());
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_COOL", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                bll_cool.Add(mod);
                btn_Query_Click(null, null);
                MessageBox.Show("保存成功！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加缓冷要求");//添加操作日志 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 跳转到钢种查询页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_STlGRD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_GZ frm = new FrmQB_SELECT_GZ(strPhyCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    fil_STlGRD.Text = frm.str_c_grd;
                    frm.Close();
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

        private void fil_STlGRD1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_GZ frm = new FrmQB_SELECT_GZ(strPhyCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    fil_STlGRD1.Text = frm.str_c_grd;
                    frm.Close();
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
            DataRow dr = this.gv_cool.GetDataRow(this.gv_cool.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQB_HLYQ_EDIT frm = new FrmQB_HLYQ_EDIT(strPhyCode);
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    NewMethod1();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 获取缓冷工艺基础数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imcbo_CoolCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Mod_TQB_COOL_BASIC mod = bll_CoolBasic.GetModel(imcbo_CoolCode.EditValue.ToString());
                if (mod != null)
                {
                    txt_Type.Text = mod.C_TYPE;
                    txt_Heat.Text = mod.C_HEAT;
                    txt_Hot.Text = mod.C_HOT_T;
                    txt_cooldate.Text = mod.N_COOL_DT.ToString();
                    txt_CoolCraft.Text = mod.C_COOL_CRAFT;
                    txt_Remark.Text = mod.C_REMARK;
                }
                else
                {
                    txt_Type.Text = null;
                    txt_Heat.Text = null;
                    txt_Hot.Text = null;
                    txt_cooldate.Text = null;
                    txt_CoolCraft.Text = null;
                    txt_Remark.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_cool, "缓冷要求" + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
