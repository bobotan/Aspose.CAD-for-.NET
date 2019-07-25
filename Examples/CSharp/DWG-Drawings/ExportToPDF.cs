﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.CAD;
namespace Aspose.CAD.Examples.CSharp.DWG_Drawings
{
    public class ExportToPDF
    {
        public static void Run()
        {
            //ExStart:ExportToPDF
            // The path to the documents directory.
            string MyDir = RunExamples.GetDataDir_DWGDrawings();
            string sourceFilePath = MyDir + "666368_1.DWG";//"Bottom_plate.dwg";
            using (Aspose.CAD.Image image = Aspose.CAD.Image.Load(sourceFilePath))
            {
                // Create an instance of CadRasterizationOptions and set its various properties
                Aspose.CAD.ImageOptions.CadRasterizationOptions rasterizationOptions = new Aspose.CAD.ImageOptions.CadRasterizationOptions();
                rasterizationOptions.BackgroundColor = Aspose.CAD.Color.White;
                rasterizationOptions.PageWidth = 1600;
                rasterizationOptions.PageHeight = 1600;
                // Set Layouts
                rasterizationOptions.Layouts = new string[] { "Layout1" };
                // Create an instance of PdfOptions
                Aspose.CAD.ImageOptions.PdfOptions pdfOptions = new Aspose.CAD.ImageOptions.PdfOptions();
                // Set the VectorRasterizationOptions property
                pdfOptions.VectorRasterizationOptions = rasterizationOptions;

                MyDir = MyDir + "Bottom_plate_out.pdf";
                //Export the DWG to PDF
                image.Save(MyDir, pdfOptions);                
            }
            //ExEnd:ExportToPDF            
            Console.WriteLine("\nThe DWG file exported successfully to PDF.\nFile saved at " + MyDir);

        }
    }
}
