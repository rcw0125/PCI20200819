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
    public partial class FrmRP_AutoSyncUser : Form
    {
        public FrmRP_AutoSyncUser()
        {
            InitializeComponent();
        }

        Bll_TB_AUTO_SYNC_USER bll_TB_AUTO_SYNC_USER = new Bll_TB_AUTO_SYNC_USER();

        private void FrmRP_AutoSyncUser_Load(object sender, EventArgs e)
        {
            DataTable dt = bll_TB_AUTO_SYNC_USER.GetList("").Tables[0];
            this.gc_ZGSJ.DataSource = dt;
            this.gv_ZGSJ.OptionsView.ColumnAutoWidth = false;
            SetGridViewRowNum.SetRowNum(gv_ZGSJ);
        }

        private void btn_TB_Click(object sender, EventArgs e)
        {
            int selectedPlanHandle = this.gv_ZGSJ.FocusedRowHandle;//获取计划焦点行索引
            string id = this.gv_ZGSJ.GetRowCellValue(selectedPlanHandle, "C_ID").ToString();//获取焦点主键
            if (bll_TB_AUTO_SYNC_USER.UpdateUser(id, txt_num.Text.Trim()))
            {
                MessageBox.Show("操作成功");
                DataTable dt = bll_TB_AUTO_SYNC_USER.GetList("").Tables[0];
                this.gc_ZGSJ.DataSource = dt;
                this.gv_ZGSJ.OptionsView.ColumnAutoWidth = false;
                SetGridViewRowNum.SetRowNum(gv_ZGSJ);
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
    }
}
