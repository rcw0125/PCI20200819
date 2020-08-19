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
    public partial class FrmRC_TBKPSJ3 : Form
    {
        public FrmRC_TBKPSJ3()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staID = bll_TB_STA.GetStaIdByCode(arr[0]);
            slbwhCode = arr[1];
        }

        string staID = "";//工位ID
        string slbwhCode = "";//合格坯仓库库位编码

        private Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        private Bll_TRC_COGDOWN_MAIN bll_TRC_COGDOWN_MAIN = new Bll_TRC_COGDOWN_MAIN();

        private void FrmRC_TBKPSJ3_Load(object sender, EventArgs e)
        {
            this.dt_Plan.DateTime = DateTime.Now.AddDays(-10);
            this.dt_PlanEnd.DateTime = DateTime.Now.AddDays(1);
            BindToSlabList();
        }


        /// <summary>
        /// 绑定已调拨钢坯数据
        /// </summary>
        public void BindToSlabList()
        {
            try
            {
                string sqlWhere = "";

                if (this.dt_Plan.DateTime != DateTime.MinValue)
                {
                    sqlWhere += " AND TCP.D_Q_DATE>to_date('" + dt_Plan.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
                    sqlWhere += " AND  TCP.D_Q_DATE<to_date('" + dt_PlanEnd.DateTime.ToString("yyyyMMdd") + "','yyyy-mm-dd') ";
                }
                DataTable dt = bll_TRC_COGDOWN_MAIN.GetCogDownFact(3, staID,sqlWhere).Tables[0];
                this.gc_TBKPSJ.DataSource = dt;
                this.gv_TBKPSJ.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gv_TBKPSJ);
            }
            catch
            {

            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            int compareDt = DateTime.Compare(this.dt_Plan.DateTime, this.dt_PlanEnd.DateTime);
            if (compareDt > 0)
            {
                MessageBox.Show("日期错误!");
                return;
            }
            BindToSlabList();
        }

        private void btn_out_toExcel1_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_TBKPSJ, "完工记录" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
