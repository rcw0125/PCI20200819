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
    public partial class FrmPB_HLKGL_OLD : Form
    {
        private BLL.Bll_TPB_COOLPIT Bll_TPB_COOLPIT = new BLL.Bll_TPB_COOLPIT();//线材仓库信息
        private BLL.Bll_TPB_COOLPIT_AREA Bll_TPB_COOLPIT_AREA = new BLL.Bll_TPB_COOLPIT_AREA();//线材库区域信息
        private BLL.Bll_TPB_COOLPIT_LOC Bll_TPB_COOLPIT_LOC = new BLL.Bll_TPB_COOLPIT_LOC();//线材库库位信息

        private string strMenuName;

        public FrmPB_HLKGL_OLD()
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
                if (this.txt_COOLPIT_Code.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入仓库编码！");
                    this.txt_COOLPIT_Code.Focus();
                }
                if (this.txt_COOLPIT_Name.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入仓库描述！");
                    this.txt_COOLPIT_Name.Focus();
                }
                if (this.lbl_WHID.Text == "")
                {
                    if (DialogResult.No == MessageBox.Show("是否确认添加仓库信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TPB_COOLPIT model = new Mod_TPB_COOLPIT();
                    model.C_COOLPIT_CODE = this.txt_COOLPIT_Code.Text.Trim();
                    model.C_COOLPIT_NAME = this.txt_COOLPIT_Name.Text.Trim();
                    model.C_REMARK = this.txt_Remark.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;

                    bool res = Bll_TPB_COOLPIT.Add(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加缓冷坑仓库信息");//添加操作日志

                        MessageBox.Show("添加成功！");
                        BindXCCK();//重新加载仓库信息
                        btn_Reset_Click(null, null);//清空控件
                    }
                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑仓库信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TPB_COOLPIT model = Bll_TPB_COOLPIT.GetModel(this.lbl_WHID.Text);
                    model.C_COOLPIT_CODE = this.txt_COOLPIT_Code.Text.Trim();
                    model.C_COOLPIT_NAME = this.txt_COOLPIT_Name.Text.Trim();
                    model.C_REMARK = this.txt_Remark.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();

                    bool res = Bll_TPB_COOLPIT.Update(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改缓冷坑仓库信息");//添加操作日志

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
        private void gv_slab_wh_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
        /// 停用选中的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_slab_wh.SelectedRowsCount;
                int commitNum = 0;//停用记录数量
                int cannotNum = 0;//不能停用记录数量
                int failtNum = 0;//停用失败数量
                int[] rownumber = this.gv_slab_wh.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_slab_wh.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    //判断该仓库的区域是否已经全部停用
                    bool hasNoStopArea = Bll_TPB_COOLPIT_AREA.ExistsNOSotpByCOOLPIT(strID);
                    if (hasNoStopArea)
                    {
                        Mod_TPB_COOLPIT model = Bll_TPB_COOLPIT.GetModel(strID);
                        model.N_STATUS = 0;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        model.D_END_DATE = RV.UI.ServerTime.timeNow();
                        bool update = Bll_TPB_COOLPIT.Update(model);
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
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，停用" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用缓冷坑仓库信息");//添加操作日志

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
            if (this.rbtn_isty_wh.SelectedIndex == 0)
            {
                dt = Bll_TPB_COOLPIT.GetListByStatus(1).Tables[0];
            }
            else
            {
                dt = Bll_TPB_COOLPIT.GetListByStatus(0).Tables[0];
            }

            this.gc_slab_wh.DataSource = dt;
            this.gv_slab_wh.OptionsView.ColumnAutoWidth = false;
            this.gv_slab_wh.OptionsSelection.MultiSelect = true;
            gv_slab_wh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_slab_wh.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_slab_wh);
        }
        /// <summary>
        /// 根据仓库信息加载仓库区域信息
        /// </summary>
        /// <param name="strCKID">仓库主键</param>
        /// <param name="iStatus">状态0停用1启用</param>
        public void BindXCQU(string strCKID, int iStatus)
        {
            DataTable dt = null;
            if (strCKID.Trim() != "")
            {
                dt = Bll_TPB_COOLPIT_AREA.GetListByCOOLPITID(strCKID, iStatus).Tables[0];
            }
            this.gc_slab_area.DataSource = dt;
            this.gv_slab_area.OptionsView.ColumnAutoWidth = false;
            this.gv_slab_area.OptionsSelection.MultiSelect = true;
            this.gv_slab_area.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_slab_area.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_slab_area);
        }
        /// <summary>
        /// 获取仓库列表焦点行信息
        /// </summary>
        public void BindFocusedRowCK()
        {
            int selectedHandle = this.gv_slab_wh.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                return;
            }
            this.lbl_WHID.Text = this.gv_slab_wh.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到仓库对象，并在界面赋值
            Mod_TPB_COOLPIT model = Bll_TPB_COOLPIT.GetModel(this.lbl_WHID.Text);
            this.txt_COOLPIT_Code.Text = model.C_COOLPIT_CODE;
            this.txt_COOLPIT_Name.Text = model.C_COOLPIT_NAME;
            this.txt_Remark.Text = model.C_REMARK;

            //加载仓库区域信息
            BindXCQU(this.lbl_WHID.Text, rbtn_isty_area.SelectedIndex == 0 ? 1 : 0);
        }


        /// <summary>
        /// 根据区域信息加载仓库库位信息
        /// </summary>
        /// <param name="strCKID">区域主键</param>
        public void BindXCKW(string strQYID, int iStatus)
        {
            DataTable dt = null;
            if (strQYID!="")
            {
                dt = Bll_TPB_COOLPIT_LOC.GetListByArea(strQYID, iStatus).Tables[0];
            }
           
            this.gc_slab_loc.DataSource = dt;
            this.gv_slab_loc.OptionsView.ColumnAutoWidth = false;
            this.gv_slab_loc.OptionsSelection.MultiSelect = true;
            this.gv_slab_loc.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_slab_loc.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_slab_loc);
        }
        /// <summary>
        /// 焦点行变化时加载区域信息
        /// </summary>
        public void BindFoucedQY()
        {
            int selectedHandle = this.gv_slab_area.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                btn_reset_area_Click(null, null);
                //加载仓库库位信息
                BindXCKW(this.lbl_Area_ID.Text, this.rbtn_isty_loc.SelectedIndex == 0 ? 1 : 0);
                return;
            }
            this.lbl_Area_ID.Text = this.gv_slab_area.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到仓库对象，并在界面赋值
            Mod_TPB_COOLPIT_AREA model = Bll_TPB_COOLPIT_AREA.GetModel(this.lbl_Area_ID.Text);
            this.txt_Area_Code.Text = model.C_COOLPIT_AREA_CODE;
            this.txt_Area_Name.Text = model.C_COOLPIT_AREA_NAME;
            this.txt_remark_area.Text = model.C_REMARK;
            //加载仓库库位信息
            BindXCKW(this.lbl_Area_ID.Text, this.rbtn_isty_loc.SelectedIndex == 0 ? 1 : 0);
        }


        /// <summary>
        /// 焦点行变化时加载库位信息
        /// </summary>
        public void BindFoucedKW()
        {
            int selectedHandle = this.gv_slab_loc.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                btn_reset_loc_Click(null, null);
                return;
            }
            this.lbl_LOC_ID.Text = this.gv_slab_loc.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到仓库对象，并在界面赋值
            Mod_TPB_COOLPIT_LOC model = Bll_TPB_COOLPIT_LOC.GetModel(this.lbl_LOC_ID.Text);
            this.txt_loc_code.Text = model.C_COOLPIT_LOC_CODE;
            this.txt_loc_name.Text = model.C_COOLPIT_LOC_NAME;
            this.txt_loc_floor.Text = model.N_COOLPIT_TIER.ToString();
            this.txt_loc_cap.Text = model.N_COOLPIT_LOC_CAP.ToString();
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
                int selectedHandle = this.gv_slab_wh.FocusedRowHandle;//获取焦点行索引
                if (selectedHandle >= 0)
                {
                    strWHID = this.gv_slab_wh.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
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

                if (this.lbl_Area_ID.Text == "")
                {
                    if (DialogResult.No == MessageBox.Show("是否确认添加区域信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TPB_COOLPIT_AREA model = new Mod_TPB_COOLPIT_AREA();
                    model.C_COOLPIT_ID = strWHID;
                    model.C_COOLPIT_AREA_CODE = this.txt_Area_Code.Text.Trim();
                    model.C_COOLPIT_AREA_NAME = this.txt_Area_Name.Text.Trim();
                    model.C_REMARK = this.txt_remark_area.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;

                    bool res = Bll_TPB_COOLPIT_AREA.Add(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加缓冷坑区域信息");//添加操作日志

                        MessageBox.Show("添加成功！");
                        BindXCQU(strWHID, rbtn_isty_area.SelectedIndex == 0 ? 1 : 0);//重新加载区域信息
                        btn_reset_area_Click(null, null);//清空控件
                    }
                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑区域信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TPB_COOLPIT_AREA model = Bll_TPB_COOLPIT_AREA.GetModel(this.lbl_Area_ID.Text);
                    model.C_COOLPIT_AREA_CODE = this.txt_Area_Code.Text.Trim();
                    model.C_COOLPIT_AREA_NAME = this.txt_Area_Name.Text.Trim();
                    model.C_REMARK = this.txt_remark_area.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();

                    bool res = Bll_TPB_COOLPIT_AREA.Update(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改缓冷坑区域信息");//添加操作日志

                        MessageBox.Show("编辑成功！");
                        BindXCQU(strWHID, rbtn_isty_area.SelectedIndex == 0 ? 1 : 0);//重新加载区域信息
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
        /// <summary>
        /// 停用选中的区域信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_area_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_slab_area.SelectedRowsCount;
                int commitNum = 0;//停用记录数量
                int cannotNum = 0;//不能停用记录数量
                int failtNum = 0;//停用失败数量
                int[] rownumber = this.gv_slab_area.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_slab_area.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    //判断该仓库的区域是否已经全部停用
                    bool hasNoStopLoc = Bll_TPB_COOLPIT_LOC.GetListByArea(strID, 1).Tables[0].Rows.Count == 0 ? true : false;
                    if (hasNoStopLoc)
                    {
                        Mod_TPB_COOLPIT_AREA model = Bll_TPB_COOLPIT_AREA.GetModel(strID);
                        model.N_STATUS = 0;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        model.D_END_DATE = RV.UI.ServerTime.timeNow();
                        bool update = Bll_TPB_COOLPIT_AREA.Update(model);
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
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，停用" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用缓冷坑区域信息");//添加操作日志

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
        private void gv_slab_area_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
                int selectedHandle = this.gv_slab_wh.FocusedRowHandle;//获取焦点行索引
                if (selectedHandle >= 0)
                {
                    strWHID = this.gv_slab_wh.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
                }
                else
                {
                    MessageBox.Show("请先选择对应的仓库信息！");
                    return;
                }
                BindXCQU(strWHID, rbtn_isty_area.SelectedIndex == 0 ? 1 : 0);//重新加载区域信息
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
                int selectedHandle = this.gv_slab_area.FocusedRowHandle;//获取焦点行索引
                if (selectedHandle >= 0)
                {
                    strQUID = this.gv_slab_area.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
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
                    Mod_TPB_COOLPIT_LOC model = new Mod_TPB_COOLPIT_LOC();
                    model.C_COOLPIT_AREA_ID = strQUID;
                    model.C_COOLPIT_LOC_CODE = this.txt_loc_code.Text.Trim();
                    model.C_COOLPIT_LOC_NAME = this.txt_loc_name.Text.Trim();
                    model.N_COOLPIT_TIER = Convert.ToDecimal(this.txt_loc_floor.Text);
                    model.N_COOLPIT_LOC_CAP = Convert.ToDecimal(this.txt_loc_cap.Text);
                    model.C_REMARK = this.txt_remark_loc.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    bool res = Bll_TPB_COOLPIT_LOC.Add(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加缓冷坑库位信息");//添加操作日志

                        MessageBox.Show("添加成功！");
                        BindXCKW(strQUID, rbtn_isty_area.SelectedIndex == 0 ? 1 : 0);//重新加载库位信息
                        btn_reset_loc_Click(null, null);//清空控件
                    }
                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑区域信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TPB_COOLPIT_LOC model = Bll_TPB_COOLPIT_LOC.GetModel(this.lbl_LOC_ID.Text);
                    model.C_COOLPIT_AREA_ID = strQUID;
                    model.C_COOLPIT_LOC_CODE = this.txt_loc_code.Text.Trim();
                    model.C_COOLPIT_LOC_NAME = this.txt_loc_name.Text.Trim();
                    model.N_COOLPIT_TIER = Convert.ToDecimal(this.txt_loc_floor.Text);
                    model.N_COOLPIT_LOC_CAP = Convert.ToDecimal(this.txt_loc_cap.Text);
                    model.C_REMARK = this.txt_remark_loc.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool res = Bll_TPB_COOLPIT_LOC.Update(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改缓冷坑库位信息");//添加操作日志

                        MessageBox.Show("编辑成功！");
                        BindXCKW(strQUID, rbtn_isty_area.SelectedIndex == 0 ? 1 : 0);//重新加载库位信息
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
        /// 停用选中的库位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_loc_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_slab_loc.SelectedRowsCount;
                int commitNum = 0;//停用记录数量
                int cannotNum = 0;//不能停用记录数量
                int failtNum = 0;//停用失败数量
                int[] rownumber = this.gv_slab_loc.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_slab_loc.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    //判断该仓库的区域是否已经全部停用
                    bool isCanStop = true;


                    if (isCanStop)
                    {
                        Mod_TPB_COOLPIT_LOC model = Bll_TPB_COOLPIT_LOC.GetModel(strID);
                        model.N_STATUS = 0;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        model.D_END_DATE = RV.UI.ServerTime.timeNow();
                        bool update = Bll_TPB_COOLPIT_LOC.Update(model);
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
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，停用" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用缓冷坑库位信息");//添加操作日志

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
        private void gv_slab_loc_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
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
        /// <summary>
        /// 仓库信息是否停用选择变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_isty_wh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtn_isty_wh.SelectedIndex == 1)
                {
                    //仓库信息
                    this.txt_COOLPIT_Code.ReadOnly = true;
                    this.txt_COOLPIT_Name.ReadOnly = true;
                    this.txt_Remark.ReadOnly = true;
                    this.btn_Add.Enabled = false;
                    //区域信息
                    this.txt_Area_Code.ReadOnly = true;
                    this.txt_Area_Name.ReadOnly = true;
                    this.txt_remark_area.ReadOnly = true;
                    this.btn_reset_area.Enabled = false;
                    this.btn_save_area.Enabled = false;
                    //库位信息
                    this.txt_loc_code.ReadOnly = true;
                    this.txt_loc_name.ReadOnly = true;
                    this.txt_remark_loc.ReadOnly = true;
                    this.btn_save_loc.Enabled = false;
                    this.btn_reset_loc.Enabled = false;
                    this.txt_loc_cap.ReadOnly = true;
                    this.txt_loc_floor.ReadOnly = true;
                }
                else
                {
                    //仓库信息
                    this.txt_COOLPIT_Code.ReadOnly = false;
                    this.txt_COOLPIT_Name.ReadOnly = false;
                    this.txt_Remark.ReadOnly = false;
                    this.btn_Add.Enabled = true;
                    //区域信息
                    this.txt_Area_Code.ReadOnly = false;
                    this.txt_Area_Name.ReadOnly = false;
                    this.txt_remark_area.ReadOnly = false;
                    this.btn_reset_area.Enabled = true;
                    this.btn_save_area.Enabled = true;

                    //库位信息
                    this.txt_loc_code.ReadOnly = false;
                    this.txt_loc_name.ReadOnly = false;
                    this.txt_remark_loc.ReadOnly = false;
                    this.btn_save_loc.Enabled = true;
                    this.btn_reset_loc.Enabled = true;
                    this.txt_loc_cap.ReadOnly = false;
                    this.txt_loc_floor.ReadOnly = false;
                }

                btn_query_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
        }
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
                int selectedHandle = this.gv_slab_area.FocusedRowHandle;//获取焦点行索引
                if (selectedHandle >= 0)
                {
                    strWHID = this.gv_slab_area.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
                }
                else
                {
                    MessageBox.Show("请先选择对应的仓库信息！");
                    return;
                }
                BindXCKW(strWHID, this.rbtn_isty_loc.SelectedIndex == 0 ? 1 : 0);//重新加载区域信息
                BindFoucedKW();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
        }
        /// <summary>
        /// 选择区域状态事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_isty_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtn_isty_area.SelectedIndex == 1)
                {

                    this.txt_Area_Code.ReadOnly = true;
                    this.txt_Area_Name.ReadOnly = true;
                    this.txt_remark_area.ReadOnly = true;
                    this.btn_save_area.Enabled = false;
                    //库位信息
                    this.txt_loc_code.ReadOnly = true;
                    this.txt_loc_name.ReadOnly = true;
                    this.txt_remark_loc.ReadOnly = true;
                    this.txt_loc_cap.ReadOnly = true;
                    this.txt_loc_floor.ReadOnly = true;
                    this.btn_save_loc.Enabled = false;
                    this.btn_reset_loc.Enabled = false;
                }
                else
                {
                    this.txt_Area_Code.ReadOnly = false;
                    this.txt_Area_Name.ReadOnly = false;
                    this.txt_remark_area.ReadOnly = false;
                    this.btn_save_area.Enabled = true;
                    //库位信息
                    this.txt_loc_code.ReadOnly = false;
                    this.txt_loc_name.ReadOnly = false;
                    this.txt_remark_loc.ReadOnly = false;
                    this.txt_loc_cap.ReadOnly = false;
                    this.txt_loc_floor.ReadOnly = false;
                    this.btn_save_loc.Enabled = true;
                    this.btn_reset_loc.Enabled = true;
                }
                btn_query_area_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void rbtn_isty_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtn_isty_loc.SelectedIndex == 1)
                {

                    //库位信息
                    this.txt_loc_code.ReadOnly = true;
                    this.txt_loc_name.ReadOnly = true;
                    this.txt_remark_loc.ReadOnly = true;
                    this.btn_save_loc.Enabled = false;
                    this.btn_reset_loc.Enabled = false;
                }
                else
                {
                    //库位信息
                    this.txt_loc_code.ReadOnly = false;
                    this.txt_loc_name.ReadOnly = false;
                    this.txt_remark_loc.ReadOnly = false;
                    this.btn_save_loc.Enabled = true;
                    this.btn_reset_loc.Enabled = true;
                }
                btn_query_loc_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}
