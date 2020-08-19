using BLL;
using Common;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XGCAP.UI.R.RR;

namespace XGCAP.UI.R.RP
{
    public partial class FrmRP_XMJH : Form
    {
        public FrmRP_XMJH()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            //staID = bll_TB_STA.GetStaIdByCode(arr[0]);           
            slbwhCodeArr = arr[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staCode = arr[1];
            dept = arr[2];
            area = arr[3];
        }

        string[] slbwhCodeArr = null;//待修磨钢坯仓库库位编码
        string staCode = "";
        string dept = "";
        string area = "";


        CommonSub sub = new CommonSub();
        Bll_TRC_PLAN_REGROUND bll_TRC_PLAN_REGROUND = new Bll_TRC_PLAN_REGROUND();
        private Bll_TPB_SLABWH bllTpbSlabWh = new Bll_TPB_SLABWH();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TPB_SLABWH_AREA Bll_TPB_SLABWH_AREA = new BLL.Bll_TPB_SLABWH_AREA();//钢坯库区域信息
        Bll_TPB_SLABWH_LOC Bll_TPB_SLABWH_LOC = new BLL.Bll_TPB_SLABWH_LOC();//钢坯库库位信息
        private Bll_TPB_SLABWH_TIER bll_TPB_SLABWH_TIER = new Bll_TPB_SLABWH_TIER();//钢坯库层信息
        Bll_TSC_SLAB_MAIN bllTscSlabMain = new Bll_TSC_SLAB_MAIN();

        private void FrmRP_XMJH_Load(object sender, EventArgs e)
        {
            this.dt_Plan.DateTime = DateTime.Now.AddDays(-3);
            this.dt_PlanEnd.DateTime = DateTime.Now.AddDays(1);
            BindXMData();
            BindXMPlanData();
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            sub.ImageComboBoxEditBindNCBC(cbo_Shift, staCode);
            sub.ImageComboBoxEditBindNCBZ(cbo_Group, staCode);
            sub.BCBZBindEdit(cbo_Shift, cbo_Group, staCode);
            BindStore();
            BindSta();
            BindXLLoc();
            img_RegroundStandard.Properties.Items.Clear();
            if (area == "1")
            {
                foreach (var item in General.NameType)
                {
                    img_RegroundStandard.Properties.Items.Add(item.Key, item.Key, -1);
                }
            }
            else
            {
                foreach (var item in General.NameTypes)
                {
                    img_RegroundStandard.Properties.Items.Add(item.Key, item.Key, -1);
                }
            }
            img_RegroundStandard.Properties.Items.Add("抛丸探伤", "抛丸探伤", -1);
            img_RegroundStandard.SelectedIndex = img_RegroundStandard.Properties.Items.Count - 1;
        }

        /// <summary>
        /// 绑定工位区域
        /// </summary>
        public void BindSta()
        {
            DataTable dt = bll_TRC_PLAN_REGROUND.GetStaInfo().Tables[0];
            image_Sta.Properties.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                if (area == "1")
                {
                    if (item["C_STA_CODE"].ToString() != "9#XM" && item["C_STA_CODE"].ToString() != "10#XM")
                        this.image_Sta.Properties.Items.Add(item["C_STA_DESC"].ToString());
                }
                else if (area == "2")
                {
                    if (item["C_STA_CODE"].ToString() == "9#XM" || item["C_STA_CODE"].ToString() == "10#XM")
                        this.image_Sta.Properties.Items.Add(item["C_STA_DESC"].ToString());
                }
            }
            this.image_Sta.Properties.Items.Add("抛丸探伤");
            this.image_Sta.Properties.Items[this.image_Sta.Properties.Items.Count-1].CheckState =CheckState.Checked;
        }

        /// <summary>
        /// 绑定仓库
        /// </summary>
        public void BindStore()
        {
            DataTable dt = bllTpbSlabWh.GetList().Tables[0];
            image_Store.Properties.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                image_Store.Properties.Items.Add(item["C_SLABWH_CODE"].ToString() + item["C_SLABWH_NAME"].ToString(), item["C_SLABWH_CODE"], -1);
            }
        }

        /// <summary>
        /// 绑定仓库区域
        /// </summary>
        public void BindStoreArea()
        {
            string slabwhID = bllTpbSlabWh.GetList_id(image_Store.EditValue.ToString());
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
        /// 绑定下料库位
        /// </summary>
        public void BindXLLoc()
        {
            string areaCode = this.image_Area.EditValue == null ? "" : this.image_Area.EditValue.ToString();
            DataTable dt = Bll_TPB_SLABWH_LOC.GetLocByCODEL().Tables[0];
            image_Xloc.Properties.Items.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    this.image_Xloc.Properties.Items.Add(item["C_SLABWH_LOC_NAME"].ToString(), item["C_SLABWH_LOC_CODE"], -1);
                }
            }
            this.image_Xloc.SelectedIndex = 0;
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
                    txt_Tier.Text = "1";
                }
                else
                {
                    txt_Tier.Text = (Convert.ToInt32(dt.Rows[0]["COU"].ToString()) + 1).ToString();
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
        /// 绑定待修磨钢种
        /// </summary>
        public void BindXMData()
        {
            string sqlWhere = "";
            if (!string.IsNullOrWhiteSpace(txt_Stove.Text))
                sqlWhere += "  AND ( TSM.C_STOVE  like '%" + txt_Stove.Text + "%' or   TSM.C_BATCH_NO like '%" + txt_Stove.Text + "%'  ) ";


            //if (this.dt_Plan.DateTime != DateTime.MinValue)
            //{
            //    sqlWhere += " AND  TSM.D_CCM_DATE>to_date('" + dt_Plan.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //    sqlWhere += " AND  TSM.D_CCM_DATE<to_date('" + dt_PlanEnd.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //}
            //else
            //{
            //    sqlWhere += " AND  TSM.D_P_START_TIME>to_date('" + DateTime.Now.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //    sqlWhere += " AND  TSM.D_P_START_TIME<to_date('" + DateTime.Now.AddDays(1).ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //}

            DataTable dt = bll_TRC_PLAN_REGROUND.GetWaitRegroudSlab(slbwhCodeArr, sqlWhere).Tables[0];
            this.gc_XM.DataSource = dt;
            this.gv_XM.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_XM);
        }

        /// <summary>
        /// 绑定修磨计划
        /// </summary>
        public void BindXMPlanData()
        {
            this.gc_XMJH.DataSource = null;
            string sqlWhere = " N_STATUS=0  AND N_QUA>0  AND C_SLAB_TYPE='" + dept + "' ";
            DataTable dt = bll_TRC_PLAN_REGROUND.GetList(sqlWhere).Tables[0];
            this.gc_XMJH.DataSource = dt;
            this.gv_XMJH.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_XMJH);
        }

        /// <summary>
        /// 确认生成修磨计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Confirm_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "生成修磨计划", "生成修磨计划", "生成修磨计划");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认生成修磨计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_XM.FocusedRowHandle;//获取计划焦点行索引
            if (selectedPlanHandle < 0)
            {
                MessageBox.Show("请检查可修磨钢种，记录为空!");
                return;
            }

            if (image_Store.EditValue == null)
            {
                MessageBox.Show("请选择仓库！");
                return;
            }

            string stove = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_STOVE").ToString();//获取焦点炉号
            string batchNo = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_BATCH_NO").ToString();//获取焦点批号
            string grd = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_STL_GRD").ToString();//获取焦点钢种
            string spec = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_SPEC").ToString();//获取焦点规格
            string std = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_STD_CODE") == null ? "" : this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_STD_CODE").ToString();//获取焦点执行标准           
            string matCode = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_MAT_CODE").ToString();//获取焦点物料编码
            string matName = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_MAT_NAME").ToString();//获取焦点物料名称    
            string len = this.gv_XM.GetRowCellValue(selectedPlanHandle, "N_LEN").ToString();//获取焦点长度
            string num = this.gv_XM.GetRowCellValue(selectedPlanHandle, "N_QUA").ToString();//获取焦点支数
            decimal wgt = decimal.Parse(this.gv_XM.GetRowCellValue(selectedPlanHandle, "N_WGT").ToString());//获取焦点重量
            string slbwhCode = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_SLABWH_CODE").ToString();//获取焦点仓库编码
            string slbwhArea = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_SLABWH_AREA_CODE").ToString();//获取焦点区域编码
            string slbwhLoc = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_SLABWH_LOC_CODE").ToString();//获取焦点库位编码
            string grdXMGX = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_XMGX").ToString();//获取焦点修磨工序
            string grdRemark = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_REMARK").ToString();//获取焦点备注
            string isxm = this.gv_XM.GetRowCellValue(selectedPlanHandle, "C_ISXM").ToString();//获取焦点备注
            string isxmWhere = isxm == "未修" ? "Y" : "N";

            string factNum = txt_Num.Text;//支数 
            string reGroundWork = cbo_RegroundWork.Text;//修磨工序
            string shift = cbo_Shift.EditValue.ToString();//班次
            string group = cbo_Group.EditValue.ToString();//班组
            string remark = txt_Remark.Text;//备注
            string store = image_Store.EditValue.ToString();
            string area = image_Area.EditValue.ToString();
            string kw = image_Loc.EditValue.ToString();
            string floor = txt_Tier.Text.Trim();
            if (!string.IsNullOrWhiteSpace(grdRemark))
                remark += "|" + grdRemark;

            if (cbo_RegroundWork.Text == "")
            {
                MessageBox.Show("修磨工序不能为空!");
                return;
            }

            int errorNum = 0;//TryParse 输出参数      
            if (!Int32.TryParse(factNum, out errorNum))
            {
                MessageBox.Show("修磨支数只能是整数!");
                return;
            }

            if (Convert.ToInt32(factNum) > Convert.ToInt32(num))
            {
                MessageBox.Show("修磨支数不能大于库存支数!");
                return;
            }

            string result = bll_TRC_PLAN_REGROUND.CreateRegroundPlan(stove, batchNo, grd, spec, std, matCode, matName, len, factNum, reGroundWork, shift, group, remark, slbwhCode, wgt, grdXMGX, store, area, kw, floor, dept, slbwhArea, slbwhLoc, isxmWhere, img_RegroundStandard.Text, image_Sta.Text, cbo_GrinWheel.Text,image_Xloc.Text,RV.UI.UserInfo.userName);

            if (result == "1")
            {
                BindXMData();
                BindXMPlanData();
                MessageBox.Show("操作成功!");
            }
            else
            {
                BindXMData();
                BindXMPlanData();
                MessageBox.Show("操作失败!");
            }
        }

        private void btn_AssePlanQuery_Click(object sender, EventArgs e)
        {
            BindXMData();
            BindXMPlanData();
        }

        private void gv_XM_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_XM.GetDataRow(gv_XM.FocusedRowHandle);
                if (dr != null)
                {
                    txt_Num.Text = dr["N_QUA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_BackOut_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "撤回修磨计划", "撤回修磨计划", "撤回修磨计划");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认撤回吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_XMJH.FocusedRowHandle;//获取计划焦点行索引
            if (selectedPlanHandle < 0)
            {
                MessageBox.Show("请检查修磨计划，记录为空!");
                return;
            }

            string id = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            string num = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "N_QUA").ToString();//获取焦点支数

            string result = bll_TRC_PLAN_REGROUND.BackRegroundPlan(id, num, slbwhCodeArr[0]);

            if (result == "1")
            {
                BindXMData();
                BindXMPlanData();
                MessageBox.Show("操作成功!");
            }
            else
            {
                BindXMData();
                BindXMPlanData();
                MessageBox.Show("操作失败!");
            }

        }

        private void gv_XM_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_XM.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_XM.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_XM_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_XM.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_XMJH_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_XMJH.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_XMJH_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_XMJH.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_XMJH.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_XM, "钢坯实绩" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_XMJH, "修磨计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
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

        private void gv_XMJH_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_XMJH.GetDataRow(gv_XMJH.FocusedRowHandle);
                if (dr != null)
                {
                    // 创建报表
                    FrmRR_XMSL report = new FrmRR_XMSL(dr["C_ID"].ToString());
                    // 显示预览
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreview();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
