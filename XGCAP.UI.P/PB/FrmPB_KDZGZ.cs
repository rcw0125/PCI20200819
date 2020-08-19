using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_KDZGZ : Form
    {
        public FrmPB_KDZGZ()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();
        Bll_TPB_REPLACE_GRD bll_TPB_REPLACE_GRD = new Bll_TPB_REPLACE_GRD();

        private string strMenuName;


        private void FrmPB_KDZGZ_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                lbl_std_main_id.Text = "";
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 查询数据并绑定
        /// </summary>
        private void Query()
        {
            DataTable dt = null;
            dt = bll_TQB_STD_MAIN.GetList(txt_Std.Text, txt_Grd.Text).Tables[0];
            this.gc_StdMain.DataSource = dt;
            this.gv_StdMain.OptionsView.ColumnAutoWidth = false;
            this.gv_StdMain.OptionsSelection.MultiSelect = true;
            this.gv_StdMain.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdMain);
            //DataRow dr_StdMain = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
            //BindGZBZXM(dr_StdMain);
            //BindKDZGZ(dr_StdMain);
        }
        private void BindGZBZXM(DataRow dr)
        {
            DataTable dt = null;
            dt = bll_TQB_STD_MAIN.GetListByGZ(dr["c_stl_grd"].ToString(), dr["c_std_code"].ToString()).Tables[0];
            this.gc_BZGZXM.DataSource = dt;
            this.gv_BZGZXM.OptionsView.ColumnAutoWidth = false;
            this.gv_BZGZXM.OptionsSelection.MultiSelect = true;
            this.gv_BZGZXM.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_BZGZXM.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_BZGZXM);
        }
        private void BindKDZGZ(DataRow dr)
        {
            DataTable dt = null;
            dt = bll_TPB_REPLACE_GRD.GetList(dr["c_stl_grd"].ToString(), dr["c_std_code"].ToString()).Tables[0];
            this.gc_KDZGZ.DataSource = dt;
            this.gv_KDZGZ.OptionsView.ColumnAutoWidth = false;
            this.gv_KDZGZ.OptionsSelection.MultiSelect = true;
            this.gv_KDZGZ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_KDZGZ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_KDZGZ);
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                Query();
                gv_StdMain_FocusedRowChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gv_StdMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int selectedHandle = this.gv_StdMain.FocusedRowHandle;//获取焦点行索引
                if (selectedHandle < 0)
                {
                    this.lbl_std_main_id.Text = "";

                    return;
                }
                this.lbl_std_main_id.Text = this.gv_StdMain.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
                this.txt_xzgz.Text = this.gv_StdMain.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();//获取焦点行钢种
                this.txt_xzbz.Text = this.gv_StdMain.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();//获取焦点行标准
                                                                                                              //DataRow dr_StdMain = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);

                btn_query2_Click(null, null);
                BindKDZInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                //DataRow dr_StdMain = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
                string strGZ = this.txt_xzgz.Text.Trim();//选中行钢种
                string strBZ = this.txt_xzbz.Text.Trim();//选中行标准
                string strID = this.lbl_std_main_id.Text;//选中行主键

                string strXM = "";//修磨要求
                if (this.chk_xm.Checked)
                {
                    strXM = chk_xm.Text;
                }
                else if (this.chk_wxm.Checked)
                {
                    strXM = chk_wxm.Text;
                }
                string strSW = "";//首尾坯要求
                if (this.chk_fswl.Checked)
                {
                    strSW = chk_fswl.Text;
                }
                string strFP = "";//大方坯
                if (this.chk_dfp.Checked)
                {
                    strFP = chk_dfp.Text;
                }
                string strSL = "";//首炉要求
                if (this.ck_sl.Checked)
                {
                    strSL = ck_sl.Text;
                }
                string strRemark = this.txt_remark.Text.Trim();//备注
                int[] rownumber = this.gv_BZGZXM.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Count() > 0)
                {
                    foreach (var item in rownumber)
                    {
                        Mod_TPB_REPLACE_GRD mod_TPB_REPLACE_GRD = new Mod_TPB_REPLACE_GRD();
                        mod_TPB_REPLACE_GRD.C_EMP_ID = RV.UI.UserInfo.userID;
                        mod_TPB_REPLACE_GRD.C_STD_MAIN_ID = strID;
                        mod_TPB_REPLACE_GRD.C_STD_CODE = strBZ;
                        mod_TPB_REPLACE_GRD.C_STL_GRD = strGZ;
                        mod_TPB_REPLACE_GRD.C_SFXM = strXM;
                        mod_TPB_REPLACE_GRD.C_SLAB_TYPE = strFP;
                        mod_TPB_REPLACE_GRD.C_SWL = strSW;
                        mod_TPB_REPLACE_GRD.C_SL = strSL;
                        mod_TPB_REPLACE_GRD.C_REMARK = strRemark;
                        mod_TPB_REPLACE_GRD.C_STD_MAIN_KDZ_ID = this.gv_BZGZXM.GetRowCellValue(item, "C_ID").ToString();
                        mod_TPB_REPLACE_GRD.C_REPLACE_GRD = this.gv_BZGZXM.GetRowCellValue(item, "C_STL_GRD").ToString();
                        mod_TPB_REPLACE_GRD.C_REPLACE_STD_CODE = this.gv_BZGZXM.GetRowCellValue(item, "C_STD_CODE").ToString();
                        #region 检测是否重复添加
                        System.Collections.Hashtable ht = new System.Collections.Hashtable();
                        ht.Add("C_STL_GRD", mod_TPB_REPLACE_GRD.C_STL_GRD);
                        ht.Add("C_STD_CODE", mod_TPB_REPLACE_GRD.C_STD_CODE);
                        ht.Add("C_REPLACE_GRD", mod_TPB_REPLACE_GRD.C_REPLACE_GRD);
                        ht.Add("C_REPLACE_STD_CODE", mod_TPB_REPLACE_GRD.C_REPLACE_STD_CODE);
                        ht.Add("N_STATUS", 1);
                        if (Common.CheckRepeat.CheckTable("TPB_REPLACE_GRD", ht) > 0)
                        {
                            MessageBox.Show("保存失败！可代轧钢种"+ mod_TPB_REPLACE_GRD.C_REPLACE_GRD + "执行标准"+ mod_TPB_REPLACE_GRD.C_REPLACE_STD_CODE + "已存在!");
                            return;
                        }
                        #endregion
                        bll_TPB_REPLACE_GRD.Add(mod_TPB_REPLACE_GRD);            
                    }

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加可代轧钢种信息");//添加操作日志

                    MessageBox.Show("维护成功！");
                    //重新加载数据
                    QueryGZ2(this.txt_bz2.Text.Trim(), this.txt_gz1.Text.Trim(), this.lbl_std_main_id.Text.Trim());
                    BindKDZInfo();
                }
                else
                {
                    MessageBox.Show("未选中行！");
                    this.gv_BZGZXM.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("是否确认删除选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }
            int selectedNum = this.gv_KDZGZ.SelectedRowsCount;
            int commitNum = 0;//删除记录数量
            int failtNum = 0;//删除失败数量
            int[] rownumber = this.gv_KDZGZ.GetSelectedRows();//获取选中行号数组；
            for (int i = 0; i < rownumber.Length; i++)
            {
                int selectedHandle = rownumber[i];
                string strID = this.gv_KDZGZ.GetRowCellValue(selectedHandle, "C_ID").ToString();
                Mod_TPB_REPLACE_GRD model = bll_TPB_REPLACE_GRD.GetModel(strID);
                model.N_STATUS = 0;
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                model.D_END_DATE = RV.UI.ServerTime.timeNow();
                bool update = bll_TPB_REPLACE_GRD.Update(model);
                if (update)
                {
                    commitNum = commitNum + 1;
                }
                else
                {
                    failtNum = failtNum + 1;
                }
            }
            MessageBox.Show("选择" + selectedNum.ToString() + "条记录，删除" + commitNum.ToString() + "条记录！");
            //重新加载数据
            QueryGZ2(this.txt_bz2.Text.Trim(), this.txt_gz1.Text.Trim(), this.lbl_std_main_id.Text.Trim());
            BindKDZInfo();
        }


        /// <summary>
        /// 查询待匹配钢种数据并绑定
        /// </summary>
        /// <param name="strGZ">钢种</param>
        /// <param name="strBZ">标准</param>
        /// <param name="strStdMainID">主键</param>
        private void QueryGZ2(string strBZ, string strGZ, string strStdMainID)
        {
            try
            {
                DataTable dt = null;
                dt = bll_TQB_STD_MAIN.GetListKDZ(strBZ, strGZ, strStdMainID).Tables[0];
                this.gc_BZGZXM.DataSource = dt;
                this.gv_BZGZXM.OptionsView.ColumnAutoWidth = false;
                this.gv_BZGZXM.OptionsSelection.MultiSelect = true;
                gv_BZGZXM.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.gv_BZGZXM.BestFitColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

        private void btn_query2_Click(object sender, EventArgs e)
        {
            try
            {
                QueryGZ2(this.txt_bz2.Text.Trim(), this.txt_gz1.Text.Trim(), this.lbl_std_main_id.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_query3_Click(object sender, EventArgs e)
        {
            try
            {
                BindKDZInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        /// <summary>
        /// 查询可代轧
        /// </summary>
        public void BindKDZInfo()
        {
            string strGZ = this.txt_gz3.Text.Trim();
            string strBZ = this.txt_bz3.Text.Trim();
            string strDZGZ = this.txt_gz4.Text.Trim();
            string strDZBZ = this.txt_bz4.Text.Trim();
            int iStatus = 1;
            string strgrd = "";
            string strbz = "";
            if (this.rbtn_xz.SelectedIndex == 0)
            {
                strgrd = this.txt_xzgz.Text.Trim();
                strbz = this.txt_xzbz.Text.Trim();
            }
            DataTable dt = bll_TPB_REPLACE_GRD.BindKDZInfo(strGZ, strBZ, strDZGZ, strDZBZ, iStatus, strgrd,strbz).Tables[0];
            this.gc_KDZGZ.DataSource = dt;
            this.gv_KDZGZ.OptionsView.ColumnAutoWidth = false;
            this.gv_KDZGZ.OptionsSelection.MultiSelect = true;
            gv_KDZGZ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_KDZGZ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_KDZGZ);
        }
        /// <summary>
        /// 选中改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_xm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string strChk = chk_xm.CheckState.ToString();//Unchecked Checked
                if (strChk == "Checked")
                {
                    if (this.chk_wxm.Checked)
                    {
                        this.chk_wxm.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

        private void chk_wxm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string strChk = chk_wxm.CheckState.ToString();//Unchecked Checked
                if (strChk == "Checked")
                {
                    if (this.chk_xm.Checked)
                    {
                        this.chk_xm.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
        }

        private void gv_StdMain_Click(object sender, EventArgs e)
        {
            try
            {
                gv_StdMain_FocusedRowChanged(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_DCKDZGZ_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_KDZGZ);
        }
    }
}
