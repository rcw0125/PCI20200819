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
    public partial class FrmPB_GPKGL : Form
    {
        private BLL.Bll_TPB_SLABWH bll_TPB_SLABWH = new BLL.Bll_TPB_SLABWH();//钢坯库库信息
        private BLL.Bll_TPB_SLABWH_AREA bll_TPB_SLABWH_AREA = new BLL.Bll_TPB_SLABWH_AREA();//钢坯库区域信息
        private BLL.Bll_TPB_SLABWH_LOC bll_TPB_SLABWH_LOC = new BLL.Bll_TPB_SLABWH_LOC();//钢坯库库位信息
        private BLL.Bll_TPB_SLABWH_TIER bll_TPB_SLABWH_TIER = new BLL.Bll_TPB_SLABWH_TIER();//钢坯库层信息


        private string strMenuName;

        public FrmPB_GPKGL()
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
        /// 添加编辑钢坯库库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txt_slabWh_Code.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入仓库编码！");
                    this.txt_slabWh_Code.Focus();
                    return;
                }
                if (this.txt_SlabWh_Name.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入仓库描述！");
                    this.txt_SlabWh_Name.Focus();
                    return;
                }

                DataTable dt_NC_CK = bll_TPB_SLABWH.Get_NC_CK_INFO(txt_slabWh_Code.Text.Trim()).Tables[0];
                if (dt_NC_CK.Rows.Count == 0)
                {
                    MessageBox.Show("NC没有该仓库，请现在NC添加需要的仓库信息！");
                    return;
                }

                if (this.lbl_WHID.Text == "")
                {
                    if (DialogResult.No == MessageBox.Show("是否确认添加仓库信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }

                    Mod_TPB_SLABWH model = new Mod_TPB_SLABWH();
                    model.C_ID = dt_NC_CK.Rows[0]["PK_STORDOC"].ToString();
                    model.C_SLABWH_CODE = this.txt_slabWh_Code.Text.Trim();
                    model.C_SLABWH_NAME = this.txt_SlabWh_Name.Text.Trim();
                    model.C_REMARK = this.txt_Remark.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_SLABWH_CODE", model.C_SLABWH_CODE);
                    ht.Add("N_STATUS", 1);
                    if (Common.CheckRepeat.CheckTable("TPB_SLABWH", ht) > 0)
                    {
                        MessageBox.Show("已存在该仓库编码！");
                    }
                    else
                    {
                        bool res = bll_TPB_SLABWH.Add(model, true);
                        if (res)
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加仓库信息");//添加操作日志
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
                    Mod_TPB_SLABWH model = bll_TPB_SLABWH.GetModel(this.lbl_WHID.Text);

                    if(model.C_SLABWH_CODE!= txt_slabWh_Code.Text.Trim())
                    {
                        MessageBox.Show("不能修改仓库编号！");
                        return;
                    }

                    //model.C_SLABWH_CODE = this.txt_slabWh_Code.Text.Trim();
                    model.C_SLABWH_NAME = this.txt_SlabWh_Name.Text.Trim();
                    model.C_REMARK = this.txt_Remark.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();

                    bool res = bll_TPB_SLABWH.Update(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改仓库信息");//添加操作日志

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

                int selectedNum = this.gv_slab_wh.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int cannotNum = 0;//不能删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_slab_wh.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_slab_wh.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    //判断该仓库的区域是否已经全部删除
                    bool hasNoStopArea = bll_TPB_SLABWH_AREA.ExistsNOSotpBySlabWH(strID);
                    if (hasNoStopArea)
                    {
                        cannotNum = cannotNum + 1;
                    }
                    else
                    {
                        Mod_TPB_SLABWH model = bll_TPB_SLABWH.GetModel(strID);
                        model.N_STATUS = 0;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        model.D_END_DATE = RV.UI.ServerTime.timeNow();
                        bool update = bll_TPB_SLABWH.Update(model);
                        if (update)
                        {
                            commitNum = commitNum + 1;
                        }
                        else
                        {
                            
                            failtNum = failtNum + 1;
                        }
                    }


                }
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，删除" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除仓库信息");//添加操作日志

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
        /// 加载钢坯库信息
        /// </summary>
        public void BindXCCK()
        {
            DataTable dt = null;
            dt = bll_TPB_SLABWH.GetListByStatus(1).Tables[0];
            this.gc_slab_wh.DataSource = dt;
            this.gv_slab_wh.OptionsView.ColumnAutoWidth = false;
            this.gv_slab_wh.OptionsSelection.MultiSelect = true;
            gv_slab_wh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_slab_wh.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_slab_wh);
            BindFocusedRowCK();
        }
        /// <summary>
        /// 根据仓库信息加载仓库区域信息
        /// </summary>
        /// <param name="strCKID">仓库主键</param>
        /// <param name="iStatus">状态0删除1启用</param>
        public void BindXCQU(string strCKID, int iStatus)
        {
            DataTable dt = null;
            if (strCKID.Trim() != "")
            {
                dt = bll_TPB_SLABWH_AREA.GetListBySlabWHID(strCKID, iStatus).Tables[0];
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
            Mod_TPB_SLABWH model = bll_TPB_SLABWH.GetModel(this.lbl_WHID.Text);
            this.txt_slabWh_Code.Text = model.C_SLABWH_CODE;
            this.txt_SlabWh_Name.Text = model.C_SLABWH_NAME;
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
            DataTable dt = null;
            if (strQYID != "")
            {
                dt = bll_TPB_SLABWH_LOC.GetListByArea(strQYID, iStatus).Tables[0];
            }

            this.gc_slab_loc.DataSource = dt;
            this.gv_slab_loc.OptionsView.ColumnAutoWidth = false;
            this.gv_slab_loc.OptionsSelection.MultiSelect = true;
            this.gv_slab_loc.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_slab_loc.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_slab_loc);

        }
        /// <summary>
        /// 根据库位加载仓库层信息
        /// </summary>
        /// <param name="strKWID">库位域主键</param>
        public void BindGPC(string strKWID)
        {
            DataTable dt = null;
            if (strKWID != "")
            {
                dt = bll_TPB_SLABWH_TIER.GetListByKW(strKWID).Tables[0];
            }
            this.gc_C.DataSource = dt;
            this.gv_C.OptionsView.ColumnAutoWidth = false;
            this.gv_C.OptionsSelection.MultiSelect = true;
            this.gv_C.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_C.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_C);
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
                BindXCKW(this.lbl_Area_ID.Text, 1);
                return;
            }
            this.lbl_Area_ID.Text = this.gv_slab_area.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到仓库对象，并在界面赋值
            Mod_TPB_SLABWH_AREA model = bll_TPB_SLABWH_AREA.GetModel(this.lbl_Area_ID.Text);
            this.txt_Area_Code.Text = model.C_SLABWH_AREA_CODE;
            this.txt_Area_Name.Text = model.C_SLABWH_AREA_NAME;
            this.txt_remark_area.Text = model.C_REMARK;
            //加载仓库库位信息
            BindXCKW(this.lbl_Area_ID.Text, 1);
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
                //加载仓库层信息
                BindGPC(this.lbl_LOC_ID.Text);
                return;
            }
            this.lbl_LOC_ID.Text = this.gv_slab_loc.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            DataTable dt = bll_TPB_SLABWH_TIER.GetListByKW(this.lbl_LOC_ID.Text).Tables[0];
            string num = "";
            if (dt.Rows.Count > 0)
            {
                num = dt.Rows[0]["N_SLABWH_TIER_NUM"].ToString();//获取支数
            }

            //根据主键得到库位对象，并在界面赋值
            Mod_TPB_SLABWH_LOC model = bll_TPB_SLABWH_LOC.GetModel(this.lbl_LOC_ID.Text);
            txt_loc_floor.Text = model.N_SLABWH_TIER.ToString();
            imcbo_Type.Text = model.C_SLABWH_TYPE;
            txt_loc_name.Text = model.C_SLABWH_LOC_NAME.ToString();
            txt_loc_code.Text = model.C_SLABWH_LOC_CODE;
            txt_remark_loc.Text = model.C_REMARK;
            txt_tier_num.Text = num;
            cbo_slab_type.EditValue = model.C_SLAB_TYPE;
            //加载仓库库位信息
            BindGPC(this.lbl_LOC_ID.Text);
        }
        /// <summary>
        /// 焦点行变化时加载库位信息
        /// </summary>
        public void BindFoucedC()
        {
            int selectedHandle = this.gv_slab_area.FocusedRowHandle;//获取焦点行索引
            string id = this.gv_slab_area.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
                                                                                             //根据主键得到仓库对象，并在界面赋值
            BindGPC(id);
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
                    Mod_TPB_SLABWH_AREA model = new Mod_TPB_SLABWH_AREA();
                    model.C_SLABWH_ID = strWHID;
                    model.C_SLABWH_AREA_CODE = this.txt_Area_Code.Text.Trim();
                    model.C_SLABWH_AREA_NAME = this.txt_Area_Name.Text.Trim();
                    model.C_REMARK = this.txt_remark_area.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_SLABWH_ID", model.C_SLABWH_ID);
                    ht.Add("C_SLABWH_AREA_CODE", model.C_SLABWH_AREA_CODE);
                    ht.Add("N_STATUS", 1);
                    if (Common.CheckRepeat.CheckTable("TPB_SLABWH_AREA", ht) > 0)
                    {
                        MessageBox.Show("已存在该区域编码！");
                    }
                    else
                    {
                        bool res = bll_TPB_SLABWH_AREA.Add(model);
                        if (res)
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加区域信息");//添加操作日志

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
                    Mod_TPB_SLABWH_AREA model = bll_TPB_SLABWH_AREA.GetModel(this.lbl_Area_ID.Text);
                    model.C_SLABWH_AREA_CODE = this.txt_Area_Code.Text.Trim();
                    model.C_SLABWH_AREA_NAME = this.txt_Area_Name.Text.Trim();
                    model.C_REMARK = this.txt_remark_area.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();

                    bool res = bll_TPB_SLABWH_AREA.Update(model);
                    if (res)
                    {
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

                int selectedNum = this.gv_slab_area.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int cannotNum = 0;//不能删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_slab_area.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_slab_area.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    //判断该仓库的区域是否已经全部删除
                    bool hasNoStopLoc = bll_TPB_SLABWH_LOC.GetListByArea(strID, 1).Tables[0].Rows.Count == 0 ? true : false;
                    if (hasNoStopLoc)
                    {
                        Mod_TPB_SLABWH_AREA model = bll_TPB_SLABWH_AREA.GetModel(strID);
                        model.N_STATUS = 0;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        model.D_END_DATE = RV.UI.ServerTime.timeNow();
                        bool update = bll_TPB_SLABWH_AREA.Update(model);
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

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除区域信息");//添加操作日志

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
                //if (this.cbo_slab_type.Text.Trim().Length == 0)
                //{
                //    MessageBox.Show("请选择堆放钢坯类型！");
                //    this.cbo_slab_type.Focus();
                //    return;
                //}
                if (this.txt_loc_floor.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入库位层数！");
                    this.txt_loc_floor.Focus();
                    return;
                }
                if (this.txt_tier_num.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入每层支数！");
                    this.txt_tier_num.Focus();
                    return;
                }
                if (this.imcbo_Type.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请选择库位类型！");
                    this.imcbo_Type.Focus();
                    return;
                }
                if (DialogResult.No == MessageBox.Show("是否确认添加库位信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                if (this.lbl_LOC_ID.Text == "")
                {

                    Mod_TPB_SLABWH_LOC model = new Mod_TPB_SLABWH_LOC();
                    model.C_SLABWH_AREA_ID = strQUID;
                    model.C_SLABWH_LOC_CODE = this.txt_loc_code.Text.Trim();
                    model.C_SLABWH_LOC_NAME = this.txt_loc_name.Text.Trim();
                    model.N_SLABWH_TIER = Convert.ToDecimal(this.txt_loc_floor.Text);
                    model.N_SLABWH_LOC_CAP = Convert.ToDecimal(this.txt_loc_floor.Text) * Convert.ToDecimal(txt_tier_num.Text);
                    model.C_REMARK = this.txt_remark_loc.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.C_SLABWH_TYPE = imcbo_Type.Text;
                    model.C_SLAB_TYPE = cbo_slab_type.EditValue?.ToString();
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_SLABWH_AREA_ID", model.C_SLABWH_AREA_ID);
                    ht.Add("C_SLABWH_LOC_CODE", model.C_SLABWH_LOC_CODE);
                    ht.Add("N_STATUS", 1);
                    if (Common.CheckRepeat.CheckTable("TPB_SLABWH_LOC", ht) > 0)
                    {
                        MessageBox.Show("已存在该库位编码！");
                    }
                    else
                    {
                        bool res = bll_TPB_SLABWH_LOC.Add(model);
                        if (res)
                        {
                            if (model.N_SLABWH_TIER > 0)
                            {
                                for (int i = 1; i <= Convert.ToInt32(model.N_SLABWH_TIER); i++)
                                {
                                    string id = bll_TPB_SLABWH_LOC.GetListByLOCCODE(model.C_SLABWH_LOC_CODE, 1).Tables[0].Rows[0]["C_ID"].ToString();
                                    Mod_TPB_SLABWH_TIER modTier = new Mod_TPB_SLABWH_TIER();
                                    modTier.C_SLABWH_LOC_ID = id;
                                    modTier.C_SLABWH_TIER_CODE = this.txt_loc_code.Text + (i > 9 ? i.ToString() : "0" + i.ToString());
                                    modTier.N_SLABWH_TIER_NUM = Convert.ToInt32(this.txt_tier_num.Text);
                                    modTier.C_EMP_ID = RV.UI.UserInfo.userID;
                                    bll_TPB_SLABWH_TIER.Add(modTier);
                                }
                            }
                            MessageBox.Show("添加成功！");

                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加库位信息");//添加操作日志

                            BindXCKW(strQUID, 1);//重新加载库位信息
                            btn_reset_loc_Click(null, null);//清空控件
                        }
                    }
                    #endregion

                }
                else
                {
                    Mod_TPB_SLABWH_LOC model = bll_TPB_SLABWH_LOC.GetModel(this.lbl_LOC_ID.Text);
                    string num = "";
                    string loc_code = "";
                    DataTable dt_num = bll_TPB_SLABWH_TIER.GetListByKW(this.lbl_LOC_ID.Text).Tables[0];
                    if (dt_num.Rows.Count == 0)
                    {
                        num = "0";
                    }
                    else
                    {
                        num = dt_num.Rows[0]["N_SLABWH_TIER_NUM"].ToString();//获取支数
                        loc_code = model.C_SLABWH_LOC_CODE;
                    }

                    model.C_SLABWH_AREA_ID = strQUID;
                    model.C_SLABWH_LOC_CODE = this.txt_loc_code.Text.Trim();
                    model.C_SLABWH_LOC_NAME = this.txt_loc_name.Text.Trim();
                    if (txt_loc_floor.Text != model.N_SLABWH_TIER.ToString() || txt_tier_num.Text.Trim() != num || txt_loc_code.Text.Trim() != loc_code)
                    {
                        model.N_SLABWH_TIER = Convert.ToDecimal(this.txt_loc_floor.Text);
                        //删除层
                        DataTable dt = bll_TPB_SLABWH_TIER.GetListByKW(this.lbl_LOC_ID.Text).Tables[0];
                        foreach (DataRow item in dt.Rows)
                        {
                            bll_TPB_SLABWH_TIER.Delete(item["C_ID"].ToString());
                        }
                        //添加新层
                        for (int i = 1; i <= Convert.ToInt32(model.N_SLABWH_TIER); i++)
                        {
                            Mod_TPB_SLABWH_TIER modTier = new Mod_TPB_SLABWH_TIER();
                            modTier.C_SLABWH_LOC_ID = model.C_ID;
                            modTier.C_SLABWH_TIER_CODE = this.txt_loc_code.Text + (i > 9 ? i.ToString() : "0" + i.ToString());
                            modTier.N_SLABWH_TIER_NUM = Convert.ToInt32(this.txt_tier_num.Text);
                            modTier.C_EMP_ID = RV.UI.UserInfo.userID;
                            bll_TPB_SLABWH_TIER.Add(modTier);

                            //加载钢坯库层信息
                        }
                    }
                    model.N_SLABWH_LOC_CAP = Convert.ToDecimal(this.txt_loc_floor.Text) * Convert.ToDecimal(txt_tier_num.Text);
                    model.C_REMARK = this.txt_remark_loc.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.C_SLABWH_TYPE = imcbo_Type.Text.Trim();
                    model.C_SLAB_TYPE = cbo_slab_type.EditValue.ToString().Trim();
                    bool res = bll_TPB_SLABWH_LOC.Update(model);
                    if (res)
                    {
                        MessageBox.Show("编辑成功！");

                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改库位信息");//添加操作日志

                        BindXCKW(strQUID, 1);//重新加载库位信息
                        BindFoucedKW();//重新加载层信息
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

                int selectedNum = this.gv_slab_loc.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int cannotNum = 0;//不能删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_slab_loc.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_slab_loc.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    //判断该仓库的区域是否已经全部删除
                    bool isCanStop = true;


                    if (isCanStop)
                    {
                        Mod_TPB_SLABWH_LOC model = bll_TPB_SLABWH_LOC.GetModel(strID);
                        model.N_STATUS = 0;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        model.D_END_DATE = RV.UI.ServerTime.timeNow();
                        bool update = bll_TPB_SLABWH_LOC.Update(model);
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

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "撤销炼钢计划");//添加操作日志

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
                BindXCKW(strWHID, 1);//重新加载区域信息
                BindFoucedKW();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void gv_slab_wh_Click(object sender, EventArgs e)
        {
            try
            {
                BindFocusedRowCK();
                BindFoucedQY();
                BindFoucedKW();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void gv_slab_area_Click(object sender, EventArgs e)
        {

            try
            {
                BindFoucedQY();
                BindFoucedKW();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void gv_slab_loc_Click(object sender, EventArgs e)
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
        /// <summary>
        /// 保存层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btn_save_tier_Click(object sender, EventArgs e)
        //{
        //    //DataRow dr = this.gv_slab_loc.GetDataRow(this.gv_slab_loc.FocusedRowHandle);
        //    //if (dr == null) return;
        //    //DataTable dt = bll_TPB_SLABWH_TIER.GetList_Max_Code(dr["C_ID"].ToString()).Tables[0];

        //    string strQUID = "";
        //    int selectedHandle = this.gv_C.FocusedRowHandle;//获取焦点行索引
        //    if (selectedHandle >= 0)
        //    {
        //        strQUID = this.gv_C.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
        //    }
        //    else
        //    {
        //        MessageBox.Show("请先选择对应的层信息！");
        //        return;
        //    }
        //    Mod_TPB_SLABWH_TIER mod = bll_TPB_SLABWH_TIER.GetModel(strQUID);
        //    mod.N_SLABWH_TIER_NUM = Convert.ToInt32(txt_tier_num1.Text);
        //    mod.C_EMP_ID = RV.UI.UserInfo.userID;
        //    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
        //    bool res = bll_TPB_SLABWH_TIER.Update(mod);
        //    if (res)
        //    {
        //        MessageBox.Show("保存成功！");

        //        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改层信息");//添加操作日志
        //        BindFoucedKW();
        //        ClearContent.ClearPanelControl(this.panelControl9.Controls);
        //    }


        //}

        private void gv_C_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }
        /// <summary>
        /// 获取 层支数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>    
        //private void gv_C_Click(object sender, EventArgs e)
        //{
        //    string strQUID = "";
        //    int selectedHandle = this.gv_C.FocusedRowHandle;//获取焦点行索引
        //    if (selectedHandle >= 0)
        //    {
        //        strQUID = this.gv_C.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
        //    }
        //    else
        //    {
        //        MessageBox.Show("请先选择对应的层信息！");
        //        return;
        //    }
        //    Mod_TPB_SLABWH_TIER mod = bll_TPB_SLABWH_TIER.GetModel(strQUID);
        //    txt_tier_num1.Text = mod.N_SLABWH_TIER_NUM.ToString();
        //}

        private void btn_UpdateXG_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_slab_wh.GetDataRow(this.gv_slab_wh.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmPB_GPKCK_EDIT frm = new FrmPB_GPKCK_EDIT();
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    BindXCCK();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_UpdateQY_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_slab_area.GetDataRow(this.gv_slab_area.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmPB_GPKQY_EDIT frm = new FrmPB_GPKQY_EDIT();
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    btn_query_area_Click(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_UpdateKW_Click(object sender, EventArgs e)
        {
            //DataRow dr = this.gv_GWCN.GetDataRow(this.gv_GWCN.FocusedRowHandle);
            //if (dr == null) return;
            //try
            //{
            //    FrmPB_GWLSCN_EDIT frm = new FrmPB_GWLSCN_EDIT();
            //    frm.c_id = dr["C_ID"].ToString();
            //    if (frm.ShowDialog() == DialogResult.Cancel)
            //    {
            //        frm.Close();
            //        Query();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btn_DCCK_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_slab_wh);
        }

        private void btn_DCQY_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_slab_area);
        }

        private void btn_DCKW_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_slab_loc);
        }

        private void btn_DCC_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_C);
        }
    }
}
