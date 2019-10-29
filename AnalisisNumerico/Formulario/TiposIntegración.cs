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
    public partial class TiposIntegración : Form
    {
        public TiposIntegración()
        {
            InitializeComponent();      
        }

        private void TiposIntegración_Load(object sender, EventArgs e)
        {
            if (Text == "Trapezoidal Simple" || Text == "Simpson 1/3 Simple")
            {
                Controls.Remove(textBox3);
                Controls.Remove(label5);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Text == "Trapezoidal Simple")
            {
                TrapezoidalSimple trapezoidalSimple = new TrapezoidalSimple();
                label2.Text = trapezoidalSimple.Calcular(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }

            /////////////////
            if (this.Text == "Simpson 1/3 Simple")
            {
                SimpsonSimple simpsonSimple = new SimpsonSimple();
                label2.Text = simpsonSimple.Calcular(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }
        }
    }
}
