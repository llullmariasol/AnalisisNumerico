using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class Bisección
    {
        public static float f(float x)
        {
            return (x*x*x) - (2*x) + 2;
        }

        public float izq { get; set; }
        public float der { get; set; }
        public int iter { get; set; }
        public float tole { get; set; }
        public int cont { get; set; }
        public float xant { get; set; }
        public float xr { get; set; }
        public float error { get; set; }

        public Bisección(float i, float d, int it, float to, int c, float x, float xrr, float er)
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
        
        public Solución Calcular (float izq, float der, int iter, float tole)
        {
            Solución s = new Solución();
            if (f(izq)*f(der)>0)
            {
                s.Error ="Error al calcular la raíz"; //poner todos los campos en 0 del formulario
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
