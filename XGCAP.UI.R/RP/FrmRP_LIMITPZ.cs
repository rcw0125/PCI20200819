using BLL.B;
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
    public partial class FrmRP_LIMITPZ : Form
    {
        public FrmRP_LIMITPZ()
        {
            InitializeComponent();
        }

        Bll_TB_CONFIG_LIMIT bll_TB_CONFIG_LIMIT = new Bll_TB_CONFIG_LIMIT();

        private void btn_Query_Click(object sender, EventArgs e)
        {
            DataTable dt = bll_TB_CONFIG_LIMIT.GetList("").Tables[0];
            this.gc_ZGSJ.DataSource = dt;
            this.gv_ZGSJ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_ZGSJ);


            DataTable dt2 = bll_TB_CONFIG_LIMIT.GetCZJL();
            this.gridControl1.DataSource = dt2;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gridView1);
        }

        private void btn_TB_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认保存吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_ZGSJ.FocusedRowHandle;//获取计划焦点行索引
            string id = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            string min = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "N_SECTION_MIN")==null?"": this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "N_SECTION_MIN").ToString();//获取焦点区域量小
            string max = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "N_SECTION_MAX")==null?"" : this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "N_SECTION_MAX").ToString();//获取焦点区域量大
            decimal num = decimal.Parse(txt_num.Text);
            string userID = RV.UI.UserInfo.UserID;
            if (bll_TB_CONFIG_LIMIT.UpdateNum(id, num,userID))
            {
                try
                {
                    bll_TB_CONFIG_LIMIT.InsertLog(num, min, max, userID);
                }
                catch { }
                MessageBox.Show("操作成功");
                btn_Query_Click(null, null);
            }
            else
            {
                MessageBox.Show("操作成功");
            }
        }

        private void gv_ZGSJ_Click(object sender, EventArgs e)
        {
            int selectedPlanHandle = this.gv_ZGSJ.FocusedRowHandle;//获取计划焦点行索引
            string num = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "N_NUM").ToString();//获取焦点限制量
            txt_num.Text = num;
        }

        private void gv_ZGSJ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int selectedPlanHandle = this.gv_ZGSJ.FocusedRowHandle;//获取计划焦点行索引
            string num = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "N_NUM").ToString();//获取焦点限制量
            txt_num.Text = num;
        }
    }
}
