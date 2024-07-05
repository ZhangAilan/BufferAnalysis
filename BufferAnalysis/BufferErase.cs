using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace BufferAnalysis
{
    class BufferErase
    {
        string pythonPath = PythonSettings.PythonExecutable;
        string scriptPath = PythonSettings.buffer_erase_py;

        public string PerformErase(string bufferLayer, string buildingLayer)
        {
            string outputPath = string.Empty;
            try
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = pythonPath;
                start.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\"", scriptPath, bufferLayer, buildingLayer);
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                start.RedirectStandardError = true;
                start.CreateNoWindow = true;

                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        outputPath = reader.ReadToEnd().Trim();  // 读取并去除多余的空白字符
                   
                    }

                    using (StreamReader errorReader = process.StandardError)
                    {
                        string error = errorReader.ReadToEnd();
                        if (!string.IsNullOrEmpty(error))
                        {
                            throw new Exception(error);
                        }
                    }
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error running Python script: " + ex.Message);
            }

            return outputPath;
        }
    }
}
