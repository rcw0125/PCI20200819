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

namespace XGCAP.UI.P.PO.GPKWT
{
    public partial class FrmPO_GPKWT_520 : Form
    {
        public FrmPO_GPKWT_520()
        {
            InitializeComponent();
        }
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();//钢坯实绩
        Bll_TPB_SLABWH_LOC bll_TPB_SLABWH_LOC = new Bll_TPB_SLABWH_LOC();//钢坯库位
        

        /// <summary>
        /// 查询库位详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click_1(object sender, EventArgs e)
        {
            DataTable dt = bll_TSC_SLAB_MAIN.GetList_LH_KW(txt_Stove.Text,"").Tables[0];
            gc_GPSJ.DataSource = dt;
            gv_GPSJ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GPSJ);
        }
        
        /// <summary>
        /// 线材库位明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lab_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LabelControl lab_id = (DevExpress.XtraEditors.LabelControl)sender;
            DataTable dt_con = bll_TSC_SLAB_MAIN.GetList_KW("520",lab_id.AccessibleDescription ).Tables[0];
            gc_GPSJ.DataSource = dt_con;
            gv_GPSJ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GPSJ);
        }
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPO_XCKWT_Load(object sender, EventArgs e)
        {
            foreach (var item in this.pnlMain.Controls)
            {
                if (item is DevExpress.XtraEditors.LabelControl)
                {
                    DevExpress.XtraEditors.LabelControl lbla = item as DevExpress.XtraEditors.LabelControl;
                    if (!string.IsNullOrEmpty(lbla.AccessibleDescription))
                    {
                        lbla.Text = lbla.AccessibleDescription + "\r\n——\r\n" + "0";
                    }
                }
            }

            //-------线材库库位卷数
            DataTable dt = bll_TPB_SLABWH_LOC.GetAllList().Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in this.pnlMain.Controls)
                    {
                        if (item is DevExpress.XtraEditors.LabelControl)
                        {
                            DevExpress.XtraEditors.LabelControl lbla = item as DevExpress.XtraEditors.LabelControl;
                            if (!string.IsNullOrEmpty(lbla.AccessibleDescription) && lbla.AccessibleDescription == dt.Rows[i]["C_SLABWH_LOC_CODE"].ToString().Trim())
                            {
                                DataTable dt_con = bll_TSC_SLAB_MAIN.GetList_KW("520" ,lbla.AccessibleDescription).Tables[0];
                                lbla.Text = dt.Rows[i]["C_SLABWH_LOC_CODE"].ToString().Trim() + "\r\n——\r\n" + dt_con.Rows.Count;
                                if (dt_con.Rows.Count > Convert.ToInt32(dt.Rows[i]["N_SLABWH_LOC_CAP"].ToString()))
                                {
                                    lbla.ForeColor = Color.Red;
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

    }
}
