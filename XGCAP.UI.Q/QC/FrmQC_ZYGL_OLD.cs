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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_ZYGL_OLD : Form
    {
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        private Bll_TQB_SAMPLING bllTqbSampling = new Bll_TQB_SAMPLING();
        private Bll_TQC_PRESENT_SAMPLES_NAME bllTqcPresentSamplesName = new Bll_TQC_PRESENT_SAMPLES_NAME();
        Bll_TRC_ROLL_SPOT_CHECK bll_spot_check = new Bll_TRC_ROLL_SPOT_CHECK();
        Bll_TRC_ROLL_SPOT_CHECK_NAME bllTrcRollSpotCheckName = new Bll_TRC_ROLL_SPOT_CHECK_NAME();

        private string strMenuName;

        public FrmQC_ZYGL_OLD()
        {
            InitializeComponent();
        }

        private void FrmQC_ZYGL_OLD_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            dt_ZY_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_ZY_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            dte_Begin1.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }

        /// <summary>
        /// 查询送样信息（常规）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_CG_Click(object sender, EventArgs e)
        {
            try
            {
                BindSYXX_CG();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定送样信息
        /// </summary>
        private void BindSYXX_CG()
        {
            try
            {
                DataTable dt = bllTqcPresentSamplesName.Get_List(txt_BatchNo_CG.Text.Trim(),"", dt_Start.Text.Trim(), dt_End.Text.Trim(), "2").Tables[0];

                gc_SYXX.DataSource = dt;
                gv_SYXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SYXX);

                gv_SYXX.Columns[0].Visible = false;
                gv_SYXX.Columns[8].Visible = false;
                gv_SYXX.Columns[9].Visible = false;
                gv_SYXX.Columns[12].Visible = false;
                gv_SYXX.Columns[13].Visible = false;

                gv_SYXX.OptionsSelection.MultiSelect = true;
                gv_SYXX.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        ///  生成制样（常规 ）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sure_CG_Click(object sender, EventArgs e)
        {
            try
            {
                bool IS_Success = true;

                string userID = RV.UI.UserInfo.userID;

                int[] rownumber = gv_SYXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    ArrayList SQLStringList = new ArrayList();

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        string strID = gv_SYXX.GetRowCellValue(selectedHandle, "取样主表主键").ToString();

                        SQLStringList.Add(" update tqc_present_samples set N_ENTRUST_TYPE=3,C_EMP_ID_ZY='" + userID + "',D_MOD_DT_ZY=SYSDATE where C_ID='" + strID + "' ");

                        Mod_TQC_PRESENT_SAMPLES mod = bllTqcPresentSamples.GetModel(strID);
                        if (mod != null)
                        {
                            DataTable dt_GroupID = bllTqcPresentSamplesName.Get_PHYSICS_GROUP_ID(strID, "质控部").Tables[0];

                            if (dt_GroupID.Rows.Count > 0)
                            {
                                for (int kk = 0; kk < dt_GroupID.Rows.Count; kk++)
                                {
                                    SQLStringList.Add(" insert into tqc_physics_result_main(C_BATCH_NO,C_TICK_NO,c_stl_grd,c_spec,c_emp_id,d_mod_dt,c_emp_id_zy,d_mod_dt_zy,c_emp_id_js,d_mod_dt_js,C_PHYSICS_GROUP_ID,C_CHECK_STATE)values('" + mod.C_BATCH_NO + "','" + mod.C_TICK_NO + "','" + mod.C_STL_GRD + "','" + mod.C_SPEC + "','" + mod.C_EMP_ID + "',to_date('" + mod.D_MOD_DT + "','yyyy-mm-dd hh24:mi:ss'),'" + userID + "',SYSDATE,'" + mod.C_EMP_ID_JS + "',to_date('" + mod.D_MOD_DT_JS + "','yyyy-mm-dd hh24:mi:ss'),'" + dt_GroupID.Rows[kk]["C_PHYSICS_GROUP_ID"].ToString() + "','0' ) ");
                                }
                            }
                            else
                            {
                                MessageBox.Show("取样名称和性能分组没有匹配关系！");
                                IS_Success = false;
                            }
                        }
                    }

                    if (IS_Success)
                    {
                        if (bllTqcPresentSamplesName.SaveSamp(SQLStringList))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "生成制样信息");//添加操作日志

                            MessageBox.Show("保存成功！");
                            BindSYXX_CG();
                            BindZYXX_CG();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要制样的送样信息！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                DataTable dt = bllTqcPresentSamplesName.Get_List(txt_BatchNo_CG.Text.Trim(),"", dt_Start.Text.Trim(), dt_End.Text.Trim(), "3").Tables[0];

                gc_ZYXX.DataSource = dt;
                gv_ZYXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZYXX);

                gv_ZYXX.Columns[0].Visible = false;
                gv_ZYXX.Columns[8].Visible = false;
                gv_ZYXX.Columns[9].Visible = false;
                gv_ZYXX.Columns[10].Visible = false;
                gv_ZYXX.Columns[11].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 线材送样信息查询（抽查）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bllTrcRollSpotCheckName.GetList_CCZY(dte_Begin.DateTime, dte_End.DateTime, txt_BatchNo1.Text.Trim()).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    DataTable dtNew = new DataTable();
                    dtNew.Columns.Add("主键");
                    dtNew.Columns.Add("状态");
                    dtNew.Columns.Add("炉号");
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
                    int k = 0;
                    DataRow dr = null;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            dr = dtNew.NewRow();
                            dr["主键"] = dt.Rows[i]["主键"].ToString();
                            dr["状态"] = dt.Rows[i]["状态"].ToString();
                            dr["炉号"] = dt.Rows[i]["炉号"].ToString();
                            dr["批号"] = dt.Rows[i]["批号"].ToString();
                            dr["钩号"] = dt.Rows[i]["钩号"].ToString();
                            dr["钢种"] = dt.Rows[i]["钢种"].ToString();
                            dr["规格"] = dt.Rows[i]["规格"].ToString();
                            dr["取样时间"] = dt.Rows[i]["取样时间"].ToString();
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
                                dr["炉号"] = dt.Rows[i]["炉号"].ToString();
                                dr["批号"] = dt.Rows[i]["批号"].ToString();
                                dr["钩号"] = dt.Rows[i]["钩号"].ToString();
                                dr["钢种"] = dt.Rows[i]["钢种"].ToString();
                                dr["规格"] = dt.Rows[i]["规格"].ToString();
                                dr["取样时间"] = dt.Rows[i]["取样时间"].ToString();
                                if (!string.IsNullOrEmpty(dt.Rows[i]["取样名称"].ToString()))
                                {
                                    dr[dt.Rows[i]["取样名称"].ToString()] = dt.Rows[i]["取样数量"].ToString();
                                }
                            }
                        }

                    }

                    dtNew.Rows.Add(dr);
                    gc_CCSY.DataSource = dtNew;
                    gv_CCSY.BestFitColumns();
                    SetGridViewRowNum.SetRowNum(gv_CCSY);
                    gv_CCSY.Columns[0].Visible = false;
                    gv_CCSY.OptionsSelection.MultiSelect = true;
                    gv_CCSY.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                }
                else
                {
                    gc_CCSY.DataSource = null;
                    gv_CCSY.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 制样信息查询（抽查）
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
                    dtNew.Columns.Add("炉号");
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
                            dr["炉号"] = dt.Rows[i]["炉号"].ToString();
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
                            if (dt.Rows[i]["炉号"].ToString() == dt.Rows[i - 1]["炉号"].ToString() && dt.Rows[i]["批号"].ToString() == dt.Rows[i - 1]["批号"].ToString() && dt.Rows[i]["钩号"].ToString() == dt.Rows[i - 1]["钩号"].ToString() && dt.Rows[i]["钢种"].ToString() == dt.Rows[i - 1]["钢种"].ToString() && dt.Rows[i]["规格"].ToString() == dt.Rows[i - 1]["规格"].ToString())
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
                                dr["炉号"] = dt.Rows[i]["炉号"].ToString();
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
        /// 生成制样（抽查）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SCZY_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = RV.UI.UserInfo.userID;

                int[] rownumber = gv_CCSY.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    ArrayList SQLStringList = new ArrayList();

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        string strID = gv_CCSY.GetRowCellValue(selectedHandle, "主键").ToString();

                        for (int k = 8; k < gv_CCSY.Columns.Count; k++)
                        {
                            if (gv_CCSY.GetRowCellValue(selectedHandle, gv_CCSY.Columns[k].FieldName).ToString() != "")
                            {
                                SQLStringList.Add("update TRC_ROLL_SPOT_CHECK set N_ENTRUST_TYPE=3,C_EMP_ID_ZY='" + userID + "',D_MOD_DT_ZY=SYSDATE where C_ID='" + strID + "' ");
                            }
                        }
                    }

                    if (bllTqcPresentSamplesName.SaveSamp(SQLStringList))
                    {
                        MessageBox.Show("保存成功！");
                        btn_Query_Click(null, null);
                        btn_Query_ZY_Click(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要制样的送样信息！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
