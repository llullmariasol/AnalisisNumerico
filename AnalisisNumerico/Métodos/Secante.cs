using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class Secante
    {
        public static float f(float x)
        {
            // (float)Math.Log(x +1.5);
            return (float)Math.Pow(x, 0.5);
        }

        public float x1 { get; set; }
        public float x2 { get; set; }
        public int iter { get; set; }
        public float tole { get; set; }
        public int cont { get; set; }
        public float xant { get; set; }
        public float xr { get; set; }
        public float error { get; set; }

        public Secante(float xi1, float xi2, int it, float tol, int c, float x, float xrr, float er)
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

        public Solución Calcular(float x1, float x2, int iter, float tole)
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
                } //ver también si está fuera del dominio
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
                        }
                        s.sol = xr;
                        s.iteru = cont;
                        s.erel = error;
                    }
                }
            }        
            return s;
        }
    }
}
