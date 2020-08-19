using Common;
using IDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
namespace XGCAP.UI.R.TM
{
    public partial class FrmFR_XCFYDTB : Form
    {
        public FrmFR_XCFYDTB()
        {
            InitializeComponent();
        }
        Bll_Interface_FR bll_Interface_FR = new Bll_Interface_FR();
        private void FrmFR_XCFYDTB_Load(object sender, EventArgs e)
        {
            Query();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }
        private void Query()
        {
            try
            {
                DataTable dt = null;
                dt = bll_Interface_FR.GetTMFYD(txt_DH.Text.Trim()).Tables[0];
                this.gc_ZGSJ.DataSource = dt;
                this.gv_ZGSJ.OptionsView.ColumnAutoWidth = false;
                this.gv_ZGSJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZGSJ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_TB_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            string message = bll_Interface_FR.TBFYD(Application.StartupPath);
            if (message == "1")
            {
                MessageBox.Show("同步完成！");
            }
            else
            {
                MessageBox.Show("同步失败！" + message);
            }
            Query();
            YWQuery();
            WaitingFrom.CloseWait();
        }
        private void YWQuery()
        {
            try
            {
                if (gv_ZGSJ.FocusedRowHandle < 0)
                {
                    return;
                }
                string dh = gv_ZGSJ.GetRowCellValue(gv_ZGSJ.FocusedRowHandle, "fydh").ToString();//获取当前选中行发运单号
                string id = gv_ZGSJ.GetRowCellValue(gv_ZGSJ.FocusedRowHandle, "pk_SeZJB_FYD_finished").ToString();//获取当前选中行主键
                DataTable dt = null;
                dt = bll_Interface_FR.GetYWDXQ(dh, "2", id).Tables[0];
                this.gc_YWD.DataSource = dt;
                this.gv_YWD.OptionsView.ColumnAutoWidth = false;
                this.gv_YWD.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZGSJ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gv_ZGSJ_Click(object sender, EventArgs e)
        {
            YWQuery();
        }

        private void gv_ZGSJ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            YWQuery();
        }
    }
}
