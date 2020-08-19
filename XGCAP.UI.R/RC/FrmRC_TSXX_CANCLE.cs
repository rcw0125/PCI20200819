using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using Common;

namespace XGCAP.UI.R.RC
{
    public partial class FrmRC_TSXX_CANCLE : Form
    {
        public FrmRC_TSXX_CANCLE()
        {
            InitializeComponent();
        }
        Bll_TQC_SPECIFIC_CONTENT bllSpecific = new Bll_TQC_SPECIFIC_CONTENT();
        Bll_TRC_ROLL_PRODCUT bll_roll_product = new Bll_TRC_ROLL_PRODCUT();
        Bll_TQC_ROLL_COMMUTE bllRollCommute = new Bll_TQC_ROLL_COMMUTE();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRC_TSXX_CANCLE_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }
        /// <summary>
        /// 查询线材实绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void BindInfo()
        {
            try
            {
                //if (txt_BatchNo.Text.Trim() == "")
                //{
                //    MessageBox.Show("请输入批号再查询！");
                //    return;
                //}

                WaitingFrom.ShowWait("");

                DataTable dt = bll_roll_product.GetList_TSXX(txt_BatchNo.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), "全部","").Tables[0];

                gc_SJXX.DataSource = dt;
                gv_SJXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SJXX);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length == 0)
            {
                MessageBox.Show("请选择需要保存的信息！");
                return;
            }

            DataRow row = gv_SJXX.GetDataRow(rownumber[0]);
           
            if (DialogResult.OK != MessageBox.Show("是否确认保存已选中的数据？", "提示", MessageBoxButtons.OKCancel))
            {
                return;
            }

            DataTable dt = ((DataView)gv_SJXX.DataSource).ToTable();

            string result = bll_roll_product.Send_PcInfo(dt, rownumber,"待包装", "0");

            if (result == "1")
            {
                MessageBox.Show("保存成功！");
                BindInfo();
            }
            else
            {
                MessageBox.Show(result);
            }

        }
    }
}
