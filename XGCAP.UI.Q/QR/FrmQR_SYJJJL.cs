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
using System.Collections;
using Common;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_SYJJJL : Form
    {
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        private Bll_TQB_SAMPLING bllTqbSampling = new Bll_TQB_SAMPLING();
        private Bll_TQC_PRESENT_SAMPLES_NAME bllTqcPresentSamplesName = new Bll_TQC_PRESENT_SAMPLES_NAME();
        Bll_TRC_ROLL_SPOT_CHECK bll_spot_check = new Bll_TRC_ROLL_SPOT_CHECK();
        Bll_TRC_ROLL_SPOT_CHECK_NAME bllTrcRollSpotCheckName = new Bll_TRC_ROLL_SPOT_CHECK_NAME();
        public FrmQR_SYJJJL()
        {
            InitializeComponent();
        }

        private void FrmQR_SYJJJL_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            dt_ZY_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_ZY_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            dte_Begin1.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

        }

        /// <summary>
        /// 查询制样信息（常规）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_ZY_CG_Click(object sender, EventArgs e)
        {
            try
            {
                BindZYXX_CG();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定送样信息
        /// </summary>
        private void BindZYXX_CG()
        {
            try
            {
                DataTable dt = bllTqcPresentSamplesName.Get_List(txt_Batch_Min.Text.Trim(), txt_Batch_Max.Text.Trim(), dt_ZY_Start.Text.Trim(), dt_ZY_End.Text.Trim(), "3").Tables[0];

                dt.Columns["钢种"].SetOrdinal(2);
                dt.Columns["规格"].SetOrdinal(3);

                dt.Columns["送样时间"].SetOrdinal(dt.Columns.Count - 1);
                dt.Columns["接样时间"].SetOrdinal(dt.Columns.Count - 1);

                gc_ZYXX.DataSource = dt;
                gv_ZYXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZYXX);

                gv_ZYXX.Columns["取样数量"].Caption = "数量";

                gv_ZYXX.Columns["送样时间"].Caption = "取样时间";
                //gv_ZYXX.Columns["接收时间"].Caption = "接样时间";

                gv_ZYXX.Columns["取样主表主键"].Visible = false;
                gv_ZYXX.Columns["炉号"].Visible = false;
                gv_ZYXX.Columns["执行标准"].Visible = false;
                gv_ZYXX.Columns["送样人"].Visible = false;
                gv_ZYXX.Columns["接样人"].Visible = false;
                gv_ZYXX.Columns["取样明细保存时间"].Visible = false;
                gv_ZYXX.Columns["取样明细保存人"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 抽查查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_ZY_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bllTrcRollSpotCheckName.GetList_ZYXX(dte_Begin1.DateTime, dte_End1.DateTime, txt_BatchNo2.Text.Trim()).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    DataTable dtNew = new DataTable();
                    dtNew.Columns.Add("主键");
                    dtNew.Columns.Add("状态");
                    dtNew.Columns.Add("批号");
                    dtNew.Columns.Add("钩号");
                    dtNew.Columns.Add("钢种");
                    dtNew.Columns.Add("规格");

                    DataTable dtSam = bllTqbSampling.GetAllList().Tables[0];
                    for (int i = 0; i < dtSam.Rows.Count; i++)
                    {
                        dtNew.Columns.Add(dtSam.Rows[i]["C_SAMPLING_NAME"].ToString());
                    }
                    dtNew.Columns.Add("取样时间");
                    dtNew.Columns.Add("制样时间");
                    int k = 0;
                    DataRow dr = null;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            dr = dtNew.NewRow();
                            dr["主键"] = dt.Rows[i]["主键"].ToString();
                            dr["状态"] = dt.Rows[i]["状态"].ToString();
                            dr["批号"] = dt.Rows[i]["批号"].ToString();
                            dr["钩号"] = dt.Rows[i]["钩号"].ToString();
                            dr["钢种"] = dt.Rows[i]["钢种"].ToString();
                            dr["规格"] = dt.Rows[i]["规格"].ToString();
                            dr["取样时间"] = dt.Rows[i]["取样时间"].ToString();
                            dr["制样时间"] = dt.Rows[i]["制样时间"].ToString();
                            if (!string.IsNullOrEmpty(dt.Rows[i]["取样名称"].ToString()))
                            {
                                dr[dt.Rows[i]["取样名称"].ToString()] = dt.Rows[i]["取样数量"].ToString();
                            }
                        }
                        else
                        {
                            if (dt.Rows[i]["批号"].ToString() == dt.Rows[i - 1]["批号"].ToString() && dt.Rows[i]["钩号"].ToString() == dt.Rows[i - 1]["钩号"].ToString() && dt.Rows[i]["钢种"].ToString() == dt.Rows[i - 1]["钢种"].ToString() && dt.Rows[i]["规格"].ToString() == dt.Rows[i - 1]["规格"].ToString())
                            {
                                if (!string.IsNullOrEmpty(dt.Rows[i]["取样名称"].ToString()))
                                {
                                    dr[dt.Rows[i]["取样名称"].ToString()] = dt.Rows[i]["取样数量"].ToString();

                                    k++;
                                }
                            }
                            else
                            {
                                dtNew.Rows.Add(dr);

                                k = 0;

                                dr = dtNew.NewRow();
                                dr["主键"] = dt.Rows[i]["主键"].ToString();
                                dr["状态"] = dt.Rows[i]["状态"].ToString();
                                dr["批号"] = dt.Rows[i]["批号"].ToString();
                                dr["钩号"] = dt.Rows[i]["钩号"].ToString();
                                dr["钢种"] = dt.Rows[i]["钢种"].ToString();
                                dr["规格"] = dt.Rows[i]["规格"].ToString();
                                dr["取样时间"] = dt.Rows[i]["取样时间"].ToString();
                                dr["制样时间"] = dt.Rows[i]["制样时间"].ToString();
                                if (!string.IsNullOrEmpty(dt.Rows[i]["取样名称"].ToString()))
                                {
                                    dr[dt.Rows[i]["取样名称"].ToString()] = dt.Rows[i]["取样数量"].ToString();
                                }
                            }
                        }

                    }

                    dtNew.Rows.Add(dr);
                    gc_CCZY.DataSource = dtNew;
                    gv_CCZY.BestFitColumns();
                    SetGridViewRowNum.SetRowNum(gv_CCZY);
                    gv_CCZY.Columns[0].Visible = false;
                    gv_CCZY.OptionsSelection.MultiSelect = true;
                    gv_CCZY.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                }
                else
                {
                    gc_CCZY.DataSource = null;
                    gv_CCZY.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_ZYXX, "试样交接记录-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}
