using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using BLL;
using DevExpress.XtraEditors.Controls;
using Common;

namespace XGCAP.UI.P.PO.GPKWT
{
    public partial class FrmPO_GPSJ : Form
    {
        /// <summary>
        /// 2018-05-03 zmc
        /// </summary>
        public FrmPO_GPSJ()
        {
            InitializeComponent();
        }

        Bll_TB_STA bll_sta = new Bll_TB_STA();
        Bll_GPSJ bll_gpsj = new Bll_GPSJ();
        CommonSub commonSub = new CommonSub();
        private void FrmQR_GPSJ_Load(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindStock(cbo_CK1);
            cbo_ZT.SelectedIndex = 0;
            //dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            //dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        private void BindGrdSj()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_gpsj.GetList_SJ_Group(txt_Stove.Text.Trim(), txt_STL.Text.Trim(), txt_STD.Text.Trim(), cbo_CK1.EditValue == null ? "" : cbo_CK1.EditValue.ToString(), null, cbo_MatType.EditValue == null ? "" : cbo_MatType.EditValue.ToString(), cbo_ZT.EditValue.ToString()).Tables[0];
                this.gc_PDJG.DataSource = dt;
                gv_PDJG.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_PDJG);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 判定结果查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindGrdSj();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //if (DialogResult.No == MessageBox.Show("确认保存吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            //{
            //    return;
            //}
            try
            {
                if (gv_PDJG.GetRow(gv_PDJG.FocusedRowHandle) == null) return;
                int selectedHandle = this.gv_PDJG.FocusedRowHandle;//获取计划焦点行索引
                string stove = this.gv_PDJG.GetRowCellValue(selectedHandle, "C_STOVE").ToString();//获取焦点炉号
                string batchNo = this.gv_PDJG.GetRowCellValue(selectedHandle, "C_BATCH_NO").ToString();//获取焦点批号
                string matCode = this.gv_PDJG.GetRowCellValue(selectedHandle, "C_MAT_CODE").ToString();//获取焦点物料编码
                string slabwhCode = this.gv_PDJG.GetRowCellValue(selectedHandle, "C_SLABWH_CODE").ToString();//获取焦点仓库编码
                string remark = this.txt_Remark.Text;
                string result = bll_gpsj.UpdateSlabRemark(stove, matCode, slabwhCode, remark, batchNo);
                if (result == "1")
                {
                    MessageBox.Show("操作成功");
                    BindGrdSj();
                }
                else
                {
                    MessageBox.Show("操作失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_PDJG_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {

                if (gv_PDJG.GetRow(e.RowHandle) == null)
                {
                    return;
                }
                else
                {
                    var dr = gv_PDJG.GetDataRow(e.RowHandle);
                    if (dr != null)
                    {
                        string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                        if (!string.IsNullOrWhiteSpace(remark))
                        {
                            e.Appearance.ForeColor = Color.Red;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gv_PDJG_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {

                if (gv_PDJG.GetRow(e.RowHandle) == null)
                {
                    return;
                }
                else
                {
                    //获取所在行指定列的值
                    var obj = gv_PDJG.GetRowCellValue(e.RowHandle, "C_REMARK");
                    string remark = obj == null ? "" : obj.ToString();
                    if (!string.IsNullOrWhiteSpace(remark))
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_PDJG_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {

                if (gv_PDJG.GetRow(e.FocusedRowHandle) == null) return;
                int selectedHandle = this.gv_PDJG.FocusedRowHandle;//获取计划焦点行索引
                string remark = this.gv_PDJG.GetRowCellValue(selectedHandle, "C_REMARK").ToString();//获取焦点备注
                this.txt_Remark.Text = remark;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DC_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_PDJG);
        }
    }
}
