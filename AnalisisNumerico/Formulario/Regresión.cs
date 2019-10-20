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
    public partial class Regresión : Form
    {
        public Métodos.RegresiónLineal regresiónLineal { get; set; }

        public Regresión()
        {
            regresiónLineal = new RegresiónLineal();
            InitializeComponent();
            matriz = new double[10, 4];
            cont = 0;
            
        }

        public double[,] matriz { get; set; }
        public int cont { get; set; }

        public void LlenarMatriz(double x, double y)
        {
            matriz[cont, 0] = x;
            matriz[cont, 1] = y;
            matriz[cont, 2] = x*y;
            matriz[cont, 3] = x*x;
            cont++;
        }

        private void Regresión_Load(object sender, EventArgs e)
        {
            if (Text == "Regresión Lineal")
            {
                label5.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenarMatriz(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Calcular sumatorias
            if (Text == "Regresión Lineal")
            {
                regresiónLineal.n = cont;
                for (int i = 0; i < cont - 1; i++)
                {
                    regresiónLineal.SumX += matriz[i, 0];
                    regresiónLineal.SumY += matriz[i, 1];
                    regresiónLineal.SumXY += matriz[i, 2];
                    regresiónLineal.SumX2 += matriz[i, 3];
                }
                A1A0 resultado = new A1A0();
                resultado = regresiónLineal.Calcular(matriz, Convert.ToDouble(textBox3.Text));
                string a1red = resultado.a1.ToString("0.##");
                string a0red = resultado.a0.ToString("0.##");
                label7.Text = $"y = {a1red}x + {a0red}";
                string rred = resultado.r.ToString("0.##");
                label9.Text = $"r = {rred}";
                label27.Text = resultado.Eficacia;
            }
        }
    }
}
