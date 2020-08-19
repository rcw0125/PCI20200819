using Common;
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

namespace XGCAP.UI.Q.QC
{
    public partial class FrmQC_TPGP : Form
    {
        public FrmQC_TPGP()
        {
            InitializeComponent();
        }
        Bll_TSC_SLAB_MAIN bll_slab = new Bll_TSC_SLAB_MAIN();
        Bll_TQC_TP_SLAB_COMMUTE bllTPSlab = new Bll_TQC_TP_SLAB_COMMUTE();
        private string strMenuName;
        private string strPhyCode;
        private void FrmQC_TPGPSH_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            strPhyCode = RV.UI.QueryString.parameter;

            dte_Begin.EditValue = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = bllTPSlab.GetList_TPGP(dte_Begin.DateTime, dte_End.DateTime, txt_Stove1.Text.Trim()).Tables[0];
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
        /// 审核通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SHTG_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_GPYY.Text.Trim() == "")
                {
                    MessageBox.Show("请输入改判原因！");
                    return;
                }
                if (DialogResult.OK != MessageBox.Show("是否确认改判已选中的数据？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }
                DataRow dr = this.gv_GPGP.GetDataRow(this.gv_GPGP.FocusedRowHandle);
                if (dr == null) return;
                string stove = dr["炉号"].ToString();
                string strBatchNo = dr["开坯号"].ToString();
                string stlgrd = dr["改判前钢种"].ToString();
                string stdcode = dr["改判前标准"].ToString();
                string matID = dr["改判前物料编码"].ToString();
                string strZYX1 = dr["改判前自由项1"].ToString();
                string strZYX2 = dr["改判前自由项2"].ToString();
                string strSTD_GPH = dr["改判后标准"].ToString();
                string strMat_GPH = dr["改判后物料编码"].ToString();
                string strZYX1_GPH = dr["改判后自由项1"].ToString();
                string strZYX2_GPH = dr["改判后自由项2"].ToString();
                string strSlabCode = dr["仓库编码"].ToString();
                DataTable dt = bllTPSlab.GetList_TPGP_COU(stove, strBatchNo, stlgrd, stdcode, matID, strZYX1, strZYX2, strSlabCode, strMat_GPH, strSTD_GPH,strZYX1_GPH,strZYX2_GPH).Tables[0]; 
                string strs = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                { 
                    strs = strs + dt.Rows[i]["C_SLAB_MAIN_ID"].ToString() + ",";
                } 
                string strResult = bll_slab.GP_Slab(strs, dr["改判后钢种"].ToString(), dr["改判后标准"].ToString(), dr["改判后物料编码"].ToString(), dr["改判后物料描述"].ToString(), dr["责任单位代码"].ToString(), dr["责任单位描述"].ToString(), dr["改判后判定等级"].ToString(), "", Application.StartupPath, dr["改判后自由项1"].ToString(), dr["改判后自由项2"].ToString(), txt_GPYY.Text.Trim(), dr["改判后定尺"].ToString());
                if (strResult == "1")
                {
                    for (int s = 0; s < dt.Rows.Count; s++)
                    {
                        Mod_TQC_TP_SLAB_COMMUTE mod = bllTPSlab.GetModel(dt.Rows[s]["C_ID"].ToString());
                        mod.N_STATUS =2;
                        mod.C_COMMUTE_REASON = txt_GPYY.Text.Trim();
                        mod.C_REMARK1 = RV.UI.UserInfo.UserName;
                        mod.D_COMMUTE_DATE = RV.UI.ServerTime.timeNow();
                        bllTPSlab.Update(mod);
                        Mod_TSC_SLAB_MAIN mod_slab = bll_slab.GetModel(dt.Rows[s]["C_SLAB_MAIN_ID"].ToString());
                        mod_slab.C_MOVE_TYPE = dt.Rows[s]["C_REMARK2"].ToString();
                        bll_slab.Update(mod_slab);
                    }
                    btn_Query1_Click(null, null);
                    MessageBox.Show("改判成功！");
                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "钢坯挑坯改判");//添加操作日志
                }
                else
                {
                    MessageBox.Show(strResult);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         
    }
}
