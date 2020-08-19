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

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_XCZHPD_CX : Form
    {
        private Bll_TQC_COMPRE_ITEM_RESULT bllCompre = new Bll_TQC_COMPRE_ITEM_RESULT();
        private Bll_TRC_ROLL_PRODCUT bllRollProduct = new Bll_TRC_ROLL_PRODCUT();
        private Bll_TQB_CHECKSTATE bll_checkstate = new Bll_TQB_CHECKSTATE();
        private Bll_TQC_COMPRE_ROLL bllTqcCompreRoll = new Bll_TQC_COMPRE_ROLL();

        private string strMenuName;

        public FrmQR_XCZHPD_CX()
        {
            InitializeComponent();
        }

        private void FrmQR_XCZHPD_CX_Load(object sender, EventArgs e)
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
                BindCompreList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定综合判定线材信息
        /// </summary>
        public void BindCompreList()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Compre.DataSource = null;

                DataTable dt = bllTqcCompreRoll.Get_Compre_List(txt_Batch_Min.Text.Trim(), txt_Batch_Max.Text.Trim(), txt_Stove.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), icbo_state.EditValue.ToString(), icbo_Time.EditValue.ToString(), txt_Stl_Grd.Text.Trim(), txt_Std_Code.Text.Trim()).Tables[0];

                this.gc_Compre.DataSource = dt;

                gv_Compre.BestFitColumns();

                SetGridViewRowNum.SetRowNum(gv_Compre);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                DataTable dt = bllCompre.GetListCF(dr["炉号"].ToString(), dr["钢种"].ToString(), "", dr["执行标准"].ToString(), dr["批号"].ToString()).Tables[0];

                DataTable dtXN = bllCompre.GetListXN(dr["批号"].ToString(), dr["钢种"].ToString(), dr["规格"].ToString(), dr["执行标准"].ToString()).Tables[0];

                dt.Merge(dtXN);

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
        DevExpress.Utils.AppearanceDefault appNotPass3 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.LightGreen, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);

        private void gv_Item_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                //T.C_IS_DECIDE,T.C_IS_SHOW c_value
                string strResult = gv_Item.GetRowCellValue(e.RowHandle, "C_RESULT").ToString();
                string strPD = gv_Item.GetRowCellValue(e.RowHandle, "C_IS_DECIDE").ToString();
                string strPrint = gv_Item.GetRowCellValue(e.RowHandle, "C_IS_SHOW").ToString();
                string strValue = gv_Item.GetRowCellValue(e.RowHandle, "C_VALUE").ToString();
                if (strResult == "不合格")
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass1);
                }
                else if (strResult == "数据有误")
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                }
                else if (string.IsNullOrEmpty(strResult))
                {
                    if (strPD == "否")
                    {
                        DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass3);

                        if (strPrint == "是" && string.IsNullOrEmpty(strValue))
                        {
                            DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                        }
                    }
                    else
                    {
                        DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                    }
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
