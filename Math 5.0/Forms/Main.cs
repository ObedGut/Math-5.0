namespace Math_5._0
{
    public partial class Main : Form
    {
        private Button? currentButton = default!;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Main()
        {
            InitializeComponent();
            random = new Random();
            btnClose.Visible = false;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    panelTitle.BackColor = color;
                    btnClose.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 75);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnCuadra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AngulosA(), sender);
        }

        private void btnAngulos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form1(), sender);
        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Determinante(), sender);
        }

        private void btnCajero_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Cajero(), sender);
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Bisiesto(), sender);
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Ordenamiento(), sender);
        }
        private void btnHerencia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Herencia(), sender);
        }
        private void btnMcm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Mcm(), sender);
        }
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Creditos(),sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Matematicas V5.0";
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            currentButton = null;
            btnClose.Visible = false;
        }
    }
}