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
    public partial class FrmPB_ZGSCGG : Form
    {
        public FrmPB_ZGSCGG()
        {
            InitializeComponent();
        }
        CommonSub sub = new CommonSub();
        Bll_TQB_STD_SPEC bll_TQB_STD_SPEC = new Bll_TQB_STD_SPEC();
        Bll_TPB_LINE_SPEC bll_TPB_LINE_SPEC = new Bll_TPB_LINE_SPEC();
        private string strMenuName;
        private void FrmPB_CXBSCGZ_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strMenuName = RV.UI.UserInfo.menuName;
            sub.ComboBoxEditBindSPEC(cbo_GG1, "");
            sub.ImageComboBoxEditBindGWByGXstr("'ZX'", cbo_CX);
            sub.ImageComboBoxEditBindGWByGXstr("'ZX'", imgcbo_cx2);
            cbo_CX.SelectedIndex = 0;
            sub.ImageComboBoxEditBindGWByGXstr("'ZX'", imgcbo_cx2);
            imgcbo_cx2.Properties.Items.Add("全部", "", 0);
            imgcbo_cx2.SelectedIndex = 0;
            cbo_GG1.SelectedIndex = 0;
            BindGGByID();
            QueryGG();
        }

        private void btn_QueryGG_Click(object sender, EventArgs e)
        {
            try
            {
                BindGGByID();
            }
            catch 
            {
                MessageBox.Show("规格请输入数字类型或根据选择产线选择规格!");
            }
        }
        /// <summary>
        /// 根据工位加载规格信息
        /// </summary>
        /// <param name="strID">执行标准主键</param>
        public void BindGGByID()
        {
            DataTable dt = bll_TQB_STD_SPEC.GetSPECListBySTA(cbo_CX.EditValue.ToString(), cbo_GG1.EditValue.ToString(), cbo_GG2.EditValue.ToString()).Tables[0];
            this.gc_GG.DataSource = dt;
            this.gv_GG.OptionsView.ColumnAutoWidth = false;

            this.gv_GG.OptionsSelection.MultiSelect = true;
            this.gv_GG.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GG.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GG);

        }
        private void btn_Save_Click(object sender, EventArgs e)
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
        /// <summary>
        /// 查询产线规格
        /// </summary>
        private void QueryGG()
        {
            DataTable dt = null;
            dt = bll_TPB_LINE_SPEC.GetSpecListBySTA(1, imgcbo_cx2.EditValue.ToString()).Tables[0];
            this.gc_ZGCXGG.DataSource = dt;
            this.gv_ZGCXGG.OptionsView.ColumnAutoWidth = false;
            this.gv_ZGCXGG.OptionsSelection.MultiSelect = true;
            this.gv_ZGCXGG.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            colC_STA_ID.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_ZGCXGG.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ZGCXGG);
        }

        private void btn_Stop2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int selectedNum = this.gv_ZGCXGG.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
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
                MessageBox.Show("选择" + selectedNum.ToString() + "条记录，删除" + commitNum.ToString() + "条记录！");
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除轧钢规格产线信息");//添加操作日志
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
            sub.ComboBoxEditBindSPEC(cbo_GG2, cbo_GG1.EditValue.ToString());
            cbo_GG2.SelectedIndex = cbo_GG2.Properties.Items.Count-1;
        }

        private void btn_DCKSCGG_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_ZGCXGG);
        }
    }
}
