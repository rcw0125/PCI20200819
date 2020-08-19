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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_TSXX : Form
    {
        public FrmQC_TSXX()
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
        private void FrmQC_TSXX_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            DataSet dt = bllSpecific.GetList(" nvl(C_CONTENT,' ')<>'待包装' AND nvl(C_CONTENT,' ')<>'待修料' ");
            DataSet dt_All = bllSpecific.GetList("");
            image_TSXX.Properties.Items.Clear();
            foreach (DataRow item in dt.Tables[0].Rows)//判定等级下拉框
            {
                image_TSXX.Properties.Items.Add(item["C_CONTENT"].ToString(), item["C_CONTENT"], -1);
            }
            image_TSXX.SelectedIndex = 0;

            img_Tsxx_Query.Properties.Items.Clear();
            img_Tsxx_Query.Properties.Items.Add("全部", "全部", -1);
            foreach (DataRow item in dt_All.Tables[0].Rows)
            {
                img_Tsxx_Query.Properties.Items.Add(item["C_CONTENT"].ToString(), item["C_CONTENT"], -1);
            }
            img_Tsxx_Query.SelectedIndex = 0;

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

                DataTable dt = bll_roll_product.GetList_TSXX(txt_BatchNo.Text.Trim(),dt_Start.Text.Trim(),dt_End.Text.Trim(),img_Tsxx_Query.EditValue.ToString(),"").Tables[0];

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
             
            if (image_TSXX.EditValue == null)
            {
                MessageBox.Show("特殊信息不能为空！");
                return;
            }
            if (DialogResult.OK != MessageBox.Show("是否确认保存已选中的数据？", "提示", MessageBoxButtons.OKCancel))
            {
                return;
            }

            DataTable dt = ((DataView)gv_SJXX.DataSource).ToTable();

            string result = bll_roll_product.Send_PcInfo(dt, rownumber, image_TSXX.Text,"3");

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
        /// <summary>
        /// 取消特殊信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QX_Click(object sender, EventArgs e)
        {

            int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length == 0)
            {
                MessageBox.Show("请选择需要取消的信息！");
                return;
            }

            DataRow row = gv_SJXX.GetDataRow(rownumber[0]);
            if (image_TSXX.EditValue == null)
            {
                MessageBox.Show("特殊信息不能为空！");
                return;
            }
            if (DialogResult.OK != MessageBox.Show("是否确认取消已选中的数据？", "提示", MessageBoxButtons.OKCancel))
            {
                return;
            }

            DataTable dt = ((DataView)gv_SJXX.DataSource).ToTable();

            string result = bll_roll_product.Send_PcInfo(dt, rownumber, image_TSXX.Text, "0");

            if (result == "1")
            {
                MessageBox.Show("取消成功！");
                BindInfo();
            }
            else
            {
                MessageBox.Show(result);
            }
        }
    }
}
