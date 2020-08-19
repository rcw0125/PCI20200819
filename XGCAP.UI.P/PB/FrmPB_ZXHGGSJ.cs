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
    public partial class FrmPB_ZXHGGSJ : Form
    {
        public FrmPB_ZXHGGSJ()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TPB_LINE_SPEC bll_TPB_LINE_SPEC = new Bll_TPB_LINE_SPEC();
        Bll_TPB_CHANGESPEC_TIME bll_TPB_CHANGESPEC_TIME = new Bll_TPB_CHANGESPEC_TIME();

        private string strMenuName;

        private void FrmPB_ZXHGGSJ_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                cbo_CX1.EditValue = "";
                cbo_CX2.EditValue = "";
                cbo_GHQ.EditValue = "";
                cbo_GHH.EditValue = "";
                sub.ImageComboBoxEditBindGWByGX("ZX", this.cbo_CX1);
                cbo_CX1.SelectedIndex = 0;
                sub.ImageComboBoxEditBindGWByGX("ZX", this.cbo_CX2);
                cbo_CX2.Properties.Items.Add("全部", "", 0);
                cbo_CX2.SelectedIndex = cbo_CX2.Properties.Items.Count - 1;
                this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox();
                Query();
                BindGWJSCL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        private void Query()
        {
            DataTable dt = null;
            dt = bll_TPB_LINE_SPEC.GetSPECList(cbo_CX1.EditValue.ToString(), "", "", "1").Tables[0];
            this.gc_GG.DataSource = dt;
            this.gv_GG.OptionsView.ColumnAutoWidth = false;
            this.gv_GG.OptionsSelection.MultiSelect = true;
            //gv_GW.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GG.BestFitColumns();
            DataRow dr_StdMain = gv_GG.GetDataRow(gv_GG.FocusedRowHandle);
            BindGGSJ(dr_StdMain);

        }

        private void BindGGSJ(DataRow dr)
        {
            DataTable dt = null;
            if (dr != null)
            {
                dt = bll_TPB_LINE_SPEC.GetSPECList(cbo_CX1.EditValue.ToString(), dr["C_SPEC"].ToString(), "C_L_SPEC", "1").Tables[0];
                this.gc_GGSJ.DataSource = dt;
                this.gv_GGSJ.OptionsView.ColumnAutoWidth = false;
                this.gv_GGSJ.OptionsSelection.MultiSelect = true;
                this.gv_GGSJ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.gv_GGSJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GGSJ);
            }

        }
        private void BindGWJSCL()
        {
            WaitingFrom.ShowWait("");
            DataTable alldt = null;
            alldt = bll_TPB_CHANGESPEC_TIME.GetList(1, cbo_CX2.EditValue.ToString(), cbo_GHQ.EditValue.ToString(), cbo_GHH.EditValue.ToString()).Tables[0];
            this.gc_ZGCXHGGSJ.DataSource = alldt;
            this.gv_ZGCXHGGSJ.OptionsView.ColumnAutoWidth = false;
            this.gv_ZGCXHGGSJ.OptionsSelection.MultiSelect = true;
            this.gv_ZGCXHGGSJ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_ZGCXHGGSJ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ZGCXHGGSJ);
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                if (this.cbo_CX1.EditValue.ToString() == "")
                {
                    MessageBox.Show("请选择工位！");
                    this.cbo_CX1.Focus();
                    return;
                }
                else
                {
                    DataRow dr_StdMain = gv_GG.GetDataRow(gv_GG.FocusedRowHandle);

                    int[] rownumber = this.gv_GGSJ.GetSelectedRows();//获取选中行号数组；
                    int succount = 0;
                    string str = "";
                    if (rownumber.Count() > 0)
                    {
                        foreach (var item in rownumber)
                        {
                            Mod_TPB_CHANGESPEC_TIME mod_TPB_CHANGESPEC_TIME = new Mod_TPB_CHANGESPEC_TIME();
                            mod_TPB_CHANGESPEC_TIME.C_EMP_ID = RV.UI.UserInfo.userID;
                            mod_TPB_CHANGESPEC_TIME.C_STA_ID = cbo_CX1.EditValue.ToString();
                            mod_TPB_CHANGESPEC_TIME.C_B_SPEC = dr_StdMain["C_SPEC"].ToString();
                            mod_TPB_CHANGESPEC_TIME.C_L_SPEC = this.gv_GGSJ.GetRowCellValue(item, "C_SPEC").ToString();
                            if (this.gv_GGSJ.GetRowCellValue(item, "N_TIME").ToString() != "")
                            {
                                mod_TPB_CHANGESPEC_TIME.N_TIME = Convert.ToDecimal(this.gv_GGSJ.GetRowCellValue(item, "N_TIME"));
                                bll_TPB_CHANGESPEC_TIME.Add(mod_TPB_CHANGESPEC_TIME);
                                succount += 1;
                            }
                            else
                            {
                                str += mod_TPB_CHANGESPEC_TIME.C_L_SPEC + ",";
                            }
                        }
                        if (str.Length > 0)
                        {
                            MessageBox.Show("共" + rownumber.Count() + "条数据，保存成功" + succount + "条," + str.Substring(0, str.Length - 1) + "时间未输入！");
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加轧线换规格时间信息");//添加操作日志
                            cbo_CX2.EditValue = cbo_CX1.EditValue;
                            Query();
                            BindGWJSCL();
                        }
                        else
                        {
                            MessageBox.Show("共" + rownumber.Count() + "条数据，保存成功" + succount + "条");
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加轧线换规格时间信息");//添加操作日志
                            cbo_CX2.EditValue = cbo_CX1.EditValue;
                            Query();
                            BindGWJSCL();
                        }

                    }
                    else
                    {
                        MessageBox.Show("未选中行");
                        this.gv_GGSJ.Focus();
                        cbo_CX2.EditValue = cbo_CX1.EditValue;
                        return;
                    }
                }
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
                if (DialogResult.No == MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_ZGCXHGGSJ.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_ZGCXHGGSJ.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_ZGCXHGGSJ.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TPB_CHANGESPEC_TIME model = bll_TPB_CHANGESPEC_TIME.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.D_END_DATE = RV.UI.ServerTime.timeNow();
                    bool update = bll_TPB_CHANGESPEC_TIME.Update(model);
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
                Query();
                BindGWJSCL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void gv_GG_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr_StdMain = gv_GG.GetDataRow(gv_GG.FocusedRowHandle);
                BindGGSJ(dr_StdMain);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void cbo_CX1_SelectedValueChanged(object sender, EventArgs e)
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

        private void btn_Query2_Click(object sender, EventArgs e)
        {
            try
            {
                BindGWJSCL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("规格请输入数字类型或根据选择产线选择规格!");
            }



        }

        private void cbo_CX2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                sub.ComboBoxEditBindSPECByGW(cbo_CX2.EditValue.ToString(), cbo_GHQ, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbo_GHQ_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                sub.ComboBoxEditBindSPECByGW(cbo_CX2.EditValue.ToString(), cbo_GHH, cbo_GHQ.EditValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //private void btn_Reset_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ClearContent.ClearPanelControl(panelControl7.Controls);
        //        cbo_CX2.EditValue = "";
        //        cbo_GHQ.EditValue = "";
        //        cbo_GHH.EditValue = "";
        //        rbtn_isty.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_ZGCXHGGSJ.GetDataRow(this.gv_ZGCXHGGSJ.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmPB_ZGHGGSJ_EDIT frm = new FrmPB_ZGHGGSJ_EDIT();
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    BindGWJSCL();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DCHGGSJ_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_ZGCXHGGSJ);
        }
    }
}
