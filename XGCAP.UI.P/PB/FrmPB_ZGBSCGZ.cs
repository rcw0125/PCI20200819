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
    public partial class FrmPB_ZGBSCGZ : Form
    {
        public FrmPB_ZGBSCGZ()
        {
            InitializeComponent();
        }
        private string strMenuName;
        CommonSub sub = new CommonSub();
        Bll_TPB_N_GRD bll_TPB_N_GRD = new Bll_TPB_N_GRD();
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();
        private void FrmPB_CXSCGG_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strMenuName = RV.UI.UserInfo.menuName;
            sub.ImageComboBoxEditBindGWByGXstr("'ZX'", cbo_GW1);
            cbo_GW1.SelectedIndex = 0;
            sub.ImageComboBoxEditBindGWByGXstr("'ZX'", imgcbo_cx1);
            imgcbo_cx1.Properties.Items.Add("全部","",0);
            imgcbo_cx1.SelectedIndex = 0;
            Query();
            QueryBGZ();
            DataTable dtgg = bll_TPB_N_GRD.GetGG();
            cbo_GG2.Properties.Items.Clear();
            cbo_GG2.Properties.Items.Add("");
            for (int i = 0; i < dtgg.Rows.Count; i++)
            {
                cbo_GG2.Properties.Items.Add(dtgg.Rows[i]["C_SPEC"].ToString());
            }
            
        }
        private void btn_query_GZ_Click(object sender, EventArgs e)
        {
            QueryBGZ();
        }
        /// <summary>
        /// 查询产线不生产钢种
        /// </summary>
        private void QueryBGZ()
        {
            DataTable dt = null;
            dt = bll_TPB_N_GRD.GetList(1, imgcbo_cx1.EditValue.ToString(), txtGZ1.Text, txtBZ1.Text).Tables[0];
            this.gc_ZGBSCGZ.DataSource = dt;
            this.gv_ZZGBSCGZ.OptionsView.ColumnAutoWidth = false;
            this.gv_ZZGBSCGZ.OptionsSelection.MultiSelect = true;
            this.gv_ZZGBSCGZ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridColumn18.ColumnEdit = sub.GetGWIdDescItemComboBox();
            this.gv_ZZGBSCGZ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_ZZGBSCGZ);

        }
        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
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
                    //mod_TPB_N_GRD.C_SPEC = cbo_GG2.EditValue.ToString();
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
                    ht.Add("N_STATUS",1);
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

        private void btn_Stop1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int selectedNum = this.gv_ZZGBSCGZ.SelectedRowsCount;
                int commitNum = 0;//删除记录数量
                int failtNum = 0;//删除失败数量
                int[] rownumber = this.gv_ZZGBSCGZ.GetSelectedRows();//获取选中行号数组；
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = this.gv_ZZGBSCGZ.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    bool update = bll_TPB_N_GRD.Delete(strID);
                   
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
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除不生产钢种信息");//添加操作日志

                QueryBGZ();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_DCCXBSCGZ_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel( this.gc_ZGBSCGZ);
        }
    }
}
