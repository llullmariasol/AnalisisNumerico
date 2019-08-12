using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class Newton_Raphson
    {

        public static double f(double x)
        {
            return (x * x * x) - (2 * x) + 2;
        }

        public double xini { get; set; }
        public int iter { get; set; }
        public double tole { get; set; }
        public int cont { get; set; }
        public double xant { get; set; }
        public double xr { get; set; }
        public double error { get; set; }
        public double Deri { get; set; }

        public Newton_Raphson(double xin, int it, double to)
        {
            xini = xin;
            iter = it;
            tole = to;
        }
        
        public Solución Calcular()
        {
            cont = 0;
            Solución s = new Solución();
            if (f(xini) == 0)
            {
                xr = xini;
                error = 1;
            }
            else
            {
                xant = 0;
                cont = cont + 1;
                Deri = (f(xini + 0.0001) - f(xini)) / 0.0001;
                xr = xini - f(xini) / Deri;
                if (xr == 0)
                    s.Error = "La recta tangente es horizontal, no se puede seguir con el procedimiento";
                else
                {
                    error = Math.Abs(xr - xant) / xr;

                    while (Math.Abs(f(xr)) > tole && cont < iter && error > tole) //Mientras f(xr) sea mayor a la tolerancia, el contador sea menor a las
                                                                                  //iteraciones y el error sea mayor a la tolerancia, se sigue buscando xr
                    {
                        xini = xr;
                        xant = xr;
                        cont = cont + 1;
                        error = Math.Abs(xr - xant) / xr;
                    }
                    // Si sale del while es porque una de las condiciones se cumplió, entonces encontró la raíz

                    s.sol = Convert.ToSingle(xr);
                    s.iteru = cont;
                    s.erel = Convert.ToSingle(error);
                }
            }
            return s;
        }
    }
}
