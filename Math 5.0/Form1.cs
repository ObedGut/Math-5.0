namespace Math_5._0
{
    public partial class Form1 : Form
    {
        private Button currentButton = default!;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
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
            ActivateButton(sender);
        }

        private void btnAngulos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCajero_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void btnHerencia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void btnMcm_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCreditos(),sender);
        }

        
    }
}