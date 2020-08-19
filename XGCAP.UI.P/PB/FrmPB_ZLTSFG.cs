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
    public partial class FrmPB_ZLTSFG : Form
    {
        public FrmPB_ZLTSFG()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TPB_WASTE_RATIO bll_TPB_WASTE_RATIO = new Bll_TPB_WASTE_RATIO();
        Bll_TPB_CAST_STOVE_WGT bll_TPB_CAST_STOVE_WGT = new Bll_TPB_CAST_STOVE_WGT();
        private string strMenuName;
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                if (cbo_ZL1.EditValue.ToString() == "")
                {
                    cbo_ZL1.Focus();
                    MessageBox.Show("请选择转炉"); return;
                }
                if (txt_ZL.Text=="0"|| txt_ZL.Text == "")
                {
                    txt_ZL.Focus();
                    MessageBox.Show("每炉重量不能为空或不能等于0,请修改每炉重量!"); return;
                }
                if (txt_TS.Text == "0" || txt_TS.Text == "")
                {
                    txt_TS.Focus();
                    MessageBox.Show("铁水重量不能为空或不能等于0,请修改每炉重量！"); return;
                }
                if (txt_CT.Text == "0" || txt_CT.Text == "")
                {
                    txt_CT.Focus();
                    MessageBox.Show("出铁重量不能为空或不能等于0,请修改出铁重量！"); return;
                }
                if (Convert.ToDecimal(txt_TS.Text) > Convert.ToDecimal(txt_ZL.Text))
                {
                    txt_TS.Focus();
                    MessageBox.Show("铁水重量不能大于每炉重量,请修改铁水重量！"); return;
                }
                if (Convert.ToDecimal(txt_CT.Text)> Convert.ToDecimal(txt_ZL.Text))
                {
                    txt_CT.Focus();
                    MessageBox.Show("出铁重量不能大于每炉重量,请修改出铁重量！"); return;
                }                        
                Mod_TPB_WASTE_RATIO mod_TPB_WASTE_RATIO1 = new Mod_TPB_WASTE_RATIO();
                mod_TPB_WASTE_RATIO1.C_EMP_ID = RV.UI.UserInfo.userID;
                mod_TPB_WASTE_RATIO1.C_STA_NAME = cbo_ZL1.Text;
                mod_TPB_WASTE_RATIO1.C_STA_ID = cbo_ZL1.EditValue.ToString();
                mod_TPB_WASTE_RATIO1.C_REMARK = txt_Remark.Text;
                mod_TPB_WASTE_RATIO1.N_TS_WGT = Convert.ToDecimal(txt_TS.Text);
                mod_TPB_WASTE_RATIO1.N_FG_WGT = Convert.ToDecimal(txt_FG.Text);
                mod_TPB_WASTE_RATIO1.N_CG_WGT = Convert.ToDecimal(txt_CT.Text);
                mod_TPB_WASTE_RATIO1.N_WGT = Convert.ToDecimal(txt_ZL.Text);
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STA_ID", mod_TPB_WASTE_RATIO1.C_STA_ID);
                ht.Add("N_STATUS", 1);
                if (Common.CheckRepeat.CheckTable("TPB_WASTE_RATIO", ht) > 0)
                {
                    MessageBox.Show("保存失败！存在该记录!");
                    return;
                }
                else
                {
                    bll_TPB_WASTE_RATIO.Add(mod_TPB_WASTE_RATIO1);
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加转炉铁水废钢比列信息");//添加操作日志
                    MessageBox.Show("保存成功！");
                    Query();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void FrmPB_ZLTSFG_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                sub.ImageComboBoxEditBindGWByGX(cbo_ZL1);
                cbo_ZL2.SelectedIndex =0;
                sub.ImageComboBoxEditBindGWByGX(cbo_ZL2);
                cbo_ZL2.Properties.Items.Add("全部", "", 0);
                cbo_ZL2.SelectedIndex = cbo_ZL2.Properties.Items.Count - 1;
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
            string gx = cbo_ZL2.EditValue.ToString();
            dt = bll_TPB_WASTE_RATIO.GetListByStatus(1, gx).Tables[0];
            this.gc_Route.DataSource = dt;
            this.gv_Route.OptionsView.ColumnAutoWidth = false;
            this.gv_Route.OptionsSelection.MultiSelect = true;
            gv_Route.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_Route.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Route);
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

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_Route.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_Route.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_Route.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TPB_WASTE_RATIO model = bll_TPB_WASTE_RATIO.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool update = bll_TPB_WASTE_RATIO.Update(model);
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

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除转炉铁水废钢比列信息");//添加操作日志

                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_Route.GetDataRow(this.gv_Route.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmPB_ZLTSFG_EDIT frm = new FrmPB_ZLTSFG_EDIT();
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    Query();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbo_ZL1_SelectedValueChanged(object sender, EventArgs e)
        {
            //Mod_TPB_CAST_STOVE_WGT mod_TPB_CAST_STOVE_WGT = bll_TPB_CAST_STOVE_WGT.GetModelBySTA(cbo_ZL1.EditValue.ToString());
            //if (mod_TPB_CAST_STOVE_WGT == null)
            //{
            //    MessageBox.Show("该转炉重量未维护！");
            //    return;
            //}
            //wgt = mod_TPB_CAST_STOVE_WGT.N_STA_WGT;
            //txt_TS.Text = wgt.ToString();
        }

        private void txt_FGBL_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void btn_DCZLTSFG_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_Route);
        }
        private void txt_ZL_EditValueChanged(object sender, EventArgs e)
        {
            txt_TS.Text = txt_ZL.Text;
        }

        private void txt_TS_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_ZL.Text == "" || txt_ZL.Text == "0")
            {
                return;
            }
            txt_FG.Text = (Convert.ToDecimal(txt_ZL.Text) - Convert.ToDecimal(txt_TS.Text)).ToString();
        }

    }
}
