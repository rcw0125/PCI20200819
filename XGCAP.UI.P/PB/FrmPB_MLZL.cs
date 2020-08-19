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
    public partial class FrmPB_MLZL : Form
    {
        public FrmPB_MLZL()
        {
            InitializeComponent();
        }
        private string strMenuName;
        CommonSub commonSub = new CommonSub();
        Bll_TPB_CAST_STOVE_WGT bll_TPB_CAST_STOVE_WGT = new Bll_TPB_CAST_STOVE_WGT();
        private void FrmPB_MLZL_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                commonSub.ImageComboBoxEditBindGWByGX("ZL", cbo_GW);
                cbo_GW.SelectedIndex = 0;
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Query()
        {
            DataTable dt = bll_TPB_CAST_STOVE_WGT.GetList(1, "").Tables[0];
            this.gc_GWCN.DataSource = dt;
            this.gv_GWCN.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_GWCN.OptionsSelection.MultiSelect = true;//允许多选
            gv_GWCN.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            colC_STA_ID.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            this.gv_GWCN.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GWCN);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = false;

                if (DialogResult.No == MessageBox.Show("是否确认添加记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                if (this.cbo_GW.EditValue == null)
                {
                    MessageBox.Show("未选择工位！");
                    return;
                }
                if (this.txt_cn.Text.Trim() == "" || this.txt_cn.Text.Trim() == "0")
                {
                    MessageBox.Show("重量不能0或为空！");
                    return;
                }
                Mod_TPB_CAST_STOVE_WGT model = new Mod_TPB_CAST_STOVE_WGT();
                model.C_STA_ID = this.cbo_GW.EditValue.ToString();
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STA_ID", model.C_STA_ID);
                ht.Add("N_STATUS", model.N_STATUS);
                if (Common.CheckRepeat.CheckTable("TPB_CAST_STOVE_WGT", ht) > 0)
                {
                    MessageBox.Show("保存失败！存在该工位!");
                    return;
                }
                #endregion
                model.N_STA_WGT = Convert.ToDecimal(this.txt_cn.Text);
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                res = bll_TPB_CAST_STOVE_WGT.Add(model);
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加每炉重量");//添加操作日志


                if (res)
                {
                    MessageBox.Show("操作成功！");
                    Query();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ClearContent.ClearPanelControl(panelControl1.Controls);
        }

        private void btn_QueryMain_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int[] row = this.gv_GWCN.GetSelectedRows();
                foreach (var item in row)
                {
                    DataRow dr = this.gv_GWCN.GetDataRow(item);
                    Mod_TPB_CAST_STOVE_WGT mod = bll_TPB_CAST_STOVE_WGT.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    bll_TPB_CAST_STOVE_WGT.Update(mod);
                }
                Query();
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除每炉重量");//添加操作日志
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void btn_UpdateGW_Click(object sender, EventArgs e)
        {

            DataRow dr = this.gv_GWCN.GetDataRow(this.gv_GWCN.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmPB_MLZL_EDIT frm = new FrmPB_MLZL_EDIT();
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

        private void btn_Query2_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void btn_DCMLZL_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_GWCN);
        }
    }
}
