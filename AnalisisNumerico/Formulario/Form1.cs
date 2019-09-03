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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unidad1 nuevaUni = new Unidad1();
            nuevaUni.Owner = this;
            nuevaUni.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SistEcuaciones sistEcuaciones = new SistEcuaciones();
            sistEcuaciones.Owner = this;
            sistEcuaciones.Show();
         
        }
    }
}
