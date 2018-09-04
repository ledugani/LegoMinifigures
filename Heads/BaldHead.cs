using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Heads
{
    class BaldHead
    {
        public bool HasHair { get { return false; } }
        public int SmoothnessLevel { get; set; }

        public void Talk()
        {
            Console.WriteLine("Hi, I'm Bob!");
        }

        public void Eat()
        {
            Console.WriteLine("*Eats a sandwich*");
        }
    }
}
