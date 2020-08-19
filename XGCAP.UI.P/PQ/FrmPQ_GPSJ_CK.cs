using BLL;
using Common;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PQ
{
    public partial class FrmPQ_GPSJ_CK : Form
    {
        public FrmPQ_GPSJ_CK()
        {
            InitializeComponent();
        }
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        CommonSub commonSub = new CommonSub();
        Bll_GPSJ bll_gpsj = new Bll_GPSJ();

        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }
        private void Query()
        {
            WaitingFrom.ShowWait("");
            DataTable dt = null;
            dt = bll_TSC_SLAB_MAIN.GetSJ("全部", "", txt_GZ.Text.Trim(), "", txt_LH.Text.Trim(), cbo_CK1.EditValue.ToString(), "在库中", "全部", "全部", "全部").Tables[0];
            dt = LinqSortDataTable(dt);
            this.gc_GPSJ.DataSource = dt;
            this.gv_GPSJ.OptionsView.ColumnAutoWidth = false;
            this.gv_GPSJ.OptionsSelection.MultiSelect = true;
            gv_GPSJ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GPSJ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GPSJ);
            WaitingFrom.CloseWait();
        }

        public DataTable LinqSortDataTable(DataTable tmpDt)
        {
            DataTable dtsort = tmpDt.Clone();
            dtsort = tmpDt.Rows.Cast<DataRow>().OrderBy(r => Convert.ToDecimal(r["C_SLABWH_LOC_CODE"])).ThenBy(r => Convert.ToDecimal(r["C_SLABWH_TIER_CODE"])).CopyToDataTable();
            return dtsort;
        }


        private void FrmPQ_GPSJ_Load(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindStock(cbo_CK1);
            cbo_CK1.SelectedIndex = 0;

        }

        private void btn_DCGW_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_GPSJ, "钢坯库存" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //if (DialogResult.No == MessageBox.Show("确认保存吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            //{
            //    return;
            //}

            int selectedHandle = this.gv_GPSJ.FocusedRowHandle;//获取计划焦点行索引
            string stove = this.gv_GPSJ.GetRowCellValue(selectedHandle, "C_STOVE").ToString();//获取焦点炉号
            string batchNo = this.gv_GPSJ.GetRowCellValue(selectedHandle, "C_BATCH_NO").ToString();//获取焦点批号
            string matCode = this.gv_GPSJ.GetRowCellValue(selectedHandle, "C_MAT_CODE").ToString();//获取焦点物料编码
            string slabwhCode = this.gv_GPSJ.GetRowCellValue(selectedHandle, "C_SLABWH_CODE").ToString();//获取焦点仓库编码
            string remark = this.txt_Remark.Text;
            string result = bll_gpsj.UpdateSlabRemark(stove, matCode, slabwhCode, remark, batchNo);
            if (result == "1")
            {
                MessageBox.Show("操作成功");
                Common.UserLog.AddLog(RV.UI.UserInfo.menuName, this.Name, this.Text, "添加钢坯备注常：炉号（" + stove + "）；开坯号（" + batchNo + "）；备注（" + remark + "）");//添加操作日志
                Query();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

        private void gv_GPSJ_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (gv_GPSJ.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                var dr = gv_GPSJ.GetDataRow(e.RowHandle);
                if (dr != null)
                {
                    string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                    string yc = dr["C_KP_ID"] == null ? "" : dr["C_KP_ID"].ToString();
                    if (!string.IsNullOrWhiteSpace(remark) || !string.IsNullOrEmpty(yc))
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                }

            }
        }

        private void gv_GPSJ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_GPSJ.GetRow(e.FocusedRowHandle) == null) return;
            int selectedHandle = this.gv_GPSJ.FocusedRowHandle;//获取计划焦点行索引
            string remark = this.gv_GPSJ.GetRowCellValue(selectedHandle, "C_REMARK").ToString();//获取焦点备注
            this.txt_Remark.Text = remark;

        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            GridHitInfo hitInfo = gv_GPSJ.CalcHitInfo(e.ControlMousePosition);
            if (hitInfo.RowHandle < 0 || hitInfo.Column == null || hitInfo.HitTest != GridHitTest.RowCell)
            {
                toolTipController1.HideHint();
                return;
            }
            int selectedHandle = this.gv_GPSJ.FocusedRowHandle;//获取计划焦点行索引
            string stove = this.gv_GPSJ.GetRowCellValue(selectedHandle, "C_STOVE").ToString();//获取焦点炉号
            var dt = bll_gpsj.GetSlabInfo(stove);
            if (dt.Rows.Count > 0)
            {
                string message = "入坑："+dt.Rows[0]["D_ESC_DATE"].ToString();
                message += "  出坑： " + dt.Rows[0]["D_LSC_DATE"].ToString();
                e.Info = new ToolTipControlInfo("", message);
            }
        }
    }
}
