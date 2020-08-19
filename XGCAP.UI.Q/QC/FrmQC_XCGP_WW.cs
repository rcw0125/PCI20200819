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
using XGCAP.UI.Q.QB;

namespace XGCAP.UI.Q.QC
{
    /// <summary>
    /// 2018-05-24 zmc
    /// </summary>
    public partial class FrmQC_XCGP_WW : Form
    {
        public FrmQC_XCGP_WW()
        {
            InitializeComponent();
        }
        Bll_TQB_CHECKSTATE bll_checkstate = new Bll_TQB_CHECKSTATE();
        Bll_TRC_ROLL_PRODCUT bll_roll_product = new Bll_TRC_ROLL_PRODCUT();
        Bll_TQC_ROLL_COMMUTE bll_commute = new Bll_TQC_ROLL_COMMUTE();
        Bll_TB_STD_CONFIG bll_std_config = new Bll_TB_STD_CONFIG();
        private Bll_TQB_STD_MAIN bllStdMain = new Bll_TQB_STD_MAIN();
        Bll_TPB_SLABWH bllTpbSlabWh = new Bll_TPB_SLABWH();
        Bll_TB_STA bll_sta = new Bll_TB_STA();
        Bll_TQB_PACK bllPack = new Bll_TQB_PACK();
        Bll_TQC_COMPRE_ITEM_RESULT bllItemResult = new Bll_TQC_COMPRE_ITEM_RESULT();
        private string strMenuName;
        string strPhyCode;
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC005_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            strPhyCode = RV.UI.QueryString.parameter;
            dte_Begin1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            dte_Begin.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            //DataSet dt_sta = bll_sta.GetAllList();
            //imgcbo_ZRDW.Properties.Items.Clear();
            //foreach (DataRow item in dt_sta.Tables[0].Rows)//责任单位下拉框
            //{
            //    imgcbo_ZRDW.Properties.Items.Add(item["C_STA_DESC"].ToString(), item["C_STA_CODE"], -1);
            //}
            DataSet dt = bll_checkstate.GetList("");
            DataSet dt_Pack = bllPack.GetList("");
            imgcbo_PDDJ.Properties.Items.Clear();
            foreach (DataRow item in dt.Tables[0].Rows)//判定等级下拉框
            {
                imgcbo_PDDJ.Properties.Items.Add(item["C_CHECKSTATE_NAME"].ToString(), item["C_CHECKSTATE_NAME"], -1);
            }
            imgcbo_PDDJ.SelectedIndex = 0;

            imgcbo_ZYX3.Properties.Items.Clear();
            foreach (DataRow item in dt_Pack.Tables[0].Rows)//判定等级下拉框
            {
                imgcbo_ZYX3.Properties.Items.Add(item["C_PACK_TYPE_CODE"].ToString(), item["C_PACK_TYPE_CODE"], -1);
            }
            BindStore();//
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                if (image_Store.Text=="")
                {
                    MessageBox.Show("请选择仓库！");
                }
                DataTable dt = bll_roll_product.GetList_WWGP(dte_Begin1.DateTime, dte_End1.DateTime, txt_BatchNo.Text, image_Store.EditValue.ToString()).Tables[0];

                gc_SJXX.DataSource = dt;
                gv_SJXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SJXX);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 线材改判记录查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_commute.GetList_Query(dte_Begin.DateTime, dte_End.DateTime, txt_BatchNo1.Text).Tables[0];
                gc_XCGP.DataSource = dt;
                gv_XCGP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_XCGP);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 物料编码-选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataRow dr = gv_SJXX.GetDataRow(gv_SJXX.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请先点击需要改判的信息！");
                    return;
                }
                FrmQC_SELECT_WL frm = new FrmQC_SELECT_WL(dr["C_MAT_CODE"].ToString(), "2", "");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btn_mat_code.Text = frm.mat_code;
                    txt_mat_name.Text = frm.mat_name;
                    txt_Grd.Text = frm.stl_grd;
                    txt_Std.Text = frm.std;
                    txt_ZYX1.Text = frm.strZYX1;
                    txt_ZYX2.Text = frm.strZYX2;
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 改判
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Decide_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要改判的信息！");
                    return;
                }

                DataRow row = gv_SJXX.GetDataRow(rownumber[0]);
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow dr = gv_SJXX.GetDataRow(rownumber[i]);
                    if (dr["C_BATCH_NO"].ToString() != row["C_BATCH_NO"].ToString()
                      || dr["C_STD_CODE"].ToString() != row["C_STD_CODE"].ToString()
                      || dr["C_STL_GRD"].ToString() != row["C_STL_GRD"].ToString()
                      || dr["C_MAT_CODE"].ToString() != row["C_MAT_CODE"].ToString()
                      || dr["C_MAT_DESC"].ToString() != row["C_MAT_DESC"].ToString()
                      || dr["C_BZYQ"].ToString() != row["C_BZYQ"].ToString()
                      || dr["C_JUDGE_LEV_ZH"].ToString() != row["C_JUDGE_LEV_ZH"].ToString()
                      || dr["C_LINEWH_CODE"].ToString() != row["C_LINEWH_CODE"].ToString()
                      || dr["C_SPEC"].ToString() != row["C_SPEC"].ToString())
                    {
                        MessageBox.Show("数据类型不同，请重新选择！");

                        return;
                    }
                    if (dr["C_JUDGE_LEV_ZH"].ToString() == "")
                    {
                        MessageBox.Show("改判失败，信息未综合判定！");
                        return;
                    }
                }

                if (string.IsNullOrEmpty(txt_Std.Text))
                {
                    MessageBox.Show("执行标准不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(btn_mat_code.Text))
                {
                    MessageBox.Show("物料编码不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(imgcbo_PDDJ.Text))
                {
                    MessageBox.Show("判定等级不能为空！");
                    return;
                }
                //if (imgcbo_ZRDW.EditValue == null)
                //{
                //    MessageBox.Show("责任单位不能为空！");
                //    return;
                //}

                if (DialogResult.OK != MessageBox.Show("是否确认改判已选中的数据？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }

                string strs = "";

                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];

                    strs = strs + gv_SJXX.GetRowCellValue(selectedHandle, "C_ID").ToString() + ",";
                }

                List<string> liststr = new List<string>();
                liststr.AddRange(strs.Substring(0, strs.Length - 1).Split(','));
                string strResult = bll_commute.Gp_Roll_WW(strs, txt_Grd.Text.Trim(), txt_Std.Text.Trim(), btn_mat_code.Text.Trim(), txt_mat_name.Text.Trim(), imgcbo_ZRDW.EditValue?.ToString(), imgcbo_ZRDW.Text, txt_Remark.Text.Trim(), Application.StartupPath, imgcbo_PDDJ.Text.Trim(), txt_ZYX1.Text, txt_ZYX2.Text, imgcbo_ZYX3.Text.Trim(), txt_GPYY.Text.Trim());

                if (strResult == "1")
                {
                    DataRow dr = gv_SJXX.GetDataRow(0);
                    string strID = "";
                    DataTable dt = bllItemResult.GetList(" C_BATCH_NO = '" + dr["C_BATCH_NO"].ToString() + "' ").Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        strID += dt.Rows[i]["C_ID"].ToString() + ",";
                    }
                    List<string> liststrid = new List<string>();
                    liststrid.AddRange(strID.Substring(0, strID.Length - 1).Split(','));
                   
                    bll_roll_product.UpdateBatchSameToNc(dr["C_LINEWH_CODE"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_STD_CODE"].ToString(), dr["C_SPEC"].ToString(), dr["C_BATCH_NO"].ToString(), dr["C_MAT_CODE"].ToString(), imgcbo_PDDJ.Text.Trim(), dr["C_BZYQ"].ToString(), liststr, liststrid);
                    ClearContent.ClearFlowLayoutPanel(panelControl3.Controls);
                    btn_Query_Main_Click(null, null);
                    btn_Query_Click(null, null);
                    MessageBox.Show("改判成功！");

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "线材改判");//添加操作日志
                }
                else
                {
                    MessageBox.Show(strResult);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 线材实绩信息回传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_SJXX_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；
                decimal wgt = 0;
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow dr = gv_SJXX.GetDataRow(rownumber[i]);
                    wgt += Convert.ToDecimal(dr["N_WGT"]);
                }
                txt_WGT.Text = wgt.ToString();

                if (rownumber.Length == 0)
                {
                    txt_Std.Text = "";
                    txt_Grd.Text = "";
                    btn_mat_code.Text = "";
                    txt_mat_name.Text = "";
                    imgcbo_BPLX.Text = "";
                    txt_ZYX1.Text = "";
                    txt_ZYX2.Text = "";
                    imgcbo_ZYX3.Text = "";
                    imgcbo_PDDJ.Text = "";
                }
                else
                {
                    DataRow row = gv_SJXX.GetDataRow(rownumber[0]);//获取已选中的数据中的第一条数据

                    txt_Std.Text = row["C_STD_CODE"].ToString();
                    txt_Grd.Text = row["C_STL_GRD"].ToString();
                    btn_mat_code.Text = row["C_MAT_CODE"].ToString();
                    txt_mat_name.Text = row["C_MAT_DESC"].ToString();
                    imgcbo_BPLX.Text = row["C_SCUTCHEON"].ToString();
                    txt_ZYX1.Text = row["C_ZYX1"].ToString();
                    txt_ZYX2.Text = row["C_ZYX2"].ToString();
                    imgcbo_ZYX3.EditValue = row["C_BZYQ"].ToString();
                    imgcbo_PDDJ.EditValue = row["C_JUDGE_LEV_ZH"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 修改标牌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_XGBP_Click_1(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0) return;

                DataRow dr = gv_SJXX.GetDataRow(rownumber[0]);
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow row = gv_SJXX.GetDataRow(rownumber[i]);

                    if (dr["C_BATCH_NO"].ToString() != row["C_BATCH_NO"].ToString()
                      || dr["C_STD_CODE"].ToString() != row["C_STD_CODE"].ToString()
                      || dr["C_STL_GRD"].ToString() != row["C_STL_GRD"].ToString()
                      || dr["C_MAT_CODE"].ToString() != row["C_MAT_CODE"].ToString()
                      || dr["C_MAT_DESC"].ToString() != row["C_MAT_DESC"].ToString())
                    {
                        MessageBox.Show("数据类型不同，请重新选择！");
                        return;
                    }
                }

                if (imgcbo_BPLX.EditValue == null)
                {
                    MessageBox.Show("标牌类型不能为空！");
                    return;
                }
                if (DialogResult.No == MessageBox.Show("是否确认修改已选中的数据？", "提示"))
                {
                    return;
                }

                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = gv_SJXX.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    DataTable dt = bll_roll_product.GetList_ID(strID).Tables[0];
                    Mod_TQC_ROLL_COMMUTE mod = new Mod_TQC_ROLL_COMMUTE();
                    mod.C_ROLL_ID = dt.Rows[0]["C_ID"].ToString();
                    mod.C_STA_ID = dt.Rows[0]["C_PLANT_ID"].ToString();
                    mod.C_STA_DESC = dt.Rows[0]["C_PLANT_DESC"].ToString();
                    mod.C_STOVE = dt.Rows[0]["C_STOVE"].ToString();
                    mod.C_BATCH_NO = dt.Rows[0]["C_BATCH_NO"].ToString();
                    mod.C_TICK_NO = dt.Rows[0]["C_TICK_NO"].ToString();
                    mod.N_WGT = Convert.ToDecimal(dt.Rows[0]["N_WGT"]);
                    mod.C_STL_GRD_BEFORE = dt.Rows[0]["C_STL_GRD"].ToString();
                    mod.C_STA_ID = dt.Rows[0]["C_STA_ID"].ToString();
                    mod.C_STD_CODE_BEFORE = dt.Rows[0]["C_STD_CODE"].ToString();
                    mod.C_SPEC_BEFORE = dt.Rows[0]["C_SPEC"].ToString();
                    mod.C_MAT_CODE_BEFORE = dt.Rows[0]["C_MAT_CODE"].ToString();
                    mod.C_MAT_DESC_BEFORE = dt.Rows[0]["C_MAT_DESC"].ToString();
                    mod.D_COMMUTE_DATE = RV.UI.ServerTime.timeNow();
                    mod.C_STL_GRD_AFTER = dt.Rows[0]["C_STL_GRD"].ToString();
                    mod.C_STD_CODE_AFTER = txt_Std.Text;
                    mod.C_BZYQ_BEFORE = dt.Rows[0]["C_BZYQ"].ToString();
                    mod.C_BZYQ_AFTER = imgcbo_ZYX3.Text.Trim();
                    mod.C_SCUTCHEON = imgcbo_BPLX.Text;
                    mod.C_GP_TYPE = "修改标牌";
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.C_REMARK = txt_Remark.Text;
                    if (bll_commute.Add(mod))
                    {
                        Mod_TRC_ROLL_PRODCUT mod_roll_prodcut = bll_roll_product.GetModel(dt.Rows[0]["C_ID"].ToString());
                        mod_roll_prodcut.C_SCUTCHEON = imgcbo_BPLX.Text;
                        mod_roll_prodcut.C_GP_TYPE = "修改标牌";

                        bll_roll_product.Update(mod_roll_prodcut);
                    }
                }
                ClearContent.ClearFlowLayoutPanel(panelControl3.Controls);
                btn_Query_Main_Click(null, null);
                btn_Query_Click(null, null);
                MessageBox.Show("修改成功！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "线材改判标牌");//添加操作日志
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 修改重量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UpdWGT_Click(object sender, EventArgs e)
        {
            int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length == 0)
            {
                MessageBox.Show("请选择需要改判的信息！");
                return;
            }

            DataRow row = gv_SJXX.GetDataRow(rownumber[0]);
            for (int i = 0; i < rownumber.Length; i++)
            {
                DataRow dr = gv_SJXX.GetDataRow(rownumber[i]);
                if (dr["C_BATCH_NO"].ToString() != row["C_BATCH_NO"].ToString()
                  || dr["C_STD_CODE"].ToString() != row["C_STD_CODE"].ToString()
                  || dr["C_STL_GRD"].ToString() != row["C_STL_GRD"].ToString()
                  || dr["C_MAT_CODE"].ToString() != row["C_MAT_CODE"].ToString()
                  || dr["C_MAT_DESC"].ToString() != row["C_MAT_DESC"].ToString()
                  || dr["C_JUDGE_LEV_ZH"].ToString() != row["C_JUDGE_LEV_ZH"].ToString())
                {
                    MessageBox.Show("数据类型不同，请重新选择！");

                    return;
                }
                if (dr["C_JUDGE_LEV_ZH"].ToString() == "")
                {
                    MessageBox.Show("改判失败，信息未综合判定！");
                    return;
                }
            }
            if (txt_WGT.Text.Trim() == "0")
            {
                MessageBox.Show("重量不能为0");
                return;
            }
            if (DialogResult.OK != MessageBox.Show("是否确认修改已选中数据的重量？", "提示", MessageBoxButtons.OKCancel))
            {
                return;
            }


            decimal wgt = Convert.ToDecimal(txt_WGT.Text.Trim());
            bll_roll_product.Update_WGT(row["C_BATCH_NO"].ToString(), row["C_STL_GRD"].ToString(), row["C_STD_CODE"].ToString(), row["C_JUDGE_LEV_ZH"].ToString(), row["C_MAT_CODE"].ToString(), row["C_BZYQ"].ToString(), row["C_LINEWH_CODE"].ToString(), wgt, rownumber.Length);

            DataTable dr_SJ = bll_roll_product.Getlist_Wgt(row["C_BATCH_NO"].ToString(), row["C_STL_GRD"].ToString(), row["C_STD_CODE"].ToString(), row["C_JUDGE_LEV_ZH"].ToString(), row["C_MAT_CODE"].ToString(), row["C_BZYQ"].ToString(), row["C_LINEWH_CODE"].ToString()).Tables[0];

            for (int i = 0; i < dr_SJ.Rows.Count; i++)
            {
                gv_SJXX.SetRowCellValue(i, gv_SJXX.Columns["N_WGT"], dr_SJ.Rows[i]["N_WGT"]);
                gv_SJXX.RefreshData();
            }
            MessageBox.Show("修改成功！");
        }

        /// <summary>
        /// 绑定仓库
        /// </summary>
        public void BindStore()
        {
            DataTable dt = bllTpbSlabWh.GetList_WW().Tables[0];
            image_Store.Properties.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                image_Store.Properties.Items.Add(item["C_LINEWH_CODE"].ToString() + item["C_LINEWH_NAME"].ToString(), item["C_LINEWH_CODE"], -1);
            }
            image_Store.SelectedIndex = 0;
        }


    }
}


