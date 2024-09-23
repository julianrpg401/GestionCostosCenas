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

        public override double CalculateDecorationCost(int numPeople, bool decoration)
        {
            Decoration = decoration;

            if (Decoration == true)
            {
                int decorationCostPerson = 15;
                CostDecoration = decorationCostPerson * numPeople;

                return CostDecoration;
            }
            else
                return 0;
        }

        public double CalculateCostCake(byte cakeSize)
        {
            double costCake = cakeSize * 50;

            return costCake;
        }
    }
}
