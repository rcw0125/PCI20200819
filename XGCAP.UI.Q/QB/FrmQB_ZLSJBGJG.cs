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

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_ZLSJBGJG : Form
    {
        private Bll_TQB_DESIGN_ORDER bllDesignOrder = new Bll_TQB_DESIGN_ORDER();
        private Bll_TQD_DESIGN bllDesign = new Bll_TQD_DESIGN();

        public FrmQB_ZLSJBGJG()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_RollMain = new Bll_TRC_ROLL_PRODCUT();
        Bll_TSC_SLAB_MAIN bll_slab = new Bll_TSC_SLAB_MAIN();
        Bll_TQB_CHARACTER bll_CharaCter = new Bll_TQB_CHARACTER();
        Bll_TQB_DESIGN_ITEM bll_Design_Item = new Bll_TQB_DESIGN_ITEM();
        Bll_TQB_DESIGN_ITEM_LOG bll_DescignLog = new Bll_TQB_DESIGN_ITEM_LOG();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB_ZLSJBGJG_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

        }

        /// <summary>
        /// 钢坯实绩信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Stove.Text.Trim() == "")
                {
                    MessageBox.Show("请输入完整的炉号，再进行查询！");
                    return;
                }
                WaitingFrom.ShowWait("");
                DataTable dt = bll_slab.GetList_Stove2(txt_Stove.Text.Trim()).Tables[0];
                gc_GPSJ.DataSource = dt;
                gv_GPSJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPSJ);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 查询钢坯记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_GPSJ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod_CF();
        }
        /// <summary>
        /// 查询执行标准 成分
        /// </summary>
        /// <param name="str"></param>
        private void NewMethod_CF()
        {
            gc_StdCF.DataSource = null;
            DataRow dr = this.gv_GPSJ.GetDataRow(this.gv_GPSJ.FocusedRowHandle);
            if (dr["C_DESIGN_NO"].ToString() == "")
            {
                MessageBox.Show("质量设计号为空！");
                return;
            }
            DataTable dt_CX = bll_DescignLog.GetList_Query(dr["C_DESIGN_NO"].ToString()).Tables[0];
            this.gc_StdCF.DataSource = dt_CX;
            gv_StdCF.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdCF);
        }
        /// <summary>
        /// 查询线材实绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_BatchNo.Text.Trim() == "")
                {
                    MessageBox.Show("请输入完整的批号，再进行查询！");
                    return;
                }
                WaitingFrom.ShowWait("");
                DataTable dt = bll_RollMain.GetQueryBatch(txt_BatchNo.Text.Trim()).Tables[0];
                gc_SJXX.DataSource = dt;
                gv_SJXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SJXX);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 查询线材记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_SJXX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod_XC();
        }
        /// <summary>
        /// 查询执行标准 成分
        /// </summary>
        /// <param name="str"></param>
        private void NewMethod_XC()
        {
            gc_StdCF.DataSource = null;
            DataRow dr = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
            if (dr["C_DESIGN_NO"].ToString() == "")
            {
                MessageBox.Show("质量设计号为空！");
                return;
            }
            DataTable dt_CX = bll_DescignLog.GetList_CF(dr["C_DESIGN_NO"].ToString()).Tables[0];
            this.gc_StdCF.DataSource = dt_CX;
            gv_StdCF.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdCF);
        }
    }
}
