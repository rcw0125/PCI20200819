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
using XGCAP.UI.P.PB;
using XGCAP.UI.Q.QB;

namespace XGCAP.UI.P.PQ
{
    public partial class FrmPQ_BFWHGL : Form
    {
        public FrmPQ_BFWHGL()
        {
            InitializeComponent();
        }
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();
        Bll_TPB_SLAB_CAPACITY bll_TPB_SLAB_CAPACITY = new Bll_TPB_SLAB_CAPACITY();
        Bll_TPB_STATION_CAPACITY bll_TPB_STATION_CAPACITY = new Bll_TPB_STATION_CAPACITY();
        CommonSub commonSub = new CommonSub();
        private void FrmPQ_BFWHGL_Load(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindGX("", cbo_GX2, "'CC'");
            cbo_GX2.SelectedIndex = 0;
            commonSub.ImageComboBoxEditBindGX("", cbo_GX, "'ZX'");
            cbo_GX.SelectedIndex = 0;
        }
        private void btn_QueryM_Click(object sender, EventArgs e)
        {
            QueryM();
        }
        private void QueryM()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TQB_STD_MAIN.GetListByWWH().Tables[0];
                this.gc_GYLX.DataSource = dt;
                this.gv_GYLX.OptionsView.ColumnAutoWidth = false;
                this.gv_GYLX.OptionsSelection.MultiSelect = true;
                gv_GYLX.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                //this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox(); //翻译工位
                this.gv_GYLX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GYLX);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_GPDC_Click(object sender, EventArgs e)
        {
            QueryGPDC();
        }

        private void QueryGPDC()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TQB_STD_MAIN.GetListByWWHGPDC().Tables[0];
                this.gc_GPDC.DataSource = dt;
                this.gv_GPDC.OptionsView.ColumnAutoWidth = false;
                this.gv_GPDC.OptionsSelection.MultiSelect = true;
                gv_GPDC.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                //this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox(); //翻译工位
                this.gv_GYLX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPDC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_QueryTS_Click(object sender, EventArgs e)
        {
            QueryTS();
        }
        private void QueryTS()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TQB_STD_MAIN.GetListByWWHTSTJ().Tables[0];
                this.gc_TSTJ.DataSource = dt;
                this.gv_TSTJ.OptionsView.ColumnAutoWidth = false;
                this.gv_TSTJ.OptionsSelection.MultiSelect = true;
                gv_TSTJ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                //this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox(); //翻译工位
                this.gv_TSTJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_TSTJ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_QueryGPCN_Click(object sender, EventArgs e)
        {
            QueryGPCN();
        }
        private void QueryGPCN()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TQB_STD_MAIN.GetListByWWHGPCN().Tables[0];
                this.gc_GPJSCN.DataSource = dt;
                this.gv_GPJSCN.OptionsView.ColumnAutoWidth = false;
                this.gv_GPJSCN.OptionsSelection.MultiSelect = true;
                gv_GPJSCN.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                //this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox(); //翻译工位
                this.gv_GPJSCN.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPJSCN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_QueryZGCN_Click(object sender, EventArgs e)
        {
            QueryZGCN();
        }
        private void QueryZGCN()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TQB_STD_MAIN.GetListByWWHZXCN().Tables[0];
                this.gc_ZGCN.DataSource = dt;
                this.gv_ZGCN.OptionsView.ColumnAutoWidth = false;
                this.gv_ZGCN.OptionsSelection.MultiSelect = true;
                gv_ZGCN.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                //this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox(); //翻译工位
                this.gv_ZGCN.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZGCN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_WHGYLX_Click(object sender, EventArgs e)
        {
            FrmQB_GYLX frm = new FrmQB_GYLX();
            frm.Show();
        }

        private void btn_WHGPDC_Click(object sender, EventArgs e)
        {
            FrmQB_ZXBZ frm = new FrmQB_ZXBZ();
            frm.Show();
        }

        private void FrmPB_WHTS_Click(object sender, EventArgs e)
        {
            FrmPB_GZSCTJ frm = new FrmPB_GZSCTJ();
            frm.Show();
        }

        private void btn_WHGPCN_Click(object sender, EventArgs e)
        {
            if (txt_JSCN.Text=="0")
            {
                MessageBox.Show("产能不能为0！");
                return;
            }
            int[] rownumber = this.gv_GPJSCN.GetSelectedRows();//获取选中行号数组；
            int succount = 0;
            string str = "";
            if (rownumber.Count() > 0)
            {
                foreach (var item in rownumber)
                {
                    Mod_TPB_SLAB_CAPACITY mod_TPB_SLAB_CAPACITY = new Mod_TPB_SLAB_CAPACITY();
                    mod_TPB_SLAB_CAPACITY.C_STL_GRD = gv_GPJSCN.GetRowCellValue(item, "C_STL_GRD") == null ? null : gv_GPJSCN.GetRowCellValue(item, "C_STL_GRD").ToString();
                    mod_TPB_SLAB_CAPACITY.C_STD_CODE = gv_GPJSCN.GetRowCellValue(item, "C_STD_CODE") == null ? null : gv_GPJSCN.GetRowCellValue(item, "C_STD_CODE").ToString();
                    mod_TPB_SLAB_CAPACITY.C_TYPE = cbo_ys.EditValue.ToString();
                    mod_TPB_SLAB_CAPACITY.C_STA_ID = cbo_GW2.EditValue.ToString();
                    mod_TPB_SLAB_CAPACITY.N_CAPACITY = Convert.ToDecimal(txt_JSCN.Text);
                    mod_TPB_SLAB_CAPACITY.C_EMP_ID = RV.UI.UserInfo.userID;

                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_STA_ID", mod_TPB_SLAB_CAPACITY.C_STA_ID);
                    ht.Add("C_STL_GRD", mod_TPB_SLAB_CAPACITY.C_STL_GRD);
                    ht.Add("C_STD_CODE", mod_TPB_SLAB_CAPACITY.C_STD_CODE);
                    ht.Add("N_STATUS", 1);
                    if (Common.CheckRepeat.CheckTable("TPB_SLAB_CAPACITY", ht) > 0)
                    {
                        str += mod_TPB_SLAB_CAPACITY.C_PROD_NAME + "(" + mod_TPB_SLAB_CAPACITY.C_STL_GRD + "/" + mod_TPB_SLAB_CAPACITY.C_STD_CODE + "),";
                    }
                    else
                    {
                        bll_TPB_SLAB_CAPACITY.Add(mod_TPB_SLAB_CAPACITY);
                        succount += 1;
                    }
                    #endregion
                }
                if (str.Length > 0)
                {
                    MessageBox.Show("共" + rownumber.Count() + "条数据，维护成功" + succount + "条," + str.Substring(0, str.Length - 1) + "已存在！");
                    QueryGPCN();
                }
                else
                {
                    MessageBox.Show("维护成功！");
                    QueryGPCN();
                }
            }
        }

        private void cbo_GX2_SelectedValueChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindGW(cbo_GX2.EditValue.ToString(), cbo_GW2);
            cbo_GW2.SelectedIndex = 0;
        }

        private void cbo_GX_SelectedValueChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindGW(cbo_GX.EditValue.ToString(), cbo_GW);
            cbo_GW.SelectedIndex = 0;
        }

        private void btn_WHZGCN_Click(object sender, EventArgs e)
        {
            if (txt_CN.Text == "0")
            {
                MessageBox.Show("产能不能为0！");
                return;
            }
            int[] rownumber = this.gv_ZGCN.GetSelectedRows();//获取选中行号数组；
            int succount = 0;
            string str = "";
            if (rownumber.Count() > 0)
            {
                foreach (var item in rownumber)
                {
                    Mod_TPB_STATION_CAPACITY mod_TPB_STATION_CAPACITY = new Mod_TPB_STATION_CAPACITY();
                    mod_TPB_STATION_CAPACITY.C_STA_ID = cbo_GW.EditValue.ToString();
                    mod_TPB_STATION_CAPACITY.C_SPEC = this.gv_ZGCN.GetRowCellValue(item, "C_SPEC") == null ? "" : this.gv_ZGCN.GetRowCellValue(item, "C_SPEC").ToString();
                    mod_TPB_STATION_CAPACITY.C_STL_GRD = this.gv_ZGCN.GetRowCellValue(item, "C_STL_GRD") == null ? "" : this.gv_ZGCN.GetRowCellValue(item, "C_STL_GRD").ToString();
                    mod_TPB_STATION_CAPACITY.C_STD_CODE = this.gv_ZGCN.GetRowCellValue(item, "C_STD_CODE") == null ? "" : this.gv_ZGCN.GetRowCellValue(item, "C_STD_CODE").ToString();
                    mod_TPB_STATION_CAPACITY.N_CAPACITY = Convert.ToDecimal(txt_CN.Text);
                    mod_TPB_STATION_CAPACITY.C_EMP_ID = RV.UI.UserInfo.userID;
                    if (bll_TPB_STATION_CAPACITY.ExistsDate(mod_TPB_STATION_CAPACITY.C_STA_ID, mod_TPB_STATION_CAPACITY.C_STL_GRD, mod_TPB_STATION_CAPACITY.C_SPEC))
                    {
                        str += mod_TPB_STATION_CAPACITY.C_STL_GRD +",";
                    }
                    else
                    {
                        bll_TPB_STATION_CAPACITY.Add(mod_TPB_STATION_CAPACITY);
                        succount += 1;
                    }
                }
                if (str.Length > 0)
                {
                    MessageBox.Show("共" + rownumber.Count() + "条数据，保存成功" + succount + "条," + str.Substring(0, str.Length - 1) + "已存在！");

                    QueryZGCN();
                }
                else
                {
                    MessageBox.Show("共" + rownumber.Count() + "条数据，保存成功" + succount + "条");
                    QueryZGCN();
                }
            }
        }

        private void cbo_GW2_SelectedValueChanged(object sender, EventArgs e)
        {
            cbo_ys.SelectedIndex = 0;
        }

        private void btn_DCZXBZGG_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_GPDC);
        }

        private void btn_DCGYLX_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_GYLX);
        }

        private void btn_DCTSTJ_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_TSTJ);
        }

        private void btn_DCGPCN_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_GPJSCN);
        }

        private void btn_DCZGCN_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_ZGCN);
        }
    }
}
