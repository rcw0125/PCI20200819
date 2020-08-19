using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MODEL;
using BLL;
using Common;
namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_GWYDSJ_OLD : Form
    {
        public FrmPB_GWYDSJ_OLD()
        {
            InitializeComponent();
        }
        private string strMenuName;
        CommonSub commonSub = new CommonSub();
        Bll_TPB_STA_MOVETIME bll_TPB_STA_MOVETIME = new Bll_TPB_STA_MOVETIME();
        private void FrmPB_GWYDSJ_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                commonSub.ImageComboBoxEditBindGW("", cbo_QSGW1);
                commonSub.ImageComboBoxEditBindGW("", cbo_QSGW2);
                cbo_QSGW1.SelectedIndex = 0;
                cbo_QSGW2.Properties.Items.Add("全部", "全部", 0);
                cbo_QSGW2.SelectedIndex = cbo_QSGW2.Properties.Items.Count - 1;
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void cbo_QSGW1_SelectedValueChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindGW("", cbo_JSGW1);
            cbo_JSGW1.Properties.Items.Remove(cbo_JSGW1.Properties.Items.GetItem(cbo_QSGW1.EditValue.ToString()));
            cbo_JSGW1.SelectedIndex = 0;
        }

        private void cbo_QSGW2_SelectedValueChanged(object sender, EventArgs e)
        {
            commonSub.ImageComboBoxEditBindGW("", cbo_JSGW2);
            if (cbo_QSGW2.EditValue.ToString()!="全部")
            {
                cbo_JSGW2.Properties.Items.Remove(cbo_JSGW2.Properties.Items.GetItem(cbo_QSGW2.EditValue.ToString()));
            }
            cbo_JSGW2.Properties.Items.Add("全部", "全部",-1);
            cbo_JSGW2.SelectedIndex = cbo_JSGW2.Properties.Items.Count-1;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = false;
                if (this.lbl_id.Text == "")
                {
                    if (DialogResult.No == MessageBox.Show("是否确认添加记录？", "提示"))
                    {
                        return;
                    }
                    if (this.cbo_QSGW1.EditValue == null)
                    {
                        MessageBox.Show("未选择起始工位！");
                        return;
                    }
                    if (this.cbo_JSGW1.EditValue == null)
                    {
                        MessageBox.Show("未选择结束工位！");
                        return;
                    }
                    if (this.txt_cn.Text.Trim() == "" || this.txt_cn.Text.Trim() == "0")
                    {
                        MessageBox.Show("时间不能0或为空！");
                        return;
                    }
                    Mod_TPB_STA_MOVETIME model = new Mod_TPB_STA_MOVETIME();
                    model.C_STA_ID1 = this.cbo_QSGW1.EditValue.ToString();
                    model.C_STA_ID2 = this.cbo_JSGW1.EditValue.ToString();
                    model.N_TIME= Convert.ToDecimal(this.txt_cn.Text.Trim());
                    DataTable dt = bll_TPB_STA_MOVETIME.GetList(model.C_STA_ID1, model.C_STA_ID2,"1").Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("已存在工位！");
                        return;
                    }
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    res = bll_TPB_STA_MOVETIME.Add(model);
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加工位转移时间");//添加操作日志

                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑选中的记录？", "提示"))
                    {
                        return;
                    }
                    Mod_TPB_STA_MOVETIME model = bll_TPB_STA_MOVETIME.GetModel(lbl_id.Text);
                    model.N_TIME = Convert.ToDecimal(this.txt_cn.Text);
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    res = bll_TPB_STA_MOVETIME.Update(model);

                }
                if (res)
                {
                    MessageBox.Show("操作成功！");
                    ClearContent.ClearPanelControl(panelControl1.Controls);
                    this.lbl_id.Text = "";
                }
                Query();
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
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Query()
        {
            this.lbl_id.Text = "";
            DataTable dt = bll_TPB_STA_MOVETIME.GetList(cbo_QSGW2.EditValue.ToString(), cbo_JSGW2.EditValue.ToString(), this.rbtn_isty_gx.SelectedIndex.ToString() == "0" ? "1" : "0").Tables[0];
            this.gc_GWYDSJ.DataSource = dt;
            this.gv_GWYDSJ.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_GWYDSJ.OptionsSelection.MultiSelect = true;//允许多选
            this.gv_GWYDSJ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            colC_STA_ID1.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            colC_STA_ID2.ColumnEdit = commonSub.GetGWIdDescItemComboBox();
            this.gv_GWYDSJ.BestFitColumns();
            GetFoucs();
            SetGridViewRowNum.SetRowNum(gv_GWYDSJ);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ClearContent.ClearPanelControl(panelControl1.Controls);
            this.lbl_id.Text = "";
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                int selectedNum = this.gv_GWYDSJ.SelectedRowsCount;
                int commitNum = 0;//停用记录数量
                int failtNum = 0;//停用失败数量
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
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，停用" + commitNum.ToString() + "条记录！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用工位机时产能");//添加操作日志
                Query();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void gv_GWYDSJ_Click(object sender, EventArgs e)
        {
            try
            {
                GetFoucs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        public void GetFoucs()
        {
            int selectedHandle = this.gv_GWYDSJ.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                ClearContent.ClearPanelControl(panelControl1.Controls);
                this.lbl_id.Text = "";
                return;
            }
            this.lbl_id.Text = this.gv_GWYDSJ.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到工序对象，并在界面赋值
            Mod_TPB_STA_MOVETIME model = bll_TPB_STA_MOVETIME.GetModel(this.lbl_id.Text);
            cbo_QSGW1.EditValue = model.C_STA_ID1;
            cbo_JSGW1.EditValue = model.C_STA_ID2;
            this.txt_cn.Text = model.N_TIME.ToString();

        }

        private void lbl_id_TextChanged(object sender, EventArgs e)
        {
            if (lbl_id.Text != "")
            {
                cbo_JSGW1.Enabled = false;
                cbo_QSGW1.Enabled = false;
            }
            else
            {
                cbo_JSGW1.Enabled = true;
                cbo_QSGW1.Enabled = true;
            }
        }
    }
}
