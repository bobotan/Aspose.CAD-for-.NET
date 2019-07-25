using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;

namespace PrintPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string directPath = string.Empty;
                for (int i = 0; i < args.Length; i++)
                {
                    //  Console.WriteLine(args[i]);

                    if (args[i].ToString().Equals("path"))
                    {
                        if (i + 1 < args.Length)
                            directPath = args[i + 1];
                    }
                }
                if (string.IsNullOrWhiteSpace(directPath))
                {
                    Console.WriteLine("Error CommandLine! correct format:   PrintPdf.exe path filepath");
                    return;
                }
                DirectoryInfo TheFolder = new DirectoryInfo(directPath);

                foreach (FileInfo nextFile in TheFolder.GetFiles("*.pdf",))
                {
                    Console.WriteLine($"find file {nextFile.Name}");
                    PdfDocument doc = new PdfDocument();
                    doc.LoadFromFile(nextFile.FullName);
                    doc.PageSettings.Orientation = PdfPageOrientation.Landscape;//设置打印方向

                    PrintDocument printDoc = doc.PrintDocument;
                    printDoc.PrintController = new StandardPrintController();//设置静默打印（默认打印机）
                    printDoc.Print();
                    //doc.PrintDocument.Print();
                    doc.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
