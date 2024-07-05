using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BufferAnalysis
{
    class Voronoi
    {
        //arcpy创建泰森多边形
        public void CreateVoronoi(string inputShp, string outputShp)
        {
            // Python脚本路径
            string pythonScriptPath = PythonSettings.create_thiessen_py;

            // 创建ProcessStartInfo对象
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = PythonSettings.PythonExecutable, // Python解释器路径
                Arguments = "\"" + pythonScriptPath + "\" \"" + inputShp + "\" \"" + outputShp + "\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            // 启动进程并执行Python脚本
            using (Process process = new Process())
            {
                process.StartInfo = psi;
                process.Start();

                // 读取标准输出和标准错误
                string output = process.StandardOutput.ReadToEnd();
                string errors = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    throw new Exception(errors);
                }

                Console.WriteLine(output);
            }
        }
    }
}
