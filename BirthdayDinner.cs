using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCostosCenas
{
    internal class BirthdayDinner : Dinner
    {
        private string cakeSize;
        private string cakeText;

        public string CakeSize { get => cakeSize; set => cakeSize = value; }
        public string CakeText { get => cakeText; set => cakeText = value; }
    }
}
