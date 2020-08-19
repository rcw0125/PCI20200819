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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_SELECT_LLGPWL : Form
    {
        private Bll_TQB_GP_LCP_BASIS bllTqbGpLcpBasis = new Bll_TQB_GP_LCP_BASIS();
        private Bll_TB_MATRL_MAIN bll_matrl = new Bll_TB_MATRL_MAIN();
        public string mat_code = "";
        public string mat_name = "";
        public string std = "";
        public string stl_grd = "";
        public string lennew = ""; 
        public string spec = "";
        public string zyx1 = "";
        public string zyx2 = "";

        public FrmQC_SELECT_LLGPWL()
        {
            InitializeComponent();
        }
        private void FrmQC_SELECT_WL_Load(object sender, EventArgs e)
        {
             
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
                NewMethod1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NewMethod1()
        {
            WaitingFrom.ShowWait("");
            DataTable dt = bllTqbGpLcpBasis.Get_Item_List_WLGP(txt_mat_code.Text.Trim(), txt_GZ.Text.Trim(), txt_STD.Text.Trim()).Tables[0];
            gc_Matrl.DataSource = dt;
            gv_Matrl.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Matrl);
            WaitingFrom.CloseWait();
        } 
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (zyx1 == "" || zyx2 == "")
            {
                MessageBox.Show("自由项为空不能添加！");
                return;
            }
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
                std = dr["执行标准"].ToString();
                stl_grd = dr["钢种"].ToString(); 
                lennew = dr["定尺"].ToString();
                spec = dr["规格"].ToString();
                zyx1 = dr["自由项1"].ToString();
                zyx2 = dr["自由项2"].ToString();
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

    }
}
