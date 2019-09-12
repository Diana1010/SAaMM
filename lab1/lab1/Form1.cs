using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab1
{
    public partial class Form1 : Form
    {
        const int countOfIntervals = 20; 
        const double xMin = 0;
        const double xMax = 1;
        const double yMin = 0;
        const double yMax = 0.1;
        const double delta = 1 / (double)countOfIntervals;
        const int N = 200000;

        public Form1()
        {
            InitializeComponent();
        }


        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidNumber(M.Text) && IsValidNumber(A.Text) && IsValidNumber(R0.Text))
                {

                    double a = Convert.ToDouble(A.Text);
                    double m = Convert.ToDouble(M.Text);
                    double r0 = Convert.ToDouble(R0.Text);

                    if (m <= a)
                    {
                        MessageBox.Show("Параметр M должен быть больше A");
                        return;
                    }

                    Lehmer l = new Lehmer(a, m, r0);
                    List<double> xValues = l.getValues(N);


                    Calculations calc = new Calculations(xValues);
                    Mx.Text = (calc.getMx()).ToString("0.0000000");
                    Dx.Text = (calc.getDx()).ToString("0.0000000");
                    Sigma.Text = (calc.getSigma()).ToString("0.0000000");

                    DrawDiagrams(xValues);

                    p.Text = (calc.getPeriod()).ToString();
                    La.Text = (calc.getAperiodLength()).ToString();
                    check.Text = (calc.check()).ToString();

                }
                else
                {
                    MessageBox.Show("Некорректные входные параметры");
                }
            }
            catch
            {
                MessageBox.Show("Извините, произошла ошибка");
            }
        }

        private bool IsValidNumber(string text)
        {
            int number;
            return (int.TryParse(text, out number) && number > 0) ? true : false;
            
        }

        private void DrawDiagrams(List<double> xValues)
        {
            DrawDiagramWithValues(xValues);
            DrawEvaluationDiagram(xValues);
        }

        private void DrawDiagramWithValues(List<double> xValues)
        {
            chart1.Series["Xi"].Points.Clear();
            chart1.Series["Xi"].ChartType = SeriesChartType.Point;

            int max = N;
            //int delta = max / 10000;
            int delta = 100;

            chart1.ChartAreas[0].AxisY.Maximum = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = max;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            //foreach (double x in xValues)
            for (int i = 0; i < max; i += delta)
            {
                chart1.Series["Xi"].Points.AddXY(i, xValues[i]);
            }
        }

        private void DrawEvaluationDiagram(List<double> xValues)
        {
            chart2.Series["Ci"].Points.Clear();

            chart2.ChartAreas[0].AxisY.Maximum = yMax;
            chart2.ChartAreas[0].AxisY.Minimum = yMin;
            chart2.ChartAreas[0].AxisX.Maximum = xMax;
            chart2.ChartAreas[0].AxisX.Minimum = yMin;

            int[] countInIntervals = new int[countOfIntervals];
            int intervalNumber;

            foreach (double x in xValues)
            {
                intervalNumber = (int)Math.Truncate(x / delta);
                countInIntervals[intervalNumber]++;
            }


            for (int i = 0; i < countInIntervals.Length; i++)
            {
                chart2.Series["Ci"].Points.AddXY(i * delta + delta / 2, (double)countInIntervals[i] / N);
            }

            StripLine stripline = new StripLine();
            stripline.StripWidth = 0.0001;
            stripline.BackColor = Color.Aquamarine;
            stripline.IntervalOffset = 1 / (double)countOfIntervals;

            chart2.ChartAreas[0].AxisY.StripLines.Add(stripline);
        }
    }
}
