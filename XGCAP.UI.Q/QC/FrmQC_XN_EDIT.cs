﻿using System;
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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_XN_EDIT : Form
    {
        private Bll_TQC_PHYSICS_RESULT bllTqcPhysicsResult = new Bll_TQC_PHYSICS_RESULT();
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        private Bll_TQC_PHYSICS_RESULT_MAIN bllTqcPhyResultMain = new Bll_TQC_PHYSICS_RESULT_MAIN();
        private Bll_TQB_PHYSICS_QUALITATIVE bllTqbPhysicsQualitative = new Bll_TQB_PHYSICS_QUALITATIVE();
        private Bll_TQB_PHYSICS_EQUIPMENT bll_TQB_PHYSICS_EQUIPMENT = new Bll_TQB_PHYSICS_EQUIPMENT();//实验室设备
        private Bll_TQB_PHYSICS_GROUP blltqbPhysicsGroup = new Bll_TQB_PHYSICS_GROUP();//物理检验项目分组维护
        private Bll_TQB_DESIGN_ITEM bllTqbDesignItem = new Bll_TQB_DESIGN_ITEM();
        Bll_TQB_PHYSICS_GROUP bll_group = new Bll_TQB_PHYSICS_GROUP();

        private Bll_TQB_XN_CHECK_USER bllTqbXnCheckUser = new Bll_TQB_XN_CHECK_USER();

        private List<Mod_TQB_DESIGN_ITEM> lstDesignItem;

        private string strMenuName;

        private DataTable dtDX;

        private string str_PHYSICS_GROUP_ID;
        private string strPhyCode;
        private string strCheckState;
        private string strName;
        private string str_Spec = "";

        public FrmQC_XN_EDIT()
        {
            InitializeComponent();
        }

        private void FrmQC_XN_EDIT_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;
                strName = RV.UI.QueryString.parameter;
                lstDesignItem = new List<Mod_TQB_DESIGN_ITEM>();

                dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

                dt_Start_Result.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dt_End_Result.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

                DataSet ds = bll_group.GetList("");
                imgcbo_Name.Properties.Items.Clear();
                foreach (DataRow item in ds.Tables[0].Rows)//性能名称下拉框绑定
                {
                    imgcbo_Name.Properties.Items.Add(item["C_NAME"].ToString(), item["C_ID"], -1);
                }

                //审核人下拉框信息
                DataTable dtUser = bllTqbXnCheckUser.Get_List("质控部").Tables[0];

                icbo_User.Properties.Items.Add("", "", -1);

                if (dtUser.Rows.Count > 0)
                {
                    for (int i = 0; i < dtUser.Rows.Count; i++)
                    {
                        icbo_User.Properties.Items.Add(dtUser.Rows[i]["C_USER_NAME"].ToString(), dtUser.Rows[i]["C_USER_NAME"].ToString(), -1);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                BindZYXX();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定制样主表信息
        /// </summary>
        private void BindZYXX()
        {
            WaitingFrom.ShowWait("");

            gc_ZYXX.DataSource = null;

            DataTable dt = bllTqcPhysicsResult.Get_XN_List(dt_Start.Text.Trim(), dt_End.Text.Trim(), txt_BatchNo.Text.Trim(), strName).Tables[0];

            gc_ZYXX.DataSource = dt;

            gv_ZYXX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ZYXX);

            gv_ZYXX.Columns[12].Caption = "录入人";
            gv_ZYXX.Columns[0].Visible = false;
            gv_ZYXX.Columns[1].Visible = false;
            gv_ZYXX.Columns[2].Visible = false;

            WaitingFrom.CloseWait();
        }

        private void gv_ZYXX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_ZYXX.GetDataRow(e.FocusedRowHandle);
            if (dr != null)
            {
                lstDesignItem = bllTqbDesignItem.DataTableToList(bllTqbDesignItem.GetList(dr["执行标准"].ToString(), dr["钢种"].ToString()).Tables[0]);

                str_PHYSICS_GROUP_ID = dr["性能主键"].ToString();
                strPhyCode = dr["性能代码"].ToString();
                //strCheckState = dr["检验状态"].ToString() == "初检" ? "0" : "1";
                strCheckState = "";

                str_Spec = dr["规格"].ToString();

                BindInfo();

                BindItem(dr["取样主表主键"].ToString());

                txt_Batch_Result.Text = dr["批号"].ToString();
                imgcbo_Name.EditValue = dr["性能主键"].ToString();

                BindResult();
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
            WaitingFrom.ShowWait("");

            gc_Result.DataSource = null;
            gv_Result.Columns.Clear();

            DataTable dt = bllTqcPhysicsResult.Get_Log_List(strPhyCode, txt_Batch_Result.Text.Trim(), dt_Start_Result.Text.Trim(), dt_End_Result.Text.Trim(), strCheckState).Tables["ds"];

            gc_Result.DataSource = dt;
            gv_Result.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Result);

            if (dt != null && dt.Rows.Count > 0 && gv_Result.Columns.Count > 0)
            {
                gv_Result.Columns[9].Caption = "修改时间";
                gv_Result.Columns[10].Caption = "录入人";
                gv_Result.Columns[0].Visible = false;
                gv_Result.Columns[8].Visible = false;

                //冻结有焦点的列
                gv_Result.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_Result.Columns[2].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_Result.Columns[3].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_Result.Columns[4].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_Result.Columns[5].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            }

            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 保存性能录入结果信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_ZYXX.GetDataRow(gv_ZYXX.FocusedRowHandle);

                if (dr != null)
                {
                    WaitingFrom.ShowWait("");

                    string strPD = dr["判定状态"].ToString();

                    if (strPD == "未判")
                    {
                        MessageBox.Show("未判定的数据不能修改！");
                        return;
                    }

                    DataTable dt_Result = ((DataView)gv_ITEM.DataSource).ToTable();

                    string userID = RV.UI.UserInfo.userID;

                    string result = bllTqcPhysicsResult.Edit_Result(dr, dt_Result, str_PHYSICS_GROUP_ID, cbo_SB.Text, txt_WD.Text.Trim(), txt_SD.Text.Trim(), icbo_BC.Text.ToString(), icbo_BZ.Text.ToString(), icbo_User.Text.Trim());

                    if (result == "1")
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "保存性能信息");//添加操作日志

                        MessageBox.Show("保存成功！");
                        BindZYXX();
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }

                    WaitingFrom.CloseWait();
                }
                else
                {
                    MessageBox.Show("选择要保存的数据！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindInfo()
        {
            DataTable dt_name = bll_TQB_PHYSICS_EQUIPMENT.GetList_Fid(str_PHYSICS_GROUP_ID).Tables[0];

            cbo_SB.Properties.Items.Clear();
            foreach (DataRow item in dt_name.Rows)//设备名称
            {
                cbo_SB.Properties.Items.Add(item["C_EQ_NAME"].ToString());
            }

            dtDX = bllTqbPhysicsQualitative.Get_List(str_PHYSICS_GROUP_ID).Tables[0];
        }

        private void BindItem(string str_id)
        {
            DataTable dt = bllTqcPhysicsResult.Get_XNList(strPhyCode, str_id).Tables[0];

            gc_ITEM.DataSource = dt;

            SetGridViewRowNum.SetRowNum(gv_ITEM);

            Mod_TQC_PHYSICS_RESULT_MAIN mod = bllTqcPhyResultMain.GetModel(str_id);
            if (mod != null)
            {
                cbo_SB.Text = mod.C_EQ_NAME;

                if (!string.IsNullOrEmpty(mod.C_TEMP))
                {
                    txt_WD.Text = mod.C_TEMP;
                }

                if (!string.IsNullOrEmpty(mod.C_HUMIDITY))
                {
                    txt_SD.Text = mod.C_HUMIDITY;
                }

                if (!string.IsNullOrEmpty(mod.C_BC))
                {
                    icbo_BC.Text = mod.C_BC;
                }

                if (!string.IsNullOrEmpty(mod.C_BZ))
                {
                    icbo_BZ.Text = mod.C_BZ;
                }

                if (!string.IsNullOrEmpty(mod.C_CHECK_USER))
                {
                    icbo_User.Text = mod.C_CHECK_USER;
                }
                else
                {
                    icbo_User.Text = "";
                }
            }
        }

        private void gv_ITEM_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                string fieldName = e.Column.FieldName;
                DataRow dr = gv_ITEM.GetDataRow(e.RowHandle);

                if (dr != null)
                {
                    string strValue = dr["C_CHARACTER_ID"].ToString();

                    if (fieldName == "C_VALUE")
                    {
                        DataRow[] rows = dtDX.Select("C_CHARACTER_ID='" + strValue + "'");

                        if (rows.Length > 0)
                        {
                            DevExpress.XtraEditors.Repository.RepositoryItemComboBox resCbo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();

                            resCbo.Name = "resCbo_" + strValue;
                            resCbo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

                            foreach (var item in rows)
                            {
                                resCbo.Items.Add(item["C_RESULT"].ToString());
                            }

                            e.RepositoryItem = resCbo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void gv_ITEM_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                DataRow dr = gv_ITEM.GetDataRow(e.RowHandle);

                if (dr != null)
                {
                    var lst = lstDesignItem.Where(x => x.C_CHARACTER_ID == dr["C_CHARACTER_ID"].ToString()).ToList();

                    if (lst.Count > 0)
                    {
                        e.Appearance.BackColor = Color.LightGreen;
                    }

                    if (!string.IsNullOrEmpty(dr["C_VALUE"].ToString()))
                    {
                        //var lst = lstDesignItem.Where(x => x.C_CHARACTER_ID == dr["C_CHARACTER_ID"].ToString()).ToList();

                        for (int i = 0; i < lst.Count; i++)
                        {
                            if (lst[i].C_QUANTITATIVE == "定量")
                            {
                                double dValue = Convert.ToDouble(dr["C_VALUE"].ToString());

                                bool IsFind = false;

                                if (string.IsNullOrEmpty(lst[i].C_SPEC_INTERVAL))
                                {
                                    IsFind = true;
                                }
                                else
                                {
                                    decimal dSpec = Convert.ToDecimal(str_Spec.Substring(1));

                                    if (lst[i].C_SPEC_INTERVAL == "≤E≤")
                                    {
                                        if (dSpec >= lst[i].N_SPEC_MIN || dSpec <= lst[i].N_SPEC_MAX)
                                        {
                                            IsFind = true;
                                        }
                                    }
                                    else if (lst[i].C_SPEC_INTERVAL == "≤E")
                                    {
                                        if (dSpec >= lst[i].N_SPEC_MIN)
                                        {
                                            IsFind = true;
                                        }
                                    }
                                    else if (lst[i].C_SPEC_INTERVAL == "E≤")
                                    {
                                        if (dSpec <= lst[i].N_SPEC_MAX)
                                        {
                                            IsFind = true;
                                        }
                                    }

                                }

                                if (IsFind)
                                {
                                    if (dValue.ToString() == lst[0].C_TARGET_MIN || dValue.ToString() == lst[0].C_TARGET_MAX)
                                    {
                                        e.Appearance.BackColor = Color.Yellow;
                                    }
                                    else
                                    {
                                        if (lst[0].C_TARGET_INTERVAL == "≤E≤")
                                        {
                                            if (dValue < Convert.ToDouble(lst[0].C_TARGET_MIN) || dValue > Convert.ToDouble(lst[0].C_TARGET_MAX))
                                            {
                                                e.Appearance.BackColor = Color.Red;
                                            }
                                        }
                                        else if (lst[0].C_TARGET_INTERVAL == "≤E")
                                        {
                                            if (dValue < Convert.ToDouble(lst[0].C_TARGET_MIN))
                                            {
                                                e.Appearance.BackColor = Color.Red;
                                            }
                                        }
                                        else if (lst[0].C_TARGET_INTERVAL == "E≤")
                                        {
                                            if (dValue > Convert.ToDouble(lst[0].C_TARGET_MAX))
                                            {
                                                e.Appearance.BackColor = Color.Red;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void imgcbo_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            strPhyCode = bll_group.Get_Code(imgcbo_Name.EditValue.ToString());

            strCheckState = "";
        }


        private bool IsChange = true;

        private void gv_ITEM_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (IsChange)
                {
                    if (strPhyCode == "R03" || strPhyCode == "R23")
                    {
                        double ls_11 = 0;//原始直径d(1-1)
                        double ls_12 = 0;//原始直径d(1-2)
                        double ls_21 = 0;//原始直径d(2-1)
                        double ls_22 = 0;//原始直径d(2-2)
                        double ls_31 = 0;//原始直径d(3-1)
                        double ls_32 = 0;//原始直径d(3-2)
                        double ls_41 = 0;//断后直径d(mm)(1)
                        double ls_42 = 0;//断后直径d(mm)(2)
                        double ls_ave1 = 0;//原始直径平均1
                        double ls_ave2 = 0;//原始直径平均2
                        double ls_ave3 = 0;//原始直径平均3
                        double ls_ave4 = 0;//断后直径d(mm)(平均值)
                        double ls_ave = 0;//原始直径d(平均)

                        for (int i = 0; i < gv_ITEM.DataRowCount; i++)
                        {
                            if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "原始直径d(1-1)")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    ls_11 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "原始直径d(1-2)")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    ls_12 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "原始直径d(2-1)")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    ls_21 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "原始直径d(2-2)")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    ls_22 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "原始直径d(3-1)")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    ls_31 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "原始直径d(3-2)")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    ls_32 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "断后直径d(mm)(1)")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    ls_41 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "断后直径d(mm)(2)")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    ls_42 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }

                            if (ls_11 != 0 || ls_12 != 0)
                            {
                                ls_ave1 = Math.Round((ls_11 + ls_12) / 2, 2);
                            }

                            if (ls_21 != 0 || ls_22 != 0)
                            {
                                ls_ave2 = Math.Round((ls_21 + ls_22) / 2, 2);
                            }

                            if (ls_31 != 0 || ls_32 != 0)
                            {
                                ls_ave3 = Math.Round((ls_31 + ls_32) / 2, 2);
                            }

                            if (ls_41 != 0 || ls_42 != 0)
                            {
                                ls_ave4 = Math.Round((ls_41 + ls_42) / 2, 2);
                            }

                            if (ls_ave1 != 0 || ls_ave2 != 0 || ls_ave3 != 0)
                            {
                                ls_ave = Math.Round((ls_ave1 + ls_ave2 + ls_ave3) / 3, 2);
                            }


                            if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "原始直径d(1平均)")
                            {
                                if (ls_ave1 != 0)
                                {
                                    IsChange = false;

                                    gv_ITEM.SetRowCellValue(i, "C_VALUE", ls_ave1.ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "原始直径d(2平均)")
                            {
                                if (ls_ave2 != 0)
                                {
                                    IsChange = false;

                                    gv_ITEM.SetRowCellValue(i, "C_VALUE", ls_ave2);
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "原始直径d(3平均)")
                            {
                                if (ls_ave3 != 0)
                                {
                                    IsChange = false;

                                    gv_ITEM.SetRowCellValue(i, "C_VALUE", ls_ave3);
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "原始直径d(平均)")
                            {
                                if (ls_ave != 0)
                                {
                                    IsChange = false;

                                    gv_ITEM.SetRowCellValue(i, "C_VALUE", ls_ave);
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "断后直径d(mm)(平均值)")
                            {
                                if (ls_ave4 != 0)
                                {
                                    IsChange = false;

                                    gv_ITEM.SetRowCellValue(i, "C_VALUE", ls_ave4);
                                }
                            }
                        }
                    }
                    else if (strPhyCode == "R05")
                    {
                        double yd_11 = 0;//压痕直径mm(1)
                        double yd_12 = 0;//压痕直径mm(2)
                        double yd_21 = 0;//(硬度/HRB)1
                        double yd_22 = 0;//(硬度/HRB)2
                        double yd_23 = 0;//(硬度/HRB)3
                        double ydx_21 = 0;//(心部硬度)1
                        double ydx_22 = 0;//(心部硬度)2
                        double ydx_23 = 0;//(心部硬度)3
                        double yd_ave1 = 0;//压痕直径mm(平均值)
                        double yd_ave2 = 0;//硬度/HRB
                        double ydx_ave = 0;//心部硬度

                        for (int i = 0; i < gv_ITEM.DataRowCount; i++)
                        {
                            if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "压痕直径mm(1)")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    yd_11 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "压痕直径mm(2)")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    yd_12 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "(硬度/HRB)1")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    yd_21 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "(硬度/HRB)2")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    yd_22 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "(硬度/HRB)3")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    yd_23 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "(心部硬度)1")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    ydx_21 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "(心部硬度)2")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    ydx_22 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "(心部硬度)3")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    ydx_23 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }

                            if (yd_11 != 0 || yd_12 != 0)
                            {
                                yd_ave1 = Math.Round((yd_11 + yd_12) / 2, 2);
                            }

                            if (yd_21 != 0 || yd_22 != 0 || yd_23 != 0)
                            {
                                yd_ave2 = Math.Round((yd_21 + yd_22 + yd_23) / 3, 1);
                            }

                            if (ydx_21 != 0 || ydx_22 != 0 || ydx_23 != 0)
                            {
                                ydx_ave = Math.Round((ydx_21 + ydx_22 + ydx_23) / 3, 1);
                            }

                            if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "压痕直径mm(平均值)")
                            {
                                if (yd_ave1 != 0)
                                {
                                    IsChange = false;

                                    gv_ITEM.SetRowCellValue(i, "C_VALUE", yd_ave1.ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "硬度/HRB")
                            {
                                if (yd_ave2 != 0)
                                {
                                    IsChange = false;

                                    gv_ITEM.SetRowCellValue(i, "C_VALUE", yd_ave2);
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "心部硬度")
                            {
                                if (ydx_ave != 0)
                                {
                                    IsChange = false;

                                    gv_ITEM.SetRowCellValue(i, "C_VALUE", ydx_ave);
                                }
                            }
                        }
                    }
                    else if (strPhyCode == "R11")
                    {
                        double dd_11 = 0;//实测直径1
                        double dd_12 = 0;//实测直径2
                        double dd_13 = 0;//实测直径3
                        double dd_14 = 0;//实测直径4
                        double dd_15 = 0;//实测直径5
                        double dz_11 = 0;//Rt电阻(10-3Ω)1
                        double dz_12 = 0;//Rt电阻(10-3Ω)2
                        double dz_13 = 0;//Rt电阻(10-3Ω)3
                        double dz_ave = 0;//Rt电阻(10-3Ω)平均值
                        double dd_ave = 0;//实测平均直径(mm)

                        for (int i = 0; i < gv_ITEM.DataRowCount; i++)
                        {
                            if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "实测直径1")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    dd_11 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "实测直径2")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    dd_12 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "实测直径3")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    dd_13 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "实测直径4")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    dd_14 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "实测直径5")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    dd_15 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "Rt电阻(10-3Ω)1")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    dz_11 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "Rt电阻(10-3Ω)2")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    dz_12 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "Rt电阻(10-3Ω)3")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    dz_13 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }

                            if (dd_11 != 0 || dd_12 != 0 || dd_13 != 0 || dd_14 != 0 || dd_15 != 0)
                            {
                                dd_ave = Math.Round((dd_11 + dd_12 + dd_13 + dd_14 + dd_15) / 5, 2);
                            }

                            if (dz_11 != 0 || dz_12 != 0 || dz_13 != 0)
                            {
                                dz_ave = Math.Round((dz_11 + dz_12 + dz_13) / 3, 2);
                            }

                            if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "实测平均直径(mm)")
                            {
                                if (dd_ave != 0)
                                {
                                    IsChange = false;

                                    gv_ITEM.SetRowCellValue(i, "C_VALUE", dd_ave.ToString());
                                }
                            }

                            if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "Rt电阻(10-3Ω)平均值")
                            {
                                if (dd_ave != 0)
                                {
                                    IsChange = false;

                                    gv_ITEM.SetRowCellValue(i, "C_VALUE", dz_ave.ToString());
                                }
                            }

                        }
                    }
                    else if (strPhyCode == "R22")
                    {
                        double dmd_11 = 0;//(末端淬透性试验J7(HRC))正面
                        double dmd_12 = 0;//(末端淬透性试验J7(HRC))背面
                        double dmd_ave = 0;//末端淬透性试验J7(HRC)

                        for (int i = 0; i < gv_ITEM.DataRowCount; i++)
                        {
                            if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "(末端淬透性试验J7(HRC))正面")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    dmd_11 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }
                            else if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "(末端淬透性试验J7(HRC))背面")
                            {
                                if (!string.IsNullOrEmpty(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString()))
                                {
                                    dmd_12 = Convert.ToDouble(gv_ITEM.GetRowCellValue(i, "C_VALUE").ToString());
                                }
                            }

                            if (dmd_11 != 0 || dmd_12 != 0)
                            {
                                dmd_ave = Math.Round((dmd_11 + dmd_12) / 2, 1);
                            }

                            if (gv_ITEM.GetRowCellValue(i, "C_NAME").ToString() == "末端淬透性试验J7(HRC)")
                            {
                                if (dmd_ave != 0)
                                {
                                    IsChange = false;

                                    gv_ITEM.SetRowCellValue(i, "C_VALUE", dmd_ave.ToString());
                                }
                            }

                        }
                    }
                }
                else
                {
                    IsChange = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
