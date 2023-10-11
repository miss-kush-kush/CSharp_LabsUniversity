using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2Convertor;

internal static class Functions
{
    internal static void GetHtmlFromCsvFile(string csvFilePath, string htmlFilePath)
    {
        using (StreamReader reader = new StreamReader(csvFilePath))
        {
            GetHtmlFromCsv(reader, htmlFilePath);
        }
    }

    internal static void FileHeader(StreamWriter htmlFile)
    {
        htmlFile.WriteLine("<html >");
        htmlFile.WriteLine("<head>");
        htmlFile.WriteLine("<style>");
        htmlFile.WriteLine("table { font-family: cambria; border-collapse: collapse; width: auto;}");
        htmlFile.WriteLine("table td, table th { border: 1px solid #ddd; padding: 8px; }");
        htmlFile.WriteLine("table tr:nth-child(even){background-color: #f2f2f2;}");
        htmlFile.WriteLine("table tr:hover {background-color: #ddd;}");
        htmlFile.WriteLine("table th { padding-top: 12px; padding-bottom: 12px; text-align: left; background-color: #4CAF50; color: white;}");
        htmlFile.WriteLine("</style>");
        htmlFile.WriteLine("</head>");
        htmlFile.WriteLine("<body>");
        htmlFile.WriteLine("<table>");
    }

    internal static void FileFooter(StreamWriter htmlFile)
    {
        htmlFile.WriteLine("</table>");
        htmlFile.WriteLine("</body>");
        htmlFile.WriteLine("</html>");
    }

    internal static void TableHeader(StreamWriter htmlFile, string[] headerLine)
    {
        htmlFile.WriteLine("<thead>");
        foreach (var header_col in headerLine)
        {
            htmlFile.WriteLine("<th>" + header_col + "</th>");
        }
        htmlFile.WriteLine("</thead>");
    }

    internal static void TableData(StreamWriter htmlFile, StreamReader csvReader)
    {
        htmlFile.WriteLine("<tbody>");

        string line;
        while ((line = csvReader.ReadLine()) != null)
        {
            var data = line.Split(';');
            htmlFile.WriteLine("<tr>");
            foreach (var data_col in data)
            {
                htmlFile.WriteLine("<td>" + data_col + "</td>");
            }
            htmlFile.WriteLine("</tr>");
        }

        htmlFile.WriteLine("</tbody>");
    }

    internal static void GetHtmlFromCsv(StreamReader csvReader, string htmlFilePath)
    {
        using (StreamWriter htmlFile = new StreamWriter(htmlFilePath))
        {
            FileHeader(htmlFile);

            var headerLine = csvReader.ReadLine();
            if (headerLine != null)
            {
                string[] headers = headerLine.Split(';');
                TableHeader(htmlFile, headers);
            }

            TableData(htmlFile, csvReader);
            FileFooter(htmlFile);
        }
    }

}




