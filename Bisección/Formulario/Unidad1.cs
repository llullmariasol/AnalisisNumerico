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
    public partial class Unidad1 : Form
    {
        public Unidad1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            datos.Owner = this;
            datos.Show();
        }

        private void Unidad1_Load(object sender, EventArgs e)
        {

        }
    }
}
