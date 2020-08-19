using DevExpress.Skins;
using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;

namespace Common
{
    public class DxSpreadsheetControlTemplateDataTypeEditor : UITypeEditor
    {
        // Fields
        private IWindowsFormsEditorService iwfes = null;

        // Methods
        public DxSpreadsheetControlTemplateDataTypeEditor()
        {
            SkinManager.EnableFormSkins();
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (((context != null) && (context.Instance != null)) && (provider != null))
            {
                this.iwfes = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
                if (this.iwfes == null)
                {
                    return value;
                }
                DxSpreadsheetControlTemplateData data = value as DxSpreadsheetControlTemplateData;
                if (data != null)
                {
                    SpreadSheetDesigner designer = new SpreadSheetDesigner(Base2e15.Decode(data.Content));
                    designer.ShowDialog();
                    byte[] byts = designer.SpreadsheetControl.SaveDocument(DocumentFormat.Xlsx);
                    DxSpreadsheetControlTemplateData data1 = new DxSpreadsheetControlTemplateData
                    {
                        Content = Base2e15.Encode(byts)
                    };
                    value = data1;
                }
            }
            return value;
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if ((context != null) && (context.Instance != null))
            {
                return UITypeEditorEditStyle.Modal;
            }
            return base.GetEditStyle(context);
        }
    }
}

