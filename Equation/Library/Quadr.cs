using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Quadr
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public Quadr(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public void ToFindD()
        {
            this.D = this.B * this.B - 4 * this.A * this.C;
        }

        public double[] ToFindResult()
        {
            this.ToFindD();
            double[] x = {0,0};
            if (this.D > 0)
            {
                x[0] = (-this.B + Math.Sqrt(this.D)) / (2 * this.A);
                x[1] = (-this.B - Math.Sqrt(this.D)) / (2 * this.A);
                return x;
            }
            else
            {
                if (this.D == 0)
                {
                    x[0] = (-this.B) / (2 * this.A);
                    return x;
                }
            }

            return x;
        }
    }


}
