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

namespace XGCAP.UI.R.RC
{
    public partial class FrmRC_KPJRLGL : Form
    {
        public FrmRC_KPJRLGL()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staID = bll_TB_STA.GetStaIdByCode(arr[0]);
            staCode = arr[0];
            slabwhCode = arr[1];
        }

        CommonSub sub = new CommonSub();
        Bll_TSC_SLAB_MAIN bll_TSC_SLAB_MAIN = new Bll_TSC_SLAB_MAIN();
        Bll_TRC_COGDOWN_MAIN bll_TRC_COGDOWN_MAIN = new Bll_TRC_COGDOWN_MAIN();
        Bll_TRC_COGDOWN_LOG bll_TRC_COGDOWN_LOG = new Bll_TRC_COGDOWN_LOG();
        Bll_TRP_PLAN_COGDOWN bll_TRP_PLAN_COGDOWN = new Bll_TRP_PLAN_COGDOWN();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();

        private string staID = "";//轧线工位ID
        private string staCode = "";
        string slabwhCode = "";//仓库

        private void FrmRC_KPJRLGL_Load(object sender, EventArgs e)
        {
            SetTime();
            RefreshPut(Query1());
            RefreshOut(Query2());
            Refresh(Query3());
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            sub.ImageComboBoxEditBindNCBC(cbo_PutShift, staCode);
            sub.ImageComboBoxEditBindNCBZ(cbo_PutGroup, staCode);
            sub.BCBZBindEdit(cbo_PutShift, cbo_PutGroup, staCode);
            sub.ImageComboBoxEditBindNCBC(cbo_OutShift, staCode);
            sub.ImageComboBoxEditBindNCBZ(cbo_OutGroup, staCode);
            sub.BCBZBindEdit(cbo_OutShift, cbo_OutGroup, staCode);
        }

        /// <summary>
        /// 设置时间控件
        /// </summary>
        private void SetTime()
        {
            this.dt_Put.DateTime = DateTime.Now;
            this.dt_Put.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dt_Put.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
            this.dt_Put.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dt_Put.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Put.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dt_Put.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Put.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm";

            this.dt_Out.DateTime = DateTime.Now;
            this.dt_Out.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dt_Out.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
            this.dt_Out.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dt_Out.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Out.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dt_Out.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_Out.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm";
        }

        private DataTable Query1()
        {
            string whereSql = "";

            whereSql += " AND TRM.C_STA_ID='" + staID + "' ";

            whereSql += " AND TRM.N_QUA_TOTAL>0 ";

            if (!string.IsNullOrWhiteSpace(this.txt_Grd.Text))
                whereSql += " AND UPPER(TPC.C_STL_GRD) LIKE  UPPER('%" + txt_Grd.Text + "%')   ";

            if (!string.IsNullOrWhiteSpace(this.txt_Std.Text))
                whereSql += " AND TRM.C_STD_CODE LIKR '%" + txt_Std.Text + "%'  ";

            if (!string.IsNullOrWhiteSpace(this.txt_Spec.Text))
                whereSql += " AND TRM.C_SPEC LIKR '%" + txt_Spec.Text + "%'  ";

            DataTable dt = bll_TRC_COGDOWN_MAIN.GetListMain(whereSql, true).Tables[0];
            this.gc_DRLGP.DataSource = dt;
            this.gv_DRLGP.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_DRLGP);
            return dt;
        }

        private DataTable Query2()
        {
            string whereSql = "  WHERE TRM.N_STATUS = 1  AND TWF.N_ROLL_STATE=1     ";

            whereSql += " AND TRM.C_STA_ID='" + staID + "' ";

            DataTable dt = bll_TRC_COGDOWN_MAIN.GetList(whereSql, true, 1).Tables[0];
            this.gc_JRLRL.DataSource = dt;
            this.gv_JRLRL.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_JRLRL);
            return dt;
        }

        private DataTable Query3()
        {
            string whereSql = "  WHERE TRM.N_STATUS = 1 AND TWF.N_ROLL_STATE=2 ";

            whereSql += " AND TRM.C_STA_ID='" + staID + "' ";


            DataTable dt = bll_TRC_COGDOWN_MAIN.GetList(whereSql, true, 2).Tables[0];
            this.gc_JRLCL.DataSource = dt;
            this.gv_JRLCL.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_JRLCL);
            return dt;
        }

        /// <summary>
        /// 入炉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Put_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "入炉", "入炉", "入炉");//添加操作日志

            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认入炉？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                DataTable dtLength = Query1();
                if (dtLength == null || dtLength.Rows.Count == 0)
                {
                    MessageBox.Show("无待入炉钢坯!");
                    return;
                }

                int errorNum = 0;//TryParse 输出参数
                //入炉总支数
                string putNum = this.txt_PutNum.Text.Trim();
                if (!Int32.TryParse(putNum, out errorNum))
                {
                    MessageBox.Show("入炉支数只能是整数!");
                    return;
                }

                if (int.Parse(putNum) == 0)
                {
                    MessageBox.Show("入炉支数不能为0!");
                    return;
                }

                int result = 0;
                //单次入炉支数
                int num = 0;
                //控制循环开关
                bool bol = false;
                do
                {
                    DataTable dt = Query1();
                    if (dt == null || dt.Rows.Count == 0)
                    {
                        bol = false;
                        break;
                    }


                    //总入炉支数-组坯支数 如果记过>0还需要下一下循环 <=0不需要下次循环
                    int calculate = int.Parse(putNum) - Convert.ToInt32(dt.Rows[0]["N_QUA_TOTAL"]);
                    if (calculate > 0)
                    {
                        bol = true;
                        num = Convert.ToInt32(dt.Rows[0]["N_QUA_TOTAL"]);
                        putNum = calculate.ToString();
                    }
                    else
                    {
                        bol = false;
                        num = int.Parse(putNum);
                    }

                    string remark = dt.Rows[0]["C_REMARK"] == null ? "" : dt.Rows[0]["C_REMARK"].ToString();
                    if (!string.IsNullOrWhiteSpace(remark))
                        this.txt_PutRemark.Text += "|" + remark;
                    string id = dt.Rows[0]["C_ID"].ToString();
                    string batchNo = dt.Rows[0]["C_BATCH_NO"].ToString();
                    string staID = dt.Rows[0]["C_STA_ID"].ToString();
                    string planID = dt.Rows[0]["C_PLAN_ID"].ToString();
                    var plan = bll_TRP_PLAN_COGDOWN.GetModel(planID);
                    decimal qua = decimal.Parse(dt.Rows[0]["N_QUA_TOTAL_VIRTUAL"].ToString());
                    decimal wgt = decimal.Parse(dt.Rows[0]["N_WGT_TOTAL_VIRTUAL"].ToString());
                    decimal pw = plan.N_SLAB_PW.Value;
                    if (bll_TRC_COGDOWN_MAIN.PutFurnaceHandler(id, num, batchNo, staID, this.cbo_PutShift.EditValue.ToString(), this.cbo_PutGroup.EditValue.ToString(), this.txt_PutRemark.Text, planID, pw, RV.UI.ServerTime.timeNow()) == "1")
                        result++;
                }
                while (bol);

                if (result > 0)
                    MessageBox.Show("操作成功");
                else
                    MessageBox.Show("操作失败");

                RefreshPut(Query1());
                RefreshOut(Query2());
                Refresh(Query3());
                this.txt_PutRemark.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 入炉撤回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PutBack_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "入炉撤回", "入炉撤回", "入炉撤回");//添加操作日志

            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认撤回？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int errorNum = 0;//TryParse 输出参数
                //撤回支数
                string num = this.txt_putCancelNum.Text.Trim();
                if (!Int32.TryParse(num, out errorNum))
                {
                    MessageBox.Show("撤回支数只能是整数!");
                    return;
                }

                if (int.Parse(num) <= 0)
                {
                    MessageBox.Show("撤回支数不能小于0");
                    return;
                }

                //剔除支数不能大于入炉支数
                int furnaceNum = bll_TRC_COGDOWN_MAIN.GetFurnaceNum(staID, int.Parse(num), 1);
                if (furnaceNum < int.Parse(num))
                {
                    MessageBox.Show("撤回支数不能大于入炉支数!");
                    return;
                }

                if (bll_TRC_COGDOWN_MAIN.PutBackHandler(staID, this.txt_PutRemark.Text, int.Parse(num)) == "1")
                    MessageBox.Show("撤回成功！");
                else
                    MessageBox.Show("撤回失败！");

                RefreshPut(Query1());
                RefreshOut(Query2());
                Refresh(Query3());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 入炉剔除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PutElim_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "入炉剔除", "入炉剔除", "入炉剔除");//添加操作日志

            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认剔除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int errorNum = 0;//TryParse 输出参数
                //支数
                string putNum = this.txt_putCancelNum.Text.Trim();
                if (!Int32.TryParse(putNum, out errorNum))
                {
                    MessageBox.Show("剔除支数只能是整数!");
                    return;
                }

                if (int.Parse(putNum) <= 0)
                {
                    MessageBox.Show("剔除支数不能为0");
                    return;
                }

                DataTable dt = Query1();
                //剔除支数不能大于入炉支数
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("无待入炉数据!");
                    return;
                }

                int num = Convert.ToInt32(dt.Rows[0]["N_QUA_TOTAL"]);
                if (int.Parse(putNum) >= num)
                {
                    MessageBox.Show("剔除后组坯支数为0，请撤回组坯计划重新组坯!");
                    return;
                }

                string shift = this.cbo_PutShift.EditValue.ToString();
                string group = this.cbo_PutGroup.EditValue.ToString();
                string userID = RV.UI.UserInfo.UserID;
                string id = dt.Rows[0]["C_ID"].ToString();

                if (bll_TRC_COGDOWN_MAIN.PutElimHandler(staID, this.txt_PutRemark.Text, int.Parse(putNum), slabwhCode, shift, group, userID, id) == "1")
                    MessageBox.Show("剔除成功！");
                else
                    MessageBox.Show("剔除失败！");

                RefreshPut(Query1());
                RefreshOut(Query2());
                Refresh(Query3());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 出炉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OutFurnace_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "出炉", "出炉", "出炉");//添加操作日志

            if (DialogResult.No == MessageBox.Show("是否确认出炉？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            DataTable dtLength = Query2();
            if (dtLength == null || dtLength.Rows.Count == 0)
            {
                MessageBox.Show("无入炉钢坯!");
                return;
            }

            int errorNum = 0;//TryParse 输出参数
            //出炉总支数
            string outNum = this.txt_OutNum.Text.Trim();
            if (!Int32.TryParse(outNum, out errorNum))
            {
                MessageBox.Show("出炉支数只能是整数!");
                return;
            }

            if (int.Parse(outNum) == 0)
            {
                MessageBox.Show("出炉支数不能为0!");
                return;
            }

            int result = 0;
            //单次入炉支数
            int num = 0;
            //控制循环开关
            bool bol = false;
            do
            {
                DataTable dt = Query2();
                if (dt == null || dt.Rows.Count == 0)
                {
                    bol = false;
                    break;
                }

                //总入炉支数-组坯支数 如果记过>0还需要下一下循环 <=0不需要下次循环
                int calculate = int.Parse(outNum) - Convert.ToInt32(dt.Rows[0]["N_QUA_JOIN"]);
                if (int.Parse(dt.Rows[0]["N_QUA_JOIN"].ToString()) == 0)
                {
                    break;
                }
                else if (calculate > 0)
                {
                    bol = true;
                    num = Convert.ToInt32(dt.Rows[0]["N_QUA_JOIN"]);
                    outNum = calculate.ToString();
                }
                else
                {
                    bol = false;
                    num = int.Parse(outNum);
                }

                string remark = dt.Rows[0]["C_REMARK"] == null ? "" : dt.Rows[0]["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                    this.txt_OutRemark.Text += "|" + remark;
                string id = dt.Rows[0]["C_ID"].ToString();
                string batchNo = dt.Rows[0]["C_BATCH_NO"].ToString();
                string staID = dt.Rows[0]["C_STA_ID"].ToString();
                string planID = dt.Rows[0]["C_PLAN_ID"].ToString();
                var plan = bll_TRP_PLAN_COGDOWN.GetModel(planID);
                decimal pw = plan.N_SLAB_PW.Value;
                if (bll_TRC_COGDOWN_MAIN.OutFurnaceHandler(id, num, batchNo, staID, this.cbo_OutShift.EditValue.ToString(), this.cbo_OutGroup.EditValue.ToString(), this.txt_OutRemark.Text, planID, pw, RV.UI.ServerTime.timeNow()) == "1")
                    result++;
            }
            while (bol);

            if (result > 0)
                MessageBox.Show("操作成功");
            else
                MessageBox.Show("操作失败");

            RefreshPut(Query1());
            RefreshOut(Query2());
            Refresh(Query3());
            this.txt_OutRemark.Text = "";
        }

        /// <summary>
        /// 出炉撤回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OutBack_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "出炉撤回", "出炉撤回", "出炉撤回");//添加操作日志

            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认撤回？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int errorNum = 0;//TryParse 输出参数
                //支数
                string outNum = this.txt_outCancelNum.Text.Trim();
                if (!Int32.TryParse(outNum, out errorNum))
                {
                    MessageBox.Show("撤回支数只能是整数!");
                    return;
                }

                if (int.Parse(outNum) <= 0)
                {
                    MessageBox.Show("撤回支数不能小于0");
                    return;
                }

                //剔除支数不能大于入炉支数
                int furnaceNum = bll_TRC_COGDOWN_MAIN.GetFurnaceNum(staID, int.Parse(outNum), 2);
                if (furnaceNum < int.Parse(outNum))
                {
                    MessageBox.Show("撤回支数不能大于入炉支数!");
                    return;
                }

                if (bll_TRC_COGDOWN_MAIN.OutBackHandler(staID, this.txt_PutRemark.Text, int.Parse(outNum), this.cbo_OutShift.EditValue.ToString(), this.cbo_OutGroup.EditValue.ToString()) == "1")
                    MessageBox.Show("撤回成功！");
                else
                    MessageBox.Show("撤回失败！");

                RefreshPut(Query1());
                RefreshOut(Query2());
                Refresh(Query3());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 出炉剔除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OutElim_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "出炉剔除", "出炉剔除", "出炉剔除");//添加操作日志

            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认剔除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int errorNum = 0;//TryParse 输出参数
                //支数
                string outNum = this.txt_outCancelNum.Text.Trim();
                if (!Int32.TryParse(outNum, out errorNum))
                {
                    MessageBox.Show("剔除支数只能是整数!");
                    return;
                }

                if (int.Parse(outNum) <= 0)
                {
                    MessageBox.Show("剔除支数不能为0");
                    return;
                }

                //剔除支数不能大于入炉支数
                int furnaceNum = bll_TRC_COGDOWN_MAIN.GetFurnaceNum(staID, int.Parse(outNum), 2);
                if (furnaceNum < int.Parse(outNum))
                {
                    MessageBox.Show("剔除支数不能大于出炉支数!");
                    return;
                }

                string shift = this.cbo_OutShift.EditValue.ToString();
                string group = this.cbo_OutGroup.EditValue.ToString();
                string userID = RV.UI.UserInfo.UserID;

                if (bll_TRC_COGDOWN_MAIN.OutElimHandler(staID, this.txt_OutRemark.Text, int.Parse(outNum), slabwhCode, shift, group, userID) == "1")
                    MessageBox.Show("剔除成功！");
                else
                    MessageBox.Show("剔除失败！");

                RefreshPut(Query1());
                RefreshOut(Query2());
                Refresh(Query3());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 刷新入炉支数
        /// </summary>
        /// <param name="dt"></param>
        public void RefreshPut(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                this.txt_PutNum.Text = dt.Rows[0]["N_QUA_TOTAL"].ToString();
            }
            else
            {
                this.txt_PutNum.Text = "0";

            }
            this.txt_putCancelNum.Text = "0";
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="dt"></param>
        public void Refresh(DataTable dt)
        {
            this.txt_outCancelNum.Text = "0";
        }

        /// <summary>
        /// 刷新出炉支数
        /// </summary>
        /// <param name="dt"></param>
        public void RefreshOut(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                this.txt_OutNum.Text = dt.Rows[0]["N_QUA_JOIN"].ToString();
            }
            else
            {
                this.txt_OutNum.Text = "0";
            }
            this.txt_outCancelNum.Text = "0";
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            RefreshPut(Query1());
            RefreshOut(Query2());
            Refresh(Query3());
        }

        private void gv_DRLGP_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_DRLGP.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_DRLGP_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_DRLGP.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_DRLGP.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_JRLRL_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_JRLRL.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_JRLRL_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_JRLRL.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_JRLRL.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_JRLCL_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gv_JRLCL.GetRow(e.RowHandle) == null)
            {
                return;
            }
            else
            {
                //获取所在行指定列的值
                var obj = gv_JRLCL.GetRowCellValue(e.RowHandle, "C_REMARK");
                string remark = obj == null ? "" : obj.ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gv_JRLCL_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var dr = gv_JRLCL.GetDataRow(e.RowHandle);
                string remark = dr["C_REMARK"] == null ? "" : dr["C_REMARK"].ToString();
                if (!string.IsNullOrWhiteSpace(remark))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dt_Put.DateTime = DateTime.Now;
            dt_Out.DateTime = DateTime.Now;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dt_Put.DateTime = DateTime.Now;
            dt_Out.DateTime = DateTime.Now;
        }
    }
}
