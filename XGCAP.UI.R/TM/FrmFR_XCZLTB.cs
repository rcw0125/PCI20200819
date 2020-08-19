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

namespace XGCAP.UI.R.TM
{
    public partial class FrmFR_XCZLTB : Form
    {
        public FrmFR_XCZLTB()
        {
            InitializeComponent();
        }

        Bll_Interface_FR bll_Interface_FR = new Bll_Interface_FR();
        Bll_TB_RF_SYNCWGT_LOG bll_TB_RF_SYNCWGT_LOG = new Bll_TB_RF_SYNCWGT_LOG();
        DataTable dt = null;
        DataTable dt2 = null;

        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            BindRf();
        }

        private void BindRf()
        {
            string batchNo = txt_Batch_No.Text;
            string gh = txt_Gh.Text;

            if (string.IsNullOrWhiteSpace(batchNo))
            {
                MessageBox.Show("请输入批次号进行查询！");
                return;
            }
            try
            {

                DataTable rf = bll_Interface_FR.RfXC(batchNo, gh).Tables[0];
                DataTable roll = bll_Interface_FR.RollPro(batchNo, gh).Tables[0];
                dt = rf.Clone();
                dt2 = roll.Clone();

                if (rf.Rows.Count == roll.Rows.Count)
                {

                    for (int i = 0; i < rf.Rows.Count; i++)
                    {
                        string rfGh = rf.Rows[i]["GH"].ToString();
                        DataRow[] dr = roll.Select(" C_TICK_NO='" + rfGh + "' ");
                        if (decimal.Parse(rf.Rows[i]["ZL"].ToString()) != decimal.Parse(dr[0]["N_WGT"].ToString()))
                        {
                            dt.Rows.Add(rf.Rows[i].ItemArray);
                            dt2.Rows.Add(dr[0].ItemArray);
                        }
                    }
                }

                this.gc_Rf.DataSource = dt;
                this.gv_Rf.OptionsView.ColumnAutoWidth = false;
                this.gv_Rf.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Rf);


                this.gc_RollPro.DataSource = dt2;
                this.gv_RollPro.OptionsView.ColumnAutoWidth = false;
                this.gv_RollPro.BestFitColumns();
                gv_RollPro.ColumnWidthChanged += Gv_RollPro_ColumnWidthChanged;
                SetGridViewRowNum.SetRowNum(gv_RollPro);
                gv_RollPro.OptionsSelection.MultiSelect = true;
                gv_RollPro.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Gv_RollPro_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //int selectedPlanHandle = this.gv_Rf.FocusedRowHandle;//获取RF焦点行索引
            //int selectedAllowGrd = this.gv_RollPro.FocusedRowHandle;//获取PCI焦点行索引
            //if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
            //{
            //    MessageBox.Show("请检查，记录为空!");
            //    return;
            //}
            //string zl = this.gv_Rf.GetRowCellValue(selectedPlanHandle, "ZL").ToString();
            //string rq = this.gv_Rf.GetRowCellValue(selectedPlanHandle, "RQ").ToString();
            //string pch = this.gv_Rf.GetRowCellValue(selectedPlanHandle, "PCH").ToString();
            //string rollId = this.gv_RollPro.GetRowCellValue(selectedAllowGrd, "C_ID").ToString();
            //if (bll_Interface_FR.UpdateWgt(rollId, decimal.Parse(zl), DateTime.Parse(rq)))
            //{
            //    Mod_TB_RF_SYNCWGT_LOG model = new Mod_TB_RF_SYNCWGT_LOG();
            //    model.C_BATCH_NO = pch;
            //    model.N_WGT = decimal.Parse(zl);
            //    model.C_EMP_ID = RV.UI.UserInfo.userID;
            //    model.C_EMP_NAME = RV.UI.UserInfo.userName;
            //    bll_TB_RF_SYNCWGT_LOG.Add(model);
            //    MessageBox.Show("操作成功");
            //    BindRf();
            //}
            //else
            //{
            //    MessageBox.Show("操作失败");
            //}

            try
            {
                string userID = RV.UI.UserInfo.userID;
                int[] rownumber = gv_RollPro.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length > 0)
                {
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        DataRow drRoll = gv_RollPro.GetDataRow(selectedHandle);
                        DataRow[] drRf = dt.Select(" GH='" + drRoll["C_TICK_NO"].ToString() + "' ");
                        string rollID = drRoll["C_ID"].ToString();
                        decimal wgt = decimal.Parse(drRoll["N_WGT"].ToString());
                        decimal zl = decimal.Parse(drRf[0]["ZL"].ToString());
                        string rq = drRf[0]["RQ"].ToString();
                        if (bll_Interface_FR.UpdateWgt(rollID, zl, DateTime.Parse(rq)))
                        {
                            Mod_TB_RF_SYNCWGT_LOG model = new Mod_TB_RF_SYNCWGT_LOG();
                            model.C_BATCH_NO = drRoll["C_BATCH_NO"].ToString();
                            model.N_WGT = zl;
                            model.C_EMP_ID = RV.UI.UserInfo.userID;
                            model.C_EMP_NAME = RV.UI.UserInfo.userName;
                            bll_TB_RF_SYNCWGT_LOG.Add(model);
                        }
                    }
                    MessageBox.Show("操作成功");
                    BindRf();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gv_Rf_Click(object sender, EventArgs e)
        {

            gc_RollPro.DataSource = null;
            this.gc_RollPro.DataSource = dt2;
            this.gv_RollPro.OptionsView.ColumnAutoWidth = false;
            this.gv_RollPro.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_RollPro);
            gv_RollPro.UnselectRow(0);
            int selectedPlanHandle = this.gv_Rf.FocusedRowHandle;//获取RF焦点行索引
            string GH = this.gv_Rf.GetRowCellValue(selectedPlanHandle, "GH") == null ? "" : this.gv_Rf.GetRowCellValue(selectedPlanHandle, "GH").ToString();
            int index = -1;
            if (dt2 == null || dt2.Rows.Count == 0)
            {
                return;
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt2.Rows[i]["C_TICK_NO"].ToString() == GH)
                    index = i;
            }
            this.gv_RollPro.SelectRow(index);
        }

        private void FrmFR_XCZLTB_Load(object sender, EventArgs e)
        {
            gv_Rf.OptionsCustomization.AllowSort = false;
            gv_RollPro.OptionsCustomization.AllowSort = false;
        }

        private void gv_RollPro_Click(object sender, EventArgs e)
        {
            gc_Rf.DataSource = null;
            this.gc_Rf.DataSource = dt;
            this.gv_Rf.OptionsView.ColumnAutoWidth = false;
            this.gv_Rf.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Rf);
            gv_Rf.UnselectRow(0);
            int selectedAllowGrd = this.gv_RollPro.FocusedRowHandle;//获取PCI焦点行索引
            string GH = this.gv_RollPro.GetRowCellValue(selectedAllowGrd, "C_TICK_NO") == null ? "" : this.gv_RollPro.GetRowCellValue(selectedAllowGrd, "C_TICK_NO").ToString();
            int index = -1;
            if (dt == null || dt.Rows.Count == 0)
            {
                return;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["GH"].ToString() == GH)
                    index = i;
            }
            gv_Rf.SelectRow(index);
        }
    }
}
