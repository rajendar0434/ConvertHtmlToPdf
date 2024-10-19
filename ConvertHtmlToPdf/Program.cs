using ConvertHtmlToPdf;
using iText.Html2pdf;

class Program
{
    static void Main(string[] args)
    {
        string html = "<html><body><h1>HTML to Pdf</h1><div>This is an example to convert Html to Pdf file using itext7 in C#</div></body></html>";
        string outputPath = "C:\\Pdf\\output.pdf";       

        using (FileStream outputStream = new FileStream(outputPath, FileMode.Create))
        {
            ConverterProperties converterProperties = new ConverterProperties();
            HtmlConverter.ConvertToPdf(html, outputStream, converterProperties);
        }

        Console.WriteLine("HTML to PDF conversion completed successfully and pdf file create at C:\\Pdf.");

        // Merge PDF files
        string[] pdfFiles = { "C:\\Pdf\\output1.pdf", "C:\\Pdf\\output2.pdf" };
        string outputFile = "C:\\Pdf\\Merged.pdf";
        PdfService.MergePdfs(pdfFiles, outputFile);

        Console.WriteLine("Given Pdf files merged and new pdf file Merged.pdf created at C:\\Pdf.");
    }
}
