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
        public RegresiónLineal regresiónLineal { get; set; }
        public RegresiónPolinomial regresiónPolinomial { get; set; }
        public int grado { get; set; }
        public double[] VectorX { get; set; }
        public double[] VectorY { get; set; }

        public Regresión()
        {
            InitializeComponent();
            VectorY = new double[10];
            VectorX = new double[10];
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
                regresiónLineal = new RegresiónLineal();
                matriz = new double[10, 4];
                label5.Visible = false;
                textBox4.Visible = false;
            }
            else
            {
                regresiónPolinomial = new RegresiónPolinomial();
                regresiónPolinomial.VectorX = new double[10];
                regresiónPolinomial.VectorY = new double[10];
            }
            cont = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Text == "Regresión Lineal")
                LlenarMatriz(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            else
            {
                regresiónPolinomial.VectorX[cont] = Convert.ToDouble(textBox1.Text);
                VectorX[cont] = regresiónPolinomial.VectorX[cont];
                regresiónPolinomial.VectorY[cont] = Convert.ToDouble(textBox2.Text);
                VectorY[cont] = regresiónPolinomial.VectorY[cont];
                cont++;
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Text == "Regresión Lineal")
            {
                regresiónLineal.n = cont;
                for (int i = 0; i < cont; i++)
                {
                    regresiónLineal.SumX += matriz[i, 0];
                    regresiónLineal.SumY += matriz[i, 1];
                    regresiónLineal.SumXY += matriz[i, 2];
                    regresiónLineal.SumX2 += matriz[i, 3];
                }
                A1A0 resultado = new A1A0();
                resultado = regresiónLineal.Calcular(matriz, 80);
                string a1red = resultado.a1.ToString("0.##");
                string a0red = resultado.a0.ToString("0.##");
                label7.Text = $"y = {a1red}x + {a0red}";
                string rred = resultado.r.ToString("0.##");
                label9.Text = $"r = {rred}";
                label27.Text = resultado.Eficacia;
            }
            else
            {
                regresiónPolinomial.n = cont;
                regresiónPolinomial.Grado = int.Parse(textBox4.Text);
                grado = regresiónPolinomial.Grado;
                double[] solución = new double[regresiónPolinomial.Grado + 1];
                solución = regresiónPolinomial.Calcular();
                label7.Text = "y = ";
                for (int i = regresiónPolinomial.Grado; i > -1; i--)
                {
                    if (i > 1)
                        label7.Text += $"{solución[i].ToString("0.##")}(x^{i}) + ";
                    else
                        if (i == 0)
                            label7.Text += $"{solución[i].ToString("0.##")}";
                        else
                            label7.Text += $"{solución[i].ToString("0.##")}x + ";
                }

                double r;
                if (regresiónPolinomial.St != 0)
                {
                    r = Math.Sqrt((regresiónPolinomial.St - regresiónPolinomial.Sr) / regresiónPolinomial.St) * 100;
                    label9.Text = $"r = {r.ToString("0.##")}";

                    if (r < Convert.ToInt32(textBox3.Text))
                        label27.Text = "No es aceptable el ajuste";
                    else
                        label27.Text = "El ajuste es aceptable";
                }
                else
                    label9.Text = "Error, división por 0";
                          
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lagrange lagrange = new Lagrange(VectorX, VectorY, grado, cont);
            lagrange.Owner = this;
            lagrange.Show();
        }
    }
}