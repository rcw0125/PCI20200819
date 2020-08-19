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

namespace XGCAP.UI.P.PR
{
    public partial class FrmPR_TS_PLAN : Form
    {
        public FrmPR_TS_PLAN()
        {
            InitializeComponent();
        }
        private Bll_TPP_INITIALIZE_STA bll_TPP_INITIALIZE_STA = new Bll_TPP_INITIALIZE_STA();//方案初始化工序工位
        private Bll_TSP_PLAN_SMS bll_sms = new Bll_TSP_PLAN_SMS();
        private void FrmPR_TS_PLAN_Load(object sender, EventArgs e)
        {
            BindIcbo("", "ZL", icbo_zl);
        }

        /// <summary>
        /// 加载工位信息到ImageComboBoxEdit
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <param name="cbo">ImageComboBoxEdit</param>
        public void BindIcbo(string strIniID, string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetGXGWByIni(strIniID, strGX);
            if (dt.Rows.Count > 0)
            {
                //cbo.Properties.Items.Add("", "", -1);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_STA_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            if (this.dtp_form.Text.Trim()==""||this.dtp_end.Text.Trim()=="")
            {
                MessageBox.Show("查询日期不能为空！");
                this.dtp_form.Focus();
                return;
            }
          DataTable tsplan=  bll_sms.GetTSPlan(this.dtp_form.Text+" 00:00:01", this.dtp_end.Text.Trim()+" 23:59:59", icbo_zl.SelectedIndex>=0? icbo_zl.Properties.Items[this.icbo_zl.SelectedIndex].Value.ToString():"", this.chk_type.Checked?"Y":"N");
            this.gridControl1.DataSource = tsplan;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();


            DataTable tsplancf = bll_sms.GetTSPlanCF(this.dtp_form.Text + " 00:00:01", this.dtp_end.Text.Trim() + " 23:59:59", icbo_zl.SelectedIndex >= 0 ? icbo_zl.Properties.Items[this.icbo_zl.SelectedIndex].Value.ToString() : "");
            this.gridControl2.DataSource = tsplancf;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView2);
            this.gridView2.BestFitColumns();


        }
    }
}
