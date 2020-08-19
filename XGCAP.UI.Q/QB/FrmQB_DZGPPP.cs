using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_DZGPPP : Form
    {
        public FrmQB_DZGPPP()
        {
            InitializeComponent();
        }
        Bll_TQB_STD_MAIN bll_std_main = new Bll_TQB_STD_MAIN();
        Bll_TQB_REPLACE_SLAB bll_replace = new Bll_TQB_REPLACE_SLAB();
        private string strMenuName;
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB_DZGPPP_Load(object sender, EventArgs e)
        {
            strMenuName = RV.UI.UserInfo.menuName;
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_STD_Click(object sender, EventArgs e)
        {
            GetQuery();
            GetQueryRight();
        }

        private void GetQuery()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = new DataTable();
                if (rbtn_isty_wh.SelectedIndex == 1)
                {
                    dt = bll_std_main.GetList("1",1,"全部",txt_ZXBZ.Text.Trim(),txt_GZ.Text.Trim()).Tables[0];
                }
                if (rbtn_isty_wh.SelectedIndex == 0)
                {
                    dt = bll_std_main.GetList("0", 1, "全部", txt_ZXBZ.Text.Trim(), txt_GZ.Text.Trim()).Tables[0];
                } 
                this.gc_STD_Main.DataSource = dt;
                gv_STD_Main.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_STD_Main);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 匹配表查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_STD_Main_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetQuery_PPB();
        }
        private void GetQuery_PPB()
        {
            try
            {
                WaitingFrom.ShowWait("");
                gc_DZGZ.DataSource = null;
                DataRow dr = gv_STD_Main.GetDataRow(gv_STD_Main.FocusedRowHandle);
                if (dr == null) return;
                DataTable dt = new DataTable();
                
                    dt = bll_replace.GetList_Query(dr["C_IS_BXG"].ToString(), dr["C_STL_GRD"].ToString(),dr["C_STD_CODE"].ToString() ).Tables[0];
                
                this.gc_DZGZ.DataSource = dt;
                gv_DZGZ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_DZGZ);
                WaitingFrom.CloseWait();
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
        private void btn_Query_dz_Click(object sender, EventArgs e)
        {
            GetQueryRight();
        }
        private void GetQueryRight()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = new DataTable();
                if (rbtn_isty_wh.SelectedIndex == 1)
                {
                    dt = bll_std_main.GetList("1", 1, "全部", txt_Right_Std.Text.Trim(), txt_Right_STL.Text.Trim()).Tables[0];
                }
                if (rbtn_isty_wh.SelectedIndex == 0)
                {
                    dt = bll_std_main.GetList("0", 1, "全部", txt_Right_Std.Text.Trim(), txt_Right_STL.Text.Trim()).Tables[0];
                }
                this.gc_right.DataSource = dt;
                gv_right.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_right);
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
                DataRow dr_StdMain = gv_STD_Main.GetDataRow(gv_STD_Main.FocusedRowHandle);
                DataRow dr_Slab = gv_right.GetDataRow(gv_right.FocusedRowHandle);
                if (dr_StdMain == null) return;
                if (dr_Slab == null) return;

                Mod_TQB_REPLACE_SLAB model = new Mod_TQB_REPLACE_SLAB();
                model.C_STL_GRD = dr_StdMain["C_STL_GRD"].ToString();
                model.C_STD_CODE = dr_StdMain["C_STD_CODE"].ToString();
                model.C_STL_GRD_SLAB = dr_Slab["C_STL_GRD"].ToString();
                model.C_STD_CODE_SLAB = dr_Slab["C_STD_CODE"].ToString();
                model.C_SF_BXG= dr_Slab["C_IS_BXG"].ToString();
                if (chk_XM.Checked)
                {
                    model.C_XM = "修磨";
                }
                if (chk_WXM.Checked)
                {
                    model.C_XM = "未修磨";
                }
                if (chk_DFP.Checked)
                {
                    model.C_DFP = "大方坯";
                }
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable(); 
                ht.Add("C_STL_GRD", model.C_STL_GRD); 
                ht.Add("C_STD_CODE", model.C_STD_CODE);
                ht.Add("C_STL_GRD_SLAB", model.C_STL_GRD_SLAB);
                ht.Add("C_STD_CODE_SLAB", model.C_STD_CODE_SLAB);
                ht.Add("C_SF_BXG", model.C_SF_BXG);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_REPLACE_SLAB", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion

                if (model.C_STL_GRD==model.C_STL_GRD_SLAB && model.C_STD_CODE==model.C_STD_CODE_SLAB)
                {
                    MessageBox.Show("请勿匹配相同钢种！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (bll_replace.Add(model))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加待轧钢坯匹配关系");//添加操作日志
                    GetQuery_PPB();
                    GetQueryRight();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {

                    Bll_Common bllCommon = new Bll_Common();
                    DataRow dr = gv_DZGZ.GetDataRow(gv_DZGZ.FocusedRowHandle);
                    if (dr == null) return;
                    if (bllCommon.DataDisabled("TQB_REPLACE_SLAB", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                    {
                        GetQuery_PPB();
                        MessageBox.Show("已删除！");


                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消待轧钢坯匹配关系");//添加操作日志
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
        /// 钢种类型选择变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_isty_wh_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetQuery();
            GetQueryRight();
        }
        /// <summary>
        /// 修磨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_XM_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_XM.Checked)
                {
                    chk_WXM.Checked = false;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 未修磨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_WXM_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_WXM.Checked)
                {
                    chk_XM.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_STD_Main_Click(object sender, EventArgs e)
        {
            GetQuery_PPB();
        }
    }
}
