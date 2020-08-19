using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_GPDB : Form
    {
        public FrmPO_GPDB()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        Bll_TRC_SLABWH_LOG bll_TRC_SLABWH_LOG = new Bll_TRC_SLABWH_LOG();
        string type1 = "E";
        string type2 = "D";
        private string strMenuName;

        private void FrmPB_GPCK_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                cbo_CK1.EditValue = "";
                cbo_QY1.EditValue = "";
                sub.ImageComboBoxEditBindGPK(cbo_CK1);
                de_st.DateTime = DateTime.Now;
                Query1();
                Query2();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
        }
        private void Query1()
        {
            DataTable dt = null;
            dt = bll_TSC_SLAB_MAIN.GetList("","", "", "F", txt_LH1.Text, txt_GZ1.Text, txt_ZXBZ1.Text, type1,"").Tables[0];
            this.gc_GP1.DataSource = dt;
            this.gv_GP1.OptionsView.ColumnAutoWidth = false;
            this.gv_GP1.OptionsSelection.MultiSelect = true;
            gv_GP1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GP1.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GP1);
        }

        private void gv_GP1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                txt_XZZS.Text = gv_GP1.GetSelectedRows().Count().ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                Query1();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int[] row = gv_GP1.GetSelectedRows();
                int ycount = 0;
                string ck = cbo_CK1.Text;
                string qy = cbo_QY1.Text;
                foreach (var item in row)
                {
                    DataRow dr = gv_GP1.GetDataRow(item);
                    string id = dr["C_ID"].ToString();
                    if (bll_TSC_SLAB_MAIN.Update(id, type2, ck, qy, "", ""))
                    {
                        ycount += 1;
                        Mod_TRC_SLABWH_LOG model = new Mod_TRC_SLABWH_LOG();
                        model.C_SLAB_MAIN_ID = id;
                        model.C_MOVE_TYPE = type2;
                        model.C_TRANSPORTATION = cbo_ZKFS.Text;
                        model.C_EMP_ID = RV.UI.UserInfo.userName;
                        model.C_FLOOR_BEFORE = dr["C_SLABWH_TIER_CODE"].ToString();
                        model.C_GROUP = cbo_BZ.EditValue.ToString();
                        model.C_SLABWH_AREA_CODE_AFTER = cbo_QY1.Text;
                        model.C_SLABWH_AREA_CODE_BEFORE = dr["C_SLABWH_AREA_CODE"].ToString();
                        model.C_SLABWH_CODE_AFTER = cbo_CK1.Text;
                        model.C_SLABWH_CODE_BEFORE = dr["C_SLABWH_CODE"].ToString();
                        model.C_SLABWH_LOC_CODE_BEFORE = dr["C_SLABWH_LOC_CODE"].ToString();
                        model.C_SHIFT = cbo_BC.EditValue.ToString();
                        model.D_STORAGE_DT = de_st.DateTime;
                        model.N_ORDER = bll_TRC_SLABWH_LOG.GetSLABCount(id, type2).Tables[0].Rows.Count + 1;
                        bll_TRC_SLABWH_LOG.Add(model);
                        bll_TRC_SLABWH_LOG.Upstatus(id, 0, Convert.ToInt32(model.N_ORDER));
                    }
                }
                MessageBox.Show("共出库" + row.Count() + "条，成功出库" + ycount + "条！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "钢坯调拨");//添加操作日志
                Query1();
                Query2();
                txt_XZZS.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

           
        }

        private void btn_Query2_Click(object sender, EventArgs e)
        {
            try
            {
                Query2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
        private void Query2()
        {
            DataTable dt = null;
            dt = bll_TRC_SLABWH_LOG.GetList(1, type2, txt_GZ2.Text, txt_ZXBZ1.Text, txt_LH2.Text).Tables[0];
            this.gc_GP2.DataSource = dt;
            this.gv_GP2.OptionsView.ColumnAutoWidth = false;
            this.gv_GP2.OptionsSelection.MultiSelect = true;
            gv_GP2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GP2.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GP2);
        }
        private void cbo_CK1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                sub.ImageComboBoxEditBindGPKQY(cbo_CK1.EditValue.ToString(), cbo_QY1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        /// <summary>
        /// 销售
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Shop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认销售？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int[] row = gv_GP1.GetSelectedRows();
                int ycount = 0;
                string ck = cbo_CK1.Text;
                string qy = cbo_QY1.Text;
                foreach (var item in row)
                {
                    DataRow dr = gv_GP1.GetDataRow(item);
                    string id = dr["C_ID"].ToString();
                    if (bll_TSC_SLAB_MAIN.Update(id, type2, ck, qy, "", ""))
                    {
                        ycount += 1;
                        Mod_TRC_SLABWH_LOG model = new Mod_TRC_SLABWH_LOG();
                        model.C_SLAB_MAIN_ID = id;
                        model.C_MOVE_TYPE = type2;
                        model.C_EMP_ID = RV.UI.UserInfo.userName;
                        model.C_FLOOR_BEFORE = dr["C_SLABWH_TIER_CODE"].ToString();
                        model.C_GROUP = cbo_BZ.EditValue.ToString();
                        model.C_SLABWH_AREA_CODE_BEFORE = dr["C_SLABWH_AREA_CODE"].ToString();
                        model.C_SLABWH_CODE_BEFORE = dr["C_SLABWH_CODE"].ToString();
                        model.C_SLABWH_LOC_CODE_BEFORE = dr["C_SLABWH_LOC_CODE"].ToString();
                        model.C_SHIFT = cbo_BC.EditValue.ToString();
                        model.D_STORAGE_DT = de_st.DateTime;
                        model.C_SALE_AREA = cbo_XSQX.Text;
                        model.C_TRANSPORTATION = cbo_YSFS.Text;
                        model.N_ORDER = bll_TRC_SLABWH_LOG.GetSLABCount(id, type2).Tables[0].Rows.Count + 1;
                        bll_TRC_SLABWH_LOG.Add(model);
                        bll_TRC_SLABWH_LOG.Upstatus(id, 0, Convert.ToInt32(model.N_ORDER));
                    }
                }
                MessageBox.Show("共销售" + row.Count() + "条，成功销售" + ycount + "条！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "钢坯销售");//添加操作日志
                Query1();
                Query2();
                txt_XZZS.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }

        private void btn_Retreat_Click(object sender, EventArgs e)
        {
            try
            {
                int[] row = gv_GP2.GetSelectedRows();
                int ycount = 0;
                foreach (var item in row)
                {
                    DataRow dr = gv_GP2.GetDataRow(item);
                    string slabid = dr["C_SLAB_MAIN_ID"].ToString();
                    int order = Convert.ToInt32(dr["N_ORDER"]);
                    DataTable dt = bll_TSC_SLAB_MAIN.GetList(slabid, "N", "", "", "", "", "", "", "").Tables[0];
                    #region model
                    Mod_TSC_SLAB_MAIN mod_TSC_SLAB_MAIN = new Mod_TSC_SLAB_MAIN();
                    mod_TSC_SLAB_MAIN.C_CCM_EMP_ID = dt.Rows[0]["C_CCM_EMP_ID"].ToString();
                    mod_TSC_SLAB_MAIN.C_CCM_GROUP = dt.Rows[0]["C_CCM_GROUP"].ToString();
                    mod_TSC_SLAB_MAIN.C_CCM_SHIFT = dt.Rows[0]["C_CCM_SHIFT"].ToString();
                    mod_TSC_SLAB_MAIN.C_CON_NO = dt.Rows[0]["C_CON_NO"].ToString();
                    mod_TSC_SLAB_MAIN.C_CUS_NAME = dt.Rows[0]["C_CUS_NAME"].ToString();
                    mod_TSC_SLAB_MAIN.C_CUS_NO = dt.Rows[0]["C_CUS_NO"].ToString();
                    mod_TSC_SLAB_MAIN.C_DESIGN_NO = dt.Rows[0]["C_DESIGN_NO"].ToString();
                    mod_TSC_SLAB_MAIN.C_ID = dt.Rows[0]["C_ID"].ToString();
                    mod_TSC_SLAB_MAIN.C_ISXM = dt.Rows[0]["C_ISXM"].ToString();
                    mod_TSC_SLAB_MAIN.C_IS_DEPOT = dt.Rows[0]["C_IS_DEPOT"].ToString();
                    mod_TSC_SLAB_MAIN.C_KP_ID = dt.Rows[0]["C_KP_ID"].ToString();
                    mod_TSC_SLAB_MAIN.C_MAT_CODE = dt.Rows[0]["C_MAT_CODE"].ToString();
                    mod_TSC_SLAB_MAIN.C_MAT_NAME = dt.Rows[0]["C_MAT_NAME"].ToString();
                    mod_TSC_SLAB_MAIN.C_MAT_TYPE = dt.Rows[0]["C_MAT_TYPE"].ToString();
                    mod_TSC_SLAB_MAIN.C_MOVE_TYPE = dt.Rows[0]["C_MOVE_TYPE"].ToString();
                    mod_TSC_SLAB_MAIN.C_ORD_NO = dt.Rows[0]["C_ORD_NO"].ToString();
                    mod_TSC_SLAB_MAIN.C_PLAN_ID = dt.Rows[0]["C_PLAN_ID"].ToString();
                    mod_TSC_SLAB_MAIN.C_QF_NAME = dt.Rows[0]["C_QF_NAME"].ToString();
                    mod_TSC_SLAB_MAIN.C_QGP_STATE = dt.Rows[0]["C_QGP_STATE"].ToString();
                    mod_TSC_SLAB_MAIN.C_QKP_STATE = dt.Rows[0]["C_QKP_STATE"].ToString();
                    mod_TSC_SLAB_MAIN.C_SC_STATE = dt.Rows[0]["C_SC_STATE"].ToString();
                    mod_TSC_SLAB_MAIN.C_SLABWH_AREA_CODE = dt.Rows[0]["C_SLABWH_AREA_CODE"].ToString();
                    mod_TSC_SLAB_MAIN.C_SLABWH_CODE = dt.Rows[0]["C_SLABWH_CODE"].ToString();
                    mod_TSC_SLAB_MAIN.C_SLABWH_LOC_CODE = dt.Rows[0]["C_SLABWH_LOC_CODE"].ToString();
                    mod_TSC_SLAB_MAIN.C_SLABWH_TIER_CODE = dt.Rows[0]["C_SLABWH_TIER_CODE"].ToString();
                    mod_TSC_SLAB_MAIN.C_SLAB_TYPE = dt.Rows[0]["C_SLAB_TYPE"].ToString();
                    mod_TSC_SLAB_MAIN.C_SPEC = dt.Rows[0]["C_SPEC"].ToString();
                    mod_TSC_SLAB_MAIN.C_STA_CODE = dt.Rows[0]["C_STA_CODE"].ToString();
                    mod_TSC_SLAB_MAIN.C_STA_DESC = dt.Rows[0]["C_STA_DESC"].ToString();
                    mod_TSC_SLAB_MAIN.C_STA_ID = dt.Rows[0]["C_STA_ID"].ToString();
                    mod_TSC_SLAB_MAIN.C_STD_CODE = dt.Rows[0]["C_STD_CODE"].ToString();
                    mod_TSC_SLAB_MAIN.C_STL_GRD = dt.Rows[0]["C_STL_GRD"].ToString();
                    mod_TSC_SLAB_MAIN.C_STL_GRD_PRE = dt.Rows[0]["C_STL_GRD_PRE"].ToString();
                    mod_TSC_SLAB_MAIN.C_STOCK_STATE = dt.Rows[0]["C_STOCK_STATE"].ToString();
                    mod_TSC_SLAB_MAIN.C_STOVE = dt.Rows[0]["C_STOVE"].ToString();
                    mod_TSC_SLAB_MAIN.C_WE_EMP_ID = dt.Rows[0]["C_WE_EMP_ID"].ToString();
                    mod_TSC_SLAB_MAIN.C_WE_GROUP = dt.Rows[0]["C_WE_GROUP"].ToString();
                    mod_TSC_SLAB_MAIN.C_WE_SHIFT = dt.Rows[0]["C_WE_SHIFT"].ToString();
                    mod_TSC_SLAB_MAIN.C_WL_EMP_ID = dt.Rows[0]["C_WL_EMP_ID"].ToString();
                    mod_TSC_SLAB_MAIN.C_WL_GROUP = dt.Rows[0]["C_WL_GROUP"].ToString();
                    mod_TSC_SLAB_MAIN.C_WL_SHIFT = dt.Rows[0]["C_WL_SHIFT"].ToString();
                    mod_TSC_SLAB_MAIN.C_XMGX = dt.Rows[0]["C_XMGX"].ToString();
                    mod_TSC_SLAB_MAIN.C_ZRBM = dt.Rows[0]["C_ZRBM"].ToString();
                    if (dt.Rows[0]["D_CCM_DATE"] != DBNull.Value)
                    {
                        mod_TSC_SLAB_MAIN.D_CCM_DATE = Convert.ToDateTime(dt.Rows[0]["D_CCM_DATE"]);
                    }
                    if (dt.Rows[0]["D_ESC_DATE"] != DBNull.Value)
                    {
                        mod_TSC_SLAB_MAIN.D_ESC_DATE = Convert.ToDateTime(dt.Rows[0]["D_ESC_DATE"]);
                    }
                    if (dt.Rows[0]["D_LSC_DATE"] != DBNull.Value)
                    {
                        mod_TSC_SLAB_MAIN.D_LSC_DATE = Convert.ToDateTime(dt.Rows[0]["D_LSC_DATE"]);
                    }

                    if (dt.Rows[0]["D_WE_DATE"] != DBNull.Value)
                    {
                        mod_TSC_SLAB_MAIN.D_WE_DATE = Convert.ToDateTime(dt.Rows[0]["D_WE_DATE"]);
                    }
                    if (dt.Rows[0]["D_WL_DATE"] != DBNull.Value)
                    {
                        mod_TSC_SLAB_MAIN.D_WL_DATE = Convert.ToDateTime(dt.Rows[0]["D_WL_DATE"]);
                    }
                    if (dt.Rows[0]["N_LEN"] != DBNull.Value)
                    {
                        mod_TSC_SLAB_MAIN.N_LEN = Convert.ToDecimal(dt.Rows[0]["N_LEN"]);
                    }
                    if (dt.Rows[0]["N_QUA"] != DBNull.Value)
                    {
                        mod_TSC_SLAB_MAIN.N_QUA = Convert.ToDecimal(dt.Rows[0]["N_QUA"]);
                    }
                    if (dt.Rows[0]["N_WGT"] != DBNull.Value)
                    {
                        mod_TSC_SLAB_MAIN.N_WGT = Convert.ToDecimal(dt.Rows[0]["N_WGT"]);
                    }
                    if (dt.Rows[0]["N_WGT_METER"] != DBNull.Value)
                    {
                        mod_TSC_SLAB_MAIN.N_WGT_METER = Convert.ToDecimal(dt.Rows[0]["N_WGT_METER"]);
                    }
                    #endregion
                    DataTable dt1 = bll_TRC_SLABWH_LOG.GetListByID(slabid, "").Tables[0];
                    mod_TSC_SLAB_MAIN.C_MOVE_TYPE = type1;
                    mod_TSC_SLAB_MAIN.C_SLABWH_CODE = dt1.Rows[0]["C_SLABWH_CODE_BEFORE"].ToString();
                    mod_TSC_SLAB_MAIN.C_SLABWH_AREA_CODE = dt1.Rows[0]["C_SLABWH_AREA_CODE_BEFORE"].ToString();
                    mod_TSC_SLAB_MAIN.C_SLABWH_LOC_CODE = dt1.Rows[0]["C_SLABWH_LOC_CODE_BEFORE"].ToString();
                    mod_TSC_SLAB_MAIN.C_SLABWH_TIER_CODE = dt1.Rows[0]["C_FLOOR_BEFORE"].ToString();
                    if (bll_TSC_SLAB_MAIN.Update(mod_TSC_SLAB_MAIN))
                    {
                        bll_TRC_SLABWH_LOG.Upstatus(slabid, 1, order - 1);
                        bll_TRC_SLABWH_LOG.Upstatus(slabid, 0, order - 1);
                        ycount += 1;
                    }
                }
                MessageBox.Show("共撤回" + row.Count() + "条，成功撤回" + ycount + "条！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "撤销钢坯调拨或者销售信息");//添加操作日志
                Query1();
                Query2();
                txt_CHZS.Text = "0";
                txt_XZZS.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }

        private void gv_GP2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                txt_CHZS.Text = gv_GP2.GetSelectedRows().Count().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                type2 = "D";
                if (xtraTabControl1.SelectedTabPage.Name == "XS")
                {
                    type2 = "S";
                }
                Query1();
                Query2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }
    }
}
