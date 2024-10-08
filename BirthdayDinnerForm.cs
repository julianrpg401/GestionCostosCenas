﻿using System;
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
        private int numPeople;
        private double costFoodPerson;
        private byte cakeSize;
        private string cakeText;
        private bool decoration;

        public BirthdayDinnerForm()
        {
            InitializeComponent();
        }

        private void txtNumPeople_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el número de personas: {ex.Message}");
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

        private void cmbCakeSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            cakeSize = (byte)cmbCakeSize.SelectedIndex;
            cakeSize += 1;
        }

        private void txtCakeText_TextChanged(object sender, EventArgs e)
        {
            lblExceptionCakeText.Text = "";

            cakeText = txtCakeText.Text;
            cakeText.ToArray();

            if (cakeText.Length > 30)
            {
                lblExceptionCakeText.Text = "Ha excedido el número de caracteres (máximo 30)";
                lblExceptionCakeText.ForeColor = Color.Red;
            }
        }

        private void chkDecoration_CheckedChanged(object sender, EventArgs e)
            => decoration = chkDecoration.Checked;

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            try
            {
                BirthdayDinner birthdayDinner = (BirthdayDinner)DinnerManagement.CreateDinner(cakeSize, cakeText, numPeople, costFoodPerson, decoration);

                double costDecoration = birthdayDinner.CalculateDecorationCost();
                double costCake = birthdayDinner.CalculateCostCake();
                double totalCost = birthdayDinner.CalculateTotalCost(costCake);

                if (totalCost > 0)
                {
                    if (totalCost < 100)
                        MessageBox.Show("La cena debe tener un costo mínimo de $100");
                    else
                        MessageBox.Show($"El costo total de la cena es de: ${totalCost}");
                }
                else
                    MessageBox.Show($"Error al calcular el costo total, el valor no puede ser negativo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el cálculo del costo total: {ex.Message}");
            }
        }
    }
}
