using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class SimpsonMúltiple
    {
        public int n { get; set; }
        public double h { get; set; }

        public static double f(double x)
        {
            return (Math.Pow(Math.E,x))*(1-Math.Pow(0.5,2)); 
        }

        public double Calcular(double a, double b)
        {
            h = (b - a) / n;
            double sumatoria = 0;
            double sumatoria2 = 0;
            double resultado = 0;
            for (int i = 1; i <= n-1; i+=2)
            {
                sumatoria += f((i * h)+a);
            }
            for (int i = 2; i <= n - 2; i += 2)
            {
                sumatoria2+= f((i * h)+a);
            }
            resultado = (h/3) * (f(a) + (4 * sumatoria) + (2 * sumatoria2) + f(b));
            return resultado;
        }
    }
}
