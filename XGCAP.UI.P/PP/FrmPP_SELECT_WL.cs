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

namespace XGCAP.UI.P.PP
{
    public partial class FrmPP_SELECT_WL : Form
    {
        public FrmPP_SELECT_WL()
        {
            InitializeComponent();
        }
        public string mat_code = "";//物料编码
        public string mat_name = "";//物料名称
        public string str_GZ = "";//钢种
        public string str_BZ = "";//标准
        public string str_SlabSize = "";//断面
        public string str_Length = "";//定尺
        public string str_NC_PK = "";//物料NC主键
        Bll_TB_MATRL_MAIN bll = new Bll_TB_MATRL_MAIN();
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

                DataTable dt = bll.Get_Slab_List(txt_Mat_Code.Text, txt_Mat_Name.Text, txt_GRD.Text, txt_Slab_Size.Text).Tables[0];
                gc_Matrl.DataSource = dt;
                gv_Matrl.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Matrl);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        /// 回传信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Matrl_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_Matrl.GetDataRow(e.FocusedRowHandle);
                if (dr == null) return;
                mat_code = dr["物料编码"].ToString();
                mat_name = dr["物料名称"].ToString();
                str_GZ= dr["钢种"].ToString();
                str_BZ = dr["执行标准"].ToString();
                str_SlabSize = dr["断面"].ToString();
                str_Length = dr["定尺"].ToString();
                str_NC_PK = dr["C_PK_INVBASDOC"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 双击获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Matrl_DoubleClick(object sender, EventArgs e)
        {
            btn_OK_Click(null, null);
        }

        private void FrmPP_SELECT_WL_Load(object sender, EventArgs e)
        {

        }
    }
}
