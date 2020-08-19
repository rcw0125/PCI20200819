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
    public partial class XM : Form
    {
        public XM()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            //staID = bll_TB_STA.GetStaIdByCode(arr[1]);           
            slbwhCodeArr = arr[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staCode = arr[1];
            area = arr[2];
        }

        string slbwhCode = "588";//待修磨钢坯仓库库位编码
        string[] slbwhCodeArr = null;//待修磨钢坯仓库库位编码
        string staCode = "";
        string area = "";

        CommonSub sub = new CommonSub();
        Bll_TRC_PLAN_REGROUND bll_TRC_PLAN_REGROUND = new Bll_TRC_PLAN_REGROUND();

        private void XM_Load(object sender, EventArgs e)
        {
            this.dt_Plan.DateTime = DateTime.Now.AddDays(-5);
            this.dt_PlanEnd.DateTime = DateTime.Now.AddDays(1);
            BindXMPlanData();
            BindSta();
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            sub.ImageComboBoxEditBindNCBC(cbo_Shift, staCode);
            sub.ImageComboBoxEditBindNCBZ(cbo_Group, staCode);
            sub.BCBZBindEdit(cbo_Shift, cbo_Group, staCode);
            gv_XMJH.CustomColumnDisplayText += Gv_XMJH_CustomColumnDisplayText;
            txt_EMP.Text = RV.UI.UserInfo.userID;
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

        private void Gv_XMJH_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "N_TYPE")
            {
                switch (e.DisplayText)
                {
                    case "1":
                        e.DisplayText = "原料";
                        break;
                    case "2":
                        e.DisplayText = "半成品";
                        break;
                }
            }
        }

        /// <summary>
        /// 绑定修磨计划
        /// </summary>
        public void BindXMPlanData()
        {
            this.gc_XMJH.DataSource = null;
            string sqlWhere = " AND  T.N_STATUS=0  AND T.N_QUA>0  AND C_SLAB_TYPE='" + area + "' ";

            if (!string.IsNullOrWhiteSpace(txt_Stove.Text))
                sqlWhere += "  AND ( T.C_STOVE  like '%" + txt_Stove.Text + "%' or  T.C_BATCH_NO like '%" + txt_Stove.Text + "%'  ) ";

            string type = img_Type.EditValue == null ? "" : img_Type.EditValue.ToString();
            if (!string.IsNullOrWhiteSpace(type))
            {
                sqlWhere += " AND T.N_TYPE=" + type + "  ";
            }

            //if (this.dt_Plan.DateTime != DateTime.MinValue)
            //{
            //    sqlWhere += " AND  T.D_QR_DATE>to_date('" + dt_Plan.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //    sqlWhere += " AND  T.D_QR_DATE<to_date('" + dt_PlanEnd.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
            //}

            DataTable dt = bll_TRC_PLAN_REGROUND.GetListXm(sqlWhere, slbwhCodeArr).Tables[0];
            this.gc_XMJH.DataSource = dt;
            this.gv_XMJH.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_XMJH);


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

            //获取计划焦点行索引
            int selectedPlanHandle = this.gv_XMJH.FocusedRowHandle;
            //获取焦点支数
            int num = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "N_QUA") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "N_QUA").ToString());
            if (area == "1")
            {
                //获取焦点全修2mm
                int C_EXTEND1 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND1") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND1").ToString());
                //获取焦点全修1.5mm
                int C_EXTEND2 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND2") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND2").ToString());
                //获取焦点全修1mm
                int C_EXTEND3 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND3") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND3").ToString());
                //获取焦点精修0.5mm
                int C_EXTEND4 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND4") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND4").ToString());
                //获取焦点修角刺
                int C_EXTEND5 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND5") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND5").ToString());
                //获取焦点全修1.5mm
                int C_EXTEND6 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND6") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND6").ToString());
                //获取焦点精修1mm
                int C_EXTEND12 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND12") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND12").ToString());
            }
            else
            {
                //获取焦点全修2mm
                int C_EXTEND1 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND7") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND7").ToString());
                //获取焦点全修1.5mm
                int C_EXTEND2 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND8") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND8").ToString());
                //获取焦点全修1mm
                int C_EXTEND3 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND9") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND9").ToString());
                //获取焦点精修0.5mm
                int C_EXTEND4 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND10") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND10").ToString());
                int C_EXTEND5 = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND13") == null ? 0 : int.Parse(this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_EXTEND13").ToString());
            }
            //if (num == C_EXTEND1)
            //{
            //    var item = img_RegroundStandard.Properties.Items.GetItem("全修2mm");
            //    img_RegroundStandard.Properties.Items.Remove(item);
            //}
            //if (num == C_EXTEND2)
            //{
            //    var item = img_RegroundStandard.Properties.Items.GetItem("全修1.5mm");
            //    img_RegroundStandard.Properties.Items.Remove(item);
            //}
            //if (num == C_EXTEND3)
            //{
            //    var item = img_RegroundStandard.Properties.Items.GetItem("全修1mm");
            //    img_RegroundStandard.Properties.Items.Remove(item);
            //}
            //if (num == C_EXTEND4)
            //{
            //    var item = img_RegroundStandard.Properties.Items.GetItem("精修0.5mm");
            //    img_RegroundStandard.Properties.Items.Remove(item);
            //}
            //if (num == C_EXTEND5)
            //{
            //    var item = img_RegroundStandard.Properties.Items.GetItem("修角刺");
            //    img_RegroundStandard.Properties.Items.Remove(item);
            //}
            this.txt_Elim.Text = "0";

        }

        /// <summary>
        /// 绑定修磨操作记录
        /// </summary>
        public void BindHandlerData(string id)
        {
            DataTable dt = bll_TRC_PLAN_REGROUND.GetRegroundHandler(1, id).Tables[0];
            this.gc_Handler.DataSource = dt;
            this.gv_Handler.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_Handler);
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "确认修磨", "确认修磨", "确认修磨");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认修磨吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
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
            string batchNo = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "C_BATCH_NO").ToString();//获取焦点批次号
            string xmbz = img_RegroundStandard.Text;//修磨表标准
            string factNum = txt_Num.Text;//支数
            string sta = image_Sta.EditValue == null ? "" : image_Sta.EditValue.ToString();//工位
            string remark = txt_Remark.Text;//备注
            string emp = txt_EMP.Text;//修磨人
            string hg = "";//txt_HG.Text;//货管
            string grinWheel = cbo_GrinWheel.Text;//砂轮
            string group = this.cbo_Group.EditValue.ToString();//班组
            string shift = this.cbo_Shift.EditValue.ToString();//班次
            DateTime operation = this.dt_operation.DateTime;

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

            if (string.IsNullOrWhiteSpace(grinWheel))
            {
                MessageBox.Show("请选砂轮!");
                return;
            }

            if (string.IsNullOrWhiteSpace(xmbz))
            {
                MessageBox.Show("请选择修磨标准!");
                return;
            }
            string columnName = "";
            if (area == "1")
            {
                columnName = General.NameType[xmbz];
            }
            else
            {
                columnName = General.NameTypes[xmbz];
            }
            string xmbzNum = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, columnName).ToString();//获取焦点修磨标准支数
            int reaultNum = int.Parse(xmbzNum) + int.Parse(factNum);

            if (reaultNum > int.Parse(num))
            {
                MessageBox.Show("修磨支数大于工序最大支数!");
                return;
            }


            string result = bll_TRC_PLAN_REGROUND.RegroundConfirm(id, num, factNum, xmbz, sta, remark, emp, hg, batchNo, "合格", "临时", slbwhCode, grinWheel
               , group, shift, operation, area);

            if (result == "1")
            {
                BindXMPlanData();
                BindHandlerData(id);
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

        private void btn_Accomplish_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "确认完成", "确认完成", "确认完成");//添加操作日志

            if (DialogResult.No == MessageBox.Show("确认完成吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
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
            string num = this.gv_XMJH.GetRowCellValue(selectedPlanHandle, "N").ToString();//获取焦点支数        
            string factNum = txt_Num.Text;//支数        



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

            string result = bll_TRC_PLAN_REGROUND.Accomplish(id, factNum, "修磨");

            if (result == "1")
            {
                BindXMPlanData();
                BindHandlerData(id);
                MessageBox.Show("操作成功!");
            }
            else
            {
                MessageBox.Show("操作失败!");
            }
            RefreshControls();
        }

        private void btn_AssePlanQuery_Click(object sender, EventArgs e)
        {
            //int compareDt = DateTime.Compare(this.dt_Plan.DateTime, this.dt_PlanEnd.DateTime);
            //if (compareDt > 0)
            //{
            //    MessageBox.Show("日期错误!");
            //    return;
            //}
            BindXMPlanData();
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
                        this.image_Sta.Properties.Items.Add(item["C_STA_DESC"].ToString(), item["C_STA_CODE"], -1);
                }
                else if (area == "2")
                {
                    if (item["C_STA_CODE"].ToString() == "9#XM" || item["C_STA_CODE"].ToString() == "10#XM")
                        this.image_Sta.Properties.Items.Add(item["C_STA_DESC"].ToString(), item["C_STA_CODE"], -1);
                }
            }
            this.image_Sta.SelectedIndex = 0;
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

        /// <summary>
        /// 删除修磨记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "确认删除", "确认删除", "确认删除");//添加操作日志


            if (DialogResult.No == MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_Handler.FocusedRowHandle;//获取计划焦点行索引
            if (selectedPlanHandle < 0)
            {
                MessageBox.Show("请检查修磨记录，数据为空!");
                return;
            }

            string id = this.gv_Handler.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            string regroundid = this.gv_Handler.GetRowCellValue(selectedPlanHandle, "C_REGROUND_ID").ToString();//获取焦点修磨计划id
            string xmbz = this.gv_Handler.GetRowCellValue(selectedPlanHandle, "C_XMBZ").ToString();//获取焦点修磨标准
            string qua = this.gv_Handler.GetRowCellValue(selectedPlanHandle, "N_QUA").ToString();//获取焦点修磨支数

            string result = bll_TRC_PLAN_REGROUND.DelRegroundHandler(id, regroundid, xmbz, qua);
            if (result == "1")
            {
                MessageBox.Show("操作成功");
                BindXMPlanData();
                BindHandlerData(regroundid);
            }
            else
            {
                MessageBox.Show("操作失败");
            }

        }

        /// <summary>
        /// 剔除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Elim_Click(object sender, EventArgs e)
        {

            string strMenuName = RV.UI.UserInfo.menuName;
            UserLog.AddLog(strMenuName, this.Name + "修磨剔除", "修磨剔除", "修磨剔除");//添加操作日志

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
            string remark = txt_ElimRemark.Text;//备注


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

            string result = bll_TRC_PLAN_REGROUND.Elim(id, factNum, "修磨", remark, slbwhCodeArr[0]);

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_XMJH, "修磨计划" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_Handler, "修磨记录" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
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

        private void gv_XMJH_ColumnChanged(object sender, EventArgs e)
        {

        }
    }
}
