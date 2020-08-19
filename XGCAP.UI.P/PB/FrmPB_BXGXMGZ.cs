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
    public partial class FrmPB_BXGXMGZ : Form
    {
        public FrmPB_BXGXMGZ()
        {
            InitializeComponent();
        }
        Bll_TQB_STD_MAIN bll_TQB_STD_MAIN = new Bll_TQB_STD_MAIN();
        Bll_TPB_BXGXMGZ bll = new Bll_TPB_BXGXMGZ();
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
            dt = bll_TQB_STD_MAIN.GetList_Type(txt_Grd.Text, "1").Tables[0];
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
                    Mod_TPB_BXGXMGZ mod = new Mod_TPB_BXGXMGZ();
                    mod.C_GZLX = cbo_GZ.EditValue.ToString();
                    //mod.C_SPEC = cbo_SPEC.EditValue.ToString();
                    mod.C_STL_GRD = gv_StdMain.GetRowCellValue(item, "C_STL_GRD").ToString();//钢种
                    mod.N_JSCN = Convert.ToDecimal(txt_JSCN.Text);
                    mod.C_EMP_ID = RV.UI.UserInfo.userID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_STL_GRD", mod.C_STL_GRD);
                   // ht.Add("C_SPEC", mod.C_SPEC);
                    ht.Add("C_GZLX", mod.C_GZLX);
                    if (Common.CheckRepeat.CheckTable("TPB_BXGXMGZ", ht) > 0)
                    {
                       // str += mod.C_STL_GRD + "(" + mod.C_SPEC + "),";
                    }
                    else
                    {
                        bll.Add(mod);
                        scount += 1;
                    }
                    #endregion

                }
                if (str.Length > 0)
                {
                    MessageBox.Show("共" + count + "条数据，保存成功" + scount + "条," + str.Substring(0, str.Length - 1) + "已存在！");
                }
                else
                {
                    MessageBox.Show("共" + count + "条数据，保存成功" + scount + "条");

                }
                QueryGZ();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmPB_BXGXMGZ_Load(object sender, EventArgs e)
        {
            cbo_GZ.SelectedIndex = 0;
            cbo_SPEC.SelectedIndex = 0;
            cbo_GZ2.SelectedIndex = 0;
            cbo_SPEC2.SelectedIndex = 0;
        }

        private void btn_QueryGZ_Click(object sender, EventArgs e)
        {
            QueryGZ();
        }
        /// <summary>
        /// 查询钢种、执行标准信息
        /// </summary>
        private void QueryGZ()
        {
            DataTable dt = null;
            dt = bll.GetList("").Tables[0];
            this.gc_GZ.DataSource = dt;
            this.gv_GZ.OptionsView.ColumnAutoWidth = false;
            this.gv_GZ.OptionsSelection.MultiSelect = true;
            this.gv_GZ.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_GZ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_GZ);

        }

        private void btn_Stop2_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumberCX = this.gv_GZ.GetSelectedRows();//获取产线选中行号数组；
                if (rownumberCX.Count() == 0)
                {
                    MessageBox.Show("未选中钢种信息！"); return;
                }
                int count = rownumberCX.Length;
                int scount = 0;
                string str = "";
                foreach (var item in rownumberCX)
                {
                    string id = gv_GZ.GetRowCellValue(item, "C_ID").ToString();//钢种
                    bll.Delete(id);
                    scount += 1;
                }
                if (str.Length > 0)
                {
                    MessageBox.Show("共" + count + "条数据，删除成功" + scount + "条," + str.Substring(0, str.Length - 1) + "已存在！");
                }
                else
                {
                    MessageBox.Show("共" + count + "条数据，删除成功" + scount + "条");

                }
                QueryGZ();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_DCKSCGG_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_GZ);
        }
    }
}
