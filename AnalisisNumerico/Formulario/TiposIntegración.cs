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
            if (this.Text == "Trapezoidal Simple")
            {
                TrapezoidalSimple trapezoidalSimple = new TrapezoidalSimple();
                label2.Text = trapezoidalSimple.Calcular(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }
        }
    }
}
