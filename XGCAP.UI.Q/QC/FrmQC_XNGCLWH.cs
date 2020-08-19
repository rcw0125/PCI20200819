using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using MODEL;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_XNGCLWH : Form
    {
        public FrmQC_XNGCLWH()
        {
            InitializeComponent();
        }
        private string strMenuName;
        private Bll_TQC_PRESENT_SAMPLES bllTqcPresentSamples = new Bll_TQC_PRESENT_SAMPLES();
        Bll_TQB_PHYSICS_GROUP bll_group = new Bll_TQB_PHYSICS_GROUP();
        Bll_TRC_ROLL_PRODCUT bll_trc_product = new Bll_TRC_ROLL_PRODCUT();
        Bll_TQC_PHYSICS_RESULT_MAIN bll_ResultMain = new Bll_TQC_PHYSICS_RESULT_MAIN();
        Bll_TQC_RESULT_MAIN_ZJB bllResultMainZJB = new Bll_TQC_RESULT_MAIN_ZJB();
        private void FrmQC_XNGCLWH_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;
            gv_right.OptionsSelection.MultiSelect = true;
            gv_right.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            DataSet ds = bll_group.GetList("");
            imgcbo_Name.Properties.Items.Clear();
            foreach (DataRow item in ds.Tables[0].Rows)//性能名称下拉框绑定
            {
                imgcbo_Name.Properties.Items.Add(item["C_NAME"].ToString(), item["C_ID"], -1);
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            NewMethod();
        }
        /// <summary>
        /// 查询
        /// </summary>
        private void NewMethod()
        {
            try
            {
                if (txt_BatchNo.Text.Trim() == "")
                {
                    MessageBox.Show("请输入批号！");
                    return;
                }
                WaitingFrom.ShowWait("");
                DataTable dt = bllTqcPresentSamples.GetList(txt_BatchNo.Text.Trim()).Tables[0];
                DataTable dt_product = bll_trc_product.GetList_Batch(txt_BatchNo.Text.Trim()).Tables[0];
                gc_ZYXX.DataSource = dt;
                gc_right.DataSource = dt_product;
                gv_ZYXX.BestFitColumns();
                gv_right.BestFitColumns();
                DataSet ds = bll_trc_product.GetList_Batch(txt_BatchNo.Text.Trim());

                SetGridViewRowNum.SetRowNum(gv_ZYXX);
                SetGridViewRowNum.SetRowNum(gv_right);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (imgcbo_Name.Text.Trim() == "")
            {
                MessageBox.Show("请选择性能名称！");
                return;
            }
            try
            {
                int[] rownumber = gv_right.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要添加的信息！");
                    return;
                }
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = gv_right.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TRC_ROLL_PRODCUT mod_pro = bll_trc_product.GetModel(strID);
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_BATCH_NO", mod_pro.C_BATCH_NO);
                    ht.Add("C_TICK_NO", mod_pro.C_TICK_NO);
                    ht.Add("C_PHYSICS_GROUP_ID", imgcbo_Name.EditValue.ToString());
                    ht.Add("N_STATUS", "1");
                    if (Common.CheckRepeat.CheckTable("TQC_PHYSICS_RESULT_MAIN", ht) > 0)
                    {
                        MessageBox.Show("该检验项目下已存在钩号"+ mod_pro.C_TICK_NO + ",不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    #endregion
                }
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    string strID = gv_right.GetRowCellValue(selectedHandle, "C_ID").ToString();
                    Mod_TRC_ROLL_PRODCUT mod_pro = bll_trc_product.GetModel(strID);
                    Mod_TQC_PHYSICS_RESULT_MAIN mod = new Mod_TQC_PHYSICS_RESULT_MAIN();
                    mod.C_BATCH_NO = mod_pro.C_BATCH_NO;
                    mod.C_STL_GRD = mod_pro.C_STL_GRD;
                    mod.C_TICK_NO = mod_pro.C_TICK_NO;
                    mod.C_SPEC = mod_pro.C_SPEC;
                    mod.C_PHYSICS_GROUP_ID = imgcbo_Name.EditValue.ToString();
                    mod.C_EMP_ID_ZY = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT_ZY = RV.UI.ServerTime.timeNow();
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    mod.C_CHECK_STATE = "0";


                    bll_ResultMain.Add(mod);
                }

                MessageBox.Show("添加成功！");
                NewMethod();
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加性能结果录入项目");//添加操作日志 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
