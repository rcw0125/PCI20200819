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
using BLL;
namespace XGCAP.UI.P.PO.APS
{
    public partial class FrmPO_APS_Addjc : Form
    {
        public FrmPO_APS_Addjc()
        {
            InitializeComponent();
        }
        Bll_TSP_PLAN_SMS bll_Plan_SMS = new Bll_TSP_PLAN_SMS();
        Bll_TSP_CAST_PLAN bll_cast_plan = new Bll_TSP_CAST_PLAN();
        Bll_TB_MATRL_MAIN bll_matrl = new Bll_TB_MATRL_MAIN();
        Bll_TPB_ENDTOEND_GRD bll_endtoend = new Bll_TPB_ENDTOEND_GRD();
        private Bll_TQB_COPING bll_xm = new Bll_TQB_COPING();//修磨要求
        private Bll_TQB_ROUTE bll_gylx = new Bll_TQB_ROUTE();//工艺路线
        string str_ID = "";
        /// <summary>
        /// 初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPO_APS_Addjc_Load(object sender, EventArgs e)
        {
            CommonSub.BindIcboNoAll("", "CC", icbo_lz3);
        }
        /// <summary>
        /// 选择钢种执行标准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_STL_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmPO_APS_Select_WL frm = new FrmPO_APS_Select_WL();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnEdit_STL.Text = frm.strSTL;
                    txt_STD.Text = frm.strSTD;
                    txt_WLMC.Text = frm.strWLMS;
                    txt_ZYX1.Text = frm.strZYX1;
                    txt_ZYX2.Text = frm.strZYX2;
                    txt_DM.Text = frm.strDM;
                    txt_DC.Text = frm.strCD;
                    txt_GYLX.Text = frm.strGYLX;
                    str_ID = frm.str_ID;
                    frm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Seave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btnEdit_STL.Text.Trim()))
            {
                MessageBox.Show("请选择钢种！");
                return;
            }
            if (string.IsNullOrEmpty(icbo_lz3.Text.Trim()))
            {
                MessageBox.Show("请选择连铸！");
                return;
            }
            try
            {

                Mod_TSP_CAST_PLAN mod = new Mod_TSP_CAST_PLAN();
                DataTable dt_Max = bll_cast_plan.GetList_Max(icbo_lz3.EditValue.ToString()).Tables[0];
                Mod_TB_MATRL_MAIN mod_matrl = bll_matrl.GetModel(str_ID);
                mod.C_CCM_ID = icbo_lz3.EditValue.ToString();
                mod.C_CCM_CODE = icbo_lz3.Text.Trim();
                int group_max = 0;
                int sort_max = 0;
                if (dt_Max.Rows[0]["GROUP_MAX"].ToString() == "")
                {
                    group_max = 1; 
                }
                else
                {
                    group_max = (Convert.ToInt32(dt_Max.Rows[0]["GROUP_MAX"].ToString()) + 1);
                }
                if (dt_Max.Rows[0]["SORT_MAX"].ToString() == "")
                { 
                    sort_max = 1;
                }
                else
                {
                    
                    sort_max = (Convert.ToInt32(dt_Max.Rows[0]["SORT_MAX"].ToString()) + 1);
                }
                mod.C_ID = System.Guid.NewGuid().ToString();
                mod.N_GROUP = group_max; 
                mod.N_TOTAL_WGT = Convert.ToInt32(txt_ZJCLS.Text.Trim());
                mod.N_ZJCLS = Convert.ToInt32(txt_ZJCLS.Text.Trim());
                mod.N_ZJCLZL = Convert.ToInt32(txt_ZJCLS.Text.Trim()) * 77;
                mod.N_MLZL = 77;
                mod.N_SORT = sort_max;
                mod.C_STL_GRD = btnEdit_STL.Text.Trim();
                mod.N_JSCN = 144;
                DataTable dt_SWL = bll_endtoend.GetSWLSteel(btnEdit_STL.Text.Trim(), txt_STD.Text.Trim(), "");
                if (dt_SWL.Rows.Count != 0)
                {
                    mod.C_BY1 = dt_SWL.Rows[0]["C_B_E_STOVE_STEEL"].ToString() + "`" + dt_SWL.Rows[0]["C_BORDER_STD_CODE"].ToString();
                }
                mod.C_BY2 = "";
                mod.C_BY3 ="";
                mod.C_STD_CODE = txt_STD.Text.Trim();
                if (icbo_lz3.Text=="5#铸机" || icbo_lz3.Text=="7#铸机")
                {
                    mod.C_SLAB_TYPE = "大方坯";
                }
                else
                {
                    mod.C_SLAB_TYPE = "小方坯";
                }

                mod.C_STL_GRD_TYPE = mod_matrl.C_PROD_KIND;
                mod.C_PROD_NAME = mod_matrl.C_PROD_NAME;
                mod.C_REMARK = btnEdit_STL.Text.Trim() + "`" + txt_STD.Text.Trim(); 

                DataTable dtgylx = bll_gylx.GetGYLX(mod.C_STL_GRD, mod.C_STD_CODE,"");
                if (dtgylx.Rows.Count > 0)
                { 
                    if (dtgylx.Rows[0]["C_ROUTE_DESC"].ToString().Contains("RH"))
                    {
                        mod.C_RH = "Y";
                    }
                    else
                    {
                        mod.C_RH = "N";
                    }

                    if (dtgylx.Rows[0]["C_ROUTE_DESC"].ToString().Contains("XM"))
                    {
                        mod.C_XM = "Y";
                    }
                    else
                    {
                        mod.C_XM = "N";
                    }
                    if (dtgylx.Rows[0]["C_ROUTE_DESC"].ToString().Contains("DHL"))
                    {
                        mod.C_DFP_HL = "Y";
                    }
                    else
                    {
                        mod.C_DFP_HL = "N";
                    }
                    if (dtgylx.Rows[0]["C_ROUTE_DESC"].ToString().Contains("HL"))
                    {
                        mod.C_HL = "Y";
                    }
                    else
                    {
                        mod.C_HL = "N";
                    }
                    if (dtgylx.Rows[0]["C_ROUTE_DESC"].ToString().Contains("TL"))
                    {
                        mod.C_TL = "Y";
                    }
                    else
                    {
                        mod.C_TL = "N";
                    }
                }
                if (bll_cast_plan.Add(mod))
                { 
                    
                    for (int l = 0; l < Convert.ToInt32(txt_ZJCLS.Text.Trim()); l++)
                    {
                        Mod_TSP_PLAN_SMS mod_add_lc2 = new Mod_TSP_PLAN_SMS(); 
                        mod_add_lc2.C_ID = System.Guid.NewGuid().ToString();
                        mod_add_lc2.C_FK = mod.C_ID;
                        mod_add_lc2.N_SORT = l;
                        mod_add_lc2.C_STATE = "1";
                        mod_add_lc2.C_STL_GRD = mod.C_STL_GRD;
                        mod_add_lc2.C_STD_CODE = mod.C_STD_CODE;
                        mod_add_lc2.C_CCM_ID = mod.C_CCM_ID;
                        mod_add_lc2.C_CCM_DESC = mod.C_CCM_CODE;
                        mod_add_lc2.N_SLAB_WGT = mod.N_MLZL;
                        mod_add_lc2.C_SLAB_SIZE = mod_matrl.C_SLAB_SIZE;
                        mod_add_lc2.C_SLAB_LENGTH = mod_matrl.N_LTH.ToString();
                        mod_add_lc2.N_JC_SORT = mod.N_SORT;
                        mod_add_lc2.C_BY1 = mod.C_BY1;
                        mod_add_lc2.C_ROUTE = txt_GYLX.Text.Trim();
                        mod_add_lc2.C_FREE1 = txt_ZYX1.Text.Trim();
                        mod_add_lc2.C_FREE2 = txt_ZYX2.Text.Trim();
                        mod_add_lc2.C_RH = mod.C_RH;
                        mod_add_lc2.C_DFP_HL = mod.C_DFP_HL;
                        mod_add_lc2.C_HL = mod.C_HL;
                        mod_add_lc2.C_XM = mod.C_XM;
                        mod_add_lc2.C_TL = mod.C_TL;
                        mod_add_lc2.C_BY2 = "手动添加";
                        bll_Plan_SMS.Add(mod_add_lc2);
                    }
                }

                MessageBox.Show("添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
