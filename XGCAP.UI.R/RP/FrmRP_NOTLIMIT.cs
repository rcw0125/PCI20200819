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
using MODEL;

namespace XGCAP.UI.R.RP
{
    public partial class FrmRP_NOTLIMIT : Form
    {
        public FrmRP_NOTLIMIT()
        {
            InitializeComponent();
        }

        Bll_TB_NOT_LIMIT bll_TB_NOT_LIMIT = new Bll_TB_NOT_LIMIT();

        private void FrmRP_NOTLIMIT_Load(object sender, EventArgs e)
        {
            BindNotLimit();
        }

        public void BindNotLimit()
        {
            DataTable dt = bll_TB_NOT_LIMIT.GetList("").Tables[0];
            gc_ZGSJ.DataSource = dt;
            this.gv_ZGSJ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_ZGSJ);
        }

        private void gv_ZGSJ_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "C_TYPE")
            {
                switch (e.DisplayText)
                {
                    case "1":
                        e.DisplayText = "钢种";
                        break;
                    case "2":
                        e.DisplayText = "物料编码";
                        break;
                    case "3":
                        e.DisplayText = "不锈钢";
                        break;
                }
            }
        }

        private void btn_TB_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string type = image_Type.EditValue.ToString();
            if (bll_TB_NOT_LIMIT.GetRecord(name, decimal.Parse(type)) == 0)
            {
                Mod_TB_NOT_LIMIT m = new Mod_TB_NOT_LIMIT();
                m.C_NAME = name;
                m.C_TYPE = decimal.Parse(type);
                m.C_EMP_ID = RV.UI.UserInfo.userID;
                bll_TB_NOT_LIMIT.Add(m);
                MessageBox.Show("操作成功");
                BindNotLimit();
            }
            else
            {
                MessageBox.Show("数据重复");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int selectedPlanHandle = this.gv_ZGSJ.FocusedRowHandle;//获取计划焦点行索引
            string id = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            if (selectedPlanHandle < 0)
            {
                MessageBox.Show("记录为空!");
                return;
            }

            if (bll_TB_NOT_LIMIT.Del(id))
            {
                MessageBox.Show("操作成功");
                BindNotLimit();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

    }
}
