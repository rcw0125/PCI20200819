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
using XGCAP.UI.P.PB;


namespace XGCAP.UI.P
{
    public partial class FrmPB_ZGJSCN1 : Form
    {
        public FrmPB_ZGJSCN1()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();
        Bll_TQB_STD_SPEC bll_TQB_STD_SPEC = new Bll_TQB_STD_SPEC();
        Bll_TPB_STATION_CAPACITY bll_TPB_STATION_CAPACITY = new Bll_TPB_STATION_CAPACITY();

        private string strMenuName;
        private void FrmPB_ZGJSCN1_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                sub.ImageComboBoxEditBindGX("", cbo_GX1,"'ZX'");
                cbo_GX1.SelectedIndex = 0;
                sub.ImageComboBoxEditBindGX("", cbo_GX2, "'ZX'");
                cbo_GX2.SelectedIndex = cbo_GX2.Properties.Items.Count-1;
                Query();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }
        /// <summary>
        /// 查询
        /// </summary>
        private void Query()
        {
            DataTable dt = null;
            dt = bll_TQB_STD_MAIN.GetGZList(txt_Grd.Text).Tables[0];
            this.gc_StdMain.DataSource = dt;
            this.gv_StdMain.OptionsView.ColumnAutoWidth = false;
            this.gv_StdMain.OptionsSelection.MultiSelect = true;
            this.gv_StdMain.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_StdMain.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdMain);
        }

        private void cbo_GW_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_GW.Text.Contains("开坯"))
                {
                    cbo_GG.Properties.Items.Clear();
                    cbo_GG.Properties.Items.Add("150*150");
                    cbo_GG.Properties.Items.Add("160*160");
                    cbo_GG.SelectedIndex = 0;
                }
                else
                {
                    sub.ComboBoxEditBindSPECByGW(cbo_GW.EditValue.ToString(), cbo_GG, "");
                    cbo_GG.SelectedIndex = 0;
                }


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

                if (cbo_GW.EditValue.ToString() != "")
                {
                    if (cbo_GG.EditValue.ToString() != "")
                    {
                        if (txt_JSCN.Text.Trim() != "")
                        {
                            if (ck_JKGG.Checked == true)
                            {
                                Mod_TPB_STATION_CAPACITY mod_TPB_STATION_CAPACITY = new Mod_TPB_STATION_CAPACITY();
                                mod_TPB_STATION_CAPACITY.C_PRO_ID = cbo_GX1.EditValue.ToString();
                                mod_TPB_STATION_CAPACITY.C_STA_ID = cbo_GW.EditValue.ToString();
                                mod_TPB_STATION_CAPACITY.C_SPEC = cbo_GG.EditValue.ToString();
                                mod_TPB_STATION_CAPACITY.N_CAPACITY = Convert.ToDecimal(txt_JSCN.Text);
                                mod_TPB_STATION_CAPACITY.C_EMP_ID = RV.UI.UserInfo.userID;
                                if (bll_TPB_STATION_CAPACITY.Exists(mod_TPB_STATION_CAPACITY.C_STA_ID, mod_TPB_STATION_CAPACITY.C_SPEC))
                                {
                                    MessageBox.Show("保存失败！存在该记录!");
                                }
                                else
                                {
                                    bll_TPB_STATION_CAPACITY.Add(mod_TPB_STATION_CAPACITY);
                                    MessageBox.Show("保存成功！");
                                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加轧钢机时产能");//添加操作日志
                                    Query2();
                                }
                            }
                            else
                            {
                                int[] rownumber = this.gv_StdMain.GetSelectedRows();//获取选中行号数组；
                                int succount = 0;
                                string str = "";
                                if (rownumber.Count() > 0)
                                {
                                    foreach (var item in rownumber)
                                    {
                                        Mod_TPB_STATION_CAPACITY mod_TPB_STATION_CAPACITY = new Mod_TPB_STATION_CAPACITY();
                                        mod_TPB_STATION_CAPACITY.C_STA_ID = cbo_GW.EditValue.ToString();
                                        mod_TPB_STATION_CAPACITY.C_SPEC = cbo_GG.EditValue.ToString();
                                        mod_TPB_STATION_CAPACITY.C_STL_GRD = this.gv_StdMain.GetRowCellValue(item, "C_STL_GRD") == null ? "" : this.gv_StdMain.GetRowCellValue(item, "C_STL_GRD").ToString();
                                        mod_TPB_STATION_CAPACITY.N_CAPACITY = Convert.ToDecimal(txt_JSCN.Text);
                                        mod_TPB_STATION_CAPACITY.C_EMP_ID = RV.UI.UserInfo.userID;
                                        if (bll_TPB_STATION_CAPACITY.ExistsDate(mod_TPB_STATION_CAPACITY.C_STA_ID, mod_TPB_STATION_CAPACITY.C_STL_GRD, mod_TPB_STATION_CAPACITY.C_SPEC)==true)
                                        {
                                            str += mod_TPB_STATION_CAPACITY.C_STL_GRD + ",";
                                        }
                                        else
                                        {
                                            bll_TPB_STATION_CAPACITY.Add(mod_TPB_STATION_CAPACITY);
                                            succount += 1;
                                        }
                                    }
                                    if (str.Length > 0)
                                    {
                                        MessageBox.Show("共" + rownumber.Count() + "条数据，保存成功" + succount + "条," + str.Substring(0, str.Length - 1) + "已存在！");
                                        cbo_GW2.EditValue = cbo_GW.EditValue;
                                        cbo_GX2.EditValue = cbo_GX1.EditValue;
                                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加轧钢机时产能信息");//添加操作日志

                                        Query2();
                                    }
                                    else
                                    {
                                        MessageBox.Show("共" + rownumber.Count() + "条数据，保存成功" + succount + "条");

                                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加轧钢机时产能信息");//添加操作日志

                                        Query2();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("请选择钢种！");
                                    gv_StdMain.Focus();
                                }
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
                        MessageBox.Show("请选择规格！");
                        cbo_GG.Focus();
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
        private void Query2()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable alldt = null;
                alldt = bll_TPB_STATION_CAPACITY.GetList(1, cbo_GX2.EditValue.ToString(), cbo_GW2.EditValue.ToString(), txt_GZ2.Text,cbo_GG2.Text,"").Tables[0];
                this.gc_GWJSCL.DataSource = alldt;
                this.gv_GWJSCL.OptionsView.ColumnAutoWidth = false;
                this.gv_GWJSCL.OptionsSelection.MultiSelect = true;
                this.gv_GWJSCL.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                this.colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox();
                this.gv_GWJSCL.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GWJSCL);

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
                int selectedNum = this.gv_GWJSCL.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_GWJSCL.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_GWJSCL.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TPB_STATION_CAPACITY model = bll_TPB_STATION_CAPACITY.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.D_END_DATE = RV.UI.ServerTime.timeNow();
                    bool update = bll_TPB_STATION_CAPACITY.Update(model);
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

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除轧钢机时产能信息");//添加操作日志

                Query2();
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
            if (cbo_GX2.EditValue.ToString()=="")
            {
                cbo_GW2.Properties.Items.Add("全部", "", 0);
                cbo_GW2.SelectedIndex = cbo_GW2.Properties.Items.Count - 1;
            }
            else
            {
                sub.ImageComboBoxEditBindGW(cbo_GX2.EditValue.ToString(), cbo_GW2);
                cbo_GW2.Properties.Items.Add("全部", "", 0);
                cbo_GW2.SelectedIndex = cbo_GW2.Properties.Items.Count - 1;
            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int[] row = gv_GWJSCL.GetSelectedRows();
            if (row.Count()<1)
            {
                MessageBox.Show("未选中要修改的信息！");
                return;
            }
            try
            {
                foreach (var item in row)
                {
                    string id = gv_GWJSCL.GetRowCellValue(item,"C_ID").ToString();
                    Mod_TPB_STATION_CAPACITY mod_TPB_STATION_CAPACITY = bll_TPB_STATION_CAPACITY.GetModel(id);
                    mod_TPB_STATION_CAPACITY.N_CAPACITY = Convert.ToUInt32(txt_CN2.Text==""?"0": txt_CN2.Text);
                    bll_TPB_STATION_CAPACITY.Update(mod_TPB_STATION_CAPACITY);
                }
                MessageBox.Show("修改成功！");
                Query2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbo_GW2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_GW2.Text.Contains("开坯"))
                {
                    cbo_GG2.Properties.Items.Clear();
                    cbo_GG2.Properties.Items.Add("150*150");
                    cbo_GG2.Properties.Items.Add("160*160");
                    cbo_GG2.SelectedIndex = 0;
                }
                else
                {
                    sub.ComboBoxEditBindSPECByGW("", cbo_GG2, "");
                    cbo_GG2.Properties.Items.Add("全部");
                    cbo_GG2.SelectedIndex = cbo_GG2.Properties.Items.Count-1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_DCZGJSCN_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_GWJSCL);
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
