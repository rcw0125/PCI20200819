using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Aspose.Cells;
using BLL;
using Common;
using MODEL;

namespace XGCAP.UI.Q.QB
{
    public partial class FrmQB_QYMB : Form
    {
        private Bll_TQB_SAMP_MODLE bllTqbSampModle = new Bll_TQB_SAMP_MODLE();
        private Bll_TQB_SAMP_ITEM_MODLE bllTqbSampItemModle = new Bll_TQB_SAMP_ITEM_MODLE();
        private Bll_TQB_STD_MAIN bllMain = new Bll_TQB_STD_MAIN();
        private Bll_TQB_SAMPLING bllTqbSam = new Bll_TQB_SAMPLING();

        public FrmQB_QYMB()
        {
            InitializeComponent();
        }

        private void FrmQB_QYMB_Load(object sender, EventArgs e)
        {

        }

        private void BindMain()
        {
            try
            {
                WaitingFrom.ShowWait("");

                gc_Main.DataSource = null;
                DataTable dt = bllTqbSampModle.GetList(txt_BZ.Text.Trim(), txt_GZ.Text.Trim()).Tables[0];
                gc_Main.DataSource = dt;
                SetGridViewRowNum.SetRowNum(gv_Main);

                WaitingFrom.CloseWait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gv_Main_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gv_Main.GetDataRow(e.FocusedRowHandle);

                if (dr != null)
                {
                    BindItem(dr);
                }
                else
                {
                    gc_Item.DataSource = null;
                }
            }
            catch
            {

            }
        }

        private void BindItem(DataRow dr)
        {
            DataTable dt = bllTqbSampItemModle.Get_Model_List(dr["执行标准"].ToString(), dr["钢种"].ToString(), dr["规格最小值"].ToString(), dr["规格最大值"].ToString()).Tables[0];

            gc_Item.DataSource = dt;
            SetGridViewRowNum.SetRowNum(gv_Item);

            gv_Item.Columns[0].Visible = false;

            for (int i = 0; i < gv_Item.Columns.Count; i++)
            {
                if (i < 5)
                {
                    gv_Item.Columns[i].OptionsColumn.AllowEdit = false;
                }
                else
                {
                    gv_Item.Columns[i].OptionsColumn.AllowEdit = true;
                }
            }
        }


        #region 导入

        private void btn_Bz_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable dt = OpenExcelFile(this.txtUrl.Text, "Sheet1");
            //    string strLog = "";

            //    Int64 i_id = 2019032200000;

            //    if (dt.Rows.Count > 0)
            //    {
            //        for (int i = 0; i < dt.Rows.Count; i++)
            //        {
            //            DataTable dtMain = bllMain.GetList_ID(dt.Rows[i]["文件号"].ToString().Trim(), dt.Rows[i]["牌号"].ToString().Trim()).Tables[0];

            //            if (dtMain.Rows.Count > 0)
            //            {
            //                i_id++;

            //                Mod_TQB_SAMP_MODLE modSam = new Mod_TQB_SAMP_MODLE();
            //                modSam.C_ID = i_id.ToString();
            //                modSam.C_STD_CODE = dt.Rows[i]["文件号"].ToString().Trim();
            //                modSam.C_STL_GRD = dt.Rows[i]["牌号"].ToString().Trim();
            //                modSam.C_SPEC_MIN = dt.Rows[i]["规格最小"].ToString().Trim();
            //                modSam.C_SPEC_MAX = dt.Rows[i]["规格最大"].ToString().Trim();
            //                modSam.N_SAM_NUM = Convert.ToDecimal(dt.Rows[i]["数量"].ToString().Trim());

            //                bllTqbSampModle.Add(modSam);

            //                for (int kk = 5; kk < dt.Columns.Count; kk++)
            //                {
            //                    string strID = bllTqbSam.GetSampId(dt.Columns[kk].ColumnName);

            //                    if(!string.IsNullOrEmpty(dt.Rows[i][kk].ToString().Trim()))
            //                    {
            //                        Mod_TQB_SAMP_ITEM_MODLE modItem = new Mod_TQB_SAMP_ITEM_MODLE();
            //                        modItem.C_SAMP_MODLE_ID = modSam.C_ID;
            //                        modItem.C_SAMPLES_ID = strID;
            //                        modItem.C_SAM_NUM = dt.Rows[i][kk].ToString().Trim();
            //                        modItem.C_SAMPLES_NAME = dt.Columns[kk].ColumnName;

            //                        bllTqbSampItemModle.Add(modItem);
            //                    }

            //                }
            //            }
            //            else
            //            {
            //                strLog = strLog + "添加失败：" + dt.Rows[i]["文件号"].ToString() + "   " + dt.Rows[i]["牌号"].ToString() + ";";
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }


        /// <summary>
        ///  获取Excel中的数据，根据Sheet名字获取数据
        /// </summary>
        /// <param name="excelPath">文件路径</param>
        /// <param name="sheetName">需要打开的sheet名称</param>
        /// <returns></returns>
        public static DataTable OpenExcelFile(string excelPath, string sheetName)
        {
            //DataSet ds = new DataSet();
            //Workbook workBook = new Workbook(excelPath);
            //Worksheet workSheet = workBook.Worksheets[sheetName];
            //Cells cell = workSheet.Cells;
            DataTable dt = new DataTable();
            //int count = cell.Columns.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    string str = cell.GetRow(0)[i].StringValue;
            //    dt.Columns.Add(new DataColumn(str));
            //}
            //for (int i = 1; i < cell.Rows.Count; i++)//第一行为表头行，不取
            //{
            //    DataRow dr = dt.NewRow();
            //    for (int j = 0; j < count; j++)
            //    {
            //        dr[j] = cell[i, j].StringValue;
            //    }
            //    dt.Rows.Add(dr);
            //}
            //dt.AcceptChanges();
            ////ds.Tables.Add(dt);
            return dt;
        }

        private void txtUrl_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Multiselect = false;
            //fileDialog.Title = "请选择文件";
            //fileDialog.Filter = "所有Excel文件|*.XLSX;*.XLS;*.xlsx;*.xls";
            //fileDialog.FilterIndex = 1;
            //fileDialog.RestoreDirectory = true;
            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string file = fileDialog.FileName;
            //    txtUrl.Text = file;
            //}
        }

        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BindMain();
        }

        private void btn_Add_Main_Click(object sender, EventArgs e)
        {
            try
            {
                FrmQB_QYMB_Add_MAIN frm = new FrmQB_QYMB_Add_MAIN();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindMain();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Del_Main_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Main.GetDataRow(gv_Main.FocusedRowHandle);

                if (dr != null)
                {
                    if (bllTqbSampModle.update_status(dr["执行标准"].ToString(), dr["钢种"].ToString(), dr["规格最小值"].ToString(), dr["规格最大值"].ToString()))
                    {
                        MessageBox.Show("删除成功！");
                        BindMain();
                    }
                }
                else
                {
                    gc_Item.DataSource = null;
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 添加子信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Item_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Main.GetDataRow(gv_Main.FocusedRowHandle);

            if (dr != null)
            {
                gv_Item.AddNewRow();
                gv_Item.SetFocusedRowCellValue("执行标准", dr["执行标准"].ToString());
                gv_Item.SetFocusedRowCellValue("钢种", dr["钢种"].ToString());
                gv_Item.SetFocusedRowCellValue("规格最小值", dr["规格最小值"].ToString());
                gv_Item.SetFocusedRowCellValue("规格最大值", dr["规格最大值"].ToString());
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ((DataView)gv_Item.DataSource).ToTable();
                if (dt.Rows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("是否确认保存数据？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)//如果点击“确定”按钮
                    {
                        string result = bllTqbSampModle.Save_Modle(dt);

                        if (result == "1")
                        {
                            MessageBox.Show("保存成功！");
                        }
                        else
                        {
                            MessageBox.Show(result);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("没有需要保存的数据！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 删除子信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Item_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gv_Item.GetDataRow(gv_Main.FocusedRowHandle);

                if (dr != null)
                {
                    if (bllTqbSampItemModle.Update_Trans(dr["C_ID"].ToString()))
                    {
                        MessageBox.Show("删除成功！");

                        DataRow drMain = gv_Main.GetDataRow(gv_Main.FocusedRowHandle);

                        if (drMain != null)
                        {
                            BindItem(drMain);
                        }
                    }
                }
            }
            catch
            {

            }
        }

    }
}
