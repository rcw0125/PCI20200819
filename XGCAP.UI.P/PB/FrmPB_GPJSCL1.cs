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
    public partial class FrmPB_GPJSCL1 : Form
    {
        public FrmPB_GPJSCL1()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TQB_SLAB_LEN_MATCH bll_TQB_SLAB_LEN_MATCH = new Bll_TQB_SLAB_LEN_MATCH();
        Bll_TPB_SLAB_CAPACITY bll_TPB_SLAB_CAPACITY = new Bll_TPB_SLAB_CAPACITY();

        private string strMenuName;
        private void FrmPB_GPJSCL1_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                cbo_DM.SelectedIndex = 0;
                sub.ImageComboBoxEditBindGX("", cbo_GX1, "'CC'");
                cbo_GX1.SelectedIndex = 0;
                sub.ImageComboBoxEditBindGX("", cbo_GX2, "'CC'");
                cbo_GX2.SelectedIndex = 0;
                cbo_ys.SelectedIndex = 0;
                cbo_YS2.SelectedIndex = 0;
                Query();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void Query()
        {
            try
            {
                DataTable dt = null;
                dt = bll_TQB_STD_MAIN.GetGLList(txt_Grd.Text, "", txt_Std.Text).Tables[0];
                this.gc_StdMain.DataSource = dt;
                this.gv_StdMain.OptionsView.ColumnAutoWidth = false;
                this.gv_StdMain.OptionsSelection.MultiSelect = true;
                gv_StdMain.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.gv_StdMain.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_StdMain);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void QueryMain()
        {
            WaitingFrom.ShowWait("");
            DataTable dt = null;
            dt = bll_TPB_SLAB_CAPACITY.GetList(cbo_GW2.EditValue.ToString(), "", txt_GZ2.Text, 1, txt_ZXBZ.Text, cbo_YS2.EditValue.ToString()).Tables[0];
            this.gc_GWJSCL.DataSource = dt;
            this.gv_GWJSCL.OptionsView.ColumnAutoWidth = false;
            this.gv_GWJSCL.OptionsSelection.MultiSelect = true;
            gv_GWJSCL.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_GWJSCL.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GWJSCL);
            WaitingFrom.CloseWait();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认保存信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                if (cbo_GW.EditValue.ToString() != "")
                {
                    if (cbo_DM.EditValue.ToString() != "")
                    {
                        if (txt_JSCN.Text.Trim() != "")
                        {
                            int[] rownumber = this.gv_StdMain.GetSelectedRows();//获取选中行号数组；
                            int succount = 0;
                            string str = "";
                            if (rownumber.Count() > 0)
                            {
                                foreach (var item in rownumber)
                                {
                                    Mod_TPB_SLAB_CAPACITY mod_TPB_SLAB_CAPACITY = new Mod_TPB_SLAB_CAPACITY();
                                    mod_TPB_SLAB_CAPACITY.C_PROD_NAME = gv_StdMain.GetRowCellValue(item, "C_PROD_NAME") == null ? null : gv_StdMain.GetRowCellValue(item, "C_PROD_NAME").ToString();
                                    mod_TPB_SLAB_CAPACITY.C_STL_GRD = gv_StdMain.GetRowCellValue(item, "C_STL_GRD") == null ? null : gv_StdMain.GetRowCellValue(item, "C_STL_GRD").ToString();
                                    mod_TPB_SLAB_CAPACITY.C_STD_CODE = gv_StdMain.GetRowCellValue(item, "C_STD_CODE") == null ? null : gv_StdMain.GetRowCellValue(item, "C_STD_CODE").ToString();
                                    if (cbo_DM.Enabled == true)
                                    {
                                        mod_TPB_SLAB_CAPACITY.C_SPEC = cbo_DM.EditValue.ToString();
                                    }
                                    mod_TPB_SLAB_CAPACITY.C_TYPE = cbo_ys.EditValue.ToString();
                                    mod_TPB_SLAB_CAPACITY.C_STA_ID = cbo_GW.EditValue.ToString();
                                    mod_TPB_SLAB_CAPACITY.N_CAPACITY = Convert.ToDecimal(txt_JSCN.Text);
                                    mod_TPB_SLAB_CAPACITY.C_EMP_ID = RV.UI.UserInfo.userID;

                                    #region 检测是否重复添加
                                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                                    ht.Add("C_PROD_NAME", mod_TPB_SLAB_CAPACITY.C_PROD_NAME);
                                    ht.Add("C_STA_ID", mod_TPB_SLAB_CAPACITY.C_STA_ID);
                                    ht.Add("C_SPEC", mod_TPB_SLAB_CAPACITY.C_SPEC);
                                    ht.Add("C_STL_GRD", mod_TPB_SLAB_CAPACITY.C_STL_GRD);
                                    ht.Add("C_STD_CODE", mod_TPB_SLAB_CAPACITY.C_STD_CODE);
                                    ht.Add("N_STATUS", 1);
                                    if (Common.CheckRepeat.CheckTable("TPB_SLAB_CAPACITY", ht) > 0)
                                    {
                                        str += mod_TPB_SLAB_CAPACITY.C_PROD_NAME + "(" + mod_TPB_SLAB_CAPACITY.C_STL_GRD + "/" + mod_TPB_SLAB_CAPACITY.C_STD_CODE + "),";
                                    }
                                    else
                                    {
                                        bll_TPB_SLAB_CAPACITY.Add(mod_TPB_SLAB_CAPACITY);
                                        succount += 1;
                                    }
                                    #endregion
                                }
                                if (str.Length > 0)
                                {
                                    MessageBox.Show("共" + rownumber.Count() + "条数据，保存成功" + succount + "条," + str.Substring(0, str.Length - 1) + "已存在！");
                                    cbo_GW2.EditValue = cbo_GW.EditValue;
                                    cbo_GX2.EditValue = cbo_GX1.EditValue;
                                    QueryMain();
                                }
                                else
                                {
                                    MessageBox.Show("保存成功！");
                                    cbo_GW2.EditValue = cbo_GW.EditValue;
                                    cbo_GX2.EditValue = cbo_GX1.EditValue;
                                    QueryMain();
                                }
                            }
                            else
                            {
                                MessageBox.Show("请选择钢种！");
                                gv_StdMain.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("请输入机时产能！");
                            txt_JSCN.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择断面！");
                        cbo_DM.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("请选择工位！");
                    cbo_GW.Focus();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void btn_QueryMain_Click(object sender, EventArgs e)
        {
            try
            {
                QueryMain();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int selectedNum = this.gv_GWJSCL.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_GWJSCL.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_GWJSCL.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TPB_SLAB_CAPACITY model = bll_TPB_SLAB_CAPACITY.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.D_END_DATE = RV.UI.ServerTime.timeNow();
                    bool update = bll_TPB_SLAB_CAPACITY.Update(model);
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

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除钢坯机时产能");//添加操作日志

                QueryMain();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbo_GW_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_GW.Text.Contains("铸"))
                {
                    cbo_DM.Enabled = true;
                }
                else
                {
                    cbo_DM.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbo_GX1_SelectedValueChanged(object sender, EventArgs e)
        {
            sub.ImageComboBoxEditBindGW(cbo_GX1.EditValue.ToString(), cbo_GW);
            cbo_GW.SelectedIndex = 0;
        }

        private void cbo_GX2_SelectedValueChanged(object sender, EventArgs e)
        {
            sub.ImageComboBoxEditBindGW(cbo_GX2.EditValue.ToString(), cbo_GW2);
            cbo_GW2.Properties.Items.Add("全部", "", 0);
            cbo_GW2.SelectedIndex = cbo_GW2.Properties.Items.Count - 1;
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_GWJSCL.GetDataRow(this.gv_GWJSCL.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmPB_GPJSCN_EDIT frm = new FrmPB_GPJSCN_EDIT();
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    QueryMain();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DCZGCN_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_GWJSCL);
        }

        //private void rbtn_isty_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (rbtn_isty.SelectedIndex == 0)
        //    {
        //        btn_Stop.Enabled = true;
        //        btn_Update.Enabled = true;
        //    }
        //    else
        //    {
        //        btn_Stop.Enabled = false;
        //        btn_Update.Enabled = false;
        //    }
        //}
    }
}
