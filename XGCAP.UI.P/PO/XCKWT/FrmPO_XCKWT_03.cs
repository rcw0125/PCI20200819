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
    public partial class FrmPO_XCKWT_03 : Form
    {
        public FrmPO_XCKWT_03()
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
            DataTable dt = bll_TRC_Roll_Product.GetList_RK_KW(BatchNo, kw, "","603").Tables[0];
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
            DataTable dt = bll_TRC_Roll_Product.GetList_LXC("60301",str[0], str[1]).Tables[0];
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
            
            DataTable dt_01_12 = bll_TRC_Roll_Product.GetList_LXC("60301","1", "12").Tables[0];
            DataTable dt_13_21 = bll_TRC_Roll_Product.GetList_LXC("60301","13", "21").Tables[0];
            labelControl17.Text = "1\r\n\r\n至\r\n\r\n12" + "\r\n——\r\n" + dt_01_12.Rows.Count;//-------线材库库位卷数
            labelControl1.Text = "13\r\n\r\n至\r\n\r\n21" + "\r\n——\r\n" + dt_13_21.Rows.Count;
           
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
                        if (dt_01_12.Rows.Count > cou)
                        {
                            labelControl17.ForeColor = Color.Red;
                        }
                        if (dt_13_21.Rows.Count > cou)
                        {
                            labelControl1.ForeColor = Color.Red;
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
