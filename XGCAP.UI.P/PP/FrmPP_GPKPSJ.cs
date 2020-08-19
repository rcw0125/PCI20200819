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

namespace XGCAP.UI.P.PP
{
    public partial class FrmPP_GPKPSJ : Form
    {
        public FrmPP_GPKPSJ()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TPP_SLAB_PLAN_KP bll_TPP_SLAB_PLAN_KP = new Bll_TPP_SLAB_PLAN_KP();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        Bll_TSC_SLAB_MAIN_KP bll_TSC_SLAB_MAIN_KP = new Bll_TSC_SLAB_MAIN_KP();
        string planid = "";
        private void FrmPP_GPKPSJ_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                Query1();
                Query2();
                Query3();
                sub.ImageComboBoxEditBindGWByGX("开坯", cbo_KPX);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
      
        }
        private void Query1()
        {
            DataTable dt = null;
            dt = bll_TPP_SLAB_PLAN_KP.GetList("").Tables[0];
            this.gc_GPKPJH.DataSource = dt;
            this.gv_GPKPJH.OptionsView.ColumnAutoWidth = false;
            this.gv_GPKPJH.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GPKPJH);
        }
        private void Query2()
        {
            int selectedHandle = this.gv_GPKPJH.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                return;
            }
            string grd = this.gv_GPKPJH.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();//获取焦点行钢种
            string std = this.gv_GPKPJH.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();//获取焦点行执行标准
            txt_JHZS.Text= this.gv_GPKPJH.GetRowCellValue(selectedHandle, "N_QTY").ToString();//获取计划支数
            planid= this.gv_GPKPJH.GetRowCellValue(selectedHandle, "C_PLAN_ID").ToString();//获取计划号
           string sta = this.gv_GPKPJH.GetRowCellValue(selectedHandle, "C_STA_ID").ToString();//获取工序
            string slabwh = "";
            if (sta== "33AD76AADC184E1F9B8DD0539B09CDC6")
            {
                 slabwh = "526";            
            }
            if (sta == "1ED8E5A18B854429B1246B4AFA8426FE")
            {
                 slabwh = "530";
            }
            DataTable dt = null;
            dt = bll_TSC_SLAB_MAIN.GetList("","","","","",grd,std,"E", slabwh).Tables[0];
            this.gc_GP1.DataSource = dt;
            this.gv_GP1.OptionsView.ColumnAutoWidth = false;
            this.gv_GP1.OptionsSelection.MultiSelect = true;
            gv_GP1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_GP1.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GP1);
        }

        private void btn_Query_Click(object sender, EventArgs e)
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

        private void gv_GPKPJH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
                foreach (var item in row)
                {
                    DataRow dr = gv_GP1.GetDataRow(item);
                    string id = dr["C_ID"].ToString();
                    Mod_TSC_SLAB_MAIN mod_TSC_SLAB_MAIN = bll_TSC_SLAB_MAIN.GetModel(id);
                    mod_TSC_SLAB_MAIN.C_MOVE_TYPE = "KP";
                    if (bll_TSC_SLAB_MAIN.Update(mod_TSC_SLAB_MAIN))
                    {
                        ycount += 1;
                        Mod_TSC_SLAB_MAIN_KP model = new Mod_TSC_SLAB_MAIN_KP();

                        model.C_SLAN_PLAN_KP_ID = planid;
                        model.C_STA_ID = cbo_KPX.EditValue.ToString();
                        model.C_SPEC = dr["C_SPEC"].ToString();
                        model.N_LEN = Convert.ToDecimal(dr["N_LEN"]);
                        model.N_QUA = Convert.ToDecimal(dr["N_QUA"]);
                        model.N_WGT = Convert.ToDecimal(dr["N_WGT"]);
                        model.D_ACT_START_TIME = de_st.DateTime;
                        model.D_ACT_END_TIME = de_et.DateTime;
                        model.N_BFZS = Convert.ToDecimal(txt_BFZS.Text == "" ? "0" : txt_BFZS.Text);
                        model.C_BC = cbo_BC.Text;
                        model.C_BZ = cbo_BZ.Text;
                        bll_TSC_SLAB_MAIN_KP.Add(model);
                        mod_TSC_SLAB_MAIN.C_MOVE_TYPE = "PN";
                        bll_TSC_SLAB_MAIN.Add(mod_TSC_SLAB_MAIN);
                        bll_TSC_SLAB_MAIN.Add(mod_TSC_SLAB_MAIN);
                    }
                }
                MessageBox.Show("开坯" + row.Count() + "条，成功开坯" + ycount + "条！");
                Query1();
                Query2();
                Query3();
                txt_XZZS.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
        private void Query3()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TSC_SLAB_MAIN_KP.GetList("").Tables[0];
                this.gc_GPKPSJ.DataSource = dt;
                this.gv_GPKPSJ.OptionsView.ColumnAutoWidth = false;
                this.colC_STA_ID1.ColumnEdit = sub.GetGWIdDescItemComboBox();
                this.gv_GPKPSJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPKPSJ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
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
    }
}
