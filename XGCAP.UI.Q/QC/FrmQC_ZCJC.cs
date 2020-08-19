using Common;
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
namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_ZCJC : Form
    {
        private string strMenuName;

        public FrmQC_ZCJC()
        {
            InitializeComponent();
        }
        Bll_TQB_TRUCK bll = new Bll_TQB_TRUCK();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC010_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
                dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void NewMethod()
        {
            try
            {
                DataTable dt = bll.GetList_Query(dte_Begin.DateTime, dte_End.DateTime, txt_CH1.Text).Tables[0];
                gc_ZCJC.DataSource = dt;
                gv_ZCJC.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_ZCJC);
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
            try
            {

                if (string.IsNullOrEmpty(txt_CH.Text.Trim()))
                {
                    MessageBox.Show("车号不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(txt_FYPC.Text.Trim()))
                {
                    MessageBox.Show("发运批次不能为空！");
                    return;
                }

                if (string.IsNullOrEmpty(txt_GZ.Text.Trim()))
                {
                    MessageBox.Show("钢种不能为空！");
                    return;
                }
                Mod_TQB_TRUCK mod_add = new Mod_TQB_TRUCK();
                mod_add.D_TRUCK_DT = RV.UI.ServerTime.timeNow();
                mod_add.C_TRUCK_NUM = txt_CH.Text.Trim();
                mod_add.C_SHIPMENT_BATCH = txt_FYPC.Text.Trim();
                mod_add.C_STL_GRD = txt_GZ.Text.Trim();
                mod_add.C_LOADING_QUANTITY = txt_ZCJS.Text.Trim();
                mod_add.C_CRE_ABRADE = txt_ZCQCS.Text.Trim();
                mod_add.C_CRE_ABRADE_TICK = txt_ZCQGH.Text.Trim();
                mod_add.C_BACK_ABRADE = txt_ZCHCS.Text.Trim();
                mod_add.C_BACK_ABRADE_TICK = txt_ZCHGH.Text.Trim();
                mod_add.C_SUPERINTENDENT = RV.UI.UserInfo.UserID;
                mod_add.C_REMARK = txt_Remark.Text.Trim();
                mod_add.C_EMP_ID = RV.UI.UserInfo.UserID;
                mod_add.D_MOD_DT = RV.UI.ServerTime.timeNow();
                bll.Add(mod_add);
                btn_Query_Click(null, null);
                btn_Rest_Click(null, null);
                MessageBox.Show("保存成功！");

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "保存装车检查信息");//添加操作日志


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl1.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rownumber = gv_ZCJC.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0) return;
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        int selectedHandle = rownumber[i];
                        string strID = gv_ZCJC.GetRowCellValue(selectedHandle, "C_ID").ToString();
                        Bll_Common bll_common = new Bll_Common();
                        if (bll_common.DataDisabled("TQB_TRUCK", strID, RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用装车检查信息");//添加操作日志
                        }

                    } 
                    MessageBox.Show("已停用！");
                    btn_Query_Click(null, null);
                }
                else//如果点击“取消”按钮
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow dr = this.gv_ZCJC.GetDataRow(this.gv_ZCJC.FocusedRowHandle);
            if (dr == null) return;
            try
            {
                FrmQC_ZCJC_EDIT frm = new FrmQC_ZCJC_EDIT();
                frm.c_id = dr["C_ID"].ToString();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                }
                NewMethod();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}





