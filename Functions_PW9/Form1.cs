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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			UpdateChart();
		}

		private void UpdateChart()
		{
			if (!double.TryParse(textBoxMin.Text.Replace('.', ','), out double Xmin)) { return; }
			if (!double.TryParse(textBoxMax.Text.Replace('.', ','), out double Xmax)) { return; }
			if (!double.TryParse(textBoxStep.Text.Replace('.', ','), out double XStep)) { return; }

			double steps = (Xmax - Xmin) / XStep;
			int count = (int)Math.Ceiling(steps) + 1;

			double[] x = new double[count];
			double[] y1 = new double[count];
			double[] y2 = new double[count];

			for (int i = 0; i < count; i++)
			{
				x[i] = Xmin + XStep * i;
				y1[i] = Math.Sin(x[i]);
				y2[i] = Math.Cos(x[i]);
			}

			chart1.ChartAreas[0].AxisX.Minimum = Xmin;
			chart1.ChartAreas[0].AxisX.Maximum = Xmax;
			chart1.ChartAreas[0].AxisX.MajorGrid.Interval = XStep;

			chart1.Series[0].Points.DataBindXY(x, y1);
			chart1.Series[1].Points.DataBindXY(x, y2);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UpdateChart();
		}
	}
}