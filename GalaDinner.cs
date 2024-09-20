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
    }
}
