using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using SeriesCollection = LiveCharts.SeriesCollection;

namespace Si_projekt
{
	public partial class Form2 : Form
	{
		//Thread nawigacja;
		SeriesCollection series = new SeriesCollection();
		public Form2(double[] wyniki,SeriesCollection sr,string [] wartosci,string doLabela)
		{
			InitializeComponent();
			label1.Text = $"Pokolenie : {doLabela}";
			
			//this.chart1.Series["Age"].Points.Add("Max",33);
			for (int i = 0; i < wyniki.Length; i++)
			{
				chart1.Series["Series1"].Points.AddXY($"chromosm{i}",wyniki[i]);
				chart1.Series["Series1"].LegendText += $"Chromosom{i}={wartosci[i]} \n\n";
			}
			pieChart1.Series =sr;

			
		}

		private void Powrot_Click(object sender, EventArgs e)
		{
	
		}
	






		private void Form2_Load(object sender, EventArgs e)
		{
			pieChart1.LegendLocation = LegendLocation.Bottom;
			
		}
	}
}
