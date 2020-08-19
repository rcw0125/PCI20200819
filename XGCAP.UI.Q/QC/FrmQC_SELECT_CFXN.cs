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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_SELECT_CFXN : Form
    {
        private Bll_TQB_CHECKTYPE bllCheckType = new Bll_TQB_CHECKTYPE();
        private Bll_TQB_CHARACTER bllCharacter = new Bll_TQB_CHARACTER();

        public string str_CHARACTER_ID = "";
        public string str_ITEM_NAME = "";

        public FrmQC_SELECT_CFXN()
        {
            InitializeComponent();
        }

        private void FrmQC_SELECT_CFXN_Load(object sender, EventArgs e)
        {
            DataSet dt = bllCheckType.GetList("");
            imgcbo_Type.Properties.Items.Add("全部", "全部", -1);
            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imgcbo_Type.Properties.Items.Add(item["C_TYPE_NAME"].ToString(), item["C_ID"], -1);
            }

            imgcbo_Type.SelectedIndex = 0;
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
                WaitingFrom.ShowWait("");

                string type = imgcbo_Type.EditValue?.ToString();
                DataTable dt = bllCharacter.GetList(txt_name.Text, type).Tables[0];

                this.gc_CFXN.DataSource = dt;
                gv_CFXN.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_CFXN);

                WaitingFrom.CloseWait();
            }
            catch
            {
                throw;
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
                DataRow dr = gv_CFXN.GetDataRow(gv_CFXN.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择需要添加的项目！");
                    return;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
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
                DataRow dr = gv_CFXN.GetDataRow(gv_CFXN.FocusedRowHandle);
                if (dr == null) return;
                str_CHARACTER_ID = dr["C_ID"].ToString();
                str_ITEM_NAME = dr["C_NAME"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
