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
    public partial class FrmPO_GPCHLK : Form
    {
        public FrmPO_GPCHLK()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        Bll_TRC_SLABWH_LOG bll_TRC_SLABWH_LOG = new Bll_TRC_SLABWH_LOG();
        string type1 = "E";
        string type2 = "NZ";
        private void FrmPO_GPCHLK_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
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
            dt = bll_TSC_SLAB_MAIN.GetList("", "", "", "F", txt_LH1.Text, txt_GZ1.Text, txt_ZXBZ1.Text, type1,"").Tables[0];
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
                if (DialogResult.No == MessageBox.Show("是否确认？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
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
                    if (type2 == "D")
                    {
                        type2 += bll_TRC_SLABWH_LOG.GetDBCount(id, type2);
                    }
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
                Query1();
                Query2();
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
                        model.N_ORDER = bll_TRC_SLABWH_LOG.GetSLABCount(id, type2).Tables[0].Rows.Count + 1;
                        bll_TRC_SLABWH_LOG.Add(model);
                        bll_TRC_SLABWH_LOG.Upstatus(id, 0, Convert.ToInt32(model.N_ORDER));
                    }
                }
                MessageBox.Show("共销售" + row.Count() + "条，成功销售" + ycount + "条！");
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
            if (DialogResult.No == MessageBox.Show("是否确认撤销？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
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

        private void btn_Query1_Click_1(object sender, EventArgs e)
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
    }
}
