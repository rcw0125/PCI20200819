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
    public partial class FrmPB_ZGSCGL_OLD : Form
    {
        public FrmPB_ZGSCGL_OLD()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();
        Bll_TQB_STD_SPEC bll_TQB_STD_SPEC = new Bll_TQB_STD_SPEC();
        Bll_TPB_LINE_SPEC bll_TPB_LINE_SPEC = new Bll_TPB_LINE_SPEC();
        Bll_TPB_N_GRD bll_TPB_N_GRD = new Bll_TPB_N_GRD();
        Bll_TB_STA bllsta = new Bll_TB_STA();
        private string strMenuName;
        private void FrmPB_ZGSCGL_Load(object sender, EventArgs e)
        {
            try
            {
                strMenuName = RV.UI.UserInfo.menuName;
                sub.ComboBoxEditBindSPEC(cbo_GG1, "");
                sub.ImageComboBoxEditBindGWByGXstr("'ZX'", cbo_CX);
                sub.ImageComboBoxEditBindGWByGXstr("'ZX'", cbo_GW1);
                sub.ImageComboBoxEditBindGWByGXstr("'ZX'", imgcbo_cx1);
                sub.ImageComboBoxEditBindGWByGXstr("'ZX'", imgcbo_cx2);
                imgcbo_cx1.Properties.Items.Add("全部", "", 0);
                imgcbo_cx2.Properties.Items.Add("全部", "", 0);
                cbo_CX.SelectedIndex = 0;
                cbo_GG1.SelectedIndex = 0;
                cbo_GW1.SelectedIndex = 0;
                imgcbo_cx1.SelectedIndex = 0;
                imgcbo_cx2.SelectedIndex = 0;
                Query();
                BindGGByID();
                QueryBGZ();
                QueryGG();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 查询钢种、执行标准信息
        /// </summary>
        private void Query()
        {
            DataTable dt = null;
            dt = bll_TQB_STD_MAIN.GetList(txt_Std.Text, txt_Grd.Text).Tables[0];
            this.gc_StdMain.DataSource = dt;
            this.gv_StdMain.OptionsView.ColumnAutoWidth = false;
            this.gv_StdMain.OptionsSelection.MultiSelect = true;
            this.gv_StdMain.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_StdMain.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdMain);

        }
        /// <summary>
        /// 查询产线规格
        /// </summary>
        private void QueryGG()
        {
            DataTable dt = null;
            if (this.rbtn_isty2.SelectedIndex == 0)
            {
                dt = bll_TPB_LINE_SPEC.GetSpecListBySTA(1, imgcbo_cx2.EditValue.ToString()).Tables[0];
            }
            else
            {
                dt = bll_TPB_LINE_SPEC.GetSpecListBySTA(0, imgcbo_cx2.EditValue.ToString()).Tables[0];
            }
           
            this.gc_ZGCXGG.DataSource = dt;
            this.gv_ZGCXGG.OptionsView.ColumnAutoWidth = false;
            this.gv_ZGCXGG.OptionsSelection.MultiSelect = true;
            this.gv_ZGCXGG.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_ZGCXGG.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ZGCXGG);

        }
        /// <summary>
        /// 查询产线不生产钢种
        /// </summary>
        private void QueryBGZ()
        {
            DataTable dt = null;
            if (this.rbtn_isty1.SelectedIndex == 0)
            {
                dt = bll_TPB_N_GRD.GetList(1, imgcbo_cx1.EditValue.ToString(), txtGZ1.Text, txtBZ1.Text).Tables[0];
            }
            else
            {
                dt = bll_TPB_N_GRD.GetList(0, imgcbo_cx1.EditValue.ToString(), txtGZ1.Text, txtBZ1.Text).Tables[0];
            }
            this.gc_ZGBSCGZ.DataSource = dt;
            this.gv_ZZGBSCGZ.OptionsView.ColumnAutoWidth = false;
            this.gv_ZZGBSCGZ.OptionsSelection.MultiSelect = true;
            this.gv_ZZGBSCGZ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridColumn18.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_ZZGBSCGZ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ZZGBSCGZ);
        }
        /// <summary>
        /// 根据工位加载规格信息
        /// </summary>
        /// <param name="strID">执行标准主键</param>
        public void BindGGByID()
        {
            DataTable dt = bll_TQB_STD_SPEC.GetSPECListBySTA(cbo_CX.EditValue.ToString(),cbo_GG1.EditValue.ToString(),cbo_GG2.EditValue.ToString()).Tables[0];
            this.gc_GG.DataSource = dt;
            this.gv_GG.OptionsView.ColumnAutoWidth = false;
            this.gv_GG.OptionsSelection.MultiSelect = true;
            this.gv_GG.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GG.BestFitColumns();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void btn_query_GZ_Click(object sender, EventArgs e)
        {
            QueryBGZ();
        }

        private void btn_Stop1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int selectedNum = this.gv_ZZGBSCGZ.SelectedRowsCount;
                int commitNum = 0;//停用记录数量
                int failtNum = 0;//停用失败数量
                int[] rownumber = this.gv_ZZGBSCGZ.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_ZZGBSCGZ.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TPB_N_GRD model = bll_TPB_N_GRD.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool update = bll_TPB_N_GRD.Update(model);
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
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用不生产钢种信息");//添加操作日志

                QueryBGZ();
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
                int[] rownumberCX = this.gv_StdMain.GetSelectedRows();//获取产线选中行号数组；
                if (rownumberCX.Count() == 0)
                {
                    MessageBox.Show("未选中钢种信息！"); return;
                }
                int count = rownumberCX.Length;
                int scount = 0;
                string str = "";
                foreach (var item in rownumberCX)
                {
                    Mod_TPB_N_GRD mod_TPB_N_GRD = new Mod_TPB_N_GRD();
                    mod_TPB_N_GRD.C_STA_ID = cbo_GW1.EditValue.ToString();
                    mod_TPB_N_GRD.C_PROD_KIND = gv_StdMain.GetRowCellValue(item, "C_PROD_KIND").ToString();//品种
                    mod_TPB_N_GRD.C_PROD_NAME = gv_StdMain.GetRowCellValue(item, "C_PROD_NAME").ToString();//品名
                    mod_TPB_N_GRD.C_STL_GRD = gv_StdMain.GetRowCellValue(item, "C_STL_GRD").ToString();//钢种
                    mod_TPB_N_GRD.C_STD_CODE = gv_StdMain.GetRowCellValue(item, "C_STD_CODE").ToString();//执行标准
                    mod_TPB_N_GRD.C_EMP_ID = RV.UI.UserInfo.userID;
                    mod_TPB_N_GRD.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_PROD_NAME", mod_TPB_N_GRD.C_PROD_NAME);
                    ht.Add("C_STA_ID", mod_TPB_N_GRD.C_STA_ID);
                    ht.Add("C_PROD_KIND", mod_TPB_N_GRD.C_PROD_KIND);
                    ht.Add("C_STL_GRD", mod_TPB_N_GRD.C_STL_GRD);
                    ht.Add("C_STD_CODE", mod_TPB_N_GRD.C_STD_CODE);
                    if (Common.CheckRepeat.CheckTable("TPB_N_GRD", ht) > 0)
                    {
                        str += mod_TPB_N_GRD.C_PROD_NAME + "(" + mod_TPB_N_GRD.C_STL_GRD + "/" + mod_TPB_N_GRD.C_STD_CODE + "),";
                    }
                    else
                    {
                        bll_TPB_N_GRD.Add(mod_TPB_N_GRD);
                        scount += 1;
                    }
                    #endregion

                }
                if (str.Length > 0)
                {
                    MessageBox.Show("共" + count + "条数据，保存成功" + scount + "条," + str.Substring(0, str.Length - 1) + "已存在！");
                    imgcbo_cx1.EditValue = cbo_GW1.EditValue;
                    QueryBGZ();
                }
                else
                {
                    MessageBox.Show("共" + count + "条数据，保存成功" + scount + "条");
                    imgcbo_cx1.EditValue = cbo_GW1.EditValue;
                    QueryBGZ();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Save2_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumberCX = this.gv_GG.GetSelectedRows();//获取产线选中行号数组；
                if (rownumberCX.Count() == 0)
                {
                    MessageBox.Show("未选中规格！"); return;
                }
                int count = rownumberCX.Length;
                int scount = 0;
                string str = "";
                foreach (int item in rownumberCX)
                {
                    Mod_TPB_LINE_SPEC mod_TPB_LINE_SPEC = new Mod_TPB_LINE_SPEC();
                    mod_TPB_LINE_SPEC.C_STA_ID = cbo_CX.EditValue.ToString();
                    mod_TPB_LINE_SPEC.C_SPEC = gv_GG.GetRowCellValue(item, "C_SPEC").ToString();//规格
                    mod_TPB_LINE_SPEC.C_EMP_ID = RV.UI.UserInfo.userID;
                    mod_TPB_LINE_SPEC.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_STA_ID", mod_TPB_LINE_SPEC.C_STA_ID);
                    ht.Add("C_SPEC", mod_TPB_LINE_SPEC.C_SPEC);
                    ht.Add("N_STATUS", 1);
                    if (Common.CheckRepeat.CheckTable("TPB_LINE_SPEC", ht) > 0)
                    {
                        str += mod_TPB_LINE_SPEC.C_SPEC + ",";
                    }
                    else
                    {
                        bll_TPB_LINE_SPEC.Add(mod_TPB_LINE_SPEC);
                        scount += 1;
                    }
                    #endregion
                }
                if (str.Length > 0)
                {
                    MessageBox.Show("共" + count + "条数据，保存成功" + scount + "条," + str.Substring(0, str.Length - 1) + "已存在！");
                    BindGGByID();
                    imgcbo_cx2.EditValue = cbo_CX.EditValue;
                    QueryGG();
                }
                else
                {
                    MessageBox.Show("共" + count + "条数据，保存成功" + scount + "条");
                    BindGGByID();
                    imgcbo_cx2.EditValue = cbo_CX.EditValue;
                    QueryGG();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_query_GG_Click(object sender, EventArgs e)
        {
            QueryGG();
        }

        private void btn_Stop2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认停用？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int selectedNum = this.gv_ZGCXGG.SelectedRowsCount;
                int commitNum = 0;//停用记录数量
                int failtNum = 0;//停用失败数量
                int[] rownumber = this.gv_ZGCXGG.GetSelectedRows();//获取选中行号数组；
                foreach (int item in rownumber)
                {
                    string strID = this.gv_ZGCXGG.GetRowCellValue(item, "C_ID").ToString();
                    Mod_TPB_LINE_SPEC model = bll_TPB_LINE_SPEC.GetModel(strID);
                    model.N_STATUS = 0;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bool update = bll_TPB_LINE_SPEC.Update(model);
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
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用轧钢规格产线信息");//添加操作日志
                BindGGByID();
                QueryGG();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbo_GG1_SelectedValueChanged(object sender, EventArgs e)
        {
            sub.ComboBoxEditBindSPEC(cbo_GG2,cbo_GG1.EditValue.ToString());
            cbo_GG2.SelectedIndex = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BindGGByID();
        }
    }
}
