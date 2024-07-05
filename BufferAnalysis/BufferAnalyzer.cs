using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.AnalysisTools;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using Buffer = ESRI.ArcGIS.AnalysisTools.Buffer;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataManagementTools;
using ESRI.ArcGIS.Geometry;
using System.Diagnostics;

namespace BufferAnalysis
{
    class BufferAnalyzer
    {

        //通用缓冲区执行函数
        private void ExecuteBuffer(Geoprocessor gp, Buffer buffer, string layerName)
        {
            IGeoProcessorResult results = null;
            try
            {
                results = (IGeoProcessorResult)gp.Execute(buffer, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建缓冲区失败！");
                return;
            }

            if (results == null || results.Status != esriJobStatus.esriJobSucceeded)
            {
                MessageBox.Show("缓冲区加载失败！");
            }
        }

        //统一缓冲区
        public void CreateUniformBuffer(string layerPath, double bufferDistance, string outputPath, string units,bool dissolve)
        {
            if (bufferDistance <= 0)
            {
                MessageBox.Show("缓冲距离无效！");
                return;
            }

            Geoprocessor gp = new Geoprocessor { OverwriteOutput = true };
            Buffer buffer = new Buffer
            {
                in_features = layerPath,
                out_feature_class = outputPath,
                buffer_distance_or_field = ConvertDistanceToMeters(bufferDistance, units).ToString() + " Meters",
                dissolve_option = dissolve ? "ALL" : "NONE"
            };

            ExecuteBuffer(gp, buffer, null);
        }

        //输入距离的可变缓冲区
        public void CreateVariableBuffer(string layerPath, string BufferDistanceField, string outputPath, bool dissolve)
        {
            try
            {
                // 设置进程启动信息
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = PythonSettings.PythonExecutable;
                start.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\" ",PythonSettings.variable_buffer_py, layerPath, BufferDistanceField, outputPath, dissolve ? 1 : 0);
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                start.RedirectStandardError = true;
                start.CreateNoWindow = true;

                // 启动进程
                using (Process process = Process.Start(start))
                {
                    using (System.IO.StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.WriteLine(result);
                    }
                    using (System.IO.StreamReader reader = process.StandardError)
                    {
                        string error = reader.ReadToEnd();
                        if (!string.IsNullOrEmpty(error))
                        {
                            Console.WriteLine("错误: " + error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("调用Python脚本失败: " + ex.Message);
            }
        }

        //双向缓冲区
        public void CreateBidirectionalBuffer(string layerPath, double bufferDistance, string outputPath, string units)
        {
            if (bufferDistance <= 0)
            {
                MessageBox.Show("缓冲距离无效！");
                return;
            }
            Geoprocessor gp = new Geoprocessor { OverwriteOutput = true };
            Buffer buffer = new Buffer
            {
                in_features = layerPath,
                out_feature_class = outputPath,
                buffer_distance_or_field = ConvertDistanceToMeters(bufferDistance, units).ToString() + " Meters",
                dissolve_option = "ALL",
                line_side = "FULL"
            };

            ExecuteBuffer(gp, buffer, null);
        }

        //回退缓冲区
        public void CreateNegativeBuffer(string layerPath, double bufferDistance, string outputPath, string sideType = "LEFT")
        {
            try
            {
                string buffer_distance_or_field = bufferDistance.ToString() + " Meters";

                // 设置进程启动信息
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = PythonSettings.PythonExecutable;
                start.Arguments = string.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\"",
                                                 PythonSettings.single_side_buffer_py, layerPath, outputPath, buffer_distance_or_field, sideType);
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                start.RedirectStandardError = true;
                start.CreateNoWindow = true;

                // 启动进程
                using (Process process = Process.Start(start))
                {
                    using (System.IO.StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.WriteLine(result);
                    }
                    using (System.IO.StreamReader reader = process.StandardError)
                    {
                        string error = reader.ReadToEnd();
                        if (!string.IsNullOrEmpty(error))
                        {
                            Console.WriteLine("错误: " + error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("调用Python脚本失败: " + ex.Message);
            }
        }
 

        //将距离转换为m
        private double ConvertDistanceToMeters(double distance, string units)
        {
            if (units == "km")
            {
                return distance * 1000;
            }
            else //默认单位为米
            {
                return distance;
            }
        }
    }
}
