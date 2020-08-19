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
    /// <summary>
    /// 线材生产影响记录
    /// </summary>
    public partial class FrmPPXCNYXHJL : Form
    {
        string stacode = "";
        public FrmPPXCNYXHJL()
        {
            InitializeComponent();
            stacode = RV.UI.QueryString.parameter;
        }
        CommonSub commonSub = new CommonSub();
        private Bll_TB_PRO bllPro = new Bll_TB_PRO();//工位
        private Bll_TB_STA bllSta = new Bll_TB_STA();//工位
        private void FrmPPXCNYXHJL_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                commonSub.ImageComboBoxEditBindGX("", imgcbo_pro, "");//加载轧钢的工序
                imgcbo_pro.SelectedIndex = 0;
                commonSub.ImageComboBoxEditBindGX("", imgcbo_GX, "");//加载轧钢的工序
                imgcbo_GX.Properties.Items.Add("全部", "", 0);
                imgcbo_GX.SelectedIndex = imgcbo_GX.Properties.Items.Count - 1;
                commonSub.ImageComboBoxEditBindNCBC(cbo_shift, stacode);
                commonSub.ImageComboBoxEditBindNCBZ(cbo_group, stacode);
                commonSub.BCBZBindEdit(cbo_shift, cbo_group, stacode);
                cbo_energy.SelectedIndex = 0;
                cbo_query_energy.SelectedIndex = 0;
                dt_recode_dt.DateTime = RV.UI.ServerTime.timeNow();
                dt_query_form.DateTime = RV.UI.ServerTime.timeNow().AddDays(-1);
                dt_query_to.DateTime = RV.UI.ServerTime.timeNow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private Bll_TB_STA bllsta = new Bll_TB_STA();//工位
        private Bll_TB_ITEM_TYPE bllitem = new Bll_TB_ITEM_TYPE();//项目
        private Bll_TRC_ENERGY_RECORD bllenergy = new Bll_TRC_ENERGY_RECORD();//能源

        #region 方法
        public void BindEnergy()
        {
            DataTable dt = null;
            dt = bllitem.GetListByType("能源消耗").Tables[0];
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        this.cbo_energy.Properties.Items.Add(dt.Rows[i]["C_ITEM_NAME"].ToString());

                        this.cbo_query_energy.Properties.Items.Add(dt.Rows[i]["C_ITEM_NAME"].ToString());
                    }
                }
            }
            else
            {
                this.cbo_energy.Properties.Items.Clear();
                this.cbo_query_energy.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 查询能源消耗实绩记录
        /// </summary>
        public void BindRecode()
        {
            string stacode = "";
            string procode = "";
            if (imgcbo_GX.EditValue.ToString() != "")
            {
                Mod_TB_PRO mod_TB_PRO = bllPro.GetModel(imgcbo_GX.EditValue.ToString());
                procode = mod_TB_PRO.C_PRO_CODE;
            }
            if (imgcbo_GW.EditValue.ToString() != "")
            {
                Mod_TB_STA mod_TB_STA = bllSta.GetModel(imgcbo_GW.EditValue.ToString());
                stacode = mod_TB_STA.C_STA_CODE;
            }
            DataTable dt = bllenergy.BindRecode(dt_query_form.DateTime, dt_query_to.DateTime, procode, stacode, cbo_energy.EditValue.ToString()).Tables[0];
            this.gc_scyx.DataSource = dt;
            this.gv_scyx.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_scyx.OptionsSelection.MultiSelect = true;//允许多选
            gv_scyx.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            this.gv_scyx.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_scyx);
        }

        #endregion
        /// <summary>
        /// 查询记录信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                BindRecode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 停用记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_scyx.SelectedRowsCount;
                int commitNum = 0;//停用记录数量
                int failtNum = 0;//停用失败数量
                int[] rownumber = this.gv_scyx.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_scyx.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    Mod_TRC_ENERGY_RECORD model = bllenergy.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool update = bllenergy.Update(model);
                    if (update)
                    {
                        commitNum = commitNum + 1;
                    }
                    else
                    {
                        failtNum = failtNum + 1;
                    }
                }
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，停用" + commitNum.ToString() + "条记录！");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 保存记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                #region 验证信息
                if (this.dt_recode_dt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请选择记录的日期！");
                    this.dt_recode_dt.Focus();
                    return;
                }
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
                if (this.cbo_energy.Text.Trim() == "")
                {
                    MessageBox.Show("请选择记录的能源种类！");
                    this.cbo_energy.Focus();
                    return;
                }

                if (this.txt_Consumption.Text.Trim() == "")
                {
                    MessageBox.Show("请输入消耗实绩！");
                    this.txt_Consumption.Focus();
                    return;
                }

                if (this.cbo_Unit.Text.Trim() == "")
                {
                    MessageBox.Show("请选择单位！");
                    this.cbo_Unit.Focus();
                    return;
                }
                #endregion
                bool res = false;
                if (DialogResult.No == MessageBox.Show("是否确认添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                Mod_TRC_ENERGY_RECORD model = new Mod_TRC_ENERGY_RECORD();
                //工序信息
                Mod_TB_PRO modpro = bllPro.GetModel(imgcbo_pro.EditValue.ToString());
                model.C_PRO_CODE = modpro.C_PRO_CODE;
                //工位信息
                Mod_TB_STA modSta = bllsta.GetModel(imgcbo_sta.EditValue.ToString());
                model.C_STA_CODE = modSta.C_STA_CODE;
                model.D_RECODE_DT = Convert.ToDateTime(this.dt_recode_dt.Text);
                model.C_SHIFT = this.cbo_shift.EditValue.ToString() ;
                model.C_GROUP = this.cbo_group.EditValue.ToString();
                model.C_ENERGY_KIND = cbo_energy.Text;
                model.N_CONSUMPTION = Convert.ToDecimal(this.txt_Consumption.Text);
                model.C_UNIT = this.cbo_Unit.Text;
                model.C_REMARK = this.txt_Remark.Text;
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                res = bllenergy.Add(model);
                if (res)
                {
                    MessageBox.Show("操作成功！");
                    BindRecode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbo_energy_SelectedValueChanged(object sender, EventArgs e)
        {
            cbo_Unit.SelectedIndex = 0;
        }

        private void imgcbo_pro_SelectedValueChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindGW(imgcbo_pro.EditValue.ToString(), imgcbo_sta);//加载轧钢的工位
            imgcbo_sta.SelectedIndex = 0;
        }

        private void imgcbo_GX_SelectedValueChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindGW(imgcbo_GX.EditValue.ToString(), imgcbo_GW);//加载轧钢的工位
            imgcbo_GW.Properties.Items.Add("全部", "", 0);
            imgcbo_GW.SelectedIndex = imgcbo_GW.Properties.Items.Count - 1;
        }
    }
}
