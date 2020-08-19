using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;
using Common;

namespace XGCAP.UI.P.PO.GPKWT
{
    public partial class FrmPO_GPKWT : Form
    {
        private Bll_TPB_SLABWH bllTPB_SLABWH = new Bll_TPB_SLABWH();
        private Bll_TPB_SLABWH_AREA bllTPB_SLABWH_AREA = new Bll_TPB_SLABWH_AREA();
        private Bll_TPB_SLABWH_LOC bllTPB_SLABWH_LOC = new Bll_TPB_SLABWH_LOC();
        private Bll_TPB_SLABWH_TIER bllTPB_SLABWH_TIER = new Bll_TPB_SLABWH_TIER();
        private Bll_TPO_GPKWT_LAB bllTPO_GPKWT_LAB = new Bll_TPO_GPKWT_LAB();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();//钢坯实绩

        public FrmPO_GPKWT()
        {
            InitializeComponent();
        }

        private void FrmPO_GPKWT_Load(object sender, EventArgs e)
        {
            BindCK();
        }


        /// <summary>
        /// 绑定仓库信息
        /// </summary>
        private void BindCK()
        {

            icbo_CK.Properties.Items.Clear();
            DataTable dt = bllTPB_SLABWH.GetListByStatus(1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                icbo_CK.Properties.Items.Add("全部", "全部", -1);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    icbo_CK.Properties.Items.Add(dt.Rows[i]["C_SLABWH_CODE"].ToString() + "-" + dt.Rows[i]["C_SLABWH_NAME"].ToString() , dt.Rows[i]["C_SLABWH_CODE"].ToString(), -1);
                }

                icbo_CK.SelectedIndex = 0;
            }
            else
            {
                icbo_CK.Properties.Items.Clear();
            }
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
            icbo_QY.Properties.Items.Add("全部", "全部", -1);
            DataTable dt = bllTPB_SLABWH_AREA.GetListBySlabWHID(icbo_CK.EditValue.ToString(), 1).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                icbo_QY.Properties.Items.Add(dt.Rows[i]["C_SLABWH_AREA_CODE"].ToString() + "-" + dt.Rows[i]["C_SLABWH_AREA_NAME"].ToString() , dt.Rows[i]["C_SLABWH_AREA_CODE"].ToString(), -1);
            }

            icbo_QY.SelectedIndex = 0;
        }


        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            DataTable dt = new DataTable();
            if (this.rbtn_isty_wh.SelectedIndex == 0)//钢坯库/缓冷坑 查询
            {
                dt = bllTPB_SLABWH_LOC.GetList_count(icbo_CK.EditValue.ToString().Trim(), icbo_QY.Text.Trim(), "钢坯库").Tables[0];
            }
            else
            {
                dt = bllTPB_SLABWH_LOC.GetList_count(icbo_CK.EditValue.ToString().Trim(), icbo_QY.EditValue.ToString().ToString(), "缓冷坑").Tables[0];
            }
            gc_GPKW.DataSource = dt;
            gv_GPKW.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GPKW);
            WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 获取钢坯实绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_GPKW_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = this.gv_GPKW.GetDataRow(this.gv_GPKW.FocusedRowHandle);
            if (dr == null)
            {
                gc_GPSJ.DataSource = null;
                return;
            }
            DataTable dt = bll_TSC_SLAB_MAIN.GetList_KW_Group(dr["C_SLABWH_LOC_CODE"].ToString()).Tables[0];
            gc_GPSJ.DataSource = dt;
            gv_GPSJ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GPSJ);
        }
    }
}
