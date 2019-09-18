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
    public partial class SistEcuaciones : Form
    {
        public int dime { get; set; }
        public GaussJordan gaussJordan { get; set; }
        public GaussSeidel gaussSeidel { get; set; }

        public SistEcuaciones()
        {
            InitializeComponent();
        }

        private void SistEcuaciones_Load(object sender, EventArgs e)
        {
            cantelem.MaxLength = 1; 
        }

        private void generar_Click(object sender, EventArgs e)
        {
            int cantelementos = dime;
            int pointx = 30;
            int pointy = 30;
            panel1.Controls.Clear();
            for (int j = 0; j < dime; j++)
            {
                for (int i = 0; i < dime; i++)
                {
                    TextBox txt = new TextBox();
                    txt.Location = new Point(pointx, pointy);
                    txt.Name = $"txt{i}{j}";
                    txt.AutoSize = false;
                    txt.Size = new Size(40,40);
                    txt.Font = new Font("Microsoft Sans Serif", 10);
                    panel1.Controls.Add(txt);
                    panel1.Show();
                    pointy +=50;
                }
                pointx += 50;
                pointy = 30;
            }
            
            for (int i = 0; i < dime; i++)
            {
                TextBox txt = new TextBox();
                txt.Location = new Point(pointx, pointy);
                txt.Name = $"txtb{i}";
                txt.AutoSize = false;
                txt.Size = new Size(40, 40);
                txt.Font = new Font("Microsoft Sans Serif", 10);
                txt.BackColor = Color.LightBlue;
                panel1.Controls.Add(txt);
                panel1.Show();
                pointy += 50;
            }
            if (comboBox1.Text == "Gauss Jordan")
            {
                gaussJordan = new GaussJordan();
                gaussJordan.dim = int.Parse(cantelem.Text);
                dime = gaussJordan.dim;
            }
            else
            {
                gaussSeidel = new GaussSeidel();
                gaussSeidel.dim = int.Parse(cantelem.Text);
                dime = gaussSeidel.dim;
            }
        }

        private void cantelem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public double[,] LlenarMatriz()
        {
            double[,] matriz = new double[dime, dime+1];

            double[] v = new double[(dime * dime) + dime];
            int i = 0;
            foreach (TextBox txt in panel1.Controls.OfType<TextBox>())
            {
                v[i] = Convert.ToDouble(txt.Text);
                i++;
            }

            int xv = 0;
            for (int ym = 0; ym < dime+1; ym++)
            {
                for (int xm = 0; xm < dime; xm++)
                {
                    matriz[xm, ym] = v[xv];
                    xv++;
                }
            }
            return matriz;
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double[] vectorResult;
            if (comboBox1.Text == "Gauss Jordan")
            {
                this.Text = "Método Gauss Jordan";
                vectorResult = gaussJordan.Calcular(LlenarMatriz());
            }
            else
            {
                this.Text = "Método Gauss Seidel";
                vectorResult = gaussSeidel.Calcular(LlenarMatriz());
                if (gaussSeidel.iteru > 100)

                    label4.Text = "Se superó la cantidad máxima de iteraciones";
                else
                {
                    label3.Text = "Iteraciones utilizadas";
                    label4.Text = Convert.ToString(gaussSeidel.iteru);
                }                          
                if (gaussSeidel.DD == true)
                    label5.Text = "El sistema es Diagonalmente Dominante";
                else
                {
                    if (gaussSeidel.DDParcial == true)
                        label5.Text = "El sistema no es DD pero con diferencia menor a 1";
                    else
                        label5.Text = "El sistema no es Diagonalmente Dominante";
                }
            }
                int pointx = 400;
                int pointy = 35;
                for (int i = 0; i < dime; i++)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(pointx, pointy);
                    lbl.Size = new Size(150,50);
                    switch (i)
                    {
                        case 0:
                            lbl.Text = $"X = {vectorResult[i]}";
                            break;
                        case 1:
                            lbl.Text = $"Y = {vectorResult[i]}";
                            break;
                        case 2:
                            lbl.Text = $"Z = {vectorResult[i]}";
                            break;
                        case 3:
                            lbl.Text = $"T = {vectorResult[i]}";
                            break;
                        case 4:
                            lbl.Text = $"W = {vectorResult[i]}";
                            break;
                    }
                    panel1.Controls.Add(lbl);
                    panel1.Show();
                    pointy += 50;
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
