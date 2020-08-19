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
    public partial class FrmPP_ZGPC : Form
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

        public FrmPP_ZGPC()
        {
            InitializeComponent();
        }

        private void FrmPP_ZGPC_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
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


        private void Query()
        {
            DataTable dt = null;

            dt = bll_order.GetList(" C_SFPJ ='Y' ").Tables[0];

            this.gc_DDFA.DataSource = dt;
            this.gv_DDFA.OptionsView.ColumnAutoWidth = false;
            this.gv_DDFA.OptionsSelection.MultiSelect = true;
            this.gv_DDFA.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            colC_LINE_NO.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            this.gv_DDFA.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_DDFA);
        }

        private void Query1()
        {

            DataTable dt = null;
            dt = bll_TRP_PLAN_ROLL.GetList(0, "", "").Tables[0];
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

                int[] row = gv_DDFA.GetSelectedRows();
                if (row.Count() == 0)
                {
                    MessageBox.Show("未选中订单！");
                    return;
                }
                if (row.Count() == 1)
                {
                    DataRow dr = gv_DDFA.GetDataRow(row[0]);
                    decimal wgt = (Convert.ToDecimal(dr["N_WGT"].ToString()) - Convert.ToDecimal(dr["N_ROLL_PROD_WGT"].ToString()));//数量

                    if (Convert.ToDecimal(txt_wgt1.Text.Trim()) > wgt)
                    {
                        MessageBox.Show("排产重量不能大于订单剩余未排量!");
                        //txt_wgt1.Text = wgt.ToString();
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
                    MessageBox.Show("不能同时选择多条订单");
                    return;
                }
                txt_wgt1.Text = "0";
                Query();
                Query1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void PLANADD(int item)
        {
            DataRow dr = gv_DDFA.GetDataRow(item);
            int count = bll_TRP_PLAN_ROLL.GetFACount("", "");//该方案下该工位计划数量
            Mod_TRP_PLAN_ROLL mod_TRP_PLAN_ROLL = new Mod_TRP_PLAN_ROLL();
            mod_TRP_PLAN_ROLL.N_SORT = count + 1;
            mod_TRP_PLAN_ROLL.C_SPEC = dr["C_SPEC"].ToString();
            mod_TRP_PLAN_ROLL.C_STD_CODE = dr["C_STD_CODE"].ToString();
            mod_TRP_PLAN_ROLL.C_STL_GRD = dr["C_STL_GRD"].ToString();
            mod_TRP_PLAN_ROLL.C_ORDER_NO = dr["C_ORDER_NO"].ToString();
            mod_TRP_PLAN_ROLL.C_MAT_NAME = dr["C_MAT_NAME"].ToString();
            mod_TRP_PLAN_ROLL.C_MAT_CODE = dr["C_MAT_CODE"].ToString();
            mod_TRP_PLAN_ROLL.C_FREE_TERM = dr["C_FREE1"].ToString();
            mod_TRP_PLAN_ROLL.C_FREE_TERM2 = dr["C_FREE2"].ToString();
            mod_TRP_PLAN_ROLL.N_WGT = Convert.ToDecimal(dr["N_WGT"]);
            if (dr["C_LINE_NO"] == null || dr["C_LINE_NO"].ToString() == "")
            {
                MessageBox.Show(mod_TRP_PLAN_ROLL.C_STL_GRD + "未分配产线!");
                return;
            }
            mod_TRP_PLAN_ROLL.C_STA_ID = dr["C_LINE_NO"].ToString();

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
                DataTable bdt = bll_TRP_PLAN_ROLL.GetList(Convert.ToInt32(mod_TRP_PLAN_ROLL.N_SORT - 1), "", mod_TRP_PLAN_ROLL.C_STA_ID).Tables[0];
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
                mod_TRP_PLAN_ROLL.D_P_START_TIME = RV.UI.ServerTime.timeNow();
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

            Mod_TMO_ORDER modOrder = bll_order.GetModelByORDERNO(dr["C_ORDER_NO"].ToString());
            modOrder.N_ROLL_PROD_WGT = Convert.ToDecimal(dr["N_WGT"]);

            bll_order.Update(modOrder);

            bll_TRP_PLAN_ROLL.Add(mod_TRP_PLAN_ROLL);//变更计划表

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

    }
}
