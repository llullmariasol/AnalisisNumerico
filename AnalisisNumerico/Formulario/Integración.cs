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
    public partial class Integración : Form
    {
        public Integración()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiposIntegración tiposIntegración = new TiposIntegración();
            tiposIntegración.Owner = this;
            tiposIntegración.Text = "Trapezoidal Simple";
            tiposIntegración.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TiposIntegración tiposIntegración = new TiposIntegración();
            tiposIntegración.Owner = this;
            tiposIntegración.Text = "Trapezoidal Múltiple";
            tiposIntegración.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TiposIntegración tiposIntegración = new TiposIntegración();
            tiposIntegración.Owner = this;
            tiposIntegración.Text = "Simpson 1/3 Simple";
            tiposIntegración.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TiposIntegración tiposIntegración = new TiposIntegración();
            tiposIntegración.Owner = this;
            tiposIntegración.Text = "Simpson 1/3 Múltiple";
            tiposIntegración.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TiposIntegración tiposIntegración = new TiposIntegración();
            tiposIntegración.Owner = this;
            tiposIntegración.Text = "Simpson 3/8";
            tiposIntegración.Show();
        }

        private void Integración_Load(object sender, EventArgs e)
        {

        }
    }
}
