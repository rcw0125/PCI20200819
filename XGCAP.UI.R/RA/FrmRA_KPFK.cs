using BLL;
using Common;
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
    public partial class FrmRA_KPFK : Form
    {
        public FrmRA_KPFK()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staID = bll_TB_STA.GetStaIdByCode(arr[0]);
            stacode = arr[0];
            slbwhCode = arr[1];
            notSlbwhCode = arr[2];
        }
        string strStoveNum = "";
        string stacode = "";
        string staID = "";//工位ID
        string slbwhCode = "";//合格坯仓库库位编码
        string notSlbwhCode = "";//不合格坯仓库库位编码
        CommonSub commonSub = new CommonSub();
        private Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TPB_STA_WH bll_TPB_STA_WH = new Bll_TPB_STA_WH();
        Bll_TSC_SLAB_MAIN bllTscSlabMain = new Bll_TSC_SLAB_MAIN();
        private Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();
        Bll_TRC_COGDOWN_MAIN bll_TRC_COGDOWN_MAIN = new Bll_TRC_COGDOWN_MAIN();
        Bll_TPB_SLABWH_AREA Bll_TPB_SLABWH_AREA = new BLL.Bll_TPB_SLABWH_AREA();//钢坯库区域信息
        Bll_TPB_SLABWH_LOC Bll_TPB_SLABWH_LOC = new BLL.Bll_TPB_SLABWH_LOC();//钢坯库库位信息
        private Bll_TPB_SLABWH_TIER bll_TPB_SLABWH_TIER = new Bll_TPB_SLABWH_TIER();//钢坯库层信息

        private void FrmRA_KPFK_Load(object sender, EventArgs e)
        {
            dt_Fk_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_Fk_End.EditValue = DateTime.Now.AddHours(1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            commonSub.ImageComboBoxEditBindNCBC(icbo_Shift, stacode);
            commonSub.ImageComboBoxEditBindNCBZ(icbo_Group, stacode);
            commonSub.BCBZBindEdit(icbo_Shift, icbo_Group, stacode);
            BindStore();
            BindSlabList();
            BindToSlabList();
        }

        /// <summary>
        /// 绑定仓库
        /// </summary>
        public void BindStore()
        {
            DataTable dt = bll_TPB_SLABWH.GetList_KP().Tables[0];
            //DataRow[] dr = dt.Select("C_SLABWH_CODE='" + slbwhCode + "'   or   C_SLABWH_CODE='" + notSlbwhCode + "' ");
            image_Store.Properties.Items.Clear();
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    image_Store.Properties.Items.Add(item["C_SLABWH_CODE"].ToString() + item["C_SLABWH_NAME"].ToString(), item["C_SLABWH_CODE"], -1);
                }
            }
        }

        /// <summary>
        /// 绑定仓库区域
        /// </summary>
        public void BindStoreArea()
        {
            string slabwhID = bll_TPB_SLABWH.GetList_id(image_Store.EditValue.ToString());
            DataTable dt = Bll_TPB_SLABWH_AREA.GetListBySlabwhID(slabwhID).Tables[0];
            image_Area.Properties.Items.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    this.image_Area.Properties.Items.Add(item["C_SLABWH_AREA_CODE"].ToString() + item["C_SLABWH_AREA_NAME"].ToString(), item["C_SLABWH_AREA_CODE"], -1);
                }
            }
            this.image_Area.SelectedIndex = 0;
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
        /// 绑定可调拨钢坯数据
        /// </summary>
        public void BindSlabList()
        {
            try
            {
                WaitingFrom.ShowWait("");
                BindStoreTier();
                DataTable dt = bll_TRC_COGDOWN_MAIN.GetCogDownFact_Stove(1, staID, "", "", txt_Stove.Text.Trim(), txt_Grd.Text.Trim(), txt_Spec.Text.Trim()).Tables[0];
                this.gc_Fk.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Fk);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 绑定已调拨钢坯数据
        /// </summary>
        public void BindToSlabList()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bll_TRC_COGDOWN_MAIN.GetCogDownFact_Stove(2, staID, dt_Fk_Start.Text.Trim(), dt_Fk_End.Text.Trim(), txt_Stove_Fk.Text.Trim(), "", "").Tables[0];
                this.gc_Move.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Move);

                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        private void gv_Fk_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_Fk.GetDataRow(gv_Fk.FocusedRowHandle);
            if (dr != null)
            {
                if (string.IsNullOrWhiteSpace(this.txt_AllotNum.Text))
                    this.txt_AllotNum.Text = (Convert.ToInt32(dr["N_QUA"])).ToString();
                else if (Convert.ToInt32(this.txt_AllotNum.Text) > Convert.ToInt32(dr["N_QUA"].ToString()))
                {
                    this.txt_AllotNum.Text = (Convert.ToInt32(dr["N_QUA"])).ToString();
                }

                this.image_Store.EditValue = slbwhCode;
            }
        }

        private void btn_Fk_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, slbwhCode + "入库", "入库", "入库");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认入库吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            DataRow dr = gv_Fk.GetDataRow(gv_Fk.FocusedRowHandle);

            if (dr == null)
            {
                MessageBox.Show("请选择需要入库的数据!");
                return;
            }

            if (string.IsNullOrEmpty(this.image_Store.Text))
            {
                MessageBox.Show("请选择仓库!");
                return;
            }

            if (string.IsNullOrEmpty(icbo_Shift.Text))
            {
                MessageBox.Show("请选择班次!");
                return;
            }

            if (string.IsNullOrEmpty(icbo_Group.Text))
            {
                MessageBox.Show("请选择班组!");
                return;
            }

            string store = this.image_Store.EditValue.ToString();//仓库
            string area = this.image_Area.EditValue == null ? "" : this.image_Area.EditValue.ToString();//区域
            string kw = this.image_Loc.EditValue == null ? "" : this.image_Loc.EditValue.ToString();//库位
            string floor = strStoveNum;//层
            string shift = this.icbo_Shift.EditValue.ToString();//班次
            string group = this.icbo_Group.EditValue.ToString();//班组
            string remark = this.txt_Remark.Text;
            DateTime start = this.dt_Fk_Start.DateTime;
            DateTime end = this.dt_Fk_End.DateTime;
            string empID = RV.UI.UserInfo.userID;
            DateTime ccmData = DateTime.Now;

            int errorNum = 0;//TryParse 输出参数
            string allotNum = dr["N_QUA"].ToString();
            if (!Int32.TryParse(allotNum, out errorNum))
            {
                MessageBox.Show("调拨支数只能是整数!");
                return;
            }

            if (Convert.ToInt32(allotNum) > Convert.ToInt32(dr["N_QUA"].ToString()))
            {
                MessageBox.Show("调拨支数不能超过可调拨钢坯总数!");
                return;
            }

            string result = bll_TRC_COGDOWN_MAIN.CogDownFkHandler(dr, int.Parse(allotNum), store, shift, group, staID, start, end, empID, ccmData,
                    area, kw, floor, remark);
            if (result == "1")
            {
                BindSlabList();
                BindToSlabList();
                MessageBox.Show("操作成功!");
            }
            else
            {
                MessageBox.Show("操作失败!");
            }
        }

        private void btn_QuerySlabFk_Click(object sender, EventArgs e)
        {
            BindToSlabList();
        }

        private void btn_QuerySlab_Click(object sender, EventArgs e)
        {
            BindSlabList();
        }

        private void gv_Fk_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Fk.GetDataRow(gv_Fk.FocusedRowHandle);
                if (dr != null)
                {
                    txt_AllotNum.Text = dr["N_QUA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void image_Store_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindStoreArea();
            BindStoreLoc();
            BindStoreTier();
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

        private void gv_Fk_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_Fk.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_Fk_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_Fk.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_Fk.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
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
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            Common.OutToExcel.ToExcel(this.gc_Fk);
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
