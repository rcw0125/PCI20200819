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

namespace XGCAP.UI.P.PO.XCKWT
{
    public partial class FrmPO_XCKWT_05 : Form
    {
        public FrmPO_XCKWT_05()
        {
            InitializeComponent();
        }
        Bll_TPB_LINEWH_LOC Bll_TPB_LINEWH_LOC = new Bll_TPB_LINEWH_LOC();//线材库位
        Bll_TRC_ROLL_PRODCUT bll_TRC_Roll_Product = new Bll_TRC_ROLL_PRODCUT();//线材实绩
        /// <summary>
        /// 查询库位明细
        /// </summary>
        /// <param name="BatchNo">批号</param>
        /// <param name="kw">库位号</param>
        private void Query(string BatchNo, string kw)
        {
            DataTable dt = bll_TRC_Roll_Product.GetList_RK_KW(BatchNo, kw, "", "605").Tables[0];
            gc_SJXX.DataSource = dt;
            gv_SJXX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_SJXX);
        }
        /// <summary>
        /// 线材库位明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lab_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LabelControl lab_id = (DevExpress.XtraEditors.LabelControl)sender;
            string BatchNo = txt_BatchNo.Text.Trim();
            string kw = lab_id.AccessibleDescription;
            Query(BatchNo, kw);
        }
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPO_XCKWT_Load(object sender, EventArgs e)
        {
            DataTable dt_1_10 = bll_TRC_Roll_Product.GetList_LXC("60501", "1", "10").Tables[0];
            
            foreach (var item in this.pnlMain.Controls)
            {
                if (item is DevExpress.XtraEditors.LabelControl)
                {
                    DevExpress.XtraEditors.LabelControl lbla = item as DevExpress.XtraEditors.LabelControl;
                    if (!string.IsNullOrEmpty(lbla.AccessibleDescription))
                    {
                        labelControl1.Text = "10\r\n\r\n至\r\n\r\n1" + "\r\n——\r\n" + dt_1_10.Rows.Count;
                        lbla.Text = lbla.AccessibleDescription + "\r\n——\r\n" + "0";
                    }
                }
            }

            //-------线材库库位卷数
            DataTable dt = Bll_TPB_LINEWH_LOC.GetAllList().Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in this.pnlMain.Controls)
                    {
                        if (item is DevExpress.XtraEditors.LabelControl)
                        {
                            DevExpress.XtraEditors.LabelControl lbla = item as DevExpress.XtraEditors.LabelControl;
                            if (!string.IsNullOrEmpty(lbla.AccessibleDescription) && lbla.AccessibleDescription == dt.Rows[i]["C_LINEWH_LOC_CODE"].ToString().Trim())
                            {
                                DataTable dt_con = bll_TRC_Roll_Product.GetList_RK_KW("", lbla.AccessibleDescription, "", "605").Tables[0];
                                lbla.Text = dt.Rows[i]["C_LINEWH_LOC_CODE"].ToString().Trim() + "\r\n——\r\n" + dt_con.Rows.Count;
                                if (dt_con.Rows.Count > Convert.ToInt32(dt.Rows[i]["N_QTY"].ToString()))
                                {
                                    lbla.ForeColor = Color.Red;
                                }
                                if (dt_1_10.Rows.Count > Convert.ToInt32(dt.Rows[i]["N_QTY"].ToString()))
                                {
                                    labelControl1.ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                }
            }

        }
        /// <summary>
        /// 刷新库位图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmPO_XCKWT_Load(null, null);
        }

        /// <summary>
        /// 查询实绩信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click_1(object sender, EventArgs e)
        {
            string BatchNo = txt_BatchNo.Text.Trim();
            string kw = "";
            Query(BatchNo, kw);
        }
        /// <summary>
        /// 查询1-10库位的实绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelControl1_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LabelControl lab_id = (DevExpress.XtraEditors.LabelControl)sender;
            string kw = lab_id.AccessibleDescription;
            string[] str = kw.Split(',');
            DataTable dt = bll_TRC_Roll_Product.GetList_LXC("60501", str[0], str[1]).Tables[0];
            gc_SJXX.DataSource = dt;
            gv_SJXX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_SJXX);
        }
    }
}
