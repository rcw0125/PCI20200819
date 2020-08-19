using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public partial class SpreadSheetDesigner : Form
    {
        public SpreadSheetDesigner(byte[] bytes)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.SpreadsheetControl.LoadDocument(bytes, DocumentFormat.Xlsx);
        }

        //public SpreadSheetDesigner2(byte[] bytes) : base()
        //{
        //    this.SpreadsheetControl.LoadDocument(bytes, DocumentFormat.Xlsx);

        //}
    }
}
