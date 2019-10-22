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
    public partial class Lagrange : Form
    {
        public double[] Vectorx { get; set; }
        public double[] Vectory { get; set; }
        public int Grado { get; set; }
        public int Cont { get; set; }

        public Lagrange(double[] vectorx, double[] vectory, int grado, int cont)
        {
            InitializeComponent();
            Vectorx = vectorx;
            Vectory = vectory;
            Grado = grado;
            Cont = cont;
        }

        private void Lagrange_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MLagrange lagrange = new MLagrange();
            lagrange.Grado = Cont;
            for (int i = 0; i < Cont; i++)
            {
                lagrange.x[i] = Vectorx[i];
                lagrange.y[i] = Vectory[i];
            }
            lagrange.Incognita = Convert.ToDouble(textBox1.Text);
            label5.Text = lagrange.Calcular().ToString();
            label3.Text = lagrange.Imprimir();
        }
    }
}
