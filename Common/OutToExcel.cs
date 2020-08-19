using Aspose.Cells;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Common
{
   public  class OutToExcel
    {

        ///// <summary>
        ///// 导出数据到excel
        ///// </summary>
        ///// <param name="frm">窗体</param>
        ///// <param name="gc">表格</param>
        //public static void ToExcel(IWin32Window frm, DevExpress.XtraGrid.GridControl gc)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Title = "导出Excel";
        //    saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
        //    DialogResult dialogResult = saveFileDialog.ShowDialog(frm);
        //    if (dialogResult == DialogResult.OK)
        //    {
        //        DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
        //        gc.ExportToXls(saveFileDialog.FileName);
        //        DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        /// <summary>
        /// GridControl数据导出到Excel
        /// </summary>
        /// <param name="gc">GridControl</param>
        public static void ToExcel(DevExpress.XtraGrid.GridControl gc)
        {

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx ";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gc.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gc.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gc.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gc.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gc.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gc.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            if (DialogResult.Yes == MessageBox.Show("文件已成功导出，是否打开文件?", "提示", MessageBoxButtons.YesNo))
                            {
                                System.Diagnostics.Process.Start(exportFilePath);
                            }
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        /// <summary>
        /// GridControl数据导出到Excel
        /// </summary>
        /// <param name="gc">GridControl</param>
        /// <param name="FileName">导出文件名</param>
        public static void ToExcel(DevExpress.XtraGrid.GridControl gc,string FileName)
        {

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                //saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                saveDialog.FileName = FileName;
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx ";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gc.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gc.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gc.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gc.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gc.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gc.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            if (DialogResult.Yes == MessageBox.Show("文件已成功导出，是否打开文件?", "提示", MessageBoxButtons.YesNo))
                            {
                                System.Diagnostics.Process.Start(exportFilePath);
                            }
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary> 
        /// 导出数据到本地 
        /// </summary> 
        /// <param name="dt">要导出的数据</param> 
        /// <param name="dt">要导出的数据</param> 
        /// <param name="tableName">表格标题</param> 
        /// <param name="path">保存路径 , string path</param> 
        public static string OutFileToDisk(IWin32Window frm, DataTable dt)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "导出Excel";
                saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
                DialogResult dialogResult = saveFileDialog.ShowDialog(frm);
                if (dialogResult == DialogResult.OK)
                {
                    string filename = saveFileDialog.Title;
                    Workbook workbook = new Workbook(); //工作簿 
                    Worksheet sheet = workbook.Worksheets[0]; //工作表 
                    Cells cells = sheet.Cells;//单元格 

                    //为标题设置样式     
                    //Style styleTitle = workbook.Styles[workbook.Styles.Add()];//新增样式 
                    //styleTitle.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
                    //styleTitle.Font.Name = "宋体";//文字字体 
                    //styleTitle.Font.Size = 14;//文字大小 
                    //styleTitle.Font.IsBold = true;//粗体 

                    //样式2 
                    Style style2 = workbook.Styles[workbook.Styles.Add()];//新增样式 
                    style2.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
                    style2.Font.Name = "宋体";//文字字体 
                    style2.Font.Size = 12;//文字大小 
                    style2.Font.IsBold = true;//粗体 
                    style2.IsTextWrapped = false;//单元格内容自动换行 
                    style2.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style2.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style2.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style2.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

                    //样式3 
                    Style style3 = workbook.Styles[workbook.Styles.Add()];//新增样式 
                    style3.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
                    style3.Font.Name = "宋体";//文字字体 
                    style3.Font.Size = 9;//文字大小 
                    style3.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
                    style3.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
                    style3.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
                    style3.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

                    int Colnum = dt.Columns.Count;//表格列数 
                    int Rownum = dt.Rows.Count;//表格行数 

                    //生成行1 标题行    
                    // cells.Merge(0, 0, 1, Colnum);//合并单元格 
                    //cells[0, 0].PutValue(tableName);//填写内容 
                    //cells[0, 0].SetStyle(styleTitle);
                    //cells.SetRowHeight(0, 38);

                    //生成行2 列名行 
                    for (int i = 0; i < Colnum; i++)
                    {
                        cells[0, i].PutValue(dt.Columns[i].ColumnName);
                        cells[0, i].SetStyle(style2);
                        //cells.SetRowHeight(1, 25);
                    }

                    //生成数据行 
                    for (int i = 0; i < Rownum; i++)
                    {
                        for (int k = 0; k < Colnum; k++)
                        {
                            cells[1 + i, k].PutValue(dt.Rows[i][k].ToString());
                            cells[1 + i, k].SetStyle(style3);
                        }
                        // cells.SetRowHeight(2 + i, 24);
                    }
                    workbook.Save(saveFileDialog.FileName);
                }
                return "导出成功！";
            }
            catch (Exception)
            {

                return "导出失败！";
            }
           
        }


        public MemoryStream OutFileToStream(DataTable dt, string tableName)
        {
            Workbook workbook = new Workbook(); //工作簿 
            Worksheet sheet = workbook.Worksheets[0]; //工作表 
            Cells cells = sheet.Cells;//单元格 

            //为标题设置样式     
            Style styleTitle = workbook.Styles[workbook.Styles.Add()];//新增样式 
            styleTitle.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            styleTitle.Font.Name = "宋体";//文字字体 
            styleTitle.Font.Size = 18;//文字大小 
            styleTitle.Font.IsBold = true;//粗体 

            //样式2 
            Style style2 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style2.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style2.Font.Name = "宋体";//文字字体 
            style2.Font.Size = 14;//文字大小 
            style2.Font.IsBold = true;//粗体 
            style2.IsTextWrapped = true;//单元格内容自动换行 
            style2.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            //样式3 
            Style style3 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style3.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style3.Font.Name = "宋体";//文字字体 
            style3.Font.Size = 12;//文字大小 
            style3.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            int Colnum = dt.Columns.Count;//表格列数 
            int Rownum = dt.Rows.Count;//表格行数 

            //生成行1 标题行    
            cells.Merge(0, 0, 1, Colnum);//合并单元格 
            cells[0, 0].PutValue(tableName);//填写内容 
            cells[0, 0].SetStyle(styleTitle);
            cells.SetRowHeight(0, 38);

            //生成行2 列名行 
            for (int i = 0; i < Colnum; i++)
            {
                cells[1, i].PutValue(dt.Columns[i].ColumnName);
                cells[1, i].SetStyle(style2);
                cells.SetRowHeight(1, 25);
            }

            //生成数据行 
            for (int i = 0; i < Rownum; i++)
            {
                for (int k = 0; k < Colnum; k++)
                {
                    cells[2 + i, k].PutValue(dt.Rows[i][k].ToString());
                    cells[2 + i, k].SetStyle(style3);
                }
                cells.SetRowHeight(2 + i, 24);
            }

            MemoryStream ms = workbook.SaveToStream();
            return ms;
        }



    }
}
