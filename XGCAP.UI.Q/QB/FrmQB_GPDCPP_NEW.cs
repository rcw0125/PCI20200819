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
    public partial class FrmQB_GPDCPP_NEW : Form
    {
        private Bll_TQB_STD_MAIN bllTqbStdMain = new Bll_TQB_STD_MAIN();
        private Bll_TQB_STD_TYPE bllTqbStdType = new Bll_TQB_STD_TYPE();
        private Bll_TQB_SLAB_LEN bllTqbSlabLen = new Bll_TQB_SLAB_LEN();
        private Bll_TQB_SLAB_LEN_MATCH bllTqbSlabLenMatch = new Bll_TQB_SLAB_LEN_MATCH();
        private Bll_TB_SLAB_MATRAL bllSlabMatral = new Bll_TB_SLAB_MATRAL();

        private string strMenuName;
        string strPhyCode;

        public FrmQB_GPDCPP_NEW()
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void BindSlabMatchList(string C_STL_GRD, string C_STD_CODE,string C_ROUTE_DESC)
        {

            DataTable dt = bllSlabMatral.GetList(C_STL_GRD, C_STD_CODE, C_ROUTE_DESC).Tables[0];

            gc_SlabMatch.DataSource = dt;
            gv_SlabMatch.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_SlabMatch);
        }

        private void BindSlabList(string stl, string KP, string std)
        {
            DataTable dt = new DataTable();
            if (strPhyCode == "1")
            {
                dt = bllTqbSlabLen.GetSLabNoMatch611_BXG(stl, txt_Size.Text.Trim(), std).Tables[0];
            }
            if (strPhyCode == "0")
            {
                if (KP != "")
                {
                    dt = bllTqbSlabLen.GetSLabNoMatch613(stl, txt_Size.Text.Trim(), std).Tables[0];
                }
                else
                {
                    dt = bllTqbSlabLen.GetSLabNoMatch611(stl, txt_Size.Text.Trim(), std).Tables[0];
                }
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
                gc_StdMain.DataSource = null;
                DataTable dt = bllTqbStdMain.GetList_GYLX(strPhyCode, txt_Std.Text.Trim(), txt_Grd.Text.Trim()).Tables[0];

                gc_StdMain.DataSource = dt;
                gv_StdMain.BestFitColumns(); 
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
                BindSlabMatchList(dr["C_STL_GRD"].ToString(), dr["C_STD_CODE"].ToString(), dr["C_ROUTE_DESC"].ToString());
                BindSlabList(dr["C_STL_GRD"].ToString(), dr["KP"].ToString(), dr["C_STD_CODE"].ToString());
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
                int[] rownumber = gv_Slab.GetSelectedRows();//获取选中行号数组；
                if (rownumber.Length == 0)
                {
                    MessageBox.Show("请选择需要添加的信息！");
                    return;
                }

                for (int si = 0; si < rownumber.Length; si++)
                {
                    DataRow dr = gv_Slab.GetDataRow(rownumber[si]);

                    Mod_TB_SLAB_MATRAL model = new Mod_TB_SLAB_MATRAL();
                    model.C_MATRAL_CODE = dr["C_ID"].ToString();
                    model.C_STD_CODE = dr_StdMain["C_STD_CODE"].ToString();
                    model.C_STL_GRD = dr_StdMain["C_STL_GRD"].ToString();
                    model.C_ROUTE_DESC = dr_StdMain["C_ROUTE_DESC"].ToString();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;

                    #region 检测是否重复添加    
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_MATRAL_CODE", model.C_MATRAL_CODE);
                    ht.Add("C_STD_CODE", model.C_STD_CODE);
                    ht.Add("C_STL_GRD", model.C_STL_GRD);
                    ht.Add("C_ROUTE_DESC", model.C_ROUTE_DESC);
                    ht.Add("N_STATUS", "1");
                    if (Common.CheckRepeat.CheckTable("TB_SLAB_MATRAL", ht) > 0)
                    {
                        MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    #endregion
                    bllSlabMatral.Add(model);

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钢坯定尺匹配关系");//添加操作日志

                }


                BindSlabMatchList(dr_StdMain["C_STL_GRD"].ToString(), dr_StdMain["C_STD_CODE"].ToString(), dr_StdMain["C_ROUTE_DESC"].ToString());
                BindSlabList(dr_StdMain["C_STL_GRD"].ToString(), dr_StdMain["KP"].ToString(), dr_StdMain["C_STD_CODE"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #region 批量添加  
            //try
            //{
            //    DataRow dr_Slab = gv_Slab.GetDataRow(gv_Slab.FocusedRowHandle);
            //    DataRow dr_StdMain = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
            //    if (dr_Slab == null) return;
            //    int[] rownumber = gv_Slab.GetSelectedRows();//获取选中行号数组；
            //    if (rownumber.Length == 0)
            //    {
            //        MessageBox.Show("请选择需要添加的信息！");
            //        return;
            //    }
            //    DataTable dt = ((DataView)gv_StdMain.DataSource).ToTable();

            //    DataTable dt_slab = new DataTable();

            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        if (dt.Rows[i]["KP"].ToString() != "")
            //        {
            //            dt_slab = bllTqbSlabLen.GetSLabNoMatch613(dt.Rows[i]["C_STL_GRD"].ToString(), txt_Size.Text.Trim(), dt.Rows[i]["C_STD_CODE"].ToString()).Tables[0];
            //        }
            //        else
            //        {
            //            dt_slab = bllTqbSlabLen.GetSLabNoMatch611_BXG(dt.Rows[i]["C_STL_GRD"].ToString(), txt_Size.Text.Trim(), dt.Rows[i]["C_STD_CODE"].ToString()).Tables[0];
            //        }
            //        for (int si = 0; si < dt_slab.Rows.Count; si++)
            //        {
            //            DataRow dr = gv_Slab.GetDataRow(rownumber[si]);

            //            Mod_TB_SLAB_MATRAL model = new Mod_TB_SLAB_MATRAL();
            //            model.C_MATRAL_CODE = dt_slab.Rows[si]["C_ID"].ToString();
            //            model.C_STD_CODE = dt.Rows[i]["C_STD_CODE"].ToString();
            //            model.C_STL_GRD = dt.Rows[i]["C_STL_GRD"].ToString();
            //            model.C_EMP_ID = RV.UI.UserInfo.userID;
            //            #region 检测是否重复添加    
            //            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            //            ht.Add("C_MATRAL_CODE", model.C_MATRAL_CODE);
            //            ht.Add("C_STD_CODE", model.C_STD_CODE);
            //            ht.Add("C_STL_GRD", model.C_STL_GRD);
            //            ht.Add("N_STATUS", "1");
            //            if (Common.CheckRepeat.CheckTable("TB_SLAB_MATRAL", ht) > 0)
            //            {
            //                MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                return;
            //            }
            //            #endregion
            //            bllSlabMatral.Add(model);

            //            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钢坯定尺匹配关系");//添加操作日志

            //        }
            //    }

            //    BindSlabMatchList(dr_StdMain["C_STL_GRD"].ToString(), dr_StdMain["C_STD_CODE"].ToString());
            //    BindSlabList(dr_StdMain["C_STL_GRD"].ToString(), dr_StdMain["KP"].ToString(), dr_StdMain["C_STD_CODE"].ToString());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            #endregion
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
                    DataRow dr_StdMain = gv_SlabMatch.GetDataRow(gv_SlabMatch.FocusedRowHandle);
                    int[] rownumber = gv_SlabMatch.GetSelectedRows();//获取选中行号数组；
                    if (rownumber.Length == 0)
                    {
                        MessageBox.Show("请选择需要删除的信息！");
                        return;
                    }

                    for (int si = 0; si < rownumber.Length; si++)
                    {
                        DataRow dr = gv_SlabMatch.GetDataRow(rownumber[si]);
                        bllCommon.DataDisabled("TB_SLAB_MATRAL", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow());
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消钢坯定尺匹配关系");//添加操作日志
                    }
                    gv_StdMain_FocusedRowChanged(null, null);
                    MessageBox.Show("已删除！");

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
                BindSlabMatchList(dr_StdMain["C_STL_GRD"].ToString(), dr_StdMain["C_STD_CODE"].ToString(), dr_StdMain["C_ROUTE_DESC"].ToString());
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
            BindSlabList(dr["C_STL_GRD"].ToString(), dr["KP"].ToString(), dr["C_STD_CODE"].ToString());
        }
    }
}
