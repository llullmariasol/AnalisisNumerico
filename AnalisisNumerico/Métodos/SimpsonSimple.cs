using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class SimpsonSimple
    {
        public static double f(double x)
        {
            return Math.Pow(Math.E, x) * (1 - (0.5 * Math.Pow(x, 2)));
        }

        public double Calcular(double a, double b)
        {
            double h;
            h = (b - a) / 2;
            return (h / 3) * (f(a) + 4 * f(h) + f(b));
        }
    }
}
