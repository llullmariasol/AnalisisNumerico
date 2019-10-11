using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class Secante
    {
        public static double f(double x)
        {
            return (((10 * x) + 20) / ((x * x) + (4 * x) + 5)) + 2;
            // return (Math.Log(x)) + (1 / x) - 3;
            // return ((x*x)-(3*x)+Math.Log(1+x)) - (5-Math.Pow(x,0.5));
            //return (Math.Abs((x * x) - 4)) + (2 * x);
            // return ((12.5 * (x + 2)) / (x * x + 4 * x + 5)) + 2;
        }

        public double x1 { get; set; }
        public double x2 { get; set; }
        public int iter { get; set; }
        public double tole { get; set; }
        public int cont { get; set; }
        public double xant { get; set; }
        public double xr { get; set; }
        public double error { get; set; }

        public Secante(double xi1, double xi2, int it, double tol, int c, double x, double xrr, double er)
        {
            x1 = xi1;
            x2 = xi2;
            iter = it;
            tole = tol;
            cont = c;
            xant = x;
            xr = xrr;
            error = er;
        }

        public Solución Calcular(double x1, double x2, int iter, double tole)
        {
            Solución s = new Solución();
            if (x1 < x2)
            {
                s.Error = "El punto inicial 1 debe ser mayor que el punto inicial 2";
            }
            else
            {
                if (f(x1) == f(x2))
                {
                    s.Error = "Mal elegidos los puntos";
                } 
                else
                {
                    if (f(x1) == 0 || f(x2) == 0) //la raíz es x1 o x2
                    {
                        if (f(x1) == 0)
                            s.sol = x1;
                        else
                            s.sol = x2;
                    }
                    else //buscar raíz
                    {
                        if (f(x1).ToString() == "NaN" || f(x1).ToString() == "NaN")
                        {
                            s.Error = "Un punto o ambos está/n fuera del dominio";
                        }
                        else
                        {
                            cont = 0;
                            xant = 0;

                            cont = cont + 1;
                            xr = ((f(x2) * x1) - (f(x1) * x2)) / (f(x2) - f(x1));
                            error = Math.Abs((xr - xant) / xr);

                            while ((Math.Abs(f(xr)) >= tole) && (cont <= iter) && (error >= tole))
                            {
                                x1 = x2;
                                x2 = xr;
                                xant = xr;

                                cont = cont + 1;
                                xr = ((f(x2) * x1) - (f(x1) * x2)) / (f(x2) - f(x1));
                                error = Math.Abs((xr - xant) / xr);
                                if (f(x1) == f(x2))
                                {
                                    s.Error = "Mal elegidos los puntos";
                                    cont = 102;
                                }
                            }
                            s.sol = xr;
                            s.iteru = cont;
                            s.erel = error;

                            if (f(xr).ToString() == "NaN")
                            {
                                s.Error = "Mal elegidos los puntos";
                            }
                        }           
                    }
                }
            }        
            return s;
        }
    }
}
