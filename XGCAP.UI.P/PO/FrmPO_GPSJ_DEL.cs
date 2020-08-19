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
using System.Collections;
using MODEL;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_GPSJ_DEL : Form
    {
        private string strMenuName;

        private Bll_TSC_SLAB_MAIN bllTscSlabMain = new Bll_TSC_SLAB_MAIN();
        private Bll_TQC_COMPRE_SLAB bllTqcCompreSlab = new Bll_TQC_COMPRE_SLAB();
        private Bll_TSC_SLAB_MES bllTscSlabMes = new Bll_TSC_SLAB_MES();
        private Bll_TSC_SLAB_MES_LOG bllTscSlabMesLog = new Bll_TSC_SLAB_MES_LOG();

        private DataTable dtSlab;

        public FrmPO_GPSJ_DEL()
        {
            InitializeComponent();
        }

        private void FrmPO_GPSJ_DEL_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strMenuName = RV.UI.UserInfo.menuName;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Stove.Text.Trim()))
            {
                MessageBox.Show("请输入要查询的炉号！");
                return;
            }

            BindSlab();
        }

        private void BindSlab()
        {
            try
            {
                WaitingFrom.ShowWait("");

                dtSlab = bllTscSlabMain.Get_List_ByStove(txt_Stove.Text.Trim()).Tables[0];

                gc_Slab.DataSource = dtSlab;
                SetGridViewRowNum.SetRowNum(gv_Slab);

                gv_Slab.OptionsSelection.MultiSelect = true;
                gv_Slab.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

                WaitingFrom.CloseWait();
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
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(dtSlab==null)
            {
                MessageBox.Show("请选择需要删除的炉号！");
                return;
            }

            if (dtSlab.Rows.Count > 1)
            {
                MessageBox.Show("该炉号不止一个钢种或物料，不能删除！");
                return;
            }

            if (string.IsNullOrEmpty(txt_Reason.Text.Trim()))
            {
                MessageBox.Show("请填写删除原因！");
                return;
            }

            DataRow dr = gv_Slab.GetDataRow(gv_Slab.FocusedRowHandle);
            if (dr != null)
            {
                string stove = dr["C_STOVE"].ToString();

                if (DialogResult.Yes == MessageBox.Show("确认删除炉号：" + stove + "吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    ArrayList SQLStringList = new ArrayList();

                    SQLStringList.Add("DELETE FROM TSC_SLAB_MES T WHERE T.MATERIALID='" + stove + "' ");
                    SQLStringList.Add("DELETE FROM TSC_SLAB_MAIN T WHERE T.C_STOVE='" + stove + "' ");
                    SQLStringList.Add("DELETE FROM tsc_slab_move T WHERE T.C_STOVE='" + stove + "' ");
                    SQLStringList.Add("DELETE FROM TQC_COMPRE_SLAB T WHERE T.C_STOVE='" + stove + "' ");
                    SQLStringList.Add("DELETE FROM TQC_COMPRE_ITEM_RESULT T WHERE T.C_STOVE='" + stove + "' AND T.C_BATCH_NO IS NULL ");

                    if (bllTscSlabMes.Del_Stove(SQLStringList))
                    {
                        Mod_TSC_SLAB_MES_LOG modLog = new Mod_TSC_SLAB_MES_LOG();
                        modLog.C_STA_DESC = dr["C_STA_DESC"].ToString();
                        modLog.C_STOVE = dr["C_STOVE"].ToString();
                        modLog.C_STL_GRD = dr["C_STL_GRD"].ToString();
                        modLog.C_STD_CODE = dr["C_STD_CODE"].ToString();
                        modLog.C_SPEC = dr["C_SPEC"].ToString();
                        modLog.C_LEN = dr["N_LEN"].ToString();
                        modLog.C_MAT_CODE = dr["C_MAT_CODE"].ToString();
                        modLog.C_MAT_NAME = dr["C_MAT_NAME"].ToString();
                        modLog.C_QUA = dr["N_QUA"].ToString();
                        modLog.C_WGT = dr["N_WGT"].ToString();
                        modLog.D_DEL_TIME = Convert.ToDateTime(RV.UI.ServerTime.timeNow());
                        modLog.C_DEL_USER = RV.UI.UserInfo.userID;
                        modLog.C_REASON = txt_Reason.Text.Trim();

                        bllTscSlabMesLog.Add(modLog);

                        MessageBox.Show("删除成功！");
                        BindSlab();
                    }
                }
            }
            else
            {
                MessageBox.Show("没有需要删除的数据！");
                return;
            }
        }

        /// <summary>
        /// 同步MES钢坯信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Tb_Click(object sender, EventArgs e)
        {
            string stove = txt_Stove.Text.Trim();

            if (stove.Length == 9)
            {
                if (DialogResult.Yes == MessageBox.Show("确认同步炉号：" + stove + "吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    WaitingFrom.ShowWait("正在同步数据，请稍等...");

                    bllTscSlabMain.TB_SLAB_SJ_STOVE(stove);//同步钢坯实绩
                    bllTscSlabMain.TB_SLAB_MAIN_STOVE(stove);//同步钢坯实绩到TSC_SLAB_MAIN

                    bllTqcCompreSlab.JUDGE_SLAB_STOVE(stove);//判定
                    bllTqcCompreSlab.TB_SLAB_STOVE(stove);//同步

                    MessageBox.Show("同步成功！");

                    WaitingFrom.CloseWait();
                }
            }
            else
            {
                MessageBox.Show("请输入正确的炉号！");
            }
        }
    }
}
