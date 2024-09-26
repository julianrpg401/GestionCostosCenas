using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCostosCenas
{
    internal class GalaDinner : Dinner
    {
        private double averageCostPerson;
        private bool healthyOption;

        public double AverageCostPerson { get => averageCostPerson; set => averageCostPerson = value; }
        public bool HealthyOption { get => healthyOption; set => healthyOption = value; }

        public GalaDinner(double averageCostPerson, int numPeople, double costFoodPerson, bool decoration, bool healthyOption) : base(numPeople, costFoodPerson, decoration)
        {
            this.averageCostPerson = averageCostPerson;
            this.healthyOption = healthyOption;
        }

        public override double CalculateDecorationCost()
        {

        }

        public override double CalculateCostCake()
        {

        }

        public override double CalculateTotalCost(double costCake)
        {

        }
    }
}
