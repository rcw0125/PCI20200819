using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using BLL;
using MODEL;

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_GPZHPD : Form
    {
        private Bll_TSC_SLAB_MAIN bllSlabMain = new Bll_TSC_SLAB_MAIN();
        private Bll_TQC_COMPRE_ITEM_RESULT bllCompre = new Bll_TQC_COMPRE_ITEM_RESULT();
        private Bll_TQB_CHECKSTATE bll_checkstate = new Bll_TQB_CHECKSTATE();
        private Bll_TQC_COMPRE_SLAB bllTqcCompreSlab = new Bll_TQC_COMPRE_SLAB();

        private string strMenuName;

        private int rowIndex = 0;

        public FrmQC_GPZHPD()
        {
            InitializeComponent();
        }

        private void FrmQC_GPZHPD_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strMenuName = RV.UI.UserInfo.menuName;

            dt_Start.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dt_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            //DataSet dt = bll_checkstate.GetList_GP("");
            //imgcbo_PDDJ.Properties.Items.Clear();
            //foreach (DataRow item in dt.Tables[0].Rows)//判定等级下拉框
            //{
            //    imgcbo_PDDJ.Properties.Items.Add(item["C_CHECKSTATE_NAME"].ToString(), item["C_ID"], -1);
            //}
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
        /// 绑定综合判定钢坯信息
        /// </summary>
        public void BindCompreList()
        {
            WaitingFrom.ShowWait("");

            gc_Compre.DataSource = null;

            DataTable dt = bllTqcCompreSlab.GetList(txt_Stove.Text.Trim(), dt_Start.Text.Trim(), dt_End.Text.Trim(), icbo_state.EditValue.ToString()).Tables[0];

            this.gc_Compre.DataSource = dt;

            gv_Compre.BestFitColumns();

            SetGridViewRowNum.SetRowNum(gv_Compre);

            gv_Compre.FocusedRowHandle = rowIndex;

            WaitingFrom.CloseWait();
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

                txt_Remark.Text = dr["备注"].ToString();

                DataTable dt = bllCompre.GetListCF(dr["炉号"].ToString(), dr["钢种"].ToString(), dr["断面"].ToString(), dr["执行标准"].ToString()).Tables[0];

                gc_Item.DataSource = dt;
                gv_Item.BestFitColumns();

                SetGridViewRowNum.SetRowNum(gv_Item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        DevExpress.Utils.AppearanceDefault appNotPass1 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Red, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
        DevExpress.Utils.AppearanceDefault appNotPass2 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Yellow, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);

        private void gv_Item_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                string strResult = gv_Item.GetRowCellValue(e.RowHandle, "C_RESULT").ToString();
                if (strResult == "不合格")
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass1);
                }
                else if (string.IsNullOrEmpty(strResult))
                {
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
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
            DataRow dr = gv_Compre.GetDataRow(gv_Compre.FocusedRowHandle);
            if (dr != null)
            {
                rowIndex = gv_Compre.FocusedRowHandle;

                Mod_TQC_COMPRE_SLAB model = bllTqcCompreSlab.GetModel(dr["C_ID"].ToString());
                if (model != null)
                {
                    string result = bllTqcCompreSlab.Slab_Remark(model, txt_Remark.Text.Trim());

                    if (result=="1")
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
            if (string.IsNullOrEmpty(imgcbo_PDDJ.Text.Trim()))
            {
                MessageBox.Show("请选择判定等级！");
                return;
            }

            DataRow dr = gv_Compre.GetDataRow(gv_Compre.FocusedRowHandle);
            if (dr != null)
            {
                rowIndex = gv_Compre.FocusedRowHandle;

                Mod_TQC_COMPRE_SLAB model = bllTqcCompreSlab.GetModel(dr["C_ID"].ToString());
                if (model != null)
                {
                    if (dr["是否确认"].ToString() == "Y")
                    {
                        MessageBox.Show("已经审核确认，不能重新人工判定！");
                        return;
                    }

                    model.C_RESULT_PEOPLE = imgcbo_PDDJ.Text.Trim();//人工判定结果
                    model.D_RESPEO_DT = RV.UI.ServerTime.timeNow();//人工判定时间
                    if (bllTqcCompreSlab.Update(model))
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
        /// 审核确认
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
                    rowIndex = gv_Compre.FocusedRowHandle;

                    Mod_TQC_COMPRE_SLAB model = bllTqcCompreSlab.GetModel(dr["C_ID"].ToString());
                    if (model != null)
                    {
                        if (!string.IsNullOrEmpty(model.C_RESULT_PEOPLE) || model.C_RESULT_ALL == "合格品")
                        {
                            //判定结果回写实绩表
                            string strResult = "";
                            if (!string.IsNullOrEmpty(model.C_RESULT_PEOPLE))
                            {
                                strResult = model.C_RESULT_PEOPLE;
                            }
                            else
                            {
                                strResult = model.C_RESULT_ALL;
                            }

                            if (DialogResult.No == MessageBox.Show("炉号：" + dr["炉号"].ToString() + " 的综判结果为 " + strResult + " ,确定审核确认吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                            {
                                return;
                            }

                            string result = bllTqcCompreSlab.Slab_Compre_OK(model, strResult);

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
                            MessageBox.Show("请先选择人工判定等级！");
                            return;
                        }
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
                MessageBox.Show("请选择需要人工判定的数据！");
                return;
            }
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
                WaitingFrom.ShowWait("正在判定，请稍等...");

                string result_PD = bllTqcCompreSlab.JUDGE_SLAB().ToString();
                string result_TB = bllTqcCompreSlab.TB_SLAB().ToString();

                MessageBox.Show("系统判定成功！");
                BindCompreList();

                WaitingFrom.CloseWait();
            }
        }

        private void btn_Sys_PD_Stove_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Compre.GetDataRow(gv_Compre.FocusedRowHandle);
            if (dr != null)
            {
                rowIndex = gv_Compre.FocusedRowHandle;

                if (DialogResult.Yes == MessageBox.Show("确认判定批号：" + dr["炉号"].ToString() + "吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    WaitingFrom.ShowWait("正在系统判定，请稍等...");

                    string result_Judge = bllTqcCompreSlab.JUDGE_SLAB_STOVE(dr["炉号"].ToString());//判定
                    string result_Tb = bllTqcCompreSlab.TB_SLAB_STOVE(dr["炉号"].ToString());//同步

                    if (result_Judge == "成功" || result_Tb == "成功")
                    {
                        MessageBox.Show("系统判定成功！");
                        BindCompreList();
                    }

                    WaitingFrom.CloseWait();
                }
            }
        }
    }
}
