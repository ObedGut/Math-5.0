using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_5._0.Forms
{
    public partial class Ordenamiento : Form
    {
        public Ordenamiento()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int numero1, numero2, numero3;
            try
            {
                numero1 = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en numero 1", "Error");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
            try
            {
                numero2 = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en numero 2", "Error");
                textBox2.Text = "";
                textBox2.Focus();
                return;
            }
            try
            {
                numero3 = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en numero 3", "Error");
                textBox3.Text = "";
                textBox3.Focus();
                return;
            }

            if (numero1 > numero2 && numero1 > numero3)
            {
                if (numero2 > numero3)
                {
                    lblMayor.Text =  numero1.ToString();
                    lblMedio.Text =  numero2.ToString();
                    lblMenor.Text =  numero3.ToString();
                }
                else if (numero3 > numero2)
                {
                    lblMayor.Text = numero1.ToString();
                    lblMedio.Text = numero3.ToString();
                    lblMenor.Text = numero2.ToString();
                }
            }
            if (numero2 > numero1 && numero2 > numero3)
            {
                if (numero1 > numero3)
                {
                    lblMayor.Text = numero2.ToString();
                    lblMedio.Text = numero1.ToString();
                    lblMenor.Text = numero3.ToString();
                }
                else if (numero3 > numero1)
                {
                    lblMayor.Text = numero3.ToString();
                    lblMedio.Text = numero2.ToString();
                    lblMenor.Text = numero1.ToString();
                }
            }
            if (numero3 > numero1 && numero3 > numero2)
            {
                if (numero1 > numero2)
                {
                    lblMayor.Text = numero3.ToString();
                    lblMedio.Text = numero1.ToString();
                    lblMenor.Text = numero2.ToString();
                }
                else if (numero2 > numero1)
                {
                    lblMayor.Text = numero3.ToString();
                    lblMedio.Text = numero2.ToString();
                    lblMenor.Text = numero1.ToString();
                }
            }

            if(numero1 == numero2 || numero2 == numero3 || numero3 == numero1)
            {
                if(numero1 == numero2 && numero3 < numero1)
                {
                    lblMayor.Text = numero1.ToString();
                    lblMedio.Text = "No existe";
                    lblMenor.Text = numero3.ToString();
                }else if(numero1 == numero3 && numero2 < numero1)
                {
                    lblMayor.Text = numero1.ToString();
                    lblMedio.Text = "No existe";
                    lblMenor.Text = numero2.ToString();
                }else if(numero3 == numero2 && numero1 < numero2)
                {
                    lblMayor.Text = numero2.ToString();
                    lblMedio.Text = "No existe";
                    lblMenor.Text = numero1.ToString();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            lblMayor.Text = "-";
            lblMedio.Text = "-";
            lblMenor.Text = "-";
            textBox1.Focus();
        }
    }
}
