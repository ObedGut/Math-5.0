using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_5._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading.Width += 3;

            if (loading.Width >= 599)
            {
                timer1.Stop();
                Main mn = new Main();
                mn.Show();
                this.Hide();
            }
        }
    }
}
