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

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_CNLR : Form
    {
        public FrmPB_CNLR()
        {
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TB_STA bllSta = new Bll_TB_STA();
        Bll_TPB_STA_CN bllStaCN = new Bll_TPB_STA_CN();
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPB_CNLR_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                dte_Time.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;//禁止编辑
                var formatString = "yyyy-MM";//格式化日期
                dte_Time.Properties.Mask.EditMask = formatString;
                dte_Time.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
                dte_Time.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
                dte_Time.Properties.ShowToday = false;
                dte_Time.Properties.Mask.UseMaskAsDisplayFormat = true;//允许格式化显示


                DataSet dt_sta = bllSta.Get_CN();
                imgcbo_CJ.Properties.Items.Clear();
                foreach (DataRow item in dt_sta.Tables[0].Rows)//车间下拉框
                {
                    imgcbo_CJ.Properties.Items.Add(item["C_PRO_DESC"].ToString(), item["C_PRO_ID"], -1);
                }
                imgcbo_CJ.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query();
        }
        private void Query()
        {
            try
            {
                gc_CN.DataSource = null;
                gv_CN.Columns.Clear();
                WaitingFrom.ShowWait("");

                DataTable dt_sta = bllSta.Get_CN_CODE(imgcbo_CJ.EditValue.ToString()).Tables[0];
                DataTable dt = bllStaCN.GetList_sta(dte_Time.Text, imgcbo_CJ.EditValue.ToString()).Tables[0];
                string str = "";
                if (rbtn_isty_wh.SelectedIndex == 0)
                {
                    str = "上旬";
                }
                if (rbtn_isty_wh.SelectedIndex == 1)
                {
                    str = "中旬";
                }
                if (rbtn_isty_wh.SelectedIndex == 2)
                {
                    str = "下旬";
                }
                DataTable dt_Item = bllStaCN.GetList_sta_Item(dte_Time.Text, imgcbo_CJ.EditValue.ToString(), str).Tables[0];
                DataTable new_DataTable = new DataTable();
                DataColumn new_d_col = new DataColumn();
                new_DataTable.Columns.Add("日期", typeof(string));

                for (int i = 0; i < dt_sta.Rows.Count; i++)
                {
                    new_d_col = new DataColumn();
                    new_d_col.ColumnName = dt_sta.Rows[i]["C_STA_DESC"].ToString();
                    new_d_col.Caption = dt_sta.Rows[i]["C_STA_DESC"].ToString();

                    new_DataTable.Columns.Add(new_d_col);
                }
                new_DataTable.Columns.Add("操作人员", typeof(string));
                new_DataTable.Columns.Add("操作时间", typeof(DateTime));

                DataRow new_dr;
                DataRow[] drs;
                foreach (DataRow dr in dt_Item.Rows)
                {
                    new_dr = new_DataTable.NewRow();
                    new_dr["日期"] = dr["日期"].ToString();
                    new_dr["操作人员"] = dr["操作人员"].ToString();
                    new_dr["操作时间"] = dr["操作时间"].ToString();

                    drs = dt.Select(" 日期 = '" + dr["日期"].ToString() + "'   ");
                    for (int i = 0; i < drs.Length; i++)
                    {
                        new_dr[drs[i]["车间"].ToString()] = drs[i]["产能"].ToString();
                    }
                    new_DataTable.Rows.Add(new_dr);
                }
                new_DataTable.DefaultView.Sort = "日期 ";
                new_DataTable = new_DataTable.DefaultView.ToTable();

                gc_CN.DataSource = new_DataTable;
                gv_CN.BestFitColumns();
                gv_CN.Columns["日期"].OptionsColumn.AllowEdit = false;
                gv_CN.Columns["操作人员"].OptionsColumn.AllowEdit = false;
                gv_CN.Columns["操作时间"].OptionsColumn.AllowEdit = false;
                SetGridViewRowNum.SetRowNum(gv_CN);
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
        private void btn_Add_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt_sta = bllSta.Get_CN_CODE(imgcbo_CJ.EditValue.ToString()).Tables[0];
                int days = DateTime.DaysInMonth(dte_Time.DateTime.Year, dte_Time.DateTime.Month);
                int s = 0;
                string str = "";
                if (rbtn_isty_wh.SelectedIndex == 0)
                {
                    s = 1;
                    days = 10;
                    str = "上旬";
                }
                if (rbtn_isty_wh.SelectedIndex == 1)
                {
                    s = 11;
                    days = 20;
                    str = "中旬";
                }
                if (rbtn_isty_wh.SelectedIndex == 2)
                {
                    s = 21;
                    str = "下旬";
                }
                for (int i = s; i <= days; i++)
                {
                    for (int y = 0; y < dt_sta.Rows.Count; y++)
                    {
                        Mod_TPB_STA_CN mod = new Mod_TPB_STA_CN();
                        string a = "";
                        if (i < 10)
                        {
                            a = "0" + i.ToString();
                        }
                        else
                        {
                            a = i.ToString();
                        }
                        mod.C_DATE = dte_Time.DateTime.ToString("yyyy-MM") + "-" + a;
                        mod.C_STA = dt_sta.Rows[y]["C_STA_DESC"].ToString();
                        mod.C_VALUE = "";
                        mod.C_MONTH = str;
                        mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                        mod.C_REMARK = dt_sta.Rows[y]["C_PRO_ID"].ToString();
                        bllStaCN.Add(mod);
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加工序产能");//添加操作日志
                    }
                }
                Query();
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
            try
            {
                string str = "";
                int days = DateTime.DaysInMonth(dte_Time.DateTime.Year, dte_Time.DateTime.Month);
                int s = 0;
                int o = 0;
                if (rbtn_isty_wh.SelectedIndex == 0)
                {
                    s = 1;
                    days = 10;
                    str = "上旬";
                }
                if (rbtn_isty_wh.SelectedIndex == 1)
                {
                    s = 11;
                    days = 20;
                    str = "中旬";
                }
                if (rbtn_isty_wh.SelectedIndex == 2)
                {
                    s = 21;
                    str = "下旬";
                }
                DataTable dt = ((DataView)gv_CN.DataSource).ToTable();
                DataTable dt_sta = bllSta.Get_CN_CODE(imgcbo_CJ.EditValue.ToString()).Tables[0];
                if (bllStaCN.Delete(dte_Time.Text, dt_sta.Rows[0]["C_PRO_ID"].ToString(), str))
                {

                    for (int i = s; i <= days; i++)
                    {
                        o++;
                        for (int y = 0; y < dt_sta.Rows.Count; y++)
                        {

                            Mod_TPB_STA_CN mod = new Mod_TPB_STA_CN();
                            string a = "";
                            if (i < 10)
                            {
                                a = "0" + i.ToString();
                            }
                            else
                            {
                                a = i.ToString();
                            }

                            mod.C_DATE = dte_Time.DateTime.ToString("yyyy-MM") + "-" + a;
                            mod.C_STA = dt_sta.Rows[y]["C_STA_DESC"].ToString();

                            mod.C_VALUE = gv_CN.GetRowCellValue(o - 1, mod.C_STA).ToString();
                            //mod.C_VALUE = dt.Rows[1][1].ToString();

                            mod.C_MONTH = str;
                            mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                            mod.C_REMARK = dt_sta.Rows[y]["C_PRO_ID"].ToString();
                            bllStaCN.Add(mod);
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改工序产能");//添加操作日志
                        }
                    }

                }
                Query();
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
            DialogResult dialogResult = MessageBox.Show("删除将会把当前显示的内容全部删除，是否确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    string str = "";

                    if (rbtn_isty_wh.SelectedIndex == 0)
                    {

                        str = "上旬";
                    }
                    if (rbtn_isty_wh.SelectedIndex == 1)
                    {

                        str = "中旬";
                    }
                    if (rbtn_isty_wh.SelectedIndex == 2)
                    {

                        str = "下旬";
                    }
                    DataTable dt_sta = bllSta.Get_CN_CODE(imgcbo_CJ.EditValue.ToString()).Tables[0];
                    if (bllStaCN.Delete(dte_Time.Text, dt_sta.Rows[0]["C_PRO_ID"].ToString(), str))
                    {
                        MessageBox.Show("已删除！");
                        Query();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else//如果点击“取消”按钮
            {
                return;
            }
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DC_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_CN);
        }
    }
}
