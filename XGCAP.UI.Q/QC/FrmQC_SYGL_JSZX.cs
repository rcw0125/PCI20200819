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
    public partial class FrmQC_SYGL_JSZX : Form
    {
        private Bll_TQB_SAMPLING bllTqbSampling = new Bll_TQB_SAMPLING();
        private Bll_TQC_PRESENT_SAMPLES_NAME bllTqcPresentSamplesName = new Bll_TQC_PRESENT_SAMPLES_NAME();
        private Bll_TQB_STD_SAMPLING bll_std_sampling = new Bll_TQB_STD_SAMPLING();
        private Bll_TQC_PRESENT_SAMPLES_JSZX bllTqcPresentSamplesJszx = new Bll_TQC_PRESENT_SAMPLES_JSZX();

        private string strMenuName;
        private string strSam = "";
        private string strSamplesName = "";

        private DataTable dt_sampling;

        private DataTable dtMain;

        public FrmQC_SYGL_JSZX()
        {
            InitializeComponent();
        }

        private void FrmQC_SYGL_JSZX_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            strSam = RV.UI.QueryString.parameter;

            dt_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            dt_SY_Start.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_SY_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");


            if (strSam.Length > 0)
            {
                string[] strs = strSam.Split('|');

                for (int i = 0; i < strs.Length; i++)
                {
                    strSamplesName = strSamplesName + "'" + strs[i] + "',";
                }

                if (strSamplesName.Length > 0)
                {
                    strSamplesName = strSamplesName.Substring(0, strSamplesName.Length - 1);
                }
            }
        }

        /// <summary>
        /// 查询委托信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_CG_Click(object sender, EventArgs e)
        {
            try
            {
                BindJYXX();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定送样信息
        /// </summary>
        private void BindJYXX()
        {
            try
            {
                WaitingFrom.ShowWait("");

                dtMain = new DataTable();

                gc_SYXX.DataSource = null;

                dtMain = bllTqcPresentSamplesName.Get_List_JSZX(txt_BatchNo_CG.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), "0").Tables[0];

                dt_sampling = bll_std_sampling.GetList_JSZX(dt_Start.Text.Trim(), dt_End.Text.Trim()).Tables[0];

                gc_SYXX.DataSource = dtMain;
                gv_SYXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SYXX);

                for (int i = 0; i < 14; i++)
                {
                    gv_SYXX.Columns[i].OptionsColumn.AllowEdit = false;
                }

                gv_SYXX.Columns[0].Visible = false;
                //gv_SYXX.Columns[8].Visible = false;
                //gv_SYXX.Columns[9].Visible = false;
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

                WaitingFrom.CloseWait();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        ///  保存
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
                    //int failSum = 0;

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int Num = 0;
                        int num_temp = 0;

                        int selectedHandle = rownumber[i];

                        DataRow dr = gv_SYXX.GetDataRow(selectedHandle);

                        if (dr == null)
                        {
                            failNum++;
                            break;
                        }

                        SQLStringList.Add("delete from tqc_present_samples_name where C_PRESENT_SAMPLES_ID='" + dr["取样主表主键"].ToString() + "' and c_samples_id in (select ts.c_id from tqb_sampling ts where ts.c_check_depmt='技术中心') ");

                        int samp_num = 0;

                        for (int k = 14; k < gv_SYXX.Columns.Count; k++)
                        {
                            if (!string.IsNullOrEmpty(gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString()))
                            {
                                int result = 0;
                                if (!int.TryParse(gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString(), out result) && !gv_SYXX.Columns[k].FieldName.Contains("备注"))
                                {
                                    if (!gv_SYXX.Columns[k].FieldName.Contains("备注"))
                                    {
                                        failNum++;
                                        MessageBox.Show(gv_SYXX.Columns[k].FieldName + " 数量只能填写整数！");
                                        break;
                                    }
                                }
                                else
                                {

                                    string SampId = bllTqbSampling.GetSampId(gv_SYXX.Columns[k].FieldName, "技术中心");

                                    //if (gv_SYXX.Columns[k].FieldName.Contains("备注"))
                                    //{
                                    //    continue;
                                    //}

                                    samp_num++;

                                    SQLStringList.Add("insert into tqc_present_samples_name(C_PRESENT_SAMPLES_ID,C_SAMPLES_ID,N_SAM_NUM,C_EMP_ID) values('" + dr["取样主表主键"].ToString() + "','" + SampId + "','" + gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString() + "','" + userID + "') ");

                                    //if (gv_SYXX.Columns[k].FieldName == "冷镦试验" || gv_SYXX.Columns[k].FieldName == "酸洗检验")
                                    //{
                                    //    if (Convert.ToInt32(gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString()) > num_temp)
                                    //    {
                                    //        num_temp = Convert.ToInt32(gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString());
                                    //    }
                                    //}
                                    //else
                                    //{
                                    //    Num += Convert.ToInt32(gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString());
                                    //}

                                }
                            }
                        }

                        if (samp_num == 0)
                        {
                            failNum++;
                            MessageBox.Show(dr["批号"] + "第" + dr["钩号"] + "钩取样明细为空，不能保存！");
                            break;
                        }

                        if (failNum > 0)
                        {
                            break;
                        }
                        else
                        {
                            //int sum = Convert.ToInt32(gv_SYXX.GetRowCellValue(selectedHandle, "取样数量").ToString());

                            //if (sum != (Num + num_temp))
                            //{
                            //    failSum++;
                            //    MessageBox.Show("取样数量明细和总数量不对应，无法接收！");
                            //    break;
                            //}
                            //else
                            {
                                SQLStringList.Add("update tqc_present_samples_jszx set N_ENTRUST_TYPE=1 where C_ID='" + dr["取样主表主键"].ToString() + "' ");
                            }
                        }
                    }

                    if (failNum > 0)
                    {
                        return;
                    }

                    //if (failSum == 0)
                    {
                        if (bllTqcPresentSamplesName.SaveSamp(SQLStringList))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "向技术中心提交送样信息");//添加操作日志

                            MessageBox.Show("成功保存送样信息！");
                            BindJYXX();
                            BindZYXX();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("请选择需要保存的送样信息！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询已送样信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_ZY_CG_Click(object sender, EventArgs e)
        {
            try
            {
                BindZYXX();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定送样信息
        /// </summary>
        private void BindZYXX()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bllTqcPresentSamplesName.Get_List_JSZX(txt_BatchNo_CG.Text.Trim(), dt_SY_Start.Text.Trim(), dt_SY_End.Text.Trim(), "2").Tables[0];

                gc_ZYXX.DataSource = dt;
                gv_ZYXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZYXX);

                for (int i = 0; i < 14; i++)
                {
                    gv_ZYXX.Columns[i].OptionsColumn.AllowEdit = false;
                }

                gv_ZYXX.Columns[0].Visible = false;
                gv_ZYXX.Columns[8].Visible = false;
                gv_ZYXX.Columns[9].Visible = false;
                gv_ZYXX.Columns[12].Visible = false;
                gv_ZYXX.Columns[13].Visible = false;

                //冻结有焦点的列
                gv_ZYXX.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_ZYXX.Columns[2].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_ZYXX.Columns[3].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_ZYXX.Columns[4].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;

                gv_ZYXX.OptionsSelection.MultiSelect = true;
                gv_ZYXX.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

                WaitingFrom.CloseWait();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 送样
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SY_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = RV.UI.UserInfo.userID;

                int[] rownumber = gv_SYXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    ArrayList SQLStringList = new ArrayList();

                    bool flag = true;

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        string strID = gv_SYXX.GetRowCellValue(selectedHandle, "取样主表主键").ToString();

                        int count = bllTqcPresentSamplesJszx.Get_Count(strID, "0");

                        if (count > 0)
                        {
                            flag = false;
                            MessageBox.Show("批号：" + gv_SYXX.GetRowCellValue(selectedHandle, "批号").ToString() + " 钩号：" + gv_SYXX.GetRowCellValue(selectedHandle, "钩号").ToString() + " 的检验明细未保存，不能执行送样操作！");
                            break;
                        }

                        SQLStringList.Add(" update tqc_present_samples_jszx set N_ENTRUST_TYPE=2,C_EMP_ID_JS='" + userID + "',D_MOD_DT_JS=SYSDATE where C_ID='" + strID + "' ");
                    }

                    if (flag)
                    {
                        if (bllTqcPresentSamplesName.SaveSamp(SQLStringList))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "技术中心提交送样信息");//添加操作日志

                            MessageBox.Show("操作成功！");
                            BindJYXX();
                            BindZYXX();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要操作的信息！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_SYXX_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //DataRow dr = gv_SYXX.GetDataRow(e.RowHandle);

            //if (dr != null)
            //{
            //    DataRow[] arrRows = dt_sampling.Select("C_SAMPLING_NAME = '" + e.Column.FieldName + "' and 执行标准='" + dr["执行标准"].ToString() + "' and 钢种='" + dr["钢种"].ToString() + "' ");

            //    if (arrRows.Length > 0)
            //    {
            //        if (string.IsNullOrEmpty(e.CellValue.ToString()))
            //        {
            //            gv_SYXX.SetRowCellValue(e.RowHandle, e.Column.FieldName, "1");
            //        }
            //        e.Appearance.BackColor = Color.Yellow;
            //    }

            //}
        }

        /// <summary>
        /// 取消送样
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = RV.UI.UserInfo.userID;

                int[] rownumber = gv_ZYXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    ArrayList SQLStringList = new ArrayList();

                    bool flag = true;

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        string strID = gv_ZYXX.GetRowCellValue(selectedHandle, "取样主表主键").ToString();

                        int count = bllTqcPresentSamplesJszx.Get_Count(strID, "3");

                        if (count > 0)
                        {
                            flag = false;
                            MessageBox.Show("批号：" + gv_ZYXX.GetRowCellValue(selectedHandle, "批号").ToString() + " 钩号：" + gv_ZYXX.GetRowCellValue(selectedHandle, "钩号").ToString() + " 技术中心已接收，不能取消送样！");
                            break;
                        }

                        SQLStringList.Add(" update tqc_present_samples_jszx set N_ENTRUST_TYPE=1,C_EMP_ID_JS='',D_MOD_DT_JS=null where C_ID='" + strID + "' ");
                    }

                    if (flag)
                    {
                        if (bllTqcPresentSamplesName.SaveSamp(SQLStringList))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "技术中心提交送样信息");//添加操作日志

                            MessageBox.Show("操作成功！");
                            BindJYXX();
                            BindZYXX();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要操作的信息！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Match_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtMain == null)
                    return;

                WaitingFrom.ShowWait("正在根据模板匹配取样信息...");

                DataTable dt = bllTqcPresentSamplesName.Get_Model_List_JSZX("", "").Tables[0];

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
                            //if (dtMain.Rows[i]["取样数量"].ToString() == rows[mm]["取样数量"].ToString())
                            {
                                for (int kk = 14; kk < dtMain.Columns.Count; kk++)
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
                            //else
                            //{
                            //    DataRow dr = dt_Error.NewRow();
                            //    dr["Error"] = "批号" + dtMain.Rows[i]["批号"].ToString() + "的取样信息与模板不一致，请核对数据！";
                            //    dt_Error.Rows.Add(dr);
                            //}
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
