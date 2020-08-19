using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;
using Common;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_Allot_Line : Form
    {
        public FrmPO_Allot_Line()
        {
            InitializeComponent();
        }
        Bll_TB_PRO bll_TB_PRO = new Bll_TB_PRO();
        Bll_TPP_PRODUCTION_PLAN bll_TPP_PRODUCTION_PLAN = new Bll_TPP_PRODUCTION_PLAN();
        Bll_TPP_INITIALIZE_ITEM bll_TPP_INITIALIZE_ITEM = new Bll_TPP_INITIALIZE_ITEM();
        CommonSub commonSub = new CommonSub();
        private void FrmPO_Allot_Line_Load(object sender, EventArgs e) 
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            cbo_FA.EditValue = "";
            commonSub.ComboBoxEditBindQS(cbo_issue);
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            Query();
        }
        private void Query()
        {
            DataTable dt = null;
            dt = bll_TPP_PRODUCTION_PLAN.GetFADDList(cbo_FA.Text,"","","","0").Tables[0];
            this.gc_DPCDD.DataSource = dt;
            this.gv_DPCDD.OptionsView.ColumnAutoWidth = false;
            this.gv_DPCDD.OptionsSelection.MultiSelect = true;
            gv_DPCDD.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            DataTable dt2 = null;
            dt2 = bll_TPP_PRODUCTION_PLAN.GetFADDList(cbo_FA.EditValue.ToString(), "", "","","-1").Tables[0];
            this.gc_BPCDD.DataSource = dt2;
            this.gv_BPCDD.OptionsView.ColumnAutoWidth = false;
            this.gv_BPCDD.OptionsSelection.MultiSelect = true;
            gv_BPCDD.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_BPCDD.BestFitColumns();
        }

        private void cbo_FA_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = bll_TB_PRO.GetListByStatus(1, "ZG", "").Tables[0];
            if (dt.Rows.Count > 0)
            {
                string cid = dt.Rows[0]["C_ID"].ToString();
                commonSub.ImageComboBoxEditBindLGGW("", cbo_FA.EditValue.ToString(), cbo_CX);
            }
        }

        private void txt_issue_SelectedValueChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindFA(cbo_FA, cbo_issue.EditValue.ToString());
        }
    }
}
