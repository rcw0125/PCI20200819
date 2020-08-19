using BLL;
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

namespace XGCAP.UI.R.TM
{
    public partial class FrmFR_YWDTB : Form
    {
        public FrmFR_YWDTB()
        {
            InitializeComponent();
        }
        Bll_Interface_FR bll_Interface_FR = new Bll_Interface_FR();
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void FrmFR_YWDTB_Load(object sender, EventArgs e)
        {
            Query();
            YWQuery();
        }
        private void Query()
        {
            try
            {
                DataTable dt = null;
                dt = bll_Interface_FR.GetTMYWD(txt_YWDH.Text.Trim()).Tables[0];
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
            string message = bll_Interface_FR.TBYWD();
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
                string dh = gv_ZGSJ.GetRowCellValue(gv_ZGSJ.FocusedRowHandle, "ywdh").ToString();//获取当前选中行移位单号
                string id = gv_ZGSJ.GetRowCellValue(gv_ZGSJ.FocusedRowHandle, "pk_SeZJB_Shift_Record").ToString();//获取当前选中行id
                DataTable dt = null;
                dt = bll_Interface_FR.GetYWDXQ(dh,"2",id).Tables[0];
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
