using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Generator
    {
        public int R0 { get; protected set; }
        public int m { get; protected set; }
        public int a { get; protected set; }

        private double current;
        private double prevR;

        public Generator(int a, int m, int R0)
        {
            this.a = a;
            this.m = m;
            this.R0 = R0;
            prevR = R0;
        }

        public double GetNext()
        {
            Move();
            return current / this.m;
        }

        private void Move()
        {
            current = (a * prevR) % m;
            prevR = current;   
        }
    }
}
