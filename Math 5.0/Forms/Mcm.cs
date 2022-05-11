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
    public partial class Mcm : Form
    {
        public Mcm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1, numero2, minimo, mcm, mcd;

            try
            {
                numero1 = int.Parse(textBox1.Text);
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
                numero2 = int.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en numero 2", "Error");
                textBox2.Text = "";
                textBox2.Focus();
                return;
            }
            minimo = Math.Min(numero1, numero2); //Seleccionamos el menor
            mcm = 0; //Variable para el resultado
            for (int i = 1; i <= minimo; i++) //Ciclo para las iteraciones
            {
                //Condicion que comprobara si el numero corresponde
                //a la iteracion es el mcd

                if (numero1 % i == 0 && numero2 % i == 0)
                {
                    mcd = i; //Asignamos el mcd
                    mcm = (numero1 * numero2) / mcd; //Calculamos el mcm
                }
            }

            lblMcm.Text = mcm.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            lblMcm.Text = "----";
            textBox1.Focus();
        }
    }
}
