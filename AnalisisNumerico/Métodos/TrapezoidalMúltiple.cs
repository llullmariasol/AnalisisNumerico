using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class TrapezoidalMúltiple
    {
        public double h { get; set; } //distancia entre los intervalos 
        public int n { get; set; }  //cantidad de intervalos

        public static double f(double x)
        {
            return Math.Pow(x,2); 
        }

        public double Calcular(double a, double b)
        {
            h = (b - a) / n;
            double resultado = 0;
            double sumatoria = 0;
            for (int i = 1; i <= n-1; i++)
            {
                sumatoria += f((i * h) + a);
            }
            resultado = (h/2) * (f(a) + sumatoria + f(b));
            return resultado;
        }
    }
}
