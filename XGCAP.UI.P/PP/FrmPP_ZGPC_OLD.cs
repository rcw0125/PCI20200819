using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;
using MODEL;

namespace XGCAP.UI.P.PP
{
    public partial class FrmPP_ZGPC_OLD : Form
    {
        Bll_TPP_INITIALIZE_ITEM bll_TPP_INITIALIZE_ITEM = new Bll_TPP_INITIALIZE_ITEM();
        Bll_TPP_PRODUCTION_PLAN bll_TPP_PRODUCTION_PLAN = new Bll_TPP_PRODUCTION_PLAN();
        Bll_TRP_PLAN_ROLL bll_TRP_PLAN_ROLL = new Bll_TRP_PLAN_ROLL();
        Bll_TPB_STATION_CAPACITY bll_TPB_STATION_CAPACITY = new Bll_TPB_STATION_CAPACITY();
        Bll_TPB_CHANGESPEC_TIME bll_TPB_CHANGESPEC_TIME = new Bll_TPB_CHANGESPEC_TIME();
        Bll_TB_PRO bll_TB_PRO = new Bll_TB_PRO();
        CommonSub commonSub = new CommonSub();
        private Bll_TPP_INITIALIZE_ORDER bll_ini_order = new Bll_TPP_INITIALIZE_ORDER();//初始化订单表
        private Bll_TPP_PROD_INITIALIZE bll_TPP_PROD_INITIALIZE = new Bll_TPP_PROD_INITIALIZE();//初始化主表（档期表）
        private Bll_TPP_INITIALIZE_ITEM bll_Item = new Bll_TPP_INITIALIZE_ITEM();//初始化（方案表）
        private Bll_TB_PRO bllPro = new Bll_TB_PRO();//工序表
        private Bll_TB_STA bllSta = new Bll_TB_STA();//工位表
        private Bll_TPP_INITIALIZE_STA bll_TPP_INITIALIZE_STA = new Bll_TPP_INITIALIZE_STA();//方案初始化工序工位
        private Bll_TPP_INITIALIZE_LINE bll_INI_LINE = new Bll_TPP_INITIALIZE_LINE();//方案初始化的炼钢工艺路线
        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();//订单池
        private Bll_TPB_LINE_SPEC bll_line_spec = new Bll_TPB_LINE_SPEC();//规格产线数据表
        private Bll_TPB_SLAB_CAPACITY bll_slab_spec = new Bll_TPB_SLAB_CAPACITY();//连铸机机时产能对照biao

        public FrmPP_ZGPC_OLD()
        {
            InitializeComponent();
        }

        private void FrmPP_ZGPC_OLD_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                this.dtp_dt1.Text = System.DateTime.Now.ToString("yyyy-MM") + "-01";
                this.dtp_dt2.Text = Convert.ToDateTime(this.dtp_dt1.Text).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 查询订单信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
            Query1();
        }
        private void Query2()
        {
            try
            {

                int selectedHandle = this.gv_CXXQ.FocusedRowHandle;//获取焦点行索引
                string GX = "";
                if (selectedHandle >= 0)
                {
                    GX = this.gv_CXXQ.GetRowCellValue(selectedHandle, "C_STA_ID").ToString();//获取产线
                }
                DataTable dacx = bll_TRP_PLAN_ROLL.GetGZList(GX, cbo_FA.EditValue.ToString()).Tables[0];
                this.gc_GZXQ.DataSource = dacx;
                this.gv_GZXQ.OptionsView.ColumnAutoWidth = false;
                this.gv_GZXQ.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Query()
        {
            if (cbo_FA.Text == "")
            {
                return;
            }
            DataTable dt = null;

            if (rbtn_N.Checked)
            {
                dt = bll_ini_order.ROLLGetIniOrderByIniID(cbo_FA.EditValue.ToString(), txt_GZ.Text.Trim(), txt_ZXBZ.Text.Trim(), cbo_GG1.EditValue.ToString(), cbo_GG2.EditValue.ToString(), cbo_GW1.EditValue.ToString(), 0);
            }

            if (rbtn_Y.Checked)
            {
                dt = bll_ini_order.ROLLGetIniOrderByIniID(cbo_FA.EditValue.ToString(), txt_GZ.Text.Trim(), txt_ZXBZ.Text.Trim(), cbo_GG1.EditValue.ToString(), cbo_GG2.EditValue.ToString(), cbo_GW1.EditValue.ToString(), 1);
            }
            this.gc_DDFA.DataSource = dt;
            this.gv_DDFA.OptionsView.ColumnAutoWidth = false;
            this.gv_DDFA.OptionsSelection.MultiSelect = true;
            this.gv_DDFA.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            C_ROLL_STA_ID.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            this.gv_DDFA.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_DDFA);
            gv_DDFA_Click();
        }

        private void Query1()
        {
            if (cbo_FA.Text == "")
            {
                return;
            }
            DataTable dt = null;
            dt = bll_TRP_PLAN_ROLL.GetList(0, cbo_FA.EditValue.ToString(), cbo_GW1.EditValue.ToString()).Tables[0];
            this.gc_ZGJH.DataSource = dt;
            this.gv_ZGJH.OptionsView.ColumnAutoWidth = false;
            colC_STA_ID.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            this.gv_ZGJH.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ZGJH);
        }

        /// <summary>
        /// 添加轧钢计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                //DataTable dataTable = bll_TPP_INITIALIZE_STA.GetList("", cbo_GW1.EditValue.ToString(), cbo_FA.Text, "").Tables[0];
                //decimal gwsycn = 0;
                //if (dataTable.Rows.Count > 0)
                //{
                //    gwsycn = Convert.ToDecimal(dataTable.Rows[0]["N_CAPACITY"]) - GWCN(cbo_GW1.EditValue.ToString());
                //}
                //if (Convert.ToDecimal(txt_wgt1.Text) > gwsycn)
                //{
                //    MessageBox.Show("已超出产能");
                //    return;
                //}
                int[] row = gv_DDFA.GetSelectedRows();
                if (row.Count() == 0)
                {
                    MessageBox.Show("未选中计划！");
                    return;
                }
                if (row.Count() == 1)
                {
                    DataRow dr = gv_DDFA.GetDataRow(row[0]);
                    decimal wgt = (Convert.ToDecimal(dr["N_WGT"].ToString()) - Convert.ToDecimal(dr["N_ROLL_PROD_WGT"].ToString()));//数量

                    if (Convert.ToDecimal(txt_wgt1.Text.Trim()) > wgt)
                    {
                        MessageBox.Show("超出最大值!");
                        txt_wgt1.Text = wgt.ToString();
                        return;
                    }
                    if (Convert.ToDecimal(txt_wgt1.Text.Trim()) == 0)
                    {
                        MessageBox.Show("排产数量不能为0");
                        return;
                    }

                    PLANADD(row[0]);
                }
                else
                {
                    foreach (var item in row)
                    {
                        PLANADD(item);
                    }
                }
                txt_wgt1.Text = "0";
                Query();
                Query1();
                gv_DDFA_Click();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void PLANADD(int item)
        {
            DataRow dr = gv_DDFA.GetDataRow(item);
            int count = bll_TRP_PLAN_ROLL.GetFACount(cbo_FA.EditValue.ToString(), cbo_GW1.EditValue.ToString());//该方案下该工位计划数量
            Mod_TRP_PLAN_ROLL mod_TRP_PLAN_ROLL = new Mod_TRP_PLAN_ROLL();
            mod_TRP_PLAN_ROLL.C_INITIALIZE_ID = cbo_FA.EditValue.ToString();
            mod_TRP_PLAN_ROLL.C_INITIALIZE_ITEM_ID = dr["C_ID"].ToString();
            mod_TRP_PLAN_ROLL.N_SORT = count + 1;
            mod_TRP_PLAN_ROLL.C_SPEC = dr["C_SPEC"].ToString();
            mod_TRP_PLAN_ROLL.C_STD_CODE = dr["C_STD_CODE"].ToString();
            mod_TRP_PLAN_ROLL.C_STL_GRD = dr["C_STL_GRD"].ToString();
            mod_TRP_PLAN_ROLL.C_ORDER_NO = dr["C_ORDER_NO"].ToString();
            mod_TRP_PLAN_ROLL.C_MAT_NAME = dr["C_MAT_NAME"].ToString();
            mod_TRP_PLAN_ROLL.C_MAT_CODE = dr["C_MAT_CODE"].ToString();
            mod_TRP_PLAN_ROLL.N_WGT = Convert.ToDecimal(dr["N_WGT"]);
            if (dr["C_ROLL_STA_ID"] == null || dr["C_ROLL_STA_ID"].ToString() == "")
            {
                MessageBox.Show(mod_TRP_PLAN_ROLL.C_STL_GRD + "未分配产线!");
                return;
            }
            mod_TRP_PLAN_ROLL.C_STA_ID = dr["C_ROLL_STA_ID"].ToString();

            if (txt_wgt1.Enabled == true)
            {
                mod_TRP_PLAN_ROLL.N_ROLL_PROD_WGT = Convert.ToDecimal(txt_wgt1.Text);
            }
            else
            {
                mod_TRP_PLAN_ROLL.N_ROLL_PROD_WGT = Convert.ToDecimal(dr["N_WGT"]) - Convert.ToDecimal(dr["N_ROLL_PROD_WGT"]);
            }
            if (mod_TRP_PLAN_ROLL.N_WGT <= 0)
            {
                return;
            }
            if (count > 0)
            {
                DataTable bdt = bll_TRP_PLAN_ROLL.GetList(Convert.ToInt32(mod_TRP_PLAN_ROLL.N_SORT - 1), mod_TRP_PLAN_ROLL  .C_INITIALIZE_ID, mod_TRP_PLAN_ROLL.C_STA_ID).Tables[0];
                if (bdt.Rows.Count > 0)
                {
                    DateTime enddt = Convert.ToDateTime(bdt.Rows[0]["D_P_END_TIME"]);//上一计划结束时间
                    DataTable hggdt = bll_TPB_CHANGESPEC_TIME.GetList(1, mod_TRP_PLAN_ROLL.C_STA_ID, bdt.Rows[0]["C_SPEC"].ToString(), mod_TRP_PLAN_ROLL.C_SPEC).Tables[0];
                    if (hggdt.Rows.Count > 0)
                    {
                        mod_TRP_PLAN_ROLL.D_P_START_TIME = enddt.AddMinutes(Convert.ToDouble(hggdt.Rows[0]["N_TIME"]));
                    }
                    else
                    {
                        mod_TRP_PLAN_ROLL.D_P_START_TIME = enddt;
                    }
                }

            }
            else
            {
                mod_TRP_PLAN_ROLL.D_P_START_TIME = DateTime.Now;
            }
            int cn = 0;
            if (!string.IsNullOrEmpty(dr["N_MACH_WGT"].ToString()))
            {
                cn = Convert.ToInt32(dr["N_MACH_WGT"].ToString());
            }

            if (cn == 0)
            {
                cn = 50;
            }

            double db = Convert.ToDouble(mod_TRP_PLAN_ROLL.N_WGT) / Convert.ToDouble(cn);
            DateTime dt = Convert.ToDateTime(mod_TRP_PLAN_ROLL.D_P_START_TIME);
            dt = dt.AddHours(Convert.ToDouble(db));
            mod_TRP_PLAN_ROLL.D_P_END_TIME = dt;

            Mod_TPP_INITIALIZE_ORDER mod_TPP_INITIALIZE_ORDER = bll_ini_order.GetModel(mod_TRP_PLAN_ROLL.C_INITIALIZE_ITEM_ID);
            mod_TPP_INITIALIZE_ORDER.N_EXEC_STATUS = 1;
            mod_TPP_INITIALIZE_ORDER.N_ROLL_PROD_WGT += mod_TRP_PLAN_ROLL.N_WGT;
            bll_ini_order.Update(mod_TPP_INITIALIZE_ORDER);//变更方案计划表数据

            bll_TRP_PLAN_ROLL.Add(mod_TRP_PLAN_ROLL);//变更计划表

            //DataTable itemdt = bll_TPP_INITIALIZE_ITEM.GetListByNAME(cbo_FA.Text).Tables[0];
            ////Mod_TPP_INITIALIZE_ITEM mod_TPP_INITIALIZE_ITEM = bll_TPP_INITIALIZE_ITEM.GetModel(itemdt.Rows[0]["C_ID"].ToString());
            ////mod_TPP_INITIALIZE_ITEM.N_Z_WGT = (mod_TPP_INITIALIZE_ITEM.N_Z_WGT.ToString() == DBNull.Value.ToString() ? 0 : mod_TPP_INITIALIZE_ITEM.N_Z_WGT) + mod_TRP_PLAN_ROLL.N_WGT;
            ////mod_TPP_INITIALIZE_ITEM.D_ROLL_END_TIME = mod_TRP_PLAN_ROLL.D_P_END_TIME;
            ////bll_TPP_INITIALIZE_ITEM.Update(mod_TPP_INITIALIZE_ITEM);//变更方案表
            //bll_TPP_INITIALIZE_STA.UpdateBySTAFID(cbo_FA.Text, cbo_GW1.EditValue.ToString(), Convert.ToInt32(txt_wgt1.Text));
        }

        /// <summary>
        /// 轧钢计划撤销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_area_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认撤回？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                DataRow dr = gv_ZGJH.GetDataRow(gv_ZGJH.FocusedRowHandle);
                Mod_TPP_INITIALIZE_ORDER mod = bll_ini_order.GetModel(dr["C_INITIALIZE_ITEM_ID"].ToString());
                if (mod != null)
                {
                    mod.N_ROLL_PROD_WGT = mod.N_ROLL_PROD_WGT - Convert.ToDecimal(dr["N_WGT"].ToString());
                    if (mod.N_ROLL_PROD_WGT == 0)
                    {
                        mod.N_EXEC_STATUS = 0;
                    }
                    bll_TRP_PLAN_ROLL.Delete(dr["C_ID"].ToString());


                    #region 重新计算顺序

                    bll_TRP_PLAN_ROLL.Update(dr["C_STA_ID"].ToString(), dr["C_INITIALIZE_ID"].ToString(), Convert.ToInt32(dr["N_SORT"].ToString()));

                    #endregion


                    #region 重新计算计划时间

                    int count = bll_TRP_PLAN_ROLL.GetFACount(cbo_FA.EditValue.ToString(), dr["C_STA_ID"].ToString());//该方案下该工位计划数量

                    int startNum = 1;

                    startNum = Convert.ToInt32(dr["N_SORT"].ToString());
                    mod.N_ROLL_PROD_WGT = mod.N_WGT - Convert.ToDecimal(dr["N_ROLL_PROD_WGT"]);
                    mod.N_EXEC_STATUS = 0;
                    bll_ini_order.Update(mod);
                    for (int i = startNum; i <= count; i++)
                    {
                        Mod_TRP_PLAN_ROLL mod_TRP_PLAN_ROLL = bll_TRP_PLAN_ROLL.GetModel(i, dr["C_INITIALIZE_ID"].ToString(), dr["C_STA_ID"].ToString());

                        if (i > 1)
                        {
                            DataTable bdt = bll_TRP_PLAN_ROLL.GetList(Convert.ToInt32(mod_TRP_PLAN_ROLL.N_SORT - 1), mod_TRP_PLAN_ROLL.C_INITIALIZE_ITEM_ID, mod_TRP_PLAN_ROLL.C_STA_ID).Tables[0];
                            DateTime enddt = Convert.ToDateTime(bdt.Rows[0]["D_P_END_TIME"]);//上一计划结束时间
                            DataTable hggdt = bll_TPB_CHANGESPEC_TIME.GetList(1, mod_TRP_PLAN_ROLL.C_STA_ID, bdt.Rows[0]["C_SPEC"].ToString(), mod_TRP_PLAN_ROLL.C_SPEC).Tables[0];

                            if (hggdt.Rows.Count > 0)
                            {
                                mod_TRP_PLAN_ROLL.D_P_START_TIME = enddt.AddMinutes(Convert.ToDouble(hggdt.Rows[0]["N_TIME"]));
                            }
                            else
                            {
                                mod_TRP_PLAN_ROLL.D_P_START_TIME = enddt;
                            }
                        }
                        else
                        {
                            mod_TRP_PLAN_ROLL.D_P_START_TIME = Convert.ToDateTime(bll_TPP_INITIALIZE_ITEM.GetListByNAME(cbo_FA.Text).Tables[0].Rows[0]["D_ROLL_START_TIME"]);
                        }

                        DataTable dataTable = bll_TPB_STATION_CAPACITY.GetList(1, "", mod_TRP_PLAN_ROLL.C_STA_ID, mod_TRP_PLAN_ROLL.C_STL_GRD, mod_TRP_PLAN_ROLL.C_SPEC, mod_TRP_PLAN_ROLL.C_STD_CODE).Tables[0];
                        string cn = "";
                        if (dataTable.Rows.Count > 0)
                        {
                            cn = dataTable.Rows[0]["N_CAPACITY"].ToString();
                        }
                        else
                        {
                            cn = "60";
                        }
                        double db = Convert.ToDouble(mod_TRP_PLAN_ROLL.N_WGT) / Convert.ToDouble(cn);
                        DateTime dt = Convert.ToDateTime(mod_TRP_PLAN_ROLL.D_P_START_TIME);
                        dt = dt.AddHours(Convert.ToDouble(db));

                        mod_TRP_PLAN_ROLL.D_P_END_TIME = dt;

                        bll_TRP_PLAN_ROLL.Update(mod_TRP_PLAN_ROLL);


                    }

                    MessageBox.Show("撤销成功！");

                    Query();
                    Query1();
                    gv_DDFA_Click();
                    #endregion


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void gv_DDFA_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                int[] row = gv_DDFA.GetSelectedRows();
                if (row.Count() < 0)
                {
                    return;
                }
                else
                {
                    if (row.Count() == 1)
                    {
                        DataRow dr = gv_DDFA.GetDataRow(row[0]);
                        string cid = dr["C_ID"].ToString();
                        txt_wgt1.Text = (Convert.ToDecimal(dr["N_WGT"].ToString()) - Convert.ToDecimal(dr["N_ROLL_PROD_WGT"].ToString() == DBNull.Value.ToString() ? "0" : dr["N_ROLL_PROD_WGT"].ToString())).ToString();//数量
                        txt_wgt1.Enabled = false;
                    }
                    else
                    {
                        decimal wgt = 0;
                        foreach (var item in row)
                        {
                            DataRow dr = gv_DDFA.GetDataRow(item);
                            wgt += Convert.ToDecimal(dr["N_WGT"].ToString()) - Convert.ToDecimal(dr["N_ROLL_PROD_WGT"].ToString() == DBNull.Value.ToString() ? "0" : dr["N_ROLL_PROD_WGT"].ToString());//数量
                        }
                        txt_wgt1.Text = wgt.ToString();
                        txt_wgt1.Enabled = false;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private decimal GWCN(string sta)
        {
            DataTable dt = bll_TRP_PLAN_ROLL.GetList(cbo_FA.Text, sta).Tables[0];
            decimal wgt = 0;
            foreach (DataRow item in dt.Rows)
            {
                wgt += Convert.ToDecimal(item["N_WGT"]);
            }
            return wgt;
        }

        /// <summary>
        /// 获取工序id
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public string GetGXid(string pro)
        {
            DataTable dt = bll_TB_PRO.GetListByStatus(1, pro, "").Tables[0];
            string cid = "";
            if (dt.Rows.Count > 0)
            {
                cid = dt.Rows[0]["C_ID"].ToString();
            }
            return cid;
        }

        private void gv_DDFA_Click()
        {
            DataTable dacx = bll_TRP_PLAN_ROLL.GetCXList(Gethoursbrid(cbo_FA.Text), cbo_FA.EditValue.ToString()).Tables[0];
            this.gc_CXXQ.DataSource = dacx;
            this.gv_CXXQ.OptionsView.ColumnAutoWidth = false;
            ZX.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            this.gv_CXXQ.BestFitColumns();
            Query2();
        }
        /// <summary>
        /// 根据方案获取时间
        /// </summary>
        /// <param name="fno">方案</param>
        /// <returns></returns>
        public decimal Gethoursbrid(string fno)
        {
            DataTable dt = bll_TPP_INITIALIZE_ITEM.GetListByNAME(fno).Tables[0];
            string C_ISSUE = "";
            if (dt.Rows.Count > 0)
            {
                C_ISSUE = dt.Rows[0]["C_ISSUE"].ToString();
            }
            Mod_TPP_PROD_INITIALIZE mod = bll_TPP_PROD_INITIALIZE.GetModelByISSUE(C_ISSUE);
            decimal hours = 0;
            if (mod != null)
            {
                hours = (Convert.ToDateTime(mod.D_END_TIME) - Convert.ToDateTime(mod.D_START_TIME)).Days * 24;
            }
            return hours;
        }
        private void gv_CXXQ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Query2();
        }

        private void gv_CXXQ_Click(object sender, EventArgs e)
        {
            Query2();
        }



        private void cbo_FA_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                commonSub.ImageComboBoxEditBindLGGW(GetGXid("ZX"), cbo_FA.EditValue.ToString(), cbo_GW1);
                cbo_GW1.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_ZDPC_Click(object sender, EventArgs e)
        {
            bll_TRP_PLAN_ROLL.Add_ZG_Plan(cbo_FA.EditValue.ToString());
            Query();
            Query1();
            gv_DDFA_Click();
        }

        private void dtp_dt2_TextChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindFABYTIME(cbo_FA, this.dtp_dt1.Text.Trim(), this.dtp_dt2.Text.Trim(), this.radioGroup2.Properties.Items[radioGroup2.SelectedIndex].Description.ToString());
            cbo_FA.SelectedIndex = 0;
        }

        private void dtp_dt1_TextChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindFABYTIME(cbo_FA, this.dtp_dt1.Text.Trim(), this.dtp_dt2.Text.Trim(), this.radioGroup2.Properties.Items[radioGroup2.SelectedIndex].Description.ToString());
            cbo_FA.SelectedIndex = 0;
        }

        private void cbo_GW1_SelectedValueChanged(object sender, EventArgs e)
        {
            commonSub.ComboBoxEditBindSPECByGW(cbo_GG1, cbo_GW1.EditValue.ToString(), "");
            cbo_GG1.SelectedIndex = 0;
            cbo_GG1_SelectedValueChanged(null, null);
        }

        private void cbo_GG1_SelectedValueChanged(object sender, EventArgs e)
        {
            commonSub.ComboBoxEditBindSPECByGW(cbo_GG2, cbo_GW1.EditValue.ToString(), cbo_GG1.EditValue.ToString());
            cbo_GG2.SelectedIndex = 0;
        }
    }
}
