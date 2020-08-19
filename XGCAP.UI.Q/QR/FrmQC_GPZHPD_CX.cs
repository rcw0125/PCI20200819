using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;
using MODEL;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_GPZHPD_CX : Form
    {
        private Bll_TSC_SLAB_MAIN bllSlabMain = new Bll_TSC_SLAB_MAIN();
        private Bll_TQC_COMPRE_ITEM_RESULT bllCompre = new Bll_TQC_COMPRE_ITEM_RESULT();
        private Bll_TQB_CHECKSTATE bll_checkstate = new Bll_TQB_CHECKSTATE();
        private Bll_TQC_COMPRE_SLAB bllTqcCompreSlab = new Bll_TQC_COMPRE_SLAB();

        private string strMenuName;

        private int rowIndex = 0;

        public FrmQR_GPZHPD_CX()
        {
            InitializeComponent();
        }

        private void FrmQR_GPZHPD_CX_Load(object sender, EventArgs e)
        {
            // UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strMenuName = RV.UI.UserInfo.menuName;

            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
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
                rowIndex = 0;
                BindCompreList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 绑定综合判定钢坯信息
        /// </summary>
        public void BindCompreList()
        {
            WaitingFrom.ShowWait("");

            this.gc_Compre.DataSource = null;

            DataTable dt = bllTqcCompreSlab.GetList_CX(txt_Stove_Min.Text.Trim(), txt_Stove_Max.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), icbo_state.EditValue.ToString(), txt_Stl_Grd.Text.Trim(), txt_Std_Code.Text.Trim()).Tables[0];

            this.gc_Compre.DataSource = dt;

            gv_Compre.BestFitColumns();

            SetGridViewRowNum.SetRowNum(gv_Compre);

            gv_Compre.FocusedRowHandle = rowIndex;

            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 综判信息选择变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Compre_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = this.gv_Compre.GetDataRow(this.gv_Compre.FocusedRowHandle);
                if (dr == null) return;

                DataTable dt = bllCompre.GetListCF(dr["炉号"].ToString(), dr["钢种"].ToString(), dr["断面"].ToString(), dr["执行标准"].ToString()).Tables[0];

                gc_Item.DataSource = dt;
                gv_Item.BestFitColumns();

                SetGridViewRowNum.SetRowNum(gv_Item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        DevExpress.Utils.AppearanceDefault appNotPass1 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Red, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
        DevExpress.Utils.AppearanceDefault appNotPass2 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Yellow, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);

        private void gv_Item_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                string strResult = gv_Item.GetRowCellValue(e.RowHandle, "C_RESULT").ToString();
                if (strResult == "不合格")
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass1);
                }
                else if (string.IsNullOrEmpty(strResult))
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                }
            }
            catch
            {

            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_Compre, "线材综合判定查询" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
