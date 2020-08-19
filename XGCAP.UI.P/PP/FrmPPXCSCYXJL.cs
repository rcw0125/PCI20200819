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

namespace XGCAP.UI.P.PP
{
    public partial class FrmPPXCSCYXJL : Form
    {
        string stacode = "";
        private Bll_TB_PRO bllPro = new Bll_TB_PRO();//工位
        private Bll_TB_STA bllSta = new Bll_TB_STA();//工位
        private Bll_TB_ITEM_TYPE bllitem = new Bll_TB_ITEM_TYPE();//项目
        private Bll_TRC_PRODUCTION_IMPACT bllimpact = new Bll_TRC_PRODUCTION_IMPACT();//生产因数
        CommonSub commonSub = new CommonSub();
        public FrmPPXCSCYXJL()
        {
            InitializeComponent();
            stacode = RV.UI.QueryString.parameter;
        }
        private void FrmPPXCSCYXJL_Load(object sender, EventArgs e)
        {
            try
            {
                // cbo_YXLB1
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                commonSub.ImageComboBoxEditBindNCBC(cbo_shift, stacode);
                commonSub.ImageComboBoxEditBindNCBZ(cbo_group, stacode);
                commonSub.BCBZBindEdit(cbo_shift, cbo_group, stacode);
                cbo_YXType.SelectedIndex = 0;
                cbo_YXLB1.SelectedIndex = 0;
                dt_recode_dt.DateTime = Convert.ToDateTime(RV.UI.ServerTime.timeNow().ToString("yyyy-MM-dd hh:00:00"));
                dt_END_DATE.DateTime = Convert.ToDateTime(RV.UI.ServerTime.timeNow().AddHours(6).ToString("yyyy-MM-dd hh:00:00")); ;
                dt_query_form.DateTime = Convert.ToDateTime(RV.UI.ServerTime.timeNow().AddDays(-7).ToString("yyyy-MM-dd") + " 00:00:00");
                dt_query_to.DateTime = Convert.ToDateTime(RV.UI.ServerTime.timeNow().ToString("yyyy-MM-dd") + " 23:59:59");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        ///// <summary>
        ///// 加载项目类型
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void cbo_Type_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.cbo_impact_kind.Text = "";
        //        DataTable dt = null;
        //        if (cbo_YXType.SelectedIndex > 0)
        //        {
        //            dt = bllitem.GetListByType(cbo_YXType.Text.Trim()).Tables[0];
        //        }
        //        if (dt != null)
        //        {
        //            if (dt.Rows.Count > 0)
        //            {
        //                this.cbo_impact_kind.Properties.Items.Clear();
        //                for (int i = 0; i < dt.Rows.Count; i++)
        //                {
        //                    this.cbo_impact_kind.Properties.Items.Add(dt.Rows[i]["C_ITEM_NAME"].ToString());
        //                }
        //            }
        //        }
        //        else
        //        {
        //            this.cbo_impact_kind.Properties.Items.Clear();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.ToString());
        //    }
        //}
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                #region 验证信息
                if (this.cbo_shift.Text.Trim() == "")
                {
                    MessageBox.Show("未排班！");
                    this.cbo_shift.Focus();
                    return;
                }

                if (this.cbo_group.Text.Trim() == "")
                {
                    MessageBox.Show("未排班！");
                    this.cbo_group.Focus();
                    return;
                }
                if (this.cbo_YXType.Text.Trim() == "")
                {
                    MessageBox.Show("请选择影响类别！");
                    this.cbo_YXType.Focus();
                    return;
                }

                if (this.txt_YXDESC.Text.Trim() == "")
                {
                    MessageBox.Show("请输入影响描述！");
                    this.txt_YXDESC.Focus();
                    return;
                }

                #endregion
                bool res = false;
                if (DialogResult.No == MessageBox.Show("是否确认添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                Mod_TRC_PRODUCTION_IMPACT model = new Mod_TRC_PRODUCTION_IMPACT();

                //工位信息
                model.C_STA_CODE = stacode;
                model.C_IMPACT_DESC = txt_YXDESC.Text.Trim();
                model.D_IMPACT_DT = Convert.ToDateTime(this.dt_recode_dt.Text);
                model.D_IMPACT_END_DT = Convert.ToDateTime(this.dt_END_DATE.Text);
                TimeSpan ts = ((DateTime)model.D_IMPACT_END_DT - (DateTime)model.D_IMPACT_DT);
                model.N_IMPACT =Convert.ToInt32( ts.TotalMinutes);
                model.C_SHIFT = this.cbo_shift.EditValue.ToString();
                model.C_GROUP = this.cbo_group.EditValue.ToString();
                model.C_IMPACT_KIND = this.cbo_YXType.Text;
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                res = bllimpact.Add(model);
                if (res)
                {
                    MessageBox.Show("操作成功！");
                    btn_query_Click(null, null);
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
        private void btn_query_Click(object sender, EventArgs e)
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

        /// <summary>
        /// 查询生产影响记录
        /// </summary>
        public void BindInfo()
        {

            string procode = "";
            DataTable dt = bllimpact.BindInfo(dt_query_form.DateTime, dt_query_to.DateTime, stacode, cbo_YXLB1.Text, procode).Tables[0];
            this.gc_scyx.DataSource = dt;
            this.gv_scyx.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_scyx.OptionsSelection.MultiSelect = true;//允许多选
            gv_scyx.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            this.gv_scyx.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_scyx);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除选中的记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_scyx.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_scyx.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_scyx.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    Mod_TRC_PRODUCTION_IMPACT model = bllimpact.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool update = bllimpact.Update(model);
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
                BindInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


    }
}
