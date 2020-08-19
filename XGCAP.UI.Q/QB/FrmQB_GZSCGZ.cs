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

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_GZSCGZ : Form
    {
        public FrmQB_GZSCGZ()
        {
            InitializeComponent();
        }
        private string strMenuName;
        string strPhyCode;
        Bll_TQB_STD_MAIN bll_StdMain = new Bll_TQB_STD_MAIN();
        Bll_TQB_GZ_CHECK bll_GzCheck = new Bll_TQB_GZ_CHECK();
        private void FrmQB_GZSCGZ_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;
            strPhyCode = RV.UI.QueryString.parameter;
            gv_std_right.OptionsSelection.MultiSelect = true;
            gv_std_right.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

            NewMethod();
            NewMethod1();
        }
        /// <summary>
        /// 查询执行标准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            WaitingFrom.ShowWait("");
            DataTable dt = bll_StdMain.GetList_GZ(1, txt_Std.Text.Trim(), txt_Grd.Text.Trim()).Tables[0];
            gc_std_main.DataSource = dt;
            gv_std_main.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_std_main);
            WaitingFrom.CloseWait();
        }

        /// <summary>
        /// 查询未匹配的钢种
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            NewMethod1();
        }

        private void NewMethod1()
        {
            DataTable dt = bll_StdMain.GetList_GZ(1, txt_std1.Text.Trim(), txt_Grd1.Text.Trim()).Tables[0];
            gc_std_right.DataSource = dt;
            gv_std_right.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_std_right);
        }

        /// <summary>
        /// 查询已匹配信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_std_main_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod2();
        }

        private void NewMethod2()
        {
            try
            {
                DataRow dr = gv_std_main.GetDataRow(gv_std_main.FocusedRowHandle);
                if (dr == null) return;
                DataTable dt = bll_GzCheck.Query(dr["C_ID"].ToString()).Tables[0];
                gc_std_check.DataSource = dt;
                gv_std_check.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_std_check);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataRow dr_main = gv_std_main.GetDataRow(gv_std_main.FocusedRowHandle);
            string str = "";
            int succount = 0;
            if (dr_main == null) return;
            int[] rownumber = gv_std_right.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length == 0)
            {
                MessageBox.Show("请选择需要保存的信息！");
                return;
            }
            for (int i = 0; i < rownumber.Length; i++)
            {
                int selectedHandle = rownumber[i];
                string strID = gv_std_right.GetRowCellValue(selectedHandle, "C_ID").ToString();
                Mod_TQB_STD_MAIN mod_ID = bll_StdMain.GetModel(strID);
                Mod_TQB_GZ_CHECK mod = new Mod_TQB_GZ_CHECK();
                mod.C_STD_ID = dr_main["C_ID"].ToString();
                mod.C_STD_MAIN_ID = mod_ID.C_ID.ToString();
                mod.C_CHECK = "1";
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STD_ID", mod.C_STD_ID);
                ht.Add("C_STD_MAIN_ID", mod.C_STD_MAIN_ID);
                ht.Add("C_CHECK", 1);
                if (Common.CheckRepeat.CheckTable("TQB_GZ_CHECK", ht) > 0)
                {
                    str += mod_ID.C_STL_GRD + "(" + mod_ID.C_STD_CODE + "),";
                }
                else
                {
                    bll_GzCheck.Add(mod);
                    succount += 1;
                }
                #endregion
            }
            if (str.Length > 0)
            {
                MessageBox.Show("共" + rownumber.Count() + "条数据，保存成功" + succount + "条," + str.Substring(0, str.Length - 1) + "已存在！");
                NewMethod2();
            }
            else
            {
                MessageBox.Show("保存成功！");
                NewMethod2();
            }
            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "保存钢种生产规则");//添加操作日志
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_std_check.GetDataRow(gv_std_check.FocusedRowHandle);
            if (dr == null) return;
            bll_GzCheck.Delete(dr["C_ID"].ToString());
            NewMethod2();
            MessageBox.Show("删除成功！");
            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除钢种生产规则");//添加操作日志
        }
    }
}
