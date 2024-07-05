using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufferAnalysis
{
    public static class PythonSettings
    {
        public static string PythonExecutable = @"C:\\Python27\\ArcGIS10.2\\python.exe"; // 修改为Python可执行文件的路径
        public static string create_thiessen_py = @"C:\\Users\\zyh\\Desktop\\BufferAnalysis\\BufferAnalysis\\create_thiessen.py"; // 修改为Python脚本的路径
        public static string clipe_layer_py = @"C:\\Users\\zyh\\Desktop\\BufferAnalysis\\BufferAnalysis\\clip_layers.py";
        public static string variable_buffer_py = @"C:\\Users\\zyh\\Desktop\\BufferAnalysis\\BufferAnalysis\\variable_buffer.py";
        public static string single_side_buffer_py = @"C:\\Users\\zyh\\Desktop\\BufferAnalysis\\BufferAnalysis\\single_side_buffer.py";
        public static string buffer_erase_py = @"C:\\Users\\zyh\\Desktop\\BufferAnalysis\\BufferAnalysis\\buffer_erase.py";
    }
}
