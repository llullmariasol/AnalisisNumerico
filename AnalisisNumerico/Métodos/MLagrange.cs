using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class MLagrange
    {
        public double[] x { get; set; }
        public double[] y { get; set; }
        public int Grado { get; set; }
        public double Incognita { get; set; }

        public MLagrange()
        {
            x = new double[10];
            y = new double[10];
        }

        public double Calcular()
        {
            double S = 0;
            double Sa = 0;
            double Sb = 0;
            int i = 0;
            while (i <= Grado-1)
            {
                Sa = 1;
                Sb = 1;
                for (int j = 0; j < Grado; j++)
                {
                    if (i!=j)
                    {
                        Sa = Sa * (Incognita - x[j]);
                        Sb = Sb * (x[i] - x[j]);
                    }
                }
                S = S + (y[i] * Sa / Sb);
                i++;
            }
            return S;
        }

        public string Imprimir()
        {
            string ecuacion = "";
            string sa = "";
            string sb = "";
            double S = 0;
            double Sb = 0;
            int i = 0;
            while (i <= Grado - 1)
            {
                Sb = 1;
                sa = "";
                for (int j = 0; j < Grado; j++)
                {
                    if (i != j)
                    {
                        if (y[i] != 0)
                        {
                            if (x[j] < 0)
                                sa = sa + $"(x + {(-1)*x[j]})";
                            else
                                sa = sa + $"(x - {x[j]})";
                            Sb = Sb * (x[i] - x[j]);
                            sb = sb + $".{Sb}";
                        }
                    }
                }
                if (y[i] != 0)
                    ecuacion = ecuacion + $" + {y[i].ToString("0.##")}.{sa}/{Sb}";
                i++;
            }
            return ecuacion;
        }
    }
}
