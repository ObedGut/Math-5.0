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
    public partial class AngulosA : Form
    {
        public AngulosA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cal_Click(object sender, EventArgs e)
        {
            if (valA.Text == "")
            {
                MessageBox.Show("Debe ingresar un en a", "Error");
                valA.Focus();
                return;
            }
            double a;
            try
            {
                a = Convert.ToDouble(valA.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en a", "Error");
                valA.Text = "";
                valA.Focus();
                return;
            }
            if (valB.Text == "")
            {
                MessageBox.Show("Debe ingresar un en b", "Error");
                valB.Focus();
                return;
            }
            double b;
            try
            {
                b = Convert.ToDouble(valB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en b", "Error");
                valB.Text = "";
                valB.Focus();
                return;
            }
            if (valC.Text == "")
            {
                MessageBox.Show("Debe ingresar un en c", "Error");
                valC.Focus();
                return;
            }
            double c;
            try
            {
                c = Convert.ToDouble(valC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en c", "Error");
                valC.Text = "";
                valC.Focus();
                return;
            }

            //Procedimiento
            double x1, x2;
            Cuadraatica(a, b, c, out x1, out x2);

            
        }

        private void Cuadraatica(double a, double b, double c, out double x1, out double x2)
        {
            double ex = b * b - 4 * a * c;

            if(ex < 0)
            {
               ex = ex * -1;

                x1 = (-b + Math.Sqrt(ex)) / (2 * a);
                x2 = (-b - Math.Sqrt(ex)) / (2 * a);
                lblImaginario.Text = "Numeros Imaginarios!!!";
                //Salida
                valxu.Text = Math.Round(x1, 2).ToString() + "i";
                valxd.Text = Math.Round(x2, 2).ToString() + "i";
            }
            else
            {

                x1 = (-b + Math.Sqrt(ex)) / (2 * a);
                x2 = (-b - Math.Sqrt(ex)) / (2 * a);

                lblImaginario.Text = "";

                //Salida
                valxu.Text = Math.Round(x1, 2).ToString();
                valxd.Text = Math.Round(x2, 2).ToString();
            }

        }


        private void reset_Click_1(object sender, EventArgs e)
        {
            valA.Text = "";
            valB.Text = "";
            valC.Text = "";
            valxu.Text = "";
            valxd.Text = "";
            lblImaginario.Text = "";
            valA.Focus();
        }
    }
}
    
