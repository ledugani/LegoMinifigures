using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Heads
{
    class TomHead : HeadBase
    {
        public override bool HasHair { get { return true; } }
        public string HairColor { get { return "brown"; } }
        public string Texture { get; set; }

        public override void Talk()
        {
            Console.WriteLine("That's what she said.");
        }

        public override void Eat()
        {
            Console.WriteLine("*Eats some nachos*");
        }
    }

    abstract class HeadBase
    {
        public abstract bool HasHair { get; }

        public virtual void Talk()
        {
            Console.WriteLine("That's not what she said.");
        }

        public abstract void Eat();
    }
}
