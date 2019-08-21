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
    public partial class DatosSecante : Form
    {
        public DatosSecante()
        {
            InitializeComponent();
        }

        private void DatosSecante_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float x1 = Convert.ToSingle(textBox1.Text);
            float x2 = Convert.ToSingle(textBox2.Text);
            int iter = (int)Convert.ToSingle(textBox3.Text);
            float tole = Convert.ToSingle(textBox4.Text);
            Solución solu = new Solución();
            Secante secante = new Secante(x1, x2, iter, tole, 0, 0, 0, 0);
            solu = secante.Calcular(x1, x2, iter, tole);

            if (solu.sol.ToString() == "NaN" || solu.erel.ToString() == "NaN")
            {
                solu.Error = "Mal elegidos los puntos";
            }
            else
            {
                label10.Text = solu.iteru.ToString();
                label11.Text = Convert.ToDecimal(solu.erel).ToString();
                label12.Text = solu.sol.ToString();
            }
            label13.Text = solu.Error;

            if (solu.Error != null)
            {
                // textBox1.Text = "";
                // textBox2.Text = "";
                // textBox3.Text = "";
                // textBox4.Text = "";
                label10.Text = "-";
                label11.Text = "-";
                label12.Text = "-";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
