using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;

namespace Common
{
    [ProvideProperty("TemplateData", "DevExpress.XtraSpreadsheet.SpreadsheetControl")]
    public class controlExprovider : Component, IExtenderProvider
    {
        public bool CanExtend(object extendee)
        {
            return true;
        }

        [DefaultValue(null)]
        [Description("表格模版设置")]
        [DisplayName("TemplateData")]
        public DxSpreadsheetControlTemplateData GetTemplateData(SpreadsheetControl spc)
        {
            var data = new DxSpreadsheetControlTemplateData();
            var arr = spc.SaveDocument(DocumentFormat.Xlsx);
            data.Content = Base2e15.Encode(arr);
            return data;
        }

        public void SetTemplateData(SpreadsheetControl spc, DxSpreadsheetControlTemplateData value)
        {
            spc.LoadDocument(Base2e15.Decode(value.Content), DocumentFormat.Xlsx);
        }
    }
}
