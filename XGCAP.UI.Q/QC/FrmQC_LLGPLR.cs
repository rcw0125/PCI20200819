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
    public partial class FrmQC_LLGPLR : Form
    {
        public FrmQC_LLGPLR()
        {
            InitializeComponent();
        }
        Bll_TSC_SLAB_MAIN bll = new Bll_TSC_SLAB_MAIN();
        Bll_TSC_SLAB_WLGP_LOG bllWLGP_LOG = new Bll_TSC_SLAB_WLGP_LOG();
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bll.GetList_WLGP(dte_Begin.DateTime,dte_End.DateTime, txt_Stove1.Text.Trim(), txt_GZ.Text.Trim()).Tables[0];
                gc_GPGP.DataSource = dt;
                gv_GPGP.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_GPGP);
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
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {

                    DataRow dr = this.gv_GPGP.GetDataRow(this.gv_GPGP.FocusedRowHandle);
                    if (dr == null)
                    {
                        MessageBox.Show("请选择需要删除的信息！");
                        return;
                    }
                    if (dr["C_MOVE_TYPE"].ToString() == "E" || dr["C_MOVE_TYPE"].ToString() == "M")
                    {
                         
                        if (bll.Delete(dr["C_ID"].ToString()))
                        {
                            Mod_TSC_SLAB_WLGP_LOG mod_LOG = new Mod_TSC_SLAB_WLGP_LOG();
                            mod_LOG.C_STOVE = dr["C_STOVE"].ToString();
                            mod_LOG.C_MAT_CODE = dr["C_MAT_CODE"].ToString();
                            mod_LOG.C_MAT_NAME = dr["C_MAT_NAME"].ToString();
                            mod_LOG.C_STL_GRD = dr["C_STL_GRD"].ToString();
                            mod_LOG.C_STD_CODE = dr["C_STD_CODE"].ToString();
                            mod_LOG.C_SPEC = dr["C_SPEC"].ToString();
                            mod_LOG.N_LEN = Convert.ToDecimal(dr["N_LEN"].ToString());
                            mod_LOG.N_WGT = Convert.ToDecimal(dr["N_WGT"].ToString());
                            mod_LOG.C_SLABWH_CODE = dr["C_SLABWH_CODE"].ToString();
                            mod_LOG.C_EMP_ID = RV.UI.UserInfo.UserID;
                            mod_LOG.C_REMARK = "删除";
                            bllWLGP_LOG.Add(mod_LOG);
                            MessageBox.Show("删除成功！");
                            NewMethod();
                        }
                    }
                    else
                    {
                        MessageBox.Show("钢坯已使用不能删除！");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
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
                FrmQC_LLGPLR_Add frm = new FrmQC_LLGPLR_Add();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    NewMethod();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmQC_LLGPLR_Load(object sender, EventArgs e)
        {
            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }
    }
}
