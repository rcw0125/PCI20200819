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

namespace XGCAP.UI.P.PB
{
    public partial class FrmPB_GZSCTJWH : Form
    {
        private string strPhyCode = "";
        private string max_XLGZ = "";
        private string max_SWLGZ = "";
        private string max_SCGZ = "";
        private string max_TSTJ = "";
        private string max_GBTJ = "";

        private bool IsClick = false;

        public FrmPB_GZSCTJWH(string sys_id)
        {
            InitializeComponent();
            strPhyCode = sys_id;
        }
        Bll_TPB_STEEL_PRO_CONDITION bll_steel_pro = new Bll_TPB_STEEL_PRO_CONDITION();
        Bll_TPB_BORDER_GRD bll_border_grd = new Bll_TPB_BORDER_GRD();
        Bll_TPB_ENDTOEND_GRD bll_endtoend = new Bll_TPB_ENDTOEND_GRD();
        Bll_TPB_RINSE_GRD bll_rinse = new Bll_TPB_RINSE_GRD();
        Bll_TPB_CCM_CONTRAST bll_ccm_contrast = new Bll_TPB_CCM_CONTRAST();
        Bll_TPB_LADLE bll_ladle = new Bll_TPB_LADLE();
        Bll_TPB_SLAB_ALLOT bll_slab_allot = new Bll_TPB_SLAB_ALLOT();
        Bll_TQB_STD_MAIN bll_StdMain = new Bll_TQB_STD_MAIN();
        Bll_TQB_TSBZ_CF bll_tsbz = new Bll_TQB_TSBZ_CF();
        private string strMenuName;

        /// <summary>
        /// 页面初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPB_GZSCTJWH_Load(object sender, EventArgs e)
        {
            try
            {

                strMenuName = RV.UI.UserInfo.menuName;
                txt_ID.Visible = false;//隐藏文本框
                txt_ID1.Visible = false;
                txt_ID2.Visible = false;
                txt_ID3.Visible = false;
                txt_ID4.Visible = false;
                txt_ID5.Visible = false;

                txt_ID.Text = FrmPB_GZSCTJ.str_cid;
                if (txt_ID.Text != "")
                {
                    Mod_TPB_STEEL_PRO_CONDITION mod = bll_steel_pro.GetModel(txt_ID.Text);
                    txt_GZLB.Text = mod.C_STL_GRD_TYPE;
                    txt_GZJB.Text = mod.C_STL_GRD_RANK;
                    btnEdite_STlGRD.Text = mod.C_STL_GRD;
                    imgcbo_STD.Text = mod.C_STD_CODE;
                    txt_FGFL.Text = mod.C_STL_SCRAP_TYPE;
                    txt_FGFLBS.Text = mod.C_STL_SCRAP_FLIJ;
                    txt_GYYQ.Text = mod.C_GOUTE;
                    txt_GPYQ.Text = mod.C_ADV_PRO_REQUIRE;
                    txt_Remark.Text = mod.C_REMARK;
                    NewMethod(txt_ID.Text);//相邻钢种查询
                    NewMethod1(txt_ID.Text);//浇次首尾炉钢种查询
                    NewMethod2(txt_ID.Text);//涮槽钢种查询
                    NewMethod3(txt_ID.Text.Trim());//铁水条件查询
                    NewMethod4(txt_ID.Text);//钢包条件查询
                    NewMethod();//绑定执行标准下拉框



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        /// <summary>
        /// 钢包条件
        /// </summary>
        /// <param name="dr"></param>
        private void NewMethod4(string C_ID)
        {
            DataTable dt_ladle = bll_ladle.GetList_Query(C_ID).Tables[0];
            this.gc_TPB_LADLE.DataSource = dt_ladle;
            gv_TPB_LADLE.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_TPB_LADLE);
            NewMethod9();//钢包条件信息回传
        }

        /// <summary>
        /// 铁水条件
        /// </summary>
        /// <param name="dr"></param>
        private void NewMethod3(string C_ID)
        {
            DataTable dt_tstj = bll_tsbz.GetList_ProID(C_ID).Tables[0];
            this.gc_tqb_tstj_cf.DataSource = dt_tstj;
            gv_tqb_tstj_cf.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_tqb_tstj_cf);
            NewMethod8();//铁水条件信息回传
        }

        /// <summary>
        /// 刷槽钢种
        /// </summary>
        /// <param name="dr"></param>
        private void NewMethod2(string C_ID)
        {
            DataTable dt_max = bll_rinse.GetList_Max(C_ID).Tables[0];
            max_SCGZ = dt_max.Rows[0]["N_LEVEL"].ToString();
            DataTable dt_rinse = bll_rinse.GetList_Query(C_ID).Tables[0];
            this.gc_TPB_RINSE_GRD.DataSource = dt_rinse;
            gv_TPB_RINSE_GRD.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_TPB_RINSE_GRD);
            NewMethod7();//涮槽钢种信息回传 
        }

        /// <summary>
        /// 浇次首尾炉钢种
        /// </summary>
        /// <param name="dr"></param>
        private void NewMethod1(string C_ID)
        {
            DataTable dt_max = bll_endtoend.GetList_Max(C_ID).Tables[0];
            max_SWLGZ = dt_max.Rows[0]["N_LEVEL"].ToString();
            DataTable dt_endtoend = bll_endtoend.GetList_Query(C_ID).Tables[0];
            this.gc_TPB_ENDTOEND_GRD.DataSource = dt_endtoend;
            gv_TPB_ENDTOEND_GRD.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_TPB_ENDTOEND_GRD);
            NewMethod5();//浇次首尾炉钢种信息回传

        }
        /// <summary>
        ///相邻钢种查询
        /// </summary>
        /// <param name="dr"></param>
        private void NewMethod(string C_ID)
        {

            DataTable dt_max = bll_border_grd.GetList_Max(C_ID).Tables[0];
            max_XLGZ = dt_max.Rows[0]["N_LEVEL"].ToString();
            DataTable dt = bll_border_grd.GetList_Query(C_ID).Tables[0];
            this.gc_TPB_BORDER_GRD.DataSource = dt;
            gv_TPB_BORDER_GRD.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_TPB_BORDER_GRD);
            NewMethod6();//相邻钢种信息回传 
        }
        /// <summary>
        /// 钢种生产条件主表添加/修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_GZLB.Text.Trim()))
                {
                    MessageBox.Show("钢种类别不能为空！");
                    return;
                }
                //if (string.IsNullOrEmpty(txt_GZJB.Text.Trim()))
                //{
                //    MessageBox.Show("钢种级别不能为空！");
                //    return;
                //}
                if (string.IsNullOrEmpty(btnEdite_STlGRD.Text.Trim()))
                {
                    MessageBox.Show("计划钢种不能为空！");
                    return;
                }
                //if (string.IsNullOrEmpty(imgcbo_STD.Text.Trim()))
                //{
                //    MessageBox.Show("执行标准不能为空！");
                //    return;
                //}
                if (string.IsNullOrEmpty(txt_FGFL.Text.Trim()))
                {
                    MessageBox.Show("产生废钢分类不能为空！");
                    return;
                }
                //if (string.IsNullOrEmpty(txt_FGFLBS.Text.Trim()))
                //{
                //    MessageBox.Show("废钢分类标识不能为空！");
                //    return;
                //}
                if (DialogResult.OK != MessageBox.Show("是否确认保存已输入的数据？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }

                if (string.IsNullOrEmpty(txt_ID.Text))//添加
                {
                    Mod_TPB_STEEL_PRO_CONDITION mod = new Mod_TPB_STEEL_PRO_CONDITION();
                    string[] std;
                    if (imgcbo_STD.Text.Contains("Q/XG") || imgcbo_STD.Text.Contains("GB/T"))
                    {
                        if (imgcbo_STD.Text.Contains("."))
                        {
                            std = imgcbo_STD.Text.Trim().Split('.');
                            mod.C_STD_CODE = std[0];
                        }
                        else
                        {
                            std = imgcbo_STD.Text.Trim().Split('-');
                            mod.C_STD_CODE = std[0];
                        }
                    }
                    else
                    {
                        mod.C_STD_CODE = imgcbo_STD.Text.Trim();
                    }

                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_STD_CODE", mod.C_STD_CODE);
                    ht.Add("C_STL_GRD", btnEdite_STlGRD.Text.Trim());
                    ht.Add("N_STATUS", "1");
                    //ht.Add("C_ID", mod.C_ID);
                    if (Common.CheckRepeat.CheckTable("TPB_STEEL_PRO_CONDITION", ht) > 0)
                    {
                        MessageBox.Show("已存在重复的标准钢种,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    mod.C_ID = Guid.NewGuid().ToString();
                    mod.C_STL_GRD_TYPE = txt_GZLB.Text.Trim();
                    mod.C_STL_GRD_RANK = txt_GZJB.Text.Trim();
                    mod.C_STL_GRD = btnEdite_STlGRD.Text.Trim();
                    mod.C_STL_SCRAP_TYPE = txt_FGFL.Text.Trim();
                    mod.C_STL_SCRAP_FLIJ = txt_FGFLBS.Text.Trim();
                    mod.C_GOUTE = txt_GYYQ.Text.Trim();
                    mod.C_TEASE_PERSON = RV.UI.UserInfo.UserName;
                    mod.C_ADV_PRO_REQUIRE = txt_GPYQ.Text.Trim();
                    mod.C_REMARK = txt_Remark.Text.Trim();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.C_IS_BXG = strPhyCode;
                    bll_steel_pro.Add(mod);
                    MessageBox.Show("当前钢种生产条件已维护，\r\n请在当前产品维护结束后，\r\n到【可混浇维护】界面将其组号进行维护,\r\n否则生产订单排产仍然不能进行！");
                    txt_ID.Text = mod.C_ID;

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钢种生产条件");//添加操作日志
                }
                else
                {
                    Mod_TPB_STEEL_PRO_CONDITION mod = bll_steel_pro.GetModel(txt_ID.Text.Trim());
                    string[] std;
                    if (imgcbo_STD.Text.Contains("Q/XG") || imgcbo_STD.Text.Contains("GB/T"))
                    {
                        if (imgcbo_STD.Text.Contains("."))
                        {
                            std = imgcbo_STD.Text.Trim().Split('.');
                            mod.C_STD_CODE = std[0];
                        }
                        else
                        {
                            std = imgcbo_STD.Text.Trim().Split('-');
                            mod.C_STD_CODE = std[0];
                        }
                    }
                    else
                    {
                        mod.C_STD_CODE = imgcbo_STD.Text.Trim();
                    }

                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_STD_CODE", mod.C_STD_CODE);
                    ht.Add("C_STL_GRD", btnEdite_STlGRD.Text.Trim());
                    ht.Add("N_STATUS", "1");
                    ht.Add("C_ID", mod.C_ID);
                    if (Common.CheckRepeat.CheckTable("TPB_STEEL_PRO_CONDITION", ht) > 0)
                    {
                        MessageBox.Show("已存在重复的标准钢种,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    mod.C_STL_GRD_TYPE = txt_GZLB.Text.Trim();
                    mod.C_STL_GRD_RANK = txt_GZJB.Text.Trim();
                    mod.C_STL_GRD = btnEdite_STlGRD.Text.Trim();
                    mod.C_STL_SCRAP_TYPE = txt_FGFL.Text.Trim();
                    mod.C_STL_SCRAP_FLIJ = txt_FGFLBS.Text.Trim();
                    mod.C_GOUTE = txt_GYYQ.Text.Trim();
                    mod.C_TEASE_PERSON = RV.UI.UserInfo.UserName;
                    mod.C_ADV_PRO_REQUIRE = txt_GPYQ.Text.Trim();
                    mod.C_REMARK = txt_Remark.Text.Trim();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    mod.C_IS_BXG = strPhyCode;
                    mod.N_STATUS = 1;
                    bll_steel_pro.Update(mod);
                    MessageBox.Show("保存成功！");

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改钢种生产条件");//添加操作日志
                }

                IsClick = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 相邻钢种数据 回传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_TPB_BORDER_GRD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod6();
        }

        private void NewMethod6()
        {
            try
            {
                DataRow dr = this.gv_TPB_BORDER_GRD.GetDataRow(this.gv_TPB_BORDER_GRD.FocusedRowHandle);
                if (dr != null)
                {
                    Mod_TPB_BORDER_GRD mod_grd = bll_border_grd.GetModel(dr["C_ID"].ToString());
                    txt_ID1.Text = mod_grd.C_ID;
                    btnEdite_STlGRD1.Text = mod_grd.C_BORDER_STL_GRD;
                    imgcbo_STD1.Text = mod_grd.C_BORDER_STD_CODE;
                    txt_BPYQ.Text = mod_grd.C_SLAB_REQUIRE;
                    txt_Remark1.Text = mod_grd.C_REMARK;
                    NewMethod1();//绑定执行标准下拉框
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 相邻钢种 添加/保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ID.Text.Trim()))
                {
                    MessageBox.Show("未保存主信息！");
                    return;
                }
                if (!IsClick)
                {
                    MessageBox.Show("未保存主信息！");
                    return;
                }
                if (string.IsNullOrEmpty(btnEdite_STlGRD1.Text.Trim()))
                {
                    MessageBox.Show("相邻钢种不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(imgcbo_STD1.Text.Trim()))
                {
                    MessageBox.Show("执行标准不能为空！");
                    return;
                }

                if (txt_ID1.Text == "")//新增
                {
                    Mod_TPB_BORDER_GRD model = new Mod_TPB_BORDER_GRD();
                    model.C_BORDER_STL_GRD = btnEdite_STlGRD1.Text.Trim();
                    if (string.IsNullOrEmpty(max_XLGZ))
                    {
                        max_XLGZ = "1";
                    }
                    else
                    {
                        max_XLGZ = (Convert.ToInt32(max_XLGZ) + 1).ToString();
                    }
                    string[] std;
                    if (imgcbo_STD1.Text.Contains("Q/XG") || imgcbo_STD1.Text.Contains("GB/T"))
                    {
                        if (imgcbo_STD1.Text.Contains("."))
                        {
                            std = imgcbo_STD1.Text.Trim().Split('.');
                            model.C_BORDER_STD_CODE = std[0];
                        }
                        else
                        {
                            std = imgcbo_STD1.Text.Trim().Split('-');
                            model.C_BORDER_STD_CODE = std[0];
                        }
                    }
                    else
                    {
                        model.C_BORDER_STD_CODE = imgcbo_STD1.Text.Trim();
                    }

                    model.N_LEVEL = Convert.ToInt32(max_XLGZ);
                    model.C_PRO_CONDITION_ID = txt_ID.Text.Trim();
                    model.C_SLAB_REQUIRE = txt_BPYQ.Text.Trim();
                    model.C_REMARK = txt_Remark1.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    if (bll_border_grd.Add(model))
                    {
                        MessageBox.Show("保存成功！");
                        NewMethod(txt_ID.Text);//相邻钢种查询
                    }
                }
                else//修改
                {
                    Mod_TPB_BORDER_GRD model = bll_border_grd.GetModel(txt_ID1.Text);
                    string[] std;
                    if (imgcbo_STD1.Text.Contains("Q/XG") || imgcbo_STD1.Text.Contains("GB/T"))
                    {
                        if (imgcbo_STD1.Text.Contains("."))
                        {
                            std = imgcbo_STD1.Text.Trim().Split('.');
                            model.C_BORDER_STD_CODE = std[0];
                        }
                        else
                        {
                            std = imgcbo_STD1.Text.Trim().Split('-');
                            model.C_BORDER_STD_CODE = std[0];
                        }
                    }
                    else
                    {
                        model.C_BORDER_STD_CODE = imgcbo_STD1.Text.Trim();
                    }
                    model.C_BORDER_STL_GRD = btnEdite_STlGRD1.Text.Trim();
                    model.C_PRO_CONDITION_ID = txt_ID.Text.Trim();
                    model.C_SLAB_REQUIRE = txt_BPYQ.Text.Trim();
                    model.C_REMARK = txt_Remark1.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    if (bll_border_grd.Update(model))
                    {
                        MessageBox.Show("保存成功！");
                        NewMethod(txt_ID.Text);//相邻钢种查询
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 相邻钢种 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_TPB_BORDER_GRD.GetDataRow(this.gv_TPB_BORDER_GRD.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择需要删除的信息！");
                    return;
                }
                if (bll_border_grd.Delete(dr["C_ID"].ToString()))
                {
                    MessageBox.Show("删除成功！");
                    bll_border_grd.Update_Order(Convert.ToInt32(dr["N_LEVEL"]), txt_ID.Text);
                    NewMethod(txt_ID.Text);//相邻钢种查询
                    NewMethod6();
                    ClearContent.ClearFlowLayoutPanel(panelControl2.Controls);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 相邻钢种 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl2.Controls);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 浇次首尾炉钢种 添加/修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ID.Text.Trim()))
                {
                    MessageBox.Show("未保存主信息！");
                    return;
                }
                if (!IsClick)
                {
                    MessageBox.Show("未保存主信息！");
                    return;
                }
                if (string.IsNullOrEmpty(txt_SWL.Text.Trim()))
                {
                    MessageBox.Show("首尾炉不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(btnEdite_STlGRD2.Text.Trim()))
                {
                    MessageBox.Show("浇次首尾炉钢种不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(imgcbo_STD2.Text.Trim()))
                {
                    MessageBox.Show("执行标准不能为空！");
                    return;
                }

                if (txt_ID2.Text == "")//新增
                {
                    Mod_TPB_ENDTOEND_GRD model = new Mod_TPB_ENDTOEND_GRD();
                    model.C_B_E_STOVE = txt_SWL.Text.Trim();
                    if (string.IsNullOrEmpty(max_SWLGZ))
                    {
                        max_SWLGZ = "1";
                    }
                    else
                    {
                        max_SWLGZ = (Convert.ToInt32(max_SWLGZ) + 1).ToString();
                    }

                    string[] std;
                    if (imgcbo_STD2.Text.Contains("Q/XG") || imgcbo_STD2.Text.Contains("GB/T"))
                    {
                        if (imgcbo_STD2.Text.Contains("."))
                        {
                            std = imgcbo_STD2.Text.Trim().Split('.');
                            model.C_BORDER_STD_CODE = std[0];
                        }
                        else
                        {
                            std = imgcbo_STD2.Text.Trim().Split('-');
                            model.C_BORDER_STD_CODE = std[0];
                        }
                    }
                    else
                    {
                        model.C_BORDER_STD_CODE = imgcbo_STD2.Text.Trim();
                    }

                    model.N_LEVEL = Convert.ToInt32(max_SWLGZ);
                    model.C_PRO_CONDITION_ID = txt_ID.Text.Trim();
                    model.C_B_E_STOVE_STEEL = btnEdite_STlGRD2.Text.Trim();
                    model.C_REMARK = txt_Remark2.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    if (bll_endtoend.Add(model))
                    {
                        MessageBox.Show("保存成功！");
                        NewMethod1(txt_ID.Text);//浇次首尾炉钢种查询
                    }
                }
                else//修改
                {
                    Mod_TPB_ENDTOEND_GRD model = bll_endtoend.GetModel(txt_ID2.Text);

                    string[] std;
                    if (imgcbo_STD2.Text.Contains("Q/XG") || imgcbo_STD2.Text.Contains("GB/T"))
                    {
                        if (imgcbo_STD2.Text.Contains("."))
                        {
                            std = imgcbo_STD2.Text.Trim().Split('.');
                            model.C_BORDER_STD_CODE = std[0];
                        }
                        else
                        {
                            std = imgcbo_STD2.Text.Trim().Split('-');
                            model.C_BORDER_STD_CODE = std[0];
                        }
                    }
                    else
                    {
                        model.C_BORDER_STD_CODE = imgcbo_STD2.Text.Trim();
                    }

                    model.C_B_E_STOVE = txt_SWL.Text.Trim();
                    model.C_B_E_STOVE_STEEL = btnEdite_STlGRD2.Text.Trim();
                    model.C_REMARK = txt_Remark2.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    if (bll_endtoend.Update(model))
                    {
                        MessageBox.Show("保存成功！");
                        NewMethod1(txt_ID.Text);//浇次首尾炉钢种查询
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 浇次首尾炉钢种 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_TPB_ENDTOEND_GRD.GetDataRow(this.gv_TPB_ENDTOEND_GRD.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择需要删除的信息！");
                    return;
                }
                if (bll_endtoend.Delete(dr["C_ID"].ToString()))
                {
                    MessageBox.Show("删除成功！");
                    bll_endtoend.Update_Order(Convert.ToInt32(dr["N_LEVEL"]), txt_ID.Text);
                    NewMethod1(txt_ID.Text);//浇次首尾炉钢种查询
                    ClearContent.ClearFlowLayoutPanel(panelControl3.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 浇次首尾炉钢种 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest1_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl3.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 涮槽钢种 添加/修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ID.Text.Trim()))
                {
                    MessageBox.Show("未保存主信息！");
                    return;
                }
                if (!IsClick)
                {
                    MessageBox.Show("未保存主信息！");
                    return;
                }
                if (string.IsNullOrEmpty(btnEdite_STlGRD3.Text.Trim()))
                {
                    MessageBox.Show("涮槽钢种不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(imgcbo_STD3.Text.Trim()))
                {
                    MessageBox.Show("执行标准不能为空！");
                    return;
                }

                if (txt_ID3.Text == "")//新增
                {
                    Mod_TPB_RINSE_GRD model = new Mod_TPB_RINSE_GRD();
                    model.C_RINSE_GRD = btnEdite_STlGRD3.Text.Trim();
                    if (string.IsNullOrEmpty(max_SCGZ))
                    {
                        max_SCGZ = "1";
                    }
                    else
                    {
                        max_SCGZ = (Convert.ToInt32(max_SCGZ) + 1).ToString();
                    }

                    string[] std;
                    if (imgcbo_STD3.Text.Contains("Q/XG") || imgcbo_STD3.Text.Contains("GB/T"))
                    {
                        if (imgcbo_STD3.Text.Contains("."))
                        {
                            std = imgcbo_STD3.Text.Trim().Split('.');
                            model.C_RINSE_STD_CODE = std[0];
                        }
                        else
                        {
                            std = imgcbo_STD3.Text.Trim().Split('-');
                            model.C_RINSE_STD_CODE = std[0];
                        }
                    }
                    else
                    {
                        model.C_RINSE_STD_CODE = imgcbo_STD3.Text.Trim();
                    }

                    model.N_LEVEL = Convert.ToInt32(max_SCGZ);
                    model.C_PRO_CONDITION_ID = txt_ID.Text.Trim();
                    model.C_REMARK = txt_Remark3.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    if (bll_rinse.Add(model))
                    {
                        MessageBox.Show("保存成功！");
                        NewMethod2(txt_ID.Text);//涮槽钢种查询
                    }
                }
                else//修改
                {
                    Mod_TPB_RINSE_GRD model = bll_rinse.GetModel(txt_ID3.Text);
                    string[] std;
                    if (imgcbo_STD3.Text.Contains("Q/XG") || imgcbo_STD3.Text.Contains("GB/T"))
                    {
                        if (imgcbo_STD3.Text.Contains("."))
                        {
                            std = imgcbo_STD3.Text.Trim().Split('.');
                            model.C_RINSE_STD_CODE = std[0];
                        }
                        else
                        {
                            std = imgcbo_STD3.Text.Trim().Split('-');
                            model.C_RINSE_STD_CODE = std[0];
                        }
                    }
                    else
                    {
                        model.C_RINSE_STD_CODE = imgcbo_STD3.Text.Trim();
                    }

                    model.C_RINSE_GRD = btnEdite_STlGRD3.Text.Trim();
                    model.C_REMARK = txt_Remark3.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    if (bll_rinse.Update(model))
                    {
                        MessageBox.Show("保存成功！");
                        NewMethod2(txt_ID.Text);//涮槽钢种查询
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 涮槽钢种 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del3_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_TPB_RINSE_GRD.GetDataRow(this.gv_TPB_RINSE_GRD.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择需要删除的信息！");
                    return;
                }
                if (bll_rinse.Delete(dr["C_ID"].ToString()))
                {
                    MessageBox.Show("删除成功！");
                    bll_rinse.Update_Order(Convert.ToInt32(dr["N_LEVEL"]), txt_ID.Text);
                    NewMethod2(txt_ID.Text);//涮槽钢种查询
                    gv_TPB_RINSE_GRD_FocusedRowChanged(null, null);
                    ClearContent.ClearFlowLayoutPanel(panelControl4.Controls);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 涮槽钢种 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest3_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl4.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 铁水条件 添加/修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ID.Text.Trim()))
                {
                    MessageBox.Show("未保存主信息！");
                    return;
                }
                if (!IsClick)
                {
                    MessageBox.Show("未保存主信息！");
                    return;
                }
                if (string.IsNullOrEmpty(txt_CFMC.Text.Trim()))
                {
                    MessageBox.Show("成分名称不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(txt_MBZ.Text.Trim()))
                {
                    MessageBox.Show("目标值不能为空！");
                    return;
                }

                if (txt_ID4.Text == "")//新增
                {
                    Mod_TQB_TSBZ_CF model = new Mod_TQB_TSBZ_CF();
                    model.C_NAME = txt_CFMC.Text.Trim();
                    model.N_TARGET_VALUE = Convert.ToDecimal(txt_MBZ.Text.Trim());
                    model.C_STD_CODE = imgcbo_STD.Text.Trim();
                    model.C_STL_GRD = btnEdite_STlGRD.Text.Trim();
                    model.C_REMARK = txt_Remark4.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.C_PRO_CONDITION_ID = txt_ID.Text.Trim();
                    if (bll_tsbz.Add(model))
                    {
                        MessageBox.Show("保存成功！");
                        NewMethod3(txt_ID.Text.Trim());//铁水条件查询
                    }
                }
                else//修改
                {
                    Mod_TQB_TSBZ_CF model = bll_tsbz.GetModel(txt_ID4.Text);
                    model.C_NAME = txt_CFMC.Text.Trim();
                    model.N_TARGET_VALUE = Convert.ToDecimal(txt_MBZ.Text.Trim());
                    model.C_STD_CODE = imgcbo_STD.Text.Trim();
                    model.C_STL_GRD = btnEdite_STlGRD.Text.Trim();
                    model.C_REMARK = txt_Remark4.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    if (bll_tsbz.Update(model))
                    {
                        MessageBox.Show("保存成功！");
                        NewMethod3(txt_ID.Text.Trim());//铁水条件查询
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 生产铸机 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del4_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_tqb_tstj_cf.GetDataRow(this.gv_tqb_tstj_cf.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择需要删除的数据！");
                }
                if (bll_tsbz.Delete(dr["C_ID"].ToString()))
                {
                    MessageBox.Show("删除成功！");
                    NewMethod3(txt_ID.Text.Trim());//生产铸机查询
                    gv_TPB_CCM_CONTRAST_FocusedRowChanged(null, null);
                    ClearContent.ClearFlowLayoutPanel(panelControl5.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 生产铸机 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest4_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl5.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 钢包条件 添加/修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save5_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ID.Text.Trim()))
                {
                    MessageBox.Show("未保存主信息！");
                    return;
                }
                if (!IsClick)
                {
                    MessageBox.Show("未保存主信息！");
                    return;
                }

                if (string.IsNullOrEmpty(txt_GBYQ.Text.Trim()))
                {
                    MessageBox.Show("钢包生产要求条件不能为空！");
                    return;
                }

                if (txt_ID5.Text == "")//新增
                {
                    Mod_TPB_LADLE model = new Mod_TPB_LADLE();

                    model.C_LADLE = txt_GBYQ.Text.Trim();
                    model.C_PRO_CONDITION_ID = txt_ID.Text.Trim();
                    model.C_REMARK = txt_Remark5.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    if (bll_ladle.Add(model))
                    {
                        MessageBox.Show("保存成功！");
                        NewMethod4(txt_ID.Text);//钢包条件查询
                    }
                }
                else//修改
                {
                    Mod_TPB_LADLE model = bll_ladle.GetModel(txt_ID5.Text);
                    model.C_LADLE = txt_GBYQ.Text.Trim();
                    model.C_PRO_CONDITION_ID = txt_ID.Text.Trim();
                    model.C_REMARK = txt_Remark5.Text.Trim();
                    model.C_EMP_ID = RV.UI.UserInfo.userID;
                    model.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    if (bll_ladle.Update(model))
                    {
                        MessageBox.Show("保存成功！");
                        NewMethod4(txt_ID.Text);//钢包条件查询
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 钢包条件 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Det5_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_TPB_LADLE.GetDataRow(this.gv_TPB_LADLE.FocusedRowHandle);
                if (dr == null)
                {
                    MessageBox.Show("请选择需要删除的信息！");
                    return;
                }
                if (bll_ladle.Delete(dr["C_ID"].ToString()))
                {
                    MessageBox.Show("删除成功！");
                    NewMethod4(txt_ID.Text);//钢包条件查询
                    gv_TPB_LADLE_FocusedRowChanged(null, null);
                    ClearContent.ClearFlowLayoutPanel(panelControl6.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 钢包条件 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rest5_Click(object sender, EventArgs e)
        {
            try
            {
                ClearContent.ClearFlowLayoutPanel(panelControl6.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        /// <summary>
        /// 浇次首尾炉钢种 回传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_TPB_ENDTOEND_GRD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod5();

        }

        private void NewMethod5()
        {
            try
            {
                DataRow dr = this.gv_TPB_ENDTOEND_GRD.GetDataRow(this.gv_TPB_ENDTOEND_GRD.FocusedRowHandle);
                if (dr != null)
                {
                    Mod_TPB_ENDTOEND_GRD model = bll_endtoend.GetModel(dr["C_ID"].ToString());
                    txt_ID2.Text = model.C_ID;
                    txt_SWL.Text = model.C_B_E_STOVE;
                    imgcbo_STD2.Text = model.C_BORDER_STD_CODE;
                    btnEdite_STlGRD2.Text = model.C_B_E_STOVE_STEEL;
                    txt_Remark2.Text = model.C_REMARK;
                    NewMethod2();//绑定执行标准下拉框
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 涮槽钢种 回传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_TPB_RINSE_GRD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod7();

        }

        private void NewMethod7()
        {
            try
            {
                DataRow dr = this.gv_TPB_RINSE_GRD.GetDataRow(this.gv_TPB_RINSE_GRD.FocusedRowHandle);
                if (dr != null)
                {
                    Mod_TPB_RINSE_GRD model = bll_rinse.GetModel(dr["C_ID"].ToString());
                    txt_ID3.Text = model.C_ID;
                    btnEdite_STlGRD3.Text = model.C_RINSE_GRD;
                    imgcbo_STD3.Text = model.C_RINSE_STD_CODE;
                    txt_Remark3.Text = model.C_REMARK;

                    NewMethod3();//绑定执行标准下拉框
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 生产铸机 回传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_TPB_CCM_CONTRAST_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod8();

        }

        private void NewMethod8()
        {
            try
            {
                DataRow dr = this.gv_tqb_tstj_cf.GetDataRow(this.gv_tqb_tstj_cf.FocusedRowHandle);
                if (dr != null)
                {
                    Mod_TQB_TSBZ_CF model = bll_tsbz.GetModel(dr["C_ID"].ToString());
                    txt_ID4.Text = model.C_ID;
                    txt_CFMC.Text = model.C_NAME;
                    txt_MBZ.Text = model.N_TARGET_VALUE.ToString();
                    txt_Remark4.Text = model.C_REMARK;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 钢包条件 回传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_TPB_LADLE_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            NewMethod9();

        }

        private void NewMethod9()
        {
            try
            {
                DataRow dr = this.gv_TPB_LADLE.GetDataRow(this.gv_TPB_LADLE.FocusedRowHandle);
                if (dr != null)
                {
                    Mod_TPB_LADLE model = bll_ladle.GetModel(dr["C_ID"].ToString());
                    txt_ID5.Text = model.C_ID;
                    txt_GBYQ.Text = model.C_LADLE;
                    txt_Remark5.Text = model.C_REMARK;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 选择钢种
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdite_STlGRD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmPB_SELECT_GZ frm = new FrmPB_SELECT_GZ(strPhyCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnEdite_STlGRD.Text = frm.str_c_grd;

                    frm.Close();
                    NewMethod();//绑定执行标准下拉框
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 绑定执行标准下拉框
        /// </summary>
        private void NewMethod()
        {
            DataSet dt = bll_StdMain.GetList_Std(strPhyCode, btnEdite_STlGRD.Text);

            imgcbo_STD.Properties.Items.Clear();

            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imgcbo_STD.Properties.Items.Add(item["C_STD_CODE"].ToString(), item["C_STD_CODE"], -1);

            }
        }
        /// <summary>
        /// 绑定执行标准下拉框
        /// </summary>
        private void NewMethod1()
        {
            DataSet dt = bll_StdMain.GetList_Std(strPhyCode, btnEdite_STlGRD1.Text);
            imgcbo_STD1.Properties.Items.Clear();

            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imgcbo_STD1.Properties.Items.Add(item["C_STD_CODE"].ToString(), item["C_STD_CODE"], -1);
            }
            imgcbo_STD1.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定执行标准下拉框
        /// </summary>
        private void NewMethod2()
        {
            DataSet dt = bll_StdMain.GetList_Std(strPhyCode, btnEdite_STlGRD2.Text);

            imgcbo_STD2.Properties.Items.Clear();

            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imgcbo_STD2.Properties.Items.Add(item["C_STD_CODE"].ToString(), item["C_STD_CODE"], -1);

            }
            imgcbo_STD2.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定执行标准下拉框
        /// </summary>
        private void NewMethod3()
        {
            DataSet dt = bll_StdMain.GetList_Std(strPhyCode, btnEdite_STlGRD3.Text);

            imgcbo_STD3.Properties.Items.Clear();

            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imgcbo_STD3.Properties.Items.Add(item["C_STD_CODE"].ToString(), item["C_STD_CODE"], -1);

            }
            imgcbo_STD3.SelectedIndex = 0;
        }
        /// <summary>
        /// 相邻钢种
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdite_STlGRD1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmPB_SELECT_GZ frm = new FrmPB_SELECT_GZ(strPhyCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnEdite_STlGRD1.Text = frm.str_c_grd;

                    frm.Close();
                    NewMethod1();//绑定执行标准下拉框
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 浇次首尾炉钢种选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdite_STlGRD2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmPB_SELECT_GZ frm = new FrmPB_SELECT_GZ(strPhyCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnEdite_STlGRD2.Text = frm.str_c_grd;

                    frm.Close();
                    NewMethod2();//绑定执行标准下拉框
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 涮槽钢种选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdite_STlGRD3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmPB_SELECT_GZ frm = new FrmPB_SELECT_GZ(strPhyCode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnEdite_STlGRD3.Text = frm.str_c_grd;

                    frm.Close();
                    NewMethod3();//绑定执行标准下拉框
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 相邻钢种-上移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_UP_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = this.gv_TPB_BORDER_GRD.FocusedRowHandle;
                if (rowIndex == 0)
                {
                    MessageBox.Show("已经是第一行了!", "提示");
                    return;
                }
                int A = Convert.ToInt32(gv_TPB_BORDER_GRD.GetRowCellValue(rowIndex, "N_LEVEL").ToString());//获取当前行的序号
                gv_TPB_BORDER_GRD.SetRowCellValue(rowIndex - 1, "N_LEVEL", A);
                gv_TPB_BORDER_GRD.SetRowCellValue(rowIndex, "N_LEVEL", A - 1);
                #region 保存当前排序
                for (int i = 0; i < gv_TPB_BORDER_GRD.RowCount; i++)
                {
                    Mod_TPB_BORDER_GRD modpx = bll_border_grd.GetModel(gv_TPB_BORDER_GRD.GetRowCellValue(i, "C_ID").ToString());
                    modpx.N_LEVEL = Convert.ToInt32(gv_TPB_BORDER_GRD.GetRowCellValue(i, "N_LEVEL").ToString());
                    bll_border_grd.Update(modpx);
                }
                NewMethod(txt_ID.Text);//相邻钢种查询
                #endregion

                this.gv_TPB_BORDER_GRD.SelectRow(rowIndex - 1);
                this.gv_TPB_BORDER_GRD.FocusedRowHandle = rowIndex - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 相邻钢种-下移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Down_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = this.gv_TPB_BORDER_GRD.FocusedRowHandle;
                if (rowIndex == this.gv_TPB_BORDER_GRD.RowCount - 1)
                {
                    MessageBox.Show("已经是最后一行了!", "提示");
                    return;
                }
                int A = Convert.ToInt32(gv_TPB_BORDER_GRD.GetRowCellValue(rowIndex, "N_LEVEL").ToString());//获取当前行的序号
                gv_TPB_BORDER_GRD.SetRowCellValue(rowIndex + 1, "N_LEVEL", A);
                gv_TPB_BORDER_GRD.SetRowCellValue(rowIndex, "N_LEVEL", A + 1);
                #region 保存当前排序
                for (int i = 0; i < gv_TPB_BORDER_GRD.RowCount; i++)
                {
                    Mod_TPB_BORDER_GRD modpx = bll_border_grd.GetModel(gv_TPB_BORDER_GRD.GetRowCellValue(i, "C_ID").ToString());
                    modpx.N_LEVEL = Convert.ToInt32(gv_TPB_BORDER_GRD.GetRowCellValue(i, "N_LEVEL").ToString());
                    bll_border_grd.Update(modpx);
                }
                NewMethod(txt_ID.Text);//相邻钢种查询
                #endregion
                this.gv_TPB_BORDER_GRD.SelectRow(rowIndex + 1);
                this.gv_TPB_BORDER_GRD.FocusedRowHandle = rowIndex + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 首尾炉钢种-上移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_UP1_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = this.gv_TPB_ENDTOEND_GRD.FocusedRowHandle;
                if (rowIndex == 0)
                {
                    MessageBox.Show("已经是第一行了!", "提示");
                    return;
                }
                int A = Convert.ToInt32(gv_TPB_ENDTOEND_GRD.GetRowCellValue(rowIndex, "N_LEVEL").ToString());//获取当前行的序号
                gv_TPB_ENDTOEND_GRD.SetRowCellValue(rowIndex - 1, "N_LEVEL", A);
                gv_TPB_ENDTOEND_GRD.SetRowCellValue(rowIndex, "N_LEVEL", A - 1);
                #region 保存当前排序
                for (int i = 0; i < gv_TPB_ENDTOEND_GRD.RowCount; i++)
                {
                    Mod_TPB_ENDTOEND_GRD modpx = bll_endtoend.GetModel(gv_TPB_ENDTOEND_GRD.GetRowCellValue(i, "C_ID").ToString());
                    modpx.N_LEVEL = Convert.ToInt32(gv_TPB_ENDTOEND_GRD.GetRowCellValue(i, "N_LEVEL").ToString());
                    bll_endtoend.Update(modpx);
                }
                NewMethod1(txt_ID.Text);//浇次首尾炉钢种查询
                #endregion

                this.gv_TPB_ENDTOEND_GRD.SelectRow(rowIndex - 1);
                this.gv_TPB_ENDTOEND_GRD.FocusedRowHandle = rowIndex - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 首尾炉钢种-下移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Down1_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = this.gv_TPB_ENDTOEND_GRD.FocusedRowHandle;
                if (rowIndex == this.gv_TPB_ENDTOEND_GRD.RowCount - 1)
                {
                    MessageBox.Show("已经是最后一行了!", "提示");
                    return;
                }
                int A = Convert.ToInt32(gv_TPB_ENDTOEND_GRD.GetRowCellValue(rowIndex, "N_LEVEL").ToString());//获取当前行的序号
                gv_TPB_ENDTOEND_GRD.SetRowCellValue(rowIndex + 1, "N_LEVEL", A);
                gv_TPB_ENDTOEND_GRD.SetRowCellValue(rowIndex, "N_LEVEL", A + 1);
                #region 保存当前排序
                for (int i = 0; i < gv_TPB_ENDTOEND_GRD.RowCount; i++)
                {
                    Mod_TPB_ENDTOEND_GRD modpx = bll_endtoend.GetModel(gv_TPB_ENDTOEND_GRD.GetRowCellValue(i, "C_ID").ToString());
                    modpx.N_LEVEL = Convert.ToInt32(gv_TPB_ENDTOEND_GRD.GetRowCellValue(i, "N_LEVEL").ToString());
                    bll_endtoend.Update(modpx);
                }
                NewMethod1(txt_ID.Text);//浇次首尾炉钢种查询
                #endregion
                this.gv_TPB_ENDTOEND_GRD.SelectRow(rowIndex + 1);
                this.gv_TPB_ENDTOEND_GRD.FocusedRowHandle = rowIndex + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 涮槽钢种优先级-上移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_UP2_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = this.gv_TPB_RINSE_GRD.FocusedRowHandle;
                if (rowIndex == 0)
                {
                    MessageBox.Show("已经是第一行了!", "提示");
                    return;
                }
                int A = Convert.ToInt32(gv_TPB_RINSE_GRD.GetRowCellValue(rowIndex, "N_LEVEL").ToString());//获取当前行的序号
                gv_TPB_RINSE_GRD.SetRowCellValue(rowIndex - 1, "N_LEVEL", A);
                gv_TPB_RINSE_GRD.SetRowCellValue(rowIndex, "N_LEVEL", A - 1);
                #region 保存当前排序
                for (int i = 0; i < gv_TPB_RINSE_GRD.RowCount; i++)
                {
                    Mod_TPB_RINSE_GRD modpx = bll_rinse.GetModel(gv_TPB_RINSE_GRD.GetRowCellValue(i, "C_ID").ToString());
                    modpx.N_LEVEL = Convert.ToInt32(gv_TPB_RINSE_GRD.GetRowCellValue(i, "N_LEVEL").ToString());
                    bll_rinse.Update(modpx);
                }
                NewMethod2(txt_ID.Text);
                #endregion

                this.gv_TPB_RINSE_GRD.SelectRow(rowIndex - 1);
                this.gv_TPB_RINSE_GRD.FocusedRowHandle = rowIndex - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 涮槽钢种优先级-下移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Down2_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = this.gv_TPB_RINSE_GRD.FocusedRowHandle;
                if (rowIndex == this.gv_TPB_RINSE_GRD.RowCount - 1)
                {
                    MessageBox.Show("已经是最后一行了!", "提示");
                    return;
                }
                int A = Convert.ToInt32(gv_TPB_RINSE_GRD.GetRowCellValue(rowIndex, "N_LEVEL").ToString());//获取当前行的序号
                gv_TPB_RINSE_GRD.SetRowCellValue(rowIndex + 1, "N_LEVEL", A);
                gv_TPB_RINSE_GRD.SetRowCellValue(rowIndex, "N_LEVEL", A + 1);
                #region 保存当前排序
                for (int i = 0; i < gv_TPB_RINSE_GRD.RowCount; i++)
                {
                    Mod_TPB_RINSE_GRD modpx = bll_rinse.GetModel(gv_TPB_RINSE_GRD.GetRowCellValue(i, "C_ID").ToString());
                    modpx.N_LEVEL = Convert.ToInt32(gv_TPB_RINSE_GRD.GetRowCellValue(i, "N_LEVEL").ToString());
                    bll_rinse.Update(modpx);
                }
                NewMethod2(txt_ID.Text);
                #endregion
                this.gv_TPB_RINSE_GRD.SelectRow(rowIndex + 1);
                this.gv_TPB_RINSE_GRD.FocusedRowHandle = rowIndex + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
