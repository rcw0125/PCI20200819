using Aspose.Cells;
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

namespace XGCAP.UI.P.PO
{
    public partial class FrmPO_Improt_Order : Form
    {
        public FrmPO_Improt_Order()
        {
            InitializeComponent();
        }

        private Bll_TMO_ORDER bllorder = new Bll_TMO_ORDER();
        private Bll_TB_MATRL_MAIN bllwl = new Bll_TB_MATRL_MAIN();
        private Bll_TQB_STD_MAIN bllbz = new Bll_TQB_STD_MAIN();//执行标准

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

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = ReadExcel(this.txtUrl.Text);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        #region 导入订单
                        string strGUID = System.Guid.NewGuid().ToString();
                        Mod_TMO_ORDER modorder = new Mod_TMO_ORDER();
                        modorder.C_ID = System.Guid.NewGuid().ToString();
                        modorder.C_ORDER_NO = dt.Rows[i]["计划订单号"].ToString();
                        modorder.D_DT = Convert.ToDateTime(dt.Rows[i]["计划日期"].ToString());
                        modorder.D_NEED_DT = Convert.ToDateTime(dt.Rows[i]["需求日期"].ToString());
                        modorder.D_DELIVERY_DT = Convert.ToDateTime(dt.Rows[i]["交货日期"].ToString());
                        modorder.C_MAT_CODE = dt.Rows[i]["物料编码"].ToString();
                        modorder.C_STL_GRD = dt.Rows[i]["型号"].ToString();
                        modorder.C_SPEC = dt.Rows[i]["规格"].ToString();
                        modorder.C_MAT_NAME = dt.Rows[i]["工艺代码"].ToString();
                        Mod_TB_MATRL_MAIN modwl = bllwl.GetModel(modorder.C_MAT_CODE);
                       
                        if (modwl != null)
                        {
                            modorder.C_INVBASDOCID = modwl.C_PK_INVBASDOC;
                            modorder.C_MAT_NAME = modwl.C_MAT_NAME;
                            modorder.C_SPEC = modwl.C_SPEC;
                            modorder.C_STL_GRD = modwl.C_STL_GRD;
                        }
                        else
                        {
                           // continue;
                        }
                        modorder.C_FREE1 = dt.Rows[i]["产品标准"].ToString();
                        modorder.C_FREE2 = dt.Rows[i]["技术要求"].ToString();

                        Mod_TQB_STD_MAIN modbz = bllbz.GetModel(modorder.C_STL_GRD, modorder.C_FREE1, modorder.C_FREE2);
                        if (modbz != null)
                        {
                            modorder.C_STD_CODE = modbz.C_STD_CODE;
                        }
                        // modorder.C_STD_CODE=
                        modorder.C_PACK = dt.Rows[i]["包装"].ToString();
                        modorder.N_WGT = Convert.ToDecimal(dt.Rows[i]["需求数量"].ToString());
                        

                        modorder.C_AREA = dt.Rows[i]["其他要求"].ToString();
                        modorder.C_TRANSMODE = dt.Rows[i]["内部备注"].ToString();
                        modorder.C_ORDER_LEV = dt.Rows[i]["订单级别"].ToString();
                        modorder.C_PRO_USE = dt.Rows[i]["客户用途"].ToString();
                        modorder.N_PROD_WGT=Convert.ToDecimal( dt.Rows[i]["完工数量"].ToString()==""?"0": dt.Rows[i]["完工数量"].ToString());
                        modorder.N_EXEC_STATUS = 0;//订单刚导入状态
                        modorder.N_TYPE = 8;//线材订单
                        modorder.N_STATUS = 2;//可执行
                        modorder.C_REMARK = "导入";//标志订单是导入的
                        modorder.C_CON_NO = (Convert.ToInt64(System.DateTime.Now.ToString("yyMMdd")+"0001") + i).ToString();

                        if (Convert.ToDouble(modorder.N_PROD_WGT)<Convert.ToDouble( modorder.N_WGT)*0.9)
                        {
                            modorder.N_WGT = modorder.N_WGT - modorder.N_PROD_WGT;
                            bllorder.Add(modorder);//生产量大于90%的视同完成
                        }
                      
                        #endregion

                    }
                    MessageBox.Show("订单导入成功！");
                    WaitingFrom.CloseWait();
                    btn_query_main_Click(null, null);
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
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_main_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            double? gg_min = null;//规格最小值
            if (this.txt_gg_min.Text.Trim() != "")
            {
                gg_min = Convert.ToDouble(this.txt_gg_min.Text.Trim());
            }
            double? gg_max = null;//规格最大值
            if (this.txt_gg_max.Text.Trim() != "" && Convert.ToDouble(this.txt_gg_max.Text.Trim()) > 0)
            {
                gg_max = Convert.ToDouble(this.txt_gg_max.Text.Trim());
            }
            int n_status = -1;
            if (this.rbtn_status.SelectedIndex == 0)
            {
                n_status = -1;
            }
            else
            {
                n_status = 0;
            }
            string strJQMin = this.dtp_form1.EditValue == null ? "" : this.dtp_form1.EditValue.ToString();
            string strJQMax = this.dtp_end1.EditValue == null ? "" : this.dtp_end1.EditValue.ToString();
            DataTable dtOrder = bllorder.GetImporyOrder("N", 2, n_status, this.txt_gz1.Text.Trim(), this.txt_zxbz1.Text.Trim(), gg_min, gg_max, "导入", strJQMin, strJQMax).Tables[0];

            this.gc_tmo_order.DataSource = dtOrder;
            this.gv_tmo_order.OptionsView.ColumnAutoWidth = false;
            this.gv_tmo_order.OptionsSelection.MultiSelect = true;
            gv_tmo_order.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            SetGridViewRowNum.SetRowNum(gv_tmo_order);
            this.gv_tmo_order.BestFitColumns();
            WaitingFrom.CloseWait();
        }
        /// <summary>
        ///导入备坯计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_import_gp_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = ReadExcel(this.txtUrl.Text);
                if (dt.Rows.Count > 0)
                {
                    WaitingFrom.ShowWait("");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string strGUID = System.Guid.NewGuid().ToString();
                        Mod_TMO_ORDER modorder = new Mod_TMO_ORDER();
                        modorder.C_ID = System.Guid.NewGuid().ToString();
                        modorder.C_ORDER_NO = System.Guid.NewGuid().ToString();
                        modorder.D_DT = Convert.ToDateTime(System.DateTime.Now);
                        modorder.D_NEED_DT = Convert.ToDateTime(System.DateTime.Now.AddDays(40));
                        modorder.D_DELIVERY_DT = Convert.ToDateTime(System.DateTime.Now.AddDays(60));
                        modorder.C_MAT_CODE = dt.Rows[i][2].ToString();

                        Mod_TB_MATRL_MAIN modwl = bllwl.GetModel(modorder.C_MAT_CODE);
                        if (modwl != null)
                        {
                            modorder.C_INVBASDOCID = modwl.C_PK_INVBASDOC;
                            modorder.C_MAT_NAME = modwl.C_MAT_NAME;
                            modorder.C_SPEC = modwl.C_SPEC;
                            modorder.C_STL_GRD = modwl.C_STL_GRD;
                        }
                        else
                        {
                            continue;
                        }

                        modorder.C_STD_CODE = dt.Rows[i][1].ToString().Replace(" ", "").Replace("（", "(").Replace("）", ")");
                        DataTable dtzyx = bllbz.GetZYX(modorder.C_STL_GRD, modorder.C_STD_CODE);
                        if (dtzyx.Rows.Count > 0)
                        {
                            modorder.C_FREE1 = dtzyx.Rows[0]["ZYX1"].ToString();
                            modorder.C_FREE2 = dtzyx.Rows[0]["ZYX2"].ToString();
                        }

                        modorder.N_WGT = Convert.ToDecimal(dt.Rows[i][3].ToString());
                        try
                        {
                            modorder.N_PROD_WGT = Convert.ToDecimal(dt.Rows[i][9].ToString().Trim() == "" ? "0" : dt.Rows[i][9].ToString());
                        }
                        catch (Exception)
                        {

                            modorder.N_PROD_WGT = 0;
                        }
                        modorder.N_EXEC_STATUS = -1;//订单刚导入状态
                        modorder.N_TYPE = 6;//线材订单
                        modorder.N_STATUS = 2;//可执行
                        modorder.C_REMARK = "导入";//标志订单是导入的
                        bllorder.Add(modorder);

                    }
                    MessageBox.Show("订单导入成功！");
                    WaitingFrom.CloseWait();
                    btn_query_main_Click(null, null);
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            int[] rownumber = this.gv_tmo_order.GetSelectedRows();//获取选中行号数组；
            for (int i = 0; i < rownumber.Length; i++)
            {
                int selectedHandle = rownumber[i];
                string strID = this.gv_tmo_order.GetRowCellValue(selectedHandle, "C_ID").ToString();
                double wcl = Convert.ToDouble(this.gv_tmo_order.GetRowCellValue(selectedHandle, "WCL").ToString());
                Mod_TMO_ORDER modorder = bllorder.GetModel(strID);
                if (wcl>0.9)
                {
                    modorder.N_EXEC_STATUS =-2;
                }
                else
                {
                    modorder.N_EXEC_STATUS = 0;
                }
              
                bllorder.Update(modorder);

            }
            WaitingFrom.CloseWait();
            btn_query_main_Click(null, null);
            
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            WaitingFrom.ShowWait("");
            int[] rownumber = this.gv_tmo_order.GetSelectedRows();//获取选中行号数组；
            for (int i = 0; i < rownumber.Length; i++)
            {
                int selectedHandle = rownumber[i];
                string strID = this.gv_tmo_order.GetRowCellValue(selectedHandle, "C_ID").ToString();
                Mod_TMO_ORDER modorder = bllorder.GetModel(strID);
                modorder.N_EXEC_STATUS =-1;
                bllorder.Update(modorder);

            }
            WaitingFrom.CloseWait();
            btn_query_main_Click(null, null);
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            WaitingFrom.ShowWait("");
            int[] rownumber = this.gv_tmo_order.GetSelectedRows();//获取选中行号数组；
            for (int i = 0; i < rownumber.Length; i++)
            {
                int selectedHandle = rownumber[i];
                string strID = this.gv_tmo_order.GetRowCellValue(selectedHandle, "C_ID").ToString();
                Mod_TMO_ORDER modorder = bllorder.GetModel(strID);
                modorder.N_EXEC_STATUS = -2;
                bllorder.Update(modorder);

            }
            WaitingFrom.CloseWait();
            btn_query_main_Click(null, null);
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            OutToExcel.ToExcel(this.gc_tmo_order);
        }

        private void FrmPO_Improt_Order_Load(object sender, EventArgs e)
        {
            UserButtonRight.GetBtnFun(this, RV.UI.UserInfo.menuID);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                WaitingFrom.ShowWait("");
                DataTable dt = ReadExcel(this.txtUrl.Text);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        #region 导入订单
                        string strGUID = System.Guid.NewGuid().ToString();
                        Mod_TMO_ORDER modorder = new Mod_TMO_ORDER();
                        modorder.C_ID = System.Guid.NewGuid().ToString();
                        modorder.C_ORDER_NO = dt.Rows[i]["计划订单号"].ToString();
                        modorder.D_DT = Convert.ToDateTime("2019-02-01"); //Convert.ToDateTime(dt.Rows[i]["计划日期"].ToString());
                        modorder.D_NEED_DT = Convert.ToDateTime(dt.Rows[i]["需求日期"].ToString());
                        modorder.D_DELIVERY_DT = Convert.ToDateTime(dt.Rows[i]["交货日期"].ToString());
                        modorder.C_MAT_CODE = dt.Rows[i]["物料编码"].ToString();
                        modorder.C_STL_GRD = dt.Rows[i]["型号"].ToString();
                        modorder.C_SPEC = dt.Rows[i]["规格"].ToString();
                        modorder.C_MAT_NAME = dt.Rows[i]["工艺代码"].ToString();
                        Mod_TB_MATRL_MAIN modwl = bllwl.GetModel(modorder.C_MAT_CODE);

                        if (modwl != null)
                        {
                            modorder.C_INVBASDOCID = modwl.C_PK_INVBASDOC;
                            modorder.C_MAT_NAME = modwl.C_MAT_NAME;
                            modorder.C_SPEC = modwl.C_SPEC;
                            modorder.C_STL_GRD = modwl.C_STL_GRD;
                        }
                        else
                        {
                            // continue;
                        }
                        modorder.C_FREE1 = dt.Rows[i]["产品标准"].ToString();
                        modorder.C_FREE2 = dt.Rows[i]["技术要求"].ToString();

                        Mod_TQB_STD_MAIN modbz = bllbz.GetModel(modorder.C_STL_GRD, modorder.C_FREE1, modorder.C_FREE2);
                        if (modbz != null)
                        {
                            modorder.C_STD_CODE = modbz.C_STD_CODE;
                        }
                        // modorder.C_STD_CODE=
                        modorder.C_PACK = dt.Rows[i]["包装"].ToString();
                        modorder.N_WGT = Convert.ToDecimal(dt.Rows[i]["需求数量"].ToString());


                        modorder.C_AREA = dt.Rows[i]["其他要求"].ToString();
                        modorder.C_TRANSMODE = dt.Rows[i]["内部备注"].ToString();
                        modorder.C_ORDER_LEV = dt.Rows[i]["订单级别"].ToString();
                        modorder.C_PRO_USE = dt.Rows[i]["客户用途"].ToString();
                        modorder.N_PROD_WGT = Convert.ToDecimal(dt.Rows[i]["完工数量"].ToString() == "" ? "0" : dt.Rows[i]["完工数量"].ToString());
                        modorder.N_EXEC_STATUS = 0;//订单刚导入状态
                        modorder.N_TYPE = 8;//线材订单
                        modorder.N_STATUS = 2;//可执行
                        modorder.C_REMARK = "导入";//标志订单是导入的
                        modorder.C_CON_NO = (Convert.ToInt64(System.DateTime.Now.ToString("yyMMdd") + "0001") + i).ToString();

                        if (bllorder.ifcz(modorder.C_ORDER_NO))
                        {
                            bllorder.Add(modorder);
                        }
                        //if (Convert.ToDouble(modorder.N_PROD_WGT) >= Convert.ToDouble(modorder.N_WGT) * 0.9)
                        //{
                           // modorder.N_WGT = modorder.N_WGT - modorder.N_PROD_WGT;
                            //bllorder.Add(modorder);//生产量大于90%的视同完成
                        //}

                        #endregion

                    }
                    MessageBox.Show("订单导入成功！");
                    WaitingFrom.CloseWait();
                    btn_query_main_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
