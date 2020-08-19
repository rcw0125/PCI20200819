using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using Common;

namespace XGCAP.UI.P.PO.XCKWT
{
    public partial class FrmPO_XCKWT : Form
    {
        public FrmPO_XCKWT()
        {
            InitializeComponent();
        }
        private Bll_TRC_ROLL_PRODCUT bll_roll_product = new Bll_TRC_ROLL_PRODCUT();
        private Bll_TPB_LINEWH bll_linewh = new Bll_TPB_LINEWH();//仓库
        private Bll_TPB_LINEWH_AREA bll_area = new Bll_TPB_LINEWH_AREA();//区域
        private Bll_TPB_LINEWH_LOC bll_loc = new Bll_TPB_LINEWH_LOC();//库位
        private Bll_TPB_LINEWH_TIER bll_tier = new Bll_TPB_LINEWH_TIER();//层
        private Bll_TPO_XCKWT_LAB bll_xckw_lab = new Bll_TPO_XCKWT_LAB();//线材库位图lab
        private void FrmPO_XCKWT_Load(object sender, EventArgs e)
        {
            BindCK();
        }

        /// <summary>
        /// 绑定仓库信息
        /// </summary>
        private void BindCK()
        {

            icbo_CK.Properties.Items.Clear();
            DataTable dt = bll_linewh.GetListByStatus(1).Tables[0]; 
            icbo_CK.Properties.Items.Add("全部", "全部", -1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                icbo_CK.Properties.Items.Add(dt.Rows[i]["C_LINEWH_CODE"].ToString(), dt.Rows[i]["C_LINEWH_CODE"].ToString(), -1);
            }

            icbo_CK.SelectedIndex = 0;


        }

        /// <summary>
        /// 仓库选择变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void icbo_CK_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindQY();
        }

        /// <summary>
        /// 绑定区域信息
        /// </summary>
        private void BindQY()
        {
            icbo_QY.Properties.Items.Clear();
            DataTable dt = bll_area.GetListByLineWHID(icbo_CK.EditValue.ToString(), 1).Tables[0];

            icbo_QY.Properties.Items.Add("全部", "全部", -1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                icbo_QY.Properties.Items.Add(dt.Rows[i]["C_LINEWH_AREA_CODE"].ToString(), dt.Rows[i]["C_LINEWH_AREA_CODE"].ToString(), -1);
            }

            icbo_QY.SelectedIndex = 0;


        }
        /// <summary>
        /// 库位信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            WaitingFrom.ShowWait("");
            DataTable dt = bll_loc.GetList_KW(icbo_CK.EditValue.ToString().Trim(), icbo_QY.EditValue.ToString().Trim()).Tables[0];
            gc_XCKW.DataSource = dt;
            gv_XCKW.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_XCKW);
            WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 获取线材实绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_XCKW_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = this.gv_XCKW.GetDataRow(this.gv_XCKW.FocusedRowHandle);
            if (dr == null)
            {
                gc_SJXX.DataSource = null;
                return;
            }
            DataTable dt = bll_roll_product.GetList_KW_Group(dr["C_LINEWH_LOC_CODE"].ToString()).Tables[0];
            gc_SJXX.DataSource = dt;
            gv_SJXX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_SJXX);
        }

    }
}
