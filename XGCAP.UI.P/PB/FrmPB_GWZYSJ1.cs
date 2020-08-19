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
    public partial class FrmPB_GWZYSJ1 : Form
    {
        public FrmPB_GWZYSJ1()
        {
            InitializeComponent();
        }
        private string strMenuName;
        CommonSub commonSub = new CommonSub();
        Bll_TPB_STA_MOVETIME bll_TPB_STA_MOVETIME = new Bll_TPB_STA_MOVETIME();
        Bll_TB_STA bllSta = new Bll_TB_STA();
        private void FrmPB_GWZYSJ1_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                commonSub.ImageComboBoxEditBindGX("",cbo_GX1, "'GL','ZL','LF','RH'");
                cbo_GX1.Properties.Items.Add("全部", "", 0);
                cbo_GX1.SelectedIndex = cbo_GX1.Properties.Items.Count - 1;
                BindCbolst(cbolst_GL);
                BindCbolst(cbolst_ZL);
                BindCbolst(cbolst_LF);
                BindCbolst(cbolst_RH);
                BindCbolst(cbolst_CC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        /// <summary>
        /// 加载所有工位信息
        /// </summary>
        /// <param name="cbolst"></param>
        public void BindCbolst(DevExpress.XtraEditors.CheckedListBoxControl cbolst)
        {
            DataTable dt = bllSta.GetListByGXDM(cbolst.Tag.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbolst.Items.Add(dt.Rows[i]["C_ID"].ToString(), dt.Rows[i]["C_STA_DESC"].ToString());
                }

            }
        }
        private void ExistsCount()
        {
            if (cbolst_GL.CheckedItemsCount + cbolst_CC.CheckedItemsCount + cbolst_LF.CheckedItemsCount + cbolst_RH.CheckedItemsCount + cbolst_ZL.CheckedItemsCount > 1)
            {
                string gwstr1 = "";
                string gwstr2 = "";

                if (cbolst_GL.CheckedItemsCount == 0)
                {
                    cbolst_GL.Enabled = false;
                }
                else
                {
                    for (int i = 0; i < cbolst_GL.Items.Count; i++)
                    {
                        if (cbolst_GL.Items[i].CheckState == CheckState.Checked)
                        {
                            gwstr1 = cbolst_GL.Items[i].Value.ToString();
                        }
                    }


                }
                if (cbolst_ZL.CheckedItemsCount == 0)
                {
                    cbolst_ZL.Enabled = false;
                }
                else
                {
                    if (gwstr1 == "")
                    {
                        for (int i = 0; i < cbolst_ZL.Items.Count; i++)
                        {
                            if (cbolst_ZL.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr1 = cbolst_ZL.Items[i].Value.ToString();
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < cbolst_ZL.Items.Count; i++)
                        {
                            if (cbolst_ZL.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr2 = cbolst_ZL.Items[i].Value.ToString();
                            }
                        }
                    }
                }
                if (cbolst_LF.CheckedItemsCount == 0)
                {
                    cbolst_LF.Enabled = false;
                }
                else
                {
                    if (gwstr1 == "")
                    {
                        for (int i = 0; i < cbolst_LF.Items.Count; i++)
                        {
                            if (cbolst_LF.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr1 = cbolst_LF.Items[i].Value.ToString();
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < cbolst_LF.Items.Count; i++)
                        {
                            if (cbolst_LF.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr2 = cbolst_LF.Items[i].Value.ToString();
                            }
                        }
                    }
                }
                if (cbolst_RH.CheckedItemsCount == 0)
                {
                    cbolst_RH.Enabled = false;
                }
                else
                {
                    if (gwstr1 == "")
                    {
                        for (int i = 0; i < cbolst_RH.Items.Count; i++)
                        {
                            if (cbolst_RH.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr1 = cbolst_RH.Items[i].Value.ToString();
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < cbolst_RH.Items.Count; i++)
                        {
                            if (cbolst_RH.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr2 = cbolst_RH.Items[i].Value.ToString();
                            }
                        }
                    }
                }
                if (cbolst_CC.CheckedItemsCount == 0)
                {
                    cbolst_CC.Enabled = false;
                }
                else
                {
                    if (gwstr1 == "")
                    {
                        for (int i = 0; i < cbolst_CC.Items.Count; i++)
                        {
                            if (cbolst_CC.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr1 = cbolst_CC.Items[i].Value.ToString();
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < cbolst_CC.Items.Count; i++)
                        {
                            if (cbolst_CC.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr2 = cbolst_CC.Items[i].Value.ToString();
                            }
                        }
                    }
                }
                DataTable dt = bll_TPB_STA_MOVETIME.GetList(gwstr1, gwstr2, "1").Tables[0];
                if (dt.Rows.Count > 0)
                {
                    txt_Time1.Text = dt.Rows[0]["N_TIME"].ToString();
                }
            }
            else
            {
                if (cbolst_GL.CheckedItemsCount == 0)
                {
                    cbolst_GL.Enabled = true;
                }

                if (cbolst_CC.CheckedItemsCount == 0)
                {
                    cbolst_CC.Enabled = true;
                }

                if (cbolst_LF.CheckedItemsCount == 0)
                {
                    cbolst_LF.Enabled = true;
                }

                if (cbolst_RH.CheckedItemsCount == 0)
                {
                    cbolst_RH.Enabled = true;
                }
                if (cbolst_ZL.CheckedItemsCount == 0)
                {
                    cbolst_ZL.Enabled = true;
                }
                txt_Time1.Text = "0";
            }

        }



        private void btn_QueryMain_Click(object sender, EventArgs e)
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
        private void Query()
        {
            DataTable dt = bll_TPB_STA_MOVETIME.GetListByGXGW(cbo_GX1.EditValue.ToString(),cbo_GW.EditValue.ToString(), "1").Tables[0];
            this.gc_GWYDSJ.DataSource = dt;
            this.gv_GWYDSJ.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_GWYDSJ.OptionsSelection.MultiSelect = true;//允许多选
            this.gv_GWYDSJ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            colC_STA_ID1.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            colC_STA_ID2.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            this.gv_GWYDSJ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GWYDSJ);
        }

        private void btn_save_fagw_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbolst_GL.CheckedItemsCount + cbolst_CC.CheckedItemsCount + cbolst_LF.CheckedItemsCount + cbolst_RH.CheckedItemsCount + cbolst_ZL.CheckedItemsCount < 2)
                {
                    MessageBox.Show("必须选中俩个工位！");
                    return;
                }
                if (txt_Time1.Text == "0")
                {
                    MessageBox.Show("时间不能为空或为0！");
                    return;
                }
                if (DialogResult.No == MessageBox.Show("是否确认保存选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                string gwstr1 = "";
                string gwstr2 = "";
                if (cbolst_GL.CheckedItemsCount == 0)
                {
                    cbolst_GL.Enabled = false;
                }
                else
                {
                    if (gwstr1 == "")
                    {
                        for (int i = 0; i < cbolst_GL.Items.Count; i++)
                        {
                            if (cbolst_GL.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr1 = cbolst_GL.Items[i].Value.ToString();
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < cbolst_GL.Items.Count; i++)
                        {
                            if (cbolst_GL.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr2 = cbolst_GL.Items[i].Value.ToString();
                            }
                        }
                    }
                }
                if (cbolst_ZL.CheckedItemsCount == 0)
                {
                    cbolst_ZL.Enabled = false;
                }
                else
                {
                    if (gwstr1 == "")
                    {
                        for (int i = 0; i < cbolst_ZL.Items.Count; i++)
                        {
                            if (cbolst_ZL.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr1 = cbolst_ZL.Items[i].Value.ToString();
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < cbolst_ZL.Items.Count; i++)
                        {
                            if (cbolst_ZL.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr2 = cbolst_ZL.Items[i].Value.ToString();
                            }
                        }
                    }
                }
                if (cbolst_LF.CheckedItemsCount == 0)
                {
                    cbolst_LF.Enabled = false;
                }
                else
                {
                    if (gwstr1 == "")
                    {
                        for (int i = 0; i < cbolst_LF.Items.Count; i++)
                        {
                            if (cbolst_LF.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr1 = cbolst_LF.Items[i].Value.ToString();
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < cbolst_LF.Items.Count; i++)
                        {
                            if (cbolst_LF.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr2 = cbolst_LF.Items[i].Value.ToString();
                            }
                        }
                    }
                }
                if (cbolst_RH.CheckedItemsCount == 0)
                {
                    cbolst_RH.Enabled = false;
                }
                else
                {
                    if (gwstr1 == "")
                    {
                        for (int i = 0; i < cbolst_RH.Items.Count; i++)
                        {
                            if (cbolst_RH.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr1 = cbolst_RH.Items[i].Value.ToString();
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < cbolst_RH.Items.Count; i++)
                        {
                            if (cbolst_RH.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr2 = cbolst_RH.Items[i].Value.ToString();
                            }
                        }
                    }
                }
                if (cbolst_CC.CheckedItemsCount == 0)
                {
                    cbolst_CC.Enabled = false;
                }
                else
                {
                    if (gwstr1 == "")
                    {
                        for (int i = 0; i < cbolst_CC.Items.Count; i++)
                        {
                            if (cbolst_CC.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr1 = cbolst_CC.Items[i].Value.ToString();
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < cbolst_CC.Items.Count; i++)
                        {
                            if (cbolst_CC.Items[i].CheckState == CheckState.Checked)
                            {
                                gwstr2 = cbolst_CC.Items[i].Value.ToString();
                            }
                        }
                    }
                }
                bll_TPB_STA_MOVETIME.Delete(gwstr1, gwstr2);

                bool res = false;
                Mod_TPB_STA_MOVETIME model = new Mod_TPB_STA_MOVETIME();
                model.C_STA_ID1 = gwstr1;
                model.C_STA_ID2 = gwstr2;
                model.N_TIME = Convert.ToDecimal(this.txt_Time1.Text.Trim());
                model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                res = bll_TPB_STA_MOVETIME.Add(model);
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加工位转移时间");//添加操作日志
                if (res)
                {
                    MessageBox.Show("操作成功！");
                }
                Query();
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

                int selectedNum = this.gv_GWYDSJ.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_GWYDSJ.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_GWYDSJ.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TPB_STA_MOVETIME model = bll_TPB_STA_MOVETIME.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool update = bll_TPB_STA_MOVETIME.Update(model);
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

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除工位机时产能");//添加操作日志
                Query();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbolst_GL_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
            for (int i = 0; i < cbolst_GL.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    cbolst_GL.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            //ExistsCount();
        }

        private void cbolst_ZL_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
            for (int i = 0; i < cbolst_ZL.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    cbolst_ZL.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            //ExistsCount();
        }

        private void cbolst_LF_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
            for (int i = 0; i < cbolst_LF.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    cbolst_LF.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            //ExistsCount();
        }

        private void cbolst_RH_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
                for (int i = 0; i < cbolst_RH.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        cbolst_RH.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }

            //ExistsCount();
        }

        private void cbolst_CC_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
            for (int i = 0; i < cbolst_CC.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    cbolst_CC.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            //ExistsCount();
        }

        private void cbolst_GL_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            ExistsCount();
        }

        private void cbolst_ZL_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            ExistsCount();
        }

        private void cbolst_LF_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            ExistsCount();
        }

        private void cbolst_RH_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            ExistsCount();
        }

        private void cbolst_CC_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            ExistsCount();
        }

        private void cbo_GX1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_GX1.EditValue.ToString()=="")
            {
                cbo_GW.Properties.Items.Add("全部", "", 0);
                cbo_GW.SelectedIndex = cbo_GW.Properties.Items.Count - 1;
            }
            else
            {
                commonSub.ImageComboBoxEditBindGW(cbo_GX1.EditValue.ToString(), cbo_GW);
                cbo_GW.Properties.Items.Add("全部","",0);
                cbo_GW.SelectedIndex = cbo_GW.Properties.Items.Count - 1;
            }  
        }

        private void btn_DCGWZYSJ_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_GWYDSJ);
        }
    }
}
