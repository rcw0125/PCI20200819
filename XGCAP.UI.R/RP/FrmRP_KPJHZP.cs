using BLL;
using Common;
using DevExpress.XtraReports.UI;
using MODEL;
using RV.UI;
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
    public partial class FrmRP_KPJHZP : Form
    {
        public FrmRP_KPJHZP()
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

        string staID = "";//开坯工位ID
        string staCode = "";
        string slbwhCode = "";//待开坯仓库库位编码
        private string grd = "";//获取焦点行钢种
        private string std = "";//获取焦点行执行标准
        private string stove = "";//炉号
        private bool isJumpBatch = false;

        CommonSub sub = new CommonSub();
        Bll_TRP_PLAN_COGDOWN bll_TRP_PLAN_COGDOWN = new Bll_TRP_PLAN_COGDOWN();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        Bll_TRC_COGDOWN_MAIN bll_TRC_COGDOWN_MAIN = new Bll_TRC_COGDOWN_MAIN();
        Bll_TRC_COGDOWN_MAIN_ITEM bll_TRC_COGDOWNL_MAIN_ITEM = new Bll_TRC_COGDOWN_MAIN_ITEM();
        Bll_TRC_COGDOWN_LOG bll_TRC_COGDOWN_LOG = new Bll_TRC_COGDOWN_LOG();
        Bll_TRC_SLABWH_LOG bll_TRC_SLABWH_LOG = new Bll_TRC_SLABWH_LOG();
        Bll_TPB_STA_WH bll_TPB_STA_WH = new Bll_TPB_STA_WH();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TRC_ROLL_MAIN bll_TRC_ROLL_MAIN = new Bll_TRC_ROLL_MAIN();

        private void FrmRP_KPJHZP_Load(object sender, EventArgs e)
        {

            this.gv_KPZPJH.CustomColumnDisplayText += Gv_KPZPJH_CustomColumnDisplayText;
            this.gv_KPZPSJ.CustomColumnDisplayText += Gv_KPZPSJ_CustomColumnDisplayText;
            this.gv_PDJG.CustomColumnDisplayText += Gv_PDJG_CustomColumnDisplayText;
            this.dt_Plan.DateTime = DateTime.Now;
            this.dt_ExecStart.DateTime = DateTime.Now.AddDays(-1);
            this.dt_ExecEnd.DateTime = DateTime.Now.AddDays(1);
            this.txt_BranchNo.Text = bll_TRC_COGDOWN_MAIN.CreateBranchNo(staID);
            this.cmb_status.SelectedIndex = 0;
            Query1();
            Query2();
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

        private void Gv_KPZPSJ_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
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

        private void Gv_KPZPJH_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "N_STATUS")
            {
                switch (e.DisplayText)
                {
                    case "1":
                        e.DisplayText = "已下发";
                        break;
                    case "2":
                        e.DisplayText = "已完成";
                        break;
                    case "3":
                        e.DisplayText = "已关闭";
                        break;
                }
            }
        }

        /// <summary>
        /// 组批计划查询
        /// </summary>
        private void Query1()
        {
            string status = cmb_status.EditValue == null ? "" : cmb_status.EditValue.ToString();

            string whereSql = " TPC.N_STATUS=" + status;

            whereSql += " AND TPC.C_STA_ID='" + staID + "' ";


            //if (this.dt_Plan.DateTime != DateTime.MinValue)
            //{
            //    whereSql += " AND  TPC.D_P_START_TIME>=to_date('" + dt_Plan.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //    whereSql += " AND  TPC.D_P_START_TIME<=to_date('" + dt_Plan.DateTime.AddDays(1).ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //}
            //else
            //{
            //    whereSql += " AND  TPC.D_P_START_TIME>=to_date('" + DateTime.Now.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //    whereSql += " AND  TPC.D_P_START_TIME<=to_date('" + DateTime.Now.AddDays(1).ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //}

            if (!string.IsNullOrWhiteSpace(txt_Grd.Text))
            {
                whereSql += " AND UPPER(TPC.C_STL_GRD) LIKE  UPPER('%" + txt_Grd.Text + "%')  ";
            }

            if (!string.IsNullOrWhiteSpace(txt_Std.Text))
            {
                whereSql += " AND  TPC.C_STL_GRD LIKE  '%" + txt_Std.Text + "%'  ";
            }

            if (!string.IsNullOrWhiteSpace(txt_Spec.Text))
            {
                whereSql += " AND TPC.C_SPEC like '%" + txt_Spec.Text + "%'  ";
            }

            DataTable dt = bll_TRP_PLAN_COGDOWN.GetList(whereSql).Tables[0];
            this.gc_KPZPJH.DataSource = dt;
            this.gv_KPZPJH.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_KPZPJH);
            DataRow dr = gv_KDZGZ.GetDataRow(gv_KDZGZ.FocusedRowHandle);
            if (dr != null)
            {
                txt_AsseNum.Text = dr["N_QUA"].ToString();
            }
            else
                txt_AsseNum.Text = "0";
        }

        /// <summary>
        /// 可轧钢种查询
        /// </summary>
        private void Query2()
        {
            int selectedHandle = this.gv_KPZPJH.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.gc_KDZGZ.DataSource = null;
                this.gv_KDZGZ.BestFitColumns();
                return;
            }

            //获取焦点行执行标准
            std = this.gv_KPZPJH.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();
            //钢坯定尺
            string spec = this.gv_KPZPJH.GetRowCellValue(selectedHandle, "C_SLAB_SIZE").ToString();
            //物料编码
            string matCode = this.gv_KPZPJH.GetRowCellValue(selectedHandle, "C_MATRL_CODE_SLAB").ToString();
            //长度
            string length = this.gv_KPZPJH.GetRowCellValue(selectedHandle, "N_SLAB_LENGTH").ToString();
            //炉号
            stove = this.gv_KPZPJH.GetRowCellValue(selectedHandle, "C_CAST_NO").ToString();

            //获取开坯可组批钢坯
            DataTable assembly = bll_TSC_SLAB_MAIN.GetRepalceStl(matCode, std, spec, length, stove, slbwhCode).Tables[0];
            this.gc_KDZGZ.DataSource = assembly;
            this.gv_KDZGZ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_KDZGZ);
            DataRow dr = gv_KDZGZ.GetDataRow(gv_KDZGZ.FocusedRowHandle);
            if (dr != null)
            {
                txt_AsseNum.Text = dr["N_QUA"].ToString();
            }
            //获取焦点行
            var wgt = decimal.Parse(this.gv_KPZPJH.GetRowCellValue(selectedHandle, "N_WGT").ToString());
            var groupWgt = decimal.Parse(this.gv_KPZPJH.GetRowCellValue(selectedHandle, "N_GROUP_WGT").ToString() == "" ? "0" : this.gv_KPZPJH.GetRowCellValue(selectedHandle, "N_GROUP_WGT").ToString());
            //if (groupWgt <= wgt)
            //{
            //    btn_Sucess.Enabled = false;
            //}
            //else
            //{
            //    btn_Sucess.Enabled = true;
            //}

            //if (groupWgt == 0)
            //{
            //    btn_Close.Enabled = true;
            //}
            //else
            //{
            //    btn_Close.Enabled = false;
            //}

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
            DataTable dt = bll_TRC_COGDOWN_MAIN.GetListMain(whereSql, false).Tables[0];
            this.gc_KPZPSJ.DataSource = dt;
            this.gv_KPZPSJ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_KPZPSJ);
        }

        /// <summary>
        /// 组批计划查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AssePlanQuery_Click(object sender, EventArgs e)
        {
            Query1();
            Query2();
            this.txt_BranchNo.Text = bll_TRC_COGDOWN_MAIN.CreateBranchNo(staID);
        }

        /// <summary>
        /// 组批计划焦点变化时 刷新可轧钢种
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_KPZPJH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Query2();
            int selectedHandle = this.gv_KPZPJH.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.gc_KDZGZ.DataSource = null;
                this.gv_KDZGZ.BestFitColumns();
                return;
            }
            //获取焦点行
            var wgt = decimal.Parse(this.gv_KPZPJH.GetRowCellValue(selectedHandle, "N_WGT").ToString());
            var groupWgt = decimal.Parse(this.gv_KPZPJH.GetRowCellValue(selectedHandle, "N_GROUP_WGT").ToString() == "" ? "0" : this.gv_KPZPJH.GetRowCellValue(selectedHandle, "N_GROUP_WGT").ToString());
            //if (groupWgt <= wgt)
            //{

            //    btn_Sucess.Enabled = false;
            //}
            //else
            //{

            //    btn_Sucess.Enabled = true;
            //}

            //if (groupWgt == 0)
            //{
            //    btn_Close.Enabled = true;
            //}
            //else
            //{
            //    btn_Close.Enabled = false;
            //}

        }

        /// <summary>
        ///  可轧钢种焦点变化时 更新组批支数
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
        /// 可轧钢种查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AllowGrdQuery_Click(object sender, EventArgs e)
        {
            Query2();
            this.txt_BranchNo.Text = bll_TRC_COGDOWN_MAIN.CreateBranchNo(staID);
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
            this.txt_BranchNo.Text = bll_TRC_COGDOWN_MAIN.CreateBranchNo(staID);
        }

        /// <summary>
        /// 组批
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Asse_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "组批", "组批", "组批");//添加操作日志

            try
            {
                if (DialogResult.No == MessageBox.Show("确认组批吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedPlanHandle = this.gv_KPZPJH.FocusedRowHandle;//获取计划焦点行索引
                int selectedAllowGrd = this.gv_KDZGZ.FocusedRowHandle;//获取可轧钢种焦点行索引
                if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
                {
                    MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                    return;
                }
                string planID = this.gv_KPZPJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
                string planGrd = this.gv_KPZPJH.GetRowCellValue(selectedPlanHandle, "C_STL_GRD").ToString();//获取焦点行钢种
                string planStd = this.gv_KPZPJH.GetRowCellValue(selectedPlanHandle, "C_STD_CODE").ToString();//获取焦点行执行标准   
                string planSpec = this.gv_KPZPJH.GetRowCellValue(selectedPlanHandle, "C_SPEC").ToString();//获取焦点规格  
                string status = this.gv_KPZPJH.GetRowCellValue(selectedPlanHandle, "N_STATUS").ToString();//获取焦点状态
                string castNo = this.gv_KPZPJH.GetRowCellValue(selectedPlanHandle, "C_CAST_NO").ToString();//获取焦点炉号

                int allowGrdNum = Convert.ToInt32(this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "N_QUA"));//可轧钢种支数
                decimal wgt = decimal.Parse(this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "N_WGT").ToString()); //重量
                string grd = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_STL_GRD").ToString(); //钢种
                string std = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_STD_CODE").ToString(); //执行标准
                string spec = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_SPEC").ToString(); //钢坯断面
                string matCode = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_MAT_CODE").ToString();//获取焦点物料编码
                string matName = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_MAT_NAME").ToString();//获取焦点物料名称
                string remark = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_REMARK").ToString();//备注
                string stove = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_STOVE").ToString();//获取焦点炉号

                if (castNo != stove)
                {
                    MessageBox.Show("炉号不匹配，请选择与计划匹配炉号进行组坯!");
                    return;
                }

                if (status != "1")
                {
                    MessageBox.Show("请选择已下发状态计划组坯!");
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

                Mod_TRC_COGDOWN_MAIN model = new Mod_TRC_COGDOWN_MAIN();
                model.C_ID = bll_TRC_COGDOWN_MAIN.CreateID();
                model.C_STOVE = this.gv_KDZGZ.GetRowCellValue(selectedAllowGrd, "C_STOVE").ToString();
                model.C_BATCH_NO = this.txt_BranchNo.Text;
                model.C_PLAN_ID = planID;
                model.C_STL_GRD_SLAB = grd;
                model.C_SPEC_SLAB = spec;
                model.N_QUA_TOTAL = decimal.Parse(asseNum);
                model.N_WGT_TOTAL = wgt * model.N_QUA_TOTAL;
                model.C_EMP_ID = UserInfo.UserID;
                model.C_STL_GRD = planGrd;
                model.C_SPEC = planSpec;
                model.C_STD_CODE = planStd;
                model.C_MAT_SLAB_CODE = matCode;
                model.C_MAT_SLAB_NAME = matName;
                if (!string.IsNullOrWhiteSpace(remark))
                    model.C_REMARK = this.txt_Remark.Text += "|" + remark;
                model.C_GROUP = this.cbo_Group.EditValue.ToString();
                model.C_SHIFT = this.cbo_Shift.EditValue.ToString();
                model.C_STA_ID = staID;
                model.N_QUA_TOTAL_VIRTUAL = model.N_QUA_TOTAL;
                model.N_WGT_TOTAL_VIRTUAL = model.N_WGT_TOTAL;
                string result = bll_TRC_COGDOWN_MAIN.AssemblyHandler(model, grd, std, slbwhCode, Application.StartupPath);
                if (result == "1")
                {
                    btn_AssePlanQuery_Click(null, null);
                    Query3();
                    MessageBox.Show("操作成功!");
                    //生成批号
                    this.txt_BranchNo.Text = bll_TRC_COGDOWN_MAIN.CreateBranchNo(staID);
                }
                else
                { MessageBox.Show("操作失败!"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 撤回组批
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BackOut_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "撤回", "撤回", "撤回");//添加操作日志

            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认撤回？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                string sql = " AND TRM.C_STA_ID='" + staID + "' ";

                DataTable dt = bll_TRC_COGDOWN_MAIN.GetListMain(sql, false).Tables[0];
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("无组批记录，无法撤回!");
                    return;
                }
                DataRow dr = dt.Rows[0];
                string planID = dr["C_PLAN_ID"].ToString();
                string asseID = dr["C_ID"].ToString();
                decimal wgt = decimal.Parse(dr["N_WGT_TOTAL"].ToString());

                string result = bll_TRC_COGDOWN_MAIN.BackOutHandler(asseID, wgt, planID);
                if (result == "1")
                {
                    MessageBox.Show("操作成功!");
                    Query1();
                    Query2();
                    Query3();
                    //生成批号
                    this.txt_BranchNo.Text = bll_TRC_COGDOWN_MAIN.CreateBranchNo(staID);
                }
                else
                {
                    MessageBox.Show("操作失败!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void gv_KDZGZ_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
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

        private void gv_KPZPSJ_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_KPZPSJ.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_KPZPSJ.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_KPZPSJ_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_KPZPSJ.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "关闭计划", "关闭计划", "关闭计划");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认关闭计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_KPZPJH.FocusedRowHandle;//获取计划焦点行索引

            if (selectedPlanHandle < 0)
            {
                MessageBox.Show("请检查计划记录!");
                return;
            }
            string planID = this.gv_KPZPJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            decimal wgt = decimal.Parse(this.gv_KPZPJH.GetRowCellValue(selectedPlanHandle, "N_GROUP_WGT").ToString());//获取焦点主键

            if (wgt != 0)
            {
                MessageBox.Show("只能撤销组坯量为0的计划！");
                return;
            }

            string result = bll_TRC_COGDOWN_MAIN.ClosePlan(planID);

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

        private void gv_KPZPJH_Click(object sender, EventArgs e)
        {
            Query2();
            GetOrderRelationAsse();

            int selectedHandle = this.gv_KPZPJH.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.gc_KDZGZ.DataSource = null;
                this.gv_KDZGZ.BestFitColumns();
                return;
            }
            //获取焦点行
            var wgt = decimal.Parse(this.gv_KPZPJH.GetRowCellValue(selectedHandle, "N_WGT").ToString());
            var groupWgt = decimal.Parse(this.gv_KPZPJH.GetRowCellValue(selectedHandle, "N_GROUP_WGT").ToString() == "" ? "0" : this.gv_KPZPJH.GetRowCellValue(selectedHandle, "N_GROUP_WGT").ToString());
            //if (groupWgt <= wgt)
            //{
            //    btn_Sucess.Enabled = false;
            //}
            //else
            //{
            //    btn_Sucess.Enabled = true;
            //}
            //if (groupWgt == 0)
            //{ btn_Close.Enabled = true; }
            //else
            //{ btn_Close.Enabled = false; }

        }

        private void GetOrderRelationAsse()
        {
            int selectedPlanHandle = this.gv_KPZPJH.FocusedRowHandle;//获取计划焦点行索引
            if (selectedPlanHandle<0)
            {
                return;
            }
            string planID = this.gv_KPZPJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键

            string whereSql = " AND TRM.C_PLAN_ID='" + planID + "' ";
            DataTable dt = bll_TRC_COGDOWN_MAIN.GetListMain(whereSql, false).Tables[0];
            this.gridControl1.DataSource = dt;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView1);
        }

        /// <summary>
        /// 获取钢坯库存
        /// </summary>
        private void GetSalbInvenStory()
        {
            int selectedHandle = this.gv_KPZPJH.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                this.gc_KDZGZ.DataSource = null;
                this.gv_KDZGZ.BestFitColumns();
                return;
            }

            //获取焦点行执行标准
            std = this.gv_KPZPJH.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();
            //钢坯规格
            string spec = this.gv_KPZPJH.GetRowCellValue(selectedHandle, "C_SLAB_SIZE").ToString();
            //物料编码
            string matCode = this.gv_KPZPJH.GetRowCellValue(selectedHandle, "C_MATRL_CODE_SLAB").ToString();
            //长度
            string length = this.gv_KPZPJH.GetRowCellValue(selectedHandle, "N_SLAB_LENGTH").ToString();
            var dt = bll_TRC_ROLL_MAIN.GetSlabInventory(null, spec, std, null, matCode, length, null);
            gc_PDJG.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_PDJG);
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
                this.lbl_minjcsort.Text = jcminsort.ToString();
                this.lbl_minlcsort.Text = ((int)bll_plan_sms.GetModelListByJcID(jc_cast_plan[0].C_ID).Min(a => a.N_SORT)).ToString();//报错
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
            OutToExcel.ToExcel(this.gc_KPZPSJ, "开坯组坯计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_KPZPJH, "开坯计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void btn_Sucess_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "完成计划", "完成计划", "完成计划");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认完成计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_KPZPJH.FocusedRowHandle;//获取计划焦点行索引

            if (selectedPlanHandle < 0)
            {
                MessageBox.Show("请检查计划记录!");
                return;
            }
            string planID = this.gv_KPZPJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键

            string result = bll_TRC_COGDOWN_MAIN.SuccessPlan(planID);
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

        private void hideContainerRight_Click(object sender, EventArgs e)
        {
            GetSalbInvenStory();
        }

        private void gc_PDJG_MouseDown(object sender, MouseEventArgs e)
        {
            GetSalbInvenStory();
        }

        private void gv_KPZPSJ_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_KPZPSJ.GetDataRow(gv_KPZPSJ.FocusedRowHandle);
                if (dr != null)
                {
                    // 创建报表
                    FrmRR_LGKP report = new FrmRR_LGKP(dr["C_BATCH_NO"].ToString(),2);
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
