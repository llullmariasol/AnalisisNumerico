using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Métodos;

namespace Formulario
{
    public partial class RegresiónMinCuadrados : Form
    {
        public RegresiónMinCuadrados regresiónMinCuadrados { get; set; }

        public RegresiónMinCuadrados()
        {
            InitializeComponent();
            matriz = new double[cont, 3];
            cont = 0;
        }

        public double[,] matriz { get; set; }
        public int cont { get; set; }

        public void LlenarMatriz(double x, double y)
        {
            cont++;
            matriz[cont, 0] = x;
            matriz[cont, 1] = y;
            matriz[cont, 2] = x*y;
            matriz[cont, 3] = x*x;
        }

        private void RegresiónMinCuadrados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenarMatriz(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regresiónMinCuadrados = new RegresiónMinCuadrados();
            string solucion = regresiónMinCuadrados.Calcular(matriz);
        }

        private string Calcular(double[,] matriz)
        {
            throw new NotImplementedException();
        }
    }
}
