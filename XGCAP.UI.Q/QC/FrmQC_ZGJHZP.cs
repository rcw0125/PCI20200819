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
    public partial class FrmQC_ZGJHZP : Form
    {
        private Bll_TRC_ROLL_MAIN bllTrcRollMain = new Bll_TRC_ROLL_MAIN();

        public FrmQC_ZGJHZP()
        {
            InitializeComponent();
        }

        private void FrmQC_ZGJHZP_Load(object sender, EventArgs e)
        {
            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            CommonSub.BindIcbo("", "ZX", icbo_ZX);
            icbo_ZX.SelectedIndex = 0;
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }

        /// <summary>
        /// 组批查询
        /// </summary>
        private void Query()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bllTrcRollMain.GetList(txt_BatchNo.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), icbo_ZX.EditValue.ToString()).Tables[0];

                this.gc_ZGZPSJ.DataSource = dt;
                this.gv_ZGZPSJ.OptionsView.ColumnAutoWidth = false;

                SetGridViewRowNum.SetRowNum(gv_ZGZPSJ);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_ZGZPSJ_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gv_ZGZPSJ.FocusedColumn.GetTextCaption() == "炉号")
                {
                    int handle = gv_ZGZPSJ.FocusedRowHandle;
                    if (handle >= 0)
                    {
                        string strBatch = gv_ZGZPSJ.GetRowCellValue(handle, "C_BATCH_NO").ToString();
                        string strStove = gv_ZGZPSJ.GetRowCellValue(handle, "C_STOVE").ToString();
                        string strStlGrd = gv_ZGZPSJ.GetRowCellValue(handle, "C_STL_GRD").ToString();
                        string strStdCode = gv_ZGZPSJ.GetRowCellValue(handle, "C_STD_CODE").ToString();

                        FrmQC_CFPD frm = new FrmQC_CFPD(strBatch, strStove, strStdCode, strStlGrd);
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
