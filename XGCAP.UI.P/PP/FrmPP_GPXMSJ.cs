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
    public partial class FrmPP_GPXMSJ : Form
    {
        public FrmPP_GPXMSJ()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TPP_SLAB_PLAN_XM bll_TPP_SLAB_PLAN_XM = new Bll_TPP_SLAB_PLAN_XM();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        Bll_TSC_SLAB_MAIN_XM bll_TSC_SLAB_MAIN_XM = new Bll_TSC_SLAB_MAIN_XM();
        string planid = "";
        private void FrmPP_GPXMSJ_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                sub.ImageComboBoxEditBindGWByGX("修磨", cbo_XMX);
                Query1();
                Query2();
                Query3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
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
        private void Query1()
        {
            DataTable dt = null;
            dt = bll_TPP_SLAB_PLAN_XM.GetList("").Tables[0];
            this.gc_GPXMJH.DataSource = dt;
            this.gv_GPXMJH.OptionsView.ColumnAutoWidth = false;
            this.gv_GPXMJH.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GPXMJH);
        }
        private void Query2()
        {
            int selectedHandle = this.gv_GPXMJH.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                return;
            }
            string grd = this.gv_GPXMJH.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();//获取焦点行钢种
            string std = this.gv_GPXMJH.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();//获取焦点行执行标准
            txt_XMZS.Text = this.gv_GPXMJH.GetRowCellValue(selectedHandle, "N_QTY").ToString();//获取计划支数
            planid = this.gv_GPXMJH.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取计划号
            DataTable dt = null;
            dt = bll_TSC_SLAB_MAIN.GetList("", "", "", "", "", grd, std, "E", "570").Tables[0];
            this.gc_GP1.DataSource = dt;
            this.gv_GP1.OptionsView.ColumnAutoWidth = false;
            this.gv_GP1.OptionsSelection.MultiSelect = true;
            gv_GP1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_GP1.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GP1);
        }
    

        private void gv_GPXMJH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
                if (DialogResult.No == MessageBox.Show("是否确认保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
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
                    mod_TSC_SLAB_MAIN.C_MOVE_TYPE = "MN";
                    if (bll_TSC_SLAB_MAIN.Update(mod_TSC_SLAB_MAIN))
                    {
                        ycount += 1;
                        Mod_TSC_SLAB_MAIN_XM model = new Mod_TSC_SLAB_MAIN_XM();
                        model.C_SLAB_MAIN_PLAN_ID = planid;
                        model.C_STA_ID = cbo_XMX.EditValue.ToString();
                        model.C_XMGX = cbo_XMGX.EditValue.ToString();
                        model.D_ACT_START_TIME = de_st.DateTime;
                        model.D_ACT_END_TIME = de_et.DateTime;
                        model.N_BFZS = Convert.ToDecimal(txt_BFZS.Text == "" ? "0" : txt_BFZS.Text);
                        model.C_BC = cbo_BC.Text;
                        model.C_BZ = cbo_BZ.Text;
                        model.N_XMZS = Convert.ToDecimal(txt_XZZS.Text == "" ? "0" : txt_XZZS.Text);
                        bll_TSC_SLAB_MAIN_XM.Add(model);
                    }
                }
                MessageBox.Show("开坯" + row.Count() + "条，成功开坯" + ycount + "条！");
                Query1();
                Query2();
                Query3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
            
        }
        private void Query3()
        {
            DataTable dt = null;
            dt = bll_TSC_SLAB_MAIN_XM.GetList("").Tables[0];
            this.gc_GPXMSJ.DataSource = dt;
            this.gv_GPXMSJ.OptionsView.ColumnAutoWidth = false;
            this.colC_STA_ID1.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_GPXMSJ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GPXMSJ);
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

        private void btn_reset_area_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认撤回？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
        }
    }
}
