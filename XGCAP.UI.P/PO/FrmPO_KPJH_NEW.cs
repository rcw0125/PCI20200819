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
    public partial class FrmPO_KPJH_NEW : Form
    {
        Bll_TSP_PLAN_SMS bll_sms = new Bll_TSP_PLAN_SMS();
        Bll_TMO_ORDER bllorder = new Bll_TMO_ORDER();
        Bll_TRP_PLAN_COGDOWN bll_kp = new Bll_TRP_PLAN_COGDOWN();
        Bll_TSC_SLAB_MAIN bllTscSlabMain = new Bll_TSC_SLAB_MAIN();
        Bll_TB_MATRL_MAIN bll_wl = new Bll_TB_MATRL_MAIN();

        private string strHsl = "0";

        public FrmPO_KPJH_NEW()
        {
            InitializeComponent();
        }

        private void FrmPO_KPJH_NEW_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            CommonSub.BindIcboNoAll("", "KP", icbo_zx3);
            icbo_zx3.SelectedIndex = 0;
        }

        private void btn_query_zg_Click(object sender, EventArgs e)
        {
            BindKP();
        }

        private void BindKP()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gridControl1.DataSource = null;

                string result = bllTscSlabMain.P_UPDATE_KP_MATRAL();

                DataTable dt = bllTscSlabMain.Get_List_Kp(txt_Stl_Grd.Text.Trim(), txt_Std_Code.Text.Trim(), txt_Stove.Text.Trim()).Tables[0];

                this.gridControl1.DataSource = dt;
                this.gridView1.OptionsSelection.MultiSelect = true;
                gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

                SetGridViewRowNum.SetRowNum(gridView1);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xf_Click(object sender, EventArgs e)
        {
            if (this.icbo_zx3.SelectedIndex < 0)
            {
                MessageBox.Show("请选择开坯线！");
                this.icbo_zx3.Focus();
                return;
            }

            int[] rownumber = gridView1.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length == 0)
            {
                MessageBox.Show("请选择需要下发的计划！");
                return;
            }
            DataRow row = gridView1.GetDataRow(rownumber[0]);
            for (int i = 0; i < rownumber.Length; i++)
            {
                DataRow dr = gridView1.GetDataRow(rownumber[i]);
                if (dr["C_STL_GRD"].ToString() != row["C_STL_GRD"].ToString()
                  || dr["C_STD_CODE"].ToString() != row["C_STD_CODE"].ToString()
                  || dr["C_MAT_CODE"].ToString() != row["C_MAT_CODE"].ToString()
                  || dr["C_SPEC"].ToString() != row["C_SPEC"].ToString()
                  || dr["N_LEN"].ToString() != row["N_LEN"].ToString()
                  || dr["C_ZYX1"].ToString() != row["C_ZYX1"].ToString()
                  || dr["C_ZYX2"].ToString() != row["C_ZYX2"].ToString())
                {
                    MessageBox.Show("选择需要下发的开坯计划信息不一致，请重新选择！");
                    return;
                }
            }

            if (string.IsNullOrEmpty(btn_mat_code.Text.Trim()) || string.IsNullOrEmpty(txt_mat_name.Text.Trim()) || string.IsNullOrEmpty(txt_Slab_Size.Text.Trim()) || string.IsNullOrEmpty(txt_Len.Text.Trim()) || string.IsNullOrEmpty(strHsl))
            {
                MessageBox.Show("热轧坯物料编码有误！");
                return;
            }
            else
            {
                if (DialogResult.No == MessageBox.Show("确认下发 物料：" + btn_mat_code.Text.Trim() + "断面：" + txt_Slab_Size.Text.Trim() + "*" + txt_Len.Text.Trim() + "的开坯计划吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
            }

            WaitingFrom.ShowWait("");

            for (int i = 0; i < rownumber.Length; i++)
            {
                DataRow dr = gridView1.GetDataRow(rownumber[i]);

                int i_sort = bll_kp.Get_Max_Sort() + 1;

                Mod_TB_MATRL_MAIN modWl = bll_wl.GetModel(btn_mat_code.Text.Trim());
                if (modWl == null)
                {
                    MessageBox.Show("没有找到热轧坯物料编码，不能下发！");
                    return;
                }
                else
                {
                    if (modWl.C_STL_GRD != dr["C_STL_GRD"].ToString())
                    {
                        MessageBox.Show("热轧坯钢种和大方坯钢种不一致，不能下发！");
                        return;
                    }
                }

                Mod_TRP_PLAN_COGDOWN mod = new Mod_TRP_PLAN_COGDOWN();
                mod.C_ID = System.Guid.NewGuid().ToString();
                mod.N_STATUS = 1;
                mod.C_INITIALIZE_ITEM_ID = "";
                mod.N_SORT = i_sort;
                mod.N_WGT = Convert.ToDecimal(dr["N_WGT"].ToString());
                mod.C_MAT_CODE = btn_mat_code.Text.Trim();
                mod.C_MAT_NAME = txt_mat_name.Text.Trim();
                mod.C_SPEC = txt_Slab_Size.Text.Trim();
                mod.C_STL_GRD = dr["C_STL_GRD"].ToString();
                mod.C_STD_CODE = dr["C_STD_CODE"].ToString();
                mod.N_LENTH = Convert.ToDecimal(txt_Len.Text.Trim());
                try
                {
                    mod.D_P_START_TIME = RV.UI.ServerTime.timeNow();
                    mod.D_P_END_TIME = Convert.ToDateTime(mod.D_P_START_TIME).AddHours(Convert.ToDouble(mod.N_WGT / 114));
                }
                catch
                {

                }
                mod.C_STA_ID = this.icbo_zx3.Properties.Items[this.icbo_zx3.SelectedIndex].Value.ToString();
                mod.C_CAST_NO = dr["C_STOVE"].ToString();
                mod.C_LINE_DESC = this.icbo_zx3.Properties.Items[this.icbo_zx3.SelectedIndex].Description.ToString();
                mod.C_FREE1 = dr["C_ZYX1"].ToString();
                mod.C_FREE2 = dr["C_ZYX2"].ToString();
                mod.C_EMP_ID = RV.UI.UserInfo.userID;
                mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                mod.N_PW = Convert.ToDecimal(strHsl);
                mod.C_MATRL_CODE_SLAB = dr["C_MAT_CODE"].ToString();
                mod.C_MATRL_NAME_SLAB = dr["C_MAT_NAME"].ToString();
                mod.C_SLAB_SIZE = dr["C_SPEC"].ToString();
                mod.N_SLAB_LENGTH = Convert.ToDecimal(dr["N_LEN"].ToString());

                Mod_TB_MATRL_MAIN modMaterMain = bll_wl.GetModel(dr["C_MAT_CODE"].ToString());
                if (modMaterMain != null)
                {
                    mod.N_SLAB_PW = modMaterMain.N_HSL;
                }

                bll_kp.Add(mod);
            }

            BindKP();

            BindPlan();

            WaitingFrom.CloseWait();

        }

        /// <summary>
        /// 撤回开坯计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_canale_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("计划正在撤回，请稍候...");
                int[] rownumber = this.gv_KPZPJH.GetSelectedRows();//获取选中行号数组；

                int num = 0;

                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string c_id = gv_KPZPJH.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TRP_PLAN_COGDOWN mod = bll_kp.GetModel(c_id);
                    if (mod.N_STATUS == 1 && mod.N_GROUP_WGT == 0)
                    {
                        if (bll_kp.Delete(c_id))
                        {
                            num++;
                        }
                    }
                }

                if (num > 0)
                {
                    MessageBox.Show("需要撤回{" + rownumber.Length + "}条计划，已成功撤回{" + num + "}条计划！");

                    BindKP();
                    BindPlan();
                }
                else
                {
                    MessageBox.Show("撤回失败！");
                }


                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btn_query_kpplan_Click(object sender, EventArgs e)
        {
            BindPlan();
        }

        private void BindPlan()
        {
            try
            {
                WaitingFrom.ShowWait("数据正在加载中，请稍候...");
                string C_STA_ID = this.icbo_zx3.Properties.Items[this.icbo_zx3.SelectedIndex].Value.ToString();
                DataTable lst = bll_kp.GetList(C_STA_ID, 1, false, txt_lh.Text.Trim(), txt_gz.Text.Trim(), txt_bz.Text.Trim()).Tables[0];
                this.modTRPPLANCOGDOWNBindingSource.DataSource = lst;
                this.gv_KPZPJH.OptionsView.ColumnAutoWidth = false;
                this.gv_KPZPJH.OptionsSelection.MultiSelect = true;
                gv_KPZPJH.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                SetGridViewRowNum.SetRowNum(gv_KPZPJH);
                this.gv_KPZPJH.BestFitColumns();
                WaitingFrom.CloseWait();
            }
            catch
            {

            }
        }

        private void btn_out2_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_KPZPJH, "开坯计划" + DateTime.Now.ToString("yyyyMMdd"));
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gridControl1, "开坯计划" + DateTime.Now.ToString("yyyyMMdd"));
        }

        private void btn_mat_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                    FrmPO_SELECT_WL frm = new FrmPO_SELECT_WL(dr["C_STD_CODE"].ToString(), dr["C_STL_GRD"].ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        btn_mat_code.Text = frm.str_MatCode;
                        txt_mat_name.Text = frm.str_MatName;
                        txt_Slab_Size.Text = frm.str_Spec;
                        txt_Len.Text = frm.str_Len;
                        strHsl = frm.str_Hsl;
                        frm.Close();
                    }
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //try
            //{
            //    DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            //    if (dr == null)
            //    {
            //        btn_mat_code.Text = "";
            //        txt_mat_name.Text = "";
            //        txt_Slab_Size.Text = "";
            //        txt_Len.Text = "";
            //        strHsl = "0";
            //    }
            //    else
            //    {
            //        btn_mat_code.Text = dr["C_MATRL_CODE_KP"].ToString();
            //        txt_mat_name.Text = dr["C_MATRL_NAME_KP"].ToString();
            //        txt_Slab_Size.Text = dr["C_KP_SIZE"].ToString();
            //        txt_Len.Text = dr["N_KP_LENGTH"].ToString();
            //        strHsl = dr["N_KP_PW"].ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;
            //}
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                int[] rownumber = gridView1.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    btn_mat_code.Text = "";
                    txt_mat_name.Text = "";
                    txt_Slab_Size.Text = "";
                    txt_Len.Text = "";
                    strHsl = "0";
                }
                else
                {
                    DataRow dr = gridView1.GetDataRow(rownumber[0]);//获取已选中的数据中的第一条数据
                    if (dr == null)
                    {
                        btn_mat_code.Text = "";
                        txt_mat_name.Text = "";
                        txt_Slab_Size.Text = "";
                        txt_Len.Text = "";
                        strHsl = "0";
                    }
                    else
                    {
                        btn_mat_code.Text = dr["C_MATRL_CODE_KP"].ToString();
                        txt_mat_name.Text = dr["C_MATRL_NAME_KP"].ToString();
                        txt_Slab_Size.Text = dr["C_KP_SIZE"].ToString();
                        txt_Len.Text = dr["N_KP_LENGTH"].ToString();
                        strHsl = dr["N_KP_PW"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
