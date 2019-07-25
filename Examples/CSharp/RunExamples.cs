﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Aspose.CAD.Examples.CSharp.DWG_Drawings;
using Aspose.CAD.Examples.CSharp.DXF_Drawings;
using Aspose.CAD.Examples.CSharp.ConvertingCAD;
using Aspose.CAD.Examples.CSharp.Export;
using Aspose.CAD.Examples.CSharp.Exporting_DGN;
using Aspose.CAD.Examples.CSharp.DWF_Drawings;
using Aspose.CAD.Examples.CSharp.IGES_Drawings;
using Aspose.CAD.Examples.CSharp.PLT_Drawings;

namespace Aspose.CAD.Examples.CSharp
{
    class RunExamples
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");
            // Uncomment the one you want to try out

            //// =====================================================
            //// =====================================================
            //// DWF-Drawings
            //// =====================================================
            //// =====================================================

            //GetSizeOfDwfLayout.Run();

            //// =====================================================
            //// =====================================================
            //// DWG-Drawings
            //// =====================================================
            //// =====================================================

           // ExportToPDF.Run();
           // ExportSpecificLayoutToPDF.Run();
            //GetBlockAttributeValue.Run();
            //SearchText.Run();
            //SupportMLeaderEntityForDWGFormat.Run();
            //AddTextInDWG.Run();
            //ParticularDWGToImage.Run();
            //ImportImageToDWG.Run();
            //MeshSupportForDWG.Run();
            //ColorRendering.Run();
            //DWGToDXF.Run();
            //ExportToSVG.Run();
            //// =====================================================
            //// =====================================================
            //// DXF-Drawings
            //// =====================================================
            //// =====================================================

            ExportDXFToPDF.Run();
            //ExportDXFSpecificLayerToPDF.Run();
           // ExportDXFSpecificLayoutToPDF.Run();
            //SaveDXFFiles.Run();
            //AddAttribute.Run();
            //SupportOfBlockClipping.Run();
            //ExportImagesToDXF.Run();
            //EnableTracking.Run();

            //// =====================================================
            //// =====================================================
            //// ConvertingCAD
            //// =====================================================
            //// =====================================================

            //PenSupportInExport.Run(); 
            //GetSizeOfCADLayout.Run();
            //ConvertDrawingToRasterImage.Run();
            //ListLayouts.Run();
            ConvertLayoutsToRasterImage.Run();
            //MeshSupport.Run();
            //IntegrateIGESFormat.Run();
            //SettingCanvasSizeAndMode.Run();
            //SettingBackgroundAndDrawingColors.Run();
            //SettingAutoLayoutScaling.Run();
            //EnableTrackingForCADRendering.Run();
            //SubstitutingFonts.Run();
            CADLayersToRasterImageFormats.Run();

            //// =====================================================
            //// =====================================================
            ////Export
            //// =====================================================
            //// =====================================================

             Export3DImagestoPDF.Run();
            //CADLayoutsToPDF.Run();
            //ExportToBMP.Run();
            //ExportDWFToPDF.Run();
            //DecomposeCADInsertObject.Run();
            //ACADProxyEntities.Run();


            //// =====================================================
            //// =====================================================
            ////Exporting-DGN
            //// =====================================================
            //// =====================================================

            //ExportDGNToPdf.Run();
            //ExportDGNToRasterImage.Run();


            //// =====================================================
            //// =====================================================
            //// IGES-Drawings
            //// =====================================================
            //// =====================================================

            //ExportIGEStoPDF.Run();


            //// =====================================================
            //// =====================================================
            //// PLT-Drawings
            //// =====================================================
            //// =====================================================

            //ExportPLTtoImage.Run();
            //ExportPLTtoPDF.Run();

            //add here


            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }
        public static String GetDataDir_ExportingDGN()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Exporting-DGN/");
        }
        public static String GetDataDir_DWGDrawings()
        {
            return Path.GetFullPath(GetDataDir_Data() + "DWG-Drawings/");
        }
        public static String GetDataDir_DXFDrawings()
        {
            return Path.GetFullPath(GetDataDir_Data() + "DXF-Drawings/");
        }
        public static String GetDataDir_PLTDrawings()
        {
            return Path.GetFullPath(GetDataDir_Data() + "PLT-Drawings/");
        }
        public static String GetDataDir_IGESDrawings()
        {
            return Path.GetFullPath(GetDataDir_Data() + "IGES-Drawings/");
        }
        public static String GetDataDir_ConvertingCAD()
        {
            return Path.GetFullPath(GetDataDir_Data() + "ConvertingCAD/");
        }
        public static String GetDataDir_DWFDrawings()
        {
            return Path.GetFullPath(GetDataDir_Data() + "DWF-Drawings/");
        }

        private static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return Path.Combine(startDirectory, "Data\\");
        }
        public static string GetOutputFilePath(String inputFilePath)
        {
            string extension = Path.GetExtension(inputFilePath);
            string filename = Path.GetFileNameWithoutExtension(inputFilePath);
            return filename + "_out" + extension;
        }
    }
}
