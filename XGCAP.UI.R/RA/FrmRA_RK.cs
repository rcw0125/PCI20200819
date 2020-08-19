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

namespace XGCAP.UI.R.RA
{
    public partial class FrmRA_RK : Form
    {
        Bll_TSC_SLAB_MAIN bllTscSlabMain = new Bll_TSC_SLAB_MAIN();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();
        Bll_TPB_SLABWH_AREA Bll_TPB_SLABWH_AREA = new BLL.Bll_TPB_SLABWH_AREA();//钢坯库区域信息
        Bll_TPB_SLABWH_LOC Bll_TPB_SLABWH_LOC = new BLL.Bll_TPB_SLABWH_LOC();//钢坯库库位信息
        private Bll_TPB_SLABWH_TIER bll_TPB_SLABWH_TIER = new Bll_TPB_SLABWH_TIER();//钢坯库层信息
        private Bll_TSC_SLAB_MOVE bllTscSlabMove = new Bll_TSC_SLAB_MOVE();

        CommonSub commoonSub = new CommonSub();
        string strStoveNum = "";//炉
        string stacode = "";
        string slabwhCode = "";//仓库
        string slabwhID = "";//仓库ID
        string strMenuName = "";

        public FrmRA_RK()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            slabwhCode = arr[0];
            slabwhID = bll_TPB_SLABWH.GetList_id(slabwhCode);
            stacode = arr[1];
        }

        private void FrmRA_RK_Load(object sender, EventArgs e)
        {
            //UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            dt_Rk_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_Rk_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            commoonSub.ImageComboBoxEditBindNCBC(cbo_Shift, stacode);
            commoonSub.ImageComboBoxEditBindNCBZ(cbo_Group, stacode);
            commoonSub.BCBZBindEdit(cbo_Shift, cbo_Group, stacode);
            BindStoreArea();
            BindStoreArea2();
            BindStoreLoc();
            BindStoreTier();
            BindSlabList();
        }

        /// <summary>
        /// 绑定仓库区域
        /// </summary>
        public void BindStoreArea()
        {
            DataTable dt = Bll_TPB_SLABWH_AREA.GetListBySlabwhID(slabwhID).Tables[0];
            image_Area.Properties.Items.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    this.image_Area.Properties.Items.Add(item["C_SLABWH_AREA_NAME"].ToString(), item["C_SLABWH_AREA_CODE"], -1);
                }
            }
            this.image_Area.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定仓库区域
        /// </summary>
        public void BindStoreArea2()
        {
            DataTable dt = Bll_TPB_SLABWH_AREA.GetListBySlabwhID(slabwhID).Tables[0];
            img_area.Properties.Items.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.img_area.Properties.Items.Add("全部", "全部", 0);
                foreach (DataRow item in dt.Rows)
                {
                    this.img_area.Properties.Items.Add(item["C_SLABWH_AREA_NAME"].ToString(), item["C_SLABWH_AREA_CODE"], -1);
                }
            }
            this.img_area.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定仓库库位
        /// </summary>
        public void BindStoreLoc()
        {
            string areaCode = this.image_Area.EditValue == null ? "" : this.image_Area.EditValue.ToString();
            string areaID = "";
            DataTable dt = null;
            if (!string.IsNullOrWhiteSpace(areaCode))
            {
                areaID = Bll_TPB_SLABWH_AREA.GetList_ID(areaCode);
                dt = Bll_TPB_SLABWH_LOC.GetListByArea(areaID, 1).Tables[0];
            }
            image_Loc.Properties.Items.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    this.image_Loc.Properties.Items.Add(item["C_SLABWH_LOC_NAME"].ToString(), item["C_SLABWH_LOC_CODE"], -1);
                }
            }
            this.image_Loc.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定仓库层
        /// </summary>
        public void BindStoreTier()
        {
            string locCode = this.image_Loc.EditValue == null ? "" : this.image_Loc.EditValue.ToString();
            //string locID = ""; 
            if (!string.IsNullOrWhiteSpace(locCode))
            {
                DataTable dt = bllTscSlabMain.GetList_LocNum(locCode).Tables[0];
                if (dt.Rows[0]["COU"].ToString() == "0")
                {
                    strStoveNum = "1";
                }
                else
                {
                    strStoveNum = (Convert.ToInt32(dt.Rows[0]["COU"].ToString()) + 1).ToString();
                }
                //locID = Bll_TPB_SLABWH_LOC.GetListByLocID(locCode, 1);
                //dt = bll_TPB_SLABWH_TIER.GetListByKW(locID).Tables[0];
            }
            //image_Tier.Properties.Items.Clear();
            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    foreach (DataRow item in dt.Rows)
            //    {
            //        string code = item["C_SLABWH_TIER_CODE"].ToString();
            //        code = code.Substring(code.Length - 2);
            //        this.image_Tier.Properties.Items.Add(code, item["C_SLABWH_TIER_CODE"], -1);
            //    }
            //}
            //this.image_Tier.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定待入库信息
        /// </summary>
        public void BindSlabList()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Slab.DataSource = null;
                BindStoreTier();
                DataTable dt = bllTscSlabMain.Get_DB_List(txt_Grd.Text.Trim(), txt_Stove.Text.Trim(), txt_Spec.Text.Trim(), slabwhCode, "", "").Tables[0];

                gc_Slab.DataSource = dt;

                SetGridViewRowNum.SetRowNum(gv_Slab);

                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        /// <summary>
        /// 绑定入库记录
        /// </summary>
        private void BindSlabRK()
        {
            WaitingFrom.ShowWait("");

            string area = this.img_area.EditValue.ToString();//地区

            DataTable dt = bllTscSlabMove.Get_RK_Log(slabwhCode, txt_Stove_Rk.Text.Trim(), dt_Rk_Start.Text.Trim(), dt_Rk_End.Text.Trim(), area).Tables[0];

            gc_Move.DataSource = dt;

            SetGridViewRowNum.SetRowNum(gv_Move);

            WaitingFrom.CloseWait();
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

            DataRow dr = gv_Slab.GetDataRow(gv_Slab.FocusedRowHandle);

            if (dr == null)
            {
                MessageBox.Show("请选择需要入库的数据!");
                return;
            }

            if (string.IsNullOrEmpty(image_Area.Text.Trim()))
            {
                MessageBox.Show("请选择区域!");
                return;
            }

            //if (string.IsNullOrEmpty(image_Loc.Text.Trim()))
            //{
            //    MessageBox.Show("请选择库位!");
            //    return;
            //} 
            //if (string.IsNullOrEmpty(txt_Tier.Text.Trim()))
            //{
            //    MessageBox.Show("请输入层!");
            //    return;
            //}

            string area = this.image_Area.EditValue.ToString();//区域
            string locCode = this.image_Loc.EditValue == null ? "" : this.image_Loc.EditValue.ToString();
            //string locID = ""; 
            if (!string.IsNullOrWhiteSpace(locCode))
            {
                DataTable dt = bllTscSlabMain.GetList_LocNum(locCode).Tables[0];
                if (dt.Rows[0]["COU"].ToString() == "0")
                {
                    strStoveNum = "1";
                }
                else
                {
                    strStoveNum = (Convert.ToInt32(dt.Rows[0]["COU"].ToString()) + 1).ToString();
                }
                //locID = Bll_TPB_SLABWH_LOC.GetListByLocID(locCode, 1);
                //dt = bll_TPB_SLABWH_TIER.GetListByKW(locID).Tables[0];
            }
            string kw = this.image_Loc.EditValue == null ? "" : this.image_Loc.EditValue.ToString();//库位
            string floor = strStoveNum;//层
            string shift = this.cbo_Shift.EditValue.ToString();//班次
            string group = this.cbo_Group.EditValue.ToString();//班组
            string remark = this.txt_Remark.Text.ToLower();

            int errorNum = 0;//TryParse 输出参数
            string putNum = txt_PutNum.Text.Trim();
            if (!Int32.TryParse(putNum, out errorNum))
            {
                MessageBox.Show("调拨支数只能是整数!");
                return;
            }

            if (Convert.ToInt32(putNum) > Convert.ToInt32(dr["N_QUA"].ToString()))
            {
                MessageBox.Show("入库支数不能超过调拨钢坯总数!");
                return;
            }

            WaitingFrom.ShowWait("");

            string result = bllTscSlabMove.Add_RK(dr, Convert.ToInt32(putNum), slabwhCode, area, kw, floor, shift, group, Application.StartupPath, remark);
            if (result == "1")
            {
                BindSlabList();
                BindSlabRK();

                this.txt_Remark.Text = "";
                MessageBox.Show("操作成功!");

            }
            else
            {
                MessageBox.Show(result);
            }

            WaitingFrom.CloseWait();
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
                DataRow dr = gv_Slab.GetDataRow(gv_Slab.FocusedRowHandle);
                if (dr != null)
                {
                    txt_PutNum.Text = dr["N_QUA"].ToString();
                    txt_Remark.Text = dr["C_REMARK"].ToString();
                }
                else
                {
                    txt_Remark.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Query_Slab_Click(object sender, EventArgs e)
        {
            BindSlabList();
        }

        private void btn_Query_RK_Click(object sender, EventArgs e)
        {
            BindSlabRK();
        }

        private void gv_Slab_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_Slab.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_Slab.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_Slab_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_Slab.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_Move_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_Move.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_Move_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_Move.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_Move.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }
        /// <summary>
        /// 保存备注——LOG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认保存吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            int selectedPlanHandle = this.gv_Move.FocusedRowHandle;//获取焦点行索引
            string stove = this.gv_Move.GetRowCellValue(selectedPlanHandle, "C_STOVE").ToString();//获取焦点炉号
            string remark = txt_Remark.Text;
            if (bll_TPB_SLABWH.UpdateRemark(stove, remark))
            {
                MessageBox.Show("操作成功");
            }
            else
            {
                MessageBox.Show("操作失败");
            }
            txt_Remark.Text = "";
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            Common.OutToExcel.ToExcel(this.gc_Slab);
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_min_Click(object sender, EventArgs e)
        {
            Common.OutToExcel.ToExcel(this.gc_Move);
        }
    }
}
