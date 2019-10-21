using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class RegresiónPolinomial
    {
        public int n { get; set; }
        public double[,] Matriz { get; set; }
        public int Grado { get; set; }
        public double SumX { get; set; }
        public double SumY { get; set; }
        public double[] VectorX { get; set; }
        public double[] VectorY { get; set; }
        public double Sr { get; set; }
        public double St { get; set; }

        public double[] Calcular()
        {
            double[] Resultado;
            GaussJordan gaussJordan = new GaussJordan();
            Matriz = new double[Grado+1, Grado + 2];
            for (int i = 0; i < n; i++)
            {
                SumX += VectorX[i];
                SumY += VectorY[i];
                for (int j = 0; j < Grado + 1; j++)
                {
                    for (int k = 0; k < Grado + 1; k++)
                    {
                        Matriz[j, k] += Math.Pow(VectorX[i], k + j);
                    }
                    Matriz[j, Grado+1] += VectorY[i] * Math.Pow(VectorX[i],j);
                }
            }
            Resultado = gaussJordan.Calcular(Matriz, Grado+1);
            double Base;

            for (int i = 0; i < n-1; i++)
            {
                St = St + Math.Pow((SumY / n) - VectorY[i], 2);
                Base = VectorY[i];
                for (int j = 0; j < Grado; j++)
                {
                    if (j == 0)
                        Base = Base - Resultado[j];
                    else
                        Base = Base - (Resultado[j]*Math.Pow(VectorX[i], i));
                }
                Sr = Sr + Math.Pow(Base, 2);
            }

            return Resultado;
        }
    }
}