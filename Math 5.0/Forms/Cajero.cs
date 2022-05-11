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
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }

        private void Cajero_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			double CAN;
			int C100, C50, C20, C10, C5, C1;
			C100 = 0;
			C50 = 0;
			C20 = 0;
			C10 = 0;
			C5 = 0;
			C1 = 0;
			try
			{
				CAN = Convert.ToDouble(lblMonto.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("Debe ingresar un valor numerico en el monto", "Error");
				lblMonto.Text = "";
				lblMonto.Focus();
				return;
			}

			if ((CAN >= 100))
			{
				C100 = ((int)CAN / 100);
				CAN = CAN - (C100 * 100);
			}
			if ((CAN >= 50))
			{
				C50 = ((int)CAN / 50);
				CAN = CAN - (C50 * 50);
			}
			if ((CAN >= 20))
			{
				C20 = ((int)CAN / 20);
				CAN = CAN - (C20 * 20);
			}
			if ((CAN >= 10))
			{
				C10 = ((int)CAN / 10);
				CAN = CAN - (C10 * 10);
			}
			if ((CAN >= 5))
			{
				C5 = ((int)CAN / 5);
				CAN = CAN - (C5 * 5);
			}
			if ((CAN >= 1))
			{
				C1 = ((int)CAN / 1);
				CAN = CAN - (C1 * 1);
			}
			billetesCien.Text = C100.ToString();
			billetesCincuenta.Text =  C50.ToString();
			billetesVeinte.Text =  C20.ToString();
			billetesDiez.Text =  C10.ToString();
			billetesCinco.Text =  C5.ToString();
			billetesUno.Text = C1.ToString();
		}

        private void button2_Click(object sender, EventArgs e)
        {
			billetesCien.Text = "0";
			billetesCincuenta.Text = "0";
			billetesVeinte.Text = "0";
			billetesDiez.Text = "0";
			billetesCinco.Text = "0";
			billetesUno.Text = "0";
			lblMonto.Text = "0";
			lblMonto.Focus();
        }
    }
}
