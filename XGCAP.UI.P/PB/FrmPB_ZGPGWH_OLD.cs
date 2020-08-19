using BLL;
using Common;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_ZGPGWH_OLD : Form
    {
        string strQueryString = "";
        string strStaID = "";
        Bll_TB_STA bll_Sta = new Bll_TB_STA();
        public FrmPB_ZGPGWH_OLD()
        {
            InitializeComponent();

            strQueryString = RV.UI.QueryString.parameter;
            strStaID = bll_Sta.GetStaIdByCode(strQueryString);


        }
        Bll_TPB_STA_HOOK_NO bll_TPB_STA_HOOK_NO = new Bll_TPB_STA_HOOK_NO();
        CommonSub sub = new CommonSub();

        private string strMenuName;


        private void FrmPB_ZGPGWH_Load(object sender, EventArgs e)
        {
            try
            {
                strMenuName = RV.UI.UserInfo.menuName;

                //cbo_GW1.EditValue = "";
                //cbo_GW2.EditValue = "";
                //sub.ImageComboBoxEditBindGWByGX("轧线", cbo_GW1);
                //sub.ImageComboBoxEditBindGWByGX("轧线", cbo_GW2); 
                //cbo_GW2.SelectedIndex = 0;
                Query();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                Query();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }
        private void btn_SaveDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbl_ID.Text.Trim()=="")//新增
                {

                }
                else//编辑
                {

                    if (DialogResult.No == MessageBox.Show("是否确认编辑第"+ txt_XH.Text + "号钩信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        return;
                    }


                    if (cbo_PGH.Text == "")
                    {
                        MessageBox.Show("请输入排钩号！");
                        this.cbo_PGH.Focus();
                        return;
                    }
                    Mod_TPB_STA_HOOK_NO model = bll_TPB_STA_HOOK_NO.GetModel(lbl_ID.Text);
                    model.C_HOOK_NAME = cbo_PGH.Text;
                    model.C_EMP_ID = RV.UI.UserInfo.userID;

                    int xh = Convert.ToInt32(model.N_NO);
                    try
                    {
                        if (bll_TPB_STA_HOOK_NO.Update(model))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "编辑"+strQueryString+"排钩信息");//添加操作日志

                            MessageBox.Show("保存成功！");
                            Query();//重新加载仓库信息
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("保存失败，钩号重复！");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearPanelControl(panelControl1.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
        }

        /// <summary>
        /// 查询
        /// </summary>
        private void Query()
        {
            DataTable dt = null;
            string cx = strStaID;
            dt = bll_TPB_STA_HOOK_NO.GetListBySTA(cx,"","").Tables[0];
            this.gc_CXPG.DataSource = dt;
            this.vGridControl1.DataSource = dt;
            DataTable dtno = bll_TPB_STA_HOOK_NO.GetFreeNO(strStaID);
            if (dtno.Rows.Count>0)
            {
                this.cbo_PGH.Text = "";
                this.cbo_PGH.Properties.Items.Clear();
                for (int i = 0; i < dtno.Rows.Count; i++)
                {
                    this.cbo_PGH.Properties.Items.Add(dtno.Rows[i]["N_NO"].ToString());
                }
            }
            else
            {
                this.cbo_PGH.Text = "";
                this.cbo_PGH.Properties.Items.Clear();
            }
            this.gv_CXPG.OptionsView.ColumnAutoWidth = false;
            this.colC_STA_ID.ColumnEdit =sub.GetGWIdDescItemComboBox();
            this.gv_CXPG.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_CXPG);
        }

        private void gv_CXPG_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_CXPG.GetDataRow(gv_CXPG.FocusedRowHandle);
                if (dr != null)
                {
                   
                    txt_XH.Text = dr["N_NO"].ToString();
                   // cbo_PGH.Text = dr["C_HOOK_NAME"].ToString();
                    lbl_ID.Text = dr["C_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
           
        }

        private void btn_pg_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (this.lbl_ID.Text.Trim().ToString() == "")
                {
                    MessageBox.Show("未选中行！");
                    return;
                }
                Mod_TPB_STA_HOOK_NO model = bll_TPB_STA_HOOK_NO.GetModel(lbl_ID.Text);
                model.C_REMARK ="跑号";
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                if (DialogResult.No == MessageBox.Show("是否确认钩号 "+ model .C_HOOK_NAME+ " 跑号？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                try
                {
                    if (bll_TPB_STA_HOOK_NO.Update(model))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加"+strQueryString+"排钩跑号信息");//添加操作日志
                        MessageBox.Show("保存成功！");
                        Query();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("保存失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancleph_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.lbl_ID.Text.Trim().ToString() == "")
                {
                    MessageBox.Show("未选中行！");
                    return;
                }
                Mod_TPB_STA_HOOK_NO model = bll_TPB_STA_HOOK_NO.GetModel(lbl_ID.Text);
                if (model.C_REMARK!= "跑号")
                {
                    MessageBox.Show("当前选中钩没有记录跑号！");
                    return;
                }
                model.C_REMARK = "";
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                if (DialogResult.No == MessageBox.Show("是否确认取消钩号 " + model.C_HOOK_NAME + " 跑号？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                try
                {
                    if (bll_TPB_STA_HOOK_NO.Update(model))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "取消轧线排钩跑号信息");//添加操作日志
                        MessageBox.Show("保存成功！");
                        Query();//重新加载仓库信息
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("保存失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_jx_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.lbl_ID.Text.Trim().ToString() == "")
                {
                    MessageBox.Show("未选中行！");
                    return;
                }
                Mod_TPB_STA_HOOK_NO model = bll_TPB_STA_HOOK_NO.GetModel(lbl_ID.Text);
                model.C_REMARK = "检修";
                model.C_HOOK_NAME = "";
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                if (DialogResult.No == MessageBox.Show("是否确认第 " + model.N_NO.ToString() + " 序号钩检修？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                try
                {
                    if (bll_TPB_STA_HOOK_NO.Update(model))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加"+strQueryString+"排钩检修信息");//添加操作日志
                        MessageBox.Show("保存成功！");
                        Query();//重新加载仓库信息
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("保存失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_jxwc_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.lbl_ID.Text.Trim().ToString() == "")
                {
                    MessageBox.Show("未选中行！");
                    return;
                }
                Mod_TPB_STA_HOOK_NO model = bll_TPB_STA_HOOK_NO.GetModel(lbl_ID.Text);
                if (model.C_REMARK!="检修")
                {
                    MessageBox.Show("该序号没有检修！");
                    return;
                }
                if (this.cbo_PGH.Text.Trim().ToString() == "")
                {
                    MessageBox.Show("检修完成后请选择钩号信息！");
                    return;
                }
                model.C_REMARK = "";
                model.C_HOOK_NAME = this.cbo_PGH.Text;
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                if (DialogResult.No == MessageBox.Show("是否确认第 " + model.N_NO.ToString() + " 序号钩检修完成？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                try
                {
                    if (bll_TPB_STA_HOOK_NO.Update(model))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加" + strQueryString + "排钩检修完成信息");//添加操作日志
                        MessageBox.Show("保存成功！");
                        Query();//重新加载仓库信息
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("保存失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_xg_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.lbl_ID.Text.Trim().ToString() == "")
                {
                    MessageBox.Show("未选中行！");
                    return;
                }
                Mod_TPB_STA_HOOK_NO model = bll_TPB_STA_HOOK_NO.GetModel(lbl_ID.Text);
                model.C_REMARK = "";
                model.C_HOOK_NAME = "";
                model.C_EMP_ID = RV.UI.UserInfo.userID;
                if (DialogResult.No == MessageBox.Show("是否确认第 " + model.N_NO.ToString() + " 序号钩下钩？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    return;
                }
                try
                {
                    if (bll_TPB_STA_HOOK_NO.Update(model))
                    {
                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加" + strQueryString + "排钩下钩信息");//添加操作日志
                        MessageBox.Show("保存成功！");
                        Query();//重新加载仓库信息
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("保存失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
