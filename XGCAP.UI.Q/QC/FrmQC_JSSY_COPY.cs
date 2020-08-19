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
    public partial class FrmQC_JSSY_COPY : Form
    {
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        private Bll_TQB_SAMPLING bllTqbSampling = new Bll_TQB_SAMPLING();
        private Bll_TQC_PRESENT_SAMPLES_NAME bllTqcPresentSamplesName = new Bll_TQC_PRESENT_SAMPLES_NAME();
        Bll_TRC_ROLL_SPOT_CHECK bll_spot_check = new Bll_TRC_ROLL_SPOT_CHECK();
        Bll_TRC_ROLL_SPOT_CHECK_NAME bllTrcRollSpotCheckName = new Bll_TRC_ROLL_SPOT_CHECK_NAME();
        Bll_TQB_STD_SAMPLING bll_std_sampling = new Bll_TQB_STD_SAMPLING();
        Bll_TRC_ROLL_MAIN bll_trc_roll_main = new Bll_TRC_ROLL_MAIN();
        private Bll_TQC_PHYSICS_RESULT_MAIN bllTqcPhysicsResultMain = new Bll_TQC_PHYSICS_RESULT_MAIN();
        private Bll_TQC_PRESENT_SAMPLES_JSZX bllTqcPresentSamplesJszx = new Bll_TQC_PRESENT_SAMPLES_JSZX();
        Bll_TQB_SAMP_ITEM_MODLE bllTqbSampItemModle = new Bll_TQB_SAMP_ITEM_MODLE();

        private string strMenuName;
        private bool m_checkStatus = false;

        private DataTable dtMain;

        public FrmQC_JSSY_COPY()
        {
            InitializeComponent();
        }

        private void FrmQC_JSSY_COPY_Load(object sender, EventArgs e)
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


            DataTable dtCol = new DataTable();
            dtCol.Columns.Add("取样主表主键");
            dtCol.Columns.Add("批号");
            dtCol.Columns.Add("钩号");
            dtCol.Columns.Add("炉号");
            dtCol.Columns.Add("取样数量");
            dtCol.Columns.Add("钢种");
            dtCol.Columns.Add("规格");
            dtCol.Columns.Add("执行标准");
            dtCol.Columns.Add("送样时间");
            dtCol.Columns.Add("送样人");
            dtCol.Columns.Add("送样班次");
            dtCol.Columns.Add("送样班组");
            dtCol.Columns.Add("取样明细保存时间");
            dtCol.Columns.Add("取样明细保存人");
            dtCol.Columns.Add("接样时间");
            dtCol.Columns.Add("接样人");
            dtCol.Columns.Add("接样班次");
            dtCol.Columns.Add("接样班组");

            DataTable dt_Sam = bllTqbSampling.GetList_Item().Tables[0];

            for (int i = 0; i < dt_Sam.Rows.Count; i++)
            {
                dtCol.Columns.Add(dt_Sam.Rows[i]["C_SAMPLING_NAME"].ToString());
            }


            for (int i = 0; i < dtCol.Columns.Count; i++)
            {
                DevExpress.XtraGrid.Columns.GridColumn gridColumnAdd = new DevExpress.XtraGrid.Columns.GridColumn();
                gridColumnAdd.Caption = dtCol.Columns[i].ColumnName;
                gridColumnAdd.FieldName = dtCol.Columns[i].ColumnName;
                gridColumnAdd.Name = "gridColumnAdd" + i.ToString();
                gridColumnAdd.Visible = true;
                gridColumnAdd.VisibleIndex = i;

                gv_SYXX.Columns.Add(gridColumnAdd);
            }

            gv_SYXX.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            gv_SYXX.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            gv_SYXX.OptionsSelection.MultiSelect = true;
            gv_SYXX.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
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
                dtMain = new DataTable();

                m_checkStatus = false;

                dtMain = bllTqcPresentSamplesName.Get_List(txt_Batch_Min.Text.Trim(), txt_Batch_Max.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), "1").Tables[0];

                dtMain.Columns.Add("chk", System.Type.GetType("System.Boolean"));
                dtMain.Columns["chk"].DefaultValue = Boolean.FalseString;
                dtMain.Columns["chk"].SetOrdinal(0);

                gc_SYXX.DataSource = dtMain;
                gv_SYXX.BestFitColumns();

                for (int i = 0; i < dtMain.Rows.Count; i++)
                {
                    gv_SYXX.SetRowCellValue(i, "chk", false);
                }

                for (int i = 1; i <= 14; i++)
                {
                    gv_SYXX.Columns[i].OptionsColumn.AllowEdit = false;
                }

                gv_SYXX.Columns[1].Visible = false;
                gv_SYXX.Columns["取样明细保存时间"].Visible = false;
                gv_SYXX.Columns["取样明细保存人"].Visible = false;
                gv_SYXX.Columns["接样时间"].Visible = false;
                gv_SYXX.Columns["接样人"].Visible = false;
                gv_SYXX.Columns["接样班次"].Visible = false;
                gv_SYXX.Columns["接样班组"].Visible = false;

                //冻结有焦点的列
                gv_SYXX.Columns[0].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_SYXX.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_SYXX.Columns[2].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_SYXX.Columns[3].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_SYXX.Columns[4].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_SYXX.Columns[5].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
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

                bool IsCheck = false;

                int failNum = 0;
                int failSum = 0;

                ArrayList SQLStringList = new ArrayList();

                for (int i = 0; i < gv_SYXX.DataRowCount; i++)
                {
                    string val = this.gv_SYXX.GetRowCellValue(i, this.gv_SYXX.Columns["chk"]).ToString();
                    if (val == "True")
                    {
                        IsCheck = true;

                        int Num = 0;
                        int num_temp = 0;

                        DataRow dr = gv_SYXX.GetDataRow(i);

                        SQLStringList.Add("delete from tqc_present_samples_name where C_PRESENT_SAMPLES_ID='" + dr["取样主表主键"].ToString() + "' ");

                        SQLStringList.Add("delete from tqc_present_samples_jszx where C_ID='" + dr["取样主表主键"].ToString() + "' ");

                        for (int k = 19; k < gv_SYXX.Columns.Count; k++)
                        {
                            if (!string.IsNullOrEmpty(gv_SYXX.GetRowCellValue(i, gv_SYXX.Columns[k].FieldName).ToString()))
                            {
                                int result = 0;
                                if (!int.TryParse(gv_SYXX.GetRowCellValue(i, gv_SYXX.Columns[k].FieldName).ToString(), out result) && !gv_SYXX.Columns[k].FieldName.Contains("备注"))
                                {
                                    if (!gv_SYXX.Columns[k].FieldName.Contains("备注"))
                                    {
                                        failNum++;
                                        MessageBox.Show("第" + i + "行" + gv_SYXX.Columns[k].FieldName + " 数量只能填写整数！");
                                        break;
                                    }
                                }
                                else
                                {

                                    string SampId = bllTqbSampling.GetSampId(gv_SYXX.Columns[k].FieldName, "质控部");

                                    //if (gv_SYXX.Columns[k].FieldName.Contains("备注"))
                                    //{
                                    //    continue;
                                    //}

                                    SQLStringList.Add("insert into tqc_present_samples_name(C_PRESENT_SAMPLES_ID,C_SAMPLES_ID,N_SAM_NUM,C_EMP_ID) values('" + dr["取样主表主键"].ToString() + "','" + SampId + "','" + gv_SYXX.GetRowCellValue(i, gv_SYXX.Columns[k].FieldName).ToString() + "','" + userID + "') ");

                                    if (gv_SYXX.Columns[k].FieldName == "冷镦试验" || gv_SYXX.Columns[k].FieldName == "酸洗检验")
                                    {
                                        if (Convert.ToInt32(gv_SYXX.GetRowCellValue(i, gv_SYXX.Columns[k].FieldName).ToString()) > num_temp)
                                        {
                                            num_temp = Convert.ToInt32(gv_SYXX.GetRowCellValue(i, gv_SYXX.Columns[k].FieldName).ToString());
                                        }
                                    }
                                    else
                                    {
                                        if (!gv_SYXX.Columns[k].FieldName.Contains("备注"))
                                        {
                                            Num += Convert.ToInt32(gv_SYXX.GetRowCellValue(i, gv_SYXX.Columns[k].FieldName).ToString());
                                        }
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

                        int sum = Convert.ToInt32(gv_SYXX.GetRowCellValue(i, "取样数量").ToString());

                        if (sum != (Num + num_temp))
                        {
                            failSum++;
                            MessageBox.Show("第" + i + "行取样数量明细和总数量不对应，无法接收！");
                            break;
                        }
                        else
                        {
                            SQLStringList.Add("update tqc_present_samples set N_ENTRUST_TYPE=2,C_EMP_ID_JS='" + userID + "',D_MOD_DT_JS=SYSDATE where C_ID='" + dr["取样主表主键"].ToString() + "' ");
                        }
                    }
                }

                if (!IsCheck)
                {
                    MessageBox.Show("请选择需要保存的信息！");
                    return;
                }
                else
                {
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
                DataTable dt = bllTqcPresentSamplesName.Get_List(txt_Batch_ZY_Min.Text.Trim(), txt_Batch_ZY_Max.Text.Trim(), dt_ZY_Start.Text.Trim(), dt_ZY_End.Text.Trim(), "3").Tables[0];

                gc_ZYXX.DataSource = dt;
                gv_ZYXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZYXX);

                gv_ZYXX.Columns[0].Visible = false;
                gv_ZYXX.Columns["取样明细保存时间"].Visible = false;
                gv_ZYXX.Columns["取样明细保存人"].Visible = false;
                gv_ZYXX.Columns["送样时间"].Visible = false;
                gv_ZYXX.Columns["送样人"].Visible = false;
                gv_ZYXX.Columns["送样班次"].Visible = false;
                gv_ZYXX.Columns["送样班组"].Visible = false;

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

                bool flag = true;

                if (string.IsNullOrEmpty(icbo_BC.Text.ToString()) || string.IsNullOrEmpty(icbo_BZ.Text.ToString()))
                {
                    MessageBox.Show("请选择班次班组！");
                    return;
                }

                for (int i = 0; i < gv_SYXX.DataRowCount; i++)
                {
                    string val = this.gv_SYXX.GetRowCellValue(i, this.gv_SYXX.Columns["chk"]).ToString();
                    if (val == "True")
                    {
                        string strID = gv_SYXX.GetRowCellValue(i, "取样主表主键").ToString();

                        int count = bllTqcPresentSamples.Get_JS_Count(strID, "0");

                        if (count > 0)
                        {
                            flag = false;
                            MessageBox.Show("批号：" + gv_SYXX.GetRowCellValue(i, "批号").ToString() + " 钩号：" + gv_SYXX.GetRowCellValue(i, "钩号").ToString() + " 的数据已取消委托，不能执行接样操作！");
                            break;
                        }

                        int count2 = bllTqcPresentSamples.Get_JS_Count(strID, "1");

                        if (count2 > 0)
                        {
                            flag = false;
                            MessageBox.Show("批号：" + gv_SYXX.GetRowCellValue(i, "批号").ToString() + " 钩号：" + gv_SYXX.GetRowCellValue(i, "钩号").ToString() + " 的数据明细未保存，不能执行接样操作！");
                            break;
                        }
                    }
                }

                if (!flag)
                {
                    return;
                }

                ArrayList SQLStringList = new ArrayList();

                for (int i = 0; i < gv_SYXX.DataRowCount; i++)
                {
                    string val = this.gv_SYXX.GetRowCellValue(i, this.gv_SYXX.Columns["chk"]).ToString();
                    if (val == "True")
                    {
                        string strID = gv_SYXX.GetRowCellValue(i, "取样主表主键").ToString();

                        SQLStringList.Add(" update tqc_present_samples set N_ENTRUST_TYPE=3,C_EMP_ID_ZY='" + userID + "',D_MOD_DT_ZY=SYSDATE,C_BC_JY='" + icbo_BC.EditValue.ToString() + "',C_BZ_JY='" + icbo_BZ.EditValue.ToString() + "' where C_ID='" + strID + "' ");

                        SQLStringList.Add(" update tqc_present_samples_jszx set N_ENTRUST_TYPE=0,D_MOD_DT=SYSDATE,C_EMP_ID_SY='" + userID + "',D_MOD_DT_SY=sysdate where C_ID='" + strID + "' ");

                        Mod_TQC_PRESENT_SAMPLES mod = bllTqcPresentSamples.GetModel(strID);
                        if (mod != null)
                        {
                            DataTable dt_GroupID = bllTqcPresentSamplesName.Get_PHYSICS_GROUP_ID(strID, "质控部").Tables[0];

                            if (dt_GroupID.Rows.Count > 0)
                            {
                                for (int kk = 0; kk < dt_GroupID.Rows.Count; kk++)
                                {
                                    SQLStringList.Add(" insert into tqc_physics_result_main(C_BATCH_NO,C_TICK_NO,c_stl_grd,c_spec,c_emp_id,d_mod_dt,c_emp_id_zy,d_mod_dt_zy,c_emp_id_js,d_mod_dt_js,C_PHYSICS_GROUP_ID,C_CHECK_STATE,C_PRESENT_SAMPLES_ID)values('" + mod.C_BATCH_NO + "','" + mod.C_TICK_NO + "','" + mod.C_STL_GRD + "','" + mod.C_SPEC + "','" + mod.C_EMP_ID + "',to_date('" + mod.D_MOD_DT + "','yyyy-mm-dd hh24:mi:ss'),'" + userID + "',SYSDATE,'" + mod.C_EMP_ID_JS + "',to_date('" + mod.D_MOD_DT_JS + "','yyyy-mm-dd hh24:mi:ss'),'" + dt_GroupID.Rows[kk]["C_PHYSICS_GROUP_ID"].ToString() + "','0','" + strID + "' ) ");
                                }
                            }
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
                        BindJYXX_CG();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 取消接样(常规)
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

                        SQLStringList.Add("update tqc_present_samples set N_ENTRUST_TYPE=2,C_EMP_ID_ZY='',D_MOD_DT_ZY=null where C_ID='" + strID + "' ");

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
                if (ClickGridCheckBox(gv_SYXX, "chk", m_checkStatus))
                {
                    m_checkStatus = !m_checkStatus;
                }

                DataRow dr = this.gv_SYXX.GetDataRow(this.gv_SYXX.FocusedRowHandle);
                if (dr == null) return;//判断是否选中线材实绩信息                             
                DataTable dt = bll_trc_roll_main.GetList_Batch(dr["批号"].ToString()).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    //DataTable dt_sampling = bll_std_sampling.GetList_Query(dt.Rows[0]["C_STL_GRD"].ToString(), dt.Rows[0]["C_STD_CODE"].ToString()).Tables[0];
                    DataTable dt_sampling = bllTqbSampItemModle.Get_ITEM_List(dt.Rows[0]["C_STD_CODE"].ToString(), dt.Rows[0]["C_STL_GRD"].ToString(), dt.Rows[0]["C_SPEC"].ToString().Substring(1)).Tables[0];
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

        #region 复制

        private int colStartIndex = 0;
        private int rowStartIndex = 0;
        private string strStart = "";

        private void gv_SYXX_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Form的KeyPreview属性应设为true
                if (e.KeyChar != (char)22)// Ctrl + V
                {
                    return;
                }

                colStartIndex = gv_SYXX.FocusedColumn.ColumnHandle;
                rowStartIndex = gv_SYXX.FocusedRowHandle;

                int rowIndex = rowStartIndex;

                if (colStartIndex <= 14)//前10列固定，不能修改
                {
                    return;
                }

                IDataObject data = Clipboard.GetDataObject();
                string[] types = data.GetFormats();
                string tmp = "";
                if (data.GetDataPresent(typeof(string)))
                {
                    tmp = (string)data.GetData(typeof(string));

                    string schar = tmp.Substring(tmp.Length - 1);
                    if (schar == "\n")
                    {
                        tmp = tmp.Substring(0, tmp.Length - 1);
                    }

                    tmp = tmp.Replace("\r", "");
                    string[] rows = tmp.Split(new char[] { '\n' });

                    for (int i = 0; i < rows.Length; i++)
                    {
                        int colIndex = colStartIndex;

                        string[] cols = rows[i].Split(new char[] { '\t' });
                        // 把cols插入到grid中

                        for (int jj = 0; jj < cols.Length; jj++)
                        {
                            if (i == 0 && jj == 0)
                            {
                                strStart = cols[jj];
                            }

                            if (colIndex < gv_SYXX.Columns.Count && rowIndex < gv_SYXX.RowCount)
                            {
                                gv_SYXX.SetRowCellValue(rowIndex, gv_SYXX.Columns[colIndex], cols[jj]);
                                colIndex++;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        rowIndex++;
                    }
                }
            }
            catch
            {

            }
        }

        private void gv_SYXX_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                e.Appearance.Font = new System.Drawing.Font("宋体", 9);
                e.Info.ImageIndex = -1;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }

                if (e.RowHandle >= 0)
                {
                    if (colStartIndex > 0 && e.RowHandle == rowStartIndex)
                    {
                        gv_SYXX.SetRowCellValue(rowStartIndex, gv_SYXX.Columns[colStartIndex], strStart);

                        colStartIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region  列头选择框

        /// <summary>
        /// 列头画多选框
        /// </summary>
        /// <param name="e"></param>
        /// <param name="chk"></param>

        private static void DrawCheckBox(DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e, bool chk)
        {
            try
            {
                DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryCheck = e.Column.ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit;
                if (repositoryCheck != null)
                {
                    System.Drawing.Graphics g = e.Graphics;
                    System.Drawing.Rectangle r = e.Bounds;

                    DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
                    DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
                    DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
                    info = repositoryCheck.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;

                    painter = repositoryCheck.CreatePainter() as DevExpress.XtraEditors.Drawing.CheckEditPainter;
                    info.EditValue = chk;
                    info.Bounds = r;
                    info.CalcViewInfo(g);
                    args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
                    painter.Draw(args);
                    args.Cache.Dispose();
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 自定义列头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_SYXX_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null && e.Column.FieldName == "chk")
            {
                e.Info.InnerElements.Clear();
                e.Painter.DrawObject(e.Info);
                DrawCheckBox(e, m_checkStatus);
                e.Handled = true;
            }
        }

        /// <summary>
        /// 全选/全不选
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="fieldName"></param>
        /// <param name="currentStatus"></param>
        /// <returns></returns>
        private bool ClickGridCheckBox(DevExpress.XtraGrid.Views.Grid.GridView gridView, string fieldName, bool currentStatus)

        {

            try
            {
                bool result = false;

                if (gridView != null)
                {

                    gridView.PostEditor();

                    DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo info;

                    Point pt = gridView.GridControl.PointToClient(Control.MousePosition);

                    info = gridView.CalcHitInfo(pt);

                    if (info.InColumn && info.Column != null && info.Column.FieldName == fieldName)
                    {
                        for (int i = 0; i < gridView.RowCount; i++)
                        {
                            gridView.SetRowCellValue(i, fieldName, !currentStatus);
                        }

                        return true;

                    }

                }

                return result;
            }
            catch
            {
                return false;
            }

        }


        #endregion

        private void gv_SYXX_DoubleClick(object sender, EventArgs e)
        {
            if (gv_SYXX.FocusedColumn.GetTextCaption() == "批号")
            {
                int handle = gv_SYXX.FocusedRowHandle;
                if (handle >= 0)
                {
                    bool bChk = (bool)gv_SYXX.GetRowCellValue(handle, "chk");
                    string strBatch = gv_SYXX.GetRowCellValue(handle, "批号").ToString();
                    for (int i = 0; i < gv_SYXX.RowCount; i++)
                    {
                        if (strBatch == gv_SYXX.GetRowCellValue(i, "批号").ToString())
                        {
                            gv_SYXX.SetRowCellValue(i, "chk", !bChk);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 匹配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Match_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtMain == null)
                    return;

                WaitingFrom.ShowWait("正在根据模板匹配取样信息...");

                DataTable dt = bllTqcPresentSamplesName.Get_Model_List("", "").Tables[0];

                string strBatch = "";

                DataRow[] rows = null;

                int mm = 0;

                DataTable dt_Error = new DataTable();
                dt_Error.Columns.Add("Error");

                for (int i = 0; i < dtMain.Rows.Count; i++)
                {
                    if (strBatch != dtMain.Rows[i]["批号"].ToString())
                    {
                        if (rows != null)
                        {
                            if (mm < rows.Length - 1)
                            {
                                DataRow dr = dt_Error.NewRow();
                                dr["Error"] = "批号" + strBatch + "的取样信息与模板不一致，请核对数据！";
                                dt_Error.Rows.Add(dr);
                            }
                        }

                        rows = dt.Select(" 执行标准='" + dtMain.Rows[i]["执行标准"].ToString() + "' and 钢种='" + dtMain.Rows[i]["钢种"].ToString() + "' AND 规格最小值<= '" + Convert.ToDecimal(dtMain.Rows[i]["规格"].ToString().Substring(1)) + "' AND 规格最大值>='" + Convert.ToDecimal(dtMain.Rows[i]["规格"].ToString().Substring(1)) + "' ");

                        mm = 0;
                    }
                    else
                    {
                        mm++;
                    }

                    strBatch = dtMain.Rows[i]["批号"].ToString();

                    if (rows.Length > 0)
                    {
                        if (mm < rows.Length)
                        {
                            if (dtMain.Rows[i]["取样数量"].ToString() == rows[mm]["取样数量"].ToString())
                            {
                                for (int kk = 19; kk < dtMain.Columns.Count; kk++)
                                {
                                    //if (dtMain.Columns[kk].ColumnName.Contains("备注"))
                                    //{
                                    //    continue;
                                    //}

                                    if (!string.IsNullOrEmpty(rows[mm][dtMain.Columns[kk].ColumnName].ToString()))
                                    {
                                        dtMain.Rows[i][kk] = rows[mm][dtMain.Columns[kk].ColumnName].ToString();
                                    }
                                    else
                                    {
                                        dtMain.Rows[i][kk] = DBNull.Value;
                                    }
                                }
                            }
                            else
                            {
                                DataRow dr = dt_Error.NewRow();
                                dr["Error"] = "批号" + dtMain.Rows[i]["批号"].ToString() + "的取样信息与模板不一致，请核对数据！";
                                dt_Error.Rows.Add(dr);
                            }
                        }
                        else
                        {
                            DataRow dr = dt_Error.NewRow();
                            dr["Error"] = "批号" + dtMain.Rows[i]["批号"].ToString() + "的取样信息与模板不一致，请核对数据！";
                            dt_Error.Rows.Add(dr);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                if (rows != null)
                {
                    if (mm < rows.Length - 1)
                    {
                        DataRow dr = dt_Error.NewRow();
                        dr["Error"] = "批号" + strBatch + "的取样信息与模板不一致，请核对数据！";
                        dt_Error.Rows.Add(dr);
                    }
                }

                DataView dataView = dt_Error.DefaultView;

                DataTable dataTableDistinct = dataView.ToTable(true, "Error");

                string strError = "";

                for (int i = 0; i < dataTableDistinct.Rows.Count; i++)
                {
                    strError = strError + dataTableDistinct.Rows[i]["Error"].ToString() + "；";
                }

                if (!string.IsNullOrEmpty(strError))
                {
                    MessageBox.Show(strError);
                }
                else
                {
                    MessageBox.Show("匹配成功！");
                }

                gc_SYXX.RefreshDataSource();

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
