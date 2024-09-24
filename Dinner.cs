using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCostosCenas
{
    internal abstract class Dinner
    {
        private int numPeople;
        private double costDecoration;
        private double extraBonus;
        private double costFoodPerson;
        private bool decoration;

        public int NumPeople { get => numPeople; set => numPeople = value; }
        public double CostDecoration { get => costDecoration; set => costDecoration = value; }
        public double ExtraBonus { get => extraBonus; set => extraBonus = value; }
        public double CostFoodPerson { get => costFoodPerson; set => costFoodPerson = value; }
        public bool Decoration { get => decoration; set => decoration = value; }

        public Dinner(int numPeople, double costFoodPerson, bool decoration)
        {
            this.numPeople = numPeople;
            costDecoration = 0;
            extraBonus = 0;
            this.costFoodPerson = costFoodPerson;
            this.decoration = decoration;
        }

        public abstract double CalculateDecorationCost();
        public abstract double CalculateCostCake();
        public abstract double CalculateTotalCost(double costCake);
    }
}
