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
    public partial class FrmFR_QTCKDTB : Form
    {
        public FrmFR_QTCKDTB()
        {
            InitializeComponent();
        }
        Bll_Interface_FR bll_Interface_FR = new Bll_Interface_FR();
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
            YWQuery();
        }

        private void FrmFR_QTCKDTB_Load(object sender, EventArgs e)
        {
            Query();
            YWQuery();
        }
        private void Query()
        {
            try
            {
                DataTable dt = null;
                dt = bll_Interface_FR.GetTMZJB(txt_DH.Text.Trim()).Tables[0];
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
        private void YWQuery()
        {
            try
            {
                if (gv_ZGSJ.FocusedRowHandle<0)
                {
                    return;
                }
                string dh = gv_ZGSJ.GetRowCellValue(gv_ZGSJ.FocusedRowHandle, "ckdh").ToString();//获取当前选中行数量
                DataTable dt = null;
                dt = bll_Interface_FR.GetYWDXQ(dh,"3","").Tables[0];
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
        private void btn_QTCKTB_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            string message = bll_Interface_FR.QTCKDTB(Application.StartupPath);
            if (message == "1")
            {
                MessageBox.Show("同步完成！");
            }
            else
            {
                MessageBox.Show("同步失败！"+message);
            }
            Query();
            YWQuery();
            WaitingFrom.CloseWait();
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
