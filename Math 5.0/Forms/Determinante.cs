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
    public partial class Determinante : Form
    {
        public Determinante()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double sol1, sol2, sol3, dx, dy, d, sx, sy;
            //matriz donde guardaremos los datos para resolver el sistema de ecuaciones
            double[,] m = new double[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        try
                        {
                            m[i, j] = Convert.ToInt32(textBox1.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Debe ingresar un valor numerico en x", "Error");
                            textBox1.Text = "";
                            textBox1.Focus();
                            return;
                        }
                    }
                    if (i == 0 && j == 1)
                    {
                        try
                        {
                            m[i, j] = Convert.ToInt32(textBox2.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Debe ingresar un valor numerico en y", "Error");
                            textBox2.Text = "";
                            textBox2.Focus();
                            return;
                        }
                    }
                    if (i == 0 && j == 2)
                    {
                        try
                        {
                            m[i, j] = Convert.ToInt32(textBox3.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Debe ingresar un valor numerico en z", "Error");
                            textBox3.Text = "";
                            textBox3.Focus();
                            return;
                        }
                    }
                    if (i == 1 && j == 0)
                    {
                        try
                        {

                            m[i, j] = Convert.ToInt32(textBox4.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Debe ingresar un valor numerico en x", "Error");
                            textBox4.Text = "";
                            textBox4.Focus();
                            return;
                        }
                    }
                    if (i == 1 && j == 1)
                    {
                        try
                        {
                            m[i, j] = Convert.ToInt32(textBox5.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Debe ingresar un valor numerico en y", "Error");
                            textBox5.Text = "";
                            textBox5.Focus();
                            return;
                        }
                    }
                    if (i == 1 && j == 2)
                    {
                        try
                        {
                            m[i, j] = Convert.ToInt32(textBox6.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Debe ingresar un valor numerico en z", "Error");
                            textBox6.Text = "";
                            textBox6.Focus();
                            return;
                        }
                    }
                }

            }

            sol1 = m[0, 0] / m[1, 0];
            sol2 = m[0, 1] / m[1, 1];
            sol3 = m[0, 2] / m[1, 2];
            if (sol1 != sol2)
            {
                d = (m[0, 0] * m[1, 1]) - (m[1, 0] * m[0, 1]);
                dx = (m[0, 2] * m[1, 1]) - (m[1, 2] * m[0, 1]);
                dy = (m[0, 0] * m[1, 2]) - (m[1, 0] * m[0, 2]);
                sx = dx / d;
                sy = dy / d;

                lblX.Text = Math.Round(sx,2).ToString();
                lblY.Text = Math.Round(sy,2).ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            lblX.Text = "-";
            lblY.Text = "-";
            textBox1.Focus();
        }
    }
}

