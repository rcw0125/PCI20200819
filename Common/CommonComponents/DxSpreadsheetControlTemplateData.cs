using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Common
{
    [Editor(typeof(DxSpreadsheetControlTemplateDataTypeEditor), typeof(UITypeEditor))]
    public class DxSpreadsheetControlTemplateData
    {
        // Methods
        public override string ToString()
        {
            return "Click to Open Designer...";
        }

        // Properties
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string Content { get; set; }
    }
}
