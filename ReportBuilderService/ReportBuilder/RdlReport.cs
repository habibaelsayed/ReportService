using iTextSharp.text.pdf;
using Microsoft.Reporting.NETCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilderService.ReportBuilder
{
    public static class RdlReport
    {



        private static byte[] GetReportPdfDataAsync(ReportParametersDto Parameters)
        {
            var fileStream = new FileStream($"{Parameters.Path}/{Parameters.ReportName}.rdl",
                FileMode.Open, FileAccess.Read);

            //   var reportDetails = new ReportDataSource("ReportDetails", Parameters.ReportDetails);

            var report = new LocalReport();
            report.LoadReportDefinition(fileStream);
            report.EnableExternalImages = true;
            report.EnableHyperlinks = true;
            foreach (var item in Parameters.dataSources)
            {
                var reportDataSource = new ReportDataSource(item.DataSetName, item.DataList);
                report.DataSources.Add(reportDataSource);

            }



            //    report.DataSources.Add(reportDetails);

            return report.Render("PDF");
        }




        private static IEnumerable<byte[]> GetSeperatedReportPdfData(List<ReportParametersDto> Parameters)
        {
            List<byte[]> bytes = new List<byte[]>();

            foreach (var Parameter in Parameters)
            {
                var fileStream = new FileStream($"{Parameter.Path}/{Parameter.ReportName}.rdl",
            FileMode.Open, FileAccess.Read);

                //   var reportDetails = new ReportDataSource("ReportDetails", Parameters.ReportDetails);

                var report = new LocalReport();
                report.LoadReportDefinition(fileStream);
                report.EnableExternalImages = true;
                report.EnableHyperlinks = true;
                foreach (var item in Parameter.dataSources)
                {
                    var reportDataSource = new ReportDataSource(item.DataSetName, item.DataList);
                    report.DataSources.Add(reportDataSource);

                }

                bytes.Add(report.Render("PDF"));
                //    report.DataSources.Add(reportDetails);

            }
            return bytes;

        }

        private static IEnumerable<byte[]> GetSeperatedReportPdfData2(List<ReportParametersDto2> Parameters)
        {
            List<byte[]> bytes = new List<byte[]>();

            foreach (var Parameter in Parameters)
            {
                var fileStream = new FileStream($"{Parameter.Path}/{Parameter.ReportName}.rdl",
            FileMode.Open, FileAccess.Read);

                //   var reportDetails = new ReportDataSource("ReportDetails", Parameters.ReportDetails);

                var report = new LocalReport();
                report.LoadReportDefinition(fileStream);
                report.EnableExternalImages = true;
                report.EnableHyperlinks = true;
                foreach (var item in Parameter.dataSources)
                {
                    var reportDataSource = new ReportDataSource(item.DataSetName, item.Data);
                    report.DataSources.Add(reportDataSource);

                }

                bytes.Add(report.Render("PDF"));
                //    report.DataSources.Add(reportDetails);

            }
            return bytes;

        }


        public static byte[] GetReportPdfDataAsync(List<ReportParametersDto> Parameters)
        {

            var SeperatedReports = GetSeperatedReportPdfData(Parameters).ToList();
            return concatAndAddContent(SeperatedReports.ToList());
        }


        public static List< byte[]> GetReportPdfDataAsync2(List<ReportParametersDto> Parameters)
        {

        return GetSeperatedReportPdfData(Parameters).ToList();
        }
        public static byte[] GetReportPdfDataAsync3(List<ReportParametersDto2> Parameters)
        {

            var SeperatedReports = GetSeperatedReportPdfData2(Parameters).ToList();
            return concatAndAddContent(SeperatedReports.ToList());
        }

        public static byte[] concatAndAddContent(List<byte[]> pdfByteContent)
        {

            var ms = new MemoryStream();

            var doc = new iTextSharp.text.Document();

            var copy = new PdfSmartCopy(doc, ms);

            doc.Open();

            //Loop through each byte array
            foreach (var p in pdfByteContent)
            {

                //Create a PdfReader bound to that byte array
                using (var reader = new PdfReader(p))
                {

                    //Add the entire document instead of page-by-page
                    copy.AddDocument(reader);
                }
            }

            doc.Close();



            //Return just before disposing
            return ms.ToArray();
        }







    }



}







