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
    public partial class FrmQC_SELECT_WL : Form
    {
        private Bll_TQB_GP_LCP_BASIS bllTqbGpLcpBasis = new Bll_TQB_GP_LCP_BASIS();
        private Bll_TB_MATRL_MAIN bll_matrl = new Bll_TB_MATRL_MAIN();
        public string mat_code = "";
        public string mat_name = "";
        public string std = "";
        public string stl_grd = "";
        public string lennew = "";
        private string str_Plan_Code = "";
        public string strZYX1 = "";
        public string strZYX2 = "";
        private string strType = "";
        private string strLEN = "";
        public FrmQC_SELECT_WL(string str, string strGP, string len)
        {
            InitializeComponent();
            strType = strGP;
            str_Plan_Code = str;
            strLEN = len;
        }
        private void FrmQC_SELECT_WL_Load(object sender, EventArgs e)
        {
            txt_Len.Text = strLEN;
            if (strType == "2")
            {
                //    labelControl8.Visible = false;
                //    txt_mat_code.Visible = false;
                labelControl4.Visible = false;
                txt_Len.Visible = false;
                btn_Query.Visible = false;
                NewMethod1();
            }
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
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NewMethod1()
        {
            WaitingFrom.ShowWait("");
            DataTable dt = bllTqbGpLcpBasis.Get_Item_List(str_Plan_Code, txt_GZ.Text.Trim(), txt_STD.Text.Trim(), txt_Spec.Text.Trim()).Tables[0];
            gc_Matrl.DataSource = dt;
            gv_Matrl.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Matrl);
            WaitingFrom.CloseWait();
        }
        private void NewMethod()
        {
            WaitingFrom.ShowWait("");
            gc_Matrl.DataSource = null;
            DataTable dt = new DataTable();
            if (txt_mat_code.Text.Trim() == "" && txt_GZ.Text.Trim() == "" && txt_STD.Text.Trim() == "" && txt_Spec.Text.Trim() == "")
            {
                MessageBox.Show("请输入物料编码或钢种、执行标准、规格！");
                return;
            }
            if (strType == "1")//钢坯=1
            { 
                dt = bll_matrl.GetGP_WL(txt_mat_code.Text.Trim(), txt_GZ.Text.Trim(), txt_STD.Text.Trim(), txt_Spec.Text.Trim(), txt_Len.Text.Trim(), "6").Tables[0];
            }
            if (strType == "2")//线材=2
            {
               // dt = bll_matrl.GetGP_WL(txt_mat_code.Text.Trim(), txt_GZ.Text.Trim(), txt_STD.Text.Trim(), txt_Spec.Text.Trim(), txt_Len.Text.Trim(), "8").Tables[0];
                NewMethod1();
            }

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
            if (strZYX1 == "" || strZYX2 == "")
            {
                MessageBox.Show("自由项为空不能改判！");
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
                strZYX1 = dr["自由项1"].ToString();
                strZYX2 = dr["自由项2"].ToString();
                lennew = dr["定尺"].ToString();
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
