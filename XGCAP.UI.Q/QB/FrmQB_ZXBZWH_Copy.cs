using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    /// <summary>
    /// 2018-04-28 zmc
    /// </summary>
    public partial class FrmQB_ZXBZWH_Copy : Form
    {
        string strPhyCode = "";
        public FrmQB_ZXBZWH_Copy(string sys_id)
        {
            InitializeComponent();
            strPhyCode = sys_id;
        }
        Bll_TQB_STL_GRD_NAME bll_stlname = new Bll_TQB_STL_GRD_NAME();
        Bll_TQB_STL_GRD_TYPE bll_stltype = new Bll_TQB_STL_GRD_TYPE();
        Bll_TQB_STD_TYPE bll_type = new Bll_TQB_STD_TYPE();
        Bll_TQB_STD_MAIN bll_stdmain = new Bll_TQB_STD_MAIN();
        Bll_TQB_STD_SPEC bll_StdSpec = new Bll_TQB_STD_SPEC();
        Bll_TQB_CHARACTER bll_CharaCter = new Bll_TQB_CHARACTER();
        Bll_TQB_STD_CFXN bll_STD_CFXN = new Bll_TQB_STD_CFXN();
        Bll_TQB_STD_SAMPLING bll_stdSampaing = new Bll_TQB_STD_SAMPLING();
        Bll_TQB_SAMPLING bll_Sampling = new Bll_TQB_SAMPLING();
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox_CF_Name = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();//成分-定性/定量
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox_XN_Name = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();//性能-定性/定量
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox_CF_QJ = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();//成分-区间
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox_XN_QJ = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();//性能-区间 
        string str_id = "";
        private void FrmQB_ZXBZWH_Copy_Load(object sender, EventArgs e)
        {

            try
            {
                txt_ID.Text = FrmQB_ZXBZ.str_cid;
                str_id = FrmQB_ZXBZ.str_cid;

                DataSet dt = bll_type.GetList("");
                imgcbo_stdtype.Properties.Items.Clear();
                foreach (DataRow item in dt.Tables[0].Rows)
                {
                    imgcbo_stdtype.Properties.Items.Add(item["C_TYPE_NAME"].ToString(), item["C_ID"], -1);
                }
                GetImageQyert_Name();//品名下拉框绑定
                GetImageQyert_Type();//品种下拉框绑定
                repositoryItemImageComboBox_CF_Name.Items.Clear();
                repositoryItemImageComboBox_CF_Name.Items.Add("定性", "定性", -1);
                repositoryItemImageComboBox_CF_Name.Items.Add("定量", "定量", -1);

                repositoryItemImageComboBox_XN_Name.Items.Clear();
                repositoryItemImageComboBox_XN_Name.Items.Add("定性", "定性", -1);
                repositoryItemImageComboBox_XN_Name.Items.Add("定量", "定量", -1);
                repositoryItemImageComboBox2.Items.Add("", "", -1);
                repositoryItemImageComboBox2.Items.Add("<E", "<E", -1);
                repositoryItemImageComboBox2.Items.Add("≤E", "≤E", -1);
                repositoryItemImageComboBox2.Items.Add("≤E≤", "≤E≤", -1);
                repositoryItemImageComboBox2.Items.Add("E≤", "E≤", -1);
                repositoryItemImageComboBox2.Items.Add("E<", "E<", -1);
                repositoryItemImageComboBox3.Items.Add("", "", -1);
                repositoryItemImageComboBox3.Items.Add("<E", "<E", -1);
                repositoryItemImageComboBox3.Items.Add("≤E", "≤E", -1);
                repositoryItemImageComboBox3.Items.Add("≤E≤", "≤E≤", -1);
                repositoryItemImageComboBox3.Items.Add("E≤", "E≤", -1);
                repositoryItemImageComboBox3.Items.Add("E<", "E<", -1);
                repositoryItemImageComboBox4.Items.Add("是", "是", -1);
                repositoryItemImageComboBox4.Items.Add("否", "否", -1);
                repositoryItemImageComboBox5.Items.Add("是", "是", -1);
                repositoryItemImageComboBox5.Items.Add("否", "否", -1);
                NewMethod();// 钢种规格明细
                NewMethod1();//检验基础数据查询
                NewMethod2();
                NewMethod3();
                NewMethod_XN();//查询执行标准 性能
                NewMethod_CF();// 查询执行标准 成分
                NewMethod4();//查询执行标准 取样信息


                NewMethod5();//回传


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 品名下拉框绑定
        /// </summary>
        private void GetImageQyert_Name()
        {
            DataSet dt = bll_stlname.GetList("");
            imgcbo_grdtype.Properties.Items.Clear();
            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imgcbo_grdtype.Properties.Items.Add(item["C_NAME"].ToString(), item["C_NAME"], -1);
            }
        }
        /// <summary>
        /// 品种下拉框绑定
        /// </summary>
        private void GetImageQyert_Type()
        {
            DataSet dt = bll_stltype.GetList("");
            imgcbo_prodkind.Properties.Items.Clear();
            foreach (DataRow item in dt.Tables[0].Rows)
            {
                imgcbo_prodkind.Properties.Items.Add(item["C_TYPE_NAME"].ToString(), item["C_TYPE_NAME"], -1);
            }
        }
        /// <summary>
        /// 回传信息
        /// </summary>
        private void NewMethod5()
        {
            Mod_TQB_STD_MAIN mod = bll_stdmain.GetModel(str_id);
            imgcbo_stdtype.EditValue = mod.C_STD_TYPE;
            txt_stdcode.Text = mod.C_STD_CODE;
            txt_stddes.Text = mod.C_STD_DESC;
            txt_stlgrd.Text = mod.C_STL_GRD;
            imgcbo_grdtype.EditValue = mod.C_PROD_NAME.Trim();
            imgcbo_prodkind.EditValue = mod.C_PROD_KIND.Trim();
            txt_uses.Text = mod.C_USES;
            txt_editnum.Text = Convert.ToString(mod.N_EDIT_NUM);
            txt_edition.Text = mod.C_EDITION;
            imgcbo_LF.Text = mod.C_IS_LF;
            imgcbo_RH.Text = mod.C_IS_RH;
            txt_state.Text = mod.C_DELIVERY_STATE;
            txt_xnsx.Text = mod.C_PHYSICS_TIME;
            txt_Remark.Text = mod.C_REMARK;
        }

        private void NewMethod4()
        {
            DataTable dt_stdSampaning = bll_stdSampaing.GetList("a.C_STD_MAIN_ID='" + str_id + "'").Tables[0];
            this.gc_StdQY.DataSource = dt_stdSampaning;
            //冻结有焦点的列
            gv_StdQY.Columns[0].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_StdQY.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_StdQY.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdQY);
        }

        /// <summary>
        /// 查询执行标准 性能
        /// </summary>
        /// <param name="str"></param>
        private void NewMethod_XN()
        {
            DataTable dt_XN = bll_STD_CFXN.GetList("C_STD_MAIN_ID='" + str_id + "' and c.c_type_name='性能'").Tables[0];
            this.gc_StdXN.DataSource = dt_XN;
            //冻结有焦点的列
            gv_StdXN.Columns[0].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_StdXN.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_StdXN.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdXN);
        }

        /// <summary>
        /// 查询执行标准 成分
        /// </summary>
        /// <param name="str"></param>
        private void NewMethod_CF()
        {
            DataTable dt_CX = bll_STD_CFXN.GetList_CF("C_STD_MAIN_ID='" + str_id + "' and c.c_type_name='成分'").Tables[0];
            this.gc_StdCF.DataSource = dt_CX;
            //冻结有焦点的列
            gv_StdCF.Columns[0].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_StdCF.Columns[1].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gv_StdCF.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_StdCF);
        }
        /// <summary>
        /// 检验基础数据查询——成分
        /// </summary>
        private void NewMethod1()
        {
            DataTable dt_CharaCter = bll_CharaCter.GetList_JCSJ_CF(txt_name.Text).Tables[0];
            this.gc_JCSJ.DataSource = dt_CharaCter;
            gv_JCSJ.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_JCSJ);
        }
        /// <summary>
        /// 检验基础数据查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            NewMethod1();
        }

        /// <summary>
        /// 钢种规格明细查询
        /// </summary>
        private void NewMethod()
        {
            DataTable dt_stdspec = bll_StdSpec.GetList("C_STD_MAIN_ID ='" + str_id + "'").Tables[0];
            this.gc_Spec.DataSource = dt_stdspec;
            gv_Spec.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_Spec);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_stdcode.Text.Trim()))
                {
                    MessageBox.Show("标准代码不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(txt_stddes.Text.Trim()))
                {
                    MessageBox.Show("标准描述不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(txt_stlgrd.Text.Trim()))
                {
                    MessageBox.Show("钢种不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(imgcbo_grdtype.Text.Trim()))
                {
                    MessageBox.Show("钢种类型不能为空！");
                    return;
                }
                if (imgcbo_stdtype.EditValue == null)
                {
                    MessageBox.Show("标准类型不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(imgcbo_prodkind.Text.Trim()))
                {
                    MessageBox.Show("品种不能为空！");
                    return;
                }
                if (string.IsNullOrEmpty(imgcbo_RH.Text.Trim()))
                {
                    MessageBox.Show("请选择是否RH！");
                    return;
                }
                if (string.IsNullOrEmpty(imgcbo_LF.Text.Trim()))
                {
                    MessageBox.Show("请选择是否LF！");
                    return;
                }
                if (txt_stdcode.Text.Trim().Contains(" "))
                {
                    MessageBox.Show("执行标准代码中存在空格！");
                    return;
                }
                if (DialogResult.OK != MessageBox.Show("是否确认保存已输入的数据？", "提示", MessageBoxButtons.OKCancel))
                {
                    return;
                }


                Mod_TQB_STD_MAIN mod = new Mod_TQB_STD_MAIN();
                mod.C_ID = "bz" + RV.UI.ServerTime.timeNow().ToString("yyyyMMddHHmmssfff");
                mod.C_STD_TYPE = imgcbo_stdtype.EditValue.ToString();
                mod.C_STD_CODE = txt_stdcode.Text.Trim();
                mod.C_STD_DESC = txt_stddes.Text.Trim();
                mod.C_STL_GRD = txt_stlgrd.Text.Trim();
                mod.C_PROD_NAME = imgcbo_grdtype.Text.Trim();
                mod.C_PROD_KIND = imgcbo_prodkind.Text.Trim();
                mod.C_USES = txt_uses.Text;
                mod.N_EDIT_NUM = Convert.ToDecimal(txt_editnum.Text.Trim());
                mod.C_EDITION = txt_edition.Text.Trim();
                mod.C_IS_LF = imgcbo_LF.Text.Trim();
                mod.C_IS_RH = imgcbo_RH.Text.Trim();
                mod.C_DELIVERY_STATE = txt_state.Text.Trim();
                mod.C_PHYSICS_TIME = txt_xnsx.Text.Trim();
                mod.C_REMARK = txt_Remark.Text.Trim();
                mod.C_IS_BXG = strPhyCode;
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;


                bll_stdmain.Add(mod);

                str_id = mod.C_ID;


                NewMethod6(str_id);
                NewMethod7(str_id);
                NewMethod8(str_id);
                NewMethod9(str_id);


                MessageBox.Show("保存成功！");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 钢种规格明细添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                if (string.IsNullOrEmpty(txt_spec.Text.Trim()))
                {
                    MessageBox.Show("规格不能为空！");
                    return;
                }
                if (Convert.ToDecimal(txt_spec.Text.Trim()) == 0)
                {
                    MessageBox.Show("规格不能为0！");
                    return;
                }



                Mod_TQB_STD_SPEC mod = new Mod_TQB_STD_SPEC();
                mod.C_STD_MAIN_ID = str_id;
                mod.C_SPEC = "φ" + txt_spec.Text.Trim();
                #region 检测是否重复添加
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("C_STD_MAIN_ID", str_id);
                ht.Add("C_SPEC", mod.C_SPEC);
                ht.Add("N_STATUS", "1");
                if (Common.CheckRepeat.CheckTable("TQB_STD_SPEC", ht) > 0)
                {
                    MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                #endregion
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                bll_StdSpec.Add(mod);
                NewMethod();// 钢种规格明细查询
                MessageBox.Show("添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 复制保存钢种规格信息
        /// </summary>
        private void NewMethod6(string C_ID)
        {
            try
            { 
                for (int i = 0; i < gv_Spec.DataRowCount; i++)
                { 
                    DataRow dr = this.gv_Spec.GetDataRow(i);

                    Mod_TQB_STD_SPEC mod = new Mod_TQB_STD_SPEC();
                    mod.C_STD_MAIN_ID = C_ID;
                    if (!dr["C_SPEC"].ToString().Contains("φ"))
                    {
                        mod.C_SPEC = "φ" + dr["C_SPEC"].ToString();
                    }
                    else
                    {
                        mod.C_SPEC = dr["C_SPEC"].ToString();
                    }
                    mod.C_REMARK = dr["C_REMARK"].ToString();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    bll_StdSpec.Add(mod);

                }
                NewMethod();// 钢种规格明细
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 钢种规格明细停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_Spec.GetDataRow(gv_Spec.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_STD_SPEC", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            MessageBox.Show("已停用！");
                            NewMethod();// 钢种规格明细查询
                        }
                    }
                }
                else//如果点击“取消”按钮
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 钢种规格明细修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                for (int i = 0; i < gv_Spec.DataRowCount; i++)
                {
                    DataRow dr = this.gv_Spec.GetDataRow(i);

                    Mod_TQB_STD_SPEC mod = bll_StdSpec.GetModel(dr["C_ID"].ToString());
                    if (!dr["C_SPEC"].ToString().Contains("φ"))
                    {
                        mod.C_SPEC = "φ" + dr["C_SPEC"].ToString();
                    }
                    else
                    {
                        mod.C_SPEC = dr["C_SPEC"].ToString();
                    }
                    if (Convert.ToDecimal(mod.C_SPEC.Substring(1)) == 0)
                    {
                        MessageBox.Show("规格不能为0！");
                        return;
                    }
                    #region 检测是否重复添加
                    System.Collections.Hashtable ht = new System.Collections.Hashtable();
                    ht.Add("C_ID", mod.C_ID);
                    ht.Add("C_STD_MAIN_ID", str_id);
                    ht.Add("C_SPEC", mod.C_SPEC);
                    ht.Add("N_STATUS", "1");
                    if (Common.CheckRepeat.CheckTable("TQB_STD_SPEC", ht) > 0)
                    {
                        MessageBox.Show("已存在,不能重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    #endregion
                    mod.C_REMARK = dr["C_REMARK"].ToString();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bll_StdSpec.Update(mod);

                }
                NewMethod();// 钢种规格明细查询
                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 检验基础数据查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                NewMethod2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 检验基础数据查询——性能
        /// </summary>
        private void NewMethod2()
        {
            try
            {
                DataTable dt_CharaCter = bll_CharaCter.GetList_JCSJ_XN(txt_name1.Text).Tables[0];
                this.gc_JCSJ1.DataSource = dt_CharaCter;
                gv_JCSJ1.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_JCSJ1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        ///检验基础数据查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query2_Click(object sender, EventArgs e)
        {
            try
            {
                NewMethod3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewMethod3()
        {
            DataTable dt = bll_Sampling.GetList_Query(txt_name3.Text).Tables[0];
            this.gc_JCSJ2.DataSource = dt;
            gv_JCSJ2.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_JCSJ2);

        }
        /// <summary>
        /// 执行标准 成分信息添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_CF_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                DataRow dr = this.gv_JCSJ.GetDataRow(this.gv_JCSJ.FocusedRowHandle);
                if (dr == null) return;
                Mod_TQB_STD_CFXN mod = new Mod_TQB_STD_CFXN();
                mod.C_STD_MAIN_ID = str_id;
                mod.C_CHARACTER_ID = dr["C_ID"].ToString();
                Mod_TQB_CHARACTER mod_character = bll_CharaCter.GetModel(dr["C_ID"].ToString()); 
                mod.C_QUANTITATIVE = mod_character.C_QUANTITATIVE;
                mod.C_UNIT = mod_character.C_UNIT;
                if (!string.IsNullOrEmpty(mod_character.C_DIGIT))
                {
                    mod.N_DIGIT = Convert.ToDecimal(mod_character.C_DIGIT);
                }
                if (mod_character.C_NAME == "C")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 1;
                }
                else if (mod_character.C_NAME == "Si")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 2;
                }
                else if (mod_character.C_NAME == "Mn")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 3;
                }
                else if (mod_character.C_NAME == "P")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 4;
                }
                else if (mod_character.C_NAME == "S")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 5;
                }
                else if (mod_character.C_NAME == "Al")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 6;
                }
                else if (mod_character.C_NAME == "Cr")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 7;
                }
                else if (mod_character.C_NAME == "Ni")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 8;
                }
                else if (mod_character.C_NAME == "Cu")//检测是否添加‘碳硅锰磷硫’
                {
                    mod.N_PRINT_ORDER = 9;
                }
                mod.C_TYPE = "成分";
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                bll_STD_CFXN.Add(mod);
                NewMethod_CF();// 查询执行标准 成分
                MessageBox.Show("添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        /// <summary>
        /// 复制添加成分信息
        /// </summary>
        private void NewMethod7(string c_id)
        {
            try
            {

                for (int i = 0; i < gv_StdCF.DataRowCount; i++)
                {

                    DataRow dr = this.gv_StdCF.GetDataRow(i);

                    Mod_TQB_STD_CFXN mod = new Mod_TQB_STD_CFXN();
                    mod.C_STD_MAIN_ID = c_id;
                    mod.C_CHARACTER_ID = dr["C_CHARACTER_ID"].ToString();
                    mod.C_TYPE = "成分";
                    mod.C_TARGET_MIN = dr["C_TARGET_MIN"].ToString();
                    mod.C_TARGET_INTERVAL = dr["C_TARGET_INTERVAL"].ToString();
                    mod.C_TARGET_MAX = dr["C_TARGET_MAX"].ToString();
                    mod.C_PREWARNING_VALUE = dr["C_PREWARNING_VALUE"].ToString();
                    if (!string.IsNullOrEmpty(dr["N_SPEC_MIN"].ToString()))
                    {
                        mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);
                    }
                    mod.C_IS_DECIDE = dr["C_IS_DECIDE"].ToString();
                    mod.C_IS_PRINT = dr["C_IS_PRINT"].ToString();
                    mod.C_SPEC_INTERVAL = dr["C_SPEC_INTERVAL"].ToString();
                    if (!string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                    {
                        mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);
                    }
                    if (!string.IsNullOrEmpty(dr["N_PRINT_ORDER"].ToString()))
                    {
                        mod.N_PRINT_ORDER = Convert.ToDecimal(dr["N_PRINT_ORDER"]);
                    }
                    mod.C_QUANTITATIVE = dr["C_QUANTITATIVE"].ToString();
                    mod.C_FORMULA = dr["C_FORMULA"].ToString();
                    mod.C_UNIT = dr["C_UNIT"].ToString();
                    if (!string.IsNullOrEmpty(dr["N_DIGIT"].ToString()))
                    {
                        mod.N_DIGIT = Convert.ToDecimal(dr["N_DIGIT"]);
                    }
                    mod.C_TEST_TEM = dr["C_TEST_TEM"].ToString();
                    mod.C_TEST_CONDITION = dr["C_TEST_CONDITION"].ToString();
                    mod.C_REMARK = dr["C_REMARK"].ToString();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    bll_STD_CFXN.Add(mod);

                }
                NewMethod_CF();// 查询执行标准 成分
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 执行标准成分信息停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_CF_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_StdCF.GetDataRow(gv_StdCF.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_STD_CFXN", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            MessageBox.Show("已停用！");
                            NewMethod_CF();// 查询执行标准 成分
                        }
                    }
                }
                else//如果点击“取消”按钮
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 执行标准成分信息 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_CF_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                for (int i = 0; i < gv_StdCF.DataRowCount; i++)
                {
                    DataRow dr = this.gv_StdCF.GetDataRow(i);
                    if (dr == null) return;
                    if (string.IsNullOrEmpty(dr["C_QUANTITATIVE"].ToString()))
                    {
                        MessageBox.Show("请选择定性或定量");
                        return;
                    }

                }
                for (int i = 0; i < gv_StdCF.DataRowCount; i++)
                {
                    DataRow dr = this.gv_StdCF.GetDataRow(i);
                    if (dr == null) return;
                    Mod_TQB_STD_CFXN mod = bll_STD_CFXN.GetModel(dr["C_ID"].ToString());


                    #region 目标值区间
                    if (!string.IsNullOrEmpty(dr["C_TARGET_INTERVAL"].ToString()))
                    {
                        mod.C_TARGET_INTERVAL = dr["C_TARGET_INTERVAL"].ToString();
                        if (dr["C_TARGET_INTERVAL"].ToString() == "≤E")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写目标最小值！");
                                return;
                            }
                            else
                            {
                                mod.C_TARGET_MIN = dr["C_TARGET_MIN"].ToString();//目标最小值
                                mod.C_TARGET_MAX = "";//目标最大值
                            }
                        }
                        else if (dr["C_TARGET_INTERVAL"].ToString() == "<E")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写目标最小值！");
                                return;
                            }
                            else
                            {
                                mod.C_TARGET_MIN = dr["C_TARGET_MIN"].ToString();//目标最小值
                                mod.C_TARGET_MAX = "";//目标最大值
                            }
                        }
                        else if (dr["C_TARGET_INTERVAL"].ToString() == "≤E≤")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写目标最小值！");
                                return;
                            }

                            if (string.IsNullOrEmpty(dr["C_TARGET_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写目标最大值！");
                                return;
                            }

                            mod.C_TARGET_MIN = dr["C_TARGET_MIN"].ToString();//目标最小值
                            mod.C_TARGET_MAX = dr["C_TARGET_MAX"].ToString();//目标最大值
                        }
                        else if (dr["C_TARGET_INTERVAL"].ToString() == "E≤")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写目标最大值！");
                                return;
                            }
                            else
                            {
                                mod.C_TARGET_MIN = "";//目标最小值
                                mod.C_TARGET_MAX = dr["C_TARGET_MAX"].ToString();//目标最大值
                            }
                        }
                        else if (dr["C_TARGET_INTERVAL"].ToString() == "E<")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写目标最大值！");
                                return;
                            }
                            else
                            {
                                mod.C_TARGET_MIN = "";//目标最小值
                                mod.C_TARGET_MAX = dr["C_TARGET_MAX"].ToString();//目标最大值
                            }
                        }
                    }
                    else
                    {
                        mod.C_TARGET_MIN = "";
                        mod.C_TARGET_INTERVAL = dr["C_TARGET_INTERVAL"].ToString();
                        mod.C_TARGET_MAX = "";
                    }
                    #endregion

                    mod.C_PREWARNING_VALUE = dr["C_PREWARNING_VALUE"].ToString();
                    //if (!string.IsNullOrEmpty(dr["N_SPEC_MIN"].ToString()))
                    //{
                    //    mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);
                    //}

                    //mod.C_SPEC_INTERVAL = dr["C_SPEC_INTERVAL"].ToString();
                    //if (!string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                    //{
                    //    mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);
                    //}

                    #region 规格区间
                    if (!string.IsNullOrEmpty(dr["C_SPEC_INTERVAL"].ToString()))
                    {
                        mod.C_SPEC_INTERVAL = dr["C_SPEC_INTERVAL"].ToString();
                        if (dr["C_SPEC_INTERVAL"].ToString() == "<E")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写规格最小值！");
                                return;
                            }
                            else
                            {
                                mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);//规格最小值
                                mod.N_SPEC_MAX = null;
                            }
                        }
                        else if (dr["C_SPEC_INTERVAL"].ToString() == "≤E")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写规格最小值！");
                                return;
                            }
                            else
                            {
                                mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);//规格最小值
                                mod.N_SPEC_MAX = null;
                            }
                        }
                        else if (dr["C_SPEC_INTERVAL"].ToString() == "≤E≤")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写规格最小值！");
                                return;
                            }

                            if (string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写规格最大值！");
                                return;
                            }

                            mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);//规格最小值
                            mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);//规格最大值
                        }
                        else if (dr["C_SPEC_INTERVAL"].ToString() == "E≤")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写规格最大值！");
                                return;
                            }
                            else
                            {
                                mod.N_SPEC_MIN = null;
                                mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);//规格最大值
                            }
                        }
                        else if (dr["C_SPEC_INTERVAL"].ToString() == "E<")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写规格最大值！");
                                return;
                            }
                            else
                            {
                                mod.N_SPEC_MIN = null;
                                mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);//规格最大值
                            }
                        }
                    }
                    else
                    {
                        mod.N_SPEC_MIN = null;
                        mod.C_SPEC_INTERVAL = dr["C_SPEC_INTERVAL"].ToString();
                        mod.N_SPEC_MAX = null;
                    }
                    #endregion

                    if (!string.IsNullOrEmpty(dr["N_PRINT_ORDER"].ToString()))
                    {
                        mod.N_PRINT_ORDER = Convert.ToDecimal(dr["N_PRINT_ORDER"]);
                    }
                    mod.C_QUANTITATIVE = dr["C_QUANTITATIVE"].ToString();
                    mod.C_FORMULA = dr["C_FORMULA"].ToString();
                    mod.C_UNIT = dr["C_UNIT"].ToString();
                    if (!string.IsNullOrEmpty(dr["N_DIGIT"].ToString()))
                    {
                        mod.N_DIGIT = Convert.ToDecimal(dr["N_DIGIT"]);
                    }
                    mod.C_IS_DECIDE = dr["C_IS_DECIDE"].ToString();
                    mod.C_IS_PRINT = dr["C_IS_PRINT"].ToString();
                    mod.C_TEST_TEM = dr["C_TEST_TEM"].ToString();
                    mod.C_TEST_CONDITION = dr["C_TEST_CONDITION"].ToString();
                    mod.C_REMARK = dr["C_REMARK"].ToString();

                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    //double result = 0.0;
                    //if (!double.TryParse(mod.C_TARGET_MIN, out result))
                    //{
                    //    MessageBox.Show("目标最小值只能输入浮点数！");
                    //    return;
                    //}
                    //if (!double.TryParse(mod.C_TARGET_MAX, out result))
                    //{
                    //    MessageBox.Show("目标最大值只能输入浮点数！");
                    //    return;
                    //}
                    bll_STD_CFXN.Update(mod);

                }
                NewMethod_CF();// 查询执行标准 成分
                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 执行标准 性能信息添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_XN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                DataRow dr = this.gv_JCSJ1.GetDataRow(this.gv_JCSJ1.FocusedRowHandle);
                if (dr == null) return;
                Mod_TQB_STD_CFXN mod = new Mod_TQB_STD_CFXN();

                Mod_TQB_CHARACTER mod_character = bll_CharaCter.GetModel(dr["C_ID"].ToString());
                mod.C_QUANTITATIVE = mod_character.C_QUANTITATIVE;
                if (!string.IsNullOrEmpty(mod_character.C_DIGIT))
                {
                    mod.N_DIGIT = Convert.ToDecimal(mod_character.C_DIGIT);
                }
                mod.C_UNIT = mod_character.C_UNIT;
                mod.C_STD_MAIN_ID = str_id; 
                mod.C_CHARACTER_ID = dr["C_ID"].ToString(); 
                mod.C_TYPE = "性能";
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                bll_STD_CFXN.Add(mod);
                NewMethod_XN();// 查询执行标准 性能
                MessageBox.Show("添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        /// <summary>
        /// 复制添加性能信息
        /// </summary>
        private void NewMethod8(string c_id)
        {
            try
            {

                for (int i = 0; i < gv_StdXN.DataRowCount; i++)
                {

                    DataRow dr = this.gv_StdXN.GetDataRow(i);

                    Mod_TQB_STD_CFXN mod = new Mod_TQB_STD_CFXN();
                    mod.C_STD_MAIN_ID = c_id;
                    mod.C_CHARACTER_ID = dr["C_CHARACTER_ID"].ToString();
                    mod.C_TYPE = "性能";

                    mod.C_TARGET_MIN = dr["C_TARGET_MIN"].ToString();
                    mod.C_TARGET_INTERVAL = dr["C_TARGET_INTERVAL"].ToString();
                    mod.C_TARGET_MAX = dr["C_TARGET_MAX"].ToString();
                    mod.C_PREWARNING_VALUE = dr["C_PREWARNING_VALUE"].ToString();
                    if (!string.IsNullOrEmpty(dr["N_SPEC_MIN"].ToString()))
                    {
                        mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);
                    }
                    mod.C_SPEC_INTERVAL = dr["C_SPEC_INTERVAL"].ToString();
                    if (!string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                    {
                        mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);
                    }
                    mod.C_QUANTITATIVE = dr["C_QUANTITATIVE"].ToString();
                    mod.C_FORMULA = dr["C_FORMULA"].ToString();
                    mod.C_UNIT = dr["C_UNIT"].ToString();

                    if (!string.IsNullOrEmpty(dr["N_DIGIT"].ToString()))
                    {
                        mod.N_DIGIT = Convert.ToDecimal(dr["N_DIGIT"]);
                    }

                    mod.C_TEST_TEM = dr["C_TEST_TEM"].ToString();
                    mod.C_TEST_CONDITION = dr["C_TEST_CONDITION"].ToString();
                    if (!string.IsNullOrEmpty(dr["N_PRINT_ORDER"].ToString()))
                    {
                        mod.N_PRINT_ORDER = Convert.ToDecimal(dr["N_PRINT_ORDER"]);
                    }
                    mod.C_IS_DECIDE = dr["C_IS_DECIDE"].ToString();
                    mod.C_IS_PRINT = dr["C_IS_PRINT"].ToString();
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    mod.C_REMARK = dr["C_REMARK"].ToString();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bll_STD_CFXN.Add(mod);


                }
                NewMethod_XN();//查询执行标准 性能 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 执行标准性能信息停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_XN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_StdXN.GetDataRow(gv_StdXN.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_STD_CFXN", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            MessageBox.Show("已停用！");
                            NewMethod_XN();// 查询执行标准 性能
                        }
                    }
                }
                else//如果点击“取消”按钮
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 执行标准性能信息 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_XN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                for (int i = 0; i < gv_StdXN.DataRowCount; i++)
                {
                    DataRow dr = this.gv_StdXN.GetDataRow(i);
                    if (dr == null) return;
                    if (string.IsNullOrEmpty(dr["C_QUANTITATIVE"].ToString()))
                    {
                        MessageBox.Show("请选择定性或定量");
                        return;
                    }
                }
                    for (int i = 0; i < gv_StdXN.DataRowCount; i++)
                {
                    DataRow dr = this.gv_StdXN.GetDataRow(i);
                    if (dr == null) return;
                    Mod_TQB_STD_CFXN mod = bll_STD_CFXN.GetModel(dr["C_ID"].ToString());
                    #region 目标值区间
                    if (!string.IsNullOrEmpty(dr["C_TARGET_INTERVAL"].ToString()))
                    {
                        mod.C_TARGET_INTERVAL = dr["C_TARGET_INTERVAL"].ToString();

                        if (dr["C_TARGET_INTERVAL"].ToString() == "≤E")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写目标最小值！");
                                return;
                            }
                            else
                            {
                                mod.C_TARGET_MAX = "";
                                mod.C_TARGET_MIN = dr["C_TARGET_MIN"].ToString();//目标最小值
                            }
                        }
                        else if (dr["C_TARGET_INTERVAL"].ToString() == "<E")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写目标最小值！");
                                return;
                            }
                            else
                            {
                                mod.C_TARGET_MAX = "";
                                mod.C_TARGET_MIN = dr["C_TARGET_MIN"].ToString();//目标最小值
                            }

                        }
                        else if (dr["C_TARGET_INTERVAL"].ToString() == "≤E≤")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写目标最小值！");
                                return;
                            }

                            if (string.IsNullOrEmpty(dr["C_TARGET_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写目标最大值！");
                                return;
                            }

                            mod.C_TARGET_MIN = dr["C_TARGET_MIN"].ToString();//目标最小值
                            mod.C_TARGET_MAX = dr["C_TARGET_MAX"].ToString();//目标最大值
                        }
                        else if (dr["C_TARGET_INTERVAL"].ToString() == "E≤")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写目标最大值！");
                                return;
                            }
                            else
                            {
                                mod.C_TARGET_MIN = "";
                                mod.C_TARGET_MAX = dr["C_TARGET_MAX"].ToString();//目标最大值
                            }
                        }
                        else if (dr["C_TARGET_INTERVAL"].ToString() == "E<")
                        {
                            if (string.IsNullOrEmpty(dr["C_TARGET_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写目标最大值！");
                                return;
                            }
                            else
                            {
                                mod.C_TARGET_MIN = "";
                                mod.C_TARGET_MAX = dr["C_TARGET_MAX"].ToString();//目标最大值
                            }
                        }
                    }
                    else
                    {
                        mod.C_TARGET_INTERVAL = dr["C_TARGET_INTERVAL"].ToString();
                        mod.C_TARGET_MIN ="";//目标最小值
                        mod.C_TARGET_MAX = "";//目标最大值
                    }
                    #endregion

                    mod.C_PREWARNING_VALUE = dr["C_PREWARNING_VALUE"].ToString();
                    //if (!string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                    //{
                    //    mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);
                    //}
                    //mod.C_SPEC_INTERVAL = dr["C_SPEC_INTERVAL"].ToString();
                    //if (!string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                    //{
                    //    mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);
                    //}

                    #region 规格区间
                    if (!string.IsNullOrEmpty(dr["C_SPEC_INTERVAL"].ToString()))
                    {
                        mod.C_SPEC_INTERVAL = dr["C_SPEC_INTERVAL"].ToString();

                        if (dr["C_SPEC_INTERVAL"].ToString() == "≤E")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写规格最小值！");
                                return;
                            }
                            else
                            {
                                mod.N_SPEC_MAX = null;
                                mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);//规格最小值
                            }
                        }
                        else if (dr["C_SPEC_INTERVAL"].ToString() == "<E")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写规格最小值！");
                                return;
                            }
                            else
                            {
                                mod.N_SPEC_MAX = null;
                                mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);//规格最小值
                            }
                        }
                        else if (dr["C_SPEC_INTERVAL"].ToString() == "≤E≤")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MIN"].ToString()))
                            {
                                MessageBox.Show("请填写规格最小值！");
                                return;
                            }

                            if (string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写规格最大值！");
                                return;
                            }

                            mod.N_SPEC_MIN = Convert.ToDecimal(dr["N_SPEC_MIN"]);//规格最小值
                            mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);//规格最大值
                        }
                        else if (dr["C_SPEC_INTERVAL"].ToString() == "E≤")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写规格最大值！");
                                return;
                            }
                            else
                            {
                                mod.N_SPEC_MIN = null;
                                   mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);//规格最大值
                            }
                        }
                        else if (dr["C_SPEC_INTERVAL"].ToString() == "E<")
                        {
                            if (string.IsNullOrEmpty(dr["N_SPEC_MAX"].ToString()))
                            {
                                MessageBox.Show("请填写规格最大值！");
                                return;
                            }
                            else
                            {
                                mod.N_SPEC_MIN = null;
                                mod.N_SPEC_MAX = Convert.ToDecimal(dr["N_SPEC_MAX"]);//规格最大值
                            }
                        }
                    }
                    else
                    {
                        mod.C_SPEC_INTERVAL = dr["C_SPEC_INTERVAL"].ToString();
                        mod.N_SPEC_MIN = null;//规格最小值
                        mod.N_SPEC_MAX = null;//规格最大值
                    }
                    #endregion

                    mod.C_IS_DECIDE = dr["C_IS_DECIDE"].ToString();
                    mod.C_IS_PRINT = dr["C_IS_PRINT"].ToString();
                    mod.C_QUANTITATIVE = dr["C_QUANTITATIVE"].ToString();
                    mod.C_FORMULA = dr["C_FORMULA"].ToString();
                    mod.C_UNIT = dr["C_UNIT"].ToString();

                    if (!string.IsNullOrEmpty(dr["N_DIGIT"].ToString()))
                    {
                        mod.N_DIGIT = Convert.ToDecimal(dr["N_DIGIT"]);
                    }

                    //mod.N_DIGIT = Convert.ToDecimal(dr["N_DIGIT"]);
                    mod.C_TEST_TEM = dr["C_TEST_TEM"].ToString();
                    mod.C_TEST_CONDITION = dr["C_TEST_CONDITION"].ToString();
                    if (!string.IsNullOrEmpty(dr["N_PRINT_ORDER"].ToString()))
                    {
                        mod.N_PRINT_ORDER = Convert.ToDecimal(dr["N_PRINT_ORDER"]);
                    }

                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    mod.C_REMARK = dr["C_REMARK"].ToString();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    //double result = 0.0;
                    //if (!double.TryParse(mod.C_TARGET_MIN, out result))
                    //{
                    //    MessageBox.Show("目标最小值只能输入浮点数！");
                    //    return;
                    //}
                    //if (!double.TryParse(mod.C_TARGET_MAX, out result))
                    //{
                    //    MessageBox.Show("目标最大值只能输入浮点数！");
                    //    return;
                    //}

                    bll_STD_CFXN.Update(mod);

                }
                NewMethod_XN();// 查询执行标准 性能

                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 执行标准取样信息添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_QY_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                DataRow dr = this.gv_JCSJ2.GetDataRow(this.gv_JCSJ2.FocusedRowHandle);
                if (dr == null) return;
                Mod_TQB_STD_SAMPLING mod = new Mod_TQB_STD_SAMPLING();

                mod.C_STD_MAIN_ID = str_id;
                mod.C_SAMPLING_ID = dr["C_ID"].ToString();
                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                bll_stdSampaing.Add(mod);
                NewMethod4();// 查询执行标准 性能
                MessageBox.Show("添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        /// <summary>
        /// 复制添加取样信息
        /// </summary>
        private void NewMethod9(string c_id)
        {
            try
            {

                for (int i = 0; i < gv_StdQY.DataRowCount; i++)
                {


                    DataRow dr = this.gv_StdQY.GetDataRow(i);

                    Mod_TQB_STD_SAMPLING mod = new Mod_TQB_STD_SAMPLING();

                    mod.C_STD_MAIN_ID = c_id;
                    mod.C_SAMPLING_ID = dr["C_SAMPLING_ID"].ToString();
                    mod.C_NUMBER = dr["C_NUMBER"].ToString();
                    mod.C_SAM_SPE = dr["C_SAM_SPE"].ToString();
                    mod.C_SAM_LEN = dr["C_SAM_LEN"].ToString();
                    mod.C_SAM_METHOD = dr["C_SAM_METHOD"].ToString();
                    mod.C_SAM_NUM = dr["C_SAM_NUM"].ToString();
                    mod.C_RECHECK_NUM = dr["C_RECHECK_NUM"].ToString();
                    mod.C_NUM_UNIT = dr["C_NUM_UNIT"].ToString();
                    mod.C_SAM_SECTION = dr["C_SAM_SECTION"].ToString();
                    mod.C_TEST_UNIT = dr["C_TEST_UNIT"].ToString();
                    mod.C_REMARK = dr["C_REMARK"].ToString();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    bll_stdSampaing.Add(mod);

                }
                NewMethod4();//查询执行标准 取样信息
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 执行标准取样信息停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_QY_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_StdQY.GetDataRow(gv_StdQY.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TQB_STD_SAMPLING", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            MessageBox.Show("已停用！");
                            NewMethod4();// 查询执行标准信息取样
                        }
                    }
                }
                else//如果点击“取消”按钮
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 执行标准取样信息修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_QY_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(str_id) || str_id == txt_ID.Text)
                {
                    MessageBox.Show("请先保存主信息再进行操作！");
                    return;
                }
                for (int i = 0; i < gv_StdQY.DataRowCount; i++)
                {
                    DataRow dr = this.gv_StdQY.GetDataRow(i);
                    if (dr == null) return;
                    Mod_TQB_STD_SAMPLING mod = bll_stdSampaing.GetModel(dr["C_ID"].ToString());
                    mod.C_NUMBER = dr["C_NUMBER"].ToString();
                    mod.C_SAM_SPE = dr["C_SAM_SPE"].ToString();
                    mod.C_SAM_LEN = dr["C_SAM_LEN"].ToString();
                    mod.C_SAM_METHOD = dr["C_SAM_METHOD"].ToString();
                    mod.C_SAM_NUM = dr["C_SAM_NUM"].ToString();
                    mod.C_RECHECK_NUM = dr["C_RECHECK_NUM"].ToString();
                    mod.C_NUM_UNIT = dr["C_NUM_UNIT"].ToString();
                    mod.C_SAM_SECTION = dr["C_SAM_SECTION"].ToString();
                    mod.C_TEST_UNIT = dr["C_TEST_UNIT"].ToString();
                    mod.C_REMARK = dr["C_REMARK"].ToString();
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    bll_stdSampaing.Update(mod);
                }
                NewMethod4();// 查询执行标准  取样

                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 成分列表中绑定下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_StdCF_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                string fieldName = e.Column.FieldName;
                DataRow selectRow = gv_StdCF.GetDataRow(e.RowHandle);

                if (fieldName == "C_QUANTITATIVE")
                {
                    e.RepositoryItem = repositoryItemImageComboBox_CF_Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 性能列表绑定下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_StdXN_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {

                string fieldName = e.Column.FieldName;
                DataRow selectRow = gv_StdXN.GetDataRow(e.RowHandle);

                if (fieldName == "C_QUANTITATIVE")
                {
                    e.RepositoryItem = repositoryItemImageComboBox_XN_Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
