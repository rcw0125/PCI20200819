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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_XNJGQR : Form
    {
        public FrmQC_XNJGQR()
        {
            InitializeComponent();
        }
        private string strMenuName;
        private string strPhyCode;
        Bll_TQC_RESULT_MAIN_ZJB bllResultMainZJB = new Bll_TQC_RESULT_MAIN_ZJB();
        Bll_TQC_PHYSICS_RESULT_MAIN bllResultMain = new Bll_TQC_PHYSICS_RESULT_MAIN();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC_XNJGQR_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            strPhyCode = RV.UI.QueryString.parameter;
            dte_Begin1.EditValue = DateTime.Now.AddDays(-5).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Sam_Click(object sender, EventArgs e)
        {
            Query_SQ();
        }

        /// <summary>
        /// 复检申请查询
        /// </summary>
        private void Query_SQ()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = new DataTable();
                if (rbtn_isty_wh.SelectedIndex == 1)
                {
                    dt = bllResultMainZJB.GetList(Convert.ToDateTime(dte_Begin1.DateTime), Convert.ToDateTime(dte_End1.DateTime), txt_BatchNo_Sam.Text.Trim(), strPhyCode, "0").Tables[0];
                }
                if (rbtn_isty_wh.SelectedIndex == 0)
                {
                    dt = bllResultMainZJB.GetList(Convert.ToDateTime(dte_Begin1.DateTime), Convert.ToDateTime(dte_End1.DateTime), txt_BatchNo_Sam.Text.Trim(), strPhyCode, "1").Tables[0];
                }



                this.gc_SQLB.DataSource = dt;
                gv_SQLB.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SQLB);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QR_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_SQLB.GetSelectedRows();//获取选中行号数组； 
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要确认的信息！");
                    return;
                }
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow dr = gv_SQLB.GetDataRow(rownumber[i]);
                    Mod_TQC_RESULT_MAIN_ZJB mod_ZJB = bllResultMainZJB.GetModel(dr["C_ID"].ToString());
                    if (mod_ZJB.N_STATUS==0)
                    {
                        MessageBox.Show("已确认，请勿重复操作！");
                        return;
                    }

                }
                if (DialogResult.OK != MessageBox.Show("是否确认已选中的数据？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow dr = gv_SQLB.GetDataRow(rownumber[i]);
                    Mod_TQC_RESULT_MAIN_ZJB mod_ZJB = bllResultMainZJB.GetModel(dr["C_ID"].ToString());
                    mod_ZJB.N_STATUS = 0;
                    bllResultMainZJB.Update(mod_ZJB);
                    Mod_TQC_PHYSICS_RESULT_MAIN modPhysicsResultMain = new Mod_TQC_PHYSICS_RESULT_MAIN();
                    modPhysicsResultMain.C_BATCH_NO = mod_ZJB.C_BATCH_NO;
                    modPhysicsResultMain.C_TICK_NO = mod_ZJB.C_TICK_NO;
                    modPhysicsResultMain.C_STL_GRD = mod_ZJB.C_STL_GRD;
                    modPhysicsResultMain.C_SPEC = mod_ZJB.C_SPEC;
                    modPhysicsResultMain.C_EMP_ID = mod_ZJB.C_EMP_ID;
                    modPhysicsResultMain.D_MOD_DT = mod_ZJB.D_MOD_DT;
                    modPhysicsResultMain.C_EMP_ID_ZY = RV.UI.UserInfo.UserID;
                    modPhysicsResultMain.D_MOD_DT_ZY = RV.UI.ServerTime.timeNow();
                    modPhysicsResultMain.C_EMP_ID_JS = mod_ZJB.C_EMP_ID_JS;
                    modPhysicsResultMain.D_MOD_DT_JS = mod_ZJB.D_MOD_DT_JS;
                    modPhysicsResultMain.C_PHYSICS_GROUP_ID = mod_ZJB.C_PHYSICS_GROUP_ID;
                    modPhysicsResultMain.C_CHECK_STATE = mod_ZJB.C_CHECK_STATE;
                    modPhysicsResultMain.N_RECHECK = mod_ZJB.N_RECHECK;
                    bllResultMain.Add(modPhysicsResultMain);
                }
                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加物理性能结果信息");//添加操作日志

                MessageBox.Show("确认成功！");
                Query_SQ();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
