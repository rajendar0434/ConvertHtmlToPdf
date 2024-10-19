using iText.Kernel.Pdf;
using iText.Kernel.Utils;

namespace ConvertHtmlToPdf
{
    public class PdfServiceBase
    {
        public void MergePdf(string[] pdfFiles, string outputFile)
        {
            using PdfWriter writer = new PdfWriter(outputFile);
            using PdfDocument mergedPdf = new PdfDocument(writer);
            PdfMerger merger = new PdfMerger(mergedPdf);

            foreach (string file in pdfFiles)
            {
                using PdfReader reader = new PdfReader(file);
                using PdfDocument pdf = new PdfDocument(reader);
                merger.Merge(pdf, 1, pdf.GetNumberOfPages());
            }
        }
    }
}