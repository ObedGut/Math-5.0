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
    public partial class Herencia : Form
    {
        public Herencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double herencia, herencia_de_Juan, herencia_de_Luis, herencia_de_Rosa, monto;
            double servicios_de_abogado, parteLuis, parteJuan, parteRosa;
            try
            {
               herencia = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en el valor de la herencia", "Error");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
            herencia_de_Juan = herencia / 3;
            herencia_de_Luis = (4 * herencia) / 9;
            herencia_de_Rosa = (2 * herencia) / 9;
            monto = (herencia_de_Juan + herencia_de_Luis + herencia_de_Rosa)/3;
            servicios_de_abogado = 0;

            if (herencia_de_Juan >= monto)
            {
                parteJuan = herencia_de_Juan * 0.05;
            }
            else 
            { 
                parteJuan = herencia_de_Juan * 0.03;
            }

            if(herencia_de_Luis >= monto)
            {
                parteLuis = herencia_de_Luis * 0.05;
            }
            else
            {
                parteLuis = herencia_de_Luis * 0.03;
            }

            if (herencia_de_Rosa >= monto)
            {
                parteRosa = herencia_de_Rosa * 0.05;
            }
            else
            {
                parteRosa = herencia_de_Rosa * 0.03;
            }

            servicios_de_abogado = parteJuan + parteLuis + parteRosa;


            lblJ.Text = "$" + Math.Round(herencia_de_Juan);
            lblL.Text = "$" + Math.Round(herencia_de_Luis);
            lblR.Text = "$" + Math.Round(herencia_de_Rosa);
            //Console.WriteLine("Valor de monto: " + monto);
            //Console.WriteLine("Valor de porcentaje: " + porcentaje);
            lblA.Text = "$" + Math.Round(servicios_de_abogado);
        }

        private void Herencia_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lblA.Text = "$0";
            lblJ.Text = "$0";
            lblL.Text = "$0";
            lblR.Text = "$0";
            textBox1.Focus();
        }
    }
}
