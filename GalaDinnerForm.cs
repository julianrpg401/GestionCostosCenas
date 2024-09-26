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
    public partial class GalaDinnerForm : Form
    {
        private int numPeople;
        private double costFoodPerson;
        private bool decoration;
        private bool healthyOption;
        double averageCostPerson;

        public GalaDinnerForm()
        {
            InitializeComponent();
        }

        private void txtNumPeople_TextChanged(object sender, EventArgs e)
        {
            lblExceptionPeople.Text = "";

            if (!int.TryParse(txtNumPeople.Text, out numPeople))
                lblExceptionPeople.Text = "Campo obligatorio";

            else if (numPeople < 1 || numPeople > 500)
            {
                lblExceptionPeople.Text = "Ingrese un número mayor a 1 e inferior a 500";
                lblExceptionPeople.ForeColor = Color.Red;
            }
        }

        private void txtCostFoodPerson_TextChanged(object sender, EventArgs e)
        {
            lblExceptionCostFoodPerson.Text = "";

            if (!double.TryParse(txtCostFoodPerson.Text, out costFoodPerson))
                lblExceptionCostFoodPerson.Text = "Campo obligatorio";

            else if (costFoodPerson < 10 || costFoodPerson > 500)
            {
                lblExceptionCostFoodPerson.Text = "El costo por persona no puede ser menor a $10 ni mayor a $500";
                lblExceptionCostFoodPerson.ForeColor = Color.Red;
            }
        }

        private void chkDecoration_CheckedChanged(object sender, EventArgs e)
            => decoration = chkDecoration.Checked;

        private void chkHealthyOption_CheckedChanged(object sender, EventArgs e)
            => healthyOption = chkHealthyOption.Checked;

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            Dinner galaDinner = DinnerManagement.CreateDinner(averageCostPerson, numPeople, costFoodPerson, decoration, healthyOption);


        }
    }
}
