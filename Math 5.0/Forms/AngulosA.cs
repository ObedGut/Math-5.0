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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, h;

            try
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en cateto mayor", "Error");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
            try
            {
                b = Convert.ToDouble(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en cateto menor", "Error");
                textBox2.Text = "";
                textBox2.Focus();
                return;
            }

            h = Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 2), 0.5); //Calculamos la hipotenusa del triangulo 


            double catma, catme, hipot;


            //Comparamos ambos datos de entrada para determinar el lado mayor y el menor 
            if (a > b)
            {
                catma = a;
                catme = b;
            }
            else
            {
                catma = b;
                catme = a;
            }

            double angma, angme;
            //Usamos la funcion Arcocoseno para determinar el angulo adyacente a cada lado(mayor y menor)
            angma = (180 / Math.PI) * Math.Acos(catma / h);
            angme = (180 / Math.PI) * Math.Acos(catme / h);
            hipot = Math.Sqrt(a*a + b*b);

            lblMayor.Text = Math.Round(catma,2).ToString() + "m";
            lblAnguloM.Text = Math.Round(angma,2).ToString() + "°";
            lblMenor.Text = Math.Round(catme,2).ToString() + "m";
            lblAnguloAm.Text = Math.Round(angme,2).ToString() + "°";
            lblHipotenusa.Text = Math.Round(hipot, 2).ToString() + "m";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            lblMayor.Text = "0";
            lblAnguloAm.Text = "0";
            lblMenor.Text = "0";
            lblAnguloM.Text = "0";
            textBox1.Focus();
        }
    }
}
