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

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_WL : Form
    {
        public FrmPB_WL()
        {
            InitializeComponent();
        }

        private Bll_TB_MATRL_MAIN bllWL = new Bll_TB_MATRL_MAIN();
        private void FrmPB_WL_Load(object sender, EventArgs e)
        {


        }
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                if (string.IsNullOrEmpty(txt_mat_code.Text.Trim())
                 && string.IsNullOrEmpty(txt_Name.Text.Trim())
                 && string.IsNullOrEmpty(txt_GZ.Text.Trim())
                 && string.IsNullOrEmpty(txt_Spec.Text.Trim())
                 && string.IsNullOrEmpty(txt_Len.Text.Trim()))
                {
                    MessageBox.Show("请输入查询条件进行查询！");
                    return;
                }

                int C_MAT_TYPE = 0;
                if (this.rbtn_zl.SelectedIndex == 0)
                {
                    C_MAT_TYPE = 8;
                }
                else
                {
                    C_MAT_TYPE = 6;
                }
                DataTable dt = bllWL.GetListByWhere(txt_mat_code.Text.Trim(), txt_Name.Text.Trim(), txt_GZ.Text.Trim(), txt_Spec.Text.Trim(), txt_Len.Text.Trim(), C_MAT_TYPE).Tables[0];
                this.gc_wl.DataSource = dt;
                this.gv_wl.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_wl);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        ///// <summary>
        ///// 加载钢类
        ///// </summary>
        //public void BindGL()
        //{
        //    DataTable dt = bllWL.GetGl(this.rbtn_zl.SelectedIndex == 0?8:6).Tables[0];

        //    this.cbo_lb.Properties.Items.Clear();
        //    if (dt.Rows.Count>0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            this.cbo_lb.Properties.Items.Add(dt.Rows[i]["C_PROD_NAME"].ToString());
        //        }
        //    }
        //    this.cbo_lb.SelectedIndex = 0;
        //}
        ///// <summary>
        ///// 加载钢种
        ///// </summary>
        //public void BindGZ()
        //{
        //    DataTable dt = bllWL.GetGZ(this.rbtn_zl.SelectedIndex == 0 ? 8 : 6,this.cbo_lb.Text.Trim()).Tables[0];
        //    this.cbo_gz.Properties.Items.Clear();
        //    if (dt.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            this.cbo_gz.Properties.Items.Add(dt.Rows[i]["C_STL_GRD"].ToString());
        //        }
        //    }
        //    cbo_gz.SelectedIndex = 0;
        //} 


        private void btn_DCWL_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_wl);
        }
    }
}
