namespace GestionCostosCenas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnGalaDinner_Click(object sender, EventArgs e)
        {
            GalaDinnerForm galaDinner = new GalaDinnerForm();
            galaDinner.Show();
        }

        private void btnBirthdayDinner_Click(object sender, EventArgs e)
        {
            BirthdayDinnerForm birthdayDinner = new BirthdayDinnerForm();
            birthdayDinner.Show();
        }
    }
}
