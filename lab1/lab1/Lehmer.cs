using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Lehmer
    {
        private double R0 { set; get;  }
        private double m { set; get; }
        private double a { set; get; }
        private double previousR { set; get; }



        public Lehmer(double a, double m, double R0)
        {
            this.a = a;
            this.m = m;
            this.R0 = R0;
            this.previousR = R0;
        }


        public double getCurrentValue()
        {
            return (a * previousR) % m;
        }

        public List<double> getValues(int N)
        {
            List<double> xValues = new List<double>();

            for(int i = 0; i < N; i++) { 
                double curR = getCurrentValue();
                previousR = curR;
                xValues.Add(curR / m);   
            }

            return xValues;
        }


    }
}
