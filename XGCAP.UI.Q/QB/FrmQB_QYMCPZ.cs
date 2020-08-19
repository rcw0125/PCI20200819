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

namespace XGCAP.UI.Q.QB
{
    /// <summary>
    /// 2018-04-19 zmc
    /// </summary>
    public partial class FrmQB_QYMCPZ : Form
    {
        public FrmQB_QYMCPZ()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQB1101_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strMenuName = RV.UI.UserInfo.menuName;

                btn_Query_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        Bll_TQB_PHYSICS_GROUP bll_PHYSICS_GROUP = new Bll_TQB_PHYSICS_GROUP();
        Bll_TQB_SAMPLING_GROUP bll_SAMPLING_GROUP = new Bll_TQB_SAMPLING_GROUP();
        Bll_TQB_SAMPLING bll_sampling = new Bll_TQB_SAMPLING();

        private string strMenuName;

        /// <summary>
        /// 物理检验项目分组查询
        /// </summary>
        /// <param name="sender"></param> 
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                string str = txt_Name.Text.Trim();
                DataTable dt = bll_PHYSICS_GROUP.GetList(str).Tables[0];
                this.gc_wljyfz.DataSource = dt;
                gv_wljyfz.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_wljyfz);
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 物理检验项目配置查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_wljyfz_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod();
        }
        /// <summary>
        ///添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr_wljyfz = this.gv_wljyfz.GetDataRow(this.gv_wljyfz.FocusedRowHandle);
                DataRow dr_jcsj = this.gv_jcsj.GetDataRow(this.gv_jcsj.FocusedRowHandle);
                if (dr_wljyfz == null) return;
                if (dr_jcsj==null) return;
                Mod_TQB_SAMPLING_GROUP mod = new Mod_TQB_SAMPLING_GROUP(); 
                mod.C_PHYSICS_GROUP_ID = dr_wljyfz["C_ID"].ToString();
                mod.C_SAMPLING_ID = dr_jcsj["C_ID"].ToString();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                if (bll_SAMPLING_GROUP.Add(mod))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "匹配取样名称");//添加操作日志

                    MessageBox.Show("添加成功！");
                }


                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 基础数据条件查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_jcsjQuery_Click(object sender, EventArgs e)
        {
            NewMethod();

        }
        /// <summary>
        /// 基础数据条件查询
        /// </summary>
        private void NewMethod()
        {
            try
            {

                DataRow dr_wljyfz = this.gv_wljyfz.GetDataRow(this.gv_wljyfz.FocusedRowHandle);
                if (dr_wljyfz == null) return;
                DataTable dt = bll_SAMPLING_GROUP.GetList_Query(dr_wljyfz["C_ID"].ToString()).Tables[0];
                string row = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row += "'" + dt.Rows[i]["C_SAMPLING_CODE"].ToString() + "',";
                }
                DataTable dt_jcsj = new DataTable();
                if (row.Length > 0)
                {
                    row = row.Substring(0, row.Length - 1);
                    dt_jcsj = bll_sampling.GetList_CODE(row, txt_Name1.Text.Trim()).Tables[0];
                }
                else
                {
                    dt_jcsj = bll_sampling.GetList_CODE("", txt_Name1.Text.Trim()).Tables[0];
                }
                gc_QYMC.DataSource = dt;
                gc_jcsj.DataSource = dt_jcsj;
                gv_QYMC.BestFitColumns();
                gv_jcsj.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_QYMC);
                SetGridViewRowNum.SetRowNum(gv_jcsj);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dialogResult = MessageBox.Show("是否取消？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    int[] rownumber = gv_QYMC.GetSelectedRows();//获取选中行号数组；
                    if (rownumber.Length == 0) return;
                    for (int i = 0; i < rownumber.Length; i++)
                    {
                        DataRow row = gv_QYMC.GetDataRow(rownumber[i]);
                        Mod_TQB_SAMPLING_GROUP mod = bll_SAMPLING_GROUP.GetModel(row["C_ID"].ToString());
                        mod.N_STATUS = 0;
                        bll_SAMPLING_GROUP.Update(mod);
                    }

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消取样名称匹配关系");//添加操作日志

                    MessageBox.Show("已取消！");
                    gv_wljyfz_FocusedRowChanged(null, null);
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
    }
}
