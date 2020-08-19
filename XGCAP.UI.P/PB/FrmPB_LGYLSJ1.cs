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
    public partial class FrmPB_LGYLSJ1 : Form
    {
        public FrmPB_LGYLSJ1()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();
        Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        Bll_TPB_STEEL_SMELT_TIME bll_TPB_STEEL_SMELT_TIME = new Bll_TPB_STEEL_SMELT_TIME();

        private string strMenuName;
        private void FrmPB_LGYLSJ1_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                sub.ImageComboBoxEditBindGX("", cbo_GX, "'CC','ZL','LF','RH'");
                sub.ImageComboBoxEditBindGX("", cbo_GX2, "'CC','ZL','LF','RH'");
                cbo_GX.SelectedIndex = 0;
                cbo_GX2.Properties.Items.Add("全部", "", 0);
                cbo_GX2.SelectedIndex = cbo_GX2.Properties.Items.Count - 1;
                Query2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Query2()
        {
            DataTable dt = null;
            string gz = "";
            string zxbz = "";
            dt = bll_TPB_STEEL_SMELT_TIME.GetList(1, cbo_GX2.EditValue.ToString(), cbo_GW2.EditValue.ToString(), gz, zxbz).Tables[0];
            this.gc_GWJSCL.DataSource = dt;
            this.gv_GWJSCL.OptionsView.ColumnAutoWidth = false;
            this.gv_GWJSCL.OptionsSelection.MultiSelect = true;
            this.gv_GWJSCL.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_GWJSCL.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GWJSCL);
 
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_GX.Text == "")
                {
                    MessageBox.Show("请选择工序！");
                    cbo_GX.Focus();
                    return;
                }
                if (cbo_GW.Text == "")
                {
                    MessageBox.Show("请选择工位！");
                    cbo_GW.Focus();
                    return;
                }

                if (txt_JSCN.Text.Trim() == "" || txt_JSCN.Text.Trim() == "0")
                {
                    MessageBox.Show("冶炼时间不能为空或为0！");
                    txt_JSCN.Focus();
                }
                else
                {

                    if (DialogResult.No == MessageBox.Show("是否确认保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }

                    Mod_TPB_STEEL_SMELT_TIME mod_TPB_STEEL_SMELT_TIME = new Mod_TPB_STEEL_SMELT_TIME();
                    mod_TPB_STEEL_SMELT_TIME.C_EMP_ID = RV.UI.UserInfo.userID;
                    mod_TPB_STEEL_SMELT_TIME.C_PRO_ID = cbo_GX.EditValue.ToString();
                    mod_TPB_STEEL_SMELT_TIME.C_STA_ID = cbo_GW.EditValue.ToString();
                    mod_TPB_STEEL_SMELT_TIME.N_SMELT_TIME = Convert.ToDecimal(txt_JSCN.Text.ToString());
                    if (bll_TPB_STEEL_SMELT_TIME.ExistsDate(mod_TPB_STEEL_SMELT_TIME.C_PRO_ID, mod_TPB_STEEL_SMELT_TIME.C_STA_ID))
                    {
                        MessageBox.Show("保存失败，已存在" + cbo_GW.Text + "下冶炼时间！");
                        return;
                    }

                    if (bll_TPB_STEEL_SMELT_TIME.Add(mod_TPB_STEEL_SMELT_TIME))
                    {
                        MessageBox.Show("保存成功！");
                        cbo_GW2.EditValue = cbo_GW.EditValue;
                        cbo_GX2.EditValue = cbo_GX.EditValue;
                        Query2();
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加炼钢冶炼时间信息");//添加操作日志
                    }
                    else
                    {
                        MessageBox.Show("保存失败！");
                        Query2();
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加炼钢冶炼时间信息");//添加操作日志
                    }
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

        private void simpleButton2_Click(object sender, EventArgs e)
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
                    Mod_TPB_STEEL_SMELT_TIME model = bll_TPB_STEEL_SMELT_TIME.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.D_END_DATE = RV.UI.ServerTime.timeNow();
                    bool update = bll_TPB_STEEL_SMELT_TIME.Update(model);
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

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除炼钢冶炼时间信息");//添加操作日志

                Query2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbo_GX_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                sub.ImageComboBoxEditBindGW(cbo_GX.EditValue.ToString(), cbo_GW);
                cbo_GW.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbo_GX2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_GX2.EditValue.ToString()=="")
                {
                    cbo_GW2.Properties.Items.Add("全部", "", 0);
                    cbo_GW2.SelectedIndex = cbo_GW2.Properties.Items.Count - 1;
                    return;
                }
                sub.ImageComboBoxEditBindGW(cbo_GX2.EditValue.ToString(), cbo_GW2);
                cbo_GW2.Properties.Items.Add("全部", "", 0);
                cbo_GW2.SelectedIndex = cbo_GW2.Properties.Items.Count - 1;
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
        //        ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
        //        lbl_id.Text = "";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        //private void gv_GWJSCL_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        GetFoucs();
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.ToString());
        //    }
        //}
        //public void GetFoucs()
        //{
        //    int selectedHandle = this.gv_GWJSCL.FocusedRowHandle;//获取焦点行索引
        //    if (selectedHandle < 0)
        //    {
        //        ClearContent.ClearPanelControl(panelControl1.Controls);
        //        this.lbl_id.Text = "";
        //        return;
        //    }
        //    this.lbl_id.Text = this.gv_GWJSCL.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
        //    //根据主键得到工序对象，并在界面赋值
        //    Mod_TPB_STEEL_SMELT_TIME model = bll_TPB_STEEL_SMELT_TIME.GetModel(this.lbl_id.Text);
        //    cbo_GX.EditValue = model.C_PRO_ID;
        //    cbo_GW.EditValue = model.C_STA_ID;
        //    this.txt_JSCN.Text = model.N_SMELT_TIME.ToString();
        //}

        //private void lbl_id_TextChanged(object sender, EventArgs e)
        //{
        //    if (lbl_id.Text != "")
        //    {
        //        cbo_GX.Enabled = false;
        //        cbo_GW.Enabled = false;
        //    }
        //    else
        //    {
        //        cbo_GX.Enabled = true;
        //        cbo_GW.Enabled = true;
        //    }
        //}

        private void btn_UpdateGW_Click(object sender, EventArgs e)
        {

            DataRow dr = this.gv_GWJSCL.GetDataRow(this.gv_GWJSCL.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmPB_LGTLSJ_EDIT frm = new FrmPB_LGTLSJ_EDIT();
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

        private void btn_DCYLSJ_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_GWJSCL);
        }

        //private void rbtn_isty_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (rbtn_isty.SelectedIndex == 0)
        //    {
        //        btn_Stop.Enabled = true;
        //        btn_UpdateGW.Enabled = true;
        //    }
        //    else
        //    {
        //        btn_Stop.Enabled = false;
        //        btn_UpdateGW.Enabled = false;
        //    }
        //}
    }
}
