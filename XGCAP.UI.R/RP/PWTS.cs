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

namespace XGCAP.UI.R.RP
{
    public partial class PWTS : Form
    {
        public PWTS()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            //staID = bll_TB_STA.GetStaIdByCode(arr[1]);           
            slbwhCodeArr = arr[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staCode = arr[1];
            area = arr[2];
        }

        string[] slbwhCodeArr = null;//待修磨钢坯仓库库位编码
        string staCode = "";
        string area = "";

        CommonSub sub = new CommonSub();
        Bll_TRC_PLAN_REGROUND bll_TRC_PLAN_REGROUND = new Bll_TRC_PLAN_REGROUND();

        private void PWTS_Load(object sender, EventArgs e)
        {
            this.dt_Plan.DateTime = DateTime.Now.AddDays(-5);
            this.dt_PlanEnd.DateTime = DateTime.Now.AddDays(1);
            BindXMPlanData();
            BindSta();
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            sub.ImageComboBoxEditBindNCBC(cbo_Shift, staCode);
            sub.ImageComboBoxEditBindNCBZ(cbo_Group, staCode);
            sub.BCBZBindEdit(cbo_Shift, cbo_Group, staCode);
            this.txt_NotNum.Text = "0";
            txt_EMP.Text = RV.UI.UserInfo.UserID;
            SetDate();
        }

        private void SetDate()
        {
            this.dt_operation.DateTime = DateTime.Now;
            this.dt_operation.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dt_operation.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
            this.dt_operation.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dt_operation.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_operation.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.dt_operation.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_operation.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm";
        }

        /// <summary>
        /// 绑定探伤计划
        /// </summary>
        public void BindXMPlanData()
        {
            this.gc_XMJH.DataSource = null;
            string sqlWhere = " AND  T.N_STATUS=0  AND T.C_SLAB_TYPE='" + area + "' ";

            if (!string.IsNullOrWhiteSpace(txt_Stove.Text))
                sqlWhere += "  AND ( T.C_STOVE  like '%" + txt_Stove.Text + "%' or   T.C_BATCH_NO like '%" + txt_Stove.Text + "%'  ) ";

            //if (this.dt_Plan.DateTime != DateTime.MinValue)
            //{
            //    sqlWhere += " AND  T.D_QR_DATE>to_date('" + dt_Plan.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //    sqlWhere += " AND  T.D_QR_DATE<to_date('" + dt_PlanEnd.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //}

            DataTable dt = bll_TRC_PLAN_REGROUND.GetListPw(sqlWhere, slbwhCodeArr).Tables[0];
            this.gc_XMJH.DataSource = dt;
            this.gv_XMJH.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_XMJH);
            this.txt_Elim.Text = "0";
        }

        /// <summary>
        /// 绑定探伤操作记录
        /// </summary>
        public void BindHandlerData(string id)
        {
            DataTable dt = bll_TRC_PLAN_REGROUND.GetRegroundHandler(2, id).Tables[0];
            this.gc_Handler.DataSource = dt;
            this.gv_Handler.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_Handler);
        }

        private void gv_XMJH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_XMJH.GetDataRow(gv_XMJH.FocusedRowHandle);
                if (dr != null)
                {
                    txt_Num.Text = dr["N"].ToString();
                    BindHandlerData(dr["C_ID"].ToString());
                }
                else
                {
                    this.gc_Handler.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认探伤吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_XMJH.FocusedRowHandle;//获取计划焦点行索引
            if (selectedPlanHandle < 0)
            {
                MessageBox.Show("请检查探伤计划，记录为空!");
                return;
            }

            string id = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            string num = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "N_QUA").ToString();//获取焦点支数
            string notNum = this.txt_NotNum.Text;//未探支数
            string notCause = "";//this.txt_Cause.Text;//未探原因
            string batchNo = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_BATCH_NO").ToString();//获取焦点批次号
            string factNum = txt_Num.Text;//探伤支数
            string xmbz = cbo_Cause.Text;//修磨表标准
            string sta = image_Sta.EditValue == null ? "" : image_Sta.EditValue.ToString();//工位
            string remark = txt_Remark.Text;//备注
            string emp = txt_EMP.Text;//探伤人
            string notBz = cbo_Cause.Text + cbo_Level.Text;//不合格标准
            string group = this.cbo_Group.EditValue.ToString();//班组
            string shift = this.cbo_Shift.EditValue.ToString();//班次
            DateTime operation = this.dt_operation.DateTime;

            int errorNum = 0;//TryParse 输出参数      
            if (!Int32.TryParse(notNum, out errorNum))
            {
                MessageBox.Show("未探支数只能是整数!");
                return;
            }

            if (!Int32.TryParse(factNum, out errorNum))
            {
                MessageBox.Show("探伤支数只能是整数!");
                return;
            }

            if (Convert.ToInt32(factNum) > Convert.ToInt32(num))
            {
                MessageBox.Show("探伤支数不能大于库存支数!");
                return;
            }

            string result = bll_TRC_PLAN_REGROUND.ShotBlastingConfirm(id, num, factNum, notNum, notBz, sta, remark, emp, batchNo, "地上", notCause, group, shift, operation);

            if (result == "1")
            {
                BindXMPlanData();
                MessageBox.Show("操作成功!");
            }
            else
            {
                BindXMPlanData();
                MessageBox.Show("操作失败!");
            }
        }

        private void btn_Accomplish_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "抛丸完成", "抛丸完成", "抛丸完成");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认完成吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_XMJH.FocusedRowHandle;//获取计划焦点行索引
            if (selectedPlanHandle < 0)
            {
                MessageBox.Show("请检查探伤计划，记录为空!");
                return;
            }

            string id = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            string num = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "N").ToString();//获取焦点支数        
            string factNum = txt_Num.Text;//支数            
            string notNum = this.txt_NotNum.Text;//未探支数
            string cause = image_Sta.Text;//this.txt_Cause.Text;/抛丸说明
            string batchNo = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_BATCH_NO").ToString();//获取焦点批次号
            string xmbz = cbo_Cause.Text;//修磨表标准
            string sta = image_Sta.EditValue == null ? "" : image_Sta.EditValue.ToString().Substring(0, 2);//工位
            string remark = txt_Remark.Text;//备注
            string emp = txt_EMP.Text;//探伤人
            string notBz = cbo_Cause.Text + cbo_Level.Text;//不合格标准
            string group = this.cbo_Group.EditValue.ToString();//班组
            string shift = this.cbo_Shift.EditValue.ToString();//班次
            DateTime operation = this.dt_operation.DateTime;


            int errorNum = 0;//TryParse 输出参数      
            if (!Int32.TryParse(factNum, out errorNum))
            {
                MessageBox.Show("探伤支数只能是整数!");
                return;
            }

            if (!Int32.TryParse(notNum, out errorNum))
            {
                MessageBox.Show("未探支数只能是整数!");
                return;
            }

            if (Convert.ToInt32(factNum) > Convert.ToInt32(num))
            {
                MessageBox.Show("探伤支数不能大于库存支数!");
                return;
            }

            bll_TRC_PLAN_REGROUND.ShotBlastingConfirm(id, num, factNum, notNum, notBz, sta, remark, emp, batchNo, "地上", cause, group, shift, operation);
            string result = bll_TRC_PLAN_REGROUND.Accomplish(id, factNum, "抛丸探伤");

            if (result == "1")
            {
                BindXMPlanData();
                MessageBox.Show("操作成功!");
            }
            else
            {
                BindXMPlanData();
                MessageBox.Show("操作失败!");
            }
            RefreshControls();
        }

        private void btn_AssePlanQuery_Click(object sender, EventArgs e)
        {
            BindXMPlanData();
        }

        /// <summary>
        /// 绑定工位区域
        /// </summary>
        public void BindSta()
        {
            DataTable dt = bll_TRC_PLAN_REGROUND.GetStaInfo(1).Tables[0];
            image_Sta.Properties.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                this.image_Sta.Properties.Items.Add(item["C_STA_DESC"].ToString(), item["C_STA_CODE"], -1);
            }
            this.image_Sta.SelectedIndex = 0;
        }

        private void txt_NotNum_Leave(object sender, EventArgs e)
        {
            if (int.Parse(this.txt_NotNum.Text) > int.Parse(this.txt_Num.Text))
            {
                this.txt_Num.Text = "0";
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

        private void btn_Elim_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "抛丸剔除", "抛丸剔除", "抛丸剔除");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认剔除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
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
            string factNum = txt_Elim.Text;//支数        
            string remark = txt_ElimRemark.Text;



            int errorNum = 0;//TryParse 输出参数      
            if (!Int32.TryParse(factNum, out errorNum))
            {
                MessageBox.Show("剔除支数只能是整数!");
                return;
            }

            if (Convert.ToInt32(factNum) == 0)
            {
                MessageBox.Show("剔除支数不能为0!");
                return;
            }

            if (Convert.ToInt32(factNum) > Convert.ToInt32(num))
            {
                MessageBox.Show("剔除支数不能大于库存支数!");
                return;
            }

            string result = bll_TRC_PLAN_REGROUND.Elim(id, factNum, "抛丸探伤", remark, slbwhCodeArr[0]);

            if (result == "1")
            {
                BindXMPlanData();
                MessageBox.Show("操作成功!");
            }
            else
            {
                MessageBox.Show("操作失败!");
            }
            RefreshControls();
        }

        private void RefreshControls()
        {
            txt_Remark.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_XMJH, "抛丸探伤计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_Handler, "抛丸探伤记录" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void gv_XMJH_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_XMJH.GetDataRow(gv_XMJH.FocusedRowHandle);
                if (dr != null)
                {
                    txt_Num.Text = dr["N"].ToString();
                    BindHandlerData(dr["C_ID"].ToString());
                }
                else
                {
                    this.gc_Handler.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
