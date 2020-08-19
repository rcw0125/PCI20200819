using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;


namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_GX : Form
    {
        public FrmPB_GX()
        {
            InitializeComponent();
        }

        Bll_TB_PRO bll_TB_PRO = new Bll_TB_PRO();//工序
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();//工位
        CommonSub sub = new CommonSub();

        private string strMenuName;

        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPB_GX_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                this.lbl_GXID.Text = "";//主键清空
                this.lbl_GWID.Text = "";
                sub.setColumReadOnly(gv_GX.Columns);//禁止编辑
                Query();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveDetails_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txt_GXMS.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入工序！");
                    this.txt_GXMS.Focus();
                    return;
                }
                if (this.txt_GXDM.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入工序代码！");
                    this.txt_GXDM.Focus();
                    return;
                }
                if (this.lbl_GXID.Text == "")
                {
                    if (DialogResult.No == MessageBox.Show("是否确认添加工序信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }

                    if (bll_TB_PRO.ExistsByProCode(this.txt_GXDM.Text.Trim()))
                    {
                        MessageBox.Show("该工序代码已存在！");
                        return;
                    }
                    Mod_TB_PRO model = new Mod_TB_PRO();
                    model.C_PRO_CODE = this.txt_GXDM.Text.Trim();
                    model.C_PRO_DESC = this.txt_GXMS.Text.Trim();
                    model.C_PRO_ERPCODE = this.txt_ERPGXDM.Text.Trim();
                    model.C_PRO_MESCODE = this.txt_MESGXDM.Text.Trim();
                    model.C_REMARK = this.txt_Remark.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.N_SORT = bll_TB_PRO.GetRecordCount()+1;
                    bool res = bll_TB_PRO.Add(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加工序信息");//添加操作日志

                        MessageBox.Show("添加成功！");
                        Query();//重新加载工序信息
                        btn_Reset_Click(null, null);//清空控件
                    }
                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑工序信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TB_PRO model = bll_TB_PRO.GetModel(this.lbl_GXID.Text);
                    model.C_PRO_CODE = this.txt_GXDM.Text.Trim();
                    model.C_PRO_DESC = this.txt_GXMS.Text.Trim();
                    model.C_PRO_ERPCODE = this.txt_ERPGXDM.Text.Trim();
                    model.C_PRO_MESCODE = this.txt_MESGXDM.Text.Trim();
                    model.C_REMARK = this.txt_Remark.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();

                    bool res = bll_TB_PRO.Update(model);
                    if (res)
                    {

                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工序信息");//添加操作日志

                        MessageBox.Show("编辑成功！");
                        Query();//重新加载工序信息
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
        private void Query()
        {
            DataTable dt = null;
            string gx = txt_GX2.Text;
            dt = bll_TB_PRO.GetListByStatus(1, gx, "").Tables[0];
            this.gc_GX.DataSource = dt;
            this.gv_GX.OptionsView.ColumnAutoWidth = false;
            this.gv_GX.OptionsSelection.MultiSelect = true;
            gv_GX.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GX);
        }
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                Query();
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

                int selectedNum = this.gv_GX.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int cannotNum = 0;//不能删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_GX.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_GX.GetRowCellValue(selectedHandle, "C_ID").ToString();

                    //判断该工序的工位是否已经全部删除
                    bool hasNoStopArea = bll_TB_PRO.ExistsNOSotpGX(strID);
                    if (!hasNoStopArea)
                    {
                        Mod_TB_PRO model = bll_TB_PRO.GetModel(strID);
                        model.N_STATUS = 0;
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        model.D_END_DATE = RV.UI.ServerTime.timeNow();
                        bool update = bll_TB_PRO.Update(model);
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
                if (selectedNum==0)
                {
                    MessageBox.Show("未选中工序！");
                }
                else
                {
                    bll_TB_PRO.CZSORT();
                    MessageBox.Show("选择" + selectedNum.ToString() + "条记录，删除" + commitNum.ToString() + "条记录！");
                }
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除工序信息");//添加操作日志

                Query();//重新加载仓库信息
                gv_GX_Click(null,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ClearContent.ClearPanelControl(panelControl1.Controls);
            lbl_GXID.Text = "";
            ClearContent.ClearPanelControl(panelControl3.Controls);
            lbl_GWID.Text = "";
            btn_QueryGW_Click(null,null);
        }
        private void btn_QueryGW_Click(object sender, EventArgs e)
        {
            try
            {
                BindGW();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 获取工序列表焦点行信息
        /// </summary>
        public void BindFocusedRowGX()
        {
            int selectedHandle = this.gv_GX.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                groupControl2.Text = "工位维护";
                return;
            }
            //根据主键得到工序对象，并在界面赋值
            Mod_TB_PRO model = bll_TB_PRO.GetModel(this.lbl_GXID.Text);
            this.txt_GXMS.Text = model.C_PRO_DESC;
            this.txt_GXDM.Text = model.C_PRO_CODE;
            this.txt_ERPGXDM.Text = model.C_PRO_ERPCODE;
            this.txt_MESGXDM.Text = model.C_PRO_MESCODE;
            this.txt_Remark.Text = model.C_REMARK;
            groupControl2.Text = "工位维护：" + model.C_PRO_DESC;
            //加载工位信息
            BindGW();
        }
        /// <summary>
        /// 根据工序主键加载工位信息
        /// </summary>
        public void BindGW()
        {
            string strGXID = "";//工序主键
            int selectedHandle = this.gv_GX.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle >= 0)
            {
                strGXID = this.gv_GX.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            }
            else
            {
                MessageBox.Show("请先选择对应的工序信息！");
                return;
            }
            DataTable dt = null;
            dt = bll_TB_STA.GetListByStatus(1, strGXID, txt_Query_GW.Text.Trim()).Tables[0];
            this.gc_GW.DataSource = dt;
            this.gv_GW.OptionsView.ColumnAutoWidth = false;
            this.gv_GW.OptionsSelection.MultiSelect = true;
            gv_GW.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GW.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GW);
            BindFocusedRowGW();
        }

        private void btn_SaveGW_Click(object sender, EventArgs e)
        {
            try
            {
                string strGXID = "";//工序主键
                int selectedHandle = this.gv_GX.FocusedRowHandle;//获取焦点行索引
                if (selectedHandle >= 0)
                {
                    strGXID = this.gv_GX.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
                }
                else
                {
                    MessageBox.Show("请先选择对应的工序信息！");
                    return;
                }
                if (this.txt_GW.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入工位！");
                    this.txt_GW.Focus();
                    return;
                }
                if (this.txt_GWDM.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入工位代码！");
                    this.txt_GWDM.Focus();
                    return;
                }
                if (this.lbl_GWID.Text == "")
                {
                    if (DialogResult.No == MessageBox.Show("是否确认添加工位信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }

                    if (bll_TB_STA.ExistsBySTACode(this.txt_GWDM.Text.Trim()))
                    {
                        MessageBox.Show("该工位代码已存在！");
                        return;
                    }
                    Mod_TB_STA model = new Mod_TB_STA();
                    model.C_PRO_ID = strGXID;
                    model.C_STA_DESC = this.txt_GW.Text.Trim();
                    model.C_STA_CODE = this.txt_GWDM.Text.Trim();
                    model.C_STA_ERPCODE = this.txt_ERPGWDM.Text.Trim();
                    model.C_STA_MESCODE = this.txt_MESGWDM.Text.Trim();
                    model.C_REMARK = this.txt_Remark_GW.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.N_SORT = bll_TB_STA.GetRecordCount(strGXID)+1;
                    bool res = bll_TB_STA.Add(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "保存工位信息");//添加操作日志

                        MessageBox.Show("添加成功！");
                        btn_QueryGW_Click(null, null);//重新加载工位信息
                        btn_ResetGW_Click(null, null);//清空控件
                    }
                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑工位信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TB_STA model = bll_TB_STA.GetModel(this.lbl_GWID.Text);
                    model.C_PRO_ID = strGXID;
                    model.C_STA_CODE = this.txt_GWDM.Text.Trim();
                    model.C_STA_DESC = this.txt_GW.Text.Trim();
                    model.C_STA_ERPCODE = this.txt_ERPGWDM.Text.Trim();
                    model.C_STA_MESCODE = this.txt_MESGWDM.Text.Trim();
                    model.C_REMARK = this.txt_Remark.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();

                    bool res = bll_TB_STA.Update(model);
                    if (res)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工位信息");//添加操作日志

                        MessageBox.Show("编辑成功！");
                        btn_QueryGW_Click(null, null);//重新加载工位信息
                        btn_ResetGW_Click(null, null);//清空控件
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }
        }

        private void btn_ResetGW_Click(object sender, EventArgs e)
        {
            ClearContent.ClearPanelControl(panelControl3.Controls);
            lbl_GWID.Text = "";
        }
        /// <summary>
        /// 删除工位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StopGW_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_GW.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_GW.GetSelectedRows();//获取选中行号数组；
                string pro = "";
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_GW.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TB_STA model = bll_TB_STA.GetModel(strID);
                    pro = model.C_PRO_ID;
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.D_END_DATE = RV.UI.ServerTime.timeNow();
                    bool update = bll_TB_STA.Update(model);
                    if (update)
                    {
                        commitNum = commitNum + 1;
                    }
                    else
                    {
                        failtNum = failtNum + 1;
                    }
                }
                if (selectedNum==0)
                {
                    MessageBox.Show("未选中工位！");
                }
                else
                {
                    bll_TB_STA.CZSORT(pro);
                    MessageBox.Show("选择" + selectedNum.ToString() + "条记录，删除" + commitNum.ToString() + "条记录！");
                }
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除工位信息");//添加操作日志

                btn_QueryGW_Click(null, null);//重新加载工位信息
                gv_GW_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }


        /// <summary>
        /// 获取工序列表焦点行信息
        /// </summary>
        public void BindFocusedRowGW()
        {
            int selectedHandle = this.gv_GW.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                ClearContent.ClearPanelControl(panelControl3.Controls);
                lbl_GWID.Text = "";
                return;
            }
            this.lbl_GWID.Text = this.gv_GW.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到工序对象，并在界面赋值
            Mod_TB_STA model = bll_TB_STA.GetModel(this.lbl_GWID.Text);
            this.txt_GW.Text = model.C_STA_DESC;
            this.txt_GWDM.Text = model.C_STA_CODE;
            this.txt_ERPGWDM.Text = model.C_STA_ERPCODE;
            this.txt_MESGWDM.Text = model.C_STA_MESCODE;
            this.txt_Remark.Text = model.C_REMARK;
        }

        private void gv_GW_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            BindFocusedRowGW();
        }
        /// <summary>
        /// 获取焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_GX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //BindFocusedRowGX();
        }

        private void gv_GX_Click(object sender, EventArgs e)
        {
            int selectedHandle = this.gv_GX.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle>=0)
            {
                this.lbl_GXID.Text = this.gv_GX.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            }
            BindFocusedRowGX();
        }

        private void gv_GW_Click(object sender, EventArgs e)
        {
            int selectedHandle = this.gv_GW.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle >= 0)
            {
                this.lbl_GWID.Text = this.gv_GW.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            }
            BindFocusedRowGW();
        }



        private void lbl_GXID_TextChanged(object sender, EventArgs e)
        {
            if (lbl_GXID.Text.Trim() != "")
            {
                txt_GXDM.Enabled = false;
            }
            else
            {
                txt_GXDM.Enabled = true;
            }
        }

        private void lbl_GWID_TextChanged(object sender, EventArgs e)
        {
            if (lbl_GWID.Text.Trim() != "")
            {
                txt_GWDM.Enabled = false;
            }
            else
            {
                txt_GWDM.Enabled = true;
            }
        }

       
        private void btn_SY_Click(object sender, EventArgs e)
        {
            Mod_TB_PRO model = bll_TB_PRO.GetModel(this.lbl_GXID.Text);
            if (model != null)
            {
                model.N_SORT = model.N_SORT - 1;
            }
            else
            {
                return;
            }
            if (model.N_SORT == 0)
            {
                return;
            }
            model.C_EMP_ID = RV.UI.UserInfo.userID;
            model.D_MOD_DT = RV.UI.ServerTime.timeNow();
            Mod_TB_PRO model1 = bll_TB_PRO.GetModelBySoft(model.N_SORT.ToString());
            model1.N_SORT = model1.N_SORT + 1;
            model1.C_EMP_ID = RV.UI.UserInfo.userID;
            model1.D_MOD_DT = RV.UI.ServerTime.timeNow();

            bool res = bll_TB_PRO.Update(model);
            bll_TB_PRO.Update(model1);
            if (res)
            {
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工序顺序");//添加操作日志
                Query();//重新加载工序信息
                //btn_Reset_Click(null, null);//清空控件
            }
            this.lbl_GXID.Text = model.C_ID;
        }

        private void btn_XY_Click(object sender, EventArgs e)
        {
            Mod_TB_PRO model = bll_TB_PRO.GetModel(this.lbl_GXID.Text);
            if (model != null)
            {
                    model.N_SORT = model.N_SORT + 1;
            }
            else
            {
                return;
            }
            model.C_EMP_ID = RV.UI.UserInfo.userID;
            model.D_MOD_DT = RV.UI.ServerTime.timeNow();
            if (model.N_SORT > bll_TB_PRO.GetRecordCount())
            {
                return;
            }
            Mod_TB_PRO model1 = bll_TB_PRO.GetModelBySoft(model.N_SORT.ToString());
            model1.N_SORT = model1.N_SORT - 1;
            model1.C_EMP_ID = RV.UI.UserInfo.userID;
            model1.D_MOD_DT = RV.UI.ServerTime.timeNow();
            bool res = bll_TB_PRO.Update(model);
            bll_TB_PRO.Update(model1);
            if (res)
            {
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工序顺序");//添加操作日志
                Query();//重新加载工序信息
                //btn_Reset_Click(null, null);//清空控件
            }
            this.lbl_GXID.Text = model.C_ID;
        }

        private void btn_SY2_Click(object sender, EventArgs e)
        {
            Mod_TB_STA model = bll_TB_STA.GetModel(this.lbl_GWID.Text);
            if (model != null)
            {
                model.N_SORT = model.N_SORT -1;
            }
            else
            {
                return;
            }
            if (model.N_SORT==0)
            {
                return;
            }
            model.C_EMP_ID = RV.UI.UserInfo.userID;
            model.D_MOD_DT = RV.UI.ServerTime.timeNow();
            Mod_TB_STA model1 = bll_TB_STA.GetModelBySoft(model.N_SORT.ToString(),model.C_PRO_ID);
            model1.N_SORT = model1.N_SORT + 1;
            model1.C_EMP_ID = RV.UI.UserInfo.userID;
            model1.D_MOD_DT = RV.UI.ServerTime.timeNow();
            bool res = bll_TB_STA.Update(model);
            bll_TB_STA.Update(model1);
            if (res)
            {
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工位顺序");//添加操作日志
                BindGW();//重新加载工位信息
                //btn_Reset_Click(null, null);//清空控件
            }
            this.lbl_GWID.Text = model.C_ID;
        }

        private void btn_XY2_Click(object sender, EventArgs e)
        {
            Mod_TB_STA model = bll_TB_STA.GetModel(this.lbl_GWID.Text);
            if (model != null)
            {
                model.N_SORT = model.N_SORT + 1;
            }
            else
            {
                return;
            }
            model.C_EMP_ID = RV.UI.UserInfo.userID;
            model.D_MOD_DT = RV.UI.ServerTime.timeNow();
            if (model.N_SORT > bll_TB_STA.GetRecordCount(model.C_PRO_ID))
            {
                return;
            }
            Mod_TB_STA model1 = bll_TB_STA.GetModelBySoft(model.N_SORT.ToString(), model.C_PRO_ID);
            model1.N_SORT = model1.N_SORT - 1;
            model1.C_EMP_ID = RV.UI.UserInfo.userID;
            model1.D_MOD_DT = RV.UI.ServerTime.timeNow();
            bool res = bll_TB_STA.Update(model);
            bll_TB_STA.Update(model1);
            if (res)
            {
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工位顺序");//添加操作日志
                BindGW();//重新加载工位信息
                //btn_Reset_Click(null, null);//清空控件
            }
            this.lbl_GWID.Text = model.C_ID;
        }

        private void btn_DCGX_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_GX);
        }

        private void btn_DCGW_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_GW);
        }
    }
}
