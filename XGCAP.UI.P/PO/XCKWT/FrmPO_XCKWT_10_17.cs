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
    public partial class FrmPO_XCKWT_10_17 : Form
    {
        public FrmPO_XCKWT_10_17()
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
            DataTable dt = bll_TRC_Roll_Product.GetList_RK_KW(BatchNo, kw, "61017", "612").Tables[0];
            gc_SJXX.DataSource = dt;
            gv_SJXX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_SJXX);
        }
        /// <summary>
        /// 查询库位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lab_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LabelControl lab_id = (DevExpress.XtraEditors.LabelControl)sender;
            string kw = lab_id.AccessibleDescription;
            string[] str = kw.Split(',');
            DataTable dt = bll_TRC_Roll_Product.GetList_LXC("61017", str[0], str[1]).Tables[0];
            gc_SJXX.DataSource = dt;
            gv_SJXX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_SJXX);
        }
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPO_XCKWT_Load(object sender, EventArgs e)
        {
            

            DataTable dt_01_25 = bll_TRC_Roll_Product.GetList_LXC("61017", "1", "25").Tables[0];
            DataTable dt_26_50 = bll_TRC_Roll_Product.GetList_LXC("61017", "26", "50").Tables[0];
            DataTable dt_51_75 = bll_TRC_Roll_Product.GetList_LXC("61017", "51", "75").Tables[0];
            DataTable dt_76_99 = bll_TRC_Roll_Product.GetList_LXC("61017", "76", "99").Tables[0];
            labelControl17.Text = "25\r\n\r\n至\r\n\r\n1" + "\r\n——\r\n" + dt_01_25.Rows.Count;//-------线材库库位卷数
            labelControl1.Text = "50\r\n\r\n至\r\n\r\n26" + "\r\n——\r\n" + dt_26_50.Rows.Count;
            labelControl2.Text = "75\r\n\r\n至\r\n\r\n51" + "\r\n——\r\n" + dt_51_75.Rows.Count;
            labelControl3.Text = "99\r\n\r\n至\r\n\r\n76" + "\r\n——\r\n" + dt_76_99.Rows.Count;

            foreach (var item in this.pnlMain.Controls)
            {
                if (item is DevExpress.XtraEditors.LabelControl)
                {
                    DevExpress.XtraEditors.LabelControl lbla = item as DevExpress.XtraEditors.LabelControl;
                    if (!string.IsNullOrEmpty(lbla.AccessibleDescription))
                    {
                        string kw = lbla.AccessibleDescription;
                        string[] str = kw.Split(',');

                        int cou = Bll_TPB_LINEWH_LOC.GetList_SUM(str[0], str[1]);
                        if (dt_01_25.Rows.Count > cou)
                        {
                            labelControl17.ForeColor = Color.Red;
                        }
                        if (dt_26_50.Rows.Count > cou)
                        {
                            labelControl1.ForeColor = Color.Red;
                        }
                        if (dt_51_75.Rows.Count > cou)
                        {
                            labelControl2.ForeColor = Color.Red;
                        }
                        if (dt_76_99.Rows.Count > cou)
                        {
                            labelControl3.ForeColor = Color.Red;
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

         
    }
}
