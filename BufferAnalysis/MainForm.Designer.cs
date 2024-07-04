namespace BufferAnalysis
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboxDistanceField = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkVoronoi = new System.Windows.Forms.CheckBox();
            this.buttonTempPath = new System.Windows.Forms.Button();
            this.textTempPath = new System.Windows.Forms.TextBox();
            this.radioMerge = new System.Windows.Forms.RadioButton();
            this.buttonBuilding = new System.Windows.Forms.Button();
            this.TextBuildingPath = new System.Windows.Forms.TextBox();
            this.checkStacking = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.BufferTypeText = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BufferDistanceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unitsText = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.outputPathText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputPathText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Location = new System.Drawing.Point(490, 4);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(397, 28);
            this.axToolbarControl1.TabIndex = 1;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(490, 33);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(721, 661);
            this.axMapControl1.TabIndex = 0;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Location = new System.Drawing.Point(490, 437);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(257, 257);
            this.axTOCControl1.TabIndex = 2;
            this.axTOCControl1.UseWaitCursor = true;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(918, 437);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 694);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboBoxDirection);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.comboxDistanceField);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txtMessages);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.BufferTypeText);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.BufferDistanceText);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.unitsText);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.outputPathText);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.inputPathText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 661);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "生成缓冲区";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "缓冲区方向:";
            this.label8.Visible = false;
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Items.AddRange(new object[] {
            "LEFT",
            "RIGHT",
            "OUTSIDE_ONLY",
            "INSIDE_ONLY"});
            this.comboBoxDirection.Location = new System.Drawing.Point(108, 224);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(135, 28);
            this.comboBoxDirection.TabIndex = 36;
            this.comboBoxDirection.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "选择距离字段：";
            // 
            // comboxDistanceField
            // 
            this.comboxDistanceField.FormattingEnabled = true;
            this.comboxDistanceField.Location = new System.Drawing.Point(326, 176);
            this.comboxDistanceField.Name = "comboxDistanceField";
            this.comboxDistanceField.Size = new System.Drawing.Size(107, 28);
            this.comboxDistanceField.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.checkVoronoi);
            this.panel1.Controls.Add(this.buttonTempPath);
            this.panel1.Controls.Add(this.textTempPath);
            this.panel1.Controls.Add(this.radioMerge);
            this.panel1.Controls.Add(this.buttonBuilding);
            this.panel1.Controls.Add(this.TextBuildingPath);
            this.panel1.Controls.Add(this.checkStacking);
            this.panel1.Controls.Add(this.label6);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(10, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 165);
            this.panel1.TabIndex = 33;
            // 
            // checkVoronoi
            // 
            this.checkVoronoi.AutoSize = true;
            this.checkVoronoi.Location = new System.Drawing.Point(130, 32);
            this.checkVoronoi.Name = "checkVoronoi";
            this.checkVoronoi.Size = new System.Drawing.Size(115, 24);
            this.checkVoronoi.TabIndex = 45;
            this.checkVoronoi.Text = "泰森多边形";
            this.checkVoronoi.UseVisualStyleBackColor = true;
            // 
            // buttonTempPath
            // 
            this.buttonTempPath.Location = new System.Drawing.Point(316, 62);
            this.buttonTempPath.Name = "buttonTempPath";
            this.buttonTempPath.Size = new System.Drawing.Size(119, 43);
            this.buttonTempPath.TabIndex = 43;
            this.buttonTempPath.Text = "暂存Path";
            this.buttonTempPath.UseVisualStyleBackColor = true;
            this.buttonTempPath.Visible = false;
            // 
            // textTempPath
            // 
            this.textTempPath.Location = new System.Drawing.Point(11, 70);
            this.textTempPath.Name = "textTempPath";
            this.textTempPath.Size = new System.Drawing.Size(299, 26);
            this.textTempPath.TabIndex = 44;
            this.textTempPath.Visible = false;
            // 
            // radioMerge
            // 
            this.radioMerge.AutoSize = true;
            this.radioMerge.Location = new System.Drawing.Point(10, 32);
            this.radioMerge.Name = "radioMerge";
            this.radioMerge.Size = new System.Drawing.Size(114, 24);
            this.radioMerge.TabIndex = 42;
            this.radioMerge.TabStop = true;
            this.radioMerge.Text = "融合缓冲区";
            this.radioMerge.UseVisualStyleBackColor = true;
            // 
            // buttonBuilding
            // 
            this.buttonBuilding.Location = new System.Drawing.Point(315, 111);
            this.buttonBuilding.Name = "buttonBuilding";
            this.buttonBuilding.Size = new System.Drawing.Size(119, 43);
            this.buttonBuilding.TabIndex = 34;
            this.buttonBuilding.Text = "选择建筑轮廓";
            this.buttonBuilding.UseVisualStyleBackColor = true;
            this.buttonBuilding.Visible = false;
            // 
            // TextBuildingPath
            // 
            this.TextBuildingPath.Location = new System.Drawing.Point(10, 119);
            this.TextBuildingPath.Name = "TextBuildingPath";
            this.TextBuildingPath.Size = new System.Drawing.Size(299, 26);
            this.TextBuildingPath.TabIndex = 40;
            this.TextBuildingPath.Visible = false;
            // 
            // checkStacking
            // 
            this.checkStacking.AutoSize = true;
            this.checkStacking.Location = new System.Drawing.Point(249, 33);
            this.checkStacking.Name = "checkStacking";
            this.checkStacking.Size = new System.Drawing.Size(131, 24);
            this.checkStacking.TabIndex = 39;
            this.checkStacking.Text = "叠加建筑轮廓";
            this.checkStacking.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "高级选项:";
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(10, 484);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(447, 165);
            this.txtMessages.TabIndex = 30;
            this.txtMessages.Text = "欢迎使用通用缓冲区分析平台！！！\r\n";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 43);
            this.button3.TabIndex = 29;
            this.button3.Text = "生成缓冲区";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BufferTypeText
            // 
            this.BufferTypeText.FormattingEnabled = true;
            this.BufferTypeText.Items.AddRange(new object[] {
            "统一缓冲区",
            "可变缓冲区",
            "双向缓冲区",
            "回退缓冲区"});
            this.BufferTypeText.Location = new System.Drawing.Point(108, 130);
            this.BufferTypeText.Name = "BufferTypeText";
            this.BufferTypeText.Size = new System.Drawing.Size(135, 28);
            this.BufferTypeText.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "缓冲区类型:";
            // 
            // BufferDistanceText
            // 
            this.BufferDistanceText.Location = new System.Drawing.Point(106, 178);
            this.BufferDistanceText.Name = "BufferDistanceText";
            this.BufferDistanceText.Size = new System.Drawing.Size(79, 26);
            this.BufferDistanceText.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "缓冲区距离:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "单位:";
            // 
            // unitsText
            // 
            this.unitsText.FormattingEnabled = true;
            this.unitsText.Items.AddRange(new object[] {
            "km",
            "m"});
            this.unitsText.Location = new System.Drawing.Point(307, 130);
            this.unitsText.Name = "unitsText";
            this.unitsText.Size = new System.Drawing.Size(71, 28);
            this.unitsText.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 43);
            this.button2.TabIndex = 21;
            this.button2.Text = "输出Path";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // outputPathText
            // 
            this.outputPathText.Location = new System.Drawing.Point(88, 81);
            this.outputPathText.Name = "outputPathText";
            this.outputPathText.Size = new System.Drawing.Size(260, 26);
            this.outputPathText.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "输出图层:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "选择图层";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputPathText
            // 
            this.inputPathText.Location = new System.Drawing.Point(88, 20);
            this.inputPathText.Name = "inputPathText";
            this.inputPathText.Size = new System.Drawing.Size(260, 26);
            this.inputPathText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "输入图层:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(471, 661);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "缓冲区分析";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 702);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axTOCControl1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.axMapControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox BufferTypeText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BufferDistanceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox unitsText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox outputPathText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputPathText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkStacking;
        private System.Windows.Forms.Button buttonBuilding;
        private System.Windows.Forms.TextBox TextBuildingPath;
        private System.Windows.Forms.RadioButton radioMerge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboxDistanceField;
        private System.Windows.Forms.Button buttonTempPath;
        private System.Windows.Forms.TextBox textTempPath;
        private System.Windows.Forms.CheckBox checkVoronoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDirection;
    }
}