﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class Bisección
    {
        public static double f(double x)
        {
            return ((12.5 * (x + 2)) / (x * x + 4 * x + 5)) + 2;
        }

        public double izq { get; set; }
        public double der { get; set; }
        public int iter { get; set; }
        public double tole { get; set; }
        public int cont { get; set; }
        public double xant { get; set; }
        public double xr { get; set; }
        public double error { get; set; }

        public Bisección(double i, double d, int it, double to, int c, double x, double xrr, double er)
        {
            izq = i;
            der = d;
            iter = it;
            tole = to;
            cont = c;
            xant = x;
            xr = xrr;
            error = er;   
        }
        
        public Solución Calcular (double izq, double der, int iter, double tole)
        {
            Solución s = new Solución();
            if (f(izq)*f(der)>0)
            {
                s.Error ="Error al calcular la raíz";
            }
            else
            {
                if (f(izq) * f(der) == 0) //la raíz es izq o der
                {
                    if (f(izq) == 0)
                        s.sol = izq;
                    else
                        s.sol = der;
                }
                else //menor a 0, buscar raíz
                {
                    cont = 0;
                    xant = 0;

                    xr = (izq + der) / 2;
                    cont = cont + 1;
                    error = Math.Abs((xr - xant) / xr);

                    while ((Math.Abs(f(xr)) >= tole) && (cont <= iter) && (error >= tole))
                    {
                        if (f(izq) * f(der) < 0)
                            der = xr;
                        else
                            izq = xr;
                        xant = xr;

                        xr = (izq + der) / 2;
                        cont = cont + 1;
                        error = Math.Abs((xr - xant) / xr);
                    }
                    s.sol = xr;
                    s.iteru = cont;
                    s.erel = error;            
                }               
            }       
            return s;
        }
    }
}
