using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCostosCenas
{
    internal class DinnerManagement
    {
        public static Dinner CreateDinner(byte cakeSize, string cakeText, int numPeople, double costFoodPerson, bool decoration)
        {
            try
            {
                return new BirthdayDinner(cakeSize, cakeText, numPeople, costFoodPerson, decoration);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return null;
        }

        public static Dinner CreateDinner(int numPeople, double costFoodPerson, bool decoration, bool healthyOption)
        {
            try
            {
                return new GalaDinner(numPeople, costFoodPerson, decoration, healthyOption);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return null;
        }
    }
}
