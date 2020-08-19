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
    public partial class FrmQC_JSSY : Form
    {
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        private Bll_TQB_SAMPLING bllTqbSampling = new Bll_TQB_SAMPLING();
        private Bll_TQC_PRESENT_SAMPLES_NAME bllTqcPresentSamplesName = new Bll_TQC_PRESENT_SAMPLES_NAME();
        private Bll_TRC_ROLL_SPOT_CHECK_NAME bllTrcRollSpotCheckName = new Bll_TRC_ROLL_SPOT_CHECK_NAME();
        private Bll_TQB_STD_SAMPLING bll_std_sampling = new Bll_TQB_STD_SAMPLING();
        private Bll_TRC_ROLL_MAIN bll_trc_roll_main = new Bll_TRC_ROLL_MAIN();
        private Bll_TQC_PHYSICS_RESULT_MAIN bllTqcPhysicsResultMain = new Bll_TQC_PHYSICS_RESULT_MAIN();
        private Bll_TQC_PRESENT_SAMPLES_JSZX bllTqcPresentSamplesJszx = new Bll_TQC_PRESENT_SAMPLES_JSZX();

        private string strMenuName;


        public FrmQC_JSSY()
        {
            InitializeComponent();
        }

        private void FrmQC_JSSY_Load(object sender, EventArgs e)
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

        #region 常规

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
                DataTable dt = bllTqcPresentSamplesName.Get_List(txt_BatchNo_CG.Text.Trim(),"", dt_Start.Text.Trim(), dt_End.Text.Trim(), "1").Tables[0];

                gc_SYXX.DataSource = dt;
                gv_SYXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SYXX);

                for (int i = 0; i < 14; i++)
                {
                    gv_SYXX.Columns[i].OptionsColumn.AllowEdit = false;
                }

                gv_SYXX.Columns[0].Visible = false;
                gv_SYXX.Columns[10].Visible = false;
                gv_SYXX.Columns[11].Visible = false;
                gv_SYXX.Columns[12].Visible = false;
                gv_SYXX.Columns[13].Visible = false;

                //冻结有焦点的列
                gv_SYXX.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_SYXX.Columns[2].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_SYXX.Columns[3].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_SYXX.Columns[4].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;

                gv_SYXX.OptionsSelection.MultiSelect = true;
                gv_SYXX.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        ///  保存（常规 ）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sure_CG_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = RV.UI.UserInfo.userID;

                int[] rownumber = gv_SYXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    ArrayList SQLStringList = new ArrayList();

                    int failNum = 0;
                    int failSum = 0;

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int Num = 0;
                        int num_temp = 0;

                        int selectedHandle = rownumber[i];

                        //string strID = gv_SYXX.GetRowCellValue(selectedHandle, "取样主表主键").ToString();

                        DataRow dr = gv_SYXX.GetDataRow(selectedHandle);

                        if (dr == null)
                        {
                            failNum++;
                            break;
                        }

                        SQLStringList.Add("delete from tqc_present_samples_name where C_PRESENT_SAMPLES_ID='" + dr["取样主表主键"].ToString() + "' ");

                        SQLStringList.Add("delete from tqc_present_samples_jszx where C_ID='" + dr["取样主表主键"].ToString() + "' ");

                        for (int k = 14; k < gv_SYXX.Columns.Count; k++)
                        {
                            if (!string.IsNullOrEmpty(gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString()))
                            {
                                int result = 0;
                                if (!int.TryParse(gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString(), out result))
                                {
                                    failNum++;
                                    MessageBox.Show(gv_SYXX.Columns[k].FieldName + " 数量只能填写整数！");
                                    break;
                                }
                                else
                                {

                                    string SampId = bllTqbSampling.GetSampId(gv_SYXX.Columns[k].FieldName,"质控部");

                                    SQLStringList.Add("insert into tqc_present_samples_name(C_PRESENT_SAMPLES_ID,C_SAMPLES_ID,N_SAM_NUM,C_EMP_ID) values('" + dr["取样主表主键"].ToString() + "','" + SampId + "','" + gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString() + "','" + userID + "') ");

                                    if (gv_SYXX.Columns[k].FieldName == "冷镦试验" || gv_SYXX.Columns[k].FieldName == "酸洗检验")
                                    {
                                        if (Convert.ToInt32(gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString()) > num_temp)
                                        {
                                            num_temp = Convert.ToInt32(gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString());
                                        }
                                    }
                                    else
                                    {
                                        Num += Convert.ToInt32(gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString());
                                    }

                                    #region 委托技术中心
                                    if (gv_SYXX.Columns[k].FieldName == "技术中心")
                                    {
                                        SQLStringList.Add("insert into tqc_present_samples_jszx(C_ID,C_BATCH_NO,C_TICK_NO,C_STL_GRD,C_SPEC,N_SAMPLES_NUM,D_MOD_DT) values('" + dr["取样主表主键"].ToString() + "','" + dr["批号"].ToString() + "','" + dr["钩号"].ToString() + "','" + dr["钢种"].ToString() + "','" + dr["规格"].ToString() + "','" + dr["技术中心"].ToString() + "',SYSDATE) ");


                                    }
                                    #endregion
                                }
                            }
                        }

                        if (failNum > 0)
                        {
                            break;
                        }
                        else
                        {
                            int sum = Convert.ToInt32(gv_SYXX.GetRowCellValue(selectedHandle, "取样数量").ToString());

                            if (sum != (Num + num_temp))
                            {
                                failSum++;
                                MessageBox.Show("取样数量明细和总数量不对应，无法接收！");
                                break;
                            }
                            else
                            {
                                SQLStringList.Add("update tqc_present_samples set N_ENTRUST_TYPE=2,C_EMP_ID_JS='" + userID + "',D_MOD_DT_JS=SYSDATE where C_ID='" + dr["取样主表主键"].ToString() + "' ");
                            }
                        }
                    }

                    if (failNum > 0)
                    {
                        return;
                    }

                    if (failSum == 0)
                    {
                        if (bllTqcPresentSamplesName.SaveSamp(SQLStringList))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "保存信息");//添加操作日志

                            MessageBox.Show("成功保存信息！");
                            BindSYXX_CG();
                            BindJYXX_CG();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("请选择需要保存的信息！");
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
                BindJYXX_CG();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定已接样信息
        /// </summary>
        private void BindJYXX_CG()
        {
            try
            {
                DataTable dt = bllTqcPresentSamplesName.Get_List(txt_Batch_ZY_CG.Text.Trim(),"", dt_ZY_Start.Text.Trim(), dt_ZY_End.Text.Trim(), "3").Tables[0];

                gc_ZYXX.DataSource = dt;
                gv_ZYXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZYXX);

                gv_ZYXX.Columns[0].Visible = false;
                gv_ZYXX.Columns[8].Visible = false;
                gv_ZYXX.Columns[9].Visible = false;
                gv_ZYXX.Columns[10].Visible = false;
                gv_ZYXX.Columns[11].Visible = false;

                //冻结有焦点的列
                gv_ZYXX.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_ZYXX.Columns[2].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_ZYXX.Columns[3].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_ZYXX.Columns[4].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;

                gv_ZYXX.OptionsSelection.MultiSelect = true;
                gv_ZYXX.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 接收制样
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_JS_CG_Click(object sender, EventArgs e)
        {
            try
            {
                bool IS_Success = true;

                string userID = RV.UI.UserInfo.userID;

                int[] rownumber = gv_SYXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    bool flag = true;
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        string strID = gv_SYXX.GetRowCellValue(selectedHandle, "取样主表主键").ToString();

                        int count = bllTqcPresentSamples.Get_JS_Count(strID, "0");

                        if (count > 0)
                        {
                            flag = false;
                            MessageBox.Show("批号：" + gv_SYXX.GetRowCellValue(selectedHandle, "批号").ToString() + " 钩号：" + gv_SYXX.GetRowCellValue(selectedHandle, "钩号").ToString() + " 的数据已取消委托，不能执行接样操作！");
                            break;
                        }

                        int count2 = bllTqcPresentSamples.Get_JS_Count(strID, "1");

                        if (count2 > 0)
                        {
                            flag = false;
                            MessageBox.Show("批号：" + gv_SYXX.GetRowCellValue(selectedHandle, "批号").ToString() + " 钩号：" + gv_SYXX.GetRowCellValue(selectedHandle, "钩号").ToString() + " 的数据明细未保存，不能执行接样操作！");
                            break;
                        }
                    }

                    if (!flag)
                    {
                        return;
                    }

                    ArrayList SQLStringList = new ArrayList();

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        string strID = gv_SYXX.GetRowCellValue(selectedHandle, "取样主表主键").ToString();

                        SQLStringList.Add(" update tqc_present_samples set N_ENTRUST_TYPE=3,C_EMP_ID_ZY='" + userID + "',D_MOD_DT_ZY=SYSDATE where C_ID='" + strID + "' ");

                        SQLStringList.Add(" update tqc_present_samples_jszx set N_ENTRUST_TYPE=0,D_MOD_DT=SYSDATE,C_EMP_ID_SY='" + userID + "',D_MOD_DT_SY=sysdate where C_ID='" + strID + "' ");

                        Mod_TQC_PRESENT_SAMPLES mod = bllTqcPresentSamples.GetModel(strID);
                        if (mod != null)
                        {
                            DataTable dt_GroupID = bllTqcPresentSamplesName.Get_PHYSICS_GROUP_ID(strID, "质控部").Tables[0];

                            if (dt_GroupID.Rows.Count > 0)
                            {
                                for (int kk = 0; kk < dt_GroupID.Rows.Count; kk++)
                                {
                                    SQLStringList.Add(" insert into tqc_physics_result_main(C_BATCH_NO,C_TICK_NO,c_stl_grd,c_spec,c_emp_id,d_mod_dt,c_emp_id_zy,d_mod_dt_zy,c_emp_id_js,d_mod_dt_js,C_PHYSICS_GROUP_ID,C_CHECK_STATE,C_PRESENT_SAMPLES_ID)values('" + mod.C_BATCH_NO + "','" + mod.C_TICK_NO + "','" + mod.C_STL_GRD + "','" + mod.C_SPEC + "','" + mod.C_EMP_ID + "',to_date('" + mod.D_MOD_DT + "','yyyy-mm-dd hh24:mi:ss'),'" + userID + "',SYSDATE,'" + mod.C_EMP_ID_JS + "',to_date('" + mod.D_MOD_DT_JS + "','yyyy-mm-dd hh24:mi:ss'),'" + dt_GroupID.Rows[kk]["C_PHYSICS_GROUP_ID"].ToString() + "','0', '" + strID + "') ");
                                }
                            }
                            //else
                            //{
                            //    MessageBox.Show("取样名称和性能分组没有匹配关系！");
                            //    IS_Success = false;
                            //    break;
                            //}
                        }
                    }

                    if (IS_Success)
                    {
                        if (bllTqcPresentSamplesName.SaveSamp(SQLStringList))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "生成制样信息");//添加操作日志

                            MessageBox.Show("保存成功！");
                            BindSYXX_CG();
                            BindJYXX_CG();
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
        /// 取消接样（常规）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Back_CG_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = RV.UI.UserInfo.userID;

                int[] rownumber = gv_ZYXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    bool flag = true;
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        string strID = gv_ZYXX.GetRowCellValue(selectedHandle, "取样主表主键").ToString();

                        int count = bllTqcPhysicsResultMain.Get_Count(strID, "1");

                        if (count > 0)
                        {
                            flag = false;
                            MessageBox.Show("批号：" + gv_ZYXX.GetRowCellValue(selectedHandle, "批号").ToString() + "钩号：" + gv_ZYXX.GetRowCellValue(selectedHandle, "钩号").ToString() + "的数据已录入性能结果，不能取消！");
                            break;
                        }

                        int count_jszx = bllTqcPresentSamplesJszx.Get_Count(strID, "3");

                        if (count_jszx > 0)
                        {
                            flag = false;
                            MessageBox.Show("批号：" + gv_ZYXX.GetRowCellValue(selectedHandle, "批号").ToString() + "钩号：" + gv_ZYXX.GetRowCellValue(selectedHandle, "钩号").ToString() + "的信息，信息中心已接收，不能取消！");
                            break;
                        }

                    }

                    if (!flag)
                    {
                        return;
                    }

                    ArrayList SQLStringList = new ArrayList();

                    bool isBack = true;

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        string strID = gv_ZYXX.GetRowCellValue(selectedHandle, "取样主表主键").ToString();

                        if (string.IsNullOrEmpty(strID))
                        {
                            isBack = false;
                            break;
                        }

                        SQLStringList.Add("delete from tqc_physics_result_main where C_PRESENT_SAMPLES_ID ='" + strID + "' ");

                        SQLStringList.Add("update tqc_present_samples_jszx set N_ENTRUST_TYPE=null where C_ID='" + strID + "' ");

                        SQLStringList.Add("update tqc_present_samples set N_ENTRUST_TYPE=2,C_EMP_ID_JS='',D_MOD_DT_JS=null where C_ID='" + strID + "' ");

                        SQLStringList.Add("delete from TQC_PRESENT_SAMPLES_NAME t where t.C_PRESENT_SAMPLES_ID='" + strID + "' and t.c_samples_id in(select tb.c_id from tqb_sampling tb where tb.c_check_depmt = '技术中心') ");
                    }

                    if (isBack)
                    {
                        if (bllTqcPresentSamplesName.SaveSamp(SQLStringList))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消接收送样信息");//添加操作日志

                            MessageBox.Show("成功取消接样！");
                            BindSYXX_CG();
                            BindJYXX_CG();
                        }
                    }
                    else
                    {
                        MessageBox.Show("取消失败！");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要取消的信息！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region 抽查

        /// <summary>
        /// 线材送样信息查询（抽查）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bllTrcRollSpotCheckName.GetList_CCSY(dte_Begin.DateTime, dte_End.DateTime, txt_BatchNo1.Text.Trim()).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    DataTable dtNew = new DataTable();
                    dtNew.Columns.Add("主键");
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
                DataTable dt = bllTrcRollSpotCheckName.GetList_CCZY(dte_Begin1.DateTime, dte_End1.DateTime, txt_BatchNo2.Text.Trim()).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    DataTable dtNew = new DataTable();
                    dtNew.Columns.Add("主键");
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
                    dtNew.Columns.Add("接样时间");
                    int k = 0;
                    DataRow dr = null;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            dr = dtNew.NewRow();
                            dr["主键"] = dt.Rows[i]["主键"].ToString();
                            dr["炉号"] = dt.Rows[i]["炉号"].ToString();
                            dr["批号"] = dt.Rows[i]["批号"].ToString();
                            dr["钩号"] = dt.Rows[i]["钩号"].ToString();
                            dr["钢种"] = dt.Rows[i]["钢种"].ToString();
                            dr["规格"] = dt.Rows[i]["规格"].ToString();
                            dr["取样时间"] = dt.Rows[i]["取样时间"].ToString();
                            dr["接样时间"] = dt.Rows[i]["接样时间"].ToString();
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
                                dr["炉号"] = dt.Rows[i]["炉号"].ToString();
                                dr["批号"] = dt.Rows[i]["批号"].ToString();
                                dr["钩号"] = dt.Rows[i]["钩号"].ToString();
                                dr["钢种"] = dt.Rows[i]["钢种"].ToString();
                                dr["规格"] = dt.Rows[i]["规格"].ToString();
                                dr["取样时间"] = dt.Rows[i]["取样时间"].ToString();
                                dr["接样时间"] = dt.Rows[i]["接样时间"].ToString();
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

                        for (int k = 7; k < gv_CCSY.Columns.Count; k++)
                        {
                            if (gv_CCSY.GetRowCellValue(selectedHandle, gv_CCSY.Columns[k].FieldName).ToString() != "")
                            {
                                SQLStringList.Add("update TRC_ROLL_SPOT_CHECK set N_ENTRUST_TYPE=2,C_EMP_ID_JS='" + userID + "',D_MOD_DT_JS=SYSDATE where C_ID='" + strID + "' ");
                            }
                        }
                    }

                    if (bllTqcPresentSamplesName.SaveSamp(SQLStringList))
                    {
                        MessageBox.Show("成功接收送样信息！");
                        btn_Query_Click(null, null);
                        btn_Query_ZY_Click(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要接收的送样信息！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion
        /// <summary>
        /// 性能类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_SYXX_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_SYXX.GetDataRow(this.gv_SYXX.FocusedRowHandle);
                if (dr == null) return;//判断是否选中线材实绩信息                             
                DataTable dt = bll_trc_roll_main.GetList_Batch(dr["批号"].ToString()).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    DataTable dt_sampling = bll_std_sampling.GetList_Query(dt.Rows[0]["C_STL_GRD"].ToString(), dt.Rows[0]["C_STD_CODE"].ToString()).Tables[0];
                    gc_XNLB.DataSource = dt_sampling;
                    gv_XNLB.BestFitColumns();
                    SetGridViewRowNum.SetRowNum(gv_XNLB);
                }
                else
                {
                    gc_XNLB.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
