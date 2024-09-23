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

        public BirthdayDinner()
        {
            cakeSize = 0;
            cakeText = null;
        }

        public BirthdayDinner(byte cakeSize, string cakeText)
        {
            this.cakeSize = cakeSize;
            this.cakeText = cakeText;
        }
    }
}
