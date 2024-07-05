using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.AnalysisTools;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataManagementTools;
using ESRI.ArcGIS.Geometry;
using System.Diagnostics;

namespace BufferAnalysis
{
    public partial class MainForm : Form
    {
        private BufferAnalyzer bufferAnalyzer;
        private Voronoi voronoi;
        private ClipTool clipTool;
        private BufferErase bufferErase;

        public MainForm()
        {
            InitializeComponent();
            bufferAnalyzer = new BufferAnalyzer();
            voronoi = new Voronoi();
            clipTool = new ClipTool();
            bufferErase = new BufferErase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Shapefile (*.shp)|*.shp|All files (*.*)|*.*";
                openFileDialog.Title = "选择SHP文件";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputPathText.Text = openFileDialog.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Shapefile (*.shp)|*.shp|All files (*.*)|*.*";
                saveFileDialog.Title = "选择SHP文件";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputPathText.Text = saveFileDialog.FileName;
                }
            }
        }

        private void BufferTypeText_SelectedIndexChanged(object sender, EventArgs e)
        {
            string layerPath = inputPathText.Text;
            string bufferType = BufferTypeText.SelectedItem.ToString();
            switch (bufferType)
            {
                case "统一缓冲区":
                    txtMessages.Text += "输入参数=单位+距离！！！\r\n";
                    break;
                case "可变缓冲区":
                    txtMessages.Text += "输入参数=距离字段（属性表默认单位m）！！！";
                    PopulateComboBoxWithFieldNames(layerPath, comboxDistanceField);
                    break;
                case "双向缓冲区":
                    txtMessages.Text += "输入参数=单位+距离！！！";
                    break;
                case "回退缓冲区":
                    txtMessages.Text += "输入参数=单位+距离+方向！！！";
                    break;
                default:
                    break;
            }
        }
        
        //获取输入图层属性表中的所有字段值，将其添加到combox中
        public void PopulateComboBoxWithFieldNames(string layerPath, ComboBox comboBox)
        {
            // 创建工作空间工厂
            IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactory();

            // 获取工作空间
            IWorkspace workspace = workspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(layerPath), 0);

            // 获取图层文件名
            string fileName = System.IO.Path.GetFileName(layerPath);

            // 获取要素工作区
            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspace;

            // 获取要素类
            IFeatureClass featureClass = featureWorkspace.OpenFeatureClass(fileName);

            // 清空ComboBox
            comboBox.Items.Clear();

            // 遍历字段，并将字段名称添加到ComboBox
            for (int i = 0; i < featureClass.Fields.FieldCount; i++)
            {
                IField field = featureClass.Fields.get_Field(i);
                comboBox.Items.Add(field.Name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string layerPath = inputPathText.Text;
            string outputPath = outputPathText.Text;
            string buffertype=BufferTypeText.SelectedItem.ToString();

            bool Merge = checkMerge.Checked;
            bool Voronoi = checkVoronoi.Checked;
            bool Buildings = checkStacking.Checked;

            switch (buffertype)
            {
                case"统一缓冲区":
                    string units_uniform = unitsText.SelectedItem.ToString();
                    double bufferDistance_uniform = Convert.ToDouble(BufferDistanceText.Text);
                    bufferAnalyzer.CreateUniformBuffer(layerPath, bufferDistance_uniform, outputPath, units_uniform, Merge);
                    AddLayerToMap(layerPath);
                    AddLayerToMap(outputPath);
                    txtMessages.Text += "统一缓冲区已成功创建！！！\r\n";
                    break;
                case"可变缓冲区":
                    string bufferDistanceField = comboxDistanceField.SelectedItem.ToString();
                    bufferAnalyzer.CreateVariableBuffer(layerPath, bufferDistanceField, outputPath, Merge);
                    AddLayerToMap(layerPath);
                    AddLayerToMap(outputPath);
                    txtMessages.Text += "可变缓冲区已成功创建！！!\r\n";
                    break;
                case"双向缓冲区":
                    string units_bid = unitsText.SelectedItem.ToString();
                    double bufferDistance_bid = Convert.ToDouble(BufferDistanceText.Text);
                    bufferAnalyzer.CreateBidirectionalBuffer(layerPath, bufferDistance_bid, outputPath, units_bid);
                    AddLayerToMap(layerPath);
                    AddLayerToMap(outputPath);
                    txtMessages.Text += "双向缓冲区已成功创建！！！\r\n";
                    break;
                case"回退缓冲区":
                    string direction = comboBoxDirection.SelectedItem.ToString();
                    string units_side = unitsText.SelectedItem.ToString();
                    double bufferDistance_side = Convert.ToDouble(BufferDistanceText.Text);
                    bufferAnalyzer.CreateNegativeBuffer(layerPath, bufferDistance_side, outputPath, direction);
                    AddLayerToMap(layerPath);
                    AddLayerToMap(outputPath);
                    txtMessages.Text += "回退缓冲区已成功创建！！！\r\n";
                    break;
                default:
                    MessageBox.Show("请选择一个操作");
                    break;
            }

            string outputVoronoiPath = textTempPath.Text;
            string clipVoronoiPath;
            string BuildingPath = TextBuildingPath.Text;
            string eraseBuildingPath;
            if (Voronoi)
            {
                voronoi.CreateVoronoi(layerPath, outputVoronoiPath);
                AddLayerToMap(outputVoronoiPath);
                txtMessages.Text += "泰森多边形已成功创建！！！\r\n";
                
                //裁切泰森多边形
                clipVoronoiPath = clipTool.ClipLayers(outputVoronoiPath,outputPath);
                AddLayerToMap(clipVoronoiPath);
                txtMessages.Text += "泰森多边形已成功裁切！！！\r\n";

                //判断是否要叠加建筑轮廓
                if (Buildings)
                {
                    eraseBuildingPath = bufferErase.PerformErase(clipVoronoiPath, BuildingPath);
                    AddLayerToMap(eraseBuildingPath);
                    txtMessages.Text += "建筑轮廓已成功叠加！！！\r\n";
                }
            }

            if (!Voronoi && Buildings)
            {
                MessageBox.Show("不建议这样，对缓冲区图层叠加建筑轮廓计算将会异常缓慢！");
            }
        }

        //将图层添加到Map中
        public void AddLayerToMap(string layerPath)
        {

            // 创建工作空间工厂
            IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactory();

            // 获取工作空间
            IWorkspace workspace = workspaceFactory.OpenFromFile(System.IO.Path.GetDirectoryName(layerPath), 0);

            // 获取图层文件名
            string fileName = System.IO.Path.GetFileName(layerPath);

            // 获取要素工作区
            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspace;

            // 获取要素类
            IFeatureClass featureClass = featureWorkspace.OpenFeatureClass(fileName);

            // 创建要素图层
            IFeatureLayer featureLayer = new FeatureLayer();
            featureLayer.FeatureClass = featureClass;
            featureLayer.Name = featureClass.AliasName;

            // 将图层添加到MapControl
            axMapControl1.AddLayer((ILayer)featureLayer);

            // 刷新MapControl
            axMapControl1.Refresh();
        }

        private void buttonTempPath_Click(object sender, EventArgs e)
        {
            //获取泰森多边形的输出路径
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Shapefile (*.shp)|*.shp|All files (*.*)|*.*";
                saveFileDialog.Title = "选择SHP文件";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textTempPath.Text = saveFileDialog.FileName;
                }
            }
        }


        private void checkVoronoi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVoronoi.Checked)
            {
                checkMerge.Checked = true;
                txtMessages.Text += "注意：创建泰森多边形只针对点要素！！！";
            }
        }

        private void buttonBuilding_Click(object sender, EventArgs e)
        {
            //获取输入建筑轮廓的路径
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Shapefile (*.shp)|*.shp|All files (*.*)|*.*";
                openFileDialog.Title = "选择SHP文件";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBuildingPath.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
