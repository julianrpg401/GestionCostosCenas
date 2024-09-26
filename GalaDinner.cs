using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCostosCenas
{
    internal class GalaDinner : Dinner
    {
        private bool healthyOption;
        public bool HealthyOption { get => healthyOption; set => healthyOption = value; }

        public GalaDinner(int numPeople, double costFoodPerson, bool decoration, bool healthyOption) : base(numPeople, costFoodPerson, decoration)
        {
            this.healthyOption = healthyOption;
        }

        public override double CalculateDecorationCost()
        {
            if (Decoration == true)
            {
                int decorationCostPerson = 15;
                CostDecoration = decorationCostPerson * NumPeople;

                if (NumPeople > 100)
                {
                    double additionalCostDecoration = 500;
                    CostDecoration += additionalCostDecoration;

                    return CostDecoration;
                }
                else
                    return CostDecoration;
            }
            else
                return 0;
        }

        public double SetHealthyOptional()
        {
            double costHealthyOption;

            if (HealthyOption == true)
            {
                costHealthyOption = NumPeople * 5;

                return costHealthyOption;
            }

            return 0;
        }

        public override double CalculateTotalCost(double costHealthyOption)
        {
            try
            {
                double totalCost;

                totalCost = (CostFoodPerson * NumPeople) + costHealthyOption;

                if (Decoration == true)
                {
                    totalCost += CostDecoration;
                }

                if (totalCost > 0)
                {
                    if (totalCost > 1000)
                    {
                        ExtraBonus = totalCost * 0.2;
                        totalCost -= ExtraBonus;

                        return totalCost;
                    }
                    else
                        return totalCost;
                }
                else
                    return totalCost;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al calcular el costo total de la cena de gala", ex);
            }
        }
    }
}
