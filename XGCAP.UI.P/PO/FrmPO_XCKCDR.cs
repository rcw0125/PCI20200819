using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using Common;
using Aspose.Cells;

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_XCKCDR : Form
    {

        private Bll_TPB_SLABWH Bll_TPB_SLABWH = new BLL.Bll_TPB_SLABWH();//钢坯库库信息
        private Bll_TPB_SLABWH_AREA Bll_TPB_SLABWH_AREA = new BLL.Bll_TPB_SLABWH_AREA();//钢坯库区域信息
        private Bll_TPB_SLABWH_LOC Bll_TPB_SLABWH_LOC = new BLL.Bll_TPB_SLABWH_LOC();//钢坯库库位信息
        private Bll_TPB_SLABWH_TIER bll_TPB_SLABWH_TIER = new BLL.Bll_TPB_SLABWH_TIER();//钢坯库层信息


        private Bll_TPB_LINEWH bll_linewh = new Bll_TPB_LINEWH();//仓库
        private Bll_TPB_LINEWH_AREA bll_area = new Bll_TPB_LINEWH_AREA();//区域
        private Bll_TPB_LINEWH_LOC bll_loc = new Bll_TPB_LINEWH_LOC();//库位
        private Bll_TPB_LINEWH_TIER bll_tier = new Bll_TPB_LINEWH_TIER();//层

        private string strMenuName;


        public FrmPO_XCKCDR()
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
            DataTable dt = OpenExcelFile(this.txtUrl.Text, "sheet1");
            StringBuilder strLog = new StringBuilder();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(dt.Rows[i][0].ToString().Trim()))
                    {
                        if (i > 0)
                        {
                            if (dt.Rows[i]["仓库编码"].ToString().Trim() == dt.Rows[i - 1]["仓库编码"].ToString().Trim())
                            {
                                continue;
                            }
                        }
                        try
                        {

                            Mod_TPB_LINEWH model = new Mod_TPB_LINEWH();

                            model.C_LINEWH_CODE = dt.Rows[i]["仓库编码"].ToString();
                            model.C_LINEWH_NAME = dt.Rows[i]["仓库描述"].ToString();

                            model.C_EMP_ID = "222";

                            bool res = bll_linewh.Add(model);

                            if (!res)
                            {
                                strLog.Append("添加失败");
                            }
                        }
                        catch
                        {
                            strLog.Append("添加失败");
                        }
                    }
                }
            }


            strLog.Append("导入完成！");

            rtxt_Log.Text = strLog.ToString();

            Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "导入库位");//添加操作日志
        }


        /// <summary>
        /// 导入区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GG_Click(object sender, EventArgs e)
        {
            DataTable dt = OpenExcelFile(this.txtUrl.Text, "sheet1");
            StringBuilder strLog = new StringBuilder();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataTable dtMain = bll_linewh.GetList_ID(dt.Rows[i]["仓库编码"].ToString(), dt.Rows[i]["仓库描述"].ToString()).Tables[0];

                    if (dtMain.Rows.Count > 0)
                    {


                        string s_id = dtMain.Rows[0]["C_ID"].ToString();

                        if (!string.IsNullOrEmpty(dt.Rows[i][0].ToString().Trim()))
                        {
                            if (i > 0)
                            {
                                if (dt.Rows[i]["区域编码"].ToString().Trim() == dt.Rows[i - 1]["区域编码"].ToString().Trim())
                                {
                                    continue;
                                }
                            }


                            try
                            {

                                Mod_TPB_LINEWH_AREA model = new Mod_TPB_LINEWH_AREA();
                                model.C_LINEWH_ID = s_id;
                                model.C_LINEWH_AREA_CODE = dt.Rows[i]["区域编码"].ToString();
                                model.C_LINEWH_AREA_NAME = dt.Rows[i]["区域描述"].ToString();
                                model.N_LINEWH_AREA_CAP = Convert.ToDecimal(dt.Rows[i]["区域容量"].ToString());
                                model.C_ISOUT = dt.Rows[i]["内外储放"].ToString();
                                model.C_LOADING_MODE = dt.Rows[i]["装车方式"].ToString();
                                model.C_TRANSPORT_MODE = dt.Rows[i]["运输方式"].ToString();
                                model.C_EMP_ID = "222";

                                bool res = bll_area.Add(model);

                                if (!res)
                                {
                                    strLog.Append("添加失败");
                                }
                            }
                            catch
                            {
                                strLog.Append("添加失败");
                            }
                        }
                    }
                }


                strLog.Append("导入完成！");

                rtxt_Log.Text = strLog.ToString();

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "导入库位");//添加操作日志
            }
        }

        /// <summary>
        /// 导入库位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CF_Click(object sender, EventArgs e)
        {
            DataTable dt = OpenExcelFile(this.txtUrl.Text, "sheet1");
            StringBuilder strLog = new StringBuilder();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataTable dtMain = bll_area.GetList_linewh_id(dt.Rows[i]["区域编码"].ToString(), dt.Rows[i]["区域描述"].ToString()).Tables[0];

                    if (dtMain.Rows.Count > 0)
                    {


                        string s_id = dtMain.Rows[0]["C_ID"].ToString();

                        if (!string.IsNullOrEmpty(dt.Rows[i][0].ToString().Trim()))
                        {



                            //try
                            //{

                             
//Convert.ToString( Convert.ToInt64(con)+y);

                                Mod_TPB_LINEWH_LOC model = new Mod_TPB_LINEWH_LOC();
                                model.C_LINEWH_AREA_ID = s_id;
                                model.C_LINEWH_LOC_CODE =dt.Rows[i]["库位编码"].ToString().Trim();
                                model.C_LINEWH_LOC_NAME = dt.Rows[i]["库位描述"].ToString().Trim();
                                model.N_QTY = 36;
                            model.C_REMARK = "232";

                                bool res = bll_loc.Add(model);

                                if (!res)
                                {
                                    strLog.Append("添加失败");
                                }
                                //}
                                //catch
                                //{
                                //    strLog.Append("添加失败");
                                //}
                            }
                        
                    }

                }
                strLog.Append("导入完成！");

                rtxt_Log.Text = strLog.ToString();

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "导入库位");//添加操作日志

            }
        }

        /// <summary>
        /// 导入层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_XN_Click(object sender, EventArgs e)
        {

            DataTable dt = OpenExcelFile(this.txtUrl.Text, "sheet1");
            StringBuilder strLog = new StringBuilder();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataTable dtMain = Bll_TPB_SLABWH_LOC.GetList_ID(dt.Rows[i]["库位编码"].ToString(), dt.Rows[i]["库位描述"].ToString()).Tables[0];

                    if (dtMain.Rows.Count > 0)
                    {


                        string s_id = dtMain.Rows[0]["C_ID"].ToString();

                        if (!string.IsNullOrEmpty(dt.Rows[i][0].ToString().Trim()))
                        {
                            string con = "";

                            for (int y = 0; y < Convert.ToInt32(dt.Rows[i]["层数"].ToString()); y++)
                            {
                                if (y >= 9)
                                {
                                    con = (y + 1).ToString();
                                }
                                else
                                {
                                    con = ("0" + (y + 1)).ToString();
                                }
                                con = dt.Rows[i]["库位编码"].ToString() + con;
                                Mod_TPB_SLABWH_TIER model = new Mod_TPB_SLABWH_TIER();
                                model.C_SLABWH_LOC_ID = s_id;
                                model.C_SLABWH_TIER_CODE = con;
                                model.N_SLABWH_TIER_NUM = Convert.ToDecimal(dt.Rows[i]["层支数"].ToString());
                                model.C_EMP_ID = "222";


                                bll_TPB_SLABWH_TIER.Add(model);
                            }

                        }
                    }
                }


                strLog.Append("导入完成！");

                rtxt_Log.Text = strLog.ToString();

                Common.UserLog.AddLog(strMenuName, this.Name, this.Text, "导入库位");//添加操作日志


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
