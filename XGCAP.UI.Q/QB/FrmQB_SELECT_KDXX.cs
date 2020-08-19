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

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_SELECT_KDXX : Form
    {
        private Bll_TS_CUSTFILE bllCUST = new Bll_TS_CUSTFILE();

       
        public string str_NO = "";
        public string str_NAME = "";

        public FrmQB_SELECT_KDXX()
        {
            InitializeComponent();
        }

        private void FrmQB_SELECT_ZXBZ_Load(object sender, EventArgs e)
        {
           // BindList();

        }
        public void str_GRD_visible()
        {
            gridColumn3.Visible = false;             
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindList();
        }

        private void BindList()
        {
            try
            {
                if (txt_cust_no.Text.Trim()=="" && txt_cust_name.Text.Trim()=="")
                {
                    MessageBox.Show("请输入客户编码或客户名称再进行查询！");
                    return;
                }
                WaitingFrom.ShowWait("");
                DataTable dt = bllCUST.GetCustomer(this.txt_cust_no.Text.Trim(),this.txt_cust_name.Text.Trim(),"").Tables[0];

                gc_StdMain.DataSource = dt;
                gv_StdMain.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_StdMain);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }       

        private void gv_StdMain_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
                if (dr == null) return;
               
                str_NO = dr["C_NO"].ToString();
                str_NAME = dr["C_NAME"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 双击执行标准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_StdMain_DoubleClick(object sender, EventArgs e)
        {
            btn_OK_Click(null,null);
        }
    }
}
