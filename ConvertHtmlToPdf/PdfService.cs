using iText.Kernel.Pdf;
using iText.Kernel.Utils;


namespace ConvertHtmlToPdf
{
    public class PdfService
    {
        public static void MergePdfs(string[] pdfFiles, string outputFile)
        {
            using PdfWriter writer = new (outputFile);
            using PdfDocument mergedPdf = new(writer);
            PdfMerger merger = new(mergedPdf);

            foreach (string file in pdfFiles)
            {
                using PdfReader reader = new(file);
                using PdfDocument pdf = new(reader);
                merger.Merge(pdf, 1, pdf.GetNumberOfPages());
            }
        }
    }
}
