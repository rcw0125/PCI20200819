using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using Common;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_XCKCRK : Form
    {
        public FrmPO_XCKCRK()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_roll_product = new Bll_TRC_ROLL_PRODCUT();
        Bll_TPB_LINEWH bll_linewh = new Bll_TPB_LINEWH();//仓库
        Bll_TPB_LINEWH_AREA bll_area = new Bll_TPB_LINEWH_AREA();//区域
        Bll_TPB_LINEWH_LOC bll_loc = new Bll_TPB_LINEWH_LOC();//库位
        Bll_TPB_LINEWH_TIER bll_tier = new Bll_TPB_LINEWH_TIER();//层
        Bll_TMB_AREAMAX bll_areamax = new Bll_TMB_AREAMAX();//销售区域
        Bll_TRC_ROLL_STORAGE_LOG bll_storage = new Bll_TRC_ROLL_STORAGE_LOG();//线材库存记录

        private string strMenuName;

        /// <summary>
        /// 查询线材未入库的实绩信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bll_roll_product.GetList_WRK(txt_BatchNo.Text).Tables[0];
                gc_SJXX.DataSource = dt;
                gv_SJXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SJXX);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPO_XCKCRK_Load(object sender, EventArgs e)
        {
            try
            {
                strMenuName = RV.UI.UserInfo.menuName;
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                DataSet dt = bll_linewh.GetList("");
                imgcbo_CK.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)//仓库下拉框绑定
                {
                    imgcbo_CK.Properties.Items.Add(item["C_LINEWH_CODE"].ToString(), item["C_ID"], -1);
                }

                DataSet dt_KW = bll_loc.GetList_Query("");
                imgcbo_KW1.Properties.Items.Clear();
                foreach (DataRow item in dt_KW.Tables[0].Rows)//库位下拉框绑定
                {
                    imgcbo_KW1.Properties.Items.Add(item["C_LINEWH_LOC_CODE"].ToString(), item["C_ID"], -1);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 区域下拉框绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_CK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dt = bll_area.GetList_Query(imgcbo_CK.EditValue.ToString());
                imgcbo_QY.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)//区域下拉框绑定
                {
                    imgcbo_QY.Properties.Items.Add(item["C_LINEWH_AREA_CODE"].ToString(), item["C_ID"], -1);
                }
                imgcbo_QY.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 库位下拉框绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_QY_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dt = bll_loc.GetList_Query(imgcbo_QY.EditValue.ToString());
                imgcbo_KW.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)//库位下拉框绑定
                {
                    imgcbo_KW.Properties.Items.Add(item["C_LINEWH_LOC_CODE"].ToString(), item["C_ID"], -1);
                }
                imgcbo_KW.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
        /// <summary>
        /// 层 下拉框绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_KW_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dt = bll_tier.GetList_Query(imgcbo_KW.EditValue.ToString());
                imgcbo_CENG.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)//层下拉框绑定
                {
                    imgcbo_CENG.Properties.Items.Add(item["C_LINEWH_TIER_CODE"].ToString(), item["C_ID"], -1);
                }
                imgcbo_CENG.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        /// <summary>
        /// 转库实绩查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bll_roll_product.GetList_ZK(txt_BatchNo2.Text).Tables[0];
                gc_ZKSJ.DataSource = dt;
                gv_ZKSJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZKSJ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

            
        }
        /// <summary>
        /// 线材库存记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = bll_storage.GetList_RK(txt_BatchNo1.Text).Tables[0];
                gc_KCJL.DataSource = dt;
                gv_KCJL.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_KCJL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
      
        }
        /// <summary>
        /// 线材常规入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RK_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认入库？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0) return;
                DataRow row = gv_SJXX.GetDataRow(rownumber[0]);
                if (imgcbo_CK.EditValue == null)
                {
                    MessageBox.Show("仓库不能为空！");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("是否确认入库已选中的数据？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        string strID = gv_SJXX.GetRowCellValue(selectedHandle, "C_ID").ToString();
                        DataTable dt = bll_roll_product.GetList_ID(strID).Tables[0];
                        Mod_TRC_ROLL_STORAGE_LOG mod = new Mod_TRC_ROLL_STORAGE_LOG();
                        mod.C_TRC_ROLL_MAIN_ID = dt.Rows[0]["C_ID"].ToString();
                        mod.C_STOVE = dt.Rows[0]["C_STOVE"].ToString();
                        mod.C_BATCH_NO = dt.Rows[0]["C_BATCH_NO"].ToString();
                        mod.C_TICK_NO = dt.Rows[0]["C_TICK_NO"].ToString();
                        mod.C_STL_GRD = dt.Rows[0]["C_STL_GRD"].ToString();
                        mod.N_WGT = Convert.ToDecimal(dt.Rows[0]["N_WGT"]);
                        mod.C_STD_CODE = dt.Rows[0]["C_STD_CODE"].ToString();
                        mod.C_MOVE_TYPE = "E";
                        mod.C_SPEC = dt.Rows[0]["C_SPEC"].ToString();
                        mod.C_SHIFT = dt.Rows[0]["C_SHIFT"].ToString();
                        mod.C_GROUP = dt.Rows[0]["C_GROUP"].ToString();
                        mod.C_MAT_CODE = dt.Rows[0]["C_MAT_CODE"].ToString();
                        mod.C_MAT_DESC = dt.Rows[0]["C_MAT_DESC"].ToString();
                        mod.C_LINEWH_CODE_BEFORE = imgcbo_CK.Text.ToString();
                        mod.C_LINEWH_AREA_CODE_BEFORE = imgcbo_QY.Text.ToString();
                        mod.C_LINEWH_LOC_CODE_BEFORE = imgcbo_KW.Text.ToString();
                        mod.C_FLOOR_BEFORE = imgcbo_CENG.Text.ToString();
                        mod.D_STORAGE_DT = RV.UI.ServerTime.timeNow();
                        mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                        mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        if (bll_storage.Add(mod))
                        {
                            Mod_TRC_ROLL_PRODCUT mod_roll_prodcut = bll_roll_product.GetModel(dt.Rows[0]["C_ID"].ToString());
                            mod_roll_prodcut.C_LINEWH_CODE = imgcbo_CK.Text.ToString();
                            mod_roll_prodcut.C_LINEWH_AREA_CODE = imgcbo_QY.Text.ToString();
                            mod_roll_prodcut.C_LINEWH_LOC_CODE = imgcbo_KW.Text.ToString();
                            mod_roll_prodcut.C_FLOOR = imgcbo_CENG.Text.ToString();
                            mod_roll_prodcut.C_MOVE_TYPE = "E";
                            mod_roll_prodcut.C_EMP_ID = RV.UI.UserInfo.UserID;
                            mod_roll_prodcut.D_MOD_DT = RV.UI.ServerTime.timeNow();
                            bll_roll_product.Update(mod_roll_prodcut);

                        }
                    }

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "线材常规入库");//添加操作日志

                    MessageBox.Show("入库成功！");
                    btn_Query_Main_Click(null, null);
                    btn_Query_Click(null, null);
                    ClearContent.ClearFlowLayoutPanel(panelControl2.Controls);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
               
           
        }
        /// <summary>
        /// 转库入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RK1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认入库？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                int[] rownumber = gv_ZKSJ.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0) return;
                DataRow row = gv_ZKSJ.GetDataRow(rownumber[0]);

                if (DialogResult.No == MessageBox.Show("是否确认入库已选中的数据？", "提示"))
                {
                    return;
                }
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = gv_ZKSJ.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    DataTable dt = bll_roll_product.GetList_ID(strID).Tables[0];
                    Mod_TRC_ROLL_STORAGE_LOG mod = new Mod_TRC_ROLL_STORAGE_LOG();

                    mod.C_TRC_ROLL_MAIN_ID = dt.Rows[0]["C_ID"].ToString();
                    mod.C_STOVE = dt.Rows[0]["C_STOVE"].ToString();
                    mod.C_BATCH_NO = dt.Rows[0]["C_BATCH_NO"].ToString();
                    mod.C_TICK_NO = dt.Rows[0]["C_TICK_NO"].ToString();
                    mod.C_STL_GRD = dt.Rows[0]["C_STL_GRD"].ToString();
                    mod.N_WGT = Convert.ToDecimal(dt.Rows[0]["N_WGT"]);
                    mod.C_STD_CODE = dt.Rows[0]["C_STD_CODE"].ToString();
                    mod.C_MOVE_TYPE = "E";
                    mod.C_SPEC = dt.Rows[0]["C_SPEC"].ToString();
                    mod.C_SHIFT = dt.Rows[0]["C_SHIFT"].ToString();
                    mod.C_GROUP = dt.Rows[0]["C_GROUP"].ToString();
                    mod.C_MAT_CODE = dt.Rows[0]["C_MAT_CODE"].ToString();
                    mod.C_MAT_DESC = dt.Rows[0]["C_MAT_DESC"].ToString();
                    mod.C_LINEWH_CODE_BEFORE = dt.Rows[0]["C_LINEWH_CODE"].ToString();
                    mod.C_LINEWH_AREA_CODE_BEFORE = dt.Rows[0]["C_LINEWH_AREA_CODE"].ToString();
                    mod.C_LINEWH_LOC_CODE_BEFORE = dt.Rows[0]["C_LINEWH_LOC_CODE"].ToString();
                    mod.C_FLOOR_BEFORE = dt.Rows[0]["C_FLOOR"].ToString();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    if (bll_storage.Add(mod))
                    {
                        Mod_TRC_ROLL_PRODCUT mod_roll_prodcut = bll_roll_product.GetModel(dt.Rows[0]["C_ID"].ToString());
                        mod_roll_prodcut.C_MOVE_TYPE = "E";
                        mod_roll_prodcut.C_LINEWH_LOC_CODE = imgcbo_KW1.Text;
                        mod_roll_prodcut.C_FLOOR = imgcbo_CENG1.Text;
                        mod_roll_prodcut.C_EMP_ID = RV.UI.UserInfo.UserID;
                        mod_roll_prodcut.D_MOD_DT = RV.UI.ServerTime.timeNow();
                        bll_roll_product.Update(mod_roll_prodcut);
                        MessageBox.Show("入库成功！");
                        btn_Query1_Click(null, null);
                        btn_Query_Click(null, null);

                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "线材转库入库");//添加操作日志
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }
        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_repeal_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.No == MessageBox.Show("是否确认撤销？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "撤销线材入库");//添加操作日志
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
        /// <summary>
        /// 层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_KW1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dt = bll_tier.GetList_Query(imgcbo_KW1.EditValue.ToString());
                imgcbo_CENG1.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)//层下拉框绑定
                {
                    imgcbo_CENG1.Properties.Items.Add(item["C_LINEWH_TIER_CODE"].ToString(), item["C_ID"], -1);
                }
                imgcbo_CENG1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}
