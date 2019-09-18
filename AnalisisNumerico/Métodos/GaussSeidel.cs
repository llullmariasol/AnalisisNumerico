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
            tole = 0.0001;
            iter = 100;
        }

        public double[] Calcular(double[,] M) //matriz llena, tolerancia e iteraciones como parámetro
        {
            double[] V = new double[dim];
            double x;
            int contador = 0;
            double resultado;
            double[] VANT = new double[dim];
            double[] R = new double[dim];
            bool flag = true;
            DD = true;
            for (int i = 0; i < dim; i++)  // recorro las filas de la matriz
            {
                double diagonal = M[i, i];
                double sumatoria = 0;
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
            while (flag == true & iter >= contador)
            {
                contador++;
                if (contador > 1)
                   V.CopyTo(VANT, 0);
                for (int i = 0; i < dim; i++)
                {
                    resultado = M[i, dim];
                    x = Convert.ToDouble(M[i, i]);
                    for (int j = 0; j < dim; j++)
                    {
                        if (i != j)
                            resultado = resultado - (M[i, j] * V[j]);
                    }
                    x = Convert.ToDouble(resultado) / x;
                    V[i] = x;
                }
                flag = false;
                for (int i = 0; i < dim; i++)
                {
                    R[i] = Math.Abs(V[i] - VANT[i]);
                    if (R[i] > tole)
                        flag = true;
                }       
            }
            iteru = contador;
            return V;
        }
    }
}
