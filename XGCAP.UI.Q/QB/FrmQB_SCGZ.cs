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
    public partial class FrmQB_SCGZ : Form
    {
        public FrmQB_SCGZ()
        {
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQB_STD_MAIN bllStdMain = new Bll_TQB_STD_MAIN();
        Bll_TQB_RINSE_TANK_GRD bllRinseTank = new Bll_TQB_RINSE_TANK_GRD();
        private void FrmQB_SCGZ_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;
            gv_std_main.OptionsSelection.MultiSelect = true;
            gv_std_main.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
        }
        /// <summary>
        /// 执行标准主表查询
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
            DataTable dt = bllStdMain.GetList_TANK(txt_Std.Text.Trim(), txt_Grd.Text.Trim()).Tables[0];
            gc_std_main.DataSource = dt;
            gv_std_main.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_std_main);
            WaitingFrom.CloseWait();
        }
        /// <summary>
        /// 查询涮槽钢种
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            NewMethod1();
        }

        private void NewMethod1()
        {
            DataTable dt = bllRinseTank.Query(txt_std1.Text.Trim(), txt_grd1.Text.Trim()).Tables[0];
            gc_std_check.DataSource = dt;
            gv_std_check.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_std_check);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            int[] rownumber = gv_std_main.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length == 0)
            {
                MessageBox.Show("请选择需要添加的信息！");
                return;
            }

            string strUserID = RV.UI.UserInfo.UserID;

            for (int i = 0; i < rownumber.Length; i++)
            {
                int selectedHandle = rownumber[i];
                string strID = gv_std_main.GetRowCellValue(selectedHandle, "C_ID").ToString();
                Mod_TQB_STD_MAIN mod_ID = bllStdMain.GetModel(strID);
                Mod_TQB_RINSE_TANK_GRD mod = new Mod_TQB_RINSE_TANK_GRD();
                mod.C_STD_CODE = mod_ID.C_STD_CODE;
                mod.C_STL_GRD = mod_ID.C_STL_GRD;
                mod.C_EMP_ID = strUserID;

                bllRinseTank.Add(mod);
            }
            NewMethod();
            NewMethod1();
            MessageBox.Show("添加成功！");

            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加涮槽钢种");//添加操作日志 
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
            bllRinseTank.Delete(dr["C_ID"].ToString());
            NewMethod();
            NewMethod1();
            MessageBox.Show("删除成功！");
            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除涮槽钢种");//添加操作日志
        }
    }
}
