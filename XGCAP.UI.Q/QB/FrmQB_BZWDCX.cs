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
using MODEL;

namespace XGCAP.UI.Q.QB
{
    /// <summary>
    /// 2018-04-25 zmc
    /// </summary>
    public partial class FrmQB_BZWDCX : Form
    {
        Bll_TQB_STD_FILE bll = new Bll_TQB_STD_FILE();

        public FrmQB_BZWDCX()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                ItemButtonEdit_Preview.ButtonClick += ItemButtonEdit_Preview_ButtonClick;

                string queryName = txt_Name.Text;
                DataTable dt = new DataTable();
                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    dt = bll.GetList("").Tables[0];
                }
                else
                {
                    dt = bll.GetList("C_FILE_NAME like '%" + queryName + "%'").Tables[0];
                }
                this.gc_StdFileb.DataSource = dt;
                gv_StdFileb.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_StdFileb);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmQB_BZWDCX_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }

        private void ItemButtonEdit_Preview_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Bll_TS_SERVER_CONFIG bllConfig = new Bll_TS_SERVER_CONFIG();

            DataRow dr = gv_StdFileb.GetDataRow(gv_StdFileb.FocusedRowHandle);

            if (dr != null)
            {
                Mod_TQB_STD_FILE model = bll.GetModel(dr["C_ID"].ToString());
                if (model != null)
                {
                    DataTable dt = bllConfig.GetList(" c_no='N03' ").Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        string strPath = dt.Rows[0]["C_FILE"].ToString() + "\\" + model.C_STD_FILE_CODE + ".pdf";
                        System.Diagnostics.Process.Start(dt.Rows[0]["C_URL"].ToString() + "/index.aspx?inFilePath=" + strPath);
                    }
                }
            }
        }
    }
}
