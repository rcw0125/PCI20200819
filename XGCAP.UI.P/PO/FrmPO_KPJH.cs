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

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_KPJH : Form
    {
        public FrmPO_KPJH()
        {
            InitializeComponent();
        }
        Bll_TSP_PLAN_SMS bll_sms = new Bll_TSP_PLAN_SMS();
        Bll_TMO_ORDER bllorder = new Bll_TMO_ORDER();
        Bll_TRP_PLAN_COGDOWN bll_kp = new Bll_TRP_PLAN_COGDOWN();

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            int EXCESTATUS = this.radioGroup1.SelectedIndex;

            var lst = bll_sms.GetKP_PlanBySms(this.txt_gz4.Text.Trim(), this.txt_bz4.Text.Trim(), this.rbtn_zg.SelectedIndex, EXCESTATUS);
            this.gridControl1.DataSource = lst;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gridView1);
            this.gridView1.BestFitColumns();
            gridView1.ColumnWidthChanged += GridView1_ColumnWidthChanged;
            WaitingFrom.CloseWait();
        }

        private void GridView1_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            this.gridView1.OptionsView.RowAutoHeight = true;
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                //if (gridView1.Columns[i].FieldName == "C_STL_GRD")
                //{
                //设置所有列可编辑
                gridView1.Columns[i].OptionsColumn.AllowEdit = true;
                //RepositoryItemMemoEdit对每一列进行设置
                DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryitemmemoedi1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                gridView1.Columns[i].ColumnEdit = repositoryitemmemoedi1;
                repositoryitemmemoedi1.LinesCount = 0;

                //设置列不可编辑
                gridView1.Columns[i].OptionsColumn.AllowEdit = false;
                //}

            }
        }

        private void FrmPO_KPJH_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            CommonSub.BindIcboNoAll("", "KP", icbo_zx3);
            icbo_zx3.SelectedIndex = 0;
            rbtn_zg_SelectedIndexChanged(null, null);
        }

        private void btn_xf_Click(object sender, EventArgs e)
        {
            if (this.icbo_zx3.SelectedIndex < 0)
            {
                MessageBox.Show("请选择开坯线！");
                this.icbo_zx3.Focus();
                return;
            }

            WaitingFrom.ShowWait("");
            int[] rownumber = this.gridView1.GetSelectedRows();//获取选中行号数组；
            for (int i = 0; i < rownumber.Length; i++)
            {
                int selectedHandle = rownumber[i];

                Mod_TRP_PLAN_COGDOWN mod = new Mod_TRP_PLAN_COGDOWN();
                mod.C_ID = System.Guid.NewGuid().ToString();
                mod.N_STATUS = 1;
                mod.C_ORDER_NO = this.gridView1.GetRowCellValue(selectedHandle, "C_ID").ToString();
               // mod.C_INITIALIZE_ITEM_ID = this.gridView1.GetRowCellValue(selectedHandle, "N_JC_SORT").ToString();
               // mod.N_SORT = Convert.ToInt32(this.gridView1.GetRowCellValue(selectedHandle, "N_SORT").ToString());
                mod.N_WGT = Convert.ToDecimal(this.gridView1.GetRowCellValue(selectedHandle, "N_SLAB_WGT").ToString());
                mod.C_MAT_CODE = this.gridView1.GetRowCellValue(selectedHandle, "C_MATRL_CODE_KP").ToString();
                mod.C_MAT_NAME = this.gridView1.GetRowCellValue(selectedHandle, "C_MATRL_NAME_KP").ToString();
                mod.C_SPEC = this.gridView1.GetRowCellValue(selectedHandle, "C_KP_SIZE").ToString();
                mod.C_STL_GRD = this.gridView1.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
                mod.C_STD_CODE = this.gridView1.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();
                mod.N_LENTH = Convert.ToDecimal(this.gridView1.GetRowCellValue(selectedHandle, "N_KP_LENGTH").ToString());
                try
                {
                    mod.D_P_START_TIME = Convert.ToDateTime(this.gridView1.GetRowCellValue(selectedHandle, "D_KP_START_TIME").ToString());
                    mod.D_P_END_TIME = Convert.ToDateTime(this.gridView1.GetRowCellValue(selectedHandle, "D_KP_END_TIME").ToString());
                }
                catch (Exception)
                {

                }
                mod.C_STA_ID = this.icbo_zx3.Properties.Items[this.icbo_zx3.SelectedIndex].Value.ToString();
                mod.C_CAST_NO = this.gridView1.GetRowCellValue(selectedHandle, "C_STOVE_NO").ToString();
                mod.C_LINE_DESC = this.icbo_zx3.Properties.Items[this.icbo_zx3.SelectedIndex].Description.ToString();
                mod.C_FREE1 = this.gridView1.GetRowCellValue(selectedHandle, "C_FREE1").ToString();
                mod.C_FREE2 = this.gridView1.GetRowCellValue(selectedHandle, "C_FREE2").ToString();
                mod.C_EMP_ID = RV.UI.UserInfo.userID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                mod.N_PW = Convert.ToDecimal(this.gridView1.GetRowCellValue(selectedHandle, "N_KP_PW").ToString());
                mod.C_MATRL_CODE_SLAB = this.gridView1.GetRowCellValue(selectedHandle, "C_MATRL_NO").ToString();
                mod.C_MATRL_NAME_SLAB = this.gridView1.GetRowCellValue(selectedHandle, "C_MATRL_NAME").ToString();
                mod.C_SLAB_SIZE = this.gridView1.GetRowCellValue(selectedHandle, "C_SLAB_SIZE").ToString();
                mod.N_SLAB_LENGTH = Convert.ToDecimal(this.gridView1.GetRowCellValue(selectedHandle, "C_SLAB_LENGTH").ToString());
               
                mod.N_SLAB_PW = Convert.ToDecimal(this.gridView1.GetRowCellValue(selectedHandle, "N_SLAB_PW").ToString());

                Mod_TSP_PLAN_SMS mod_sms = bll_sms.GetModel(mod.C_ORDER_NO);
                mod_sms.N_CREAT_ZG_PLAN = 1;
                bll_sms.Update(mod_sms);

                bll_kp.Add(mod);
            }
            #region MyRegion
            //for (int i = 0; i < rownumber.Length; i++)
            //{
            //    int selectedHandle = rownumber[i];

            //    Mod_TRP_PLAN_COGDOWN mod = new Mod_TRP_PLAN_COGDOWN();
            //    mod.C_ID = System.Guid.NewGuid().ToString();
            //    mod.N_STATUS = 1;
            //    mod.C_INITIALIZE_ITEM_ID = this.gridView1.GetRowCellValue(selectedHandle, "N_JC_SORT").ToString();
            //    mod.N_SORT = Convert.ToInt32(this.gridView1.GetRowCellValue(selectedHandle, "N_SORT").ToString());
            //    mod.N_WGT = Convert.ToDecimal(this.gridView1.GetRowCellValue(selectedHandle, "N_SLAB_WGT").ToString());
            //    mod.C_MAT_CODE = this.gridView1.GetRowCellValue(selectedHandle, "C_MATRL_CODE_KP").ToString();
            //    mod.C_MAT_NAME = this.gridView1.GetRowCellValue(selectedHandle, "C_MATRL_NAME_KP").ToString();
            //    mod.C_SPEC = this.gridView1.GetRowCellValue(selectedHandle, "C_KP_SIZE").ToString();
            //    mod.C_STL_GRD = this.gridView1.GetRowCellValue(selectedHandle, "C_STL_GRD").ToString();
            //    mod.C_STD_CODE = this.gridView1.GetRowCellValue(selectedHandle, "C_STD_CODE").ToString();
            //    mod.N_LENTH = Convert.ToDecimal(this.gridView1.GetRowCellValue(selectedHandle, "N_KP_LENGTH").ToString());
            //    try
            //    {
            //        mod.D_P_START_TIME = Convert.ToDateTime(this.gridView1.GetRowCellValue(selectedHandle, "D_P_START_TIME").ToString());
            //        mod.D_P_END_TIME = Convert.ToDateTime(this.gridView1.GetRowCellValue(selectedHandle, "D_P_END_TIME").ToString());
            //    }
            //    catch (Exception)
            //    {

            //    }
            //    mod.C_STA_ID = this.icbo_zx3.Properties.Items[this.icbo_zx3.SelectedIndex].Value.ToString();
            //    mod.C_FREE1 = this.gridView1.GetRowCellValue(selectedHandle, "C_FREE1").ToString();
            //    mod.C_FREE2 = this.gridView1.GetRowCellValue(selectedHandle, "C_FREE2").ToString();
            //    mod.C_EMP_ID = RV.UI.UserInfo.userID;
            //    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
            //    mod.N_PW = Convert.ToDecimal(this.gridView1.GetRowCellValue(selectedHandle, "N_KP_PW").ToString());
            //    mod.C_MATRL_CODE_SLAB = this.gridView1.GetRowCellValue(selectedHandle, "C_MATRL_NO").ToString();
            //    mod.C_MATRL_NAME_SLAB = this.gridView1.GetRowCellValue(selectedHandle, "C_MATRL_NAME").ToString();
            //    mod.C_SLAB_SIZE = this.gridView1.GetRowCellValue(selectedHandle, "C_SLAB_SIZE").ToString();
            //    mod.N_SLAB_LENGTH = Convert.ToDecimal(this.gridView1.GetRowCellValue(selectedHandle, "C_SLAB_LENGTH").ToString());
            //    mod.N_SLAB_PW = Convert.ToDecimal(this.gridView1.GetRowCellValue(selectedHandle, "N_SLAB_PW").ToString());
            //    bll_sms.Down_KP(mod.C_STL_GRD, mod.C_MATRL_CODE_SLAB, mod.C_STD_CODE, mod.C_MAT_CODE, mod.C_INITIALIZE_ITEM_ID);
            //    bll_kp.Add(mod);
            //}
            #endregion

            btn_query_zg_Click(null, null);
            btn_query_kpplan_Click(null, null);
            WaitingFrom.CloseWait();

        }

        /// <summary>
        /// 撤回开坯计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_canale_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("计划正在撤回，请稍候...");
            int[] rownumber = this.gv_KPZPJH.GetSelectedRows();//获取选中行号数组；
            for (int i = 0; i < rownumber.Length; i++)
            {
                int selectedHandle = rownumber[i];
                string c_id = gv_KPZPJH.GetRowCellValue(selectedHandle, "C_ID").ToString();
                Mod_TRP_PLAN_COGDOWN mod = bll_kp.GetModel(c_id);
                if (mod.N_STATUS == 1 && mod.N_GROUP_WGT == 0)
                {
                    string order_id = mod.C_ORDER_NO;
                    Mod_TSP_PLAN_SMS mod_sms = bll_sms.GetModel(order_id);
                    if (mod_sms != null)
                    {
                        mod_sms.N_CREAT_ZG_PLAN = 0;
                        bll_sms.Update(mod_sms);
                        bll_kp.Delete(c_id);
                    }

                }
            }
            WaitingFrom.CloseWait();
            btn_query_zg_Click(null, null);
            btn_query_kpplan_Click(null, null);
        }

        private void rbtn_zg_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.rbtn_zg.SelectedIndex == 0)
            {
                btn_xf.Enabled = true;
                this.radioGroup1.Enabled = true;
            }
            else if (this.rbtn_zg.SelectedIndex == 1)
            {
                btn_xf.Enabled = false;
                this.radioGroup1.Enabled = false;
            }
            else
            {
                btn_xf.Enabled = false;
                this.radioGroup1.Enabled = false;
            }

        }

        private void btn_query_kpplan_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("数据正在加载中，请稍候...");
            string C_STA_ID = this.icbo_zx3.Properties.Items[this.icbo_zx3.SelectedIndex].Value.ToString();
            DataTable lst = bll_kp.GetList(C_STA_ID, 1, false).Tables[0];
            this.modTRPPLANCOGDOWNBindingSource.DataSource = lst;
            this.gv_KPZPJH.OptionsView.ColumnAutoWidth = false;
            this.gv_KPZPJH.OptionsSelection.MultiSelect = true;
            gv_KPZPJH.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gv_KPZPJH);
            this.gv_KPZPJH.BestFitColumns();
            WaitingFrom.CloseWait();

        }

        private void btn_out2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_KPZPJH, "开坯计划" + DateTime.Now.ToString("yyyyMMdd"));
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl1, "开坯计划" + DateTime.Now.ToString("yyyyMMdd"));
        }
    }
}
