using Métodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Newton : Form
    {
        public Newton()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void Newton_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {// double xin, int it, double to, int c, double x, double xrr, double er, double der            
            double xini = Convert.ToDouble(textBox1.Text);
            int iter = (int)Convert.ToSingle(textBox3.Text);
            double tole = Convert.ToSingle(textBox2.Text);
            Newton_Raphson newton = new Newton_Raphson(xini, iter, tole);
            Solución solu = newton.Calcular(xini, iter, tole);

            if (solu.sol.ToString() == "NaN" || solu.erel.ToString() == "NaN")
            {
                solu.Error = "Mal elegidos los puntos";
            }
            else
            {
                label10.Text = solu.iteru.ToString();
                label11.Text = solu.sol.ToString();
                label2.Text = Convert.ToDecimal(solu.erel).ToString();
            }
            label13.Text = solu.Error;

            if (solu.Error != null)
            {
                //textBox1.Text = "";
                //textBox2.Text = "";
                //textBox3.Text = "";
                label10.Text = "-";
                label11.Text = "-";
                label2.Text = "-";
            }

        }
    }
}
