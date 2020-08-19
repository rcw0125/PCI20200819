using BLL;
using DevExpress.XtraGrid.Views.Grid;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RV.UI;
using Common;
using XGCAP.UI.R.RR;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;

namespace XGCAP.UI.R.RP
{
    public partial class FrmRP_ZGJHZP : Form
    {
        public FrmRP_ZGJHZP()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staID = bll_TB_STA.GetStaIdByCode(arr[0]);
            staCode = arr[0];
            slbwhCode = arr[1];
            if (arr.Length > 2)
            {
                if (arr[2] == "true")
                    isJumpBatch = true;
            }
        }

        string staID = "";//轧线工位ID
        string staCode = "";
        string slbwhCode = "";//待轧钢坯仓库库位编码
        private string grd = "";//获取焦点行钢种
        private string std = "";//获取焦点行执行标准
        private string spec = "";//获取焦点规格
        private string length = "";//获取焦点长度
        private string matCode = "";//获取焦点物料编码
        private string stove = "";//炉号
        private bool isJumpBatch = false;

        CommonSub sub = new CommonSub();
        Bll_TRP_PLAN_ROLL bll_TRP_PLAN_ROLL = new Bll_TRP_PLAN_ROLL();
        Bll_TRP_PLAN_ROLL_ITEM bll_TRP_PLAN_ROLL_ITEM = new Bll_TRP_PLAN_ROLL_ITEM();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        Bll_TRC_ROLL_MAIN bll_TRC_ROLL_MAIN = new Bll_TRC_ROLL_MAIN();
        Bll_TRC_ROLL_MAIN_ITEM bll_TRC_ROLL_MAIN_ITEM = new Bll_TRC_ROLL_MAIN_ITEM();
        Bll_TRC_ROLL_LOG bll_TRC_ROLL_LOG = new Bll_TRC_ROLL_LOG();
        Bll_TRC_SLABWH_LOG bll_TRC_SLABWH_LOG = new Bll_TRC_SLABWH_LOG();
        Bll_TPB_STA_WH bll_TPB_STA_WH = new Bll_TPB_STA_WH();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        private Bll_TRP_PLAN_ROLL_ITEM_INFO bllTrpPlanRollItemInfo = new Bll_TRP_PLAN_ROLL_ITEM_INFO();
        private Bll_TPP_ZG_PLAN bllTppZgPlan = new Bll_TPP_ZG_PLAN();

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRP_ZGJHZP_Load(object sender, EventArgs e)
        {
            this.gv_ZGZPJH.CustomColumnDisplayText += Gv_ZGZPJH_CustomColumnDisplayText;
            this.gv_ZGZPSJ.CustomColumnDisplayText += Gv_ZGZPSJ_CustomColumnDisplayText;
            this.gv_PDJG.CustomColumnDisplayText += Gv_PDJG_CustomColumnDisplayText;
            this.dt_Plan.DateTime = DateTime.Now;
            this.dt_ExecEnd.DateTime = DateTime.Now.AddDays(1);
            this.dt_ExecStart.DateTime = DateTime.Now.AddDays(-10);
            this.txt_BranchNo.Text = bll_TRC_ROLL_MAIN.CreateBranchNo(staID);
            cmb_status.SelectedIndex = 0;
            Query1();
            Query3();
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            sub.ImageComboBoxEditBindNCBC(cbo_Shift, staCode);
            sub.ImageComboBoxEditBindNCBZ(cbo_Group, staCode);
            sub.BCBZBindEdit(cbo_Shift, cbo_Group, staCode);
            CommonSub.BindIcboNoAll("", "CC", icbo_lz3);
            if (isJumpBatch)
            {
                txt_BranchNo.ReadOnly = false;
            }
        }

        private void Gv_PDJG_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "C_MOVE_TYPE")
            {
                switch (e.DisplayText)
                {
                    case "S":
                        e.DisplayText = "已销售";
                        break;
                    case "N":
                        e.DisplayText = "待入库";
                        break;
                    case "DZ":
                        e.DisplayText = "待轧";
                        break;
                    case "NP":
                        e.DisplayText = "待开坯";
                        break;
                    case "R":
                        e.DisplayText = "入炉";
                        break;
                    case "C":
                        e.DisplayText = "出炉";
                        break;
                    case "EX":
                        e.DisplayText = "消耗";
                        break;
                    case "M":
                        e.DisplayText = "调拨中";
                        break;
                    case "E":
                        e.DisplayText = "入库";
                        break;
                    case "DX":
                        e.DisplayText = "待修磨";
                        break;
                    case "0":
                        e.DisplayText = "销售占用";
                        break;
                    case "1":
                        e.DisplayText = "销售实绩";
                        break;
                }
            }
        }

        private void Gv_ZGZPSJ_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "C_ROLL_STATE")
            {
                switch (e.DisplayText)
                {
                    case "0":
                        e.DisplayText = "未轧制";
                        break;
                    case "1":
                        e.DisplayText = "已完工";
                        break;
                }
            }

        }

        private void Gv_ZGZPJH_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "N_STATUS")
            {
                switch (e.DisplayText)
                {
                    case "1":
                        e.DisplayText = "已下发";
                        break;
                    case "2":
                        e.DisplayText = "已组坯";
                        break;
                    case "3":
                        e.DisplayText = "已完成";
                        break;
                    case "4":
                        e.DisplayText = "已关闭";
                        break;
                }
            }
        }

        /// <summary>
        /// 组批计划查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AssePlanQuery_Click(object sender, EventArgs e)
        {
            try
            {
                Query1();
                Query2();
                this.txt_BranchNo.Text = bll_TRC_ROLL_MAIN.CreateBranchNo(staID);
            }
            catch
            { }
        }

        /// <summary>
        /// 可轧钢种查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AllowGrdQuery_Click(object sender, EventArgs e)
        {
            Query2();
            this.txt_BranchNo.Text = bll_TRC_ROLL_MAIN.CreateBranchNo(staID);
        }

        /// <summary>
        /// 组批计划查询
        /// </summary>
        private void Query1()
        {
            string status = cmb_status.EditValue == null ? "" : cmb_status.EditValue.ToString();

            string whereSql = "";

            if (status == "1")
            {
                whereSql += "  (TPR.N_STATUS=" + status + "  OR TPR.N_STATUS=2 )";
            }
            else
            {
                whereSql += " TPR.N_STATUS=" + status;

                whereSql += " AND  TPR.D_DT>=to_date('" + DateTime.Now.AddDays(-7).ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
                //whereSql += " AND  TPR.D_P_START_TIME<=to_date('" + dt_Plan.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            }

            whereSql += " AND TPR.C_STA_ID='" + staID + "' ";



            if (!string.IsNullOrWhiteSpace(txt_Grd.Text))
            {
                whereSql += " AND UPPER(TPR.C_STL_GRD) LIKE  UPPER('%" + txt_Grd.Text + "%')  ";
            }

            if (!string.IsNullOrWhiteSpace(txt_Std.Text))
            {
                whereSql += " AND TPR.C_STD_CODE like '%" + txt_Std.Text + "%'  ";
            }

            if (!string.IsNullOrWhiteSpace(txt_Spec.Text))
            {
                whereSql += " AND TPR.C_SPEC like '%" + txt_Spec.Text + "%'  ";
            }

            DataTable dt = bll_TRP_PLAN_ROLL.GetList(whereSql).Tables[0];
            dt.Columns.Add("AuxiliaryWgt");
            dt.Columns.Add("MaxWgt");
            var wgt01 = decimal.Parse(bll_TRC_ROLL_MAIN_ITEM.GetLimitNum("82B88B5EE5180ED8E055000000000001").ToString());
            var wgt02 = decimal.Parse(bll_TRC_ROLL_MAIN_ITEM.GetLimitNum("82B88B5EE5190ED8E055000000000001").ToString());
            var wgt03 = decimal.Parse(bll_TRC_ROLL_MAIN_ITEM.GetLimitNum("82B88B5EE51A0ED8E055000000000001").ToString());
            var wgt04 = decimal.Parse(bll_TRC_ROLL_MAIN_ITEM.GetLimitNum("82B88B5EE51B0ED8E055000000000001").ToString());
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    var CountWgt = decimal.Parse(dt.Rows[i]["N_WGT"].ToString());
                    var qua = int.Parse(dt.Rows[i]["S"].ToString().ToString());

                    var maxWgt = bll_TRP_PLAN_ROLL_ITEM.GetLimitMax(dt.Rows[i]["C_ID"].ToString()).ToString();
                    dt.Rows[i]["MaxWgt"] = maxWgt;
                }
            }

            this.gc_ZGZPJH.DataSource = dt;
            this.gv_ZGZPJH.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_ZGZPJH);
        }

        /// <summary>
        /// 可轧钢种查询
        /// </summary>
        private void Query2()
        {

            int selectedHandle = this.gv_ZGZPJH.FocusedRowHandle;//获取焦点行索引

            if (selectedHandle < 0)
            {
                this.gc_KDZGZ.DataSource = null;
                this.gv_KDZGZ.BestFitColumns();
                return;
            }


            //获取焦点行钢坯执行标准
            grd = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_STL_GRD_SLAB").ToString();
            //获取焦点行钢坯执行标准
            std = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_STD_CODE_SLAB").ToString();
            //钢坯规格
            spec = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_SLAB_SIZE").ToString();
            //钢坯长度
            length = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "N_SLAB_LENGTH").ToString();
            //钢坯物料编码
            matCode = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_MATRL_CODE_SLAB").ToString();
            //炉号
            string ordergrd = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();//原计划钢种
            string orderstd = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();//原计划标准
            stove = txt_Stove.Text;
            //获取计划开始时间
            dt_PlanStart.DateTime = DateTime.Parse(this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "D_P_START_TIME").ToString());

            //获取可代轧钢种、执行标准
            DataTable replaceStl = bll_TPB_STA_WH.GetAllowPlaceStl(grd, std).Tables[0];
            DataTable assembly = bll_TSC_SLAB_MAIN.GetRepalceStl(ordergrd,orderstd, replaceStl, grd, std, spec, stove, length, matCode, slbwhCode).Tables[0];
            this.gc_KDZGZ.DataSource = assembly;
            this.gv_KDZGZ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_KDZGZ);
            DataRow dr = gv_KDZGZ.GetDataRow(gv_KDZGZ.FocusedRowHandle);
            if (dr != null)
            {
                txt_AsseNum.Text = dr["N_QUA"].ToString();
            }
            else
                txt_AsseNum.Text = "0";

            //获取焦点行
            var wgt = decimal.Parse(this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "N_WGT").ToString());
            var groupWgt = decimal.Parse(this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "N_GROUP_WGT").ToString() == "" ? "0" : this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "N_GROUP_WGT").ToString());
            if (groupWgt < wgt)
            {
                btn_Close.Enabled = true;
                btn_Success.Enabled = false;
            }
            else
            {
                btn_Close.Enabled = false;
                btn_Success.Enabled = true;
            }

            string orderNo = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_ORDER_NO").ToString();//获取焦点订单号         
            var dt = bllTrpPlanRollItemInfo.GetJoinOrder(orderNo);
            if (dt.Rows.Count > 0)
            {
                this.gridControl2.DataSource = dt;
                this.gridView2.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gridView2);
            }
            else
            {
                this.gridControl2.DataSource = null;
            }

        }

        /// <summary>
        /// 组批查询
        /// </summary>
        private void Query3()
        {
            string whereSql = " AND TRM.C_STA_ID='" + staID + "' ";
            if (this.dt_ExecStart.DateTime != DateTime.MinValue)
            {
                whereSql += " AND  TRM.D_MOD_DT>=to_date('" + dt_ExecStart.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
                whereSql += " AND  TRM.D_MOD_DT<=to_date('" + dt_ExecEnd.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            }
            DataTable dt = bll_TRC_ROLL_MAIN.GetListMain(whereSql, false).Tables[0];
            this.gc_ZGZPSJ.DataSource = dt;
            this.gv_ZGZPSJ.OptionsView.ColumnAutoWidth = false;
            gridColumn12.ColumnEdit = sub.GetBCIdDescItemComboBox();
            gridColumn13.ColumnEdit = sub.GetBZIdDescItemComboBox();
            SetGridViewRowNum.SetRowNum(gv_ZGZPSJ);

        }

        /// <summary>
        /// 组批计划焦点变化时 刷新可轧钢种
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_ZGZPJH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Query2();
            }
            catch { }
        }

        /// <summary>
        /// 可轧钢种焦点变化时 更新组批支数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_KDZGZ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_KDZGZ.GetDataRow(gv_KDZGZ.FocusedRowHandle);
                if (dr != null)
                {
                    txt_AsseNum.Text = dr["N_QUA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 组批
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Asse_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.gv_ZGZPJH.RowCount == 0)
                {
                    MessageBox.Show("计划记录为空！");
                    return;
                }

                int selectedPlanHandle = this.gv_ZGZPJH.FocusedRowHandle;//获取计划焦点行索引

                if (selectedPlanHandle != 0 && string.IsNullOrWhiteSpace(txt_Remark.Text))
                {
                    MessageBox.Show("配批必须输入备注！");
                    return;
                }

                int selectedAllowGrd = this.gv_KDZGZ.FocusedRowHandle;//获取可轧钢种焦点行索引
                if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
                {
                    MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                    return;
                }

                if (DialogResult.No == MessageBox.Show("确认组批吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                string planID = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
                string planGrd = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_STL_GRD").ToString();//获取焦点行钢种
                string planStd = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_STD_CODE").ToString();//获取焦点行执行标准   
                string planSpec = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_SPEC").ToString();//获取焦点规格  
                string status = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "N_STATUS").ToString();//获取焦点状态
                string planMatCode = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_MAT_CODE").ToString();//获取焦点物料编码
                string planMatName = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_MAT_NAME").ToString();//获取焦点物料名称
                string planIsMerge = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "N_IS_MERGE").ToString();//获取焦点合并标记
                string maxWgt = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "MaxWgt").ToString();//获取焦点合并标记



                int allowGrdNum = Convert.ToInt32(this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "N_QUA"));//可轧钢种支数
                string grd = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_STL_GRD").ToString(); //钢种
                string std = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_STD_CODE").ToString(); //执行标准
                string spec = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_SPEC").ToString(); //钢坯断面
                string matCode = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_MAT_CODE").ToString();//获取焦点物料编码
                string matName = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_MAT_NAME").ToString();//获取焦点物料名称
                string remark = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_REMARK").ToString();//获取焦点物料名称
                decimal planPw = decimal.Parse(this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "N_WGT").ToString());//获取焦点单重
                string kpBatchNo = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_BATCH_NO").ToString();//获取焦点开批号


                string strMenuName = RV.UI.UserInfo.menuName;

                UserLog.AddLog(strMenuName, this.Name + "轧钢组坯" + this.txt_BranchNo.Text, "轧钢组坯", "轧钢组坯");//添加操作日志

                if (status != "1" && status != "2")
                {
                    MessageBox.Show("请选择已下发、已组坯状态计划组坯!");
                    return;
                }

                int errorNum = 0;//TryParse 输出参数
                string asseNum = txt_AsseNum.Text.Trim();
                if (!Int32.TryParse(asseNum, out errorNum) || int.Parse(asseNum) == 0)
                {
                    MessageBox.Show("组批支数只能是整数!");
                    return;
                }

                if (int.Parse(asseNum) > allowGrdNum)
                {
                    MessageBox.Show("组批支数不能大于钢坯库存支数!");
                    return;
                }

                Mod_TRC_ROLL_MAIN model = new Mod_TRC_ROLL_MAIN();
                model.C_ID = bll_TRC_ROLL_MAIN.CreateID();
                model.C_STOVE = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_STOVE").ToString();
                model.C_BATCH_NO = this.txt_BranchNo.Text;
                model.C_PLAN_ID = planID;
                model.C_STL_GRD_SLAB = grd;
                model.C_STD_CODE_SLAB = std;
                model.C_SPEC_SLAB = spec;
                model.N_QUA_TOTAL = decimal.Parse(asseNum);
                model.N_WGT_TOTAL = planPw * decimal.Parse(asseNum);
                model.C_EMP_ID = UserInfo.UserID;
                model.C_STL_GRD = planGrd;
                model.C_SPEC = planSpec;
                model.C_STD_CODE = planStd;
                model.C_MAT_SLAB_CODE = matCode;
                model.C_MAT_SLAB_NAME = matName;
                model.C_REMARK = this.txt_Remark.Text;
                if (!string.IsNullOrWhiteSpace(remark))
                    model.C_REMARK += "|" + remark;
                model.C_GROUP = this.cbo_Group.EditValue.ToString();
                model.C_SHIFT = this.cbo_Shift.EditValue.ToString();
                model.N_QUA_TOTAL_VRITUAL = model.N_QUA_TOTAL;
                model.N_WGT_TOTAL_VRITUAL = model.N_WGT_TOTAL;
                model.C_PLANT = kpBatchNo;
                model.C_STA_ID = staID;
                model.N_IS_MERGE = decimal.Parse(planIsMerge);
                string result = bll_TRC_ROLL_MAIN.AssemblyHandler(model, grd, std, slbwhCode, kpBatchNo, planMatCode, staID, maxWgt);
                if (result == "1")
                {
                    btn_AssePlanQuery_Click(null, null);
                    Query3();
                    MessageBox.Show("操作成功!");
                    //生成批号
                    this.txt_BranchNo.Text = bll_TRC_ROLL_MAIN.CreateBranchNo(staID);
                }
                else if (result == "8")
                {
                    btn_AssePlanQuery_Click(null, null);
                    Query3();
                    MessageBox.Show("组批量超出计划量，不能组坯");
                    //生成批号
                    this.txt_BranchNo.Text = bll_TRC_ROLL_MAIN.CreateBranchNo(staID);
                }
                else if (result == "9")
                {
                    btn_AssePlanQuery_Click(null, null);
                    Query3();
                    MessageBox.Show("组批量超出订单总量，不能组坯");
                    //生成批号
                    this.txt_BranchNo.Text = bll_TRC_ROLL_MAIN.CreateBranchNo(staID);
                }
                else
                {
                    btn_AssePlanQuery_Click(null, null);
                    Query3();
                    MessageBox.Show("操作失败!");
                    //生成批号
                    this.txt_BranchNo.Text = bll_TRC_ROLL_MAIN.CreateBranchNo(staID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 撤回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BackOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认撤回？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                string sql = " AND TRM.C_STA_ID='" + staID + "' ";

                DataTable dt = bll_TRC_ROLL_MAIN.GetListMain(sql, false).Tables[0];
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("无组批记录，无法撤回!");
                    return;
                }
                DataRow dr = dt.Rows[0];
                string planID = dr["C_PLAN_ID"].ToString();
                string asseID = dr["C_ID"].ToString();
                decimal assemNum = decimal.Parse(dr["N_WGT_TOTAL_VIRTUAL"].ToString());

                string strMenuName = RV.UI.UserInfo.menuName;

                UserLog.AddLog(strMenuName, this.Name + "轧钢组坯撤销" + dr["C_BATCH_NO"].ToString(), "轧钢组坯撤销", "轧钢组坯撤销");//添加操作日志

                string result = bll_TRC_ROLL_MAIN.BackOutHandler(asseID, assemNum, planID);
                if (result == "1")
                {
                    MessageBox.Show("操作成功!");
                    Query1();
                    Query2();
                    Query3();
                    //生成批号
                    this.txt_BranchNo.Text = bll_TRC_ROLL_MAIN.CreateBranchNo(staID);
                }
                else
                {
                    MessageBox.Show("操作失败!");
                    Query1();
                    Query2();
                    Query3();
                    //生成批号
                    this.txt_BranchNo.Text = bll_TRC_ROLL_MAIN.CreateBranchNo(staID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 组批主表查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AsseQuery_Click(object sender, EventArgs e)
        {
            int compareDt = DateTime.Compare(this.dt_ExecStart.DateTime, this.dt_ExecEnd.DateTime);
            if (compareDt > 0)
            {
                MessageBox.Show("日期错误!");
                return;
            }
            Query3();
            this.txt_BranchNo.Text = bll_TRC_ROLL_MAIN.CreateBranchNo(staID);
        }

        private void gv_KDZGZ_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_KDZGZ.GetDataRow(gv_KDZGZ.FocusedRowHandle);
                if (dr != null)
                {
                    txt_AsseNum.Text = dr["N_QUA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void gv_ZGZPSJ_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_ZGZPSJ.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_KDZGZ_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_KDZGZ.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_ZGZPSJ_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_ZGZPSJ.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_ZGZPSJ.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_KDZGZ_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_KDZGZ.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_KDZGZ.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认关闭计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            string strMenuName = RV.UI.UserInfo.menuName;

            UserLog.AddLog(strMenuName, this.Name + "确认关闭计划" + this.txt_BranchNo.Text, "确认关闭计划", "确认关闭计划");//添加操作日志

            string planRemark = txt_planRemark.Text.Trim();
            if (planRemark == "")
            {
                MessageBox.Show("关闭计划请填写备注");
                return;
            }

            int selectedPlanHandle = this.gv_ZGZPJH.FocusedRowHandle;//获取计划焦点行索引
            if (selectedPlanHandle < 0)
            {
                MessageBox.Show("请检查计划记录!");
                return;
            }
            string planID = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            string orderNo = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_ORDER_NO").ToString();//获取焦点订单号
            string groupWgt = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "N_GROUP_WGT").ToString();//获取焦点组批量
            string wgt = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "N_WGT").ToString();//获取焦点组批量

            var m = bll_TRP_PLAN_ROLL_ITEM.GetModel(planID);
            if (m.N_GROUP_WGT >= m.N_WGT)
            {
                MessageBox.Show("组批量大于等于计划量，无法关闭");
                return;
            }

            string result = bll_TRC_ROLL_MAIN.ClosePlans(planID, orderNo, planRemark, RV.UI.UserInfo.UserID, RV.UI.UserInfo.UserName);
            if (result == "1")
            {
                MessageBox.Show("操作成功");
                Query1();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 获取钢坯库存
        /// </summary>
        private void GetSalbInvenStory()
        {
            int selectedHandle = this.gv_ZGZPJH.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.gc_KDZGZ.DataSource = null;
                this.gv_KDZGZ.BestFitColumns();
                return;
            }

            //获取焦点行钢种
            grd = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_STL_GRD_SLAB").ToString();
            //获取焦点行钢种
            matCode = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_MATRL_CODE_SLAB").ToString();
            //获取焦点行执行标准
            std = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_STD_CODE_SLAB").ToString();
            //钢坯规格
            spec = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_SLAB_SIZE").ToString();
            //钢坯长度
            length = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "N_SLAB_LENGTH").ToString();

            //获取可代轧钢种、执行标准
            DataTable replaceStl = bll_TPB_STA_WH.GetAllowPlaceStl(grd, std).Tables[0];
            var dt = bll_TRC_ROLL_MAIN.GetSlabInventory(grd, std, null, replaceStl);
            gc_PDJG.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_PDJG);
        }

        private void gv_ZGZPJH_Click(object sender, EventArgs e)
        {
            try
            {
                Query2();
                GetOrderRelationAsse();
            }
            catch { }
        }

        private void GetOrderRelationAsse()
        {
            int selectedHandle = this.gv_ZGZPJH.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.gc_KDZGZ.DataSource = null;
                this.gv_KDZGZ.BestFitColumns();
                return;
            }

            //获取焦点行钢种
            string id = this.gv_ZGZPJH.GetRowCellValue(selectedHandle, "C_ID").ToString();
            string whereSql = " AND TRM.C_PLAN_ID='" + id + "'    ";
            DataTable dt = bll_TRC_ROLL_MAIN.GetListMain(whereSql, false).Tables[0];
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView1);

        }

        private void btn_query_jc_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                BindLsbGrid(_strCCMID, this.rbtn_status.SelectedIndex + 1);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {

            }
        }

        private List<Mod_TSP_CAST_PLAN> jc_cast_plan = new List<Mod_TSP_CAST_PLAN>();//浇次计划 
        private List<Mod_TSP_PLAN_SMS> sms_plan = new List<Mod_TSP_PLAN_SMS>();//炉次计划
        private static Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();//浇次计划
        private static Bll_TSP_PLAN_SMS bll_plan_sms = new Bll_TSP_PLAN_SMS();//炉次计划
        DateTime dt_jc_start_time = DateTime.Now;//查询的计划的开始时间
        public int jcminsort = 1;//浇次起始序号
        #region 查询浇次计划
        /// <summary>
        /// 查询浇次计划方法
        /// </summary>
        /// <param name="strCCMID">连铸机</param>
        private void BindLsbGrid(string strCCMID, int n_status)
        {
            jc_cast_plan = bll_cast_plan.GetModelList(strCCMID, n_status, "").OrderBy(a => a.N_SORT).ToList();
            if (jc_cast_plan.Count > 0)
            {
                jcminsort = (int)jc_cast_plan.Min(a => a.N_SORT);
                dt_jc_start_time = (DateTime)jc_cast_plan.Min(a => a.D_P_START_TIME);
            }
            this.gridControl6.DataSource = jc_cast_plan;
            this.gridView6.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView6);
            //this.gridView6.UpdateSummary();
            //this.gridView6.RefreshData();
            //this.gridView6.BestFitColumns();

        }

        /// <summary>
        /// 浇次计划排产查询连铸主键
        /// </summary>
        private string _strCCMID
        {
            get
            {
                var index = this.icbo_lz3.SelectedIndex;
                if (index >= 0)
                    return this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString();

                return string.Empty;
            }
        }
        #endregion

        private void btn_out_toExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_ZGZPSJ, "轧钢组坯计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_ZGZPJH, "轧钢计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void btn_Success_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认完成计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            string strMenuName = RV.UI.UserInfo.menuName;

            UserLog.AddLog(strMenuName, this.Name + "确认完成计划吗" + this.txt_BranchNo.Text, "确认完成计划", "确认完成计划");//添加操作日志

            int selectedPlanHandle = this.gv_ZGZPJH.FocusedRowHandle;//获取计划焦点行索引
            if (selectedPlanHandle < 0)
            {
                MessageBox.Show("请检查计划记录!");
                return;
            }
            string planID = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            decimal wgt = 0;
            decimal groupWgt = decimal.Parse(this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "N_GROUP_WGT").ToString());
            decimal planWgt = decimal.Parse(this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "N_WGT").ToString());
            var m = bll_TRP_PLAN_ROLL_ITEM.GetModel(planID);
            if (m.N_GROUP_WGT < m.N_WGT)
            {
                MessageBox.Show("组批量小于计划量，无法完成");
                return;
            }
            string result = bll_TRC_ROLL_MAIN.SuccessPlan(planID);



            if (result == "1")
            {
                MessageBox.Show("操作成功");
                Query1();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }



        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            bll_TRC_ROLL_MAIN.ChckIfAsse("", 1);
        }

        private void hideContainerRight_Click(object sender, EventArgs e)
        {
            GetSalbInvenStory();
        }

        private void gc_PDJG_MouseDown(object sender, MouseEventArgs e)
        {
            GetSalbInvenStory();
        }


        private void gc_ZGZPJH_Click(object sender, EventArgs e)
        {

        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {


            int selectedPlanHandle = 0;//获取计划焦点行索引
            if (gv_ZGZPJH.RowCount == 0)
            {
                MessageBox.Show("记录为空!");
                return;
            }

            if (DialogResult.No == MessageBox.Show("确认修改时间吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            string strMenuName = RV.UI.UserInfo.menuName;

            UserLog.AddLog(strMenuName, this.Name + "确认关闭计划" + this.txt_BranchNo.Text, "确认关闭计划", "确认关闭计划");//添加操作日志

            string planID = this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            decimal mach = decimal.Parse(this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "N_MACH_WGT").ToString());//获取焦点机时产能
            decimal wgt = decimal.Parse(this.gv_ZGZPJH.GetRowCellValue(selectedPlanHandle, "N_WGT").ToString());//获取焦点行排产量  
            DateTime start = dt_PlanStart.DateTime;
            decimal re = wgt / mach;
            DateTime end = start.AddHours((double)re);
            if (bll_TRC_ROLL_MAIN.UpdatePlanTime(planID, start, end))
            {
                #region 重新计算所有订单生产时间
                OverAgainTime();
                #endregion

                MessageBox.Show("操作成功");
                Query1();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

        /// <summary>
        /// 重新计算所有订单执行时间
        /// </summary>
        private void OverAgainTime()
        {
            //查询当前产线所有未完成订单
            string whereSql = "(TPR.N_STATUS=1  OR TPR.N_STATUS=2 )";
            whereSql += " AND TPR.C_STA_ID='" + staID + "' ";
            DataTable dt = bll_TRP_PLAN_ROLL.GetList(whereSql).Tables[0];
            //重新计算所有订单执行时间
            bll_TRC_ROLL_MAIN.OverAgainTime(dt, staID);
        }

        private void gv_ZGZPSJ_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_ZGZPSJ.GetDataRow(gv_ZGZPSJ.FocusedRowHandle);
                if (dr != null)
                {
                    // 创建报表
                    FrmRR_LGKP report = new FrmRR_LGKP(dr["C_BATCH_NO"].ToString());
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


        private void gv_ZGZPSJ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {


        }

        private void gv_ZGZPSJ_Click(object sender, EventArgs e)
        {
            int selectedHandle = this.gv_ZGZPSJ.FocusedRowHandle;//获取焦点行索引
            string orderNo = this.gv_ZGZPSJ.GetRowCellValue(selectedHandle, "C_ORDER_NO").ToString();//获取焦点订单号         
            var dt = bllTrpPlanRollItemInfo.GetJoinOrder(orderNo);
            if (dt.Rows.Count > 0)
            {
                this.gridControl2.DataSource = dt;
                this.gridView2.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gridView2);
            }
            else
            {
                this.gridControl2.DataSource = null;
            }

            string id = this.gv_ZGZPSJ.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点订单号      
            var dt2 = bllTrpPlanRollItemInfo.GetRelationOrder(id);
            if (dt2.Rows.Count > 0)
            {
                this.gridControl3.DataSource = dt2;
                this.gridView3.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gridView3);
            }
            else
            {
                this.gridControl3.DataSource = null;
            }       
        }

    }
}
