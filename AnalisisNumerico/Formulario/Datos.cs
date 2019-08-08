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
    public partial class Datos : Form
    {
        private Bisección Bisección { get; set; }

        public Datos()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IngresarDatos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float izq = Convert.ToSingle(textBox1.Text);
            float der = Convert.ToSingle(textBox2.Text);
            int iter = (int)Convert.ToSingle(textBox3.Text);
            float tole = Convert.ToSingle(textBox4.Text);
            Solución solu = new Solución();
            if (Text == "Datos Bisección")
            {
                Bisección bisección = new Bisección(izq, der, iter, tole, 0, 0, 0, 0);
                solu = bisección.Calcular(izq, der, iter, tole);           
            }
            else
            {
                ReglaFalsa reglafalsa = new ReglaFalsa(izq, der, iter, tole, 0, 0, 0, 0);
                solu = reglafalsa.Calcular(izq, der, iter, tole);
            }
            label10.Text = solu.iteru.ToString();
            label11.Text = Convert.ToDecimal(solu.erel).ToString();
            label12.Text = solu.sol.ToString();
            label13.Text = solu.Error;
            if (solu.Error == null)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
