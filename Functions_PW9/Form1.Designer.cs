using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions_PW9
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxMin = new System.Windows.Forms.TextBox();
			this.textBoxMax = new System.Windows.Forms.TextBox();
			this.textBoxStep = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			series3.BorderWidth = 2;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series3.Legend = "Legend1";
			series3.LegendText = "sin(x)";
			series3.Name = "Sin";
			series4.BorderWidth = 2;
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series4.Legend = "Legend1";
			series4.LegendText = "cos(x)";
			series4.Name = "Cos";
			this.chart1.Series.Add(series3);
			this.chart1.Series.Add(series4);
			this.chart1.Size = new System.Drawing.Size(472, 221);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 224);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Min X";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(77, 224);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Max X";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(128, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Step";
			// 
			// textBoxMin
			// 
			this.textBoxMin.Location = new System.Drawing.Point(15, 250);
			this.textBoxMin.Name = "textBoxMin";
			this.textBoxMin.Size = new System.Drawing.Size(56, 20);
			this.textBoxMin.TabIndex = 4;
			this.textBoxMin.Text = "-10";
			// 
			// textBoxMax
			// 
			this.textBoxMax.Location = new System.Drawing.Point(77, 250);
			this.textBoxMax.Name = "textBoxMax";
			this.textBoxMax.Size = new System.Drawing.Size(48, 20);
			this.textBoxMax.TabIndex = 5;
			this.textBoxMax.Text = "10";
			// 
			// textBoxStep
			// 
			this.textBoxStep.Location = new System.Drawing.Point(131, 250);
			this.textBoxStep.Name = "textBoxStep";
			this.textBoxStep.Size = new System.Drawing.Size(58, 20);
			this.textBoxStep.TabIndex = 6;
			this.textBoxStep.Text = "1.5";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(360, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 46);
			this.button1.TabIndex = 7;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 281);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxStep);
			this.Controls.Add(this.textBoxMax);
			this.Controls.Add(this.textBoxMin);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chart1);
			this.Name = "Form1";
			this.Text = "График функций";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBoxMin;
		private TextBox textBoxMax;
		private TextBox textBoxStep;
		private Button button1;
	}
}
