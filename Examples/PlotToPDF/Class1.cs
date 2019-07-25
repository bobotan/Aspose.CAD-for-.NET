using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections;

namespace PlotToPDF
{
    public class Class1
    {
        [CommandMethod("plotTest")]
        public static void ToPDF()
        {

            Document activeDoc = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument;

            AcadDocument ThisDrawing = activeDoc.GetAcadDocument() as AcadDocument;

            AcadLayout layout = ThisDrawing.ActiveLayout;
            String MediaName = layout.CanonicalMediaName;
            if (MediaName.Equals(""))
            {
                activeDoc.Editor.WriteMessage("There is no media set for the active layout.");
                return;
            }
            else
            {
                activeDoc.Editor.WriteMessage("The media for the active layout is: " + MediaName);
            }

            try
            {
                AcadPlotConfiguration oplot = ThisDrawing.PlotConfigurations.Add("PDF", layout.ModelType);

                oplot.PaperUnits = AcPlotPaperUnits.acMillimeters;

                oplot.StyleSheet = "monochrome.ctb";

                oplot.PlotWithPlotStyles = true;

                oplot.ConfigName = "DWG To PDF.pc3";

                oplot.UseStandardScale = true;

                oplot.StandardScale = AcPlotScale.acScaleToFit;

                oplot.PlotType = AcPlotType.acExtents;

                oplot.CenterPlot = true;

                Object oMediaNames = layout.GetCanonicalMediaNames();
                ArrayList mediaNames = new ArrayList((string[])oMediaNames);
                foreach (String sName in mediaNames)
                {
                    if (sName.Contains(MediaName))

                    {

                        oplot.CanonicalMediaName = sName;

                        layout.CopyFrom(oplot);

                        layout.PlotRotation = AcPlotRotation.ac0degrees;

                        layout.RefreshPlotDeviceInfo();



                        ThisDrawing.SetVariable("BACKGROUNDPLOT", 0);

                        ThisDrawing.Plot.QuietErrorMode = true;



                        ThisDrawing.Plot.PlotToFile("c://temp//d1.pdf", "DWG To PDF.pc3");

                        oplot.Delete();

                        oplot = null;

                        return;

                    }

                }

            }

            catch (System.Exception es)
            {
                // System.Windows.Forms.MessageBox.Show(es.ToString());

            }

        }
    }
}
