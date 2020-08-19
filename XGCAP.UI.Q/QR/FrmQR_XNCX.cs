using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using BLL;
using MODEL;
using Common;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_XNCX : Form
    {
        private Bll_TQC_PHYSICS_RESULT bllTqcPhysicsResult = new Bll_TQC_PHYSICS_RESULT();
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        private Bll_TQC_PHYSICS_RESULT_MAIN bllTqcPhyResultMain = new Bll_TQC_PHYSICS_RESULT_MAIN();
        private Bll_TQB_PHYSICS_QUALITATIVE bllTqbPhysicsQualitative = new Bll_TQB_PHYSICS_QUALITATIVE();
        private Bll_TQB_PHYSICS_EQUIPMENT bll_TQB_PHYSICS_EQUIPMENT = new Bll_TQB_PHYSICS_EQUIPMENT();//实验室设备
        private Bll_TQB_PHYSICS_GROUP blltqbPhysicsGroup = new Bll_TQB_PHYSICS_GROUP();//物理检验项目分组维护
        private Bll_TQB_DESIGN_ITEM bllTqbDesignItem = new Bll_TQB_DESIGN_ITEM();
        Bll_TQB_PHYSICS_GROUP bll_group = new Bll_TQB_PHYSICS_GROUP();

        private List<Mod_TQB_DESIGN_ITEM> lstDesignItem;

        private string strMenuName;


        public FrmQR_XNCX()
        {
            InitializeComponent();
        }

        private void FrmQR_XNCX_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                dt_Start_Result.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dt_End_Result.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

                BindInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定性能名称
        /// </summary>
        private void BindInfo()
        {
            DataSet ds = bll_group.GetList("");
            imgcbo_Name.Properties.Items.Clear();
            foreach (DataRow item in ds.Tables[0].Rows)//性能名称下拉框绑定
            {
                imgcbo_Name.Properties.Items.Add(item["C_NAME"].ToString(), item["C_CODE"], -1);
            }
        }

        /// <summary>
        /// 查询录入结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Result_Click(object sender, EventArgs e)
        {
            try
            {
                BindResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定性能结果信息
        /// </summary>
        private void BindResult()
        {
            if (string.IsNullOrEmpty(imgcbo_Name.Text.Trim()))
            {
                MessageBox.Show("请选择需要查询的性能名称！");
                return;
            }

            gc_Result.DataSource = null;
            gv_Result.Columns.Clear();

            DataTable dt = bllTqcPhysicsResult.Get_Result_List(imgcbo_Name.EditValue.ToString(), txt_Batch_Result.Text.Trim(), dt_Start_Result.Text.Trim(), dt_End_Result.Text.Trim(), "1",txt_STLGRD.Text.Trim()).Tables["ds"];

            gc_Result.DataSource = dt;
            gv_Result.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Result);

            if (dt != null && dt.Rows.Count > 0)
            {
                gv_Result.Columns[9].Caption = "录入人";
                gv_Result.Columns[0].Visible = false;
            }

            //冻结有焦点的列
            gv_Result.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_Result.Columns[2].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_Result.Columns[3].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_Result.Columns[4].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_Result, imgcbo_Name.Text + "-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
