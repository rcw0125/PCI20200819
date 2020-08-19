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
    public partial class FrmRP_XMSJ : Form
    {
        public FrmRP_XMSJ()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            //staID = bll_TB_STA.GetStaIdByCode(arr[0]);           
            slbwhCodeArr = arr[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staCode = arr[1];
            dept = arr[2];

        }

        string[] slbwhCodeArr = null;//待修磨钢坯仓库库位编码
        string staID = "";
        string staCode = "";
        string dept = "";

        CommonSub sub = new CommonSub();
        Bll_TRC_PLAN_REGROUND bll_TRC_PLAN_REGROUND = new Bll_TRC_PLAN_REGROUND();

        private void FrmRP_XMSJ_Load(object sender, EventArgs e)
        {
            this.dt_Plan.DateTime = DateTime.Now.AddDays(-10);
            this.dt_PlanEnd.DateTime = DateTime.Now.AddDays(1);
            BindXMPlanData();
            //img_Status.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定修磨计划
        /// </summary>
        public void BindXMPlanData()
        {
            string sqlWhere = "";
            string status = img_Status.EditValue.ToString();
            if (!string.IsNullOrWhiteSpace(status))
                sqlWhere = " T.N_STATUS=" + status;
            else
                sqlWhere = " T.N_STATUS=1";
            if (this.dt_Plan.DateTime != DateTime.MinValue)
            {
                sqlWhere += " AND T.D_QR_DATE>to_date('" + dt_Plan.DateTime.ToString("yyyyMMdd") + " 00:00:00 ','yyyy-mm-dd hh24:mi:ss') ";
                sqlWhere += " AND  T.D_QR_DATE<to_date('" + dt_PlanEnd.DateTime.ToString("yyyyMMdd") + " 23:59:59','yyyy-mm-dd hh24:mi:ss') ";
            }

            if (!string.IsNullOrEmpty(txt_Stove.Text))
            {
                sqlWhere += " AND ( T.C_STOVE like '%" + txt_Stove.Text + "%' or  T.C_BATCH_NO like '%" + txt_Stove.Text + "%' ) ";
            }

            sqlWhere += " AND  T.C_SLAB_TYPE='" + dept + "'  ";
            DataTable dt = bll_TRC_PLAN_REGROUND.GetList(sqlWhere, slbwhCodeArr).Tables[0];
            this.gc_XMJH.DataSource = dt;
            this.gv_XMJH.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_XMJH);
        }

        private void btn_AssePlanQuery_Click(object sender, EventArgs e)
        {
            int compareDt = DateTime.Compare(this.dt_Plan.DateTime, this.dt_PlanEnd.DateTime);
            if (compareDt > 0)
            {
                MessageBox.Show("日期错误!");
                return;
            }
            BindXMPlanData();
        }


        /// <summary>
        /// 绑定修磨操作记录
        /// </summary>
        public void BindHandlerData(string id)
        {
            DataTable dt = bll_TRC_PLAN_REGROUND.GetRegroundHandler(id).Tables[0];
            this.gc_Handler.DataSource = dt;
            this.gv_Handler.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_Handler);
        }

        private void gv_Handler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gv_XMJH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_XMJH.GetDataRow(gv_XMJH.FocusedRowHandle);
                if (dr != null)
                {
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认删除计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            DataRow dr = gv_XMJH.GetDataRow(gv_XMJH.FocusedRowHandle);
            if (dr != null)
            {
                if (bll_TRC_PLAN_REGROUND.Delete(dr["C_ID"].ToString()))
                {
                    MessageBox.Show("操作成功");
                    btn_AssePlanQuery_Click(null, null);
                }
                else
                    MessageBox.Show("操作成功");
            }
        }
    }
}
