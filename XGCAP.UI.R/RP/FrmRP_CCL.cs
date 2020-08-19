using BLL;
using Common;
using MODEL;
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
    public partial class FrmRP_CCL : Form
    {
        public FrmRP_CCL()
        {
            InitializeComponent();
        }

        Bll_TB_CONFIG_PERCENTAGE bll_TB_CONFIG_PERCENTAGE = new Bll_TB_CONFIG_PERCENTAGE();

        private void FrmRP_CCL_Load(object sender, EventArgs e)
        {
            BindCCL();
        }

        public void BindCCL()
        {
            DataTable dt = bll_TB_CONFIG_PERCENTAGE.GetList("").Tables[0];
            gc_ZGSJ.DataSource = dt;
            this.gv_ZGSJ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_ZGSJ);
        }

        private void gv_ZGSJ_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "N_TYPE")
            {
                switch (e.DisplayText)
                {
                    case "1":
                        e.DisplayText = "品种";
                        break;
                    case "2":
                        e.DisplayText = "品种加类别";
                        break;
                    case "3":
                        e.DisplayText = "品种加类别+其他类别";
                        break;
                }
            }
        }

        private void btn_TB_Click(object sender, EventArgs e)
        {
            int selectedPlanHandle = this.gv_ZGSJ.FocusedRowHandle;//获取计划焦点行索引
            string id = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点品种
            Mod_TB_CONFIG_PERCENTAGE model = new Mod_TB_CONFIG_PERCENTAGE();
            model.C_ID = id;
            model.C_PROD_KIND = txt_Kind.Text;
            model.C_PROD_NAME = txt_Name.Text;
            model.C_PERCENTAGE = decimal.Parse(txt_Percentage.Text);
            model.C_CONDITION = txt_Condition.Text;
            model.C_ELSECON = txt_ElseCon.Text;
            model.C_ELSETYPE = txt_ElseType.Text;
            if (bll_TB_CONFIG_PERCENTAGE.Update(model))
            {
                MessageBox.Show("操作成功！");
                BindCCL();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void gv_ZGSJ_Click(object sender, EventArgs e)
        {
            int selectedPlanHandle = this.gv_ZGSJ.FocusedRowHandle;//获取计划焦点行索引
            txt_Kind.Text = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "C_PROD_KIND").ToString();//获取焦点品种
            txt_Name.Text = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "C_PROD_NAME").ToString();//获取焦点类别
            txt_Percentage.Text = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "C_PERCENTAGE").ToString();//获取焦点百分比
            txt_Condition.Text = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "C_CONDITION").ToString();//获取焦点条件
            txt_Condition2.Text = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "C_CONDITION2").ToString();//获取焦点条件
            txt_ElseCon.Text = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "C_ELSECON").ToString();//获取焦点其他条件
            txt_ElseType.Text = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "C_ELSETYPE").ToString();//获取焦点其他类别
        }
    }
}
