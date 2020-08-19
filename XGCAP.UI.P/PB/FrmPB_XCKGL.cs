using Common;
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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_XCKGL : Form
    {
        private BLL.Bll_TPB_LINEWH bll_TPB_LINEWH = new BLL.Bll_TPB_LINEWH();//线材仓库信息
        private BLL.Bll_TPB_LINEWH_AREA bll_TPB_LINEWH_AREA = new BLL.Bll_TPB_LINEWH_AREA();//线材库区域信息
        private BLL.Bll_TPB_LINEWH_LOC bll_TPB_LINEWH_LOC = new BLL.Bll_TPB_LINEWH_LOC();//线材库库位信息

        private string strMenuName;

        public FrmPB_XCKGL()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPB_XCKGL_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;

                //重置ID值
                this.lbl_WHID.Text = "";
                this.lbl_Area_ID.Text = "";
                this.lbl_LOC_ID.Text = "";
                BindXCCK();//重新加载仓库信息
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        #region 仓库管理事件
        /// <summary>
        /// 添加编辑线材仓库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_LineWh_Code.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入仓库编码！");
                    this.txt_LineWh_Code.Focus();
                    return;
                }
                if (this.txt_LIineWh_Name.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入仓库描述！");
                    this.txt_LIineWh_Name.Focus();
                    return;
                }
                if (this.lbl_WHID.Text == "")
                {
                    if (DialogResult.No == MessageBox.Show("是否确认添加仓库信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }

                    Mod_TPB_LINEWH model = new Mod_TPB_LINEWH();
                    model.C_LINEWH_CODE = this.txt_LineWh_Code.Text.Trim();
                    model.C_LINEWH_NAME = this.txt_LIineWh_Name.Text.Trim();
                    model.C_REMARK = this.txt_Remark.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_LINEWH_CODE", model.C_LINEWH_CODE);
                    ht.Add("N_STATUS", 1);
                    if (Common.CheckRepeat.CheckTable("TPB_LINEWH", ht) > 0)
                    {
                        MessageBox.Show("已存在该仓库！");
                    }
                    else
                    {
                        string msg = bll_TPB_LINEWH.GetNCID(model.C_LINEWH_CODE);
                        if (msg == "")
                        {
                            MessageBox.Show("添加失败,NC不存在");
                            return;
                        }
                        bool res = bll_TPB_LINEWH.Add(model);
                        if (res)
                        {
                            string msg1 = bll_TPB_LINEWH.TBNCID(model.C_LINEWH_CODE, msg);
                            if (msg1 != "1")
                            {
                                MessageBox.Show("添加失败" + msg1);
                            }
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加线材仓库信息");//添加操作日志
                            MessageBox.Show("添加成功！");
                            BindXCCK();//重新加载仓库信息
                            btn_Reset_Click(null, null);//清空控件
                        }
                    }
                    #endregion

                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑仓库信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TPB_LINEWH model = bll_TPB_LINEWH.GetModel(this.lbl_WHID.Text);
                    model.C_LINEWH_CODE = this.txt_LineWh_Code.Text.Trim();
                    model.C_LINEWH_NAME = this.txt_LIineWh_Name.Text.Trim();
                    model.C_REMARK = this.txt_Remark.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();

                    bool res = bll_TPB_LINEWH.Update(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改线材仓库信息");//添加操作日志

                        MessageBox.Show("编辑成功！");
                        BindXCCK();//重新加载仓库信息
                        btn_Reset_Click(null, null);//清空控件
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_Click(object sender, EventArgs e)
        {
            try
            {
                BindXCCK();//重新加载仓库信息
                BindFocusedRowCK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 重置仓库编辑框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearPanelControl(this.panelControl1.Controls);
                this.lbl_WHID.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 仓库列表焦点行改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_line_wh_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                BindFocusedRowCK();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        /// <summary>
        /// 删除选中的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_line_wh.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int cannotNum = 0;//不能删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_line_wh.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_line_wh.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    //判断该仓库的区域是否已经全部删除
                    bool hasNoStopArea = bll_TPB_LINEWH_AREA.ExistsNOSotpByLineWH(strID);
                    if (hasNoStopArea == false)
                    {
                        bool update = bll_TPB_LINEWH.Delete(strID);
                        if (update)
                        {
                            commitNum = commitNum + 1;
                        }
                        else
                        {
                            failtNum = failtNum + 1;
                        }
                    }

                    else
                    {
                        MessageBox.Show("请先删除该区域下的所有区域！");
                        cannotNum = cannotNum + 1;
                    }


                }
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，删除" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除线材仓库信息");//添加操作日志

                BindXCCK();//重新加载仓库信息

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        #region 方法  

        /// <summary>
        /// 加载线材库信息
        /// </summary>
        public void BindXCCK()
        {
            DataTable dt = null;
            dt = bll_TPB_LINEWH.GetListByStatus(1).Tables[0];
            this.gc_line_wh.DataSource = dt;
            this.gv_line_wh.OptionsView.ColumnAutoWidth = false;
            this.gv_line_wh.OptionsSelection.MultiSelect = true;
            gv_line_wh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_line_wh.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_line_wh);
        }
        /// <summary>
        /// 根据仓库信息加载仓库区域信息
        /// </summary>
        /// <param name="strCKID">仓库主键</param>
        /// <param name="iStatus">状态0删除1启用</param>
        public void BindXCQU(string strCKID, int iStatus)
        {
            gc_line_area.DataSource = null;
            DataTable dt = null;
            if (strCKID.Trim() != "")
            {
                dt = bll_TPB_LINEWH_AREA.GetListByLineWHID(strCKID, iStatus).Tables[0];
            }
            this.gc_line_area.DataSource = dt;
            this.gv_line_area.OptionsView.ColumnAutoWidth = false;
            this.gv_line_area.OptionsSelection.MultiSelect = true;
            this.gv_line_area.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_line_area.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_line_area);

        }
        /// <summary>
        /// 获取仓库列表焦点行信息
        /// </summary>
        public void BindFocusedRowCK()
        {
            int selectedHandle = this.gv_line_wh.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                return;
            }
            this.lbl_WHID.Text = this.gv_line_wh.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到仓库对象，并在界面赋值
            Mod_TPB_LINEWH model = bll_TPB_LINEWH.GetModel(this.lbl_WHID.Text);
            this.txt_LineWh_Code.Text = model.C_LINEWH_CODE;
            this.txt_LIineWh_Name.Text = model.C_LINEWH_NAME;
            this.txt_Remark.Text = model.C_REMARK;

            //加载仓库区域信息
            BindXCQU(this.lbl_WHID.Text, 1);
        }


        /// <summary>
        /// 根据区域信息加载仓库库位信息
        /// </summary>
        /// <param name="strCKID">区域主键</param>
        public void BindXCKW(string strQYID, int iStatus)
        {
            gc_line_loc.DataSource = null;
            DataTable dt = null;
            if (strQYID != "")
            {
                dt = bll_TPB_LINEWH_LOC.GetListByArea(strQYID, iStatus).Tables[0];
            }

            this.gc_line_loc.DataSource = dt;
            this.gv_line_loc.OptionsView.ColumnAutoWidth = false;
            this.gv_line_loc.OptionsSelection.MultiSelect = true;
            this.gv_line_loc.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_line_loc.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_line_loc);

        }
        /// <summary>
        /// 焦点行变化时加载区域信息
        /// </summary>
        public void BindFoucedQY()
        {
            int selectedHandle = this.gv_line_area.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                btn_reset_area_Click(null, null);
                //加载仓库库位信息
                BindXCKW(this.lbl_Area_ID.Text, 1);
                return;
            }
            this.lbl_Area_ID.Text = this.gv_line_area.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到仓库对象，并在界面赋值
            Mod_TPB_LINEWH_AREA model = bll_TPB_LINEWH_AREA.GetModel(this.lbl_Area_ID.Text);
            this.txt_Area_Code.Text = model.C_LINEWH_AREA_CODE;
            this.txt_Area_Name.Text = model.C_LINEWH_AREA_NAME;
            this.txt_remark_area.Text = model.C_REMARK;
            this.txt_Area_Cap.Text = model.N_LINEWH_AREA_CAP.ToString();
            this.cbo_loading_mode.Text = model.C_LOADING_MODE;
            this.cbo_transport_mode.Text = model.C_TRANSPORT_MODE;
            if (model.C_ISOUT == "室内")
            {
                rbtn_isOUT.SelectedIndex = 1;
            }
            else
            {
                rbtn_isOUT.SelectedIndex = 0;
            }
            //加载仓库库位信息
            BindXCKW(this.lbl_Area_ID.Text, 1);
        }


        /// <summary>
        /// 焦点行变化时加载库位信息
        /// </summary>
        public void BindFoucedKW()
        {
            int selectedHandle = this.gv_line_loc.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                btn_reset_loc_Click(null, null);
                return;
            }
            this.lbl_LOC_ID.Text = this.gv_line_loc.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到仓库对象，并在界面赋值
            Mod_TPB_LINEWH_LOC model = bll_TPB_LINEWH_LOC.GetModel(this.lbl_LOC_ID.Text);
            this.txt_loc_code.Text = model.C_LINEWH_LOC_CODE;
            this.txt_loc_name.Text = model.C_LINEWH_LOC_NAME;
            this.txt_remark_loc.Text = model.C_REMARK;
        }
        #endregion

        #region 区域管理
        /// <summary>
        /// 保存区域信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_area_Click(object sender, EventArgs e)
        {
            try
            {
                string strWHID = "";
                int selectedHandle = this.gv_line_wh.FocusedRowHandle;//获取焦点行索引
                if (selectedHandle >= 0)
                {
                    strWHID = this.gv_line_wh.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
                }
                else
                {
                    MessageBox.Show("请先选择对应的仓库信息！");
                    return;
                }


                if (this.txt_Area_Code.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入区域编码！");
                    this.txt_Area_Code.Focus();
                    return;
                }
                if (this.txt_Area_Name.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入区域描述！");
                    this.txt_Area_Name.Focus();
                    return;
                }
                if (this.txt_Area_Cap.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入区域容量！");
                    this.txt_Area_Cap.Focus();
                    return;

                }
                if (this.cbo_transport_mode.Text == "")
                {
                    MessageBox.Show("请选择运输方式！");
                    this.cbo_transport_mode.Focus();
                    return;
                }
                if (this.cbo_loading_mode.Text == "")
                {
                    MessageBox.Show("请选择装车方式！");
                    this.cbo_loading_mode.Focus();
                    return;
                }
                if (this.lbl_Area_ID.Text == "")
                {
                    if (DialogResult.No == MessageBox.Show("是否确认添加区域信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TPB_LINEWH_AREA model = new Mod_TPB_LINEWH_AREA();
                    model.C_LINEWH_ID = strWHID;
                    model.C_LINEWH_AREA_CODE = this.txt_Area_Code.Text.Trim();
                    model.C_LINEWH_AREA_NAME = this.txt_Area_Name.Text.Trim();
                    model.C_REMARK = this.txt_remark_area.Text.Trim();
                    model.C_ISOUT = this.rbtn_isOUT.SelectedIndex == 0 ? "室外" : "室内";
                    model.N_LINEWH_AREA_CAP = Convert.ToDecimal(this.txt_Area_Cap.Text);
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.C_LOADING_MODE = this.cbo_loading_mode.Text.Trim();
                    model.C_TRANSPORT_MODE = this.cbo_transport_mode.Text.Trim();
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_LINEWH_AREA_CODE", model.C_LINEWH_AREA_CODE);
                    ht.Add("N_STATUS", 1);
                    if (Common.CheckRepeat.CheckTable("TPB_LINEWH_AREA", ht) > 0)
                    {
                        MessageBox.Show("已存在该区域编码！");
                    }
                    else
                    {
                        bool res = bll_TPB_LINEWH_AREA.Add(model);
                        if (res)
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加线材仓库区域信息");//添加操作日志

                            MessageBox.Show("添加成功！");
                            BindXCQU(strWHID, 1);//重新加载区域信息
                            btn_reset_area_Click(null, null);//清空控件
                        }
                    }
                    #endregion

                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑区域信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TPB_LINEWH_AREA model = bll_TPB_LINEWH_AREA.GetModel(this.lbl_Area_ID.Text);
                    model.C_LINEWH_AREA_CODE = this.txt_Area_Code.Text.Trim();
                    model.C_LINEWH_AREA_NAME = this.txt_Area_Name.Text.Trim();
                    model.C_REMARK = this.txt_remark_area.Text.Trim();
                    model.C_ISOUT = this.rbtn_isOUT.SelectedIndex == 0 ? "室外" : "室内";
                    model.N_LINEWH_AREA_CAP = Convert.ToDecimal(this.txt_Area_Cap.Text);
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.C_LOADING_MODE = this.cbo_loading_mode.Text.Trim();
                    model.C_TRANSPORT_MODE = this.cbo_transport_mode.Text.Trim();

                    bool res = bll_TPB_LINEWH_AREA.Update(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改线材仓库区域信息");//添加操作日志

                        MessageBox.Show("编辑成功！");
                        BindXCQU(strWHID, 1);//重新加载区域信息
                        btn_reset_area_Click(null, null);//清空控件
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 重置区域编辑控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_area_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearPanelControl(this.panelControl3.Controls);
                this.lbl_Area_ID.Text = "";
                this.rbtn_isOUT.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 删除选中的区域信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_area_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_line_area.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int cannotNum = 0;//不能删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_line_area.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_line_area.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    //判断该仓库的区域是否已经全部删除
                    bool hasNoStopLoc = bll_TPB_LINEWH_LOC.GetListByArea(strID, 1).Tables[0].Rows.Count == 0 ? true : false;
                    if (hasNoStopLoc)
                    {
                        Mod_TPB_LINEWH_AREA model = bll_TPB_LINEWH_AREA.GetModel(strID);
                        model.N_STATUS = 0;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        model.D_END_DATE = RV.UI.ServerTime.timeNow();
                        bool update = bll_TPB_LINEWH_AREA.Update(model);
                        if (update)
                        {
                            commitNum = commitNum + 1;
                        }
                        else
                        {
                            failtNum = failtNum + 1;
                        }
                    }

                    else
                    {
                        MessageBox.Show("请先删除该区域下的所有库位！");
                        cannotNum = cannotNum + 1;
                    }


                }
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，删除" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除线材仓库区域信息");//添加操作日志

                btn_query_area_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 区域列表焦点改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_line_area_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                BindFoucedQY();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 查询区域信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_area_Click(object sender, EventArgs e)
        {
            try
            {
                string strWHID = "";
                int selectedHandle = this.gv_line_wh.FocusedRowHandle;//获取焦点行索引
                if (selectedHandle >= 0)
                {
                    strWHID = this.gv_line_wh.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
                }
                else
                {
                    MessageBox.Show("请先选择对应的仓库信息！");
                    return;
                }
                BindXCQU(strWHID, 1);//重新加载区域信息
                BindFoucedQY();//重新加载焦点库位信息
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        #region 库位管理
        /// <summary>
        /// 保存库位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_loc_Click(object sender, EventArgs e)
        {
            try
            {
                string strQUID = "";
                int selectedHandle = this.gv_line_area.FocusedRowHandle;//获取焦点行索引
                if (selectedHandle >= 0)
                {
                    strQUID = this.gv_line_area.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
                }
                else
                {
                    MessageBox.Show("请先选择对应的区域信息！");
                    return;
                }

                if (this.txt_loc_code.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入库位编码！");
                    this.txt_loc_code.Focus();
                    return;
                }
                if (this.txt_loc_name.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入库位描述！");
                    this.txt_loc_name.Focus();
                    return;
                }

                if (this.lbl_LOC_ID.Text == "")
                {
                    if (DialogResult.No == MessageBox.Show("是否确认添加库位信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TPB_LINEWH_LOC model = new Mod_TPB_LINEWH_LOC();
                    model.C_LINEWH_AREA_ID = strQUID;
                    model.C_LINEWH_LOC_CODE = this.txt_loc_code.Text.Trim();
                    model.C_LINEWH_LOC_NAME = this.txt_loc_name.Text.Trim();
                    model.C_REMARK = this.txt_remark_loc.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_LINEWH_LOC_CODE", model.C_LINEWH_LOC_CODE);
                    ht.Add("N_STATUS", 1);
                    if (Common.CheckRepeat.CheckTable("TPB_LINEWH_LOC", ht) > 0)
                    {
                        MessageBox.Show("已存在该库位编码！");
                    }
                    else
                    {
                        bool res = bll_TPB_LINEWH_LOC.Add(model);
                        if (res)
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加线材仓库库位信息");//添加操作日志

                            MessageBox.Show("添加成功！");
                            BindXCKW(strQUID, 1);//重新加载库位信息
                            btn_reset_loc_Click(null, null);//清空控件
                        }
                    }
                    #endregion

                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑区域信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TPB_LINEWH_LOC model = bll_TPB_LINEWH_LOC.GetModel(this.lbl_LOC_ID.Text);
                    model.C_LINEWH_LOC_CODE = this.txt_loc_code.Text.Trim();
                    model.C_LINEWH_LOC_NAME = this.txt_loc_name.Text.Trim();
                    model.C_REMARK = this.txt_remark_loc.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool res = bll_TPB_LINEWH_LOC.Update(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改线材仓库库位信息");//添加操作日志

                        MessageBox.Show("编辑成功！");
                        BindXCKW(strQUID, 1);//重新加载库位信息
                        btn_reset_loc_Click(null, null);//清空控件
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 重置库位编辑控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_loc_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearPanelControl(this.panelControl5.Controls);
                this.lbl_LOC_ID.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 删除选中的库位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_loc_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_line_loc.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int cannotNum = 0;//不能删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_line_loc.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_line_loc.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    //判断该仓库的区域是否已经全部删除
                    bool isCanStop = true;


                    if (isCanStop)
                    {
                        Mod_TPB_LINEWH_LOC model = bll_TPB_LINEWH_LOC.GetModel(strID);
                        model.N_STATUS = 0;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        model.D_END_DATE = RV.UI.ServerTime.timeNow();
                        bool update = bll_TPB_LINEWH_LOC.Update(model);
                        if (update)
                        {
                            commitNum = commitNum + 1;
                        }
                        else
                        {
                            failtNum = failtNum + 1;
                        }
                    }

                    else
                    {
                        cannotNum = cannotNum + 1;
                    }


                }
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，删除" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除线材仓库库位信息");//添加操作日志

                btn_query_loc_Click(null, null);//重新加载
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 库位列表焦点改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_line_loc_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                BindFoucedKW();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        #endregion
        ///// <summary>
        ///// 仓库信息是否删除选择变化
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void rbtn_isty_wh_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (rbtn_isty_wh.SelectedIndex == 1)
        //        {
        //            //仓库信息
        //            this.txt_LineWh_Code.ReadOnly = true;
        //            this.txt_LIineWh_Name.ReadOnly = true;
        //            this.txt_Remark.ReadOnly = true;
        //            this.btn_Add.Enabled = false;
        //            //区域信息
        //            this.txt_Area_Cap.ReadOnly = true;
        //            this.txt_Area_Code.ReadOnly = true;
        //            this.txt_Area_Name.ReadOnly = true;
        //            this.rbtn_isOUT.ReadOnly = true;
        //            this.txt_remark_area.ReadOnly = true;
        //            this.btn_reset_area.Enabled = false;
        //            this.btn_save_area.Enabled = false;
        //            this.cbo_loading_mode.ReadOnly = true;
        //            this.cbo_transport_mode.ReadOnly = true;
        //            //库位信息
        //            this.txt_loc_code.ReadOnly = true;
        //            this.txt_loc_name.ReadOnly = true;
        //            this.txt_remark_loc.ReadOnly = true;
        //            this.btn_save_loc.Enabled = false;
        //            this.btn_reset_loc.Enabled = false;
        //        }
        //        else
        //        {
        //            //仓库信息
        //            this.txt_LineWh_Code.ReadOnly = false;
        //            this.txt_LIineWh_Name.ReadOnly = false;
        //            this.txt_Remark.ReadOnly = false;
        //            this.btn_Add.Enabled = true;
        //            //区域信息
        //            this.txt_Area_Cap.ReadOnly = false;
        //            this.txt_Area_Code.ReadOnly = false;
        //            this.txt_Area_Name.ReadOnly = false;
        //            this.rbtn_isOUT.ReadOnly = false;
        //            this.txt_remark_area.ReadOnly = false;
        //            this.btn_reset_area.Enabled = true;
        //            this.btn_save_area.Enabled = true;
        //            this.cbo_loading_mode.ReadOnly = false;
        //            this.cbo_transport_mode.ReadOnly = false;

        //            //库位信息
        //            this.txt_loc_code.ReadOnly = false;
        //            this.txt_loc_name.ReadOnly = false;
        //            this.txt_remark_loc.ReadOnly = false;
        //            this.btn_save_loc.Enabled = true;
        //            this.btn_reset_loc.Enabled = true;
        //        }

        //        btn_query_Click(null, null);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}
        /// <summary>
        /// 查询库位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_loc_Click(object sender, EventArgs e)
        {
            try
            {
                string strWHID = "";
                int selectedHandle = this.gv_line_area.FocusedRowHandle;//获取焦点行索引
                if (selectedHandle >= 0)
                {
                    strWHID = this.gv_line_area.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
                }
                else
                {
                    MessageBox.Show("请先选择对应的仓库信息！");
                    return;
                }
                BindXCKW(strWHID, 1);//重新加载区域信息
                BindFoucedKW();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        ///// <summary>
        ///// 选择区域状态事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void rbtn_isty_area_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (rbtn_isty_area.SelectedIndex == 1)
        //        {

        //            this.txt_Area_Code.ReadOnly = true;
        //            this.txt_Area_Name.ReadOnly = true;
        //            this.txt_remark_area.ReadOnly = true;
        //            this.txt_Area_Cap.ReadOnly = true;
        //            this.rbtn_isOUT.ReadOnly = true;
        //            this.btn_save_area.Enabled = false;
        //            this.cbo_loading_mode.ReadOnly = true;
        //            this.cbo_transport_mode.ReadOnly = true;

        //            //库位信息
        //            this.txt_loc_code.ReadOnly = true;
        //            this.txt_loc_name.ReadOnly = true;
        //            this.txt_remark_loc.ReadOnly = true;
        //            this.btn_save_loc.Enabled = false;
        //            this.btn_reset_loc.Enabled = false;
        //        }
        //        else
        //        {
        //            this.txt_Area_Code.ReadOnly = false;
        //            this.txt_Area_Name.ReadOnly = false;
        //            this.txt_remark_area.ReadOnly = false;
        //            this.txt_Area_Cap.ReadOnly = false;
        //            this.rbtn_isOUT.ReadOnly = false;
        //            this.btn_save_area.Enabled = true;
        //            this.cbo_loading_mode.ReadOnly = false;
        //            this.cbo_transport_mode.ReadOnly = false;
        //            //库位信息
        //            this.txt_loc_code.ReadOnly = false;
        //            this.txt_loc_name.ReadOnly = false;
        //            this.txt_remark_loc.ReadOnly = false;
        //            this.btn_save_loc.Enabled = true;
        //            this.btn_reset_loc.Enabled = true;
        //        }
        //        btn_query_area_Click(null, null);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}

        //private void rbtn_isty_loc_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (rbtn_isty_loc.SelectedIndex == 1)
        //        {

        //            //库位信息
        //            this.txt_loc_code.ReadOnly = true;
        //            this.txt_loc_name.ReadOnly = true;
        //            this.txt_remark_loc.ReadOnly = true;
        //            this.btn_save_loc.Enabled = false;
        //            this.btn_reset_loc.Enabled = false;
        //        }
        //        else
        //        {
        //            //库位信息
        //            this.txt_loc_code.ReadOnly = false;
        //            this.txt_loc_name.ReadOnly = false;
        //            this.txt_remark_loc.ReadOnly = false;
        //            this.btn_save_loc.Enabled = true;
        //            this.btn_reset_loc.Enabled = true;
        //        }
        //        btn_query_loc_Click(null, null);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //DataTable dt = bll_TPB_LINEWH_AREA.GetAllList().Tables[0];
                //DataRow dr = this.gv_line_area.GetDataRow(this.gv_line_area.FocusedRowHandle);
                int[] rownumber = this.gv_line_area.GetSelectedRows();//获取选中行号数组；
                
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strAreaID = this.gv_line_area.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    string strAreaCode = this.gv_line_area.GetRowCellValue(selectedHandle, "C_LINEWH_AREA_CODE").ToString();
                    string count = this.gv_line_area.GetRowCellValue(selectedHandle, "N_LINEWH_AREA_CAP").ToString();
                    string remark = this.gv_line_area.GetRowCellValue(selectedHandle, "C_REMARK").ToString();

                    int iKwNum = Convert.ToInt32(count == "" ? "0" : count);
                    if (iKwNum > 0)
                    {
                        bll_TPB_LINEWH_LOC.Delete(strAreaID);
                        for (int j = 1; j < iKwNum + 1; j++)
                        {
                            string strLocCode = strAreaCode + j.ToString("d2");
                            //string insertSql = "INSERT INTO tpb_linewh_loc(C_LINEWH_AREA_ID,C_LINEWH_LOC_CODE) VALUES('"+ strAreaID + "','"+ strLocCode + "')";
                            Mod_TPB_LINEWH_LOC model = new Mod_TPB_LINEWH_LOC();
                            model.C_LINEWH_AREA_ID = strAreaID;
                            model.C_LINEWH_LOC_CODE = strLocCode;
                            model.C_EMP_ID = RV.UI.UserInfo.userID;
                            model.C_LINEWH_LOC_NAME = remark;
                            bool res = bll_TPB_LINEWH_LOC.Add(model);


                        }
                    }
                }
                //加载仓库库位信息
                BindXCKW(this.lbl_Area_ID.Text, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void gv_line_area_Click(object sender, EventArgs e)
        {
            try
            {
                BindFoucedQY();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void gv_line_wh_Click(object sender, EventArgs e)
        {
            try
            {
                BindFocusedRowCK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_DCCK_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_line_wh);
        }

        private void btn_DCQY_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_line_area);
        }

        private void btn_DCKW_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_line_loc);
        }

        private void btn_TBNC_Click(object sender, EventArgs e)
        {

        }
    }
}
