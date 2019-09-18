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
        public double tole { get; set; }
        public int iter { get; set; }
        public int iteru { get; set; }
        public bool DD { get; set; }
        public bool DDParcial { get; set; }

        public GaussSeidel()
        {
            tole = 0.001;
            iter = 100;
        }

        public decimal[] Calcular(decimal[,] M) //matriz llena, tolerancia e iteraciones como parámetro
        {
            decimal[] V = new decimal[dim];
            decimal x;
            int contador = 0;
            decimal resultado;
            decimal[] VANT = new decimal[dim];
            decimal[] R = new decimal[dim];
            bool flag = true;
            DD = true;
            for (int i = 0; i < dim; i++)  // recorro las filas de la matriz
            {
                decimal diagonal = M[i, i];
                decimal sumatoria = 0;
                for (int j = 0; j < dim; j++)  // recorro las columnas
                {
                    if (i != j)
                        sumatoria = sumatoria + Math.Abs(M[i, j]);
                }
                if (Math.Abs(diagonal) < sumatoria) // si alguna ecuacion tiene la diagonal menor que la sumatoria no es DD
                {
                    DD = false;
                    break;
                }
                else
                {
                    if (Math.Abs(diagonal) - sumatoria > 1) // si la diagonal es menor pero no más que una diferencia de 1, es "parcial"
                    {
                        DDParcial = false;
                        break;
                    }
                    else
                        DDParcial = true;
                }
            }
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
                    if (R[i] > Convert.ToDecimal(tole))
                        flag = true;
                }
            }
            iteru = contador;
            return V;
        }
    }
}
