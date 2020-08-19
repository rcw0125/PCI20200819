using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Spreadsheet.Formulas;
using System.Collections;
using System.Drawing;
using DevExpress.XtraSpreadsheet;
using System.ComponentModel;

namespace Common
{
    public static class SpreadSheetExtend
    {
        /// <summary>
        /// 设置区域样式，边框及字体
        /// </summary>
        /// <param name="range">要设置的区域</param>
        /// <param name="templateCell">设置单元格模板样式，如果为空则采用默认配置</param>
        public static void SetDefaultStyle(
            this Range rangeC3E6,
            Color? backgroundColor = null,
            bool isColumnHeader = false,
            SpreadsheetHorizontalAlignment horizontal = SpreadsheetHorizontalAlignment.Center)
        {
            // Format the "C3:E6" range of cells.
            // Access an object representing a range of cells to be formatted.
            //Range rangeC3E6 = worksheet.Range["C3:E6"];

            // Start updating a range formatting. 
            Formatting rangeC3E6Formatting = rangeC3E6.BeginUpdateFormatting();

            // Specify font appearance (font name, color, size and style).
            rangeC3E6Formatting.Font.Name = SpreadSheetConfig.FontName;
            //rangeC3E6Formatting.Font.Color = Color.Blue;
            rangeC3E6Formatting.Font.Size = SpreadSheetConfig.FontSize;
            rangeC3E6Formatting.Font.Bold = false;

            // border
            rangeC3E6Formatting.Borders.SetAllBorders(
                isColumnHeader ? SpreadSheetConfig.HeaderBorderColor : SpreadSheetConfig.ContentBorderColor,
                BorderLineStyle.Thin);

            // Specify cell background color.
            rangeC3E6Formatting.Fill.BackgroundColor = backgroundColor ?? Color.Transparent;

            // Specify text alignment in cells.
            rangeC3E6Formatting.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
            rangeC3E6Formatting.Alignment.Horizontal = horizontal;

            // Complete updating range formatting.
            rangeC3E6.EndUpdateFormatting(rangeC3E6Formatting);

        }

        /// <summary>
        /// 设置SpreadSheet可编辑区域
        /// </summary>
        /// <param name="sc"></param>
        /// <param name="range"></param>
        /// <param name="rangeName"></param>
        /// <returns></returns>
        public static string SetCanEditRanges(this SpreadsheetControl sc, Range range = null, string rangeName = "")
        {
            if (!sc.ActiveWorksheet.IsProtected)
            {
                sc.ActiveWorksheet.Protect(string.Empty, WorksheetProtectionPermissions.Default);

                sc.ProtectionWarning -= Sc_ProtectionWarning;
                sc.ProtectionWarning += Sc_ProtectionWarning;
            }

            if (range != null)
            {
                string protectedName = string.IsNullOrEmpty(rangeName) ? range.GetReferenceA1().Replace(":", "") : rangeName;

                if (!sc.ActiveWorksheet.ProtectedRanges.Contains(protectedName))
                {
                    sc.ActiveWorksheet.ProtectedRanges.Add(protectedName, range);
                }

                return protectedName;
            }

            return string.Empty;
        }

        private static void Sc_ProtectionWarning(object sender, HandledEventArgs e)
        {
            e.Handled = true;
        }

        //public static Range GetRange(this Range range, int rowCount)
        //{
        //    range.mo;
        //}

        /// <summary>
        /// 多个区域汇总，引用
        /// </summary>
        /// <param name="range"></param>
        /// <param name="arrRange"></param>
        /// <returns></returns>
        public static Range GetRange(this Worksheet sheet, params Range[] arrRange)
        {
            return sheet[string.Join(",", arrRange.Select(x => x.GetReferenceA1()))];
        }

        public static Range GetRange(this Range range, params Range[] arrRange)
        {
            var ranges = arrRange.ToList();

            ranges.Add(range);

            return range.Worksheet.GetRange(ranges.ToArray());
        }
    }

    /// <summary>
    /// 默认SpreadSheet环境变量配置，包含字体边框样式
    /// </summary>
    public static class SpreadSheetConfig
    {
        /// <summary>
        /// 字体大小
        /// </summary>
        public static double FontSize = 9;

        /// <summary>
        /// 字体样式
        /// </summary>
        public static string FontName = "Tahoma";

        /// <summary>
        /// 列头边框颜色
        /// </summary>
        public static Color HeaderBorderColor = Color.FromArgb(166, 166, 166);

        /// <summary>
        /// 内容边框颜色
        /// </summary>
        public static Color ContentBorderColor = Color.FromArgb(166, 166, 166);

        /// <summary>
        /// 列头填充颜色
        /// </summary>
        public static Color HeaderBackgroundColor = Color.FromArgb(240, 240, 240);
        /// <summary>
        /// 合计填充色
        /// </summary>
        public static Color TotalColor = Color.FromArgb(219, 238, 227);
    }
}
