using System;
using System.IO;

namespace Sample
{
    class Test
    {
        static void Main(string[] args)
        {
            // Add a page header and footer during the conversion of HTML to RTF or DOCX.
            // If you need more information about "HTML to RTF .Net" email us at:
            // support@sautinsoft.com.
            AddHeaderAndFooter();
        }

        public static void AddHeaderAndFooter()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            string inputFile = @"..\..\Sample.html";
            string outputFile = "Result.docx";

            // Set page header and footer.
            string headerFromHtml = File.ReadAllText(@"..\..\header.html");
            string footerFromRtf = File.ReadAllText(@"..\..\footer.rtf");

            // Add page header.
            h.PageStyle.PageHeader.Html(headerFromHtml);

            // Add extra space between header and page contents.
            h.PageStyle.PageHeader.MarginBottom.Mm(10);

            // Add page footer.
            h.PageStyle.PageFooter.Rtf(footerFromRtf);

            if (h.OpenHtml(inputFile))
            {
                bool ok = h.ToDocx(outputFile);

                // Open the result for demonstration purposes.
                if (ok)
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
            }
        }
    }
}
