using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class GaussSeidel
    {
        public int dim { get; set; }

        public decimal[] Calcular(decimal[,] M, decimal tolerancia, int iter) //matriz llena, tolerancia e iteraciones como parámetro
        {
            decimal[] V = new decimal[dim];
            decimal x = tolerancia + 1;
            int contador = 0;
            decimal resultado;
            decimal[] VANT = new decimal[dim];
            decimal[] R = new decimal[dim];
            bool flag = true;
            while (flag == true & iter > contador)
            {
                contador++;
                if (contador > 1)
                    VANT = V;
                for (int i = 0; i < dim; i++)
                {
                    resultado = M[i, dim];
                    x = M[i, i];
                    for (int j = 0; j < dim; j++)
                    {
                        if (i != j)
                            resultado = resultado - (M[i, j] * V[j]);
                    }
                    x = resultado / x;
                    V[i] = x;
                }
                flag = false;
                for (int i = 0; i < dim; i++)
                {
                    R[i] = Math.Abs(V[i] - VANT[i]);
                    if (R[i] > tolerancia)
                        flag = true;
                }
            }
            return V;
        }
    }
}
