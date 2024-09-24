using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCostosCenas
{
    internal class BirthdayDinner : Dinner
    {
        private byte cakeSize;
        private string? cakeText;

        public byte CakeSize { get => cakeSize; set => cakeSize = value; }
        public string? CakeText { get => cakeText; set => cakeText = value; }

        public BirthdayDinner(byte cakeSize, string cakeText, int numPeople, double costFoodPerson, bool decoration) : base(numPeople, costFoodPerson, decoration)
        {
            this.cakeSize = cakeSize;
            this.cakeText = cakeText;
        }

        public override double CalculateDecorationCost()
        {
            if (Decoration == true)
            {
                int decorationCostPerson = 15;
                CostDecoration = decorationCostPerson * NumPeople;

                return CostDecoration;
            }
            else
                return 0;
        }

        public override double CalculateCostCake()
        {
            double costCake = CakeSize * 50;

            return costCake;
        }

        public override double CalculateTotalCost(double costCake)
        {
            double totalCost;

            totalCost = (CostFoodPerson * NumPeople) + costCake;

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
    }
}
