using Common;
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
namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APS_Select_WL : Form
    {
        public FrmPO_APS_Select_WL()
        {
            InitializeComponent();
        }
        public string strSTL = "";//钢种
        public string strSTD = "";//执行标准
        public string strGYLX = "";//工艺路线
        public string strWLMS = "";//物料描述
        public string strDM = "";//断面
        public string strCD = "";//长度
        public string strZYX1 = "";//自由项1
        public string strZYX2 = "";//自由项2
        public string str_ID = "";//物料主键
        Bll_TQB_STD_MAIN bll_stdmain = new Bll_TQB_STD_MAIN();
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bll_stdmain.GetList_QueryStdMatrl(txt_Std.Text.Trim(), txt_STL.Text.Trim()).Tables[0];
                this.gc_Matrl.DataSource = dt;
                gv_Matrl.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Matrl);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// 双击确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Matrl_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPO_APS_Select_WL_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }
        /// <summary>
        /// 回传信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Matrl_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Matrl.GetDataRow(gv_Matrl.FocusedRowHandle);
                if (dr == null) return; 
                strSTL = dr["C_STL_GRD"].ToString();
                strSTD = dr["C_STD_CODE"].ToString();
                strGYLX = dr["C_ROUTE_DESC"].ToString();
                strWLMS = dr["C_MAT_NAME"].ToString();
                strDM = dr["C_SLAB_SIZE"].ToString();
                strCD = dr["N_LTH"].ToString();
                strZYX1 = dr["C_ZYX1"].ToString();
                strZYX2 = dr["C_ZYX2"].ToString();
                str_ID = dr["C_ID"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
    }
}
