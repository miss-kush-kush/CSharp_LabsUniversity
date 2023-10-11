using System.Text;
using static System.Console;
using Lab2Convertor;

try
{
    string csvFile = "Table.csv";
    string htmlFile = "Table.html";
    Functions.GetHtmlFromCsvFile(csvFile, htmlFile);
}
catch (FileNotFoundException)
{
    WriteLine("The file was not found");
}




