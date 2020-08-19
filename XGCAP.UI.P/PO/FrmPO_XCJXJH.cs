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

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_XCJXJH : Form
    {
        public string stacode;
        public FrmPO_XCJXJH()
        {
            InitializeComponent();
            stacode = RV.UI.QueryString.parameter;
        }
        private Bll_TB_PRO bllPro = new Bll_TB_PRO();//工位
        private Bll_TB_STA bllSta = new Bll_TB_STA();//工位
        private Bll_TB_ITEM_TYPE bllitem = new Bll_TB_ITEM_TYPE();//项目
        private Bll_TPP_TURNAROUND_PLAN blljxjh = new Bll_TPP_TURNAROUND_PLAN();//检修计划
        private CommonSub commonSub = new CommonSub();

        private string strMenuName;

        private void FrmXCJXJH_Load(object sender, EventArgs e)
        {
            try
            {
                strMenuName = RV.UI.UserInfo.menuName;
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                cbo_jxlb.SelectedIndex = 0;
                cbo_query_jxlb.SelectedIndex = 0;
                dt_jx_from_time.DateTime = RV.UI.ServerTime.timeNow();
                dt_jx_end_time.DateTime = RV.UI.ServerTime.timeNow().AddHours(6);
                dt_query_from_dt.DateTime = RV.UI.ServerTime.timeNow();
                dt_query_to_dt.DateTime = RV.UI.ServerTime.timeNow().AddDays(30);
                commonSub.ImageComboBoxEditBindNCBC(cbo_shift, stacode);
                commonSub.ImageComboBoxEditBindNCBZ(cbo_group, stacode);
                commonSub.BCBZBindEdit(cbo_shift, cbo_group, stacode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 加载检修类别
        /// </summary>
        public void BindJXLB()
        {
            DataTable dt = null;
            dt = bllitem.GetListByType("检修类别").Tables[0];
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        this.cbo_jxlb.Properties.Items.Add(dt.Rows[i]["C_ITEM_NAME"].ToString());

                        this.cbo_query_jxlb.Properties.Items.Add(dt.Rows[i]["C_ITEM_NAME"].ToString());
                    }
                }

            }
            else
            {
                this.cbo_jxlb.Properties.Items.Clear();
                this.cbo_query_jxlb.Properties.Items.Clear();
            }

        }



        /// <summary>
        /// 查询检修计划
        /// </summary>
        public void BindInfo()
        {
            DataTable dt = blljxjh.BindInfo(dt_query_from_dt.DateTime, dt_query_to_dt.DateTime, stacode, cbo_query_jxlb.Text.Trim(), this.rbtn_issh.SelectedIndex == 0 ? 1 : 2, "").Tables[0];
            this.gc_jxjh.DataSource = dt;
            this.gv_jxjh.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_jxjh.OptionsSelection.MultiSelect = true;//允许多选
            gv_jxjh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            this.gv_jxjh.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_jxjh);
        }

        /// <summary>
        /// 保存信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveDetails_Click(object sender, EventArgs e)
        {
            try
            {
                #region 验证信息
                if (txt_remark.Text.Trim() != "")
                {
                    MessageBox.Show("备注不能为空！");
                    return;
                }

                #endregion
                bool res = false;
                if (DialogResult.No == MessageBox.Show("是否确认保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                Mod_TPP_TURNAROUND_PLAN model = new Mod_TPP_TURNAROUND_PLAN();
                model.C_STA_CODE = stacode;
                Mod_TB_STA mod = bllSta.GetModelByCODE(stacode);
                if (mod != null)
                {
                    model.C_STA_ID = mod.C_ID;
                }
                model.D_START_TIME = Convert.ToDateTime(this.dt_jx_from_time.Text);
                model.D_END_TIME = Convert.ToDateTime(this.dt_jx_end_time.Text);
                model.C_PLAN_TYPE = this.cbo_jxlb.Text;
                model.C_REMARK = txt_remark.Text;
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                res = blljxjh.Add(model);
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加轧线检修计划");//添加操作日志
                if (res)
                {
                    MessageBox.Show("操作成功！");
                    BindInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                BindInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_jxjh.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_jxjh.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_jxjh.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    Mod_TPP_TURNAROUND_PLAN model = blljxjh.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    bool update = blljxjh.Update(model);
                    if (update)
                    {
                        commitNum = commitNum + 1;
                    }
                    else
                    {
                        failtNum = failtNum + 1;
                    }
                }
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，删除" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除检修计划");//添加操作日志
                BindInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_sh_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认审核？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_jxjh.SelectedRowsCount;
                int commitNum = 0;//审核记录数量
                int failtNum = 0;//审核失败数量
                int[] rownumber = this.gv_jxjh.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_jxjh.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    Mod_TPP_TURNAROUND_PLAN model = blljxjh.GetModel(strID);
                    model.N_STATUS = 2;
                    model.C_SH_EMP_ID = RV.UI.UserInfo.userName;
                    model.D_SH_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool update = blljxjh.Update(model);
                    if (update)
                    {
                        commitNum = commitNum + 1;
                    }
                    else
                    {
                        failtNum = failtNum + 1;
                    }
                }
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，审核" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "审核检修计划");//添加操作日志
                BindInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
