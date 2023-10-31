
namespace procesorMemorie
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.lblcpu = new MetroFramework.Controls.MetroLabel();
            this.lblram = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pGPU = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGPU)).BeginInit();
            this.SuspendLayout();
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_total";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CPU
            // 
            // 
            // 
            // 
            this.CPU.CustomButton.Image = null;
            this.CPU.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.CPU.CustomButton.Name = "";
            this.CPU.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CPU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CPU.CustomButton.TabIndex = 1;
            this.CPU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CPU.CustomButton.UseSelectable = true;
            this.CPU.CustomButton.Visible = false;
            this.CPU.Lines = new string[] {
        "CPU"};
            this.CPU.Location = new System.Drawing.Point(146, 86);
            this.CPU.MaxLength = 32767;
            this.CPU.Name = "CPU";
            this.CPU.PasswordChar = '\0';
            this.CPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CPU.SelectedText = "";
            this.CPU.SelectionLength = 0;
            this.CPU.SelectionStart = 0;
            this.CPU.ShortcutsEnabled = true;
            this.CPU.Size = new System.Drawing.Size(96, 23);
            this.CPU.TabIndex = 0;
            this.CPU.Text = "CPU";
            this.CPU.UseSelectable = true;
            this.CPU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CPU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "RAM"};
            this.metroTextBox2.Location = new System.Drawing.Point(146, 127);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(96, 23);
            this.metroTextBox2.TabIndex = 1;
            this.metroTextBox2.Text = "RAM";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(273, 86);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(273, 23);
            this.metroProgressBar1.TabIndex = 2;
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(273, 127);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(273, 23);
            this.metroProgressBar2.TabIndex = 3;
            this.metroProgressBar2.Click += new System.EventHandler(this.metroProgressBar2_Click);
            // 
            // lblcpu
            // 
            this.lblcpu.AutoSize = true;
            this.lblcpu.Location = new System.Drawing.Point(590, 89);
            this.lblcpu.Name = "lblcpu";
            this.lblcpu.Size = new System.Drawing.Size(29, 20);
            this.lblcpu.TabIndex = 4;
            this.lblcpu.Text = "0%";
            // 
            // lblram
            // 
            this.lblram.AutoSize = true;
            this.lblram.Location = new System.Drawing.Point(590, 127);
            this.lblram.Name = "lblram";
            this.lblram.Size = new System.Drawing.Size(29, 20);
            this.lblram.TabIndex = 5;
            this.lblram.Text = "0%";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 172);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(742, 212);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 424);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblram);
            this.Controls.Add(this.lblcpu);
            this.Controls.Add(this.metroProgressBar2);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.CPU);
            this.Name = "Form1";
            this.Text = "Monitorizare RAM si CPU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTextBox CPU;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        private MetroFramework.Controls.MetroLabel lblcpu;
        private MetroFramework.Controls.MetroLabel lblram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Diagnostics.PerformanceCounter pGPU;
    }
}

