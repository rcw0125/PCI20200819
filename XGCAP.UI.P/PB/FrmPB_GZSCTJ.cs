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
using Aspose.Cells;
using System.Text.RegularExpressions;

namespace XGCAP.UI.P.PB
{
    /// <summary>
    /// 2018-05-15 zmc
    /// </summary>
    public partial class FrmPB_GZSCTJ : Form
    {
        public FrmPB_GZSCTJ()
        {
            InitializeComponent();
        }
        Bll_TPB_STEEL_PRO_CONDITION bll_steel_pro = new Bll_TPB_STEEL_PRO_CONDITION();
        Bll_TPB_BORDER_GRD bll_border_grd = new Bll_TPB_BORDER_GRD();
        Bll_TPB_ENDTOEND_GRD bll_endtoend = new Bll_TPB_ENDTOEND_GRD();
        Bll_TPB_RINSE_GRD bll_rinse = new Bll_TPB_RINSE_GRD();
        Bll_TPB_LADLE bll_ladle = new Bll_TPB_LADLE();
        Bll_TPB_SLAB_ALLOT bll_slab_allot = new Bll_TPB_SLAB_ALLOT();
        Bll_TQB_TSBZ_CF bll_tstj_cf = new Bll_TQB_TSBZ_CF();
        private string strMenuName;
        private string strPhyCode;

        DataTable dtmain = null;
        private void FrmPB_GZSCTJ_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
            strMenuName = RV.UI.UserInfo.menuName;
            strPhyCode = RV.UI.QueryString.parameter;
        }
        /// <summary>
        /// 钢种生产条件主表查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                dtmain = bll_steel_pro.GetList_GZSCTJ(strPhyCode, txt_GRD.Text.Trim(), txt_Std.Text.Trim()).Tables[0];
                this.gc_Main.DataSource = dtmain;

                gv_Main.OptionsView.ColumnAutoWidth = false;
                gv_Main.OptionsView.RowAutoHeight = true;

                gv_Main.BestFitColumns();
                SetGridViewRowNum.SetRowNum(gv_Main);
                NewMethod6();
                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void NewMethod6()
        {
            DataRow dr = this.gv_Main.GetDataRow(this.gv_Main.FocusedRowHandle);
            if (dr != null)
            {
                NewMethod(dr);//相邻钢种
                NewMethod1(dr);//浇次首尾炉钢种
                NewMethod2(dr);//涮槽钢种
                NewMethod3(dr);//铁水条件
                NewMethod4(dr);//钢包条件

            }
            else
            {

                gc_TPB_LADLE.DataSource = null;
                gc_tqb_tstj_cf.DataSource = null;
                gc_TPB_RINSE_GRD.DataSource = null;
                gc_TPB_ENDTOEND_GRD.DataSource = null;
                gc_TPB_BORDER_GRD.DataSource = null;
            }
        }



        /// <summary>
        /// 钢包条件
        /// </summary>
        /// <param name="dr"></param>
        private void NewMethod4(DataRow dr)
        {
            DataTable dt_ladle = bll_ladle.GetList_Query(dr["C_ID"].ToString()).Tables[0];
            this.gc_TPB_LADLE.DataSource = dt_ladle;
            gv_TPB_LADLE.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_TPB_LADLE);
        }

        /// <summary>
        /// 铁水条件
        /// </summary>
        /// <param name="dr"></param>
        private void NewMethod3(DataRow dr)
        {
            DataTable dt_tstj = bll_tstj_cf.GetList_ProID(dr["C_ID"].ToString()).Tables[0];
            this.gc_tqb_tstj_cf.DataSource = dt_tstj;
            gv_tqb_tstj_cf.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_tqb_tstj_cf);
        }

        /// <summary>
        /// 刷槽钢种
        /// </summary>
        /// <param name="dr"></param>
        private void NewMethod2(DataRow dr)
        {
            DataTable dt_rinse = bll_rinse.GetList_Query(dr["C_ID"].ToString()).Tables[0];
            this.gc_TPB_RINSE_GRD.DataSource = dt_rinse;
            gv_TPB_RINSE_GRD.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_TPB_RINSE_GRD);
        }

        /// <summary>
        /// 浇次首尾炉钢种
        /// </summary>
        /// <param name="dr"></param>
        private void NewMethod1(DataRow dr)
        {
            DataTable dt_endtoend = bll_endtoend.GetList_Query(dr["C_ID"].ToString()).Tables[0];
            this.gc_TPB_ENDTOEND_GRD.DataSource = dt_endtoend;
            gv_TPB_ENDTOEND_GRD.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_TPB_ENDTOEND_GRD);
        }

        /// <summary>
        ///相邻钢种查询
        /// </summary>
        /// <param name="dr"></param>
        private void NewMethod(DataRow dr)
        {
            DataTable dt = bll_border_grd.GetList_Query(dr["C_ID"].ToString()).Tables[0];
            this.gc_TPB_BORDER_GRD.DataSource = dt;

            gv_TPB_BORDER_GRD.BestFitColumns();
            SetGridViewRowNum.SetRowNum(gv_TPB_BORDER_GRD);
        }
        public static string str_cid;
        /// <summary>
        /// 跳转到添加页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                str_cid = "";
                FrmPB_GZSCTJWH frm = new FrmPB_GZSCTJWH(strPhyCode);
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    frm.Close();
                    btn_Query_Click(null, null);

                    Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "添加钢种生产条件");//添加操作日志
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 跳转到修改页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = this.gv_Main.GetDataRow(this.gv_Main.FocusedRowHandle);
                if (dr != null)//判断是否选中数据
                {
                    str_cid = dr["C_ID"].ToString();
                    FrmPB_GZSCTJWH frm = new FrmPB_GZSCTJWH(strPhyCode);
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        frm.Close();
                        btn_Query_Click(null, null);

                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改钢种生产条件");//添加操作日志
                    }
                }
                else
                {
                    MessageBox.Show("请选择需要修改的数据！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 主数据点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Main_Click(object sender, EventArgs e)
        {
            try
            {
                NewMethod6();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }


        /// <summary>
        /// 导入主表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                //DataTable dt = OpenExcelFile(this.txtUrl.Text, "Sheet2");
                DataTable dt = ReadExcel(this.txtUrl.Text);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Mod_TPB_STEEL_PRO_CONDITION modis = bll_steel_pro.GetModel(dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString());
                        if (modis == null)
                        {
                            string strGUID = System.Guid.NewGuid().ToString();
                            Mod_TPB_STEEL_PRO_CONDITION model = new Mod_TPB_STEEL_PRO_CONDITION();
                            model.C_ID = strGUID;//主键
                            model.C_STL_GRD_TYPE = dt.Rows[i][0].ToString();//钢种类别
                            model.C_STL_GRD_RANK = dt.Rows[i][1].ToString();//钢种级别
                            model.C_STL_GRD = Regex.Replace(dt.Rows[i][2].ToString(), @"\s", ""); //计划钢种
                            model.C_STD_CODE = Regex.Replace(dt.Rows[i][3].ToString(), @"\s", "");//执行标准  
                            model.C_STL_SCRAP_TYPE = dt.Rows[i][4].ToString();//产生废钢分类
                            model.C_STL_SCRAP_FLIJ = dt.Rows[i][5].ToString();//废钢分类标识号
                            model.C_GOUTE = dt.Rows[i][6].ToString();//三次冷却工艺要求
                            model.C_TEASE_PERSON = dt.Rows[i][7].ToString();//梳理人
                            model.C_ADV_PRO_REQUIRE = dt.Rows[i][8].ToString();//特高级产品用钢坯生产和改判要求
                            model.C_REMARK = dt.Rows[i][9].ToString();//备注
                            model.C_IS_BXG = strPhyCode;
                            model.C_EMP_ID = RV.UI.UserInfo.UserID;
                            model.C_IS_DR = "1";
                            bool res = bll_steel_pro.Add(model);
                        }

                    }
                    MessageBox.Show("导入成功！");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 将Excel转换成datatable
        /// </summary>
        /// <param name="strFileName">路径</param>
        /// <returns></returns>
        public static System.Data.DataTable ReadExcel(String strFileName)
        {
            Workbook book = new Workbook(strFileName);
            //book.Open(strFileName);
            Worksheet sheet = book.Worksheets[0];
            Cells cells = sheet.Cells;
            return cells.ExportDataTableAsString(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, true);
        }

        private void txtUrl_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = false;
                fileDialog.Title = "请选择文件";
                fileDialog.Filter = "所有Excel文件|*.XLSX;*.XLS;*.xlsx;*.xls";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = fileDialog.FileName;
                    txtUrl.Text = file;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 相邻钢种导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // DataTable dt = OpenExcelFile(this.txtUrl.Text, "Sheet2");
                DataTable dt = ReadExcel(this.txtUrl.Text);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string strGUID = System.Guid.NewGuid().ToString();

                        string jhgz = Regex.Replace(dt.Rows[i][0].ToString(), @"\s", ""); //计划钢种
                        string jhbz = Regex.Replace(dt.Rows[i][1].ToString(), @"\s", "");//执行标准 
                        string STLGRD = Regex.Replace(dt.Rows[i][2].ToString(), @"\s", ""); //相邻钢种
                        string STD = Regex.Replace(dt.Rows[i][3].ToString(), @"\s", "");//相邻钢种执行标准  
                        Mod_TPB_STEEL_PRO_CONDITION model = bll_steel_pro.GetModel(jhgz, jhbz);
                        string zbID = "";//钢种生产条件表主键
                        if (model != null)
                        {
                            zbID = model.C_ID;
                            Mod_TPB_BORDER_GRD modis = bll_border_grd.GetModel_GZ(STLGRD, STD, zbID);
                            if (modis == null)
                            {
                                Mod_TPB_BORDER_GRD modb = new Mod_TPB_BORDER_GRD();
                                modb.C_ID = strGUID;
                                modb.C_PRO_CONDITION_ID = zbID;
                                modb.C_BORDER_STL_GRD = STLGRD.Trim();
                                modb.C_BORDER_STD_CODE = STD.Trim();
                                modb.C_SLAB_REQUIRE = dt.Rows[i][4].ToString().Trim();//拨坯要求 
                                int result = 0;
                                if (int.TryParse(dt.Rows[i][5].ToString(), out result))
                                {
                                    modb.N_LEVEL = 0;
                                }
                                else
                                {
                                    modb.N_LEVEL = Convert.ToDecimal(dt.Rows[i][5]);//优先级 
                                }

                                modb.C_EMP_ID = RV.UI.UserInfo.UserID;
                                bll_border_grd.Add(modb);
                            }

                        }
                    }
                    MessageBox.Show("导入成功！");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 涮槽钢种导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                // DataTable dt = OpenExcelFile(this.txtUrl.Text, "Sheet2");
                DataTable dt = ReadExcel(this.txtUrl.Text);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string strGUID = System.Guid.NewGuid().ToString();

                        string jhgz = Regex.Replace(dt.Rows[i][0].ToString(), @"\s", "");//计划钢种
                        string jhbz = Regex.Replace(dt.Rows[i][1].ToString(), @"\s", "");//计划文件号
                        string STLGRD = Regex.Replace(dt.Rows[i][2].ToString(), @"\s", "");//涮槽钢种
                        string STD = Regex.Replace(dt.Rows[i][3].ToString(), @"\s", "");//涮槽钢种执行标准
                        Mod_TPB_STEEL_PRO_CONDITION model = bll_steel_pro.GetModel(jhgz, jhbz);
                        string zbID = "";//钢种生产条件表主键
                        if (model != null)
                        {
                            zbID = model.C_ID;
                            Mod_TPB_RINSE_GRD modis = bll_rinse.GetModel_GZ(STLGRD, STD, zbID);
                            if (modis == null)
                            {
                                Mod_TPB_RINSE_GRD modb = new Mod_TPB_RINSE_GRD();
                                modb.C_ID = strGUID;
                                modb.C_PRO_CONDITION_ID = zbID;
                                modb.C_RINSE_GRD = STLGRD.Trim();
                                modb.C_RINSE_STD_CODE = STD.Trim();
                                int result = 0;
                                if (int.TryParse(dt.Rows[i][4].ToString(), out result))
                                {
                                    modb.N_LEVEL = 0;
                                }
                                else
                                {
                                    modb.N_LEVEL = Convert.ToDecimal(dt.Rows[i][4]);//优先级 
                                }
                                modb.C_REMARK = dt.Rows[i][5].ToString().Trim();
                                modb.C_EMP_ID = RV.UI.UserInfo.UserID;
                                bll_rinse.Add(modb);
                            }


                        }
                    }
                    MessageBox.Show("导入成功！");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 首尾炉导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ReadExcel(this.txtUrl.Text);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string strGUID = System.Guid.NewGuid().ToString();

                        string jhgz = Regex.Replace(dt.Rows[i][0].ToString(), @"\s", "");//计划钢种
                        string jhbz = Regex.Replace(dt.Rows[i][1].ToString(), @"\s", "");//计划文件号
                        string isswl = Regex.Replace(dt.Rows[i][2].ToString(), @"\s", "");//首尾炉标识
                        string swgz = Regex.Replace(dt.Rows[i][3].ToString(), @"\s", "");//首尾炉钢种
                        string swbz = Regex.Replace(dt.Rows[i][4].ToString(), @"\s", "");//首尾炉标准
                        Mod_TPB_STEEL_PRO_CONDITION model = bll_steel_pro.GetModel(jhgz, jhbz);
                        string zbID = "";//钢种生产条件表主键
                        if (model != null)
                        {
                            zbID = model.C_ID;
                            Mod_TPB_ENDTOEND_GRD modis = bll_endtoend.GetModel_GZ(swgz, swbz, zbID);
                            if (modis == null)
                            {
                                Mod_TPB_ENDTOEND_GRD mod = new Mod_TPB_ENDTOEND_GRD();
                                mod.C_ID = strGUID;
                                mod.C_PRO_CONDITION_ID = zbID;
                                mod.C_B_E_STOVE = isswl.Trim();
                                mod.C_B_E_STOVE_STEEL = swgz.Trim();
                                mod.C_BORDER_STD_CODE = swbz;
                                mod.C_BORDER_STD_CODE = swbz;
                                int result = 0;
                                if (int.TryParse(dt.Rows[i][5].ToString(), out result))
                                {
                                    mod.N_LEVEL = 0;
                                }
                                else
                                {
                                    mod.N_LEVEL = Convert.ToDecimal(dt.Rows[i][5]);//优先级 
                                }
                                mod.C_REMARK = dt.Rows[i][6].ToString().Trim();
                                mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                                bll_endtoend.Add(mod);
                            }
                        }
                    }
                    MessageBox.Show("导入成功！");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 铁水条件导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                // DataTable dt = OpenExcelFile(this.txtUrl.Text, "Sheet2");
                DataTable dt = ReadExcel(this.txtUrl.Text);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string strGUID = System.Guid.NewGuid().ToString();

                        string jhgz = Regex.Replace(dt.Rows[i][0].ToString(), @"\s", "");//计划钢种
                        string jhbz = Regex.Replace(dt.Rows[i][1].ToString(), @"\s", "");//计划文件号 
                        string name= dt.Rows[i][2].ToString().Trim();//成分名称
                        int result = 0;
                        decimal values = 0;
                        if (int.TryParse(dt.Rows[i][3].ToString(), out result))
                        {
                            values = 0;
                        }
                        else
                        {
                            values = Convert.ToDecimal(dt.Rows[i][3]);
                        }
                        
                        Mod_TPB_STEEL_PRO_CONDITION model = bll_steel_pro.GetModel(jhgz, jhbz);
                        string zbID = "";//钢种生产条件表主键
                        if (model != null)
                        {
                            zbID = model.C_ID;
                            Mod_TQB_TSBZ_CF modis = bll_tstj_cf.GetModel_GZ(name, values, zbID);
                            if (modis == null)
                            {
                                Mod_TQB_TSBZ_CF modb = new Mod_TQB_TSBZ_CF();
                                modb.C_ID = strGUID;
                                modb.C_PRO_CONDITION_ID = zbID;
                                modb.C_STL_GRD = jhgz.Trim();
                                modb.C_STD_CODE = jhbz.Trim();
                                modb.C_NAME = dt.Rows[i][2].ToString().Trim(); 
                                modb.N_TARGET_VALUE = values; 
                                modb.C_REMARK = dt.Rows[i][4].ToString().Trim();
                                modb.C_EMP_ID = RV.UI.UserInfo.UserID;
                                bll_tstj_cf.Add(modb);
                            }
                        }
                    }
                    MessageBox.Show("导入成功！");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 钢包条件导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                // DataTable dt = OpenExcelFile(this.txtUrl.Text, "Sheet2");
                DataTable dt = ReadExcel(this.txtUrl.Text);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string strGUID = System.Guid.NewGuid().ToString();

                        string jhgz = Regex.Replace(dt.Rows[i][0].ToString(), @"\s", "");//计划钢种
                        string jhbz = Regex.Replace(dt.Rows[i][1].ToString(), @"\s", "");//计划文件号 
                        Mod_TPB_STEEL_PRO_CONDITION model = bll_steel_pro.GetModel(jhgz, jhbz);
                        string zbID = "";//钢种生产条件表主键
                        if (model != null)
                        {
                            zbID = model.C_ID; 
                            Mod_TPB_LADLE modb = new Mod_TPB_LADLE();
                            modb.C_ID = strGUID;
                            modb.C_PRO_CONDITION_ID = zbID;
                            modb.C_LADLE = dt.Rows[i][2].ToString().Trim();
                            modb.C_REMARK = dt.Rows[i][3].ToString().Trim();
                            modb.C_EMP_ID = RV.UI.UserInfo.UserID;
                            bll_ladle.Add(modb);


                        }
                    }
                    MessageBox.Show("导入成功！");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gv_Main_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            try
            {
                NewMethod6();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Common.OutToExcel.ToExcel(this.gc_Main);
            // Common.OutToExcel.OutFileToDisk(this, dtmain);
        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("是否停用？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                {
                    Bll_Common bll_common = new Bll_Common();
                    DataRow dr = gv_Main.GetDataRow(gv_Main.FocusedRowHandle);
                    if (dr != null)
                    {
                        if (bll_common.DataDisabled("TPB_STEEL_PRO_CONDITION", dr["C_ID"].ToString(), RV.UI.UserInfo.userID, RV.UI.ServerTime.timeNow()))
                        {
                            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "停用钢种生产条件");//添加操作日志
                            MessageBox.Show("已停用！");
                            btn_Query_Click(null, null);
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
        /// 复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Copy_Add_Click(object sender, EventArgs e)
        {

            try
            {
                DataRow dr = this.gv_Main.GetDataRow(this.gv_Main.FocusedRowHandle);
                if (dr != null)
                {
                    if (DialogResult.OK != MessageBox.Show("是否确认复制？", "提示", MessageBoxButtons.OKCancel))
                    {
                        return;
                    }
                    string strID = "";
                    #region 钢种生产条件主表复制添加
                    Mod_TPB_STEEL_PRO_CONDITION mod = new Mod_TPB_STEEL_PRO_CONDITION();
                    Mod_TPB_STEEL_PRO_CONDITION mod_log = bll_steel_pro.GetModel(dr["C_ID"].ToString());
                    mod.C_ID = Guid.NewGuid().ToString();
                    mod.C_STD_CODE = mod_log.C_STD_CODE;
                    mod.C_STL_GRD_TYPE = mod_log.C_STL_GRD_TYPE;
                    mod.C_STL_GRD_RANK = mod_log.C_STL_GRD_RANK;
                    mod.C_STL_GRD = mod_log.C_STL_GRD;
                    mod.C_STL_SCRAP_TYPE = mod_log.C_STL_SCRAP_TYPE;
                    mod.C_STL_SCRAP_FLIJ = mod_log.C_STL_SCRAP_FLIJ;
                    mod.C_GOUTE = mod_log.C_GOUTE;
                    mod.C_TEASE_PERSON = mod_log.C_TEASE_PERSON;
                    mod.C_ADV_PRO_REQUIRE = mod_log.C_ADV_PRO_REQUIRE;
                    mod.C_REMARK = mod_log.C_REMARK;
                    mod.C_EMP_ID = RV.UI.UserInfo.UserID;
                    mod.D_MOD_DT = RV.UI.ServerTime.timeNow();
                    mod.C_IS_BXG = mod_log.C_IS_BXG;
                    mod.N_STATUS = 0;
                    bll_steel_pro.Add(mod);
                    strID = mod.C_ID;
                    #endregion

                    #region 相邻钢种复制添加
                    for (int i = 0; i < gv_TPB_BORDER_GRD.DataRowCount; i++)
                    {
                        DataRow dr_GRD = this.gv_TPB_BORDER_GRD.GetDataRow(i);
                        Mod_TPB_BORDER_GRD mod_GRD = new Mod_TPB_BORDER_GRD();
                        mod_GRD.C_BORDER_STL_GRD = dr_GRD["C_BORDER_STL_GRD"].ToString();
                        mod_GRD.C_BORDER_STD_CODE = dr_GRD["C_BORDER_STD_CODE"].ToString();
                        if (!string.IsNullOrEmpty(dr_GRD["N_LEVEL"].ToString()))
                        {
                            mod_GRD.N_LEVEL = Convert.ToDecimal(dr_GRD["N_LEVEL"]);
                        }
                        else
                        {
                            mod_GRD.N_LEVEL = null;
                        }

                        mod_GRD.C_PRO_CONDITION_ID = strID;
                        mod_GRD.C_SLAB_REQUIRE = dr_GRD["C_SLAB_REQUIRE"].ToString();
                        mod_GRD.C_EMP_ID = RV.UI.UserInfo.userID;
                        mod_GRD.C_REMARK = dr_GRD["C_REMARK"].ToString();
                        bll_border_grd.Add(mod_GRD);

                    }
                    #endregion

                    #region 浇次首尾炉钢种复制添加
                    for (int i = 0; i < gv_TPB_ENDTOEND_GRD.DataRowCount; i++)
                    {
                        DataRow dr_ENDTOEND = this.gv_TPB_ENDTOEND_GRD.GetDataRow(i);
                        Mod_TPB_ENDTOEND_GRD mod_ENDTOEND = new Mod_TPB_ENDTOEND_GRD();
                        mod_ENDTOEND.C_B_E_STOVE = dr_ENDTOEND["C_B_E_STOVE"].ToString();
                        mod_ENDTOEND.C_B_E_STOVE_STEEL = dr_ENDTOEND["C_B_E_STOVE_STEEL"].ToString();
                        mod_ENDTOEND.C_BORDER_STD_CODE = dr_ENDTOEND["C_BORDER_STD_CODE"].ToString();
                        if (!string.IsNullOrEmpty(dr_ENDTOEND["N_LEVEL"].ToString()))
                        {
                            mod_ENDTOEND.N_LEVEL = Convert.ToDecimal(dr_ENDTOEND["N_LEVEL"]);
                        }
                        else
                        {
                            mod_ENDTOEND.N_LEVEL = null;
                        }

                        mod_ENDTOEND.C_PRO_CONDITION_ID = strID;
                        mod_ENDTOEND.C_EMP_ID = RV.UI.UserInfo.userID;
                        mod_ENDTOEND.C_REMARK = dr_ENDTOEND["C_REMARK"].ToString();
                        bll_endtoend.Add(mod_ENDTOEND);

                    }
                    #endregion

                    #region 涮槽钢种复制添加
                    for (int i = 0; i < gv_TPB_RINSE_GRD.DataRowCount; i++)
                    {
                        DataRow dr_RINSE_GRD = this.gv_TPB_RINSE_GRD.GetDataRow(i);
                        Mod_TPB_RINSE_GRD mod_RINSE_GRD = new Mod_TPB_RINSE_GRD();
                        mod_RINSE_GRD.C_RINSE_GRD = dr_RINSE_GRD["C_RINSE_GRD"].ToString();
                        mod_RINSE_GRD.C_RINSE_STD_CODE = dr_RINSE_GRD["C_RINSE_STD_CODE"].ToString();
                        if (!string.IsNullOrEmpty(dr_RINSE_GRD["N_LEVEL"].ToString()))
                        {
                            mod_RINSE_GRD.N_LEVEL = Convert.ToDecimal(dr_RINSE_GRD["N_LEVEL"]);
                        }
                        else
                        {
                            mod_RINSE_GRD.N_LEVEL = null;
                        }

                        mod_RINSE_GRD.C_PRO_CONDITION_ID = strID;
                        mod_RINSE_GRD.C_EMP_ID = RV.UI.UserInfo.userID;
                        mod_RINSE_GRD.C_REMARK = dr_RINSE_GRD["C_REMARK"].ToString();
                        bll_rinse.Add(mod_RINSE_GRD);

                    }
                    #endregion
                    #region 铁水条件复制添加
                    for (int i = 0; i < gv_tqb_tstj_cf.DataRowCount; i++)
                    {
                        DataRow dr_TSBZ_CF = this.gv_tqb_tstj_cf.GetDataRow(i);
                        Mod_TQB_TSBZ_CF mod_TSBZ_CF = new Mod_TQB_TSBZ_CF();
                        mod_TSBZ_CF.C_CHARACTER_ID = dr_TSBZ_CF["C_CHARACTER_ID"].ToString();
                        mod_TSBZ_CF.C_CODE = dr_TSBZ_CF["C_CODE"].ToString();
                        mod_TSBZ_CF.C_NAME = dr_TSBZ_CF["C_NAME"].ToString();
                        mod_TSBZ_CF.C_STL_GRD = dr_TSBZ_CF["C_STL_GRD"].ToString();
                        mod_TSBZ_CF.C_STD_CODE = dr_TSBZ_CF["C_STD_CODE"].ToString();
                        if (!string.IsNullOrEmpty(dr_TSBZ_CF["N_TARGET_VALUE"].ToString()))
                        {
                            mod_TSBZ_CF.N_TARGET_VALUE = Convert.ToDecimal(dr_TSBZ_CF["N_TARGET_VALUE"]);
                        }
                        else
                        {
                            mod_TSBZ_CF.N_TARGET_VALUE = null;
                        }

                        mod_TSBZ_CF.C_PRO_CONDITION_ID = strID;
                        mod_TSBZ_CF.C_EMP_ID = RV.UI.UserInfo.userID;
                        mod_TSBZ_CF.C_REMARK = dr_TSBZ_CF["C_REMARK"].ToString();
                        bll_tstj_cf.Add(mod_TSBZ_CF);

                    }
                    #endregion

                    #region 钢包条件复制添加
                    for (int i = 0; i < gv_TPB_LADLE.DataRowCount; i++)
                    {
                        DataRow dr_LADLE = this.gv_TPB_LADLE.GetDataRow(i);
                        Mod_TPB_LADLE mod_LADLE = new Mod_TPB_LADLE();
                        mod_LADLE.C_STD_CODE = dr_LADLE["C_STD_CODE"].ToString();
                        mod_LADLE.C_LADLE = dr_LADLE["C_LADLE"].ToString();
                        mod_LADLE.C_PRO_CONDITION_ID = strID;
                        mod_LADLE.C_EMP_ID = RV.UI.UserInfo.userID;
                        mod_LADLE.C_REMARK = dr_LADLE["C_REMARK"].ToString();
                        bll_ladle.Add(mod_LADLE);

                    }
                    #endregion

                    str_cid = strID;
                    FrmPB_GZSCTJWH frm = new FrmPB_GZSCTJWH(strPhyCode);
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        frm.Close();
                        btn_Query_Click(null, null);

                        Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "修改钢种生产条件");//添加操作日志
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
