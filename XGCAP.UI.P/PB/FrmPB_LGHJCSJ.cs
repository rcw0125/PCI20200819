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
    public partial class FrmPB_LGHJCSJ : Form
    {
        public FrmPB_LGHJCSJ()
        {
            InitializeComponent();
        }
        private string strMenuName;
        CommonSub commonSub = new CommonSub();
        Bll_TPB_CC_CHANGE_TIME bll_TPB_CC_CHANGE_TIME = new Bll_TPB_CC_CHANGE_TIME();
        private void FrmPB_LZHJCSJ_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                commonSub.ImageComboBoxEditBindGWByGX("CC", cbo_GW);
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        private void Query()
        {
            DataTable dt = bll_TPB_CC_CHANGE_TIME.GetListBySTA("").Tables[0];
            this.gc_GWCN.DataSource = dt;
            this.gv_GWCN.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_GWCN.OptionsSelection.MultiSelect = true;//允许多选
            gv_GWCN.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            colC_STA_ID.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            this.gv_GWCN.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GWCN);
        }
        private void btn_QueryMain_Click(object sender, EventArgs e)
        {
            Query();
        }
        //public void GetFoucs()
        //{
        //    int selectedHandle = this.gv_GWCN.FocusedRowHandle;//获取焦点行索引
        //    if (selectedHandle < 0)
        //    {
        //        ClearContent.ClearPanelControl(panelControl1.Controls);
        //        return;
        //    }
        //    this.lbl_id.Text = this.gv_GWCN.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
        //    //根据主键得到工序对象，并在界面赋值
        //    Mod_TPB_CC_CHANGE_TIME model = bll_TPB_CC_CHANGE_TIME.GetModel(this.lbl_id.Text);
        //    cbo_GW.EditValue = model.C_STA_ID;
        //    this.txt_cn.Text = model.N_TIME.ToString();

        //}

        //private void lbl_id_TextChanged(object sender, EventArgs e)
        //{
        //    if (lbl_id.Text != "")
        //    {
        //        cbo_GW.Enabled = false;
        //    }
        //    else
        //    {
        //        cbo_GW.Enabled = true;
        //    }
        //}

        //private void btn_reset_Click(object sender, EventArgs e)
        //{
        //    ClearContent.ClearPanelControl(panelControl1.Controls);
        //    this.lbl_id.Text = "";
        //}

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
                    MessageBox.Show("产能不能0或为空！");
                    return;
                }
                Mod_TPB_CC_CHANGE_TIME model = new Mod_TPB_CC_CHANGE_TIME();
                model.C_STA_ID = this.cbo_GW.EditValue.ToString();
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STA_ID", model.C_STA_ID);
                if (Common.CheckRepeat.CheckTable("TPB_CC_CHANGE_TIME", ht) > 0)
                {
                    MessageBox.Show("保存失败！存在该工位!");
                    return;
                }
                #endregion
                model.N_TIME = Convert.ToDecimal(this.txt_cn.Text);
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                res = bll_TPB_CC_CHANGE_TIME.Add(model);
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加连铸浇次时间");//添加操作日志

                //}
                //else
                //{
                //    if (DialogResult.No == MessageBox.Show("是否确认编辑选中的记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                //    {
                //        return;
                //    }
                //    Mod_TPB_CC_CHANGE_TIME model = bll_TPB_CC_CHANGE_TIME.GetModel(lbl_id.Text);
                //    model.N_TIME = Convert.ToDecimal(this.txt_cn.Text);
                //    model.C_EMP_ID = RV.UI.UserInfo.userID;
                //    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                //    res = bll_TPB_CC_CHANGE_TIME.Update(model);

                //}
                //if (res)
                //{
                //    MessageBox.Show("操作成功！");
                //   
                //}
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
                if (DialogResult.No == MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int[] rows = gv_GWCN.GetSelectedRows();
                foreach (var item in rows)
                {
                    DataRow dr = this.gv_GWCN.GetDataRow(item);
                    bll_TPB_CC_CHANGE_TIME.Delete(dr["C_ID"].ToString());
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除连铸换浇次时间");//添加操作日志
                }
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //private void gv_GWCN_Click(object sender, EventArgs e)
        //{
        //    GetFoucs();
        //}

        private void btn_UpdateGW_Click(object sender, EventArgs e)
        {

            DataRow dr = this.gv_GWCN.GetDataRow(this.gv_GWCN.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmPB_LGHJCSJ_EDIT frm = new FrmPB_LGHJCSJ_EDIT();
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

        private void btn_QueryMain_Click_1(object sender, EventArgs e)
        {
            Query();
        }

        private void btn_DCHJCSJ_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_GWCN);
        }
    }
}
