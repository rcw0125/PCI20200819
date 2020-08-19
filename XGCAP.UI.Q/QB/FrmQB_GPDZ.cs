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
    public partial class FrmQB_GPDZ : Form
    {
        private Bll_TB_MATRL_MAIN bllMatrlMain = new Bll_TB_MATRL_MAIN();
        private Bll_TB_MATRL_CONTRAST bllMatrlContrast = new Bll_TB_MATRL_CONTRAST();
        private string strMenuName;
        string strPhyCode;

        public FrmQB_GPDZ()
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

        /// <summary>
        /// 定尺对照表
        /// </summary>
        private void BindSlabMatchList()
        {
            try
            {

                DataRow dr = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
                if (dr == null) return;
                DataTable dt = bllMatrlContrast.GetList_Slab(dr["C_SLAB_SIZE"].ToString(), dr["N_LTH"].ToString()).Tables[0];

                gc_SlabMatch.DataSource = dt;
                gv_SlabMatch.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SlabMatch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindSlabList()
        {
            try
            {

                DataTable dt = bllMatrlMain.GetList_RZPCD(txt_Size.Text.Trim()).Tables[0];

                gc_Slab.DataSource = dt;
                gv_Slab.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Slab);
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
                gc_StdMain.DataSource = null;
                DataTable dt = bllMatrlMain.GetList_DFPCD(txt_CD.Text.Trim()).Tables[0];

                gc_StdMain.DataSource = dt;
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
                BindSlabMatchList();
                BindSlabList();
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

                    Mod_TB_MATRL_CONTRAST model = new Mod_TB_MATRL_CONTRAST();
                    model.C_SLAB_SIZE = dr_StdMain["C_SLAB_SIZE"].ToString();
                    model.N_SLAB_LENTH = Convert.ToDecimal(dr_StdMain["N_LTH"]);
                    model.C_KP_SIZE = dr["C_SLAB_SIZE"].ToString();
                    model.N_KP_LENTH = Convert.ToDecimal(dr["N_LTH"]);
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    #region 检测是否重复添加    
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_SLAB_SIZE", model.C_SLAB_SIZE);
                    ht.Add("N_SLAB_LENTH", model.N_SLAB_LENTH);
                    ht.Add("C_KP_SIZE", model.C_KP_SIZE);
                    ht.Add("N_KP_LENTH", model.N_KP_LENTH);
                    if (Common.CheckRepeat.CheckTable("TB_MATRL_CONTRAST", ht) > 0)
                    {
                        MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    #endregion
                    bllMatrlContrast.Add(model);

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钢坯对照关系信息");//添加操作日志

                }
                BindSlabMatchList();
                BindSlabList();

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
            int[] rownumber = gv_SlabMatch.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length == 0)
            {
                MessageBox.Show("请选择需要删除的信息！");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    for (int si = 0; si < rownumber.Length; si++)
                    {
                        DataRow dr = gv_SlabMatch.GetDataRow(rownumber[si]);

                        bllMatrlContrast.Delete(dr["C_ID"].ToString());
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "删除钢坯对照关系信息");//添加操作日志
                    }
                    BindSlabMatchList();
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
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QueryRight_Click(object sender, EventArgs e)
        {
            BindSlabList();
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


                if (gv_SlabMatch.DataRowCount > 0)
                {
                    DataRow dr_StdMain = gv_StdMain.GetDataRow(gv_StdMain.FocusedRowHandle);
                    Mod_TB_MATRL_CONTRAST model = new Mod_TB_MATRL_CONTRAST();

                    for (int i = 0; i < gv_SlabMatch.DataRowCount; i++)
                    {

                        model = bllMatrlContrast.GetModel(gv_SlabMatch.GetRowCellValue(i, "C_ID").ToString());
                        model.C_REMARK1 = gv_SlabMatch.GetRowCellValue(i, "C_REMARK1").ToString();

                        bllMatrlContrast.Update(model);
                    }
                    BindSlabMatchList();
                    MessageBox.Show("保存成功");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
