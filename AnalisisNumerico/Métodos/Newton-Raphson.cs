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
            return -0.0145*Math.Pow(x,3)+0.0724 * Math.Pow(x, 2) + 2.8772 * x - 20.6481;
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
        
        public Solución Calcular(double xini, int iter, double tole)
        {
            cont = 0;
            double function = f(xini);
            Solución s = new Solución();
            if (f(xini) == 0)
            {
                xr = xini;
                error = 0;
            }
            else
            {
                if (f(xini).ToString()=="NaN")
                {
                    s.Error = "Punto inicial mal elegido";
                }
                else
                {
                    xant = 0;
                    cont = cont + 1; 
                    Deri = (f(xini + 0.0001) - f(xini)) / 0.0001;
                    xr = xini - (f(xini) / Deri); 
                    if (Deri == 0)
                        s.Error = "La recta tangente es horizontal, no se puede seguir con el procedimiento";
                    else
                    {
                        error = Math.Abs((xr - xant) / xr);

                        while (Math.Abs(f(xr)) >= tole && cont <= iter && error >= tole) //Mientras f(xr) sea mayor a la tolerancia, el contador sea menor a las iteraciones y el error sea mayor a la tolerancia, se sigue buscando xr
                        {
                            xini = xr;                       
                            xant = xr;
                            cont = cont + 1;

                            Deri = (f(xini + 0.0001) - f(xini)) / 0.0001;
                            xr = xini - (f(xini) / Deri);
                            if (Deri == 0 || f(xr).ToString()=="NaN")
                            {
                                s.Error = "Punto inicial mal elegido";
                            }
                            error = Math.Abs((xr - xant) / xr);
                        }
                        // Si sale del while es porque una de las condiciones se cumplió, entonces encontró la raíz

                        s.sol = xr;
                        s.iteru = cont;
                        s.erel = error;

                        if (f(xr).ToString()=="NaN")
                        {
                            s.Error = "Punto inicial mal elegido";
                        }

                        // Verificar si salió por SUPERAR LAS ITERACIONES (QUEDÓ EN UN "BUCLE") >>VER
                        if (cont > iter)
                        {
                            s.Error = "Superó la cantidad de iteraciones";
                        }
                    }
                }             
            }
            return s;
        }
    }
}
