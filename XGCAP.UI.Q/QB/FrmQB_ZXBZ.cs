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
    /// 2018-04-24 zmc
    /// </summary>
    public partial class FrmQB_ZXBZ : Form
    {
        public FrmQB_ZXBZ()
        {
            InitializeComponent();
        }
        Bll_TQB_STD_MAIN bll_StdMain = new Bll_TQB_STD_MAIN();
        Bll_TQB_STD_TYPE bll_StdType = new Bll_TQB_STD_TYPE();
        Bll_TQB_STD_CFXN bll_StdCFXN = new Bll_TQB_STD_CFXN();
        private Bll_TQB_DESIGN bllTqbDesign = new Bll_TQB_DESIGN();
        private Bll_TRC_ROLL_PRODCUT bllTrcRollProduct = new Bll_TRC_ROLL_PRODCUT();

        private string strMenuName;
        string strPhyCode;
        private void FrmQB0701_Load(object sender, EventArgs e)
        {
            try
            {
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

                strPhyCode = RV.UI.QueryString.parameter;
                strMenuName = RV.UI.UserInfo.menuName;
                DataTable dt = bll_StdType.GetList("").Tables[0];
                imgcbo_StdType.Properties.Items.Clear();
                imgcbo_StdType.Properties.Items.Add("全部", "全部", -1);
                if (dt.Rows.Count > 0)
                    foreach (DataRow item in dt.Rows)
                    {
                        imgcbo_StdType.Properties.Items.Add(item["C_TYPE_NAME"].ToString(), item["C_ID"], -1);
                    }
                imgcbo_StdType.SelectedIndex = 0;
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
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt;
                string C_STD_TYPE = imgcbo_StdType.EditValue?.ToString();
                string C_STD_CODE = txt_Std.Text.Trim();
                string C_STL_GRD = txt_GRD.Text.Trim();

                if (this.rbtn_isty_wh.SelectedIndex == 0)
                {
                    dt = bll_StdMain.GetList(strPhyCode, 1, C_STD_TYPE, C_STD_CODE, C_STL_GRD).Tables[0];
                }
                else
                {
                    dt = bll_StdMain.GetList(strPhyCode, 0, C_STD_TYPE, C_STD_CODE, C_STL_GRD).Tables[0];
                }

                this.gc_StdMain.DataSource = dt;
                gv_StdMain.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_StdMain);
                WaitingFrom.CloseWait();
                if (dt.Rows.Count > 0)
                {
                    string str = dt.Rows[0]["C_ID"].ToString();
                    if (!string.IsNullOrEmpty(str))
                    {
                        NewMethod(str);
                        NewMethod1(str);
                        NewMethod2(str);
                        NewMethod3(str);
                    }
                    else
                    {
                        gc_Spec.DataSource = null;
                        gc_StdCX.DataSource = null;
                        gc_StdXN.DataSource = null;
                        gc_StdQY.DataSource = null;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 执行标准明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_StdMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                gc_Spec.DataSource = null;
                gc_StdCX.DataSource = null;
                gc_StdXN.DataSource = null;
                gc_StdQY.DataSource = null;
                DataRow dr = this.gv_StdMain.GetDataRow(this.gv_StdMain.FocusedRowHandle);
                if (dr == null) return;
                string str = dr["C_ID"].ToString();

                NewMethod(str);
                NewMethod1(str);
                NewMethod2(str);
                NewMethod3(str);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 执行标准明细 取样信息
        /// </summary>
        /// <param name="str"></param>
        private void NewMethod3(string str)
        {
            try
            {
                Bll_TQB_STD_SAMPLING bll_stdSampaing = new Bll_TQB_STD_SAMPLING();
                DataTable dt_stdSampaning = bll_stdSampaing.GetList("C_STD_MAIN_ID='" + str + "'").Tables[0];
                //冻结有焦点的列
                gv_StdQY.Columns[0].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_StdQY.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                this.gc_StdQY.DataSource = dt_stdSampaning;
                gv_StdQY.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_StdQY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询执行标准 性能
        /// </summary>
        /// <param name="str"></param>
        private void NewMethod2(string str)
        {
            try
            {
                DataTable dt_XN = bll_StdCFXN.GetList("C_STD_MAIN_ID='" + str + "' and c.c_type_name='性能'").Tables[0];
                //冻结有焦点的列
                gv_StdXN.Columns[0].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_StdXN.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                this.gc_StdXN.DataSource = dt_XN;
                gv_StdXN.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_StdXN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询执行标准 成分
        /// </summary>
        /// <param name="str"></param>
        private void NewMethod1(string str)
        {
            try
            {
                DataTable dt_CX = bll_StdCFXN.GetList("C_STD_MAIN_ID='" + str + "' and c.c_type_name='成分'").Tables[0];
                this.gc_StdCX.DataSource = dt_CX;
                //冻结有焦点的列
                gv_StdCX.Columns[0].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_StdCX.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                gv_StdCX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_StdCX);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 钢种规格明细
        /// </summary>
        /// <param name="str"></param>
        private void NewMethod(string str)
        {
            try
            {
                Bll_TQB_STD_SPEC bll_StdSpec = new Bll_TQB_STD_SPEC();
                DataTable dt = bll_StdSpec.GetList("C_STD_MAIN_ID='" + str + "'").Tables[0];
                this.gc_Spec.DataSource = dt;
                gv_Spec.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Spec);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static string str_cid;
        public static string str_HC;
        /// <summary>
        /// 跳转到添加页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                str_cid = "";
                FrmQB_ZXBZWH_ADD frm = new FrmQB_ZXBZWH_ADD(strPhyCode);
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    btn_Query_Click(null, null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 跳转到修改界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_StdMain.GetDataRow(this.gv_StdMain.FocusedRowHandle);
                if (dr == null) return;
                if (dr["N_IS_CHECK"].ToString() == "已审核")
                {
                    MessageBox.Show("已审核，不能修改！");
                    return;
                }
                str_cid = dr["C_ID"].ToString();
                if (!string.IsNullOrEmpty(str_cid))
                {
                    FrmQB_ZXBZWH_Edit frm = new FrmQB_ZXBZWH_Edit(strPhyCode);
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        frm.Close();
                        btn_Query_Click(null, null);

                    }
                }
                else
                {
                    MessageBox.Show("请选择需要修改的数据！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 复制添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copy_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_StdMain.GetDataRow(this.gv_StdMain.FocusedRowHandle);
                if (dr == null) return;
                str_cid = dr["C_ID"].ToString();
                if (!string.IsNullOrEmpty(str_cid))
                {
                    FrmQB_ZXBZWH_Copy frm = new FrmQB_ZXBZWH_Copy(strPhyCode);
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        frm.Close();
                        btn_Query_Click(null, null);

                    }
                }
                else
                {
                    MessageBox.Show("请选择需要复制的数据！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Audit_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_StdMain.GetDataRow(this.gv_StdMain.FocusedRowHandle);
                if (dr == null) return;
                if (dr["N_IS_CHECK"].ToString() == "已审核")
                {
                    MessageBox.Show("请勿重复审核！");
                    return;
                }

                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STD_CODE", dr["C_STD_CODE"].ToString());
                ht.Add("N_IS_CHECK", "1");
                ht.Add("N_STATUS", "1");
                ht.Add("C_STL_GRD", dr["C_STL_GRD"].ToString());
                if (Common.CheckRepeat.CheckTable("TQB_STD_MAIN", ht) > 0)
                {
                    MessageBox.Show("已存在重复的标准,不能审核，请先停用原来的标准！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string result = bll_StdMain.Creat_Design(dr["C_ID"].ToString());

                if (result == "成功")
                {
                    Mod_TQB_STD_MAIN mod = bll_StdMain.GetModel(dr["C_ID"].ToString());

                    mod.N_IS_CHECK = 1;
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    if (bll_StdMain.Update(mod))
                    {
                        MessageBox.Show("已审核！");

                        UpdateDesign(dr["C_ID"].ToString(), dr["C_STD_CODE"].ToString(), dr["C_STL_GRD"].ToString());

                        btn_Query_Click(null, null);
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "审核执行标准");//添加操作日志
                    }
                }
                else
                {
                    MessageBox.Show("成分性能没有维护，不能审核！");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateDesign(string strMainID, string strStdCode, string strStlGrd)
        {
            string strDesign = bllTqbDesign.Get_New_Design(strMainID);

            if (!string.IsNullOrEmpty(strDesign))
            {
                bllTrcRollProduct.Update_Design(strDesign, strStdCode, strStlGrd);

                bllTrcRollProduct.Update_Order_Design(strDesign, strStdCode, strStlGrd);
            }
        }


        /// <summary>
        /// 取消审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btn_Cancel_Audit_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DataRow dr = this.gv_StdMain.GetDataRow(this.gv_StdMain.FocusedRowHandle);
        //        if (dr == null) return;
        //        if (dr["N_IS_CHECK"].ToString() == "未审核")
        //        {
        //            MessageBox.Show("请勿重复取消！");
        //            return;
        //        }
        //        Mod_TQB_STD_MAIN mod = bll_StdMain.GetModel(dr["C_ID"].ToString());

        //        mod.N_IS_CHECK = 0;
        //        mod.C_EMP_ID = RV.UI.UserInfo.UserID;
        //        mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
        //        if (
        //        bll_StdMain.Update(mod))
        //        {
        //            MessageBox.Show("已取消审核！");
        //            btn_Query_Click(null, null);
        //            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消审核执行标准");//添加操作日志
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}



        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_STD_MAIN", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用执行标准");//添加操作日志
                            MessageBox.Show("已停用！");
                            btn_Query_Click(null, null);
                        }
                    }
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
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_out_Click(object sender, EventArgs e)
        {
            Common.OutToExcel.ToExcel(this.gc_StdMain);
        }
    }
}
