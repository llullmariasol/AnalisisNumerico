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
        public SistEcuaciones()
        {
            InitializeComponent();
        }

        private void SistEcuaciones_Load(object sender, EventArgs e)
        {

        }

        private void generar_Click(object sender, EventArgs e)
        {
            int cantelementos = int.Parse(cantelem.Text);
            int pointx = 120;
            int pointy = 120;
            panel1.Controls.Clear();
            for (int j = 0; j < int.Parse(cantelem.Text); j++)
            {
                for (int i = 0; i < int.Parse(cantelem.Text); i++)
                {
                    TextBox txt = new TextBox();
                    txt.Location = new Point(pointx, pointy);
                    txt.Height= 50; 
                    txt.Name = $"txt{i}{j}";
                    panel1.Controls.Add(txt);
                    panel1.Show();
                    pointy += 60;
                }
                pointx += 120;
                pointy = 120;
            }

        }

        private void cantelem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
