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
    public partial class FrmRA_DD : Form
    {
        Bll_TSC_SLAB_MAIN bllTscSlabMain = new Bll_TSC_SLAB_MAIN();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TPB_SLABWH bll_TPB_SLABWH = new Bll_TPB_SLABWH();
        Bll_TPB_SLABWH_AREA Bll_TPB_SLABWH_AREA = new BLL.Bll_TPB_SLABWH_AREA();//钢坯库区域信息
        Bll_TPB_SLABWH_LOC Bll_TPB_SLABWH_LOC = new BLL.Bll_TPB_SLABWH_LOC();//钢坯库库位信息
        private Bll_TPB_SLABWH_TIER bll_TPB_SLABWH_TIER = new Bll_TPB_SLABWH_TIER();//钢坯库层信息
        private Bll_TSC_SLAB_STACK bllTscSlabStack = new Bll_TSC_SLAB_STACK();

        CommonSub commonSub = new CommonSub();
        string strStoveNum = "";//炉
        string slabwhCode = "";//仓库
        string slabwhID = "";//仓库ID
        string strMenuName = "";
        string stacode = "";
        public FrmRA_DD()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            slabwhCode = arr[0];
            slabwhID = bll_TPB_SLABWH.GetList_id(slabwhCode);
            stacode = arr[1];
        }

        private void FrmRA_DD_Load(object sender, EventArgs e)
        {
            //UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName; 

            dt_DD_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_DD_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            commonSub.ImageComboBoxEditBindNCBC(icbo_Shift, stacode);
            commonSub.ImageComboBoxEditBindNCBZ(icbo_Group, stacode);
            commonSub.BCBZBindEdit(icbo_Shift, icbo_Group, stacode);
            BindStoreArea();
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
                    strStoveNum = (Convert.ToInt32( dt.Rows[0]["COU"].ToString())+1).ToString();
                }
                
            } 
        }

        /// <summary>
        /// 绑定需要倒垛的钢坯信息
        /// </summary>
        public void BindSlabList()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Slab.DataSource = null;
                BindStoreTier();
                DataTable dt = bllTscSlabMain.Get_DD_KC_List(slabwhCode, txt_Grd.Text.Trim(), txt_Stove.Text.Trim(), txt_Spec.Text.Trim(), "","").Tables[0];

                gc_Slab.DataSource = dt;

                SetGridViewRowNum.SetRowNum(gv_Slab);

                WaitingFrom.CloseWait();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 绑定倒垛记录
        /// </summary>
        private void BindSlabDD()
        {
            WaitingFrom.ShowWait(""); 

            DataTable dt = bllTscSlabStack.Get_DD_Log(slabwhCode, txt_Stove_Rk.Text.Trim(), dt_DD_Start.Text.Trim(), dt_DD_End.Text.Trim(),"").Tables[0];

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
            if (DialogResult.No == MessageBox.Show("确认倒垛吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
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

            //if (string.IsNullOrEmpty(image_Tier.Text.Trim()))
            //{
            //    MessageBox.Show("请选择层!");
            //    return;
            //}

            string area = this.image_Area.EditValue.ToString();//区域
            string kw = this.image_Loc.EditValue == null ? "" : this.image_Loc.EditValue.ToString();//库位
            string floor = strStoveNum;//层
            string shift = this.icbo_Shift.EditValue.ToString();//班次
            string group = this.icbo_Group.EditValue.ToString();//班组
            string remark = this.txt_Remark.Text.ToString();


            int errorNum = 0;//TryParse 输出参数
            string putNum = txt_PutNum.Text.Trim();
            if (!Int32.TryParse(putNum, out errorNum))
            {
                MessageBox.Show("倒垛支数只能是整数!");
                return;
            }

            if (Convert.ToInt32(putNum) > Convert.ToInt32(dr["N_QUA"].ToString()))
            {
                MessageBox.Show("倒垛支数不能超过库存钢坯总数!");
                return;
            }

            string result = bllTscSlabStack.Add_DD(dr, Convert.ToInt32(putNum), slabwhCode, area, kw, floor, shift, group, remark);
            if (result == "1")
            {
                BindSlabList();
                BindSlabDD();
                this.txt_Remark.Text = "";
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
                DataRow dr = gv_Slab.GetDataRow(gv_Slab.FocusedRowHandle);
                if (dr != null)
                {
                    txt_PutNum.Text = dr["N_QUA"].ToString();

                    if (!string.IsNullOrEmpty(dr["C_SLABWH_AREA_CODE"].ToString()))
                    {
                        image_Area.EditValue = dr["C_SLABWH_AREA_CODE"].ToString();
                    }

                    if (!string.IsNullOrEmpty(dr["C_SLABWH_LOC_CODE"].ToString()))
                    {
                        image_Loc.EditValue = dr["C_SLABWH_LOC_CODE"].ToString();
                    }

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
            BindSlabDD();
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
