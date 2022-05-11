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
    public partial class Bisiesto : Form
    {
        public Bisiesto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblDias.Text == "")
            {
                MessageBox.Show("Debe ingresar un en a", "Error");
                lblDias.Focus();
                return;
            }
            int dia;
            try
            {
                dia = Convert.ToInt32(lblDias.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico de dias", "Error");
                lblDias.Text = "";
                lblDias.Focus();
                return;
            }
                if (dia >= 1 && dia <= 31)
                {
                    lblMes.Text = "ENERO";
                }
                if (dia >= 31 && dia <= 60)
                {
                    lblMes.Text = "FEBRERO";
                }
                if (dia >= 60 && dia <= 91)
                {
                    lblMes.Text = "MARZO";
                }
                if (dia >= 91 && dia <= 121)
                {
                    lblMes.Text = "ABRIL";
                }
                if (dia >= 121 && dia <= 152)
                {
                    lblMes.Text = "MAYO";
                }
                if (dia >= 152 && dia <= 182)
                {
                    lblMes.Text = "JUNIO";
                }
                if (dia >= 182 && dia <= 213)
                {
                    lblMes.Text = "JULIO";
                }
                if (dia >= 213 && dia <= 244)
                {
                    lblMes.Text = "AGOSTO";
                }
                if (dia >= 244 && dia <= 274)
                {
                    lblMes.Text = "SEPTIEMBRE";
                }
                if (dia >= 274 && dia <= 305)
                {
                    lblMes.Text = "OCTUBRE";
                }
                if (dia >= 305 && dia <= 335)
                {
                    lblMes.Text = "NOVIEMBRE";
                }
                if (dia >= 335 && dia <= 366)
                {
                    lblMes.Text = "DICIEMBRE";
                }
            if (dia < 1 || dia > 366)
            {
                {
                    MessageBox.Show("Ingrese un numero Valido!!!");
                    lblDias.Focus();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblMes.Text = "----------";
            lblDias.Text = "";
            lblDias.Focus();
        }
    }
}
