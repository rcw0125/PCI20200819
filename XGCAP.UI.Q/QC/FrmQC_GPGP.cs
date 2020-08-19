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
using XGCAP.UI.Q.QB;
using Common;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_GPGP : Form
    {
        public FrmQC_GPGP()
        {
            InitializeComponent();
        }
        Bll_TQB_CHECKSTATE bll_checkstate = new Bll_TQB_CHECKSTATE();
        private Bll_TQB_GP_LCP_BASIS bllTqbGpLcpBasis = new Bll_TQB_GP_LCP_BASIS();
        Bll_TSC_SLAB_MAIN bll_slab = new Bll_TSC_SLAB_MAIN();
        Bll_TQC_SLAB_COMMUTE bll_commute = new Bll_TQC_SLAB_COMMUTE();
        Bll_TB_STA bll_sta = new Bll_TB_STA();
        Bll_TB_MATRL_MAIN bll_matrl = new Bll_TB_MATRL_MAIN();
        private string strMenuName;
        string strLen = "";
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC006_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            btn_mat_code.ReadOnly = true;
            txt_mat_name.ReadOnly = true;
            txt_Grd.ReadOnly = true;
            txt_Std.ReadOnly = true;
            txt_ZYX1.ReadOnly = true;
            txt_ZYX2.ReadOnly = true;

            dte_Begin1.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            DataSet dt_sta = bll_sta.GetAllList();
            imgcbo_ZRDW.Properties.Items.Clear();
            foreach (DataRow item in dt_sta.Tables[0].Rows)//责任单位下拉框
            {
                imgcbo_ZRDW.Properties.Items.Add(item["C_STA_DESC"].ToString(), item["C_STA_CODE"], -1);
            }
            DataSet dt = bll_checkstate.GetList_GP("");
            imgcbo_PDDJ.Properties.Items.Clear();
            foreach (DataRow item in dt.Tables[0].Rows)//判定等级下拉框
            {
                imgcbo_PDDJ.Properties.Items.Add(item["C_CHECKSTATE_NAME"].ToString(), item["C_CHECKSTATE_NAME"], -1);
            }
            imgcbo_PDDJ.SelectedIndex = 0;

        }
        /// <summary>
        /// 钢坯实绩查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_slab.GetList_Stove1(dte_Begin1.DateTime, dte_End1.DateTime, txt_Stove.Text.Trim()).Tables[0];
                gc_GPSJ.DataSource = dt;
                gv_GPSJ.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPSJ);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// 跳转到物料编码查询页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mat_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataRow dr = gv_GPSJ.GetDataRow(gv_GPSJ.FocusedRowHandle);
                if (dr==null)
                {
                    MessageBox.Show("请先点击需要改判的信息！");
                    return;
                }
                FrmQC_SELECT_WL frm = new FrmQC_SELECT_WL(dr["C_MAT_CODE"].ToString(),"1",dr["N_LEN"].ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                { 
                    btn_mat_code.Text = frm.mat_code;
                    txt_mat_name.Text = frm.mat_name;
                    txt_Std.Text = frm.std;
                    txt_Grd.Text = frm.stl_grd;
                    txt_ZYX1.Text = frm.strZYX1;
                    txt_ZYX2.Text = frm.strZYX2;
                    strLen = frm.lennew;
                    frm.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         
        /// <summary>
        /// 钢坯改判记录查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll_commute.GetList_Query(dte_Begin.DateTime, dte_End.DateTime, txt_Stove1.Text.Trim()).Tables[0];
                gc_GPGP.DataSource = dt;
                gv_GPGP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPGP);
                WaitingFrom.CloseWait();
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
                int[] rownumber = gv_GPSJ.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要改判的信息！");
                    return;
                }
                if (txt_GPYY.Text.Trim() == "")
                {
                    MessageBox.Show("请输入改判原因");
                    return;
                }
                DataRow row = gv_GPSJ.GetDataRow(rownumber[0]);
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow dr = gv_GPSJ.GetDataRow(rownumber[i]);
                    if (dr["C_STOVE"].ToString() != row["C_STOVE"].ToString()
                      || dr["C_STD_CODE"].ToString() != row["C_STD_CODE"].ToString()
                      || dr["C_STL_GRD"].ToString() != row["C_STL_GRD"].ToString()
                      || dr["C_MAT_CODE"].ToString() != row["C_MAT_CODE"].ToString()
                      || dr["C_MAT_NAME"].ToString() != row["C_MAT_NAME"].ToString() 
                      || dr["C_SLABWH_CODE"].ToString() != row["C_SLABWH_CODE"].ToString())
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

                if (DialogResult.OK != MessageBox.Show("是否确认改判选中的数据？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }
                string strs = "";
                for (int i = 0; i < rownumber.Length; i++)
                {
                    int selectedHandle = rownumber[i];
                    strs = strs + gv_GPSJ.GetRowCellValue(selectedHandle, "C_ID").ToString() + ",";
                } 


                string strResult = bll_slab.GP_Slab(strs, txt_Grd.Text.Trim(), txt_Std.Text.Trim(), btn_mat_code.Text.Trim(), txt_mat_name.Text.Trim(), imgcbo_ZRDW.EditValue?.ToString(), imgcbo_ZRDW.Text, imgcbo_PDDJ.Text.Trim(), txt_Remark.Text.Trim(), Application.StartupPath, txt_ZYX1.Text.Trim(), txt_ZYX2.Text.Trim(),txt_GPYY.Text.Trim(), strLen);
                if (strResult == "1")
                {
                    btn_Query_Click(null, null);
                    btn_Query1_Click(null, null);
                    ClearContent.ClearFlowLayoutPanel(panelControl4.Controls);
                    MessageBox.Show("改判成功！");
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "钢坯改判");//添加操作日志
                }
                else
                {
                    MessageBox.Show(strResult);
                }

                string url = Application.StartupPath;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
         
        /// <summary>
        /// 钢坯实绩信息回传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_GPSJ_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_GPSJ.GetDataRow(gv_GPSJ.FocusedRowHandle);
                if (dr == null)
                {
                    txt_Std.Text = "";
                    txt_Grd.Text = "";
                    btn_mat_code.Text = "";
                    txt_mat_name.Text = "";
                    txt_ZYX1.Text = "";
                    txt_ZYX2.Text = "";
                    imgcbo_PDDJ.Text = "";
                    strLen = "";
                }
                else
                {
                    btn_mat_code.Text = dr["C_MAT_CODE"].ToString();
                    txt_mat_name.Text = dr["C_MAT_NAME"].ToString();
                    txt_Std.Text = dr["C_STD_CODE"].ToString();
                    txt_Grd.Text = dr["C_STL_GRD"].ToString();
                    txt_ZYX1.Text = dr["C_ZYX1"].ToString();
                    txt_ZYX2.Text = dr["C_ZYX2"].ToString();
                    imgcbo_PDDJ.EditValue = dr["C_JUDGE_LEV_ZH"].ToString();
                    strLen = dr["N_LEN"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
