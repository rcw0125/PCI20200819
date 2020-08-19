using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCAP.UI.Q.QR
{
    public partial class FrmQR_ZZS_TD : Form
    {
        public FrmQR_ZZS_TD()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport_TD rpt = new XtraReport_TD("");
            DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(rpt);

            //       DevExpress.XtraPrinting.PrintingSystemBase mPSB = printTool.PrintingSystem; mPSB.SetCommandVisibility(new DevExpress.XtraPrinting.PrintingSystemCommand[]
            //{
            //   DevExpress.XtraPrinting.PrintingSystemCommand.Background ,
            //   DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview ,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.Customize ,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap ,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.File ,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground ,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.Open ,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup ,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.Print ,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect ,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.Save,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.Watermark,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.ExportXps,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.SendFile,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.SendMht,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.SendXls,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.SendXps,
            //       DevExpress.XtraPrinting.PrintingSystemCommand.SubmitParameters
            //    }, DevExpress.XtraPrinting.CommandVisibility.None);


            //printTool.ShowPreviewDialog();

            printTool.Print();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XtraReport_TD rpt = new XtraReport_TD("");
            this.documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
            
        }
    }
}
