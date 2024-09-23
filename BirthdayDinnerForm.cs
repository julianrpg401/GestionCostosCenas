using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCostosCenas
{
    public partial class BirthdayDinnerForm : Form
    {
        BirthdayDinner birthdayDinner = new BirthdayDinner();
        public BirthdayDinnerForm()
        {
            InitializeComponent();
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            BirthdayDinner birthdayDinner = new BirthdayDinner();
        }

        private void txtNumPeople_TextChanged(object sender, EventArgs e)
        {
            lblExceptionPeople.Text = "";

            int numPeople;

            if (!int.TryParse(txtNumPeople.Text, out numPeople))
                lblExceptionPeople.Text = "Campo obligatorio";

            else if (numPeople < 1 || numPeople > 500)
            {
                lblExceptionPeople.Text = "Ingrese un número mayor a 1 e inferior a 500";
                lblExceptionPeople.ForeColor = Color.Red;
            }
        }
    }
}
