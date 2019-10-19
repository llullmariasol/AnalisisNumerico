using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class RegresiónLineal
    {
        public double a1 { get; set; }
        public double a0 { get; set; }
        public double St { get; set; }
        public double Sr { get; set; }
        public double SumX { get; set; }
        public double SumY { get; set; }
        public double SumXY { get; set; }
        public double SumX2 { get; set; }
        public int n { get; set; } //cantidad de puntos ingresados

        public string Calcular(double[,] Matriz)
        {
            a1 = (n*SumXY - SumX*SumY) / (n*SumX2 - Math.Pow(SumX,2));
            a0 = (SumY / n) - (a1 * (SumX / n));
            //FOR para averiguar St Y Sr

            return "hola"; //mostrar funcion y coeficiente de correlacion
        }
    }
}
