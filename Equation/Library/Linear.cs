using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Linear
    {
        public double A { get; set; }
        public double B { get; set; }

        public Linear(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public double ToFindResult()
        {
            double x = (-this.B) / this.A;
            return x;
        }
    }
}
