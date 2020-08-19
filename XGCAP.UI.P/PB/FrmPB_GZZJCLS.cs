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
using Common;

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_GZZJCLS : Form
    {
        public FrmPB_GZZJCLS()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TPB_CAST_STOVE bll_TPB_CAST_STOVE = new Bll_TPB_CAST_STOVE();
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();

        private string strMenuName;

        private void FrmPB_GZZJCLS_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                sub.ImageComboBoxEditBindGWByGX("CC",cbo_GW1);
                cbo_GW1.SelectedIndex = 0;
                sub.ImageComboBoxEditBindGWByGX("CC", cbo_GW2);
                cbo_GW2.Properties.Items.Add("全部","",0);
                cbo_GW2.SelectedIndex = cbo_GW2.Properties.Items.Count-1;
                Query();
                Query2();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
         
        }

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
        /// 查询
        /// </summary>
        private void Query()
        {
            DataTable dt = null;
            dt = bll_TQB_STD_MAIN.GetList(txt_Std.Text, txt_Grd.Text).Tables[0];
            this.gc_StdMain.DataSource = dt;
            this.gv_StdMain.OptionsView.ColumnAutoWidth = false;
            this.gv_StdMain.OptionsSelection.MultiSelect = true;
            gv_StdMain.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_StdMain.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdMain);
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                if (cbo_GW1.EditValue.ToString()=="")
                {
                    MessageBox.Show("未选中工位！");
                    return;
                }
                if (txt_MAX.Text.Trim()==""|| txt_MAX.Text.Trim() == "0")
                {
                    MessageBox.Show("最大炉数不能为空或为0！");
                    return;
                }
                if (txt_MBLS.Text.Trim() == "" || txt_MBLS.Text.Trim() == "0")
                {
                    MessageBox.Show("目标炉数不能为空或为0！");
                    return;
                }
                if (txt_MIN.Text.Trim() == "" || txt_MIN.Text.Trim() == "0")
                {
                    MessageBox.Show("最小炉数不能为空或为0！");
                    return;
                }
                if (Convert.ToInt32(txt_MIN.Text)> Convert.ToInt32(txt_MIN.Text.Trim()))
                {
                    MessageBox.Show("最大炉数不能小于最小炉数！");
                    return;
                }
                int[] rownumber = this.gv_StdMain.GetSelectedRows();//获取选中行号数组；
                int succount = 0;
                string str = "";
                if (rownumber.Count() > 0)
                {
                    foreach (var item in rownumber)
                    {

                        Mod_TPB_CAST_STOVE mod_TPB_CAST_STOVE = new Mod_TPB_CAST_STOVE();
                        mod_TPB_CAST_STOVE.C_EMP_ID = RV.UI.UserInfo.userID;
                        mod_TPB_CAST_STOVE.C_STD_CODE = this.gv_StdMain.GetRowCellValue(item, "C_STD_CODE").ToString();
                        mod_TPB_CAST_STOVE.C_STL_GRD = this.gv_StdMain.GetRowCellValue(item, "C_STL_GRD").ToString();
                        mod_TPB_CAST_STOVE.C_STA_ID = cbo_GW1.EditValue.ToString();
                        if (txt_MAX.Text != "")
                        {
                            mod_TPB_CAST_STOVE.N_STOVE_MAX_NUM = Convert.ToDecimal(txt_MAX.Text);
                        }
                        if (txt_MIN.Text != "")
                        {
                            mod_TPB_CAST_STOVE.N_STOVE_MIN_NUM = Convert.ToDecimal(txt_MIN.Text);
                        }
                        if (txt_MBLS.Text != "")
                        {
                            mod_TPB_CAST_STOVE.N_TARGET_NUM = Convert.ToDecimal(txt_MBLS.Text);
                        }
                        if (bll_TPB_CAST_STOVE.ExistsDate(mod_TPB_CAST_STOVE.C_STL_GRD, mod_TPB_CAST_STOVE.C_STD_CODE,mod_TPB_CAST_STOVE.C_STA_ID))
                        {
                            str += cbo_GW1.Text+"下"+ mod_TPB_CAST_STOVE.C_STL_GRD + "(" + mod_TPB_CAST_STOVE.C_STD_CODE + "),";
                        }
                        else
                        {
                            bll_TPB_CAST_STOVE.Add(mod_TPB_CAST_STOVE);
                            succount += 1;
                        }
                    }
                    if (str.Length > 0)
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钢种整浇次炉数");//添加操作日志

                        MessageBox.Show("共" + rownumber.Count() + "条数据，保存成功" + succount + "条," + str.Substring(0, str.Length - 1) + "已存在！");
                        cbo_GW2.EditValue = cbo_GW1.EditValue;
                        Query2();
                    }
                    else
                    {
                        MessageBox.Show("共" + rownumber.Count() + "条数据，保存成功" + succount + "条");
                        cbo_GW2.EditValue = cbo_GW1.EditValue;
                        Query2();
                    }
                }
                else
                {
                    MessageBox.Show("未选中行");
                    this.gv_StdMain.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }
        private void Query2()
        {
            WaitingFrom.ShowWait("");
            DataTable alldt = null;
            alldt = bll_TPB_CAST_STOVE.GetList(1,txt_GZ2.Text,txt_ZXBZ2.Text,cbo_GW2.EditValue.ToString()).Tables[0];
            this.gc_ZJCLS.DataSource = alldt;
            this.gv_ZJCLS.OptionsView.ColumnAutoWidth = false;
            this.gv_ZJCLS.OptionsSelection.MultiSelect = true;
            this.gv_ZJCLS.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_ZJCLS.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ZJCLS);
            //if (rbtn_isty.SelectedIndex == 0)
            //{
            //    this.btn_Stop.Enabled = true;
            //}
            //else
            //{
            //    this.btn_Stop.Enabled = false;
            //}
            WaitingFrom.CloseWait();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_ZJCLS.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_ZJCLS.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_ZJCLS.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TPB_CAST_STOVE model = bll_TPB_CAST_STOVE.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.D_END_DATE = RV.UI.ServerTime.timeNow();
                    bool update = bll_TPB_CAST_STOVE.Update(model);
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

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除钢种整浇次炉数信息");//添加操作日志

                Query2();//重新加载
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_Query2_Click(object sender, EventArgs e)
        {
            try
            {
                Query2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_ZJCLS.GetDataRow(this.gv_ZJCLS.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmPB_GZZJCLS_EDIT frm = new FrmPB_GZZJCLS_EDIT();
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    Query2();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DCGZZJCLS_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_ZJCLS);
        }
    }
}
