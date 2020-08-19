﻿using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_KHJWH1 : Form
    {
        public FrmPB_KHJWH1()
        {
            InitializeComponent();
        }
        Bll_TPB_STEEL_PRO_CONDITION bll_TPB_STEEL_PRO_CONDITION = new Bll_TPB_STEEL_PRO_CONDITION();
        Bll_TPB_STEEL_PRO_CONDITION bll_steel_pro = new Bll_TPB_STEEL_PRO_CONDITION();
        Bll_TPB_BORDER_GRD bll_border_grd = new Bll_TPB_BORDER_GRD();
        private void FrmPB_KHJWH1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //查询当前分组号所在的钢种
            DataTable dt = bll_TPB_STEEL_PRO_CONDITION.GetListbyGP(txt_gp.Text.Trim()).Tables[0];
            string msg = "";
            if (dt.Rows.Count > 0)
            {
                msg += "分组：" + txt_gp.Text.Trim() + "\r\n";
                foreach (DataRow item in dt.Rows)
                {
                    msg += item["C_STL_GRD"] + "(" + item["C_STD_CODE"] + ");";
                }
            }
            else
            {
                msg += "新建分组：" + txt_gp.Text.Trim() + "\r\n";
            }

            int[] grdrow = gv_Route.GetSelectedRows();
            if (grdrow.Count() > 0)
            {
                msg += "变更数据" + "\r\n";
                foreach (var grditem in grdrow)
                {
                    string grd = gv_Route.GetRowCellValue(grditem, "C_STL_GRD").ToString();
                    string std = gv_Route.GetRowCellValue(grditem, "C_STD_CODE").ToString();
                    bll_TPB_STEEL_PRO_CONDITION.UPKHJ(grd, std, txt_gp.Text.Trim());
                    msg += grd + "(" + std + ");";
                }
                MessageBox.Show(msg);
            }
            else
            {
                msg = "未选中行！";
                MessageBox.Show(msg);
                return;
            }

        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }
        private void Query()
        {
            DataTable dt = null;
            dt = bll_TPB_STEEL_PRO_CONDITION.GetList(txt_grd.Text.Trim(), txt_std.Text.Trim(), txt_group.Text.Trim()).Tables[0];
            this.gc_Route.DataSource = dt;
            this.gv_Route.OptionsView.ColumnAutoWidth = false;
            this.gv_Route.OptionsSelection.MultiSelect = true;
            gv_Route.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_Route.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Route);
        }

        private void btn_DCZLTSFG_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_Route);
        }

        private void btn_QueryR_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dtmain = bll_steel_pro.GetList_Query("", txt_GZ2.Text.Trim(), txt_ZXBZ2.Text.Trim()).Tables[0];
                this.gc_Main.DataSource = dtmain;

                gv_Main.OptionsView.ColumnAutoWidth = false;
                gv_Main.OptionsView.RowAutoHeight = true;

                gv_Main.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Main);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        ///相邻钢种查询
        /// </summary>
        /// <param name="dr"></param>
        private void NewMethod(DataRow dr)
        {
            DataTable dt = bll_border_grd.GetList_Query(dr["C_ID"].ToString()).Tables[0];
            this.gc_TPB_BORDER_GRD.DataSource = dt;

            gv_TPB_BORDER_GRD.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_TPB_BORDER_GRD);
        }

        private void gv_Main_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_Main.GetDataRow(this.gv_Main.FocusedRowHandle);
            if (dr != null)
            {
                NewMethod(dr);//相邻钢种
            }
            else
            {
                gc_TPB_BORDER_GRD.DataSource = null;
            }
        }

        Bll_APS_LGPC bll = new Bll_APS_LGPC();
        private void btn_auto_group_Click(object sender, EventArgs e)
        {

            bll.updateALL();
        }
    }
}
