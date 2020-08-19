using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MODEL;
using BLL;
using XGCAP.UI.Q.QB;
using Common;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_CCSYGL : Form
    {
        private string strMenuName;

        public FrmQC_CCSYGL()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_SPOT_CHECK bll_spot_check = new Bll_TRC_ROLL_SPOT_CHECK();
        Bll_TRC_ROLL_SPOT_CHECK_NAME bllTrcRollSpotCheckName = new Bll_TRC_ROLL_SPOT_CHECK_NAME();
        Bll_TQB_SAMPLING bllTqbSampling = new Bll_TQB_SAMPLING();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC011_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 线材实绩信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
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

        private void NewMethod()
        {
            string batch = txt_BatchNo.Text;
            DataTable dt = bll_spot_check.GetList_Query(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), batch).Tables[0];
            this.gc_SJXX.DataSource = dt;
            gv_SJXX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_SJXX);
        }

        /// <summary>
        /// 线材抽查信息添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Std.Text.Trim()))
            {
                MessageBox.Show("执行标准不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(txt_Grd.Text.Trim()))
            {
                MessageBox.Show("钢种不能为空！");
                return;
            }
            try
            {
                Mod_TRC_ROLL_SPOT_CHECK mod = new Mod_TRC_ROLL_SPOT_CHECK();
                mod.C_STOVE = txt_LH.Text.Trim();
                mod.C_BATCH_NO = txt_PH.Text.Trim();
                mod.C_TICK_NO = txt_GH.Text.Trim();
                mod.C_STD_CODE = txt_Std.Text.Trim();
                mod.C_STL_GRD = txt_Grd.Text.Trim();
                mod.C_SPEC = txt_Spec.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STOVE", mod.C_STOVE);
                ht.Add("C_BATCH_NO", mod.C_BATCH_NO);
                ht.Add("C_TICK_NO", mod.C_TICK_NO);
                ht.Add("C_STD_CODE", mod.C_STD_CODE);
                ht.Add("C_STL_GRD", mod.C_STL_GRD);
                ht.Add("C_SPEC", mod.C_SPEC);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TRC_ROLL_SPOT_CHECK", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (bll_spot_check.Add(mod))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加抽查送样信息");//添加操作日志

                    btn_Rest_Click(null, null);
                    btn_Query_Main_Click(null, null);
                    MessageBox.Show("添加成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 抽查送样子表查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Sam_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (this.rbtn_isty_wh.SelectedIndex == 0)//未委托 查询
                {
                    dt = bllTrcRollSpotCheckName.Get_List(txt_BatchNo_Sam.Text.Trim()).Tables[0];
                }
                else//已委托
                {
                    dt = bllTrcRollSpotCheckName.Get_List_Query(txt_BatchNo_Sam.Text.Trim()).Tables[0];
                }
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

                            if (!string.IsNullOrEmpty(dt.Rows[i]["取样名称"].ToString()))
                            {
                                dr[dt.Rows[i]["取样名称"].ToString()] = dt.Rows[i]["取样数量"].ToString();
                            }
                        }
                        else
                        {
                            if (   dt.Rows[i]["炉号"].ToString() == dt.Rows[i - 1]["炉号"].ToString() 
                                && dt.Rows[i]["批号"].ToString() == dt.Rows[i - 1]["批号"].ToString() 
                                && dt.Rows[i]["钩号"].ToString() == dt.Rows[i - 1]["钩号"].ToString() 
                                && dt.Rows[i]["钢种"].ToString() == dt.Rows[i - 1]["钢种"].ToString() 
                                && dt.Rows[i]["规格"].ToString() == dt.Rows[i - 1]["规格"].ToString())
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

                                if (!string.IsNullOrEmpty(dt.Rows[i]["取样名称"].ToString()))
                                {
                                    dr[dt.Rows[i]["取样名称"].ToString()] = dt.Rows[i]["取样数量"].ToString();
                                }
                            }
                        }

                    }

                    dtNew.Rows.Add(dr);
                    gc_SYXX.DataSource = dtNew;
                    gv_SYXX.BestFitColumns();
                    SetGridViewRowNum.SetRowNum(gv_SYXX);
                    gv_SYXX.Columns[0].Visible = false;
                    gv_SYXX.OptionsSelection.MultiSelect = true;
                    gv_SYXX.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                }
                else
                {
                    gc_SYXX.DataSource = null;
                    gv_SYXX.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 添加送样
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TJSY_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        string strID = gv_SJXX.GetRowCellValue(selectedHandle, "C_ID").ToString();
                        Mod_TRC_ROLL_SPOT_CHECK modProduct = bll_spot_check.GetModel(strID);
                        modProduct.N_ENTRUST_TYPE = 0;
                        modProduct.C_EMP_ID = RV.UI.UserInfo.userID;
                        bll_spot_check.Update(modProduct);
                    }

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "生成抽查送样信息");//添加操作日志

                    MessageBox.Show("添加成功！");
                    btn_Query_Main_Click(null, null);
                    btn_Query_Sam_Click(null, null);
                }
                else
                {
                    MessageBox.Show("请选择送样的实绩！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 保存送样
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BCSY_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = RV.UI.UserInfo.userID;

                int[] rownumber = gv_SYXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    ArrayList SQLStringList = new ArrayList();

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        string strID = gv_SYXX.GetRowCellValue(selectedHandle, "主键").ToString();
                        DataTable dt = bll_spot_check.GetList_ID(strID).Tables[0];
                        if (Convert.ToInt32(dt.Rows[0]["N_ENTRUST_TYPE"]) == 1)
                        {
                            MessageBox.Show("送样实绩已委托，不能修改！");
                            return;
                        }
                        if (bllTrcRollSpotCheckName.Delete(strID))
                        {
                            MessageBox.Show("保存失败！");
                            return;
                        }

                        for (int k = 7; k < gv_SYXX.Columns.Count; k++)
                        {
                            if (gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString() != "")
                            {
                                SQLStringList.Add("insert into TRC_ROLL_SPOT_CHECK_NAME(C_ROLL_SPOT_CHECK_ID,C_SAMPLES_NAME,N_SAM_NUM,C_EMP_ID) values('" + strID + "','" + gv_SYXX.Columns[k].FieldName + "','" + gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString() + "','" + userID + "') ");
                            }
                        }

                    }

                    if (bllTrcRollSpotCheckName.SaveSamp(SQLStringList))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "保存抽查送样信息");//添加操作日志

                        MessageBox.Show("保存成功！");
                        btn_Query_Sam_Click(null, null);
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
        /// 提交委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TJWT_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = RV.UI.UserInfo.userID;
                DateTime dtTime = RV.UI.ServerTime.timeNow();

                int[] rownumber = gv_SYXX.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length > 0)
                {
                    ArrayList SQLStringList = new ArrayList();

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];

                        string strID = gv_SYXX.GetRowCellValue(selectedHandle, "主键").ToString();
                        DataTable dt = bll_spot_check.GetList_ID(strID).Tables[0];
                        if (Convert.ToInt32(dt.Rows[0]["N_ENTRUST_TYPE"]) == 1)
                        {
                            MessageBox.Show("重复委托！");
                            return;
                        }

                        for (int k = 6; k < gv_SYXX.Columns.Count; k++)
                        {
                            if (gv_SYXX.GetRowCellValue(selectedHandle, gv_SYXX.Columns[k].FieldName).ToString() != "")
                            {
                                SQLStringList.Add("update TRC_ROLL_SPOT_CHECK set N_ENTRUST_TYPE=1,C_EMP_ID='" + userID + "',D_MOD_DT=SYSDATE where C_ID='" + strID + "' ");
                            }
                        }

                    }

                    if (bllTrcRollSpotCheckName.SaveSamp(SQLStringList))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "委托送样信息");//添加操作日志

                        MessageBox.Show("保存成功！");
                        btn_Query_Sam_Click(null, null);
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
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要删除的数据！");
                }
                DialogResult dialogResult = MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {

                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        string strID = gv_SJXX.GetRowCellValue(selectedHandle, "C_ID").ToString();
                        bll_spot_check.Delete(strID);
                    }
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除抽查送样信息");//添加操作日志
                    NewMethod();
                    btn_Rest_Click(null, null);
                    MessageBox.Show("删除成功！");

                }
                else//如果点击“取消”按钮
                {
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
