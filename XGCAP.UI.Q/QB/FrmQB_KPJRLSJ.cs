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
    public partial class FrmQB_KPJRLSJ : Form
    {
        public FrmQB_KPJRLSJ()
        {
            InitializeComponent();
        }
        Bll_TQB_STD_MAIN bll_StdMain = new Bll_TQB_STD_MAIN();
        Bll_TB_REHEATING_FURNACE bllReheting = new Bll_TB_REHEATING_FURNACE();
        /// <summary>
        /// 查询钢种
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

                WaitingFrom.ShowWait("");

                DataTable dt = bll_StdMain.GetList_GroupStlGrd(txt_Grd.Text.Trim(), txt_STD_CODE.Text.Trim()).Tables[0];

                this.gc_StdMain.DataSource = dt;
                gv_StdMain.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_StdMain);
                WaitingFrom.CloseWait();
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
        private void btn_QueryMain_Click(object sender, EventArgs e)
        {
            NewMethod1();
        }

        private void NewMethod1()
        {
            try
            {

                WaitingFrom.ShowWait("");

                DataTable dt = bllReheting.Getlist_Query(txt_GZ.Text.Trim()).Tables[0];

                this.gc_Time.DataSource = dt;
                gv_Time.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Time);
                WaitingFrom.CloseWait();
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

                int[] rownumber = gv_StdMain.GetSelectedRows();//获取选中行号数组；

                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要保存的信息！");
                    return;
                }
                if (imgcbo_Time.EditValue == null)
                {
                    MessageBox.Show("加热时间不能为空！", "提示");
                    return;
                }
                if (DialogResult.OK != MessageBox.Show("是否确认保存已选中的数据？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }
                for (int i = 0; i < rownumber.Length; i++)
                {
                    DataRow dr = gv_StdMain.GetDataRow(rownumber[i]);

                    Mod_TB_REHEATING_FURNACE mod = new Mod_TB_REHEATING_FURNACE();
                    if (rbtn_isty_wh.SelectedIndex == 0)
                    {
                        mod.C_ZL_TYPE = "热装";
                    }
                    if (rbtn_isty_wh.SelectedIndex == 1)
                    {
                        mod.C_ZL_TYPE = "冷装";
                    }
                    mod.C_STL_GRD = dr["C_STL_GRD"].ToString();
                    mod.C_STD_CODE = dr["C_STD_CODE"].ToString();
                    mod.N_HOUR = Convert.ToDecimal(imgcbo_Time.EditValue);
                    mod.C_BY1 = txt_remark.Text.Trim();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    #region 检测是否重复添加    
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_STL_GRD", mod.C_STL_GRD);
                    ht.Add("C_STD_CODE", mod.C_STD_CODE);
                    ht.Add("N_HOUR", mod.N_HOUR);
                    ht.Add("C_ZL_TYPE", mod.C_ZL_TYPE);
                    if (Common.CheckRepeat.CheckTable("TB_REHEATING_FURNACE", ht) > 0)
                    {
                        MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    #endregion
                    bllReheting.Add(mod);
                }
                MessageBox.Show("保存成功！", "提示");
                NewMethod();
                NewMethod1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    DataRow dr_StdMain = gv_Time.GetDataRow(gv_Time.FocusedRowHandle);
                    int[] rownumber = gv_Time.GetSelectedRows();//获取选中行号数组；
                    if (rownumber.Length == 0)
                    {
                        MessageBox.Show("请选择需要添加的信息！");
                        return;
                    }

                    for (int si = 0; si < rownumber.Length; si++)
                    {
                        DataRow dr = gv_Time.GetDataRow(rownumber[si]);
                        bllReheting.Delete(dr["C_ID"].ToString());
                    }
                    MessageBox.Show("已删除！");
                    NewMethod1();

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
        private void btn_DCKDZGZ_Click(object sender, EventArgs e)
        {
            Common.OutToExcel.ToExcel(this.gc_Time);
        }

        private void FrmQB_KPJRLSJ_Load(object sender, EventArgs e)
        {

        }
    }
}
