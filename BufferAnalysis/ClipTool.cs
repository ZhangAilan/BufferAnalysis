using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.AnalysisTools;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataSourcesGDB;
using System.Diagnostics;

namespace BufferAnalysis
{
    class ClipTool
    {
        public string ClipLayers(string targetLayerPath, string clipLayerPath)
        {
            try
            {
                // Prepare the process start info
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = PythonSettings.PythonExecutable;
                start.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\"", PythonSettings.clipe_layer_py, targetLayerPath, clipLayerPath, targetLayerPath);
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                start.RedirectStandardError = true;
                start.CreateNoWindow = true;

                // Start the process
                using (Process process = Process.Start(start))
                {
                    using (System.IO.StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        process.WaitForExit();

                        if (process.ExitCode == 0)
                        {
                            // Parse the output to get the path to the clipped shapefile
                            string[] lines = result.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (string line in lines)
                            {
                                if (line.StartsWith("Clipped layer created at: "))
                                {
                                    return line.Replace("Clipped layer created at: ", "").Trim();
                                }
                            }
                        }
                        else
                        {
                            string error = process.StandardError.ReadToEnd();
                            Console.WriteLine("Error: " + error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing Python script: " + ex.Message);
            }

            return null;
        }
    }
}
