using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_XCZHPD : Form
    {
        private Bll_TQC_COMPRE_ITEM_RESULT bllCompre = new Bll_TQC_COMPRE_ITEM_RESULT();
        private Bll_TRC_ROLL_PRODCUT bllRollProduct = new Bll_TRC_ROLL_PRODCUT();
        private Bll_TQB_CHECKSTATE bll_checkstate = new Bll_TQB_CHECKSTATE();
        private Bll_TQC_COMPRE_ROLL bllTqcCompreRoll = new Bll_TQC_COMPRE_ROLL();
        private Bll_TQB_STD_SAMPLING bllTqbStdSampling = new Bll_TQB_STD_SAMPLING();

        private string strMenuName;

        private int rowIndex = 0;

        public FrmQC_XCZHPD()
        {
            InitializeComponent();
        }

        private void FrmQC_XCZHPD_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strMenuName = RV.UI.UserInfo.menuName;

            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            DataSet dt = bll_checkstate.GetList("");
            imgcbo_PDDJ.Properties.Items.Clear();
            imgcbo_PDDJ.Properties.Items.Add("", "", -1);
            foreach (DataRow item in dt.Tables[0].Rows)//判定等级下拉框
            {
                imgcbo_PDDJ.Properties.Items.Add(item["C_CHECKSTATE_NAME"].ToString(), item["C_CHECKSTATE_NAME"].ToString(), -1);
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
                rowIndex = 0;
                BindCompreList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 绑定综合判定线材信息
        /// </summary>
        public void BindCompreList()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Compre.DataSource = null;

                DataTable dt = bllTqcCompreRoll.GetList(txt_BatchNo.Text.Trim(), txt_Stove.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), icbo_state.EditValue.ToString(), icbo_Time.EditValue.ToString()).Tables[0];

                this.gc_Compre.DataSource = dt;

                gv_Compre.BestFitColumns();

                SetGridViewRowNum.SetRowNum(gv_Compre);

                gv_Compre.FocusedRowHandle = rowIndex;

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 综判信息选择变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Compre_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = this.gv_Compre.GetDataRow(this.gv_Compre.FocusedRowHandle);
                if (dr == null) return;

                DataTable dt = bllCompre.GetListCF(dr["炉号"].ToString(), dr["钢种"].ToString(), "", dr["执行标准"].ToString(), dr["批号"].ToString()).Tables[0];

                DataTable dtXN = bllCompre.GetListXN(dr["批号"].ToString(), dr["钢种"].ToString(), dr["规格"].ToString(), dr["执行标准"].ToString()).Tables[0];

                dt.Merge(dtXN);

                gc_Item.DataSource = dt;
                gv_Item.BestFitColumns();

                SetGridViewRowNum.SetRowNum(gv_Item);

                int count = bllTqbStdSampling.Get_Count(dr["执行标准"].ToString(), dr["钢种"].ToString());
                if (count > 0)
                {
                    MessageBox.Show("该批号需要取线材的成分！！！");
                }

                txt_Remark.Text = dr["备注"].ToString();

                imgcbo_PDDJ.EditValue = dr["表判结果"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        DevExpress.Utils.AppearanceDefault appNotPass1 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Red, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
        DevExpress.Utils.AppearanceDefault appNotPass2 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Yellow, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
        DevExpress.Utils.AppearanceDefault appNotPass3 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.LightGreen, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);

        private void gv_Item_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                //T.C_IS_DECIDE,T.C_IS_SHOW c_value
                string strResult = gv_Item.GetRowCellValue(e.RowHandle, "C_RESULT").ToString();
                string strPD = gv_Item.GetRowCellValue(e.RowHandle, "C_IS_DECIDE").ToString();
                string strPrint = gv_Item.GetRowCellValue(e.RowHandle, "C_IS_SHOW").ToString();
                string strValue = gv_Item.GetRowCellValue(e.RowHandle, "C_VALUE").ToString();
                if (strResult == "不合格")
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass1);
                }
                else if (strResult == "数据有误")
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                }
                else if (string.IsNullOrEmpty(strResult))
                {
                    //if (!string.IsNullOrEmpty(strValue))
                    //{
                    //    if (strPD == "否")
                    //    {
                    //        DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass3);
                    //    }
                    //}

                    if (strPD == "否")
                    {
                        DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass3);

                        if (strPrint == "是" && string.IsNullOrEmpty(strValue))
                        {
                            DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                        }
                    }
                    else
                    {
                        DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                    }
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 保存备注
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Remark.Text.Trim()))
            {
                MessageBox.Show("请填写备注！");
                return;
            }

            DataRow dr = gv_Compre.GetDataRow(gv_Compre.FocusedRowHandle);
            if (dr != null)
            {
                rowIndex = gv_Compre.FocusedRowHandle;

                Mod_TQC_COMPRE_ROLL model = bllTqcCompreRoll.GetModel(dr["C_ID"].ToString());
                if (model != null)
                {
                    model.C_REMARK = txt_Remark.Text.Trim();
                    if (bllTqcCompreRoll.Update(model))
                    {
                        MessageBox.Show("保存备注成功！");
                        BindCompreList();
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择需要保存备注的数据！");
                return;
            }
        }

        /// <summary>
        /// 人工判定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Peo_PD_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(imgcbo_PDDJ.Text.Trim()))
            //{
            //    MessageBox.Show("请选择判定等级！");
            //    return;
            //}

            DataRow dr = gv_Compre.GetDataRow(gv_Compre.FocusedRowHandle);
            if (dr != null)
            {
                rowIndex = gv_Compre.FocusedRowHandle;

                if (DialogResult.No == MessageBox.Show("批号：" + dr["批号"].ToString() + " , 确定人工判定为(" + imgcbo_PDDJ.Text.Trim() + ")吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }

                Mod_TQC_COMPRE_ROLL model = bllTqcCompreRoll.GetModel(dr["C_ID"].ToString());
                if (model != null)
                {
                    if (dr["是否确认"].ToString() == "Y")
                    {
                        MessageBox.Show("已经审核确认，不能重新人工判定！");
                        return;
                    }

                    model.C_RESULT_PEOPLE = imgcbo_PDDJ.Text.Trim();//人工判定结果
                    model.D_RESPEO_DT = RV.UI.ServerTime.timeNow();//人工判定时间
                    if (bllTqcCompreRoll.Update(model))
                    {
                        MessageBox.Show("判定成功！");
                        BindCompreList();
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择需要人工判定的数据！");
                return;
            }
        }

        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QR_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Compre.GetDataRow(gv_Compre.FocusedRowHandle);
            if (dr != null)
            {
                if (dr["是否确认"].ToString() == "N")
                {
                    string strBatchNo = dr["批号"].ToString();

                    rowIndex = gv_Compre.FocusedRowHandle;

                    if (DialogResult.No == MessageBox.Show("批号：" + strBatchNo + " ,确定审核确认吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }

                    string result = bllTqcCompreRoll.Roll_Compre_OK(strBatchNo, Application.StartupPath);

                    if (result == "1")
                    {
                        MessageBox.Show("确认成功！");
                        BindCompreList();
                    }
                    else
                    {
                        MessageBox.Show(result);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("已审核确认过，不能重复审确认！");
                    return;
                }
            }
            else
            {
                MessageBox.Show("请选择需要确认的数据！");
                return;
            }
        }

        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            //DataRow dr = gv_Compre.GetDataRow(gv_Compre.FocusedRowHandle);
            //if (dr != null)
            //{
            //    if (dr["是否确认"].ToString() == "Y")
            //    {
            //        Mod_TQC_COMPRE_ROLL model = bllTqcCompreRoll.GetModel(dr["C_ID"].ToString());
            //        if (model != null)
            //        {
            //            if (!string.IsNullOrEmpty(model.C_RESULT_PEOPLE) || model.C_RESULT_ALL == "A")
            //            {
            //                if (DialogResult.No == MessageBox.Show("确认取消：" + dr["批号"].ToString() + " 的审核确认状态吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            //                {
            //                    return;
            //                }

            //                model.C_QR_STATE = "N";
            //                model.C_EMP_ID = RV.UI.UserInfo.userID;
            //                model.D_MOD_DT = RV.UI.ServerTime.timeNow();

            //                if (bllTqcCompreRoll.Update(model))
            //                {
            //                    if (bllRollProduct.Update(model.C_EMP_ID, model))
            //                    {
            //                        MessageBox.Show("确认成功！");
            //                        BindCompreList();
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("请先选择人工判定等级！");
            //                return;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("没有审核确认过，不需要撤销！");
            //        return;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("请选择需要撤销的数据！");
            //    return;
            //}
        }

        /// <summary>
        /// 系统判定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sys_PD_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认系统判定吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
            {
                WaitingFrom.ShowWait("正在系统判定，请稍等...");

                string result_Judge = bllTqcCompreRoll.JUDGE_ROLL().ToString();//判定
                string result_Tb = bllTqcCompreRoll.TB_ROLL().ToString();//同步

                MessageBox.Show("系统判定成功！");
                BindCompreList();

                WaitingFrom.CloseWait();
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(gc_Compre, "综判信息-" + System.DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        /// <summary>
        /// 单批号判定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sys_PD_Batch_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Compre.GetDataRow(gv_Compre.FocusedRowHandle);
            if (dr != null)
            {
                rowIndex = gv_Compre.FocusedRowHandle;

                if (DialogResult.Yes == MessageBox.Show("确认判定批号：" + dr["批号"].ToString() + "吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    WaitingFrom.ShowWait("正在系统判定，请稍等...");

                    string result_Judge = bllTqcCompreRoll.JUDGE_ROLL_BATCH(dr["批号"].ToString());//判定
                    string result_Tb = bllTqcCompreRoll.TB_ROLL_BATCH(dr["批号"].ToString());//同步

                    if (result_Judge == "成功" || result_Tb == "成功")
                    {
                        MessageBox.Show("系统判定成功！");
                        BindCompreList();
                    }

                    WaitingFrom.CloseWait();
                }
            }
        }

        /// <summary>
        /// 保存特殊信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_TSXX_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Compre.GetDataRow(gv_Compre.FocusedRowHandle);
            if (dr != null)
            {

                if (DialogResult.Yes == MessageBox.Show("确认添加批号：" + dr["批号"].ToString() + "的特殊信息为厂外时效吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    rowIndex = gv_Compre.FocusedRowHandle;

                    string result = bllTqcCompreRoll.Save_TSXX(dr, "厂外时效");
                    if (result == "1")
                    {
                        MessageBox.Show("添加特殊信息成功！");
                        BindCompreList();
                    }
                    else
                    {
                        MessageBox.Show(result);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择需要添加特殊信息的数据！");
                return;
            }
        }
        /// <summary>
        /// 取消特殊信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QX_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Compre.GetDataRow(gv_Compre.FocusedRowHandle);
            if (dr != null)
            {
                if (DialogResult.Yes == MessageBox.Show("确认取消批号：" + dr["批号"].ToString() + "的厂外时效吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    rowIndex = gv_Compre.FocusedRowHandle;

                    string result = bllTqcCompreRoll.Cancle_TSXX(dr);
                    if (result == "1")
                    {
                        MessageBox.Show("取消特殊信息成功！");
                        BindCompreList();
                    }
                    else
                    {
                        MessageBox.Show(result);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择需要取消特殊信息的数据！");
                return;
            }
        }
    }
}
