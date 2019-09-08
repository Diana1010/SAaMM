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
            if (IsValidNumber(M.Text) && IsValidNumber(A.Text) && IsValidNumber(R0.Text))
            {
                
                double a = Convert.ToDouble(A.Text);
                double m = Convert.ToDouble(M.Text);
                double r0 = Convert.ToDouble(R0.Text);

                //Lehmer l = new Lehmer(1567, 68030, 2797);
                Lehmer l = new Lehmer(a, m, r0);
                List<double> xValues = l.getValues(N);


                Calculations calc = new Calculations(xValues);
                Mx.Text = (calc.getMx()).ToString();
                Dx.Text = (calc.getDx()).ToString();
                Sigma.Text = (calc.getSigma()).ToString();

                DrawDiagram(xValues);

                p.Text = (calc.getPeriod()).ToString();
                La.Text = (calc.getAperiodLength()).ToString();
                check.Text = (calc.check()).ToString();

            }
            else
            {
                MessageBox.Show("Incorrect values");
            }
        }

        private bool IsValidNumber(string text)
        {
            double number;
            return (double.TryParse(text, out number) && number > 0) ? true : false;
            
        }



        private void DrawDiagram(List<double> xValues)
        {
            chart1.Series["Ci"].Points.Clear();

            chart1.ChartAreas[0].AxisY.Maximum = yMax;
            chart1.ChartAreas[0].AxisY.Minimum = yMin;
            chart1.ChartAreas[0].AxisX.Maximum = xMax;
            chart1.ChartAreas[0].AxisX.Minimum = yMin;

            int[] countInIntervals = new int[countOfIntervals] ;
            int intervalNumber = 0;

            foreach (double x in xValues)
            {
                intervalNumber = (int)Math.Truncate(x / delta);
                countInIntervals[intervalNumber]++;
            }
            

            for (int i = 0; i < countInIntervals.Length; i++)
            {
                chart1.Series["Ci"].Points.AddXY(i * delta + delta / 2, (double) countInIntervals[i] / N);
            }

            StripLine stripline = new StripLine();
            stripline.StripWidth = 0.0009;
            stripline.BackColor = Color.Aquamarine;
            stripline.IntervalOffset = 1 / (double)countOfIntervals;

            chart1.ChartAreas[0].AxisY.StripLines.Add(stripline);
        }

      
    }
}
