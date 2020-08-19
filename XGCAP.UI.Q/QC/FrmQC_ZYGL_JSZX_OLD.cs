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
    public partial class FrmQC_ZYGL_JSZX_OLD : Form
    {
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        private Bll_TQB_SAMPLING bllTqbSampling = new Bll_TQB_SAMPLING();
        private Bll_TQC_PRESENT_SAMPLES_NAME bllTqcPresentSamplesName = new Bll_TQC_PRESENT_SAMPLES_NAME();
        Bll_TRC_ROLL_SPOT_CHECK bll_spot_check = new Bll_TRC_ROLL_SPOT_CHECK();
        Bll_TRC_ROLL_SPOT_CHECK_NAME bllTrcRollSpotCheckName = new Bll_TRC_ROLL_SPOT_CHECK_NAME();

        private string strMenuName;

        public FrmQC_ZYGL_JSZX_OLD()
        {
            InitializeComponent();
        }

        private void FrmQC_ZYGL_JSZX_OLD_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            dt_ZY_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_ZY_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
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
                DataTable dt = bllTqcPresentSamplesName.Get_List_JSZX(txt_BatchNo_CG.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), "2").Tables[0];

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

                        SQLStringList.Add(" update tqc_present_samples_jszx set N_ENTRUST_TYPE=3,C_EMP_ID_ZY='" + userID + "',D_MOD_DT_ZY=SYSDATE where C_ID='" + strID + "' ");

                        Mod_TQC_PRESENT_SAMPLES mod = bllTqcPresentSamples.GetModel(strID);
                        if (mod != null)
                        {
                            DataTable dt_GroupID = bllTqcPresentSamplesName.Get_PHYSICS_GROUP_ID(strID, "技术中心").Tables[0];

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
                    MessageBox.Show("请选择需要制样的信息！");
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
                DataTable dt = bllTqcPresentSamplesName.Get_List_JSZX(txt_BatchNo_CG.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), "3").Tables[0];

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
    }
}
