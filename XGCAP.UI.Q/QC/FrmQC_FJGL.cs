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
    public partial class FrmQC_FJGL : Form
    {
        public FrmQC_FJGL()
        {
            InitializeComponent();
        }
        private string strMenuName;
        Bll_TQC_COMPRE_ITEM_RESULT bll_item_result = new Bll_TQC_COMPRE_ITEM_RESULT();//综合判定项目结果明细
        Bll_TQC_RECHECK bll_recheck = new Bll_TQC_RECHECK();//复检申请
        private Bll_Common bllCommon = new Bll_Common();
        Bll_TQC_UPD_MATERIAL_MAIN bllUpdMaterial = new Bll_TQC_UPD_MATERIAL_MAIN();
        Bll_TQC_UPDATE_MATERIAL bll_Update = new Bll_TQC_UPDATE_MATERIAL();

        private void FrmQC_FJGL_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;


            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            dte_Begin1.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            Query();

        }
        /// <summary>
        /// 查询判定结果
        /// </summary>
        private void Query()
        {
            try
            {
                DataTable dt = bll_item_result.GetList_Group(Convert.ToDateTime(dte_Begin.DateTime), Convert.ToDateTime(dte_End.DateTime), txt_Stove.Text.Trim(), txt_BatchNo.Text.Trim(), imgcbo_ZP.EditValue.ToString()).Tables[0];
                this.gc_SJXX.DataSource = dt;
                gv_SJXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SJXX);
                NewMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 查询项目名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_SJXX_Click(object sender, EventArgs e)
        {
            NewMethod();
        }
        /// <summary>
        /// 查询项目名称
        /// </summary>
        private void NewMethod()
        {
            DataRow dr = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
            if (dr == null)
            {
                gc_right.DataSource = null;
                return;
            }
            DataTable dt = bll_item_result.GetList_ItemName(dr["C_STOVE"].ToString(), dr["C_BATCH_NO"].ToString()).Tables[0];
            gc_right.DataSource = dt;
            gv_right.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_right);
        }

        /// <summary>
        /// 复检申请查询
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
                DataTable dt = bll_recheck.GetList_Query_Group(Convert.ToDateTime(dte_Begin1.DateTime), Convert.ToDateTime(dte_End1.DateTime), txt_Stove_Sam.Text.Trim(), txt_BatchNo_Sam.Text.Trim(), 0).Tables[0];
                this.gc_SQLB.DataSource = dt;
                gv_SQLB.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SQLB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 复检申请
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_FJSQ_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                if (!int.TryParse(txt_Num.Text.Trim(), out result))
                {
                    MessageBox.Show("数量只能填写整数！");
                    return;
                }

                if (Convert.ToInt32(txt_Num.Text.Trim()) == 0)
                {
                    MessageBox.Show("请输入取样数量！");
                    return;
                }
                if (image_Count.Text.Trim()=="")
                {
                    MessageBox.Show("请选择复检次数！");
                    return;
                }


                DataRow dr = this.gv_SJXX.GetDataRow(this.gv_SJXX.FocusedRowHandle);
                DataRow dr_right = this.gv_right.GetDataRow(this.gv_right.FocusedRowHandle);
                if (dr == null) return;
                if (dr_right == null) return;
                int cou = bll_recheck.GetRecordCount(dr["C_BATCH_NO"].ToString());
                if (cou > 0)
                {
                    if (DialogResult.OK != MessageBox.Show("该批号已申请'" + cou + "'件，是否确认继续申请！", "提示", MessageBoxButtons.OKCancel))
                    {
                        return;
                    }
                }
                string strItemName = "";
                DataTable dt = bll_item_result.Get_Item(dr["C_STOVE"].ToString(), dr["C_BATCH_NO"].ToString(), dr_right["C_CODE"].ToString()).Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Mod_TQC_COMPRE_ITEM_RESULT mod = bll_item_result.GetModel(dt.Rows[i]["C_ID"].ToString());
                    strItemName += mod.C_ITEM_NAME + ";";
                }


                if (Convert.ToInt32(txt_Num.Text.Trim()) > 0)
                {
                    for (int i = 0; i < Convert.ToInt32(txt_Num.Text.Trim()); i++)
                    {
                        Mod_TQC_RECHECK model = new Mod_TQC_RECHECK();
                        model.C_PHYSICS_CODE = dr_right["C_CODE"].ToString();
                        model.C_PHYSICS_NAME = dr_right["C_NAME"].ToString();
                        model.C_STOVE = dr["C_STOVE"].ToString();
                        model.C_BATCH_NO = dr["C_BATCH_NO"].ToString();
                        model.C_STL_GRD = dr["C_STL_GRD"].ToString();
                        model.C_SPEC = dr["C_SPEC"].ToString();
                        model.C_STD_CODE = dr["C_STD_CODE"].ToString();
                        model.C_ITEM_NAME = strItemName;
                        model.C_SHIFT = imcbo_Shift.Text.Trim();
                        model.C_GROUP = imcbo_Group.Text.Trim();
                        model.C_DISPOSAL = txt_CLYJ.Text.Trim();
                        model.N_RECHECK = Convert.ToDecimal(image_Count.Text.Trim());
                        model.C_EMP_ID = RV.UI.UserInfo.userID;
                        bll_recheck.Add(model);
                       

                    }
                    Mod_TQC_UPD_MATERIAL_MAIN mod_UpdMaterial = new Mod_TQC_UPD_MATERIAL_MAIN();
                    mod_UpdMaterial.C_BATCH_NO = dr["C_BATCH_NO"].ToString();
                    mod_UpdMaterial.C_REMARK = txt_CLYJ.Text.Trim();
                    mod_UpdMaterial.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod_UpdMaterial.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    #region 检测是否重复添加    
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_BATCH_NO", mod_UpdMaterial.C_BATCH_NO);
                    ht.Add("N_STATUS", 1);
                    if (Common.CheckRepeat.CheckTable("TQC_UPD_MATERIAL_MAIN", ht) > 0)
                    {
                        if (DialogResult.OK != MessageBox.Show(" 批号'" + mod_UpdMaterial.C_BATCH_NO + "'已申请修料，是否确认继续申请！", "提示", MessageBoxButtons.OKCancel))
                        {
                            return;
                        }
                        else
                        {
                            DataTable dts = bll_Update.GetList_CXXL(dr["C_BATCH_NO"].ToString()).Tables[0];
                            for (int s = 0; s < dt.Rows.Count; s++)
                            {
                                Mod_TQC_UPDATE_MATERIAL mod_update = bll_Update.GetModel(dts.Rows[s]["C_ID"].ToString());
                                mod_update.N_STATUS = 0;
                                mod_update.C_EMP_ID = RV.UI.UserInfo.UserID;
                                mod_update.D_MOD_DT = RV.UI.ServerTime.timeNow();
                                bll_Update.Update(mod_update);
                            }

                        }
                    }
                    #endregion
                    bllUpdMaterial.Add(mod_UpdMaterial);
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加复检申请信息");//添加操作日志    
                    Query_SQ();
                    MessageBox.Show("申请成功！");

                    txt_Num.Text = "";
                    image_Count.Text = "";
                }
                else
                {
                    MessageBox.Show("请选择需要申请的信息！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 取消申请
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QXSQ_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否取消申请？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    DataRow dr = gv_SQLB.GetDataRow(gv_SQLB.FocusedRowHandle);
                    if (dr == null) return;
                    if (bll_recheck.Update_CX(dr["C_STOVE"].ToString(), dr["C_BATCH_NO"].ToString(), dr["C_STL_GRD"].ToString(), dr["C_SPEC"].ToString(), dr["C_STD_CODE"].ToString(), dr["C_PHYSICS_CODE"].ToString(), dr["DT"].ToString()))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用复检申请信息");//添加操作日志
                        Query_SQ();
                        MessageBox.Show("已取消申请！");
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
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl4.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
