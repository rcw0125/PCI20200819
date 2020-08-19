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
    public partial class FrmQC_TBGPSJ : Form
    {
        private Bll_TSC_SLAB_MES bllSlabMes = new Bll_TSC_SLAB_MES();
        private Bll_TSC_SLAB_MAIN bllTscSlabMain = new Bll_TSC_SLAB_MAIN();

        private string strMenuName;

        public FrmQC_TBGPSJ()
        {
            InitializeComponent();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Stove.Text.Trim()))
            {
                MessageBox.Show("请输入要查询的炉号！");
                return;
            }

            BindSlab();
        }

        private void FrmQC_TBGPSJ_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strMenuName = RV.UI.UserInfo.menuName;
        }

        private void BindSlab()
        {
            try
            {
                WaitingFrom.ShowWait("");

                Mod_TSC_SLAB_MES model = bllSlabMes.GetModel(txt_Stove.Text.Trim());
                if (model != null)
                {
                    if (model.STATUS == 11 || model.STATUS == 14)
                    {
                        MessageBox.Show("该炉号已入库，不能重复同步！");
                        return;
                    }
                    else
                    {
                        DataTable dt = bllSlabMes.Get_List(txt_Stove.Text.Trim()).Tables[0];

                        gc_Slab.DataSource = dt;
                        SetGridViewRowNum.SetRowNum(gv_Slab);
                    }
                }
                else
                {
                    MessageBox.Show("没有找到对应的炉号信息！");
                    return;
                }

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 同步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Tb_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Slab.GetDataRow(gv_Slab.FocusedRowHandle);
            if (dr != null)
            {
                string stove = dr["MATERIALID"].ToString();

                if (DialogResult.Yes == MessageBox.Show("确认同步炉号：" + stove + "吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    WaitingFrom.ShowWait("正在同步数据，请稍等...");

                    bllTscSlabMain.TB_SLAB_SJ_STOVE(stove);//同步钢坯实绩
                    bllTscSlabMain.TB_SLAB_MAIN_STOVE(stove);//同步钢坯实绩到TSC_SLAB_MAIN

                    MessageBox.Show("同步成功！");

                    WaitingFrom.CloseWait();
                }
            }
            else
            {
                MessageBox.Show("没有需要同步的信息！");
                return;
            }
        }
    }
}
