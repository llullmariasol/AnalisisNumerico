using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    public class GaussJordan
    {
        public int dim { get; set; }

        public double[] Calcular(double[,] M) //matriz llena como parámetro
        {
            double[] V = new double[dim];
            for (int i = 0; i <= dim-1; i++)
            {
                double coeficiente = M[i, i];
                for (int j = 0; j <= dim; j++)
                {
                    M[i, j] = M[i, j] / coeficiente;
                }
                for (int j = 0; j <= dim-1; j++)
                {
                    if (i!=j)
                    {
                        coeficiente = M[j, i];
                        for (int k = 0; k <= dim; k++)
                        {
                            M[j, k] = M[j, k] - (coeficiente * M[i, k]);
                        }
                    }
                }
            }
            for (int i = 0; i <=dim-1; i++)
            {
                V[i] = M[i, dim];
            }
            return V;
        }
    }
}
