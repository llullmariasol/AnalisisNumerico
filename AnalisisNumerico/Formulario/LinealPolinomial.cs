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
    public partial class LinealPolinomial : Form
    {
        public LinealPolinomial()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regresión regresión = new Regresión();
            regresión.Owner = this;
            regresión.Text = "Regresión Lineal";
            regresión.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regresión regresión = new Regresión();
            regresión.Owner = this;
            regresión.Show();
        }
    }
}
