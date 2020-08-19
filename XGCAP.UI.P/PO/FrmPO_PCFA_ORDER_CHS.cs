using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_PCFA_ORDER_CHS : Form
    {
        private Bll_TPP_PROD_INITIALIZE bll_TPP_PROD_INITIALIZE = new Bll_TPP_PROD_INITIALIZE();//初始化主表（档期表）
        private Bll_TPP_INITIALIZE_ITEM bll_Item = new Bll_TPP_INITIALIZE_ITEM();//初始化（方案表）
        private Bll_TB_PRO bllPro = new Bll_TB_PRO();//工序表
        private Bll_TB_STA bllSta = new Bll_TB_STA();//工位表
        private Bll_TPP_INITIALIZE_STA bll_TPP_INITIALIZE_STA = new Bll_TPP_INITIALIZE_STA();//方案初始化工序工位
        private Bll_TPP_INITIALIZE_LINE bll_INI_LINE = new Bll_TPP_INITIALIZE_LINE();//方案初始化的炼钢工艺路线
        private Bll_TMO_ORDER bll_order = new Bll_TMO_ORDER();//订单池
        private Bll_TPB_LINE_SPEC bll_line_spec = new Bll_TPB_LINE_SPEC();//规格产线数据表
        private Bll_TPB_SLAB_CAPACITY bll_slab_spec = new Bll_TPB_SLAB_CAPACITY();//连铸机机时产能对照
        private Bll_TPP_INITIALIZE_ORDER bll_ini_order = new Bll_TPP_INITIALIZE_ORDER();//初始化订单表
        private Bll_TQB_SLAB_LEN_MATCH bllslabmatch = new Bll_TQB_SLAB_LEN_MATCH();//订单钢坯规格匹配
        Bll_TQB_TSBZ_CF bll_cf = new Bll_TQB_TSBZ_CF();


        public FrmPO_PCFA_ORDER_CHS()
        {
            InitializeComponent();
        }

        private void FrmPO_PCFA_ORDER_CHS_Load(object sender, EventArgs e)
        {
            // BindYearMonth(3);
            BindCbolstInfo(panel8.Controls);//加载工位信息 
            this.dtp_dt1.Text = System.DateTime.Now.ToString("yyyy-MM") + "-01";
            this.dtp_dt2.Text = Convert.ToDateTime(this.dtp_dt1.Text).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
        }

        #region COMMSUB
        /// <summary>
        /// 把CheckedListBoxControl设置为单选框
        /// </summary>
        /// <param name="chkControl">CheckedListBoxControl</param>
        /// <param name="index">index当前选中的索引</param>
        public void SingleSelectCheckedListBoxControls(DevExpress.XtraEditors.CheckedListBoxControl chkControl, int index)
        {
            if (chkControl.CheckedItems.Count > 0)
            {
                for (int i = 0; i < chkControl.Items.Count; i++)
                {
                    if (i != index)
                    {
                        chkControl.SetItemCheckState(i, System.Windows.Forms.CheckState.Unchecked);

                    }
                }
            }
        }
        #endregion

        #region 排产方案加载方法
        ///// <summary>
        ///// 从当月开始加载年月
        ///// </summary>
        ///// <param name="MonNum">加载月数</param>
        //public void BindYearMonth(int MonNum)
        //{
        //    cbo_yyyyMM.Properties.Items.Clear();
        //    for (int i = 0; i < MonNum; i++)
        //    {
        //        cbo_yyyyMM.Properties.Items.Add(System.DateTime.Now.AddMonths(i).ToString("yyyy-MM"));
        //    }
        //}

        /// <summary>
        /// 根据年月加载档期信息
        /// </summary>
        /// <param name = "YM" > 选择的年月 </ param >
        /// < param name="type">类型</param>
        //public void BindDQ(String YM, string type)
        //{
        //    DataTable dt = bll_TPP_PROD_INITIALIZE.GetListByYM(YM, type);
        //    cbo_QS.Properties.Items.Clear();
        //    cbo_QS.Text = "";
        //    if (dt.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            cbo_QS.Properties.Items.Add(dt.Rows[i]["C_ISSUE"].ToString());
        //        }
        //    }
        //}

        /// <summary>
        /// 根据档期号加载方案信息
        /// </summary>
        /// <param name="DQ">档期号</param>
        public void BindInfoByDQ(string type, string dt1, string dt2)
        {
            DataTable dt = bll_Item.GetList(null, type, dt1, dt2).Tables[0];
            this.gc_fa.DataSource = dt;
            this.gv_fa.OptionsView.ColumnAutoWidth = false;
            this.gv_fa.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_fa);
        }

        /// <summary>
        /// 获取焦点方案行信息
        /// </summary>
        public void GetFouceFa()
        {
            int selectedHandle = this.gv_fa.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                groupControl2.Text = "请选择方案！";
                this.lbl_fazj.Text = "";//获取焦点行主键
                this.lbl_faname.Text = "";//获取焦点行名称
                this.lbl_dq.Text = "";//获取焦点行档期号
                return;
            }
            this.lbl_fazj.Text = this.gv_fa.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            this.lbl_faname.Text = this.gv_fa.GetRowCellValue(selectedHandle, "C_ITEM_NAME").ToString();//获取焦点行名称
            this.lbl_dq.Text = this.gv_fa.GetRowCellValue(selectedHandle, "C_ISSUE").ToString();//获取焦点行档期号

            //根据方案主键加载配置工位信息
            BindGWToCheckList(this.lbl_fazj.Text);
            BindLGGWByINI(this.lbl_fazj.Text);
            BindLGGYLX(this.lbl_fazj.Text);
            BindIcbo(this.lbl_fazj.Text, "ZG", cbo_zx4);
            BindIcbo(this.lbl_fazj.Text, "ZG", cbo_zx3);
            BindIcbo(this.lbl_fazj.Text, "ZG", cbo_zx2);
            BindIcbo(this.lbl_fazj.Text, "ZG", cbo_zx1);
            BindIcbo(this.lbl_fazj.Text, "CC", cbo_lz4);
            BindIcbo(this.lbl_fazj.Text, "CC", cbo_lz3);
            BindIcbo(this.lbl_fazj.Text, "CC", cbo_lz2);
            BindIcbo(this.lbl_fazj.Text, "CC", cbo_lz1);
            btn_query_order_wcsh_Click(null, null);

        }
        #endregion

        #region 工序工位初始化
        /// <summary>
        /// 加载工位信息到ImageComboBoxEdit
        /// </summary>
        /// <param name="strIniID">方案主键</param>
        /// <param name="strGX">工序代码</param>
        /// <param name="cbo">ImageComboBoxEdit</param>
        public void BindIcbo(string strIniID, string strGX, DevExpress.XtraEditors.ImageComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DataTable dt = bll_TPP_INITIALIZE_STA.GetGXGWByIni(strIniID, strGX);
            if (dt.Rows.Count > 0)
            {
                cbo.Properties.Items.Add("", "", -1);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbo.Properties.Items.Add(dt.Rows[i]["C_STA_DESC"].ToString(), dt.Rows[i]["C_STA_ID"].ToString(), -1);
                }
            }
            else
            {
                cbo.Properties.Items.Clear();
            }
        }

        /// <summary>
        /// 加载所有工位信息
        /// </summary>
        /// <param name="cbolst"></param>
        public void BindCbolst(DevExpress.XtraEditors.CheckedListBoxControl cbolst)
        {
            DataTable dt = bllSta.GetListByGXDM(cbolst.Tag.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                cbolst.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbolst.Items.Add(dt.Rows[i]["C_STA_CODE"].ToString(), dt.Rows[i]["C_STA_DESC"].ToString());
                }

            }
        }

        /// <summary>
        /// 页面加载CheckedListBoxControl信息
        /// </summary>
        /// <param name="dd"></param>
        public void BindCbolstInfo(System.Windows.Forms.Panel.ControlCollection dd)
        {
            foreach (var c in dd)
            {

                if (c is DevExpress.XtraEditors.CheckedListBoxControl)
                {
                    DevExpress.XtraEditors.CheckedListBoxControl a = (DevExpress.XtraEditors.CheckedListBoxControl)c;
                    BindCbolst(a);
                }

            }

        }


        /// <summary>
        /// 绑定工位
        /// </summary>
        /// <param name="strInitID">方案主键</param>
        public void BindGWToCheckList(string strInitID)
        {
            foreach (var c in panel8.Controls)
            {
                if (c is DevExpress.XtraEditors.CheckedListBoxControl)
                {
                    DevExpress.XtraEditors.CheckedListBoxControl a = (DevExpress.XtraEditors.CheckedListBoxControl)c;
                    string strGX = a.Tag.ToString();
                    DataTable dt = null;
                    dt = bll_TPP_INITIALIZE_STA.GetListByFaid(strGX, strInitID).Tables[0];
                    string idList = "";
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        idList = idList + dt.Rows[i]["C_STA_CODE"].ToString();
                    }
                    for (int i = 0; i < a.Items.Count; i++)
                    {
                        if (idList.Contains(a.Items[i].Value.ToString()))
                        {
                            a.Items[i].CheckState = CheckState.Checked;

                        }
                        else
                        {
                            a.Items[i].CheckState = CheckState.Unchecked;
                        }
                    }

                }
            }
        }


        /// <summary>
        /// 根据方案主键加载炼钢工序工位信息
        /// </summary>
        /// <param name="strInitID">方案主键</param>
        public void BindLGGWByINI(string strInitID)
        {
            foreach (var c in panel6.Controls)
            {
                if (c is DevExpress.XtraEditors.CheckedListBoxControl)
                {
                    DevExpress.XtraEditors.CheckedListBoxControl a = (DevExpress.XtraEditors.CheckedListBoxControl)c;
                    string strGX = a.Tag.ToString();
                    DataTable dt = null;
                    dt = bll_TPP_INITIALIZE_STA.GetLGGXGWByIniID(strInitID, strGX);
                    a.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        a.Items.Add(dt.Rows[i]["C_STA_ID"].ToString(), dt.Rows[i]["C_STA_DESC"].ToString());
                    }


                }
            }
        }

        /// <summary>
        /// 查询当前方案的炼钢工艺路线
        /// </summary>
        /// <param name="C_INITIALIZE_ITEM_ID">方案主键</param>
        /// <returns></returns>
        public void BindLGGYLX(string C_INITIALIZE_ITEM_ID)
        {

            DataTable dt = null;
            dt = bll_INI_LINE.GetListByIniID(C_INITIALIZE_ITEM_ID).Tables[0];
            this.gc_LGLX.DataSource = dt;
            this.gv_LGLX.OptionsView.ColumnAutoWidth = false;
            this.gv_LGLX.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_LGLX);
        }
        #endregion

        private void cbo_yyyyMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  BindDQ(cbo_yyyyMM.Text.Trim(), this.cbo_type.Text.Trim());
        }

        private void cbo_QS_SelectedIndexChanged(object sender, EventArgs e)
        {
            // BindInfoByDQ(cbo_QS.Text);
        }
        /// <summary>
        /// 方案列表项变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_fa_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            GetFouceFa();
        }

        /// <summary>
        /// 保存方案排产工位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_fagw_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认保存当前编辑的工位信息？\r\n确认提交后炼钢工序信息将重置，需要重新配置！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            //清楚当前方案已配置的工位信息
            bool clear1 = bll_TPP_INITIALIZE_STA.DeleteByItemID(this.lbl_fazj.Text);
            //清楚当前方案配置的炼钢工序信息
            bool clear2 = bll_INI_LINE.DeleteByFa(this.lbl_fazj.Text);

            foreach (var c in panel8.Controls)
            {
                if (c is DevExpress.XtraEditors.CheckedListBoxControl)
                {
                    DevExpress.XtraEditors.CheckedListBoxControl a = (DevExpress.XtraEditors.CheckedListBoxControl)c;
                    string strGX = a.Tag.ToString();//工序代码
                    string strGXID = bllPro.GetIDByProCode(strGX);//工序主键
                    for (int i = 0; i < a.Items.Count; i++)
                    {
                        if (a.Items[i].CheckState == CheckState.Checked)
                        {
                            //添加排产工位信息
                            Mod_TPP_INITIALIZE_STA mod = new Mod_TPP_INITIALIZE_STA();
                            mod.C_INITIALIZE_ITEM_ID = this.lbl_fazj.Text;
                            mod.C_PRO_ID = strGXID;
                            mod.C_PRO_CODE = strGX;
                            mod.C_STA_CODE = a.Items[i].Value.ToString();
                            mod.C_STA_DESC = a.Items[i].Description.ToString();
                            mod.C_STA_ID = bllSta.GetStaIdByCode(mod.C_STA_CODE);
                            mod.C_EMP_ID = RV.UI.UserInfo.userName;
                            bool res = bll_TPP_INITIALIZE_STA.Add(mod);

                        }

                    }

                }
            }
            MessageBox.Show("保存成功！");
            BindLGGWByINI(this.lbl_fazj.Text);
            BindLGGYLX(this.lbl_fazj.Text);
        }

        private void btn_query_dq_Click(object sender, EventArgs e)
        {

            BindInfoByDQ(this.radioGroup2.Properties.Items[radioGroup2.SelectedIndex].Description.ToString(), this.dtp_dt1.Text.Trim(), this.dtp_dt2.Text.Trim());


        }

        private void cbo_type_SelectedIndexChanged(object sender, EventArgs e)
        {

            //  BindDQ(cbo_yyyyMM.Text.Trim(), this.cbo_type.Text.Trim());
        }


        private void cbolst_CC1_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
            SingleSelectCheckedListBoxControls(cbolst_CC1, e.Index);
        }

        private void cbolst_RH1_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
            SingleSelectCheckedListBoxControls(cbolst_RH1, e.Index);
        }

        private void cbolst_LF1_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
            SingleSelectCheckedListBoxControls(cbolst_LF1, e.Index);
        }

        private void cbolst_ZL1_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
            SingleSelectCheckedListBoxControls(cbolst_ZL1, e.Index);
        }

        /// <summary>
        /// 保存炼钢工艺路线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_lx_Click(object sender, EventArgs e)
        {

            string strCCCode = "";
            string strCCDesc = "";
            //连铸
            if (cbolst_CC1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < cbolst_CC1.Items.Count; i++)
                {
                    if (cbolst_CC1.Items[i].CheckState == CheckState.Checked)
                    {
                        strCCCode = cbolst_CC1.Items[i].Value.ToString();
                        strCCDesc = cbolst_CC1.Items[i].Description.ToString();
                    }
                }
            }
            string strZLCode = "";
            string strZLDesc = "";
            if (cbolst_ZL1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < cbolst_ZL1.Items.Count; i++)
                {
                    if (cbolst_ZL1.Items[i].CheckState == CheckState.Checked)
                    {
                        strZLCode = cbolst_ZL1.Items[i].Value.ToString();
                        strZLDesc = cbolst_ZL1.Items[i].Description.ToString();
                    }
                }
            }
            string strLFCode = "";
            string strLFDesc = "";
            if (cbolst_LF1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < cbolst_LF1.Items.Count; i++)
                {
                    if (cbolst_LF1.Items[i].CheckState == CheckState.Checked)
                    {
                        strLFCode = cbolst_LF1.Items[i].Value.ToString();
                        strLFDesc = cbolst_LF1.Items[i].Description.ToString();
                    }
                }
            }
            string strRHCode = "";
            string strRHDesc = "";
            if (cbolst_RH1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < cbolst_RH1.Items.Count; i++)
                {
                    if (cbolst_RH1.Items[i].CheckState == CheckState.Checked)
                    {
                        strRHCode = cbolst_RH1.Items[i].Value.ToString();
                        strRHDesc = cbolst_RH1.Items[i].Description.ToString();
                    }
                }
            }

            Mod_TPP_INITIALIZE_LINE mod = new Mod_TPP_INITIALIZE_LINE();
            mod.C_INITIALIZE_ITEM_ID = this.lbl_fazj.Text;
            mod.C_EMP_ID = RV.UI.UserInfo.userName;
            mod.C_JL_STA_ID = strLFCode;
            mod.C_JL_STA_DESC = strLFDesc;
            mod.C_LZ_STA_ID = strCCCode;
            mod.C_LZ_STA_DESC = strCCDesc;
            mod.C_ZK_STA_ID = strRHCode;
            mod.C_ZK_STA_DESC = strRHDesc;
            mod.C_ZL_STA_ID = strZLCode;
            mod.C_ZL_STA_DESC = strZLDesc;
            bool res = bll_INI_LINE.Add(mod);
            BindLGGWByINI(this.lbl_fazj.Text);
            BindLGGYLX(this.lbl_fazj.Text);
        }

        /// <summary>
        /// 删除炼钢工艺路线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_del_lx_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否取消当前选中的炼钢路线！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedHandle = this.gv_LGLX.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                MessageBox.Show("没有选中行！");
                return;
            }
            string strID = this.gv_LGLX.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键

            bool res = bll_INI_LINE.Delete(strID);

            BindLGGWByINI(this.lbl_fazj.Text);
            BindLGGYLX(this.lbl_fazj.Text);
        }

        DataTable dtwchs = null;//未初始化订单列表
        /// <summary>
        /// 查询当前方案未初始化订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_order_wcsh_Click(object sender, EventArgs e)
        {
            if (gv_fa.DataRowCount==0)
            {
                return;
            }
            string strDT = this.gv_fa.GetRowCellValue(gv_fa.FocusedRowHandle, "C_TYPE").ToString();
            if (strDT == "月排产")
            {
                strDT = "1";
            }
            else if (strDT == "旬排产")
            {
                strDT = "2";
            }
            if (this.lbl_fazj.Text.Trim().Length == 0)
            {
                dtwchs = null;
            }
            if (this.rbtn_type.SelectedIndex == 0)
            {
                dtwchs = bll_order.GetWCSHOrderByIni(this.lbl_fazj.Text, "否", strDT);
            }
            else
            {
                dtwchs = bll_order.GetWCSHOrderByIni(this.lbl_fazj.Text, "是", strDT);
            }

            this.gc_wini_order.DataSource = dtwchs;
            this.gv_wini_order.OptionsView.ColumnAutoWidth = false;
            this.gv_wini_order.OptionsSelection.MultiSelect = true;
            this.gv_wini_order.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_wini_order.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_wini_order);
        }
        /// <summary>
        /// 初始化订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_csh_Click(object sender, EventArgs e)
        {
            if (this.rbtn_type.SelectedIndex == 0)
            {

                DataTable dtdchs = dtwchs.Clone();//将选中的订单复制到当前DataTable
                int[] rownumber = this.gv_wini_order.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length > 0)
                {


                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        DataRow dr = dtdchs.NewRow();
                        dr.ItemArray = this.gv_wini_order.GetDataRow(i).ItemArray;
                        dtdchs.Rows.Add(dr);
                    }
                    dtdchs.DefaultView.Sort = " D_DELIVERY_DT, C_LEV ";//将选中的订单按照排产目标进行排序
                    dtdchs = dtdchs.DefaultView.ToTable();//获取的需要初始化的表

                    #region 初始化订单
                    if (dtdchs.Rows.Count == 0)
                    {
                        MessageBox.Show("没有待处理订单！");
                        return;
                    }

                    //将初始化的订单信息添加到表TPP_INITIALIZE_ORDER（初始化订单表）
                    for (int j = 0; j < dtdchs.Rows.Count; j++)
                    {
                        //获取当前方案排产的工位 TPP_INITIALIZE_STA
                        //自动分配轧线 TPB_LINE_SPEC TPB_N_GRD
                        //自动分配到连铸 V_GZ_CCM（钢种连铸匹配数据）
                        //匹配轧线及时产量
                        //匹配连铸机时产量
                        Mod_TPP_INITIALIZE_ORDER mod = new Mod_TPP_INITIALIZE_ORDER();
                        mod.C_INITIALIZE_ID = this.lbl_fazj.Text;
                        mod.C_ORDER_ID = dtdchs.Rows[j]["C_ID"].ToString();
                        mod.N_WGT = Convert.ToDecimal(dtdchs.Rows[j]["N_WGT"].ToString());
                        mod.C_EMP_NAME = RV.UI.UserInfo.userName;
                        string strSpec = dtdchs.Rows[j]["C_SPEC"].ToString();//订单规格
                        string strGZ = dtdchs.Rows[j]["C_STL_GRD"].ToString();//订单规格
                        string strBZ = dtdchs.Rows[j]["C_STD_CODE"].ToString();//订单标准

                        //自动分配轧钢产线
                        DataTable dtsta = bll_line_spec.GetLineByWhere(strSpec, this.lbl_fazj.Text, strGZ, strBZ);
                        if (dtsta.Rows.Count > 0)
                        {
                            mod.C_ROLL_STA_ID = dtsta.Rows[0]["C_STA_ID"].ToString();// 
                            mod.N_MACH_WGT = Convert.ToDecimal(dtsta.Rows[0]["N_CAPACITY"].ToString());
                        }
                        //自动分配连铸产线
                        DataTable dtccm = bll_slab_spec.GetOrderCCM(strGZ, strBZ, this.lbl_fazj.Text);
                        if (dtccm.Rows.Count > 0)
                        {
                            mod.C_CCM_STA_ID = dtccm.Rows[0]["C_STA_ID"].ToString();
                            mod.N_MACH_WGT_CCM = Convert.ToDecimal(dtccm.Rows[0]["N_CAPACITY"].ToString());
                            #region 获取钢坯物料信息
                            
                            DataTable dt = bllslabmatch.GetOrderSlabSize(strGZ, strBZ,"").Tables[0];
                            if (dt.Rows.Count>0)
                            {
                                mod.C_SLAB_SIZE = dt.Rows[0]["C_SLAB_SIZE"].ToString();
                                mod.N_SLAB_LENGTH = Convert.ToDecimal(dt.Rows[0]["C_COLD_LEN"].ToString());
                                mod.N_SLAB_PW = Convert.ToDecimal(dt.Rows[0]["C_THE_WEIGHT"].ToString().Trim()==""?"0": dt.Rows[0]["C_THE_WEIGHT"].ToString());
                                mod.C_KP_SIZE = dt.Rows[0]["C_SLAB_SIZE_KP"].ToString();
                                mod.N_KP_LENGTH = Convert.ToDecimal(dt.Rows[0]["C_COLD_LEN_KP"].ToString());
                                mod.N_KP_PW =Convert.ToDecimal( dt.Rows[0]["C_THE_WEIGHT_KP"].ToString().Trim()==""?"0": dt.Rows[0]["C_THE_WEIGHT_KP"].ToString().Trim());
                            }

                            #endregion

                            #region 匹配开坯物料信息

                            #endregion
                        }

                        bll_ini_order.Add(mod);

                    }
                    btn_query_order_wcsh_Click(null, null);
                    MessageBox.Show("订单已初始化！");

                    #endregion



                }
                else
                {
                    MessageBox.Show("您没有选择需要初始化的订单！");
                    return;
                }

            }
            else
            {
                MessageBox.Show("当前订单已初始化！");
                return;
            }


        }

        private void btn_query_ycsh_Click(object sender, EventArgs e)
        {
            DataTable dt = bll_ini_order.GetIniOrderByIniID(this.lbl_fazj.Text, this.txt_gz3.Text.Trim(), this.txt_bz3.Text.Trim(), this.cbo_zx2.EditValue == null ? "" : this.cbo_zx2.EditValue.ToString().Trim(), this.cbo_lz2.EditValue == null ? "" : this.cbo_lz2.EditValue.ToString().Trim(), null, null);
            this.gc_ini_order.DataSource = dt;
            this.gv_ini_order.OptionsView.ColumnAutoWidth = false;
            this.gv_ini_order.OptionsSelection.MultiSelect = true;
            this.gv_ini_order.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_ini_order.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ini_order);
        }
        /// <summary>
        /// 轧线调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fp_zx_Click(object sender, EventArgs e)
        {
            int[] rownumber = this.gv_ini_order.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strId = gv_ini_order.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TPP_INITIALIZE_ORDER mod = bll_ini_order.GetModel(strId);
                    mod.C_ROLL_STA_ID = this.cbo_zx3.Properties.Items[this.cbo_zx3.SelectedIndex].Value.ToString();
                    bll_ini_order.Update(mod);

                }
            }
            btn_query_ycsh_Click(null, null);
            MessageBox.Show("轧线调整成功！");
        }
        /// <summary>
        /// 连铸调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fp_lz_Click(object sender, EventArgs e)
        {
            int[] rownumber = this.gv_ini_order.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strId = gv_ini_order.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TPP_INITIALIZE_ORDER mod = bll_ini_order.GetModel(strId);
                    mod.C_CCM_STA_ID = this.cbo_lz3.Properties.Items[this.cbo_lz3.SelectedIndex].Value.ToString();
                    bll_ini_order.Update(mod);
                }
                btn_query_ycsh_Click(null, null);
                MessageBox.Show("连铸调整成功！");
            }
        }

        private void btn_order_pc_Click(object sender, EventArgs e)
        {
            int[] rownumber = this.gv_ini_order.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length > 0)
            {
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strId = gv_ini_order.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    bll_ini_order.Delete(strId);
                }
                btn_query_ycsh_Click(null, null);
                MessageBox.Show("订单已排除！");
            }
        }

        private void btn_query_order_ts_Click(object sender, EventArgs e)
        {
            DataTable dt = bll_ini_order.GetIniOrderByIniID(this.lbl_fazj.Text, this.txt_gz4.Text.Trim(), this.txt_bz4.Text.Trim(), this.cbo_zx4.EditValue == null ? "" : this.cbo_zx4.EditValue.ToString().Trim(), this.cbo_lz4.EditValue == null ? "" : this.cbo_lz4.EditValue.ToString().Trim(), null, null);
            this.gc_ini_order2.DataSource = dt;
            this.gv_ini_order2.OptionsView.ColumnAutoWidth = false;
            this.gv_ini_order2.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ini_order2);

            DataTable dtcf = bll_cf.GetTSCFByOrder(this.lbl_fazj.Text, this.txt_gz4.Text.Trim(), this.txt_bz4.Text.Trim(), this.cbo_zx4.EditValue == null ? "" : this.cbo_zx4.EditValue.ToString().Trim(), this.cbo_lz4.EditValue == null ? "" : this.cbo_lz4.EditValue.ToString().Trim(), null, null);
            this.gc_cf.DataSource = dtcf;
            this.gv_cf.OptionsView.ColumnAutoWidth = false;
            this.gv_cf.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_cf);

        }



        private void btn_tj1_Click(object sender, EventArgs e)
        {
            DataTable dt = bll_ini_order.GetOrderAndKCP(this.lbl_fazj.Text, this.txt_gz6.Text, this.txt_bz6.Text);
            this.gc_order_gp.DataSource = dt;
            this.gv_order_gp.OptionsView.ColumnAutoWidth = false;
            //this.gv_order_gp.OptionsSelection.MultiSelect = true;
            //this.gv_order_gp.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_order_gp.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_order_gp);
        }

        private void btn_tj2_Click(object sender, EventArgs e)
        {


            //统计类别: 1轧钢2连铸，3钢种,4产线规格
            DataTable dt = bll_ini_order.GetOrderIniTJ(this.lbl_fazj.Text, this.txt_gz3.Text.Trim(), this.txt_bz3.Text.Trim(), this.cbo_zx2.EditValue == null ? "" : this.cbo_zx2.EditValue.ToString().Trim(), this.cbo_lz2.EditValue == null ? "" : this.cbo_lz2.EditValue.ToString().Trim(), null, null, this.rbtn_tj.Properties.Items[this.rbtn_tj.SelectedIndex].Value.ToString());
            this.gc_tj2.DataSource = dt;
            #region 统计主界面
            if (this.rbtn_tj.Properties.Items[this.rbtn_tj.SelectedIndex].Value.ToString() == "1")
            {
                this.gc_tj2.MainView = this.gv_tj_zg;
                this.gv_tj_zg.OptionsView.ColumnAutoWidth = false;
                //this.gv_tj_zg.OptionsSelection.MultiSelect = true;
                this.gv_tj_zg.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_tj_zg);
            }
            if (this.rbtn_tj.Properties.Items[this.rbtn_tj.SelectedIndex].Value.ToString() == "2")
            {
                this.gc_tj2.MainView = this.gv_tj_lz;
                this.gv_tj_lz.OptionsView.ColumnAutoWidth = false;
                //this.gv_tj_lz.OptionsSelection.MultiSelect = true;
                this.gv_tj_lz.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_tj_lz);
            }
            if (this.rbtn_tj.Properties.Items[this.rbtn_tj.SelectedIndex].Value.ToString() == "3")
            {
                this.gc_tj2.MainView = this.gv_tj_gz;
                this.gv_tj_gz.OptionsView.ColumnAutoWidth = false;
                //this.gv_tj_gz.OptionsSelection.MultiSelect = true;
                this.gv_tj_gz.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_tj_gz);
            }
            if (this.rbtn_tj.Properties.Items[this.rbtn_tj.SelectedIndex].Value.ToString() == "4")
            {
                this.gc_tj2.MainView = this.gv_tj_gg;
                this.gv_tj_gg.OptionsView.ColumnAutoWidth = false;
                // this.gv_tj_gg.OptionsSelection.MultiSelect = true;
                this.gv_tj_gg.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_tj_gg);
            }
            #endregion

        }
    }
}
