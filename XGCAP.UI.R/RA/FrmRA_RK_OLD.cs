using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.R.RA
{
    public partial class FrmRA_RK_OLD : Form
    {
        string slabwhCode = "";//仓库
        string slabwhID = "";//仓库ID

        public FrmRA_RK_OLD()
        {
            InitializeComponent();
            slabwhCode = RV.UI.QueryString.parameter;
            slabwhID = bll_TPB_SLABWH.GetList_id(slabwhCode);
        }

        Bll_TSC_SLAB_MAIN bll = new Bll_TSC_SLAB_MAIN();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();
        Bll_TPB_SLABWH_AREA Bll_TPB_SLABWH_AREA = new BLL.Bll_TPB_SLABWH_AREA();//钢坯库区域信息
        Bll_TPB_SLABWH_LOC Bll_TPB_SLABWH_LOC = new BLL.Bll_TPB_SLABWH_LOC();//钢坯库库位信息
        private BLL.Bll_TPB_SLABWH_TIER bll_TPB_SLABWH_TIER = new BLL.Bll_TPB_SLABWH_TIER();//钢坯库层信息

        private void FrmRA_RK_OLD_Load(object sender, EventArgs e)
        {
            BindAllotBillet();
            BindStoreArea();
            BindStoreLoc();
            BindStoreTier();
            BindTime();
            BindPutBillet();
        }

        /// <summary>
        /// 绑定仓库区域
        /// </summary>
        public void BindStoreArea()
        {
            DataTable dt = Bll_TPB_SLABWH_AREA.GetListBySlabwhID(slabwhID).Tables[0];
            image_Area.Properties.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                this.image_Area.Properties.Items.Add(item["C_SLABWH_AREA_NAME"].ToString() + "-" + item["C_SLABWH_AREA_CODE"].ToString(), item["C_SLABWH_AREA_CODE"], -1);
            }
            this.image_Area.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定仓库库位
        /// </summary>
        public void BindStoreLoc()
        {
            string areaCode = this.image_Area.EditValue.ToString();
            string areaID = "";
            DataTable dt = null;
            if (!string.IsNullOrWhiteSpace(areaCode))
            {
                areaID = Bll_TPB_SLABWH_AREA.GetList_ID(areaCode);
                dt = Bll_TPB_SLABWH_LOC.GetListByArea(areaID, 1).Tables[0];
            }
            image_Loc.Properties.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                this.image_Loc.Properties.Items.Add(item["C_SLABWH_LOC_NAME"].ToString() + "-" + item["C_SLABWH_LOC_CODE"].ToString(), item["C_SLABWH_LOC_CODE"], -1);
            }
            this.image_Loc.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定仓库层
        /// </summary>
        public void BindStoreTier()
        {
            string locCode = this.image_Loc.EditValue.ToString();
            string locID = "";
            DataTable dt = null;
            if (!string.IsNullOrWhiteSpace(locCode))
            {
                locID = Bll_TPB_SLABWH_LOC.GetListByLocID(locCode, 1);
                dt = bll_TPB_SLABWH_TIER.GetListByKW(locID).Tables[0];
            }
            image_Tier.Properties.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                this.image_Tier.Properties.Items.Add(item["C_SLABWH_TIER_CODE"].ToString(), item["C_SLABWH_TIER_CODE"], -1);
            }
            this.image_Tier.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定调拨钢坯数据
        /// </summary>
        public void BindAllotBillet()
        {
            string grd = this.txt_Grd.Text;
            string spec = this.txt_Spec.Text;
            string std = this.txt_Std.Text;
            DataTable dt = bll.GetPutData(slabwhCode, grd, std, spec).Tables[0];
            this.gc_Put.DataSource = dt;
            this.gv_Put.OptionsView.ColumnAutoWidth = false;
            this.gv_Put.BestFitColumns();
        }

        /// <summary>
        /// 绑定入库信息
        /// </summary>
        public void BindPutBillet()
        {
            DataTable dt = bll.GetPutData(slabwhCode, this.dt_Start.DateTime, this.dt_End.DateTime).Tables[0];
            this.gc_PutCenter.DataSource = dt;
            this.gv_PutCenter.OptionsView.ColumnAutoWidth = false;
            this.gv_PutCenter.BestFitColumns();
        }

        /// <summary>
        /// 绑定查询时间
        /// </summary>
        public void BindTime()
        {
            this.dt_Start.DateTime = DateTime.Now.AddDays(-10);
            this.dt_End.DateTime = DateTime.Now;
        }

        /// <summary>
        /// 入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PutStore_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认入库吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_Put.FocusedRowHandle;//获取计划焦点行索引
            int selectedAllowGrd = this.gv_Put.FocusedRowHandle;//获取可轧钢种焦点行索引
            if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
            {
                MessageBox.Show("请检查入库信息，记录为空!");
                return;
            }
            string stove = this.gv_Put.GetRowCellValue(selectedPlanHandle, "C_STOVE").ToString();//获取焦点炉号
            string num = this.gv_Put.GetRowCellValue(selectedPlanHandle, "N_QUA").ToString();//获取焦点调拨支数            
            string grd = this.gv_Put.GetRowCellValue(selectedPlanHandle, "C_STL_GRD").ToString();//获取焦点钢种
            string std = this.gv_Put.GetRowCellValue(selectedPlanHandle, "C_STD_CODE").ToString();//获取焦点执行标准
            string spec = this.gv_Put.GetRowCellValue(selectedPlanHandle, "C_SPEC").ToString();//获取焦点规格
            string matCode = this.gv_Put.GetRowCellValue(selectedPlanHandle, "C_MAT_CODE").ToString();//获取焦点物料编码
            string area = this.image_Area.EditValue.ToString();//区域
            string loc = this.image_Loc.EditValue.ToString();//库位
            string tier = this.image_Tier.EditValue.ToString();//层
            string shift = this.cbo_Shift.EditValue.ToString();//班次
            string group = this.cbo_Group.EditValue.ToString();//班组

            int errorNum = 0;//TryParse 输出参数
            string putNum = txt_PutNum.Text.Trim();
            if (!Int32.TryParse(putNum, out errorNum))
            {
                MessageBox.Show("调拨支数只能是整数!");
                return;
            }

            if (Convert.ToInt32(putNum) > Convert.ToInt32(num))
            {
                MessageBox.Show("入库支数不能超过调拨钢坯总数!");
                return;
            }
            else
                num = putNum;

            string result = bll.PutStoreHandler(stove, Convert.ToInt32(num), grd, std, spec, matCode, area, loc, tier, shift, group, slabwhCode);
            if (result == "1")
            {
                BindAllotBillet();
                BindPutBillet();
                MessageBox.Show("操作成功!");
            }
            else
            {
                MessageBox.Show("操作失败!");
            }

        }

        private void image_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindStoreLoc();
            BindStoreTier();
        }

        private void image_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindStoreTier();
        }

        private void gv_Put_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_Put.GetDataRow(gv_Put.FocusedRowHandle);
                if (dr != null)
                {
                    txt_PutNum.Text = dr["N_QUA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_PutStoreQuery_Click(object sender, EventArgs e)
        {
            BindPutBillet();
        }

        private void btn_AllotQuery_Click(object sender, EventArgs e)
        {
            BindAllotBillet();
        }
    }
}
