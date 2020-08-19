using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Common
{
    public class ConvertToCellValueHelper
    {
        /// <summary>
        /// 实体化一个工具类根据类型，初始化spreadsheetcell自定义属性
        /// </summary>
        /// <param name="type"></param>
        public ConvertToCellValueHelper(Type type)
        {
            TPorperties.Clear();
            TPorperties.AddRange(GetCellAttributes(type));

            Helpers.Clear();

            foreach (var proInfo in TPorperties)
            {
                if (proInfo.PropertyType == typeof(string))
                {
                    continue;
                }

                if (proInfo.PropertyType.GetInterfaces().Any(x => x.Name == typeof(IEnumerable<>).Name))
                {
                    var helper = new ConvertToCellValueHelper(proInfo.PropertyType.GetGenericArguments()[0]);

                    Helpers.Add(proInfo, helper);
                }
                else if (proInfo.PropertyType.IsClass)
                {
                    var helper = new ConvertToCellValueHelper(proInfo.PropertyType);
                    Helpers.Add(proInfo, helper);
                }
            }
        }

        /// <summary>
        /// 存储复杂属性类对应的工具类
        /// </summary>
        Dictionary<PropertyInfo, ConvertToCellValueHelper> Helpers = new Dictionary<PropertyInfo, ConvertToCellValueHelper>();

        /// <summary>
        /// 存储自定义属性
        /// </summary>
        List<PropertyInfo> TPorperties { get; set; } = new List<PropertyInfo>();

        /// <summary>
        /// 获取SpreadSheetCellAttribute属性
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private List<PropertyInfo> GetCellAttributes(Type type)
        {
            var properties = type.GetProperties()
                .Where(x => x.GetCustomAttribute<SpreadSheetCellAttribute>() != null)
                .OrderBy(x => x.GetCustomAttribute<SpreadSheetCellAttribute>().Seq).ToList();

            return properties;
        }

        /// <summary>
        /// 转换为CELLVALUE值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tItem"></param>
        /// <returns></returns>
        public List<CellValue> GetCellValue<T>(T tItem)
        {
            var result = new List<CellValue>();

            if (tItem == null)
            {
                result.Add(tItem.GetCellValue());
                return result;
            }

            if (tItem.GetType().Equals(typeof(string)))
            {
                result.Add(tItem.GetCellValue());
            }
            else if (tItem.GetType().IsValueType)
            {
                result.Add(tItem.GetCellValue());
            }
            else
            {
                foreach (var proInfo in TPorperties)
                {
                    var propertyType = proInfo.PropertyType;

                    var proValue = proInfo.GetValue(tItem, null);

                    if (proValue == null)
                    {
                        result.Add(proValue.GetCellValue());
                        continue;
                    }

                    if (propertyType.Equals(typeof(string)))
                    {
                        result.Add(proValue.GetCellValue());
                    }
                    else if (propertyType.IsValueType)
                    {
                        result.Add(CellValue.DefaultConverter.TryConvertFromObject(proValue));
                    }
                    else if (proInfo.PropertyType.GetInterfaces().Any(x => x.Name == typeof(IEnumerable<>).Name))
                    {
                        var helper = Helpers[proInfo]; //new ImportHelper(proInfo.PropertyType.GenericTypeArguments[0]);

                        foreach (object o in (proValue as System.Collections.IEnumerable))
                        {
                            result.AddRange(helper.GetCellValue(o));
                        }
                    }
                    else if (propertyType.IsClass)
                    {
                        var helper = Helpers[proInfo]; //new ImportHelper(propertyType);
                        result.AddRange(helper.GetCellValue(proValue));
                    }
                    else
                    {
                        throw new NotImplementedException("不支持此类型转换为Cellvalue");
                    }

                }
            }

            return result;
        }

    }

    public static class PropertyExtions
    {
        public static T GetCustomAttribute<T>(this PropertyInfo info)
        {
            return info.GetCustomAttributes(typeof(T), false).OfType<T>().FirstOrDefault();
        }

        public static CellValue GetCellValue(this object val)
        {
            return CellValue.DefaultConverter.TryConvertFromObject(val);
        }
    }
}
