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
    public partial class FrmPB_GWLSCN : Form
    {
        private string strMenuName;

        public FrmPB_GWLSCN()
        {
            InitializeComponent();
        }
        private Bll_TPB_STA_HISTORY_CAP bll = new Bll_TPB_STA_HISTORY_CAP();
        private Bll_TB_STA bllsta = new Bll_TB_STA();//工位
        CommonSub commonSub = new CommonSub();
        private void FrmPB_GWLSCN_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                commonSub.ImageComboBoxEditBindGX("", cbo_GX, "'CC','ZL','LF','RH','ZX'");//绑定工序
                cbo_GX.SelectedIndex = 0;
                commonSub.ImageComboBoxEditBindGX("", cbo_GX2, "'CC','ZL','LF','RH','ZX'");//绑定工序
                cbo_GX2.Properties.Items.Add("全部", "", 0);
                cbo_GX2.SelectedIndex = cbo_GX2.Properties.Items.Count - 1;
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Query()
        {
            DataTable dt = bll.GetList(cbo_GX2.EditValue.ToString(), "", 1).Tables[0];
            this.gc_GWCN.DataSource = dt;
            this.gv_GWCN.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_GWCN.OptionsSelection.MultiSelect = true;//允许多选
            gv_GWCN.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            colC_PRO_ID.ColumnEdit = commonSub.GetGXIdDescItemComboBox();
            colC_STA_ID.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            this.gv_GWCN.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GWCN);
        }
        //public void GetFoucs()
        //{
        //    int selectedHandle = this.gv_GWCN.FocusedRowHandle;//获取焦点行索引
        //    if (selectedHandle < 0)
        //    {
        //        ClearContent.ClearPanelControl(panelControl1.Controls);
        //        this.lbl_id.Text = "";
        //        return;
        //    }
        //    this.lbl_id.Text = this.gv_GWCN.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
        //    //根据主键得到工序对象，并在界面赋值
        //    Mod_TPB_STA_HISTORY_CAP model = bll.GetModel(this.lbl_id.Text);
        //    cbo_GX.EditValue = model.C_PRO_ID;
        //    cbo_GW.EditValue = model.C_STA_ID;
        //    this.txt_cn.Text = model.N_CAPACITY.ToString();
        //}

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
                int[] row = gv_GWCN.GetSelectedRows();
                foreach (var item in row)
                {
                    DataRow dr = this.gv_GWCN.GetDataRow(item);
                    Mod_TPB_STA_HISTORY_CAP mod = bll.GetModel(dr["C_ID"].ToString());
                    mod.N_STATUS = 0;
                    bll.Update(mod);
                }
                Query();
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除工位历史产能");//添加操作日志
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
                commonSub.ImageComboBoxEditBindGW(cbo_GX.EditValue.ToString(), cbo_GW);//绑定工位
                cbo_GW.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                if (this.cbo_GX.EditValue == null)
                {
                    MessageBox.Show("未选择工序！");
                    return;
                }
                if (this.cbo_GW.EditValue == null)
                {
                    MessageBox.Show("未选择工位！");
                    return;
                }
                if (this.txt_cn.Text.Trim() == "" || this.txt_cn.Text.Trim() == "0")
                {
                    MessageBox.Show("产能不能0或为空！");
                    return;
                }
                Mod_TPB_STA_HISTORY_CAP model = new Mod_TPB_STA_HISTORY_CAP();
                model.C_PRO_ID = this.cbo_GX.EditValue.ToString();
                model.C_STA_ID = this.cbo_GW.EditValue.ToString();
                model.N_CAPACITY = Convert.ToDecimal(this.txt_cn.Text);
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STA_ID", model.C_STA_ID);
                ht.Add("N_STATUS", 1);
                if (Common.CheckRepeat.CheckTable("TPB_STA_HISTORY_CAP", ht) > 0)
                {
                    MessageBox.Show("保存失败！存在该记录!");
                    return;
                }
                else
                {
                    res = bll.Add(model);
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加工位日产能");//添加操作日志
                }
                #endregion
                if (res)
                {
                    MessageBox.Show("操作成功！");
                    cbo_GX2.EditValue = cbo_GX.EditValue;
                    Query();
                }
                else
                {
                    MessageBox.Show("操作失败！");
                    Query();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

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

        //private void btn_reset_Click(object sender, EventArgs e)
        //{
        //    ClearContent.ClearPanelControl(panelControl1.Controls);
        //    this.lbl_id.Text = "";
        //}

        //private void gv_GWCN_Click(object sender, EventArgs e)
        //{
        //    GetFoucs();
        //}

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_GWCN.GetDataRow(this.gv_GWCN.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmPB_GWLSCN_EDIT frm = new FrmPB_GWLSCN_EDIT();
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

        private void btn_DCGWCN_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_GWCN);
        }

        private void gc_GWCN_Click(object sender, EventArgs e)
        {

        }

        //private void rbtn_isty_gx_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (rbtn_isty_gx.SelectedIndex == 0)
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
