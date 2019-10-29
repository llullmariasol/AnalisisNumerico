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
            if (Text == "Trapezoidal Simple" || Text == "Simpson 1/3 Simple" || Text == "Simpson 3/8")
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

            if (this.Text == "Trapezoidal Múltiple")
            {
                TrapezoidalMúltiple trapezoidalMultiple = new TrapezoidalMúltiple();
                trapezoidalMultiple.n = Convert.ToInt16(textBox3.Text);
                label2.Text = trapezoidalMultiple.Calcular(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text)).ToString();
            }

            if (this.Text == "Simpson 1/3 Simple")
            {
                SimpsonSimple simpsonSimple = new SimpsonSimple();
                label2.Text = simpsonSimple.Calcular(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }

            if (this.Text == "Simpson 1/3 Múltiple")
            {
                SimpsonMúltiple simpsonMultiple = new SimpsonMúltiple();
                if (simpsonMultiple.n % 2 == 0) //es par
                {
                    simpsonMultiple.n = Convert.ToInt16(textBox3.Text);
                    label2.Text = simpsonMultiple.Calcular(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
                }
                else //es impar, usa en conjunto Simpson 1/3 multiple y Simpson 3/8
                {
                    double result1, result2;
                    SimpsonTresOct simpsonTresOct = new SimpsonTresOct();
                    simpsonMultiple.n = Convert.ToInt16(textBox3.Text) - 3;
                    result1 = simpsonMultiple.Calcular(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text) - 3);
                    result2 = simpsonTresOct.Calcular(Convert.ToDouble(textBox2.Text) - 3, Convert.ToDouble(textBox2.Text));
                    label2.Text = (result1 + result2).ToString();
                }
            }

            if (this.Text == "Simpson 3/8")
            {
                SimpsonTresOct simpsonTresOct = new SimpsonTresOct();
                label2.Text = simpsonTresOct.Calcular(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }
        }
    }
}
