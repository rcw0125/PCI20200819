
using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Common
{
    /// <summary>
    /// 填充SpraedSheet数据工具类
    /// </summary>
    public static class BindSpreadSheetHelper
    {
        /// <summary>
        /// 填充数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sheet"></param>
        /// <param name="range"></param>
        /// <param name="dataSource"></param>
        /// <param name="isver"></param>
        /// <returns></returns>
        public static Range BindDataSource<T>(
            this Worksheet sheet,
            Range range,
            IEnumerable<T> dataSource,
            bool isver = false,
            bool isCpyStyle = false)
        {
            if (dataSource.Count() == 0) { return range; }

            int topRowIndex = range.TopRowIndex;
            int leftColumnIndex = range.LeftColumnIndex;
            int rightColumnIndex = range.LeftColumnIndex;
            int bottomRowIndex = range.TopRowIndex;

            var helper = new ConvertToCellValueHelper(typeof(T));

            var lstCellValues = dataSource.Select(w => helper.GetCellValue(w)).ToList();

            if (isver == false)
            {
                var rowIndex = range.TopRowIndex;


                var styleRange = sheet.Range.FromLTRB(
                    leftColumnIndex,
                    topRowIndex,
                    leftColumnIndex + lstCellValues.FirstOrDefault().Count - 1,
                    topRowIndex);
                if (isCpyStyle == false)
                {
                    styleRange.SetDefaultStyle();
                }

                foreach (var rowItem in lstCellValues)
                {
                    var nowRange = sheet.Range.FromLTRB(leftColumnIndex, rowIndex, leftColumnIndex + rowItem.Count-1, rowIndex);
                    nowRange.CopyFrom(styleRange, PasteSpecial.Formats);

                    var columnIndex = range.LeftColumnIndex;

                    foreach (var valueItem in rowItem)
                    {
                        if (sheet[rowIndex, columnIndex].HasFormula == false)
                        {
                            sheet[rowIndex, columnIndex].Value = valueItem;
                        }

                        columnIndex++;
                        bottomRowIndex = rowIndex;
                    }

                    rowIndex++;

                    rightColumnIndex = columnIndex - 1;
                }
            }
            else
            {
                var columnIndex = range.LeftColumnIndex;

                var styleRange = sheet.Range.FromLTRB(
                    leftColumnIndex,
                    topRowIndex,
                    leftColumnIndex,
                    topRowIndex + lstCellValues.FirstOrDefault().Count - 1);

                if (isCpyStyle == false)
                {
                    styleRange.SetDefaultStyle();
                }

                foreach (var rowItem in lstCellValues)
                {
                    var nowRange = sheet.Range.FromLTRB(columnIndex, topRowIndex, columnIndex, topRowIndex + rowItem.Count - 1);
                    nowRange.CopyFrom(styleRange, PasteSpecial.Formats);

                    var rowIndex = range.TopRowIndex;

                    foreach (var valueItem in rowItem)
                    {
                        if (sheet[rowIndex, columnIndex].HasFormula == false)
                        {
                            sheet[rowIndex, columnIndex].Value = valueItem;
                        }

                        rowIndex++;
                    }

                    columnIndex++;

                    bottomRowIndex = rowIndex - 1;
                }

                rightColumnIndex = columnIndex - 1;
            }

            return sheet.Range.FromLTRB(
                leftColumnIndex,
                topRowIndex,
                rightColumnIndex,
                bottomRowIndex);
        }

        public static IEnumerable<CellValue> GetCellValues<T>(T t)
        {
            List<CellValue> result = new List<CellValue>();

            if (t == null || t.GetType().Equals(typeof(Nullable<>)))
            {
                result.Add(CellValue.DefaultConverter.TryConvertFromObject(t));
                return result;
            }

            if (t.GetType().Equals(typeof(string)))
            {
                result.Add(CellValue.DefaultConverter.TryConvertFromObject(t));

                return result;
            }

            if (t.GetType().IsValueType)
            {
                result.Add(CellValue.DefaultConverter.TryConvertFromObject(t));

                return result;
            }

            var properties = t.GetType().GetProperties()
                                        .Where(x => x.GetCustomAttribute<SpreadSheetCellAttribute>() != null)
                                        .OrderBy(x => x.GetCustomAttribute<SpreadSheetCellAttribute>().Seq);

            foreach (var proItem in properties)
            {
                result.AddRange(GetCellValues(t, proItem));
            }

            return result;
        }

        private static List<CellValue> GetCellValues<T>(T t, PropertyInfo proInfo)
        {
            var propertyType = proInfo.PropertyType;

            List<CellValue> result = new List<CellValue>();

            var proValue = proInfo.GetValue(t, null);

            if (proValue == null)
            {
                result.Add(CellValue.DefaultConverter.TryConvertFromObject(proValue));
                return result;
            }

            if (propertyType.Equals(typeof(string)))
            {
                result.Add(CellValue.DefaultConverter.TryConvertFromObject(proValue));
            }
            else if (propertyType.IsValueType)
            {
                result.Add(CellValue.DefaultConverter.TryConvertFromObject(proValue));
            }
            else if (proInfo.PropertyType.GetInterfaces().Any(x => x.Name == typeof(IEnumerable<>).Name))
            {
                foreach (object o in (proValue as System.Collections.IEnumerable))
                {
                    result.AddRange(GetCellValues(o));
                }
            }
            else if (propertyType.IsClass)
            {
                result.AddRange(GetCellValues(proValue));
            }
            else
            {
                throw new NotImplementedException("不支持此类型转换为Cellvalue");
            }

            return result;
        }
    }
}
