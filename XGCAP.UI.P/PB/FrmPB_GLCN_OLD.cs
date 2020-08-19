using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_GLCN_OLD : Form
    {
        public FrmPB_GLCN_OLD()
        {
            InitializeComponent();
        }
        private Bll_TPB_GL_CAPACITY bll = new Bll_TPB_GL_CAPACITY();
        private Bll_TB_STA bllsta = new Bll_TB_STA();//工位
        CommonSub commonSub = new CommonSub();
        private string strMenuName;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ClearContent.ClearPanelControl(panelControl1.Controls);
            this.lbl_id.Text = "";
        }

        private void FrmPB_GLCN_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strMenuName = RV.UI.UserInfo.menuName;
                cbo_GX_Query.EditValue = "";
                commonSub.ImageComboBoxEditBindGX("", cbo_GX, "");//绑定工序
                commonSub.ImageComboBoxEditBindGX("", cbo_GX_Query, "");//绑定工序
                cbo_GX_Query.SelectedIndex = 0;
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }
          
        }

        private void gridView1_Click(object sender, EventArgs e)
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
            int selectedHandle = this.gv_GWCN.FocusedRowHandle;//获取焦点行索引
            if (selectedHandle < 0)
            {
                ClearContent.ClearPanelControl(panelControl1.Controls);
                this.lbl_id.Text = "";
                return;
            }
            this.lbl_id.Text = this.gv_GWCN.GetRowCellValue(selectedHandle, "C_ID").ToString();//获取焦点行主键
            //根据主键得到工序对象，并在界面赋值
            Mod_TPB_GL_CAPACITY model = bll.GetModel(this.lbl_id.Text);
            cbo_GX.EditValue = model.C_PRO_ID;
            cbo_GW.EditValue = model.C_STA_ID;
            this.txt_cn.Text = model.N_CAPACITY.ToString();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = false;
                if (this.lbl_id.Text == "")
                {
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
                    Mod_TPB_GL_CAPACITY model = new Mod_TPB_GL_CAPACITY();
                    model.C_STA_ID = this.cbo_GW.EditValue.ToString();
                    DataTable dt = bll.GetList( model.C_STA_ID, 1).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("已存在工位！");
                        return;
                    }
                    //工位信息
                    Mod_TB_STA modSta = bllsta.GetModel(model.C_STA_ID);
                    model.C_PRO_ID = modSta.C_PRO_ID;
                    model.C_STA_CODE = modSta.C_STA_CODE;
                    model.C_STA_DESC = modSta.C_STA_DESC;
                    model.N_CAPACITY = Convert.ToDecimal(this.txt_cn.Text);
                    modSta.N_STATUS = this.rbtn_isty_gx.SelectedIndex == 0 ? 1 : 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    res = bll.Add(model);

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加工位日产能");//添加操作日志

                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("是否确认编辑选中的记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }
                    Mod_TPB_GL_CAPACITY model = bll.GetModel(lbl_id.Text);
                    model.N_CAPACITY = Convert.ToDecimal(this.txt_cn.Text);
                    model.N_STATUS = this.rbtn_isty_gx.SelectedIndex == 0 ? 1 : 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    res = bll.Update(model);

                }
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


        private void cbo_GW_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                commonSub.ImageComboBoxEditBindGW(cbo_GX.EditValue.ToString(), cbo_GW);//绑定工位
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
         
        }

        private void lbl_id_TextChanged(object sender, EventArgs e)
        {
            if (lbl_id.Text != "")
            {
                cbo_GX.Enabled = false;
                cbo_GW.Enabled = false;
            }
            else
            {
                cbo_GX.Enabled = true;
                cbo_GW.Enabled = true;
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
            DataTable dt = bll.GetList(cbo_GX_Query.EditValue.ToString(), "", this.rbtn_isty_gx.SelectedIndex == 0 ? 1 : 0).Tables[0];
            this.gc_GWCN.DataSource = dt;
            this.gv_GWCN.OptionsView.ColumnAutoWidth = false;//不允许自动列宽
            this.gv_GWCN.OptionsSelection.MultiSelect = true;//允许多选
            gv_GWCN.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;//加载checkBox
            colC_PRO_ID.ColumnEdit = commonSub.GetGXIdDescItemComboBox();
            this.gv_GWCN.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GWCN);
            GetFoucs();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                DataRow dr = this.gv_GWCN.GetDataRow(this.gv_GWCN.FocusedRowHandle);
                Mod_TPB_GL_CAPACITY mod = bll.GetModel(dr["C_ID"].ToString());
                mod.N_STATUS = 0;
                bll.Update(mod);
                Query();
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用工位产能");//添加操作日志
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
