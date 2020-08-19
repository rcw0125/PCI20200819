using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aspose.Cells;
using MODEL;
using BLL;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_BZDR : Form
    {
        private Bll_TQB_STD_SPEC bllSpec = new Bll_TQB_STD_SPEC();
        private Bll_TQB_STD_MAIN bllMain = new Bll_TQB_STD_MAIN();
        private Bll_TQB_STD_CFXN bllCFXN = new Bll_TQB_STD_CFXN();
        private Bll_TQB_CHARACTER bllCharacter = new Bll_TQB_CHARACTER();
        private Bll_TQB_SAMPLING bllSampling = new Bll_TQB_SAMPLING();
        private Bll_TQB_STD_SAMPLING bllStdSampling = new Bll_TQB_STD_SAMPLING();

        private string strMenuName;


        public FrmQB_BZDR()
        {
            InitializeComponent();
        }
        private void FrmQB_BZDR_Load(object sender, EventArgs e)
        {

            strMenuName = RV.UI.UserInfo.menuName;

        }

        /// <summary>
        ///  获取Excel中的数据，根据Sheet名字获取数据
        /// </summary>
        /// <param name="excelPath">文件路径</param>
        /// <param name="sheetName">需要打开的sheet名称</param>
        /// <returns></returns>
        public static DataTable OpenExcelFile(string excelPath, string sheetName)
        {
            DataSet ds = new DataSet();
            Workbook workBook = new Workbook(excelPath);
            Worksheet workSheet = workBook.Worksheets[sheetName];
            Cells cell = workSheet.Cells;
            DataTable dt = new DataTable();
            int count = cell.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                string str = cell.GetRow(0)[i].StringValue;
                dt.Columns.Add(new DataColumn(str));
            }
            for (int i = 1; i < cell.Rows.Count; i++)//第一行为表头行，不取
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < count; j++)
                {
                    dr[j] = cell[i, j].StringValue;
                }
                dt.Rows.Add(dr);
            }
            dt.AcceptChanges();
            //ds.Tables.Add(dt);
            return dt;
        }

        private void btn_Bz_Click(object sender, EventArgs e)
        {
            //DataTable dt = OpenExcelFile(this.txtUrl.Text, "执行标准主表信息");
            //if (dt.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        string strGUID = System.Guid.NewGuid().ToString();
            //        Mod_TQB_TSBZ_MAIN model = new Mod_TQB_TSBZ_MAIN();
            //        model.C_ID = strGUID;//主键
            //        model.C_PROD_KIND = dt.Rows[i][0].ToString();//钢种分类
            //        model.C_STL_GRD = dt.Rows[i][1].ToString();//钢种
            //        model.C_XY_CODE = dt.Rows[i][2].ToString();//协议号
            //        model.C_ROUTE = dt.Rows[i][3].ToString();//工艺
            //        model.C_REMARK = dt.Rows[i][4].ToString();//备注
            //        model.C_IS_OFTEN = dt.Rows[i][5].ToString();//是否常用
            //        model.C_REMARK_JB = dt.Rows[i][6].ToString();//备注级别
            //        model.C_EMP_ID = RV.UI.UserInfo.userID;
            //        bool res = bllTsbz_Main.Add(model);
            //        if (res)
            //        {
            //            for (int j = 7; j < 28; j++)//成分信息
            //            {
            //                string nvalue = dt.Rows[i][j].ToString().Trim();
            //                if (nvalue != "")
            //                {
            //                    string itemName = dt.Columns[j].ColumnName;
            //                    Mod_TQB_TSBZ_CF modcf = new Mod_TQB_TSBZ_CF();
            //                    modcf.C_TSBZ_MAIN_ID = strGUID;
            //                    modcf.C_EMP_ID = RV.UI.UserInfo.userID;
            //                    modcf.C_NAME = itemName;
            //                    try
            //                    {
            //                        modcf.N_TARGET_VALUE = Convert.ToDecimal(nvalue);
            //                    }
            //                    catch (Exception)
            //                    {

            //                        modcf.N_TARGET_VALUE = -1;
            //                    }
            //                    bool rescf = bllTsbz_CF.Add(modcf);
            //                }

            //            }
            //        }


            //    }

            //}
        }

        /// <summary>
        /// 导入规格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GG_Click(object sender, EventArgs e)
        {
            DataTable dt = OpenExcelFile(this.txtUrl.Text, "执行标准钢种规格");
            StringBuilder strLog = new StringBuilder();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataTable dtMain = bllMain.GetList_ID(dt.Rows[i]["备注"].ToString().Trim(), dt.Rows[i]["钢种"].ToString().Trim()).Tables[0];

                    if (dtMain.Rows.Count > 0)
                    {
                        //continue;

                        string[] strs = dt.Rows[i][0].ToString().Split('、');

                        string s_id = dtMain.Rows[0]["C_ID"].ToString();

                        if (!string.IsNullOrEmpty(dt.Rows[i][0].ToString().Trim()))
                        {
                            for (int k = 0; k < strs.Length; k++)
                            {
                                try
                                {
                                    //判断是否有重复
                                    if (bllSpec.Exists(s_id, strs[k].Trim()))
                                    {
                                        continue;
                                    }

                                    Mod_TQB_STD_SPEC model = new Mod_TQB_STD_SPEC();
                                    model.C_STD_MAIN_ID = s_id;
                                    model.C_SPEC = strs[k].Trim();
                                    model.C_REMARK = dt.Rows[i]["备注"].ToString().Trim();
                                    model.C_EMP_ID = "222";
                                    bool res = bllSpec.Add(model);

                                    if (!res)
                                    {
                                        strLog.Append("添加失败：" + s_id + "   " + strs[k] + "   " + dt.Rows[i]["备注"].ToString() + "\t");
                                    }
                                }
                                catch
                                {
                                    strLog.Append("添加失败：" + s_id + "   " + strs[k] + "   " + dt.Rows[i]["备注"].ToString() + "\t");
                                }
                            }
                        }
                    }
                    else
                    {
                        //strLog.Append("添加失败：" + dt.Rows[i]["备注"].ToString() + "   " + dt.Rows[i]["钢种"].ToString() + "\t");
                    }
                }

                strLog.Append("导入完成！");

                rtxt_Log.Text = strLog.ToString();

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "导入规格");//添加操作日志
            }
        }

        /// <summary>
        /// 导入成分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CF_Click(object sender, EventArgs e)
        {
            DataTable dt = OpenExcelFile(this.txtUrl.Text, "执行标准成分标准信息");

            StringBuilder strLog = new StringBuilder();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataTable dtMain = bllMain.GetList_ID(dt.Rows[i]["标准代码"].ToString(), dt.Rows[i]["钢种"].ToString()).Tables[0];

                    if (dtMain.Rows.Count > 0)
                    {
                        string C_CHARACTER_ID = bllCharacter.GetItemID(dt.Rows[i]["项目名称"].ToString());

                        if (!string.IsNullOrEmpty(C_CHARACTER_ID))
                        {
                            //continue;

                            try
                            {
                                if (bllCFXN.Exists(dtMain.Rows[0]["C_ID"].ToString(), C_CHARACTER_ID))
                                {
                                    continue;
                                }

                                Mod_TQB_STD_CFXN model = new Mod_TQB_STD_CFXN();
                                model.C_STD_MAIN_ID = dtMain.Rows[0]["C_ID"].ToString();
                                model.C_CHARACTER_ID = C_CHARACTER_ID;

                                if (!string.IsNullOrEmpty(dt.Rows[i]["最小值"].ToString()))
                                {
                                    model.C_TARGET_MIN = dt.Rows[i]["最小值"].ToString();
                                }

                                model.C_TARGET_INTERVAL = dt.Rows[i]["开闭区间"].ToString();

                                if (!string.IsNullOrEmpty(dt.Rows[i]["最大值"].ToString()))
                                {
                                    model.C_TARGET_MAX = dt.Rows[i]["最大值"].ToString();
                                }

                                model.C_PREWARNING_VALUE = dt.Rows[i]["预警值"].ToString();
                                model.C_TYPE = dt.Rows[i]["项目类型"].ToString();

                                if (!string.IsNullOrEmpty(dt.Rows[i]["是否判定"].ToString()))
                                {
                                    model.C_IS_DECIDE = dt.Rows[i]["是否判定"].ToString();
                                }

                                if (!string.IsNullOrEmpty(dt.Rows[i]["是否打印"].ToString()))
                                {
                                    model.C_IS_PRINT = dt.Rows[i]["是否打印"].ToString() == "N" ? "否" : "是";
                                }

                                if (!string.IsNullOrEmpty(dt.Rows[i]["打印顺序"].ToString()))
                                {
                                    model.N_PRINT_ORDER = Convert.ToDecimal(dt.Rows[i]["打印顺序"].ToString());
                                }

                                if (!string.IsNullOrEmpty(dt.Rows[i]["规格最小"].ToString()))
                                {
                                    model.N_SPEC_MIN = Convert.ToDecimal(dt.Rows[i]["规格最小"].ToString());
                                }

                                model.C_SPEC_INTERVAL = dt.Rows[i]["规格区间"].ToString();

                                if (!string.IsNullOrEmpty(dt.Rows[i]["规格最大"].ToString()))
                                {
                                    model.N_SPEC_MAX = Convert.ToDecimal(dt.Rows[i]["规格最大"].ToString());
                                }

                                model.C_FORMULA = dt.Rows[i]["计算公式"].ToString();
                                model.C_UNIT = dt.Rows[i]["单位(种类)"].ToString();

                                if (!string.IsNullOrEmpty(dt.Rows[i]["小数位数"].ToString()))
                                {
                                    model.N_DIGIT = Convert.ToDecimal(dt.Rows[i]["小数位数"].ToString());
                                }

                                model.C_QUANTITATIVE = dt.Rows[i]["定性/定量"].ToString();
                                model.C_TEST_TEM = dt.Rows[i]["试验温度"].ToString();
                                model.C_TEST_CONDITION = dt.Rows[i]["试验条件"].ToString();
                                model.C_EMP_ID = "222";

                                bool res = bllCFXN.Add(model);

                                rtxt_Log.Text = strLog.ToString();
                            }
                            catch
                            {

                                strLog.Append("添加失败：" + dt.Rows[i]["标准代码"].ToString() + dt.Rows[i]["钢种"].ToString() + dt.Rows[i]["项目名称"].ToString() + "\n");
                            }
                        }
                        else
                        {
                            strLog.Append("添加失败：" + dt.Rows[i]["项目名称"].ToString() + "\n");
                        }
                    }
                }

                strLog.Append("导入完成！");

                rtxt_Log.Text = strLog.ToString();

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "导入成分");//添加操作日志

            }
        }

        /// <summary>
        /// 导入性能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_XN_Click(object sender, EventArgs e)
        {
            DataTable dt = OpenExcelFile(this.txtUrl.Text, "执行标准性能标准信息");

            StringBuilder strLog = new StringBuilder();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataTable dtMain = bllMain.GetList_ID(dt.Rows[i]["协议号"].ToString(), dt.Rows[i]["钢种"].ToString()).Tables[0];

                    if (dtMain.Rows.Count > 0)
                    {
                        if (dt.Rows[i]["项目类型"].ToString().Trim() == "性能")
                        {
                            string C_CHARACTER_ID = bllCharacter.GetItemID(dt.Rows[i]["项目名称"].ToString().Trim());

                            if (!string.IsNullOrEmpty(C_CHARACTER_ID))
                            {
                                //continue;

                                try
                                {
                                    Mod_TQB_STD_CFXN model = new Mod_TQB_STD_CFXN();
                                    model.C_STD_MAIN_ID = dtMain.Rows[0]["C_ID"].ToString();
                                    model.C_CHARACTER_ID = C_CHARACTER_ID;

                                    if (!string.IsNullOrEmpty(dt.Rows[i]["最小值"].ToString()))
                                    {
                                        model.C_TARGET_MIN = dt.Rows[i]["最小值"].ToString();
                                    }

                                    model.C_TARGET_INTERVAL = dt.Rows[i]["开闭区间"].ToString();

                                    if (!string.IsNullOrEmpty(dt.Rows[i]["最大值"].ToString()))
                                    {
                                        model.C_TARGET_MAX = dt.Rows[i]["最大值"].ToString();
                                    }

                                    model.C_PREWARNING_VALUE = dt.Rows[i]["预警值"].ToString();
                                    model.C_TYPE = dt.Rows[i]["项目类型"].ToString();

                                    if (!string.IsNullOrEmpty(dt.Rows[i]["是否判定"].ToString()))
                                    {
                                        model.C_IS_DECIDE = dt.Rows[i]["是否判定"].ToString();
                                    }

                                    if (!string.IsNullOrEmpty(dt.Rows[i]["是否打印"].ToString()))
                                    {
                                        model.C_IS_PRINT = dt.Rows[i]["是否打印"].ToString() == "N" ? "否" : "是";
                                    }

                                    if (!string.IsNullOrEmpty(dt.Rows[i]["打印顺序"].ToString()))
                                    {
                                        model.N_PRINT_ORDER = Convert.ToDecimal(dt.Rows[i]["打印顺序"].ToString());
                                    }

                                    if (!string.IsNullOrEmpty(dt.Rows[i]["规格最小"].ToString()))
                                    {
                                        model.N_SPEC_MIN = Convert.ToDecimal(dt.Rows[i]["规格最小"].ToString());
                                    }

                                    model.C_SPEC_INTERVAL = dt.Rows[i]["规格区间"].ToString();

                                    if (!string.IsNullOrEmpty(dt.Rows[i]["规格最大"].ToString()))
                                    {
                                        model.N_SPEC_MAX = Convert.ToDecimal(dt.Rows[i]["规格最大"].ToString());
                                    }

                                    model.C_FORMULA = dt.Rows[i]["计算公式"].ToString();
                                    model.C_UNIT = dt.Rows[i]["单位(种类)"].ToString();

                                    if (!string.IsNullOrEmpty(dt.Rows[i]["小数位数"].ToString()))
                                    {
                                        model.N_DIGIT = Convert.ToDecimal(dt.Rows[i]["小数位数"].ToString());
                                    }

                                    model.C_QUANTITATIVE = dt.Rows[i]["定性/定量"].ToString();
                                    model.C_TEST_TEM = dt.Rows[i]["试验温度"].ToString();
                                    model.C_TEST_CONDITION = dt.Rows[i]["试验条件"].ToString();
                                    model.C_EMP_ID = "888";

                                    bool res = bllCFXN.Add(model);

                                    rtxt_Log.Text = strLog.ToString();
                                }
                                catch
                                {

                                    strLog.Append("添加失败：" + dt.Rows[i]["协议号"].ToString() + dt.Rows[i]["钢种"].ToString() + dt.Rows[i]["项目名称"].ToString() + "\n");
                                }
                            }
                            else
                            {
                                strLog.Append("添加失败：" + dt.Rows[i]["项目名称"].ToString() + "\n");
                            }

                        }
                    }
                    else
                    {
                        strLog.Append("添加失败：" + dt.Rows[i]["协议号"].ToString() + "    " + dt.Rows[i]["钢种"].ToString() + "\n");
                    }
                }

                strLog.Append("导入完成！");

                rtxt_Log.Text = strLog.ToString();

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "导入性能");//添加操作日志

            }
        }


        /// <summary>
        /// 导入取样
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_QY_Click(object sender, EventArgs e)
        {
            DataTable dt = OpenExcelFile(this.txtUrl.Text, "执行标准取样标准信息");

            StringBuilder strLog = new StringBuilder();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataTable dtMain = bllMain.GetList_ID(dt.Rows[i]["协议号"].ToString(), dt.Rows[i]["钢种"].ToString()).Tables[0];

                    if (dtMain.Rows.Count > 0)
                    {
                        string C_Samp_Id = bllSampling.GetSampId(dt.Rows[i]["检验项目"].ToString(),"");

                        if (!string.IsNullOrEmpty(C_Samp_Id))
                        {
                            //continue;

                            try
                            {
                                Mod_TQB_STD_SAMPLING model = new Mod_TQB_STD_SAMPLING();
                                model.C_STD_MAIN_ID = dtMain.Rows[0]["C_ID"].ToString();
                                model.C_SAMPLING_ID = C_Samp_Id;

                                model.C_NUMBER = dt.Rows[i]["序列号"].ToString();
                                model.C_SAM_SPE = dt.Rows[i]["取样规格 直接/宽*厚"].ToString();
                                model.C_SAM_LEN = dt.Rows[i]["取样长度"].ToString();
                                model.C_SAM_METHOD = dt.Rows[i]["取样方法"].ToString();
                                model.C_SAM_NUM = dt.Rows[i]["取样 数量"].ToString();
                                model.C_RECHECK_NUM = dt.Rows[i]["复验样 数量"].ToString();
                                model.C_NUM_UNIT = dt.Rows[i]["数量 单位"].ToString();
                                model.C_SAM_SECTION = dt.Rows[i]["取样部位"].ToString();
                                model.C_TEST_UNIT = dt.Rows[i]["试验方法"].ToString();
                                model.C_REMARK = dt.Rows[i]["备注"].ToString();
                                model.C_EMP_ID = "777";

                                bool res = bllStdSampling.Add(model);

                                rtxt_Log.Text = strLog.ToString();
                            }
                            catch
                            {

                                strLog.Append("添加失败：" + dt.Rows[i]["协议号"].ToString() + dt.Rows[i]["钢种"].ToString() + dt.Rows[i]["检验项目"].ToString() + "\n");
                            }
                        }
                        else
                        {
                            strLog.Append("添加失败：" + dt.Rows[i]["检验项目"].ToString() + "\n");
                        }
                    }
                }

                strLog.Append("导入完成！");

                rtxt_Log.Text = strLog.ToString();

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "导入取样");//添加操作日志

            }
        }

        private void txtUrl_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
    }
}
