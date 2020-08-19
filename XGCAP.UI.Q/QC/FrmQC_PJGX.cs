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
    public partial class FrmQC_PJGX : Form
    {
        public FrmQC_PJGX()
        {
            InitializeComponent();
        }
        Bll_TRC_ROLL_PRODCUT bll_roll_product = new Bll_TRC_ROLL_PRODCUT();
        Bll_TQC_RATING_PROCESS bll_Rating = new Bll_TQC_RATING_PROCESS();
        Bll_TQC_RATING_PROCESS_ITEM bll_ratingItem = new Bll_TQC_RATING_PROCESS_ITEM();
        private string strMenuName;
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQC_PJGX_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);

            strMenuName = RV.UI.UserInfo.menuName;

            dte_Begin1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End1.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");
            dte_Begin.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 00:00:00");
            dte_End.EditValue = DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.ToString(" 23:59:59");

            DataSet dt = bll_Rating.GetList_Group("");
            imgcbo_PJGX.Properties.Items.Clear();
            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imgcbo_PJGX.Properties.Items.Add(item["C_NAME"].ToString(), item["C_NAME"], -1);
            }

        }

        /// <summary>
        /// 查询线材实绩信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Main_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bll_roll_product.GetList_PJGX(dte_Begin1.DateTime, dte_End1.DateTime, txt_BatchNo.Text.Trim()).Tables[0];

                gc_SJXX.DataSource = dt;
                gv_SJXX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_SJXX);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 评级项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgcbo_PJGX_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                DataSet dt = bll_Rating.GetList_Type(imgcbo_PJGX.Text.Trim());
                checkcbo_PJXM.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)
                {
                    checkcbo_PJXM.Properties.Items.Add(item["C_TYPE"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 评级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PJ_Click(object sender, EventArgs e)
        {
            string str = null;
            
            for (int s = 0; s < checkcbo_PJXM.Properties.Items.Count; s++)
            {
                if (checkcbo_PJXM.Properties.Items[s].CheckState == CheckState.Checked)
                {
                    str = str + checkcbo_PJXM.Properties.Items[s].Value.ToString() + ","; 
                }

            }
            if (str.Length == 0)
            {
                MessageBox.Show ("请选择评级项目！");
                return;

            }
            str= str.Substring(0, str.Length - 1); 

            int[] rownumber = gv_SJXX.GetSelectedRows();//获取选中行号数组；
            if (rownumber.Length == 0)
            {
                MessageBox.Show("请选择需要评级的信息！");
                return;
            }
            for (int i = 0; i < rownumber.Length; i++)
            {
                DataRow dr = gv_SJXX.GetDataRow(rownumber[i]);
                Mod_TQC_RATING_PROCESS_ITEM mod = new Mod_TQC_RATING_PROCESS_ITEM();
                mod.C_BATCH_NO = dr["C_BATCH_NO"].ToString();
                mod.C_STL_GRD = dr["C_STL_GRD"].ToString();
                mod.C_STD_CODE = dr["C_STD_CODE"].ToString();
                mod.C_LEVEL = imgcbo_DJ.Text.Trim();
                mod.C_NAME = imgcbo_PJGX.Text.Trim();
                mod.C_TYPE = str;
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                #region 检测是否重复添加    
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_NAME", mod.C_NAME); 
                ht.Add("C_BATCH_NO", mod.C_BATCH_NO); 
                ht.Add("C_BATCH_NO", mod.C_BATCH_NO); 
                ht.Add("C_BATCH_NO", mod.C_BATCH_NO); 
                ht.Add("C_BATCH_NO", mod.C_BATCH_NO); 
                ht.Add("C_STL_GRD", mod.C_STL_GRD); 
                ht.Add("C_STD_CODE", mod.C_STD_CODE); 
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQC_RATING_PROCESS_ITEM", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                bll_ratingItem.Add(mod);

            }
            MessageBox.Show("评级成功！");
            Query1();
        }
        /// <summary>
        /// 查询评级明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            Query1();
        }
        private void Query1()
        {
            try
            {
                WaitingFrom.ShowWait("");

                DataTable dt = bll_ratingItem.GetList_PJMX(dte_Begin.DateTime,dte_End.DateTime, txt_BatchNo1.Text.Trim()).Tables[0];

                gc_PJMX.DataSource = dt;
                gv_PJMX.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_PJMX);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
            {
                try
                {
                    Bll_Common bllCommon = new Bll_Common();

                    DataRow dr = gv_PJMX.GetDataRow(gv_PJMX.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bllCommon.DataDisabled("TQC_RATING_PROCESS_ITEM", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用评级信息");//添加操作日志
                            Query();
                            Query1();
                            MessageBox.Show("已成功停用！");
                        }
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
    }
}
