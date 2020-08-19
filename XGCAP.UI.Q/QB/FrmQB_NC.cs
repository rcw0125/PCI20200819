using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MODEL;
using BLL;
using Common;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_NC : Form
    {
        private Bll_TS_SERVER_CONFIG bllConfig = new Bll_TS_SERVER_CONFIG();

        public FrmQB_NC()
        {
            InitializeComponent();
        }

        private void FrmQB_NC_Load(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void BindInfo()
        {
            try
            {
                DataTable dt = bllConfig.Get_List().Tables[0];

                gc_Info.DataSource = dt;

                SetGridViewRowNum.SetRowNum(gv_Info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Info.GetDataRow(gv_Info.FocusedRowHandle);
            if (dr != null)
            {
                if (DialogResult.Yes == MessageBox.Show("确认修改" + dr["C_USE"].ToString() + "的配置信息吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    FrmQB_NC_EDIT frm = new FrmQB_NC_EDIT(dr["C_ID"].ToString());

                    frm.ShowDialog();

                    BindInfo();
                }
            }
        }
    }
}
