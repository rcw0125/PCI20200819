using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_BZ_ZYX : Form
    {
        public FrmQB_BZ_ZYX()
        {
            InitializeComponent();
        }
        BindDropDown bdd = new BindDropDown();
        Bll_TB_STD_CONFIG bll_TB_STD_CONFIG = new Bll_TB_STD_CONFIG();

        private string strMenuName;

        private void FrmQB_BZ_ZYX_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                cbo_gz.EditValue = "";
                cbo_zyx1.EditValue = "";
                cbo_zyx2.EditValue = "";
                bdd.ComboBoxEditBindGZ(cbo_gz);
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void cbo_gz_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                bdd.ComboBoxEditBindZYX1(cbo_gz.EditValue.ToString(), 1, cbo_zyx1);
                bdd.ComboBoxEditBindZYX1(cbo_gz.EditValue.ToString(), 2, cbo_zyx2);
                bdd.ComboBoxEditBindBZ(cbo_gz.EditValue.ToString(), cbo_zzbz);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void Query()
        {
            DataTable dt = null;
            string gz = txt_q_gz.Text;
            string khyx = txt_q_khxy.Text;
            string zxbz = txt_q_zxbz.Text;
            string lgjh = txt_q_lgjh.Text;
            dt = bll_TB_STD_CONFIG.GetList(gz,khyx,zxbz,lgjh).Tables[0];
            this.gc_config.DataSource = dt;
            this.gv_config.OptionsView.ColumnAutoWidth = false;
            this.gv_config.OptionsSelection.MultiSelect = true;
            gv_config.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_config.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_config);

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearPanelControl(panelControl1.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
             
            if (cbo_gz.EditValue.ToString() == "")
            {
                MessageBox.Show("请选择钢种！");
                this.cbo_gz.Focus();
                return;
            }
            if (cbo_zyx1.Text.Trim() == "")
            {
                MessageBox.Show("请选择自由项1");
                this.cbo_zyx1.Focus();
                return;
            }
            if (cbo_zyx2.Text.Trim() == "")
            {
                MessageBox.Show("请输自由项2");
                this.cbo_zyx2.Focus();
                return;
            }

           

            Mod_TB_STD_CONFIG model = new Mod_TB_STD_CONFIG();
            model.C_STL_GRD = cbo_gz.EditValue.ToString();
            model.C_CUST_TECH_PROT = txt_khxy.Text;
            model.C_STEEL_SIGN = txt_lgjh.Text;
            model.C_STD_CODE = cbo_zzbz.EditValue.ToString();
            model.C_ZYX1 = cbo_zyx1.EditValue.ToString();
            model.C_ZYX2 = cbo_zyx2.EditValue.ToString();
            model.C_EMP_ID = RV.UI.UserInfo.userID;
            model.C_CUST_NO = this.lbl_cust_no.Text;
            model.C_CUST_NAME = this.cbo_cust_name.Text;
            model.C_REMARK = txt_Remark.Text.Trim();
            try
            {
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STL_GRD", model.C_STL_GRD);
                ht.Add("N_STATUS", "1");
                ht.Add("C_CUST_TECH_PROT", model.C_STEEL_SIGN);
                ht.Add("C_STD_CODE", model.C_STD_CODE);
                if (Common.CheckRepeat.CheckTable("TB_STD_CONFIG", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                if (bll_TB_STD_CONFIG.Add(model))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加客户协议和自由项关系");//添加操作日志

                    MessageBox.Show("保存成功！");
                    Query();//重新加载仓库信息
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("保存失败！");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int selectedNum = this.gv_config.SelectedRowsCount;
                int commitNum = 0;//停用记录数量
                int failtNum = 0;//停用失败数量
                int[] rownumber = this.gv_config.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_config.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TB_STD_CONFIG model = bll_TB_STD_CONFIG.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    model.D_END_DATE = RV.UI.ServerTime.timeNow();
                    bool update = bll_TB_STD_CONFIG.Update(model);
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

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用客户协议自由项匹配数据");//添加操作日志

                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbo_cust_name_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FrmQB_SELECT_KDXX frm = new FrmQB_SELECT_KDXX();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                  
                    this.cbo_cust_name.Text = frm.str_NAME;
                    this.lbl_cust_no.Text = frm.str_NO;
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbo_cust_name_DoubleClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmQB_SELECT_KDXX frm = new FrmQB_SELECT_KDXX();
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    this.cbo_cust_name.Text = frm.str_NAME;
                    this.lbl_cust_no.Text = frm.str_NO;
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbo_gz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
