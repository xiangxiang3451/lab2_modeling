namespace WindowsFormsApp2
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InputEuro = new System.Windows.Forms.NumericUpDown();
            this.InputUSA = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputUSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.InputUSA);
            this.panel1.Controls.Add(this.InputEuro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 127);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 479);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = " Initial price:";
            // 
            // InputEuro
            // 
            this.InputEuro.Location = new System.Drawing.Point(238, 51);
            this.InputEuro.Name = "InputEuro";
            this.InputEuro.Size = new System.Drawing.Size(120, 28);
            this.InputEuro.TabIndex = 1;
            this.InputEuro.Value = new decimal(new int[] {
            9990,
            0,
            0,
            131072});
            // 
            // InputUSA
            // 
            this.InputUSA.Location = new System.Drawing.Point(407, 51);
            this.InputUSA.Name = "InputUSA";
            this.InputUSA.Size = new System.Drawing.Size(120, 28);
            this.InputUSA.TabIndex = 2;
            this.InputUSA.Value = new decimal(new int[] {
            9190,
            0,
            0,
            131072});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start/Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea18.AxisX.Maximum = 11D;
            chartArea18.AxisX.Minimum = 0D;
            chartArea18.AxisY.Maximum = 102D;
            chartArea18.AxisY.Minimum = 90D;
            chartArea18.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea18);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend18.Name = "Legend1";
            this.chart1.Legends.Add(legend18);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series35.BorderWidth = 3;
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series35.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series35.IsValueShownAsLabel = true;
            series35.LabelFormat = "f4";
            series35.Legend = "Legend1";
            series35.Name = "Euro";
            series36.BorderWidth = 3;
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series36.Color = System.Drawing.Color.Red;
            series36.IsValueShownAsLabel = true;
            series36.LabelFormat = "f4";
            series36.Legend = "Legend1";
            series36.Name = "USA";
            this.chart1.Series.Add(series35);
            this.chart1.Series.Add(series36);
            this.chart1.Size = new System.Drawing.Size(1083, 479);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputUSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown InputUSA;
        private System.Windows.Forms.NumericUpDown InputEuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

