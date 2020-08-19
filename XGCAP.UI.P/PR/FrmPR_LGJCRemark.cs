using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;

namespace XGCAP.UI.P.PR
{
    public partial class FrmPR_LGJCRemark : Form
    {
        public FrmPR_LGJCRemark()
        {
            InitializeComponent();
        }
        private Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();
        private void FrmPR_LGJCRemark_Load(object sender, EventArgs e)
        {
            CommonSub.BindIcbo("", "CC", icbo_lz3);

            dt_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            this.icbo_lz3.SelectedIndex = 0;
        }

        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (this.rbtn_status.SelectedIndex==0)
            {
                dt = bll_cast_plan.GetTZPlan(this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString(),this.dt_Start.Text,this.dt_End.Text);
            }
            else
            {
                dt = bll_cast_plan.GetZZPlan(this.icbo_lz3.Properties.Items[this.icbo_lz3.SelectedIndex].Value.ToString(), this.dt_Start.Text, this.dt_End.Text);
            }
           
            this.gc_Lgfx.DataSource = dt; //gridView1
            if (this.rbtn_status.SelectedIndex == 0)
            {
                gc_Lgfx.MainView = gv_Lgfx;
                this.gv_Lgfx.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gv_Lgfx);
                this.gv_Lgfx.BestFitColumns();
            }
            else
            {
                gc_Lgfx.MainView = gridView1;
                this.gridView1.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gridView1);
                this.gridView1.BestFitColumns();
            }
            
        }
    }
}
