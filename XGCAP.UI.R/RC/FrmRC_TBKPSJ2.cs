using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.R.RC
{
    public partial class FrmRC_TBKPSJ2 : Form
    {
        public FrmRC_TBKPSJ2()
        {
            InitializeComponent();
            var arr = RV.UI.QueryString.parameter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            staID = bll_TB_STA.GetStaIdByCode(arr[0]);
            slbwhCode = arr[1];
        }

        string staID = "";//工位ID
        string slbwhCode = "";//合格坯仓库库位编码

        private Bll_TB_STA bll_TB_STA = new Bll_TB_STA();
        private Bll_TRC_COGDOWN_MAIN bll_TRC_COGDOWN_MAIN = new Bll_TRC_COGDOWN_MAIN();

        private void btn_Query_Click(object sender, EventArgs e)
        {
            BindToSlabList();
        }

        /// <summary>
        /// 绑定已调拨钢坯数据
        /// </summary>
        public void BindToSlabList()
        {
            try
            {
                DataTable dt = bll_TRC_COGDOWN_MAIN.GetCogDownFact(2, staID).Tables[0];
                this.gc_TBKPSJ.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_TBKPSJ);
            }
            catch
            {

            }
        }

        public void BtnEnabled(string status)
        {
            this.btn_A2.Enabled = false;
            this.btn_A3.Enabled = false;
            this.btn_A4.Enabled = false;
            this.btn_46.Enabled = false;

            if (status == "2")
                this.btn_A2.Enabled = true;
            else if (status == "3")
                this.btn_A3.Enabled = true;
            else if (status == "4")
                this.btn_A4.Enabled = true;
            else if (status == "5")
                this.btn_46.Enabled = true;
        }

        private void gv_TBKPSJ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_TBKPSJ.GetDataRow(gv_TBKPSJ.FocusedRowHandle);
                if (dr != null)
                {
                    BtnEnabled(dr["N_IF_EXEC_STATUS"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_A2_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认同步吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_TBKPSJ.FocusedRowHandle;//获取计划焦点行索引
            int selectedAllowGrd = this.gv_TBKPSJ.FocusedRowHandle;//获取可轧钢种焦点行索引
            if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
            {
                MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                return;
            }

            string id = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_COGDOWN_ID").ToString();//获取焦点id
            string shift = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_SHIFT").ToString();//获取焦点班次
            string group = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_GROUP").ToString();//获取焦点班组
            string result = bll_TRC_COGDOWN_MAIN.KpSyncNcA2(id, slbwhCode, staID, Application.StartupPath, shift, group);
            if (result == "0")
            {  
                MessageBox.Show("同步成功");
            }
           else
                MessageBox.Show("同步失败");
            BindToSlabList();
        }

        private void btn_A3_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认同步吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_TBKPSJ.FocusedRowHandle;//获取计划焦点行索引
            int selectedAllowGrd = this.gv_TBKPSJ.FocusedRowHandle;//获取可轧钢种焦点行索引
            if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
            {
                MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                return;
            }

            string id = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_COGDOWN_ID").ToString();//获取焦点id
            string shift = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_SHIFT").ToString();//获取焦点班次
            string group = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_GROUP").ToString();//获取焦点班组
            string result = bll_TRC_COGDOWN_MAIN.KpSyncNcA3(id, slbwhCode, staID, Application.StartupPath, shift, group);
            if (result == "0")
            {
                MessageBox.Show("同步成功");
            }
            else
                MessageBox.Show("同步失败");
            BindToSlabList();
        }

        private void btn_A4_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认同步吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_TBKPSJ.FocusedRowHandle;//获取计划焦点行索引
            int selectedAllowGrd = this.gv_TBKPSJ.FocusedRowHandle;//获取可轧钢种焦点行索引
            if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
            {
                MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                return;
            }

            string id = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_COGDOWN_ID").ToString();//获取焦点id
            string shift = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_SHIFT").ToString();//获取焦点班次
            string group = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_GROUP").ToString();//获取焦点班组
            string result = bll_TRC_COGDOWN_MAIN.KpSyncNcA4(id, slbwhCode, staID, Application.StartupPath, shift, group);
            if (result == "0")
            {
                MessageBox.Show("同步成功");
            }
            else
                MessageBox.Show("同步失败");
            BindToSlabList();
        }

        private void btn_46_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认同步吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                return;
            }

            int selectedPlanHandle = this.gv_TBKPSJ.FocusedRowHandle;//获取计划焦点行索引
            int selectedAllowGrd = this.gv_TBKPSJ.FocusedRowHandle;//获取可轧钢种焦点行索引
            if (selectedPlanHandle < 0 || selectedAllowGrd < 0)
            {
                MessageBox.Show("请检查计划和可轧钢种，记录为空!");
                return;
            }

            string id = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_COGDOWN_ID").ToString();//获取焦点id
            string shift = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_SHIFT").ToString();//获取焦点班次
            string group = this.gv_TBKPSJ.GetRowCellValue(selectedPlanHandle, "C_GROUP").ToString();//获取焦点班组
            string result = bll_TRC_COGDOWN_MAIN.KpSyncNc46(id, slbwhCode, staID, Application.StartupPath, shift, group);
            if (result == "0")
            {
                MessageBox.Show("同步成功");
            }
            else
                MessageBox.Show("同步失败");
            BindToSlabList();
        }

        private void FrmRC_TBKPSJ2_Load(object sender, EventArgs e)
        {
            BindToSlabList();
        }
    }
}
