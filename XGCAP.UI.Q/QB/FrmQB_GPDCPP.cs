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
    public partial class FrmQB_GPDCPP : Form
    {
        private Bll_TQB_STD_MAIN bllTqbStdMain = new Bll_TQB_STD_MAIN();
        private Bll_TQB_STD_TYPE bllTqbStdType = new Bll_TQB_STD_TYPE();
        private Bll_TQB_SLAB_LEN bllTqbSlabLen = new Bll_TQB_SLAB_LEN();
        private Bll_TQB_SLAB_LEN_MATCH bllTqbSlabLenMatch = new Bll_TQB_SLAB_LEN_MATCH();

        private string strMenuName;
        string strPhyCode;

        public FrmQB_GPDCPP()
        {
            InitializeComponent();
        }

        private void FrmQB_GPDCPP_Load(object sender, EventArgs e)
        {
            
            try
            {
                strMenuName = RV.UI.UserInfo.menuName;
                UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
                strPhyCode = RV.UI.QueryString.parameter;
                BindStdType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 绑定执行标准类型
        /// </summary>
        private void BindStdType()
        {
            DataTable dt = bllTqbStdType.GetAllList().Tables[0];
            imgcbo_StdType.Properties.Items.Add("全部", "全部", -1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                imgcbo_StdType.Properties.Items.Add(dt.Rows[i]["C_TYPE_NAME"].ToString(), dt.Rows[i]["C_ID"].ToString(), -1);
            }

            imgcbo_StdType.SelectedIndex = 0;
        }

        private void BindSlabMatchList(string C_STD_ID)
        {

            DataTable dt = bllTqbSlabLenMatch.GetSlabMatch(C_STD_ID).Tables[0];

            gc_SlabMatch.DataSource = dt;
            gv_SlabMatch.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_SlabMatch);
        }

        private void BindSlabList(string C_STD_ID, string stl)
        {
            DataTable dt = new DataTable();
            if (strPhyCode == "1")
            {
                dt = bllTqbSlabLen.GetSLabNoMatch_Hot(C_STD_ID, stl, txt_Size.Text.Trim()).Tables[0];
            }
            else
            {

                dt = bllTqbSlabLen.GetSLabNoMatch_Cold(C_STD_ID, stl, txt_Size.Text.Trim()).Tables[0];
            } 
            gc_Slab.DataSource = dt;
            gv_Slab.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Slab);
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
                gc_StdMain.DataSource = null;
                DataTable dt = bllTqbStdMain.GetList_GPDC(strPhyCode, imgcbo_StdType.Text.Trim(), txt_Std.Text.Trim(), txt_Grd.Text.Trim()).Tables[0];

                gc_StdMain.DataSource = dt;
                gv_StdMain.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_StdMain);
                if (dt.Rows.Count > 0)
                {
                    BindSlabMatchList(dt.Rows[0]["C_ID"].ToString());
                }
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 钢坯定尺匹配字表 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_StdMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            { 
                DataRow dr = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
                if (dr == null) return;
                BindSlabMatchList(dr["C_ID"].ToString());
                BindSlabList(dr["C_ID"].ToString(), dr["C_STL_GRD"].ToString());
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
                DataRow dr_StdMain = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
                DataRow dr_Slab = gv_Slab.GetDataRow(gv_Slab.FocusedRowHandle);
                if (dr_StdMain == null) return;
                if (dr_Slab == null) return;
                Mod_TQB_SLAB_LEN_MATCH model = new Mod_TQB_SLAB_LEN_MATCH();
                model.C_STD_ID = dr_StdMain["C_ID"].ToString();
                model.C_SLAB_ID = dr_Slab["C_ID"].ToString();
                model.C_STD_CODE = dr_StdMain["C_STD_CODE"].ToString();
                model.C_STL_GRD = dr_StdMain["C_STL_GRD"].ToString();
                model.C_REMARK = dr_Slab["C_REMARK"].ToString();
                model.C_EMP_ID = RV.UI.UserInfo.userID;

                if (bllTqbSlabLenMatch.Add(model))
                {
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钢坯定尺匹配关系");//添加操作日志

                    BindSlabMatchList(dr_StdMain["C_ID"].ToString());
                    BindSlabList(dr_StdMain["C_ID"].ToString(), dr_StdMain["C_STL_GRD"].ToString());
                }
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
        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {

                    Bll_Common bllCommon = new Bll_Common();
                    DataRow dr = gv_SlabMatch.GetDataRow(gv_SlabMatch.FocusedRowHandle);
                    if (dr == null) return;
                    if (bllCommon.DataDisabled("Tqb_Slab_Len_Match", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                    {
                        gv_StdMain_FocusedRowChanged(null, null);
                        MessageBox.Show("已删除！");


                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消钢坯定尺匹配关系");//添加操作日志
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
        /// 保存分组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (gv_SlabMatch.DataRowCount > 0)
            {
                DataRow dr_StdMain = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
                Mod_TQB_SLAB_LEN_MATCH model = new Mod_TQB_SLAB_LEN_MATCH();

                for (int i = 0; i < gv_SlabMatch.DataRowCount; i++)
                {
                   
                    model = bllTqbSlabLenMatch.GetModel(gv_SlabMatch.GetRowCellValue(i, "C_ID").ToString());
                    model.C_GROUP = gv_SlabMatch.GetRowCellValue(i, "C_GROUP1").ToString();
                    model.C_ORDER = gv_SlabMatch.GetRowCellValue(i, "C_ORDER").ToString();
                    if (!string.IsNullOrEmpty(model.C_ORDER))
                    {
                        int result = 0;
                        if (!Int32.TryParse(model.C_ORDER, out result))
                        {
                            MessageBox.Show("第" + (i + 1) + "行顺序号输入错误，只能输入整数！");
                            continue;
                        }
                    }
                    bllTqbSlabLenMatch.Update(model);
                }
                BindSlabMatchList(dr_StdMain["C_ID"].ToString());
                MessageBox.Show("保存成功");
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QueryRight_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
            if (dr == null) return; 
            BindSlabList(dr["C_ID"].ToString(), dr["C_STL_GRD"].ToString());
        }
    }
}
