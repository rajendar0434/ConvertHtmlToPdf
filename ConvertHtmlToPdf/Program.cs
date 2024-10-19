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
    }
}
